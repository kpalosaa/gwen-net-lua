using System;

namespace GwenNetLua.Control
{
	public class Canvas : Internal.ControlBase
	{
		public Canvas(Gwen.Control.Canvas canvas)
			: base(canvas)
		{
		}

		public float Scale { get { return GetTarget<Gwen.Control.Canvas>().Scale; } set { GetTarget<Gwen.Control.Canvas>().Scale = value; } }
	}
}
