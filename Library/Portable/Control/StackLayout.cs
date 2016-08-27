using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class StackLayout : Internal.ControlBase
	{
		public static StackLayout Create(Internal.ControlBase parent)
		{
			return new StackLayout(new Gwen.Control.Layout.StackLayout(parent.Target));
		}

		[MoonSharpHidden]
		public static StackLayout Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new StackLayout(control);
		}

		[MoonSharpHidden]
		public StackLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool Horizontal { get { return GetTarget<Gwen.Control.Layout.StackLayout>().Horizontal; } set { GetTarget<Gwen.Control.Layout.StackLayout>().Horizontal = value; } }
	}
}
