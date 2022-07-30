using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RAW.Properties
{
	// Token: 0x020000AE RID: 174
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00025A6D File Offset: 0x00025A6D
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00025A74 File Offset: 0x00025A74
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00025A86 File Offset: 0x00025A86
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00025A94 File Offset: 0x00025A94
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00025AA6 File Offset: 0x00025AA6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x04000448 RID: 1096
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
