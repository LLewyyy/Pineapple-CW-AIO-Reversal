using System;
using System.IO;
using kc;
using kR;
using Microsoft.Win32.SafeHandles;
using sU;
using tA;
using tv;

namespace qL
{
	// Token: 0x0200000B RID: 11
	public class qK : IDisposable, tu
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000290D File Offset: 0x0000290D
		public tw IO { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002915 File Offset: 0x00002915
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000291D File Offset: 0x0000291D
		internal tx qX { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002926 File Offset: 0x00002926
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000292E File Offset: 0x0000292E
		public rg Config { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002937 File Offset: 0x00002937
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000293F File Offset: 0x0000293F
		public EventHandler Loaded { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002948 File Offset: 0x00002948
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002950 File Offset: 0x00002950
		public EventHandler Unloaded { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002959 File Offset: 0x00002959
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002961 File Offset: 0x00002961
		public EventHandler Disposed { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000296A File Offset: 0x0000296A
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002972 File Offset: 0x00002972
		public bool IsLoaded { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000297B File Offset: 0x0000297B
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002983 File Offset: 0x00002983
		public bool IsDisposed { get; private set; }

		// Token: 0x06000048 RID: 72 RVA: 0x000024F2 File Offset: 0x000024F2
		protected qK()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000298C File Offset: 0x0000298C
		public qK(rg Config, string LoaderPath = null)
		{
			this.qY(Config, LoaderPath);
			switch (Config.rG)
			{
			case tB.tC:
				this.IO = null;
				return;
			case tB.tD:
				this.IO = new rL(this);
				return;
			case tB.tE:
				this.IO = new sl(this);
				return;
			default:
				throw new ArgumentException("Invalid IoMethod specified", "IoMethod");
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000029F4 File Offset: 0x000029F4
		public void qY(rg qZ, string ra = null)
		{
			if (qZ == null)
			{
				throw new ArgumentNullException("Config");
			}
			this.Config = qZ;
			if (string.IsNullOrEmpty(qZ.rq))
			{
				throw new Exception("Config->ServiceName is null or empty");
			}
			if (qZ.rG == tB.tD && string.IsNullOrEmpty(qZ.ry))
			{
				throw new Exception("Config->SymbolicLink is null or empty");
			}
			if (!string.IsNullOrEmpty(ra))
			{
				this.rb(ra);
			}
			if (this.Config.rC > tz.N)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
			this.qX = new sT();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002A8F File Offset: 0x00002A8F
		public void rb(string rc)
		{
			if (string.IsNullOrEmpty(rc))
			{
				throw new ArgumentNullException("Path");
			}
			if (this.Config.rC > tz.N)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002AC4 File Offset: 0x00002AC4
		public bool Load()
		{
			bool result;
			if (!this.qX.tp(this))
			{
				kb.kj(typeof(qK), "Failed to create the driver at Load().");
				result = false;
			}
			else
			{
				if (!qK.rd(this.Config.ry, tB.tD) && !this.qX.tr())
				{
					kb.kj(typeof(qK), "Failed to load the driver at Load().");
					return false;
				}
				this.IsLoaded = true;
				if (this.IO.IsConnected)
				{
					this.IO.Disconnect();
				}
				this.IO.Connect();
				if (!this.IO.IsConnected)
				{
					kb.kj(typeof(qK), "Failed to open the symbolic file.");
				}
				if (this.Loaded != null)
				{
					try
					{
						this.Loaded(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002BBC File Offset: 0x00002BBC
		public bool Unload()
		{
			if (this.IO.IsConnected)
			{
				this.IO.Disconnect();
			}
			bool result;
			if (!this.qX.ts())
			{
				kb.kj(typeof(qK), "Failed to unload the driver at Unload().");
				result = false;
			}
			else if (!this.qX.tt())
			{
				kb.kj(typeof(qK), "Failed to delete the driver at Unload().");
				result = false;
			}
			else
			{
				this.IsLoaded = false;
				if (this.Unloaded != null)
				{
					try
					{
						this.Unloaded(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002C6C File Offset: 0x00002C6C
		public void Dispose()
		{
			if (!this.IsDisposed)
			{
				this.IsDisposed = true;
				try
				{
					if (!this.Unload())
					{
						kb.kj(typeof(qK), "Failed to unload the driver at Dispose().");
					}
				}
				catch (Exception ex)
				{
					kb.kj(typeof(qK), ex.GetType().Name + ", " + ex.Message);
				}
				tw io = this.IO;
				if (io != null)
				{
					io.Dispose();
				}
				if (this.Disposed != null)
				{
					try
					{
						this.Disposed(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002D28 File Offset: 0x00002D28
		public static bool rd(string re, tB rf = tB.tD)
		{
			bool result;
			if (rf != tB.tD)
			{
				if (rf != tB.tE)
				{
					throw new ArgumentException();
				}
				result = false;
			}
			else
			{
				SafeFileHandle safeFileHandle = lp.CreateFile(re, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
				int num = (safeFileHandle == null) ? 0 : ((!safeFileHandle.IsInvalid) ? 1 : 0);
				if (safeFileHandle != null)
				{
					safeFileHandle.Close();
				}
				result = (num != 0);
			}
			return result;
		}
	}
}
