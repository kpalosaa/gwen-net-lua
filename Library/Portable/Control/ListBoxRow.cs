using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ListBoxRow : TableRow
	{
		public static new ListBoxRow Create(Internal.ControlBase parent)
		{
			return new ListBoxRow(new Gwen.Control.ListBoxRow(parent.Target));
		}

		[MoonSharpHidden]
		public static new ListBoxRow Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ListBoxRow(control);
		}

		[MoonSharpHidden]
		public ListBoxRow(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
