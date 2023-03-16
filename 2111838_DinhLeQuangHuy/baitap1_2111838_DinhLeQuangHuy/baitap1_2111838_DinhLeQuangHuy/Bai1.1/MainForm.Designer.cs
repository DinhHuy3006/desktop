namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDNu = new System.Windows.Forms.RadioButton();
            this.RDNam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RDXanh = new System.Windows.Forms.RadioButton();
            this.RDDO = new System.Windows.Forms.RadioButton();
            this.TxtHopMau = new System.Windows.Forms.TextBox();
            this.BtnToMau = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDNu);
            this.groupBox1.Controls.Add(this.RDNam);
            this.groupBox1.Location = new System.Drawing.Point(156, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // RDNu
            // 
            this.RDNu.AutoSize = true;
            this.RDNu.Location = new System.Drawing.Point(35, 53);
            this.RDNu.Name = "RDNu";
            this.RDNu.Size = new System.Drawing.Size(39, 17);
            this.RDNu.TabIndex = 1;
            this.RDNu.TabStop = true;
            this.RDNu.Text = "Nữ";
            this.RDNu.UseVisualStyleBackColor = true;
            this.RDNu.CheckedChanged += new System.EventHandler(this.RDNu_CheckedChanged);
            // 
            // RDNam
            // 
            this.RDNam.AutoSize = true;
            this.RDNam.Checked = true;
            this.RDNam.Location = new System.Drawing.Point(35, 19);
            this.RDNam.Name = "RDNam";
            this.RDNam.Size = new System.Drawing.Size(47, 17);
            this.RDNam.TabIndex = 1;
            this.RDNam.TabStop = true;
            this.RDNam.Text = "Nam";
            this.RDNam.UseVisualStyleBackColor = true;
            this.RDNam.CheckedChanged += new System.EventHandler(this.RDNam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnToMau);
            this.groupBox2.Controls.Add(this.TxtHopMau);
            this.groupBox2.Controls.Add(this.RDXanh);
            this.groupBox2.Controls.Add(this.RDDO);
            this.groupBox2.Location = new System.Drawing.Point(156, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Màu";
            // 
            // RDXanh
            // 
            this.RDXanh.AutoSize = true;
            this.RDXanh.Location = new System.Drawing.Point(35, 53);
            this.RDXanh.Name = "RDXanh";
            this.RDXanh.Size = new System.Drawing.Size(50, 17);
            this.RDXanh.TabIndex = 1;
            this.RDXanh.TabStop = true;
            this.RDXanh.Text = "Xanh";
            this.RDXanh.UseVisualStyleBackColor = true;
            this.RDXanh.CheckedChanged += new System.EventHandler(this.RDNu_CheckedChanged);
            // 
            // RDDO
            // 
            this.RDDO.AutoSize = true;
            this.RDDO.Checked = true;
            this.RDDO.Location = new System.Drawing.Point(35, 19);
            this.RDDO.Name = "RDDO";
            this.RDDO.Size = new System.Drawing.Size(41, 17);
            this.RDDO.TabIndex = 1;
            this.RDDO.TabStop = true;
            this.RDDO.Text = "DO";
            this.RDDO.UseVisualStyleBackColor = true;
            this.RDDO.CheckedChanged += new System.EventHandler(this.RDNam_CheckedChanged);
            // 
            // TxtHopMau
            // 
            this.TxtHopMau.Location = new System.Drawing.Point(194, 36);
            this.TxtHopMau.Multiline = true;
            this.TxtHopMau.Name = "TxtHopMau";
            this.TxtHopMau.ReadOnly = true;
            this.TxtHopMau.Size = new System.Drawing.Size(130, 20);
            this.TxtHopMau.TabIndex = 2;
            // 
            // BtnToMau
            // 
            this.BtnToMau.Location = new System.Drawing.Point(91, 33);
            this.BtnToMau.Name = "BtnToMau";
            this.BtnToMau.Size = new System.Drawing.Size(75, 23);
            this.BtnToMau.TabIndex = 3;
            this.BtnToMau.Text = "Tô Màu";
            this.BtnToMau.UseVisualStyleBackColor = true;
            this.BtnToMau.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài Tập 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDNu;
        private System.Windows.Forms.RadioButton RDNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnToMau;
        private System.Windows.Forms.TextBox TxtHopMau;
        private System.Windows.Forms.RadioButton RDXanh;
        private System.Windows.Forms.RadioButton RDDO;
    }
}

