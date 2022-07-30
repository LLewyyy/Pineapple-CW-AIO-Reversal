using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RAW.AntiDebug
{
	// Token: 0x020000C1 RID: 193
	internal class DumpProtect1
	{
		// Token: 0x06000568 RID: 1384
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x06000569 RID: 1385
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x0600056A RID: 1386 RVA: 0x000449A8 File Offset: 0x000449A8
		private static void EraseSection(IntPtr address, int size)
		{
			IntPtr intPtr = (IntPtr)size;
			IntPtr flNewProtect = 0;
			DumpProtect1.VirtualProtect(address, intPtr, (IntPtr)64, ref flNewProtect);
			DumpProtect1.ZeroMemory(address, intPtr);
			IntPtr intPtr2 = 0;
			DumpProtect1.VirtualProtect(address, intPtr, flNewProtect, ref intPtr2);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000449F0 File Offset: 0x000449F0
		public static void AntiDump()
		{
			IntPtr baseAddress = Process.GetCurrentProcess().MainModule.BaseAddress;
			int num = Marshal.ReadInt32((IntPtr)(baseAddress.ToInt32() + 60));
			short num2 = Marshal.ReadInt16((IntPtr)(baseAddress.ToInt32() + num + 6));
			DumpProtect1.EraseSection(baseAddress, 30);
			for (int i = 0; i < DumpProtect1.peheaderdwords.Length; i++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderdwords[i]), 4);
			}
			for (int j = 0; j < DumpProtect1.peheaderwords.Length; j++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderwords[j]), 2);
			}
			for (int k = 0; k < DumpProtect1.peheaderbytes.Length; k++)
			{
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + DumpProtect1.peheaderbytes[k]), 1);
			}
			int l = 0;
			int num3 = 0;
			while (l <= (int)num2)
			{
				if (num3 == 0)
				{
					DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + 32), 2);
				}
				DumpProtect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + DumpProtect1.sectiontabledwords[num3]), 4);
				num3++;
				if (num3 == DumpProtect1.sectiontabledwords.Length)
				{
					l++;
					num3 = 0;
				}
			}
		}

		// Token: 0x04000682 RID: 1666
		private static int[] sectiontabledwords = new int[]
		{
			8,
			12,
			16,
			20,
			24,
			28,
			36
		};

		// Token: 0x04000683 RID: 1667
		private static int[] peheaderbytes = new int[]
		{
			26,
			27
		};

		// Token: 0x04000684 RID: 1668
		private static int[] peheaderwords = new int[]
		{
			4,
			22,
			24,
			64,
			66,
			68,
			70,
			72,
			74,
			76,
			92,
			94
		};

		// Token: 0x04000685 RID: 1669
		private static int[] peheaderdwords = new int[]
		{
			0,
			8,
			12,
			16,
			22,
			28,
			32,
			40,
			44,
			52,
			60,
			76,
			80,
			84,
			88,
			96,
			100,
			104,
			108,
			112,
			116,
			260,
			264,
			268,
			272,
			276,
			284
		};
	}
}
