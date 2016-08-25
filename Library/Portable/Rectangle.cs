using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Rectangle
	{
		public static Rectangle Create(int left, int top, int width, int height)
		{
			return new Rectangle(left, top, width, height);
		}

		[MoonSharpHidden]
		public Rectangle(int left, int top, int width, int height)
		{
			target = new Gwen.Rectangle(left, top, width, height);
		}

		[MoonSharpHidden]
		public Rectangle(Gwen.Rectangle rect)
		{
			target = rect;
		}

		private Gwen.Rectangle target;
		[MoonSharpHidden]
		public Gwen.Rectangle Target { get { return target; } }
	}
}
