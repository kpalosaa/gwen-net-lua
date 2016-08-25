using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class ControlBase
	{
		private Gwen.Control.ControlBase target;

		[MoonSharpHidden]
		public ControlBase(Gwen.Control.ControlBase target)
		{
			this.target = target;
		}

		[MoonSharpHidden]
		public T GetTarget<T>() where T: Gwen.Control.ControlBase
		{
			return (T)target;
		}

		[MoonSharpHidden]
		public Gwen.Control.ControlBase Target { get { return target; } }

		public string Name { get { return target.Name; } set { target.Name = value; } }

		public int Left { get { return target.Left; } set { target.Left = value; } }
		public int Top { get { return target.Top; } set { target.Top = value; } }
		public int Width { get { return target.Width; } set { target.Width = value; } }
		public int Height { get { return target.Height; } set { target.Height = value; } }

		public Point Position { get { return new Point(target.Position); } set { target.Position = value.Target; } }
		public Size Size { get { return new Size(target.Size); } set { target.Size = value.Target; } }

		public Size MaximumSize { get { return new Size(target.MaximumSize); } set { target.MaximumSize = value.Target; } }
		public Size MinimumSize { get { return new Size(target.MinimumSize); } set { target.MinimumSize = value.Target; } }

		public Margin Margin { get { return new Margin(target.Margin); } set { target.Margin = value.Target; } }
		public Padding Padding { get { return new Padding(target.Padding); } set { target.Padding = value.Target; } }

		public Anchor Anchor { get { return new Anchor(target.Anchor); } set { target.Anchor = value.Target; } }
		public Rectangle AnchorBounds { get { return new Rectangle(target.AnchorBounds); } set { target.AnchorBounds = value.Target; } }

		public bool IsHidden { get { return target.IsHidden; } set { target.IsHidden = value; } }
		public bool IsCollapsed { get { return target.IsCollapsed; } set { target.IsCollapsed = value; } }
		public bool IsDisabled { get { return target.IsDisabled; } set { target.IsDisabled = value; } }

		public string ToolTipText { get { return target.ToolTipText; } set { target.ToolTipText = value; } }
	}
}
