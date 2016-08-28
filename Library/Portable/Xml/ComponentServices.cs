using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Xml
{
	public class ComponentServices
	{
		private Script script;

		[MoonSharpHidden]
		public ComponentServices(Script script)
		{
			this.script = script;
		}

		public void Register(string name, string xml)
		{
			LuaComponent.RegisterComponent(name, new Gwen.Xml.XmlStringSource(xml), script);
		}

		public DynValue Create(string name, Control.Internal.ControlBase parent)
		{
			LuaComponent component = Gwen.Xml.Component.Create(name, parent.Target) as LuaComponent;
			return component.Self;
		}

		public Gwen.Control.ControlBase GetControl(Gwen.Control.ControlBase view, string name)
		{
			Gwen.Control.ControlBase control = null;
			if (view.Name == name)
				control = view;
			else
				control = view.FindChildByName(name, true);

			return control;
		}

		public DynValue GetComponent(Gwen.Control.ControlBase view, string name)
		{
			Gwen.Control.ControlBase control = null;
			if (view.Name == name)
				control = view;
			else
				control = view.FindChildByName(name, true);

			if (control == null)
				return null;

			if (control.Component != null)
			{
				LuaComponent luaComponent = control.Component as LuaComponent;
				if (luaComponent != null)
					return luaComponent.Self;
				else
					return null;
			}
			else
			{
				return null;
			}
		}
	}
}
