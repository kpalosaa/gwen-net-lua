using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Xml
{
	public class LuaComponent : Gwen.Xml.Component
	{
		private Script script;
		private DynValue self;

		static LuaComponent()
		{
			Gwen.Xml.Parser.RegisterEventHandlerConverter(typeof(LuaEventArgs), (attribute, value) =>
			{
				return new Gwen.Control.ControlBase.GwenEventHandler<LuaEventArgs>(new Gwen.Xml.XmlEventHandler<LuaEventArgs>(value, attribute).OnEvent);
			});
		}

		public static void RegisterComponent(string name, Gwen.Xml.IXmlSource xmlSource, Script script)
		{
			Gwen.Xml.Component.Register<LuaComponent>(name, name, xmlSource, script);
		}

		public LuaComponent(Gwen.Control.ControlBase parent, string name, Gwen.Xml.IXmlSource xmlSource, Script script)
			: base(parent, xmlSource)
		{
			this.script = script;

			self = script.Call(script.Globals.Get(name), View);
			if (self.Type != DataType.Table)
				throw new ScriptRuntimeException("Component must be implemented as a lua table");
		}

		public override bool GetValue(string name, out object value)
		{
			value = null;
			return false;
		}

		public override bool GetValueType(string name, out Type type)
		{
			var field = self.Table.Get(name);
			switch (field.Type)
			{
				case DataType.String:
					type = typeof(string);
					return true;
				case DataType.Number:
					type = typeof(double);
					return true;
				case DataType.Boolean:
					type = typeof(bool);
					return true;
				case DataType.UserData:
					if (field.UserData.Object is LuaEvent)
					{
						type = typeof(LuaEventArgs);
						return true;
					}
					break;
			}

			type = null;
			return false;
		}

		public override bool SetValue(string name, object value)
		{
			var field = self.Table.Get(name);
			if (field == null)
				return false;

			switch (field.Type)
			{
				case DataType.String:
					self.Table.Set(name, DynValue.NewString((string)value));
					return true;
				case DataType.Number:
					self.Table.Set(name, DynValue.NewNumber((double)value));
					return true;
				case DataType.Boolean:
					self.Table.Set(name, DynValue.NewBoolean((bool)value));
					return true;
				case DataType.UserData:
					if (field.UserData.Object is LuaEvent && value is Gwen.Control.ControlBase.GwenEventHandler<LuaEventArgs>)
					{
						LuaEvent e = field.UserData.Object as LuaEvent;
						e.Invoked += value as Gwen.Control.ControlBase.GwenEventHandler<LuaEventArgs>;
						return true;
					}
					break;
			}

			return false;
		}

		public override bool HandleEvent(string eventName, string handlerName, Gwen.Control.ControlBase sender, EventArgs args)
		{
			var func = self.Table[handlerName];
			if (func == null)
				return false;

			script.Call(func, sender, args);

			return true;
		}

		public DynValue Self { get { return self; } }
	}
}
