using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public static class Lua
	{
		public static void Init(Script script, Gwen.Control.Canvas canvas)
		{
			Table gwen = new Table(script);

			// Register enums

			UserData.RegisterType<Gwen.HorizontalAlignment>();
			gwen["HorizontalAlignment"] = UserData.CreateStatic<Gwen.HorizontalAlignment>();

			UserData.RegisterType<Gwen.VerticalAlignment>();
			gwen["VerticalAlignment"] = UserData.CreateStatic<Gwen.VerticalAlignment>();

			UserData.RegisterType<Gwen.Dock>();
			gwen["Dock"] = UserData.CreateStatic<Gwen.Dock>();

			UserData.RegisterType<Gwen.Alignment>();
			gwen["Alignment"] = UserData.CreateStatic<Gwen.Alignment>();

			UserData.RegisterType<Gwen.Control.ImageAlign>();
			gwen["ImageAlign"] = UserData.CreateStatic<Gwen.Control.ImageAlign>();
			
			// Register event args

			UserData.RegisterType<EventArgs>();
			UserData.RegisterType<Gwen.Control.ClickedEventArgs>();

			// Register structs

			UserData.RegisterType<GwenNetLua.Margin>();
			gwen["Margin"] = typeof(GwenNetLua.Margin);

			UserData.RegisterType<GwenNetLua.Padding>();
			gwen["Padding"] = typeof(GwenNetLua.Padding);

			UserData.RegisterType<GwenNetLua.Point>();
			gwen["Point"] = typeof(GwenNetLua.Point);

			UserData.RegisterType<GwenNetLua.Size>();
			gwen["Size"] = typeof(GwenNetLua.Size);

			UserData.RegisterType<GwenNetLua.Rectangle>();
			gwen["Rectangle"] = typeof(GwenNetLua.Rectangle);

			UserData.RegisterType<GwenNetLua.Font>();
			gwen["Font"] = typeof(GwenNetLua.Font);

			UserData.RegisterType<GwenNetLua.Color>();
			gwen["Color"] = typeof(GwenNetLua.Color);

			UserData.RegisterType<GwenNetLua.Anchor>();
			gwen["Anchor"] = typeof(GwenNetLua.Anchor);

			// Register controls

			UserData.RegisterProxyType<GwenNetLua.Control.Canvas, Gwen.Control.Canvas>(r => new GwenNetLua.Control.Canvas(r));
			gwen["Canvas"] = new GwenNetLua.Control.Canvas(canvas);

			UserData.RegisterProxyType<GwenNetLua.Control.DockLayout, Gwen.Control.Layout.DockLayout>(r => new GwenNetLua.Control.DockLayout(r));
			gwen["DockLayout"] = typeof(GwenNetLua.Control.DockLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.StackLayout, Gwen.Control.Layout.StackLayout>(r => new GwenNetLua.Control.StackLayout(r));
			gwen["StackLayout"] = typeof(GwenNetLua.Control.StackLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.GridLayout, Gwen.Control.Layout.GridLayout>(r => new GwenNetLua.Control.GridLayout(r));
			gwen["GridLayout"] = typeof(GwenNetLua.Control.GridLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.FlowLayout, Gwen.Control.Layout.FlowLayout>(r => new GwenNetLua.Control.FlowLayout(r));
			gwen["FlowLayout"] = typeof(GwenNetLua.Control.FlowLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.AnchorLayout, Gwen.Control.Layout.AnchorLayout>(r => new GwenNetLua.Control.AnchorLayout(r));
			gwen["AnchorLayout"] = typeof(GwenNetLua.Control.AnchorLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.Button, Gwen.Control.Button>(r => new GwenNetLua.Control.Button(r));
			gwen["Button"] = typeof(GwenNetLua.Control.Button);

			gwen.MetaTable = new Table(script);
			gwen.MetaTable["__metatable"] = "Read-only";
			gwen.MetaTable["__index"] = gwen;
			gwen.MetaTable["__newindex"] = (Action<Table, DynValue, DynValue>)((tbl, index, value) =>
			{
				throw new ScriptRuntimeException($"{index} is read-only");
			});

			script.Globals["Gwen"] = gwen;
		}
	}
}
