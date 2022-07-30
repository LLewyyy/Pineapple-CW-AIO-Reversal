using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32.SafeHandles;

namespace yktv
{
	// Token: 0x02000093 RID: 147
	public class Memory
	{
		// Token: 0x060002FE RID: 766
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

		// Token: 0x060002FF RID: 767
		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr hProcess, ulong lpBaseAddress, [In] [Out] byte[] lpBuffer, ulong dwSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000300 RID: 768
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(uint dwAccess, bool inherit, int pid);

		// Token: 0x06000301 RID: 769 RVA: 0x00021CF0 File Offset: 0x00021CF0
		public void WriteMemory(ulong MemoryAddress, byte[] Buffer)
		{
			uint num;
			Memory.VirtualProtectEx(this.ProcessHandle, (IntPtr)((long)MemoryAddress), (uint)Buffer.Length, 4U, out num);
			IntPtr intPtr;
			Memory.WriteProcessMemory(this.ProcessHandle, MemoryAddress, Buffer, (ulong)((long)Buffer.Length), out intPtr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00021D2C File Offset: 0x00021D2C
		[return: Dynamic]
		public dynamic IsProcessRunning(string processName)
		{
			if (this.yes)
			{
				return true;
			}
			if (Encryption.check)
			{
				try
				{
					Process process = Process.GetProcessesByName(processName)[0];
					if (process.Handle.ToInt64() != 0L)
					{
						this.BaseAddress = process.MainModule.BaseAddress.ToInt64();
						this.ProcessID = process.Id;
						this.ProcessName = processName;
						this.ProcessHandle = Memory.OpenProcess(56U, false, this.ProcessID);
						this.yes = true;
						return true;
					}
				}
				catch (Exception)
				{
					this.BaseAddress = 0L;
					this.ProcessID = 0;
					this.ProcessHandle = IntPtr.Zero;
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000303 RID: 771
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr VirtualAlloc(IntPtr baseAddress, uint size, Memory.MemoryAllocationFlags allocationType, Memory.MemoryProtectionFlags protection);

		// Token: 0x06000304 RID: 772
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

		// Token: 0x06000305 RID: 773
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, long lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

		// Token: 0x06000306 RID: 774 RVA: 0x00021E04 File Offset: 0x00021E04
		public bool IsOpen()
		{
			if (Memory.<>o__13.<>p__1 == null)
			{
				Memory.<>o__13.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Memory)));
			}
			Func<CallSite, object, bool> target = Memory.<>o__13.<>p__1.Target;
			CallSite <>p__ = Memory.<>o__13.<>p__1;
			bool flag = !(this.ProcessName == string.Empty);
			object arg;
			if (flag)
			{
				if (Memory.<>o__13.<>p__0 == null)
				{
					Memory.<>o__13.<>p__0 = CallSite<Func<CallSite, bool, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(Memory), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg = Memory.<>o__13.<>p__0.Target(Memory.<>o__13.<>p__0, flag, this.IsProcessRunning(this.ProcessName));
			}
			else
			{
				arg = flag;
			}
			return target(<>p__, arg);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00021ECC File Offset: 0x00021ECC
		public void sysWriteint(long pAddress, int value)
		{
			byte[] array = new byte[]
			{
				76,
				139,
				209,
				184,
				0,
				0,
				0,
				0,
				15,
				5,
				195
			};
			Buffer.BlockCopy(BitConverter.GetBytes(58), 0, array, 4, 4);
			IntPtr intPtr = Memory.VirtualAlloc(IntPtr.Zero, (uint)array.Length, Memory.MemoryAllocationFlags.Commit | Memory.MemoryAllocationFlags.Reserve, Memory.MemoryProtectionFlags.ExecuteReadWrite);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Marshal.GetDelegateForFunctionPointer(intPtr, typeof(Memory.NtWriteVirtualMemory)).DynamicInvoke(new object[]
			{
				this.ProcessHandle,
				pAddress,
				BitConverter.GetBytes(value),
				4U,
				IntPtr.Zero
			});
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00021F70 File Offset: 0x00021F70
		public void WriteInt(long _lpBaseAddress, int _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory((ulong)_lpBaseAddress, bytes);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00021F8C File Offset: 0x00021F8C
		public long GetPointerInt(long add, long[] offsets, int level)
		{
			long num = add;
			for (int i = 0; i < level; i++)
			{
				num = this.ReadInt64(num) + offsets[i];
			}
			return num;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00021FB4 File Offset: 0x00021FB4
		public void WriteByte(long _lpBaseAddress, byte _Value)
		{
			byte[] bytes = BitConverter.GetBytes((short)_Value);
			uint num = 0U;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, bytes, (uint)(bytes.Length - 1), out num);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00005140 File Offset: 0x00005140
		public void WriteUInt(long pAddress, uint value)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00005140 File Offset: 0x00005140
		public void WriteBool(long pAddress, bool value)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00021FE0 File Offset: 0x00021FE0
		public void WriteXBytes(ulong _lpBaseAddress, byte[] _Value)
		{
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, _Value, (ulong)((long)_Value.Length), out zero);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0002200C File Offset: 0x0002200C
		public void WriteFloat(long _lpBaseAddress, float _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory((ulong)_lpBaseAddress, bytes);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00022028 File Offset: 0x00022028
		public string ReadString(long pAddress)
		{
			return "";
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002202F File Offset: 0x0002202F
		public long ReadInt64(long pAddress)
		{
			return 0L;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00022033 File Offset: 0x00022033
		public int ReadInt(long pAddress)
		{
			return 0;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00022036 File Offset: 0x00022036
		public float ReadFloat(long pAddress)
		{
			return 0f;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00022040 File Offset: 0x00022040
		public byte[] ReadBytes(long pAddress, int length)
		{
			byte[] array = new byte[length];
			uint num = 0U;
			Memory.ReadProcessMemory(this.ProcessHandle, pAddress, array, (uint)length, out num);
			return array;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00022068 File Offset: 0x00022068
		public byte[] ReadBytesuint(uint pAddress, uint length)
		{
			byte[] array = new byte[length];
			uint num = 0U;
			Memory.ReadProcessMemory(this.ProcessHandle, (long)((ulong)pAddress), array, length, out num);
			return array;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00005140 File Offset: 0x00005140
		public void WriteString(long pAddress, string pString)
		{
		}

		// Token: 0x040003D1 RID: 977
		private string ProcessName;

		// Token: 0x040003D2 RID: 978
		public bool yes;

		// Token: 0x040003D3 RID: 979
		public long BaseAddress;

		// Token: 0x040003D4 RID: 980
		public int ProcessID;

		// Token: 0x040003D5 RID: 981
		public IntPtr ProcessHandle;

		// Token: 0x02000094 RID: 148
		[Flags]
		internal enum MemoryAllocationFlags
		{
			// Token: 0x040003D7 RID: 983
			Commit = 4096,
			// Token: 0x040003D8 RID: 984
			Reserve = 8192
		}

		// Token: 0x02000095 RID: 149
		[Flags]
		internal enum MemoryProtectionFlags
		{
			// Token: 0x040003DA RID: 986
			ExecuteReadWrite = 64
		}

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000318 RID: 792
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int NtWriteVirtualMemory(SafeProcessHandle processHandle, IntPtr address, byte[] buffer, uint size, IntPtr bytesWrittenBuffer);
	}
}
