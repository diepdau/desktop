namespace Lab01_Form_2115196_DauThiTieuDiep
{
	partial class frmBai1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTrang = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.lable1 = new System.Windows.Forms.Label();
			this.lblSoLuong = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(32, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 131);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTrang);
			this.groupBox1.Controls.Add(this.rdDo);
			this.groupBox1.Controls.Add(this.rdXanh);
			this.groupBox1.Location = new System.Drawing.Point(285, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(228, 139);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu xe";
			// 
			// rdTrang
			// 
			this.rdTrang.AutoSize = true;
			this.rdTrang.Location = new System.Drawing.Point(23, 86);
			this.rdTrang.Name = "rdTrang";
			this.rdTrang.Size = new System.Drawing.Size(53, 17);
			this.rdTrang.TabIndex = 2;
			this.rdTrang.TabStop = true;
			this.rdTrang.Text = "Trắng";
			this.rdTrang.UseVisualStyleBackColor = true;
			this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Location = new System.Drawing.Point(23, 53);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(39, 17);
			this.rdDo.TabIndex = 1;
			this.rdDo.TabStop = true;
			this.rdDo.Text = "Đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Location = new System.Drawing.Point(23, 19);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(50, 17);
			this.rdXanh.TabIndex = 0;
			this.rdXanh.TabStop = true;
			this.rdXanh.Text = "Xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// lable1
			// 
			this.lable1.AutoSize = true;
			this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable1.Location = new System.Drawing.Point(284, 183);
			this.lable1.Name = "lable1";
			this.lable1.Size = new System.Drawing.Size(54, 16);
			this.lable1.TabIndex = 2;
			this.lable1.Text = "Số Tiền";
			// 
			// lblSoLuong
			// 
			this.lblSoLuong.AutoSize = true;
			this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoLuong.Location = new System.Drawing.Point(284, 228);
			this.lblSoLuong.Name = "lblSoLuong";
			this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
			this.lblSoLuong.TabIndex = 3;
			this.lblSoLuong.Text = "Số lượng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(456, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "$";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(161, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tổng số tiền thanh toán";
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoTien.Location = new System.Drawing.Point(346, 304);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(18, 20);
			this.lblSoTien.TabIndex = 6;
			this.lblSoTien.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(456, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "$";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(350, 179);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(100, 20);
			this.txtDonGia.TabIndex = 8;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(350, 224);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
			this.txtSoLuong.TabIndex = 9;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTinhTien.Location = new System.Drawing.Point(285, 261);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(88, 30);
			this.btnTinhTien.TabIndex = 10;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblSoLuong);
			this.Controls.Add(this.lable1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmBai1";
			this.Text = "frmBai1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTrang;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.Label lblSoLuong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnTinhTien;
	}
}