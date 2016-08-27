using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class NumericUpDown : Internal.ControlBase
	{
		public static NumericUpDown Create(Internal.ControlBase parent)
		{
			return new NumericUpDown(new Gwen.Control.NumericUpDown(parent.Target));
		}

		[MoonSharpHidden]
		public static NumericUpDown Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new NumericUpDown(control);
		}

		[MoonSharpHidden]
		public NumericUpDown(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public float Max { get { return GetTarget<Gwen.Control.NumericUpDown>().Max; } set { GetTarget<Gwen.Control.NumericUpDown>().Max = value; } }
		public float Min { get { return GetTarget<Gwen.Control.NumericUpDown>().Min; } set { GetTarget<Gwen.Control.NumericUpDown>().Min = value; } }
		public float Step { get { return GetTarget<Gwen.Control.NumericUpDown>().Step; } set { GetTarget<Gwen.Control.NumericUpDown>().Step = value; } }
		public float Value { get { return GetTarget<Gwen.Control.NumericUpDown>().Value; } set { GetTarget<Gwen.Control.NumericUpDown>().Value = value; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ValueChanged
		{
			add { GetTarget<Gwen.Control.NumericUpDown>().ValueChanged += value; }
			remove { GetTarget<Gwen.Control.NumericUpDown>().ValueChanged -= value; }
		}
	}
}
