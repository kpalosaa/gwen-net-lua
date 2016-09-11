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

			GwenNetLua.Lua.Init(script, canvas);
		}

		public void Run()
		{
			var assembly = typeof(Sample).GetTypeInfo().Assembly;

			using (Stream stream = assembly.GetManifestResourceStream("GwenNetLua.Sample.Lua.Sample.lua"))
			{
				DynValue result = Run("GwenNetLua.Sample.Lua.Sample.lua", stream);
				if (result.Type == DataType.UserData)
				{
					Control.ListBox textOutput = result.UserData.Object as Control.ListBox;
					if (textOutput != null)
						script.Options.DebugPrint = t => { textOutput.AddRow(t); textOutput.ScrollToBottom(); };
				}
			}
			
			foreach (var res in assembly.GetManifestResourceNames())
			{
				if (res != "GwenNetLua.Sample.Lua.Sample.lua" && res.Contains(".lua"))
				{
					using (Stream stream = assembly.GetManifestResourceStream(res))
					{
						Run(res, stream);
					}
				}
			}
		}

		private DynValue Run(string name, Stream stream)
		{
			try
			{
				return script.DoStream(stream);
			}
			catch (ScriptRuntimeException ex)
			{
				throw new Exception(String.Format("Runtime error in '{0}': {1}", name, ex.DecoratedMessage), ex);
			}
			catch (SyntaxErrorException ex)
			{
				throw new Exception(String.Format("Syntax error in '{0}': {1}", name, ex.DecoratedMessage), ex);
			}
			catch (Exception ex)
			{
				throw new Exception(String.Format("Error in '{0}': {1}", name, ex.Message), ex);
			}
		}
	}
}
