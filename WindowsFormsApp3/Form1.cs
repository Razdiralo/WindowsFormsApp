using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        #region Константы

        private const int PROGRESS_TIMER_INTERVAL = 50;
        private const int PROGRESS_STEP = 1;
        private const int DELAY_INTERVAL = 1000;
        private const float SHAPE_SIZE_FACTOR = 20f;
        private const float MIN_SCALE = 0.3f;
        private const float SCALE_STEP = 1.2f;
        private const int MAX_MATRIX_SIZE = 20;
        private const int MATRIX_CELL_WIDTH = 45;
        private const float DEFAULT_FONT_SIZE = 12f;

        #endregion

        #region Поля

        private readonly Dictionary<string, LSItem> _activeLS = new();
        private readonly List<CommandItem> _allCommands = new();
        private readonly List<Shape> _shapes = new();
        private readonly Random _random = new();

        private System.Windows.Forms.Timer _clockTimer;
        private Shape? _selectedShape;
        private LSItem? _selectedLS;

        private ProgressDirection _progressDirection = ProgressDirection.Forward;
        private enum ProgressDirection { Forward, Reverse }
        private enum ShapeType { Square, Circle, Pentagon, Text }

        private RectangleF _drawingBounds;
        private Color _currentColor = Color.Blue;
        private PointF _canvasOffset = PointF.Empty;
        private PointF _dragStartPoint;
        private PointF _shapeStartPosition;

        private bool _wasProgressStopped;
        private bool _isDragging;

        private string? _currentXmlFile;
        private float _canvasScale = 1f;
        private int _savedProgressValue;

        #endregion

        #region Конструктор

        public Form1()
        {
            InitializeComponent();
            InitializeApp();
            InitializeDefaultLS();
        }

        private void InitializeApp()
        {
            timer1.Interval = PROGRESS_TIMER_INTERVAL;
            _clockTimer = new System.Windows.Forms.Timer { Interval = DELAY_INTERVAL };
            _clockTimer.Tick += (_, _) => dateTimePicker1.Value = DateTime.Now;
            _clockTimer.Start();

            SetupDrawingPanel();
            SetupMatrix();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            typeof(Panel).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(drawingPanel, true);
        }

        private void InitializeDefaultLS()
        {
            tabControlLS.SelectedTab = tabPageLS1;

            TabControlLS_SelectedIndexChanged(tabControlLS, EventArgs.Empty);
        }


        #endregion

        #region Инициализация компонентов

        private void SetupMatrix()
        {
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.CellValidating += DataGridViewMatrix_CellValidating;
            txtRows.Text = txtCols.Text = "5";
        }

        private void SetupDrawingPanel()
        {
            drawingPanel.Paint += DrawingPanel_Paint;
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
            drawingPanel.MouseUp += DrawingPanel_MouseUp;
            drawingPanel.Resize += (_, _) => { UpdateDrawingBounds(); drawingPanel.Invalidate(); };
            UpdateDrawingBounds();
        }

        #endregion

        #region Задание 1: ProgressBar

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_progressDirection == ProgressDirection.Forward)
            {
                progressBar1.Value += PROGRESS_STEP;

                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    progressBar1.Value = progressBar1.Maximum;
                    timer1.Stop();
                    _progressDirection = ProgressDirection.Reverse;
                    _wasProgressStopped = false;

                    var messageTimer = new System.Windows.Forms.Timer { Interval = DELAY_INTERVAL / 2 };
                    messageTimer.Tick += (s, _) =>
                    {
                        messageTimer.Stop();
                        messageTimer.Dispose();
                        MessageBox.Show("Прогрессбар заполнен", "Сообщение");
                    };
                    messageTimer.Start();
                }
            }
            else
            {
                progressBar1.Value -= PROGRESS_STEP;

                if (progressBar1.Value <= 0)
                {
                    progressBar1.Value = 0;
                    timer1.Stop();
                    _progressDirection = ProgressDirection.Forward;
                    _wasProgressStopped = false;

                    MessageBox.Show("Прогрессбар пуст", "Сообщение");
                }
            }
        }

        private void BtnStartProgress_Click(object sender, EventArgs e)
        {
            if (_wasProgressStopped)
            {
                progressBar1.Value = _savedProgressValue;
                _wasProgressStopped = false;
            }

            timer1.Start();
        }

        private void BtnDelay_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                MessageBox.Show("Прогрессбар не запущен", "Информация");
                return;
            }

            timer1.Stop();

            var delayTimer = new System.Windows.Forms.Timer { Interval = DELAY_INTERVAL };
            delayTimer.Tick += (s, _) =>
            {
                delayTimer.Stop();
                delayTimer.Dispose();
                if (!_wasProgressStopped)
                {
                    timer1.Start();
                }
            };
            delayTimer.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _savedProgressValue = progressBar1.Value;
            _wasProgressStopped = true;
            timer1.Stop();
        }

        #endregion

        #region Задание 2: Матрица

        private void BtnDrawTable_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRows.Text, out int rows) || !int.TryParse(txtCols.Text, out int cols) ||
                rows <= 0 || cols <= 0)
            {
                MessageBox.Show("Введите корректные числа для строк и столбцов", "Ошибка");
                return;
            }

            if (rows > MAX_MATRIX_SIZE || cols > MAX_MATRIX_SIZE)
            {
                MessageBox.Show($"Размер матрицы не должен превышать {MAX_MATRIX_SIZE}x{MAX_MATRIX_SIZE}", "Ошибка");
                return;
            }

            dataGridViewMatrix.Columns.Clear();
            dataGridViewMatrix.Rows.Clear();

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns.Add($"col{i}", string.Empty);
                dataGridViewMatrix.Columns[i].Width = MATRIX_CELL_WIDTH;
                dataGridViewMatrix.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridViewMatrix.Rows.Add(rows);
            CalculateMatrixSums();
        }

        private void BtnFillRandom_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatrix.RowCount == 0 || dataGridViewMatrix.ColumnCount == 0)
            {
                MessageBox.Show("Сначала нарисуйте таблицу", "Ошибка");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewMatrix.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = _random.Next(-10, 11);

            CalculateMatrixSums();
        }

        private void CalculateMatrixSums()
        {
            if (dataGridViewMatrix.RowCount == 0 || dataGridViewMatrix.ColumnCount == 0)
            {
                lblSumCol.Text = "Сумма элементов первого столбца: 0";
                lblSumRow.Text = "Сумма элементов первой строки: 0";
                lblSumDiagonal.Text = "Сумма элементов главной диагонали: 0";
                return;
            }

            lblSumCol.Text = $"Сумма элементов первого столбца: {GetColumnSum(0)}";
            lblSumRow.Text = $"Сумма элементов первой строки: {GetRowSum(0)}";
            lblSumDiagonal.Text = $"Сумма элементов главной диагонали: {GetDiagonalSum()}";
        }

        private int GetColumnSum(int colIndex) =>
            dataGridViewMatrix.Rows.Cast<DataGridViewRow>().Sum(row => GetCellValue(row.Cells[colIndex]));

        private int GetRowSum(int rowIndex) =>
            dataGridViewMatrix.Rows[rowIndex].Cells.Cast<DataGridViewCell>().Sum(GetCellValue);

        private int GetDiagonalSum() =>
            Enumerable.Range(0, Math.Min(dataGridViewMatrix.RowCount, dataGridViewMatrix.ColumnCount))
                .Sum(i => GetCellValue(dataGridViewMatrix.Rows[i].Cells[i]));

        private static int GetCellValue(DataGridViewCell cell) =>
            cell.Value != null && int.TryParse(cell.Value.ToString(), out int val) ? val : 0;

        private void BtnSaveMatrix_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatrix.RowCount == 0 || dataGridViewMatrix.ColumnCount == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Информация");
                return;
            }

            using var saveDialog = new SaveFileDialog { Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*" };
            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var writer = new StreamWriter(saveDialog.FileName);
                writer.WriteLine($"{dataGridViewMatrix.RowCount},{dataGridViewMatrix.ColumnCount}");

                foreach (DataGridViewRow row in dataGridViewMatrix.Rows)
                {
                    var values = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "0");
                    writer.WriteLine(string.Join(",", values));
                }

                MessageBox.Show("Матрица сохранена успешно", "Сохранение");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private void BtnLoadMatrix_Click(object sender, EventArgs e)
        {
            using var openDialog = new OpenFileDialog { Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*", Title = "Загрузить матрицу" };
            if (openDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var lines = File.ReadAllLines(openDialog.FileName);
                if (lines.Length == 0) return;

                var dimensions = lines[0].Split(',');
                if (dimensions.Length != 2 || !int.TryParse(dimensions[0], out int rows) || !int.TryParse(dimensions[1], out int cols))
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка");
                    return;
                }

                txtRows.Text = rows.ToString();
                txtCols.Text = cols.ToString();

                BtnDrawTable_Click(sender, e);

                for (int i = 1; i < lines.Length && i - 1 < rows; i++)
                {
                    var values = lines[i].Split(',');
                    for (int j = 0; j < values.Length && j < cols; j++)
                    {
                        if (int.TryParse(values[j], out int val))
                            dataGridViewMatrix.Rows[i - 1].Cells[j].Value = val;
                    }
                }

                CalculateMatrixSums();
                MessageBox.Show("Матрица загружена успешно", "Загрузка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка");
            }
        }

        private void BtnClearMatrix_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix.Columns.Clear();
            CalculateMatrixSums();
        }

        private void BtnRecalc_Click(object sender, EventArgs e) => CalculateMatrixSums();

        private void DataGridViewMatrix_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!string.IsNullOrEmpty(e.FormattedValue?.ToString()) &&
                !int.TryParse(e.FormattedValue.ToString(), out _))
            {
                MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        #endregion

        #region Задание 3: Фигуры

        private void UpdateDrawingBounds() => _drawingBounds = new RectangleF(0, 0, drawingPanel.Width, drawingPanel.Height);

        private void AddShape(ShapeType type, string text = "")
        {
            _shapes.Add(new Shape
            {
                Type = type.ToString(),
                Position = new PointF(_drawingBounds.X + _drawingBounds.Width / 2, _drawingBounds.Y + _drawingBounds.Height / 2),
                Color = _currentColor,
                Size = 1f,
                Text = text
            });
            drawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TranslateTransform(_canvasOffset.X, _canvasOffset.Y);
            g.ScaleTransform(_canvasScale, _canvasScale);
            g.Clear(Color.White);

            foreach (var shape in _shapes)
            {
                if (shape.Type == ShapeType.Text.ToString())
                    DrawTextShape(g, shape);
                else
                    DrawGeometricShape(g, shape);
            }
        }

        private void DrawTextShape(Graphics g, Shape shape)
        {
            using var font = new Font("Arial", shape.Size * DEFAULT_FONT_SIZE);
            using var brush = new SolidBrush(shape.Color);

            g.DrawString(shape.Text, font, brush, shape.Position);

            if (shape == _selectedShape)
            {
                var textSize = g.MeasureString(shape.Text, font);
                var rect = new RectangleF(
                    shape.Position.X - 2,
                    shape.Position.Y - 2,
                    textSize.Width + 4,
                    textSize.Height + 4);

                using var highlightPen = new Pen(Color.Red, 2);
                g.DrawRectangle(highlightPen, rect.X, rect.Y, rect.Width, rect.Height);
            }
        }
        private void DrawGeometricShape(Graphics g, Shape shape)
        {
            var size = shape.Size * SHAPE_SIZE_FACTOR;
            var shapeRect = new RectangleF(shape.Position.X - size / 2, shape.Position.Y - size / 2, size, size);

            using var brush = new SolidBrush(shape.Color);
            using var pen = new Pen(Color.Black, 1);
            using var highlightPen = new Pen(Color.Red, 2);

            switch (shape.Type)
            {
                case "Square":
                    g.FillRectangle(brush, shapeRect);
                    g.DrawRectangle(pen, shapeRect.X, shapeRect.Y, shapeRect.Width, shapeRect.Height);
                    if (shape == _selectedShape)
                        g.DrawRectangle(highlightPen, shapeRect.X, shapeRect.Y, shapeRect.Width, shapeRect.Height);
                    break;

                case "Circle":
                    g.FillEllipse(brush, shapeRect);
                    g.DrawEllipse(pen, shapeRect);
                    if (shape == _selectedShape)
                        g.DrawEllipse(highlightPen, shapeRect);
                    break;

                case "Pentagon":
                    var points = GetPentagonPoints(shape.Position, size);
                    g.FillPolygon(brush, points);
                    g.DrawPolygon(pen, points);
                    if (shape == _selectedShape)
                        g.DrawPolygon(highlightPen, points);
                    break;
            }
        }

        private static PointF[] GetPentagonPoints(PointF center, float size)
        {
            var points = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                var angle = 2 * Math.PI * i / 5 - Math.PI / 2;
                points[i] = new PointF(center.X + size * (float)Math.Cos(angle), center.Y + size * (float)Math.Sin(angle));
            }
            return points;
        }

        private Shape? GetShapeAtPoint(PointF screenPoint)
        {
            var canvasPoint = new PointF((screenPoint.X - _canvasOffset.X) / _canvasScale, (screenPoint.Y - _canvasOffset.Y) / _canvasScale);
            return _shapes.LastOrDefault(shape => IsPointInShape(canvasPoint, shape));
        }

        private bool IsPointInShape(PointF point, Shape shape)
        {
            if (shape.Type == ShapeType.Text.ToString())
            {
                using var g = drawingPanel.CreateGraphics();
                using var font = new Font("Arial", shape.Size * DEFAULT_FONT_SIZE);
                var textSize = g.MeasureString(shape.Text, font);
                var textBounds = new RectangleF(shape.Position.X - 2, shape.Position.Y - 2, textSize.Width + 4, textSize.Height + 4);
                return textBounds.Contains(point);
            }

            var size = shape.Size * SHAPE_SIZE_FACTOR;
            var halfSize = size / 2;
            var shapeBounds = new RectangleF(shape.Position.X - halfSize, shape.Position.Y - halfSize, size, size);

            if (!shapeBounds.Contains(point)) return false;

            if (shape.Type == "Circle")
            {
                var distance = (float)Math.Sqrt(Math.Pow(point.X - shape.Position.X, 2) + Math.Pow(point.Y - shape.Position.Y, 2));
                return distance <= halfSize;
            }

            return true;
        }

        private PointF ClampPosition(PointF position, float size)
        {
            var halfSize = size / 2;
            return new PointF(
                Math.Clamp(position.X, _drawingBounds.X + halfSize, _drawingBounds.X + _drawingBounds.Width - halfSize),
                Math.Clamp(position.Y, _drawingBounds.Y + halfSize, _drawingBounds.Y + _drawingBounds.Height - halfSize));
        }

        private bool IsPositionWithinBounds(PointF position, float size)
        {
            var halfSize = size / 2;
            return position.X - halfSize >= _drawingBounds.X &&
                   position.X + halfSize <= _drawingBounds.X + _drawingBounds.Width &&
                   position.Y - halfSize >= _drawingBounds.Y &&
                   position.Y + halfSize <= _drawingBounds.Y + _drawingBounds.Height;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var mousePoint = new PointF(e.X, e.Y);
            _selectedShape = GetShapeAtPoint(mousePoint);

            if (_selectedShape != null)
            {
                _isDragging = true;
                _dragStartPoint = mousePoint;
                _shapeStartPosition = _selectedShape.Position;
                pColorPreview.BackColor = _selectedShape.Color;
            }

            drawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging || _selectedShape == null || e.Button != MouseButtons.Left) return;

            var deltaX = (e.X - _dragStartPoint.X) / _canvasScale;
            var deltaY = (e.Y - _dragStartPoint.Y) / _canvasScale;
            var size = _selectedShape.Type == ShapeType.Text.ToString() ? SHAPE_SIZE_FACTOR : _selectedShape.Size * SHAPE_SIZE_FACTOR;

            var newPosition = new PointF(_shapeStartPosition.X + deltaX, _shapeStartPosition.Y + deltaY);
            _selectedShape.Position = IsPositionWithinBounds(newPosition, size) ? newPosition : ClampPosition(newPosition, size);

            drawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) _isDragging = false;
        }

        private void BtnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;

            if (_selectedShape != null)
            {
                _selectedShape.Color = colorDialog1.Color;
                drawingPanel.Invalidate();
            }
            else
            {
                _currentColor = colorDialog1.Color;
            }

            pColorPreview.BackColor = colorDialog1.Color;
        }

        private void BtnEditText_Click(object sender, EventArgs e)
        {
            if (_selectedShape?.Type != ShapeType.Text.ToString())
            {
                MessageBox.Show("Выберите текстовую фигуру", "Информация");
                return;
            }

            using var editForm = new Form
            {
                Width = 400,
                Height = 150,
                Text = "Редактировать текст",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var txtInput = new TextBox { Left = 20, Top = 50, Width = 340, Text = _selectedShape.Text };
            var btnOk = new Button { Text = "OK", Left = 260, Width = 100, Top = 80, DialogResult = DialogResult.OK };

            editForm.Controls.Add(new Label { Left = 20, Top = 20, Text = "Введите текст:" });
            editForm.Controls.Add(txtInput);
            editForm.Controls.Add(btnOk);
            editForm.AcceptButton = btnOk;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _selectedShape.Text = txtInput.Text;
                drawingPanel.Invalidate();
            }
        }

        private void ChangeScale(float factor)
        {
            if (_selectedShape != null)
            {
                var newSize = _selectedShape.Size * factor;
                if (_selectedShape.Type != ShapeType.Text.ToString())
                {
                    var size = newSize * SHAPE_SIZE_FACTOR;
                    if (!IsPositionWithinBounds(_selectedShape.Position, size))
                    {
                        MessageBox.Show("Фигура достигла границы поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                _selectedShape.Size = Math.Max(newSize, MIN_SCALE);
            }
            else
            {
                _canvasScale = Math.Clamp(_canvasScale * factor, MIN_SCALE, float.MaxValue);
            }
            drawingPanel.Invalidate();
        }

        private void BtnAllShapes_Click(object sender, EventArgs e)
        {
            _shapes.Clear();
            _shapes.AddRange(new[]
            {
                new Shape { Type = ShapeType.Square.ToString(), Position = new PointF(_drawingBounds.X + 100, _drawingBounds.Y + 70), Color = _currentColor, Size = 1f },
                new Shape { Type = ShapeType.Circle.ToString(), Position = new PointF(_drawingBounds.X + 200, _drawingBounds.Y + 70), Color = _currentColor, Size = 1f },
                new Shape { Type = ShapeType.Pentagon.ToString(), Position = new PointF(_drawingBounds.X + 150, _drawingBounds.Y + 100), Color = _currentColor, Size = 1f },
                new Shape { Type = ShapeType.Text.ToString(), Position = new PointF(_drawingBounds.X + 180, _drawingBounds.Y + 150), Color = _currentColor, Size = 1f, Text = "Привет!" }
            });
            pColorPreview.BackColor = Color.Blue;
            drawingPanel.Invalidate();
        }

        private void BtnResetShapes_Click(object sender, EventArgs e)
        {
            _shapes.Clear();
            _canvasScale = 1f;
            _canvasOffset = PointF.Empty;
            _selectedShape = null;
            _isDragging = false;
            pColorPreview.BackColor = BackColor;
            drawingPanel.Invalidate();
        }

        private void BtnSaveShapes_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0)
            {
                MessageBox.Show("Нет фигур для сохранения", "Информация");
                return;
            }

            using var saveDialog = new SaveFileDialog { Filter = "JSON файлы (*.json)|*.json|XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*" };
            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                if (saveDialog.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    var options = new JsonSerializerOptions { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault };
                    File.WriteAllText(saveDialog.FileName, JsonSerializer.Serialize(_shapes, options));
                    MessageBox.Show("Фигуры сохранены в JSON", "Сохранение");
                }
                else if (saveDialog.FileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    var serializer = new XmlSerializer(typeof(List<Shape>));
                    var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                    var settings = new XmlWriterSettings { Indent = true, Encoding = System.Text.Encoding.UTF8 };

                    using var writer = XmlWriter.Create(saveDialog.FileName, settings);
                    serializer.Serialize(writer, _shapes, ns);
                    MessageBox.Show("Фигуры сохранены в XML", "Сохранение");
                }
                else
                {
                    MessageBox.Show("Выберите файл с расширением .json или .xml", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private void BtnLoadShapes_Click(object sender, EventArgs e)
        {
            using var openDialog = new OpenFileDialog { Filter = "JSON файлы (*.json)|*.json|XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*" };
            if (openDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                _shapes.Clear();

                if (openDialog.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    var json = File.ReadAllText(openDialog.FileName);
                    var loadedShapes = JsonSerializer.Deserialize<List<Shape>>(json);
                    if (loadedShapes != null) _shapes.AddRange(loadedShapes);
                    MessageBox.Show("Фигуры загружены из JSON", "Загрузка");
                }
                else if (openDialog.FileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    var serializer = new XmlSerializer(typeof(List<Shape>));
                    using var reader = new StreamReader(openDialog.FileName);
                    var loadedShapes = (List<Shape>?)serializer.Deserialize(reader);
                    if (loadedShapes != null) _shapes.AddRange(loadedShapes);
                    MessageBox.Show("Фигуры загружены из XML", "Загрузка");
                }
                else
                {
                    MessageBox.Show("Выберите файл с расширением .json или .xml", "Ошибка");
                    return;
                }

                foreach (var shape in _shapes.Where(s => s.Type != ShapeType.Text.ToString()))
                {
                    var size = shape.Size * SHAPE_SIZE_FACTOR;
                    if (!IsPositionWithinBounds(shape.Position, size))
                        shape.Position = ClampPosition(shape.Position, size);
                }

                _selectedShape = null;
                _isDragging = false;
                drawingPanel.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка");
            }
        }

        private void BtnPentagon_Click(object sender, EventArgs e) => AddShape(ShapeType.Pentagon);
        private void BtnCircle_Click(object sender, EventArgs e) => AddShape(ShapeType.Circle);
        private void BtnSquare_Click(object sender, EventArgs e) => AddShape(ShapeType.Square);
        private void BtnText_Click(object sender, EventArgs e) => AddShape(ShapeType.Text, "Новый текст");
        private void BtnIncrease_Click(object sender, EventArgs e) => ChangeScale(SCALE_STEP);
        private void BtnDecrease_Click(object sender, EventArgs e) => ChangeScale(1f / SCALE_STEP);

        #endregion

        #region Задание 4: XML Tree

        private int _collapseLevel = 0;
        private int _expandLevel = 0;

        private void BtnLoadTree_Click(object sender, EventArgs e)
        {
            using var openDialog = new OpenFileDialog { Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*", Title = "Загрузить XML файл для просмотра" };
            if (openDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var doc = new XmlDocument();
                doc.Load(openDialog.FileName);

                treeView1.Nodes.Clear();
                _collapseLevel = 0;
                _expandLevel = 0;

                var rootNode = new TreeNode(doc.DocumentElement?.Name ?? "Корень");
                AddXmlNodeToTree(doc.DocumentElement, rootNode);
                treeView1.Nodes.Add(rootNode);
                rootNode.Expand();

                _currentXmlFile = openDialog.FileName;
                MessageBox.Show($"XML файл загружен: {Path.GetFileName(openDialog.FileName)}", "Загрузка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке XML:\n{ex.Message}", "Ошибка");
            }
        }

        private static void AddXmlNodeToTree(XmlNode? xmlNode, TreeNode treeNode)
        {
            if (xmlNode == null) return;

            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                if (childNode.NodeType != XmlNodeType.Element) continue;

                var nodeText = childNode.Name;

                if (childNode.Attributes?.Count > 0)
                {
                    var attrs = childNode.Attributes.Cast<XmlAttribute>().Select(attr => $"{attr.Name}={attr.Value}");
                    nodeText += $" [{string.Join(" ", attrs)}]";
                }

                if (childNode.ChildNodes.Count == 1 && childNode.FirstChild?.NodeType == XmlNodeType.Text)
                    nodeText += $" = {childNode.FirstChild.InnerText}";

                var childTreeNode = new TreeNode(nodeText);
                treeNode.Nodes.Add(childTreeNode);
                AddXmlNodeToTree(childNode, childTreeNode);
            }
        }

        private void BtnSaveTree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentXmlFile))
            {
                MessageBox.Show("Сначала загрузите XML файл", "Информация");
                return;
            }

            using var saveDialog = new SaveFileDialog
            {
                Filter = "XML файлы (*.xml)|*.xml|JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*",
                FileName = Path.GetFileNameWithoutExtension(_currentXmlFile),
                Title = "Сохранить файл"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                if (saveDialog.FileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    var json = ConvertXmlFileToJson(_currentXmlFile);
                    File.WriteAllText(saveDialog.FileName, json);
                    MessageBox.Show("Файл сохранен в формате JSON", "Сохранение");
                }
                else
                {
                    File.Copy(_currentXmlFile, saveDialog.FileName, true);
                    MessageBox.Show("Файл сохранен в формате XML", "Сохранение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private string ConvertXmlFileToJson(string xmlFilePath)
        {
            var doc = new XmlDocument();
            doc.Load(xmlFilePath);

            var root = new Dictionary<string, object>();
            var elements = new List<object>();

            if (doc.DocumentElement != null)
            {
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    if (node.NodeType == XmlNodeType.Element)
                    {
                        elements.Add(ConvertXmlNodeToJsonObject(node));
                    }
                }

                root[doc.DocumentElement.Name] = elements;
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            return JsonSerializer.Serialize(root, options);
        }

        private object ConvertXmlNodeToJsonObject(XmlNode node)
        {
            var obj = new Dictionary<string, object>();

            if (node.Attributes?.Count > 0)
            {
                var attrs = new Dictionary<string, string>();
                foreach (XmlAttribute attr in node.Attributes)
                {
                    attrs[attr.Name] = attr.Value;
                }
                obj["@attributes"] = attrs;
            }

            var children = new List<object>();
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.NodeType == XmlNodeType.Element)
                {
                    children.Add(ConvertXmlNodeToJsonObject(child));
                }
                else if (child.NodeType == XmlNodeType.Text && !string.IsNullOrWhiteSpace(child.Value))
                {
                    obj["#text"] = child.Value.Trim();
                }
            }

            if (children.Count > 0)
            {
                obj["children"] = children;
            }

            return new Dictionary<string, object> { [node.Name] = obj };
        }

        private void BtnImportFromShapes_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0)
            {
                MessageBox.Show("Нет фигур на холсте для импорта", "Информация");
                return;
            }

            var tempFile = Path.GetTempFileName() + ".xml";

            try
            {
                var serializer = new XmlSerializer(typeof(List<Shape>));
                using (var writer = new StreamWriter(tempFile))
                    serializer.Serialize(writer, _shapes);

                var doc = new XmlDocument();
                doc.Load(tempFile);

                treeView1.Nodes.Clear();
                _collapseLevel = 0;
                _expandLevel = 0;

                var rootNode = new TreeNode(doc.DocumentElement?.Name ?? "Фигуры");
                AddXmlNodeToTree(doc.DocumentElement, rootNode);
                treeView1.Nodes.Add(rootNode);
                rootNode.Expand();

                _currentXmlFile = tempFile;
                MessageBox.Show($"Импортировано {_shapes.Count} фигур из задания 3", "Импорт");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при импорте: {ex.Message}", "Ошибка");
            }
        }

        private void BtnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
            _collapseLevel = 0;
            _expandLevel = 0;
        }

        private void BtnExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            _collapseLevel = 0;
            _expandLevel = 2;
        }

        private void BtnCollapseChildren_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0) return;

            TreeNode rootNode = treeView1.Nodes[0];
            _expandLevel = 0;

            if (_collapseLevel == 0)
            {
                foreach (TreeNode childNode in rootNode.Nodes)
                    childNode.Collapse();
                _collapseLevel = 1;
            }
            else if (_collapseLevel == 1)
            {
                rootNode.Collapse();
                _collapseLevel = 2;
            }
            else if (_collapseLevel == 2)
            {
                _collapseLevel = 0;
            }
        }

        private void BtnExpandChildren_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0) return;

            TreeNode rootNode = treeView1.Nodes[0];
            _collapseLevel = 0;

            if (_expandLevel == 0)
            {
                rootNode.Expand();
                _expandLevel = 1;
            }
            else if (_expandLevel == 1)
            {
                foreach (TreeNode childNode in rootNode.Nodes)
                    childNode.Expand();
                _expandLevel = 2;
            }
            else if (_expandLevel == 2)
            {
                foreach (TreeNode childNode in rootNode.Nodes)
                    foreach (TreeNode grandChild in childNode.Nodes)
                        grandChild.Expand();
                _expandLevel = 3;
            }
            else if (_expandLevel == 3)
            {
                _expandLevel = 0;
            }
        }

        private void BtnClearTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            _currentXmlFile = null;
            _collapseLevel = 0;
            _expandLevel = 0;
        }

        #endregion

        #region Задание 5: Журнал

        private void BtnAddLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Введите сообщение", "Предупреждение");
                txtMessage.Focus();
                return;
            }

            dataGridViewLog.Rows.Add(dataGridViewLog.Rows.Count + 1, DateTime.Now.ToString("dd.MM.yy HH:mm:ss,ff"), txtMessage.Text);
            txtMessage.Clear();
            txtMessage.Focus();
        }

        private void BtnLoadLog_Click(object sender, EventArgs e)
        {
            using var openDialog = new OpenFileDialog { Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*", Title = "Загрузить журнал системы" };
            if (openDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var doc = new XmlDocument();
                doc.Load(openDialog.FileName);
                var nodes = doc.GetElementsByTagName("Журнал_системы").Count > 0
                            ? doc.GetElementsByTagName("Журнал_системы")
                            : doc.GetElementsByTagName("SystemJournal");

                if (nodes.Count == 0)
                {
                    MessageBox.Show("Это не файл журнала системы", "Ошибка");
                    return;
                }

                dataGridViewLog.Rows.Clear();

                foreach (XmlNode node in nodes)
                {
                    dataGridViewLog.Rows.Add(node["Номер"]?.InnerText ?? "", node["Время"]?.InnerText ?? "", node["Сообщение"]?.InnerText ?? "");
                }

                MessageBox.Show($"Загружено {nodes.Count} записей из XML", "Загрузка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка");
            }
        }

        private void BtnSaveLog_Click(object sender, EventArgs e)
        {
            if (dataGridViewLog.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Информация");
                return;
            }

            using var saveDialog = new SaveFileDialog { Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*", FileName = "Журнал_системы.xml", Title = "Сохранить журнал системы" };
            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var doc = new XmlDocument();
                doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
                var root = doc.CreateElement("DocumentElement");
                doc.AppendChild(root);

                foreach (DataGridViewRow row in dataGridViewLog.Rows)
                {
                    if (row.IsNewRow || row.Cells["Number"]?.Value == null) continue;

                    var logEntry = doc.CreateElement("Журнал_системы");
                    logEntry.AppendChild(CreateElement(doc, "Номер", row.Cells["Number"].Value.ToString()));
                    logEntry.AppendChild(CreateElement(doc, "Время", row.Cells["Time"]?.Value?.ToString() ?? ""));
                    logEntry.AppendChild(CreateElement(doc, "Сообщение", row.Cells["Message"]?.Value?.ToString() ?? ""));
                    root.AppendChild(logEntry);
                }

                var settings = new XmlWriterSettings { Indent = true, IndentChars = "  ", Encoding = System.Text.Encoding.UTF8 };
                using var writer = XmlWriter.Create(saveDialog.FileName, settings);
                doc.Save(writer);

                MessageBox.Show($"Сохранено {dataGridViewLog.Rows.Count} записей в XML", "Сохранение");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private static XmlElement CreateElement(XmlDocument doc, string name, string value)
        {
            var element = doc.CreateElement(name);
            element.InnerText = value;
            return element;
        }

        private void BtnClearLog_Click(object sender, EventArgs e) => dataGridViewLog.Rows.Clear();

        #endregion

        #region Задание 6: Система команд

        private CheckedListBox GetCurrentCheckedListBox()
        {
            if (tabControlLS.SelectedTab == tabPageLS1) return checkedListBoxCommandsLS1;
            if (tabControlLS.SelectedTab == tabPageLS2) return checkedListBoxCommandsLS2;
            if (tabControlLS.SelectedTab == tabPageLS3) return checkedListBoxCommandsLS3;
            if (tabControlLS.SelectedTab == tabPageLS4) return checkedListBoxCommandsLS4;
            if (tabControlLS.SelectedTab == tabPageLS5) return checkedListBoxCommandsLS5;
            if (tabControlLS.SelectedTab == tabPageLS6) return checkedListBoxCommandsLS6;
            if (tabControlLS.SelectedTab == tabPageLS7) return checkedListBoxCommandsLS7;
            if (tabControlLS.SelectedTab == tabPageLS8) return checkedListBoxCommandsLS8;
            if (tabControlLS.SelectedTab == tabPageLS9) return checkedListBoxCommandsLS9;
            if (tabControlLS.SelectedTab == tabPageLS10) return checkedListBoxCommandsLS10;
            if (tabControlLS.SelectedTab == tabPageLS11) return checkedListBoxCommandsLS11;
            if (tabControlLS.SelectedTab == tabPageLS12) return checkedListBoxCommandsLS12;

            return checkedListBoxCommandsLS1;
        }

        private void TabControlLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlLS.SelectedTab == null) return;

            string lsName = tabControlLS.SelectedTab.Text;

            if (_activeLS.TryGetValue(lsName, out var ls))
            {
                _selectedLS = ls;
                UpdateCheckedListBoxFromLS(ls);
            }
            else
            {
                _selectedLS = new LSItem { Name = lsName, Commands = new List<string>() };

                var currentCheckedListBox = GetCurrentCheckedListBox();
                for (int i = 0; i < currentCheckedListBox.Items.Count; i++)
                    currentCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void AddSortedLSNode(TreeNode newNode)
        {
            int newNumber = ExtractNumberFromLSName(newNode.Text);
            int insertIndex = 0;

            foreach (TreeNode node in treeViewLS.Nodes)
            {
                if (newNumber < ExtractNumberFromLSName(node.Text))
                    break;
                insertIndex++;
            }

            treeViewLS.Nodes.Insert(insertIndex, newNode);
        }

        private static int ExtractNumberFromLSName(string lsName) =>
            int.TryParse(lsName.Replace("ЛС", ""), out int number) ? number : 0;

        private void TreeViewLS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var node = treeViewLS.GetNodeAt(e.Location);
            if (node == null) return;

            if (node.Parent == null)
            {
                if (node.Tag is LSItem ls && ConfirmDelete($"Удалить {ls.Name}?"))
                {
                    treeViewLS.Nodes.Remove(node);
                    _activeLS.Remove(ls.Name);

                    ls.Commands.Clear();

                    if (_selectedLS == ls)
                    {
                        _selectedLS = null;
                        var currentCheckedListBox = GetCurrentCheckedListBox();
                        for (int i = 0; i < currentCheckedListBox.Items.Count; i++)
                            currentCheckedListBox.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                if (node.Parent.Tag is LSItem parentLs)
                {
                    string commandName = node.Text;
                    if (ConfirmDelete($"Удалить команду '{commandName}' из {parentLs.Name}?"))
                    {
                        parentLs.Commands.Remove(commandName);
                        node.Parent.Nodes.Remove(node);

                        var currentCheckedListBox = GetCurrentCheckedListBox();
                        int index = currentCheckedListBox.Items.IndexOf(commandName);
                        if (index >= 0)
                            currentCheckedListBox.SetItemChecked(index, false);

                        var cmd = _allCommands.FirstOrDefault(c => c.Name == commandName);
                        if (cmd != null) cmd.IsChecked = false;

                        if (parentLs.Commands.Count == 0 && parentLs.Node != null)
                        {
                            treeViewLS.Nodes.Remove(parentLs.Node);
                            _activeLS.Remove(parentLs.Name);
                            parentLs.Node = null;
                        }
                    }
                }
            }
        }

        private void CheckedListBoxCommands_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() =>
            {
                var currentCheckedListBox = GetCurrentCheckedListBox();
                string commandName = currentCheckedListBox.Items[e.Index].ToString() ?? "";
                bool isChecked = e.NewValue == CheckState.Checked;

                if (isChecked)
                {
                    if (!_selectedLS.Commands.Contains(commandName))
                        _selectedLS.Commands.Add(commandName);
                }
                else
                {
                    _selectedLS.Commands.Remove(commandName);
                }

                SortCommands(_selectedLS.Commands);

                if (!_activeLS.ContainsKey(_selectedLS.Name))
                {
                    if (_selectedLS.Commands.Count > 0)
                    {
                        var node = new TreeNode(_selectedLS.Name) { Tag = _selectedLS };
                        _selectedLS.Node = node;
                        AddSortedLSNode(node);
                        _activeLS[_selectedLS.Name] = _selectedLS;
                    }
                }
                else
                {
                    if (_selectedLS.Commands.Count == 0)
                    {
                        if (_selectedLS.Node != null)
                        {
                            treeViewLS.Nodes.Remove(_selectedLS.Node);
                            _activeLS.Remove(_selectedLS.Name);
                            _selectedLS.Node = null;
                        }
                    }
                }

                if (_selectedLS.Node != null)
                {
                    UpdateLSNode(_selectedLS);
                }
            }));
        }

        private void SortCommands(List<string> commands)
        {
            commands.Sort((a, b) =>
            {
                int numA = ExtractCommandNumber(a);
                int numB = ExtractCommandNumber(b);

                if (numA > 0 && numB > 0) return numA.CompareTo(numB);
                if (a == "Отключение") return 1;
                if (b == "Отключение") return -1;
                if (a == "Сигнализация") return 1;
                if (b == "Сигнализация") return -1;
                if (numA > 0 && numB == 0) return -1;
                if (numA == 0 && numB > 0) return 1;
                return string.Compare(a, b);
            });
        }

        private static int ExtractCommandNumber(string commandName)
        {
            if (commandName.StartsWith("Команда ") && int.TryParse(commandName.Replace("Команда ", ""), out int number))
                return number;
            return 0;
        }

        private void UpdateCheckedListBoxFromLS(LSItem ls)
        {
            var currentCheckedListBox = GetCurrentCheckedListBox();

            for (int i = 0; i < currentCheckedListBox.Items.Count; i++)
                currentCheckedListBox.SetItemChecked(i, false);

            foreach (var cmd in ls.Commands)
            {
                int index = currentCheckedListBox.Items.IndexOf(cmd);
                if (index >= 0)
                    currentCheckedListBox.SetItemChecked(index, true);
            }
        }

        private void UpdateLSNode(LSItem ls)
        {
            ls.Node.Nodes.Clear();
            SortCommands(ls.Commands);

            foreach (var cmd in ls.Commands)
                ls.Node.Nodes.Add(new TreeNode(cmd));

            ls.Node.Expand();
        }

        private static bool ConfirmDelete(string message) =>
            MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        #endregion

        #region Классы данных

        [Serializable]
        public class Shape
        {
            public string Type { get; set; } = "";
            public PointF Position { get; set; }

            [XmlIgnore]
            public Color Color { get; set; } = Color.Black;

            [XmlElement("Color")]
            public string ColorHtml
            {
                get => ColorTranslator.ToHtml(Color);
                set => Color = ColorTranslator.FromHtml(value);
            }

            public float Size { get; set; } = 1f;
            public string Text { get; set; } = "";
            public bool ShouldSerializeText() => !string.IsNullOrEmpty(Text);
            public bool ShouldSerializeColorHtml() => Color != Color.Black;
        }

        public class CommandItem
        {
            public string Name { get; set; } = "";
            public bool IsChecked { get; set; }
            public override string ToString() => Name;
        }

        public class LSItem
        {
            public string Name { get; set; } = "";
            public List<string> Commands { get; set; } = new();
            public TreeNode Node { get; set; } = null!;
        }

        #endregion
    }
}