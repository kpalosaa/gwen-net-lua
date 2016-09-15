using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public class Paragraph
	{
		Gwen.RichText.Paragraph paragraph;

		public static Paragraph Create(Margin margin = null, int firstIndent = 0, int remainingIndent = 0)
		{
			return new Paragraph(margin, firstIndent, remainingIndent);
		}

		[MoonSharpHidden]
		public Paragraph(Margin margin = null, int firstIndent = 0, int remainingIndent = 0)
		{
			paragraph = new Gwen.RichText.Paragraph(margin != null ? margin.Target : Gwen.Margin.Zero, firstIndent, remainingIndent);
		}

		[MoonSharpHidden]
		public Paragraph(Gwen.RichText.Paragraph paragraph)
		{
			this.paragraph = paragraph;
		}

		public int FirstIndent { get { return paragraph.FirstIndent; } }
		public Margin Margin { get { return new Margin(paragraph.Margin); } }
		public int RemainigIndent { get { return paragraph.RemainigIndent; } }

		public Paragraph Font(Font font = null) { return new Paragraph(paragraph.Font(font != null ? font.Target : null)); }
		public Paragraph LineBreak() { return new Paragraph(paragraph.LineBreak()); }
		public Paragraph Link(string text, string link, Color color = null, Color hoverColor = null, Font hoverFont = null)
		{
			return new Paragraph(paragraph.Link(
				text,
				link,
				color != null ? (Gwen.Color?)color.Target : null,
				hoverColor != null ? (Gwen.Color?)hoverColor.Target : null,
				hoverFont != null ? (Gwen.Font)hoverFont.Target : null));
		}
		public Paragraph Text(string text) { return new Paragraph(paragraph.Text(text)); }
		public Paragraph Text(string text, Color color) { return new Paragraph(paragraph.Text(text, color.Target)); }
	}
}
