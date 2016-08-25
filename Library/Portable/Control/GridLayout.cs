using System;
using System.Collections.Generic;
using System.Linq;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class GridLayout : Internal.ControlBase
	{
		public static GridLayout Create(Internal.ControlBase parent)
		{
			return new GridLayout(new Gwen.Control.Layout.GridLayout(parent.Target));
		}

		[MoonSharpHidden]
		public GridLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public const float AutoSize = Gwen.Control.Layout.GridLayout.AutoSize;
		public const float Fill = Gwen.Control.Layout.GridLayout.Fill;

		public int ColumnCount { get { return GetTarget<Gwen.Control.Layout.GridLayout>().ColumnCount; } set { GetTarget<Gwen.Control.Layout.GridLayout>().ColumnCount = value; } }

		public void SetColumnWidths(IEnumerable<float> widths)
		{
			GetTarget<Gwen.Control.Layout.GridLayout>().SetColumnWidths(widths.ToArray());
		}

		public void SetRowHeights(IEnumerable<float> heights)
		{
			GetTarget<Gwen.Control.Layout.GridLayout>().SetColumnWidths(heights.ToArray());
		}
	}
}
