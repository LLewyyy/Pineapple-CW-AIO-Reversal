using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace RAW.AntiDebug
{
	// Token: 0x020000C0 RID: 192
	internal class Scanner
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x0004444D File Offset: 0x0004444D
		public static void ScanAndKill()
		{
			if (Scanner.Scan(true) != 0)
			{
				Environment.Exit(0);
				Process.Start("shutdown", "/r /t 0");
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00044470 File Offset: 0x00044470
		private static int Scan(bool KillProcess)
		{
			int result = 0;
			if (Scanner.BadProcessnameList.Count == 0 && Scanner.BadWindowTextList.Count == 0)
			{
				Scanner.Init();
			}
			foreach (Process process in Process.GetProcesses())
			{
				if (Scanner.BadProcessnameList.Contains(process.ProcessName) || Scanner.BadWindowTextList.Contains(process.MainWindowTitle))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("BAD PROCESS FOUND: " + process.ProcessName);
					result = 1;
					if (!KillProcess)
					{
						break;
					}
					try
					{
						process.Kill();
						break;
					}
					catch (Win32Exception ex)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("Win32Exception: " + ex.Message);
						break;
					}
					catch (NotSupportedException ex2)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("NotSupportedException: " + ex2.Message);
						break;
					}
					catch (InvalidOperationException ex3)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("InvalidOperationException: " + ex3.Message);
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00044598 File Offset: 0x00044598
		private static int Init()
		{
			if (Scanner.BadProcessnameList.Count > 0 && Scanner.BadWindowTextList.Count > 0)
			{
				return 1;
			}
			Scanner.BadProcessnameList.Add("ollydbg");
			Scanner.BadProcessnameList.Add("ConfuserEx AntiDump Fixer");
			Scanner.BadProcessnameList.Add("perfmon");
			Scanner.BadProcessnameList.Add("ExtremeDumper");
			Scanner.BadProcessnameList.Add("ExtremeDumper-x86");
			Scanner.BadProcessnameList.Add("AntiDecompiler Cleaner");
			Scanner.BadProcessnameList.Add("diel");
			Scanner.BadProcessnameList.Add("die");
			Scanner.BadProcessnameList.Add("ILReplacer");
			Scanner.BadProcessnameList.Add("de4dot-x64");
			Scanner.BadProcessnameList.Add("ProcessHacker");
			Scanner.BadProcessnameList.Add("dnSpy");
			Scanner.BadProcessnameList.Add("ida");
			Scanner.BadProcessnameList.Add("ida64");
			Scanner.BadProcessnameList.Add("idag");
			Scanner.BadProcessnameList.Add("idag64");
			Scanner.BadProcessnameList.Add("idaw");
			Scanner.BadProcessnameList.Add("idaw64");
			Scanner.BadProcessnameList.Add("idaq");
			Scanner.BadProcessnameList.Add("idaq64");
			Scanner.BadProcessnameList.Add("idau");
			Scanner.BadProcessnameList.Add("idau64");
			Scanner.BadProcessnameList.Add("scylla");
			Scanner.BadProcessnameList.Add("scylla_x64");
			Scanner.BadProcessnameList.Add("scylla_x86");
			Scanner.BadProcessnameList.Add("protection_id");
			Scanner.BadProcessnameList.Add("x64dbg");
			Scanner.BadProcessnameList.Add("x32dbg");
			Scanner.BadProcessnameList.Add("windbg");
			Scanner.BadProcessnameList.Add("reshacker");
			Scanner.BadProcessnameList.Add("ImportREC");
			Scanner.BadProcessnameList.Add("IMMUNITYDEBUGGER");
			Scanner.BadProcessnameList.Add("MegaDumper");
			Scanner.BadWindowTextList.Add("Resource and Performance Monitor");
			Scanner.BadWindowTextList.Add("Resource Monitor");
			Scanner.BadWindowTextList.Add("Dump Fixer by x0rz");
			Scanner.BadWindowTextList.Add("de4dot-x64");
			Scanner.BadWindowTextList.Add("de4dot");
			Scanner.BadWindowTextList.Add("diel");
			Scanner.BadWindowTextList.Add("AntiDecompiler Cleaner");
			Scanner.BadWindowTextList.Add("die");
			Scanner.BadWindowTextList.Add("ILReplacer");
			Scanner.BadWindowTextList.Add("ExtremeDumper");
			Scanner.BadWindowTextList.Add("ExtremeDumper-x86");
			Scanner.BadWindowTextList.Add("ExtremeDumper v3.0.0.1");
			Scanner.BadWindowTextList.Add("ConfuserEx AntiDump Fixer - by x0rz");
			Scanner.BadWindowTextList.Add("OLLYDBG");
			Scanner.BadWindowTextList.Add("dnSpy");
			Scanner.BadWindowTextList.Add("Process Hacker");
			Scanner.BadWindowTextList.Add("ida");
			Scanner.BadWindowTextList.Add("disassembly");
			Scanner.BadWindowTextList.Add("scylla");
			Scanner.BadWindowTextList.Add("Debug");
			Scanner.BadWindowTextList.Add("[CPU");
			Scanner.BadWindowTextList.Add("Immunity");
			Scanner.BadWindowTextList.Add("WinDbg");
			Scanner.BadWindowTextList.Add("x32dbg");
			Scanner.BadWindowTextList.Add("x64dbg");
			Scanner.BadWindowTextList.Add("Import reconstructor");
			Scanner.BadWindowTextList.Add("MegaDumper");
			Scanner.BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
			return 0;
		}

		// Token: 0x04000680 RID: 1664
		private static HashSet<string> BadProcessnameList = new HashSet<string>();

		// Token: 0x04000681 RID: 1665
		private static HashSet<string> BadWindowTextList = new HashSet<string>();
	}
}
