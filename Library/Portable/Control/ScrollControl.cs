using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ScrollControl : Internal.ControlBase
	{
		public static ScrollControl Create(Internal.ControlBase parent)
		{
			return new ScrollControl(new Gwen.Control.ScrollControl(parent.Target));
		}

		[MoonSharpHidden]
		public static ScrollControl Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ScrollControl(control);
		}

		[MoonSharpHidden]
		public ScrollControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AutoHideBars { get { return GetTarget<Gwen.Control.ScrollControl>().AutoHideBars; } set { GetTarget<Gwen.Control.ScrollControl>().AutoHideBars = value; } }
		public bool AutoSizeToContent { get { return GetTarget<Gwen.Control.ScrollControl>().AutoSizeToContent; } set { GetTarget<Gwen.Control.ScrollControl>().AutoSizeToContent = value; } }
		public bool CanScrollH { get { return GetTarget<Gwen.Control.ScrollControl>().CanScrollH; } set { GetTarget<Gwen.Control.ScrollControl>().CanScrollH = value; } }
		public bool CanScrollV { get { return GetTarget<Gwen.Control.ScrollControl>().CanScrollV; } set { GetTarget<Gwen.Control.ScrollControl>().CanScrollV = value; } }
		public Size ContentSize { get { return new Size(GetTarget<Gwen.Control.ScrollControl>().ContentSize); } }
		public int HorizontalScroll { get { return GetTarget<Gwen.Control.ScrollControl>().HorizontalScroll; } set { GetTarget<Gwen.Control.ScrollControl>().HorizontalScroll = value; } }
		public int VerticalScroll { get { return GetTarget<Gwen.Control.ScrollControl>().VerticalScroll; } set { GetTarget<Gwen.Control.ScrollControl>().VerticalScroll = value; } }
		public Size ViewableContentSize { get { return new Size(GetTarget<Gwen.Control.ScrollControl>().ViewableContentSize); } }

		public void EnsureVisible(Rectangle rect) { GetTarget<Gwen.Control.ScrollControl>().EnsureVisible(rect.Target); }
		public void EnsureVisible(Rectangle rect, Size minChange) { GetTarget<Gwen.Control.ScrollControl>().EnsureVisible(rect.Target, minChange.Target); }
		public void ScrollToBottom() { GetTarget<Gwen.Control.ScrollControl>().ScrollToBottom(); }
		public void ScrollToLeft() { GetTarget<Gwen.Control.ScrollControl>().ScrollToLeft(); }
		public void ScrollToRight() { GetTarget<Gwen.Control.ScrollControl>().ScrollToRight(); }
		public void ScrollToTop() { GetTarget<Gwen.Control.ScrollControl>().ScrollToTop(); }
	}
}
