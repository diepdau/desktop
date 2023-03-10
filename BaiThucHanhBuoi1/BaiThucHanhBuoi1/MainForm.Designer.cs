namespace BaiThucHanhBuoi1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(310, 46);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 1;
            this.btnXuLy.Text = "Xử Lý";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(186, 49);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn đã nhập: ";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(186, 107);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.Size = new System.Drawing.Size(100, 20);
            this.txtSaoChep.TabIndex = 4;
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(310, 104);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Chương trình đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnXuLy;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaoChep;
		private System.Windows.Forms.Button btnSaoChep;
	}
}

