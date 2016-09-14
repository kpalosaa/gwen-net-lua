using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class LinkClickedEventArgs
	{
		Gwen.Control.LinkClickedEventArgs eventArgs;

		[MoonSharpHidden]
		public LinkClickedEventArgs(Gwen.Control.LinkClickedEventArgs e)
		{
			eventArgs = e;
		}

		public string Link { get { return eventArgs.Link; } }
	}
}
