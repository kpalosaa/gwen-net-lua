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
				try
				{
					script.DoStream(stream);
				}
				catch (ScriptRuntimeException ex)
				{
					throw new Exception(String.Format("Runtime error in '{0}': {1}", "GwenNetLua.Sample.Lua.Sample.lua", ex.DecoratedMessage), ex);
				}
				catch (SyntaxErrorException ex)
				{
					throw new Exception(String.Format("Syntax error in '{0}': {1}", "GwenNetLua.Sample.Lua.Sample.lua", ex.DecoratedMessage), ex);
				}
			}

			foreach (var res in assembly.GetManifestResourceNames())
			{
				if (res != "GwenNetLua.Sample.Lua.Sample.lua" && res.Contains(".lua"))
				{
					using (Stream stream = assembly.GetManifestResourceStream(res))
					{
						try
						{
							script.DoStream(stream);
						}
						catch (ScriptRuntimeException ex)
						{
							throw new Exception(String.Format("Runtime error in '{0}': {1}", res, ex.DecoratedMessage), ex);
						}
						catch (SyntaxErrorException ex)
						{
							throw new Exception(String.Format("Syntax error in '{0}': {1}", res, ex.DecoratedMessage), ex);
						}
					}
				}
			}

#if false
			script.DoString(
@"
function TestComp(view)
	local self = Gwen.ComponentBase(view)

	function self.handler()
		print('Clicked TestComp')
		comp = self.GetComponent('testComp2')
		comp.inc()
	end

	function self.ev()
		print('TestEvent')
	end

	return self
end

function TestComp2(view)
	local self = Gwen.ComponentBase(view)

	self.Attr = 0
	self.TestEvent = Gwen.Event.Create('TestEvent')

	function self.handler()
		print('Clicked TestComp2')
		self.TestEvent.Invoke(self.GetView(), {})
		control = self.GetControl('button')
		control.Text = 'button'
	end

	function self.inc()
		print('Attr ' .. self.Attr)
		self.Attr = self.Attr + 100
	end

	return self
end

	Gwen.Component.Register('TestComp2', '<VerticalLayout><Button Name=\'button\' Width=\'100\' Height=\'100\' Clicked=\'handler\' /></VerticalLayout>')

	Gwen.Component.Register('TestComp', '<VerticalLayout><Button Width=\'200\' Height=\'50\' Clicked=\'handler\' /><TestComp2 Name=\'testComp2\' Attr=\'565\' TestEvent=\'ev\' /></VerticalLayout>')

	testComp = Gwen.Component.Create('TestComp', Gwen.Canvas)

");
#endif


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
