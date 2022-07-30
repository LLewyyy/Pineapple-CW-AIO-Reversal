using System;
using Microsoft.Win32.SafeHandles;

namespace tv
{
	// Token: 0x02000003 RID: 3
	public interface tw : IDisposable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14
		tu Driver { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15
		SafeFileHandle Handle { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		EventHandler Connected { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		EventHandler Disconnected { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		EventHandler Disposed { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000016 RID: 22
		bool IsConnected { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000017 RID: 23
		bool IsDisposed { get; }

		// Token: 0x06000018 RID: 24
		void Connect();

		// Token: 0x06000019 RID: 25
		void Disconnect();

		// Token: 0x0600001A RID: 26
		bool TryIoControl(uint IoCtl);

		// Token: 0x0600001B RID: 27
		bool TryIoControl<TInput>(uint IoCtl, TInput IoData);

		// Token: 0x0600001C RID: 28
		bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize);

		// Token: 0x0600001D RID: 29
		bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput);

		// Token: 0x0600001E RID: 30
		bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize);
	}
}
