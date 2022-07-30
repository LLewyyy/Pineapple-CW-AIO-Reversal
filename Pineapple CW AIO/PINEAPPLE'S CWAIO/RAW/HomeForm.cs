using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CWTesting;
using Guna.UI2.WinForms;
using RAW.Tool;

namespace RAW
{
	// Token: 0x02000098 RID: 152
	public partial class HomeForm : Form
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00022091 File Offset: 0x00022091
		public HomeForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000220A0 File Offset: 0x000220A0
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			if (this.guna2ComboBox1.SelectedIndex == 0)
			{
				Console.Beep();
				Form form = new MainForm();
				base.Hide();
				form.ShowDialog();
				base.Close();
				Console.Beep();
			}
			if (this.guna2ComboBox1.SelectedIndex == 1)
			{
				Console.Beep();
				Form form2 = new WeaponIDForm();
				base.Hide();
				form2.ShowDialog();
				base.Close();
				Console.Beep();
			}
			if (this.guna2ComboBox1.SelectedIndex == 2)
			{
				Console.Beep();
				Form form3 = new HomeForm();
				base.Hide();
				form3.ShowDialog();
				base.Close();
				Console.Beep();
			}
			if (this.guna2ComboBox1.SelectedIndex == 3)
			{
				Console.Beep();
				Form form4 = new Form1();
				base.Hide();
				form4.ShowDialog();
				base.Close();
				Console.Beep();
			}
		}
	}
}
