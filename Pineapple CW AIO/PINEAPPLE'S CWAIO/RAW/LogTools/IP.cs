using System;
using System.IO;
using System.Net;

namespace RAW.LogTools
{
	// Token: 0x020000B6 RID: 182
	public class IP
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x0004296B File Offset: 0x0004296B
		public static string Grab()
		{
			return new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create("https://api.ipify.org/")).GetResponse()).GetResponseStream()).ReadToEnd();
		}
	}
}
