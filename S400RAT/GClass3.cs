using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public class GClass3
{
	public byte byte_0;

	public byte[] byte_1;

	public FileStream fileStream_0;

	public static GClass4 NbmvWlidHq;

	public GClass5 gclass5_0;

	public int[] int_0;

	public int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static int int_10;

	public static int int_11;

	public int int_12;

	public static int int_20;

	public static int int_21;

	public static int int_22;

	public static int int_23;

	public static int int_24;

	public static int int_25;

	public int int_13;

	public static int jbvvZxuncp;

	public static int int_14;

	public static int int_15;

	public static int int_16;

	public static int UqxveArheE;

	public static int int_17;

	public object object_0;

	public string string_0;

	public static string[] string_1;

	public static string[] string_2;

	static GClass3()
	{
		NbmvWlidHq = new GClass4("--", "N/A");
		int_2 = 3;
		int_3 = 4;
		int_4 = 4;
		int_5 = 1000;
		int_6 = 360;
		int_7 = 16700000;
		int_8 = 16000000;
		int_9 = 1;
		int_10 = 677;
		int_11 = 1353;
		int_20 = 0;
		int_21 = 1;
		int_22 = 0;
		int_23 = 1;
		int_24 = 2;
		int_25 = 3;
		jbvvZxuncp = 16776960;
		int_14 = 16700000;
		int_15 = 20;
		int_16 = 100;
		UqxveArheE = 100;
		int_17 = 3;
		string_1 = new string[256]
		{
			"--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM",
			"CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA",
			"BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN",
			"BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC",
			"CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO",
			"CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM",
			"DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI",
			"FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE",
			"GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS",
			"GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU",
			"ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM",
			"JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR",
			"KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS",
			"LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK",
			"ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU",
			"MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG",
			"NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE",
			"PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT",
			"PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC",
			"SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN",
			"SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG",
			"TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV",
			"TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC",
			"VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS",
			"ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM",
			"JE", "BL", "MF", "BQ", "SS", "O1"
		};
		string_2 = new string[256]
		{
			"N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia",
			"Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina",
			"Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam",
			"Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands",
			"Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia",
			"Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica",
			"Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland",
			"Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia",
			"French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands",
			"Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary",
			"Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica",
			"Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of",
			"Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho",
			"Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia",
			"Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius",
			"Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria",
			"Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru",
			"French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal",
			"Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles",
			"Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal",
			"Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo",
			"Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu",
			"Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines",
			"Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia",
			"South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man",
			"Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other"
		};
	}

	public GClass3(string string_3)
		: this(string_3, int_20)
	{
	}

	public GClass3(string string_3, int int_26)
	{
		fileStream_0 = null;
		gclass5_0 = null;
		object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(new object()));
		byte_0 = Convert.ToByte(GClass5.int_0);
		int_13 = 0;
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(object_0);
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
			object obj = objectValue;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				fileStream_0 = new FileStream(string_3, FileMode.Open, FileAccess.Read);
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			int_12 = int_26;
			method_0();
		}
		catch (SystemException ex)
		{
			ProjectData.SetProjectError(ex);
			SystemException projectError = ex;
			ProjectData.SetProjectError(projectError);
			Console.Write("cannot open file " + string_3 + "\n");
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void method_0()
	{
		byte[] array = new byte[3];
		byte[] array2 = new byte[int_17 - 1 + 1 - 1 + 1];
		byte_0 = (byte)GClass5.int_0;
		int_1 = int_2;
		object objectValue = RuntimeHelpers.GetObjectValue(object_0);
		ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
		object obj = objectValue;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			fileStream_0.Seek(-3L, SeekOrigin.End);
			int num = int_15 - 1;
			for (int i = 0; i <= num; i++)
			{
				fileStream_0.Read(array, 0, 3);
				if (array[0] != byte.MaxValue || array[1] != byte.MaxValue || array[2] != byte.MaxValue)
				{
					fileStream_0.Seek(-4L, SeekOrigin.Current);
					continue;
				}
				byte_0 = Convert.ToByte(fileStream_0.ReadByte());
				if (byte_0 >= 106)
				{
					byte_0 -= 105;
				}
				if (byte_0 == GClass5.int_1)
				{
					int_0 = new int[1] { int_7 };
					int_1 = int_2;
				}
				else if (byte_0 == GClass5.int_2)
				{
					int_0 = new int[1] { int_8 };
					int_1 = int_2;
				}
				else if (byte_0 == GClass5.int_3 || byte_0 == GClass5.int_4 || byte_0 == GClass5.int_5 || byte_0 == GClass5.int_14 || byte_0 == GClass5.int_6 || byte_0 == GClass5.int_13 || byte_0 == GClass5.int_8 || byte_0 == GClass5.int_12 || byte_0 == GClass5.int_18 || byte_0 == GClass5.int_19 || byte_0 == GClass5.int_17 || byte_0 == GClass5.int_16)
				{
					int_0 = new int[1];
					if (byte_0 != GClass5.int_3 && byte_0 != GClass5.int_4 && byte_0 != GClass5.int_12 && byte_0 != GClass5.int_18 && byte_0 != GClass5.int_19 && byte_0 != GClass5.int_17 && byte_0 != GClass5.int_16 && byte_0 != GClass5.int_8)
					{
						int_1 = int_3;
					}
					else
					{
						int_1 = int_2;
					}
					fileStream_0.Read(array2, 0, int_17);
					int num2 = int_17 - 1;
					for (int j = 0; j <= num2; j++)
					{
						int_0[0] = int_0[0] + (smethod_2(array2[j]) << j * 8);
					}
				}
				break;
			}
			if (byte_0 == GClass5.int_0 || byte_0 == GClass5.int_11 || byte_0 == GClass5.int_7 || byte_0 == GClass5.int_9)
			{
				int_0 = new int[1] { jbvvZxuncp };
				int_1 = int_2;
			}
			if ((int_12 & int_21) == 1)
			{
				int num3 = (int)fileStream_0.Length;
				byte_1 = new byte[num3 - 1 + 1 - 1 + 1];
				fileStream_0.Seek(0L, SeekOrigin.Begin);
				fileStream_0.Read(byte_1, 0, num3);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	public void method_1()
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(object_0);
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
			object obj = objectValue;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				fileStream_0.Close();
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			fileStream_0 = null;
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

	public GClass5 method_10()
	{
		if (gclass5_0 == null)
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					bool flag = false;
					byte[] array = new byte[3];
					fileStream_0.Seek(-3L, SeekOrigin.End);
					int num = int_15 - 1;
					for (int i = 0; i <= num; i++)
					{
						fileStream_0.Read(array, 0, 3);
						if (array[0] != byte.MaxValue || array[1] != byte.MaxValue || array[2] != byte.MaxValue)
						{
							fileStream_0.Seek(-4L, SeekOrigin.Current);
							continue;
						}
						flag = true;
						break;
					}
					if (flag)
					{
						fileStream_0.Seek(-6L, SeekOrigin.Current);
					}
					else
					{
						fileStream_0.Seek(-3L, SeekOrigin.End);
					}
					int num2 = int_16 - 1;
					for (int j = 0; j <= num2; j++)
					{
						fileStream_0.Read(array, 0, 3);
						if (array[0] != 0 || array[1] != 0 || array[2] != 0)
						{
							fileStream_0.Seek(-4L, SeekOrigin.Current);
							continue;
						}
						byte[] array2 = new byte[j - 1 + 1 - 1 + 1];
						char[] array3 = new char[j - 1 + 1 - 1 + 1];
						fileStream_0.Read(array2, 0, j);
						int num3 = j - 1;
						for (int k = 0; k <= num3; k++)
						{
							array3[k] = Convert.ToChar(array2[k]);
						}
						gclass5_0 = new GClass5(new string(array3));
						return gclass5_0;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
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
			return new GClass5(string.Empty);
		}
		return gclass5_0;
	}

	public GClass6 method_11(IPAddress ipaddress_0)
	{
		return method_12(Conversions.ToString(smethod_1(ipaddress_0.GetAddressBytes())));
	}

	public GClass6 method_12(string string_3)
	{
		IPAddress iPAddress;
		GClass6 result;
		try
		{
			iPAddress = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			ProjectData.ClearProjectError();
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0051;
		}
		result = method_12(Conversions.ToString(smethod_1(iPAddress.GetAddressBytes())));
		goto IL_0051;
		IL_0051:
		return result;
	}

	public string method_13(IPAddress ipaddress_0)
	{
		return method_17(smethod_1(ipaddress_0.GetAddressBytes()));
	}

	public string method_14(string string_3)
	{
		IPAddress ipaddress_;
		string result;
		try
		{
			ipaddress_ = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			ProjectData.ClearProjectError();
			result = null;
			ProjectData.ClearProjectError();
			goto IL_0042;
		}
		result = method_16(ipaddress_);
		goto IL_0042;
		IL_0042:
		return result;
	}

	public string method_15(string string_3)
	{
		IPAddress iPAddress;
		string result;
		try
		{
			iPAddress = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			ProjectData.ClearProjectError();
			result = null;
			ProjectData.ClearProjectError();
			goto IL_004c;
		}
		result = method_17(smethod_1(iPAddress.GetAddressBytes()));
		goto IL_004c;
		IL_004c:
		return result;
	}

	public string method_16(IPAddress ipaddress_0)
	{
		int i = 0;
		byte[] array = new byte[int_5 - 1 + 1 - 1 + 1];
		char[] array2 = new char[int_5 - 1 + 1 - 1 + 1];
		string result;
		try
		{
			int num = method_18(ipaddress_0);
			if (num == int_0[0])
			{
				return null;
			}
			int num2 = num + (2 * int_1 - 1) * int_0[0];
			if ((int_12 & int_21) == 1)
			{
				Array.Copy(byte_1, num2, array, 0, Math.Min(byte_1.Length - num2, int_5));
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					fileStream_0.Seek(num2, SeekOrigin.Begin);
					fileStream_0.Read(array, 0, int_5);
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			for (; array[i] != 0; i++)
			{
				array2[i] = Convert.ToChar(array[i]);
			}
			array2[i] = '\0';
			result = new string(array2, 0, i);
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException projectError = ex;
			ProjectData.SetProjectError(projectError);
			Console.Write("IO Exception");
			result = null;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string method_17(long long_0)
	{
		int i = 0;
		byte[] array = new byte[int_5 - 1 + 1 - 1 + 1];
		char[] array2 = new char[int_5 - 1 + 1 - 1 + 1];
		string result;
		try
		{
			int num = method_19(long_0);
			if (num == int_0[0])
			{
				return null;
			}
			int num2 = num + (2 * int_1 - 1) * int_0[0];
			if ((int_12 & int_21) == 1)
			{
				Array.Copy(byte_1, num2, array, 0, Math.Min(byte_1.Length - num2, int_5));
			}
			else
			{
				object objectValue = RuntimeHelpers.GetObjectValue(object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					fileStream_0.Seek(num2, SeekOrigin.Begin);
					fileStream_0.Read(array, 0, int_5);
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			for (; array[i] != 0; i++)
			{
				array2[i] = Convert.ToChar(array[i]);
			}
			array2[i] = '\0';
			result = new string(array2, 0, i);
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException projectError = ex;
			ProjectData.SetProjectError(projectError);
			Console.Write("IO Exception");
			result = null;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int method_18(IPAddress ipaddress_0)
	{
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		byte[] array = new byte[2 * int_4 - 1 + 1 - 1 + 1];
		int[] array2 = new int[2];
		int num = 0;
		int num2 = 127;
		while (true)
		{
			try
			{
				if ((int_12 & int_21) != 1)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						fileStream_0.Seek(2 * int_1 * num, SeekOrigin.Begin);
						fileStream_0.Read(array, 0, 2 * int_4);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
				else
				{
					int num3 = 2 * int_4 - 1;
					for (int i = 0; i <= num3; i++)
					{
						array[i] = byte_1[i + 2 * int_1 * num];
					}
				}
			}
			catch (IOException ex)
			{
				ProjectData.SetProjectError(ex);
				IOException projectError = ex;
				ProjectData.SetProjectError(projectError);
				Console.Write("IO Exception");
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num4 = 0;
			do
			{
				array2[num4] = 0;
				int num5 = int_1 - 1;
				for (int j = 0; j <= num5; j++)
				{
					int num6 = array[num4 * int_1 + j];
					if (num6 < 0)
					{
						num6 += 256;
					}
					int num7 = num4;
					array2[num7] += num6 << j * 8;
				}
				num4++;
			}
			while (num4 <= 1);
			int num8 = 127 - num2;
			int num9 = num8 >> 3;
			int num10 = 1 << ((num8 & 7) ^ 7);
			if ((addressBytes[num9] & num10) <= 0)
			{
				if (array2[0] >= int_0[0])
				{
					return array2[0];
				}
				num = array2[0];
			}
			else
			{
				if (array2[1] >= int_0[0])
				{
					break;
				}
				num = array2[1];
			}
			num2 += -1;
			if (num2 >= 0)
			{
				continue;
			}
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0));
			return 0;
		}
		return array2[1];
	}

	public int method_19(long long_0)
	{
		byte[] array = new byte[2 * int_4 - 1 + 1 - 1 + 1];
		int[] array2 = new int[2];
		int num = 0;
		int num2 = 31;
		while (true)
		{
			try
			{
				if ((int_12 & int_21) == 1)
				{
					int num3 = 2 * int_4 - 1;
					for (int i = 0; i <= num3; i++)
					{
						array[i] = byte_1[i + 2 * int_1 * num];
					}
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						fileStream_0.Seek(2 * int_1 * num, SeekOrigin.Begin);
						fileStream_0.Read(array, 0, 2 * int_4);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
			}
			catch (IOException ex)
			{
				ProjectData.SetProjectError(ex);
				IOException projectError = ex;
				ProjectData.SetProjectError(projectError);
				Console.Write("IO Exception");
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			int num4 = 0;
			do
			{
				array2[num4] = 0;
				int num5 = int_1 - 1;
				for (int j = 0; j <= num5; j++)
				{
					int num6 = array[num4 * int_1 + j];
					if (num6 < 0)
					{
						num6 += 256;
					}
					int num7 = num4;
					array2[num7] += num6 << j * 8;
				}
				num4++;
			}
			while (num4 <= 1);
			if ((long_0 & (1 << num2)) > 0L)
			{
				if (array2[1] >= int_0[0])
				{
					return array2[1];
				}
				num = array2[1];
			}
			else
			{
				if (array2[0] >= int_0[0])
				{
					break;
				}
				num = array2[0];
			}
			num2 += -1;
			if (num2 >= 0)
			{
				continue;
			}
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0));
			return 0;
		}
		return array2[0];
	}

	public GClass4 method_2(IPAddress ipaddress_0)
	{
		return method_6(smethod_1(ipaddress_0.GetAddressBytes()));
	}

	public GClass4 method_3(string string_3)
	{
		IPAddress ipaddress_;
		GClass4 result;
		try
		{
			ipaddress_ = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			GClass4 nbmvWlidHq = NbmvWlidHq;
			ProjectData.ClearProjectError();
			result = nbmvWlidHq;
			ProjectData.ClearProjectError();
			goto IL_004a;
		}
		result = method_5(ipaddress_);
		goto IL_004a;
		IL_004a:
		return result;
	}

	public GClass4 method_4(string string_3)
	{
		IPAddress iPAddress;
		GClass4 result;
		try
		{
			iPAddress = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			GClass4 nbmvWlidHq = NbmvWlidHq;
			ProjectData.ClearProjectError();
			result = nbmvWlidHq;
			ProjectData.ClearProjectError();
			goto IL_0054;
		}
		result = method_6(smethod_1(iPAddress.GetAddressBytes()));
		goto IL_0054;
		IL_0054:
		return result;
	}

	public GClass4 method_5(IPAddress ipaddress_0)
	{
		if (fileStream_0 != null)
		{
			if (!((byte_0 == GClass5.int_4) | (byte_0 == GClass5.int_3)))
			{
				int num = method_18(ipaddress_0) - jbvvZxuncp;
				if (num != 0)
				{
					return new GClass4(string_1[num], string_2[num]);
				}
				return NbmvWlidHq;
			}
			GClass6 gClass = method_11(ipaddress_0);
			if (gClass == null)
			{
				return NbmvWlidHq;
			}
			return new GClass4(gClass.string_0, gClass.string_1);
		}
		throw new Exception("Database has been closed.");
	}

	public GClass4 method_6(long long_0)
	{
		if (fileStream_0 != null)
		{
			if ((byte_0 == GClass5.int_4) | (byte_0 == GClass5.int_3))
			{
				GClass6 gClass = method_12(Conversions.ToString(long_0));
				if (gClass == null)
				{
					return NbmvWlidHq;
				}
				return new GClass4(gClass.string_0, gClass.string_1);
			}
			int num = method_19(long_0) - jbvvZxuncp;
			if (num == 0)
			{
				return NbmvWlidHq;
			}
			return new GClass4(string_1[num], string_2[num]);
		}
		throw new Exception("Database has been closed.");
	}

	public int method_7(string string_3)
	{
		IPAddress iPAddress;
		int result;
		try
		{
			iPAddress = IPAddress.Parse(string_3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Console.Write(ex3.Message);
			ProjectData.ClearProjectError();
			result = 0;
			ProjectData.ClearProjectError();
			goto IL_004c;
		}
		result = method_9(smethod_1(iPAddress.GetAddressBytes()));
		goto IL_004c;
		IL_004c:
		return result;
	}

	public int method_8(IPAddress ipaddress_0)
	{
		return method_9(smethod_1(ipaddress_0.GetAddressBytes()));
	}

	public int method_9(long long_0)
	{
		if (fileStream_0 == null)
		{
			throw new Exception("Database has been closed.");
		}
		return method_19(long_0) - int_0[0];
	}

	public static long smethod_0(long long_0)
	{
		return (((long_0 >> 0) & 0xFFL) << 24) | (((long_0 >> 8) & 0xFFL) << 16) | (((long_0 >> 16) & 0xFFL) << 8) | (((long_0 >> 24) & 0xFFL) << 0);
	}

	public static long smethod_1(object object_1)
	{
		long num = 0L;
		int num2 = 0;
		do
		{
			long num3 = ((byte[])object_1)[num2];
			if (num3 < 0L)
			{
				num3 += 256L;
			}
			num += num3 << (3 - num2) * 8;
			num2++;
		}
		while (num2 <= 3);
		return num;
	}

	public static int smethod_2(byte byte_2)
	{
		return byte_2 & 0xFF;
	}

	public static T smethod_3<T>(ref T gparam_0, T gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}
}
