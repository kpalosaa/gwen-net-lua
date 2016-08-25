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
	function OnClicked(s, e)
		button.Left = button.Left + 5
		-- print('OnClicked', s, e)
	end

	button = Gwen.Button.Create(Gwen.Canvas)
	button.Margin = Gwen.Margin.Create(4)
	button.Width = 200
	button.Height = 50
	button.Text = 'Test button'
	button.Alignment = Gwen.Alignment.Left
	button.TextPadding = Gwen.Padding.Create(5)
	button.IsToggle = true
	button.Clicked.add(OnClicked)
");
		}
	}
}
