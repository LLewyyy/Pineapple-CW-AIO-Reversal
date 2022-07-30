using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using qC;
using qL;
using tA;

namespace MainDriver
{
	// Token: 0x0200001E RID: 30
	public class gV
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000709A File Offset: 0x0000709A
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000070A2 File Offset: 0x000070A2
		internal qK ho { get; private set; }

		// Token: 0x060000E7 RID: 231 RVA: 0x000070AB File Offset: 0x000070AB
		private void hF(qK hG)
		{
			if (hG == null)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.ho = hG;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000070C7 File Offset: 0x000070C7
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000070CF File Offset: 0x000070CF
		public ulong BaseAddress { get; private set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000070D8 File Offset: 0x000070D8
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000070E0 File Offset: 0x000070E0
		public ulong hw { get; private set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000070E9 File Offset: 0x000070E9
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000070F1 File Offset: 0x000070F1
		public ulong hA { get; private set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000070FA File Offset: 0x000070FA
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00007102 File Offset: 0x00007102
		public string hE { get; private set; }

		// Token: 0x060000F0 RID: 240 RVA: 0x0000710C File Offset: 0x0000710C
		private bool hH(string hI)
		{
			if (hI == "")
			{
				throw new ArgumentNullException("", "Game is null");
			}
			Process[] processesByName = Process.GetProcessesByName(hI);
			bool result;
			if (processesByName.Length != 0)
			{
				this.hA = (ulong)((long)processesByName[0].Id);
				this.hE = hI;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007164 File Offset: 0x00007164
		public bool proc(string hK)
		{
			FileInfo ru = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
			qK qK = new qK(new rg
			{
				rq = gV.he,
				ry = "\\\\.\\\\" + gV.he,
				ru = ru,
				rC = tz.N
			}, null);
			if (qK.Load())
			{
				qK.rd(qK.Config.ry, qK.Config.rG);
				try
				{
					if (!qK.IO.IsConnected)
					{
						return false;
					}
					this.hF(qK);
					if (!this.hH(hK))
					{
						return false;
					}
					this.BaseAddress = this.jP();
					this.hw = this.jQ();
					return true;
				}
				catch (Exception)
				{
				}
				return false;
			}
			return false;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007240 File Offset: 0x00007240
		public bool hL(ulong hM)
		{
			return hM != 0UL && hM > 1048576UL && hM < 36028797018963967UL;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000725C File Offset: 0x0000725C
		private byte[] hN(ulong hO, int hP)
		{
			if (!this.ho.IO.IsConnected)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			byte[] result;
			if (!this.hL(hO))
			{
				result = new byte[hP];
			}
			else
			{
				qB ioData = default(qB);
				uint ioDataSize = (uint)Marshal.SizeOf<qB>();
				GCHandle gchandle = GCHandle.Alloc(new byte[hP], GCHandleType.Pinned);
				IntPtr intPtr = gchandle.AddrOfPinnedObject();
				if (!gchandle.IsAllocated)
				{
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
				}
				ioData.qD = this.hA;
				ioData.qG = hP;
				ioData.qF = (ulong)intPtr.ToInt64();
				ioData.qE = hO;
				if (this.ho.IO.TryIoControl<qB>(gV.gY, ioData, (int)ioDataSize))
				{
					byte[] array = (byte[])gchandle.Target;
					gchandle.Free();
					result = array;
				}
				else
				{
					gchandle.Free();
					result = new byte[hP];
				}
			}
			return result;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007345 File Offset: 0x00007345
		public byte[] ReadBytes(ulong hR, int hS = 4)
		{
			return this.hN(hR, hS);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000734F File Offset: 0x0000734F
		public byte ReadByte(ulong hU)
		{
			return this.hN(hU, 1)[0];
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000735B File Offset: 0x0000735B
		public bool ReadBool(ulong hW)
		{
			return this.hN(hW, 1)[0] > 0;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000736A File Offset: 0x0000736A
		public short ReadInt16(ulong hY)
		{
			return BitConverter.ToInt16(this.ReadBytes(hY, 2), 0);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000737A File Offset: 0x0000737A
		public ushort ReadUInt16(ulong hY)
		{
			return BitConverter.ToUInt16(this.ReadBytes(hY, 2), 0);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000738A File Offset: 0x0000738A
		public int ReadInt32(ulong ia)
		{
			return BitConverter.ToInt32(this.ReadBytes(ia, 4), 0);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000739A File Offset: 0x0000739A
		public uint ReadUInt32(ulong ic)
		{
			return BitConverter.ToUInt32(this.ReadBytes(ic, 4), 0);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000073AA File Offset: 0x000073AA
		public ulong ReadInt64(ulong ie)
		{
			return (ulong)BitConverter.ToInt64(this.ReadBytes(ie, 8), 0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000073BA File Offset: 0x000073BA
		public ulong ReadUInt64(ulong ie)
		{
			return BitConverter.ToUInt64(this.ReadBytes(ie, 8), 0);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000073CA File Offset: 0x000073CA
		public float ReadFloat(ulong ig)
		{
			return BitConverter.ToSingle(this.ReadBytes(ig, 4), 0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000073DC File Offset: 0x000073DC
		public gV.AU.CK.Ba ih(ulong ii)
		{
			byte[] array = this.ReadBytes(ii, 8);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new gV.AU.CK.Ba(array2[0], array2[1]);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007414 File Offset: 0x00007414
		public gV.AU.CL.Bb ij(ulong ik)
		{
			byte[] array = this.ReadBytes(ik, 12);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new gV.AU.CL.Bb(array2[0], array2[1], array2[2]);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007450 File Offset: 0x00007450
		public gV.AU.CM.Bc il(ulong im)
		{
			byte[] array = this.ReadBytes(im, 16);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new gV.AU.CM.Bc(array2[0], array2[1], array2[2], array2[3]);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000748F File Offset: 0x0000748F
		public double @in(ulong io)
		{
			return BitConverter.ToDouble(this.ReadBytes(io, 8), 0);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000074A0 File Offset: 0x000074A0
		public ulong GetPointer(params ulong[] iq)
		{
			ulong num = 0UL;
			for (int i = 0; i <= iq.Length - 1; i++)
			{
				if (i != iq.Length - 1)
				{
					num = this.ReadInt64(num + iq[i]);
				}
				else
				{
					num += iq[i];
				}
			}
			return num;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000074E4 File Offset: 0x000074E4
		public string ir(ulong @is, int it)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.ReadBytes(@is, it);
			for (int i = 0; i < it; i++)
			{
				if (array[i] == 0)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007534 File Offset: 0x00007534
		public string ReadNullTerminatedString(ulong address, int length = 255)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.ReadBytes(address, length);
			for (int i = 0; i < length; i++)
			{
				if (array[i] == 0 || array[i] == 10)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000758D File Offset: 0x0000758D
		public string ReadString(ulong iy, int iz)
		{
			return new ASCIIEncoding().GetString(this.ReadBytes(iy, iz * 2));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000075A4 File Offset: 0x000075A4
		public gV.AU.CN.Jc iA(ulong iB)
		{
			byte[] array = this.ReadBytes(iB, 64);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new gV.AU.CN.Jc(array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7], array2[8], array2[9], array2[10], array2[11], array2[12], array2[13], array2[14], array2[15]);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007610 File Offset: 0x00007610
		private void iC(ulong iD, byte[] iE, bool iF = false)
		{
			if (!this.ho.IO.IsConnected)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			if (this.hL(iD))
			{
				int qG = iE.Length;
				qH ioData = default(qH);
				uint ioDataSize = (uint)Marshal.SizeOf<qH>();
				GCHandle gchandle = GCHandle.Alloc(iE, GCHandleType.Pinned);
				if (!gchandle.IsAllocated)
				{
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Write(ulong Address, byte[] Value, bool ProtectionBypass = false).");
				}
				ioData.qD = this.hA;
				ioData.qG = qG;
				ioData.qI = (ulong)gchandle.AddrOfPinnedObject().ToInt64();
				ioData.qE = iD;
				if (!iF)
				{
					bool flag = this.ho.IO.TryIoControl<qH>(gV.gZ, ioData, (int)ioDataSize);
				}
				gchandle.Free();
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000076DB File Offset: 0x000076DB
		public void WriteXBytes(ulong iH, byte[] iI, bool iJ = false)
		{
			this.iC(iH, iI, iJ);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000076E8 File Offset: 0x000076E8
		public void WriteByte(ulong iL, byte iM, bool iN = false)
		{
			byte[] bytes = BitConverter.GetBytes((short)iM);
			this.WriteXBytes(iL, bytes, iN);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007708 File Offset: 0x00007708
		public void WriteBool(ulong iP, bool iQ, bool iR = false)
		{
			byte[] bytes = BitConverter.GetBytes(iQ);
			this.WriteXBytes(iP, bytes, iR);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007728 File Offset: 0x00007728
		public void WriteShort(ulong iT, short iU, bool iV = false)
		{
			byte[] bytes = BitConverter.GetBytes(iU);
			this.WriteXBytes(iT, bytes, iV);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007748 File Offset: 0x00007748
		public void WriteInt(ulong iX, int iY, bool iZ = false)
		{
			byte[] bytes = BitConverter.GetBytes(iY);
			this.WriteXBytes(iX, bytes, iZ);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007768 File Offset: 0x00007768
		public ulong GetPointerOffsets(ulong pointer, ulong[] offsets, bool makeFalse = false)
		{
			ulong num = pointer;
			for (int i = 0; i < offsets.Length; i++)
			{
				num = this.ReadInt64(num) + offsets[i];
			}
			return num;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007794 File Offset: 0x00007794
		public void WriteFloat(ulong iX, float iY, bool iZ = false)
		{
			byte[] bytes = BitConverter.GetBytes(iY);
			this.WriteXBytes(iX, bytes, iZ);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000077B4 File Offset: 0x000077B4
		public void WriteUInt64(ulong jb, ulong jc, bool jd = false)
		{
			new byte[8];
			byte[] bytes = BitConverter.GetBytes(jc);
			this.WriteXBytes(jb, bytes, jd);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000077D8 File Offset: 0x000077D8
		public void WriteLong(ulong jb, long jc, bool jd = false)
		{
			new byte[8];
			byte[] bytes = BitConverter.GetBytes(jc);
			this.WriteXBytes(jb, bytes, jd);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000077FC File Offset: 0x000077FC
		public void xV(ulong jf, float jg, bool jh = false)
		{
			byte[] bytes = BitConverter.GetBytes(jg);
			this.WriteXBytes(jf, bytes, jh);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000781C File Offset: 0x0000781C
		public void ji(ulong jj, gV.AU.CK.Ba jk, bool jl = false)
		{
			byte[] array = new byte[gV.AU.CK.Ba.Fz];
			Buffer.BlockCopy(BitConverter.GetBytes(jk.Fx), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(jk.Fy), 0, array, 4, 4);
			this.WriteXBytes(jj, array, jl);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007868 File Offset: 0x00007868
		public void jm(ulong jn, gV.AU.CL.Bb jo, bool jp = false)
		{
			byte[] array = new byte[gV.AU.CL.Bb.Fz];
			Buffer.BlockCopy(BitConverter.GetBytes(jo.Fx), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(jo.Fy), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(jo.GS), 0, array, 8, 4);
			this.WriteXBytes(jn, array, jp);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000078C8 File Offset: 0x000078C8
		public void jq(ulong jr, gV.AU.CM.Bc js, bool jt = false)
		{
			byte[] array = new byte[gV.AU.CK.Ba.Fz];
			Buffer.BlockCopy(BitConverter.GetBytes(js.Fx), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(js.Fy), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(js.GS), 0, array, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(js.Ib), 0, array, 12, 4);
			this.WriteXBytes(jr, array, jt);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000793C File Offset: 0x0000793C
		public void ju(ulong jv, double jw, bool jx = false)
		{
			byte[] bytes = BitConverter.GetBytes(jw);
			this.WriteXBytes(jv, bytes, jx);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000795C File Offset: 0x0000795C
		public void jy(ulong jz, string jA, bool jB = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			this.WriteXBytes(jz, asciiencoding.GetBytes(jA), jB);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007980 File Offset: 0x00007980
		public void WriteString(ulong jD, string jE, bool jF = false, bool nullTerminator = true)
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			if (nullTerminator)
			{
				this.WriteByte(jD + (ulong)((long)utf8Encoding.GetBytes(jE).Length), 0, jF);
			}
			this.WriteXBytes(jD, utf8Encoding.GetBytes(jE), jF);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000079BC File Offset: 0x000079BC
		public void jG(ulong jH, string jI, bool jJ = false)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			this.WriteXBytes(jH, unicodeEncoding.GetBytes(jI), jJ);
			this.WriteByte(jH + (ulong)((long)(jI.Length * 2)), 0, jJ);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000079F4 File Offset: 0x000079F4
		public void jK(ulong jL, bool jM, bool jN = false)
		{
			byte[] iE;
			if (jM)
			{
				iE = new byte[]
				{
					85,
					72,
					139,
					236,
					184,
					1,
					0,
					0,
					0,
					93,
					195
				};
			}
			else
			{
				iE = new byte[]
				{
					85,
					72,
					139,
					236,
					184,
					0,
					0,
					0,
					0,
					93,
					195
				};
			}
			this.iC(jL, iE, jN);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007A38 File Offset: 0x00007A38
		public ulong jO()
		{
			if (!this.ho.IO.IsConnected)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			qB ioData = default(qB);
			uint ioDataSize = (uint)Marshal.SizeOf<qB>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.qD = this.hA;
			ioData.qF = (ulong)intPtr.ToInt64();
			ioData.qG = 8;
			if (this.ho.IO.TryIoControl<qB>(gV.hd, ioData, (int)ioDataSize))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007ADC File Offset: 0x00007ADC
		public ulong jP()
		{
			if (!this.ho.IO.IsConnected)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			qB ioData = default(qB);
			uint ioDataSize = (uint)Marshal.SizeOf<qB>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.qD = this.hA;
			ioData.qF = (ulong)intPtr.ToInt64();
			ioData.qG = 8;
			if (this.ho.IO.TryIoControl<qB>(gV.ha, ioData, (int)ioDataSize))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007B80 File Offset: 0x00007B80
		public ulong jQ()
		{
			if (!this.ho.IO.IsConnected)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			qB ioData = default(qB);
			uint ioDataSize = (uint)Marshal.SizeOf<qB>();
			GCHandle gchandle = GCHandle.Alloc(new byte[8], GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.qD = this.hA;
			ioData.qF = (ulong)intPtr.ToInt64();
			ioData.qG = 8;
			if (this.ho.IO.TryIoControl<qB>(gV.hb, ioData, (int)ioDataSize))
			{
				return (ulong)BitConverter.ToInt64((byte[])gchandle.Target, 0);
			}
			return 0UL;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007C24 File Offset: 0x00007C24
		public ulong jR(ulong jS, ulong jT, ulong jU)
		{
			for (ulong num = jS; num < jT; num += 2000UL)
			{
				byte[] array = this.hN(num, 2000);
				for (int i = 0; i < array.Length; i++)
				{
					ulong num2 = 0UL;
					if (array[i] == 0)
					{
						while (i <= array.Length - 1 && array[i] == 0)
						{
							num2 += 1UL;
							i++;
							if (num2 >= jU)
							{
								return num + (ulong)((long)i - (long)num2);
							}
						}
					}
				}
			}
			return 0UL;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00007C92 File Offset: 0x00007C92
		public bool IsValidAddr(ulong Address)
		{
			return Address != 0UL && Address > 7696581394432UL && Address < 36028797018963967UL;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007CB4 File Offset: 0x00007CB4
		public ulong PatternScan(ulong jW, ulong jX, byte[] jY, string[] jZ, int ka)
		{
			byte[] array = new byte[jX - jW];
			ulong num = jX - jW;
			if (this.hk == null)
			{
				if (num >= 3899391UL)
				{
					ulong num2 = 0UL;
					while (num2 < num)
					{
						if (num - num2 > 3899391UL)
						{
							this.hN(jW + num2, 3899391).CopyTo(array, (int)num2);
							num2 += 3899391UL;
						}
						else
						{
							ulong num3 = num - num2;
							this.hN(jW + num2, (int)num3).CopyTo(array, (int)num3);
							num2 += 3899391UL;
						}
					}
				}
				else
				{
					array = this.hN(jW, (int)(jX - jW));
				}
				this.hk = array;
			}
			else
			{
				array = this.hk;
			}
			for (int i = 0; i < array.Length; i += ka)
			{
				int num4 = 0;
				int num5 = i;
				while (num5 < jY.Length + i && (array[num5] == jY[num4] || jZ[num4] == "?"))
				{
					num4++;
					if (num4 == jY.Length)
					{
						return jW + (ulong)((long)i);
					}
					num5++;
				}
			}
			return 0UL;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00007DBC File Offset: 0x00007DBC
		public ulong[] FindBytes(byte?[] needle, ulong startAddress, ulong endAddress, bool firstMatch = false, int bufferSize = 65535)
		{
			List<ulong> list = new List<ulong>();
			ulong num = startAddress;
			int num2 = 0;
			do
			{
				try
				{
					byte[] array = this.hN(num, bufferSize);
					for (int i = 0; i < array.Length; i++)
					{
						if (needle[num2] == null)
						{
							num2++;
						}
						else
						{
							byte? b = needle[num2];
							int? num3 = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
							int num4 = (int)array[i];
							if (num3.GetValueOrDefault() == num4 & num3 != null)
							{
								num2++;
								if (num2 == needle.Length)
								{
									list.Add(num + (ulong)((long)i) - (ulong)((long)needle.Length) + 1UL);
									if (firstMatch)
									{
										return list.ToArray();
									}
									num2 = 0;
								}
							}
							else
							{
								num2 = 0;
							}
						}
					}
				}
				catch
				{
					break;
				}
				num += (ulong)((long)bufferSize);
			}
			while (num <= endAddress);
			if (list.Count == 0)
			{
				list.Add(0UL);
			}
			return list.ToArray();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007EC8 File Offset: 0x00007EC8
		public void universalResolve(ref ulong offset, int addBeforeDeref, int addAfterDeref)
		{
			long num = (long)(offset + (ulong)((long)addBeforeDeref));
			long num2 = (long)this.ReadInt32((ulong)num);
			ulong num3 = (ulong)(num + num2 + (long)addAfterDeref);
			offset = num3;
		}

		// Token: 0x0400009B RID: 155
		public static gV gX;

		// Token: 0x0400009C RID: 156
		public static uint gY = 2237444U;

		// Token: 0x0400009D RID: 157
		public static uint gZ = 2237448U;

		// Token: 0x0400009E RID: 158
		public static uint ha = 2237452U;

		// Token: 0x0400009F RID: 159
		public static uint hb = 2237456U;

		// Token: 0x040000A0 RID: 160
		public static uint hc = 2237460U;

		// Token: 0x040000A1 RID: 161
		public static uint hd = 2237464U;

		// Token: 0x040000A2 RID: 162
		public static string he = "PornhubDriver";

		// Token: 0x040000A3 RID: 163
		public byte[] hk;

		// Token: 0x0200001F RID: 31
		public class AU
		{
			// Token: 0x02000020 RID: 32
			public class CK
			{
				// Token: 0x02000021 RID: 33
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Ba
				{
					// Token: 0x06000126 RID: 294 RVA: 0x00007F43 File Offset: 0x00007F43
					public Ba(float value)
					{
						this.Fx = value;
						this.Fy = value;
					}

					// Token: 0x06000127 RID: 295 RVA: 0x00007F53 File Offset: 0x00007F53
					public Ba(float x, float y)
					{
						this.Fx = x;
						this.Fy = y;
					}

					// Token: 0x17000041 RID: 65
					// (get) Token: 0x06000128 RID: 296 RVA: 0x00007F63 File Offset: 0x00007F63
					public bool FF
					{
						get
						{
							return (double)this.Fx == 0.0 && (double)this.Fy == 0.0;
						}
					}

					// Token: 0x06000129 RID: 297 RVA: 0x00007F8B File Offset: 0x00007F8B
					public float FG()
					{
						return (float)Math.Sqrt((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy);
					}

					// Token: 0x0600012A RID: 298 RVA: 0x00007FB2 File Offset: 0x00007FB2
					public float FH()
					{
						return (float)((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy);
					}

					// Token: 0x0600012B RID: 299 RVA: 0x00007FD4 File Offset: 0x00007FD4
					public void FI()
					{
						float num = this.FG();
						if ((double)num != 0.0)
						{
							float num2 = 1f / num;
							this.Fx *= num2;
							this.Fy *= num2;
						}
					}

					// Token: 0x0600012C RID: 300 RVA: 0x0000801B File Offset: 0x0000801B
					public float[] FJ()
					{
						return new float[]
						{
							this.Fx,
							this.Fy
						};
					}

					// Token: 0x0600012D RID: 301 RVA: 0x00008035 File Offset: 0x00008035
					public static gV.AU.CK.Ba FK(gV.AU.CK.Ba FL, gV.AU.CK.Ba FM)
					{
						return new gV.AU.CK.Ba(FL.Fx + FM.Fx, FL.Fy + FM.Fy);
					}

					// Token: 0x0600012E RID: 302 RVA: 0x00008056 File Offset: 0x00008056
					public static gV.AU.CK.Ba FN(gV.AU.CK.Ba FO, gV.AU.CK.Ba FP)
					{
						return new gV.AU.CK.Ba(FO.Fx - FP.Fx, FO.Fy - FP.Fy);
					}

					// Token: 0x0600012F RID: 303 RVA: 0x00008077 File Offset: 0x00008077
					public static gV.AU.CK.Ba FQ(gV.AU.CK.Ba FR, float FS)
					{
						return new gV.AU.CK.Ba(FR.Fx * FS, FR.Fy * FS);
					}

					// Token: 0x06000130 RID: 304 RVA: 0x0000808E File Offset: 0x0000808E
					public static gV.AU.CK.Ba FQ(gV.AU.CK.Ba FT, gV.AU.CK.Ba FU)
					{
						return new gV.AU.CK.Ba(FT.Fx * FU.Fx, FT.Fy * FU.Fy);
					}

					// Token: 0x06000131 RID: 305 RVA: 0x000080AF File Offset: 0x000080AF
					public static gV.AU.CK.Ba FV(gV.AU.CK.Ba FW, float FX)
					{
						return new gV.AU.CK.Ba(FW.Fx / FX, FW.Fy / FX);
					}

					// Token: 0x06000132 RID: 306 RVA: 0x000080C6 File Offset: 0x000080C6
					public static gV.AU.CK.Ba FV(gV.AU.CK.Ba FY, gV.AU.CK.Ba FZ)
					{
						return new gV.AU.CK.Ba(FY.Fx / FZ.Fx, FY.Fy / FZ.Fy);
					}

					// Token: 0x06000133 RID: 307 RVA: 0x000080E7 File Offset: 0x000080E7
					public static gV.AU.CK.Ba Ga(gV.AU.CK.Ba Gb)
					{
						return new gV.AU.CK.Ba(-Gb.Fx, -Gb.Fy);
					}

					// Token: 0x06000134 RID: 308 RVA: 0x000080FC File Offset: 0x000080FC
					public static gV.AU.CK.Ba Gc(gV.AU.CK.Ba Gd)
					{
						return new gV.AU.CK.Ba(((double)Gd.Fx > 0.0) ? Gd.Fx : (-Gd.Fx), ((double)Gd.Fy > 0.0) ? Gd.Fy : (-Gd.Fy));
					}

					// Token: 0x06000135 RID: 309 RVA: 0x00008150 File Offset: 0x00008150
					public static gV.AU.CK.Ba Ge(gV.AU.CK.Ba Gf, gV.AU.CK.Ba Gg, gV.AU.CK.Ba Gh)
					{
						float fx = Gf.Fx;
						float num = ((double)fx > (double)Gh.Fx) ? Gh.Fx : fx;
						float x = ((double)num < (double)Gg.Fx) ? Gg.Fx : num;
						float fy = Gf.Fy;
						float num2 = ((double)fy > (double)Gh.Fy) ? Gh.Fy : fy;
						float y = ((double)num2 < (double)Gg.Fy) ? Gg.Fy : num2;
						return new gV.AU.CK.Ba(x, y);
					}

					// Token: 0x06000136 RID: 310 RVA: 0x000081C8 File Offset: 0x000081C8
					public static float Do(gV.AU.CK.Ba Gi, gV.AU.CK.Ba Gj)
					{
						double num = (double)Gi.Fx - (double)Gj.Fx;
						float num2 = Gi.Fy - Gj.Fy;
						return (float)Math.Sqrt(num * num + (double)num2 * (double)num2);
					}

					// Token: 0x06000137 RID: 311 RVA: 0x00008200 File Offset: 0x00008200
					public static float Dl(gV.AU.CK.Ba Gk, gV.AU.CK.Ba Gl)
					{
						return (float)((double)Gk.Fx * (double)Gl.Fx + (double)Gk.Fy * (double)Gl.Fy);
					}

					// Token: 0x06000138 RID: 312 RVA: 0x00008035 File Offset: 0x00008035
					public static gV.AU.CK.Ba DA(gV.AU.CK.Ba Gm, gV.AU.CK.Ba Gn)
					{
						return new gV.AU.CK.Ba(Gm.Fx + Gn.Fx, Gm.Fy + Gn.Fy);
					}

					// Token: 0x06000139 RID: 313 RVA: 0x0000808E File Offset: 0x0000808E
					public static gV.AU.CK.Ba DG(gV.AU.CK.Ba Go, gV.AU.CK.Ba Gp)
					{
						return new gV.AU.CK.Ba(Go.Fx * Gp.Fx, Go.Fy * Gp.Fy);
					}

					// Token: 0x0600013A RID: 314 RVA: 0x00008222 File Offset: 0x00008222
					public static gV.AU.CK.Ba Gq(gV.AU.CK.Ba Gr)
					{
						return Gr;
					}

					// Token: 0x0600013B RID: 315 RVA: 0x00008056 File Offset: 0x00008056
					public static gV.AU.CK.Ba DD(gV.AU.CK.Ba Gs, gV.AU.CK.Ba Gt)
					{
						return new gV.AU.CK.Ba(Gs.Fx - Gt.Fx, Gs.Fy - Gt.Fy);
					}

					// Token: 0x0600013C RID: 316 RVA: 0x000080E7 File Offset: 0x000080E7
					public static gV.AU.CK.Ba Gu(gV.AU.CK.Ba Gv)
					{
						return new gV.AU.CK.Ba(-Gv.Fx, -Gv.Fy);
					}

					// Token: 0x0600013D RID: 317 RVA: 0x00008225 File Offset: 0x00008225
					public static gV.AU.CK.Ba DG(float Gw, gV.AU.CK.Ba Gx)
					{
						return new gV.AU.CK.Ba(Gx.Fx * Gw, Gx.Fy * Gw);
					}

					// Token: 0x0600013E RID: 318 RVA: 0x00008077 File Offset: 0x00008077
					public static gV.AU.CK.Ba DG(gV.AU.CK.Ba Gy, float Gz)
					{
						return new gV.AU.CK.Ba(Gy.Fx * Gz, Gy.Fy * Gz);
					}

					// Token: 0x0600013F RID: 319 RVA: 0x000080AF File Offset: 0x000080AF
					public static gV.AU.CK.Ba DN(gV.AU.CK.Ba GA, float GB)
					{
						return new gV.AU.CK.Ba(GA.Fx / GB, GA.Fy / GB);
					}

					// Token: 0x06000140 RID: 320 RVA: 0x0000823C File Offset: 0x0000823C
					public static gV.AU.CK.Ba DN(float GC, gV.AU.CK.Ba GD)
					{
						return new gV.AU.CK.Ba(GC / GD.Fx, GC / GD.Fy);
					}

					// Token: 0x06000141 RID: 321 RVA: 0x000080C6 File Offset: 0x000080C6
					public static gV.AU.CK.Ba DN(gV.AU.CK.Ba GE, gV.AU.CK.Ba GF)
					{
						return new gV.AU.CK.Ba(GE.Fx / GF.Fx, GE.Fy / GF.Fy);
					}

					// Token: 0x06000142 RID: 322 RVA: 0x00008253 File Offset: 0x00008253
					public static gV.AU.CK.Ba DA(gV.AU.CK.Ba GG, float GH)
					{
						return new gV.AU.CK.Ba(GG.Fx + GH, GG.Fy + GH);
					}

					// Token: 0x06000143 RID: 323 RVA: 0x0000826A File Offset: 0x0000826A
					public static gV.AU.CK.Ba DA(float GI, gV.AU.CK.Ba GJ)
					{
						return new gV.AU.CK.Ba(GI + GJ.Fx, GI + GJ.Fy);
					}

					// Token: 0x06000144 RID: 324 RVA: 0x00008281 File Offset: 0x00008281
					public static gV.AU.CK.Ba DD(gV.AU.CK.Ba GK, float GL)
					{
						return new gV.AU.CK.Ba(GK.Fx - GL, GK.Fy - GL);
					}

					// Token: 0x06000145 RID: 325 RVA: 0x00008298 File Offset: 0x00008298
					public static gV.AU.CK.Ba DD(float GM, gV.AU.CK.Ba GN)
					{
						return new gV.AU.CK.Ba(GM - GN.Fx, GM - GN.Fy);
					}

					// Token: 0x06000146 RID: 326 RVA: 0x000082AF File Offset: 0x000082AF
					public static bool DQ(gV.AU.CK.Ba GO, gV.AU.CK.Ba GP)
					{
						return (double)GO.Fx == (double)GP.Fx && (double)GO.Fy == (double)GP.Fy;
					}

					// Token: 0x06000147 RID: 327 RVA: 0x000082D3 File Offset: 0x000082D3
					public static bool DT(gV.AU.CK.Ba GQ, gV.AU.CK.Ba GR)
					{
						return (double)GQ.Fx != (double)GR.Fx || (double)GQ.Fy != (double)GR.Fy;
					}

					// Token: 0x06000148 RID: 328 RVA: 0x000082FA File Offset: 0x000082FA
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", this.Fx, this.Fy);
					}

					// Token: 0x040000A4 RID: 164
					public float Fx;

					// Token: 0x040000A5 RID: 165
					public float Fy;

					// Token: 0x040000A6 RID: 166
					public static readonly int Fz = Marshal.SizeOf<gV.AU.CK.Ba>();

					// Token: 0x040000A7 RID: 167
					public static readonly gV.AU.CK.Ba FA = new gV.AU.CK.Ba(0f);

					// Token: 0x040000A8 RID: 168
					public static readonly gV.AU.CK.Ba FB = new gV.AU.CK.Ba(1f, 0f);

					// Token: 0x040000A9 RID: 169
					public static readonly gV.AU.CK.Ba FC = new gV.AU.CK.Ba(0f, 1f);

					// Token: 0x040000AA RID: 170
					public static readonly gV.AU.CK.Ba FD = new gV.AU.CK.Ba(1f, 1f);
				}
			}

			// Token: 0x02000022 RID: 34
			public class CL
			{
				// Token: 0x02000023 RID: 35
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Bb
				{
					// Token: 0x0600014B RID: 331 RVA: 0x00008386 File Offset: 0x00008386
					public Bb(float value)
					{
						this.Fx = value;
						this.Fy = value;
						this.GS = value;
					}

					// Token: 0x0600014C RID: 332 RVA: 0x0000839D File Offset: 0x0000839D
					public Bb(float x, float y, float z)
					{
						this.Fx = x;
						this.Fy = y;
						this.GS = z;
					}

					// Token: 0x17000042 RID: 66
					// (get) Token: 0x0600014D RID: 333 RVA: 0x000083B4 File Offset: 0x000083B4
					public bool FF
					{
						get
						{
							return (double)this.Fx == 0.0 && (double)this.Fy == 0.0 && (double)this.GS == 0.0;
						}
					}

					// Token: 0x0600014E RID: 334 RVA: 0x000083EE File Offset: 0x000083EE
					public float FG()
					{
						return (float)Math.Sqrt((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy + (double)this.GS * (double)this.GS);
					}

					// Token: 0x0600014F RID: 335 RVA: 0x00008425 File Offset: 0x00008425
					public float FH()
					{
						return (float)((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy + (double)this.GS * (double)this.GS);
					}

					// Token: 0x06000150 RID: 336 RVA: 0x00008458 File Offset: 0x00008458
					public void FI()
					{
						float num = this.FG();
						if ((double)num != 0.0)
						{
							float num2 = 1f / num;
							this.Fx *= num2;
							this.Fy *= num2;
							this.GS *= num2;
						}
					}

					// Token: 0x06000151 RID: 337 RVA: 0x000084AD File Offset: 0x000084AD
					public float[] FJ()
					{
						return new float[]
						{
							this.Fx,
							this.Fy,
							this.GS
						};
					}

					// Token: 0x06000152 RID: 338 RVA: 0x000084D0 File Offset: 0x000084D0
					public static gV.AU.CL.Bb FK(gV.AU.CL.Bb Hc, gV.AU.CL.Bb Hd)
					{
						return new gV.AU.CL.Bb(Hc.Fx + Hd.Fx, Hc.Fy + Hd.Fy, Hc.GS + Hd.GS);
					}

					// Token: 0x06000153 RID: 339 RVA: 0x000084FE File Offset: 0x000084FE
					public static gV.AU.CL.Bb FN(gV.AU.CL.Bb He, gV.AU.CL.Bb Hf)
					{
						return new gV.AU.CL.Bb(He.Fx - Hf.Fx, He.Fy - Hf.Fy, He.GS - Hf.GS);
					}

					// Token: 0x06000154 RID: 340 RVA: 0x0000852C File Offset: 0x0000852C
					public static gV.AU.CL.Bb FQ(gV.AU.CL.Bb Hg, float Hh)
					{
						return new gV.AU.CL.Bb(Hg.Fx * Hh, Hg.Fy * Hh, Hg.GS * Hh);
					}

					// Token: 0x06000155 RID: 341 RVA: 0x0000854B File Offset: 0x0000854B
					public static gV.AU.CL.Bb FQ(gV.AU.CL.Bb Hi, gV.AU.CL.Bb Hj)
					{
						return new gV.AU.CL.Bb(Hi.Fx * Hj.Fx, Hi.Fy * Hj.Fy, Hi.GS * Hj.GS);
					}

					// Token: 0x06000156 RID: 342 RVA: 0x00008579 File Offset: 0x00008579
					public static gV.AU.CL.Bb FV(gV.AU.CL.Bb Hk, float Hl)
					{
						return new gV.AU.CL.Bb(Hk.Fx / Hl, Hk.Fy / Hl, Hk.GS / Hl);
					}

					// Token: 0x06000157 RID: 343 RVA: 0x00008598 File Offset: 0x00008598
					public static gV.AU.CL.Bb FV(gV.AU.CL.Bb Hm, gV.AU.CL.Bb Hn)
					{
						return new gV.AU.CL.Bb(Hm.Fx / Hn.Fx, Hm.Fy / Hn.Fy, Hm.GS / Hn.GS);
					}

					// Token: 0x06000158 RID: 344 RVA: 0x000085C6 File Offset: 0x000085C6
					public static gV.AU.CL.Bb Ga(gV.AU.CL.Bb Ho)
					{
						return new gV.AU.CL.Bb(-Ho.Fx, -Ho.Fy, -Ho.GS);
					}

					// Token: 0x06000159 RID: 345 RVA: 0x000085E4 File Offset: 0x000085E4
					public static gV.AU.CL.Bb Gc(gV.AU.CL.Bb Hp)
					{
						return new gV.AU.CL.Bb(((double)Hp.Fx > 0.0) ? Hp.Fx : (-Hp.Fx), ((double)Hp.Fy > 0.0) ? Hp.Fy : (-Hp.Fy), ((double)Hp.GS > 0.0) ? Hp.GS : (-Hp.GS));
					}

					// Token: 0x0600015A RID: 346 RVA: 0x0000865C File Offset: 0x0000865C
					public static gV.AU.CL.Bb Ge(gV.AU.CL.Bb ReadBytes, gV.AU.CL.Bb Hr, gV.AU.CL.Bb Hs)
					{
						float fx = ReadBytes.Fx;
						float num = ((double)fx > (double)Hs.Fx) ? Hs.Fx : fx;
						float x = ((double)num < (double)Hr.Fx) ? Hr.Fx : num;
						float fy = ReadBytes.Fy;
						float num2 = ((double)fy > (double)Hs.Fy) ? Hs.Fy : fy;
						float y = ((double)num2 < (double)Hr.Fy) ? Hr.Fy : num2;
						float gs = ReadBytes.GS;
						float num3 = ((double)gs > (double)Hs.GS) ? Hs.GS : gs;
						float z = ((double)num3 < (double)Hr.GS) ? Hr.GS : num3;
						return new gV.AU.CL.Bb(x, y, z);
					}

					// Token: 0x0600015B RID: 347 RVA: 0x0000870C File Offset: 0x0000870C
					public static float Do(gV.AU.CL.Bb Ht, gV.AU.CL.Bb Hu)
					{
						double num = (double)Ht.Fx - (double)Hu.Fx;
						float num2 = Ht.Fy - Hu.Fy;
						float num3 = Ht.GS - Hu.GS;
						return (float)Math.Sqrt(num * num + (double)num2 * (double)num2 + (double)num3 * (double)num3);
					}

					// Token: 0x0600015C RID: 348 RVA: 0x00008758 File Offset: 0x00008758
					public static float Dl(gV.AU.CL.Bb Hv, gV.AU.CL.Bb Hw)
					{
						return (float)((double)Hv.Fx * (double)Hw.Fx + (double)Hv.Fy * (double)Hw.Fy + (double)Hv.GS * (double)Hw.GS);
					}

					// Token: 0x0600015D RID: 349 RVA: 0x000084D0 File Offset: 0x000084D0
					public static gV.AU.CL.Bb DA(gV.AU.CL.Bb Hx, gV.AU.CL.Bb Hy)
					{
						return new gV.AU.CL.Bb(Hx.Fx + Hy.Fx, Hx.Fy + Hy.Fy, Hx.GS + Hy.GS);
					}

					// Token: 0x0600015E RID: 350 RVA: 0x0000854B File Offset: 0x0000854B
					public static gV.AU.CL.Bb DG(gV.AU.CL.Bb Hz, gV.AU.CL.Bb HA)
					{
						return new gV.AU.CL.Bb(Hz.Fx * HA.Fx, Hz.Fy * HA.Fy, Hz.GS * HA.GS);
					}

					// Token: 0x0600015F RID: 351 RVA: 0x00008222 File Offset: 0x00008222
					public static gV.AU.CL.Bb Gq(gV.AU.CL.Bb HB)
					{
						return HB;
					}

					// Token: 0x06000160 RID: 352 RVA: 0x000084FE File Offset: 0x000084FE
					public static gV.AU.CL.Bb DD(gV.AU.CL.Bb HC, gV.AU.CL.Bb HD)
					{
						return new gV.AU.CL.Bb(HC.Fx - HD.Fx, HC.Fy - HD.Fy, HC.GS - HD.GS);
					}

					// Token: 0x06000161 RID: 353 RVA: 0x000085C6 File Offset: 0x000085C6
					public static gV.AU.CL.Bb Gu(gV.AU.CL.Bb HE)
					{
						return new gV.AU.CL.Bb(-HE.Fx, -HE.Fy, -HE.GS);
					}

					// Token: 0x06000162 RID: 354 RVA: 0x0000878A File Offset: 0x0000878A
					public static gV.AU.CL.Bb DG(float HF, gV.AU.CL.Bb HG)
					{
						return new gV.AU.CL.Bb(HG.Fx * HF, HG.Fy * HF, HG.GS * HF);
					}

					// Token: 0x06000163 RID: 355 RVA: 0x0000852C File Offset: 0x0000852C
					public static gV.AU.CL.Bb DG(gV.AU.CL.Bb HH, float HI)
					{
						return new gV.AU.CL.Bb(HH.Fx * HI, HH.Fy * HI, HH.GS * HI);
					}

					// Token: 0x06000164 RID: 356 RVA: 0x00008579 File Offset: 0x00008579
					public static gV.AU.CL.Bb DN(gV.AU.CL.Bb HJ, float HK)
					{
						return new gV.AU.CL.Bb(HJ.Fx / HK, HJ.Fy / HK, HJ.GS / HK);
					}

					// Token: 0x06000165 RID: 357 RVA: 0x000087A9 File Offset: 0x000087A9
					public static gV.AU.CL.Bb DN(float HL, gV.AU.CL.Bb HM)
					{
						return new gV.AU.CL.Bb(HL / HM.Fx, HL / HM.Fy, HL / HM.GS);
					}

					// Token: 0x06000166 RID: 358 RVA: 0x00008598 File Offset: 0x00008598
					public static gV.AU.CL.Bb DN(gV.AU.CL.Bb HN, gV.AU.CL.Bb HO)
					{
						return new gV.AU.CL.Bb(HN.Fx / HO.Fx, HN.Fy / HO.Fy, HN.GS / HO.GS);
					}

					// Token: 0x06000167 RID: 359 RVA: 0x000087C8 File Offset: 0x000087C8
					public static gV.AU.CL.Bb DA(gV.AU.CL.Bb HP, float ReadBytes)
					{
						return new gV.AU.CL.Bb(HP.Fx + ReadBytes, HP.Fy + ReadBytes, HP.GS + ReadBytes);
					}

					// Token: 0x06000168 RID: 360 RVA: 0x000087E7 File Offset: 0x000087E7
					public static gV.AU.CL.Bb DA(float HR, gV.AU.CL.Bb HS)
					{
						return new gV.AU.CL.Bb(HR + HS.Fx, HR + HS.Fy, HR + HS.GS);
					}

					// Token: 0x06000169 RID: 361 RVA: 0x00008806 File Offset: 0x00008806
					public static gV.AU.CL.Bb DD(gV.AU.CL.Bb HT, float HU)
					{
						return new gV.AU.CL.Bb(HT.Fx - HU, HT.Fy - HU, HT.GS - HU);
					}

					// Token: 0x0600016A RID: 362 RVA: 0x00008825 File Offset: 0x00008825
					public static gV.AU.CL.Bb DD(float HV, gV.AU.CL.Bb HW)
					{
						return new gV.AU.CL.Bb(HV - HW.Fx, HV - HW.Fy, HV - HW.GS);
					}

					// Token: 0x0600016B RID: 363 RVA: 0x00008844 File Offset: 0x00008844
					public static bool DQ(gV.AU.CL.Bb HX, gV.AU.CL.Bb HY)
					{
						return (double)HX.Fx == (double)HY.Fx && (double)HX.Fy == (double)HY.Fy && (double)HX.GS == (double)HY.GS;
					}

					// Token: 0x0600016C RID: 364 RVA: 0x00008878 File Offset: 0x00008878
					public static bool DT(gV.AU.CL.Bb HZ, gV.AU.CL.Bb Ia)
					{
						return (double)HZ.Fx != (double)Ia.Fx || (double)HZ.Fy != (double)Ia.Fy || (double)HZ.GS != (double)Ia.GS;
					}

					// Token: 0x0600016D RID: 365 RVA: 0x000088AF File Offset: 0x000088AF
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", this.Fx, this.Fy, this.GS);
					}

					// Token: 0x040000AB RID: 171
					public float Fx;

					// Token: 0x040000AC RID: 172
					public float Fy;

					// Token: 0x040000AD RID: 173
					public float GS;

					// Token: 0x040000AE RID: 174
					public static readonly int Fz = Marshal.SizeOf<gV.AU.CL.Bb>();

					// Token: 0x040000AF RID: 175
					public static readonly gV.AU.CL.Bb FA = new gV.AU.CL.Bb(0f);

					// Token: 0x040000B0 RID: 176
					public static readonly gV.AU.CL.Bb FB = new gV.AU.CL.Bb(1f, 0f, 0f);

					// Token: 0x040000B1 RID: 177
					public static readonly gV.AU.CL.Bb FC = new gV.AU.CL.Bb(0f, 1f, 0f);

					// Token: 0x040000B2 RID: 178
					public static readonly gV.AU.CL.Bb GT = new gV.AU.CL.Bb(0f, 0f, 1f);

					// Token: 0x040000B3 RID: 179
					public static readonly gV.AU.CL.Bb FD = new gV.AU.CL.Bb(1f, 1f, 1f);

					// Token: 0x040000B4 RID: 180
					public static readonly gV.AU.CL.Bb GU = new gV.AU.CL.Bb(0f, 1f, 0f);

					// Token: 0x040000B5 RID: 181
					public static readonly gV.AU.CL.Bb GV = new gV.AU.CL.Bb(0f, -1f, 0f);

					// Token: 0x040000B6 RID: 182
					public static readonly gV.AU.CL.Bb GW = new gV.AU.CL.Bb(-1f, 0f, 0f);

					// Token: 0x040000B7 RID: 183
					public static readonly gV.AU.CL.Bb GX = new gV.AU.CL.Bb(1f, 0f, 0f);

					// Token: 0x040000B8 RID: 184
					public static readonly gV.AU.CL.Bb GY = new gV.AU.CL.Bb(0f, 0f, -1f);

					// Token: 0x040000B9 RID: 185
					public static readonly gV.AU.CL.Bb GZ = new gV.AU.CL.Bb(0f, 0f, 1f);

					// Token: 0x040000BA RID: 186
					public static readonly gV.AU.CL.Bb Ha = new gV.AU.CL.Bb(0f, 0f, 1f);

					// Token: 0x040000BB RID: 187
					public static readonly gV.AU.CL.Bb Hb = new gV.AU.CL.Bb(0f, 0f, -1f);
				}
			}

			// Token: 0x02000024 RID: 36
			public class CM
			{
				// Token: 0x02000025 RID: 37
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Bc
				{
					// Token: 0x06000170 RID: 368 RVA: 0x00008A36 File Offset: 0x00008A36
					public Bc(float value)
					{
						this.Fx = value;
						this.Fy = value;
						this.GS = value;
						this.Ib = value;
					}

					// Token: 0x06000171 RID: 369 RVA: 0x00008A54 File Offset: 0x00008A54
					public Bc(float x, float y, float z, float w)
					{
						this.Fx = x;
						this.Fy = y;
						this.GS = z;
						this.Ib = w;
					}

					// Token: 0x17000043 RID: 67
					// (get) Token: 0x06000172 RID: 370 RVA: 0x00008A74 File Offset: 0x00008A74
					public bool FF
					{
						get
						{
							return (double)this.Fx == 0.0 && (double)this.Fy == 0.0 && (double)this.GS == 0.0 && (double)this.Ib == 0.0;
						}
					}

					// Token: 0x06000173 RID: 371 RVA: 0x00008ACC File Offset: 0x00008ACC
					public float FG()
					{
						return (float)Math.Sqrt((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy + (double)this.GS * (double)this.GS + (double)this.Ib * (double)this.Ib);
					}

					// Token: 0x06000174 RID: 372 RVA: 0x00008B20 File Offset: 0x00008B20
					public float FH()
					{
						return (float)((double)this.Fx * (double)this.Fx + (double)this.Fy * (double)this.Fy + (double)this.GS * (double)this.GS + (double)this.Ib * (double)this.Ib);
					}

					// Token: 0x06000175 RID: 373 RVA: 0x00008B70 File Offset: 0x00008B70
					public void FI()
					{
						float num = this.FG();
						if ((double)num != 0.0)
						{
							float num2 = 1f / num;
							this.Fx *= num2;
							this.Fy *= num2;
							this.GS *= num2;
							this.Ib *= num2;
						}
					}

					// Token: 0x06000176 RID: 374 RVA: 0x00008BD3 File Offset: 0x00008BD3
					public float[] FJ()
					{
						return new float[]
						{
							this.Fx,
							this.Fy,
							this.GS,
							this.Ib
						};
					}

					// Token: 0x06000177 RID: 375 RVA: 0x00008BFF File Offset: 0x00008BFF
					public static gV.AU.CM.Bc FK(gV.AU.CM.Bc Id, gV.AU.CM.Bc Ie)
					{
						return new gV.AU.CM.Bc(Id.Fx + Ie.Fx, Id.Fy + Ie.Fy, Id.GS + Ie.GS, Id.Ib + Ie.Ib);
					}

					// Token: 0x06000178 RID: 376 RVA: 0x00008C3A File Offset: 0x00008C3A
					public static gV.AU.CM.Bc FN(gV.AU.CM.Bc If, gV.AU.CM.Bc Ig)
					{
						return new gV.AU.CM.Bc(If.Fx - Ig.Fx, If.Fy - Ig.Fy, If.GS - Ig.GS, If.Ib - Ig.Ib);
					}

					// Token: 0x06000179 RID: 377 RVA: 0x00008C75 File Offset: 0x00008C75
					public static gV.AU.CM.Bc FQ(gV.AU.CM.Bc Ih, float Ii)
					{
						return new gV.AU.CM.Bc(Ih.Fx * Ii, Ih.Fy * Ii, Ih.GS * Ii, Ih.Ib * Ii);
					}

					// Token: 0x0600017A RID: 378 RVA: 0x00008C9C File Offset: 0x00008C9C
					public static gV.AU.CM.Bc FQ(gV.AU.CM.Bc Ij, gV.AU.CM.Bc Ik)
					{
						return new gV.AU.CM.Bc(Ij.Fx * Ik.Fx, Ij.Fy * Ik.Fy, Ij.GS * Ik.GS, Ij.Ib * Ik.Ib);
					}

					// Token: 0x0600017B RID: 379 RVA: 0x00008CD7 File Offset: 0x00008CD7
					public static gV.AU.CM.Bc FV(gV.AU.CM.Bc Il, float Im)
					{
						return new gV.AU.CM.Bc(Il.Fx / Im, Il.Fy / Im, Il.GS / Im, Il.Ib / Im);
					}

					// Token: 0x0600017C RID: 380 RVA: 0x00008CFE File Offset: 0x00008CFE
					public static gV.AU.CM.Bc FV(gV.AU.CM.Bc In, gV.AU.CM.Bc Io)
					{
						return new gV.AU.CM.Bc(In.Fx / Io.Fx, In.Fy / Io.Fy, In.GS / Io.GS, In.Ib / Io.Ib);
					}

					// Token: 0x0600017D RID: 381 RVA: 0x00008D39 File Offset: 0x00008D39
					public static gV.AU.CM.Bc Ga(gV.AU.CM.Bc Ip)
					{
						return new gV.AU.CM.Bc(-Ip.Fx, -Ip.Fy, -Ip.GS, -Ip.Ib);
					}

					// Token: 0x0600017E RID: 382 RVA: 0x00008D5C File Offset: 0x00008D5C
					public static gV.AU.CM.Bc Gc(gV.AU.CM.Bc Iq)
					{
						return new gV.AU.CM.Bc(((double)Iq.Fx > 0.0) ? Iq.Fx : (-Iq.Fx), ((double)Iq.Fy > 0.0) ? Iq.Fy : (-Iq.Fy), ((double)Iq.GS > 0.0) ? Iq.GS : (-Iq.GS), ((double)Iq.Ib > 0.0) ? Iq.Ib : (-Iq.Ib));
					}

					// Token: 0x0600017F RID: 383 RVA: 0x00008DF4 File Offset: 0x00008DF4
					public static gV.AU.CM.Bc Ge(gV.AU.CM.Bc Ir, gV.AU.CM.Bc Is, gV.AU.CM.Bc It)
					{
						float fx = Ir.Fx;
						float num = ((double)fx > (double)It.Fx) ? It.Fx : fx;
						float x = ((double)num < (double)Is.Fx) ? Is.Fx : num;
						float fy = Ir.Fy;
						float num2 = ((double)fy > (double)It.Fy) ? It.Fy : fy;
						float y = ((double)num2 < (double)Is.Fy) ? Is.Fy : num2;
						float gs = Ir.GS;
						float num3 = ((double)gs > (double)It.GS) ? It.GS : gs;
						float z = ((double)num3 < (double)Is.GS) ? Is.GS : num3;
						float ib = Ir.Ib;
						float num4 = ((double)ib > (double)It.Ib) ? It.Ib : ib;
						float w = ((double)num4 < (double)Is.Ib) ? Is.Ib : num4;
						return new gV.AU.CM.Bc(x, y, z, w);
					}

					// Token: 0x06000180 RID: 384 RVA: 0x00008EE0 File Offset: 0x00008EE0
					public static float Do(gV.AU.CM.Bc Iu, gV.AU.CM.Bc Iv)
					{
						double num = (double)Iu.Fx - (double)Iv.Fx;
						float num2 = Iu.Fy - Iv.Fy;
						float num3 = Iu.GS - Iv.GS;
						float num4 = Iu.Ib - Iv.Ib;
						return (float)Math.Sqrt(num * num + (double)num2 * (double)num2 + (double)num3 * (double)num3 + (double)num4 * (double)num4);
					}

					// Token: 0x06000181 RID: 385 RVA: 0x00008F40 File Offset: 0x00008F40
					public static float Dl(gV.AU.CM.Bc Iw, gV.AU.CM.Bc Ix)
					{
						return (float)((double)Iw.Fx * (double)Ix.Fx + (double)Iw.Fy * (double)Ix.Fy + (double)Iw.GS * (double)Ix.GS + (double)Iw.Ib * (double)Ix.Ib);
					}

					// Token: 0x06000182 RID: 386 RVA: 0x00008BFF File Offset: 0x00008BFF
					public static gV.AU.CM.Bc DA(gV.AU.CM.Bc Iy, gV.AU.CM.Bc Iz)
					{
						return new gV.AU.CM.Bc(Iy.Fx + Iz.Fx, Iy.Fy + Iz.Fy, Iy.GS + Iz.GS, Iy.Ib + Iz.Ib);
					}

					// Token: 0x06000183 RID: 387 RVA: 0x00008C9C File Offset: 0x00008C9C
					public static gV.AU.CM.Bc DG(gV.AU.CM.Bc IA, gV.AU.CM.Bc IB)
					{
						return new gV.AU.CM.Bc(IA.Fx * IB.Fx, IA.Fy * IB.Fy, IA.GS * IB.GS, IA.Ib * IB.Ib);
					}

					// Token: 0x06000184 RID: 388 RVA: 0x00008222 File Offset: 0x00008222
					public static gV.AU.CM.Bc Gq(gV.AU.CM.Bc IC)
					{
						return IC;
					}

					// Token: 0x06000185 RID: 389 RVA: 0x00008C3A File Offset: 0x00008C3A
					public static gV.AU.CM.Bc DD(gV.AU.CM.Bc ID, gV.AU.CM.Bc IE)
					{
						return new gV.AU.CM.Bc(ID.Fx - IE.Fx, ID.Fy - IE.Fy, ID.GS - IE.GS, ID.Ib - IE.Ib);
					}

					// Token: 0x06000186 RID: 390 RVA: 0x00008D39 File Offset: 0x00008D39
					public static gV.AU.CM.Bc Gu(gV.AU.CM.Bc IF)
					{
						return new gV.AU.CM.Bc(-IF.Fx, -IF.Fy, -IF.GS, -IF.Ib);
					}

					// Token: 0x06000187 RID: 391 RVA: 0x00008F8D File Offset: 0x00008F8D
					public static gV.AU.CM.Bc DG(float IG, gV.AU.CM.Bc IH)
					{
						return new gV.AU.CM.Bc(IH.Fx * IG, IH.Fy * IG, IH.GS * IG, IH.Ib * IG);
					}

					// Token: 0x06000188 RID: 392 RVA: 0x00008C75 File Offset: 0x00008C75
					public static gV.AU.CM.Bc DG(gV.AU.CM.Bc II, float IJ)
					{
						return new gV.AU.CM.Bc(II.Fx * IJ, II.Fy * IJ, II.GS * IJ, II.Ib * IJ);
					}

					// Token: 0x06000189 RID: 393 RVA: 0x00008CD7 File Offset: 0x00008CD7
					public static gV.AU.CM.Bc DN(gV.AU.CM.Bc IK, float IL)
					{
						return new gV.AU.CM.Bc(IK.Fx / IL, IK.Fy / IL, IK.GS / IL, IK.Ib / IL);
					}

					// Token: 0x0600018A RID: 394 RVA: 0x00008FB4 File Offset: 0x00008FB4
					public static gV.AU.CM.Bc DN(float IM, gV.AU.CM.Bc IN)
					{
						return new gV.AU.CM.Bc(IM / IN.Fx, IM / IN.Fy, IM / IN.GS, IM / IN.Ib);
					}

					// Token: 0x0600018B RID: 395 RVA: 0x00008CFE File Offset: 0x00008CFE
					public static gV.AU.CM.Bc DN(gV.AU.CM.Bc IO, gV.AU.CM.Bc IP)
					{
						return new gV.AU.CM.Bc(IO.Fx / IP.Fx, IO.Fy / IP.Fy, IO.GS / IP.GS, IO.Ib / IP.Ib);
					}

					// Token: 0x0600018C RID: 396 RVA: 0x00008FDB File Offset: 0x00008FDB
					public static gV.AU.CM.Bc DA(gV.AU.CM.Bc IQ, float IR)
					{
						return new gV.AU.CM.Bc(IQ.Fx + IR, IQ.Fy + IR, IQ.GS + IR, IQ.Ib + IR);
					}

					// Token: 0x0600018D RID: 397 RVA: 0x00009002 File Offset: 0x00009002
					public static gV.AU.CM.Bc DA(float IS, gV.AU.CM.Bc IT)
					{
						return new gV.AU.CM.Bc(IS + IT.Fx, IS + IT.Fy, IS + IT.GS, IS + IT.Ib);
					}

					// Token: 0x0600018E RID: 398 RVA: 0x00009029 File Offset: 0x00009029
					public static gV.AU.CM.Bc DD(gV.AU.CM.Bc IU, float IV)
					{
						return new gV.AU.CM.Bc(IU.Fx - IV, IU.Fy - IV, IU.GS - IV, IU.Ib - IV);
					}

					// Token: 0x0600018F RID: 399 RVA: 0x00009050 File Offset: 0x00009050
					public static gV.AU.CM.Bc DD(float IW, gV.AU.CM.Bc IX)
					{
						return new gV.AU.CM.Bc(IW - IX.Fx, IW - IX.Fy, IW - IX.GS, IW - IX.Ib);
					}

					// Token: 0x06000190 RID: 400 RVA: 0x00009078 File Offset: 0x00009078
					public static bool DQ(gV.AU.CM.Bc IY, gV.AU.CM.Bc IZ)
					{
						return (double)IY.Fx == (double)IZ.Fx && (double)IY.Fy == (double)IZ.Fy && (double)IY.GS == (double)IZ.GS && (double)IY.Ib == (double)IZ.Ib;
					}

					// Token: 0x06000191 RID: 401 RVA: 0x000090C8 File Offset: 0x000090C8
					public static bool DT(gV.AU.CM.Bc Ja, gV.AU.CM.Bc Jb)
					{
						return (double)Ja.Fx != (double)Jb.Fx || (double)Ja.Fy != (double)Jb.Fy || (double)Ja.GS != (double)Jb.GS || (double)Ja.Ib != (double)Jb.Ib;
					}

					// Token: 0x06000192 RID: 402 RVA: 0x0000911C File Offset: 0x0000911C
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", new object[]
						{
							this.Fx,
							this.Fy,
							this.GS,
							this.Ib
						});
					}

					// Token: 0x040000BC RID: 188
					public float Fx;

					// Token: 0x040000BD RID: 189
					public float Fy;

					// Token: 0x040000BE RID: 190
					public float GS;

					// Token: 0x040000BF RID: 191
					public float Ib;

					// Token: 0x040000C0 RID: 192
					public static readonly int Fz = Marshal.SizeOf<gV.AU.CM.Bc>();

					// Token: 0x040000C1 RID: 193
					public static readonly gV.AU.CM.Bc FA = default(gV.AU.CM.Bc);

					// Token: 0x040000C2 RID: 194
					public static readonly gV.AU.CM.Bc FB = new gV.AU.CM.Bc(1f, 0f, 0f, 0f);

					// Token: 0x040000C3 RID: 195
					public static readonly gV.AU.CM.Bc FC = new gV.AU.CM.Bc(0f, 1f, 0f, 0f);

					// Token: 0x040000C4 RID: 196
					public static readonly gV.AU.CM.Bc GT = new gV.AU.CM.Bc(0f, 0f, 1f, 0f);

					// Token: 0x040000C5 RID: 197
					public static readonly gV.AU.CM.Bc Ic = new gV.AU.CM.Bc(0f, 0f, 0f, 1f);

					// Token: 0x040000C6 RID: 198
					public static readonly gV.AU.CM.Bc FD = new gV.AU.CM.Bc(1f, 1f, 1f, 1f);
				}
			}

			// Token: 0x02000026 RID: 38
			public class CN
			{
				// Token: 0x02000027 RID: 39
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Jc
				{
					// Token: 0x06000195 RID: 405 RVA: 0x00009230 File Offset: 0x00009230
					public Jc(float value)
					{
						this.Bf = value;
						this.Bg = value;
						this.Bh = value;
						this.Bi = value;
						this.Bj = value;
						this.Bk = value;
						this.Bl = value;
						this.Bm = value;
						this.Bn = value;
						this.Bo = value;
						this.Bp = value;
						this.Bq = value;
						this.Br = value;
						this.Bs = value;
						this.Bt = value;
						this.Bu = value;
					}

					// Token: 0x06000196 RID: 406 RVA: 0x000092B0 File Offset: 0x000092B0
					public Jc(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
					{
						this.Bf = m11;
						this.Bg = m12;
						this.Bh = m13;
						this.Bi = m14;
						this.Bj = m21;
						this.Bk = m22;
						this.Bl = m23;
						this.Bm = m24;
						this.Bn = m31;
						this.Bo = m32;
						this.Bp = m33;
						this.Bq = m34;
						this.Br = m41;
						this.Bs = m42;
						this.Bt = m43;
						this.Bu = m44;
					}

					// Token: 0x06000197 RID: 407 RVA: 0x0000933C File Offset: 0x0000933C
					public static gV.AU.CN.Jc Bw(gV.AU.CN.Jc Jd)
					{
						return new gV.AU.CN.Jc
						{
							Bf = Jd.Bf,
							Bg = Jd.Bj,
							Bh = Jd.Bn,
							Bi = Jd.Br,
							Bj = Jd.Bg,
							Bk = Jd.Bk,
							Bl = Jd.Bo,
							Bm = Jd.Bs,
							Bn = Jd.Bh,
							Bo = Jd.Bl,
							Bp = Jd.Bp,
							Bq = Jd.Bt,
							Br = Jd.Bi,
							Bs = Jd.Bm,
							Bt = Jd.Bq,
							Bu = Jd.Bu
						};
					}

					// Token: 0x06000198 RID: 408 RVA: 0x00009424 File Offset: 0x00009424
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "M11:{0} M12:{1} M13:{2} M14:{3} M21:{4} M22:{5} M23:{6} M24:{7} M31:{8} M32:{9} M33:{10} M34:{11} M41:{12} M42:{13} M43:{14} M44:{15}", new object[]
						{
							this.Bf,
							this.Bg,
							this.Bh,
							this.Bi,
							this.Bj,
							this.Bk,
							this.Bl,
							this.Bm,
							this.Bn,
							this.Bo,
							this.Bp,
							this.Bq,
							this.Br,
							this.Bs,
							this.Bt,
							this.Bu
						});
					}

					// Token: 0x040000C7 RID: 199
					public float Bf;

					// Token: 0x040000C8 RID: 200
					public float Bg;

					// Token: 0x040000C9 RID: 201
					public float Bh;

					// Token: 0x040000CA RID: 202
					public float Bi;

					// Token: 0x040000CB RID: 203
					public float Bj;

					// Token: 0x040000CC RID: 204
					public float Bk;

					// Token: 0x040000CD RID: 205
					public float Bl;

					// Token: 0x040000CE RID: 206
					public float Bm;

					// Token: 0x040000CF RID: 207
					public float Bn;

					// Token: 0x040000D0 RID: 208
					public float Bo;

					// Token: 0x040000D1 RID: 209
					public float Bp;

					// Token: 0x040000D2 RID: 210
					public float Bq;

					// Token: 0x040000D3 RID: 211
					public float Br;

					// Token: 0x040000D4 RID: 212
					public float Bs;

					// Token: 0x040000D5 RID: 213
					public float Bt;

					// Token: 0x040000D6 RID: 214
					public float Bu;
				}
			}
		}
	}
}
