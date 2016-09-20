
this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.GridLayout.Create(this)
	layout.ColumnCount = 2

        gb = Gwen.GroupBox.Create(layout)
		gb.Size = Gwen.Size.Create(200, 100)
        gb.Text = "Group Box"

        gb = Gwen.GroupBox.Create(layout)
		gb.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		gb.VerticalAlignment = Gwen.VerticalAlignment.Top
        gb.Text = "With Label (autosized)"

			label = Gwen.Label.Create(gb)
			label.Dock = Gwen.Dock.Fill
			label.Text = "I'm a label"

        gb = Gwen.GroupBox.Create(layout)
		gb.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		gb.VerticalAlignment = Gwen.VerticalAlignment.Top
		gb.Text = "With Label (autosized)"

			label = Gwen.Label.Create(gb)
			label.Dock = Gwen.Dock.Fill
			label.Text = "I'm a label. I'm a really long label!"

        gb = Gwen.GroupBox.Create(layout)
		gb.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		gb.VerticalAlignment = Gwen.VerticalAlignment.Top
		gb.Text = "Two docked Labels (autosized)"

			gbl = Gwen.DockLayout.Create(gb)

				label1 = Gwen.Label.Create(gbl)
				label1.Text = "I'm a label"
				label1.Dock = Gwen.Dock.Top
				label2 = Gwen.Label.Create(gbl)
				label2.Text = "I'm a label. I'm a really long label!"
				label2.Dock = Gwen.Dock.Top

        gb = Gwen.GroupBox.Create(layout)
		gb.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		gb.VerticalAlignment = Gwen.VerticalAlignment.Top
		gb.Text = "Empty (autosized)"

        gb1 = Gwen.GroupBox.Create(layout)
		gb1.HorizontalAlignment = Gwen.HorizontalAlignment.Left
		gb1.VerticalAlignment = Gwen.VerticalAlignment.Top
		gb1.Padding = Gwen.Padding.Five
        gb1.Text = "Yo dawg,"

			gb1l = Gwen.DockLayout.Create(gb1)

				gb2 = Gwen.GroupBox.Create(gb1l)
				gb2.Text = "I herd"
				gb2.Dock = Gwen.Dock.Left
				gb2.Margin = Gwen.Margin.Three
				gb2.Padding = Gwen.Padding.Five
                
				gb3 = Gwen.GroupBox.Create(gb1l)
				gb3.Text = "You like"
				gb3.Dock = Gwen.Dock.Fill

					gb3l = Gwen.DockLayout.Create(gb3)

						gb4 = Gwen.GroupBox.Create(gb3l)
						gb4.Text = "Group Boxes,"
						gb4.Dock = Gwen.Dock.Top

						gb5 = Gwen.GroupBox.Create(gb3l)
						gb5.Text = "So I put Group"
						gb5.Dock = Gwen.Dock.Fill

							gb5l = Gwen.DockLayout.Create(gb5)

								gb6 = Gwen.GroupBox.Create(gb5l)
								gb6.Text = "Boxes in yo"
								gb6.Dock = Gwen.Dock.Left

									gb7 = Gwen.GroupBox.Create(gb5l)
									gb7.Text = "Boxes so you can"
									gb7.Dock = Gwen.Dock.Top

										gb7l = Gwen.DockLayout.Create(gb7)

											gb8 = Gwen.GroupBox.Create(gb7l)
											gb8.Text = "Group Box while"
											gb8.Dock = Gwen.Dock.Top
											gb8.Margin = Gwen.Margin.Five

											gb9 = Gwen.GroupBox.Create(gb7l)
											gb9.Text = "u Group Box"
											gb9.Dock = Gwen.Dock.Bottom
											gb9.Padding = Gwen.Padding.Five

AddItem("Non-Interactive", "GroupBox", this)
