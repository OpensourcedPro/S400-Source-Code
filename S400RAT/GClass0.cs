using System;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public class GClass0
{
	public static string T1;

	public static string T2;

	public static string T3;

	public static string A;

	static GClass0()
	{
		A = null;
	}

	public static void Button_Click()
	{
		try
		{
			RAM();
			FC();
			B();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static void RAM()
	{
		try
		{
			string string_ = Environment.UserName;
			T1 = Strings.StrReverse(smethod_14(ref string_));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static void FC()
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_processor");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				A = Strings.Trim(item["processorId"].ToString());
			}
			T2 = Strings.StrReverse(smethod_14(ref A));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static void B()
	{
		try
		{
			string strDrive = "C:\\";
			string string_ = Conversions.ToString(Fransesco(ref strDrive));
			T3 = Strings.StrReverse(smethod_14(ref string_));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, short short_0, ref int int_0, ref int int_1, ref int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_3);

	public static int Fransesco(ref string strDrive)
	{
		string string_ = new string('\0', 255);
		string string_2 = new string('\0', 255);
		short short_ = (short)Strings.Len(string_);
		int int_ = 0;
		int int_2 = 0;
		int int_3 = default(int);
		GetVolumeInformationA(ref strDrive, ref string_, short_, ref int_3, ref int_, ref int_2, ref string_2, Strings.Len(string_2));
		return int_3;
	}

	public static string smethod_14(ref string string_0)
	{
		string result = default(string);
		try
		{
			string text = string_0;
			char[] array = text.ToCharArray();
			int num = array[0];
			string text2 = $"{num:X}";
			string text3 = text2;
			int num2 = array.Count() - 1;
			for (int i = 1; i <= num2; i++)
			{
				num = array[i];
				text2 = $"{num:X}";
				text3 += text2;
			}
			result = text3;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
