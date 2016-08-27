using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class VerticalSlider : Internal.Slider
	{
		public static VerticalSlider Create(Internal.ControlBase parent)
		{
			return new VerticalSlider(new Gwen.Control.VerticalSlider(parent.Target));
		}

		[MoonSharpHidden]
		public static VerticalSlider Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new VerticalSlider(control);
		}

		[MoonSharpHidden]
		public VerticalSlider(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
