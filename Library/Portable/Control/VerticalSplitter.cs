using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class VerticalSplitter : Internal.ControlBase
	{
		public static VerticalSplitter Create(Internal.ControlBase parent)
		{
			return new VerticalSplitter(new Gwen.Control.VerticalSplitter(parent.Target));
		}

		[MoonSharpHidden]
		public static VerticalSplitter Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new VerticalSplitter(control);
		}

		[MoonSharpHidden]
		public VerticalSplitter(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsZoomed { get { return GetTarget<Gwen.Control.VerticalSplitter>().IsZoomed; } }
		public int SplitterSize { get { return GetTarget<Gwen.Control.VerticalSplitter>().SplitterSize; } set { GetTarget<Gwen.Control.VerticalSplitter>().SplitterSize = value; } }
		public bool SplittersVisible { get { return GetTarget<Gwen.Control.VerticalSplitter>().SplittersVisible; } set { GetTarget<Gwen.Control.VerticalSplitter>().SplittersVisible = value; } }
		public float Value { get { return GetTarget<Gwen.Control.VerticalSplitter>().Value; } set { GetTarget<Gwen.Control.VerticalSplitter>().Value = value; } }

		public void CenterPanels() { GetTarget<Gwen.Control.VerticalSplitter>().CenterPanels(); }
		public void SetPanel(int index, Internal.ControlBase panel) { GetTarget<Gwen.Control.VerticalSplitter>().SetPanel(index, panel.Target); }
		public void UnZoom() { GetTarget<Gwen.Control.VerticalSplitter>().UnZoom(); }
		public void Zoom(int section) { GetTarget<Gwen.Control.VerticalSplitter>().Zoom(section); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelUnZoomed
		{
			add { GetTarget<Gwen.Control.VerticalSplitter>().PanelUnZoomed += value; }
			remove { GetTarget<Gwen.Control.VerticalSplitter>().PanelUnZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelZoomed
		{
			add { GetTarget<Gwen.Control.VerticalSplitter>().PanelZoomed += value; }
			remove { GetTarget<Gwen.Control.VerticalSplitter>().PanelZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ZoomChanged
		{
			add { GetTarget<Gwen.Control.VerticalSplitter>().ZoomChanged += value; }
			remove { GetTarget<Gwen.Control.VerticalSplitter>().ZoomChanged -= value; }
		}
	}
}
