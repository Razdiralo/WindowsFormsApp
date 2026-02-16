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
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            labelTask1Desc1 = new Label();
            btnStop = new Button();
            btnDelay = new Button();
            btnStartProgress = new Button();
            tabPageTask2 = new TabPage();
            groupBox2 = new GroupBox();
            btnDrawTable = new Button();
            dataGridViewMatrix = new DataGridView();
            button1 = new Button();
            btnFillRandom = new Button();
            btnClearMatrix = new Button();
            lblRows = new Label();
            btnRecalc = new Button();
            txtRows = new TextBox();
            btnSaveMatrix = new Button();
            lblCols = new Label();
            lblSumDiagonal = new Label();
            txtCols = new TextBox();
            lblSumRow = new Label();
            lblSumCol = new Label();
            tabPageTask3 = new TabPage();
            groupBox3 = new GroupBox();
            btnResetShapes = new Button();
            label1 = new Label();
            drawingPanel = new Panel();
            pColorPreview = new Panel();
            btnChooseColor = new Button();
            btnEditText = new Button();
            btnPentagon = new Button();
            btnLoadShapes = new Button();
            btnCircle = new Button();
            btnSaveShapes = new Button();
            btnSquare = new Button();
            btnText = new Button();
            btnAllShapes = new Button();
            btnIncrease = new Button();
            btnDecrease = new Button();
            tabPageTask4 = new TabPage();
            groupBox4 = new GroupBox();
            treeView1 = new TreeView();
            btnClearTree = new Button();
            btnLoadTree = new Button();
            btnExpandChildren = new Button();
            btnSaveTree = new Button();
            btnCollapseChildren = new Button();
            btnImportFromShapes = new Button();
            btnExpandAll = new Button();
            btnCollapseAll = new Button();
            tabPageTask5 = new TabPage();
            groupBox5 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnClearLog = new Button();
            lblMessage = new Label();
            btnSaveLog = new Button();
            txtMessage = new TextBox();
            btnLoadLog = new Button();
            btnAddLog = new Button();
            dataGridViewLog = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            tabPageTask6 = new TabPage();
            groupBox6 = new GroupBox();
            treeViewLS = new TreeView();
            tabControlLS = new TabControl();
            tabPageLS1 = new TabPage();
            checkedListBoxCommandsLS1 = new CheckedListBox();
            tabPageLS2 = new TabPage();
            checkedListBoxCommandsLS2 = new CheckedListBox();
            tabPageLS3 = new TabPage();
            checkedListBoxCommandsLS3 = new CheckedListBox();
            tabPageLS4 = new TabPage();
            checkedListBoxCommandsLS4 = new CheckedListBox();
            tabPageLS5 = new TabPage();
            checkedListBoxCommandsLS5 = new CheckedListBox();
            tabPageLS6 = new TabPage();
            checkedListBoxCommandsLS6 = new CheckedListBox();
            tabPageLS7 = new TabPage();
            checkedListBoxCommandsLS7 = new CheckedListBox();
            tabPageLS8 = new TabPage();
            checkedListBoxCommandsLS8 = new CheckedListBox();
            tabPageLS9 = new TabPage();
            checkedListBoxCommandsLS9 = new CheckedListBox();
            tabPageLS10 = new TabPage();
            checkedListBoxCommandsLS10 = new CheckedListBox();
            tabPageLS11 = new TabPage();
            checkedListBoxCommandsLS11 = new CheckedListBox();
            tabPageLS12 = new TabPage();
            checkedListBoxCommandsLS12 = new CheckedListBox();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPageTask1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageTask2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            tabPageTask3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPageTask4.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPageTask5.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            tabPageTask6.SuspendLayout();
            groupBox6.SuspendLayout();
            tabControlLS.SuspendLayout();
            tabPageLS1.SuspendLayout();
            tabPageLS2.SuspendLayout();
            tabPageLS3.SuspendLayout();
            tabPageLS4.SuspendLayout();
            tabPageLS5.SuspendLayout();
            tabPageLS6.SuspendLayout();
            tabPageLS7.SuspendLayout();
            tabPageLS8.SuspendLayout();
            tabPageLS9.SuspendLayout();
            tabPageLS10.SuspendLayout();
            tabPageLS11.SuspendLayout();
            tabPageLS12.SuspendLayout();
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
            tabControl1.Font = new Font("Microsoft Sans Serif", 8.25F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1047, 582);
            tabControl1.TabIndex = 0;
            // 
            // tabPageTask1
            // 
            tabPageTask1.Controls.Add(groupBox1);
            tabPageTask1.ForeColor = SystemColors.ControlText;
            tabPageTask1.Location = new Point(4, 22);
            tabPageTask1.Name = "tabPageTask1";
            tabPageTask1.Padding = new Padding(15);
            tabPageTask1.Size = new Size(1039, 556);
            tabPageTask1.TabIndex = 0;
            tabPageTask1.Text = "Задание 1";
            tabPageTask1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(labelTask1Desc1);
            groupBox1.Controls.Add(btnStop);
            groupBox1.Controls.Add(btnDelay);
            groupBox1.Controls.Add(btnStartProgress);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 192);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание 1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 24);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(620, 26);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // labelTask1Desc1
            // 
            labelTask1Desc1.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelTask1Desc1.Location = new Point(6, 111);
            labelTask1Desc1.Name = "labelTask1Desc1";
            labelTask1Desc1.Size = new Size(620, 72);
            labelTask1Desc1.TabIndex = 4;
            labelTask1Desc1.Text = "По заполнению прогрессбара выводится сообщение: \"Прогрессбар заполнен\". Затем прогрессбар идёт в обратном направлении. По завершении выводится сообщение \"Прогрессбар пуст\".";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Transparent;
            btnStop.FlatAppearance.BorderColor = Color.Silver;
            btnStop.FlatAppearance.BorderSize = 2;
            btnStop.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnStop.Location = new Point(6, 82);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(620, 26);
            btnStop.TabIndex = 3;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnDelay
            // 
            btnDelay.BackColor = Color.Transparent;
            btnDelay.FlatAppearance.BorderColor = Color.Silver;
            btnDelay.FlatAppearance.BorderSize = 2;
            btnDelay.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDelay.Location = new Point(320, 53);
            btnDelay.Name = "btnDelay";
            btnDelay.Size = new Size(306, 26);
            btnDelay.TabIndex = 2;
            btnDelay.Text = "Задержка на секунду";
            btnDelay.UseVisualStyleBackColor = false;
            btnDelay.Click += BtnDelay_Click;
            // 
            // btnStartProgress
            // 
            btnStartProgress.BackColor = Color.Transparent;
            btnStartProgress.FlatAppearance.BorderColor = Color.Silver;
            btnStartProgress.FlatAppearance.BorderSize = 2;
            btnStartProgress.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnStartProgress.Location = new Point(6, 53);
            btnStartProgress.Margin = new Padding(0);
            btnStartProgress.Name = "btnStartProgress";
            btnStartProgress.Size = new Size(306, 26);
            btnStartProgress.TabIndex = 1;
            btnStartProgress.Text = "Запустить прогрессбар";
            btnStartProgress.UseVisualStyleBackColor = true;
            btnStartProgress.Click += BtnStartProgress_Click;
            // 
            // tabPageTask2
            // 
            tabPageTask2.Controls.Add(groupBox2);
            tabPageTask2.Location = new Point(4, 22);
            tabPageTask2.Name = "tabPageTask2";
            tabPageTask2.Padding = new Padding(15);
            tabPageTask2.Size = new Size(1039, 556);
            tabPageTask2.TabIndex = 1;
            tabPageTask2.Text = "Задание 2";
            tabPageTask2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDrawTable);
            groupBox2.Controls.Add(dataGridViewMatrix);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnFillRandom);
            groupBox2.Controls.Add(btnClearMatrix);
            groupBox2.Controls.Add(lblRows);
            groupBox2.Controls.Add(btnRecalc);
            groupBox2.Controls.Add(txtRows);
            groupBox2.Controls.Add(btnSaveMatrix);
            groupBox2.Controls.Add(lblCols);
            groupBox2.Controls.Add(lblSumDiagonal);
            groupBox2.Controls.Add(txtCols);
            groupBox2.Controls.Add(lblSumRow);
            groupBox2.Controls.Add(lblSumCol);
            groupBox2.Location = new Point(18, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 302);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задание 2";
            // 
            // btnDrawTable
            // 
            btnDrawTable.BackColor = SystemColors.ControlLight;
            btnDrawTable.FlatAppearance.BorderColor = Color.Silver;
            btnDrawTable.FlatAppearance.BorderSize = 2;
            btnDrawTable.FlatStyle = FlatStyle.Flat;
            btnDrawTable.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDrawTable.Location = new Point(594, 28);
            btnDrawTable.Name = "btnDrawTable";
            btnDrawTable.Size = new Size(116, 63);
            btnDrawTable.TabIndex = 4;
            btnDrawTable.Text = "Нарисовать таблицу";
            btnDrawTable.UseVisualStyleBackColor = false;
            btnDrawTable.Click += BtnDrawTable_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(17, 28);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(356, 250);
            dataGridViewMatrix.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(555, 208);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 13;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnLoadMatrix_Click;
            // 
            // btnFillRandom
            // 
            btnFillRandom.BackColor = SystemColors.ControlLight;
            btnFillRandom.FlatAppearance.BorderColor = Color.Silver;
            btnFillRandom.FlatAppearance.BorderSize = 2;
            btnFillRandom.FlatStyle = FlatStyle.Flat;
            btnFillRandom.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnFillRandom.Location = new Point(392, 99);
            btnFillRandom.Name = "btnFillRandom";
            btnFillRandom.Size = new Size(318, 29);
            btnFillRandom.TabIndex = 5;
            btnFillRandom.Text = "Заполнить случайными числами от -10 до 10";
            btnFillRandom.UseVisualStyleBackColor = false;
            btnFillRandom.Click += BtnFillRandom_Click;
            // 
            // btnClearMatrix
            // 
            btnClearMatrix.BackColor = SystemColors.ControlLight;
            btnClearMatrix.FlatAppearance.BorderColor = Color.Silver;
            btnClearMatrix.FlatAppearance.BorderSize = 2;
            btnClearMatrix.FlatStyle = FlatStyle.Flat;
            btnClearMatrix.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClearMatrix.Location = new Point(392, 249);
            btnClearMatrix.Name = "btnClearMatrix";
            btnClearMatrix.Size = new Size(155, 29);
            btnClearMatrix.TabIndex = 12;
            btnClearMatrix.Text = "Очистить";
            btnClearMatrix.UseVisualStyleBackColor = false;
            btnClearMatrix.Click += BtnClearMatrix_Click;
            // 
            // lblRows
            // 
            lblRows.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblRows.ImageAlign = ContentAlignment.TopCenter;
            lblRows.Location = new Point(392, 33);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(125, 26);
            lblRows.TabIndex = 0;
            lblRows.Text = "Количество строк:";
            lblRows.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRecalc
            // 
            btnRecalc.BackColor = SystemColors.ControlLight;
            btnRecalc.FlatAppearance.BorderColor = Color.Silver;
            btnRecalc.FlatAppearance.BorderSize = 2;
            btnRecalc.FlatStyle = FlatStyle.Flat;
            btnRecalc.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnRecalc.Location = new Point(555, 249);
            btnRecalc.Name = "btnRecalc";
            btnRecalc.Size = new Size(155, 29);
            btnRecalc.TabIndex = 11;
            btnRecalc.Text = "Пересчитать";
            btnRecalc.UseVisualStyleBackColor = false;
            btnRecalc.Click += BtnRecalc_Click;
            // 
            // txtRows
            // 
            txtRows.BorderStyle = BorderStyle.FixedSingle;
            txtRows.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtRows.Location = new Point(523, 38);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(40, 20);
            txtRows.TabIndex = 1;
            txtRows.Text = "5";
            txtRows.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveMatrix
            // 
            btnSaveMatrix.BackColor = SystemColors.ControlLight;
            btnSaveMatrix.FlatAppearance.BorderColor = Color.Silver;
            btnSaveMatrix.FlatAppearance.BorderSize = 2;
            btnSaveMatrix.FlatStyle = FlatStyle.Flat;
            btnSaveMatrix.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSaveMatrix.Location = new Point(392, 208);
            btnSaveMatrix.Name = "btnSaveMatrix";
            btnSaveMatrix.Size = new Size(155, 29);
            btnSaveMatrix.TabIndex = 10;
            btnSaveMatrix.Text = "Сохранить";
            btnSaveMatrix.UseVisualStyleBackColor = false;
            btnSaveMatrix.Click += BtnSaveMatrix_Click;
            // 
            // lblCols
            // 
            lblCols.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblCols.Location = new Point(392, 65);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(125, 26);
            lblCols.TabIndex = 2;
            lblCols.Text = "Количество столбцов:";
            lblCols.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumDiagonal
            // 
            lblSumDiagonal.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblSumDiagonal.Location = new Point(392, 181);
            lblSumDiagonal.Name = "lblSumDiagonal";
            lblSumDiagonal.Size = new Size(318, 24);
            lblSumDiagonal.TabIndex = 9;
            lblSumDiagonal.Text = "Сумма элементов главной диагонали: 0";
            lblSumDiagonal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCols
            // 
            txtCols.BorderStyle = BorderStyle.FixedSingle;
            txtCols.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtCols.Location = new Point(523, 70);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(40, 20);
            txtCols.TabIndex = 3;
            txtCols.Text = "5";
            txtCols.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSumRow
            // 
            lblSumRow.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblSumRow.Location = new Point(392, 157);
            lblSumRow.Name = "lblSumRow";
            lblSumRow.Size = new Size(318, 24);
            lblSumRow.TabIndex = 8;
            lblSumRow.Text = "Сумма элементов первой строки: 0";
            lblSumRow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumCol
            // 
            lblSumCol.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblSumCol.Location = new Point(392, 133);
            lblSumCol.Name = "lblSumCol";
            lblSumCol.Size = new Size(318, 24);
            lblSumCol.TabIndex = 7;
            lblSumCol.Text = "Сумма элементов первого столбца: 0";
            lblSumCol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageTask3
            // 
            tabPageTask3.Controls.Add(groupBox3);
            tabPageTask3.Location = new Point(4, 22);
            tabPageTask3.Name = "tabPageTask3";
            tabPageTask3.Padding = new Padding(15);
            tabPageTask3.Size = new Size(1039, 556);
            tabPageTask3.TabIndex = 2;
            tabPageTask3.Text = "Задание 3";
            tabPageTask3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnResetShapes);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(drawingPanel);
            groupBox3.Controls.Add(pColorPreview);
            groupBox3.Controls.Add(btnChooseColor);
            groupBox3.Controls.Add(btnEditText);
            groupBox3.Controls.Add(btnPentagon);
            groupBox3.Controls.Add(btnLoadShapes);
            groupBox3.Controls.Add(btnCircle);
            groupBox3.Controls.Add(btnSaveShapes);
            groupBox3.Controls.Add(btnSquare);
            groupBox3.Controls.Add(btnText);
            groupBox3.Controls.Add(btnAllShapes);
            groupBox3.Controls.Add(btnIncrease);
            groupBox3.Controls.Add(btnDecrease);
            groupBox3.Location = new Point(18, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(546, 376);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Задание 3";
            // 
            // btnResetShapes
            // 
            btnResetShapes.BackColor = SystemColors.ControlLight;
            btnResetShapes.FlatAppearance.BorderColor = Color.Silver;
            btnResetShapes.FlatAppearance.BorderSize = 2;
            btnResetShapes.FlatStyle = FlatStyle.Flat;
            btnResetShapes.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnResetShapes.Location = new Point(146, 319);
            btnResetShapes.Name = "btnResetShapes";
            btnResetShapes.Size = new Size(90, 30);
            btnResetShapes.TabIndex = 6;
            btnResetShapes.Text = "Сброс";
            btnResetShapes.UseVisualStyleBackColor = false;
            btnResetShapes.Click += BtnResetShapes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(15, 352);
            label1.Name = "label1";
            label1.Size = new Size(303, 13);
            label1.TabIndex = 13;
            label1.Text = "Сохранение и загрузка (2 формата файлов  - XML и JSON)";
            // 
            // drawingPanel
            // 
            drawingPanel.BackColor = Color.White;
            drawingPanel.BorderStyle = BorderStyle.FixedSingle;
            drawingPanel.Location = new Point(14, 25);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(414, 288);
            drawingPanel.TabIndex = 10;
            // 
            // pColorPreview
            // 
            pColorPreview.BackColor = Color.FloralWhite;
            pColorPreview.BorderStyle = BorderStyle.FixedSingle;
            pColorPreview.Location = new Point(110, 319);
            pColorPreview.Name = "pColorPreview";
            pColorPreview.Size = new Size(30, 30);
            pColorPreview.TabIndex = 12;
            // 
            // btnChooseColor
            // 
            btnChooseColor.BackColor = SystemColors.ControlLight;
            btnChooseColor.FlatAppearance.BorderColor = Color.Silver;
            btnChooseColor.FlatStyle = FlatStyle.Flat;
            btnChooseColor.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnChooseColor.Location = new Point(14, 319);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(90, 30);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Выбрать цвет";
            btnChooseColor.UseVisualStyleBackColor = false;
            btnChooseColor.Click += BtnChooseColor_Click;
            // 
            // btnEditText
            // 
            btnEditText.BackColor = SystemColors.ControlLight;
            btnEditText.FlatAppearance.BorderColor = Color.Silver;
            btnEditText.FlatAppearance.BorderSize = 2;
            btnEditText.FlatStyle = FlatStyle.Flat;
            btnEditText.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEditText.Location = new Point(434, 87);
            btnEditText.Name = "btnEditText";
            btnEditText.Size = new Size(98, 25);
            btnEditText.TabIndex = 11;
            btnEditText.Text = "Редактировать";
            btnEditText.UseVisualStyleBackColor = false;
            btnEditText.Click += BtnEditText_Click;
            // 
            // btnPentagon
            // 
            btnPentagon.BackColor = SystemColors.ControlLight;
            btnPentagon.FlatAppearance.BorderColor = Color.Silver;
            btnPentagon.FlatAppearance.BorderSize = 2;
            btnPentagon.FlatStyle = FlatStyle.Flat;
            btnPentagon.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnPentagon.Location = new Point(434, 195);
            btnPentagon.Name = "btnPentagon";
            btnPentagon.Size = new Size(98, 25);
            btnPentagon.TabIndex = 1;
            btnPentagon.Text = "Пятиугольник";
            btnPentagon.UseVisualStyleBackColor = false;
            btnPentagon.Click += BtnPentagon_Click;
            // 
            // btnLoadShapes
            // 
            btnLoadShapes.BackColor = SystemColors.ControlLight;
            btnLoadShapes.FlatAppearance.BorderColor = Color.Silver;
            btnLoadShapes.FlatAppearance.BorderSize = 2;
            btnLoadShapes.FlatStyle = FlatStyle.Flat;
            btnLoadShapes.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnLoadShapes.Location = new Point(338, 319);
            btnLoadShapes.Name = "btnLoadShapes";
            btnLoadShapes.Size = new Size(90, 30);
            btnLoadShapes.TabIndex = 8;
            btnLoadShapes.Text = "Загрузить";
            btnLoadShapes.UseVisualStyleBackColor = false;
            btnLoadShapes.Click += BtnLoadShapes_Click;
            // 
            // btnCircle
            // 
            btnCircle.BackColor = SystemColors.ControlLight;
            btnCircle.FlatAppearance.BorderColor = Color.Silver;
            btnCircle.FlatAppearance.BorderSize = 2;
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCircle.Location = new Point(434, 226);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(98, 25);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Круг";
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += BtnCircle_Click;
            // 
            // btnSaveShapes
            // 
            btnSaveShapes.BackColor = SystemColors.ControlLight;
            btnSaveShapes.FlatAppearance.BorderColor = Color.Silver;
            btnSaveShapes.FlatAppearance.BorderSize = 2;
            btnSaveShapes.FlatStyle = FlatStyle.Flat;
            btnSaveShapes.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSaveShapes.Location = new Point(242, 319);
            btnSaveShapes.Name = "btnSaveShapes";
            btnSaveShapes.Size = new Size(90, 30);
            btnSaveShapes.TabIndex = 7;
            btnSaveShapes.Text = "Сохранить";
            btnSaveShapes.UseVisualStyleBackColor = false;
            btnSaveShapes.Click += BtnSaveShapes_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.ControlLight;
            btnSquare.FlatAppearance.BorderColor = Color.Silver;
            btnSquare.FlatAppearance.BorderSize = 2;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSquare.Location = new Point(434, 164);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(98, 25);
            btnSquare.TabIndex = 9;
            btnSquare.Text = "Квадрат";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += BtnSquare_Click;
            // 
            // btnText
            // 
            btnText.BackColor = SystemColors.ControlLight;
            btnText.FlatAppearance.BorderColor = Color.Silver;
            btnText.FlatAppearance.BorderSize = 2;
            btnText.FlatStyle = FlatStyle.Flat;
            btnText.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnText.Location = new Point(434, 257);
            btnText.Name = "btnText";
            btnText.Size = new Size(98, 25);
            btnText.TabIndex = 10;
            btnText.Text = "Текст";
            btnText.UseVisualStyleBackColor = false;
            btnText.Click += BtnText_Click;
            // 
            // btnAllShapes
            // 
            btnAllShapes.BackColor = SystemColors.ControlLight;
            btnAllShapes.FlatAppearance.BorderColor = Color.Silver;
            btnAllShapes.FlatAppearance.BorderSize = 2;
            btnAllShapes.FlatStyle = FlatStyle.Flat;
            btnAllShapes.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnAllShapes.Location = new Point(434, 288);
            btnAllShapes.Name = "btnAllShapes";
            btnAllShapes.Size = new Size(98, 25);
            btnAllShapes.TabIndex = 5;
            btnAllShapes.Text = "Все фигуры";
            btnAllShapes.UseVisualStyleBackColor = false;
            btnAllShapes.Click += BtnAllShapes_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = SystemColors.ControlLight;
            btnIncrease.FlatAppearance.BorderColor = Color.Silver;
            btnIncrease.FlatAppearance.BorderSize = 2;
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnIncrease.Location = new Point(434, 25);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(98, 25);
            btnIncrease.TabIndex = 3;
            btnIncrease.Text = "Увеличить";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += BtnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = SystemColors.ControlLight;
            btnDecrease.FlatAppearance.BorderColor = Color.Silver;
            btnDecrease.FlatAppearance.BorderSize = 2;
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDecrease.Location = new Point(434, 56);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(98, 25);
            btnDecrease.TabIndex = 4;
            btnDecrease.Text = "Уменьшить";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += BtnDecrease_Click;
            // 
            // tabPageTask4
            // 
            tabPageTask4.Controls.Add(groupBox4);
            tabPageTask4.Location = new Point(4, 22);
            tabPageTask4.Name = "tabPageTask4";
            tabPageTask4.Padding = new Padding(15);
            tabPageTask4.Size = new Size(1039, 556);
            tabPageTask4.TabIndex = 3;
            tabPageTask4.Text = "Задание 4";
            tabPageTask4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(treeView1);
            groupBox4.Controls.Add(btnClearTree);
            groupBox4.Controls.Add(btnLoadTree);
            groupBox4.Controls.Add(btnExpandChildren);
            groupBox4.Controls.Add(btnSaveTree);
            groupBox4.Controls.Add(btnCollapseChildren);
            groupBox4.Controls.Add(btnImportFromShapes);
            groupBox4.Controls.Add(btnExpandAll);
            groupBox4.Controls.Add(btnCollapseAll);
            groupBox4.Location = new Point(18, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(446, 358);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Задание 4";
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Microsoft Sans Serif", 8.25F);
            treeView1.Location = new Point(16, 30);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(275, 308);
            treeView1.TabIndex = 0;
            // 
            // btnClearTree
            // 
            btnClearTree.BackColor = SystemColors.ControlLight;
            btnClearTree.FlatAppearance.BorderColor = Color.Silver;
            btnClearTree.FlatAppearance.BorderSize = 2;
            btnClearTree.FlatStyle = FlatStyle.Flat;
            btnClearTree.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClearTree.Location = new Point(297, 313);
            btnClearTree.Name = "btnClearTree";
            btnClearTree.Size = new Size(128, 25);
            btnClearTree.TabIndex = 7;
            btnClearTree.Text = "Очистить дерево";
            btnClearTree.UseVisualStyleBackColor = false;
            btnClearTree.Click += BtnClearTree_Click;
            // 
            // btnLoadTree
            // 
            btnLoadTree.BackColor = SystemColors.ControlLight;
            btnLoadTree.FlatAppearance.BorderColor = Color.Silver;
            btnLoadTree.FlatAppearance.BorderSize = 2;
            btnLoadTree.FlatStyle = FlatStyle.Flat;
            btnLoadTree.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnLoadTree.Location = new Point(297, 30);
            btnLoadTree.Name = "btnLoadTree";
            btnLoadTree.Size = new Size(128, 25);
            btnLoadTree.TabIndex = 1;
            btnLoadTree.Text = "Загрузить журнал";
            btnLoadTree.UseVisualStyleBackColor = false;
            btnLoadTree.Click += BtnLoadTree_Click;
            // 
            // btnExpandChildren
            // 
            btnExpandChildren.BackColor = SystemColors.ControlLight;
            btnExpandChildren.FlatAppearance.BorderColor = Color.Silver;
            btnExpandChildren.FlatAppearance.BorderSize = 2;
            btnExpandChildren.FlatStyle = FlatStyle.Flat;
            btnExpandChildren.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnExpandChildren.Location = new Point(297, 229);
            btnExpandChildren.Name = "btnExpandChildren";
            btnExpandChildren.Size = new Size(128, 25);
            btnExpandChildren.TabIndex = 6;
            btnExpandChildren.Text = "Развернуть дочерние";
            btnExpandChildren.UseVisualStyleBackColor = false;
            btnExpandChildren.Click += BtnExpandChildren_Click;
            // 
            // btnSaveTree
            // 
            btnSaveTree.BackColor = SystemColors.ControlLight;
            btnSaveTree.FlatAppearance.BorderColor = Color.Silver;
            btnSaveTree.FlatAppearance.BorderSize = 2;
            btnSaveTree.FlatStyle = FlatStyle.Flat;
            btnSaveTree.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSaveTree.Location = new Point(297, 61);
            btnSaveTree.Name = "btnSaveTree";
            btnSaveTree.Size = new Size(128, 25);
            btnSaveTree.TabIndex = 2;
            btnSaveTree.Text = "Сохранить журнал";
            btnSaveTree.UseVisualStyleBackColor = false;
            btnSaveTree.Click += BtnSaveTree_Click;
            // 
            // btnCollapseChildren
            // 
            btnCollapseChildren.BackColor = SystemColors.ControlLight;
            btnCollapseChildren.FlatAppearance.BorderColor = Color.Silver;
            btnCollapseChildren.FlatAppearance.BorderSize = 2;
            btnCollapseChildren.FlatStyle = FlatStyle.Flat;
            btnCollapseChildren.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCollapseChildren.Location = new Point(297, 198);
            btnCollapseChildren.Name = "btnCollapseChildren";
            btnCollapseChildren.Size = new Size(128, 25);
            btnCollapseChildren.TabIndex = 5;
            btnCollapseChildren.Text = "Свернуть дочерние";
            btnCollapseChildren.UseVisualStyleBackColor = false;
            btnCollapseChildren.Click += BtnCollapseChildren_Click;
            // 
            // btnImportFromShapes
            // 
            btnImportFromShapes.BackColor = SystemColors.ControlLight;
            btnImportFromShapes.FlatAppearance.BorderColor = Color.Silver;
            btnImportFromShapes.FlatAppearance.BorderSize = 2;
            btnImportFromShapes.FlatStyle = FlatStyle.Flat;
            btnImportFromShapes.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnImportFromShapes.Location = new Point(297, 282);
            btnImportFromShapes.Name = "btnImportFromShapes";
            btnImportFromShapes.Size = new Size(128, 25);
            btnImportFromShapes.TabIndex = 8;
            btnImportFromShapes.Text = "Импорт из задания 3";
            btnImportFromShapes.UseVisualStyleBackColor = false;
            btnImportFromShapes.Click += BtnImportFromShapes_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.BackColor = SystemColors.ControlLight;
            btnExpandAll.FlatAppearance.BorderColor = Color.Silver;
            btnExpandAll.FlatAppearance.BorderSize = 2;
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnExpandAll.Location = new Point(297, 145);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(128, 25);
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
            btnCollapseAll.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCollapseAll.Location = new Point(297, 114);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(128, 25);
            btnCollapseAll.TabIndex = 3;
            btnCollapseAll.Text = "Свернуть все узлы";
            btnCollapseAll.UseVisualStyleBackColor = false;
            btnCollapseAll.Click += BtnCollapseAll_Click;
            // 
            // tabPageTask5
            // 
            tabPageTask5.Controls.Add(groupBox5);
            tabPageTask5.Location = new Point(4, 22);
            tabPageTask5.Name = "tabPageTask5";
            tabPageTask5.Padding = new Padding(15);
            tabPageTask5.Size = new Size(1039, 556);
            tabPageTask5.TabIndex = 4;
            tabPageTask5.Text = "Задание 5";
            tabPageTask5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Controls.Add(btnClearLog);
            groupBox5.Controls.Add(lblMessage);
            groupBox5.Controls.Add(btnSaveLog);
            groupBox5.Controls.Add(txtMessage);
            groupBox5.Controls.Add(btnLoadLog);
            groupBox5.Controls.Add(btnAddLog);
            groupBox5.Controls.Add(dataGridViewLog);
            groupBox5.Location = new Point(18, 18);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(759, 351);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Задание 5";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(22, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 20);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnClearLog
            // 
            btnClearLog.BackColor = SystemColors.ControlLight;
            btnClearLog.FlatAppearance.BorderColor = Color.Silver;
            btnClearLog.FlatAppearance.BorderSize = 2;
            btnClearLog.FlatStyle = FlatStyle.Flat;
            btnClearLog.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClearLog.Location = new Point(656, 181);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(83, 42);
            btnClearLog.TabIndex = 7;
            btnClearLog.Text = "Очистить";
            btnClearLog.UseVisualStyleBackColor = false;
            btnClearLog.Click += BtnClearLog_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMessage.Location = new Point(228, 31);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(73, 23);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Сообщение:";
            lblMessage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSaveLog
            // 
            btnSaveLog.BackColor = SystemColors.ControlLight;
            btnSaveLog.FlatAppearance.BorderColor = Color.Silver;
            btnSaveLog.FlatAppearance.BorderSize = 2;
            btnSaveLog.FlatStyle = FlatStyle.Flat;
            btnSaveLog.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSaveLog.Location = new Point(656, 126);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(83, 42);
            btnSaveLog.TabIndex = 6;
            btnSaveLog.Text = "Сохранить журнал";
            btnSaveLog.UseVisualStyleBackColor = false;
            btnSaveLog.Click += BtnSaveLog_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtMessage.Location = new Point(307, 31);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(333, 20);
            txtMessage.TabIndex = 2;
            // 
            // btnLoadLog
            // 
            btnLoadLog.BackColor = SystemColors.ControlLight;
            btnLoadLog.FlatAppearance.BorderColor = Color.Silver;
            btnLoadLog.FlatAppearance.BorderSize = 2;
            btnLoadLog.FlatStyle = FlatStyle.Flat;
            btnLoadLog.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnLoadLog.Location = new Point(656, 71);
            btnLoadLog.Name = "btnLoadLog";
            btnLoadLog.Size = new Size(83, 42);
            btnLoadLog.TabIndex = 5;
            btnLoadLog.Text = "Загрузить журнал";
            btnLoadLog.UseVisualStyleBackColor = false;
            btnLoadLog.Click += BtnLoadLog_Click;
            // 
            // btnAddLog
            // 
            btnAddLog.BackColor = SystemColors.ControlLight;
            btnAddLog.FlatAppearance.BorderColor = Color.Silver;
            btnAddLog.FlatAppearance.BorderSize = 2;
            btnAddLog.FlatStyle = FlatStyle.Flat;
            btnAddLog.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnAddLog.Location = new Point(656, 31);
            btnAddLog.Name = "btnAddLog";
            btnAddLog.Size = new Size(83, 25);
            btnAddLog.TabIndex = 3;
            btnAddLog.Text = "Добавить";
            btnAddLog.UseVisualStyleBackColor = false;
            btnAddLog.Click += BtnAddLog_Click;
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.AllowUserToAddRows = false;
            dataGridViewLog.AllowUserToDeleteRows = false;
            dataGridViewLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Columns.AddRange(new DataGridViewColumn[] { Number, Message, Time });
            dataGridViewLog.Location = new Point(22, 71);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.ReadOnly = true;
            dataGridViewLog.RowHeadersVisible = false;
            dataGridViewLog.Size = new Size(618, 265);
            dataGridViewLog.TabIndex = 4;
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
            // tabPageTask6
            // 
            tabPageTask6.Controls.Add(groupBox6);
            tabPageTask6.Location = new Point(4, 22);
            tabPageTask6.Name = "tabPageTask6";
            tabPageTask6.Padding = new Padding(15);
            tabPageTask6.Size = new Size(1039, 556);
            tabPageTask6.TabIndex = 5;
            tabPageTask6.Text = "Задание 6";
            tabPageTask6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(treeViewLS);
            groupBox6.Controls.Add(tabControlLS);
            groupBox6.Location = new Point(18, 18);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(659, 311);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Задание 6";
            // 
            // treeViewLS
            // 
            treeViewLS.Font = new Font("Microsoft Sans Serif", 8.25F);
            treeViewLS.Location = new Point(15, 28);
            treeViewLS.Name = "treeViewLS";
            treeViewLS.Size = new Size(338, 271);
            treeViewLS.TabIndex = 10;
            treeViewLS.MouseDoubleClick += TreeViewLS_MouseDoubleClick;
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
            tabControlLS.Font = new Font("Microsoft Sans Serif", 8.25F);
            tabControlLS.ItemSize = new Size(43, 21);
            tabControlLS.Location = new Point(368, 28);
            tabControlLS.Multiline = true;
            tabControlLS.Name = "tabControlLS";
            tabControlLS.SelectedIndex = 0;
            tabControlLS.Size = new Size(278, 271);
            tabControlLS.SizeMode = TabSizeMode.Fixed;
            tabControlLS.TabIndex = 11;
            tabControlLS.SelectedIndexChanged += TabControlLS_SelectedIndexChanged;
            // 
            // tabPageLS1
            // 
            tabPageLS1.Controls.Add(checkedListBoxCommandsLS1);
            tabPageLS1.Location = new Point(4, 49);
            tabPageLS1.Name = "tabPageLS1";
            tabPageLS1.Padding = new Padding(3);
            tabPageLS1.Size = new Size(270, 218);
            tabPageLS1.TabIndex = 0;
            tabPageLS1.Text = "ЛС1";
            tabPageLS1.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS1
            // 
            checkedListBoxCommandsLS1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS1.CheckOnClick = true;
            checkedListBoxCommandsLS1.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS1.FormattingEnabled = true;
            checkedListBoxCommandsLS1.IntegralHeight = false;
            checkedListBoxCommandsLS1.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS1.Location = new Point(6, 3);
            checkedListBoxCommandsLS1.Name = "checkedListBoxCommandsLS1";
            checkedListBoxCommandsLS1.Size = new Size(258, 212);
            checkedListBoxCommandsLS1.TabIndex = 14;
            checkedListBoxCommandsLS1.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS2
            // 
            tabPageLS2.Controls.Add(checkedListBoxCommandsLS2);
            tabPageLS2.Location = new Point(4, 49);
            tabPageLS2.Name = "tabPageLS2";
            tabPageLS2.Padding = new Padding(3);
            tabPageLS2.Size = new Size(270, 218);
            tabPageLS2.TabIndex = 1;
            tabPageLS2.Text = "ЛС2";
            tabPageLS2.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS2
            // 
            checkedListBoxCommandsLS2.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS2.CheckOnClick = true;
            checkedListBoxCommandsLS2.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS2.FormattingEnabled = true;
            checkedListBoxCommandsLS2.IntegralHeight = false;
            checkedListBoxCommandsLS2.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS2.Location = new Point(6, 3);
            checkedListBoxCommandsLS2.Name = "checkedListBoxCommandsLS2";
            checkedListBoxCommandsLS2.Size = new Size(258, 212);
            checkedListBoxCommandsLS2.TabIndex = 14;
            checkedListBoxCommandsLS2.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS3
            // 
            tabPageLS3.Controls.Add(checkedListBoxCommandsLS3);
            tabPageLS3.Location = new Point(4, 49);
            tabPageLS3.Name = "tabPageLS3";
            tabPageLS3.Padding = new Padding(3);
            tabPageLS3.Size = new Size(270, 218);
            tabPageLS3.TabIndex = 2;
            tabPageLS3.Text = "ЛС3";
            tabPageLS3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS3
            // 
            checkedListBoxCommandsLS3.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS3.CheckOnClick = true;
            checkedListBoxCommandsLS3.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS3.FormattingEnabled = true;
            checkedListBoxCommandsLS3.IntegralHeight = false;
            checkedListBoxCommandsLS3.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS3.Location = new Point(6, 3);
            checkedListBoxCommandsLS3.Name = "checkedListBoxCommandsLS3";
            checkedListBoxCommandsLS3.Size = new Size(258, 212);
            checkedListBoxCommandsLS3.TabIndex = 14;
            checkedListBoxCommandsLS3.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS4
            // 
            tabPageLS4.Controls.Add(checkedListBoxCommandsLS4);
            tabPageLS4.Location = new Point(4, 49);
            tabPageLS4.Name = "tabPageLS4";
            tabPageLS4.Padding = new Padding(3);
            tabPageLS4.Size = new Size(270, 218);
            tabPageLS4.TabIndex = 3;
            tabPageLS4.Text = "ЛС4";
            tabPageLS4.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS4
            // 
            checkedListBoxCommandsLS4.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS4.CheckOnClick = true;
            checkedListBoxCommandsLS4.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS4.FormattingEnabled = true;
            checkedListBoxCommandsLS4.IntegralHeight = false;
            checkedListBoxCommandsLS4.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS4.Location = new Point(6, 3);
            checkedListBoxCommandsLS4.Name = "checkedListBoxCommandsLS4";
            checkedListBoxCommandsLS4.Size = new Size(258, 212);
            checkedListBoxCommandsLS4.TabIndex = 14;
            checkedListBoxCommandsLS4.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS5
            // 
            tabPageLS5.Controls.Add(checkedListBoxCommandsLS5);
            tabPageLS5.Location = new Point(4, 49);
            tabPageLS5.Name = "tabPageLS5";
            tabPageLS5.Padding = new Padding(3);
            tabPageLS5.Size = new Size(270, 218);
            tabPageLS5.TabIndex = 4;
            tabPageLS5.Text = "ЛС5";
            tabPageLS5.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS5
            // 
            checkedListBoxCommandsLS5.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS5.CheckOnClick = true;
            checkedListBoxCommandsLS5.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS5.FormattingEnabled = true;
            checkedListBoxCommandsLS5.IntegralHeight = false;
            checkedListBoxCommandsLS5.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS5.Location = new Point(6, 3);
            checkedListBoxCommandsLS5.Name = "checkedListBoxCommandsLS5";
            checkedListBoxCommandsLS5.Size = new Size(258, 212);
            checkedListBoxCommandsLS5.TabIndex = 14;
            checkedListBoxCommandsLS5.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS6
            // 
            tabPageLS6.Controls.Add(checkedListBoxCommandsLS6);
            tabPageLS6.Location = new Point(4, 49);
            tabPageLS6.Name = "tabPageLS6";
            tabPageLS6.Padding = new Padding(3);
            tabPageLS6.Size = new Size(270, 218);
            tabPageLS6.TabIndex = 5;
            tabPageLS6.Text = "ЛС6";
            tabPageLS6.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS6
            // 
            checkedListBoxCommandsLS6.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS6.CheckOnClick = true;
            checkedListBoxCommandsLS6.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS6.FormattingEnabled = true;
            checkedListBoxCommandsLS6.IntegralHeight = false;
            checkedListBoxCommandsLS6.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS6.Location = new Point(6, 3);
            checkedListBoxCommandsLS6.Name = "checkedListBoxCommandsLS6";
            checkedListBoxCommandsLS6.Size = new Size(258, 212);
            checkedListBoxCommandsLS6.TabIndex = 14;
            checkedListBoxCommandsLS6.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS7
            // 
            tabPageLS7.Controls.Add(checkedListBoxCommandsLS7);
            tabPageLS7.Location = new Point(4, 49);
            tabPageLS7.Name = "tabPageLS7";
            tabPageLS7.Padding = new Padding(3);
            tabPageLS7.Size = new Size(270, 218);
            tabPageLS7.TabIndex = 6;
            tabPageLS7.Text = "ЛС7";
            tabPageLS7.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS7
            // 
            checkedListBoxCommandsLS7.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS7.CheckOnClick = true;
            checkedListBoxCommandsLS7.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS7.FormattingEnabled = true;
            checkedListBoxCommandsLS7.IntegralHeight = false;
            checkedListBoxCommandsLS7.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS7.Location = new Point(6, 3);
            checkedListBoxCommandsLS7.Name = "checkedListBoxCommandsLS7";
            checkedListBoxCommandsLS7.Size = new Size(258, 212);
            checkedListBoxCommandsLS7.TabIndex = 14;
            checkedListBoxCommandsLS7.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS8
            // 
            tabPageLS8.Controls.Add(checkedListBoxCommandsLS8);
            tabPageLS8.Location = new Point(4, 49);
            tabPageLS8.Name = "tabPageLS8";
            tabPageLS8.Padding = new Padding(3);
            tabPageLS8.Size = new Size(270, 218);
            tabPageLS8.TabIndex = 7;
            tabPageLS8.Text = "ЛС8";
            tabPageLS8.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS8
            // 
            checkedListBoxCommandsLS8.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS8.CheckOnClick = true;
            checkedListBoxCommandsLS8.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS8.FormattingEnabled = true;
            checkedListBoxCommandsLS8.IntegralHeight = false;
            checkedListBoxCommandsLS8.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS8.Location = new Point(6, 3);
            checkedListBoxCommandsLS8.Name = "checkedListBoxCommandsLS8";
            checkedListBoxCommandsLS8.Size = new Size(258, 212);
            checkedListBoxCommandsLS8.TabIndex = 14;
            checkedListBoxCommandsLS8.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS9
            // 
            tabPageLS9.Controls.Add(checkedListBoxCommandsLS9);
            tabPageLS9.Location = new Point(4, 49);
            tabPageLS9.Name = "tabPageLS9";
            tabPageLS9.Padding = new Padding(3);
            tabPageLS9.Size = new Size(270, 218);
            tabPageLS9.TabIndex = 8;
            tabPageLS9.Text = "ЛС9";
            tabPageLS9.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS9
            // 
            checkedListBoxCommandsLS9.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS9.CheckOnClick = true;
            checkedListBoxCommandsLS9.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS9.FormattingEnabled = true;
            checkedListBoxCommandsLS9.IntegralHeight = false;
            checkedListBoxCommandsLS9.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS9.Location = new Point(6, 3);
            checkedListBoxCommandsLS9.Name = "checkedListBoxCommandsLS9";
            checkedListBoxCommandsLS9.Size = new Size(258, 212);
            checkedListBoxCommandsLS9.TabIndex = 14;
            checkedListBoxCommandsLS9.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS10
            // 
            tabPageLS10.Controls.Add(checkedListBoxCommandsLS10);
            tabPageLS10.Location = new Point(4, 49);
            tabPageLS10.Name = "tabPageLS10";
            tabPageLS10.Padding = new Padding(3);
            tabPageLS10.Size = new Size(270, 218);
            tabPageLS10.TabIndex = 9;
            tabPageLS10.Text = "ЛС10";
            tabPageLS10.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS10
            // 
            checkedListBoxCommandsLS10.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS10.CheckOnClick = true;
            checkedListBoxCommandsLS10.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS10.FormattingEnabled = true;
            checkedListBoxCommandsLS10.IntegralHeight = false;
            checkedListBoxCommandsLS10.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS10.Location = new Point(6, 3);
            checkedListBoxCommandsLS10.Name = "checkedListBoxCommandsLS10";
            checkedListBoxCommandsLS10.Size = new Size(258, 212);
            checkedListBoxCommandsLS10.TabIndex = 14;
            checkedListBoxCommandsLS10.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS11
            // 
            tabPageLS11.Controls.Add(checkedListBoxCommandsLS11);
            tabPageLS11.Location = new Point(4, 49);
            tabPageLS11.Name = "tabPageLS11";
            tabPageLS11.Padding = new Padding(3);
            tabPageLS11.Size = new Size(270, 218);
            tabPageLS11.TabIndex = 10;
            tabPageLS11.Text = "ЛС11";
            tabPageLS11.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS11
            // 
            checkedListBoxCommandsLS11.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS11.CheckOnClick = true;
            checkedListBoxCommandsLS11.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS11.FormattingEnabled = true;
            checkedListBoxCommandsLS11.IntegralHeight = false;
            checkedListBoxCommandsLS11.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS11.Location = new Point(6, 3);
            checkedListBoxCommandsLS11.Name = "checkedListBoxCommandsLS11";
            checkedListBoxCommandsLS11.Size = new Size(258, 212);
            checkedListBoxCommandsLS11.TabIndex = 13;
            checkedListBoxCommandsLS11.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // tabPageLS12
            // 
            tabPageLS12.Controls.Add(checkedListBoxCommandsLS12);
            tabPageLS12.Location = new Point(4, 49);
            tabPageLS12.Name = "tabPageLS12";
            tabPageLS12.Padding = new Padding(3);
            tabPageLS12.Size = new Size(270, 218);
            tabPageLS12.TabIndex = 11;
            tabPageLS12.Text = "ЛС12";
            tabPageLS12.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCommandsLS12
            // 
            checkedListBoxCommandsLS12.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxCommandsLS12.CheckOnClick = true;
            checkedListBoxCommandsLS12.Font = new Font("Microsoft Sans Serif", 8.25F);
            checkedListBoxCommandsLS12.FormattingEnabled = true;
            checkedListBoxCommandsLS12.IntegralHeight = false;
            checkedListBoxCommandsLS12.Items.AddRange(new object[] { "Команда 1", "Команда 2", "Команда 3", "Команда 4", "Команда 5", "Команда 6", "Команда 7", "Команда 8", "Команда 9", "Команда 10", "Команда 11", "Команда 12", "Сигнализация", "Отключение" });
            checkedListBoxCommandsLS12.Location = new Point(6, 3);
            checkedListBoxCommandsLS12.Name = "checkedListBoxCommandsLS12";
            checkedListBoxCommandsLS12.Size = new Size(258, 212);
            checkedListBoxCommandsLS12.TabIndex = 12;
            checkedListBoxCommandsLS12.ItemCheck += CheckedListBoxCommands_ItemCheck;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.Blue;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 582);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowsFormsApp3 - Лабораторная работа";
            tabControl1.ResumeLayout(false);
            tabPageTask1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPageTask2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            tabPageTask3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPageTask4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tabPageTask5.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            tabPageTask6.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            tabControlLS.ResumeLayout(false);
            tabPageLS1.ResumeLayout(false);
            tabPageLS2.ResumeLayout(false);
            tabPageLS3.ResumeLayout(false);
            tabPageLS4.ResumeLayout(false);
            tabPageLS5.ResumeLayout(false);
            tabPageLS6.ResumeLayout(false);
            tabPageLS7.ResumeLayout(false);
            tabPageLS8.ResumeLayout(false);
            tabPageLS9.ResumeLayout(false);
            tabPageLS10.ResumeLayout(false);
            tabPageLS11.ResumeLayout(false);
            tabPageLS12.ResumeLayout(false);
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
        private CheckedListBox checkedListBoxCommandsLS12;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TabPage tabPageLS1;
        private TabPage tabPageLS2;
        private CheckedListBox checkedListBoxCommandsLS11;
        private CheckedListBox checkedListBoxCommandsLS1;
        private CheckedListBox checkedListBoxCommandsLS2;
        private CheckedListBox checkedListBoxCommandsLS3;
        private CheckedListBox checkedListBoxCommandsLS4;
        private CheckedListBox checkedListBoxCommandsLS5;
        private CheckedListBox checkedListBoxCommandsLS6;
        private CheckedListBox checkedListBoxCommandsLS7;
        private CheckedListBox checkedListBoxCommandsLS8;
        private CheckedListBox checkedListBoxCommandsLS9;
        private CheckedListBox checkedListBoxCommandsLS10;
    }
}