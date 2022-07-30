using System;
using System.ComponentModel;
using System.Security.Permissions;
using System.ServiceProcess;
using kc;
using kn;
using oj;
using qL;
using tv;

namespace sU
{
	// Token: 0x02000007 RID: 7
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal sealed class sT : tx
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000204F File Offset: 0x0000204F
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002057 File Offset: 0x00002057
		public bool tb { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002060 File Offset: 0x00002060
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002068 File Offset: 0x00002068
		public bool tf { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002071 File Offset: 0x00002071
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002079 File Offset: 0x00002079
		public qK ho { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002082 File Offset: 0x00002082
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000208A File Offset: 0x0000208A
		public IntPtr tk { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002093 File Offset: 0x00002093
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000209B File Offset: 0x0000209B
		public ServiceController to { get; private set; }

		// Token: 0x0600002F RID: 47 RVA: 0x000020A4 File Offset: 0x000020A4
		public bool tp(qK tq)
		{
			rg config = tq.Config;
			if (this.tb)
			{
				throw new Exception("Service is already created");
			}
			if (config == null)
			{
				throw new ArgumentNullException("Config");
			}
			this.ho = tq;
			if (tq == null)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.tk = km.kz(config.rq, config.rq, gt.gD, gP.gQ, gJ.gN, gE.gG, config.ru);
			bool result;
			if (this.tk == IntPtr.Zero)
			{
				result = false;
			}
			else
			{
				this.to = new ServiceController(config.rq);
				this.tb = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002150 File Offset: 0x00002150
		public bool tr()
		{
			if (!this.tb)
			{
				throw new Exception("Service is not created.");
			}
			bool result;
			if (this.tf)
			{
				result = true;
			}
			else
			{
				if (this.to.Status != ServiceControllerStatus.Running)
				{
					try
					{
						this.to.Start();
					}
					catch (InvalidOperationException ex)
					{
						kb.kj(typeof(sT), ex.GetType().Name + ", " + ex.Message);
						return false;
					}
					catch (Win32Exception ex2)
					{
						if (ex2.Message.Contains("signature"))
						{
							kb.kj(typeof(sT), "The driver is not signed, unable to load it using the service manager.");
						}
						else
						{
							kb.kj(typeof(sT), ex2.GetType().Name + ", " + ex2.Message);
						}
						return false;
					}
					catch (Exception ex3)
					{
						kb.kj(typeof(sT), ex3.GetType().Name + ", " + ex3.Message);
						return false;
					}
					try
					{
						this.to.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.0));
					}
					catch (System.TimeoutException)
					{
						kb.kj(typeof(sT), "Failed to start the service in 10 seconds.");
					}
					catch (Exception ex4)
					{
						kb.kj(typeof(sT), ex4.GetType().Name + ", " + ex4.Message);
						return false;
					}
				}
				this.tf = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002318 File Offset: 0x00002318
		public bool ts()
		{
			if (!this.tb)
			{
				throw new Exception("Service is not created.");
			}
			bool result;
			if (!this.tf)
			{
				result = true;
			}
			else
			{
				if (this.to.CanStop)
				{
					try
					{
						this.to.Stop();
					}
					catch (Exception ex)
					{
						kb.kj(typeof(sT), ex.GetType().Name + ", " + ex.Message);
						return false;
					}
					this.tf = false;
					try
					{
						this.to.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10.0));
					}
					catch (System.TimeoutException)
					{
						kb.kj(typeof(sT), "Failed to stop the service in 10 seconds.");
					}
					catch (Exception ex2)
					{
						kb.kj(typeof(sT), ex2.GetType().Name + ", " + ex2.Message);
						return false;
					}
					this.tf = false;
					return true;
				}
				kb.kj(typeof(sT), "Driver not stopped !");
				result = false;
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002454 File Offset: 0x00002454
		public bool tt()
		{
			if (!this.tb)
			{
				throw new Exception("Service is not created.");
			}
			bool result;
			if (this.tf && !this.ts())
			{
				result = false;
			}
			else
			{
				if (this.to != null)
				{
					this.to.Dispose();
				}
				if (this.tk != IntPtr.Zero)
				{
					if (!km.kM(this.tk))
					{
						kb.kj(typeof(sT), "Unable to delete the service using the native api.");
					}
					this.tk = IntPtr.Zero;
				}
				this.tb = false;
				result = true;
			}
			return result;
		}
	}
}
