
namespace EX1
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
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ lót";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoLot.ForeColor = System.Drawing.Color.Red;
            this.txtHoLot.Location = new System.Drawing.Point(131, 66);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(172, 27);
            this.txtHoLot.TabIndex = 2;
            this.txtHoLot.Text = "Trần Thị Hồng";
            this.txtHoLot.TextChanged += new System.EventHandler(this.txtHoLot_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Red;
            this.txtTen.Location = new System.Drawing.Point(131, 107);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(172, 27);
            this.txtTen.TabIndex = 3;
            this.txtTen.Text = "Loan";
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Blue;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(73, 148);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(250, 34);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "Trần Thị Hồng Loan";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHoLot
            // 
            this.btnHoLot.ForeColor = System.Drawing.Color.Blue;
            this.btnHoLot.Location = new System.Drawing.Point(76, 208);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(67, 30);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "Họ lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.ForeColor = System.Drawing.Color.Blue;
            this.btnTen.Location = new System.Drawing.Point(166, 208);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(67, 30);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.ForeColor = System.Drawing.Color.Blue;
            this.btnHoTen.Location = new System.Drawing.Point(256, 208);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(67, 30);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.ForeColor = System.Drawing.Color.Blue;
            this.btnTiepTuc.Location = new System.Drawing.Point(346, 208);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(67, 30);
            this.btnTiepTuc.TabIndex = 8;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(436, 208);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 30);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 308);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

