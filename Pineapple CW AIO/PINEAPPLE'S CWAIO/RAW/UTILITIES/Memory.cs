using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace RAW.UTILITIES
{
	// Token: 0x0200009B RID: 155
	public class Memory
	{
		// Token: 0x0600032D RID: 813 RVA: 0x00022B74 File Offset: 0x00022B74
		public bool AttackProcess(string _ProcessName)
		{
			Process[] processesByName = Process.GetProcessesByName(_ProcessName);
			if (processesByName.Length == 0)
			{
				return false;
			}
			this.BaseModule = processesByName[0].MainModule.BaseAddress;
			this.CurProcess = processesByName[0];
			this.ProcessID = processesByName[0].Id;
			this.ProcessName = _ProcessName;
			this.ProcessHandle = Memory.OpenProcess(56U, false, this.ProcessID);
			return this.ProcessHandle != IntPtr.Zero;
		}

		// Token: 0x0600032E RID: 814
		[DllImport("kernel32.dll")]
		public static extern bool CloseHandle(IntPtr handle);

		// Token: 0x0600032F RID: 815
		[DllImport("kernel32")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

		// Token: 0x06000330 RID: 816 RVA: 0x00022BE4 File Offset: 0x00022BE4
		~Memory()
		{
			if (this.ProcessHandle != IntPtr.Zero)
			{
				Memory.CloseHandle(this.ProcessHandle);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00022C28 File Offset: 0x00022C28
		public static IntPtr GetModuleBaseAddress(Process proc, string modName)
		{
			IntPtr result = IntPtr.Zero;
			foreach (object obj in proc.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.ModuleName == modName)
				{
					result = processModule.BaseAddress;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00022C98 File Offset: 0x00022C98
		internal static IntPtr GetBaseAddress(string ProcessName)
		{
			IntPtr result;
			try
			{
				result = Process.GetProcessesByName(ProcessName)[0].MainModule.BaseAddress;
			}
			catch
			{
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00022CD4 File Offset: 0x00022CD4
		public bool IsOpen()
		{
			return this.ProcessName != string.Empty && this.AttackProcess(this.ProcessName);
		}

		// Token: 0x06000334 RID: 820
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(uint dwAccess, bool inherit, int pid);

		// Token: 0x06000335 RID: 821 RVA: 0x00022CF8 File Offset: 0x00022CF8
		public float ReadFloat(ulong _lpBaseAddress)
		{
			byte[] array = new byte[4];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 4UL, out intPtr);
			return BitConverter.ToSingle(array, 0);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00022D28 File Offset: 0x00022D28
		public int ReadInt32(ulong _lpBaseAddress)
		{
			byte[] array = new byte[4];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 4UL, out intPtr);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00022D58 File Offset: 0x00022D58
		public int ReadXInt32(ulong _lpBaseAddress, byte[] array)
		{
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 4UL, out intPtr);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00022D80 File Offset: 0x00022D80
		public ulong ReadInt64(ulong _lpBaseAddress)
		{
			byte[] array = new byte[8];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 8UL, out intPtr);
			return BitConverter.ToUInt64(array, 0);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00022DB0 File Offset: 0x00022DB0
		public ulong ReadPointerInt(ulong add, ulong[] offsets, int level)
		{
			ulong lpBaseAddress = add;
			for (int i = 0; i < level; i++)
			{
				lpBaseAddress = this.ReadInt64(lpBaseAddress) + offsets[i];
			}
			return this.ReadInt64(lpBaseAddress);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00022DE0 File Offset: 0x00022DE0
		public ulong GetPointer(params ulong[] args)
		{
			ulong num = 0UL;
			for (int i = 0; i <= args.Length - 1; i++)
			{
				if (i != args.Length - 1)
				{
					num = this.ReadInt64(num + args[i]);
				}
				else
				{
					num += args[i];
				}
			}
			return num;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00022E20 File Offset: 0x00022E20
		public ulong GetPointerInt(ulong add, ulong[] offsets, int level)
		{
			ulong num = add;
			for (int i = 0; i < level; i++)
			{
				num = this.ReadInt64(num) + offsets[i];
			}
			return num;
		}

		// Token: 0x0600033C RID: 828
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, ulong lpBaseAddress, [In] [Out] byte[] lpBuffer, ulong dwSize, out IntPtr lpNumberOfBytesRead);

		// Token: 0x0600033D RID: 829
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		protected static extern bool ReadProcessMemory2(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesRead);

		// Token: 0x0600033E RID: 830 RVA: 0x00022E48 File Offset: 0x00022E48
		public string ReadString(ulong _lpBaseAddress)
		{
			byte[] array = new byte[1280];
			IntPtr intPtr;
			if (Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 1280UL, out intPtr))
			{
				string text = "";
				int num = 0;
				while (array[num] != 0)
				{
					string str = text;
					char c = (char)array[num];
					text = str + c.ToString();
					num++;
				}
				return text;
			}
			return "";
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00022EB0 File Offset: 0x00022EB0
		public uint ReadUInt32(ulong _lpBaseAddress)
		{
			byte[] array = new byte[4];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 4UL, out intPtr);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00022EE0 File Offset: 0x00022EE0
		public byte[] ReadBytes(ulong _lpBaseAddress, int Length)
		{
			byte[] array = new byte[Length];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 12UL, out intPtr);
			return array;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00022F08 File Offset: 0x00022F08
		public Vectors.Vec3.Vector3 ReadVector3(ulong _lpBaseAddress)
		{
			byte[] array = this.ReadBytes(_lpBaseAddress, 12);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new Vectors.Vec3.Vector3(array2[0], array2[1], array2[2]);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00022F44 File Offset: 0x00022F44
		public ulong ReadUInt64(ulong _lpBaseAddress)
		{
			byte[] array = new byte[8];
			IntPtr intPtr;
			Memory.ReadProcessMemory(this.ProcessHandle, _lpBaseAddress, array, 8UL, out intPtr);
			return BitConverter.ToUInt64(array, 0);
		}

		// Token: 0x06000343 RID: 835
		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000344 RID: 836
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

		// Token: 0x06000345 RID: 837
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

		// Token: 0x06000346 RID: 838 RVA: 0x00022F74 File Offset: 0x00022F74
		public void WriteByte(ulong _lpBaseAddress, byte _Value)
		{
			byte[] bytes = BitConverter.GetBytes((short)_Value);
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, bytes, (ulong)((long)bytes.Length), out zero);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00022FA4 File Offset: 0x00022FA4
		public void WriteBytes(ulong _lpBaseAddress, byte[] buffer)
		{
			IntPtr intPtr;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, buffer, (ulong)((long)buffer.Length), out intPtr);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00022FC8 File Offset: 0x00022FC8
		public void WriteAByte(ulong _lpBaseAddress, byte _Value)
		{
			byte[] bytes = BitConverter.GetBytes((short)_Value);
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, bytes, (ulong)((long)(bytes.Length - 1)), out zero);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00022FF8 File Offset: 0x00022FF8
		public void WriteVec3(ulong Address, Vectors.Vec3.Vector3 Value)
		{
			byte[] array = new byte[Vectors.Vec3.Vector3.SizeInBytes];
			Buffer.BlockCopy(BitConverter.GetBytes(Value.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Z), 0, array, 8, 4);
			this.WriteBytes(Address, array);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00023054 File Offset: 0x00023054
		public void WriteFloat(ulong _lpBaseAddress, float _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory(_lpBaseAddress, bytes);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00023070 File Offset: 0x00023070
		public void WriteInt16(ulong _lpBaseAddress, short _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory(_lpBaseAddress, bytes);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0002308C File Offset: 0x0002308C
		public void WriteInt32(ulong _lpBaseAddress, int _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory(_lpBaseAddress, bytes);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000230A8 File Offset: 0x000230A8
		public void WriteInt64(ulong _lpBaseAddress, long _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory(_lpBaseAddress, bytes);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000230C4 File Offset: 0x000230C4
		public void WriteMemory(ulong MemoryAddress, byte[] Buffer)
		{
			uint num;
			Memory.VirtualProtectEx(this.ProcessHandle, (IntPtr)((long)MemoryAddress), (uint)Buffer.Length, 4U, out num);
			IntPtr intPtr;
			Memory.WriteProcessMemory(this.ProcessHandle, MemoryAddress, Buffer, (ulong)((long)Buffer.Length), out intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00023100 File Offset: 0x00023100
		public void WriteNOP(ulong Address)
		{
			byte[] array = new byte[]
			{
				144,
				144,
				144,
				144,
				144
			};
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, Address, array, (ulong)((long)array.Length), out zero);
		}

		// Token: 0x06000350 RID: 848
		[DllImport("kernel32.dll")]
		public static extern bool WriteProcessMemory(IntPtr hProcess, ulong lpBaseAddress, [In] [Out] byte[] lpBuffer, ulong dwSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000351 RID: 849
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
		private static extern bool WriteProcessMemory2(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, [Out] int lpNumberOfBytesWritten);

		// Token: 0x06000352 RID: 850
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory3(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, long nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000353 RID: 851 RVA: 0x0002313C File Offset: 0x0002313C
		public void WriteString(ulong Address, string Text)
		{
			byte[] bytes = new ASCIIEncoding().GetBytes(Text);
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, Address, bytes, (ulong)((long)this.ReadString(Address).Length), out zero);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00023178 File Offset: 0x00023178
		public void WriteXString(ulong pAddress, string pString)
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				if (Memory.WriteProcessMemory(this.ProcessHandle, pAddress, Encoding.UTF8.GetBytes(pString), (ulong)pString.Length, out zero))
				{
					byte[] lpBuffer = new byte[1];
					Memory.WriteProcessMemory(this.ProcessHandle, pAddress + (ulong)((long)pString.Length), lpBuffer, 1UL, out zero);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000231E4 File Offset: 0x000231E4
		public void WriteBool(ulong pAddress, bool value)
		{
			try
			{
				byte[] array = new byte[]
				{
					value ? 1 : 0
				};
				IntPtr intPtr;
				Memory.WriteProcessMemory(this.ProcessHandle, pAddress, array, (ulong)array.Length, out intPtr);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0002322C File Offset: 0x0002322C
		public void WriteUInt32(ulong _lpBaseAddress, uint _Value)
		{
			byte[] bytes = BitConverter.GetBytes(_Value);
			this.WriteMemory(_lpBaseAddress, bytes);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00023248 File Offset: 0x00023248
		public void WriteXBytes(ulong _lpBaseAddress, byte[] _Value)
		{
			IntPtr zero = IntPtr.Zero;
			Memory.WriteProcessMemory(this.ProcessHandle, _lpBaseAddress, _Value, (ulong)((long)_Value.Length), out zero);
		}

		// Token: 0x040003E2 RID: 994
		public const uint PROCESS_VM_READ = 16U;

		// Token: 0x040003E3 RID: 995
		public const uint PROCESS_VM_WRITE = 32U;

		// Token: 0x040003E4 RID: 996
		public const uint PROCESS_VM_OPERATION = 8U;

		// Token: 0x040003E5 RID: 997
		public const uint PAGE_READWRITE = 4U;

		// Token: 0x040003E6 RID: 998
		private Process CurProcess;

		// Token: 0x040003E7 RID: 999
		private IntPtr ProcessHandle;

		// Token: 0x040003E8 RID: 1000
		private string ProcessName;

		// Token: 0x040003E9 RID: 1001
		private int ProcessID;

		// Token: 0x040003EA RID: 1002
		public IntPtr BaseModule;

		// Token: 0x0200009C RID: 156
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x040003EC RID: 1004
			All = 2035711U,
			// Token: 0x040003ED RID: 1005
			Terminate = 1U,
			// Token: 0x040003EE RID: 1006
			CreateThread = 2U,
			// Token: 0x040003EF RID: 1007
			VirtualMemoryOperation = 8U,
			// Token: 0x040003F0 RID: 1008
			VirtualMemoryRead = 16U,
			// Token: 0x040003F1 RID: 1009
			VirtualMemoryWrite = 32U,
			// Token: 0x040003F2 RID: 1010
			DuplicateHandle = 64U,
			// Token: 0x040003F3 RID: 1011
			CreateProcess = 128U,
			// Token: 0x040003F4 RID: 1012
			SetQuota = 256U,
			// Token: 0x040003F5 RID: 1013
			SetInformation = 512U,
			// Token: 0x040003F6 RID: 1014
			QueryInformation = 1024U,
			// Token: 0x040003F7 RID: 1015
			QueryLimitedInformation = 4096U,
			// Token: 0x040003F8 RID: 1016
			Synchronize = 1048576U
		}
	}
}
