using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RAW.Properties
{
	// Token: 0x020000AD RID: 173
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x000024F2 File Offset: 0x000024F2
		internal Resources()
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0002595A File Offset: 0x0002595A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("RAW.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00025986 File Offset: 0x00025986
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0002598D File Offset: 0x0002598D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00025995 File Offset: 0x00025995
		internal static Bitmap BackgroundNEW
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("BackgroundNEW", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000259B0 File Offset: 0x000259B0
		internal static Bitmap CloseIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("CloseIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x000259CB File Offset: 0x000259CB
		internal static Bitmap Discord
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Discord", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000259E6 File Offset: 0x000259E6
		internal static Bitmap EmailIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("EmailIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00025A01 File Offset: 0x00025A01
		internal static Bitmap KeyIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("KeyIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00025A1C File Offset: 0x00025A1C
		internal static Bitmap PassIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("PassIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00025A37 File Offset: 0x00025A37
		internal static Bitmap ToolPanel
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ToolPanel", Resources.resourceCulture);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00025A52 File Offset: 0x00025A52
		internal static Bitmap UserIcon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("UserIcon", Resources.resourceCulture);
			}
		}

		// Token: 0x04000446 RID: 1094
		private static ResourceManager resourceMan;

		// Token: 0x04000447 RID: 1095
		private static CultureInfo resourceCulture;
	}
}
