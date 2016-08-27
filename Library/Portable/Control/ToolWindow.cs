using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	class ToolWindow : Internal.WindowBase
	{
		public static ToolWindow Create(Internal.ControlBase parent)
		{
			return new ToolWindow(new Gwen.Control.ToolWindow(parent.Target));
		}

		[MoonSharpHidden]
		public static ToolWindow Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ToolWindow(control);
		}

		[MoonSharpHidden]
		public ToolWindow(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool Vertical { get { return GetTarget<Gwen.Control.ToolWindow>().Vertical; } set { GetTarget<Gwen.Control.ToolWindow>().Vertical = value; } }
	}
}
