using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Window : Internal.WindowBase
	{
		public static Window Create(Internal.ControlBase parent)
		{
			return new Window(new Gwen.Control.Window(parent.Target));
		}

		[MoonSharpHidden]
		public static Window Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Window(control);
		}

		[MoonSharpHidden]
		public Window(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsClosable { get { return GetTarget<Gwen.Control.Window>().IsClosable; } set { GetTarget<Gwen.Control.Window>().IsClosable = value; } }
		public bool Modal { get { return GetTarget<Gwen.Control.Window>().Modal; } set { GetTarget<Gwen.Control.Window>().Modal = value; } }
		public Color ModalBackground { get { return new Color(GetTarget<Gwen.Control.Window>().ModalBackground); } set { GetTarget<Gwen.Control.Window>().ModalBackground = value.Target; } }
		public string Title { get { return GetTarget<Gwen.Control.Window>().Title; } set { GetTarget<Gwen.Control.Window>().Title = value; } }
	}
}
