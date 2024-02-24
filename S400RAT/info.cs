using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class info : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("panel5")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
	public Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("w")]
	public Label label_1;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	public Label label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	public Label label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("pictureBox3")]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("label9")]
	[CompilerGenerated]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ControlBox1")]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel panel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	public Panel panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	public Label label_6;

	[AccessedThroughProperty("AX1")]
	[CompilerGenerated]
	public Label label_7;

	[AccessedThroughProperty("Label8")]
	[CompilerGenerated]
	public Label label_8;

	[AccessedThroughProperty("Label10")]
	[CompilerGenerated]
	public Label label_9;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	public Label label_10;

	[AccessedThroughProperty("Label28")]
	[CompilerGenerated]
	public Label label_11;

	[AccessedThroughProperty("Label29")]
	[CompilerGenerated]
	public Label label_12;

	[AccessedThroughProperty("Label25")]
	[CompilerGenerated]
	public Label label_13;

	[AccessedThroughProperty("Label20")]
	[CompilerGenerated]
	public Label label_14;

	[CompilerGenerated]
	[AccessedThroughProperty("Label23")]
	public Label label_15;

	[AccessedThroughProperty("Label24")]
	[CompilerGenerated]
	public Label label_16;

	[AccessedThroughProperty("Label13")]
	[CompilerGenerated]
	public Label label_17;

	[CompilerGenerated]
	[AccessedThroughProperty("Label17")]
	public Label label_18;

	[AccessedThroughProperty("Label18")]
	[CompilerGenerated]
	public Label uArEnhhnJk;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	public Panel panel_3;

	[AccessedThroughProperty("Label53")]
	[CompilerGenerated]
	public Label label_19;

	[CompilerGenerated]
	[AccessedThroughProperty("Label54")]
	public Label label_20;

	[AccessedThroughProperty("Guna2BorderlessForm2")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_1;

	[AccessedThroughProperty("F5")]
	[CompilerGenerated]
	public Label label_21;

	[AccessedThroughProperty("F4")]
	[CompilerGenerated]
	public Label label_22;

	[AccessedThroughProperty("F11")]
	[CompilerGenerated]
	public Label label_23;

	[AccessedThroughProperty("F10")]
	[CompilerGenerated]
	public Label label_24;

	[AccessedThroughProperty("F9")]
	[CompilerGenerated]
	public Label label_25;

	[AccessedThroughProperty("F8")]
	[CompilerGenerated]
	public Label label_26;

	[AccessedThroughProperty("F3")]
	[CompilerGenerated]
	public Label label_27;

	[AccessedThroughProperty("F2")]
	[CompilerGenerated]
	public Label label_28;

	[AccessedThroughProperty("F7")]
	[CompilerGenerated]
	public Label label_29;

	[AccessedThroughProperty("F6")]
	[CompilerGenerated]
	public Label label_30;

	[CompilerGenerated]
	[AccessedThroughProperty("F1")]
	public Label label_31;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	public Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2CircleProgressBar1")]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	public Label label_32;

	[AccessedThroughProperty("Timer2")]
	[CompilerGenerated]
	public Timer timer_1;

	[AccessedThroughProperty("PictureBox5")]
	[CompilerGenerated]
	public PictureBox pictureBox_3;

	[AccessedThroughProperty("Label22")]
	[CompilerGenerated]
	public Label label_33;

	[AccessedThroughProperty("M6")]
	[CompilerGenerated]
	public Label label_34;

	[CompilerGenerated]
	[AccessedThroughProperty("M7")]
	public Label label_35;

	[CompilerGenerated]
	[AccessedThroughProperty("Label31")]
	public Label label_36;

	[AccessedThroughProperty("Label32")]
	[CompilerGenerated]
	public Label label_37;

	[CompilerGenerated]
	[AccessedThroughProperty("M5")]
	public Label label_38;

	[CompilerGenerated]
	[AccessedThroughProperty("M8")]
	public Label label_39;

	[CompilerGenerated]
	[AccessedThroughProperty("Label35")]
	public Label label_40;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	public Label label_41;

	[AccessedThroughProperty("M3")]
	[CompilerGenerated]
	public Label label_42;

	[AccessedThroughProperty("M2")]
	[CompilerGenerated]
	public Label label_43;

	[AccessedThroughProperty("Label14")]
	[CompilerGenerated]
	public Label label_44;

	[AccessedThroughProperty("Label15")]
	[CompilerGenerated]
	public Label label_45;

	[AccessedThroughProperty("M4")]
	[CompilerGenerated]
	public Label label_46;

	[AccessedThroughProperty("M1")]
	[CompilerGenerated]
	public Label label_47;

	[AccessedThroughProperty("Label21")]
	[CompilerGenerated]
	public Label label_48;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_4;

	[AccessedThroughProperty("MAPP")]
	[CompilerGenerated]
	public Timer timer_2;

	[AccessedThroughProperty("gpg")]
	[CompilerGenerated]
	public Timer timer_3;

	[AccessedThroughProperty("PictureBox7")]
	[CompilerGenerated]
	public PictureBox pictureBox_5;

	[AccessedThroughProperty("PictureBox6")]
	[CompilerGenerated]
	public PictureBox pictureBox_6;

	[AccessedThroughProperty("ProgressBar1")]
	[CompilerGenerated]
	public ProgressBar progressBar_0;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Clos")]
	public Timer timer_4;

	public string Admin;

	public Client C;

	public string ss;

	public static string IP;

	public static string CON;

	public static string MAPS;

	public static string country;

	public virtual Panel panel5
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

	internal virtual Label n
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

	internal virtual Label w
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

	internal virtual PictureBox PictureBox1
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

	public virtual Label Label2
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

	public virtual Label Label7
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

	public virtual Label Label1
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

	public virtual PictureBox pictureBox3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
			PictureBox pictureBox = pictureBox_1;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			pictureBox_1 = value;
			pictureBox = pictureBox_1;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public virtual Label label9
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
			EventHandler value2 = method_7;
			Guna2ControlBox guna2ControlBox = guna2ControlBox_0;
			if (guna2ControlBox != null)
			{
				guna2ControlBox.Click -= value2;
			}
			guna2ControlBox_0 = value;
			guna2ControlBox = guna2ControlBox_0;
			if (guna2ControlBox != null)
			{
				guna2ControlBox.Click += value2;
			}
		}
	}

	public virtual Panel panel2
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

	public virtual Panel Panel1
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

	public virtual PictureBox PictureBox2
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

	public virtual Label Label6
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

	public virtual Label AX1
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

	public virtual Label Label8
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

	public virtual Label Label10
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

	public virtual Label Label3
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

	public virtual Label Label28
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

	public virtual Label Label29
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

	public virtual Label Label25
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

	public virtual Label Label20
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

	public virtual Label Label23
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

	public virtual Label Label24
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

	public virtual Label Label13
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

	public virtual Label Label17
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

	public virtual Label Label18
	{
		[CompilerGenerated]
		get
		{
			return uArEnhhnJk;
		}
		[CompilerGenerated]
		set
		{
			uArEnhhnJk = value;
		}
	}

	public virtual Panel Panel3
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

	public virtual Label Label53
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

	public virtual Label Label54
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

	public virtual Label F5
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

	public virtual Label F4
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

	public virtual Label F11
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

	public virtual Label F10
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

	public virtual Label F9
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

	public virtual Label F8
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

	public virtual Label F3
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

	public virtual Label F2
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

	public virtual Label F7
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

	public virtual Label F6
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

	public virtual Label F1
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

	internal virtual Label Label4
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

	public virtual PictureBox PictureBox5
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

	public virtual Label Label22
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

	public virtual Label M6
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

	public virtual Label M7
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

	public virtual Label Label31
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

	public virtual Label Label32
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

	public virtual Label M5
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

	public virtual Label M8
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

	public virtual Label Label35
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

	public virtual Label Label5
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

	public virtual Label M3
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

	public virtual Label M2
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

	public virtual Label Label14
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

	public virtual Label Label15
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

	public virtual Label M4
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

	public virtual Label M1
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

	public virtual Label Label21
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

	internal virtual PictureBox PictureBox4
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

	internal virtual PictureBox PictureBox7
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

	internal virtual PictureBox PictureBox6
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

	internal virtual ProgressBar ProgressBar1
	{
		[CompilerGenerated]
		get
		{
			return progressBar_0;
		}
		[CompilerGenerated]
		set
		{
			progressBar_0 = value;
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

	public info()
	{
		base.Load += info_Load;
		Admin = null;
		method_0();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(info));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		panel5 = new Panel();
		n = new Label();
		w = new Label();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		Label7 = new Label();
		Label1 = new Label();
		pictureBox3 = new PictureBox();
		label9 = new Label();
		Guna2ControlBox1 = new Guna2ControlBox();
		panel2 = new Panel();
		Panel3 = new Panel();
		PictureBox5 = new PictureBox();
		Label22 = new Label();
		M6 = new Label();
		M7 = new Label();
		Label31 = new Label();
		Label32 = new Label();
		M5 = new Label();
		M8 = new Label();
		Label35 = new Label();
		Label5 = new Label();
		M3 = new Label();
		M2 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		M4 = new Label();
		M1 = new Label();
		Label21 = new Label();
		PictureBox4 = new PictureBox();
		Label53 = new Label();
		Label54 = new Label();
		Panel1 = new Panel();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		Guna2CircleProgressBar1 = new Guna2CircleProgressBar();
		Label4 = new Label();
		F11 = new Label();
		F10 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label25 = new Label();
		F9 = new Label();
		Label20 = new Label();
		F8 = new Label();
		F3 = new Label();
		Label23 = new Label();
		Label24 = new Label();
		F2 = new Label();
		Label13 = new Label();
		F7 = new Label();
		F6 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		F5 = new Label();
		AX1 = new Label();
		F4 = new Label();
		F1 = new Label();
		Label8 = new Label();
		Label10 = new Label();
		Label3 = new Label();
		PictureBox2 = new PictureBox();
		Label6 = new Label();
		YulrTroIyUu(new Guna2BorderlessForm(icontainer_0));
		vmethod_6(new Timer(icontainer_0));
		vmethod_8(new Timer(icontainer_0));
		vmethod_10(new Timer(icontainer_0));
		vmethod_12(new Timer(icontainer_0));
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_14(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		panel2.SuspendLayout();
		Panel3.SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		Guna2CircleProgressBar1.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		SuspendLayout();
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel5.BackColor = Color.FromArgb(37, 42, 64);
		panel5.Controls.Add(n);
		panel5.Controls.Add(w);
		panel5.Controls.Add(PictureBox1);
		panel5.Controls.Add(Label2);
		panel5.Controls.Add(Label7);
		panel5.Controls.Add(Label1);
		panel5.Controls.Add(pictureBox3);
		panel5.Controls.Add(label9);
		panel5.Location = new Point(1, 1);
		panel5.Name = "panel5";
		panel5.Size = new Size(440, 125);
		panel5.TabIndex = 107;
		n.AutoSize = true;
		n.Font = new Font("Nirmala UI", 9.75f);
		n.ForeColor = Color.FromArgb(158, 161, 176);
		n.Location = new Point(94, 81);
		n.Name = "n";
		n.Size = new Size(18, 17);
		n.TabIndex = 109;
		n.Text = "--";
		w.AutoSize = true;
		w.Font = new Font("Nirmala UI", 9.75f);
		w.ForeColor = Color.FromArgb(158, 161, 176);
		w.Location = new Point(94, 102);
		w.Name = "w";
		w.Size = new Size(18, 17);
		w.TabIndex = 108;
		w.Text = "--";
		PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox1.Location = new Point(379, 3);
		PictureBox1.Name = "PictureBox1";
		PictureBox1.Size = new Size(53, 29);
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox1.TabIndex = 107;
		PictureBox1.TabStop = false;
		Label2.AutoSize = true;
		Label2.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label2.ForeColor = Color.White;
		Label2.Location = new Point(4, 7);
		Label2.Name = "Label2";
		Label2.Size = new Size(175, 25);
		Label2.TabIndex = 106;
		Label2.Text = "System Information";
		Label7.AutoSize = true;
		Label7.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label7.ForeColor = Color.FromArgb(158, 161, 176);
		Label7.Location = new Point(19, 100);
		Label7.Name = "Label7";
		Label7.Size = new Size(68, 17);
		Label7.TabIndex = 4;
		Label7.Text = "Windows :";
		Label1.AutoSize = true;
		Label1.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label1.ForeColor = Color.FromArgb(158, 161, 176);
		Label1.Location = new Point(6, 79);
		Label1.Name = "Label1";
		Label1.Size = new Size(81, 17);
		Label1.TabIndex = 3;
		Label1.Text = "User Name :";
		pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
		pictureBox3.Location = new Point(379, 59);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new Size(53, 58);
		pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox3.TabIndex = 2;
		pictureBox3.TabStop = false;
		label9.AutoSize = true;
		label9.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.ForeColor = Color.FromArgb(84, 131, 255);
		label9.Location = new Point(4, 44);
		label9.Name = "label9";
		label9.Size = new Size(111, 25);
		label9.TabIndex = 0;
		label9.Text = "Information";
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BorderColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(970, -2);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 106;
		panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel2.BackColor = Color.FromArgb(24, 30, 54);
		panel2.Controls.Add(Panel3);
		panel2.Controls.Add(Panel1);
		panel2.Location = new Point(10, 132);
		panel2.Name = "panel2";
		panel2.Size = new Size(993, 412);
		panel2.TabIndex = 109;
		Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		Panel3.BackColor = Color.FromArgb(37, 42, 64);
		Panel3.Controls.Add(PictureBox5);
		Panel3.Controls.Add(Label22);
		Panel3.Controls.Add(M6);
		Panel3.Controls.Add(M7);
		Panel3.Controls.Add(Label31);
		Panel3.Controls.Add(Label32);
		Panel3.Controls.Add(M5);
		Panel3.Controls.Add(M8);
		Panel3.Controls.Add(Label35);
		Panel3.Controls.Add(Label5);
		Panel3.Controls.Add(M3);
		Panel3.Controls.Add(M2);
		Panel3.Controls.Add(Label14);
		Panel3.Controls.Add(Label15);
		Panel3.Controls.Add(M4);
		Panel3.Controls.Add(M1);
		Panel3.Controls.Add(Label21);
		Panel3.Controls.Add(PictureBox4);
		Panel3.Controls.Add(Label53);
		Panel3.Controls.Add(Label54);
		Panel3.ForeColor = Color.FromArgb(37, 42, 64);
		Panel3.Location = new Point(439, 11);
		Panel3.Name = "Panel3";
		Panel3.Size = new Size(540, 386);
		Panel3.TabIndex = 102;
		PictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.Location = new Point(488, 3);
		PictureBox5.Name = "PictureBox5";
		PictureBox5.Size = new Size(49, 41);
		PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox5.TabIndex = 152;
		PictureBox5.TabStop = false;
		Label22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label22.AutoSize = true;
		Label22.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label22.ForeColor = Color.White;
		Label22.Location = new Point(256, 98);
		Label22.Name = "Label22";
		Label22.Size = new Size(96, 17);
		Label22.TabIndex = 151;
		Label22.Text = "Gegion Name :";
		M6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M6.AutoSize = true;
		M6.Font = new Font("Nirmala UI", 9.75f);
		M6.ForeColor = Color.White;
		M6.Location = new Point(358, 98);
		M6.Name = "M6";
		M6.Size = new Size(18, 17);
		M6.TabIndex = 150;
		M6.Text = "--";
		M7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M7.AutoSize = true;
		M7.Font = new Font("Nirmala UI", 9.75f);
		M7.ForeColor = Color.White;
		M7.Location = new Point(358, 74);
		M7.Name = "M7";
		M7.Size = new Size(18, 17);
		M7.TabIndex = 149;
		M7.Text = "--";
		Label31.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label31.AutoSize = true;
		Label31.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label31.ForeColor = Color.White;
		Label31.Location = new Point(291, 74);
		Label31.Name = "Label31";
		Label31.Size = new Size(61, 17);
		Label31.TabIndex = 148;
		Label31.Text = "Country :";
		Label32.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label32.AutoSize = true;
		Label32.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label32.ForeColor = Color.White;
		Label32.Location = new Point(277, 47);
		Label32.Name = "Label32";
		Label32.Size = new Size(75, 17);
		Label32.TabIndex = 147;
		Label32.Text = "Time zone :";
		M5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M5.AutoSize = true;
		M5.Font = new Font("Nirmala UI", 9.75f);
		M5.ForeColor = Color.White;
		M5.Location = new Point(358, 123);
		M5.Name = "M5";
		M5.Size = new Size(18, 17);
		M5.TabIndex = 146;
		M5.Text = "--";
		M8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M8.AutoSize = true;
		M8.Font = new Font("Nirmala UI", 9.75f);
		M8.ForeColor = Color.White;
		M8.Location = new Point(358, 49);
		M8.Name = "M8";
		M8.Size = new Size(18, 17);
		M8.TabIndex = 145;
		M8.Text = "--";
		Label35.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label35.AutoSize = true;
		Label35.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label35.ForeColor = Color.White;
		Label35.Location = new Point(316, 123);
		Label35.Name = "Label35";
		Label35.Size = new Size(36, 17);
		Label35.TabIndex = 144;
		Label35.Text = "City :";
		Label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label5.AutoSize = true;
		Label5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label5.ForeColor = Color.White;
		Label5.Location = new Point(17, 98);
		Label5.Name = "Label5";
		Label5.Size = new Size(41, 17);
		Label5.TabIndex = 143;
		Label5.Text = "LON :";
		M3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M3.AutoSize = true;
		M3.Font = new Font("Nirmala UI", 9.75f);
		M3.ForeColor = Color.White;
		M3.Location = new Point(64, 98);
		M3.Name = "M3";
		M3.Size = new Size(18, 17);
		M3.TabIndex = 142;
		M3.Text = "--";
		M2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M2.AutoSize = true;
		M2.Font = new Font("Nirmala UI", 9.75f);
		M2.ForeColor = Color.White;
		M2.Location = new Point(64, 74);
		M2.Name = "M2";
		M2.Size = new Size(18, 17);
		M2.TabIndex = 141;
		M2.Text = "--";
		Label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label14.AutoSize = true;
		Label14.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label14.ForeColor = Color.White;
		Label14.Location = new Point(23, 74);
		Label14.Name = "Label14";
		Label14.Size = new Size(35, 17);
		Label14.TabIndex = 140;
		Label14.Text = "LSP :";
		Label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label15.AutoSize = true;
		Label15.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label15.ForeColor = Color.White;
		Label15.Location = new Point(23, 49);
		Label15.Name = "Label15";
		Label15.Size = new Size(35, 17);
		Label15.TabIndex = 139;
		Label15.Text = "LAT :";
		M4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M4.AutoSize = true;
		M4.Font = new Font("Nirmala UI", 9.75f);
		M4.ForeColor = Color.White;
		M4.Location = new Point(64, 123);
		M4.Name = "M4";
		M4.Size = new Size(18, 17);
		M4.TabIndex = 138;
		M4.Text = "--";
		M1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		M1.AutoSize = true;
		M1.Font = new Font("Nirmala UI", 9.75f);
		M1.ForeColor = Color.White;
		M1.Location = new Point(64, 49);
		M1.Name = "M1";
		M1.Size = new Size(18, 17);
		M1.TabIndex = 137;
		M1.Text = "--";
		Label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label21.AutoSize = true;
		Label21.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label21.ForeColor = Color.White;
		Label21.Location = new Point(15, 123);
		Label21.Name = "Label21";
		Label21.Size = new Size(43, 17);
		Label21.TabIndex = 136;
		Label21.Text = "A - S :";
		PictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox4.Location = new Point(8, 154);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(529, 223);
		PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox4.TabIndex = 135;
		PictureBox4.TabStop = false;
		Label53.AutoSize = true;
		Label53.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label53.ForeColor = Color.White;
		Label53.Location = new Point(5, 6);
		Label53.Name = "Label53";
		Label53.Size = new Size(132, 25);
		Label53.TabIndex = 107;
		Label53.Text = "IP information";
		Label54.AutoSize = true;
		Label54.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label54.ForeColor = Color.White;
		Label54.Location = new Point(3, 6);
		Label54.Name = "Label54";
		Label54.Size = new Size(0, 17);
		Label54.TabIndex = 1;
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(37, 42, 64);
		Panel1.Controls.Add(PictureBox7);
		Panel1.Controls.Add(PictureBox6);
		Panel1.Controls.Add(ProgressBar1);
		Panel1.Controls.Add(Guna2CircleProgressBar1);
		Panel1.Controls.Add(F11);
		Panel1.Controls.Add(F10);
		Panel1.Controls.Add(Label28);
		Panel1.Controls.Add(Label29);
		Panel1.Controls.Add(Label25);
		Panel1.Controls.Add(F9);
		Panel1.Controls.Add(Label20);
		Panel1.Controls.Add(F8);
		Panel1.Controls.Add(F3);
		Panel1.Controls.Add(Label23);
		Panel1.Controls.Add(Label24);
		Panel1.Controls.Add(F2);
		Panel1.Controls.Add(Label13);
		Panel1.Controls.Add(F7);
		Panel1.Controls.Add(F6);
		Panel1.Controls.Add(Label17);
		Panel1.Controls.Add(Label18);
		Panel1.Controls.Add(F5);
		Panel1.Controls.Add(AX1);
		Panel1.Controls.Add(F4);
		Panel1.Controls.Add(F1);
		Panel1.Controls.Add(Label8);
		Panel1.Controls.Add(Label10);
		Panel1.Controls.Add(Label3);
		Panel1.Controls.Add(PictureBox2);
		Panel1.Controls.Add(Label6);
		Panel1.ForeColor = Color.FromArgb(37, 42, 64);
		Panel1.Location = new Point(14, 11);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(414, 386);
		Panel1.TabIndex = 101;
		PictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox7.Location = new Point(383, 309);
		PictureBox7.Name = "PictureBox7";
		PictureBox7.Size = new Size(25, 10);
		PictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox7.TabIndex = 137;
		PictureBox7.TabStop = false;
		PictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox6.Location = new Point(383, 270);
		PictureBox6.Name = "PictureBox6";
		PictureBox6.Size = new Size(21, 18);
		PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox6.TabIndex = 110;
		PictureBox6.TabStop = false;
		ProgressBar1.Location = new Point(297, 280);
		ProgressBar1.Name = "ProgressBar1";
		ProgressBar1.Size = new Size(100, 38);
		ProgressBar1.TabIndex = 110;
		Guna2CircleProgressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
		Guna2CircleProgressBar1.Animated = true;
		Guna2CircleProgressBar1.Controls.Add(Label4);
		Guna2CircleProgressBar1.FillThickness = 10;
		Guna2CircleProgressBar1.Location = new Point(242, 121);
		Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1";
		Guna2CircleProgressBar1.ProgressBrushMode = BrushMode.Solid;
		Guna2CircleProgressBar1.ProgressColor = Color.FromArgb(0, 126, 249);
		Guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(0, 126, 249);
		Guna2CircleProgressBar1.ProgressEndCap = LineCap.Round;
		Guna2CircleProgressBar1.ProgressStartCap = LineCap.Round;
		Guna2CircleProgressBar1.ProgressThickness = 10;
		Guna2CircleProgressBar1.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar1.ShadowDecoration.Parent = Guna2CircleProgressBar1;
		Guna2CircleProgressBar1.Size = new Size(155, 151);
		Guna2CircleProgressBar1.TabIndex = 110;
		Guna2CircleProgressBar1.Value = 45;
		Label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		Label4.AutoSize = true;
		Label4.Font = new Font("Segoe UI", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Label4.ForeColor = SystemColors.ControlDark;
		Label4.Location = new Point(30, 58);
		Label4.Name = "Label4";
		Label4.Size = new Size(94, 19);
		Label4.TabIndex = 136;
		Label4.Text = "Plase Wait ...";
		F11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F11.AutoSize = true;
		F11.Font = new Font("Nirmala UI", 9.75f);
		F11.ForeColor = Color.White;
		F11.Location = new Point(176, 360);
		F11.Name = "F11";
		F11.Size = new Size(18, 17);
		F11.TabIndex = 133;
		F11.Text = "--";
		F10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F10.AutoSize = true;
		F10.Font = new Font("Nirmala UI", 9.75f);
		F10.ForeColor = Color.White;
		F10.Location = new Point(176, 335);
		F10.Name = "F10";
		F10.Size = new Size(18, 17);
		F10.TabIndex = 132;
		F10.Text = "--";
		Label28.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label28.AutoSize = true;
		Label28.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label28.ForeColor = Color.White;
		Label28.Location = new Point(122, 360);
		Label28.Name = "Label28";
		Label28.Size = new Size(39, 17);
		Label28.TabIndex = 131;
		Label28.Text = "Port :";
		Label29.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label29.AutoSize = true;
		Label29.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label29.ForeColor = Color.White;
		Label29.Location = new Point(119, 335);
		Label29.Name = "Label29";
		Label29.Size = new Size(42, 17);
		Label29.TabIndex = 130;
		Label29.Text = "Host :";
		Label25.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label25.AutoSize = true;
		Label25.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label25.ForeColor = Color.White;
		Label25.Location = new Point(-1, 301);
		Label25.Name = "Label25";
		Label25.Size = new Size(3602, 25);
		Label25.TabIndex = 129;
		Label25.Text = componentResourceManager.GetString("Label25.Text");
		F9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F9.AutoSize = true;
		F9.Font = new Font("Nirmala UI", 9.75f);
		F9.ForeColor = Color.White;
		F9.Location = new Point(178, 280);
		F9.Name = "F9";
		F9.Size = new Size(18, 17);
		F9.TabIndex = 128;
		F9.Text = "--";
		F9.Visible = false;
		Label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label20.AutoSize = true;
		Label20.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label20.ForeColor = Color.White;
		Label20.Location = new Point(49, 129);
		Label20.Name = "Label20";
		Label20.Size = new Size(114, 17);
		Label20.TabIndex = 127;
		Label20.Text = "System Directory :";
		F8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F8.AutoSize = true;
		F8.Font = new Font("Nirmala UI", 9.75f);
		F8.ForeColor = Color.White;
		F8.Location = new Point(178, 255);
		F8.Name = "F8";
		F8.Size = new Size(18, 17);
		F8.TabIndex = 126;
		F8.Text = "--";
		F3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F3.AutoSize = true;
		F3.Font = new Font("Nirmala UI", 9.75f);
		F3.ForeColor = Color.White;
		F3.Location = new Point(178, 129);
		F3.Name = "F3";
		F3.Size = new Size(18, 17);
		F3.TabIndex = 125;
		F3.Text = "--";
		Label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label23.AutoSize = true;
		Label23.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label23.ForeColor = Color.White;
		Label23.Location = new Point(118, 280);
		Label23.Name = "Label23";
		Label23.Size = new Size(43, 17);
		Label23.TabIndex = 124;
		Label23.Text = "Time :";
		Label24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label24.AutoSize = true;
		Label24.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label24.ForeColor = Color.White;
		Label24.Location = new Point(83, 255);
		Label24.Name = "Label24";
		Label24.Size = new Size(78, 17);
		Label24.TabIndex = 123;
		Label24.Text = "User name :";
		F2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F2.AutoSize = true;
		F2.Font = new Font("Nirmala UI", 9.75f);
		F2.ForeColor = Color.White;
		F2.Location = new Point(178, 105);
		F2.Name = "F2";
		F2.Size = new Size(18, 17);
		F2.TabIndex = 122;
		F2.Text = "--";
		Label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label13.AutoSize = true;
		Label13.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label13.ForeColor = Color.White;
		Label13.Location = new Point(51, 206);
		Label13.Name = "Label13";
		Label13.Size = new Size(112, 17);
		Label13.TabIndex = 121;
		Label13.Text = "Computer Name :";
		F7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F7.AutoSize = true;
		F7.Font = new Font("Nirmala UI", 9.75f);
		F7.ForeColor = Color.White;
		F7.Location = new Point(178, 230);
		F7.Name = "F7";
		F7.Size = new Size(18, 17);
		F7.TabIndex = 120;
		F7.Text = "--";
		F6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F6.AutoSize = true;
		F6.Font = new Font("Nirmala UI", 9.75f);
		F6.ForeColor = Color.White;
		F6.Location = new Point(178, 206);
		F6.Name = "F6";
		F6.Size = new Size(18, 17);
		F6.TabIndex = 119;
		F6.Text = "--";
		Label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label17.AutoSize = true;
		Label17.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label17.ForeColor = Color.White;
		Label17.Location = new Point(84, 105);
		Label17.Name = "Label17";
		Label17.Size = new Size(79, 17);
		Label17.TabIndex = 118;
		Label17.Text = "OS Version :";
		Label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label18.AutoSize = true;
		Label18.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label18.ForeColor = Color.White;
		Label18.Location = new Point(33, 230);
		Label18.Name = "Label18";
		Label18.Size = new Size(130, 17);
		Label18.TabIndex = 117;
		Label18.Text = "User Domain Name :";
		F5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F5.AutoSize = true;
		F5.Font = new Font("Nirmala UI", 9.75f);
		F5.ForeColor = Color.White;
		F5.Location = new Point(178, 179);
		F5.Name = "F5";
		F5.Size = new Size(18, 17);
		F5.TabIndex = 116;
		F5.Text = "--";
		AX1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		AX1.AutoSize = true;
		AX1.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		AX1.ForeColor = Color.White;
		AX1.Location = new Point(95, 80);
		AX1.Name = "AX1";
		AX1.Size = new Size(68, 17);
		AX1.TabIndex = 114;
		AX1.Text = "Windows :";
		F4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F4.AutoSize = true;
		F4.Font = new Font("Nirmala UI", 9.75f);
		F4.ForeColor = Color.White;
		F4.Location = new Point(178, 154);
		F4.Name = "F4";
		F4.Size = new Size(18, 17);
		F4.TabIndex = 113;
		F4.Text = "--";
		F1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		F1.AutoSize = true;
		F1.Font = new Font("Nirmala UI", 9.75f);
		F1.ForeColor = Color.White;
		F1.Location = new Point(178, 80);
		F1.Name = "F1";
		F1.Size = new Size(18, 17);
		F1.TabIndex = 112;
		F1.Text = "--";
		Label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label8.AutoSize = true;
		Label8.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label8.ForeColor = Color.White;
		Label8.Location = new Point(7, 179);
		Label8.Name = "Label8";
		Label8.Size = new Size(156, 17);
		Label8.TabIndex = 111;
		Label8.Text = "Installed memory (RAM) :";
		Label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label10.AutoSize = true;
		Label10.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label10.ForeColor = Color.White;
		Label10.Location = new Point(90, 154);
		Label10.Name = "Label10";
		Label10.Size = new Size(73, 17);
		Label10.TabIndex = 110;
		Label10.Text = "Processor :";
		Label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		Label3.AutoSize = true;
		Label3.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label3.ForeColor = Color.White;
		Label3.Location = new Point(3, 38);
		Label3.Name = "Label3";
		Label3.Size = new Size(4644, 25);
		Label3.TabIndex = 107;
		Label3.Text = componentResourceManager.GetString("Label3.Text");
		PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(356, 3);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(55, 41);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 76;
		PictureBox2.TabStop = false;
		Label6.AutoSize = true;
		Label6.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label6.ForeColor = Color.White;
		Label6.Location = new Point(3, 6);
		Label6.Name = "Label6";
		Label6.Size = new Size(0, 17);
		Label6.TabIndex = 1;
		vmethod_4().ContainerControl = this;
		vmethod_5().Enabled = true;
		vmethod_7().Enabled = true;
		vmethod_9().Enabled = true;
		vmethod_9().Interval = 1000;
		vmethod_11().Enabled = true;
		vmethod_11().Interval = 1000;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(946, 4);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_13().Enabled = true;
		vmethod_13().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(1015, 556);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel2);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "info";
		Text = "info";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		panel2.ResumeLayout(performLayout: false);
		Panel3.ResumeLayout(performLayout: false);
		Panel3.PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		Panel1.ResumeLayout(performLayout: false);
		Panel1.PerformLayout();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		Guna2CircleProgressBar1.ResumeLayout(performLayout: false);
		Guna2CircleProgressBar1.PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2AnimateWindow vmethod_0()
	{
		return guna2AnimateWindow_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(Guna2AnimateWindow WithEventsValue)
	{
		guna2AnimateWindow_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2BorderlessForm vmethod_2()
	{
		return guna2BorderlessForm_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2BorderlessForm vmethod_4()
	{
		return guna2BorderlessForm_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void YulrTroIyUu(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_5()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_6(Timer WithEventsValue)
	{
		EventHandler value = method_1;
		Timer timer = timer_0;
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
	internal virtual Timer vmethod_7()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_8(Timer WithEventsValue)
	{
		EventHandler value = method_3;
		Timer timer = timer_1;
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
	internal virtual Timer vmethod_9()
	{
		return timer_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_10(Timer WithEventsValue)
	{
		EventHandler value = method_4;
		Timer timer = timer_2;
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
	internal virtual Timer vmethod_11()
	{
		return timer_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_12(Timer WithEventsValue)
	{
		EventHandler value = method_6;
		Timer timer = timer_3;
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
	internal virtual Timer vmethod_13()
	{
		return timer_4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_14(Timer WithEventsValue)
	{
		EventHandler value = method_9;
		Timer timer = timer_4;
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

	public void info_Load(object sender, EventArgs e)
	{
		IP = Class7.string_3;
		Class7.string_3 = "";
		if (!Directory.Exists(Application.StartupPath + "\\Map\\"))
		{
			Directory.CreateDirectory(Application.StartupPath + "\\Map\\");
		}
		C.Send("Admin" + Class7.string_1);
		try
		{
			string expression = ss;
			string[] array = Strings.Split(expression, "|'|");
			n.Text = array[0];
			w.Text = array[1];
			Admin = array[2];
			C.Send("txt");
			if (!Directory.Exists(Application.StartupPath + "\\Map"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\Map");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1(object sender, EventArgs e)
	{
	}

	public void method_2(object sender, EventArgs e)
	{
		C.Send("CPU");
	}

	public void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(F1.Text, "--", TextCompare: false) != 0)
		{
			vmethod_7().Stop();
			Guna2CircleProgressBar1.Hide();
		}
		else
		{
			C.Send("txt");
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		try
		{
			Application.DoEvents();
			if (Operators.CompareString(IP, "127.0.0.1", TextCompare: false) == 0)
			{
				return;
			}
			try
			{
				if (Operators.CompareString(M7.Text, "--", TextCompare: false) == 0)
				{
					try
					{
						string filename = "http://ip-api.com/xml/" + IP;
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(filename);
						M7.Text = xmlDocument.DocumentElement.SelectSingleNode("//country").InnerText;
						M6.Text = xmlDocument.DocumentElement.SelectSingleNode("//regionName").InnerText;
						M5.Text = xmlDocument.DocumentElement.SelectSingleNode("//city").InnerText;
						M1.Text = xmlDocument.DocumentElement.SelectSingleNode("//lat").InnerText;
						M3.Text = xmlDocument.DocumentElement.SelectSingleNode("//lon").InnerText;
						M8.Text = xmlDocument.DocumentElement.SelectSingleNode("//timezone").InnerText;
						M2.Text = xmlDocument.DocumentElement.SelectSingleNode("//isp").InnerText;
						M4.Text = xmlDocument.DocumentElement.SelectSingleNode("//as").InnerText;
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						vmethod_9().Stop();
						MessageBox.Show("Erorr : Cannot set session on local ip!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
						return;
					}
				}
				vmethod_9().Stop();
				if (File.Exists(Application.StartupPath + "\\Map\\" + M7.Text.Substring(0, 2) + ".JPG"))
				{
					PictureBox4.Image = Image.FromFile(Application.StartupPath + "\\Map\\" + M7.Text.Substring(0, 2) + ".jpg");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				vmethod_9().Stop();
				MessageBox.Show("Erorr : Cannot set session on local ip!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			vmethod_9().Stop();
			ProjectData.ClearProjectError();
		}
	}

	public bool method_5(string string_0)
	{
		bool result;
		try
		{
			using WebClient webClient = new WebClient();
			string address = "https://chart.googleapis.com/chart?chf=bg,s,252A40&chs=440x220&cht=t&chco=252A4030&chld=" + string_0 + "&chtm=world";
			Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream(webClient.DownloadData(address)));
			bitmap.Save(Application.StartupPath + "\\Map\\" + string_0 + ".jpg");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
			goto IL_0073;
		}
		result = true;
		goto IL_0073;
		IL_0073:
		return result;
	}

	public void method_6(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(F9.Text, "--", TextCompare: false) != 0)
			{
				string expression = F9.Text;
				string[] array = Strings.Split(expression, ".");
				ProgressBar1.Value = Conversions.ToInteger(array[1]);
				F9.Text = array[1];
				F9.Visible = true;
				vmethod_11().Stop();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			vmethod_11().Stop();
			ProjectData.ClearProjectError();
		}
	}

	public void method_7(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
	}

	public void method_8(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_9(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}
}
