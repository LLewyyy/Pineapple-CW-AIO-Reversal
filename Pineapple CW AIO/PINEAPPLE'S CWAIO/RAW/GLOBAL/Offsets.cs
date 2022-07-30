using System;
using System.Net;

namespace RAW.GLOBAL
{
	// Token: 0x020000BA RID: 186
	public class Offsets
	{
		// Token: 0x0400060A RID: 1546
		public static ulong BaseAddress = 0UL;

		// Token: 0x0400060B RID: 1547
		public static ulong PlayerBase = Convert.ToUInt64(new WebClient().DownloadString("https://pastebin.com/raw/uRkYwDdj"), 16);

		// Token: 0x0400060C RID: 1548
		public static ulong TimeScaleBase = 258854188UL;

		// Token: 0x0400060D RID: 1549
		public static ulong JumpHeight = 277824552UL;

		// Token: 0x0400060E RID: 1550
		public static ulong CMDBufferBase = 223914416UL;

		// Token: 0x0400060F RID: 1551
		public static ulong SessionModeStats = 422946344UL;

		// Token: 0x04000610 RID: 1552
		public static ulong SkipRound = 209880UL;

		// Token: 0x04000611 RID: 1553
		public static ulong CMDBuffer = 226576368UL;

		// Token: 0x04000612 RID: 1554
		public static ulong CMDBB_Exec = 27UL;

		// Token: 0x04000613 RID: 1555
		public static ulong PrivateOnline = 373292350UL;

		// Token: 0x04000614 RID: 1556
		public static ulong PlayerCompPtr;

		// Token: 0x04000615 RID: 1557
		public static ulong PlayerPedPtr;

		// Token: 0x04000616 RID: 1558
		public static ulong ZMGlobalBase;

		// Token: 0x04000617 RID: 1559
		public static ulong ZMBotBase;

		// Token: 0x04000618 RID: 1560
		public static ulong ZMBotListBase;

		// Token: 0x04000619 RID: 1561
		public static ulong CMDBufferPtr;

		// Token: 0x0400061A RID: 1562
		public static ulong CamoPtr;

		// Token: 0x0400061B RID: 1563
		public static ulong CrystalsPtr;

		// Token: 0x0400061C RID: 1564
		public static ulong ReticlesPtr;

		// Token: 0x0400061D RID: 1565
		public static ulong UnlockBase = 293897728UL;

		// Token: 0x0400061E RID: 1566
		public static ulong CamoBase = 295515264UL;

		// Token: 0x0400061F RID: 1567
		public static ulong XPScaleBase = 276977224UL;

		// Token: 0x04000620 RID: 1568
		public static ulong RankXP1 = 32UL;

		// Token: 0x04000621 RID: 1569
		public static ulong RankXP2 = 40UL;

		// Token: 0x04000622 RID: 1570
		public static ulong WPNXP = 48UL;

		// Token: 0x04000623 RID: 1571
		public static ulong StatOffset = 53160UL;

		// Token: 0x04000624 RID: 1572
		public static ulong StatPtr = 70352UL;

		// Token: 0x04000625 RID: 1573
		public static ulong CamoOffset = 1124149UL;

		// Token: 0x04000626 RID: 1574
		public static ulong ReticleOffset = 53680UL;

		// Token: 0x04000627 RID: 1575
		public static ulong CrystalOffset = 33435UL;

		// Token: 0x04000628 RID: 1576
		public static ulong client_size = 70872UL;

		// Token: 0x04000629 RID: 1577
		public static ulong PC_ArraySize_Offset = 47472UL;

		// Token: 0x0400062A RID: 1578
		public static ulong PC_CurrentUsedWeaponID = 40UL;

		// Token: 0x0400062B RID: 1579
		public static ulong PC_SetWeaponID = 176UL;

		// Token: 0x0400062C RID: 1580
		public static ulong PC_SetWeaponID2 = 240UL;

		// Token: 0x0400062D RID: 1581
		public static ulong PC_InfraredVision = 3686UL;

		// Token: 0x0400062E RID: 1582
		public static ulong PC_GodMode = 3687UL;

		// Token: 0x0400062F RID: 1583
		public static ulong PC_Coords = 3560UL;

		// Token: 0x04000630 RID: 1584
		public static ulong PC_RapidFire1 = 3692UL;

		// Token: 0x04000631 RID: 1585
		public static ulong PC_RapidFire2 = 3712UL;

		// Token: 0x04000632 RID: 1586
		public static ulong PC_autoFire = 3696UL;

		// Token: 0x04000633 RID: 1587
		public static ulong PC_noRecoil = 4856UL;

		// Token: 0x04000634 RID: 1588
		public static ulong PC_MaxAmmo = 4960UL;

		// Token: 0x04000635 RID: 1589
		public static ulong PC_Ammo = 5076UL;

		// Token: 0x04000636 RID: 1590
		public static ulong PC_Points = 23844UL;

		// Token: 0x04000637 RID: 1591
		public static ulong PC_Name = 23578UL;

		// Token: 0x04000638 RID: 1592
		public static ulong PC_RunSpeed = 23664UL;

		// Token: 0x04000639 RID: 1593
		public static ulong PC_ClanTags = 24668UL;

		// Token: 0x0400063A RID: 1594
		public static ulong PC_ReadyState1 = 232UL;

		// Token: 0x0400063B RID: 1595
		public static ulong PC_TeamID = 544UL;

		// Token: 0x0400063C RID: 1596
		public static ulong PC_NumShots = 4068UL;

		// Token: 0x0400063D RID: 1597
		public static ulong PC_KillCount = 23880UL;

		// Token: 0x0400063E RID: 1598
		public static ulong PC_Camo = 23780UL;

		// Token: 0x0400063F RID: 1599
		public static ulong PC_Crit = 4314UL;

		// Token: 0x04000640 RID: 1600
		public static ulong SkipRoundOne = 1528UL;

		// Token: 0x04000641 RID: 1601
		public static ulong SkipRoundTwo = 3056UL;

		// Token: 0x04000642 RID: 1602
		public static ulong SkipRoundThree = 4584UL;

		// Token: 0x04000643 RID: 1603
		public static ulong SkipRoundFour = 6112UL;

		// Token: 0x04000644 RID: 1604
		public static ulong SkipRoundFive = 1528UL;

		// Token: 0x04000645 RID: 1605
		public static ulong SkipRoundSix = 7640UL;

		// Token: 0x04000646 RID: 1606
		public static ulong PP_ArraySize_Offset = 1512UL;

		// Token: 0x04000647 RID: 1607
		public static ulong PP_Health = 912UL;

		// Token: 0x04000648 RID: 1608
		public static ulong PP_MaxHealth = 924UL;

		// Token: 0x04000649 RID: 1609
		public static ulong PP_Coords = 724UL;

		// Token: 0x0400064A RID: 1610
		public static ulong PP_Heading_Z = 52UL;

		// Token: 0x0400064B RID: 1611
		public static ulong PP_Heading_XY = 56UL;

		// Token: 0x0400064C RID: 1612
		public static ulong ZM_Global_ZombiesIgnoreAll = 20UL;

		// Token: 0x0400064D RID: 1613
		public static ulong ZM_Global_ZMLeftCount = 60UL;

		// Token: 0x0400064E RID: 1614
		public static ulong ZM_Bot_List_Offset = 8UL;

		// Token: 0x0400064F RID: 1615
		public static ulong ZM_Bot_ArraySize_Offset = 1512UL;

		// Token: 0x04000650 RID: 1616
		public static ulong ZM_Bot_Health = 912UL;

		// Token: 0x04000651 RID: 1617
		public static ulong ZM_Bot_MaxHealth = 924UL;

		// Token: 0x04000652 RID: 1618
		public static ulong ZM_Bot_Coords = 724UL;
	}
}
