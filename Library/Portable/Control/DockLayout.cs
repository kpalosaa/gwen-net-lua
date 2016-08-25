using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class DockLayout : Internal.ControlBase
	{
		public static DockLayout Create(Internal.ControlBase parent)
		{
			return new DockLayout(new Gwen.Control.Layout.DockLayout(parent.Target));
		}

		[MoonSharpHidden]
		public DockLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
