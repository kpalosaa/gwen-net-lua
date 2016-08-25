using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Point
	{
		public static Point Create(int x, int y)
		{
			return new Point(x, y);
		}

		[MoonSharpHidden]
		public Point(int x, int y)
		{
			target = new Gwen.Point(x, y);
		}

		[MoonSharpHidden]
		public Point(Gwen.Point point)
		{
			target = point;
		}

		private Gwen.Point target;
		[MoonSharpHidden]
		public Gwen.Point Target { get { return target; } }
	}
}
