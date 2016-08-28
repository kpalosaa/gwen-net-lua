using System;
using System.Collections;
using MoonSharp.Interpreter;

namespace GwenNetLua.Xml
{
	public class LuaEvent
	{
		private string name;

		public static LuaEvent Create(string name)
		{
			return new LuaEvent(name);
		}

		public void Invoke(Gwen.Control.ControlBase sender, IDictionary parameters)
		{
			Invoked?.Invoke(sender, new LuaEventArgs() { Parameters = parameters });
		}

		[MoonSharpHidden]
		public event Gwen.Control.ControlBase.GwenEventHandler<LuaEventArgs> Invoked;

		[MoonSharpHidden]
		public LuaEvent(string name)
		{
			this.name = name;
		}
	}
}
