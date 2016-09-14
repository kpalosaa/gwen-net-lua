using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Font
	{
		public static Font Create(string faceName)
		{
			return new Font(faceName);
		}

		public static Font Create(string faceName, int size)
		{
			return new Font(faceName, size);
		}

		public static Font Create(string faceName, int size, Gwen.FontStyle style)
		{
			return new Font(faceName, size, style);
		}

		public string FaceName { get { return target.FaceName; } }
		public int Size { get { return target.Size; } }

		[MoonSharpHidden]
		public Font(string faceName, int size = 10, Gwen.FontStyle style = Gwen.FontStyle.Normal)
		{
			target = Gwen.Font.Create(faceName, size, style);
		}

		[MoonSharpHidden]
		public Font(Gwen.Font font)
		{
			target = font;
		}

		private Gwen.Font target;
		[MoonSharpHidden]
		public Gwen.Font Target { get { return target; } }
	}
}
