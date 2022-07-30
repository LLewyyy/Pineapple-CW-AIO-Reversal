using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RAW.UTILITIES
{
	// Token: 0x0200009D RID: 157
	public class Vectors
	{
		// Token: 0x0200009E RID: 158
		public class Vec2
		{
			// Token: 0x0200009F RID: 159
			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			public struct Vector2
			{
				// Token: 0x0600035B RID: 859 RVA: 0x00023271 File Offset: 0x00023271
				public Vector2(float value)
				{
					this.X = value;
					this.Y = value;
				}

				// Token: 0x0600035C RID: 860 RVA: 0x00023281 File Offset: 0x00023281
				public Vector2(float x, float y)
				{
					this.X = x;
					this.Y = y;
				}

				// Token: 0x17000044 RID: 68
				// (get) Token: 0x0600035D RID: 861 RVA: 0x00023291 File Offset: 0x00023291
				public bool IsZero
				{
					get
					{
						return this.X == 0f && this.Y == 0f;
					}
				}

				// Token: 0x0600035E RID: 862 RVA: 0x000232AF File Offset: 0x000232AF
				public float Length()
				{
					return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y));
				}

				// Token: 0x0600035F RID: 863 RVA: 0x000232D3 File Offset: 0x000232D3
				public float LengthSquared()
				{
					return this.X * this.X + this.Y * this.Y;
				}

				// Token: 0x06000360 RID: 864 RVA: 0x000232F0 File Offset: 0x000232F0
				public void Normalize()
				{
					float num = this.Length();
					if (num != 0f)
					{
						float num2 = 1f / num;
						this.X *= num2;
						this.Y *= num2;
					}
				}

				// Token: 0x06000361 RID: 865 RVA: 0x00023330 File Offset: 0x00023330
				public float[] ToArray()
				{
					return new float[]
					{
						this.X,
						this.Y
					};
				}

				// Token: 0x06000362 RID: 866 RVA: 0x0002334A File Offset: 0x0002334A
				public static Vectors.Vec2.Vector2 Add(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X + right.X, left.Y + right.Y);
				}

				// Token: 0x06000363 RID: 867 RVA: 0x0002336B File Offset: 0x0002336B
				public static Vectors.Vec2.Vector2 Subtract(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X - right.X, left.Y - right.Y);
				}

				// Token: 0x06000364 RID: 868 RVA: 0x0002338C File Offset: 0x0002338C
				public static Vectors.Vec2.Vector2 Multiply(Vectors.Vec2.Vector2 value, float scale)
				{
					return new Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
				}

				// Token: 0x06000365 RID: 869 RVA: 0x000233A3 File Offset: 0x000233A3
				public static Vectors.Vec2.Vector2 Multiply(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X * right.X, left.Y * right.Y);
				}

				// Token: 0x06000366 RID: 870 RVA: 0x000233C4 File Offset: 0x000233C4
				public static Vectors.Vec2.Vector2 Divide(Vectors.Vec2.Vector2 value, float scale)
				{
					return new Vectors.Vec2.Vector2(value.X / scale, value.Y / scale);
				}

				// Token: 0x06000367 RID: 871 RVA: 0x000233DB File Offset: 0x000233DB
				public static Vectors.Vec2.Vector2 Divide(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X / right.X, left.Y / right.Y);
				}

				// Token: 0x06000368 RID: 872 RVA: 0x000233FC File Offset: 0x000233FC
				public static Vectors.Vec2.Vector2 Negate(Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(-value.X, -value.Y);
				}

				// Token: 0x06000369 RID: 873 RVA: 0x00023411 File Offset: 0x00023411
				public static Vectors.Vec2.Vector2 Abs(Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y));
				}

				// Token: 0x0600036A RID: 874 RVA: 0x00023450 File Offset: 0x00023450
				public static Vectors.Vec2.Vector2 Clamp(Vectors.Vec2.Vector2 value, Vectors.Vec2.Vector2 min, Vectors.Vec2.Vector2 max)
				{
					float num = value.X;
					num = ((num > max.X) ? max.X : num);
					num = ((num < min.X) ? min.X : num);
					float num2 = value.Y;
					num2 = ((num2 > max.Y) ? max.Y : num2);
					num2 = ((num2 < min.Y) ? min.Y : num2);
					return new Vectors.Vec2.Vector2(num, num2);
				}

				// Token: 0x0600036B RID: 875 RVA: 0x000234C0 File Offset: 0x000234C0
				public static float Distance(Vectors.Vec2.Vector2 value1, Vectors.Vec2.Vector2 value2)
				{
					float num = value1.X - value2.X;
					float num2 = value1.Y - value2.Y;
					return (float)Math.Sqrt((double)(num * num + num2 * num2));
				}

				// Token: 0x0600036C RID: 876 RVA: 0x000234F5 File Offset: 0x000234F5
				public static float Dot(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return left.X * right.X + left.Y * right.Y;
				}

				// Token: 0x0600036D RID: 877 RVA: 0x0002334A File Offset: 0x0002334A
				public static Vectors.Vec2.Vector2 operator +(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X + right.X, left.Y + right.Y);
				}

				// Token: 0x0600036E RID: 878 RVA: 0x000233A3 File Offset: 0x000233A3
				public static Vectors.Vec2.Vector2 operator *(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X * right.X, left.Y * right.Y);
				}

				// Token: 0x0600036F RID: 879 RVA: 0x00008222 File Offset: 0x00008222
				public static Vectors.Vec2.Vector2 operator +(Vectors.Vec2.Vector2 value)
				{
					return value;
				}

				// Token: 0x06000370 RID: 880 RVA: 0x0002336B File Offset: 0x0002336B
				public static Vectors.Vec2.Vector2 operator -(Vectors.Vec2.Vector2 left, Vectors.Vec2.Vector2 right)
				{
					return new Vectors.Vec2.Vector2(left.X - right.X, left.Y - right.Y);
				}

				// Token: 0x06000371 RID: 881 RVA: 0x000233FC File Offset: 0x000233FC
				public static Vectors.Vec2.Vector2 operator -(Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(-value.X, -value.Y);
				}

				// Token: 0x06000372 RID: 882 RVA: 0x00023512 File Offset: 0x00023512
				public static Vectors.Vec2.Vector2 operator *(float scale, Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
				}

				// Token: 0x06000373 RID: 883 RVA: 0x0002338C File Offset: 0x0002338C
				public static Vectors.Vec2.Vector2 operator *(Vectors.Vec2.Vector2 value, float scale)
				{
					return new Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
				}

				// Token: 0x06000374 RID: 884 RVA: 0x000233C4 File Offset: 0x000233C4
				public static Vectors.Vec2.Vector2 operator /(Vectors.Vec2.Vector2 value, float scale)
				{
					return new Vectors.Vec2.Vector2(value.X / scale, value.Y / scale);
				}

				// Token: 0x06000375 RID: 885 RVA: 0x00023529 File Offset: 0x00023529
				public static Vectors.Vec2.Vector2 operator /(float scale, Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(scale / value.X, scale / value.Y);
				}

				// Token: 0x06000376 RID: 886 RVA: 0x000233DB File Offset: 0x000233DB
				public static Vectors.Vec2.Vector2 operator /(Vectors.Vec2.Vector2 value, Vectors.Vec2.Vector2 scale)
				{
					return new Vectors.Vec2.Vector2(value.X / scale.X, value.Y / scale.Y);
				}

				// Token: 0x06000377 RID: 887 RVA: 0x00023540 File Offset: 0x00023540
				public static Vectors.Vec2.Vector2 operator +(Vectors.Vec2.Vector2 value, float scalar)
				{
					return new Vectors.Vec2.Vector2(value.X + scalar, value.Y + scalar);
				}

				// Token: 0x06000378 RID: 888 RVA: 0x00023557 File Offset: 0x00023557
				public static Vectors.Vec2.Vector2 operator +(float scalar, Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(scalar + value.X, scalar + value.Y);
				}

				// Token: 0x06000379 RID: 889 RVA: 0x0002356E File Offset: 0x0002356E
				public static Vectors.Vec2.Vector2 operator -(Vectors.Vec2.Vector2 value, float scalar)
				{
					return new Vectors.Vec2.Vector2(value.X - scalar, value.Y - scalar);
				}

				// Token: 0x0600037A RID: 890 RVA: 0x00023585 File Offset: 0x00023585
				public static Vectors.Vec2.Vector2 operator -(float scalar, Vectors.Vec2.Vector2 value)
				{
					return new Vectors.Vec2.Vector2(scalar - value.X, scalar - value.Y);
				}

				// Token: 0x0600037B RID: 891 RVA: 0x0002359C File Offset: 0x0002359C
				public static bool operator ==(Vectors.Vec2.Vector2 v1, Vectors.Vec2.Vector2 v2)
				{
					return v1.X == v2.X && v1.Y == v2.Y;
				}

				// Token: 0x0600037C RID: 892 RVA: 0x000235BC File Offset: 0x000235BC
				public static bool operator !=(Vectors.Vec2.Vector2 v1, Vectors.Vec2.Vector2 v2)
				{
					return v1.X != v2.X || v1.Y != v2.Y;
				}

				// Token: 0x0600037D RID: 893 RVA: 0x000235DF File Offset: 0x000235DF
				public override string ToString()
				{
					return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", this.X, this.Y);
				}

				// Token: 0x040003F9 RID: 1017
				public float X;

				// Token: 0x040003FA RID: 1018
				public float Y;

				// Token: 0x040003FB RID: 1019
				public static readonly int SizeInBytes = Marshal.SizeOf<Vectors.Vec2.Vector2>();

				// Token: 0x040003FC RID: 1020
				public static readonly Vectors.Vec2.Vector2 Zero = new Vectors.Vec2.Vector2(0f);

				// Token: 0x040003FD RID: 1021
				public static readonly Vectors.Vec2.Vector2 UnitX = new Vectors.Vec2.Vector2(1f, 0f);

				// Token: 0x040003FE RID: 1022
				public static readonly Vectors.Vec2.Vector2 UnitY = new Vectors.Vec2.Vector2(0f, 1f);

				// Token: 0x040003FF RID: 1023
				public static readonly Vectors.Vec2.Vector2 One = new Vectors.Vec2.Vector2(1f, 1f);
			}
		}

		// Token: 0x020000A0 RID: 160
		public class Vec3
		{
			// Token: 0x020000A1 RID: 161
			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			public struct Vector3
			{
				// Token: 0x06000380 RID: 896 RVA: 0x0002366A File Offset: 0x0002366A
				public Vector3(float value)
				{
					this.X = value;
					this.Y = value;
					this.Z = value;
				}

				// Token: 0x06000381 RID: 897 RVA: 0x00023681 File Offset: 0x00023681
				public Vector3(float x, float y, float z)
				{
					this.X = x;
					this.Y = y;
					this.Z = z;
				}

				// Token: 0x17000045 RID: 69
				[IndexerName("Component")]
				public unsafe float this[int index]
				{
					get
					{
						if ((index | 3) != 3)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.X)
						{
							return ptr[index];
						}
					}
					set
					{
						if ((index | 3) != 3)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.X)
						{
							ptr[index] = value;
						}
					}
				}

				// Token: 0x17000046 RID: 70
				// (get) Token: 0x06000384 RID: 900 RVA: 0x000236F9 File Offset: 0x000236F9
				public bool IsZero
				{
					get
					{
						return this.X == 0f && this.Y == 0f && this.Z == 0f;
					}
				}

				// Token: 0x06000385 RID: 901 RVA: 0x00023724 File Offset: 0x00023724
				public float Length()
				{
					return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z));
				}

				// Token: 0x06000386 RID: 902 RVA: 0x00023756 File Offset: 0x00023756
				public float LengthSquared()
				{
					return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
				}

				// Token: 0x06000387 RID: 903 RVA: 0x00023784 File Offset: 0x00023784
				public void Normalize()
				{
					float num = this.Length();
					if (num != 0f)
					{
						float num2 = 1f / num;
						this.X *= num2;
						this.Y *= num2;
						this.Z *= num2;
					}
				}

				// Token: 0x06000388 RID: 904 RVA: 0x000237D2 File Offset: 0x000237D2
				public float[] ToArray()
				{
					return new float[]
					{
						this.X,
						this.Y,
						this.Z
					};
				}

				// Token: 0x06000389 RID: 905 RVA: 0x000237F5 File Offset: 0x000237F5
				public static Vectors.Vec3.Vector3 Add(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
				}

				// Token: 0x0600038A RID: 906 RVA: 0x00023823 File Offset: 0x00023823
				public static Vectors.Vec3.Vector3 Subtract(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
				}

				// Token: 0x0600038B RID: 907 RVA: 0x00023851 File Offset: 0x00023851
				public static Vectors.Vec3.Vector3 Multiply(Vectors.Vec3.Vector3 value, float scale)
				{
					return new Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
				}

				// Token: 0x0600038C RID: 908 RVA: 0x00023870 File Offset: 0x00023870
				public static Vectors.Vec3.Vector3 Multiply(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
				}

				// Token: 0x0600038D RID: 909 RVA: 0x0002389E File Offset: 0x0002389E
				public static Vectors.Vec3.Vector3 Divide(Vectors.Vec3.Vector3 value, float scale)
				{
					return new Vectors.Vec3.Vector3(value.X / scale, value.Y / scale, value.Z / scale);
				}

				// Token: 0x0600038E RID: 910 RVA: 0x000238BD File Offset: 0x000238BD
				public static Vectors.Vec3.Vector3 Divide(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
				}

				// Token: 0x0600038F RID: 911 RVA: 0x000238EB File Offset: 0x000238EB
				public static Vectors.Vec3.Vector3 Negate(Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(-value.X, -value.Y, -value.Z);
				}

				// Token: 0x06000390 RID: 912 RVA: 0x00023908 File Offset: 0x00023908
				public static Vectors.Vec3.Vector3 Abs(Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y), (value.Z > 0f) ? value.Z : (-value.Z));
				}

				// Token: 0x06000391 RID: 913 RVA: 0x00023970 File Offset: 0x00023970
				public static Vectors.Vec3.Vector3 Clamp(Vectors.Vec3.Vector3 value, Vectors.Vec3.Vector3 min, Vectors.Vec3.Vector3 max)
				{
					float num = value.X;
					num = ((num > max.X) ? max.X : num);
					num = ((num < min.X) ? min.X : num);
					float num2 = value.Y;
					num2 = ((num2 > max.Y) ? max.Y : num2);
					num2 = ((num2 < min.Y) ? min.Y : num2);
					float num3 = value.Z;
					num3 = ((num3 > max.Z) ? max.Z : num3);
					num3 = ((num3 < min.Z) ? min.Z : num3);
					return new Vectors.Vec3.Vector3(num, num2, num3);
				}

				// Token: 0x06000392 RID: 914 RVA: 0x00023A0C File Offset: 0x00023A0C
				public static float Distance(Vectors.Vec3.Vector3 value1, Vectors.Vec3.Vector3 value2)
				{
					float num = value1.X - value2.X;
					float num2 = value1.Y - value2.Y;
					float num3 = value1.Z - value2.Z;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
				}

				// Token: 0x06000393 RID: 915 RVA: 0x00023A53 File Offset: 0x00023A53
				public static float Dot(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
				}

				// Token: 0x06000394 RID: 916 RVA: 0x000237F5 File Offset: 0x000237F5
				public static Vectors.Vec3.Vector3 operator +(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
				}

				// Token: 0x06000395 RID: 917 RVA: 0x00023870 File Offset: 0x00023870
				public static Vectors.Vec3.Vector3 operator *(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
				}

				// Token: 0x06000396 RID: 918 RVA: 0x00008222 File Offset: 0x00008222
				public static Vectors.Vec3.Vector3 operator +(Vectors.Vec3.Vector3 value)
				{
					return value;
				}

				// Token: 0x06000397 RID: 919 RVA: 0x00023823 File Offset: 0x00023823
				public static Vectors.Vec3.Vector3 operator -(Vectors.Vec3.Vector3 left, Vectors.Vec3.Vector3 right)
				{
					return new Vectors.Vec3.Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
				}

				// Token: 0x06000398 RID: 920 RVA: 0x000238EB File Offset: 0x000238EB
				public static Vectors.Vec3.Vector3 operator -(Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(-value.X, -value.Y, -value.Z);
				}

				// Token: 0x06000399 RID: 921 RVA: 0x00023A7E File Offset: 0x00023A7E
				public static Vectors.Vec3.Vector3 operator *(float scale, Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
				}

				// Token: 0x0600039A RID: 922 RVA: 0x00023851 File Offset: 0x00023851
				public static Vectors.Vec3.Vector3 operator *(Vectors.Vec3.Vector3 value, float scale)
				{
					return new Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
				}

				// Token: 0x0600039B RID: 923 RVA: 0x0002389E File Offset: 0x0002389E
				public static Vectors.Vec3.Vector3 operator /(Vectors.Vec3.Vector3 value, float scale)
				{
					return new Vectors.Vec3.Vector3(value.X / scale, value.Y / scale, value.Z / scale);
				}

				// Token: 0x0600039C RID: 924 RVA: 0x00023A9D File Offset: 0x00023A9D
				public static Vectors.Vec3.Vector3 operator /(float scale, Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(scale / value.X, scale / value.Y, scale / value.Z);
				}

				// Token: 0x0600039D RID: 925 RVA: 0x000238BD File Offset: 0x000238BD
				public static Vectors.Vec3.Vector3 operator /(Vectors.Vec3.Vector3 value, Vectors.Vec3.Vector3 scale)
				{
					return new Vectors.Vec3.Vector3(value.X / scale.X, value.Y / scale.Y, value.Z / scale.Z);
				}

				// Token: 0x0600039E RID: 926 RVA: 0x00023ABC File Offset: 0x00023ABC
				public static Vectors.Vec3.Vector3 operator +(Vectors.Vec3.Vector3 value, float scalar)
				{
					return new Vectors.Vec3.Vector3(value.X + scalar, value.Y + scalar, value.Z + scalar);
				}

				// Token: 0x0600039F RID: 927 RVA: 0x00023ADB File Offset: 0x00023ADB
				public static Vectors.Vec3.Vector3 operator +(float scalar, Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(scalar + value.X, scalar + value.Y, scalar + value.Z);
				}

				// Token: 0x060003A0 RID: 928 RVA: 0x00023AFA File Offset: 0x00023AFA
				public static Vectors.Vec3.Vector3 operator -(Vectors.Vec3.Vector3 value, float scalar)
				{
					return new Vectors.Vec3.Vector3(value.X - scalar, value.Y - scalar, value.Z - scalar);
				}

				// Token: 0x060003A1 RID: 929 RVA: 0x00023B19 File Offset: 0x00023B19
				public static Vectors.Vec3.Vector3 operator -(float scalar, Vectors.Vec3.Vector3 value)
				{
					return new Vectors.Vec3.Vector3(scalar - value.X, scalar - value.Y, scalar - value.Z);
				}

				// Token: 0x060003A2 RID: 930 RVA: 0x00023B38 File Offset: 0x00023B38
				public static bool operator ==(Vectors.Vec3.Vector3 v1, Vectors.Vec3.Vector3 v2)
				{
					return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
				}

				// Token: 0x060003A3 RID: 931 RVA: 0x00023B66 File Offset: 0x00023B66
				public static bool operator !=(Vectors.Vec3.Vector3 v1, Vectors.Vec3.Vector3 v2)
				{
					return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;
				}

				// Token: 0x060003A4 RID: 932 RVA: 0x00023B97 File Offset: 0x00023B97
				public override string ToString()
				{
					return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", this.X, this.Y, this.Z);
				}

				// Token: 0x04000400 RID: 1024
				public float X;

				// Token: 0x04000401 RID: 1025
				public float Y;

				// Token: 0x04000402 RID: 1026
				public float Z;

				// Token: 0x04000403 RID: 1027
				public static readonly int SizeInBytes = Marshal.SizeOf<Vectors.Vec3.Vector3>();

				// Token: 0x04000404 RID: 1028
				public static readonly Vectors.Vec3.Vector3 Zero = new Vectors.Vec3.Vector3(0f);

				// Token: 0x04000405 RID: 1029
				public static readonly Vectors.Vec3.Vector3 UnitX = new Vectors.Vec3.Vector3(1f, 0f, 0f);

				// Token: 0x04000406 RID: 1030
				public static readonly Vectors.Vec3.Vector3 UnitY = new Vectors.Vec3.Vector3(0f, 1f, 0f);

				// Token: 0x04000407 RID: 1031
				public static readonly Vectors.Vec3.Vector3 UnitZ = new Vectors.Vec3.Vector3(0f, 0f, 1f);

				// Token: 0x04000408 RID: 1032
				public static readonly Vectors.Vec3.Vector3 One = new Vectors.Vec3.Vector3(1f, 1f, 1f);

				// Token: 0x04000409 RID: 1033
				public static readonly Vectors.Vec3.Vector3 Up = new Vectors.Vec3.Vector3(0f, 1f, 0f);

				// Token: 0x0400040A RID: 1034
				public static readonly Vectors.Vec3.Vector3 Down = new Vectors.Vec3.Vector3(0f, -1f, 0f);

				// Token: 0x0400040B RID: 1035
				public static readonly Vectors.Vec3.Vector3 Left = new Vectors.Vec3.Vector3(-1f, 0f, 0f);

				// Token: 0x0400040C RID: 1036
				public static readonly Vectors.Vec3.Vector3 Right = new Vectors.Vec3.Vector3(1f, 0f, 0f);

				// Token: 0x0400040D RID: 1037
				public static readonly Vectors.Vec3.Vector3 ForwardRH = new Vectors.Vec3.Vector3(0f, 0f, -1f);

				// Token: 0x0400040E RID: 1038
				public static readonly Vectors.Vec3.Vector3 ForwardLH = new Vectors.Vec3.Vector3(0f, 0f, 1f);

				// Token: 0x0400040F RID: 1039
				public static readonly Vectors.Vec3.Vector3 BackwardRH = new Vectors.Vec3.Vector3(0f, 0f, 1f);

				// Token: 0x04000410 RID: 1040
				public static readonly Vectors.Vec3.Vector3 BackwardLH = new Vectors.Vec3.Vector3(0f, 0f, -1f);
			}
		}

		// Token: 0x020000A2 RID: 162
		public class Vec4
		{
			// Token: 0x020000A3 RID: 163
			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			public struct Vector4
			{
				// Token: 0x060003A7 RID: 935 RVA: 0x00023D1E File Offset: 0x00023D1E
				public Vector4(float value)
				{
					this.X = value;
					this.Y = value;
					this.Z = value;
					this.W = value;
				}

				// Token: 0x060003A8 RID: 936 RVA: 0x00023D3C File Offset: 0x00023D3C
				public Vector4(float x, float y, float z, float w)
				{
					this.X = x;
					this.Y = y;
					this.Z = z;
					this.W = w;
				}

				// Token: 0x17000047 RID: 71
				// (get) Token: 0x060003A9 RID: 937 RVA: 0x00023D5B File Offset: 0x00023D5B
				public bool IsZero
				{
					get
					{
						return this.X == 0f && this.Y == 0f && this.Z == 0f && this.W == 0f;
					}
				}

				// Token: 0x060003AA RID: 938 RVA: 0x00023D93 File Offset: 0x00023D93
				public float Length()
				{
					return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W));
				}

				// Token: 0x060003AB RID: 939 RVA: 0x00023DD3 File Offset: 0x00023DD3
				public float LengthSquared()
				{
					return this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
				}

				// Token: 0x060003AC RID: 940 RVA: 0x00023E0C File Offset: 0x00023E0C
				public void Normalize()
				{
					float num = this.Length();
					if (num != 0f)
					{
						float num2 = 1f / num;
						this.X *= num2;
						this.Y *= num2;
						this.Z *= num2;
						this.W *= num2;
					}
				}

				// Token: 0x060003AD RID: 941 RVA: 0x00023E68 File Offset: 0x00023E68
				public float[] ToArray()
				{
					return new float[]
					{
						this.X,
						this.Y,
						this.Z,
						this.W
					};
				}

				// Token: 0x060003AE RID: 942 RVA: 0x00023E94 File Offset: 0x00023E94
				public static Vectors.Vec4.Vector4 Add(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
				}

				// Token: 0x060003AF RID: 943 RVA: 0x00023ECF File Offset: 0x00023ECF
				public static Vectors.Vec4.Vector4 Subtract(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
				}

				// Token: 0x060003B0 RID: 944 RVA: 0x00023F0A File Offset: 0x00023F0A
				public static Vectors.Vec4.Vector4 Multiply(Vectors.Vec4.Vector4 value, float scale)
				{
					return new Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
				}

				// Token: 0x060003B1 RID: 945 RVA: 0x00023F31 File Offset: 0x00023F31
				public static Vectors.Vec4.Vector4 Multiply(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
				}

				// Token: 0x060003B2 RID: 946 RVA: 0x00023F6C File Offset: 0x00023F6C
				public static Vectors.Vec4.Vector4 Divide(Vectors.Vec4.Vector4 value, float scale)
				{
					return new Vectors.Vec4.Vector4(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
				}

				// Token: 0x060003B3 RID: 947 RVA: 0x00023F93 File Offset: 0x00023F93
				public static Vectors.Vec4.Vector4 Divide(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
				}

				// Token: 0x060003B4 RID: 948 RVA: 0x00023FCE File Offset: 0x00023FCE
				public static Vectors.Vec4.Vector4 Negate(Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(-value.X, -value.Y, -value.Z, -value.W);
				}

				// Token: 0x060003B5 RID: 949 RVA: 0x00023FF4 File Offset: 0x00023FF4
				public static Vectors.Vec4.Vector4 Abs(Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y), (value.Z > 0f) ? value.Z : (-value.Z), (value.W > 0f) ? value.W : (-value.W));
				}

				// Token: 0x060003B6 RID: 950 RVA: 0x00024078 File Offset: 0x00024078
				public static Vectors.Vec4.Vector4 Clamp(Vectors.Vec4.Vector4 value, Vectors.Vec4.Vector4 min, Vectors.Vec4.Vector4 max)
				{
					float num = value.X;
					num = ((num > max.X) ? max.X : num);
					num = ((num < min.X) ? min.X : num);
					float num2 = value.Y;
					num2 = ((num2 > max.Y) ? max.Y : num2);
					num2 = ((num2 < min.Y) ? min.Y : num2);
					float num3 = value.Z;
					num3 = ((num3 > max.Z) ? max.Z : num3);
					num3 = ((num3 < min.Z) ? min.Z : num3);
					float num4 = value.W;
					num4 = ((num4 > max.W) ? max.W : num4);
					num4 = ((num4 < min.W) ? min.W : num4);
					return new Vectors.Vec4.Vector4(num, num2, num3, num4);
				}

				// Token: 0x060003B7 RID: 951 RVA: 0x00024144 File Offset: 0x00024144
				public static float Distance(Vectors.Vec4.Vector4 value1, Vectors.Vec4.Vector4 value2)
				{
					float num = value1.X - value2.X;
					float num2 = value1.Y - value2.Y;
					float num3 = value1.Z - value2.Z;
					float num4 = value1.W - value2.W;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
				}

				// Token: 0x060003B8 RID: 952 RVA: 0x0002419D File Offset: 0x0002419D
				public static float Dot(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
				}

				// Token: 0x060003B9 RID: 953 RVA: 0x00023E94 File Offset: 0x00023E94
				public static Vectors.Vec4.Vector4 operator +(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
				}

				// Token: 0x060003BA RID: 954 RVA: 0x00023F31 File Offset: 0x00023F31
				public static Vectors.Vec4.Vector4 operator *(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
				}

				// Token: 0x060003BB RID: 955 RVA: 0x00008222 File Offset: 0x00008222
				public static Vectors.Vec4.Vector4 operator +(Vectors.Vec4.Vector4 value)
				{
					return value;
				}

				// Token: 0x060003BC RID: 956 RVA: 0x00023ECF File Offset: 0x00023ECF
				public static Vectors.Vec4.Vector4 operator -(Vectors.Vec4.Vector4 left, Vectors.Vec4.Vector4 right)
				{
					return new Vectors.Vec4.Vector4(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
				}

				// Token: 0x060003BD RID: 957 RVA: 0x00023FCE File Offset: 0x00023FCE
				public static Vectors.Vec4.Vector4 operator -(Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(-value.X, -value.Y, -value.Z, -value.W);
				}

				// Token: 0x060003BE RID: 958 RVA: 0x000241D6 File Offset: 0x000241D6
				public static Vectors.Vec4.Vector4 operator *(float scale, Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
				}

				// Token: 0x060003BF RID: 959 RVA: 0x00023F0A File Offset: 0x00023F0A
				public static Vectors.Vec4.Vector4 operator *(Vectors.Vec4.Vector4 value, float scale)
				{
					return new Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
				}

				// Token: 0x060003C0 RID: 960 RVA: 0x00023F6C File Offset: 0x00023F6C
				public static Vectors.Vec4.Vector4 operator /(Vectors.Vec4.Vector4 value, float scale)
				{
					return new Vectors.Vec4.Vector4(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
				}

				// Token: 0x060003C1 RID: 961 RVA: 0x000241FD File Offset: 0x000241FD
				public static Vectors.Vec4.Vector4 operator /(float scale, Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(scale / value.X, scale / value.Y, scale / value.Z, scale / value.W);
				}

				// Token: 0x060003C2 RID: 962 RVA: 0x00023F93 File Offset: 0x00023F93
				public static Vectors.Vec4.Vector4 operator /(Vectors.Vec4.Vector4 value, Vectors.Vec4.Vector4 scale)
				{
					return new Vectors.Vec4.Vector4(value.X / scale.X, value.Y / scale.Y, value.Z / scale.Z, value.W / scale.W);
				}

				// Token: 0x060003C3 RID: 963 RVA: 0x00024224 File Offset: 0x00024224
				public static Vectors.Vec4.Vector4 operator +(Vectors.Vec4.Vector4 value, float scalar)
				{
					return new Vectors.Vec4.Vector4(value.X + scalar, value.Y + scalar, value.Z + scalar, value.W + scalar);
				}

				// Token: 0x060003C4 RID: 964 RVA: 0x0002424B File Offset: 0x0002424B
				public static Vectors.Vec4.Vector4 operator +(float scalar, Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(scalar + value.X, scalar + value.Y, scalar + value.Z, scalar + value.W);
				}

				// Token: 0x060003C5 RID: 965 RVA: 0x00024272 File Offset: 0x00024272
				public static Vectors.Vec4.Vector4 operator -(Vectors.Vec4.Vector4 value, float scalar)
				{
					return new Vectors.Vec4.Vector4(value.X - scalar, value.Y - scalar, value.Z - scalar, value.W - scalar);
				}

				// Token: 0x060003C6 RID: 966 RVA: 0x00024299 File Offset: 0x00024299
				public static Vectors.Vec4.Vector4 operator -(float scalar, Vectors.Vec4.Vector4 value)
				{
					return new Vectors.Vec4.Vector4(scalar - value.X, scalar - value.Y, scalar - value.Z, scalar - value.W);
				}

				// Token: 0x060003C7 RID: 967 RVA: 0x000242C0 File Offset: 0x000242C0
				public static bool operator ==(Vectors.Vec4.Vector4 v1, Vectors.Vec4.Vector4 v2)
				{
					return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z && v1.W == v2.W;
				}

				// Token: 0x060003C8 RID: 968 RVA: 0x000242FC File Offset: 0x000242FC
				public static bool operator !=(Vectors.Vec4.Vector4 v1, Vectors.Vec4.Vector4 v2)
				{
					return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z || v1.W != v2.W;
				}

				// Token: 0x060003C9 RID: 969 RVA: 0x0002433C File Offset: 0x0002433C
				public override string ToString()
				{
					return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", new object[]
					{
						this.X,
						this.Y,
						this.Z,
						this.W
					});
				}

				// Token: 0x04000411 RID: 1041
				public float X;

				// Token: 0x04000412 RID: 1042
				public float Y;

				// Token: 0x04000413 RID: 1043
				public float Z;

				// Token: 0x04000414 RID: 1044
				public float W;

				// Token: 0x04000415 RID: 1045
				public static readonly int SizeInBytes = Marshal.SizeOf<Vectors.Vec4.Vector4>();

				// Token: 0x04000416 RID: 1046
				public static readonly Vectors.Vec4.Vector4 Zero = default(Vectors.Vec4.Vector4);

				// Token: 0x04000417 RID: 1047
				public static readonly Vectors.Vec4.Vector4 UnitX = new Vectors.Vec4.Vector4(1f, 0f, 0f, 0f);

				// Token: 0x04000418 RID: 1048
				public static readonly Vectors.Vec4.Vector4 UnitY = new Vectors.Vec4.Vector4(0f, 1f, 0f, 0f);

				// Token: 0x04000419 RID: 1049
				public static readonly Vectors.Vec4.Vector4 UnitZ = new Vectors.Vec4.Vector4(0f, 0f, 1f, 0f);

				// Token: 0x0400041A RID: 1050
				public static readonly Vectors.Vec4.Vector4 UnitW = new Vectors.Vec4.Vector4(0f, 0f, 0f, 1f);

				// Token: 0x0400041B RID: 1051
				public static readonly Vectors.Vec4.Vector4 One = new Vectors.Vec4.Vector4(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x020000A4 RID: 164
		public class View
		{
			// Token: 0x020000A5 RID: 165
			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			public struct Matrix
			{
				// Token: 0x060003CC RID: 972 RVA: 0x00024450 File Offset: 0x00024450
				public Matrix(float value)
				{
					this.M11 = value;
					this.M12 = value;
					this.M13 = value;
					this.M14 = value;
					this.M21 = value;
					this.M22 = value;
					this.M23 = value;
					this.M24 = value;
					this.M31 = value;
					this.M32 = value;
					this.M33 = value;
					this.M34 = value;
					this.M41 = value;
					this.M42 = value;
					this.M43 = value;
					this.M44 = value;
				}

				// Token: 0x060003CD RID: 973 RVA: 0x000244D0 File Offset: 0x000244D0
				public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
				{
					this.M11 = m11;
					this.M12 = m12;
					this.M13 = m13;
					this.M14 = m14;
					this.M21 = m21;
					this.M22 = m22;
					this.M23 = m23;
					this.M24 = m24;
					this.M31 = m31;
					this.M32 = m32;
					this.M33 = m33;
					this.M34 = m34;
					this.M41 = m41;
					this.M42 = m42;
					this.M43 = m43;
					this.M44 = m44;
				}

				// Token: 0x060003CE RID: 974 RVA: 0x0002455C File Offset: 0x0002455C
				public static Vectors.View.Matrix Transpose(Vectors.View.Matrix value)
				{
					return new Vectors.View.Matrix
					{
						M11 = value.M11,
						M12 = value.M21,
						M13 = value.M31,
						M14 = value.M41,
						M21 = value.M12,
						M22 = value.M22,
						M23 = value.M32,
						M24 = value.M42,
						M31 = value.M13,
						M32 = value.M23,
						M33 = value.M33,
						M34 = value.M43,
						M41 = value.M14,
						M42 = value.M24,
						M43 = value.M34,
						M44 = value.M44
					};
				}

				// Token: 0x060003CF RID: 975 RVA: 0x00024644 File Offset: 0x00024644
				public override string ToString()
				{
					return string.Format(CultureInfo.CurrentCulture, "M11:{0} M12:{1} M13:{2} M14:{3} M21:{4} M22:{5} M23:{6} M24:{7} M31:{8} M32:{9} M33:{10} M34:{11} M41:{12} M42:{13} M43:{14} M44:{15}", new object[]
					{
						this.M11,
						this.M12,
						this.M13,
						this.M14,
						this.M21,
						this.M22,
						this.M23,
						this.M24,
						this.M31,
						this.M32,
						this.M33,
						this.M34,
						this.M41,
						this.M42,
						this.M43,
						this.M44
					});
				}

				// Token: 0x0400041C RID: 1052
				public float M11;

				// Token: 0x0400041D RID: 1053
				public float M12;

				// Token: 0x0400041E RID: 1054
				public float M13;

				// Token: 0x0400041F RID: 1055
				public float M14;

				// Token: 0x04000420 RID: 1056
				public float M21;

				// Token: 0x04000421 RID: 1057
				public float M22;

				// Token: 0x04000422 RID: 1058
				public float M23;

				// Token: 0x04000423 RID: 1059
				public float M24;

				// Token: 0x04000424 RID: 1060
				public float M31;

				// Token: 0x04000425 RID: 1061
				public float M32;

				// Token: 0x04000426 RID: 1062
				public float M33;

				// Token: 0x04000427 RID: 1063
				public float M34;

				// Token: 0x04000428 RID: 1064
				public float M41;

				// Token: 0x04000429 RID: 1065
				public float M42;

				// Token: 0x0400042A RID: 1066
				public float M43;

				// Token: 0x0400042B RID: 1067
				public float M44;
			}
		}
	}
}
