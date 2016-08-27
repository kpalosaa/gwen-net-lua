using System;
using System.IO;
using System.Reflection;
using MoonSharp.Interpreter;

namespace GwenNetLua.Sample
{
	public class Sample
	{
		private Script script;

		public Sample(Gwen.Control.Canvas canvas)
		{
			script = new Script(CoreModules.Preset_SoftSandbox);
			script.Options.DebugPrint = t => System.Diagnostics.Debug.WriteLine(t);

			GwenNetLua.Lua.Init(script, canvas);
		}

		public void Run()
		{
			var assembly = typeof(Sample).GetTypeInfo().Assembly;

			using (Stream stream = assembly.GetManifestResourceStream("GwenNetLua.Sample.Lua.Sample.lua"))
			{
				script.DoStream(stream);
			}

			foreach (var res in assembly.GetManifestResourceNames())
			{
				if (res != "GwenNetLua.Sample.Lua.Sample.lua")
				{
					using (Stream stream = assembly.GetManifestResourceStream(res))
					{
						script.DoStream(stream);
					}
				}
			}




#if false
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
#endif
		}
	}
}
