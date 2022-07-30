using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using RAW.AntiDebug.WinStructs;

namespace RAW.AntiDebug
{
	// Token: 0x020000BE RID: 190
	internal class DebugProtect2
	{
		// Token: 0x06000550 RID: 1360
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000551 RID: 1361
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtClose([In] IntPtr Handle);

		// Token: 0x06000552 RID: 1362
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

		// Token: 0x06000553 RID: 1363
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000554 RID: 1364
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000555 RID: 1365 RVA: 0x000441EC File Offset: 0x000441EC
		public static int PerformChecks()
		{
			if (DebugProtect2.CheckDebugPort() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebugPort: HIT");
				return 1;
			}
			if (DebugProtect2.CheckKernelDebugInformation())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckKernelDebugInformation: HIT");
				return 1;
			}
			if (DebugProtect2.DetachFromDebuggerProcess())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("DetachFromDebuggerProcess: HIT");
				return 1;
			}
			return 0;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0004424C File Offset: 0x0004424C
		private static int CheckDebugPort()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			if (DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num) == NtStatus.Success && intPtr == new IntPtr(-1))
			{
				Console.WriteLine("DebugPort : {0:X}", intPtr);
				return 1;
			}
			return 0;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000442A0 File Offset: 0x000442A0
		private unsafe static bool DetachFromDebuggerProcess()
		{
			IntPtr invalid_HANDLE_VALUE = DebugProtect2.INVALID_HANDLE_VALUE;
			uint structure = 0U;
			int num;
			int num2;
			return DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out invalid_HANDLE_VALUE, IntPtr.Size, out num) == NtStatus.Success && DebugProtect2.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2) == NtStatus.Success && DebugProtect2.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE) == NtStatus.Success && DebugProtect2.NtClose(invalid_HANDLE_VALUE) == NtStatus.Success;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00044310 File Offset: 0x00044310
		private unsafe static bool CheckKernelDebugInformation()
		{
			SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
			int num;
			return DebugProtect2.NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num) == NtStatus.Success && system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent;
		}

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
	}
}
