using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using RAW.Tool;
using RAW.UTILITIES;

namespace RAW.GLOBAL
{
	// Token: 0x020000BC RID: 188
	public class Threads
	{
		// Token: 0x0600053D RID: 1341
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600053E RID: 1342 RVA: 0x00043846 File Offset: 0x00043846
		public void SetMoney(int clientID)
		{
			this.m.WriteInt32(this.main.PCompPtr(clientID) + Offsets.PC_Points, 102771);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0004386A File Offset: 0x0004386A
		public void GodMode(int clientID)
		{
			this.m.WriteInt32(this.main.PCompPtr(clientID) + Offsets.PC_GodMode, 160);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00043890 File Offset: 0x00043890
		public void InfiniteAmmo(int clientID)
		{
			for (int i = 1; i < 7; i++)
			{
				this.m.WriteInt32(this.main.PCompPtr(clientID) + Offsets.PC_Ammo + (ulong)((long)i * 4L), 270);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000438D4 File Offset: 0x000438D4
		public void PointerThread()
		{
			for (;;)
			{
				try
				{
					if (!this.m.IsOpen())
					{
						this.m.AttackProcess("BlackOpsColdWar");
					}
					else
					{
						Variables.gameProc = Process.GetProcessesByName("BlackOpsColdWar")[0];
						Variables.Proc = Memory.OpenProcess(2035711U, false, Variables.gameProc.Id);
						Offsets.BaseAddress = (ulong)((long)Memory.GetBaseAddress("BlackOpsColdWar"));
						this.m.AttackProcess("BlackOpsColdWar");
						Offsets.PlayerCompPtr = this.m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase);
						Offsets.PlayerPedPtr = this.m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 8UL);
						Offsets.ZMGlobalBase = this.m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 96UL);
						Offsets.ZMBotBase = this.m.ReadInt64(Offsets.BaseAddress + Offsets.PlayerBase + 104UL);
						Offsets.ZMBotListBase = this.m.ReadInt64(Offsets.ZMBotBase + Offsets.ZM_Bot_List_Offset);
						Offsets.CamoPtr = this.m.GetPointerInt(Offsets.BaseAddress + Offsets.UnlockBase, new ulong[]
						{
							Offsets.CamoOffset
						}, 1);
						Offsets.ReticlesPtr = this.m.GetPointer(new ulong[]
						{
							Offsets.BaseAddress + Offsets.CamoBase,
							1048932UL
						});
						Offsets.CrystalsPtr = this.m.GetPointer(new ulong[]
						{
							Offsets.BaseAddress + Offsets.CamoBase,
							1078738UL
						});
					}
					Thread.Sleep(1000);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00043A9C File Offset: 0x00043A9C
		public void NameThread()
		{
			for (;;)
			{
				try
				{
					if (Booleans.GameAttached)
					{
						Memory memory = this.m;
						ulong playerCompPtr = Offsets.PlayerCompPtr;
						ulong pc_ArraySize_Offset = Offsets.PC_ArraySize_Offset;
						string text = memory.ReadString(playerCompPtr + 0UL + Offsets.PC_Name);
						if (text != "" && text != "UnnamedPlayer")
						{
							this.main.P1Name.Text = text;
							Booleans.InGame = true;
						}
						else
						{
							this.main.P1Name.Text = "OFFLINE";
							Booleans.InGame = false;
						}
						string text2 = this.m.ReadString(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset + Offsets.PC_Name);
						if (text2 != "" && text2 != "UnnamedPlayer")
						{
							this.main.P2Name.Text = text2;
						}
						else
						{
							this.main.P2Name.Text = "OFFLINE";
						}
						string text3 = this.m.ReadString(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * 2UL + Offsets.PC_Name);
						if (text3 != "" && text3 != "UnnamedPlayer")
						{
							this.main.P3Name.Text = text3;
						}
						else
						{
							this.main.P3Name.Text = "OFFLINE";
						}
						string text4 = this.m.ReadString(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * 3UL + Offsets.PC_Name);
						if (text4 != "" && text4 != "UnnamedPlayer")
						{
							this.main.P4Name.Text = text4;
						}
						else
						{
							this.main.P4Name.Text = "OFFLINE";
						}
					}
					else
					{
						this.main.P1Name.Text = "OFFLINE";
						this.main.P2Name.Text = "OFFLINE";
						this.main.P3Name.Text = "OFFLINE";
						this.main.P4Name.Text = "OFFLINE";
					}
					Thread.Sleep(1000);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00043CCC File Offset: 0x00043CCC
		public void LobbyThread()
		{
			for (;;)
			{
				try
				{
					if (Booleans.GameAttached)
					{
						if (this.main.OneShotZombiesChk.Checked)
						{
							for (int i = 0; i < 90; i++)
							{
								float num = this.m.ReadFloat(Offsets.ZMBotListBase + Offsets.ZM_Bot_Health + Offsets.ZM_Bot_ArraySize_Offset * (ulong)((long)i));
								if (num > 0f && num < 50000f)
								{
									this.m.WriteInt32(Offsets.ZMBotListBase + Offsets.ZM_Bot_Health + Offsets.ZM_Bot_ArraySize_Offset * (ulong)((long)i), 1);
								}
							}
						}
						if (Booleans.P1UP)
						{
							this.SetMoney(0);
						}
						if (Booleans.P2UP)
						{
							this.SetMoney(1);
						}
						if (Booleans.P3UP)
						{
							this.SetMoney(2);
						}
						if (Booleans.P4UP)
						{
							this.SetMoney(3);
						}
					}
					Thread.Sleep(100);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00043DB8 File Offset: 0x00043DB8
		public void NoSleepThread()
		{
			for (;;)
			{
				try
				{
					if (Booleans.GameAttached)
					{
						if (Booleans.P1GM)
						{
							this.m.WriteInt32(this.main.PCompPtr(0) + Offsets.PC_GodMode, 160);
						}
						if (Booleans.P2GM)
						{
							this.GodMode(1);
						}
						if (Booleans.P3GM)
						{
							this.GodMode(2);
						}
						if (Booleans.P4GM)
						{
							this.GodMode(3);
						}
						if (Booleans.P1TP)
						{
							for (int i = 0; i < 90; i++)
							{
								this.m.WriteVec3(Offsets.ZMBotListBase + Offsets.ZM_Bot_Coords + Offsets.ZM_Bot_ArraySize_Offset * (ulong)((long)i), Threads.P1Location);
							}
						}
						if (this.main.TPZC.Checked)
						{
							byte[] array = new byte[12];
							IntPtr intPtr;
							Memory.ReadProcessMemory(Variables.Proc, this.m.GetPointer(new ulong[]
							{
								Offsets.BaseAddress + Offsets.PlayerBase + 8UL,
								Offsets.PP_Coords
							}), array, 12UL, out intPtr);
							float num = BitConverter.ToSingle(array, 0);
							float num2 = BitConverter.ToSingle(array, 4);
							float num3 = BitConverter.ToSingle(array, 8);
							Threads.TPCLocation = new Vectors.Vec3.Vector3((float)Math.Round((double)num, 4), (float)Math.Round((double)num2, 4), (float)Math.Round((double)num3, 4));
							byte[] array2 = new byte[12];
							byte[] array3 = new byte[4];
							byte[] array4 = new byte[4];
							Memory.ReadProcessMemory(Variables.Proc, this.m.GetPointer(new ulong[]
							{
								Offsets.BaseAddress + Offsets.PlayerBase + 8UL,
								Offsets.PP_Heading_XY
							}), array3, 4UL, out intPtr);
							Memory.ReadProcessMemory(Variables.Proc, this.m.GetPointer(new ulong[]
							{
								Offsets.BaseAddress + Offsets.PlayerBase + 8UL,
								Offsets.PP_Heading_Z
							}), array4, 4UL, out intPtr);
							double num4 = -this.ConvertToRadians((double)BitConverter.ToSingle(array4, 0));
							double num5 = this.ConvertToRadians((double)BitConverter.ToSingle(array3, 0));
							float x = Convert.ToSingle(Math.Cos(num5) * Math.Cos(num4));
							float y = Convert.ToSingle(Math.Sin(num5) * Math.Cos(num4));
							float z = Convert.ToSingle(Math.Sin(num4));
							Vectors.Vec3.Vector3 vector = Threads.TPCLocation + new Vectors.Vec3.Vector3(x, y, z) * (float)Variables.tpDistance;
							Buffer.BlockCopy(BitConverter.GetBytes(vector.X), 0, array2, 0, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(vector.Y), 0, array2, 4, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(vector.Z), 0, array2, 8, 4);
							for (int j = 0; j < 90; j++)
							{
								Memory.WriteProcessMemory(Variables.Proc, Offsets.ZMBotListBase + Offsets.ZM_Bot_ArraySize_Offset * (ulong)((long)j) + Offsets.ZM_Bot_Coords, array2, 12UL, out intPtr);
							}
						}
					}
					Thread.Sleep(1);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0004409C File Offset: 0x0004409C
		public void AmmoThread()
		{
			for (;;)
			{
				try
				{
					if (Booleans.GameAttached)
					{
						if (Booleans.P1IA)
						{
							this.InfiniteAmmo(0);
						}
						if (Booleans.P2IA)
						{
							this.InfiniteAmmo(1);
						}
						if (Booleans.P3IA)
						{
							this.InfiniteAmmo(2);
						}
						if (Booleans.P4IA)
						{
							this.InfiniteAmmo(3);
						}
					}
					Thread.Sleep(500);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00044114 File Offset: 0x00044114
		public double ConvertToRadians(double angle)
		{
			return 0.017453292519943295 * angle;
		}

		// Token: 0x04000674 RID: 1652
		public Memory m = new Memory();

		// Token: 0x04000675 RID: 1653
		public Offsets Offsets = new Offsets();

		// Token: 0x04000676 RID: 1654
		public MainForm main = MainForm.form;

		// Token: 0x04000677 RID: 1655
		public static Vectors.Vec3.Vector3 TPCLocation;

		// Token: 0x04000678 RID: 1656
		public static Vectors.Vec3.Vector3 P1Location;

		// Token: 0x04000679 RID: 1657
		public static Vectors.Vec3.Vector3 P2Location;

		// Token: 0x0400067A RID: 1658
		public static Vectors.Vec3.Vector3 P3Location;

		// Token: 0x0400067B RID: 1659
		public static Vectors.Vec3.Vector3 P4Location;

		// Token: 0x0400067C RID: 1660
		protected string OneShotZombiesChk;

		// Token: 0x0400067D RID: 1661
		public static Vectors.Vec3.Vector3 updatedPlayerPos;

		// Token: 0x0400067E RID: 1662
		public static Vectors.Vec3.Vector3 freePosition;
	}
}
