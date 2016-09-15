using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class ImageParagraph : Paragraph
	{
		Gwen.RichText.ImageParagraph imageParagraph;

		public static Paragraph Create(Margin margin = null, int indent = 0)
		{
			return new Paragraph(margin, indent);
		}

		[MoonSharpHidden]
		public ImageParagraph(Margin margin = null, int indent = 0)
		{
			this.imageParagraph = new Gwen.RichText.ImageParagraph(margin != null ? margin.Target : Gwen.Margin.Zero, indent);
		}

		[MoonSharpHidden]
		public ImageParagraph(Gwen.RichText.ImageParagraph imageParagraph)
		{
			this.imageParagraph = imageParagraph;
		}

		public Color ImageColor { get { return imageParagraph.ImageColor != null ? new Color((Gwen.Color)imageParagraph.ImageColor) : null; } }
		public string ImageName { get { return imageParagraph.ImageName; } }
		public Size ImageSize { get { return imageParagraph.ImageSize != null ? new Size((Gwen.Size)imageParagraph.ImageSize) : null; } }
		public Rectangle TextureRect { get { return imageParagraph.TextureRect != null ? new Rectangle((Gwen.Rectangle)imageParagraph.TextureRect) : null; } }

		public ImageParagraph Image(string imageName, Size imageSize = null, Rectangle textureRect = null, Color imageColor = null)
		{
			return new ImageParagraph(imageParagraph.Image(
				imageName,
				imageSize != null ? (Gwen.Size?)imageSize.Target : null,
				textureRect != null ? (Gwen.Rectangle?)textureRect.Target : null,
				imageColor != null ? (Gwen.Color?)imageColor.Target : null));
		}
	}
}
