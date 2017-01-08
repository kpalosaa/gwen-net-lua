using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Gwen.Loader.MonoGame;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;

namespace Sample.MonoGame.Windows
{
	public class SampleLoader : MonoGameAssetLoader, IScriptLoader
	{
		public SampleLoader(ContentManager contentManager)
			: base(contentManager)
		{
		}

		public object LoadFile(string file, Table globalContext)
		{
			byte[] bytes = ContentManager.Load<byte[]>(file);

			using (var outputStream = new MemoryStream())
			{
				Decompress(outputStream, bytes);

				return Encoding.UTF8.GetString(outputStream.ToArray());
			}
		}

		public string ResolveFileName(string filename, Table globalContext)
		{
			if (filename.Contains(".lua"))
				filename = filename.Substring(0, filename.Length - 4);

			filename = filename.Replace('.', '/');

			return "Lua/" + filename;
		}

		public string ResolveModuleName(string modname, Table globalContext)
		{
			return modname;
		}
	}
}
