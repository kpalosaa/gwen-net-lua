using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	class FlowLayout : Internal.ControlBase
	{
		public static FlowLayout Create(Internal.ControlBase parent)
		{
			return new FlowLayout(new Gwen.Control.Layout.FlowLayout(parent.Target));
		}

		[MoonSharpHidden]
		public static FlowLayout Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new FlowLayout(control);
		}

		[MoonSharpHidden]
		public FlowLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
