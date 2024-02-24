using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class38
{
	public delegate void Delegate10(object o);

	internal class Attribute0 : Attribute
	{
		internal class Class39<T>
		{
			internal static object object_0;

			internal static bool smethod_0()
			{
				return object_0 == null;
			}

			internal static object smethod_1()
			{
				return object_0;
			}
		}

		public Attribute0(object object_0)
		{
		}
	}

	internal class Class42
	{
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate11(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr Delegate12();

	internal struct Struct6
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	internal class Class43
	{
		public BinaryReader binaryReader_0;

		public Class43(Stream stream_0)
		{
			binaryReader_0 = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream method_0()
		{
			return binaryReader_0.BaseStream;
		}

		internal byte[] method_1(int int_0)
		{
			return binaryReader_0.ReadBytes(int_0);
		}

		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return binaryReader_0.Read(byte_0, int_0, int_1);
		}

		internal int method_3()
		{
			return binaryReader_0.ReadInt32();
		}

		internal void method_4()
		{
			binaryReader_0.Close();
		}
	}

	[UnmanagedFunctionPointer(/*Could not decode attribute arguments.*/)]
	public delegate IntPtr Delegate13(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr Delegate14(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate15(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate16(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr Delegate17(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate18(IntPtr ptr);

	[Flags]
	public enum Enum5
	{

	}

	internal static object object_0;

	public static string[] string_0;

	public static int[] int_0;

	public static int int_1;

	public static bool bool_0;

	public static bool bool_1;

	public static Delegate13 delegate13_0;

	public static long long_0;

	public static IntPtr intptr_0;

	public static int int_2;

	public static byte[] byte_0;

	public static object object_1;

	public static bool bool_2;

	public static bool bool_3;

	internal static Assembly assembly_0;

	public static Delegate16 delegate16_0;

	public static string string_1;

	public static bool bool_4;

	public static long long_1;

	internal static Hashtable hashtable_0;

	public static Dictionary<int, int> dictionary_0;

	public static List<string> list_0;

	public static int int_3;

	public static List<int> bYhzyHsudl;

	public static int int_4;

	public static Delegate15 delegate15_0;

	internal static Delegate11 delegate11_0;

	public static Delegate17 delegate17_0;

	public static uint[] uint_0;

	[Attribute0(typeof(Attribute0.Class39<Object>[]))]
	public static bool bool_5;

	public static SortedList sortedList_0;

	public static Delegate14 delegate14_0;

	public static bool bool_6;

	internal static Delegate11 delegate11_1;

	public static int int_5;

	public static IntPtr intptr_1;

	public static IntPtr intptr_2;

	public static byte[] byte_1;

	public static IntPtr intptr_3;

	public static Delegate18 delegate18_0;

	static Class38()
	{
		bool_4 = false;
		assembly_0 = typeof(Class38).Assembly;
		uint_0 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_2 = false;
		bool_3 = false;
		object_0 = null;
		dictionary_0 = null;
		object_1 = new object();
		int_3 = 0;
		list_0 = null;
		bYhzyHsudl = null;
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_2 = IntPtr.Zero;
		string_0 = new string[0];
		int_0 = new int[0];
		int_2 = 1;
		bool_6 = false;
		sortedList_0 = new SortedList();
		int_4 = 0;
		long_1 = 0L;
		delegate11_0 = null;
		delegate11_1 = null;
		long_0 = 0L;
		int_1 = 0;
		bool_0 = false;
		bool_1 = false;
		int_5 = 0;
		intptr_3 = IntPtr.Zero;
		bool_5 = false;
		hashtable_0 = new Hashtable();
		delegate13_0 = null;
		delegate14_0 = null;
		delegate15_0 = null;
		delegate16_0 = null;
		delegate17_0 = null;
		delegate18_0 = null;
		intptr_1 = IntPtr.Zero;
		string_1 = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	public void method_0()
	{
	}

	internal static byte[] smethod_0(object object_2)
	{
		uint[] array = new uint[16];
		int num = 448 - ((Array)object_2).Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(((Array)object_2).Length + num2 / 8 + 8L);
		ulong num4 = (ulong)(((Array)object_2).Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < ((Array)object_2).Length; i++)
		{
			array2[i] = ((byte[])object_2)[i];
		}
		array2[((Array)object_2).Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFuL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	public static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + ((uint[])object_2)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	public static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + ((uint[])object_2)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	public static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + ((uint[])object_2)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	public static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + ((uint[])object_2)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	public static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool smethod_6()
	{
		if (!bool_2)
		{
			smethod_8();
			bool_2 = true;
		}
		return bool_3;
	}

	internal Class38()
	{
	}

	public void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((byte_2[num7 + 3] << 24) | (byte_2[num7 + 2] << 16) | (byte_2[num7 + 1] << 8) | byte_2[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((byte_4[num7 + 3] << 24) | (byte_4[num7 + 2] << 16) | (byte_4[num7 + 1] << 8) | byte_4[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = num12;
			uint num14 = num12;
			num14 ^= num14 << 2;
			num14 += 285605539;
			num14 ^= num14 >> 15;
			num14 += 602128347;
			num14 ^= num14 << 25;
			num14 += 1095690210;
			num14 = 2387129222u - num14;
			num12 = num13 + (uint)(double)num14;
			num4 = num12;
			if (i == num2 - 1 && num > 0)
			{
				uint num15 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num15 & num10) >> num11);
				}
			}
			else
			{
				uint num16 = num4 ^ num6;
				array[num9] = (byte)(num16 & 0xFFu);
				array[num9 + 1] = (byte)((num16 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num16 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
			}
		}
		byte_0 = array;
	}

	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_6())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void smethod_8()
	{
		try
		{
			bool_3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return smethod_0(byte_2);
	}

	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 != 0)
		{
			int num = ((uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1));
			stream_0.Read(byte_2, 0, num);
			smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	internal static uint SxsHnbyixS(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_6)
			{
				binaryReader_0.BaseStream.Position = long_2 + (num * 40 + 8);
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				num4 = binaryReader_0.ReadUInt32();
				if (num3 <= uint_1 && uint_1 < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		return num4 + uint_1 - num3;
	}

	public static void smethod_12(object object_2, int int_6)
	{
		Class12.smethod_2(0, new object[2] { object_2, int_6 }, null);
	}

	internal static string smethod_13(string string_2)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_2);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint smethod_14(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr ptr = intptr_6;
		if (bool_4)
		{
			ptr = intptr_5;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = hashtable_0[num];
		if (obj != null)
		{
			Struct6 @struct = (Struct6)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
			Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
			if (@struct.bool_0)
			{
				intptr_7 = intPtr;
				uint_2 = (uint)@struct.byte_0.Length;
				smethod_23(intptr_7, @struct.byte_0.Length, 64, ref int_5);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
			uint result = 0u;
			if (uint_1 == 216669565 && !bool_5)
			{
				bool_5 = true;
			}
			else
			{
				result = delegate11_0(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
			}
			return result;
		}
		return delegate11_0(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
	}

	public static int smethod_15()
	{
		return 5;
	}

	public static void smethod_16()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	public static Delegate smethod_17(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { intptr_4, type_0 });
	}

	internal unsafe static void smethod_18()
	{
		if (bool_6)
		{
			return;
		}
		bool_6 = true;
		long num = 0L;
		Marshal.ReadIntPtr(new IntPtr(&num), 0);
		Marshal.ReadInt32(new IntPtr(&num), 0);
		Marshal.ReadInt64(new IntPtr(&num), 0);
		Marshal.WriteIntPtr(new IntPtr(&num), 0, IntPtr.Zero);
		Marshal.WriteInt32(new IntPtr(&num), 0, 0);
		Marshal.WriteInt64(new IntPtr(&num), 0, 0L);
		byte[] source = new byte[1];
		Marshal.Copy(source, 0, Marshal.AllocCoTaskMem(8), 1);
		smethod_16();
		if (!(smethod_20(Process.GetCurrentProcess().MainModule.BaseAddress, "__", 10u) != IntPtr.Zero))
		{
			return;
		}
		if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", throwOnError: false) != null)
		{
			ProcessModuleCollection modules = Process.GetCurrentProcess().Modules;
			foreach (ProcessModule item in modules)
			{
				if (item.ModuleName.ToLower() == "clrjit.dll")
				{
					Version version = new Version(item.FileVersionInfo.ProductMajorPart, item.FileVersionInfo.ProductMinorPart, item.FileVersionInfo.ProductBuildPart, item.FileVersionInfo.ProductpublicPart);
					Version version2 = new Version(4, 0, 30319, 17020);
					Version version3 = new Version(4, 0, 30319, 17921);
					if (version >= version2 && version < version3)
					{
						bool_4 = true;
						break;
					}
				}
			}
		}
		Class43 @class = new Class43(assembly_0.GetManifestResourceStream("7DVZgRydZBumnw3qIc.KRM1rHUruRC5jlw7GJ"));
		@class.method_0().Position = 0L;
		byte[] array = @class.method_1((int)@class.method_0().Length);
		byte[] array2 = new byte[32];
		array2[0] = 67;
		array2[0] = 160;
		array2[0] = 183;
		array2[1] = 92;
		array2[1] = 205;
		array2[1] = 166;
		array2[1] = 30;
		array2[2] = 156;
		array2[2] = 42;
		array2[2] = 78;
		array2[2] = 123;
		array2[2] = 75;
		array2[2] = 196;
		array2[3] = 135;
		array2[3] = 168;
		array2[3] = 203;
		array2[4] = 120;
		array2[4] = 104;
		array2[4] = 62;
		array2[4] = 18;
		array2[5] = 125;
		array2[5] = 162;
		array2[5] = 94;
		array2[5] = 170;
		array2[6] = 86;
		array2[6] = 182;
		array2[6] = 114;
		array2[6] = 56;
		array2[6] = 246;
		array2[7] = 86;
		array2[7] = 142;
		array2[7] = 167;
		array2[7] = 120;
		array2[7] = 189;
		array2[8] = 168;
		array2[8] = 208;
		array2[8] = 150;
		array2[8] = 251;
		array2[9] = 119;
		array2[9] = 83;
		array2[9] = 152;
		array2[9] = 87;
		array2[9] = 171;
		array2[10] = 58;
		array2[10] = 110;
		array2[10] = 194;
		array2[10] = 99;
		array2[10] = 229;
		array2[11] = 101;
		array2[11] = 66;
		array2[11] = 152;
		array2[12] = 107;
		array2[12] = 109;
		array2[12] = 94;
		array2[12] = 149;
		array2[12] = 168;
		array2[12] = 200;
		array2[13] = 179;
		array2[13] = 76;
		array2[13] = 142;
		array2[13] = 174;
		array2[14] = 43;
		array2[14] = 158;
		array2[14] = 77;
		array2[14] = 188;
		array2[14] = 56;
		array2[15] = 96;
		array2[15] = 125;
		array2[15] = 116;
		array2[15] = 112;
		array2[15] = 60;
		array2[16] = 101;
		array2[16] = 145;
		array2[16] = 96;
		array2[16] = 160;
		array2[17] = 59;
		array2[17] = 65;
		array2[17] = 160;
		array2[17] = 57;
		array2[17] = 62;
		array2[18] = 139;
		array2[18] = 140;
		array2[18] = 106;
		array2[18] = 213;
		array2[19] = 161;
		array2[19] = 86;
		array2[19] = 146;
		array2[19] = 238;
		array2[19] = 161;
		array2[19] = 189;
		array2[20] = 132;
		array2[20] = 136;
		array2[20] = 222;
		array2[21] = 220;
		array2[21] = 106;
		array2[21] = 106;
		array2[21] = 106;
		array2[21] = 225;
		array2[22] = 98;
		array2[22] = 115;
		array2[22] = 138;
		array2[22] = 121;
		array2[23] = 89;
		array2[23] = 74;
		array2[23] = 145;
		array2[23] = 122;
		array2[23] = 75;
		array2[23] = 254;
		array2[24] = 98;
		array2[24] = 98;
		array2[24] = 103;
		array2[24] = 172;
		array2[24] = 150;
		array2[24] = 137;
		array2[25] = 203;
		array2[25] = 60;
		array2[25] = 89;
		array2[25] = 199;
		array2[25] = 139;
		array2[25] = 209;
		array2[26] = 62;
		array2[26] = 131;
		array2[26] = 156;
		array2[26] = 102;
		array2[27] = 74;
		array2[27] = 42;
		array2[27] = 166;
		array2[28] = 149;
		array2[28] = 168;
		array2[28] = 110;
		array2[28] = 129;
		array2[28] = 142;
		array2[28] = 226;
		array2[29] = 139;
		array2[29] = 14;
		array2[29] = 110;
		array2[29] = 92;
		array2[29] = 160;
		array2[30] = 86;
		array2[30] = 130;
		array2[30] = 161;
		array2[30] = 84;
		array2[31] = 93;
		array2[31] = 152;
		array2[31] = 97;
		array2[31] = 138;
		byte[] array3 = array2;
		byte[] array4 = new byte[16];
		array4[0] = 113;
		array4[0] = 100;
		array4[0] = 148;
		array4[0] = 197;
		array4[0] = 160;
		array4[0] = 21;
		array4[1] = 109;
		array4[1] = 143;
		array4[1] = 130;
		array4[1] = 53;
		array4[1] = 133;
		array4[1] = 202;
		array4[2] = 104;
		array4[2] = 108;
		array4[2] = 147;
		array4[2] = 103;
		array4[2] = 176;
		array4[2] = 171;
		array4[3] = 107;
		array4[3] = 126;
		array4[3] = 144;
		array4[3] = 141;
		array4[3] = 85;
		array4[4] = 85;
		array4[4] = 80;
		array4[4] = 42;
		array4[4] = 8;
		array4[5] = 115;
		array4[5] = 62;
		array4[5] = 147;
		array4[5] = 130;
		array4[5] = 12;
		array4[6] = 122;
		array4[6] = 214;
		array4[6] = 73;
		array4[7] = 109;
		array4[7] = 101;
		array4[7] = 218;
		array4[8] = 143;
		array4[8] = 96;
		array4[8] = 154;
		array4[8] = 216;
		array4[9] = 149;
		array4[9] = 132;
		array4[9] = 89;
		array4[9] = 103;
		array4[9] = 111;
		array4[10] = 199;
		array4[10] = 157;
		array4[10] = 135;
		array4[10] = 86;
		array4[10] = 72;
		array4[10] = 233;
		array4[11] = 92;
		array4[11] = 140;
		array4[11] = 137;
		array4[12] = 110;
		array4[12] = 83;
		array4[12] = 32;
		array4[13] = 85;
		array4[13] = 101;
		array4[13] = 70;
		array4[14] = 75;
		array4[14] = 64;
		array4[14] = 136;
		array4[14] = 152;
		array4[14] = 131;
		array4[14] = 201;
		array4[15] = 110;
		array4[15] = 119;
		array4[15] = 165;
		array4[15] = 176;
		array4[15] = 11;
		byte[] array5 = array4;
		Array.Reverse(array5);
		byte[] publicKeyToken = assembly_0.GetName().GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken.Length > 0)
		{
			array5[1] = publicKeyToken[0];
			array5[3] = publicKeyToken[1];
			array5[5] = publicKeyToken[2];
			array5[7] = publicKeyToken[3];
			array5[9] = publicKeyToken[4];
			array5[11] = publicKeyToken[5];
			array5[13] = publicKeyToken[6];
			array5[15] = publicKeyToken[7];
			Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
		}
		for (int i = 0; i < array5.Length; i++)
		{
			array3[i] ^= array5[i];
		}
		byte[] array6 = array;
		int num2 = array6.Length % 4;
		int num3 = array6.Length / 4;
		byte[] array7 = new byte[array6.Length];
		int num4 = array3.Length / 4;
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		if (num2 > 0)
		{
			num3++;
		}
		uint num8 = 0u;
		for (int j = 0; j < num3; j++)
		{
			int num9 = j % num4;
			int num10 = j * 4;
			num8 = (uint)(num9 * 4);
			num6 = (uint)((array3[num8 + 3] << 24) | (array3[num8 + 2] << 16) | (array3[num8 + 1] << 8) | array3[num8]);
			uint num11 = 255u;
			int num12 = 0;
			if (j == num3 - 1 && num2 > 0)
			{
				num5 += num6;
				num7 = 0u;
				for (int k = 0; k < num2; k++)
				{
					if (k > 0)
					{
						num7 <<= 8;
					}
					num7 |= array6[array6.Length - (1 + k)];
				}
			}
			else
			{
				num8 = (uint)num10;
				num5 += num6;
				num7 = (uint)((array6[num8 + 3] << 24) | (array6[num8 + 2] << 16) | (array6[num8 + 1] << 8) | array6[num8]);
			}
			num5 = num5;
			uint num13 = num5;
			uint num14 = num5;
			num14 ^= num14 << 2;
			num14 += 285605539;
			num14 ^= num14 >> 15;
			num14 += 602128347;
			num14 ^= num14 << 25;
			num14 += 1095690210;
			num14 = 2387129222u - num14;
			num5 = num13 + (uint)(double)num14;
			if (j == num3 - 1 && num2 > 0)
			{
				uint num15 = num5 ^ num7;
				for (int l = 0; l < num2; l++)
				{
					if (l > 0)
					{
						num11 <<= 8;
						num12 += 8;
					}
					array7[num10 + l] = (byte)((num15 & num11) >> num12);
				}
			}
			else
			{
				uint num16 = num5 ^ num7;
				array7[num10] = (byte)(num16 & 0xFFu);
				array7[num10 + 1] = (byte)((num16 & 0xFF00) >> 8);
				array7[num10 + 2] = (byte)((num16 & 0xFF0000) >> 16);
				array7[num10 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
			}
		}
		byte[] array8 = array7;
		int num17 = array8.Length / 8;
		fixed (byte* ptr = array8)
		{
			for (int m = 0; m < num17; m++)
			{
				*(long*)(ptr + (nint)m * (nint)8) ^= 1852754431L;
			}
		}
		@class = new Class43(new MemoryStream(array8));
		@class.method_0().Position = 0L;
		long num18 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt64();
		int int_ = 0;
		int num19 = 0;
		if (assembly_0.Location == null || assembly_0.Location.Length == 0)
		{
			num19 = 7680;
		}
		@class.method_3();
		@class.method_3();
		int num20 = @class.method_3();
		int num21 = @class.method_3();
		if (num21 == 4)
		{
			SymmetricAlgorithm symmetricAlgorithm = smethod_7();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
			Array.Clear(array3, 0, array3.Length);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			array8 = memoryStream.ToArray();
			Array.Clear(array5, 0, array5.Length);
			memoryStream.Close();
			cryptoStream.Close();
			@class.method_4();
			num20 = @class.method_3();
			num21 = @class.method_3();
		}
		if (num21 == 1)
		{
			IntPtr zero = IntPtr.Zero;
			zero = smethod_24(56u, 1, (uint)Process.GetCurrentProcess().Id);
			if (IntPtr.Size == 4)
			{
				int_4 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt32();
			}
			long_1 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt64();
			IntPtr intptr_ = IntPtr.Zero;
			for (int n = 0; n < num20; n++)
			{
				IntPtr intPtr = new IntPtr(long_1 + @class.method_3() - num19);
				if (smethod_23(intPtr, 4, 4, ref int_) == 0)
				{
					smethod_23(intPtr, 4, 8, ref int_);
				}
				if (IntPtr.Size == 4)
				{
					smethod_22(zero, intPtr, BitConverter.GetBytes(@class.method_3()), 4u, out intptr_);
				}
				else
				{
					smethod_22(zero, intPtr, BitConverter.GetBytes(@class.method_3()), 4u, out intptr_);
				}
				smethod_23(intPtr, 4, int_, ref int_);
			}
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				int num22 = @class.method_3();
				IntPtr intptr_2 = new IntPtr(long_1 + num22 - num19);
				int num23 = @class.method_3();
				if (smethod_23(intptr_2, num23 * 4, 4, ref int_) == 0)
				{
					smethod_23(intptr_2, num23 * 4, 8, ref int_);
				}
				for (int num24 = 0; num24 < num23; num24++)
				{
					Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + num24 * 4), @class.method_3());
				}
				smethod_23(intptr_2, num23 * 4, int_, ref int_);
			}
			smethod_25(zero);
			return;
		}
		for (int num25 = 0; num25 < num20; num25++)
		{
			IntPtr intPtr2 = new IntPtr(num18 + @class.method_3() - num19);
			if (smethod_23(intPtr2, 4, 4, ref int_) == 0)
			{
				smethod_23(intPtr2, 4, 8, ref int_);
			}
			Marshal.WriteInt32(intPtr2, @class.method_3());
			smethod_23(intPtr2, 4, int_, ref int_);
		}
		hashtable_0 = new Hashtable(@class.method_3() + 1);
		Struct6 @struct = default(Struct6);
		@struct.byte_0 = new byte[1] { 42 };
		@struct.bool_0 = false;
		hashtable_0.Add(0L, @struct);
		bool flag = false;
		while (@class.method_0().Position < @class.method_0().Length - 1L)
		{
			int num26 = @class.method_3() - num19;
			int num27 = @class.method_3();
			flag = false;
			if (num27 >= 1879048192)
			{
				flag = true;
			}
			int num28 = @class.method_3();
			byte[] array9 = @class.method_1(num28);
			Struct6 struct2 = default(Struct6);
			struct2.byte_0 = array9;
			struct2.bool_0 = flag;
			hashtable_0.Add(num18 + num26, struct2);
		}
		long_0 = Marshal.GetHINSTANCE(typeof(Class38).Assembly.GetModules()[0]).ToInt64();
		if (IntPtr.Size == 4)
		{
			int_1 = Convert.ToInt32(long_0);
		}
		byte[] bytes = new byte[12]
		{
			109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
			108, 108
		};
		string @string = Encoding.UTF8.GetString(bytes);
		IntPtr intPtr3 = LoadLibrary(@string);
		if (intPtr3 == IntPtr.Zero)
		{
			bytes = new byte[10] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
			@string = Encoding.UTF8.GetString(bytes);
			intPtr3 = LoadLibrary(@string);
		}
		byte[] bytes2 = new byte[6] { 103, 101, 116, 74, 105, 116 };
		string string2 = Encoding.UTF8.GetString(bytes2);
		IntPtr procAddress = GetProcAddress(intPtr3, string2);
		Delegate12 @delegate = (Delegate12)smethod_17(procAddress, typeof(Delegate12));
		IntPtr ptr2 = @delegate();
		long num29 = 0L;
		num29 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr2) : Marshal.ReadInt32(ptr2));
		Marshal.ReadIntPtr(ptr2, 0);
		delegate11_1 = smethod_14;
		IntPtr zero2 = IntPtr.Zero;
		zero2 = Marshal.GetFunctionPointerForDelegate((Delegate)delegate11_1);
		long num30 = 0L;
		num30 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(new IntPtr(num29)) : Marshal.ReadInt32(new IntPtr(num29)));
		Process currentProcess = Process.GetCurrentProcess();
		try
		{
			ProcessModuleCollection modules2 = currentProcess.Modules;
			foreach (ProcessModule item2 in modules2)
			{
				if (item2.ModuleName == @string && (num30 < item2.BaseAddress.ToInt64() || num30 > item2.BaseAddress.ToInt64() + item2.ModuleMemorySize) && typeof(Class38).Assembly.EntryPoint != null)
				{
					return;
				}
			}
		}
		catch
		{
		}
		try
		{
			ProcessModuleCollection modules3 = currentProcess.Modules;
			foreach (ProcessModule item3 in modules3)
			{
				if (item3.BaseAddress.ToInt64() == long_0)
				{
					num19 = 0;
					break;
				}
			}
		}
		catch
		{
		}
		delegate11_0 = null;
		try
		{
			delegate11_0 = (Delegate11)smethod_17(new IntPtr(num30), typeof(Delegate11));
		}
		catch
		{
			try
			{
				Delegate delegate2 = smethod_17(new IntPtr(num30), typeof(Delegate11));
				delegate11_0 = (Delegate11)Delegate.CreateDelegate(typeof(Delegate11), delegate2.Method);
			}
			catch
			{
			}
		}
		int int_2 = 0;
		if (typeof(Class38).Assembly.EntryPoint != null && typeof(Class38).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class38).Assembly.Location != null && typeof(Class38).Assembly.Location.Length > 0)
		{
			return;
		}
		try
		{
			object value = typeof(Class38).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class38).Assembly.ManifestModule.ModuleHandle);
			if (value is IntPtr)
			{
				intptr_3 = (IntPtr)value;
			}
			if (value.GetType().ToString() == "System.Reflection.RuntimeModule")
			{
				intptr_3 = (IntPtr)value.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value);
			}
			MemoryStream memoryStream2 = new MemoryStream();
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			if (IntPtr.Size == 4)
			{
				memoryStream2.Write(BitConverter.GetBytes(intptr_3.ToInt32()), 0, 4);
			}
			else
			{
				memoryStream2.Write(BitConverter.GetBytes(intptr_3.ToInt64()), 0, 8);
			}
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			memoryStream2.Position = 0L;
			byte[] array10 = memoryStream2.ToArray();
			memoryStream2.Close();
			uint nativeSizeOfCode = 0u;
			fixed (byte* value2 = array10)
			{
				delegate11_1(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
			}
		}
		catch
		{
		}
		RuntimeHelpers.PrepareDelegate(delegate11_0);
		RuntimeHelpers.PrepareMethod(delegate11_0.Method.MethodHandle);
		RuntimeHelpers.PrepareDelegate(delegate11_1);
		RuntimeHelpers.PrepareMethod(delegate11_1.Method.MethodHandle);
		byte[] array11 = null;
		array11 = ((IntPtr.Size == 4) ? new byte[30]
		{
			85, 139, 236, 139, 69, 16, 129, 120, 4, 125,
			29, 234, 12, 116, 7, 184, 182, 177, 74, 6,
			235, 5, 184, 182, 146, 64, 12, 93, 255, 224
		} : new byte[40]
		{
			72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
			73, 57, 64, 8, 116, 12, 72, 184, 0, 0,
			0, 0, 0, 0, 0, 0, 255, 224, 72, 184,
			0, 0, 0, 0, 0, 0, 0, 0, 255, 224
		});
		IntPtr intPtr4 = smethod_21(IntPtr.Zero, (uint)array11.Length, 4096u, 64u);
		byte[] array12 = array11;
		byte[] array13 = null;
		byte[] array14 = null;
		byte[] array15 = null;
		if (IntPtr.Size == 4)
		{
			array15 = BitConverter.GetBytes(intptr_3.ToInt32());
			array13 = BitConverter.GetBytes(zero2.ToInt32());
			array14 = BitConverter.GetBytes(Convert.ToInt32(num30));
		}
		else
		{
			array15 = BitConverter.GetBytes(intptr_3.ToInt64());
			array13 = BitConverter.GetBytes(zero2.ToInt64());
			array14 = BitConverter.GetBytes(num30);
		}
		if (IntPtr.Size == 4)
		{
			array12[9] = array15[0];
			array12[10] = array15[1];
			array12[11] = array15[2];
			array12[12] = array15[3];
			array12[16] = array14[0];
			array12[17] = array14[1];
			array12[18] = array14[2];
			array12[19] = array14[3];
			array12[23] = array13[0];
			array12[24] = array13[1];
			array12[25] = array13[2];
			array12[26] = array13[3];
		}
		else
		{
			array12[2] = array15[0];
			array12[3] = array15[1];
			array12[4] = array15[2];
			array12[5] = array15[3];
			array12[6] = array15[4];
			array12[7] = array15[5];
			array12[8] = array15[6];
			array12[9] = array15[7];
			array12[18] = array14[0];
			array12[19] = array14[1];
			array12[20] = array14[2];
			array12[21] = array14[3];
			array12[22] = array14[4];
			array12[23] = array14[5];
			array12[24] = array14[6];
			array12[25] = array14[7];
			array12[30] = array13[0];
			array12[31] = array13[1];
			array12[32] = array13[2];
			array12[33] = array13[3];
			array12[34] = array13[4];
			array12[35] = array13[5];
			array12[36] = array13[6];
			array12[37] = array13[7];
		}
		Marshal.Copy(array12, 0, intPtr4, array12.Length);
		bool_0 = false;
		smethod_23(new IntPtr(num29), IntPtr.Size, 64, ref int_2);
		Marshal.WriteIntPtr(new IntPtr(num29), intPtr4);
		smethod_23(new IntPtr(num29), IntPtr.Size, int_2, ref int_2);
	}

	internal static object smethod_19(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(assembly_1.Location))
			{
				return assembly_1.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return assembly_1.GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_2);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_2);

	public static IntPtr smethod_20(IntPtr intptr_4, string string_2, uint uint_1)
	{
		if (delegate13_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Find ".Trim() + "ResourceA");
			delegate13_0 = (Delegate13)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate13));
		}
		return delegate13_0(intptr_4, string_2, uint_1);
	}

	public static IntPtr smethod_21(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (delegate14_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Virtual ".Trim() + "Alloc");
			delegate14_0 = (Delegate14)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate14));
		}
		return delegate14_0(intptr_4, uint_1, uint_2, uint_3);
	}

	public static int smethod_22(IntPtr intptr_4, IntPtr intptr_5, [In][Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (delegate15_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Write ".Trim() + "Process ".Trim() + "Memory");
			delegate15_0 = (Delegate15)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate15));
		}
		return delegate15_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	public static int smethod_23(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (delegate16_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Virtual ".Trim() + "Protect");
			delegate16_0 = (Delegate16)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate16));
		}
		return delegate16_0(intptr_4, int_6, int_7, ref int_8);
	}

	public static IntPtr smethod_24(uint uint_1, int int_6, uint uint_2)
	{
		if (delegate17_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Open ".Trim() + "Process");
			delegate17_0 = (Delegate17)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate17));
		}
		return delegate17_0(uint_1, int_6, uint_2);
	}

	public static int smethod_25(IntPtr intptr_4)
	{
		if (delegate18_0 == null)
		{
			IntPtr procAddress = GetProcAddress(smethod_26(), "Close ".Trim() + "Handle");
			delegate18_0 = (Delegate18)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate18));
		}
		return delegate18_0(intptr_4);
	}

	[SpecialName]
	public static IntPtr smethod_26()
	{
		if (intptr_1 == IntPtr.Zero)
		{
			intptr_1 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return intptr_1;
	}

	public static byte[] smethod_27(string string_2)
	{
		using FileStream fileStream = new FileStream(string_2, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static byte[] smethod_28(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	public static byte[] smethod_29(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = new byte[32]
		{
			111, 25, 132, 185, 171, 106, 203, 147, 181, 253,
			204, 149, 251, 9, 217, 113, 93, 119, 173, 138,
			79, 148, 47, 128, 58, 191, 95, 23, 75, 123,
			139, 185
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			236, 248, 204, 45, 242, 89, 218, 228, 254, 35,
			1, 87, 160, 63, 25, 136
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return smethod_28((MemoryStream)stream);
	}

	public unsafe static int smethod_30(object object_2)
	{
		fixed (char* ptr = object_2)
		{
			int num = 5381;
			int num2 = 5381;
			char* ptr2 = ptr;
			int num3;
			while ((num3 = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ num3;
				num3 = ptr2[1];
				if (num3 == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2) ^ num3;
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}
	}

	internal static bool smethod_31(string string_2, string string_3)
	{
		if (string_2 == string_3)
		{
			return true;
		}
		if (string_2 != null && string_3 != null)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			if (string_2.StartsWith(string_1))
			{
				flag = true;
				num = (int)(string_2[4] | ((uint)string_2[5] << 8) | ((uint)string_2[6] << 16) | ((uint)string_2[7] << 24));
			}
			if (string_3.StartsWith(string_1))
			{
				flag2 = true;
				num2 = (int)(string_3[4] | ((uint)string_3[5] << 8) | ((uint)string_3[6] << 16) | ((uint)string_3[7] << 24));
			}
			if (!flag && !flag2)
			{
				return false;
			}
			if (!flag)
			{
				num = smethod_30(string_2);
			}
			if (!flag2)
			{
				num2 = smethod_30(string_3);
			}
			return num == num2;
		}
		return false;
	}

	public byte[] method_2()
	{
		return null;
	}

	public byte[] RlwHoQynRV()
	{
		return null;
	}

	public byte[] method_3()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	public byte[] method_4()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	public byte[] method_5()
	{
		return null;
	}

	public byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_8()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_9()
	{
		return null;
	}

	internal byte[] method_10()
	{
		return null;
	}

	internal static object smethod_32(Class43 class43_0)
	{
		return class43_0.method_0();
	}

	internal static void smethod_33(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	internal static long smethod_34(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static object smethod_35(Class43 class43_0, int int_6)
	{
		return class43_0.method_1(int_6);
	}

	internal static void smethod_36(Class43 class43_0)
	{
		class43_0.method_4();
	}

	internal static void smethod_37(Array array_0)
	{
		Array.Reverse(array_0);
	}

	internal static object smethod_38(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	internal static object smethod_39(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	internal static object smethod_40()
	{
		return smethod_7();
	}

	internal static void smethod_41(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	internal static object smethod_42(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	internal static object smethod_43()
	{
		return new MemoryStream();
	}

	internal static void smethod_44(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	internal static void smethod_45(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	internal static object smethod_46(MemoryStream memoryStream_0)
	{
		return smethod_28(memoryStream_0);
	}

	internal static void smethod_47(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static bool smethod_48()
	{
		return (object)null == null;
	}

	internal static object smethod_49()
	{
		return null;
	}

	static int smethod_50()
	{
		return 1;
	}

	internal static IntPtr smethod_51(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadIntPtr(intptr_4, int_6);
	}

	internal static int smethod_52(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt32(intptr_4, int_6);
	}

	internal static long smethod_53(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt64(intptr_4, int_6);
	}

	internal static void smethod_54(IntPtr intptr_4, int int_6, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
	}

	internal static void smethod_55(IntPtr intptr_4, int int_6, int int_7)
	{
		Marshal.WriteInt32(intptr_4, int_6, int_7);
	}

	internal static void smethod_56(IntPtr intptr_4, int int_6, long long_2)
	{
		Marshal.WriteInt64(intptr_4, int_6, long_2);
	}

	internal static IntPtr smethod_57(int int_6)
	{
		return Marshal.AllocCoTaskMem(int_6);
	}

	internal static void smethod_58(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
	{
		Marshal.Copy(byte_2, int_6, intptr_4, int_7);
	}

	internal static void smethod_59()
	{
		smethod_16();
	}

	internal static object smethod_60()
	{
		return Process.GetCurrentProcess();
	}

	internal static object smethod_61(Process process_0)
	{
		return process_0.MainModule;
	}

	internal static IntPtr smethod_62(ProcessModule processModule_0)
	{
		return processModule_0.BaseAddress;
	}

	internal static IntPtr smethod_63(IntPtr intptr_4, string string_2, uint uint_1)
	{
		return smethod_20(intptr_4, string_2, uint_1);
	}

	internal static bool smethod_64(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	internal static int smethod_66()
	{
		return IntPtr.Size;
	}

	internal static Type smethod_67(string string_2, bool bool_7)
	{
		return Type.GetType(string_2, bool_7);
	}

	internal static bool smethod_68(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object smethod_69(Process process_0)
	{
		return process_0.Modules;
	}

	internal static object smethod_70(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	internal static object smethod_71(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static object smethod_72(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	internal static object smethod_73(string string_2)
	{
		return string_2.ToLower();
	}

	internal static bool smethod_74(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	internal static object smethod_75(ProcessModule processModule_0)
	{
		return processModule_0.FileVersionInfo;
	}

	internal static int smethod_76(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMajorPart;
	}

	internal static int smethod_77(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMinorPart;
	}

	internal static int smethod_78(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductBuildPart;
	}

	internal static int smethod_79(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductpublicPart;
	}

	internal static bool smethod_80(Version version_0, Version version_1)
	{
		return version_0 >= version_1;
	}

	internal static bool smethod_81(Version version_0, Version version_1)
	{
		return version_0 < version_1;
	}

	internal static bool smethod_82(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static void smethod_83(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static object smethod_84(Assembly assembly_1, string string_2)
	{
		return assembly_1.GetManifestResourceStream(string_2);
	}

	internal static object smethod_85(Class43 class43_0)
	{
		return class43_0.method_0();
	}

	internal static void smethod_86(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	internal static long smethod_87(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static object smethod_88(Class43 class43_0, int int_6)
	{
		return class43_0.method_1(int_6);
	}

	internal static void smethod_89(Array array_0)
	{
		Array.Reverse(array_0);
	}

	internal static object smethod_90(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	internal static object smethod_91(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	internal static void smethod_92(Array array_0, int int_6, int int_7)
	{
		Array.Clear(array_0, int_6, int_7);
	}

	internal static object smethod_93(Assembly assembly_1)
	{
		return assembly_1.GetModules();
	}

	internal static IntPtr smethod_94(Module module_0)
	{
		return Marshal.GetHINSTANCE(module_0);
	}

	internal static object smethod_95(Assembly assembly_1)
	{
		return assembly_1.Location;
	}

	internal static int smethod_96(string string_2)
	{
		return string_2.Length;
	}

	internal static int smethod_97(Class43 class43_0)
	{
		return class43_0.method_3();
	}

	internal static object smethod_98()
	{
		return smethod_7();
	}

	internal static void smethod_99(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	internal static object smethod_100(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	internal static void smethod_101(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	internal static void smethod_102(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	internal static object smethod_103(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static void smethod_104(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static void smethod_105(Class43 class43_0)
	{
		class43_0.method_4();
	}

	internal static int smethod_106(Process process_0)
	{
		return process_0.Id;
	}

	internal static IntPtr smethod_107(uint uint_1, int int_6, uint uint_2)
	{
		return smethod_24(uint_1, int_6, uint_2);
	}

	internal static object smethod_108(int int_6)
	{
		return BitConverter.GetBytes(int_6);
	}

	internal static long smethod_109(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static void smethod_110(IntPtr intptr_4, int int_6)
	{
		Marshal.WriteInt32(intptr_4, int_6);
	}

	internal static int smethod_111(IntPtr intptr_4)
	{
		return smethod_25(intptr_4);
	}

	internal static void smethod_112(Hashtable hashtable_1, object object_2, object object_3)
	{
		hashtable_1.Add(object_2, object_3);
	}

	internal static Type smethod_113(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_114(long long_2)
	{
		return Convert.ToInt32(long_2);
	}

	internal static object smethod_115()
	{
		return Encoding.UTF8;
	}

	internal static object smethod_116(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	internal static bool smethod_117(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	internal static object smethod_118(IntPtr intptr_4, Type type_0)
	{
		return smethod_17(intptr_4, type_0);
	}

	internal static IntPtr smethod_119(Delegate12 delegate12_0)
	{
		return delegate12_0();
	}

	internal static int smethod_120(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	internal static long smethod_121(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	internal static IntPtr smethod_122(Delegate delegate_0)
	{
		return Marshal.GetFunctionPointerForDelegate(delegate_0);
	}

	internal static int smethod_123(ProcessModule processModule_0)
	{
		return processModule_0.ModuleMemorySize;
	}

	internal static object smethod_124(Assembly assembly_1)
	{
		return assembly_1.EntryPoint;
	}

	internal static bool smethod_125(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 != methodInfo_1;
	}

	internal static object smethod_126(Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	internal static object smethod_127(Type type_0, MethodInfo methodInfo_0)
	{
		return Delegate.CreateDelegate(type_0, methodInfo_0);
	}

	internal static object smethod_128(MethodBase methodBase_0)
	{
		return methodBase_0.GetParameters();
	}

	internal static object smethod_129(Assembly assembly_1)
	{
		return assembly_1.ManifestModule;
	}

	internal static ModuleHandle smethod_130(Module module_0)
	{
		return module_0.ModuleHandle;
	}

	internal static Type smethod_131(object object_2)
	{
		return object_2.GetType();
	}

	internal static object smethod_132(FieldInfo fieldInfo_0, object object_2)
	{
		return fieldInfo_0.GetValue(object_2);
	}

	internal static object smethod_133(long long_2)
	{
		return BitConverter.GetBytes(long_2);
	}

	internal static void smethod_134(Delegate delegate_0)
	{
		RuntimeHelpers.PrepareDelegate(delegate_0);
	}

	internal static RuntimeMethodHandle smethod_135(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	internal static void smethod_136(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void smethod_137(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static IntPtr smethod_138(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		return smethod_21(intptr_4, uint_1, uint_2, uint_3);
	}

	internal static void smethod_139(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	internal static bool smethod_140()
	{
		return (object)null == null;
	}

	internal static object smethod_141()
	{
		return null;
	}
}
