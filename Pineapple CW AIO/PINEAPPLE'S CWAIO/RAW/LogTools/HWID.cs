using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace RAW.LogTools
{
	// Token: 0x020000B7 RID: 183
	public class HWID
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x00042998 File Offset: 0x00042998
		public static string Grab()
		{
			if (string.IsNullOrEmpty(HWID.fingerPrint))
			{
				HWID.fingerPrint = HWID.GetHash(string.Concat(new string[]
				{
					"CPU >> ",
					HWID.cpuId(),
					"\nBIOS >> ",
					HWID.biosId(),
					"\nBASE >> ",
					HWID.baseId(),
					"\nDISK >> ",
					HWID.diskId(),
					"\nVIDEO >> ",
					HWID.videoId()
				}));
			}
			return HWID.fingerPrint;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00042A20 File Offset: 0x00042A20
		private static string GetHash(string s)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = new ASCIIEncoding().GetBytes(s);
			return HWID.GetHexString(hashAlgorithm.ComputeHash(bytes));
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00042A4C File Offset: 0x00042A4C
		private static string GetHexString(byte[] bt)
		{
			string text = string.Empty;
			for (int i = 0; i < bt.Length; i++)
			{
				byte b = bt[i];
				int num = (int)(b & 15);
				int num2 = b >> 4 & 15;
				if (num2 > 9)
				{
					text += ((char)(num2 - 10 + 65)).ToString();
				}
				else
				{
					text += num2.ToString();
				}
				if (num > 9)
				{
					text += ((char)(num - 10 + 65)).ToString();
				}
				else
				{
					text += num.ToString();
				}
				if (i + 1 != bt.Length && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00042AF8 File Offset: 0x00042AF8
		private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject[wmiMustBeTrue].ToString() == "True" && text == "")
				{
					try
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00042B94 File Offset: 0x00042B94
		private static string identifier(string wmiClass, string wmiProperty)
		{
			string result;
			try
			{
				string text = "";
				foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text == "")
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
				}
				result = text;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00042C1C File Offset: 0x00042C1C
		private static string cpuId()
		{
			string text = HWID.identifier("Win32_Processor", "UniqueId");
			if (text == "")
			{
				text = HWID.identifier("Win32_Processor", "ProcessorId");
				if (text == "")
				{
					text = HWID.identifier("Win32_Processor", "Name");
					if (text == "")
					{
						text = HWID.identifier("Win32_Processor", "Manufacturer");
					}
					text += HWID.identifier("Win32_Processor", "MaxClockSpeed");
				}
			}
			return text;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00042CA7 File Offset: 0x00042CA7
		private static string biosId()
		{
			return HWID.identifier("Win32_BIOS", "Manufacturer") + HWID.identifier("Win32_BIOS", "IdentificationCode") + HWID.identifier("Win32_BIOS", "ReleaseDate");
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00042CDC File Offset: 0x00042CDC
		private static string diskId()
		{
			return HWID.identifier("Win32_DiskDrive", "Model") + HWID.identifier("Win32_DiskDrive", "Manufacturer") + HWID.identifier("Win32_DiskDrive", "Signature") + HWID.identifier("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00042D2A File Offset: 0x00042D2A
		private static string baseId()
		{
			return HWID.identifier("Win32_BaseBoard", "Model") + HWID.identifier("Win32_BaseBoard", "Manufacturer") + HWID.identifier("Win32_BaseBoard", "Name");
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00042D5E File Offset: 0x00042D5E
		private static string videoId()
		{
			return HWID.identifier("Win32_VideoController", "DriverVersion") + HWID.identifier("Win32_VideoController", "Name");
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00042D83 File Offset: 0x00042D83
		private static string macId()
		{
			return HWID.identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x040005BA RID: 1466
		private static string fingerPrint = string.Empty;
	}
}
