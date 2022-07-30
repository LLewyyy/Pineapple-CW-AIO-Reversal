using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace kc
{
	// Token: 0x0200001D RID: 29
	internal static class kb
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00005140 File Offset: 0x00005140
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void kd(Type ke, string kf)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005140 File Offset: 0x00005140
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void kg(Type kh, string ki)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000707D File Offset: 0x0000707D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void kj(Type kk, string kl)
		{
			Trace.WriteLine("[ ERROR ] " + kk.Name + " : " + kl);
		}
	}
}
