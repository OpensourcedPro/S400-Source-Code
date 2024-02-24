using System;

namespace S400RAT;

public class GClass6
{
	public double double_0;

	public double double_1;

	public static double double_2;

	public static double double_3;

	public static double double_4;

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	static GClass6()
	{
		double_2 = 12756.4;
		double_3 = 3.14159265;
		double_4 = double_3 / 180.0;
	}

	public double method_0(GClass6 gclass6_0)
	{
		double num = double_0;
		double num2 = double_1;
		double num3 = gclass6_0.double_0;
		double num4 = gclass6_0.double_1;
		num *= double_4;
		num3 *= double_4;
		double num5 = num3 - num;
		double num6 = (num4 - num2) * double_4;
		double num7 = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0);
		return double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7));
	}
}
