using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace RAW.UTILITIES
{
	// Token: 0x0200009A RID: 154
	public class FingerPrint
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00022764 File Offset: 0x00022764
		public static string Value()
		{
			if (string.IsNullOrEmpty(FingerPrint.fingerPrint))
			{
				FingerPrint.fingerPrint = FingerPrint.GetHash(string.Concat(new string[]
				{
					"CPU >> ",
					FingerPrint.cpuId(),
					"\nBIOS >> ",
					FingerPrint.biosId(),
					"\nBASE >> ",
					FingerPrint.baseId(),
					"\nDISK >> ",
					FingerPrint.diskId(),
					"\nVIDEO >> ",
					FingerPrint.videoId()
				}));
			}
			return FingerPrint.fingerPrint;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000227EC File Offset: 0x000227EC
		private static string GetHash(string s)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = new ASCIIEncoding().GetBytes(s);
			return FingerPrint.GetHexString(hashAlgorithm.ComputeHash(bytes));
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00022818 File Offset: 0x00022818
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

		// Token: 0x06000323 RID: 803 RVA: 0x000228C4 File Offset: 0x000228C4
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

		// Token: 0x06000324 RID: 804 RVA: 0x00022960 File Offset: 0x00022960
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

		// Token: 0x06000325 RID: 805 RVA: 0x000229E8 File Offset: 0x000229E8
		private static string cpuId()
		{
			string text = FingerPrint.identifier("Win32_Processor", "UniqueId");
			if (text == "")
			{
				text = FingerPrint.identifier("Win32_Processor", "ProcessorId");
				if (text == "")
				{
					text = FingerPrint.identifier("Win32_Processor", "Name");
					if (text == "")
					{
						text = FingerPrint.identifier("Win32_Processor", "Manufacturer");
					}
					text += FingerPrint.identifier("Win32_Processor", "MaxClockSpeed");
				}
			}
			return text;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00022A73 File Offset: 0x00022A73
		private static string biosId()
		{
			return FingerPrint.identifier("Win32_BIOS", "Manufacturer") + FingerPrint.identifier("Win32_BIOS", "IdentificationCode") + FingerPrint.identifier("Win32_BIOS", "ReleaseDate");
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00022AA8 File Offset: 0x00022AA8
		private static string diskId()
		{
			return FingerPrint.identifier("Win32_DiskDrive", "Model") + FingerPrint.identifier("Win32_DiskDrive", "Manufacturer") + FingerPrint.identifier("Win32_DiskDrive", "Signature") + FingerPrint.identifier("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00022AF6 File Offset: 0x00022AF6
		private static string baseId()
		{
			return FingerPrint.identifier("Win32_BaseBoard", "Model") + FingerPrint.identifier("Win32_BaseBoard", "Manufacturer") + FingerPrint.identifier("Win32_BaseBoard", "Name");
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00022B2A File Offset: 0x00022B2A
		private static string videoId()
		{
			return FingerPrint.identifier("Win32_VideoController", "DriverVersion") + FingerPrint.identifier("Win32_VideoController", "Name");
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00022B4F File Offset: 0x00022B4F
		private static string macId()
		{
			return FingerPrint.identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x040003E1 RID: 993
		private static string fingerPrint = string.Empty;
	}
}
