using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class LabeledRadioButton : Internal.ControlBase
	{
		public static LabeledRadioButton Create(Internal.ControlBase parent)
		{
			return new LabeledRadioButton(new Gwen.Control.LabeledRadioButton(parent.Target));
		}

		[MoonSharpHidden]
		public static LabeledRadioButton Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new LabeledRadioButton(control);
		}

		[MoonSharpHidden]
		public LabeledRadioButton(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public string Text { get { return GetTarget<Gwen.Control.LabeledRadioButton>().Text; } set { GetTarget<Gwen.Control.LabeledRadioButton>().Text = value; } }

		public void Select() { GetTarget<Gwen.Control.LabeledRadioButton>().Select(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Checked
		{
			add { GetTarget<Gwen.Control.LabeledRadioButton>().Checked += value; }
			remove { GetTarget<Gwen.Control.LabeledRadioButton>().Checked -= value; }
		}
	}
}
