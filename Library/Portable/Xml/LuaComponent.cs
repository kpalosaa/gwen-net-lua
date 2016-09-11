using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Xml
{
	public class LuaComponent : Gwen.Xml.Component
	{
		private Script script;
		private DynValue self;
		private DynValue onCreated;

		static LuaComponent()
		{
			Gwen.Xml.Parser.RegisterEventHandlerConverter(typeof(LuaEventArgs), (attribute, value) =>
			{
				return new Gwen.Control.ControlBase.GwenEventHandler<LuaEventArgs>(new Gwen.Xml.XmlEventHandler<LuaEventArgs>(value, attribute).OnEvent);
			});
		}

		public static void RegisterComponent(string name, DynValue constructor, Gwen.Xml.IXmlSource xmlSource, Script script)
		{
			if (!Gwen.Xml.Component.Register<LuaComponent>(name, constructor, xmlSource, script))
				throw new ScriptRuntimeException("Failed to register component. Name already exists.");
		}

		public LuaComponent(Gwen.Control.ControlBase parent, DynValue constructor, Gwen.Xml.IXmlSource xmlSource, Script script)
			: base(parent, xmlSource)
		{
			this.script = script;

			DynValue result = script.Call(constructor, View);

			switch (result.Type)
			{
				case DataType.Table:
					self = result;
					break;
				case DataType.Tuple:
					if (result.Tuple.Length >= 1)
						self = result.Tuple[0];
					if (result.Tuple.Length >= 2)
						if (result.Tuple[1].Type == DataType.Function)
							onCreated = result.Tuple[1];
					break;
			}

			if (self == null)
				throw new ScriptRuntimeException("Component must be implemented as a lua table.");
		}

		protected override void OnCreated()
		{
			if (onCreated != null)
				script.Call(onCreated, View);
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

			if (args is LuaEventArgs)
				script.Call(func, sender, ((LuaEventArgs)args).Parameters);
			else
				script.Call(func, sender, args);

			return true;
		}

		public DynValue Self { get { return self; } }
	}
}
