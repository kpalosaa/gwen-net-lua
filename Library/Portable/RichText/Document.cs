using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Document
	{
		Gwen.RichText.Document target;

		public static Document Create()
		{
			return new Document();
		}

		public static Document Create(string text)
		{
			return new Document(text);
		}

		[MoonSharpHidden]
		public Document(string text = null)
		{
			if (text == null)
				target = new Gwen.RichText.Document();
			else
				target = new Gwen.RichText.Document(text);
		}

		[MoonSharpHidden]
		public Document(Gwen.RichText.Document document)
		{
			target = document;
		}

		[MoonSharpHidden]
		public Gwen.RichText.Document Target { get { return target; } }

		public ImageParagraph Image(string imageName, Margin margin, int indent)
		{
			return new ImageParagraph(target.Image(imageName, margin.Target, indent));
		}

		public ImageParagraph Image(string imageName, Size imageSize, Margin margin = null, int indent = 0)
		{
			return new ImageParagraph(target.Image(imageName, imageSize.Target, margin != null ? margin.Target : Gwen.Margin.Zero, indent));
		}

		public ImageParagraph Image(string imageName, Size imageSize = null, Rectangle textureRect = null, Color imageColor = null, Margin margin = null, int indent = 0)
		{
			return new ImageParagraph(target.Image(
				imageName,
				imageSize != null ? (Gwen.Size?)imageSize.Target : null,
				textureRect != null ? (Gwen.Rectangle?)textureRect.Target : null,
				imageColor != null ? (Gwen.Color?)imageColor.Target : null,
				margin != null ? margin.Target : Gwen.Margin.Zero, 
				indent));
		}

		public Paragraph Paragraph(Margin margin = null, int firstIndent = 0, int remainingIndent = 0)
		{
			return new Paragraph(target.Paragraph(margin != null ? margin.Target : Gwen.Margin.Zero, firstIndent, remainingIndent));
		}
	}
}
