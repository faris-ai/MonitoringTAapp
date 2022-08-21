namespace MonitoringTAapp
{
    partial class RecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecForm));
            this.labelJ = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.namaMhsCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.namaDsnCB = new System.Windows.Forms.ComboBox();
            this.uraiTB = new System.Windows.Forms.TextBox();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.refUBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJ
            // 
            this.labelJ.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ.ForeColor = System.Drawing.Color.White;
            this.labelJ.Location = new System.Drawing.Point(0, 5);
            this.labelJ.Name = "labelJ";
            this.labelJ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelJ.Size = new System.Drawing.Size(711, 42);
            this.labelJ.TabIndex = 1;
            this.labelJ.Text = "Tambah Record Bimbingan";
            this.labelJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(542, 420);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 41);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbimDateTimePicker
            // 
            this.tbimDateTimePicker.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbimDateTimePicker.Location = new System.Drawing.Point(329, 223);
            this.tbimDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.tbimDateTimePicker.Name = "tbimDateTimePicker";
            this.tbimDateTimePicker.Size = new System.Drawing.Size(321, 28);
            this.tbimDateTimePicker.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Uraian";
            // 
            // namaMhsCB
            // 
            this.namaMhsCB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaMhsCB.FormattingEnabled = true;
            this.namaMhsCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.namaMhsCB.Location = new System.Drawing.Point(329, 90);
            this.namaMhsCB.Name = "namaMhsCB";
            this.namaMhsCB.Size = new System.Drawing.Size(321, 28);
            this.namaMhsCB.TabIndex = 18;
            this.namaMhsCB.TextChanged += new System.EventHandler(this.namaMhsCB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tanggal Bimbingan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama Dosen Pembimbing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.labelJ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 52);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(658, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(53, 52);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // namaDsnCB
            // 
            this.namaDsnCB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDsnCB.FormattingEnabled = true;
            this.namaDsnCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.namaDsnCB.Location = new System.Drawing.Point(329, 157);
            this.namaDsnCB.Name = "namaDsnCB";
            this.namaDsnCB.Size = new System.Drawing.Size(321, 28);
            this.namaDsnCB.TabIndex = 24;
            // 
            // uraiTB
            // 
            this.uraiTB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uraiTB.Location = new System.Drawing.Point(329, 293);
            this.uraiTB.Multiline = true;
            this.uraiTB.Name = "uraiTB";
            this.uraiTB.Size = new System.Drawing.Size(247, 78);
            this.uraiTB.TabIndex = 25;
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.hapusBtn.FlatAppearance.BorderSize = 0;
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.Color.White;
            this.hapusBtn.Location = new System.Drawing.Point(269, 420);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(108, 41);
            this.hapusBtn.TabIndex = 33;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Visible = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(406, 420);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(108, 41);
            this.editBtn.TabIndex = 32;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // refUBtn
            // 
            this.refUBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refUBtn.FlatAppearance.BorderSize = 0;
            this.refUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refUBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refUBtn.ForeColor = System.Drawing.Color.White;
            this.refUBtn.Location = new System.Drawing.Point(582, 293);
            this.refUBtn.Name = "refUBtn";
            this.refUBtn.Size = new System.Drawing.Size(53, 47);
            this.refUBtn.TabIndex = 34;
            this.refUBtn.Text = "<";
            this.refUBtn.UseVisualStyleBackColor = false;
            this.refUBtn.Click += new System.EventHandler(this.refUBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Image = global::MonitoringTAapp.Properties.Resources.images;
            this.viewBtn.Location = new System.Drawing.Point(657, 85);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(41, 37);
            this.viewBtn.TabIndex = 35;
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Visible = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // RecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 507);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.refUBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.uraiTB);
            this.Controls.Add(this.namaDsnCB);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tbimDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namaMhsCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Record Bimbingan";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJ;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker tbimDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox namaMhsCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox namaDsnCB;
        private System.Windows.Forms.TextBox uraiTB;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button refUBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}