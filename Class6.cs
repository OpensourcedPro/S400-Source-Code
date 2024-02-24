using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class Class6
{
	public static long long_0;

	static Class6()
	{
		long_0 = 0L;
	}

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr memcpy(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	public static string smethod_0(int int_0, int int_1)
	{
		if (int_1 == 0)
		{
			return "%00.0";
		}
		return (double.Parse(Conversions.ToString(int_0)) / double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100");
	}

	public static int smethod_1(int int_0, int int_1)
	{
		if (int_1 == 0)
		{
			return 0;
		}
		return (int)Math.Round((double)int_0 / (double)int_1 * 100.0);
	}

	public static Form smethod_2(string string_0)
	{
		return Class2.FEo51Ss0j.OpenForms[string_0];
	}

	public static byte[] smethod_3(ref string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public static string smethod_4(ref byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public static string smethod_5()
	{
		return Class2.GKfRhcGxM.Clock.LocalTime.ToString("hh:mm:ss");
	}

	public static string smethod_6()
	{
		return Class2.GKfRhcGxM.Clock.LocalTime.ToString("[hh:mm:ss]");
	}

	public static string smethod_7(ref string string_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
	}

	public static int smethod_8(int int_0, int int_1, bool bool_0)
	{
		long_0 = (long)Math.Round((double)long_0 + 333.33);
		Random random = new Random((int)long_0);
		return random.Next(int_0, int_1 + 1);
	}

	public static string smethod_9(string string_0)
	{
		int num = 0;
		string result;
		while (true)
		{
			try
			{
				byte[] bytes = Convert.FromBase64String(string_0);
				result = Encoding.UTF8.GetString(bytes);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				num++;
				if (num == 3)
				{
					ProjectData.ClearProjectError();
					result = null;
					ProjectData.ClearProjectError();
					break;
				}
				string_0 += "=";
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
		return result;
	}

	public static string smethod_10(long long_1)
	{
		if (long_1.ToString().Length < 4)
		{
			return Conversions.ToString(long_1) + " Bytes";
		}
		string empty = string.Empty;
		double num = (double)long_1 / 1024.0;
		if (!(num < 1024.0))
		{
			num /= 1024.0;
			if (num < 1024.0)
			{
				empty = "MB";
			}
			else
			{
				num /= 1024.0;
				empty = "GB";
			}
		}
		else
		{
			empty = "KB";
		}
		return num.ToString(".0") + " " + empty;
	}

	public static string smethod_11(string string_0, string string_1)
	{
		string result;
		try
		{
			result = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class2.GKfRhcGxM.Registry.CurrentUser.OpenSubKey("Software\\" + Class7.string_0).GetValue(string_0, string_1)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = string_1;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void jQbZimjGko(string string_0, object object_0)
	{
		if (object_0 == null)
		{
			object_0 = string.Empty;
		}
		try
		{
			Class2.GKfRhcGxM.Registry.CurrentUser.CreateSubKey("Software\\" + Class7.string_0).SetValue(string_0, object_0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static string smethod_12(object object_0)
	{
		return smethod_13(smethod_3(ref *(string*)(&object_0)));
	}

	public static string smethod_13(byte[] byte_0)
	{
		byte_0 = new MD5CryptoServiceProvider().ComputeHash(byte_0);
		string text = string.Empty;
		byte[] array = byte_0;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	public static string smethod_14(int int_0)
	{
		Random random = new Random();
		string text = string.Empty;
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 1; i <= int_0; i++)
		{
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}

	public static TreeNode smethod_15(string string_0, TreeNodeCollection treeNodeCollection_0)
	{
		if (string_0.EndsWith("\\"))
		{
			string_0 = string_0.Remove(string_0.Length - 1, 1);
		}
		TreeNode treeNode = null;
		string[] array = Strings.Split(string_0, "\\");
		foreach (string key in array)
		{
			treeNode = treeNodeCollection_0[key];
			treeNodeCollection_0 = treeNode.Nodes;
		}
		return treeNode;
	}

	public static byte[] smethod_16(byte[] byte_0, ref bool bool_0)
	{
		if (bool_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
			gZipStream.Write(byte_0, 0, byte_0.Length);
			gZipStream.Dispose();
			memoryStream.Position = 0L;
			byte[] array = new byte[(int)memoryStream.Length + 1 - 1 + 1];
			memoryStream.Read(array, 0, array.Length);
			memoryStream.Dispose();
			return array;
		}
		MemoryStream memoryStream2 = new MemoryStream(byte_0);
		GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
		byte[] array2 = new byte[4];
		memoryStream2.Position = memoryStream2.Length - 5L;
		memoryStream2.Read(array2, 0, 4);
		int num = BitConverter.ToInt32(array2, 0);
		memoryStream2.Position = 0L;
		byte[] array3 = new byte[num - 1 + 1 - 1 + 1];
		gZipStream2.Read(array3, 0, num);
		gZipStream2.Dispose();
		memoryStream2.Dispose();
		return array3;
	}

	public static Array smethod_17(byte[] byte_0, string string_0)
	{
		List<byte[]> list = new List<byte[]>();
		int num = -1;
		num = Array.IndexOf(byte_0, (byte)Strings.Asc(string_0[0]));
		while ((num > -1) & (num + string_0.Length <= byte_0.Length))
		{
			byte[] byte_ = new byte[string_0.Length - 1 + 1 - 1 + 1];
			int num2 = 0;
			int num3 = num + string_0.Length - 1;
			for (int i = num; i <= num3; i++)
			{
				byte_[num2] = byte_0[i];
				num2++;
			}
			if (Operators.CompareString(smethod_4(ref byte_), string_0, TextCompare: false) != 0)
			{
				num = Array.IndexOf(byte_0, (byte)Strings.Asc(string_0[0]), num + 1);
				continue;
			}
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, num);
			list.Add(memoryStream.ToArray());
			memoryStream.Dispose();
			memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length));
			list.Add(memoryStream.ToArray());
			memoryStream.Dispose();
			break;
		}
		if (list.Count == 0)
		{
			list.Add(byte_0);
		}
		return list.ToArray();
	}
}
