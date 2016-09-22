using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class RadioButton : CheckBox
	{
		public static new RadioButton Create(Internal.ControlBase parent)
		{
			return new RadioButton(new Gwen.Control.RadioButton(parent.Target));
		}

		[MoonSharpHidden]
		public static new RadioButton Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new RadioButton(control);
		}

		[MoonSharpHidden]
		public RadioButton(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
