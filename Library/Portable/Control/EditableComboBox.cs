using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class EditableComboBox : Internal.ComboBoxBase
	{
		public static EditableComboBox Create(Internal.ControlBase parent)
		{
			return new EditableComboBox(new Gwen.Control.EditableComboBox(parent.Target));
		}

		[MoonSharpHidden]
		public static EditableComboBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new EditableComboBox(control);
		}

		[MoonSharpHidden]
		public EditableComboBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Font Font { get { return new Font(GetTarget<Gwen.Control.EditableComboBox>().Font); } set { GetTarget<Gwen.Control.EditableComboBox>().Font = value.Target; } }
		public string Text { get { return GetTarget<Gwen.Control.EditableComboBox>().Text; } set { GetTarget<Gwen.Control.EditableComboBox>().Text = value; } }
		public Color TextColor { get { return new Color(GetTarget<Gwen.Control.EditableComboBox>().TextColor); } set { GetTarget<Gwen.Control.EditableComboBox>().TextColor = value.Target; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> SubmitPressed
		{
			add { GetTarget<Gwen.Control.EditableComboBox>().SubmitPressed += value; }
			remove { GetTarget<Gwen.Control.EditableComboBox>().SubmitPressed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> TextChanged
		{
			add { GetTarget<Gwen.Control.EditableComboBox>().TextChanged += value; }
			remove { GetTarget<Gwen.Control.EditableComboBox>().TextChanged -= value; }
		}
	}
}
