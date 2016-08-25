using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Sample
{
	public class LuaTest
	{
		private Script script;

		public LuaTest(Gwen.Control.Canvas canvas)
		{
			script = new Script(CoreModules.Preset_SoftSandbox);
			script.Options.DebugPrint = t => System.Diagnostics.Debug.WriteLine(t);

			GwenNetLua.Lua.Init(script, canvas);
		}

		public void Run()
		{
			 script.DoString(
@"
	data = 
	{
		[0] = { name = 'test1' },
		[1] = { name = 'test2' }
	}

	table = Gwen.Table.Create(Gwen.Canvas)
	table.Width = 200
	table.Height = 200
	table.DisplayMember = 'name'
	table.ItemsSource = data
");
		}
	}
}
