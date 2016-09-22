using System;
using System.Collections;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public abstract class ControlBase : IEquatable<ControlBase>
	{
		private Gwen.Control.ControlBase target;

		[MoonSharpHidden]
		protected ControlBase(Gwen.Control.ControlBase target)
		{
			if (target == null)
				throw new ScriptRuntimeException("Target must not be null");

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

		public object UserData { get { return target.UserData; } set { target.UserData = value; } }

		public ControlBase Parent { set { target.Parent = value != null ? value.Target : null; } }

		public Font DefaultFont { get { return new Font(target.Skin.DefaultFont); } }

		public Gwen.Dock Dock { get { return target.Dock; } set { target.Dock = value; } }
		public Gwen.HorizontalAlignment HorizontalAlignment { get { return target.HorizontalAlignment; } set { target.HorizontalAlignment = value; } }
		public Gwen.VerticalAlignment VerticalAlignment { get { return target.VerticalAlignment; } set { target.VerticalAlignment = value; } }

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

		public IEnumerable Children { get { return target.Children; } }

		public string Type { get { return target.GetType().Name; } }

		public bool ShouldDrawBackground { get { return target.ShouldDrawBackground; } set { target.ShouldDrawBackground = value; } }

		public bool DrawDebugOutlines { get { return target.DrawDebugOutlines; } set { target.DrawDebugOutlines = value; } }

		public int ActualBottom { get { return target.ActualBottom; } }
		public int ActualHeight { get { return target.ActualHeight; } }
		public int ActualLeft { get { return target.ActualLeft; } }
		public Point ActualPosition { get { return new Point(target.ActualPosition); } }
		public int ActualRight { get { return target.ActualRight; } }
		public Size ActualSize { get { return new Size(target.ActualSize); } }
		public int ActualTop { get { return target.ActualTop; } }
		public int ActualWidth { get { return target.ActualWidth; } }

		public void AddAccelerator(string accelerator) { target.AddAccelerator(accelerator); }
		public void AddAccelerator(string accelerator, Gwen.Control.ControlBase.GwenEventHandler<EventArgs> handler) { target.AddAccelerator(accelerator, handler); }
		public void Blur() { target.Blur(); }
		public void BringNextToControl(ControlBase child, bool behind) { target.BringNextToControl(child.Target, behind); }
		public void BringToFront() { target.BringToFront(); }
		public void DelayedDelete() { target.DelayedDelete(); }
		public void DeleteAllChildren() { target.DeleteAllChildren(); }
		public void Focus() { target.Focus(); }
		public void SendToBack() { target.SendToBack(); }
		public void Touch() { target.Touch(); }
		public Gwen.Control.ControlBase FindChildByName(string name, bool recursive = false) { return target.FindChildByName(name, recursive); }
		public Point CanvasPosToLocal(Point pnt) { return new Point(target.CanvasPosToLocal(pnt.Target)); }
		public Point LocalPosToCanvas(Point pnt) { return new Point(target.LocalPosToCanvas(pnt.Target)); }
		public void Show() { target.Show(); }
		public void Hide() { target.Hide(); }
		public void Collapse(bool collapsed = true, bool measure = true) { target.Collapse(collapsed, measure); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> BoundsChanged
		{
			add { target.BoundsChanged += value; }
			remove { target.BoundsChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> Clicked
		{
			add { target.Clicked += value; }
			remove { target.Clicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> DoubleClicked
		{
			add { target.DoubleClicked += value; }
			remove { target.DoubleClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> DoubleRightClicked
		{
			add { target.DoubleRightClicked += value; }
			remove { target.DoubleRightClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> HoverEnter
		{
			add { target.HoverEnter += value; }
			remove { target.HoverEnter -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> HoverLeave
		{
			add { target.HoverLeave += value; }
			remove { target.HoverLeave -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> RightClicked
		{
			add { target.RightClicked += value; }
			remove { target.RightClicked -= value; }
		}

		public bool Equals(ControlBase other)
		{
			return target == other.target;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
				return false;

			ControlBase control = obj as ControlBase;
			if (control == null)
				return false;
			else
				return Equals(control);
		}

		public override int GetHashCode()
		{
			return target.GetHashCode();
		}

		public static bool operator ==(ControlBase control1, ControlBase control2)
		{
			if ((object)control1 == null || (object)control2 == null)
				return Object.Equals(control1, control2);

			return control1.Equals(control2);
		}

		public static bool operator !=(ControlBase control1, ControlBase control2)
		{
			if ((object)control1 == null || (object)control2 == null)
				return !Object.Equals(control1, control2);

			return !(control1.Equals(control2));
		}
	}
}
