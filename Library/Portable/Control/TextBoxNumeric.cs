using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TextBoxNumeric : TextBox
	{
		public static new TextBoxNumeric Create(Internal.ControlBase parent)
		{
			return new TextBoxNumeric(new Gwen.Control.TextBoxNumeric(parent.Target));
		}

		[MoonSharpHidden]
		public TextBoxNumeric(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public virtual float Value { get { return GetTarget<Gwen.Control.TextBoxNumeric>().Value; } set { GetTarget<Gwen.Control.TextBoxNumeric>().Value = value; } }
	}
}
