using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class LabeledCheckBox : Internal.ControlBase
	{
		public static LabeledCheckBox Create(Internal.ControlBase parent)
		{
			return new LabeledCheckBox(new Gwen.Control.LabeledCheckBox(parent.Target));
		}

		[MoonSharpHidden]
		public static LabeledCheckBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new LabeledCheckBox(control);
		}

		[MoonSharpHidden]
		public LabeledCheckBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsChecked { get { return GetTarget<Gwen.Control.LabeledCheckBox>().IsChecked; } set { GetTarget<Gwen.Control.LabeledCheckBox>().IsChecked = value; } }
		public string Text { get { return GetTarget<Gwen.Control.LabeledCheckBox>().Text; } set { GetTarget<Gwen.Control.LabeledCheckBox>().Text = value; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> CheckChanged
		{
			add { GetTarget<Gwen.Control.LabeledCheckBox>().CheckChanged += value; }
			remove { GetTarget<Gwen.Control.LabeledCheckBox>().CheckChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Checked
		{
			add { GetTarget<Gwen.Control.LabeledCheckBox>().Checked += value; }
			remove { GetTarget<Gwen.Control.LabeledCheckBox>().Checked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> UnChecked
		{
			add { GetTarget<Gwen.Control.LabeledCheckBox>().UnChecked += value; }
			remove { GetTarget<Gwen.Control.LabeledCheckBox>().UnChecked -= value; }
		}
	}
}
