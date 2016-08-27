using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class ResizableControl : Internal.ControlBase
	{
		[MoonSharpHidden]
		public ResizableControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool ClampMovement { get { return GetTarget<Gwen.Control.ResizableControl>().ClampMovement; } set { GetTarget<Gwen.Control.ResizableControl>().ClampMovement = value; } }
		public Gwen.Control.Resizing Resizing { get { return GetTarget<Gwen.Control.ResizableControl>().Resizing; } set { GetTarget<Gwen.Control.ResizableControl>().Resizing = value; } }
		public Gwen.Control.ControlBase Content { get { return GetTarget<Gwen.Control.ResizableControl>().Content; } }

		public void EnableResizing(bool left = true, bool top = true, bool right = true, bool bottom = true) { GetTarget<Gwen.Control.ResizableControl>().EnableResizing(left, top, right, bottom); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Resized
		{
			add { GetTarget<Gwen.Control.ResizableControl>().Resized += value; }
			remove { GetTarget<Gwen.Control.ResizableControl>().Resized -= value; }
		}
	}
}
