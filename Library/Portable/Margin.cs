using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Margin
	{
		public static Margin Create(int margin)
		{
			return new Margin(margin, margin, margin, margin);
		}

		public Margin Create(int horizontal, int vertical)
		{
			return new Margin(horizontal, vertical, horizontal, vertical);
		}

		public static Margin Create(int left, int top, int right, int bottom)
		{
			return new Margin(left, top, right, bottom);
		}

		[MoonSharpHidden]
		public Margin(int left, int top, int right, int bottom)
		{
			target = new Gwen.Margin(left, top, right, bottom);
		}

		[MoonSharpHidden]
		public Margin(Gwen.Margin margin)
		{
			target = margin;
		}

		private Gwen.Margin target;
		[MoonSharpHidden]
		public Gwen.Margin Target { get { return target; } }
	}
}
