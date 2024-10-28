namespace Caesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCaesar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCaesar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDichCaesar = new System.Windows.Forms.Button();
            this.btnChuyenCaesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKeyCaesar = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVigenere = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaVigenere = new System.Windows.Forms.TextBox();
            this.btnDichVigenere = new System.Windows.Forms.Button();
            this.btnChuyenVigenere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyVegenere = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaesar
            // 
            this.txtCaesar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaesar.Location = new System.Drawing.Point(21, 28);
            this.txtCaesar.Multiline = true;
            this.txtCaesar.Name = "txtCaesar";
            this.txtCaesar.Size = new System.Drawing.Size(315, 216);
            this.txtCaesar.TabIndex = 0;
            this.txtCaesar.Text = "HELLOWORLD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCaesar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 267);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Văn bản";
            // 
            // txtMaCaesar
            // 
            this.txtMaCaesar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaCaesar.Location = new System.Drawing.Point(26, 41);
            this.txtMaCaesar.Multiline = true;
            this.txtMaCaesar.Name = "txtMaCaesar";
            this.txtMaCaesar.Size = new System.Drawing.Size(300, 203);
            this.txtMaCaesar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaCaesar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(504, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 264);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Văn bản mã hóa";
            // 
            // BtnDichCaesar
            // 
            this.BtnDichCaesar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDichCaesar.Image")));
            this.BtnDichCaesar.Location = new System.Drawing.Point(389, 192);
            this.BtnDichCaesar.Name = "BtnDichCaesar";
            this.BtnDichCaesar.Size = new System.Drawing.Size(84, 42);
            this.BtnDichCaesar.TabIndex = 11;
            this.BtnDichCaesar.UseVisualStyleBackColor = true;
            this.BtnDichCaesar.Click += new System.EventHandler(this.BtnDichCaesar_Click_1);
            // 
            // btnChuyenCaesar
            // 
            this.btnChuyenCaesar.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenCaesar.Image")));
            this.btnChuyenCaesar.Location = new System.Drawing.Point(389, 127);
            this.btnChuyenCaesar.Name = "btnChuyenCaesar";
            this.btnChuyenCaesar.Size = new System.Drawing.Size(84, 43);
            this.btnChuyenCaesar.TabIndex = 12;
            this.btnChuyenCaesar.UseVisualStyleBackColor = true;
            this.btnChuyenCaesar.Click += new System.EventHandler(this.btnChuyenCaesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key";
            // 
            // cbxKeyCaesar
            // 
            this.cbxKeyCaesar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxKeyCaesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKeyCaesar.FormattingEnabled = true;
            this.cbxKeyCaesar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbxKeyCaesar.Location = new System.Drawing.Point(412, 45);
            this.cbxKeyCaesar.Name = "cbxKeyCaesar";
            this.cbxKeyCaesar.Size = new System.Drawing.Size(44, 26);
            this.cbxKeyCaesar.TabIndex = 14;
            this.cbxKeyCaesar.Text = "3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVigenere);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 264);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Văn bản";
            // 
            // txtVigenere
            // 
            this.txtVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVigenere.Location = new System.Drawing.Point(21, 28);
            this.txtVigenere.Multiline = true;
            this.txtVigenere.Name = "txtVigenere";
            this.txtVigenere.Size = new System.Drawing.Size(315, 216);
            this.txtVigenere.TabIndex = 0;
            this.txtVigenere.Text = "HELLOWORLD";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaVigenere);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(504, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 264);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Văn bản mã hóa";
            // 
            // txtMaVigenere
            // 
            this.txtMaVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaVigenere.Location = new System.Drawing.Point(26, 38);
            this.txtMaVigenere.Multiline = true;
            this.txtMaVigenere.Name = "txtMaVigenere";
            this.txtMaVigenere.Size = new System.Drawing.Size(300, 216);
            this.txtMaVigenere.TabIndex = 0;
            // 
            // btnDichVigenere
            // 
            this.btnDichVigenere.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVigenere.Image")));
            this.btnDichVigenere.Location = new System.Drawing.Point(389, 462);
            this.btnDichVigenere.Name = "btnDichVigenere";
            this.btnDichVigenere.Size = new System.Drawing.Size(84, 42);
            this.btnDichVigenere.TabIndex = 11;
            this.btnDichVigenere.UseVisualStyleBackColor = true;
            this.btnDichVigenere.Click += new System.EventHandler(this.btnDichVigenere_Click);
            // 
            // btnChuyenVigenere
            // 
            this.btnChuyenVigenere.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenVigenere.Image")));
            this.btnChuyenVigenere.Location = new System.Drawing.Point(389, 397);
            this.btnChuyenVigenere.Name = "btnChuyenVigenere";
            this.btnChuyenVigenere.Size = new System.Drawing.Size(84, 43);
            this.btnChuyenVigenere.TabIndex = 12;
            this.btnChuyenVigenere.UseVisualStyleBackColor = true;
            this.btnChuyenVigenere.Click += new System.EventHandler(this.btnChuyenVigenere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dòng Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKeyVegenere
            // 
            this.txtKeyVegenere.Location = new System.Drawing.Point(377, 328);
            this.txtKeyVegenere.Name = "txtKeyVegenere";
            this.txtKeyVegenere.Size = new System.Drawing.Size(111, 20);
            this.txtKeyVegenere.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.Controls.Add(this.txtKeyVegenere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxKeyCaesar);
            this.Controls.Add(this.btnChuyenVigenere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDichVigenere);
            this.Controls.Add(this.btnChuyenCaesar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnDichCaesar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Caesar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaCaesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDichCaesar;
        private System.Windows.Forms.Button btnChuyenCaesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKeyCaesar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVigenere;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaVigenere;
        private System.Windows.Forms.Button btnDichVigenere;
        private System.Windows.Forms.Button btnChuyenVigenere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyVegenere;
    }
}

