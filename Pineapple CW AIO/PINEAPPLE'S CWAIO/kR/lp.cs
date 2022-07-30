using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace kR
{
	// Token: 0x0200001A RID: 26
	internal static class lp
	{
		// Token: 0x060000C7 RID: 199
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateSection(ref IntPtr lr, uint ls, IntPtr lt, ref ulong lu, uint lv, uint lw, IntPtr lx);

		// Token: 0x060000C8 RID: 200
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenSection(ref IntPtr lz, uint lA, IntPtr lB);

		// Token: 0x060000C9 RID: 201
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtMapViewOfSection(IntPtr lD, IntPtr lE, ref IntPtr lF, UIntPtr lG, UIntPtr lH, out ulong lI, out uint lJ, uint lK, uint lL, uint lM);

		// Token: 0x060000CA RID: 202
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateEvent(ref IntPtr lO, uint lP, IntPtr lQ, uint lR, bool lS);

		// Token: 0x060000CB RID: 203
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenEvent(ref IntPtr lU, uint lV, IntPtr lW);

		// Token: 0x060000CC RID: 204
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtClose(IntPtr lY);

		// Token: 0x060000CD RID: 205
		[DllImport("kernel32.dll")]
		internal static extern void CopyMemory(IntPtr ma, IntPtr mb, uint mc);

		// Token: 0x060000CE RID: 206
		[DllImport("kernel32.dll")]
		internal static extern IntPtr LoadLibrary(string me);

		// Token: 0x060000CF RID: 207
		[DllImport("kernel32.dll")]
		internal static extern IntPtr GetProcAddress(IntPtr mg, string mh);

		// Token: 0x060000D0 RID: 208
		[DllImport("kernel32.dll")]
		internal static extern bool FreeLibrary(IntPtr mj);

		// Token: 0x060000D1 RID: 209
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr OpenSCManagerW(string ml, string mm, uint mn);

		// Token: 0x060000D2 RID: 210
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CreateService(IntPtr mp, string mq, string mr, uint ms, uint mt, uint mu, uint mv, string mw, string mx, string my, string mz, string mA, string mB);

		// Token: 0x060000D3 RID: 211
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr OpenService(IntPtr mD, string mE, uint mF);

		// Token: 0x060000D4 RID: 212
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool DeleteService(IntPtr mI);

		// Token: 0x060000D5 RID: 213
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseServiceHandle(IntPtr mL);

		// Token: 0x060000D6 RID: 214
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseHandle(IntPtr mO);

		// Token: 0x060000D7 RID: 215
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern SafeFileHandle CreateFile(string mQ, [MarshalAs(UnmanagedType.U4)] FileAccess mR, [MarshalAs(UnmanagedType.U4)] FileShare mS, IntPtr mT, [MarshalAs(UnmanagedType.U4)] FileMode mU, [MarshalAs(UnmanagedType.U4)] uint mV, IntPtr mW);

		// Token: 0x060000D8 RID: 216 RVA: 0x00006E7E File Offset: 0x00006E7E
		internal static uint mX(uint mY, uint mZ, uint na, uint nb)
		{
			return mY << 16 | nb << 14 | mZ << 2 | na;
		}
	}
}
