using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class CollapsibleList : Internal.ControlBase
	{
		public static CollapsibleList Create(Internal.ControlBase parent)
		{
			return new CollapsibleList(new Gwen.Control.CollapsibleList(parent.Target));
		}

		[MoonSharpHidden]
		public static CollapsibleList Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new CollapsibleList(control);
		}

		[MoonSharpHidden]
		public CollapsibleList(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public CollapsibleCategory Add(string categoryName, string name = null, object userData = null) { return new CollapsibleCategory(GetTarget<Gwen.Control.CollapsibleList>().Add(categoryName, name, userData)); }
		public Button GetSelectedButton() { return Button.Create(GetTarget<Gwen.Control.CollapsibleList>().GetSelectedButton()); }
		public void UnselectAll() { GetTarget<Gwen.Control.CollapsibleList>().UnselectAll(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> CategoryCollapsed
		{
			add { GetTarget<Gwen.Control.CollapsibleList>().CategoryCollapsed += value; }
			remove { GetTarget<Gwen.Control.CollapsibleList>().CategoryCollapsed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> ItemSelected
		{
			add { GetTarget<Gwen.Control.CollapsibleList>().ItemSelected += value; }
			remove { GetTarget<Gwen.Control.CollapsibleList>().ItemSelected -= value; }
		}
	}
}
