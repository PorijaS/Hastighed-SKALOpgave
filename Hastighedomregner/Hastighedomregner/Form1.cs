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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			customizeDesign();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void conv_btn_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void customizeDesign()
		{
			panelCCSubmenu.Visible = false;
		}

		private void hideSubMenu()
		{
			if (panelCCSubmenu.Visible == true)
				panelCCSubmenu.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}

		private void btnCC_Click(object sender, EventArgs e)
		{
			showSubMenu(panelCCSubmenu);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new Form2());
			hideSubMenu();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
