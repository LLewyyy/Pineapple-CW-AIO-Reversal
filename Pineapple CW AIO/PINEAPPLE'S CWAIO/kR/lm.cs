using System;
using System.Runtime.InteropServices;

namespace kR
{
	// Token: 0x02000019 RID: 25
	public struct lm : IDisposable
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00006E2D File Offset: 0x00006E2D
		public lm(string s)
		{
			this.lc = (ushort)(s.Length * 2);
			this.ln = this.lc + 2;
			this.lo = Marshal.StringToHGlobalUni(s);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006E59 File Offset: 0x00006E59
		public void Dispose()
		{
			Marshal.FreeHGlobal(this.lo);
			this.lo = IntPtr.Zero;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006E71 File Offset: 0x00006E71
		public override string ToString()
		{
			return Marshal.PtrToStringUni(this.lo);
		}

		// Token: 0x04000092 RID: 146
		public ushort lc;

		// Token: 0x04000093 RID: 147
		public ushort ln;

		// Token: 0x04000094 RID: 148
		private IntPtr lo;
	}
}
