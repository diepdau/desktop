namespace BaiTapWindowsForm
{
	partial class frmBai3
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
			this.lblKQ = new System.Windows.Forms.Label();
			this.txtSoA = new System.Windows.Forms.TextBox();
			this.txtSoB = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTong1denN = new System.Windows.Forms.RadioButton();
			this.rdTongAB = new System.Windows.Forms.RadioButton();
			this.btnXemKQ = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số b";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 101);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 362);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kết quả là:";
			// 
			// lblKQ
			// 
			this.lblKQ.AutoSize = true;
			this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKQ.Location = new System.Drawing.Point(130, 365);
			this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKQ.Name = "lblKQ";
			this.lblKQ.Size = new System.Drawing.Size(13, 20);
			this.lblKQ.TabIndex = 4;
			this.lblKQ.Text = ".";
			// 
			// txtSoA
			// 
			this.txtSoA.Location = new System.Drawing.Point(117, 20);
			this.txtSoA.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoA.Name = "txtSoA";
			this.txtSoA.Size = new System.Drawing.Size(175, 22);
			this.txtSoA.TabIndex = 5;
			this.txtSoA.Text = "0";
			// 
			// txtSoB
			// 
			this.txtSoB.Location = new System.Drawing.Point(117, 57);
			this.txtSoB.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoB.Name = "txtSoB";
			this.txtSoB.Size = new System.Drawing.Size(175, 22);
			this.txtSoB.TabIndex = 6;
			this.txtSoB.Text = "0";
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(117, 92);
			this.txtSoN.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(175, 22);
			this.txtSoN.TabIndex = 7;
			this.txtSoN.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTong1denN);
			this.groupBox1.Controls.Add(this.rdTongAB);
			this.groupBox1.Location = new System.Drawing.Point(41, 146);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(267, 123);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdTong1denN
			// 
			this.rdTong1denN.AutoSize = true;
			this.rdTong1denN.Location = new System.Drawing.Point(46, 80);
			this.rdTong1denN.Margin = new System.Windows.Forms.Padding(4);
			this.rdTong1denN.Name = "rdTong1denN";
			this.rdTong1denN.Size = new System.Drawing.Size(139, 20);
			this.rdTong1denN.TabIndex = 1;
			this.rdTong1denN.Text = "Tính tổng từ 1 đến n";
			this.rdTong1denN.UseVisualStyleBackColor = true;
			// 
			// rdTongAB
			// 
			this.rdTongAB.AutoSize = true;
			this.rdTongAB.Checked = true;
			this.rdTongAB.Location = new System.Drawing.Point(46, 39);
			this.rdTongAB.Margin = new System.Windows.Forms.Padding(4);
			this.rdTongAB.Name = "rdTongAB";
			this.rdTongAB.Size = new System.Drawing.Size(145, 20);
			this.rdTongAB.TabIndex = 0;
			this.rdTongAB.TabStop = true;
			this.rdTongAB.Text = "Tính tổng của a và b";
			this.rdTongAB.UseVisualStyleBackColor = true;
			// 
			// btnXemKQ
			// 
			this.btnXemKQ.Location = new System.Drawing.Point(117, 292);
			this.btnXemKQ.Margin = new System.Windows.Forms.Padding(4);
			this.btnXemKQ.Name = "btnXemKQ";
			this.btnXemKQ.Size = new System.Drawing.Size(91, 27);
			this.btnXemKQ.TabIndex = 9;
			this.btnXemKQ.Text = "Xem Kết quả";
			this.btnXemKQ.UseVisualStyleBackColor = true;
			this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnXemKQ);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtSoB);
			this.Controls.Add(this.txtSoA);
			this.Controls.Add(this.lblKQ);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBai3";
			this.Text = "frmBai3";
			this.Load += new System.EventHandler(this.frmBai3_Load);
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
		private System.Windows.Forms.Label lblKQ;
		private System.Windows.Forms.TextBox txtSoA;
		private System.Windows.Forms.TextBox txtSoB;
		private System.Windows.Forms.TextBox txtSoN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTong1denN;
		private System.Windows.Forms.RadioButton rdTongAB;
		private System.Windows.Forms.Button btnXemKQ;
	}
}