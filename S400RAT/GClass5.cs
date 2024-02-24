using System;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public class GClass5
{
	public static int int_0;

	public static int int_1;

	public static int int_10;

	public static int int_11;

	public static int int_12;

	public static int int_13;

	public static int int_14;

	public static int int_15;

	public static int int_16;

	public static int int_17;

	public static int int_18;

	public static int int_19;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public string string_0;

	static GClass5()
	{
		int_0 = 1;
		int_1 = 7;
		int_10 = 11;
		int_11 = 12;
		int_12 = 21;
		int_13 = 22;
		int_14 = 23;
		int_15 = 24;
		int_16 = 30;
		int_17 = 31;
		int_18 = 32;
		int_19 = 33;
		int_2 = 3;
		int_3 = 6;
		int_4 = 2;
		int_5 = 5;
		int_6 = 4;
		int_7 = 8;
		int_8 = 9;
		int_9 = 10;
	}

	public GClass5(string string_1)
	{
		string_0 = string_1;
	}

	public int method_0()
	{
		if ((string_0 == null) | (Operators.CompareString(string_0, string.Empty, TextCompare: false) == 0))
		{
			return int_0;
		}
		return Convert.ToInt32(string_0.Substring(4, 3)) - 105;
	}

	public bool method_1()
	{
		return string_0.IndexOf("FREE") < 0;
	}

	public DateTime method_2()
	{
		int num = string_0.Length - 10;
		for (int i = 0; i <= num; i++)
		{
			if (char.IsWhiteSpace(string_0[i]))
			{
				string s = string_0.Substring(i + 1, 8);
				try
				{
					return DateTime.ParseExact(s, "yyyyMMdd", null);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					Console.Write(ex3.Message);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				break;
			}
		}
		return DateTime.Now;
	}

	public string method_3()
	{
		return string_0;
	}
}
