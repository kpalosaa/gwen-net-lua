using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Padding
	{
		public static Padding Create(int padding)
		{
			return new Padding(padding, padding, padding, padding);
		}

		public Padding Create(int horizontal, int vertical)
		{
			return new Padding(horizontal, vertical, horizontal, vertical);
		}

		public static Padding Create(int left, int top, int right, int bottom)
		{
			return new Padding(left, top, right, bottom);
		}

		[MoonSharpHidden]
		public Padding(int left, int top, int right, int bottom)
		{
			target = new Gwen.Padding(left, top, right, bottom);
		}

		[MoonSharpHidden]
		public Padding(Gwen.Padding padding)
		{
			target = padding;
		}

		private Gwen.Padding target;
		[MoonSharpHidden]
		public Gwen.Padding Target { get { return target; } }
	}
}
