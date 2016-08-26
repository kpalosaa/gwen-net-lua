using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ListBoxRow : TableRow
	{
		public static ListBoxRow Create(Internal.ControlBase parent)
		{
			return new ListBoxRow(new Gwen.Control.ListBoxRow(parent.Target));
		}

		[MoonSharpHidden]
		public ListBoxRow(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
