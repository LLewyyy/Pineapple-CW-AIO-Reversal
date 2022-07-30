﻿using System;

namespace RAW.AntiDebug.WinStructs
{
	// Token: 0x020000C7 RID: 199
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040008DC RID: 2268
		TERMINATE = 1,
		// Token: 0x040008DD RID: 2269
		SUSPEND_RESUME = 2,
		// Token: 0x040008DE RID: 2270
		GET_CONTEXT = 8,
		// Token: 0x040008DF RID: 2271
		SET_CONTEXT = 16,
		// Token: 0x040008E0 RID: 2272
		SET_INFORMATION = 32,
		// Token: 0x040008E1 RID: 2273
		QUERY_INFORMATION = 64,
		// Token: 0x040008E2 RID: 2274
		SET_THREAD_TOKEN = 128,
		// Token: 0x040008E3 RID: 2275
		IMPERSONATE = 256,
		// Token: 0x040008E4 RID: 2276
		DIRECT_IMPERSONATION = 512
	}
}
