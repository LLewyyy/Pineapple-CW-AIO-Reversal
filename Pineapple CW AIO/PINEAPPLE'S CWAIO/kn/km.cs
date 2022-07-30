using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.ServiceProcess;
using kR;
using Microsoft.Win32;
using oj;

namespace kn
{
	// Token: 0x0200001B RID: 27
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal static class km
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00006E90 File Offset: 0x00006E90
		internal static IntPtr ko(string kp, string kq, gt kr, gP ks, gJ kt, gE ku, FileInfo kv)
		{
			IntPtr intPtr = lp.OpenSCManagerW(null, null, 983103U);
			IntPtr result;
			if (intPtr == IntPtr.Zero)
			{
				result = IntPtr.Zero;
			}
			else
			{
				IntPtr intPtr2 = lp.CreateService(intPtr, kp, kq, (uint)kr, (uint)ks, (uint)kt, (uint)ku, kv.FullName, null, null, null, null, null);
				lp.CloseServiceHandle(intPtr);
				result = ((!(intPtr2 == IntPtr.Zero)) ? intPtr2 : IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006EF8 File Offset: 0x00006EF8
		internal static IntPtr kw(string kx, gt ky)
		{
			IntPtr intPtr = lp.OpenSCManagerW(null, null, 983103U);
			IntPtr result;
			if (intPtr != IntPtr.Zero)
			{
				IntPtr intPtr2 = lp.OpenService(intPtr, kx, (uint)ky);
				km.kO(intPtr);
				result = intPtr2;
			}
			else
			{
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006F3C File Offset: 0x00006F3C
		internal static IntPtr kz(string kA, string kB, gt kC, gP kD, gJ kE, gE kF, FileInfo kG)
		{
			IntPtr intPtr = km.ko(kA, kB, kC, kD, kE, kF, kG);
			if (intPtr == IntPtr.Zero)
			{
				return km.kw(kA, kC);
			}
			return intPtr;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006F70 File Offset: 0x00006F70
		internal static bool kH(string kI)
		{
			IntPtr intPtr = km.kw(kI, gt.gD);
			bool result;
			if (intPtr != IntPtr.Zero)
			{
				km.kO(intPtr);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006FA4 File Offset: 0x00006FA4
		internal static bool kJ(string kK, Func<ServiceController, bool> kL = null)
		{
			if (kL == null || !ServiceController.GetServices().Any(kL))
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\", RegistryRights.EnumerateSubKeys))
				{
					if (registryKey.GetSubKeyNames().Any((string Name) => Name == kK))
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007024 File Offset: 0x00007024
		internal static bool kM(IntPtr kN)
		{
			if (kN == IntPtr.Zero)
			{
				throw new ArgumentException("Handle is invalid at Delete(Handle).", "Handle");
			}
			bool result;
			if (!lp.DeleteService(kN))
			{
				result = false;
			}
			else
			{
				km.kO(kN);
				result = true;
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007067 File Offset: 0x00007067
		internal static bool kO(IntPtr kP)
		{
			return lp.CloseServiceHandle(kP);
		}
	}
}
