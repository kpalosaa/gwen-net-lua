using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class DockControl : Internal.ControlBase
	{
		public static DockControl Create(Internal.ControlBase parent)
		{
			return new DockControl(new Gwen.Control.DockControl(parent.Target));
		}

		[MoonSharpHidden]
		public static DockControl Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new DockControl(control);
		}

		[MoonSharpHidden]
		public DockControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public DockControl BottomDock { get { return DockControl.Create(GetTarget<Gwen.Control.DockControl>().BottomDock); } }
		public DockControl LeftDock { get { return DockControl.Create(GetTarget<Gwen.Control.DockControl>().LeftDock); } }
		public DockControl RightDock { get { return DockControl.Create(GetTarget<Gwen.Control.DockControl>().RightDock); } }
		public DockControl TopDock { get { return DockControl.Create(GetTarget<Gwen.Control.DockControl>().TopDock); } }

		public void Add(string title, Internal.ControlBase control) { GetTarget<Gwen.Control.DockControl>().Add(title, control.Target); }
	}
}
