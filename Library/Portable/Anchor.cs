using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Anchor
	{
		public static Anchor Create(int left, int top, int right, int bottom)
		{
			return new Anchor(left, top, right, bottom);
		}

		public static readonly Anchor LeftTop = new Anchor(0, 0, 0, 0);
		public static readonly Anchor RightTop = new Anchor(100, 0, 100, 0);
		public static readonly Anchor LeftBottom = new Anchor(0, 100, 0, 100);
		public static readonly Anchor RightBottom = new Anchor(100, 100, 100, 100);

		[MoonSharpHidden]
		public Anchor(int left, int top, int right, int bottom)
		{
			target = new Gwen.Anchor((byte)left, (byte)top, (byte)right, (byte)bottom);
		}

		[MoonSharpHidden]
		public Anchor(Gwen.Anchor anchor)
		{
			target = anchor;
		}

		private Gwen.Anchor target;
		[MoonSharpHidden]
		public Gwen.Anchor Target { get { return target; } }
	}
}
