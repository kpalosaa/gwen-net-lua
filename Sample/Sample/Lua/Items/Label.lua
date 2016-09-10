
this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)

		label = Gwen.Label.Create(layout)
		label.Text = "Standard label (not autosized)"

		label = Gwen.Label.Create(layout)
		label.Text = "Chinese: \u{4E45}\u{6709}\u{5F52}\u{5929}\u{613F} \u{7EC8}\u{8FC7}\u{9B3C}\u{95E8}\u{5173}"

		label = Gwen.Label.Create(layout)
		label.Text = "Wow, Coloured Text (and tooltip)"
		label.TextColor = Gwen.Color.Create("Blue")
		label.ToolTipText = "I'm a tooltip"

		label = Gwen.Label.Create(layout)
		label.Text = "Coloured Text With Alpha"
		label.TextColor = Gwen.Color.Create(100, 0, 0, 255)

		label = Gwen.Label.Create(layout)
		label.Text = "Custom Font (Comic Sans 25)";
		label.Font = Gwen.Font.Create("Comic Sans MS", 25)

		label = Gwen.Label.Create(layout)
		label.Font = Gwen.Font.Create("French Script MT", 35)
		label.Text = "Custom Font (French Script MT 35)"

		txt = Gwen.Label.Create(layout)
		txt.Text = "Alignment test"

		outer = Gwen.GridLayout.Create(layout)
		outer.ColumnCount = 3
                
			l11 = Gwen.Label.Create(outer)
			l11.Size = Gwen.Size.Create(50, 50)
			l11.Text = "TL"
			l11.Alignment = Gwen.Alignment.Top .. Gwen.Alignment.Left

			l12 = Gwen.Label.Create(outer)
			l12.Size = Gwen.Size.Create(50, 50)
			l12.Text = "T"
			l12.Alignment = Gwen.Alignment.Top .. Gwen.Alignment.CenterH

			l13 = Gwen.Label.Create(outer)
			l13.Size = Gwen.Size.Create(50, 50)
			l13.Text = "TR"
			l13.Alignment = Gwen.Alignment.Top .. Gwen.Alignment.Right

			l21 = Gwen.Label.Create(outer)
			l21.Size = Gwen.Size.Create(50, 50)
			l21.Text = "L"
			l21.Alignment = Gwen.Alignment.Left .. Gwen.Alignment.CenterV

			l22 = Gwen.Label.Create(outer)
			l22.Size = Gwen.Size.Create(50, 50)
			l22.Text = "C"
			l22.Alignment = Gwen.Alignment.CenterH .. Gwen.Alignment.CenterV

			l23 = Gwen.Label.Create(outer)
			l23.Size = Gwen.Size.Create(50, 50)
			l23.Text = "R"
			l23.Alignment = Gwen.Alignment.Right .. Gwen.Alignment.CenterV

			l31 = Gwen.Label.Create(outer)
			l31.Size = Gwen.Size.Create(50, 50)
			l31.Text = "BL"
			l31.Alignment = Gwen.Alignment.Bottom .. Gwen.Alignment.Left

			l32 = Gwen.Label.Create(outer)
			l32.Size = Gwen.Size.Create(50, 50)
			l32.Text = "B"
			l32.Alignment = Gwen.Alignment.Bottom .. Gwen.Alignment.CenterH

			l33 = Gwen.Label.Create(outer)
			l33.Size = Gwen.Size.Create(50, 50)
			l33.Text = "BR"
			l33.Alignment = Gwen.Alignment.Bottom .. Gwen.Alignment.Right

		outer.DrawDebugOutlines = true

AddItem("Non-Interactive", "Label", this)
