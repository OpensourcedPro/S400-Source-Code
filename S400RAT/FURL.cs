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
public class FURL : Form
{
	public IContainer icontainer_0;

	[AccessedThroughProperty("label8")]
	[CompilerGenerated]
	public Label label_0;

	[AccessedThroughProperty("Guna2CircleProgressBar2")]
	[CompilerGenerated]
	public Guna2CircleProgressBar guna2CircleProgressBar_0;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox2")]
	public Guna2TextBox guna2TextBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("TextBox1")]
	public Guna2TextBox guna2TextBox_1;

	[AccessedThroughProperty("panel1")]
	[CompilerGenerated]
	public Panel panel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton2")]
	public Guna2GradientButton guna2GradientButton_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton1")]
	public Guna2GradientButton guna2GradientButton_1;

	[AccessedThroughProperty("panel2")]
	[CompilerGenerated]
	public Panel panel_1;

	[AccessedThroughProperty("pictureBox1")]
	[CompilerGenerated]
	public PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox2")]
	public PictureBox pictureBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

	public bool IsOK;

	public virtual Label label8
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

	internal virtual Guna2CircleProgressBar Guna2CircleProgressBar2
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

	internal virtual Guna2TextBox TextBox2
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

	internal virtual Guna2TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return guna2TextBox_1;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AjetlwGuLe;
			Guna2TextBox guna2TextBox = guna2TextBox_1;
			if (guna2TextBox != null)
			{
				guna2TextBox.TextChanged -= value2;
			}
			guna2TextBox_1 = value;
			guna2TextBox = guna2TextBox_1;
			if (guna2TextBox != null)
			{
				guna2TextBox.TextChanged += value2;
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

	internal virtual Guna2GradientButton Guna2GradientButton2
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

	internal virtual PictureBox PictureBox2
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FURL));
		label8 = new Label();
		Guna2CircleProgressBar2 = new Guna2CircleProgressBar();
		TextBox2 = new Guna2TextBox();
		TextBox1 = new Guna2TextBox();
		panel1 = new Panel();
		Guna2GradientButton2 = new Guna2GradientButton();
		Guna2GradientButton1 = new Guna2GradientButton();
		panel2 = new Panel();
		PictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		Guna2ControlBox1 = new Guna2ControlBox();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		label8.AutoSize = true;
		label8.Font = new Font("Nirmala UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.ForeColor = Color.FromArgb(158, 161, 176);
		label8.Location = new Point(391, 179);
		label8.Name = "label8";
		label8.Size = new Size(179, 34);
		label8.TabIndex = 97;
		label8.Text = "Put a download URL and add\r\nthe file name with the format";
		Guna2CircleProgressBar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		Guna2CircleProgressBar2.Animated = true;
		Guna2CircleProgressBar2.FillThickness = 10;
		Guna2CircleProgressBar2.ForeColor = Color.FromArgb(0, 126, 249);
		Guna2CircleProgressBar2.Location = new Point(617, 75);
		Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2";
		Guna2CircleProgressBar2.ProgressBrushMode = BrushMode.Solid;
		Guna2CircleProgressBar2.ProgressColor = Color.FromArgb(0, 192, 0);
		Guna2CircleProgressBar2.ProgressEndCap = LineCap.Round;
		Guna2CircleProgressBar2.ProgressStartCap = LineCap.Round;
		Guna2CircleProgressBar2.ProgressThickness = 10;
		Guna2CircleProgressBar2.ShadowDecoration.Mode = ShadowMode.Circle;
		Guna2CircleProgressBar2.ShadowDecoration.Parent = Guna2CircleProgressBar2;
		Guna2CircleProgressBar2.Size = new Size(64, 61);
		Guna2CircleProgressBar2.TabIndex = 96;
		Guna2CircleProgressBar2.Value = 45;
		TextBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		TextBox2.Animated = true;
		TextBox2.AutoRoundedCorners = true;
		TextBox2.BackColor = Color.FromArgb(46, 51, 73);
		TextBox2.BorderColor = Color.FromArgb(0, 126, 249);
		TextBox2.BorderRadius = 13;
		TextBox2.BorderStyle = DashStyle.Custom;
		TextBox2.Cursor = Cursors.IBeam;
		TextBox2.DefaultText = "";
		TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
		TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
		TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
		TextBox2.DisabledState.Parent = TextBox2;
		TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
		TextBox2.FillColor = Color.FromArgb(46, 51, 73);
		TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox2.FocusedState.Parent = TextBox2;
		TextBox2.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		TextBox2.ForeColor = Color.White;
		TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox2.HoverState.Parent = TextBox2;
		TextBox2.Location = new Point(192, 181);
		TextBox2.Margin = new Padding(3, 2, 3, 2);
		TextBox2.Name = "TextBox2";
		TextBox2.PasswordChar = '\0';
		TextBox2.PlaceholderForeColor = Color.Gray;
		TextBox2.PlaceholderText = "Run As ";
		TextBox2.SelectedText = "";
		TextBox2.ShadowDecoration.Parent = TextBox2;
		TextBox2.Size = new Size(150, 29);
		TextBox2.Style = TextBoxStyle.Material;
		TextBox2.TabIndex = 95;
		TextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
		TextBox1.FillColor = Color.FromArgb(46, 51, 73);
		TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.FocusedState.Parent = TextBox1;
		TextBox1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
		TextBox1.ForeColor = Color.White;
		TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
		TextBox1.HoverState.Parent = TextBox1;
		TextBox1.Location = new Point(192, 140);
		TextBox1.Margin = new Padding(3, 2, 3, 2);
		TextBox1.Name = "TextBox1";
		TextBox1.PasswordChar = '\0';
		TextBox1.PlaceholderForeColor = Color.Gray;
		TextBox1.PlaceholderText = "URL";
		TextBox1.SelectedText = "";
		TextBox1.ShadowDecoration.Parent = TextBox1;
		TextBox1.Size = new Size(466, 29);
		TextBox1.Style = TextBoxStyle.Material;
		TextBox1.TabIndex = 94;
		panel1.BackColor = Color.FromArgb(24, 30, 54);
		panel1.Controls.Add(Guna2GradientButton2);
		panel1.Controls.Add(Guna2GradientButton1);
		panel1.Controls.Add(panel2);
		panel1.Dock = DockStyle.Left;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(186, 222);
		panel1.TabIndex = 92;
		Guna2GradientButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Guna2GradientButton2.Animated = true;
		Guna2GradientButton2.AutoRoundedCorners = true;
		Guna2GradientButton2.BackColor = Color.Transparent;
		Guna2GradientButton2.BorderRadius = 19;
		Guna2GradientButton2.CheckedState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.CustomImages.Parent = Guna2GradientButton2;
		Guna2GradientButton2.FillColor = Color.FromArgb(46, 51, 73);
		Guna2GradientButton2.FillColor2 = Color.FromArgb(46, 51, 73);
		Guna2GradientButton2.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton2.ForeColor = Color.White;
		Guna2GradientButton2.HoverState.Parent = Guna2GradientButton2;
		Guna2GradientButton2.IndicateFocus = true;
		Guna2GradientButton2.Location = new Point(7, 170);
		Guna2GradientButton2.Name = "Guna2GradientButton2";
		Guna2GradientButton2.ShadowDecoration.Parent = Guna2GradientButton2;
		Guna2GradientButton2.Size = new Size(171, 40);
		Guna2GradientButton2.TabIndex = 80;
		Guna2GradientButton2.Text = "Cancel";
		Guna2GradientButton2.UseTransparentBackground = true;
		Guna2GradientButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		Guna2GradientButton1.Animated = true;
		Guna2GradientButton1.AutoRoundedCorners = true;
		Guna2GradientButton1.BackColor = Color.Transparent;
		Guna2GradientButton1.BorderRadius = 19;
		Guna2GradientButton1.CheckedState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.CustomImages.Parent = Guna2GradientButton1;
		Guna2GradientButton1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2GradientButton1.FillColor2 = Color.FromArgb(46, 51, 73);
		Guna2GradientButton1.Font = new Font("Segoe UI", 9f);
		Guna2GradientButton1.ForeColor = Color.White;
		Guna2GradientButton1.HoverState.Parent = Guna2GradientButton1;
		Guna2GradientButton1.IndicateFocus = true;
		Guna2GradientButton1.Location = new Point(7, 124);
		Guna2GradientButton1.Name = "Guna2GradientButton1";
		Guna2GradientButton1.ShadowDecoration.Parent = Guna2GradientButton1;
		Guna2GradientButton1.Size = new Size(171, 40);
		Guna2GradientButton1.TabIndex = 77;
		Guna2GradientButton1.Text = "Go";
		Guna2GradientButton1.UseTransparentBackground = true;
		panel2.Controls.Add(PictureBox2);
		panel2.Controls.Add(pictureBox1);
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(186, 118);
		panel2.TabIndex = 0;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox2.Location = new Point(12, 72);
		PictureBox2.Name = "PictureBox2";
		PictureBox2.Size = new Size(162, 42);
		PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		PictureBox2.TabIndex = 99;
		PictureBox2.TabStop = false;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(60, 12);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(63, 56);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BorderColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(650, 0);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 98;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(628, 7);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 134;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(696, 222);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(label8);
		base.Controls.Add(Guna2CircleProgressBar2);
		base.Controls.Add(TextBox2);
		base.Controls.Add(TextBox1);
		base.Controls.Add(panel1);
		ForeColor = Color.LightSteelBlue;
		base.FormBorderStyle = FormBorderStyle.None;
		base.MaximizeBox = false;
		base.Name = "FURL";
		RightToLeftLayout = true;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "FURL";
		panel1.ResumeLayout(performLayout: false);
		panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
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

	public FURL()
	{
		base.KeyDown += FURL_KeyDown;
		base.Load += FURL_Load;
		IsOK = false;
		method_0();
	}

	public void FURL_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_2(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e);
		}
	}

	public void method_1(object sender, EventArgs e)
	{
	}

	public void method_2(object sender, EventArgs e)
	{
		if ((TextBox1.Text.Length > 0) & TextBox1.Text.ToLower().StartsWith("http") & (TextBox2.TextLength > 0))
		{
			IsOK = true;
			Close();
		}
	}

	public void method_3(object sender, EventArgs e)
	{
		Close();
	}

	public void AjetlwGuLe(object sender, EventArgs e)
	{
		try
		{
			TextBox2.Text = Strings.Split(TextBox1.Text, ".")[Strings.Split(TextBox1.Text, ".").Length - 1];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void FURL_Load(object sender, EventArgs e)
	{
	}

	public void method_4(object sender, EventArgs e)
	{
		Hide();
	}
}
