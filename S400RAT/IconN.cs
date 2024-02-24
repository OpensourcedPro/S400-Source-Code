using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace S400RAT;

public class IconN
{
	[SuppressUnmanagedCodeSecurity]
	public class Class10
	{
		[DllImport("kernel32")]
		public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, short short_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] byte_0, int int_0);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);
	}

	public struct Struct0
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;
	}

	public struct Struct1
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_0;

		public int int_1;
	}

	public struct Struct2
	{
		public uint uint_0;

		public int int_0;

		public int int_1;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_1;

		public uint uint_2;

		public int int_2;

		public int int_3;

		public uint euAqtutCrn;

		public uint uint_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Struct3
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_0;

		public ushort ushort_2;
	}

	public class Class11
	{
		public Struct0 struct0_0;

		public Struct1[] struct1_0;

		public byte[][] byte_0;

		[SpecialName]
		public int ohIqJiNdwI()
		{
			return struct0_0.ushort_2;
		}

		[SpecialName]
		public byte[] method_0(int int_0)
		{
			return byte_0[int_0];
		}

		public Class11()
		{
			struct0_0 = default(Struct0);
		}

		public static Class11 smethod_0(string string_0)
		{
			Class11 @class = new Class11();
			byte[] array = File.ReadAllBytes(string_0);
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			@class.struct0_0 = (Struct0)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Struct0));
			@class.struct1_0 = new Struct1[@class.struct0_0.ushort_2 - 1 + 1];
			@class.byte_0 = new byte[@class.struct0_0.ushort_2 - 1 + 1][];
			int num = Marshal.SizeOf(@class.struct0_0);
			Type typeFromHandle = typeof(Struct1);
			int num2 = Marshal.SizeOf(typeFromHandle);
			int num3 = @class.struct0_0.ushort_2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				Struct1 @struct = (Struct1)Marshal.PtrToStructure(new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + num), typeFromHandle);
				@class.struct1_0[i] = @struct;
				@class.byte_0[i] = new byte[@struct.int_0 - 1 + 1];
				Buffer.BlockCopy(array, @struct.int_1, @class.byte_0[i], 0, @struct.int_0);
				num += num2;
			}
			gCHandle.Free();
			return @class;
		}

		public byte[] method_1(uint uint_0)
		{
			int num = Marshal.SizeOf(typeof(Struct0)) + Marshal.SizeOf(typeof(Struct3)) * ohIqJiNdwI();
			byte[] array = new byte[num - 1 + 1];
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			Marshal.StructureToPtr(struct0_0, gCHandle.AddrOfPinnedObject(), fDeleteOld: false);
			int num2 = Marshal.SizeOf(struct0_0);
			int num3 = ohIqJiNdwI() - 1;
			for (int i = 0; i <= num3; i++)
			{
				Struct3 structure = default(Struct3);
				Struct2 @struct = default(Struct2);
				GCHandle gCHandle2 = GCHandle.Alloc(@struct, GCHandleType.Pinned);
				Marshal.Copy(method_0(i), 0, gCHandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(Struct2)));
				gCHandle2.Free();
				structure.byte_0 = struct1_0[i].byte_0;
				structure.byte_1 = struct1_0[i].byte_1;
				structure.byte_2 = struct1_0[i].byte_2;
				structure.byte_3 = struct1_0[i].byte_3;
				structure.ushort_0 = @struct.ushort_0;
				structure.ushort_1 = @struct.ushort_1;
				structure.int_0 = struct1_0[i].int_0;
				structure.ushort_2 = (ushort)(uint_0 + i);
				Marshal.StructureToPtr(structure, new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + num2), fDeleteOld: false);
				num2 += Marshal.SizeOf(typeof(Struct3));
			}
			gCHandle.Free();
			return array;
		}
	}

	public static void InjectIcon(string exeFileName, string iconFileName)
	{
		InjectIcon(exeFileName, iconFileName, 1u, 1u);
	}

	public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
	{
		Class11 @class = Class11.smethod_0(iconFileName);
		IntPtr intptr_ = Class10.BeginUpdateResource(exeFileName, bool_0: false);
		byte[] array = @class.method_1(iconBaseID);
		Class10.UpdateResource(intptr_, new IntPtr(14L), new IntPtr(iconGroupID), 0, array, array.Length);
		int num = @class.ohIqJiNdwI() - 1;
		for (int i = 0; i <= num; i++)
		{
			byte[] array2 = @class.method_0(i);
			Class10.UpdateResource(intptr_, new IntPtr(3L), new IntPtr(iconBaseID + i), 0, array2, array2.Length);
		}
		Class10.EndUpdateResource(intptr_, bool_0: false);
	}
}
