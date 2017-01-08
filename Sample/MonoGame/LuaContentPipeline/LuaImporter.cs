using System;
using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace GwenNetLua.LuaContentPipeline
{
	[ContentImporter(".lua", DefaultProcessor = "LuaProcessor", DisplayName = "Lua Importer")]
	public class LuaImporter : ContentImporter<string>
	{
		public override string Import(string filename, ContentImporterContext context)
		{
			context.Logger.LogMessage("Importing Lua file: {0}", filename);

			using (var streamReader = new StreamReader(filename))
			{
				return streamReader.ReadToEnd();
			}
		}
	}
}
