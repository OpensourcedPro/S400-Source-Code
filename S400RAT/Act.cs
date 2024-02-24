using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Act : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("panel5")]
	[CompilerGenerated]
	public Panel panel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("n")]
	public Label label_0;

	[AccessedThroughProperty("w")]
	[CompilerGenerated]
	public Label label_1;

	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[AccessedThroughProperty("pictureBox3")]
	public PictureBox pictureBox_1;

	[AccessedThroughProperty("label9")]
	[CompilerGenerated]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2ControlBox1")]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_2;

	[AccessedThroughProperty("L1")]
	[CompilerGenerated]
	public ListView listView_0;

	[AccessedThroughProperty("ColumnHeader2")]
	[CompilerGenerated]
	public ColumnHeader columnHeader_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	public Label label_6;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	public Timer timer_0;

	[AccessedThroughProperty("ContextMenuStrip1")]
	[CompilerGenerated]
	public ContextMenuStrip contextMenuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_0;

	[CompilerGenerated]
	[AccessedThroughProperty("FunToolStripMenuItem1")]
	public ToolStripMenuItem toolStripMenuItem_1;

	[AccessedThroughProperty("ImageList1")]
	[CompilerGenerated]
	public ImageList imageList_0;

	[AccessedThroughProperty("ColumnHeader1")]
	[CompilerGenerated]
	public ColumnHeader EmcrZnnyDJ;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_1;

	public Client C;

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
			EventHandler value2 = method_5;
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
			EventHandler value2 = jtGruEbDiV;
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

	internal virtual ListView L1
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

	public virtual Label Label3
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
			CancelEventHandler value2 = method_4;
			ContextMenuStrip contextMenuStrip = contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening -= value2;
			}
			contextMenuStrip_0 = value;
			contextMenuStrip = contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_2;
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

	internal virtual ToolStripMenuItem FunToolStripMenuItem1
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

	public Act()
	{
		base.Load += Act_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Act));
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
		Panel1 = new Panel();
		PictureBox2 = new PictureBox();
		L1 = new ListView();
		vmethod_5(new ColumnHeader());
		vmethod_11(new ColumnHeader());
		ContextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		FunToolStripMenuItem1 = new ToolStripMenuItem();
		vmethod_9(new ImageList(icontainer_0));
		Label3 = new Label();
		vmethod_7(new Timer(icontainer_0));
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_13(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		ContextMenuStrip1.SuspendLayout();
		SuspendLayout();
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
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
		panel5.Location = new Point(0, -1);
		panel5.Name = "panel5";
		panel5.Size = new Size(319, 124);
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
		PictureBox1.Location = new Point(258, 7);
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
		Label2.Size = new Size(146, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Active Windows";
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
		pictureBox3.Location = new Point(258, 59);
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
		Guna2ControlBox1.Location = new Point(506, -1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 127;
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(37, 42, 64);
		Panel1.Controls.Add(PictureBox2);
		Panel1.Controls.Add(L1);
		Panel1.Controls.Add(Label3);
		Panel1.ForeColor = Color.Transparent;
		Panel1.Location = new Point(9, 129);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(528, 328);
		Panel1.TabIndex = 129;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(467, 6);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(48, 38);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 119;
		PictureBox2.TabStop = false;
		L1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		L1.BackColor = Color.FromArgb(46, 51, 73);
		L1.Columns.AddRange(new ColumnHeader[2]
		{
			vmethod_4(),
			vmethod_10()
		});
		L1.ContextMenuStrip = ContextMenuStrip1;
		L1.ForeColor = Color.White;
		L1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		L1.HideSelection = false;
		L1.LargeImageList = vmethod_8();
		L1.Location = new Point(12, 50);
		L1.Name = "L1";
		L1.Size = new Size(505, 264);
		L1.SmallImageList = vmethod_8();
		L1.StateImageList = vmethod_8();
		L1.TabIndex = 118;
		L1.UseCompatibleStateImageBehavior = false;
		L1.View = View.Details;
		vmethod_4().Text = "Name";
		vmethod_4().Width = 346;
		vmethod_10().Text = "PID";
		vmethod_10().Width = 111;
		ContextMenuStrip1.BackColor = Color.Black;
		ContextMenuStrip1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
		ContextMenuStrip1.ImageScalingSize = new Size(32, 32);
		ContextMenuStrip1.ImeMode = ImeMode.Disable;
		ContextMenuStrip1.Items.AddRange(new ToolStripItem[2] { ToolStripMenuItem1, FunToolStripMenuItem1 });
		ContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
		ContextMenuStrip1.Name = "ContextMenuStrip1";
		ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
		ContextMenuStrip1.Size = new Size(197, 102);
		ToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		ToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		ToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		ToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
		ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		ToolStripMenuItem1.Size = new Size(196, 38);
		ToolStripMenuItem1.Text = "Refresh";
		FunToolStripMenuItem1.BackColor = Color.FromArgb(24, 30, 54);
		FunToolStripMenuItem1.Font = new Font("Arial", 8.25f, FontStyle.Bold);
		FunToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
		FunToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("FunToolStripMenuItem1.Image");
		FunToolStripMenuItem1.Name = "FunToolStripMenuItem1";
		FunToolStripMenuItem1.Size = new Size(196, 38);
		FunToolStripMenuItem1.Text = "Kill";
		vmethod_8().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		vmethod_8().TransparentColor = Color.Transparent;
		vmethod_8().Images.SetKeyName(0, "system_task_48px.png");
		Label3.AutoSize = true;
		Label3.Font = new Font("Nirmala UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label3.ForeColor = Color.White;
		Label3.Location = new Point(7, 6);
		Label3.Name = "Label3";
		Label3.Size = new Size(76, 25);
		Label3.TabIndex = 0;
		Label3.Text = "Process";
		vmethod_6().Enabled = true;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(482, 4);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 131;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_12().Enabled = true;
		vmethod_12().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(549, 469);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Panel1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Act";
		Text = "Act";
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
	internal virtual Timer vmethod_6()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Timer WithEventsValue)
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
	internal virtual ImageList vmethod_8()
	{
		return imageList_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_9(ImageList WithEventsValue)
	{
		imageList_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_10()
	{
		return EmcrZnnyDJ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_11(ColumnHeader WithEventsValue)
	{
		EmcrZnnyDJ = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_12()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_13(Timer WithEventsValue)
	{
		EventHandler value = method_7;
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

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	public void Act_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
		SetWindowTheme(L1.Handle, "explorer", null);
	}

	public void method_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(w.Text, null, TextCompare: false) != 0)
		{
			vmethod_6().Stop();
			C.Send("Past" + Class7.string_1);
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		L1.Items.Clear();
		C.Send("Past" + Class7.string_1);
	}

	public void method_3(object sender, EventArgs e)
	{
		C.Send("kk" + Class7.string_1);
	}

	public void method_4(object sender, CancelEventArgs e)
	{
	}

	public void method_5(object sender, EventArgs e)
	{
	}

	public void method_6(object sender, EventArgs e)
	{
		Hide();
	}

	public void jtGruEbDiV(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
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
