namespace MonitoringTAapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rPanel = new System.Windows.Forms.Panel();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.activePan = new System.Windows.Forms.Panel();
            this.monitoringTADataSet = new MonitoringTAapp.MonitoringTADataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mPanel = new System.Windows.Forms.Panel();
            this.mahasiswaDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.taPanel = new System.Windows.Forms.Panel();
            this.taDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dPanel = new System.Windows.Forms.Panel();
            this.dosenDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.searchTaTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchMhsTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchRecBT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchDsnTB = new System.Windows.Forms.TextBox();
            this.saveDsnPdfBtn = new System.Windows.Forms.Button();
            this.saveDsnExBtn = new System.Windows.Forms.Button();
            this.saveTaExBtn = new System.Windows.Forms.Button();
            this.saveTaPdfBtn = new System.Windows.Forms.Button();
            this.saveMhsExBtn = new System.Windows.Forms.Button();
            this.saveMhsPdfBtn = new System.Windows.Forms.Button();
            this.saveRecExBtn = new System.Windows.Forms.Button();
            this.saveRecPdfBtn = new System.Windows.Forms.Button();
            this.dosenBtn = new System.Windows.Forms.Button();
            this.taBtn = new System.Windows.Forms.Button();
            this.mahasiswaBtn = new System.Windows.Forms.Button();
            this.recordBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tambahMhsBtn = new System.Windows.Forms.Button();
            this.tambahRecBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringTADataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataGridView)).BeginInit();
            this.taPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taDataGridView)).BeginInit();
            this.dPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 72);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(884, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(71, 72);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.minimizeBtn);
            this.panel5.Controls.Add(this.closeBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 37);
            this.panel5.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(36, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 37);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Monitoring Tugas Akhir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dosenBtn);
            this.panel2.Controls.Add(this.taBtn);
            this.panel2.Controls.Add(this.mahasiswaBtn);
            this.panel2.Controls.Add(this.recordBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 444);
            this.panel2.TabIndex = 1;
            // 
            // rPanel
            // 
            this.rPanel.Controls.Add(this.saveRecExBtn);
            this.rPanel.Controls.Add(this.saveRecPdfBtn);
            this.rPanel.Controls.Add(this.label10);
            this.rPanel.Controls.Add(this.searchRecBT);
            this.rPanel.Controls.Add(this.tambahRecBtn);
            this.rPanel.Controls.Add(this.recordDataGridView);
            this.rPanel.Controls.Add(this.label5);
            this.rPanel.Location = new System.Drawing.Point(129, 72);
            this.rPanel.Name = "rPanel";
            this.rPanel.Size = new System.Drawing.Size(826, 444);
            this.rPanel.TabIndex = 2;
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.AllowUserToAddRows = false;
            this.recordDataGridView.AllowUserToDeleteRows = false;
            this.recordDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordDataGridView.Location = new System.Drawing.Point(47, 73);
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.ReadOnly = true;
            this.recordDataGridView.RowHeadersVisible = false;
            this.recordDataGridView.RowTemplate.Height = 24;
            this.recordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordDataGridView.Size = new System.Drawing.Size(749, 219);
            this.recordDataGridView.TabIndex = 6;
            this.recordDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordDataGridView_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(821, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Record Monitoring Tugas Akhir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // activePan
            // 
            this.activePan.BackColor = System.Drawing.Color.LightSlateGray;
            this.activePan.Location = new System.Drawing.Point(0, 0);
            this.activePan.Name = "activePan";
            this.activePan.Size = new System.Drawing.Size(5, 73);
            this.activePan.TabIndex = 1;
            // 
            // monitoringTADataSet
            // 
            this.monitoringTADataSet.DataSetName = "MonitoringTADataSet";
            this.monitoringTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.activePan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(123, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 444);
            this.panel3.TabIndex = 3;
            // 
            // mPanel
            // 
            this.mPanel.Controls.Add(this.saveMhsExBtn);
            this.mPanel.Controls.Add(this.saveMhsPdfBtn);
            this.mPanel.Controls.Add(this.label9);
            this.mPanel.Controls.Add(this.searchMhsTB);
            this.mPanel.Controls.Add(this.tambahMhsBtn);
            this.mPanel.Controls.Add(this.mahasiswaDataGridView);
            this.mPanel.Controls.Add(this.label4);
            this.mPanel.Location = new System.Drawing.Point(134, 72);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(821, 444);
            this.mPanel.TabIndex = 4;
            // 
            // mahasiswaDataGridView
            // 
            this.mahasiswaDataGridView.AllowUserToAddRows = false;
            this.mahasiswaDataGridView.AllowUserToDeleteRows = false;
            this.mahasiswaDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mahasiswaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mahasiswaDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.mahasiswaDataGridView.Location = new System.Drawing.Point(42, 73);
            this.mahasiswaDataGridView.Name = "mahasiswaDataGridView";
            this.mahasiswaDataGridView.ReadOnly = true;
            this.mahasiswaDataGridView.RowHeadersVisible = false;
            this.mahasiswaDataGridView.RowTemplate.Height = 24;
            this.mahasiswaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mahasiswaDataGridView.Size = new System.Drawing.Size(749, 219);
            this.mahasiswaDataGridView.TabIndex = 6;
            this.mahasiswaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mahasiswaDataGridView_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Mahasiswa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taPanel
            // 
            this.taPanel.Controls.Add(this.saveTaExBtn);
            this.taPanel.Controls.Add(this.saveTaPdfBtn);
            this.taPanel.Controls.Add(this.label8);
            this.taPanel.Controls.Add(this.searchTaTB);
            this.taPanel.Controls.Add(this.tambahBtn);
            this.taPanel.Controls.Add(this.taDataGridView);
            this.taPanel.Controls.Add(this.label6);
            this.taPanel.Location = new System.Drawing.Point(134, 72);
            this.taPanel.Name = "taPanel";
            this.taPanel.Size = new System.Drawing.Size(821, 444);
            this.taPanel.TabIndex = 5;
            // 
            // taDataGridView
            // 
            this.taDataGridView.AllowUserToAddRows = false;
            this.taDataGridView.AllowUserToDeleteRows = false;
            this.taDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.taDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.taDataGridView.Location = new System.Drawing.Point(42, 73);
            this.taDataGridView.Name = "taDataGridView";
            this.taDataGridView.ReadOnly = true;
            this.taDataGridView.RowHeadersVisible = false;
            this.taDataGridView.RowTemplate.Height = 24;
            this.taDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taDataGridView.Size = new System.Drawing.Size(749, 219);
            this.taDataGridView.TabIndex = 7;
            this.taDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taDataGridView_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(0, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(821, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data Tugas Akhir";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dPanel
            // 
            this.dPanel.Controls.Add(this.saveDsnExBtn);
            this.dPanel.Controls.Add(this.saveDsnPdfBtn);
            this.dPanel.Controls.Add(this.label11);
            this.dPanel.Controls.Add(this.searchDsnTB);
            this.dPanel.Controls.Add(this.dosenDataGridView);
            this.dPanel.Controls.Add(this.label7);
            this.dPanel.Location = new System.Drawing.Point(134, 72);
            this.dPanel.Name = "dPanel";
            this.dPanel.Size = new System.Drawing.Size(821, 444);
            this.dPanel.TabIndex = 6;
            // 
            // dosenDataGridView
            // 
            this.dosenDataGridView.AllowUserToAddRows = false;
            this.dosenDataGridView.AllowUserToDeleteRows = false;
            this.dosenDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dosenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dosenDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dosenDataGridView.Location = new System.Drawing.Point(42, 73);
            this.dosenDataGridView.Name = "dosenDataGridView";
            this.dosenDataGridView.ReadOnly = true;
            this.dosenDataGridView.RowHeadersVisible = false;
            this.dosenDataGridView.RowTemplate.Height = 24;
            this.dosenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dosenDataGridView.Size = new System.Drawing.Size(749, 219);
            this.dosenDataGridView.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(0, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(821, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Dosen";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchTaTB
            // 
            this.searchTaTB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTaTB.Location = new System.Drawing.Point(84, 322);
            this.searchTaTB.Name = "searchTaTB";
            this.searchTaTB.Size = new System.Drawing.Size(208, 28);
            this.searchTaTB.TabIndex = 9;
            this.searchTaTB.TextChanged += new System.EventHandler(this.searchTaTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(47, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cari";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(47, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cari";
            // 
            // searchMhsTB
            // 
            this.searchMhsTB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMhsTB.Location = new System.Drawing.Point(84, 322);
            this.searchMhsTB.Name = "searchMhsTB";
            this.searchMhsTB.Size = new System.Drawing.Size(208, 28);
            this.searchMhsTB.TabIndex = 11;
            this.searchMhsTB.TextChanged += new System.EventHandler(this.searchMhsTB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(52, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cari";
            // 
            // searchRecBT
            // 
            this.searchRecBT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRecBT.Location = new System.Drawing.Point(89, 322);
            this.searchRecBT.Name = "searchRecBT";
            this.searchRecBT.Size = new System.Drawing.Size(208, 28);
            this.searchRecBT.TabIndex = 13;
            this.searchRecBT.TextChanged += new System.EventHandler(this.searchRecBT_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(47, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cari";
            // 
            // searchDsnTB
            // 
            this.searchDsnTB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDsnTB.Location = new System.Drawing.Point(84, 322);
            this.searchDsnTB.Name = "searchDsnTB";
            this.searchDsnTB.Size = new System.Drawing.Size(208, 28);
            this.searchDsnTB.TabIndex = 15;
            this.searchDsnTB.TextChanged += new System.EventHandler(this.searchDsnTB_TextChanged);
            // 
            // saveDsnPdfBtn
            // 
            this.saveDsnPdfBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveDsnPdfBtn.FlatAppearance.BorderSize = 0;
            this.saveDsnPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDsnPdfBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDsnPdfBtn.ForeColor = System.Drawing.Color.White;
            this.saveDsnPdfBtn.Location = new System.Drawing.Point(561, 328);
            this.saveDsnPdfBtn.Name = "saveDsnPdfBtn";
            this.saveDsnPdfBtn.Size = new System.Drawing.Size(126, 38);
            this.saveDsnPdfBtn.TabIndex = 17;
            this.saveDsnPdfBtn.Text = "Save PDF";
            this.saveDsnPdfBtn.UseVisualStyleBackColor = false;
            this.saveDsnPdfBtn.Click += new System.EventHandler(this.savePdfBtn_Click);
            // 
            // saveDsnExBtn
            // 
            this.saveDsnExBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveDsnExBtn.FlatAppearance.BorderSize = 0;
            this.saveDsnExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDsnExBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDsnExBtn.ForeColor = System.Drawing.Color.White;
            this.saveDsnExBtn.Location = new System.Drawing.Point(406, 328);
            this.saveDsnExBtn.Name = "saveDsnExBtn";
            this.saveDsnExBtn.Size = new System.Drawing.Size(126, 38);
            this.saveDsnExBtn.TabIndex = 18;
            this.saveDsnExBtn.Text = "Save Excel";
            this.saveDsnExBtn.UseVisualStyleBackColor = false;
            this.saveDsnExBtn.Click += new System.EventHandler(this.saveDsnExBtn_Click);
            // 
            // saveTaExBtn
            // 
            this.saveTaExBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveTaExBtn.FlatAppearance.BorderSize = 0;
            this.saveTaExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTaExBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaExBtn.ForeColor = System.Drawing.Color.White;
            this.saveTaExBtn.Location = new System.Drawing.Point(406, 328);
            this.saveTaExBtn.Name = "saveTaExBtn";
            this.saveTaExBtn.Size = new System.Drawing.Size(126, 38);
            this.saveTaExBtn.TabIndex = 20;
            this.saveTaExBtn.Text = "Save Excel";
            this.saveTaExBtn.UseVisualStyleBackColor = false;
            this.saveTaExBtn.Click += new System.EventHandler(this.saveTaExBtn_Click);
            // 
            // saveTaPdfBtn
            // 
            this.saveTaPdfBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveTaPdfBtn.FlatAppearance.BorderSize = 0;
            this.saveTaPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTaPdfBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaPdfBtn.ForeColor = System.Drawing.Color.White;
            this.saveTaPdfBtn.Location = new System.Drawing.Point(561, 328);
            this.saveTaPdfBtn.Name = "saveTaPdfBtn";
            this.saveTaPdfBtn.Size = new System.Drawing.Size(126, 38);
            this.saveTaPdfBtn.TabIndex = 19;
            this.saveTaPdfBtn.Text = "Save PDF";
            this.saveTaPdfBtn.UseVisualStyleBackColor = false;
            this.saveTaPdfBtn.Click += new System.EventHandler(this.saveTaPdfBtn_Click);
            // 
            // saveMhsExBtn
            // 
            this.saveMhsExBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveMhsExBtn.FlatAppearance.BorderSize = 0;
            this.saveMhsExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMhsExBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMhsExBtn.ForeColor = System.Drawing.Color.White;
            this.saveMhsExBtn.Location = new System.Drawing.Point(406, 328);
            this.saveMhsExBtn.Name = "saveMhsExBtn";
            this.saveMhsExBtn.Size = new System.Drawing.Size(126, 38);
            this.saveMhsExBtn.TabIndex = 22;
            this.saveMhsExBtn.Text = "Save Excel";
            this.saveMhsExBtn.UseVisualStyleBackColor = false;
            this.saveMhsExBtn.Click += new System.EventHandler(this.saveMhsExBtn_Click);
            // 
            // saveMhsPdfBtn
            // 
            this.saveMhsPdfBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveMhsPdfBtn.FlatAppearance.BorderSize = 0;
            this.saveMhsPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMhsPdfBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMhsPdfBtn.ForeColor = System.Drawing.Color.White;
            this.saveMhsPdfBtn.Location = new System.Drawing.Point(561, 328);
            this.saveMhsPdfBtn.Name = "saveMhsPdfBtn";
            this.saveMhsPdfBtn.Size = new System.Drawing.Size(126, 38);
            this.saveMhsPdfBtn.TabIndex = 21;
            this.saveMhsPdfBtn.Text = "Save PDF";
            this.saveMhsPdfBtn.UseVisualStyleBackColor = false;
            this.saveMhsPdfBtn.Click += new System.EventHandler(this.saveMhsPdfBtn_Click);
            // 
            // saveRecExBtn
            // 
            this.saveRecExBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveRecExBtn.FlatAppearance.BorderSize = 0;
            this.saveRecExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRecExBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRecExBtn.ForeColor = System.Drawing.Color.White;
            this.saveRecExBtn.Location = new System.Drawing.Point(411, 328);
            this.saveRecExBtn.Name = "saveRecExBtn";
            this.saveRecExBtn.Size = new System.Drawing.Size(126, 38);
            this.saveRecExBtn.TabIndex = 22;
            this.saveRecExBtn.Text = "Save Excel";
            this.saveRecExBtn.UseVisualStyleBackColor = false;
            this.saveRecExBtn.Click += new System.EventHandler(this.saveRecExBtn_Click);
            // 
            // saveRecPdfBtn
            // 
            this.saveRecPdfBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveRecPdfBtn.FlatAppearance.BorderSize = 0;
            this.saveRecPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRecPdfBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRecPdfBtn.ForeColor = System.Drawing.Color.White;
            this.saveRecPdfBtn.Location = new System.Drawing.Point(566, 328);
            this.saveRecPdfBtn.Name = "saveRecPdfBtn";
            this.saveRecPdfBtn.Size = new System.Drawing.Size(126, 38);
            this.saveRecPdfBtn.TabIndex = 21;
            this.saveRecPdfBtn.Text = "Save PDF";
            this.saveRecPdfBtn.UseVisualStyleBackColor = false;
            this.saveRecPdfBtn.Click += new System.EventHandler(this.saveRecPdfBtn_Click);
            // 
            // dosenBtn
            // 
            this.dosenBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dosenBtn.FlatAppearance.BorderSize = 0;
            this.dosenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosenBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosenBtn.ForeColor = System.Drawing.Color.White;
            this.dosenBtn.Image = global::MonitoringTAapp.Properties.Resources._448c70149d;
            this.dosenBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dosenBtn.Location = new System.Drawing.Point(0, 219);
            this.dosenBtn.Name = "dosenBtn";
            this.dosenBtn.Size = new System.Drawing.Size(123, 73);
            this.dosenBtn.TabIndex = 1;
            this.dosenBtn.Text = "Dosen";
            this.dosenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.dosenBtn.UseVisualStyleBackColor = true;
            this.dosenBtn.Click += new System.EventHandler(this.dosenBtn_Click);
            // 
            // taBtn
            // 
            this.taBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.taBtn.FlatAppearance.BorderSize = 0;
            this.taBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taBtn.ForeColor = System.Drawing.Color.White;
            this.taBtn.Image = global::MonitoringTAapp.Properties.Resources.paper_icon_256;
            this.taBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.taBtn.Location = new System.Drawing.Point(0, 146);
            this.taBtn.Name = "taBtn";
            this.taBtn.Size = new System.Drawing.Size(123, 73);
            this.taBtn.TabIndex = 1;
            this.taBtn.Text = "Tugas Akhir";
            this.taBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.taBtn.UseVisualStyleBackColor = true;
            this.taBtn.Click += new System.EventHandler(this.taBtn_Click);
            // 
            // mahasiswaBtn
            // 
            this.mahasiswaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mahasiswaBtn.FlatAppearance.BorderSize = 0;
            this.mahasiswaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mahasiswaBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahasiswaBtn.ForeColor = System.Drawing.Color.White;
            this.mahasiswaBtn.Image = global::MonitoringTAapp.Properties.Resources.student;
            this.mahasiswaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mahasiswaBtn.Location = new System.Drawing.Point(0, 73);
            this.mahasiswaBtn.Name = "mahasiswaBtn";
            this.mahasiswaBtn.Size = new System.Drawing.Size(123, 73);
            this.mahasiswaBtn.TabIndex = 1;
            this.mahasiswaBtn.Text = "Mahasiswa";
            this.mahasiswaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mahasiswaBtn.UseVisualStyleBackColor = true;
            this.mahasiswaBtn.Click += new System.EventHandler(this.mahasiswaBtn_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordBtn.FlatAppearance.BorderSize = 0;
            this.recordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordBtn.ForeColor = System.Drawing.Color.White;
            this.recordBtn.Image = global::MonitoringTAapp.Properties.Resources._as;
            this.recordBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recordBtn.Location = new System.Drawing.Point(0, 0);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(123, 73);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record";
            this.recordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MonitoringTAapp.Properties.Resources.logpr;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // tambahMhsBtn
            // 
            this.tambahMhsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tambahMhsBtn.FlatAppearance.BorderSize = 0;
            this.tambahMhsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahMhsBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahMhsBtn.ForeColor = System.Drawing.Color.White;
            this.tambahMhsBtn.Image = global::MonitoringTAapp.Properties.Resources._47883;
            this.tambahMhsBtn.Location = new System.Drawing.Point(722, 322);
            this.tambahMhsBtn.Name = "tambahMhsBtn";
            this.tambahMhsBtn.Size = new System.Drawing.Size(69, 54);
            this.tambahMhsBtn.TabIndex = 9;
            this.tambahMhsBtn.UseVisualStyleBackColor = false;
            this.tambahMhsBtn.Click += new System.EventHandler(this.tambahMhsBtn_Click);
            // 
            // tambahRecBtn
            // 
            this.tambahRecBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tambahRecBtn.FlatAppearance.BorderSize = 0;
            this.tambahRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahRecBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahRecBtn.ForeColor = System.Drawing.Color.White;
            this.tambahRecBtn.Image = global::MonitoringTAapp.Properties.Resources.Document_doc_file_paper_report_add_new_512;
            this.tambahRecBtn.Location = new System.Drawing.Point(727, 322);
            this.tambahRecBtn.Name = "tambahRecBtn";
            this.tambahRecBtn.Size = new System.Drawing.Size(69, 54);
            this.tambahRecBtn.TabIndex = 10;
            this.tambahRecBtn.UseVisualStyleBackColor = false;
            this.tambahRecBtn.Click += new System.EventHandler(this.tambahRecBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tambahBtn.FlatAppearance.BorderSize = 0;
            this.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBtn.ForeColor = System.Drawing.Color.White;
            this.tambahBtn.Image = global::MonitoringTAapp.Properties.Resources._51862_add_file;
            this.tambahBtn.Location = new System.Drawing.Point(722, 322);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(69, 54);
            this.tambahBtn.TabIndex = 8;
            this.tambahBtn.UseVisualStyleBackColor = false;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(0, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(36, 37);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(955, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.rPanel);
            this.Controls.Add(this.dPanel);
            this.Controls.Add(this.taPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Monitoring Tugas Akhir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rPanel.ResumeLayout(false);
            this.rPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringTADataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataGridView)).EndInit();
            this.taPanel.ResumeLayout(false);
            this.taPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taDataGridView)).EndInit();
            this.dPanel.ResumeLayout(false);
            this.dPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rPanel;
        private System.Windows.Forms.Button dosenBtn;
        private System.Windows.Forms.Button taBtn;
        private System.Windows.Forms.Button mahasiswaBtn;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button closeBtn;
        private MonitoringTADataSet monitoringTADataSet;
        private System.Windows.Forms.Panel activePan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel taPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel dPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dosenDataGridView;
        private System.Windows.Forms.DataGridView recordDataGridView;
        private System.Windows.Forms.DataGridView mahasiswaDataGridView;
        private System.Windows.Forms.DataGridView taDataGridView;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Button tambahMhsBtn;
        private System.Windows.Forms.Button tambahRecBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTaTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchMhsTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchRecBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchDsnTB;
        private System.Windows.Forms.Button saveDsnPdfBtn;
        private System.Windows.Forms.Button saveDsnExBtn;
        private System.Windows.Forms.Button saveMhsExBtn;
        private System.Windows.Forms.Button saveMhsPdfBtn;
        private System.Windows.Forms.Button saveTaExBtn;
        private System.Windows.Forms.Button saveTaPdfBtn;
        private System.Windows.Forms.Button saveRecExBtn;
        private System.Windows.Forms.Button saveRecPdfBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizeBtn;
    }
}

