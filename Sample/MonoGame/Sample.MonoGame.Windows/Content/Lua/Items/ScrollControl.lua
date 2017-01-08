
this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.GridLayout.Create(this)
	layout.ColumnCount = 6

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Twice As Big"
		pTestButton.Size = Gwen.Size.Create(200, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Same Size"
		pTestButton.Size = Gwen.Size.Create(100, 100)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Wide"
		pTestButton.Size = Gwen.Size.Create(200, 50)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Tall"
		pTestButton.Size = Gwen.Size.Create(50, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.EnableScroll(false, true)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Vertical"
		pTestButton.Size = Gwen.Size.Create(200, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.EnableScroll(true, false)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Horizontal"
		pTestButton.Size = Gwen.Size.Create(200, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Twice As Big"
		pTestButton.Size = Gwen.Size.Create(200, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Same Size"
		pTestButton.Size = Gwen.Size.Create(100, 100)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Wide"
		pTestButton.Size = Gwen.Size.Create(200, 50)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Tall"
		pTestButton.Size = Gwen.Size.Create(50, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true
		ctrl.EnableScroll(false, true)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Vertical"
		pTestButton.Size = Gwen.Size.Create(200, 200)

		ctrl = Gwen.ScrollControl.Create(layout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.Size = Gwen.Size.Create(100, 100)
		ctrl.AutoHideBars = true
		ctrl.EnableScroll(true, false)

		pTestButton = Gwen.Button.Create(ctrl)
		pTestButton.Text = "Horinzontal"
		pTestButton.Size = Gwen.Size.Create(200, 200)

AddItem("Containers", "ScrollControl", this)
