using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class CheckBox : Internal.ButtonBase
	{
		public static CheckBox Create(Internal.ControlBase parent)
		{
			return new CheckBox(new Gwen.Control.CheckBox(parent.Target));
		}

		[MoonSharpHidden]
		public static CheckBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new CheckBox(control);
		}

		[MoonSharpHidden]
		public CheckBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsChecked { get { return GetTarget<Gwen.Control.CheckBox>().IsChecked; } set { GetTarget<Gwen.Control.CheckBox>().IsChecked = value; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> CheckChanged
		{
			add { GetTarget<Gwen.Control.CheckBox>().CheckChanged += value; }
			remove { GetTarget<Gwen.Control.CheckBox>().CheckChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Checked
		{
			add { GetTarget<Gwen.Control.CheckBox>().Checked += value; }
			remove { GetTarget<Gwen.Control.CheckBox>().Checked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> UnChecked
		{
			add { GetTarget<Gwen.Control.CheckBox>().UnChecked += value; }
			remove { GetTarget<Gwen.Control.CheckBox>().UnChecked -= value; }
		}
	}
}
