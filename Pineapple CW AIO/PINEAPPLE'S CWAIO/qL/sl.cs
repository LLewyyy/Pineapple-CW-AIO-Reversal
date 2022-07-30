using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using kc;
using kR;
using Microsoft.Win32.SafeHandles;
using nc;
using tv;

namespace qL
{
	// Token: 0x0200000F RID: 15
	public class sl : IDisposable, tw
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000030DB File Offset: 0x000030DB
		public tu Driver { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000030E3 File Offset: 0x000030E3
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000030EB File Offset: 0x000030EB
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000030F4 File Offset: 0x000030F4
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000030FC File Offset: 0x000030FC
		public IntPtr st { get; private set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003105 File Offset: 0x00003105
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000310D File Offset: 0x0000310D
		public AutoResetEvent sx { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003116 File Offset: 0x00003116
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000311E File Offset: 0x0000311E
		public AutoResetEvent sB { get; private set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003127 File Offset: 0x00003127
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000312F File Offset: 0x0000312F
		public EventHandler Connected { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003138 File Offset: 0x00003138
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00003140 File Offset: 0x00003140
		public EventHandler Disconnected { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003149 File Offset: 0x00003149
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003151 File Offset: 0x00003151
		public EventHandler Disposed { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000315A File Offset: 0x0000315A
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003162 File Offset: 0x00003162
		public object sF { get; private set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000316C File Offset: 0x0000316C
		public bool IsConnected
		{
			get
			{
				return (this.sx != null && !this.sx.SafeWaitHandle.IsInvalid && !this.sx.SafeWaitHandle.IsClosed) || (this.sB != null && !this.sB.SafeWaitHandle.IsInvalid && !this.sB.SafeWaitHandle.IsClosed);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000031DC File Offset: 0x000031DC
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000031E4 File Offset: 0x000031E4
		public bool IsDisposed { get; private set; }

		// Token: 0x06000093 RID: 147 RVA: 0x000024F2 File Offset: 0x000024F2
		protected sl()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000031F0 File Offset: 0x000031F0
		public sl(tu Driver)
		{
			this.sF = new object();
			this.Driver = Driver;
			if (this.Driver.Config.rK.BL <= 0UL)
			{
				this.st = Marshal.AllocHGlobal(4096);
				rg.Bz rK = this.Driver.Config.rK;
				if (this.st == IntPtr.Zero)
				{
					throw new InsufficientMemoryException();
				}
				rK.BL = (ulong)this.st.ToInt64();
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000327C File Offset: 0x0000327C
		public void Connect()
		{
			if (!this.IsConnected)
			{
				IntPtr intPtr = (IntPtr)0;
				IntPtr intPtr2 = (IntPtr)0;
				lb lb = new lb(this.Driver.Config.rK.BP, 0U);
				lb lb2 = new lb(this.Driver.Config.rK.BT, 0U);
				GCHandle gchandle = GCHandle.Alloc(lb, GCHandleType.Pinned);
				GCHandle gchandle2 = GCHandle.Alloc(lb2, GCHandleType.Pinned);
				Q q = (Q)sl.NtOpenEvent(ref intPtr, 2031619U, gchandle.AddrOfPinnedObject());
				if (q > Q.R)
				{
					gchandle.Free();
					gchandle2.Free();
					if (intPtr != IntPtr.Zero)
					{
						sl.NtClose(intPtr);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						sl.NtClose(intPtr2);
					}
					kb.kj(typeof(sl), "Failed to open the first event object. [" + q.ToString() + "]");
					return;
				}
				Q q2 = (Q)sl.NtOpenEvent(ref intPtr2, 2031619U, gchandle2.AddrOfPinnedObject());
				if (q2 > Q.R)
				{
					gchandle.Free();
					gchandle2.Free();
					if (intPtr != IntPtr.Zero)
					{
						sl.NtClose(intPtr);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						sl.NtClose(intPtr2);
					}
					kb.kj(typeof(sl), "Failed to open the second event object. [" + q2.ToString() + "]");
					return;
				}
				gchandle.Free();
				gchandle2.Free();
				this.sx = new AutoResetEvent(false);
				this.sx.Close();
				this.sx.SafeWaitHandle = new SafeWaitHandle(intPtr, false);
				this.sB = new AutoResetEvent(false);
				this.sB.Close();
				this.sB.SafeWaitHandle = new SafeWaitHandle(intPtr2, false);
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
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000348C File Offset: 0x0000348C
		public bool TryIoControl(uint IoCtl)
		{
			object sF = this.sF;
			bool result;
			lock (sF)
			{
				Marshal.WriteInt32(this.st, (int)IoCtl);
				this.sx.Set();
				result = this.sB.WaitOne();
				this.sB.Reset();
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000034F8 File Offset: 0x000034F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData)
		{
			return this.TryIoControl<TInput>(IoCtl, IoData, Marshal.SizeOf<TInput>());
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003508 File Offset: 0x00003508
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize)
		{
			object sF = this.sF;
			bool result;
			lock (sF)
			{
				IntPtr st = this.st;
				IntPtr sQ = IntPtr.Add(st, 4);
				Marshal.WriteInt32(st, (int)IoCtl);
				if (IoData != null)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(IoDataSize);
					Marshal.StructureToPtr<TInput>(IoData, intPtr, true);
					sl.CopyMemory(sQ, intPtr, (uint)IoDataSize);
					this.sx.Set();
					Marshal.FreeHGlobal(intPtr);
				}
				result = this.sB.WaitOne();
				this.sB.Reset();
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000035A8 File Offset: 0x000035A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput)
		{
			int ioDataSize = Marshal.SizeOf<TInput>();
			int ioOutputSize = Marshal.SizeOf<TOutput>();
			return this.TryIoControl<TInput, TOutput>(IoCtl, IoData, ioDataSize, out IoOutput, ioOutputSize);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000035CC File Offset: 0x000035CC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize)
		{
			object sF = this.sF;
			bool result;
			lock (sF)
			{
				IntPtr st = this.st;
				IntPtr intPtr = IntPtr.Add(st, 4);
				Marshal.WriteInt32(st, (int)IoCtl);
				if (IoData != null)
				{
					IntPtr intPtr2 = Marshal.AllocHGlobal(IoDataSize);
					Marshal.StructureToPtr<TInput>(IoData, intPtr2, true);
					sl.CopyMemory(intPtr, intPtr2, (uint)IoDataSize);
					this.sx.Set();
					Marshal.FreeHGlobal(intPtr2);
				}
				result = this.sB.WaitOne();
				IoOutput = Marshal.PtrToStructure<TOutput>(intPtr);
				this.sB.Reset();
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003678 File Offset: 0x00003678
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool rP<TInput, TOutput>(uint sG, TInput sH, int sI, out TOutput sJ, int sK, ref int sL)
		{
			return this.TryIoControl<TInput, TOutput>(sG, sH, sI, out sJ, sK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003688 File Offset: 0x00003688
		public void Disconnect()
		{
			if (this.IsConnected)
			{
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Close();
				}
				AutoResetEvent sx = this.sx;
				if (sx != null)
				{
					sx.Close();
				}
				AutoResetEvent sB = this.sB;
				if (sB != null)
				{
					sB.Close();
				}
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
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003704 File Offset: 0x00003704
		public void Dispose()
		{
			if (!this.IsDisposed)
			{
				this.IsDisposed = true;
				this.Disconnect();
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Dispose();
				}
				AutoResetEvent sx = this.sx;
				if (sx != null)
				{
					sx.Dispose();
				}
				AutoResetEvent sB = this.sB;
				if (sB != null)
				{
					sB.Dispose();
				}
				this.Handle = null;
				this.sx = null;
				this.sB = null;
				if (this.st != IntPtr.Zero)
				{
					try
					{
						Marshal.FreeHGlobal(this.st);
					}
					catch (Exception)
					{
					}
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

		// Token: 0x0600009E RID: 158
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtOpenEvent(ref IntPtr sM, uint sN, IntPtr sO);

		// Token: 0x0600009F RID: 159
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtClose(IntPtr sP);

		// Token: 0x060000A0 RID: 160
		[DllImport("kernel32.dll")]
		private static extern void CopyMemory(IntPtr sQ, IntPtr sR, uint sS);
	}
}
