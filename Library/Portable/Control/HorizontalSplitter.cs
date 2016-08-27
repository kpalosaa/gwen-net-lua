using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class HorizontalSplitter : Internal.ControlBase
	{
		public static HorizontalSplitter Create(Internal.ControlBase parent)
		{
			return new HorizontalSplitter(new Gwen.Control.HorizontalSplitter(parent.Target));
		}

		[MoonSharpHidden]
		public static HorizontalSplitter Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new HorizontalSplitter(control);
		}

		[MoonSharpHidden]
		public HorizontalSplitter(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsZoomed { get { return GetTarget<Gwen.Control.HorizontalSplitter>().IsZoomed; } }
		public int SplitterSize { get { return GetTarget<Gwen.Control.HorizontalSplitter>().SplitterSize; } set { GetTarget<Gwen.Control.HorizontalSplitter>().SplitterSize = value; } }
		public bool SplittersVisible { get { return GetTarget<Gwen.Control.HorizontalSplitter>().SplittersVisible; } set { GetTarget<Gwen.Control.HorizontalSplitter>().SplittersVisible = value; } }
		public float Value { get { return GetTarget<Gwen.Control.HorizontalSplitter>().Value; } set { GetTarget<Gwen.Control.HorizontalSplitter>().Value = value; } }

		public void CenterPanels() { GetTarget<Gwen.Control.HorizontalSplitter>().CenterPanels(); }
		public void SetPanel(int index, Internal.ControlBase panel) { GetTarget<Gwen.Control.HorizontalSplitter>().SetPanel(index, panel.Target); }
		public void UnZoom() { GetTarget<Gwen.Control.HorizontalSplitter>().UnZoom(); }
		public void Zoom(int section) { GetTarget<Gwen.Control.HorizontalSplitter>().Zoom(section); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelUnZoomed
		{
			add { GetTarget<Gwen.Control.HorizontalSplitter>().PanelUnZoomed += value; }
			remove { GetTarget<Gwen.Control.HorizontalSplitter>().PanelUnZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelZoomed
		{
			add { GetTarget<Gwen.Control.HorizontalSplitter>().PanelZoomed += value; }
			remove { GetTarget<Gwen.Control.HorizontalSplitter>().PanelZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ZoomChanged
		{
			add { GetTarget<Gwen.Control.HorizontalSplitter>().ZoomChanged += value; }
			remove { GetTarget<Gwen.Control.HorizontalSplitter>().ZoomChanged -= value; }
		}
	}
}
