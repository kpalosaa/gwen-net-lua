using System;
using System.Collections;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Table : Internal.ControlBase
	{
		public static Table Create(Internal.ControlBase parent)
		{
			return new Table(new Gwen.Control.Table(parent.Target));
		}

		[MoonSharpHidden]
		public Table(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AlternateColor { get { return GetTarget<Gwen.Control.Table>().AlternateColor; } set { GetTarget<Gwen.Control.Table>().AlternateColor = value; } }
		public bool AutoSizeToContent { get { return GetTarget<Gwen.Control.Table>().AutoSizeToContent; } set { GetTarget<Gwen.Control.Table>().AutoSizeToContent = value; } }
		public int ColumnCount { get { return GetTarget<Gwen.Control.Table>().ColumnCount; } set { GetTarget<Gwen.Control.Table>().ColumnCount = value; } }
		public string DisplayMember { get { return GetTarget<Gwen.Control.Table>().DisplayMember; } set { GetTarget<Gwen.Control.Table>().DisplayMember = value; } }
		public string[] DisplayMembers { get; set; }
		public IEnumerable ItemsSource { get { return GetTarget<Gwen.Control.Table>().ItemsSource; } set { GetTarget<Gwen.Control.Table>().ItemsSource = value; } }
		public int RowCount { get { return GetTarget<Gwen.Control.Table>().RowCount; } }
	}
}
