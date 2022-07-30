using System;

namespace RAW.AntiDebug.WinStructs
{
	// Token: 0x020000C6 RID: 198
	public enum ThreadInformationClass
	{
		// Token: 0x040008B4 RID: 2228
		ThreadBasicInformation,
		// Token: 0x040008B5 RID: 2229
		ThreadTimes,
		// Token: 0x040008B6 RID: 2230
		ThreadPriority,
		// Token: 0x040008B7 RID: 2231
		ThreadBasePriority,
		// Token: 0x040008B8 RID: 2232
		ThreadAffinityMask,
		// Token: 0x040008B9 RID: 2233
		ThreadImpersonationToken,
		// Token: 0x040008BA RID: 2234
		ThreadDescriptorTableEntry,
		// Token: 0x040008BB RID: 2235
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x040008BC RID: 2236
		ThreadEventPair_Reusable,
		// Token: 0x040008BD RID: 2237
		ThreadQuerySetWin32StartAddress,
		// Token: 0x040008BE RID: 2238
		ThreadZeroTlsCell,
		// Token: 0x040008BF RID: 2239
		ThreadPerformanceCount,
		// Token: 0x040008C0 RID: 2240
		ThreadAmILastThread,
		// Token: 0x040008C1 RID: 2241
		ThreadIdealProcessor,
		// Token: 0x040008C2 RID: 2242
		ThreadPriorityBoost,
		// Token: 0x040008C3 RID: 2243
		ThreadSetTlsArrayAddress,
		// Token: 0x040008C4 RID: 2244
		ThreadIsIoPending,
		// Token: 0x040008C5 RID: 2245
		ThreadHideFromDebugger,
		// Token: 0x040008C6 RID: 2246
		ThreadBreakOnTermination,
		// Token: 0x040008C7 RID: 2247
		ThreadSwitchLegacyState,
		// Token: 0x040008C8 RID: 2248
		ThreadIsTerminated,
		// Token: 0x040008C9 RID: 2249
		ThreadLastSystemCall,
		// Token: 0x040008CA RID: 2250
		ThreadIoPriority,
		// Token: 0x040008CB RID: 2251
		ThreadCycleTime,
		// Token: 0x040008CC RID: 2252
		ThreadPagePriority,
		// Token: 0x040008CD RID: 2253
		ThreadActualBasePriority,
		// Token: 0x040008CE RID: 2254
		ThreadTebInformation,
		// Token: 0x040008CF RID: 2255
		ThreadCSwitchMon,
		// Token: 0x040008D0 RID: 2256
		ThreadCSwitchPmu,
		// Token: 0x040008D1 RID: 2257
		ThreadWow64Context,
		// Token: 0x040008D2 RID: 2258
		ThreadGroupInformation,
		// Token: 0x040008D3 RID: 2259
		ThreadUmsInformation,
		// Token: 0x040008D4 RID: 2260
		ThreadCounterProfiling,
		// Token: 0x040008D5 RID: 2261
		ThreadIdealProcessorEx,
		// Token: 0x040008D6 RID: 2262
		ThreadCpuAccountingInformation,
		// Token: 0x040008D7 RID: 2263
		ThreadSuspendCount,
		// Token: 0x040008D8 RID: 2264
		ThreadDescription = 38,
		// Token: 0x040008D9 RID: 2265
		ThreadActualGroupAffinity = 41,
		// Token: 0x040008DA RID: 2266
		ThreadDynamicCodePolicy
	}
}
