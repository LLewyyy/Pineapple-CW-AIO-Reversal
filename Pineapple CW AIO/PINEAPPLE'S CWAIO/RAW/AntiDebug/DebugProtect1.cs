using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RAW.AntiDebug
{
	// Token: 0x020000BD RID: 189
	internal class DebugProtect1
	{
		// Token: 0x06000549 RID: 1353
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x0600054A RID: 1354
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x0600054B RID: 1355 RVA: 0x0004414C File Offset: 0x0004414C
		public static int PerformChecks()
		{
			if (DebugProtect1.CheckDebuggerManagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				return 1;
			}
			if (DebugProtect1.CheckRemoteDebugger() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				return 1;
			}
			return 0;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000441AB File Offset: 0x000441AB
		private static int CheckDebuggerManagedPresent()
		{
			if (Debugger.IsAttached)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000441B7 File Offset: 0x000441B7
		private static int CheckDebuggerUnmanagedPresent()
		{
			if (DebugProtect1.IsDebuggerPresent())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000441C4 File Offset: 0x000441C4
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			if (DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				return 1;
			}
			return 0;
		}
	}
}
