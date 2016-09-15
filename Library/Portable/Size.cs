using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Size
	{
		public static Size Create(int width, int height)
		{
			return new Size(width, height);
		}

		public const int Ignore = Gwen.Util.Ignore;
		public const int Infinity = Gwen.Util.Infinity;

		[MoonSharpHidden]
		public Size(int width, int height)
		{
			target = new Gwen.Size(width, height);
		}

		[MoonSharpHidden]
		public Size(Gwen.Size size)
		{
			target = size;
		}

		private Gwen.Size target;
		[MoonSharpHidden]
		public Gwen.Size Target { get { return target; } }
	}
}
