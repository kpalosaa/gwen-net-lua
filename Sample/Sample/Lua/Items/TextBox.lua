
local function OnTextChanged(s, e)
	print(string.format("TextBox: TextChanged: %s", s.Text))
end

local function OnSubmitPressed(s, e)
	print(string.format("TextBox: SubmitPressed: %s", s.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	font1 = Gwen.Font.Create("Courier New", Gwen.Canvas.DefaultFont.Size)
	font2 = Gwen.Font.Create("Times New Roman", 3 * Gwen.Canvas.DefaultFont.Size)
	font3 = Gwen.Font.Create(Gwen.Canvas.DefaultFont.FaceName, Gwen.Canvas.DefaultFont.Size + 5)

	vlayout = Gwen.VerticalLayout.Create(this)

		dockLayout = Gwen.DockLayout.Create(vlayout)

			vlayout2 = Gwen.VerticalLayout.Create(dockLayout)
			vlayout2.Dock = Gwen.Dock.Left
			vlayout2.Width = 200

				-- Vanilla Textbox
				textbox = Gwen.TextBox.Create(vlayout2)
				textbox.Margin = Gwen.Margin.Five;
				textbox.Text = "Type something here"
				textbox.TextChanged.add(OnTextChanged)
				textbox.SubmitPressed.add(OnSubmitPressed)

				textbox = Gwen.TextBoxPassword.Create(vlayout2)
				textbox.Margin = Gwen.Margin.Five
				textbox.Text = "secret"
				textbox.TextChanged.add(OnTextChanged)

				textbox = Gwen.TextBox.Create(vlayout2)
				textbox.Margin = Gwen.Margin.Five
				textbox.Text = "Select All Text On Focus"
				textbox.SelectAllOnFocus = true

				textbox = Gwen.TextBox.Create(vlayout2)
				textbox.Margin = Gwen.Margin.Five
				textbox.Text = "Different Coloured Text, for some reason"
				textbox.TextColor = Gwen.Color.Create("Green")

				textbox = Gwen.TextBoxNumeric.Create(vlayout2)
				textbox.Margin = Gwen.Margin.Five
				textbox.Value = 2004566
				textbox.TextColor = Gwen.Color.Create("Red")

			-- Multiline Textbox 
			textbox = Gwen.MultilineTextBox.Create(dockLayout)
			textbox.Dock = Gwen.Dock.Fill
			textbox.Margin = Gwen.Margin.Five
			textbox.Font = font1
			textbox.AcceptTabs = true
			textbox.Text = "In olden times when wishing still helped one, there lived a king whose daughters were all beautiful,\nbut the youngest was so beautiful that the sun itself, which has seen so much, \nwas astonished whenever it shone in her face. \nClose by the king's castle lay a great dark forest, \nand under an old lime-tree in the forest was a well, and when the day was very warm, \nthe king's child went out into the forest and sat down by the side of the cool fountain, \nand when she was bored she took a golden ball, and threw it up on high and caught it, \nand this ball was her favorite plaything."

		textbox = Gwen.TextBox.Create(vlayout)
		textbox.Margin = Gwen.Margin.Five
		textbox.Text = "In olden times when wishing still helped one, there lived a king whose daughters were all beautiful, but the youngest was so beautiful that the sun itself, which has seen so much, was astonished whenever it shone in her face. Close by the king's castle lay a great dark forest, and under an old lime-tree in the forest was a well, and when the day was very warm, the king's child went out into the forest and sat down by the side of the cool fountain, and when she was bored she took a golden ball, and threw it up on high and caught it, and this ball was her favorite plaything."
		textbox.TextColor = Gwen.Color.Create("Black")
		textbox.Font = font3

		textbox = Gwen.TextBox.Create(vlayout)
		textbox.Margin = Gwen.Margin.Five
		textbox.Width = 150
		textbox.HorizontalAlignment = Gwen.HorizontalAlignment.Right
		textbox.Text = "あおい　うみから　やってきた"
		textbox.TextColor = Gwen.Color.Create("Black")
		textbox.Font = font3

		textbox = Gwen.TextBox.Create(vlayout)
		textbox.Margin = Gwen.Margin.Five
		textbox.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		textbox.FitToText = "Fit the text"
		textbox.Text = "FitToText"
		textbox.TextColor = Gwen.Color.Create("Black")
		textbox.Font = font3

		textbox = Gwen.TextBox.Create(vlayout)
		textbox.Margin = Gwen.Margin.Five
		textbox.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		textbox.Width = 200
		textbox.Text = "Width = 200"
		textbox.TextColor = Gwen.Color.Create("Black")
		textbox.Font = font3

		textbox = Gwen.TextBox.Create(vlayout)
		textbox.Margin = Gwen.Margin.Five
		textbox.Text = "Different Font"
		textbox.Font = font2

AddItem("Standard", "TextBox", this)
