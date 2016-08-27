using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class CollapsibleCategory : Internal.ControlBase
	{
		public static CollapsibleCategory Create(Internal.ControlBase parent)
		{
			return new CollapsibleCategory(new Gwen.Control.CollapsibleCategory(parent.GetTarget<Gwen.Control.CollapsibleList>()));
		}

		[MoonSharpHidden]
		public static CollapsibleCategory Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new CollapsibleCategory(control);
		}

		[MoonSharpHidden]
		public CollapsibleCategory(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsCategoryCollapsed { get { return GetTarget<Gwen.Control.CollapsibleCategory>().IsCategoryCollapsed; } set { GetTarget<Gwen.Control.CollapsibleCategory>().IsCategoryCollapsed = value; } }
		public string Text { get { return GetTarget<Gwen.Control.CollapsibleCategory>().Text; } set { GetTarget<Gwen.Control.CollapsibleCategory>().Text = value; } }

		public Button Add(string name) { return Button.Create(GetTarget<Gwen.Control.CollapsibleCategory>().Add(name)); }
		public Button GetSelectedButton() { return Button.Create(GetTarget<Gwen.Control.CollapsibleCategory>()); }
		public void UnselectAll() { GetTarget<Gwen.Control.CollapsibleCategory>().UnselectAll(); }
		public virtual Button FindChildByName(string name) { return Button.Create(GetTarget<Gwen.Control.CollapsibleCategory>().FindChildByName(name, false)); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Collapsed
		{
			add { GetTarget<Gwen.Control.CollapsibleCategory>().Collapsed += value; }
			remove { GetTarget<Gwen.Control.CollapsibleCategory>().Collapsed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> Selected
		{
			add { GetTarget<Gwen.Control.CollapsibleCategory>().Selected += value; }
			remove { GetTarget<Gwen.Control.CollapsibleCategory>().Selected -= value; }
		}
	}
}
