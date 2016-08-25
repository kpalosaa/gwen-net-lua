using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class ButtonBase : ControlBase
	{
		[MoonSharpHidden]
		public ButtonBase(Gwen.Control.ControlBase control)
			: base(control)
		{

		}

		public bool IsToggle { get { return GetTarget<Gwen.Control.Button>().IsToggle; } set { GetTarget<Gwen.Control.Button>().IsToggle = value; } }
		public bool ToggleState { get { return GetTarget<Gwen.Control.Button>().ToggleState; } set { GetTarget<Gwen.Control.Button>().ToggleState = value; } }
		public bool IsDepressed { get { return GetTarget<Gwen.Control.Button>().ToggleState; } set { GetTarget<Gwen.Control.Button>().IsDepressed = value; } }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Pressed
		{
			add { GetTarget<Gwen.Control.Button>().Pressed += value; }
			remove { GetTarget<Gwen.Control.Button>().Pressed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Released
		{
			add { GetTarget<Gwen.Control.Button>().Released += value; }
			remove { GetTarget<Gwen.Control.Button>().Released -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Toggled
		{
			add { GetTarget<Gwen.Control.Button>().Toggled += value; }
			remove { GetTarget<Gwen.Control.Button>().Toggled -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ToggledOff
		{
			add { GetTarget<Gwen.Control.Button>().ToggledOff += value; }
			remove { GetTarget<Gwen.Control.Button>().ToggledOff -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ToggledOn
		{
			add { GetTarget<Gwen.Control.Button>().ToggledOn += value; }
			remove { GetTarget<Gwen.Control.Button>().ToggledOn -= value; }
		}
	}
}
