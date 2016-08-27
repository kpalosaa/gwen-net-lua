using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ProgressBar : Internal.ControlBase
	{
		public static ProgressBar Create(Internal.ControlBase parent)
		{
			return new ProgressBar(new Gwen.Control.ProgressBar(parent.Target));
		}

		[MoonSharpHidden]
		public static ProgressBar Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ProgressBar(control);
		}

		[MoonSharpHidden]
		public ProgressBar(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AutoLabel { get { return GetTarget<Gwen.Control.ProgressBar>().AutoLabel; } set { GetTarget<Gwen.Control.ProgressBar>().AutoLabel = value; } }
		public bool IsHorizontal { get { return GetTarget<Gwen.Control.ProgressBar>().IsHorizontal; } set { GetTarget<Gwen.Control.ProgressBar>().IsHorizontal = value; } }
		public float Value { get { return GetTarget<Gwen.Control.ProgressBar>().Value; } set { GetTarget<Gwen.Control.ProgressBar>().Value = value; } }
	}
}
