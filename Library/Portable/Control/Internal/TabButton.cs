using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class TabButton : Button
	{
		[MoonSharpHidden]
		public TabButton(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsActive { get { return GetTarget<Gwen.Control.Internal.TabButton>().IsActive; } }
	}
}
