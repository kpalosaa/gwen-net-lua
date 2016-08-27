using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class MessageBox : Window
	{
		public static MessageBox Create(Internal.ControlBase parent, string text, string caption = "", Gwen.Control.MessageBoxButtons buttons = Gwen.Control.MessageBoxButtons.OK)
		{
			return new MessageBox(new Gwen.Control.MessageBox(parent.Target, text, caption, buttons));
		}

		[MoonSharpHidden]
		public static new MessageBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new MessageBox(control);
		}

		[MoonSharpHidden]
		public MessageBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.MessageBoxResultEventArgs> Dismissed
		{
			add { GetTarget<Gwen.Control.MessageBox>().Dismissed += value; }
			remove { GetTarget<Gwen.Control.MessageBox>().Dismissed -= value; }
		}
	}
}
