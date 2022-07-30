using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SafeGuard
{
	// Token: 0x0200000A RID: 10
	internal class SafeCheck
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002508 File Offset: 0x00002508
		internal static void Md5Check()
		{
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "MD5") != SafeCheck.CurrentDllMD5)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA1") != SafeCheck.CurrentDllSHA1)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA256") != SafeCheck.CurrentDllSHA256)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SIZE") != SafeCheck.CurrentDllSize)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002628 File Offset: 0x00002628
		internal static string ComputeHash(string s, string hashtype)
		{
			if (!(hashtype == "MD5"))
			{
				if (!(hashtype == "SHA1"))
				{
					if (hashtype == "SHA256")
					{
						goto IL_138;
					}
					if (!(hashtype == "SIZE"))
					{
						goto IL_1EB;
					}
					goto IL_1B4;
				}
			}
			else
			{
				using (MD5 md = MD5.Create())
				{
					try
					{
						using (FileStream fileStream = File.OpenRead(s))
						{
							byte[] array = md.ComputeHash(fileStream);
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < array.Length; i++)
							{
								stringBuilder.Append(array[i].ToString("X2"));
							}
							return stringBuilder.ToString();
						}
					}
					catch
					{
						return "MD5 Error";
					}
				}
			}
			using (SHA1 sha = SHA1.Create())
			{
				try
				{
					using (FileStream fileStream2 = File.OpenRead(s))
					{
						byte[] array2 = sha.ComputeHash(fileStream2);
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.Append(array2[j].ToString("X2"));
						}
						return stringBuilder2.ToString();
					}
				}
				catch
				{
					return "SHA1 Error";
				}
			}
			IL_138:
			using (SHA256 sha2 = SHA256.Create())
			{
				try
				{
					using (FileStream fileStream3 = File.OpenRead(s))
					{
						byte[] array3 = sha2.ComputeHash(fileStream3);
						StringBuilder stringBuilder3 = new StringBuilder();
						for (int k = 0; k < array3.Length; k++)
						{
							stringBuilder3.Append(array3[k].ToString("X2"));
						}
						return stringBuilder3.ToString();
					}
				}
				catch
				{
					return "SHA256 Error";
				}
			}
			IL_1B4:
			try
			{
				using (File.OpenRead(s))
				{
					return new FileInfo(s).Length.ToString();
				}
			}
			catch
			{
				return "File Size Error";
			}
			IL_1EB:
			return "Invalid Type";
		}

		// Token: 0x0400000E RID: 14
		internal static string CurrentDllMD5 = "3307FC407D88BA40ABEAC87266F4558D";

		// Token: 0x0400000F RID: 15
		internal static string CurrentDllSHA1 = "3B85FC7EC65D4E26720516866E72B240598CEDCE";

		// Token: 0x04000010 RID: 16
		internal static string CurrentDllSHA256 = "B215110D42BDEC6069D1328E429C959F68C1BEE08333C4852BD3F5299B95173F";

		// Token: 0x04000011 RID: 17
		internal static string CurrentDllSize = "1741312";

		// Token: 0x04000012 RID: 18
		internal static string CurrentNewtonSoftMD5 = "6815034209687816D8CF401877EC8133";

		// Token: 0x04000013 RID: 19
		internal static string CurrentNewtonSoftSHA1 = "1248142EB45EED3BEB0D9A2D3B8BED5FE2569B10";

		// Token: 0x04000014 RID: 20
		internal static string CurrentNewtonSoftSHA256 = "7F912B28A07C226E0BE3ACFB2F57F050538ABA0100FA1F0BF2C39F1A1F1DA814";

		// Token: 0x04000015 RID: 21
		internal static string CurrentNewtonSoftSize = "700336";
	}
}
