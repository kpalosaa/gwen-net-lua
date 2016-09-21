using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class Slider : Internal.ControlBase
	{
		[MoonSharpHidden]
		public Slider(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public float Max { get { return GetTarget<Gwen.Control.Internal.Slider>().Max; } set { GetTarget<Gwen.Control.Internal.Slider>().Max = value; } }
		public float Min { get { return GetTarget<Gwen.Control.Internal.Slider>().Min; } set { GetTarget<Gwen.Control.Internal.Slider>().Min = value; } }
		public int NotchCount { get { return GetTarget<Gwen.Control.Internal.Slider>().NotchCount; } set { GetTarget<Gwen.Control.Internal.Slider>().NotchCount = value; } }
		public bool SnapToNotches { get { return GetTarget<Gwen.Control.Internal.Slider>().SnapToNotches; } set { GetTarget<Gwen.Control.Internal.Slider>().SnapToNotches = value; } }
		public float Value { get { return GetTarget<Gwen.Control.Internal.Slider>().Value; } set { GetTarget<Gwen.Control.Internal.Slider>().Value = value; } }

		public void SetRange(float min, float max) { GetTarget<Gwen.Control.Internal.Slider>().SetRange(min, max); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ValueChanged
		{
			add { GetTarget<Gwen.Control.Internal.Slider>().ValueChanged += value; }
			remove { GetTarget<Gwen.Control.Internal.Slider>().ValueChanged -= value; }
		}
	}
}
