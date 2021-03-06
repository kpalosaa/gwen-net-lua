﻿using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Label : Internal.ControlBase
	{
		public static Label Create(Internal.ControlBase parent)
		{
			return new Label(new Gwen.Control.Label(parent.Target));
		}

		[MoonSharpHidden]
		public static Label Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Label(control);
		}

		[MoonSharpHidden]
		public Label(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public string Text { get { return GetTarget<Gwen.Control.Label>().Text; } set { GetTarget<Gwen.Control.Label>().Text = value; } }
		public string TextOverride { get { return GetTarget<Gwen.Control.Label>().TextOverride; } set { GetTarget<Gwen.Control.Label>().TextOverride = value; } }
		public bool AutoSizeToContents { get { return GetTarget<Gwen.Control.Label>().AutoSizeToContents; } set { GetTarget<Gwen.Control.Label>().AutoSizeToContents = value; } }
		public Gwen.Alignment Alignment { get { return GetTarget<Gwen.Control.Label>().Alignment; } set { GetTarget<Gwen.Control.Label>().Alignment = value; } }
		public Font Font { get { return new Font(GetTarget<Gwen.Control.Label>().Font); } set { GetTarget<Gwen.Control.Label>().Font = value.Target; } }
		public Color TextColor { get { return new Color(GetTarget<Gwen.Control.Label>().TextColor); } set { GetTarget<Gwen.Control.Label>().TextColor = value.Target; } }
		public Color TextColorOverride { get { return new Color(GetTarget<Gwen.Control.Label>().TextColorOverride); } set { GetTarget<Gwen.Control.Label>().TextColorOverride = value.Target; } }
		public Padding TextPadding { get { return new Padding(GetTarget<Gwen.Control.Label>().TextPadding); } set { GetTarget<Gwen.Control.Label>().TextPadding = value.Target; } }
	}
}
