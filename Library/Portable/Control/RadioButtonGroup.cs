using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class RadioButtonGroup : Internal.ControlBase
	{
		public static RadioButtonGroup Create(Internal.ControlBase parent)
		{
			return new RadioButtonGroup(new Gwen.Control.RadioButtonGroup(parent.Target));
		}

		[MoonSharpHidden]
		public static RadioButtonGroup Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new RadioButtonGroup(control);
		}

		[MoonSharpHidden]
		public RadioButtonGroup(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public LabeledRadioButton Selected { get { return new LabeledRadioButton(GetTarget<Gwen.Control.RadioButtonGroup>().Selected); } }
		public int SelectedIndex { get { return GetTarget<Gwen.Control.RadioButtonGroup>().SelectedIndex; } }
		public string SelectedLabel { get { return GetTarget<Gwen.Control.RadioButtonGroup>().SelectedLabel; } }
		public string SelectedName { get { return GetTarget<Gwen.Control.RadioButtonGroup>().SelectedName; } }

		public void AddOption(string text, string optionName = null, object userData = null) { GetTarget<Gwen.Control.RadioButtonGroup>().AddOption(text, optionName, userData); }
		public void SelectByUserData(object userdata) { GetTarget<Gwen.Control.RadioButtonGroup>().SelectByUserData(userdata); }
		public void SetSelection(int index) { GetTarget<Gwen.Control.RadioButtonGroup>().SetSelection(index); }
		public void SetSelectionByName(string name) { GetTarget<Gwen.Control.RadioButtonGroup>().SetSelectionByName(name); }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> SelectionChanged
		{
			add { GetTarget<Gwen.Control.RadioButtonGroup>().SelectionChanged += value; }
			remove { GetTarget<Gwen.Control.RadioButtonGroup>().SelectionChanged -= value; }
		}
	}
}
