using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class CrossSplitter : Internal.ControlBase
	{
		public static CrossSplitter Create(Internal.ControlBase parent)
		{
			return new CrossSplitter(new Gwen.Control.CrossSplitter(parent.Target));
		}

		[MoonSharpHidden]
		public static CrossSplitter Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new CrossSplitter(control);
		}

		[MoonSharpHidden]
		public CrossSplitter(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsZoomed { get { return GetTarget<Gwen.Control.CrossSplitter>().IsZoomed; } }
		public int SplitterSize { get { return GetTarget<Gwen.Control.CrossSplitter>().SplitterSize; } set { GetTarget<Gwen.Control.CrossSplitter>().SplitterSize = value; } }
		public bool SplittersVisible { get { return GetTarget<Gwen.Control.CrossSplitter>().SplittersVisible; } set { GetTarget<Gwen.Control.CrossSplitter>().SplittersVisible = value; } }

		public void CenterPanels() { GetTarget<Gwen.Control.CrossSplitter>().CenterPanels(); }
		public void SetPanel(int index, Internal.ControlBase panel) { GetTarget<Gwen.Control.CrossSplitter>().SetPanel(index, panel.Target); }
		public void UnZoom() { GetTarget<Gwen.Control.CrossSplitter>().UnZoom(); }
		public void Zoom(int section) { GetTarget<Gwen.Control.CrossSplitter>().Zoom(section); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelUnZoomed
		{
			add { GetTarget<Gwen.Control.CrossSplitter>().PanelUnZoomed += value; }
			remove { GetTarget<Gwen.Control.CrossSplitter>().PanelUnZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> PanelZoomed
		{
			add { GetTarget<Gwen.Control.CrossSplitter>().PanelZoomed += value; }
			remove { GetTarget<Gwen.Control.CrossSplitter>().PanelZoomed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ZoomChanged
		{
			add { GetTarget<Gwen.Control.CrossSplitter>().ZoomChanged += value; }
			remove { GetTarget<Gwen.Control.CrossSplitter>().ZoomChanged -= value; }
		}
	}
}
