namespace Hastighedomregner
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnCC = new System.Windows.Forms.Button();
			this.panelCCSubmenu = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.panelPlayer = new System.Windows.Forms.Panel();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panelSideMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelCCSubmenu.SuspendLayout();
			this.panelChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.panelSideMenu.Controls.Add(this.button1);
			this.panelSideMenu.Controls.Add(this.panelCCSubmenu);
			this.panelSideMenu.Controls.Add(this.btnCC);
			this.panelSideMenu.Controls.Add(this.panelLogo);
			this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(200, 561);
			this.panelSideMenu.TabIndex = 24;
			this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.pictureBox2);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 100);
			this.panelLogo.TabIndex = 0;
			// 
			// btnCC
			// 
			this.btnCC.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCC.FlatAppearance.BorderSize = 0;
			this.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCC.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCC.Location = new System.Drawing.Point(0, 100);
			this.btnCC.Name = "btnCC";
			this.btnCC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCC.Size = new System.Drawing.Size(200, 45);
			this.btnCC.TabIndex = 1;
			this.btnCC.Text = "Calculators/Converters";
			this.btnCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCC.UseVisualStyleBackColor = true;
			this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
			// 
			// panelCCSubmenu
			// 
			this.panelCCSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.panelCCSubmenu.Controls.Add(this.button5);
			this.panelCCSubmenu.Controls.Add(this.button4);
			this.panelCCSubmenu.Controls.Add(this.button3);
			this.panelCCSubmenu.Controls.Add(this.button2);
			this.panelCCSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCCSubmenu.Location = new System.Drawing.Point(0, 145);
			this.panelCCSubmenu.Name = "panelCCSubmenu";
			this.panelCCSubmenu.Size = new System.Drawing.Size(200, 162);
			this.panelCCSubmenu.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.LightGray;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(200, 40);
			this.button2.TabIndex = 0;
			this.button2.Text = "SpeedConverter";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.LightGray;
			this.button3.Location = new System.Drawing.Point(0, 40);
			this.button3.Name = "button3";
			this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button3.Size = new System.Drawing.Size(200, 40);
			this.button3.TabIndex = 1;
			this.button3.Text = "Placeholder";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.LightGray;
			this.button4.Location = new System.Drawing.Point(0, 80);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button4.Size = new System.Drawing.Size(200, 40);
			this.button4.TabIndex = 2;
			this.button4.Text = "Placeholder";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(0, 120);
			this.button5.Name = "button5";
			this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.button5.Size = new System.Drawing.Size(200, 40);
			this.button5.TabIndex = 3;
			this.button5.Text = "Placeholder";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// panelPlayer
			// 
			this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelPlayer.Location = new System.Drawing.Point(200, 435);
			this.panelPlayer.Name = "panelPlayer";
			this.panelPlayer.Size = new System.Drawing.Size(734, 126);
			this.panelPlayer.TabIndex = 25;
			// 
			// panelChildForm
			// 
			this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.panelChildForm.Controls.Add(this.pictureBox1);
			this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChildForm.Location = new System.Drawing.Point(200, 0);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(734, 435);
			this.panelChildForm.TabIndex = 26;
			this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(253, 107);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(12, 521);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(934, 561);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panelPlayer);
			this.Controls.Add(this.panelSideMenu);
			this.MinimumSize = new System.Drawing.Size(950, 600);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelSideMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelCCSubmenu.ResumeLayout(false);
			this.panelChildForm.ResumeLayout(false);
			this.panelChildForm.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Panel panelCCSubmenu;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnCC;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelPlayer;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
	}
}

