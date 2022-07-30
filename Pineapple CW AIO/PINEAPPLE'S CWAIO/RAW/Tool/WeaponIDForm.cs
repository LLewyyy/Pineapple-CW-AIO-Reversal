using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using RAW.AntiDebug;
using RAW.GLOBAL;
using RAW.Properties;
using RAW.UTILITIES;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.WinForms;

namespace RAW.Tool
{
	// Token: 0x020000B3 RID: 179
	public partial class WeaponIDForm : Form
	{
		// Token: 0x060004B9 RID: 1209
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x060004BA RID: 1210
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x060004BB RID: 1211 RVA: 0x000358F8 File Offset: 0x000358F8
		public WeaponIDForm()
		{
			this.InitializeComponent();
			this.devlogin();
			this.CustomDesign();
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0003597C File Offset: 0x0003597C
		public void devlogin()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			WeaponIDForm.form = this;
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

		// Token: 0x060004BD RID: 1213 RVA: 0x00035AF4 File Offset: 0x00035AF4
		public void login()
		{
			if (Booleans.glhfc)
			{
				Control.CheckForIllegalCrossThreadCalls = false;
				WeaponIDForm.form = this;
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

		// Token: 0x060004BE RID: 1214 RVA: 0x0002604C File Offset: 0x0002604C
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00035C74 File Offset: 0x00035C74
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

		// Token: 0x060004C0 RID: 1216
		[DllImport("user32.dll")]
		private static extern bool SetWindowText(IntPtr hWnd, string text);

		// Token: 0x060004C1 RID: 1217 RVA: 0x00035CC0 File Offset: 0x00035CC0
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
				WeaponIDForm.SetWindowText(process.MainWindowHandle, text);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00035D40 File Offset: 0x00035D40
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

		// Token: 0x060004C3 RID: 1219 RVA: 0x00009AC9 File Offset: 0x00009AC9
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00036010 File Offset: 0x00036010
		private void PlayerSelectPnl()
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = true;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (WeaponIDForm.SelectedPlayer == 2)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = true;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (WeaponIDForm.SelectedPlayer == 3)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = true;
				this.Player4OptionsPnl.Visible = false;
				return;
			}
			if (WeaponIDForm.SelectedPlayer == 4)
			{
				this.PlayerAllOptionsPnl.Visible = false;
				this.Player1OptionsPnl.Visible = false;
				this.Player2OptionsPnl.Visible = false;
				this.Player3OptionsPnl.Visible = false;
				this.Player4OptionsPnl.Visible = true;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00036130 File Offset: 0x00036130
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

		// Token: 0x060004C6 RID: 1222 RVA: 0x000361A0 File Offset: 0x000361A0
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
			WeaponIDForm.SelectedPlayer = 1;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00036258 File Offset: 0x00036258
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
			WeaponIDForm.SelectedPlayer = 2;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00036310 File Offset: 0x00036310
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
			WeaponIDForm.SelectedPlayer = 3;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000363C8 File Offset: 0x000363C8
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
			WeaponIDForm.SelectedPlayer = 4;
			this.PlayerSelectPnl();
			this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			this.TeleportSelectorCombo.SelectedIndex = 0;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00036480 File Offset: 0x00036480
		public void playerUpdate(bool GM, bool IA, bool UP, bool AC, bool RF, bool WPC, int wpn, int wpn2, int tp)
		{
			this.WeaponSelectorCombo.SelectedIndex = wpn2;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00036490 File Offset: 0x00036490
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

		// Token: 0x060004CC RID: 1228 RVA: 0x00036550 File Offset: 0x00036550
		private void HomeBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = true;
			this.a2.Visible = false;
			this.a3.Visible = false;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00036576 File Offset: 0x00036576
		private void DiscordBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.discord.gg/DTvmR6JyJ4");
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00036583 File Offset: 0x00036583
		private void PlayerSettingsBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = false;
			this.a3.Visible = true;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000365A9 File Offset: 0x000365A9
		private void GlobalSettingsBtn_Click(object sender, EventArgs e)
		{
			this.a1.Visible = false;
			this.a2.Visible = true;
			this.a3.Visible = false;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000269C0 File Offset: 0x000269C0
		public ulong PCompPtr(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)i);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000269D0 File Offset: 0x000269D0
		public static ulong PCompPtrStatic(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)i);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000269E0 File Offset: 0x000269E0
		public ulong PPedPtr(int i)
		{
			return Offsets.PlayerCompPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)i) + 8UL;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000365D0 File Offset: 0x000365D0
		public void setCamo(int client, int camo)
		{
			this.Threads.m.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23588UL, camo);
			this.Threads.m.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23524UL, camo);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00036638 File Offset: 0x00036638
		public void setRet(int client, int ret)
		{
			this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23588UL, (float)ret);
			this.Threads.m.WriteFloat(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)client) + Offsets.PC_Camo - 23524UL, (float)ret);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000366A0 File Offset: 0x000366A0
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

		// Token: 0x060004D6 RID: 1238 RVA: 0x00036704 File Offset: 0x00036704
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

		// Token: 0x060004D7 RID: 1239 RVA: 0x0003676B File Offset: 0x0003676B
		private void DiscoCamosChk_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ToggleDCamo.Checked)
			{
				Variables.camo = 62;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00036784 File Offset: 0x00036784
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

		// Token: 0x060004D9 RID: 1241 RVA: 0x0003683C File Offset: 0x0003683C
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

		// Token: 0x060004DA RID: 1242 RVA: 0x00036898 File Offset: 0x00036898
		private void TPZCDistance_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.tpDistance = Convert.ToInt32(this.TPValue.Text);
			this.TPValue.Text = this.ZombieTPDistTrackBar.Value.ToString();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000368D8 File Offset: 0x000368D8
		private void CycleInterval_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.cycint = this.WeaponCycleIntervalTrackBar.Value;
			this.CycleValue.Text = this.WeaponCycleIntervalTrackBar.Value.ToString();
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00036914 File Offset: 0x00036914
		private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				try
				{
					if (Offsets.BaseAddress != 0UL)
					{
						Booleans.GameAttached = true;
						this.AttachedStateLbl.ForeColor = Color.SlateBlue;
						this.AttachedStateLbl.Text = "CONNECTED";
					}
					else
					{
						Booleans.GameAttached = false;
						this.AttachedStateLbl.ForeColor = Color.SlateBlue;
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

		// Token: 0x060004DD RID: 1245 RVA: 0x000369E8 File Offset: 0x000369E8
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

		// Token: 0x060004DE RID: 1246 RVA: 0x00036A44 File Offset: 0x00036A44
		private void RapidFireWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				if (Booleans.P1RF && WeaponIDForm.GetAsyncKeyState(Keys.LButton) < 0)
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

		// Token: 0x060004DF RID: 1247 RVA: 0x00036B74 File Offset: 0x00036B74
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x00036DA8 File Offset: 0x00036DA8
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

		// Token: 0x060004E1 RID: 1249 RVA: 0x00036DF8 File Offset: 0x00036DF8
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

		// Token: 0x060004E2 RID: 1250 RVA: 0x00036E58 File Offset: 0x00036E58
		private void ZombieWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.ZMCountLbl.Text = "N/A";
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00036E6A File Offset: 0x00036E6A
		public int ZMCountLeft()
		{
			return this.Threads.m.ReadInt32(Offsets.ZMGlobalBase + Offsets.ZM_Global_ZMLeftCount);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00036E88 File Offset: 0x00036E88
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

		// Token: 0x060004E5 RID: 1253 RVA: 0x00036EEC File Offset: 0x00036EEC
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

		// Token: 0x060004E6 RID: 1254 RVA: 0x00036FA0 File Offset: 0x00036FA0
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

		// Token: 0x060004E7 RID: 1255 RVA: 0x00037054 File Offset: 0x00037054
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

		// Token: 0x060004E8 RID: 1256 RVA: 0x00037108 File Offset: 0x00037108
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x000371BC File Offset: 0x000371BC
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

		// Token: 0x060004EA RID: 1258 RVA: 0x00037238 File Offset: 0x00037238
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

		// Token: 0x060004EB RID: 1259 RVA: 0x000372B4 File Offset: 0x000372B4
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

		// Token: 0x060004EC RID: 1260 RVA: 0x00037330 File Offset: 0x00037330
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

		// Token: 0x060004ED RID: 1261 RVA: 0x000373AC File Offset: 0x000373AC
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

		// Token: 0x060004EE RID: 1262 RVA: 0x00037428 File Offset: 0x00037428
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

		// Token: 0x060004EF RID: 1263 RVA: 0x000374A4 File Offset: 0x000374A4
		private void WeaponSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(0) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p1wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P1WPC = false;
				this.playerUpdate(Booleans.P1GM, Booleans.P1IA, Booleans.P1UP, Booleans.P1AC, Booleans.P1RF, Booleans.P1WPC, Variables.p1wpn, Variables.p1wpn2, Variables.tp);
			}
			if (WeaponIDForm.SelectedPlayer == 2 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(1) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p2wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P2WPC = false;
				this.playerUpdate(Booleans.P2GM, Booleans.P2IA, Booleans.P2UP, Booleans.P2AC, Booleans.P2RF, Booleans.P2WPC, Variables.p2wpn, Variables.p2wpn2, Variables.tp);
			}
			if (WeaponIDForm.SelectedPlayer == 3 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(2) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p3wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P3WPC = false;
				this.playerUpdate(Booleans.P3GM, Booleans.P3IA, Booleans.P3UP, Booleans.P3AC, Booleans.P3RF, Booleans.P3WPC, Variables.p3wpn, Variables.p3wpn2, Variables.tp);
			}
			if (WeaponIDForm.SelectedPlayer == 4 && this.WeaponSelectorCombo.SelectedIndex != 0)
			{
				this.Threads.m.WriteInt64(this.PCompPtr(3) + Offsets.PC_SetWeaponID, (long)Variables.GunList[this.WeaponSelectorCombo.SelectedIndex]);
				Variables.p4wpn2 = this.WeaponSelectorCombo.SelectedIndex;
				Booleans.P4WPC = false;
				this.playerUpdate(Booleans.P4GM, Booleans.P4IA, Booleans.P4UP, Booleans.P4AC, Booleans.P4RF, Booleans.P4WPC, Variables.p4wpn, Variables.p4wpn2, Variables.tp);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000376F4 File Offset: 0x000376F4
		private void WeaponCycleIntervalTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			Variables.cycint = this.WeaponCycleIntervalTrackBar.Value;
			this.CycleValue.Text = this.WeaponCycleIntervalTrackBar.Value.ToString();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00037730 File Offset: 0x00037730
		private void P1WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player1WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (WeaponIDForm.SelectedPlayer == 1)
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
				if (WeaponIDForm.SelectedPlayer == 1)
				{
					Booleans.P1WPC = false;
				}
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00037794 File Offset: 0x00037794
		private void P2WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player2WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (WeaponIDForm.SelectedPlayer == 2)
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
				if (WeaponIDForm.SelectedPlayer == 2)
				{
					Booleans.P2WPC = false;
				}
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000377F8 File Offset: 0x000377F8
		private void P3WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player3WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (WeaponIDForm.SelectedPlayer == 3)
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
				if (WeaponIDForm.SelectedPlayer == 3)
				{
					Booleans.P3WPC = false;
				}
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0003785C File Offset: 0x0003785C
		private void P4WeaponCycle_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Player4WeaponCycleChk.Checked)
			{
				this.WeaponCycleIntervalTrackBar.Enabled = true;
				if (WeaponIDForm.SelectedPlayer == 4)
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
				if (WeaponIDForm.SelectedPlayer == 4)
				{
					Booleans.P4WPC = false;
				}
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000378C0 File Offset: 0x000378C0
		public void PlayerTeleport(int clientID, int locationID)
		{
			if (Variables.locationVectors[locationID].X != 0f)
			{
				this.Threads.m.WriteVec3(this.PCompPtr(clientID) + Offsets.PC_Coords, Variables.locationVectors[locationID]);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0003790C File Offset: 0x0003790C
		private void TeleportSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(0, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (WeaponIDForm.SelectedPlayer == 2 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(1, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (WeaponIDForm.SelectedPlayer == 3 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(2, this.TeleportSelectorCombo.SelectedIndex);
			}
			if (WeaponIDForm.SelectedPlayer == 4 && this.TeleportSelectorCombo.SelectedIndex != 0)
			{
				this.PlayerTeleport(3, this.TeleportSelectorCombo.SelectedIndex);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000379B8 File Offset: 0x000379B8
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x00037A9F File Offset: 0x00037A9F
		private void TPAllToMeBtn(object sender, EventArgs e)
		{
			this.teleportPlayers(true, 0);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00037AAC File Offset: 0x00037AAC
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

		// Token: 0x060004FA RID: 1274 RVA: 0x00037B51 File Offset: 0x00037B51
		private void TPAllToJailBtn(object sender, EventArgs e)
		{
			this.toJail(true);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00037B5C File Offset: 0x00037B5C
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

		// Token: 0x060004FC RID: 1276 RVA: 0x00037BF8 File Offset: 0x00037BF8
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

		// Token: 0x060004FD RID: 1277 RVA: 0x00037F78 File Offset: 0x00037F78
		private void P1God_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				Booleans.P1GM = this.Player1GodChk.Checked;
				if (!this.Player1GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(0) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00037FC9 File Offset: 0x00037FC9
		private void P1Points_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				Booleans.P1UP = this.Player1UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00037FE3 File Offset: 0x00037FE3
		private void P1Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				Booleans.P1IA = this.Player1UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00037FFD File Offset: 0x00037FFD
		private void P1RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				Booleans.P1RF = this.Player1RapidFireChk.Checked;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00038018 File Offset: 0x00038018
		private void P1Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 1)
			{
				if (this.Player1OnlyCritChk.Checked)
				{
					this.Threads.m.WriteAByte(this.PCompPtr(0) + Offsets.PC_Crit, byte.MaxValue);
					return;
				}
				this.Threads.m.WriteByte(this.PCompPtr(0) + Offsets.PC_Crit, 0);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00005140 File Offset: 0x00005140
		private void P1AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00005140 File Offset: 0x00005140
		private void P1NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0003807C File Offset: 0x0003807C
		private void P2God_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 2)
			{
				Booleans.P2GM = this.Player2GodChk.Checked;
				if (!this.Player2GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(1) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000380CD File Offset: 0x000380CD
		private void P2Points_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 2)
			{
				Booleans.P2UP = this.Player2UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000380E7 File Offset: 0x000380E7
		private void P2Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 2)
			{
				Booleans.P2IA = this.Player2UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00038101 File Offset: 0x00038101
		private void P2RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 2)
			{
				Booleans.P2RF = this.Player2RapidFireChk.Checked;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0003811C File Offset: 0x0003811C
		private void P2Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 2)
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

		// Token: 0x06000509 RID: 1289 RVA: 0x00005140 File Offset: 0x00005140
		private void P2AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00005140 File Offset: 0x00005140
		private void P2NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000381C8 File Offset: 0x000381C8
		private void P3God_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 3)
			{
				Booleans.P3GM = this.Player3GodChk.Checked;
				if (!this.Player3GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(2) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00038219 File Offset: 0x00038219
		private void P3Points_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 3)
			{
				Booleans.P3UP = this.Player3UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00038233 File Offset: 0x00038233
		private void P3Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 3)
			{
				Booleans.P3IA = this.Player3UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0003824D File Offset: 0x0003824D
		private void P3RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 3)
			{
				Booleans.P3RF = this.Player3RapidFireChk.Checked;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00038268 File Offset: 0x00038268
		private void P3Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 3)
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

		// Token: 0x06000510 RID: 1296 RVA: 0x00005140 File Offset: 0x00005140
		private void P3AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00005140 File Offset: 0x00005140
		private void P3NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00038314 File Offset: 0x00038314
		private void P4God_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 4)
			{
				Booleans.P4GM = this.Player4GodChk.Checked;
				if (!this.Player4GodChk.Checked)
				{
					this.Threads.m.WriteInt32(this.PCompPtr(3) + Offsets.PC_GodMode, 32);
				}
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00038365 File Offset: 0x00038365
		private void P4Points_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 4)
			{
				Booleans.P4UP = this.Player4UnlimitedPointsChk.Checked;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0003837F File Offset: 0x0003837F
		private void P4Ammo_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 4)
			{
				Booleans.P4IA = this.Player4UnlimitedAmmoChk.Checked;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00038399 File Offset: 0x00038399
		private void P4RapidFire_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 4)
			{
				Booleans.P4RF = this.Player4RapidFireChk.Checked;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000383B4 File Offset: 0x000383B4
		private void P4Critical_CheckedChanged(object sender, EventArgs e)
		{
			if (WeaponIDForm.SelectedPlayer == 4)
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

		// Token: 0x06000517 RID: 1303 RVA: 0x00005140 File Offset: 0x00005140
		private void P4AutoFire_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00005140 File Offset: 0x00005140
		private void P4NoRecoil_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00005140 File Offset: 0x00005140
		private void MainBackgroundImage_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400051D RID: 1309
		public Threads Threads;

		// Token: 0x0400051E RID: 1310
		public Coords Coords;

		// Token: 0x0400051F RID: 1311
		private Memory m = new Memory();

		// Token: 0x04000520 RID: 1312
		public IntPtr baseAddress = IntPtr.Zero;

		// Token: 0x04000521 RID: 1313
		public static ulong BaseAddress = 0UL;

		// Token: 0x04000522 RID: 1314
		public static WeaponIDForm form = null;

		// Token: 0x04000523 RID: 1315
		private string pname = Process.GetCurrentProcess().ProcessName;

		// Token: 0x04000524 RID: 1316
		private char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

		// Token: 0x04000525 RID: 1317
		private Random rand = new Random();

		// Token: 0x04000526 RID: 1318
		public static int SelectedPlayer = 1;

		// Token: 0x04000527 RID: 1319
		public const int WM_NCHITTEST = 132;

		// Token: 0x04000528 RID: 1320
		public const int HT_CLIENT = 1;

		// Token: 0x04000529 RID: 1321
		public const int HT_CAPTION = 2;

		// Token: 0x0400052A RID: 1322
		public int p1 = 1;

		// Token: 0x0400052B RID: 1323
		public int p2 = 1;

		// Token: 0x0400052C RID: 1324
		public int p3 = 1;

		// Token: 0x0400052D RID: 1325
		public int p4 = 1;

		// Token: 0x020000B4 RID: 180
		public class ProcessInfo
		{
			// Token: 0x0600051D RID: 1309 RVA: 0x00042870 File Offset: 0x00042870
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
	}
}
