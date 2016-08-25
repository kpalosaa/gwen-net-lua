using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class AnchorLayout : Internal.ControlBase
	{
		public static AnchorLayout Create(Internal.ControlBase parent)
		{
			return new AnchorLayout(new Gwen.Control.Layout.AnchorLayout(parent.Target));
		}

		[MoonSharpHidden]
		public AnchorLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
