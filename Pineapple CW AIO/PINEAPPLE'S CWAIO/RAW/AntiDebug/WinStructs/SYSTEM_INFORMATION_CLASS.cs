using System;

namespace RAW.AntiDebug.WinStructs
{
	// Token: 0x020000C5 RID: 197
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x04000815 RID: 2069
		SystemBasicInformation,
		// Token: 0x04000816 RID: 2070
		SystemProcessorInformation,
		// Token: 0x04000817 RID: 2071
		SystemPerformanceInformation,
		// Token: 0x04000818 RID: 2072
		SystemTimeOfDayInformation,
		// Token: 0x04000819 RID: 2073
		SystemPathInformation,
		// Token: 0x0400081A RID: 2074
		SystemProcessInformation,
		// Token: 0x0400081B RID: 2075
		SystemCallCountInformation,
		// Token: 0x0400081C RID: 2076
		SystemDeviceInformation,
		// Token: 0x0400081D RID: 2077
		SystemProcessorPerformanceInformation,
		// Token: 0x0400081E RID: 2078
		SystemFlagsInformation,
		// Token: 0x0400081F RID: 2079
		SystemCallTimeInformation,
		// Token: 0x04000820 RID: 2080
		SystemModuleInformation,
		// Token: 0x04000821 RID: 2081
		SystemLocksInformation,
		// Token: 0x04000822 RID: 2082
		SystemStackTraceInformation,
		// Token: 0x04000823 RID: 2083
		SystemPagedPoolInformation,
		// Token: 0x04000824 RID: 2084
		SystemNonPagedPoolInformation,
		// Token: 0x04000825 RID: 2085
		SystemHandleInformation,
		// Token: 0x04000826 RID: 2086
		SystemObjectInformation,
		// Token: 0x04000827 RID: 2087
		SystemPageFileInformation,
		// Token: 0x04000828 RID: 2088
		SystemVdmInstemulInformation,
		// Token: 0x04000829 RID: 2089
		SystemVdmBopInformation,
		// Token: 0x0400082A RID: 2090
		SystemFileCacheInformation,
		// Token: 0x0400082B RID: 2091
		SystemPoolTagInformation,
		// Token: 0x0400082C RID: 2092
		SystemInterruptInformation,
		// Token: 0x0400082D RID: 2093
		SystemDpcBehaviorInformation,
		// Token: 0x0400082E RID: 2094
		SystemFullMemoryInformation,
		// Token: 0x0400082F RID: 2095
		SystemLoadGdiDriverInformation,
		// Token: 0x04000830 RID: 2096
		SystemUnloadGdiDriverInformation,
		// Token: 0x04000831 RID: 2097
		SystemTimeAdjustmentInformation,
		// Token: 0x04000832 RID: 2098
		SystemSummaryMemoryInformation,
		// Token: 0x04000833 RID: 2099
		SystemMirrorMemoryInformation,
		// Token: 0x04000834 RID: 2100
		SystemPerformanceTraceInformation,
		// Token: 0x04000835 RID: 2101
		SystemObsolete0,
		// Token: 0x04000836 RID: 2102
		SystemExceptionInformation,
		// Token: 0x04000837 RID: 2103
		SystemCrashDumpStateInformation,
		// Token: 0x04000838 RID: 2104
		SystemKernelDebuggerInformation,
		// Token: 0x04000839 RID: 2105
		SystemContextSwitchInformation,
		// Token: 0x0400083A RID: 2106
		SystemRegistryQuotaInformation,
		// Token: 0x0400083B RID: 2107
		SystemExtendServiceTableInformation,
		// Token: 0x0400083C RID: 2108
		SystemPrioritySeperation,
		// Token: 0x0400083D RID: 2109
		SystemVerifierAddDriverInformation,
		// Token: 0x0400083E RID: 2110
		SystemVerifierRemoveDriverInformation,
		// Token: 0x0400083F RID: 2111
		SystemProcessorIdleInformation,
		// Token: 0x04000840 RID: 2112
		SystemLegacyDriverInformation,
		// Token: 0x04000841 RID: 2113
		SystemCurrentTimeZoneInformation,
		// Token: 0x04000842 RID: 2114
		SystemLookasideInformation,
		// Token: 0x04000843 RID: 2115
		SystemTimeSlipNotification,
		// Token: 0x04000844 RID: 2116
		SystemSessionCreate,
		// Token: 0x04000845 RID: 2117
		SystemSessionDetach,
		// Token: 0x04000846 RID: 2118
		SystemSessionInformation,
		// Token: 0x04000847 RID: 2119
		SystemRangeStartInformation,
		// Token: 0x04000848 RID: 2120
		SystemVerifierInformation,
		// Token: 0x04000849 RID: 2121
		SystemVerifierThunkExtend,
		// Token: 0x0400084A RID: 2122
		SystemSessionProcessInformation,
		// Token: 0x0400084B RID: 2123
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x0400084C RID: 2124
		SystemNumaProcessorMap,
		// Token: 0x0400084D RID: 2125
		SystemPrefetcherInformation,
		// Token: 0x0400084E RID: 2126
		SystemExtendedProcessInformation,
		// Token: 0x0400084F RID: 2127
		SystemRecommendedSharedDataAlignment,
		// Token: 0x04000850 RID: 2128
		SystemComPlusPackage,
		// Token: 0x04000851 RID: 2129
		SystemNumaAvailableMemory,
		// Token: 0x04000852 RID: 2130
		SystemProcessorPowerInformation,
		// Token: 0x04000853 RID: 2131
		SystemEmulationBasicInformation,
		// Token: 0x04000854 RID: 2132
		SystemEmulationProcessorInformation,
		// Token: 0x04000855 RID: 2133
		SystemExtendedHandleInformation,
		// Token: 0x04000856 RID: 2134
		SystemLostDelayedWriteInformation,
		// Token: 0x04000857 RID: 2135
		SystemBigPoolInformation,
		// Token: 0x04000858 RID: 2136
		SystemSessionPoolTagInformation,
		// Token: 0x04000859 RID: 2137
		SystemSessionMappedViewInformation,
		// Token: 0x0400085A RID: 2138
		SystemHotpatchInformation,
		// Token: 0x0400085B RID: 2139
		SystemObjectSecurityMode,
		// Token: 0x0400085C RID: 2140
		SystemWatchdogTimerHandler,
		// Token: 0x0400085D RID: 2141
		SystemWatchdogTimerInformation,
		// Token: 0x0400085E RID: 2142
		SystemLogicalProcessorInformation,
		// Token: 0x0400085F RID: 2143
		SystemWow64SharedInformationObsolete,
		// Token: 0x04000860 RID: 2144
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x04000861 RID: 2145
		SystemFirmwareTableInformation,
		// Token: 0x04000862 RID: 2146
		SystemModuleInformationEx,
		// Token: 0x04000863 RID: 2147
		SystemVerifierTriageInformation,
		// Token: 0x04000864 RID: 2148
		SystemSuperfetchInformation,
		// Token: 0x04000865 RID: 2149
		SystemMemoryListInformation,
		// Token: 0x04000866 RID: 2150
		SystemFileCacheInformationEx,
		// Token: 0x04000867 RID: 2151
		SystemThreadPriorityClientIdInformation,
		// Token: 0x04000868 RID: 2152
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x04000869 RID: 2153
		SystemVerifierCancellationInformation,
		// Token: 0x0400086A RID: 2154
		SystemProcessorPowerInformationEx,
		// Token: 0x0400086B RID: 2155
		SystemRefTraceInformation,
		// Token: 0x0400086C RID: 2156
		SystemSpecialPoolInformation,
		// Token: 0x0400086D RID: 2157
		SystemProcessIdInformation,
		// Token: 0x0400086E RID: 2158
		SystemErrorPortInformation,
		// Token: 0x0400086F RID: 2159
		SystemBootEnvironmentInformation,
		// Token: 0x04000870 RID: 2160
		SystemHypervisorInformation,
		// Token: 0x04000871 RID: 2161
		SystemVerifierInformationEx,
		// Token: 0x04000872 RID: 2162
		SystemTimeZoneInformation,
		// Token: 0x04000873 RID: 2163
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x04000874 RID: 2164
		SystemCoverageInformation,
		// Token: 0x04000875 RID: 2165
		SystemPrefetchPatchInformation,
		// Token: 0x04000876 RID: 2166
		SystemVerifierFaultsInformation,
		// Token: 0x04000877 RID: 2167
		SystemSystemPartitionInformation,
		// Token: 0x04000878 RID: 2168
		SystemSystemDiskInformation,
		// Token: 0x04000879 RID: 2169
		SystemProcessorPerformanceDistribution,
		// Token: 0x0400087A RID: 2170
		SystemNumaProximityNodeInformation,
		// Token: 0x0400087B RID: 2171
		SystemDynamicTimeZoneInformation,
		// Token: 0x0400087C RID: 2172
		SystemCodeIntegrityInformation,
		// Token: 0x0400087D RID: 2173
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x0400087E RID: 2174
		SystemProcessorBrandString,
		// Token: 0x0400087F RID: 2175
		SystemVirtualAddressInformation,
		// Token: 0x04000880 RID: 2176
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x04000881 RID: 2177
		SystemProcessorCycleTimeInformation,
		// Token: 0x04000882 RID: 2178
		SystemStoreInformation,
		// Token: 0x04000883 RID: 2179
		SystemRegistryAppendString,
		// Token: 0x04000884 RID: 2180
		SystemAitSamplingValue,
		// Token: 0x04000885 RID: 2181
		SystemVhdBootInformation,
		// Token: 0x04000886 RID: 2182
		SystemCpuQuotaInformation,
		// Token: 0x04000887 RID: 2183
		SystemNativeBasicInformation,
		// Token: 0x04000888 RID: 2184
		SystemSpare1,
		// Token: 0x04000889 RID: 2185
		SystemLowPriorityIoInformation,
		// Token: 0x0400088A RID: 2186
		SystemTpmBootEntropyInformation,
		// Token: 0x0400088B RID: 2187
		SystemVerifierCountersInformation,
		// Token: 0x0400088C RID: 2188
		SystemPagedPoolInformationEx,
		// Token: 0x0400088D RID: 2189
		SystemSystemPtesInformationEx,
		// Token: 0x0400088E RID: 2190
		SystemNodeDistanceInformation,
		// Token: 0x0400088F RID: 2191
		SystemAcpiAuditInformation,
		// Token: 0x04000890 RID: 2192
		SystemBasicPerformanceInformation,
		// Token: 0x04000891 RID: 2193
		SystemQueryPerformanceCounterInformation,
		// Token: 0x04000892 RID: 2194
		SystemSessionBigPoolInformation,
		// Token: 0x04000893 RID: 2195
		SystemBootGraphicsInformation,
		// Token: 0x04000894 RID: 2196
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x04000895 RID: 2197
		SystemBadPageInformation,
		// Token: 0x04000896 RID: 2198
		SystemProcessorProfileControlArea,
		// Token: 0x04000897 RID: 2199
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x04000898 RID: 2200
		SystemEntropyInterruptTimingCallback,
		// Token: 0x04000899 RID: 2201
		SystemConsoleInformation,
		// Token: 0x0400089A RID: 2202
		SystemPlatformBinaryInformation,
		// Token: 0x0400089B RID: 2203
		SystemThrottleNotificationInformation,
		// Token: 0x0400089C RID: 2204
		SystemHypervisorProcessorCountInformation,
		// Token: 0x0400089D RID: 2205
		SystemDeviceDataInformation,
		// Token: 0x0400089E RID: 2206
		SystemDeviceDataEnumerationInformation,
		// Token: 0x0400089F RID: 2207
		SystemMemoryTopologyInformation,
		// Token: 0x040008A0 RID: 2208
		SystemMemoryChannelInformation,
		// Token: 0x040008A1 RID: 2209
		SystemBootLogoInformation,
		// Token: 0x040008A2 RID: 2210
		SystemProcessorPerformanceInformationEx,
		// Token: 0x040008A3 RID: 2211
		SystemSpare0,
		// Token: 0x040008A4 RID: 2212
		SystemSecureBootPolicyInformation,
		// Token: 0x040008A5 RID: 2213
		SystemPageFileInformationEx,
		// Token: 0x040008A6 RID: 2214
		SystemSecureBootInformation,
		// Token: 0x040008A7 RID: 2215
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x040008A8 RID: 2216
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x040008A9 RID: 2217
		SystemFullProcessInformation,
		// Token: 0x040008AA RID: 2218
		SystemKernelDebuggerInformationEx,
		// Token: 0x040008AB RID: 2219
		SystemBootMetadataInformation,
		// Token: 0x040008AC RID: 2220
		SystemSoftRebootInformation,
		// Token: 0x040008AD RID: 2221
		SystemElamCertificateInformation,
		// Token: 0x040008AE RID: 2222
		SystemOfflineDumpConfigInformation,
		// Token: 0x040008AF RID: 2223
		SystemProcessorFeaturesInformation,
		// Token: 0x040008B0 RID: 2224
		SystemRegistryReconciliationInformation,
		// Token: 0x040008B1 RID: 2225
		SystemEdidInformation,
		// Token: 0x040008B2 RID: 2226
		MaxSystemInfoClass
	}
}
