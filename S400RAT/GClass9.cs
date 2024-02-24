using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

[DesignerGenerated]
public class GClass9 : ListView
{
	public sealed class GClass10 : IComparer
	{
		public int int_0;

		public SortOrder sortOrder_0;

		public GClass10(int int_1, SortOrder sortOrder_1)
		{
			int_0 = int_1;
			sortOrder_0 = sortOrder_1;
		}

		public int Compare(object object_0, object object_1)
		{
			ListViewItem listViewItem = (ListViewItem)object_0;
			ListViewItem listViewItem2 = (ListViewItem)object_1;
			string text = ((listViewItem.SubItems.Count > int_0) ? listViewItem.SubItems[int_0].Text : string.Empty);
			string text2 = ((listViewItem2.SubItems.Count <= int_0) ? string.Empty : listViewItem2.SubItems[int_0].Text);
			if (sortOrder_0 != SortOrder.Ascending)
			{
				if (!(Versioned.IsNumeric(text) & Versioned.IsNumeric(text2)))
				{
					if (!(Information.IsDate(text) & Information.IsDate(text2)))
					{
						return string.Compare(text2, text);
					}
					return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
				}
				return Conversion.Val(text2).CompareTo(Conversion.Val(text));
			}
			if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
			{
				return Conversion.Val(text).CompareTo(Conversion.Val(text2));
			}
			if (!(Information.IsDate(text) & Information.IsDate(text2)))
			{
				return string.Compare(text, text2);
			}
			return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
		}

		public int Compare1(object x, object y)
		{
			return 0;
		}

		int IComparer.Compare(object x, object y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare1
			return this.Compare1(x, y);
		}
	}

	public ColumnHeader columnHeader_0;

	public IContainer icontainer_0;

	public ListViewItem listViewItem_0;

	public Point point_0;

	public Point point_1;

	public GClass9()
	{
		base.ParentChanged += GClass9_ParentChanged;
		base.MouseMove += GClass9_MouseMove;
		base.MouseUp += GClass9_MouseUp;
		base.ColumnClick += GClass9_ColumnClick;
		base.KeyDown += GClass9_KeyDown;
		base.MouseDown += GClass9_MouseDown;
		listViewItem_0 = null;
		point_0 = Point.Empty;
		point_1 = Point.Empty;
		AllowDrop = false;
		Font = new Font("arial", 8f, FontStyle.Bold);
		Dock = DockStyle.Fill;
		base.FullRowSelect = true;
		base.View = View.Details;
		base.OwnerDraw = true;
		SetStyle(ControlStyles.UserPaint, value: false);
		DoubleBuffered = true;
		SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.EnableNotifyMessage, value: true);
	}

	[CompilerGenerated]
	public void method_0(object sender, EventArgs e)
	{
		method_1();
	}

	[CompilerGenerated]
	public void method_4(object sender, EventArgs e)
	{
		method_1();
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

	public void GClass9_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		lock (this)
		{
			if (e.Column == -1)
			{
				return;
			}
			try
			{
				ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), null, "Columns", new object[1] { e.Column }, null, null, null);
				SortOrder sortOrder_;
				if (columnHeader_0 == null)
				{
					sortOrder_ = SortOrder.Ascending;
					columnHeader.Tag = "+";
				}
				else if (columnHeader.Equals(columnHeader_0))
				{
					if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_0.Tag), "+", TextCompare: false))
					{
						sortOrder_ = SortOrder.Descending;
						columnHeader_0.Tag = "-";
					}
					else
					{
						columnHeader_0.Tag = "+";
						sortOrder_ = SortOrder.Ascending;
					}
				}
				else
				{
					sortOrder_ = SortOrder.Ascending;
				}
				columnHeader_0 = columnHeader;
				if (columnHeader_0.Tag == null)
				{
					columnHeader_0.Tag = "+";
				}
				if (sender != null)
				{
					NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), null, "ListViewItemSorter", new object[1]
					{
						new GClass10(e.Column, sortOrder_)
					}, null, null);
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), null, "Sort", new object[0], null, null, null, IgnoreReturn: true);
					NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), null, "ListViewItemSorter", new object[1], null, null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	public void GClass9_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Space)
		{
			method_3();
		}
		if (!((e.KeyCode == Keys.A) & e.Control))
		{
			return;
		}
		IEnumerator enumerator = null;
		try
		{
			enumerator = base.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				listViewItem.Selected = true;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void GClass9_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			listViewItem_0 = GetItemAt(e.X, e.Y);
			point_0 = e.Location;
		}
	}

	public void GClass9_MouseMove(object sender, MouseEventArgs e)
	{
		point_1 = e.Location;
		if (!(point_0 != Point.Empty))
		{
			return;
		}
		if (listViewItem_0 != null && listViewItem_0.Index == -1)
		{
			listViewItem_0 = null;
		}
		if (!((e.Button == MouseButtons.Left) & (listViewItem_0 != null)) || listViewItem_0 == null)
		{
			return;
		}
		ListViewItem itemAt = GetItemAt(e.X, e.Y);
		if (itemAt == null)
		{
			return;
		}
		IEnumerator enumerator = null;
		if (itemAt.Index > listViewItem_0.Index)
		{
			int index = itemAt.Index;
			for (int i = listViewItem_0.Index; i <= index; i++)
			{
				if (!base.SelectedIndices.Contains(i))
				{
					base.SelectedIndices.Add(i);
				}
			}
			{
				foreach (object selectedIndex in base.SelectedIndices)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(selectedIndex));
					if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), listViewItem_0.Index, TextCompare: false)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, TextCompare: false))))))
					{
						base.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)));
					}
				}
				return;
			}
		}
		int index2 = listViewItem_0.Index;
		for (int j = itemAt.Index; j <= index2; j++)
		{
			if (!base.SelectedIndices.Contains(j))
			{
				base.SelectedIndices.Add(j);
			}
		}
		try
		{
			enumerator = base.SelectedIndices.GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current));
				if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, TextCompare: false)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), listViewItem_0.Index, TextCompare: false))))))
				{
					base.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)));
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void GClass9_MouseUp(object sender, MouseEventArgs e)
	{
		listViewItem_0 = null;
		point_0 = Point.Empty;
	}

	public void GClass9_ParentChanged(object sender, EventArgs e)
	{
		try
		{
			if (base.Parent != null)
			{
				base.Parent.Resize -= delegate
				{
					method_1();
				};
			}
			base.Parent.Resize += delegate
			{
				method_1();
			};
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	public void method_5()
	{
		icontainer_0 = new Container();
	}

	public void method_1()
	{
		method_3();
	}

	public ListViewItem[] method_2()
	{
		ListViewItem[] result;
		lock (this)
		{
			List<ListViewItem> list = new List<ListViewItem>();
			if (base.Items.Count == 0)
			{
				return list.ToArray();
			}
			try
			{
				ListViewItem topItem = base.TopItem;
				list.Add(topItem);
				int num = base.Items.Count - 1;
				for (int i = topItem.Index + 1; i <= num; i++)
				{
					try
					{
						topItem = base.Items[i];
						if (base.Bounds.IntersectsWith(base.Items[i].Bounds))
						{
							list.Add(topItem);
							continue;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception projectError = ex;
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception projectError2 = ex2;
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
			result = list.ToArray();
		}
		return result;
	}

	public void method_3()
	{
		try
		{
			if (base.Columns.Count == 0)
			{
				return;
			}
			if (base.Items.Count != 0)
			{
				int num = base.Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					base.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
				}
			}
			else
			{
				base.Columns[base.Columns.Count - 1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
	}

	protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs drawListViewColumnHeaderEventArgs_0)
	{
		try
		{
			StringFormat format = new StringFormat
			{
				FormatFlags = StringFormatFlags.NoWrap,
				Trimming = StringTrimming.EllipsisCharacter,
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			};
			Rectangle rect = new Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height);
			drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(new Pen(ControlPaint.Light(BackColor, 0.1f)).Brush, rect);
			drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Font, new Pen(ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format);
			drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(new Pen(ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height);
			drawListViewColumnHeaderEventArgs_0.DrawDefault = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		base.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0);
	}

	protected override void OnDrawItem(DrawListViewItemEventArgs drawListViewItemEventArgs_0)
	{
		drawListViewItemEventArgs_0.DrawDefault = true;
		base.OnDrawItem(drawListViewItemEventArgs_0);
	}

	protected override void OnDrawSubItem(DrawListViewSubItemEventArgs drawListViewSubItemEventArgs_0)
	{
		drawListViewSubItemEventArgs_0.DrawDefault = true;
		base.OnDrawSubItem(drawListViewSubItemEventArgs_0);
	}

	protected override void OnNotifyMessage(Message message_0)
	{
		if (message_0.Msg != 20)
		{
			base.OnNotifyMessage(message_0);
		}
	}
}
