using System;
using System.Runtime.InteropServices;

namespace RAW.AntiDebug.WinStructs
{
	// Token: 0x020000C8 RID: 200
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x040008E5 RID: 2277
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x040008E6 RID: 2278
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
