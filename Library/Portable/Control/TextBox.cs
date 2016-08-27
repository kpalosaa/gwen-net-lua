using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TextBox : Internal.ControlBase
	{
		public static TextBox Create(Internal.ControlBase parent)
		{
			return new TextBox(new Gwen.Control.TextBox(parent.Target));
		}

		[MoonSharpHidden]
		public static TextBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new TextBox(control);
		}

		[MoonSharpHidden]
		public TextBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public int CursorEnd { get { return GetTarget<Gwen.Control.TextBox>().CursorEnd; } set { GetTarget<Gwen.Control.TextBox>().CursorEnd = value; } }
		public int CursorPos { get { return GetTarget<Gwen.Control.TextBox>().CursorPos; } set { GetTarget<Gwen.Control.TextBox>().CursorPos = value; } }
		public string FitToText { get { return GetTarget<Gwen.Control.TextBox>().FitToText; } set { GetTarget<Gwen.Control.TextBox>().FitToText = value; } }
		public Font Font { get { return new Font(GetTarget<Gwen.Control.TextBox>().Font); } set { GetTarget<Gwen.Control.TextBox>().Font = value.Target; } }
		public bool HasSelection { get { return GetTarget<Gwen.Control.TextBox>().HasSelection; } }
		public bool SelectAllOnFocus { get { return GetTarget<Gwen.Control.TextBox>().SelectAllOnFocus; } set { GetTarget<Gwen.Control.TextBox>().SelectAllOnFocus = value; } }
		public string Text { get { return GetTarget<Gwen.Control.TextBox>().Text; } set { GetTarget<Gwen.Control.TextBox>().Text = value; } }
		public Color TextColor { get { return new Color( GetTarget<Gwen.Control.TextBox>().TextColor); } set { GetTarget<Gwen.Control.TextBox>().TextColor = value.Target; } }
		public Color TextColorOverride { get { return new Color(GetTarget<Gwen.Control.TextBox>().TextColorOverride); } set { GetTarget<Gwen.Control.TextBox>().TextColorOverride = value.Target; } }

		public void DeleteText(int startPos, int length) { GetTarget<Gwen.Control.TextBox>().DeleteText(startPos, length); }
		public void EraseSelection() { GetTarget<Gwen.Control.TextBox>().EraseSelection(); }
		public string GetSelection() { return GetTarget<Gwen.Control.TextBox>().GetSelection(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> SubmitPressed
		{
			add { GetTarget<Gwen.Control.TextBox>().SubmitPressed += value; }
			remove { GetTarget<Gwen.Control.TextBox>().SubmitPressed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> TextChanged
		{
			add { GetTarget<Gwen.Control.TextBox>().TextChanged += value; }
			remove { GetTarget<Gwen.Control.TextBox>().TextChanged -= value; }
		}
	}
}
