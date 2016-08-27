using System;
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

		public ControlBase Parent { set { target.Parent = value.Target; } }

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

		public bool DrawDebugOutlines { get { return target.DrawDebugOutlines; } set { target.DrawDebugOutlines = value; } }

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
			if (control1 == null || control2 == null)
				return Object.Equals(control1, control2);

			return control1.Equals(control2);
		}

		public static bool operator !=(ControlBase control1, ControlBase control2)
		{
			if (control1 == null || control2 == null)
				return !Object.Equals(control1, control2);

			return !(control1.Equals(control2));
		}
	}
}
