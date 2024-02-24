using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace S400RAT;

public class GClass8 : PictureBox
{
	public Timer timer_0;

	public Font fonty;

	public Graphics G;

	public List<object[]> Lines;

	public Timer T
	{
		get
		{
			return timer_0;
		}
		set
		{
			EventHandler value2 = delegate
			{
				try
				{
					wrk();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			};
			if (timer_0 != null)
			{
				timer_0.Tick -= value2;
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.Tick += value2;
			}
		}
	}

	public GClass8()
	{
		fonty = new Font("arial", 8f, FontStyle.Bold);
		Lines = new List<object[]>();
		Timer t = new Timer
		{
			Interval = 50,
			Enabled = false
		};
		T = t;
		base.SizeMode = PictureBoxSizeMode.Normal;
	}

	[CompilerGenerated]
	public void method_0(object sender, EventArgs e)
	{
		try
		{
			wrk();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void wrk()
	{
		try
		{
			T.Enabled = false;
			lock (this)
			{
				Bitmap bitmap = new Bitmap(base.Width, base.Height);
				G = Graphics.FromImage(bitmap);
				G.Clear(Color.Black);
				int num = 3;
				int num2 = TextRenderer.MeasureText("test", Font).Height;
				Color color = Color.White;
				IntPtr callbackData = default(IntPtr);
				for (int i = Lines.Count - 1; i >= 0; i += -1)
				{
					int num3 = 3;
					object[] array = Lines[i];
					int num4 = array.Length - 1;
					for (int j = 0; j <= num4; j++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[j]))));
						string left = objectValue.GetType().ToString();
						if (Operators.CompareString(left, typeof(Bitmap).ToString(), TextCompare: false) == 0)
						{
							Bitmap bitmap2 = (Bitmap)objectValue;
							if (bitmap2.Height > num2)
							{
								bitmap2 = (Bitmap)bitmap2.GetThumbnailImage(num2, num2, null, callbackData);
							}
							G.DrawImage(bitmap2, num3, num);
							num3 += bitmap2.Width + 3;
							continue;
						}
						if (Operators.CompareString(left, typeof(string).ToString(), TextCompare: false) != 0)
						{
							if (Operators.CompareString(left, typeof(Color).ToString(), TextCompare: false) == 0)
							{
								color = (Color)objectValue;
							}
							continue;
						}
						string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue)));
						Size size = TextRenderer.MeasureText(s, Font);
						G.DrawString(s, Font, new Pen(color).Brush, num3, num);
						if (size.Height - num2 <= 0)
						{
							num3 += size.Width + 3;
							continue;
						}
						num += size.Height - num2;
						num3 = 3;
					}
					num += num2;
				}
				G.Dispose();
				base.Image = bitmap;
			}
			T.Enabled = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void WRT(params object[] A)
	{
		lock (this)
		{
			Lines.Add(A);
			if (Lines.Count == 100)
			{
				Lines.RemoveAt(0);
			}
		}
	}
}
