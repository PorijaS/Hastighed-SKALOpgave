using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastighedomregner
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void amount_text_TextChanged_1(object sender, EventArgs e)
		{
			if (amount_text.Text == "")
			{
				amount_text.Text = "1";
			}

			double input = double.Parse(amount_text.Text);
			if (radioButton1.Checked)
			{
				double result = (input) * (60 * 60) / 1000;
				textBox1.Text = result.ToString();
				label2.Text = "km/t";
			}
			else if (radioButton2.Checked)
			{
				double result = (input) / 3.6;
				textBox1.Text = result.ToString();
				label2.Text = "m/s";
			}
		}

		private void clear_btn_Click_1(object sender, EventArgs e)
		{
			amount_text.Text = string.Empty;
			label2.Text = "";
		}
	}
}
