using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class HorizontalLayout : Internal.ControlBase
	{
		public static HorizontalLayout Create(Internal.ControlBase parent)
		{
			return new HorizontalLayout(new Gwen.Control.Layout.HorizontalLayout(parent.Target));
		}

		[MoonSharpHidden]
		public static HorizontalLayout Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new HorizontalLayout(control);
		}

		[MoonSharpHidden]
		public HorizontalLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
