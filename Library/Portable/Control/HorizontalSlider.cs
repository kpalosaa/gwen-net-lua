using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class HorizontalSlider : Internal.Slider
	{
		public static HorizontalSlider Create(Internal.ControlBase parent)
		{
			return new HorizontalSlider(new Gwen.Control.HorizontalSlider(parent.Target));
		}

		[MoonSharpHidden]
		public static HorizontalSlider Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new HorizontalSlider(control);
		}

		[MoonSharpHidden]
		public HorizontalSlider(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
