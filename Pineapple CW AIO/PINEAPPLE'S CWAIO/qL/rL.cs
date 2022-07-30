using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using kR;
using Microsoft.Win32.SafeHandles;
using tv;

namespace qL
{
	// Token: 0x0200000E RID: 14
	public class rL : IDisposable, tw
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002E4A File Offset: 0x00002E4A
		public tu Driver { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002E52 File Offset: 0x00002E52
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002E5A File Offset: 0x00002E5A
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002E63 File Offset: 0x00002E63
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002E6B File Offset: 0x00002E6B
		public EventHandler Connected { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002E74 File Offset: 0x00002E74
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002E7C File Offset: 0x00002E7C
		public EventHandler Disconnected { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002E85 File Offset: 0x00002E85
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002E8D File Offset: 0x00002E8D
		public EventHandler Disposed { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002E96 File Offset: 0x00002E96
		public bool IsConnected
		{
			get
			{
				return this.Handle != null && !this.Handle.IsInvalid && !this.Handle.IsClosed;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002EBD File Offset: 0x00002EBD
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002EC5 File Offset: 0x00002EC5
		public bool IsDisposed { get; private set; }

		// Token: 0x06000072 RID: 114 RVA: 0x000024F2 File Offset: 0x000024F2
		protected rL()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002ECE File Offset: 0x00002ECE
		public rL(tu Driver)
		{
			this.Driver = Driver;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002EE0 File Offset: 0x00002EE0
		public void Connect()
		{
			if (this.IsConnected)
			{
				this.Disconnect();
			}
			this.Handle = lp.CreateFile(this.Driver.Config.ry, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
			if (this.IsConnected && this.Connected != null)
			{
				try
				{
					this.Connected(this, EventArgs.Empty);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002F60 File Offset: 0x00002F60
		public bool TryIoControl(uint IoCtl)
		{
			return rL.rW(this.Handle, IoCtl, null, 0, null, 0);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F72 File Offset: 0x00002F72
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData)
		{
			return this.TryIoControl<TInput>(IoCtl, IoData, Marshal.SizeOf<TInput>());
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002F81 File Offset: 0x00002F81
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize)
		{
			return rL.rW(this.Handle, IoCtl, IoData, IoDataSize, null, 0);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002F98 File Offset: 0x00002F98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput)
		{
			return this.TryIoControl<TInput, TOutput>(IoCtl, IoData, Marshal.SizeOf<TInput>(), out IoOutput, Marshal.SizeOf<TOutput>());
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002FAD File Offset: 0x00002FAD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize)
		{
			IoOutput = default(TOutput);
			return rL.rW(this.Handle, IoCtl, IoData, IoDataSize, IoOutput, IoOutputSize);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002FD8 File Offset: 0x00002FD8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool rP<TInput, TOutput>(uint rQ, TInput rR, int rS, out TOutput rT, int rU, ref int rV)
		{
			rT = default(TOutput);
			return rL.DeviceIoControl(this.Handle, rQ, rR, rS, rT, rU, ref rV, IntPtr.Zero);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000300C File Offset: 0x0000300C
		public void Disconnect()
		{
			if (this.IsConnected)
			{
				this.Handle.Close();
				if (this.Disconnected != null)
				{
					try
					{
						this.Disconnected(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
			}
			this.Handle = null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003064 File Offset: 0x00003064
		public void Dispose()
		{
			if (!this.IsDisposed)
			{
				this.IsDisposed = true;
				this.Disconnect();
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

		// Token: 0x0600007D RID: 125 RVA: 0x000030B8 File Offset: 0x000030B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool rW(SafeFileHandle rX, uint rY, object rZ, int sa, object sb, int sc)
		{
			int num = 0;
			return rL.DeviceIoControl(rX, rY, rZ, sa, sb, sc, ref num, IntPtr.Zero);
		}

		// Token: 0x0600007E RID: 126
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool DeviceIoControl(SafeFileHandle sd, uint se, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object sf, int sg, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object sh, int si, ref int sj, IntPtr sk);
	}
}
