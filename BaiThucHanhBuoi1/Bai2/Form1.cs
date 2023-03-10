using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void rdNam_CheckedChanged(object sender, EventArgs e)
		{
			if(rdNam.Checked)
                MessageBox.Show($"Bạn chọn nam");
        }

		private void rdNu_CheckedChanged(object sender, EventArgs e)
		{
            if (rdNu.Checked)
                MessageBox.Show($"Bạn chọn nữ");
        }

		private void btnToMau_Click(object sender, EventArgs e)
		{
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rdXanh.Checked)
                txtHopMau.BackColor = Color.Green;
        }
	}
}
