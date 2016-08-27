using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Popup : ScrollControl
	{
		public static new Popup Create(Internal.ControlBase parent)
		{
			return new Popup(new Gwen.Control.Popup(parent.Target));
		}

		[MoonSharpHidden]
		public static new Popup Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Popup(control);
		}

		[MoonSharpHidden]
		public Popup(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool DeleteOnClose { get { return GetTarget<Gwen.Control.Popup>().DeleteOnClose; } set { GetTarget<Gwen.Control.Popup>().DeleteOnClose = value; } }

		public void Close() { GetTarget<Gwen.Control.Popup>().Close(); }
		public void Open(Point pos) { GetTarget<Gwen.Control.Popup>().Open(pos.Target); }
	}
}
