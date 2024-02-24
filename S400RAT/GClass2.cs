using System;
using System.Runtime.InteropServices;
using System.Security;

namespace S400RAT;

[SuppressUnmanagedCodeSecurity]
public class GClass2
{
	[DllImport("kernel32")]
	public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UpdateResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, short short_0, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0, SizeParamIndex = 5)] byte[] byte_0, int int_0);
}
