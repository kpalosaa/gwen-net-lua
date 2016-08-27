using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Border : Internal.ControlBase
	{
		public static Border Create(Internal.ControlBase parent)
		{
			return new Border(new Gwen.Control.Border(parent.Target));
		}

		[MoonSharpHidden]
		public static Border Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Border(control);
		}

		[MoonSharpHidden]
		public Border(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Gwen.Control.BorderType BorderType { get { return GetTarget<Gwen.Control.Border>().BorderType; } set { GetTarget<Gwen.Control.Border>().BorderType = value; } }
	}
}
