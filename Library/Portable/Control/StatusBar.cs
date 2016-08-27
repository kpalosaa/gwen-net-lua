using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class StatusBar : Internal.ControlBase
	{
		public static StatusBar Create(Internal.ControlBase parent)
		{
			return new StatusBar(new Gwen.Control.StatusBar(parent.Target));
		}

		[MoonSharpHidden]
		public static StatusBar Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new StatusBar(control);
		}

		[MoonSharpHidden]
		public StatusBar(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public string Text { get { return GetTarget<Gwen.Control.StatusBar>().Text; } set { GetTarget<Gwen.Control.StatusBar>().Text = value; } }
		public Color TextColor { get { return new Color(GetTarget<Gwen.Control.StatusBar>().TextColor); } set { GetTarget<Gwen.Control.StatusBar>().TextColor = value.Target; } }

		public void AddControl(Internal.ControlBase control, bool right) { GetTarget<Gwen.Control.StatusBar>().AddControl(control.Target, right); }
	}
}
