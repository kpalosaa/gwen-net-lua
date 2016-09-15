using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class RichLabel : Internal.ControlBase
	{
		public static RichLabel Create(Internal.ControlBase parent)
		{
			return new RichLabel(new Gwen.Control.RichLabel(parent.Target));
		}

		[MoonSharpHidden]
		public static RichLabel Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new RichLabel(control);
		}

		[MoonSharpHidden]
		public RichLabel(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Document Document { get { return new Document(GetTarget<Gwen.Control.RichLabel>().Document); } set { GetTarget<Gwen.Control.RichLabel>().Document = value.Target; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.LinkClickedEventArgs> LinkClicked
		{
			add { GetTarget<Gwen.Control.RichLabel>().LinkClicked += value; }
			remove { GetTarget<Gwen.Control.RichLabel>().LinkClicked -= value; }
		}
	}
}
