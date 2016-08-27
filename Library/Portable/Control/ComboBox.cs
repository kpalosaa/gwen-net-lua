using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ComboBox : Internal.ComboBoxBase
	{
		public static ComboBox Create(Internal.ControlBase parent)
		{
			return new ComboBox(new Gwen.Control.ComboBox(parent.Target));
		}

		[MoonSharpHidden]
		public static ComboBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ComboBox(control);
		}

		[MoonSharpHidden]
		public ComboBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
