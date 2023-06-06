namespace CoBan_Label_Button_Textbox
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.btnCong = new System.Windows.Forms.Button();
			this.btnNhan = new System.Windows.Forms.Button();
			this.btnChia = new System.Windows.Forms.Button();
			this.btnTru = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtKetQua = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(57, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số thứ hai:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(224, 60);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(502, 22);
			this.txtA.TabIndex = 2;
			this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
			this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(224, 118);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(502, 22);
			this.txtB.TabIndex = 3;
			this.txtB.Enter += new System.EventHandler(this.txtA_Enter);
			this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			this.txtB.Leave += new System.EventHandler(this.txtA_Leave);
			// 
			// btnCong
			// 
			this.btnCong.Enabled = false;
			this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCong.Location = new System.Drawing.Point(62, 185);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(87, 51);
			this.btnCong.TabIndex = 4;
			this.btnCong.Text = "+";
			this.btnCong.UseVisualStyleBackColor = true;
			this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
			this.btnCong.MouseEnter += new System.EventHandler(this.btnCong_MouseEnter);
			this.btnCong.MouseLeave += new System.EventHandler(this.btnCong_MouseLeave);
			// 
			// btnNhan
			// 
			this.btnNhan.Enabled = false;
			this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhan.Location = new System.Drawing.Point(348, 185);
			this.btnNhan.Name = "btnNhan";
			this.btnNhan.Size = new System.Drawing.Size(84, 51);
			this.btnNhan.TabIndex = 5;
			this.btnNhan.Text = "*";
			this.btnNhan.UseVisualStyleBackColor = true;
			this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
			this.btnNhan.MouseEnter += new System.EventHandler(this.btnCong_MouseEnter);
			this.btnNhan.MouseLeave += new System.EventHandler(this.btnCong_MouseLeave);
			// 
			// btnChia
			// 
			this.btnChia.Enabled = false;
			this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChia.Location = new System.Drawing.Point(477, 185);
			this.btnChia.Name = "btnChia";
			this.btnChia.Size = new System.Drawing.Size(84, 51);
			this.btnChia.TabIndex = 6;
			this.btnChia.Text = "/";
			this.btnChia.UseVisualStyleBackColor = true;
			this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
			this.btnChia.MouseEnter += new System.EventHandler(this.btnCong_MouseEnter);
			this.btnChia.MouseLeave += new System.EventHandler(this.btnCong_MouseLeave);
			// 
			// btnTru
			// 
			this.btnTru.Enabled = false;
			this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTru.Location = new System.Drawing.Point(198, 185);
			this.btnTru.Name = "btnTru";
			this.btnTru.Size = new System.Drawing.Size(88, 51);
			this.btnTru.TabIndex = 7;
			this.btnTru.Text = "-";
			this.btnTru.UseVisualStyleBackColor = true;
			this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
			this.btnTru.MouseEnter += new System.EventHandler(this.btnCong_MouseEnter);
			this.btnTru.MouseLeave += new System.EventHandler(this.btnCong_MouseLeave);
			// 
			// btnDel
			// 
			this.btnDel.Enabled = false;
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Location = new System.Drawing.Point(611, 185);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(115, 51);
			this.btnDel.TabIndex = 8;
			this.btnDel.Text = "Del";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			this.btnDel.MouseEnter += new System.EventHandler(this.btnCong_MouseEnter);
			this.btnDel.MouseLeave += new System.EventHandler(this.btnCong_MouseLeave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 280);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 29);
			this.label3.TabIndex = 9;
			this.label3.Text = "Kết quả:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtKetQua
			// 
			this.txtKetQua.Enabled = false;
			this.txtKetQua.Location = new System.Drawing.Point(224, 287);
			this.txtKetQua.Name = "txtKetQua";
			this.txtKetQua.ReadOnly = true;
			this.txtKetQua.Size = new System.Drawing.Size(502, 22);
			this.txtKetQua.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(800, 352);
			this.Controls.Add(this.txtKetQua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnTru);
			this.Controls.Add(this.btnChia);
			this.Controls.Add(this.btnNhan);
			this.Controls.Add(this.btnCong);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Label Button Textbox";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

