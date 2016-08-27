using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TabControl : Internal.ControlBase
	{
		public static TabControl Create(Internal.ControlBase parent)
		{
			return new TabControl(new Gwen.Control.TabControl(parent.Target));
		}

		[MoonSharpHidden]
		public static TabControl Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new TabControl(control);
		}

		[MoonSharpHidden]
		public TabControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AllowReorder { get { return GetTarget<Gwen.Control.TabControl>().AllowReorder; } set { GetTarget<Gwen.Control.TabControl>().AllowReorder = value; } }
		public int TabCount { get { return GetTarget<Gwen.Control.TabControl>().TabCount; } }
		public Gwen.Dock TabStripPosition { get { return GetTarget<Gwen.Control.TabControl>().TabStripPosition; } set { GetTarget<Gwen.Control.TabControl>().TabStripPosition = value; } }

		public void AddPage(string label, Internal.ControlBase page) { GetTarget<Gwen.Control.TabControl>().AddPage(label, page.Target); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> TabAdded
		{
			add { GetTarget<Gwen.Control.TabControl>().TabAdded += value; }
			remove { GetTarget<Gwen.Control.TabControl>().TabAdded -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> TabRemoved
		{
			add { GetTarget<Gwen.Control.TabControl>().TabRemoved += value; }
			remove { GetTarget<Gwen.Control.TabControl>().TabRemoved -= value; }
		}
	}
}
