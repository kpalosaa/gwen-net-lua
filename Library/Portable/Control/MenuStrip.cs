using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class MenuStrip : Menu
	{
		public static new MenuStrip Create(Internal.ControlBase parent)
		{
			return new MenuStrip(new Gwen.Control.MenuStrip(parent.Target));
		}

		[MoonSharpHidden]
		public static new MenuStrip Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new MenuStrip(control);
		}

		[MoonSharpHidden]
		public MenuStrip(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
