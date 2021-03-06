﻿using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class GroupBox : Internal.ControlBase
	{
		public static GroupBox Create(Internal.ControlBase parent)
		{
			return new GroupBox(new Gwen.Control.GroupBox(parent.Target));
		}

		[MoonSharpHidden]
		public static GroupBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new GroupBox(control);
		}

		[MoonSharpHidden]
		public GroupBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public virtual string Text { get { return GetTarget<Gwen.Control.GroupBox>().Text; } set { GetTarget<Gwen.Control.GroupBox>().Text = value; } }
	}
}
