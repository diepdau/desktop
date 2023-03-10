namespace BaiTapWindowsForm
{
	partial class frmBai2
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTienMat = new System.Windows.Forms.RadioButton();
			this.rdChuyenKhoan = new System.Windows.Forms.RadioButton();
			this.lblTienHang = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tiền hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đơn giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số lượng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(320, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số tiền thanh toán";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(112, 64);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(121, 20);
			this.txtDonGia.TabIndex = 5;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(112, 113);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
			this.txtSoLuong.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(322, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Tính tiền";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoTien.Location = new System.Drawing.Point(453, 190);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(12, 18);
			this.lblSoTien.TabIndex = 8;
			this.lblSoTien.Text = ".";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTienMat);
			this.groupBox1.Controls.Add(this.rdChuyenKhoan);
			this.groupBox1.Location = new System.Drawing.Point(322, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hình thức thanh toán";
			// 
			// rdTienMat
			// 
			this.rdTienMat.AutoSize = true;
			this.rdTienMat.Checked = true;
			this.rdTienMat.Location = new System.Drawing.Point(28, 56);
			this.rdTienMat.Name = "rdTienMat";
			this.rdTienMat.Size = new System.Drawing.Size(66, 17);
			this.rdTienMat.TabIndex = 1;
			this.rdTienMat.TabStop = true;
			this.rdTienMat.Text = "Tiền mặt";
			this.rdTienMat.UseVisualStyleBackColor = true;
			// 
			// rdChuyenKhoan
			// 
			this.rdChuyenKhoan.AutoSize = true;
			this.rdChuyenKhoan.Location = new System.Drawing.Point(28, 33);
			this.rdChuyenKhoan.Name = "rdChuyenKhoan";
			this.rdChuyenKhoan.Size = new System.Drawing.Size(94, 17);
			this.rdChuyenKhoan.TabIndex = 0;
			this.rdChuyenKhoan.Text = "Chuyển khoản";
			this.rdChuyenKhoan.UseVisualStyleBackColor = true;
			// 
			// lblTienHang
			// 
			this.lblTienHang.FormattingEnabled = true;
			this.lblTienHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
			this.lblTienHang.Location = new System.Drawing.Point(112, 12);
			this.lblTienHang.Name = "lblTienHang";
			this.lblTienHang.Size = new System.Drawing.Size(121, 21);
			this.lblTienHang.TabIndex = 10;
			this.lblTienHang.SelectedIndexChanged += new System.EventHandler(this.lblTienHang_SelectedIndexChanged);
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTienHang);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "Bài 2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTienMat;
		private System.Windows.Forms.RadioButton rdChuyenKhoan;
		private System.Windows.Forms.ComboBox lblTienHang;
	}
}