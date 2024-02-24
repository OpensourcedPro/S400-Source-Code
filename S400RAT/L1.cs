using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public sealed class L1 : DataGridView
{
	public delegate DataGridViewRow Delegate1(object[] object_0);

	public delegate DataGridViewRow Delegate2(string string_0, object[] object_0);

	public delegate void Delegate3(DataGridViewRow dataGridViewRow_0);

	public delegate void Delegate4(int int_0);

	public enum GEnum0
	{
		Image = 2,
		Link = 1,
		StretchImage = 3,
		Text = 0
	}

	public Collection collection_0;

	public L1()
	{
		collection_0 = new Collection();
		base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		base.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
		base.RowHeadersVisible = false;
		DoubleBuffered = true;
		base.ShowCellErrors = true;
		base.ShowEditingIcon = true;
		base.ShowRowErrors = true;
		Font = new Font("arial", 8f, FontStyle.Bold);
		base.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.EnableNotifyMessage | ControlStyles.OptimizedDoubleBuffer, value: true);
	}

	public DataGridViewRow method_0(int int_0)
	{
		return (DataGridViewRow)collection_0[int_0 + 1];
	}

	public DataGridViewRow method_1(string string_0)
	{
		return (DataGridViewRow)collection_0[string_0];
	}

	public void method_10(int int_0)
	{
		if (!base.InvokeRequired)
		{
			base.Rows.RemoveAt(int_0);
			return;
		}
		Collection collection = collection_0;
		lock (collection)
		{
			Invoke(new Delegate4(method_10), int_0);
		}
	}

	public void method_11(string string_0, GEnum0 genum0_0, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode_0)
	{
		Collection collection = collection_0;
		lock (collection)
		{
			DataGridViewColumn dataGridViewColumn = null;
			switch (genum0_0)
			{
			case GEnum0.Text:
				dataGridViewColumn = new DataGridViewTextBoxColumn();
				break;
			case GEnum0.Link:
				dataGridViewColumn = new DataGridViewLinkColumn();
				break;
			case GEnum0.Image:
			{
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
				{
					ImageLayout = DataGridViewImageCellLayout.Zoom
				};
				dataGridViewColumn = dataGridViewImageColumn;
				break;
			}
			case GEnum0.StretchImage:
			{
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
				{
					ImageLayout = DataGridViewImageCellLayout.Stretch
				};
				dataGridViewColumn = dataGridViewImageColumn;
				break;
			}
			}
			dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0;
			dataGridViewColumn.Tag = genum0_0;
			dataGridViewColumn.HeaderText = string_0;
			base.Columns.Add(dataGridViewColumn);
		}
	}

	public bool method_2(string string_0)
	{
		return collection_0.Contains(string_0);
	}

	public DataGridViewRow[] method_3()
	{
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		if (base.RowCount == 0)
		{
			return list.ToArray();
		}
		try
		{
			int num = base.FirstDisplayedScrollingRowIndex + DisplayedRowCount(includePartialRow: false);
			for (int i = base.FirstDisplayedScrollingRowIndex; i <= num && i <= base.RowCount - 1; i++)
			{
				try
				{
					list.Add(base.Rows[i]);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError = ex;
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
					break;
				}
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
		return list.ToArray();
	}

	public void method_4()
	{
		Collection collection = collection_0;
		lock (collection)
		{
			base.Rows.Clear();
			collection_0.Clear();
		}
	}

	public DataGridViewRow method_5(object[] object_0)
	{
		if (base.InvokeRequired)
		{
			Collection collection = collection_0;
			lock (collection)
			{
				return (DataGridViewRow)Invoke(new Delegate1(method_5), object_0);
			}
		}
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		int num = base.ColumnCount - 1;
		for (int i = 0; i <= num; i++)
		{
			switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(base.Columns[i].Tag)))
			{
			case 0:
			{
				DataGridViewTextBoxCell dataGridViewCell3 = new DataGridViewTextBoxCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))
				};
				dataGridViewRow.Cells.Add(dataGridViewCell3);
				break;
			}
			case 1:
			{
				DataGridViewLinkCell dataGridViewCell2 = new DataGridViewLinkCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))
				};
				dataGridViewRow.Cells.Add(dataGridViewCell2);
				break;
			}
			case 2:
			{
				DataGridViewImageCell dataGridViewCell = new DataGridViewImageCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])),
					ImageLayout = DataGridViewImageCellLayout.Normal
				};
				dataGridViewRow.Cells.Add(dataGridViewCell);
				break;
			}
			case 3:
			{
				DataGridViewImageCell dataGridViewCell = new DataGridViewImageCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])),
					ImageLayout = DataGridViewImageCellLayout.Stretch
				};
				dataGridViewRow.Cells.Add(dataGridViewCell);
				break;
			}
			}
		}
		dataGridViewRow.Resizable = DataGridViewTriState.False;
		collection_0.Add(dataGridViewRow);
		base.Rows.Add(dataGridViewRow);
		return dataGridViewRow;
	}

	public int method_6()
	{
		return base.RowTemplate.Height;
	}

	public void method_7(int int_0)
	{
		base.RowTemplate.Height = int_0;
	}

	public DataGridViewRow method_8(string string_0, object[] object_0)
	{
		if (base.InvokeRequired)
		{
			Collection collection = collection_0;
			lock (collection)
			{
				return (DataGridViewRow)Invoke(new Delegate2(method_8), string_0, object_0);
			}
		}
		DataGridViewRow dataGridViewRow = new DataGridViewRow
		{
			Height = method_6()
		};
		int num = base.ColumnCount - 1;
		for (int i = 0; i <= num; i++)
		{
			switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(base.Columns[i].Tag)))
			{
			case 0:
			{
				DataGridViewTextBoxCell dataGridViewCell3 = new DataGridViewTextBoxCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))
				};
				dataGridViewRow.Cells.Add(dataGridViewCell3);
				break;
			}
			case 1:
			{
				DataGridViewLinkCell dataGridViewCell2 = new DataGridViewLinkCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))
				};
				dataGridViewRow.Cells.Add(dataGridViewCell2);
				break;
			}
			case 2:
			{
				DataGridViewImageCell dataGridViewCell = new DataGridViewImageCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])),
					ImageLayout = DataGridViewImageCellLayout.Zoom
				};
				dataGridViewRow.Cells.Add(dataGridViewCell);
				break;
			}
			case 3:
			{
				DataGridViewImageCell dataGridViewCell = new DataGridViewImageCell
				{
					Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])),
					ImageLayout = DataGridViewImageCellLayout.Stretch
				};
				dataGridViewRow.Cells.Add(dataGridViewCell);
				break;
			}
			}
		}
		dataGridViewRow.Resizable = DataGridViewTriState.False;
		collection_0.Add(dataGridViewRow, string_0);
		base.Rows.Add(dataGridViewRow);
		return dataGridViewRow;
	}

	public void method_9(DataGridViewRow dataGridViewRow_0)
	{
		if (!base.InvokeRequired)
		{
			base.Rows.Remove(dataGridViewRow_0);
			return;
		}
		Collection collection = collection_0;
		lock (collection)
		{
			Invoke(new Delegate3(method_9), dataGridViewRow_0);
		}
	}

	protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventArgs_0.Button == MouseButtons.Right)
		{
			try
			{
				HitTestInfo hitTestInfo = HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y);
				if (hitTestInfo.RowIndex != -1)
				{
					DataGridViewRow dataGridViewRow = base.Rows[hitTestInfo.RowIndex];
					if (!dataGridViewRow.Selected)
					{
						ClearSelection();
						dataGridViewRow.Selected = true;
					}
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
		base.OnMouseUp(mouseEventArgs_0);
	}

	protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseWheel(mouseEventArgs_0);
		try
		{
			switch (mouseEventArgs_0.Delta)
			{
			case 120:
				base.FirstDisplayedScrollingRowIndex = Math.Max(0, base.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines);
				break;
			case -120:
				base.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines;
				break;
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

	protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs dataGridViewRowPostPaintEventArgs_0)
	{
		try
		{
			DataGridViewRow dataGridViewRow = base.Rows[dataGridViewRowPostPaintEventArgs_0.RowIndex];
			if (dataGridViewRow.Height != method_6())
			{
				dataGridViewRow.Height = method_6();
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
		base.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0);
	}
}
