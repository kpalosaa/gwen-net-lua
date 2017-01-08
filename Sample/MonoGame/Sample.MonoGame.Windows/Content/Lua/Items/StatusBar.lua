
this = Gwen.DockLayout.Create(Gwen.Canvas)

	sb = Gwen.StatusBar.Create(this)

		left = Gwen.Label.Create(sb)
		left.Text = "Label added to left"
		sb.AddControl(left, false)

		right = Gwen.Label.Create(sb)
		right.Text = "Label added to right"
		sb.AddControl(right, true)

		bl = Gwen.Button.Create(sb)
		bl.Text = "Left button"
		sb.AddControl(bl, false)

		br = Gwen.Button.Create(sb)
		br.Text = "Right button"
		sb.AddControl(br, true)

AddItem("Non-Interactive", "StatusBar", this)
