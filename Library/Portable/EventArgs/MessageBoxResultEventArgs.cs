using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class MessageBoxResultEventArgs
	{
		Gwen.Control.MessageBoxResultEventArgs eventArgs;

		[MoonSharpHidden]
		public MessageBoxResultEventArgs(Gwen.Control.MessageBoxResultEventArgs e)
		{
			eventArgs = e;
		}

		public Gwen.Control.MessageBoxResult Result { get { return eventArgs.Result; } }
	}
}
