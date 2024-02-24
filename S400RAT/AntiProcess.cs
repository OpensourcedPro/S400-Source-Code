using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class AntiProcess : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("CCC")]
	public Panel panel_0;

	[AccessedThroughProperty("LProc")]
	[CompilerGenerated]
	public ListView listView_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader columnHeader_0;

	[AccessedThroughProperty("Guna2GradientButton3")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Addd")]
	public Guna2GradientButton guna2GradientButton_1;

	[AccessedThroughProperty("Label22")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("T1")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("L1")]
	[CompilerGenerated]
	public ListView listView_1;

	[AccessedThroughProperty("ColumnHeader2")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_1;

	[AccessedThroughProperty("Label3")]
	[CompilerGenerated]
	public Label label_1;

	[AccessedThroughProperty("panel5")]
	[CompilerGenerated]
	public Panel EbNghAbmXo;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
	public Label label_2;

	[AccessedThroughProperty("w")]
	[CompilerGenerated]
	public Label label_3;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[AccessedThroughProperty("Label2")]
	[CompilerGenerated]
	public Label label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	public Label label_6;

	[AccessedThroughProperty("pictureBox3")]
	[CompilerGenerated]
	public PictureBox pictureBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("label9")]
	public Label label_7;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	public PictureBox pictureBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("ContextMenuStrip1")]
	public ContextMenuStrip contextMenuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("FunToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_1;

	[AccessedThroughProperty("Remove")]
	[CompilerGenerated]
	public ContextMenuStrip contextMenuStrip_1;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_2;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_0;

	public Client sk;

	public Client C;

	public static string SS;

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
			return panel_0;
		}
		[CompilerGenerated]
		set
		{
			panel_0 = value;
		}
	}

	internal virtual ListView LProc
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
			EventHandler value2 = OkbgQkbEco;
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

	internal virtual Guna2GradientButton Addd
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

	public virtual Label Label22
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
			EventHandler value2 = method_6;
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

	internal virtual ListView L1
	{
		[CompilerGenerated]
		get
		{
			return listView_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_4;
			ListView listView = listView_1;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			listView_1 = value;
			listView = listView_1;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	public virtual Label Label3
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

	public virtual Panel panel5
	{
		[CompilerGenerated]
		get
		{
			return EbNghAbmXo;
		}
		[CompilerGenerated]
		set
		{
			EbNghAbmXo = value;
		}
	}

	internal virtual Label n
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

	internal virtual Label w
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

	public virtual Label Label1
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

	public virtual PictureBox PictureBox4
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

	public virtual ContextMenuStrip ContextMenuStrip1
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

	internal virtual ToolStripMenuItem FunToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_1;
			ToolStripMenuItem toolStripMenuItem = toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			toolStripMenuItem_0 = value;
			toolStripMenuItem = toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
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

	public virtual ContextMenuStrip Remove
	{
		[CompilerGenerated]
		get
		{
			return contextMenuStrip_1;
		}
		[CompilerGenerated]
		set
		{
			contextMenuStrip_1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_9;
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

	public AntiProcess()
	{
		base.Load += AntiProcess_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AntiProcess));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		CCC = new Panel();
		PictureBox4 = new PictureBox();
		LProc = new ListView();
		vmethod_5(new ColumnHeader());
		Remove = new ContextMenuStrip(icontainer_0);
		ToolStripMenuItem2 = new ToolStripMenuItem();
		Guna2GradientButton3 = new Guna2GradientButton();
		Addd = new Guna2GradientButton();
		Label22 = new Label();
		T1 = new Guna2TextBox();
		panel5 = new Panel();
		n = new Label();
		w = new Label();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		Label7 = new Label();
		Label1 = new Label();
		pictureBox3 = new PictureBox();
		label9 = new Label();
		Panel1 = new Panel();
		PictureBox2 = new PictureBox();
		L1 = new ListView();
		vmethod_7(new ColumnHeader());
		ContextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		FunToolStripMenuItem1 = new ToolStripMenuItem();
		Label3 = new Label();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_9(new Timer(icontainer_0));
		CCC.SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		Remove.SuspendLayout();
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		ContextMenuStrip1.SuspendLayout();
		SuspendLayout();
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BackColor = Color.Transparent;
		Guna2ControlBox1.BorderColor = Color.Transparent;
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(795, 2);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 120;
		CCC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(PictureBox4);
		CCC.Controls.Add(LProc);
		CCC.Controls.Add(Guna2GradientButton3);
		CCC.Controls.Add(Addd);
		CCC.Controls.Add(Label22);
		CCC.Controls.Add(T1);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(8, 137);
		CCC.Name = "CCC";
		CCC.Size = new Size(426, 363);
		CCC.TabIndex = 119;
		PictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox4.Location = new Point(368, 6);
		PictureBox4.Name = "PictureBox4";
		PictureBox4.Size = new Size(48, 38);
		PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox4.TabIndex = 120;
		PictureBox4.TabStop = false;
		LProc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		LProc.BackColor = Color.FromArgb(46, 51, 73);
		LProc.Columns.AddRange(new ColumnHeader[1] { vmethod_4() });
		LProc.ContextMenuStrip = Remove;
		LProc.ForeColor = Color.White;
		LProc.HeaderStyle = ColumnHeaderStyle.None;
		LProc.HideSelection = false;
		LProc.Location = new Point(12, 50);
		LProc.Name = "LProc";
		LProc.Size = new Size(404, 160);
		LProc.TabIndex = 118;
		LProc.UseCompatibleStateImageBehavior = false;
		LProc.View = View.Details;
		vmethod_4().Width = 364;
		Remove.BackColor = Color.Black;
		Remove.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		Remove.ImageScalingSize = new Size(32, 32);
		Remove.ImeMode = ImeMode.Disable;
		Remove.Items.AddRange(new ToolStripItem[1] { ToolStripMenuItem2 });
		Remove.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		Remove.Name = "ContextMenuStrip1";
		Remove.RenderMode = ToolStripRenderMode.Professional;
		Remove.Size = new Size(131, 42);
		ToolStripMenuItem2.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem2.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem2.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem2.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image");
		ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		ToolStripMenuItem2.Size = new Size(130, 38);
		ToolStripMenuItem2.Text = "Delete";
		Guna2GradientButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Guna2GradientButton3.Animated = true;
		Guna2GradientButton3.BackColor = Color.Transparent;
		Guna2GradientButton3.CheckedState.Parent = Guna2GradientButton3;
		Guna2GradientButton3.CustomImages.Parent = Guna2GradientButton3;
		Guna2GradientButton3.FillColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton3.FillColor2 = Color.FromArgb(24, 30, 54);
		Guna2GradientButton3.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton3.ForeColor = Color.White;
		Guna2GradientButton3.HoverState.Parent = Guna2GradientButton3;
		Guna2GradientButton3.IndicateFocus = true;
		Guna2GradientButton3.Location = new Point(12, 296);
		Guna2GradientButton3.Name = "Guna2GradientButton3";
		Guna2GradientButton3.ShadowDecoration.Parent = Guna2GradientButton3;
		Guna2GradientButton3.Size = new Size(394, 53);
		Guna2GradientButton3.TabIndex = 117;
		Guna2GradientButton3.Text = "OK";
		Guna2GradientButton3.UseTransparentBackground = true;
		Addd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Addd.Animated = true;
		Addd.BackColor = Color.Transparent;
		Addd.CheckedState.Parent = Addd;
		Addd.CustomImages.Parent = Addd;
		Addd.FillColor = Color.FromArgb(24, 30, 54);
		Addd.FillColor2 = Color.FromArgb(24, 30, 54);
		Addd.Font = new Font("Segoe UI", 9f);
		Addd.ForeColor = Color.White;
		Addd.HoverState.Parent = Addd;
		Addd.IndicateFocus = true;
		Addd.Location = new Point(311, 249);
		Addd.Name = "Addd";
		Addd.ShadowDecoration.Parent = Addd;
		Addd.Size = new Size(95, 40);
		Addd.TabIndex = 112;
		Addd.Text = "Add";
		Addd.UseTransparentBackground = true;
		Label22.AutoSize = true;
		Label22.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label22.ForeColor = Color.White;
		Label22.Location = new Point(7, 6);
		Label22.Name = "Label22";
		Label22.Size = new Size(164, 25);
		Label22.TabIndex = 0;
		Label22.Text = "Terminate Process";
		T1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
		T1.Location = new Point(12, 215);
		T1.Margin = new Padding(3, 2, 3, 2);
		T1.Name = "T1";
		T1.PasswordChar = '\0';
		T1.PlaceholderForeColor = Color.Gray;
		T1.PlaceholderText = "Process Name";
		T1.SelectedText = "";
		T1.ShadowDecoration.Parent = T1;
		T1.Size = new Size(394, 29);
		T1.Style = TextBoxStyle.Material;
		T1.TabIndex = 37;
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
		panel5.Location = new Point(-1, -1);
		panel5.Name = "panel5";
		panel5.Size = new Size(370, 125);
		panel5.TabIndex = 121;
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
		PictureBox1.Location = new Point(309, 3);
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
		Label2.Size = new Size(115, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Anti Process";
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
		pictureBox3.Location = new Point(309, 59);
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
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(37, 42, 64);
		Panel1.Controls.Add(PictureBox2);
		Panel1.Controls.Add(L1);
		Panel1.Controls.Add(Label3);
		Panel1.ForeColor = Color.Transparent;
		Panel1.Location = new Point(440, 137);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(391, 363);
		Panel1.TabIndex = 122;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(332, 6);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(48, 38);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 119;
		PictureBox2.TabStop = false;
		L1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L1.BackColor = Color.FromArgb(46, 51, 73);
		L1.Columns.AddRange(new ColumnHeader[1] { vmethod_6() });
		L1.ContextMenuStrip = ContextMenuStrip1;
		L1.ForeColor = Color.White;
		L1.HeaderStyle = ColumnHeaderStyle.None;
		L1.HideSelection = false;
		L1.Location = new Point(12, 50);
		L1.Name = "L1";
		L1.Size = new Size(368, 299);
		L1.TabIndex = 118;
		L1.UseCompatibleStateImageBehavior = false;
		L1.View = View.Details;
		vmethod_6().Width = 364;
		ContextMenuStrip1.BackColor = Color.Black;
		ContextMenuStrip1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		ContextMenuStrip1.ImageScalingSize = new Size(32, 32);
		ContextMenuStrip1.ImeMode = ImeMode.Disable;
		ContextMenuStrip1.Items.AddRange(new ToolStripItem[2] { ToolStripMenuItem1, FunToolStripMenuItem1 });
		ContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		ContextMenuStrip1.Name = "ContextMenuStrip1";
		ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
		ContextMenuStrip1.Size = new Size(140, 80);
		ToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
		ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		ToolStripMenuItem1.Size = new Size(139, 38);
		ToolStripMenuItem1.Text = "Refresh";
		FunToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		FunToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		FunToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		FunToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("FunToolStripMenuItem1.Image");
		FunToolStripMenuItem1.Name = "FunToolStripMenuItem1";
		FunToolStripMenuItem1.Size = new Size(139, 38);
		FunToolStripMenuItem1.Text = "Add";
		Label3.AutoSize = true;
		Label3.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label3.ForeColor = Color.White;
		Label3.Location = new Point(7, 6);
		Label3.Name = "Label3";
		Label3.Size = new Size(109, 25);
		Label3.TabIndex = 0;
		Label3.Text = "Process List";
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(771, 6);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 132;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_8().Enabled = true;
		vmethod_8().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(842, 512);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Panel1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(CCC);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "AntiProcess";
		Text = "AntiProcess";
		CCC.ResumeLayout(performLayout: false);
		CCC.PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		Remove.ResumeLayout(performLayout: false);
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		Panel1.ResumeLayout(performLayout: false);
		Panel1.PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		ContextMenuStrip1.ResumeLayout(performLayout: false);
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
	internal virtual ColumnHeader vmethod_6()
	{
		return columnHeader_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(ColumnHeader WithEventsValue)
	{
		columnHeader_1 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_8()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_9(Timer WithEventsValue)
	{
		EventHandler value = method_8;
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

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	public void AntiProcess_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
		C.Send("Proc");
		SetWindowTheme(L1.Handle, "explorer", null);
		SetWindowTheme(LProc.Handle, "explorer", null);
		try
		{
			string sS = SS;
			string[] array = Strings.Split(sS, "|'|");
			n.Text = array[0];
			w.Text = array[1];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = selectedItem.Text;
				listViewItem2.ImageKey = selectedItem.ImageKey;
				LProc.Items.Add(listViewItem2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		LProc.Items.Add(T1.Text);
		T1.Text = "";
	}

	public void method_3(object sender, EventArgs e)
	{
		C.Send("Proc");
	}

	public void OkbgQkbEco(object sender, EventArgs e)
	{
		string text = string.Empty;
		int num = 0;
		foreach (ListViewItem item in LProc.Items)
		{
			_ = item;
			text = text + LProc.Items[num].SubItems[0].Text + ",";
			num++;
		}
		C.Send("K" + Class7.string_1 + text + Class7.string_1);
		Close();
	}

	public void method_4(object sender, EventArgs e)
	{
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
	}

	public void method_7(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_8(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}

	public void method_9(object sender, EventArgs e)
	{
		foreach (ListViewItem selectedItem in LProc.SelectedItems)
		{
			LProc.Items.RemoveAt(selectedItem.Index);
		}
	}
}
