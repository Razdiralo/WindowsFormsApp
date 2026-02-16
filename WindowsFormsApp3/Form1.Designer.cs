namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPageTask1 = new TabPage();
            labelTask1Desc1 = new Label();
            progressBar1 = new ProgressBar();
            btnStartProgress = new Button();
            btnDelay = new Button();
            btnStop = new Button();
            tabPageTask2 = new TabPage();
            button1 = new Button();
            btnClearMatrix = new Button();
            btnRecalc = new Button();
            btnSaveMatrix = new Button();
            lblSumDiagonal = new Label();
            lblSumRow = new Label();
            lblSumCol = new Label();
            dataGridViewMatrix = new DataGridView();
            btnFillRandom = new Button();
            btnDrawTable = new Button();
            txtCols = new TextBox();
            lblCols = new Label();
            txtRows = new TextBox();
            lblRows = new Label();
            tabPageTask3 = new TabPage();
            label1 = new Label();
            pColorPreview = new Panel();
            btnEditText = new Button();
            btnLoadShapes = new Button();
            btnSaveShapes = new Button();
            btnResetShapes = new Button();
            btnAllShapes = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            btnText = new Button();
            btnSquare = new Button();
            btnCircle = new Button();
            btnPentagon = new Button();
            btnChooseColor = new Button();
            drawingPanel = new Panel();
            tabPageTask4 = new TabPage();
            btnClearTree = new Button();
            btnExpandChildren = new Button();
            btnCollapseChildren = new Button();
            btnExpandAll = new Button();
            btnCollapseAll = new Button();
            btnImportFromShapes = new Button();
            btnSaveTree = new Button();
            btnLoadTree = new Button();
            treeView1 = new TreeView();
            tabPageTask5 = new TabPage();
            btnClearLog = new Button();
            btnSaveLog = new Button();
            btnLoadLog = new Button();
            dataGridViewLog = new DataGridView();
            btnAddLog = new Button();
            txtMessage = new TextBox();
            lblMessage = new Label();
            dateTimePicker1 = new DateTimePicker();
            tabPageTask6 = new TabPage();
            checkedListBoxCommands = new CheckedListBox();
            tabControlLS = new TabControl();
            tabPageLS1 = new TabPage();
            tabPageLS2 = new TabPage();
            tabPageLS3 = new TabPage();
            tabPageLS4 = new TabPage();
            tabPageLS5 = new TabPage();
            tabPageLS6 = new TabPage();
            tabPageLS7 = new TabPage();
            tabPageLS8 = new TabPage();
            tabPageLS9 = new TabPage();
            tabPageLS10 = new TabPage();
            tabPageLS11 = new TabPage();
            tabPageLS12 = new TabPage();
            treeViewLS = new TreeView();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            Number = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPageTask1.SuspendLayout();
            tabPageTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            tabPageTask3.SuspendLayout();
            tabPageTask4.SuspendLayout();
            tabPageTask5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            tabPageTask6.SuspendLayout();
            tabControlLS.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTask1);
            tabControl1.Controls.Add(tabPageTask2);
            tabControl1.Controls.Add(tabPageTask3);
            tabControl1.Controls.Add(tabPageTask4);
            tabControl1.Controls.Add(tabPageTask5);
            tabControl1.Controls.Add(tabPageTask6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 700);
            tabControl1.TabIndex = 0;
            // 
            // tabPageTask1
            // 
            tabPageTask1.Controls.Add(labelTask1Desc1);
            tabPageTask1.Controls.Add(progressBar1);
            tabPageTask1.Controls.Add(btnStartProgress);
            tabPageTask1.Controls.Add(btnDelay);
            tabPageTask1.Controls.Add(btnStop);
            tabPageTask1.ForeColor = SystemColors.ControlText;
            tabPageTask1.Location = new Point(4, 26);
            tabPageTask1.Name = "tabPageTask1";
            tabPageTask1.Padding = new Padding(15);
            tabPageTask1.Size = new Size(992, 670);
            tabPageTask1.TabIndex = 0;
            tabPageTask1.Text = "Задание 1";
            tabPageTask1.UseVisualStyleBackColor = true;
            // 
            // labelTask1Desc1
            // 
            labelTask1Desc1.Font = new Font("Segoe UI", 12F);
            labelTask1Desc1.Location = new Point(18, 153);
            labelTask1Desc1.Name = "labelTask1Desc1";
            labelTask1Desc1.Size = new Size(697, 72);
            labelTask1Desc1.TabIndex = 4;
            labelTask1Desc1.Text = "По заполнению прогрессбара выводится сообщение: \"Прогрессбар заполнен\". Затем прогрессбар идёт в обратном направлении. По завершении выводится сообщение \"Прогрессбар пуст\".";
            labelTask1Desc1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(18, 18);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(620, 40);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // btnStartProgress
            // 
            btnStartProgress.BackColor = SystemColors.ControlLight;
            btnStartProgress.FlatAppearance.BorderColor = Color.Silver;
            btnStartProgress.FlatAppearance.BorderSize = 2;
            btnStartProgress.FlatStyle = FlatStyle.Flat;
            btnStartProgress.Font = new Font("Segoe UI", 12F);
            btnStartProgress.Location = new Point(18, 64);
            btnStartProgress.Margin = new Padding(0);
            btnStartProgress.Name = "btnStartProgress";
            btnStartProgress.Size = new Size(306, 40);
            btnStartProgress.TabIndex = 1;
            btnStartProgress.Text = "Запустить прогрессбар";
            btnStartProgress.UseVisualStyleBackColor = false;
            btnStartProgress.Click += BtnStartProgress_Click;
            // 
            // btnDelay
            // 
            btnDelay.BackColor = SystemColors.ControlLight;
            btnDelay.FlatAppearance.BorderColor = Color.Silver;
            btnDelay.FlatAppearance.BorderSize = 2;
            btnDelay.FlatStyle = FlatStyle.Flat;
            btnDelay.Font = new Font("Segoe UI", 12F);
            btnDelay.Location = new Point(332, 64);
            btnDelay.Name = "btnDelay";
            btnDelay.Size = new Size(306, 40);
            btnDelay.TabIndex = 2;
            btnDelay.Text = "Задержка на секунду";
            btnDelay.UseVisualStyleBackColor = false;
            btnDelay.Click += BtnDelay_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = SystemColors.ControlLight;
            btnStop.FlatAppearance.BorderColor = Color.Silver;
            btnStop.FlatAppearance.BorderSize = 2;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 12F);
            btnStop.Location = new Point(18, 110);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(620, 40);
            btnStop.TabIndex = 3;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // tabPageTask2
            // 
            tabPageTask2.Controls.Add(button1);
            tabPageTask2.Controls.Add(btnClearMatrix);
            tabPageTask2.Controls.Add(btnRecalc);
            tabPageTask2.Controls.Add(btnSaveMatrix);
            tabPageTask2.Controls.Add(lblSumDiagonal);
            tabPageTask2.Controls.Add(lblSumRow);
            tabPageTask2.Controls.Add(lblSumCol);
            tabPageTask2.Controls.Add(dataGridViewMatrix);
            tabPageTask2.Controls.Add(btnFillRandom);
            tabPageTask2.Controls.Add(btnDrawTable);
            tabPageTask2.Controls.Add(txtCols);
            tabPageTask2.Controls.Add(lblCols);
            tabPageTask2.Controls.Add(txtRows);
            tabPageTask2.Controls.Add(lblRows);
            tabPageTask2.Location = new Point(4, 26);
            tabPageTask2.Name = "tabPageTask2";
            tabPageTask2.Padding = new Padding(15);
            tabPageTask2.Size = new Size(1192, 770);
            tabPageTask2.TabIndex = 1;
            tabPageTask2.Text = "Задание 2";
            tabPageTask2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(575, 286);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 13;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnLoadMatrix_Click;
            // 
            // btnClearMatrix
            // 
            btnClearMatrix.BackColor = SystemColors.ControlLight;
            btnClearMatrix.FlatAppearance.BorderColor = Color.Silver;
            btnClearMatrix.FlatAppearance.BorderSize = 2;
            btnClearMatrix.FlatStyle = FlatStyle.Flat;
            btnClearMatrix.Font = new Font("Segoe UI", 12F);
            btnClearMatrix.Location = new Point(696, 286);
            btnClearMatrix.Name = "btnClearMatrix";
            btnClearMatrix.Size = new Size(115, 35);
            btnClearMatrix.TabIndex = 12;
            btnClearMatrix.Text = "Очистить";
            btnClearMatrix.UseVisualStyleBackColor = false;
            btnClearMatrix.Click += BtnClearMatrix_Click;
            // 
            // btnRecalc
            // 
            btnRecalc.BackColor = SystemColors.ControlLight;
            btnRecalc.FlatAppearance.BorderColor = Color.Silver;
            btnRecalc.FlatAppearance.BorderSize = 2;
            btnRecalc.FlatStyle = FlatStyle.Flat;
            btnRecalc.Font = new Font("Segoe UI", 12F);
            btnRecalc.Location = new Point(817, 286);
            btnRecalc.Name = "btnRecalc";
            btnRecalc.Size = new Size(115, 35);
            btnRecalc.TabIndex = 11;
            btnRecalc.Text = "Пересчитать";
            btnRecalc.UseVisualStyleBackColor = false;
            btnRecalc.Click += BtnRecalc_Click;
            // 
            // btnSaveMatrix
            // 
            btnSaveMatrix.BackColor = SystemColors.ControlLight;
            btnSaveMatrix.FlatAppearance.BorderColor = Color.Silver;
            btnSaveMatrix.FlatAppearance.BorderSize = 2;
            btnSaveMatrix.FlatStyle = FlatStyle.Flat;
            btnSaveMatrix.Font = new Font("Segoe UI", 12F);
            btnSaveMatrix.Location = new Point(454, 286);
            btnSaveMatrix.Name = "btnSaveMatrix";
            btnSaveMatrix.Size = new Size(115, 35);
            btnSaveMatrix.TabIndex = 10;
            btnSaveMatrix.Text = "Сохранить";
            btnSaveMatrix.UseVisualStyleBackColor = false;
            btnSaveMatrix.Click += BtnSaveMatrix_Click;
            // 
            // lblSumDiagonal
            // 
            lblSumDiagonal.Font = new Font("Segoe UI", 12F);
            lblSumDiagonal.Location = new Point(454, 245);
            lblSumDiagonal.Name = "lblSumDiagonal";
            lblSumDiagonal.Size = new Size(400, 30);
            lblSumDiagonal.TabIndex = 9;
            lblSumDiagonal.Text = "Сумма элементов главной диагонали: 0";
            lblSumDiagonal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumRow
            // 
            lblSumRow.Font = new Font("Segoe UI", 12F);
            lblSumRow.Location = new Point(454, 205);
            lblSumRow.Name = "lblSumRow";
            lblSumRow.Size = new Size(400, 30);
            lblSumRow.TabIndex = 8;
            lblSumRow.Text = "Сумма элементов первой строки: 0";
            lblSumRow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumCol
            // 
            lblSumCol.Font = new Font("Segoe UI", 12F);
            lblSumCol.Location = new Point(454, 165);
            lblSumCol.Name = "lblSumCol";
            lblSumCol.Size = new Size(400, 30);
            lblSumCol.TabIndex = 7;
            lblSumCol.Text = "Сумма элементов первого столбца: 0";
            lblSumCol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(18, 18);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(418, 303);
            dataGridViewMatrix.TabIndex = 6;
            // 
            // btnFillRandom
            // 
            btnFillRandom.BackColor = SystemColors.ControlLight;
            btnFillRandom.FlatAppearance.BorderColor = Color.Silver;
            btnFillRandom.FlatAppearance.BorderSize = 2;
            btnFillRandom.FlatStyle = FlatStyle.Flat;
            btnFillRandom.Font = new Font("Segoe UI", 12F);
            btnFillRandom.Location = new Point(454, 124);
            btnFillRandom.Name = "btnFillRandom";
            btnFillRandom.Size = new Size(478, 35);
            btnFillRandom.TabIndex = 5;
            btnFillRandom.Text = "Заполнить случайными числами от -10 до 10";
            btnFillRandom.UseVisualStyleBackColor = false;
            btnFillRandom.Click += BtnFillRandom_Click;
            // 
            // btnDrawTable
            // 
            btnDrawTable.BackColor = SystemColors.ControlLight;
            btnDrawTable.FlatAppearance.BorderColor = Color.Silver;
            btnDrawTable.FlatAppearance.BorderSize = 2;
            btnDrawTable.FlatStyle = FlatStyle.Flat;
            btnDrawTable.Font = new Font("Segoe UI", 12F);
            btnDrawTable.Location = new Point(717, 23);
            btnDrawTable.Name = "btnDrawTable";
            btnDrawTable.Size = new Size(215, 77);
            btnDrawTable.TabIndex = 4;
            btnDrawTable.Text = "Нарисовать таблицу";
            btnDrawTable.UseVisualStyleBackColor = false;
            btnDrawTable.Click += BtnDrawTable_Click;
            // 
            // txtCols
            // 
            txtCols.BorderStyle = BorderStyle.FixedSingle;
            txtCols.Font = new Font("Segoe UI", 12F);
            txtCols.Location = new Point(636, 71);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(60, 29);
            txtCols.TabIndex = 3;
            txtCols.Text = "5";
            txtCols.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCols
            // 
            lblCols.Font = new Font("Segoe UI", 12F);
            lblCols.Location = new Point(454, 74);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(169, 26);
            lblCols.TabIndex = 2;
            lblCols.Text = "Количество столбцов:";
            lblCols.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRows
            // 
            txtRows.BorderStyle = BorderStyle.FixedSingle;
            txtRows.Font = new Font("Segoe UI", 12F);
            txtRows.Location = new Point(636, 23);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(60, 29);
            txtRows.TabIndex = 1;
            txtRows.Text = "5";
            txtRows.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRows
            // 
            lblRows.Font = new Font("Segoe UI", 12F);
            lblRows.ImageAlign = ContentAlignment.TopCenter;
            lblRows.Location = new Point(454, 23);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(187, 26);
            lblRows.TabIndex = 0;
            lblRows.Text = "Количество строк:";
            lblRows.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageTask3
            // 
            tabPageTask3.Controls.Add(label1);
            tabPageTask3.Controls.Add(pColorPreview);
            tabPageTask3.Controls.Add(btnEditText);
            tabPageTask3.Controls.Add(btnLoadShapes);
            tabPageTask3.Controls.Add(btnSaveShapes);
            tabPageTask3.Controls.Add(btnResetShapes);
            tabPageTask3.Controls.Add(btnAllShapes);
            tabPageTask3.Controls.Add(btnDecrease);
            tabPageTask3.Controls.Add(btnIncrease);
            tabPageTask3.Controls.Add(btnText);
            tabPageTask3.Controls.Add(btnSquare);
            tabPageTask3.Controls.Add(btnCircle);
            tabPageTask3.Controls.Add(btnPentagon);
            tabPageTask3.Controls.Add(btnChooseColor);
            tabPageTask3.Controls.Add(drawingPanel);
            tabPageTask3.Location = new Point(4, 26);
            tabPageTask3.Name = "tabPageTask3";
            tabPageTask3.Padding = new Padding(15);
            tabPageTask3.Size = new Size(1192, 770);
            tabPageTask3.TabIndex = 2;
            tabPageTask3.Text = "Задание 3";
            tabPageTask3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 510);
            label1.Name = "label1";
            label1.Size = new Size(426, 21);
            label1.TabIndex = 13;
            label1.Text = "Сохранение и загрузка (2 формата файлов  - XML и JSON)";
            // 
            // pColorPreview
            // 
            pColorPreview.BackColor = Color.FloralWhite;
            pColorPreview.BorderStyle = BorderStyle.FixedSingle;
            pColorPreview.Location = new Point(176, 461);
            pColorPreview.Name = "pColorPreview";
            pColorPreview.Size = new Size(40, 40);
            pColorPreview.TabIndex = 12;
            // 
            // btnEditText
            // 
            btnEditText.BackColor = SystemColors.ControlLight;
            btnEditText.FlatAppearance.BorderColor = Color.Silver;
            btnEditText.FlatAppearance.BorderSize = 2;
            btnEditText.FlatStyle = FlatStyle.Flat;
            btnEditText.Font = new Font("Segoe UI", 12F);
            btnEditText.Location = new Point(609, 122);
            btnEditText.Name = "btnEditText";
            btnEditText.Size = new Size(140, 40);
            btnEditText.TabIndex = 11;
            btnEditText.Text = "Редактировать";
            btnEditText.UseVisualStyleBackColor = false;
            btnEditText.Click += BtnEditText_Click;
            // 
            // btnLoadShapes
            // 
            btnLoadShapes.BackColor = SystemColors.ControlLight;
            btnLoadShapes.FlatAppearance.BorderColor = Color.Silver;
            btnLoadShapes.FlatAppearance.BorderSize = 2;
            btnLoadShapes.FlatStyle = FlatStyle.Flat;
            btnLoadShapes.Font = new Font("Segoe UI", 12F);
            btnLoadShapes.Location = new Point(474, 461);
            btnLoadShapes.Name = "btnLoadShapes";
            btnLoadShapes.Size = new Size(120, 40);
            btnLoadShapes.TabIndex = 8;
            btnLoadShapes.Text = "Загрузить";
            btnLoadShapes.UseVisualStyleBackColor = false;
            btnLoadShapes.Click += BtnLoadShapes_Click;
            // 
            // btnSaveShapes
            // 
            btnSaveShapes.BackColor = SystemColors.ControlLight;
            btnSaveShapes.FlatAppearance.BorderColor = Color.Silver;
            btnSaveShapes.FlatAppearance.BorderSize = 2;
            btnSaveShapes.FlatStyle = FlatStyle.Flat;
            btnSaveShapes.Font = new Font("Segoe UI", 12F);
            btnSaveShapes.Location = new Point(348, 461);
            btnSaveShapes.Name = "btnSaveShapes";
            btnSaveShapes.Size = new Size(120, 40);
            btnSaveShapes.TabIndex = 7;
            btnSaveShapes.Text = "Сохранить";
            btnSaveShapes.UseVisualStyleBackColor = false;
            btnSaveShapes.Click += BtnSaveShapes_Click;
            // 
            // btnResetShapes
            // 
            btnResetShapes.BackColor = SystemColors.ControlLight;
            btnResetShapes.FlatAppearance.BorderColor = Color.Silver;
            btnResetShapes.FlatAppearance.BorderSize = 2;
            btnResetShapes.FlatStyle = FlatStyle.Flat;
            btnResetShapes.Font = new Font("Segoe UI", 12F);
            btnResetShapes.Location = new Point(222, 461);
            btnResetShapes.Name = "btnResetShapes";
            btnResetShapes.Size = new Size(120, 40);
            btnResetShapes.TabIndex = 6;
            btnResetShapes.Text = "Сброс";
            btnResetShapes.UseVisualStyleBackColor = false;
            btnResetShapes.Click += BtnResetShapes_Click;
            // 
            // btnAllShapes
            // 
            btnAllShapes.BackColor = SystemColors.ControlLight;
            btnAllShapes.FlatAppearance.BorderColor = Color.Silver;
            btnAllShapes.FlatAppearance.BorderSize = 2;
            btnAllShapes.FlatStyle = FlatStyle.Flat;
            btnAllShapes.Font = new Font("Segoe UI", 12F);
            btnAllShapes.Location = new Point(609, 411);
            btnAllShapes.Name = "btnAllShapes";
            btnAllShapes.Size = new Size(135, 40);
            btnAllShapes.TabIndex = 5;
            btnAllShapes.Text = "Все фигуры";
            btnAllShapes.UseVisualStyleBackColor = false;
            btnAllShapes.Click += BtnAllShapes_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = SystemColors.ControlLight;
            btnDecrease.FlatAppearance.BorderColor = Color.Silver;
            btnDecrease.FlatAppearance.BorderSize = 2;
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.Font = new Font("Segoe UI", 12F);
            btnDecrease.Location = new Point(609, 76);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(140, 40);
            btnDecrease.TabIndex = 4;
            btnDecrease.Text = "Уменьшить";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += BtnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = SystemColors.ControlLight;
            btnIncrease.FlatAppearance.BorderColor = Color.Silver;
            btnIncrease.FlatAppearance.BorderSize = 2;
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.Font = new Font("Segoe UI", 12F);
            btnIncrease.Location = new Point(609, 30);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(140, 40);
            btnIncrease.TabIndex = 3;
            btnIncrease.Text = "Увеличить";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += BtnIncrease_Click;
            // 
            // btnText
            // 
            btnText.BackColor = SystemColors.ControlLight;
            btnText.FlatAppearance.BorderColor = Color.Silver;
            btnText.FlatAppearance.BorderSize = 2;
            btnText.FlatStyle = FlatStyle.Flat;
            btnText.Font = new Font("Segoe UI", 12F);
            btnText.Location = new Point(609, 356);
            btnText.Name = "btnText";
            btnText.Size = new Size(135, 40);
            btnText.TabIndex = 10;
            btnText.Text = "Текст";
            btnText.UseVisualStyleBackColor = false;
            btnText.Click += BtnText_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.ControlLight;
            btnSquare.FlatAppearance.BorderColor = Color.Silver;
            btnSquare.FlatAppearance.BorderSize = 2;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI", 12F);
            btnSquare.Location = new Point(609, 191);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(135, 40);
            btnSquare.TabIndex = 9;
            btnSquare.Text = "Квадрат";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += BtnSquare_Click;
            // 
            // btnCircle
            // 
            btnCircle.BackColor = SystemColors.ControlLight;
            btnCircle.FlatAppearance.BorderColor = Color.Silver;
            btnCircle.FlatAppearance.BorderSize = 2;
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.Font = new Font("Segoe UI", 12F);
            btnCircle.Location = new Point(609, 301);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(135, 40);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Круг";
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += BtnCircle_Click;
            // 
            // btnPentagon
            // 
            btnPentagon.BackColor = SystemColors.ControlLight;
            btnPentagon.FlatAppearance.BorderColor = Color.Silver;
            btnPentagon.FlatAppearance.BorderSize = 2;
            btnPentagon.FlatStyle = FlatStyle.Flat;
            btnPentagon.Font = new Font("Segoe UI", 12F);
            btnPentagon.Location = new Point(609, 246);
            btnPentagon.Name = "btnPentagon";
            btnPentagon.Size = new Size(135, 40);
            btnPentagon.TabIndex = 1;
            btnPentagon.Text = "Пятиугольник";
            btnPentagon.UseVisualStyleBackColor = false;
            btnPentagon.Click += BtnPentagon_Click;
            // 
            // btnChooseColor
            // 
            btnChooseColor.BackColor = SystemColors.ControlLight;
            btnChooseColor.FlatAppearance.BorderColor = Color.Silver;
            btnChooseColor.FlatStyle = FlatStyle.Flat;
            btnChooseColor.Font = new Font("Segoe UI", 12F);
            btnChooseColor.Location = new Point(30, 461);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(140, 40);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Выбрать цвет";
            btnChooseColor.UseVisualStyleBackColor = false;
            btnChooseColor.Click += BtnChooseColor_Click;
            // 
            // drawingPanel
            // 
            drawingPanel.BackColor = Color.White;
            drawingPanel.BorderStyle = BorderStyle.FixedSingle;
            drawingPanel.Location = new Point(30, 30);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(564, 420);
            drawingPanel.TabIndex = 10;
            // 
            // tabPageTask4
            // 
            tabPageTask4.Controls.Add(btnClearTree);
            tabPageTask4.Controls.Add(btnExpandChildren);
            tabPageTask4.Controls.Add(btnCollapseChildren);
            tabPageTask4.Controls.Add(btnExpandAll);
            tabPageTask4.Controls.Add(btnCollapseAll);
            tabPageTask4.Controls.Add(btnImportFromShapes);
            tabPageTask4.Controls.Add(btnSaveTree);
            tabPageTask4.Controls.Add(btnLoadTree);
            tabPageTask4.Controls.Add(treeView1);
            tabPageTask4.Location = new Point(4, 26);
            tabPageTask4.Name = "tabPageTask4";
            tabPageTask4.Padding = new Padding(15);
            tabPageTask4.Size = new Size(1192, 770);
            tabPageTask4.TabIndex = 3;
            tabPageTask4.Text = "Задание 4";
            tabPageTask4.UseVisualStyleBackColor = true;
            // 
            // btnClearTree
            // 
            btnClearTree.BackColor = SystemColors.ControlLight;
            btnClearTree.FlatAppearance.BorderColor = Color.Silver;
            btnClearTree.FlatAppearance.BorderSize = 2;
            btnClearTree.FlatStyle = FlatStyle.Flat;
            btnClearTree.Font = new Font("Segoe UI", 12F);
            btnClearTree.Location = new Point(550, 490);
            btnClearTree.Name = "btnClearTree";
            btnClearTree.Size = new Size(200, 40);
            btnClearTree.TabIndex = 7;
            btnClearTree.Text = "Очистить дерево";
            btnClearTree.UseVisualStyleBackColor = false;
            btnClearTree.Click += BtnClearTree_Click;
            // 
            // btnExpandChildren
            // 
            btnExpandChildren.BackColor = SystemColors.ControlLight;
            btnExpandChildren.FlatAppearance.BorderColor = Color.Silver;
            btnExpandChildren.FlatAppearance.BorderSize = 2;
            btnExpandChildren.FlatStyle = FlatStyle.Flat;
            btnExpandChildren.Font = new Font("Segoe UI", 12F);
            btnExpandChildren.Location = new Point(550, 354);
            btnExpandChildren.Name = "btnExpandChildren";
            btnExpandChildren.Size = new Size(200, 40);
            btnExpandChildren.TabIndex = 6;
            btnExpandChildren.Text = "Развернуть дочерние";
            btnExpandChildren.UseVisualStyleBackColor = false;
            btnExpandChildren.Click += BtnExpandChildren_Click;
            // 
            // btnCollapseChildren
            // 
            btnCollapseChildren.BackColor = SystemColors.ControlLight;
            btnCollapseChildren.FlatAppearance.BorderColor = Color.Silver;
            btnCollapseChildren.FlatAppearance.BorderSize = 2;
            btnCollapseChildren.FlatStyle = FlatStyle.Flat;
            btnCollapseChildren.Font = new Font("Segoe UI", 12F);
            btnCollapseChildren.Location = new Point(550, 308);
            btnCollapseChildren.Name = "btnCollapseChildren";
            btnCollapseChildren.Size = new Size(200, 40);
            btnCollapseChildren.TabIndex = 5;
            btnCollapseChildren.Text = "Свернуть дочерние";
            btnCollapseChildren.UseVisualStyleBackColor = false;
            btnCollapseChildren.Click += BtnCollapseChildren_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.BackColor = SystemColors.ControlLight;
            btnExpandAll.FlatAppearance.BorderColor = Color.Silver;
            btnExpandAll.FlatAppearance.BorderSize = 2;
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Font = new Font("Segoe UI", 12F);
            btnExpandAll.Location = new Point(550, 221);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(200, 40);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Развернуть все узлы";
            btnExpandAll.UseVisualStyleBackColor = false;
            btnExpandAll.Click += BtnExpandAll_Click;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.BackColor = SystemColors.ControlLight;
            btnCollapseAll.FlatAppearance.BorderColor = Color.Silver;
            btnCollapseAll.FlatAppearance.BorderSize = 2;
            btnCollapseAll.FlatStyle = FlatStyle.Flat;
            btnCollapseAll.Font = new Font("Segoe UI", 12F);
            btnCollapseAll.Location = new Point(550, 175);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(200, 40);
            btnCollapseAll.TabIndex = 3;
            btnCollapseAll.Text = "Свернуть все узлы";
            btnCollapseAll.UseVisualStyleBackColor = false;
            btnCollapseAll.Click += BtnCollapseAll_Click;
            // 
            // btnImportFromShapes
            // 
            btnImportFromShapes.BackColor = SystemColors.ControlLight;
            btnImportFromShapes.FlatAppearance.BorderColor = Color.Silver;
            btnImportFromShapes.FlatAppearance.BorderSize = 2;
            btnImportFromShapes.FlatStyle = FlatStyle.Flat;
            btnImportFromShapes.Font = new Font("Segoe UI", 12F);
            btnImportFromShapes.Location = new Point(550, 444);
            btnImportFromShapes.Name = "btnImportFromShapes";
            btnImportFromShapes.Size = new Size(200, 40);
            btnImportFromShapes.TabIndex = 8;
            btnImportFromShapes.Text = "Импорт из задания 3";
            btnImportFromShapes.UseVisualStyleBackColor = false;
            btnImportFromShapes.Click += BtnImportFromShapes_Click;
            // 
            // btnSaveTree
            // 
            btnSaveTree.BackColor = SystemColors.ControlLight;
            btnSaveTree.FlatAppearance.BorderColor = Color.Silver;
            btnSaveTree.FlatAppearance.BorderSize = 2;
            btnSaveTree.FlatStyle = FlatStyle.Flat;
            btnSaveTree.Font = new Font("Segoe UI", 12F);
            btnSaveTree.Location = new Point(550, 80);
            btnSaveTree.Name = "btnSaveTree";
            btnSaveTree.Size = new Size(200, 40);
            btnSaveTree.TabIndex = 2;
            btnSaveTree.Text = "Сохранить журнал";
            btnSaveTree.UseVisualStyleBackColor = false;
            btnSaveTree.Click += BtnSaveTree_Click;
            // 
            // btnLoadTree
            // 
            btnLoadTree.BackColor = SystemColors.ControlLight;
            btnLoadTree.FlatAppearance.BorderColor = Color.Silver;
            btnLoadTree.FlatAppearance.BorderSize = 2;
            btnLoadTree.FlatStyle = FlatStyle.Flat;
            btnLoadTree.Font = new Font("Segoe UI", 12F);
            btnLoadTree.Location = new Point(550, 30);
            btnLoadTree.Name = "btnLoadTree";
            btnLoadTree.Size = new Size(200, 40);
            btnLoadTree.TabIndex = 1;
            btnLoadTree.Text = "Загрузить журнал";
            btnLoadTree.UseVisualStyleBackColor = false;
            btnLoadTree.Click += BtnLoadTree_Click;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Segoe UI", 11F);
            treeView1.Location = new Point(30, 30);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(500, 500);
            treeView1.TabIndex = 0;
            // 
            // tabPageTask5
            // 
            tabPageTask5.Controls.Add(btnClearLog);
            tabPageTask5.Controls.Add(btnSaveLog);
            tabPageTask5.Controls.Add(btnLoadLog);
            tabPageTask5.Controls.Add(dataGridViewLog);
            tabPageTask5.Controls.Add(btnAddLog);
            tabPageTask5.Controls.Add(txtMessage);
            tabPageTask5.Controls.Add(lblMessage);
            tabPageTask5.Controls.Add(dateTimePicker1);
            tabPageTask5.Location = new Point(4, 26);
            tabPageTask5.Name = "tabPageTask5";
            tabPageTask5.Padding = new Padding(15);
            tabPageTask5.Size = new Size(992, 670);
            tabPageTask5.TabIndex = 4;
            tabPageTask5.Text = "Задание 5";
            tabPageTask5.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.ControlLight;
            btnClearLog.FlatAppearance.BorderColor = Color.Silver;
            btnClearLog.FlatAppearance.BorderSize = 2;
            btnClearLog.FlatStyle = FlatStyle.Flat;
            btnClearLog.Font = new Font("Segoe UI", 12F);
            btnClearLog.Location = new Point(809, 179);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(180, 35);
            btnClearLog.TabIndex = 7;
            btnClearLog.Text = "Очистить";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += BtnClearLog_Click;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.ControlLight;
            btnSaveLog.FlatAppearance.BorderColor = Color.Silver;
            btnSaveLog.FlatAppearance.BorderSize = 2;
            btnSaveLog.FlatStyle = FlatStyle.Flat;
            btnSaveLog.Font = new Font("Segoe UI", 12F);
            btnSaveLog.Location = new Point(809, 130);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(180, 35);
            btnSaveLog.TabIndex = 6;
            btnSaveLog.Text = "Сохранить журнал";
            btnSaveLog.UseVisualStyleBackColor = false;
            btnSaveLog.Click += BtnSaveLog_Click;
            // 
            // btnLoadLog
            // 
            btnLoadLog.BackColor = SystemColors.ControlLight;
            btnLoadLog.FlatAppearance.BorderColor = Color.Silver;
            btnLoadLog.FlatAppearance.BorderSize = 2;
            btnLoadLog.FlatStyle = FlatStyle.Flat;
            btnLoadLog.Font = new Font("Segoe UI", 12F);
            btnLoadLog.Location = new Point(809, 80);
            btnLoadLog.Name = "btnLoadLog";
            btnLoadLog.Size = new Size(180, 35);
            btnLoadLog.TabIndex = 5;
            btnLoadLog.Text = "Загрузить журнал";
            btnLoadLog.UseVisualStyleBackColor = false;
            btnLoadLog.Click += BtnLoadLog_Click;
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.AllowUserToAddRows = false;
            dataGridViewLog.AllowUserToDeleteRows = false;
            dataGridViewLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Columns.AddRange(new DataGridViewColumn[] { Number, Message, Time });
            dataGridViewLog.Location = new Point(30, 80);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.ReadOnly = true;
            dataGridViewLog.RowHeadersVisible = false;
            dataGridViewLog.Size = new Size(764, 327);
            dataGridViewLog.TabIndex = 4;
            // 
            // btnAddLog
            // 
            btnAddLog.BackColor = SystemColors.ControlLight;
            btnAddLog.FlatAppearance.BorderColor = Color.Silver;
            btnAddLog.FlatAppearance.BorderSize = 2;
            btnAddLog.FlatStyle = FlatStyle.Flat;
            btnAddLog.Font = new Font("Segoe UI", 12F);
            btnAddLog.Location = new Point(809, 25);
            btnAddLog.Name = "btnAddLog";
            btnAddLog.Size = new Size(120, 35);
            btnAddLog.TabIndex = 3;
            btnAddLog.Text = "Добавить";
            btnAddLog.UseVisualStyleBackColor = false;
            btnAddLog.Click += BtnAddLog_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 12F);
            txtMessage.Location = new Point(359, 29);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(435, 29);
            txtMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 12F);
            lblMessage.Location = new Point(250, 25);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(110, 35);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Сообщение:";
            lblMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(30, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPageTask6
            // 
            tabPageTask6.Controls.Add(checkedListBoxCommands);
            tabPageTask6.Controls.Add(tabControlLS);
            tabPageTask6.Controls.Add(treeViewLS);
            tabPageTask6.Location = new Point(4, 26);
            tabPageTask6.Name = "tabPageTask6";
            tabPageTask6.Padding = new Padding(15);
            tabPageTask6.Size = new Size(1192, 770);
            tabPageTask6.TabIndex = 5;
            tabPageTask6.Text = "Задание 6";
            tabPageTask6.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommands
            // 
            checkedListBoxCommands.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommands.CheckOnClick = true;
            checkedListBoxCommands.Font = new Font("Segoe UI", 11F);
            checkedListBoxCommands.FormattingEnabled = true;
            checkedListBoxCommands.IntegralHeight = false;
            checkedListBoxCommands.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommands.Location = new Point(417, 140);
            checkedListBoxCommands.Name = "checkedListBoxCommands";
            checkedListBoxCommands.Size = new Size(378, 312);
            checkedListBoxCommands.TabIndex = 12;
            checkedListBoxCommands.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabControlLS
            // 
            tabControlLS.Appearance = TabAppearance.Buttons;
            tabControlLS.Controls.Add(tabPageLS1);
            tabControlLS.Controls.Add(tabPageLS2);
            tabControlLS.Controls.Add(tabPageLS3);
            tabControlLS.Controls.Add(tabPageLS4);
            tabControlLS.Controls.Add(tabPageLS5);
            tabControlLS.Controls.Add(tabPageLS6);
            tabControlLS.Controls.Add(tabPageLS7);
            tabControlLS.Controls.Add(tabPageLS8);
            tabControlLS.Controls.Add(tabPageLS9);
            tabControlLS.Controls.Add(tabPageLS10);
            tabControlLS.Controls.Add(tabPageLS11);
            tabControlLS.Controls.Add(tabPageLS12);
            tabControlLS.Font = new Font("Segoe UI", 12F);
            tabControlLS.ItemSize = new Size(60, 30);
            tabControlLS.Location = new Point(417, 42);
            tabControlLS.Multiline = true;
            tabControlLS.Name = "tabControlLS";
            tabControlLS.SelectedIndex = 0;
            tabControlLS.Size = new Size(378, 66);
            tabControlLS.SizeMode = TabSizeMode.Fixed;
            tabControlLS.TabIndex = 11;
            tabControlLS.SelectedIndexChanged += TabControlLS_SelectedIndexChanged;
            // 
            // tabPageLS1
            // 
            tabPageLS1.Location = new Point(4, 67);
            tabPageLS1.Name = "tabPageLS1";
            tabPageLS1.Padding = new Padding(3);
            tabPageLS1.Size = new Size(370, 0);
            tabPageLS1.TabIndex = 0;
            tabPageLS1.Text = "ЛС1";
            tabPageLS1.UseVisualStyleBackColor = true;
            // 
            // tabPageLS2
            // 
            tabPageLS2.Location = new Point(4, 67);
            tabPageLS2.Name = "tabPageLS2";
            tabPageLS2.Padding = new Padding(3);
            tabPageLS2.Size = new Size(370, 0);
            tabPageLS2.TabIndex = 1;
            tabPageLS2.Text = "ЛС2";
            tabPageLS2.UseVisualStyleBackColor = true;
            // 
            // tabPageLS3
            // 
            tabPageLS3.Location = new Point(4, 67);
            tabPageLS3.Name = "tabPageLS3";
            tabPageLS3.Padding = new Padding(3);
            tabPageLS3.Size = new Size(370, 0);
            tabPageLS3.TabIndex = 2;
            tabPageLS3.Text = "ЛС3";
            tabPageLS3.UseVisualStyleBackColor = true;
            // 
            // tabPageLS4
            // 
            tabPageLS4.Location = new Point(4, 67);
            tabPageLS4.Name = "tabPageLS4";
            tabPageLS4.Padding = new Padding(3);
            tabPageLS4.Size = new Size(370, 0);
            tabPageLS4.TabIndex = 3;
            tabPageLS4.Text = "ЛС4";
            tabPageLS4.UseVisualStyleBackColor = true;
            // 
            // tabPageLS5
            // 
            tabPageLS5.Location = new Point(4, 67);
            tabPageLS5.Name = "tabPageLS5";
            tabPageLS5.Padding = new Padding(3);
            tabPageLS5.Size = new Size(370, 0);
            tabPageLS5.TabIndex = 4;
            tabPageLS5.Text = "ЛС5";
            tabPageLS5.UseVisualStyleBackColor = true;
            // 
            // tabPageLS6
            // 
            tabPageLS6.Location = new Point(4, 67);
            tabPageLS6.Name = "tabPageLS6";
            tabPageLS6.Padding = new Padding(3);
            tabPageLS6.Size = new Size(370, 0);
            tabPageLS6.TabIndex = 5;
            tabPageLS6.Text = "ЛС6";
            tabPageLS6.UseVisualStyleBackColor = true;
            // 
            // tabPageLS7
            // 
            tabPageLS7.Location = new Point(4, 67);
            tabPageLS7.Name = "tabPageLS7";
            tabPageLS7.Padding = new Padding(3);
            tabPageLS7.Size = new Size(370, 0);
            tabPageLS7.TabIndex = 6;
            tabPageLS7.Text = "ЛС7";
            tabPageLS7.UseVisualStyleBackColor = true;
            // 
            // tabPageLS8
            // 
            tabPageLS8.Location = new Point(4, 67);
            tabPageLS8.Name = "tabPageLS8";
            tabPageLS8.Padding = new Padding(3);
            tabPageLS8.Size = new Size(370, 0);
            tabPageLS8.TabIndex = 7;
            tabPageLS8.Text = "ЛС8";
            tabPageLS8.UseVisualStyleBackColor = true;
            // 
            // tabPageLS9
            // 
            tabPageLS9.Location = new Point(4, 67);
            tabPageLS9.Name = "tabPageLS9";
            tabPageLS9.Padding = new Padding(3);
            tabPageLS9.Size = new Size(370, 0);
            tabPageLS9.TabIndex = 8;
            tabPageLS9.Text = "ЛС9";
            tabPageLS9.UseVisualStyleBackColor = true;
            // 
            // tabPageLS10
            // 
            tabPageLS10.Location = new Point(4, 67);
            tabPageLS10.Name = "tabPageLS10";
            tabPageLS10.Padding = new Padding(3);
            tabPageLS10.Size = new Size(370, 0);
            tabPageLS10.TabIndex = 9;
            tabPageLS10.Text = "ЛС10";
            tabPageLS10.UseVisualStyleBackColor = true;
            // 
            // tabPageLS11
            // 
            tabPageLS11.Location = new Point(4, 67);
            tabPageLS11.Name = "tabPageLS11";
            tabPageLS11.Padding = new Padding(3);
            tabPageLS11.Size = new Size(370, 0);
            tabPageLS11.TabIndex = 10;
            tabPageLS11.Text = "ЛС11";
            tabPageLS11.UseVisualStyleBackColor = true;
            // 
            // tabPageLS12
            // 
            tabPageLS12.Location = new Point(4, 67);
            tabPageLS12.Name = "tabPageLS12";
            tabPageLS12.Padding = new Padding(3);
            tabPageLS12.Size = new Size(370, 0);
            tabPageLS12.TabIndex = 11;
            tabPageLS12.Text = "ЛС12";
            tabPageLS12.UseVisualStyleBackColor = true;
            // 
            // treeViewLS
            // 
            treeViewLS.Font = new Font("Segoe UI", 11F);
            treeViewLS.Location = new Point(35, 42);
            treeViewLS.Name = "treeViewLS";
            treeViewLS.Size = new Size(356, 410);
            treeViewLS.TabIndex = 10;
            treeViewLS.MouseDoubleClick += TreeViewLS_MouseDoubleClick;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.Blue;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // Number
            // 
            Number.FillWeight = 19.796957F;
            Number.HeaderText = "№";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Message
            // 
            Message.FillWeight = 78.8884354F;
            Message.HeaderText = "Время";
            Message.Name = "Message";
            Message.ReadOnly = true;
            // 
            // Time
            // 
            Time.FillWeight = 201.314621F;
            Time.HeaderText = "Сообщение";
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowsFormsApp3 - Лабораторная работа";
            tabControl1.ResumeLayout(false);
            tabPageTask1.ResumeLayout(false);
            tabPageTask2.ResumeLayout(false);
            tabPageTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            tabPageTask3.ResumeLayout(false);
            tabPageTask3.PerformLayout();
            tabPageTask4.ResumeLayout(false);
            tabPageTask5.ResumeLayout(false);
            tabPageTask5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            tabPageTask6.ResumeLayout(false);
            tabControlLS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageTask1;
        private TabPage tabPageTask2;
        private TabPage tabPageTask3;
        private TabPage tabPageTask4;
        private TabPage tabPageTask5;
        private TabPage tabPageTask6;

        private Label labelTask1Desc1;
        private ProgressBar progressBar1;
        private Button btnStartProgress;
        private Button btnDelay;
        private Button btnStop;

        private Label lblRows;
        private TextBox txtRows;
        private Label lblCols;
        private TextBox txtCols;
        private Button btnDrawTable;
        private Button btnFillRandom;
        private DataGridView dataGridViewMatrix;
        private Label lblSumCol;
        private Label lblSumRow;
        private Label lblSumDiagonal;
        private Button btnSaveMatrix;
        private Button btnRecalc;
        private Button btnClearMatrix;

        private Panel drawingPanel;
        private Button btnChooseColor;
        private Button btnPentagon;
        private Button btnCircle;
        private Button btnSquare;
        private Button btnText;
        private Button btnIncrease;
        private Button btnDecrease;
        private Button btnAllShapes;
        private Button btnResetShapes;
        private Button btnSaveShapes;
        private Button btnLoadShapes;
        private Button btnEditText;
        private ColorDialog colorDialog1;

        private TreeView treeView1;
        private Button btnLoadTree;
        private Button btnSaveTree;
        private Button btnImportFromShapes;
        private Button btnCollapseAll;
        private Button btnExpandAll;
        private Button btnCollapseChildren;
        private Button btnExpandChildren;
        private Button btnClearTree;

        private DateTimePicker dateTimePicker1;
        private Label lblMessage;
        private TextBox txtMessage;
        private Button btnAddLog;
        private DataGridView dataGridViewLog;
        private Button btnLoadLog;
        private Button btnSaveLog;
        private Button btnClearLog;

        private TreeView treeViewLS;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControlLS;
        private CheckedListBox checkedListBoxCommands;
        private TabPage tabPageLS1;
        private TabPage tabPageLS2;
        private TabPage tabPageLS3;
        private TabPage tabPageLS4;
        private TabPage tabPageLS5;
        private TabPage tabPageLS6;
        private TabPage tabPageLS7;
        private TabPage tabPageLS8;
        private TabPage tabPageLS9;
        private TabPage tabPageLS10;
        private TabPage tabPageLS11;
        private TabPage tabPageLS12;
        private Button button1;
        private Panel pColorPreview;
        private Label label1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Message;
        private DataGridViewTextBoxColumn Time;
    }
}