using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using RAW.AntiDebug.WinStructs;

namespace RAW.AntiDebug
{
	// Token: 0x020000BF RID: 191
	internal class DebugProtect3
	{
		// Token: 0x0600055B RID: 1371
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x0600055C RID: 1372
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x0600055D RID: 1373
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x0600055E RID: 1374
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x0600055F RID: 1375
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x06000560 RID: 1376 RVA: 0x00044358 File Offset: 0x00044358
		public static void HideOSThreads()
		{
			foreach (object obj in Process.GetCurrentProcess().Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = DebugProtect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				if (intPtr == IntPtr.Zero)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					if (DebugProtect3.HideFromDebugger(intPtr))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					DebugProtect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00044438 File Offset: 0x00044438
		public static bool HideFromDebugger(IntPtr Handle)
		{
			return DebugProtect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0) == NtStatus.Success;
		}
	}
}
