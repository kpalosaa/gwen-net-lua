﻿using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Color
	{
		public static Color Create(int a, int r, int g, int b)
		{
			return new Color(a, r, g, b);
		}

		public static Color Create(int r, int g, int b)
		{
			return new Color(r, g, b);
		}

		public static Color Create(string name)
		{
			return new Color(name);
		}

		[MoonSharpHidden]
		public Color(int a, int r, int g, int b)
		{
			target = new Gwen.Color(a, r, g, b);
		}

		[MoonSharpHidden]
		public Color(int r, int g, int b)
		{
			target = new Gwen.Color(r, g, b);
		}

		[MoonSharpHidden]
		public Color(string name)
		{
			target = Gwen.Color.FromName(name);
		}

		[MoonSharpHidden]
		public Color(Gwen.Color color)
		{
			target = color;
		}

		private Gwen.Color target;
		[MoonSharpHidden]
		public Gwen.Color Target { get { return target; } }

		public byte A { get { return target.A; } set { target.A = value; } }
		public byte B { get { return target.B; } set { target.B = value; } }
		public byte G { get { return target.G; } set { target.G = value; } }
		public byte R { get { return target.R; } set { target.R = value; } }
	}
}
