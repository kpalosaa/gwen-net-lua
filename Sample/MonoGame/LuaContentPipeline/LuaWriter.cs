using System;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace GwenNetLua.LuaContentPipeline
{
	public class LuaWriter : ContentTypeWriter<byte[]>
	{
		protected override void Write(ContentWriter output, byte[] value)
		{
			output.Write(value);
		}

		public override string GetRuntimeType(TargetPlatform targetPlatform)
		{
			return typeof(string).AssemblyQualifiedName;
		}

		public override string GetRuntimeReader(TargetPlatform targetPlatform)
		{
			return "GwenNetLua.LuaReader";
		}
	}
}
