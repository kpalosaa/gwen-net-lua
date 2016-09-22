using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class WindowBase : Internal.ResizableControl
	{
		[MoonSharpHidden]
		public WindowBase(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool DeleteOnClose { get { return GetTarget<Gwen.Control.Internal.WindowBase>().DeleteOnClose; } set { GetTarget<Gwen.Control.Internal.WindowBase>().DeleteOnClose = value; } }
		public bool IsDraggingEnabled { get { return GetTarget<Gwen.Control.Internal.WindowBase>().IsDraggingEnabled; } set { GetTarget<Gwen.Control.Internal.WindowBase>().IsDraggingEnabled = value; } }
		public bool IsOnTop { get { return GetTarget<Gwen.Control.Internal.WindowBase>().IsOnTop; } }
		public Gwen.Control.StartPosition StartPosition { get { return GetTarget<Gwen.Control.Internal.WindowBase>().StartPosition; } set { GetTarget<Gwen.Control.Internal.WindowBase>().StartPosition = value; } }

		public void Close() { GetTarget<Gwen.Control.Internal.WindowBase>().Close(); }
		public new void Touch() { GetTarget<Gwen.Control.Internal.WindowBase>().Touch(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Closed
		{
			add { GetTarget<Gwen.Control.Internal.WindowBase>().Closed += value; }
			remove { GetTarget<Gwen.Control.Internal.WindowBase>().Closed -= value; }
		}
	}
}
