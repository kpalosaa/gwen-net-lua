using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TableRow : Internal.ControlBase
	{
		public static TableRow Create(Internal.ControlBase parent)
		{
			return new TableRow(new Gwen.Control.TableRow(parent.Target));
		}

		[MoonSharpHidden]
		public TableRow(Gwen.Control.ControlBase control)
			: base(control)
		{
		}
	}
}
