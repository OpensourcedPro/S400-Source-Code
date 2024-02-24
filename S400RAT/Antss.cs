using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;
using SQLABC_ModernUI;

namespace S400RAT;

[DesignerGenerated]
public class Antss : Form
{
	public IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2AnimateWindow1")]
	public Guna2AnimateWindow guna2AnimateWindow_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2BorderlessForm1")]
	public Guna2BorderlessForm guna2BorderlessForm_0;

	[AccessedThroughProperty("CCC")]
	[CompilerGenerated]
	public Panel panel_0;

	[CompilerGenerated]
	[AccessedThroughProperty("Guna2GradientButton3")]
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

	[AccessedThroughProperty("Guna2ControlBox1")]
	[CompilerGenerated]
	public Guna2ControlBox guna2ControlBox_0;

	[AccessedThroughProperty("Contx_Kill")]
	[CompilerGenerated]
	public Guna2ContextMenuStrip guna2ContextMenuStrip_0;

	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	[CompilerGenerated]
	public ToolStripMenuItem toolStripMenuItem_0;

	[AccessedThroughProperty("ListView1")]
	[CompilerGenerated]
	public ListView listView_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader columnHeader_0;

	[CompilerGenerated]
	[AccessedThroughProperty("SqlabC_ControlMini1")]
	public SQLABC_ControlMini sqlabc_ControlMini_0;

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
			guna2TextBox_0 = value;
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

	internal virtual ToolStripMenuItem DeleteToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_0;
		}
		[CompilerGenerated]
		set
		{
			EventHandler value2 = method_3;
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

	internal virtual ListView ListView1
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

	public Antss()
	{
		base.Load += Antss_Load;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Antss));
		vmethod_1(new Guna2AnimateWindow(icontainer_0));
		vmethod_3(new Guna2BorderlessForm(icontainer_0));
		CCC = new Panel();
		ListView1 = new ListView();
		vmethod_7(new ColumnHeader());
		vmethod_5(new Guna2ContextMenuStrip());
		DeleteToolStripMenuItem = new ToolStripMenuItem();
		Guna2GradientButton3 = new Guna2GradientButton();
		Addd = new Guna2GradientButton();
		Label22 = new Label();
		T1 = new Guna2TextBox();
		Guna2ControlBox1 = new Guna2ControlBox();
		SqlabC_ControlMini1 = new SQLABC_ControlMini();
		CCC.SuspendLayout();
		vmethod_4().SuspendLayout();
		SuspendLayout();
		vmethod_0().AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
		vmethod_0().TargetForm = this;
		vmethod_2().ContainerControl = this;
		CCC.BackColor = Color.FromArgb(37, 42, 64);
		CCC.Controls.Add(ListView1);
		CCC.Controls.Add(Guna2GradientButton3);
		CCC.Controls.Add(Addd);
		CCC.Controls.Add(Label22);
		CCC.Controls.Add(T1);
		CCC.ForeColor = Color.Transparent;
		CCC.Location = new Point(19, 53);
		CCC.Name = "CCC";
		CCC.Size = new Size(426, 363);
		CCC.TabIndex = 117;
		ListView1.BackColor = Color.FromArgb(46, 51, 73);
		ListView1.Columns.AddRange(new ColumnHeader[1] { vmethod_6() });
		ListView1.ContextMenuStrip = vmethod_4();
		ListView1.ForeColor = Color.White;
		ListView1.HeaderStyle = ColumnHeaderStyle.None;
		ListView1.HideSelection = false;
		ListView1.Location = new Point(12, 34);
		ListView1.Name = "ListView1";
		ListView1.Size = new Size(394, 176);
		ListView1.TabIndex = 118;
		ListView1.UseCompatibleStateImageBehavior = false;
		ListView1.View = View.Details;
		vmethod_6().Width = 364;
		vmethod_4().Items.AddRange(new ToolStripItem[1] { DeleteToolStripMenuItem });
		vmethod_4().Name = "Guna2ContextMenuStrip1";
		vmethod_4().RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
		vmethod_4().RenderStyle.BorderColor = Color.Gainsboro;
		vmethod_4().RenderStyle.ColorTable = null;
		vmethod_4().RenderStyle.RoundedEdges = true;
		vmethod_4().RenderStyle.SelectionArrowColor = Color.White;
		vmethod_4().RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
		vmethod_4().RenderStyle.SelectionForeColor = Color.White;
		vmethod_4().RenderStyle.SeparatorColor = Color.Gainsboro;
		vmethod_4().RenderStyle.TextRenderingHint = TextRenderingHint.SystemDefault;
		vmethod_4().Size = new Size(108, 26);
		DeleteToolStripMenuItem.BackColor = Color.FromArgb(46, 51, 73);
		DeleteToolStripMenuItem.ForeColor = Color.White;
		DeleteToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("DeleteToolStripMenuItem.Image");
		DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
		DeleteToolStripMenuItem.Size = new Size(107, 22);
		DeleteToolStripMenuItem.Text = "Delete";
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
		Addd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
		Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		Guna2ControlBox1.BackColor = Color.Transparent;
		Guna2ControlBox1.BorderColor = Color.Transparent;
		Guna2ControlBox1.FillColor = Color.FromArgb(46, 51, 73);
		Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
		Guna2ControlBox1.IconColor = Color.White;
		Guna2ControlBox1.Location = new Point(418, 0);
		Guna2ControlBox1.Name = "Guna2ControlBox1";
		Guna2ControlBox1.PressedColor = Color.FromArgb(24, 30, 54);
		Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
		Guna2ControlBox1.Size = new Size(45, 29);
		Guna2ControlBox1.TabIndex = 118;
		SqlabC_ControlMini1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		SqlabC_ControlMini1.BackColor = Color.White;
		SqlabC_ControlMini1.BaseColor = Color.FromArgb(46, 51, 73);
		SqlabC_ControlMini1.Font = new Font("Marlett", 12f);
		SqlabC_ControlMini1.Location = new Point(394, 6);
		SqlabC_ControlMini1.Name = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.Size = new Size(18, 18);
		SqlabC_ControlMini1.TabIndex = 132;
		SqlabC_ControlMini1.Text = "SqlabC_ControlMini1";
		SqlabC_ControlMini1.TextColor = Color.FromArgb(243, 243, 243);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(46, 51, 73);
		base.ClientSize = new Size(464, 435);
		base.Controls.Add(SqlabC_ControlMini1);
		base.Controls.Add(Guna2ControlBox1);
		base.Controls.Add(CCC);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Antss";
		Text = "Ant";
		CCC.ResumeLayout(performLayout: false);
		CCC.PerformLayout();
		vmethod_4().ResumeLayout(performLayout: false);
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
	internal virtual Guna2ContextMenuStrip vmethod_4()
	{
		return guna2ContextMenuStrip_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_5(Guna2ContextMenuStrip WithEventsValue)
	{
		guna2ContextMenuStrip_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ColumnHeader vmethod_6()
	{
		return columnHeader_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_7(ColumnHeader WithEventsValue)
	{
		columnHeader_0 = WithEventsValue;
	}

	public void method_1(object sender, EventArgs e)
	{
		string text = string.Empty;
		int num = 0;
		foreach (ListViewItem item in ListView1.Items)
		{
			_ = item;
			text = text + ListView1.Items[num].SubItems[0].Text + ",";
			num++;
		}
		Hide();
	}

	public void method_2(object sender, EventArgs e)
	{
		ListView1.Items.Add(T1.Text);
		T1.Text = "";
	}

	public void method_3(object sender, EventArgs e)
	{
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			ListView1.Items.RemoveAt(selectedItem.Index);
		}
	}

	public void Antss_Load(object sender, EventArgs e)
	{
	}

	public void method_4(object sender, EventArgs e)
	{
	}
}
