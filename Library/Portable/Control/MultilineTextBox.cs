using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class MultilineTextBox : Internal.ControlBase
	{
		public static MultilineTextBox Create(Internal.ControlBase parent)
		{
			return new MultilineTextBox(new Gwen.Control.MultilineTextBox(parent.Target));
		}

		[MoonSharpHidden]
		public static MultilineTextBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new MultilineTextBox(control);
		}

		[MoonSharpHidden]
		public MultilineTextBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AcceptTabs { get { return GetTarget<Gwen.Control.MultilineTextBox>().AcceptTabs; } set { GetTarget<Gwen.Control.MultilineTextBox>().AcceptTabs = value; } }
		public Point CursorEnd { get { return new Point(GetTarget<Gwen.Control.MultilineTextBox>().CursorEnd); } set { GetTarget<Gwen.Control.MultilineTextBox>().CursorEnd = value.Target; } }
		public Point CursorPosition { get { return new Point(GetTarget<Gwen.Control.MultilineTextBox>().CursorPosition); } set { GetTarget<Gwen.Control.MultilineTextBox>().CursorPosition = value.Target; } }
		public Font Font { get { return new Font(GetTarget<Gwen.Control.MultilineTextBox>().Font); } set { GetTarget<Gwen.Control.MultilineTextBox>().Font = value.Target; } }
		public bool HasSelection { get { return GetTarget<Gwen.Control.MultilineTextBox>().HasSelection; } }
		public string Text { get { return GetTarget<Gwen.Control.MultilineTextBox>().Text; } set { GetTarget<Gwen.Control.MultilineTextBox>().Text = value; } }
		public int TotalLines { get { return GetTarget<Gwen.Control.MultilineTextBox>().TotalLines; } }

		public void Clear() { GetTarget<Gwen.Control.MultilineTextBox>().Clear(); }
		public void EraseSelection() { GetTarget<Gwen.Control.MultilineTextBox>().EraseSelection(); }
		public string GetSelection() { return GetTarget<Gwen.Control.MultilineTextBox>().GetSelection(); }
		public void InsertText(string text) { GetTarget<Gwen.Control.MultilineTextBox>().InsertText(text); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> TextChanged
		{
			add { GetTarget<Gwen.Control.MultilineTextBox>().TextChanged += value; }
			remove { GetTarget<Gwen.Control.MultilineTextBox>().TextChanged -= value; }
		}
	}
}
