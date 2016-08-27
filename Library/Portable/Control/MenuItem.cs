using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class MenuItem : Button
	{
		public static new MenuItem Create(Internal.ControlBase parent)
		{
			return new MenuItem(new Gwen.Control.MenuItem(parent.Target));
		}

		[MoonSharpHidden]
		public static new MenuItem Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new MenuItem(control);
		}

		[MoonSharpHidden]
		public MenuItem(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsCheckable { get { return GetTarget<Gwen.Control.MenuItem>().IsCheckable; } set { GetTarget<Gwen.Control.MenuItem>().IsCheckable = value; } }
		public bool IsChecked { get { return GetTarget<Gwen.Control.MenuItem>().IsChecked; } set { GetTarget<Gwen.Control.MenuItem>().IsChecked = value; } }
		public bool IsMenuOpen { get { return GetTarget<Gwen.Control.MenuItem>().IsMenuOpen; } }
		public bool IsOnStrip { get { return GetTarget<Gwen.Control.MenuItem>().IsOnStrip; } }
		public Menu Menu { get { return Menu.Create(GetTarget<Gwen.Control.MenuItem>().Menu); } }

		public void CloseMenu() { GetTarget<Gwen.Control.MenuItem>().CloseMenu(); }
		public void OpenMenu() { GetTarget<Gwen.Control.MenuItem>().OpenMenu(); }
		public void SetAction(Gwen.Control.ControlBase.GwenEventHandler<EventArgs> handler) { GetTarget<Gwen.Control.MenuItem>().SetAction(handler); }
		public void ToggleMenu() { GetTarget<Gwen.Control.MenuItem>().ToggleMenu(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> CheckChanged
		{
			add { GetTarget<Gwen.Control.MenuItem>().CheckChanged += value; }
			remove { GetTarget<Gwen.Control.MenuItem>().CheckChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Checked
		{
			add { GetTarget<Gwen.Control.MenuItem>().Checked += value; }
			remove { GetTarget<Gwen.Control.MenuItem>().Checked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> Selected
		{
			add { GetTarget<Gwen.Control.MenuItem>().Selected += value; }
			remove { GetTarget<Gwen.Control.MenuItem>().Selected -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> UnChecked
		{
			add { GetTarget<Gwen.Control.MenuItem>().UnChecked += value; }
			remove { GetTarget<Gwen.Control.MenuItem>().UnChecked -= value; }
		}
	}
}
