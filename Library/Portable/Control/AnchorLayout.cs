﻿using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class AnchorLayout : Internal.ControlBase
	{
		public static AnchorLayout Create(Internal.ControlBase parent)
		{
			return new AnchorLayout(new Gwen.Control.Layout.AnchorLayout(parent.Target));
		}

		[MoonSharpHidden]
		public static AnchorLayout Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new AnchorLayout(control);
		}

		[MoonSharpHidden]
		public AnchorLayout(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
