using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class InnerContentControl : Internal.ButtonBase
	{
		[MoonSharpHidden]
		public InnerContentControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
