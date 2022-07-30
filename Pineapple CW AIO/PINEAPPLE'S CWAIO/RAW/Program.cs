using System;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using FAZEDAuth;
using RAW.AntiDebug;
using RAW.LogTools;

namespace RAW
{
	// Token: 0x02000099 RID: 153
	internal static class Program
	{
		// Token: 0x0600031F RID: 799 RVA: 0x0002267C File Offset: 0x0002267C
		[STAThread]
		private static void Main()
		{
			Scanner.ScanAndKill();
			if (DebugProtect1.PerformChecks() == 1)
			{
				Environment.FailFast("");
			}
			if (DebugProtect2.PerformChecks() == 1)
			{
				Environment.FailFast("");
			}
			DebugProtect3.HideOSThreads();
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/UNAna7RJ");
			string text2 = webClient.DownloadString("https://pastebin.com/raw/6JfEiLzL");
			try
			{
				if (text.Contains(IP.Grab() + "|") || text2.Contains(WindowsIdentity.GetCurrent().User.Value + "|"))
				{
					DialogResult dialogResult = MessageBox.Show("YOU HAVE BEEN LOCKED OUT CONTACT SUPPORT", " ", MessageBoxButtons.OK);
					if (dialogResult == DialogResult.OK)
					{
						Process.GetCurrentProcess().Kill();
					}
					else if (dialogResult == DialogResult.Abort)
					{
						Process.GetCurrentProcess().Kill();
					}
				}
			}
			catch
			{
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginMenu());
		}
	}
}
