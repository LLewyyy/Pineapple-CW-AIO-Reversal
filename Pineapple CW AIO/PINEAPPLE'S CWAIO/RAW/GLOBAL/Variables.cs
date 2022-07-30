using System;
using System.Diagnostics;
using RAW.UTILITIES;

namespace RAW.GLOBAL
{
	// Token: 0x020000BB RID: 187
	public static class Variables
	{
		// Token: 0x04000653 RID: 1619
		public static IntPtr Proc;

		// Token: 0x04000654 RID: 1620
		public static Process gameProc;

		// Token: 0x04000655 RID: 1621
		public static int userindex = -1;

		// Token: 0x04000656 RID: 1622
		public static ulong[] Skip = new ulong[50];

		// Token: 0x04000657 RID: 1623
		public static ulong[] Skip2 = new ulong[50];

		// Token: 0x04000658 RID: 1624
		public static ulong[] Skip3 = new ulong[50];

		// Token: 0x04000659 RID: 1625
		public static ulong[] Skip4 = new ulong[50];

		// Token: 0x0400065A RID: 1626
		public static ulong[] Skip5 = new ulong[50];

		// Token: 0x0400065B RID: 1627
		public static ulong[] Skip6 = new ulong[50];

		// Token: 0x0400065C RID: 1628
		public static ulong skipround1;

		// Token: 0x0400065D RID: 1629
		public static ulong skipround2;

		// Token: 0x0400065E RID: 1630
		public static ulong skipround3;

		// Token: 0x0400065F RID: 1631
		public static ulong skipround4;

		// Token: 0x04000660 RID: 1632
		public static ulong skipround5;

		// Token: 0x04000661 RID: 1633
		public static ulong skipround6;

		// Token: 0x04000662 RID: 1634
		public static int reticle = 65;

		// Token: 0x04000663 RID: 1635
		public static int camo = 62;

		// Token: 0x04000664 RID: 1636
		public static string TargetProcessName = "BlackOpsColdWar";

		// Token: 0x04000665 RID: 1637
		public static int[] GunList = new int[]
		{
			0,
			0,
			81,
			9,
			20,
			77,
			48,
			61,
			88,
			65,
			31,
			25,
			55,
			59,
			58,
			7,
			69,
			93,
			52,
			73,
			9,
			29,
			34,
			47,
			56,
			80,
			39,
			20,
			18,
			24,
			77,
			52,
			57,
			68,
			65,
			75,
			23,
			54,
			5,
			81,
			79,
			48,
			17,
			91,
			50,
			46,
			8,
			19,
			43,
			27,
			30,
			74,
			40,
			15,
			64,
			28,
			71,
			85,
			11,
			6,
			72,
			84,
			37,
			22,
			86,
			60,
			3,
			4,
			5,
			14,
			512,
			515,
			187,
			103,
			108,
			110,
			93,
			95,
			96,
			97,
			99,
			100,
			101,
			267,
			464,
			223
		};

		// Token: 0x04000666 RID: 1638
		public static int[] GunListCycle = new int[]
		{
			81,
			9,
			20,
			77,
			48,
			61,
			88,
			65,
			31,
			25,
			55,
			59,
			58,
			7,
			69,
			93,
			52,
			73,
			9,
			29,
			34,
			47,
			56,
			80,
			39,
			20,
			18,
			24,
			77,
			52,
			57,
			68,
			65,
			75,
			23,
			54,
			5,
			81,
			79,
			48,
			17,
			91,
			50,
			46,
			8,
			19,
			43,
			27,
			30,
			74,
			40,
			15,
			64,
			28,
			71,
			85,
			11,
			6,
			72,
			84,
			37,
			22,
			86,
			60,
			3,
			4,
			5,
			14
		};

		// Token: 0x04000667 RID: 1639
		public static string[] GunNames = new string[]
		{
			"WEAPONS",
			"XM4",
			"AK47",
			"KRIG",
			"QBZ",
			"FFAR",
			"MP5",
			"MILANO",
			"AK74U",
			"KSP",
			"BULLFROG",
			"TYPE",
			"M16",
			"AUG",
			"STONER",
			"RPD",
			"M60",
			"PELLINGTON",
			"LW3",
			"M82",
			"1911",
			"MAGNUM",
			"DIAMATTI",
			"HAUER",
			"GALLO",
			"CIGMA",
			"RPG ",
			"M79",
			"KNIFE",
			"GROZA",
			"FARA",
			"C58",
			"MAC10",
			"LC10",
			"PPSH",
			"OTS",
			"DMR",
			"CARV",
			"MG82",
			"ZRG",
			"SWISS",
			"AMP",
			"STREETSWEEPER",
			"WAKIZASHI",
			"SLEDGEHAMMER",
			"E-TOOL",
			"MACHETTE",
			"BALLISTIC KNIFE",
			"BASEBALL BAT",
			"MACE",
			"CANE",
			"CROSSBOW",
			"NAILGUN",
			"MARSHAL",
			"EM2",
			"TEC-9",
			"RAYGUN",
			"RAI K",
			"CRBR-S BLAZER",
			"CRBR-S PISTOL",
			"CRBR-S DIFFUSER"
		};

		// Token: 0x04000668 RID: 1640
		public static int cycint = 2;

		// Token: 0x04000669 RID: 1641
		public static int p1wpn = 0;

		// Token: 0x0400066A RID: 1642
		public static int p1wpn2 = 1;

		// Token: 0x0400066B RID: 1643
		public static int p2wpn = 0;

		// Token: 0x0400066C RID: 1644
		public static int p2wpn2 = 1;

		// Token: 0x0400066D RID: 1645
		public static int p3wpn = 0;

		// Token: 0x0400066E RID: 1646
		public static int p3wpn2 = 1;

		// Token: 0x0400066F RID: 1647
		public static int p4wpn = 0;

		// Token: 0x04000670 RID: 1648
		public static int p4wpn2 = 1;

		// Token: 0x04000671 RID: 1649
		public static int tp = 0;

		// Token: 0x04000672 RID: 1650
		public static int tpDistance = 150;

		// Token: 0x04000673 RID: 1651
		public static Vectors.Vec3.Vector3[] locationVectors = new Vectors.Vec3.Vector3[]
		{
			new Vectors.Vec3.Vector3(0f, 0f, 0f),
			new Vectors.Vec3.Vector3(1026.479f, -119.0791f, 31.72773f),
			new Vectors.Vec3.Vector3(30.51227f, -104.3433f, 10.14705f),
			new Vectors.Vec3.Vector3(-1228.808f, 220.7215f, -38.83881f),
			new Vectors.Vec3.Vector3(-675.4692f, 225.9666f, 16.39506f),
			new Vectors.Vec3.Vector3(-1369.4f, 1830.137f, -85.09624f),
			new Vectors.Vec3.Vector3(-779.1058f, 1216.973f, -279.875f),
			new Vectors.Vec3.Vector3(-197.2296f, 645.5873f, -279.875f),
			new Vectors.Vec3.Vector3(283.927f, 1692.468f, -415.875f),
			new Vectors.Vec3.Vector3(1022.18f, -687.1146f, -255.875f),
			new Vectors.Vec3.Vector3(573.6108f, -124.8955f, -543.875f),
			new Vectors.Vec3.Vector3(331.2513f, 134.4783f, -671.875f),
			new Vectors.Vec3.Vector3(-1408.134f, 482.0242f, -382.875f),
			new Vectors.Vec3.Vector3(163.1014f, 832.6141f, 293.125f),
			new Vectors.Vec3.Vector3(524.9474f, 1947.043f, 388.0641f),
			new Vectors.Vec3.Vector3(-185.0556f, 1616.27f, 332.1445f),
			new Vectors.Vec3.Vector3(-1116.466f, 364.2412f, -38.32543f),
			new Vectors.Vec3.Vector3(204.6461f, 2277.219f, 218.6982f),
			new Vectors.Vec3.Vector3(926.6042f, 80.14916f, 58.46823f),
			new Vectors.Vec3.Vector3(520.3193f, -375.9803f, -671.875f),
			new Vectors.Vec3.Vector3(742.5349f, 1887.628f, -287.875f)
		};
	}
}
