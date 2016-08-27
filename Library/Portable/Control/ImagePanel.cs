using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ImagePanel : Internal.ControlBase
	{
		public static ImagePanel Create(Internal.ControlBase parent)
		{
			return new ImagePanel(new Gwen.Control.ImagePanel(parent.Target));
		}

		[MoonSharpHidden]
		public static ImagePanel Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ImagePanel(control);
		}

		[MoonSharpHidden]
		public ImagePanel(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public Color ImageColor { get { return new Color(GetTarget<Gwen.Control.ImagePanel>().ImageColor); } set { GetTarget<Gwen.Control.ImagePanel>().ImageColor = value.Target; } }
		public string ImageName { get { return GetTarget<Gwen.Control.ImagePanel>().ImageName; } set { GetTarget<Gwen.Control.ImagePanel>().ImageName = value; } }
		public Size ImageSize { get { return new Size(GetTarget<Gwen.Control.ImagePanel>().ImageSize); } set { GetTarget<Gwen.Control.ImagePanel>().ImageSize = value.Target; } }
		public Rectangle TextureRect { get { return new Rectangle(GetTarget<Gwen.Control.ImagePanel>().TextureRect); } set { GetTarget<Gwen.Control.ImagePanel>().TextureRect = value.Target; } }
	}
}
