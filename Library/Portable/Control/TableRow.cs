using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TableRow : Internal.ControlBase
	{
		public static TableRow Create(Internal.ControlBase parent)
		{
			return new TableRow(new Gwen.Control.TableRow(parent.Target));
		}

		[MoonSharpHidden]
		public static TableRow Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new TableRow(control);
		}

		[MoonSharpHidden]
		public TableRow(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public string Text { get { return GetTarget<Gwen.Control.TableRow>().Text; } set { GetTarget<Gwen.Control.TableRow>().Text = value; } }

		public string GetCellText(int columnIndex = 0) { return GetTarget<Gwen.Control.TableRow>().GetCellText(columnIndex); }
		public void SetCellText(int columnIndex, string text) { GetTarget<Gwen.Control.TableRow>().SetCellText(columnIndex, text); }
		public void SetTextColor(Color color) { GetTarget<Gwen.Control.TableRow>().SetTextColor(color.Target); }
	}
}
