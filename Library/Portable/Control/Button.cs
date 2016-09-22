using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Button : Internal.ButtonBase
	{
		public static Button Create(Internal.ControlBase parent)
		{
			return new Button(new Gwen.Control.Button(parent.Target));
		}

		[MoonSharpHidden]
		public static Button Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Button(control);
		}

		[MoonSharpHidden]
		public Button(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public string Text { get { return GetTarget<Gwen.Control.Button>().Text; } set { GetTarget<Gwen.Control.Button>().Text = value; } }
		public Gwen.Alignment Alignment { get { return GetTarget<Gwen.Control.Button>().Alignment; } set { GetTarget<Gwen.Control.Button>().Alignment = value; } }
		public Font Font { get { return new Font(GetTarget<Gwen.Control.Button>().Font); } set { GetTarget<Gwen.Control.Button>().Font = value.Target; } }
		public Color TextColor { get { return new Color(GetTarget<Gwen.Control.Button>().TextColor); } set { GetTarget<Gwen.Control.Button>().TextColor = value.Target; } }
		public Color TextColorOverride { get { return new Color(GetTarget<Gwen.Control.Button>().TextColorOverride); } set { GetTarget<Gwen.Control.Button>().TextColorOverride = value.Target; } }
		public Padding TextPadding { get { return new Padding(GetTarget<Gwen.Control.Button>().TextPadding); } set { GetTarget<Gwen.Control.Button>().TextPadding = value.Target; } }
		public string ImageName { get { return GetTarget<Gwen.Control.Button>().ImageName; } set { GetTarget<Gwen.Control.Button>().ImageName = value; } }
		public Gwen.Control.ImageAlign ImageAlign { get { return GetTarget<Gwen.Control.Button>().ImageAlign; } set { GetTarget<Gwen.Control.Button>().ImageAlign = value; } }
		public Color ImageColor { get { return new Color(GetTarget<Gwen.Control.Button>().ImageColor); } set { GetTarget<Gwen.Control.Button>().ImageColor = value.Target; } }
		public Size ImageSize { get { return new Size(GetTarget<Gwen.Control.Button>().ImageSize); } set { GetTarget<Gwen.Control.Button>().ImageSize = value.Target; } }
		public Rectangle ImageTextureRect { get { return new Rectangle(GetTarget<Gwen.Control.Button>().ImageTextureRect); } set { GetTarget<Gwen.Control.Button>().ImageTextureRect = value.Target; } }

		public void SetImage(string imageName, Gwen.Control.ImageAlign imageAlign = Gwen.Control.ImageAlign.LeftSide) { GetTarget<Gwen.Control.Button>().SetImage(imageName, imageAlign); }
	}
}
