using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class HSVColorPicker : Internal.ButtonBase
	{
		public static HSVColorPicker Create(Internal.ControlBase parent)
		{
			return new HSVColorPicker(new Gwen.Control.HSVColorPicker(parent.Target));
		}

		[MoonSharpHidden]
		public static HSVColorPicker Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new HSVColorPicker(control);
		}

		[MoonSharpHidden]
		public HSVColorPicker(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Color DefaultColor { get { return new Color(GetTarget<Gwen.Control.HSVColorPicker>().DefaultColor); } set { GetTarget<Gwen.Control.HSVColorPicker>().DefaultColor = value.Target; } }
		public bool EnableDefaultColor { get { return GetTarget<Gwen.Control.HSVColorPicker>().EnableDefaultColor; } set { GetTarget<Gwen.Control.HSVColorPicker>().EnableDefaultColor = value; } }
		public Color SelectedColor { get { return new Color(GetTarget<Gwen.Control.HSVColorPicker>().SelectedColor); } set { GetTarget<Gwen.Control.HSVColorPicker>().SelectedColor = value.Target; } }

		public void SetColor(Color color, bool onlyHue = false, bool reset = false) { GetTarget<Gwen.Control.HSVColorPicker>().SetColor(color.Target, onlyHue, reset); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> ColorChanged
		{
			add { GetTarget<Gwen.Control.HSVColorPicker>().ColorChanged += value; }
			remove { GetTarget<Gwen.Control.HSVColorPicker>().ColorChanged -= value; }
		}
	}
}
