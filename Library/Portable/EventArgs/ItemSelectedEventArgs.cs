using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ItemSelectedEventArgs
	{
		Gwen.Control.ItemSelectedEventArgs eventArgs;

		[MoonSharpHidden]
		public ItemSelectedEventArgs(Gwen.Control.ItemSelectedEventArgs e)
		{
			eventArgs = e;
		}

		public object SelectedItem
		{
			get
			{
				return eventArgs.SelectedItem;
			}
		}

		public int SelectedIndex
		{
			get
			{
				if (eventArgs.SelectedItem is Gwen.Control.ListBoxRow)
				{
					Gwen.Control.Table table = eventArgs.SelectedItem.Parent as Gwen.Control.Table;
					if (table != null)
					{
						return table.GetRowIndex(eventArgs.SelectedItem as Gwen.Control.ListBoxRow);
					}
				}
				else if (eventArgs.SelectedItem is Gwen.Control.LabeledRadioButton)
				{
					Gwen.Control.RadioButtonGroup radioGroup = eventArgs.SelectedItem.Parent as Gwen.Control.RadioButtonGroup;
					if (radioGroup != null)
					{
						return radioGroup.SelectedIndex;
					}
				}

				return -1;
			}
		}
	}
}
