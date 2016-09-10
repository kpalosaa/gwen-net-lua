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

		public static readonly Margin Zero = new Margin(Gwen.Margin.Zero);
		public static readonly Margin One = new Margin(Gwen.Margin.One);
		public static readonly Margin Two = new Margin(Gwen.Margin.Two);
		public static readonly Margin Three = new Margin(Gwen.Margin.Three);
		public static readonly Margin Four = new Margin(Gwen.Margin.Four);
		public static readonly Margin Five = new Margin(Gwen.Margin.Five);
		public static readonly Margin Six = new Margin(Gwen.Margin.Six);
		public static readonly Margin Seven = new Margin(Gwen.Margin.Seven);
		public static readonly Margin Eight = new Margin(Gwen.Margin.Eight);
		public static readonly Margin Nine = new Margin(Gwen.Margin.Nine);
		public static readonly Margin Ten = new Margin(Gwen.Margin.Ten);

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
