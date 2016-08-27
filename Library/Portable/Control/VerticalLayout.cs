using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class VerticalLayout : Internal.ControlBase
	{
		public static VerticalLayout Create(Internal.ControlBase parent)
		{
			return new VerticalLayout(new Gwen.Control.Layout.VerticalLayout(parent.Target));
		}

		[MoonSharpHidden]
		public static VerticalLayout Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new VerticalLayout(control);
		}

		[MoonSharpHidden]
		public VerticalLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
