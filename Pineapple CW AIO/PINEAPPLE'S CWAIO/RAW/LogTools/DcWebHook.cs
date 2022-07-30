using System;
using System.Collections.Specialized;
using System.Net;

namespace RAW.LogTools
{
	// Token: 0x020000B5 RID: 181
	public class DcWebHook : IDisposable
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000428AD File Offset: 0x000428AD
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x000428B5 File Offset: 0x000428B5
		public string WebHook { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x000428BE File Offset: 0x000428BE
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000428C6 File Offset: 0x000428C6
		public string UserName { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000428CF File Offset: 0x000428CF
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000428D7 File Offset: 0x000428D7
		public string ProfilePicture { get; set; }

		// Token: 0x06000525 RID: 1317 RVA: 0x000428E0 File Offset: 0x000428E0
		public DcWebHook()
		{
			this.dWebClient = new WebClient();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000428F4 File Offset: 0x000428F4
		public void SendMessage(string msgSend)
		{
			DcWebHook.discordValues.Add("username", this.UserName);
			DcWebHook.discordValues.Add("avatar_url", this.ProfilePicture);
			DcWebHook.discordValues.Add("content", msgSend);
			this.dWebClient.UploadValues(this.WebHook, DcWebHook.discordValues);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00042952 File Offset: 0x00042952
		public void Dispose()
		{
			this.dWebClient.Dispose();
		}

		// Token: 0x040005B5 RID: 1461
		private readonly WebClient dWebClient;

		// Token: 0x040005B6 RID: 1462
		private static NameValueCollection discordValues = new NameValueCollection();
	}
}
