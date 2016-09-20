using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ClickedEventArgs
	{
		Gwen.Control.ClickedEventArgs eventArgs;

		[MoonSharpHidden]
		public ClickedEventArgs(Gwen.Control.ClickedEventArgs e)
		{
			eventArgs = e;
		}

		public bool MouseDown { get { return eventArgs.MouseDown; } }
		public int X { get { return eventArgs.X; } }
		public int Y { get { return eventArgs.Y; } }
		public Point Position { get { return new Point(eventArgs.X, eventArgs.Y); } }
	}
}
