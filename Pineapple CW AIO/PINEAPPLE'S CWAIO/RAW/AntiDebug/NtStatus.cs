using System;

namespace RAW.AntiDebug
{
	// Token: 0x020000C2 RID: 194
	public enum NtStatus : uint
	{
		// Token: 0x04000687 RID: 1671
		Success,
		// Token: 0x04000688 RID: 1672
		Wait0 = 0U,
		// Token: 0x04000689 RID: 1673
		Wait1,
		// Token: 0x0400068A RID: 1674
		Wait2,
		// Token: 0x0400068B RID: 1675
		Wait3,
		// Token: 0x0400068C RID: 1676
		Wait63 = 63U,
		// Token: 0x0400068D RID: 1677
		Abandoned = 128U,
		// Token: 0x0400068E RID: 1678
		AbandonedWait0 = 128U,
		// Token: 0x0400068F RID: 1679
		AbandonedWait1,
		// Token: 0x04000690 RID: 1680
		AbandonedWait2,
		// Token: 0x04000691 RID: 1681
		AbandonedWait3,
		// Token: 0x04000692 RID: 1682
		AbandonedWait63 = 191U,
		// Token: 0x04000693 RID: 1683
		UserApc,
		// Token: 0x04000694 RID: 1684
		KernelApc = 256U,
		// Token: 0x04000695 RID: 1685
		Alerted,
		// Token: 0x04000696 RID: 1686
		Timeout,
		// Token: 0x04000697 RID: 1687
		Pending,
		// Token: 0x04000698 RID: 1688
		Reparse,
		// Token: 0x04000699 RID: 1689
		MoreEntries,
		// Token: 0x0400069A RID: 1690
		NotAllAssigned,
		// Token: 0x0400069B RID: 1691
		SomeNotMapped,
		// Token: 0x0400069C RID: 1692
		OpLockBreakInProgress,
		// Token: 0x0400069D RID: 1693
		VolumeMounted,
		// Token: 0x0400069E RID: 1694
		RxActCommitted,
		// Token: 0x0400069F RID: 1695
		NotifyCleanup,
		// Token: 0x040006A0 RID: 1696
		NotifyEnumDir,
		// Token: 0x040006A1 RID: 1697
		NoQuotasForAccount,
		// Token: 0x040006A2 RID: 1698
		PrimaryTransportConnectFailed,
		// Token: 0x040006A3 RID: 1699
		PageFaultTransition = 272U,
		// Token: 0x040006A4 RID: 1700
		PageFaultDemandZero,
		// Token: 0x040006A5 RID: 1701
		PageFaultCopyOnWrite,
		// Token: 0x040006A6 RID: 1702
		PageFaultGuardPage,
		// Token: 0x040006A7 RID: 1703
		PageFaultPagingFile,
		// Token: 0x040006A8 RID: 1704
		CrashDump = 278U,
		// Token: 0x040006A9 RID: 1705
		ReparseObject = 280U,
		// Token: 0x040006AA RID: 1706
		NothingToTerminate = 290U,
		// Token: 0x040006AB RID: 1707
		ProcessNotInJob,
		// Token: 0x040006AC RID: 1708
		ProcessInJob,
		// Token: 0x040006AD RID: 1709
		ProcessCloned = 297U,
		// Token: 0x040006AE RID: 1710
		FileLockedWithOnlyReaders,
		// Token: 0x040006AF RID: 1711
		FileLockedWithWriters,
		// Token: 0x040006B0 RID: 1712
		Informational = 1073741824U,
		// Token: 0x040006B1 RID: 1713
		ObjectNameExists = 1073741824U,
		// Token: 0x040006B2 RID: 1714
		ThreadWasSuspended,
		// Token: 0x040006B3 RID: 1715
		WorkingSetLimitRange,
		// Token: 0x040006B4 RID: 1716
		ImageNotAtBase,
		// Token: 0x040006B5 RID: 1717
		RegistryRecovered = 1073741833U,
		// Token: 0x040006B6 RID: 1718
		Warning = 2147483648U,
		// Token: 0x040006B7 RID: 1719
		GuardPageViolation,
		// Token: 0x040006B8 RID: 1720
		DatatypeMisalignment,
		// Token: 0x040006B9 RID: 1721
		Breakpoint,
		// Token: 0x040006BA RID: 1722
		SingleStep,
		// Token: 0x040006BB RID: 1723
		BufferOverflow,
		// Token: 0x040006BC RID: 1724
		NoMoreFiles,
		// Token: 0x040006BD RID: 1725
		HandlesClosed = 2147483658U,
		// Token: 0x040006BE RID: 1726
		PartialCopy = 2147483661U,
		// Token: 0x040006BF RID: 1727
		DeviceBusy = 2147483665U,
		// Token: 0x040006C0 RID: 1728
		InvalidEaName = 2147483667U,
		// Token: 0x040006C1 RID: 1729
		EaListInconsistent,
		// Token: 0x040006C2 RID: 1730
		NoMoreEntries = 2147483674U,
		// Token: 0x040006C3 RID: 1731
		LongJump = 2147483686U,
		// Token: 0x040006C4 RID: 1732
		DllMightBeInsecure = 2147483691U,
		// Token: 0x040006C5 RID: 1733
		Error = 3221225472U,
		// Token: 0x040006C6 RID: 1734
		Unsuccessful,
		// Token: 0x040006C7 RID: 1735
		NotImplemented,
		// Token: 0x040006C8 RID: 1736
		InvalidInfoClass,
		// Token: 0x040006C9 RID: 1737
		InfoLengthMismatch,
		// Token: 0x040006CA RID: 1738
		AccessViolation,
		// Token: 0x040006CB RID: 1739
		InPageError,
		// Token: 0x040006CC RID: 1740
		PagefileQuota,
		// Token: 0x040006CD RID: 1741
		InvalidHandle,
		// Token: 0x040006CE RID: 1742
		BadInitialStack,
		// Token: 0x040006CF RID: 1743
		BadInitialPc,
		// Token: 0x040006D0 RID: 1744
		InvalidCid,
		// Token: 0x040006D1 RID: 1745
		TimerNotCanceled,
		// Token: 0x040006D2 RID: 1746
		InvalidParameter,
		// Token: 0x040006D3 RID: 1747
		NoSuchDevice,
		// Token: 0x040006D4 RID: 1748
		NoSuchFile,
		// Token: 0x040006D5 RID: 1749
		InvalidDeviceRequest,
		// Token: 0x040006D6 RID: 1750
		EndOfFile,
		// Token: 0x040006D7 RID: 1751
		WrongVolume,
		// Token: 0x040006D8 RID: 1752
		NoMediaInDevice,
		// Token: 0x040006D9 RID: 1753
		NoMemory = 3221225495U,
		// Token: 0x040006DA RID: 1754
		NotMappedView = 3221225497U,
		// Token: 0x040006DB RID: 1755
		UnableToFreeVm,
		// Token: 0x040006DC RID: 1756
		UnableToDeleteSection,
		// Token: 0x040006DD RID: 1757
		IllegalInstruction = 3221225501U,
		// Token: 0x040006DE RID: 1758
		AlreadyCommitted = 3221225505U,
		// Token: 0x040006DF RID: 1759
		AccessDenied,
		// Token: 0x040006E0 RID: 1760
		BufferTooSmall,
		// Token: 0x040006E1 RID: 1761
		ObjectTypeMismatch,
		// Token: 0x040006E2 RID: 1762
		NonContinuableException,
		// Token: 0x040006E3 RID: 1763
		BadStack = 3221225512U,
		// Token: 0x040006E4 RID: 1764
		NotLocked = 3221225514U,
		// Token: 0x040006E5 RID: 1765
		NotCommitted = 3221225517U,
		// Token: 0x040006E6 RID: 1766
		InvalidParameterMix = 3221225520U,
		// Token: 0x040006E7 RID: 1767
		ObjectNameInvalid = 3221225523U,
		// Token: 0x040006E8 RID: 1768
		ObjectNameNotFound,
		// Token: 0x040006E9 RID: 1769
		ObjectNameCollision,
		// Token: 0x040006EA RID: 1770
		ObjectPathInvalid = 3221225529U,
		// Token: 0x040006EB RID: 1771
		ObjectPathNotFound,
		// Token: 0x040006EC RID: 1772
		ObjectPathSyntaxBad,
		// Token: 0x040006ED RID: 1773
		DataOverrun,
		// Token: 0x040006EE RID: 1774
		DataLate,
		// Token: 0x040006EF RID: 1775
		DataError,
		// Token: 0x040006F0 RID: 1776
		CrcError,
		// Token: 0x040006F1 RID: 1777
		SectionTooBig,
		// Token: 0x040006F2 RID: 1778
		PortConnectionRefused,
		// Token: 0x040006F3 RID: 1779
		InvalidPortHandle,
		// Token: 0x040006F4 RID: 1780
		SharingViolation,
		// Token: 0x040006F5 RID: 1781
		QuotaExceeded,
		// Token: 0x040006F6 RID: 1782
		InvalidPageProtection,
		// Token: 0x040006F7 RID: 1783
		MutantNotOwned,
		// Token: 0x040006F8 RID: 1784
		SemaphoreLimitExceeded,
		// Token: 0x040006F9 RID: 1785
		PortAlreadySet,
		// Token: 0x040006FA RID: 1786
		SectionNotImage,
		// Token: 0x040006FB RID: 1787
		SuspendCountExceeded,
		// Token: 0x040006FC RID: 1788
		ThreadIsTerminating,
		// Token: 0x040006FD RID: 1789
		BadWorkingSetLimit,
		// Token: 0x040006FE RID: 1790
		IncompatibleFileMap,
		// Token: 0x040006FF RID: 1791
		SectionProtection,
		// Token: 0x04000700 RID: 1792
		EasNotSupported,
		// Token: 0x04000701 RID: 1793
		EaTooLarge,
		// Token: 0x04000702 RID: 1794
		NonExistentEaEntry,
		// Token: 0x04000703 RID: 1795
		NoEasOnFile,
		// Token: 0x04000704 RID: 1796
		EaCorruptError,
		// Token: 0x04000705 RID: 1797
		FileLockConflict,
		// Token: 0x04000706 RID: 1798
		LockNotGranted,
		// Token: 0x04000707 RID: 1799
		DeletePending,
		// Token: 0x04000708 RID: 1800
		CtlFileNotSupported,
		// Token: 0x04000709 RID: 1801
		UnknownRevision,
		// Token: 0x0400070A RID: 1802
		RevisionMismatch,
		// Token: 0x0400070B RID: 1803
		InvalidOwner,
		// Token: 0x0400070C RID: 1804
		InvalidPrimaryGroup,
		// Token: 0x0400070D RID: 1805
		NoImpersonationToken,
		// Token: 0x0400070E RID: 1806
		CantDisableMandatory,
		// Token: 0x0400070F RID: 1807
		NoLogonServers,
		// Token: 0x04000710 RID: 1808
		NoSuchLogonSession,
		// Token: 0x04000711 RID: 1809
		NoSuchPrivilege,
		// Token: 0x04000712 RID: 1810
		PrivilegeNotHeld,
		// Token: 0x04000713 RID: 1811
		InvalidAccountName,
		// Token: 0x04000714 RID: 1812
		UserExists,
		// Token: 0x04000715 RID: 1813
		NoSuchUser,
		// Token: 0x04000716 RID: 1814
		GroupExists,
		// Token: 0x04000717 RID: 1815
		NoSuchGroup,
		// Token: 0x04000718 RID: 1816
		MemberInGroup,
		// Token: 0x04000719 RID: 1817
		MemberNotInGroup,
		// Token: 0x0400071A RID: 1818
		LastAdmin,
		// Token: 0x0400071B RID: 1819
		WrongPassword,
		// Token: 0x0400071C RID: 1820
		IllFormedPassword,
		// Token: 0x0400071D RID: 1821
		PasswordRestriction,
		// Token: 0x0400071E RID: 1822
		LogonFailure,
		// Token: 0x0400071F RID: 1823
		AccountRestriction,
		// Token: 0x04000720 RID: 1824
		InvalidLogonHours,
		// Token: 0x04000721 RID: 1825
		InvalidWorkstation,
		// Token: 0x04000722 RID: 1826
		PasswordExpired,
		// Token: 0x04000723 RID: 1827
		AccountDisabled,
		// Token: 0x04000724 RID: 1828
		NoneMapped,
		// Token: 0x04000725 RID: 1829
		TooManyLuidsRequested,
		// Token: 0x04000726 RID: 1830
		LuidsExhausted,
		// Token: 0x04000727 RID: 1831
		InvalidSubAuthority,
		// Token: 0x04000728 RID: 1832
		InvalidAcl,
		// Token: 0x04000729 RID: 1833
		InvalidSid,
		// Token: 0x0400072A RID: 1834
		InvalidSecurityDescr,
		// Token: 0x0400072B RID: 1835
		ProcedureNotFound,
		// Token: 0x0400072C RID: 1836
		InvalidImageFormat,
		// Token: 0x0400072D RID: 1837
		NoToken,
		// Token: 0x0400072E RID: 1838
		BadInheritanceAcl,
		// Token: 0x0400072F RID: 1839
		RangeNotLocked,
		// Token: 0x04000730 RID: 1840
		DiskFull,
		// Token: 0x04000731 RID: 1841
		ServerDisabled,
		// Token: 0x04000732 RID: 1842
		ServerNotDisabled,
		// Token: 0x04000733 RID: 1843
		TooManyGuidsRequested,
		// Token: 0x04000734 RID: 1844
		GuidsExhausted,
		// Token: 0x04000735 RID: 1845
		InvalidIdAuthority,
		// Token: 0x04000736 RID: 1846
		AgentsExhausted,
		// Token: 0x04000737 RID: 1847
		InvalidVolumeLabel,
		// Token: 0x04000738 RID: 1848
		SectionNotExtended,
		// Token: 0x04000739 RID: 1849
		NotMappedData,
		// Token: 0x0400073A RID: 1850
		ResourceDataNotFound,
		// Token: 0x0400073B RID: 1851
		ResourceTypeNotFound,
		// Token: 0x0400073C RID: 1852
		ResourceNameNotFound,
		// Token: 0x0400073D RID: 1853
		ArrayBoundsExceeded,
		// Token: 0x0400073E RID: 1854
		FloatDenormalOperand,
		// Token: 0x0400073F RID: 1855
		FloatDivideByZero,
		// Token: 0x04000740 RID: 1856
		FloatInexactResult,
		// Token: 0x04000741 RID: 1857
		FloatInvalidOperation,
		// Token: 0x04000742 RID: 1858
		FloatOverflow,
		// Token: 0x04000743 RID: 1859
		FloatStackCheck,
		// Token: 0x04000744 RID: 1860
		FloatUnderflow,
		// Token: 0x04000745 RID: 1861
		IntegerDivideByZero,
		// Token: 0x04000746 RID: 1862
		IntegerOverflow,
		// Token: 0x04000747 RID: 1863
		PrivilegedInstruction,
		// Token: 0x04000748 RID: 1864
		TooManyPagingFiles,
		// Token: 0x04000749 RID: 1865
		FileInvalid,
		// Token: 0x0400074A RID: 1866
		InstanceNotAvailable = 3221225643U,
		// Token: 0x0400074B RID: 1867
		PipeNotAvailable,
		// Token: 0x0400074C RID: 1868
		InvalidPipeState,
		// Token: 0x0400074D RID: 1869
		PipeBusy,
		// Token: 0x0400074E RID: 1870
		IllegalFunction,
		// Token: 0x0400074F RID: 1871
		PipeDisconnected,
		// Token: 0x04000750 RID: 1872
		PipeClosing,
		// Token: 0x04000751 RID: 1873
		PipeConnected,
		// Token: 0x04000752 RID: 1874
		PipeListening,
		// Token: 0x04000753 RID: 1875
		InvalidReadMode,
		// Token: 0x04000754 RID: 1876
		IoTimeout,
		// Token: 0x04000755 RID: 1877
		FileForcedClosed,
		// Token: 0x04000756 RID: 1878
		ProfilingNotStarted,
		// Token: 0x04000757 RID: 1879
		ProfilingNotStopped,
		// Token: 0x04000758 RID: 1880
		NotSameDevice = 3221225684U,
		// Token: 0x04000759 RID: 1881
		FileRenamed,
		// Token: 0x0400075A RID: 1882
		CantWait = 3221225688U,
		// Token: 0x0400075B RID: 1883
		PipeEmpty,
		// Token: 0x0400075C RID: 1884
		CantTerminateSelf = 3221225691U,
		// Token: 0x0400075D RID: 1885
		InternalError = 3221225701U,
		// Token: 0x0400075E RID: 1886
		InvalidParameter1 = 3221225711U,
		// Token: 0x0400075F RID: 1887
		InvalidParameter2,
		// Token: 0x04000760 RID: 1888
		InvalidParameter3,
		// Token: 0x04000761 RID: 1889
		InvalidParameter4,
		// Token: 0x04000762 RID: 1890
		InvalidParameter5,
		// Token: 0x04000763 RID: 1891
		InvalidParameter6,
		// Token: 0x04000764 RID: 1892
		InvalidParameter7,
		// Token: 0x04000765 RID: 1893
		InvalidParameter8,
		// Token: 0x04000766 RID: 1894
		InvalidParameter9,
		// Token: 0x04000767 RID: 1895
		InvalidParameter10,
		// Token: 0x04000768 RID: 1896
		InvalidParameter11,
		// Token: 0x04000769 RID: 1897
		InvalidParameter12,
		// Token: 0x0400076A RID: 1898
		MappedFileSizeZero = 3221225758U,
		// Token: 0x0400076B RID: 1899
		TooManyOpenedFiles,
		// Token: 0x0400076C RID: 1900
		Cancelled,
		// Token: 0x0400076D RID: 1901
		CannotDelete,
		// Token: 0x0400076E RID: 1902
		InvalidComputerName,
		// Token: 0x0400076F RID: 1903
		FileDeleted,
		// Token: 0x04000770 RID: 1904
		SpecialAccount,
		// Token: 0x04000771 RID: 1905
		SpecialGroup,
		// Token: 0x04000772 RID: 1906
		SpecialUser,
		// Token: 0x04000773 RID: 1907
		MembersPrimaryGroup,
		// Token: 0x04000774 RID: 1908
		FileClosed,
		// Token: 0x04000775 RID: 1909
		TooManyThreads,
		// Token: 0x04000776 RID: 1910
		ThreadNotInProcess,
		// Token: 0x04000777 RID: 1911
		TokenAlreadyInUse,
		// Token: 0x04000778 RID: 1912
		PagefileQuotaExceeded,
		// Token: 0x04000779 RID: 1913
		CommitmentLimit,
		// Token: 0x0400077A RID: 1914
		InvalidImageLeFormat,
		// Token: 0x0400077B RID: 1915
		InvalidImageNotMz,
		// Token: 0x0400077C RID: 1916
		InvalidImageProtect,
		// Token: 0x0400077D RID: 1917
		InvalidImageWin16,
		// Token: 0x0400077E RID: 1918
		LogonServer,
		// Token: 0x0400077F RID: 1919
		DifferenceAtDc,
		// Token: 0x04000780 RID: 1920
		SynchronizationRequired,
		// Token: 0x04000781 RID: 1921
		DllNotFound,
		// Token: 0x04000782 RID: 1922
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000783 RID: 1923
		OrdinalNotFound,
		// Token: 0x04000784 RID: 1924
		EntryPointNotFound,
		// Token: 0x04000785 RID: 1925
		ControlCExit,
		// Token: 0x04000786 RID: 1926
		PortNotSet = 3221226323U,
		// Token: 0x04000787 RID: 1927
		DebuggerInactive,
		// Token: 0x04000788 RID: 1928
		CallbackBypass = 3221226755U,
		// Token: 0x04000789 RID: 1929
		PortClosed = 3221227264U,
		// Token: 0x0400078A RID: 1930
		MessageLost,
		// Token: 0x0400078B RID: 1931
		InvalidMessage,
		// Token: 0x0400078C RID: 1932
		RequestCanceled,
		// Token: 0x0400078D RID: 1933
		RecursiveDispatch,
		// Token: 0x0400078E RID: 1934
		LpcReceiveBufferExpected,
		// Token: 0x0400078F RID: 1935
		LpcInvalidConnectionUsage,
		// Token: 0x04000790 RID: 1936
		LpcRequestsNotAllowed,
		// Token: 0x04000791 RID: 1937
		ResourceInUse,
		// Token: 0x04000792 RID: 1938
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000793 RID: 1939
		VolumeDirty = 3221227526U,
		// Token: 0x04000794 RID: 1940
		FileCheckedOut = 3221227777U,
		// Token: 0x04000795 RID: 1941
		CheckOutRequired,
		// Token: 0x04000796 RID: 1942
		BadFileType,
		// Token: 0x04000797 RID: 1943
		FileTooLarge,
		// Token: 0x04000798 RID: 1944
		FormsAuthRequired,
		// Token: 0x04000799 RID: 1945
		VirusInfected,
		// Token: 0x0400079A RID: 1946
		VirusDeleted,
		// Token: 0x0400079B RID: 1947
		TransactionalConflict = 3222863873U,
		// Token: 0x0400079C RID: 1948
		InvalidTransaction,
		// Token: 0x0400079D RID: 1949
		TransactionNotActive,
		// Token: 0x0400079E RID: 1950
		TmInitializationFailed,
		// Token: 0x0400079F RID: 1951
		RmNotActive,
		// Token: 0x040007A0 RID: 1952
		RmMetadataCorrupt,
		// Token: 0x040007A1 RID: 1953
		TransactionNotJoined,
		// Token: 0x040007A2 RID: 1954
		DirectoryNotRm,
		// Token: 0x040007A3 RID: 1955
		CouldNotResizeLog,
		// Token: 0x040007A4 RID: 1956
		TransactionsUnsupportedRemote,
		// Token: 0x040007A5 RID: 1957
		LogResizeInvalidSize,
		// Token: 0x040007A6 RID: 1958
		RemoteFileVersionMismatch,
		// Token: 0x040007A7 RID: 1959
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x040007A8 RID: 1960
		TransactionPropagationFailed,
		// Token: 0x040007A9 RID: 1961
		CrmProtocolNotFound,
		// Token: 0x040007AA RID: 1962
		TransactionSuperiorExists,
		// Token: 0x040007AB RID: 1963
		TransactionRequestNotValid,
		// Token: 0x040007AC RID: 1964
		TransactionNotRequested,
		// Token: 0x040007AD RID: 1965
		TransactionAlreadyAborted,
		// Token: 0x040007AE RID: 1966
		TransactionAlreadyCommitted,
		// Token: 0x040007AF RID: 1967
		TransactionInvalidMarshallBuffer,
		// Token: 0x040007B0 RID: 1968
		CurrentTransactionNotValid,
		// Token: 0x040007B1 RID: 1969
		LogGrowthFailed,
		// Token: 0x040007B2 RID: 1970
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x040007B3 RID: 1971
		StreamMiniversionNotFound,
		// Token: 0x040007B4 RID: 1972
		StreamMiniversionNotValid,
		// Token: 0x040007B5 RID: 1973
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x040007B6 RID: 1974
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x040007B7 RID: 1975
		CantCreateMoreStreamMiniversions,
		// Token: 0x040007B8 RID: 1976
		HandleNoLongerValid = 3222863912U,
		// Token: 0x040007B9 RID: 1977
		NoTxfMetadata,
		// Token: 0x040007BA RID: 1978
		LogCorruptionDetected = 3222863920U,
		// Token: 0x040007BB RID: 1979
		CantRecoverWithHandleOpen,
		// Token: 0x040007BC RID: 1980
		RmDisconnected,
		// Token: 0x040007BD RID: 1981
		EnlistmentNotSuperior,
		// Token: 0x040007BE RID: 1982
		RecoveryNotNeeded,
		// Token: 0x040007BF RID: 1983
		RmAlreadyStarted,
		// Token: 0x040007C0 RID: 1984
		FileIdentityNotPersistent,
		// Token: 0x040007C1 RID: 1985
		CantBreakTransactionalDependency,
		// Token: 0x040007C2 RID: 1986
		CantCrossRmBoundary,
		// Token: 0x040007C3 RID: 1987
		TxfDirNotEmpty,
		// Token: 0x040007C4 RID: 1988
		IndoubtTransactionsExist,
		// Token: 0x040007C5 RID: 1989
		TmVolatile,
		// Token: 0x040007C6 RID: 1990
		RollbackTimerExpired,
		// Token: 0x040007C7 RID: 1991
		TxfAttributeCorrupt,
		// Token: 0x040007C8 RID: 1992
		EfsNotAllowedInTransaction,
		// Token: 0x040007C9 RID: 1993
		TransactionalOpenNotAllowed,
		// Token: 0x040007CA RID: 1994
		TransactedMappingUnsupportedRemote,
		// Token: 0x040007CB RID: 1995
		TxfMetadataAlreadyPresent,
		// Token: 0x040007CC RID: 1996
		TransactionScopeCallbacksNotSet,
		// Token: 0x040007CD RID: 1997
		TransactionRequiredPromotion,
		// Token: 0x040007CE RID: 1998
		CannotExecuteFileInTransaction,
		// Token: 0x040007CF RID: 1999
		TransactionsNotFrozen,
		// Token: 0x040007D0 RID: 2000
		MaximumNtStatus = 4294967295U
	}
}
