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
		[0] = { name = 'test1', value = 10 },
		[1] = { name = 'test2', value = 1000 }
	}

	listBox = Gwen.ListBox.Create(Gwen.Canvas)
	listBox.DisplayMembers = { 'name', 'value' }
	listBox.AutoSizeToContent = true
	listBox.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	listBox.VerticalAlignment = Gwen.VerticalAlignment.Bottom
	listBox.Dock = Gwen.Dock.Top
	listBox.ItemsSource = data
	--listBox.RowSelected.add(function(s, e) label.Text = data[s.SelectedRowIndex].name end)
	--listBox.RowSelected.add(function(s, e) label.Text = data[listBox.SelectedRowIndex].name end)
	listBox.RowSelected.add(function(s, e) label.Text = data[e.SelectedIndex].name end)

	label = Gwen.Label.Create(Gwen.Canvas)
	label.Dock = Gwen.Dock.Top

");
		}
	}
}
