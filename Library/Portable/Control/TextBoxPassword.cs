using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TextBoxPassword : TextBox
	{
		public static new TextBoxPassword Create(Internal.ControlBase parent)
		{
			return new TextBoxPassword(new Gwen.Control.TextBoxPassword(parent.Target));
		}

		[MoonSharpHidden]
		public TextBoxPassword(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
