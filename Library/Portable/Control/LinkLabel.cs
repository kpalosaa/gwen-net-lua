using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class LinkLabel : Label
	{
		public static new LinkLabel Create(Internal.ControlBase parent)
		{
			return new LinkLabel(new Gwen.Control.LinkLabel(parent.Target));
		}

		[MoonSharpHidden]
		public static new LinkLabel Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new LinkLabel(control);
		}

		[MoonSharpHidden]
		public LinkLabel(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Color HoverColor { get { return new Color(GetTarget<Gwen.Control.LinkLabel>().HoverColor); } set { GetTarget<Gwen.Control.LinkLabel>().HoverColor = value.Target; } }
		public Font HoverFont { get { return new Font(GetTarget<Gwen.Control.LinkLabel>().HoverFont); } set { GetTarget<Gwen.Control.LinkLabel>().HoverFont = value.Target; } }
		public string Link { get { return GetTarget<Gwen.Control.LinkLabel>().Link; } set { GetTarget<Gwen.Control.LinkLabel>().Link = value; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.LinkClickedEventArgs> LinkClicked
		{
			add { GetTarget<Gwen.Control.LinkLabel>().LinkClicked += value; }
			remove { GetTarget<Gwen.Control.LinkLabel>().LinkClicked -= value; }
		}
	}
}
