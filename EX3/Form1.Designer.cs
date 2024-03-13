
namespace EX3
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Blue;
            this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplay.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(606, 55);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "TRẦN THỊ HỒNG LOAN";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTiepTuc);
            this.groupBox1.Controls.Add(this.btnHoTen);
            this.groupBox1.Controls.Add(this.btnTen);
            this.groupBox1.Controls.Add(this.btnHoLot);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtHoLot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(35, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân ";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Red;
            this.txtTen.Location = new System.Drawing.Point(153, 87);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(172, 27);
            this.txtTen.TabIndex = 7;
            this.txtTen.Text = "Loan";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoLot.ForeColor = System.Drawing.Color.Red;
            this.txtHoLot.Location = new System.Drawing.Point(153, 38);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(172, 27);
            this.txtHoLot.TabIndex = 6;
            this.txtHoLot.Text = "Trần Thị Hồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(79, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(79, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ lót";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(438, 146);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(348, 146);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(67, 30);
            this.btnTiepTuc.TabIndex = 13;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHoTen.ForeColor = System.Drawing.Color.White;
            this.btnHoTen.Location = new System.Drawing.Point(258, 146);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(67, 30);
            this.btnHoTen.TabIndex = 12;
            this.btnHoTen.Text = "Họ Tên";
            this.btnHoTen.UseVisualStyleBackColor = false;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTen.ForeColor = System.Drawing.Color.White;
            this.btnTen.Location = new System.Drawing.Point(168, 146);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(67, 30);
            this.btnTen.TabIndex = 11;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoLot
            // 
            this.btnHoLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHoLot.ForeColor = System.Drawing.Color.White;
            this.btnHoLot.Location = new System.Drawing.Point(78, 146);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(67, 30);
            this.btnHoLot.TabIndex = 10;
            this.btnHoLot.Text = "Họ lót";
            this.btnHoLot.UseVisualStyleBackColor = false;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDisplay);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoLot;
    }
}

