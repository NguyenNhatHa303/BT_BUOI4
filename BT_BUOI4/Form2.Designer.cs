namespace BT_BUOI4
{
    partial class Form2
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
            this.txtIDForm2 = new System.Windows.Forms.TextBox();
            this.txtNameForm2 = new System.Windows.Forms.TextBox();
            this.txtSalaryForm2 = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDForm2
            // 
            this.txtIDForm2.Location = new System.Drawing.Point(193, 37);
            this.txtIDForm2.Name = "txtIDForm2";
            this.txtIDForm2.Size = new System.Drawing.Size(100, 20);
            this.txtIDForm2.TabIndex = 0;
            // 
            // txtNameForm2
            // 
            this.txtNameForm2.Location = new System.Drawing.Point(193, 85);
            this.txtNameForm2.Name = "txtNameForm2";
            this.txtNameForm2.Size = new System.Drawing.Size(323, 20);
            this.txtNameForm2.TabIndex = 1;
            // 
            // txtSalaryForm2
            // 
            this.txtSalaryForm2.Location = new System.Drawing.Point(193, 152);
            this.txtSalaryForm2.Name = "txtSalaryForm2";
            this.txtSalaryForm2.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryForm2.TabIndex = 2;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(29, 40);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(38, 13);
            this.lblNV.TabIndex = 3;
            this.lblNV.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lương cơ bản";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(193, 209);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(358, 209);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.txtSalaryForm2);
            this.Controls.Add(this.txtNameForm2);
            this.Controls.Add(this.txtIDForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIDForm2;
        public System.Windows.Forms.TextBox txtNameForm2;
        public System.Windows.Forms.TextBox txtSalaryForm2;
        public System.Windows.Forms.Label lblNV;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnDongY;
        public System.Windows.Forms.Button btnBoQua;
    }
}