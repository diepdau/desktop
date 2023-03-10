using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnXuLy_Click(object sender, EventArgs e)
		{
			var tenDaNhap = txtTen.Text;
			MessageBox.Show($"Chào mừng {tenDaNhap}");
		}

		private void btnSaoChep_Click(object sender, EventArgs e)
		{
					txtSaoChep.Text = txtTen.Text;            
        }

		private void txtTen_TextChanged(object sender, EventArgs e)
		{
                   txtSaoChep.Text = txtTen.Text;
        }
	}
}
