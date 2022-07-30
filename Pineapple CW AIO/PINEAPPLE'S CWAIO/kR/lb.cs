using System;
using System.Runtime.InteropServices;

namespace kR
{
	// Token: 0x02000018 RID: 24
	public struct lb : IDisposable
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00006D1C File Offset: 0x00006D1C
		public lb(string name, uint attrs)
		{
			this.lc = 0;
			this.ld = IntPtr.Zero;
			this.le = IntPtr.Zero;
			this.lf = attrs;
			this.lg = IntPtr.Zero;
			this.lh = IntPtr.Zero;
			this.lc = Marshal.SizeOf<lb>(this);
			this.ll = new lm(name);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00006D80 File Offset: 0x00006D80
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00006D9C File Offset: 0x00006D9C
		public lm ll
		{
			get
			{
				return (lm)Marshal.PtrToStructure(this.le, typeof(lm));
			}
			set
			{
				bool fDeleteOld;
				if (!(fDeleteOld = (this.le != IntPtr.Zero)))
				{
					this.le = Marshal.AllocHGlobal(Marshal.SizeOf<lm>(value));
				}
				Marshal.StructureToPtr<lm>(value, this.le, fDeleteOld);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006DE0 File Offset: 0x00006DE0
		public void Dispose()
		{
			if (this.le != IntPtr.Zero)
			{
				Marshal.DestroyStructure(this.le, typeof(lm));
				Marshal.FreeHGlobal(this.le);
				this.le = IntPtr.Zero;
			}
		}

		// Token: 0x0400008C RID: 140
		public int lc;

		// Token: 0x0400008D RID: 141
		public IntPtr ld;

		// Token: 0x0400008E RID: 142
		private IntPtr le;

		// Token: 0x0400008F RID: 143
		public uint lf;

		// Token: 0x04000090 RID: 144
		public IntPtr lg;

		// Token: 0x04000091 RID: 145
		public IntPtr lh;
	}
}
