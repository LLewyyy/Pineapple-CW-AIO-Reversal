using System;
using qL;

namespace tv
{
	// Token: 0x02000002 RID: 2
	public interface tu : IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		tw IO { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		rg Config { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4
		// (set) Token: 0x06000005 RID: 5
		EventHandler Loaded { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		EventHandler Unloaded { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		EventHandler Disposed { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10
		bool IsLoaded { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11
		bool IsDisposed { get; }

		// Token: 0x0600000C RID: 12
		bool Load();

		// Token: 0x0600000D RID: 13
		bool Unload();
	}
}
