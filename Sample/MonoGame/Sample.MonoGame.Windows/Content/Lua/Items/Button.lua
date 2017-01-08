
this = Gwen.DockLayout.Create(Gwen.Canvas)

	hlayout = Gwen.HorizontalLayout.Create(this)

		vlayout = Gwen.VerticalLayout.Create(hlayout)
		vlayout.Width = 300

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Text = "Button"

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Image button (default)"
			button.ImageName = "test16.png"

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Image button (above)"
			button.ImageName = "test16.png"
			button.ImageAlign = Gwen.ImageAlign.Above

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Alignment = Gwen.Alignment.Left .. Gwen.Alignment.CenterV
			button.Text = "Image button (left)"
			button.ImageName = "test16.png"

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Alignment = Gwen.Alignment.Right .. Gwen.Alignment.CenterV
			button.Text = "Image button (right)"
			button.ImageName = "test16.png"

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Image button (image left)"
			button.ImageName = "test16.png"
			button.ImageAlign = Gwen.ImageAlign.Left .. Gwen.ImageAlign.CenterV

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Image button (image right)"
			button.ImageName = "test16.png"
			button.ImageAlign = Gwen.ImageAlign.Right .. Gwen.ImageAlign.CenterV

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Image button (image fill)"
			button.ImageName = "test16.png"
			button.ImageAlign = Gwen.ImageAlign.Fill

			hlayout2 = Gwen.HorizontalLayout.Create(vlayout)

				button = Gwen.Button.Create(hlayout2)
				button.HorizontalAlignment = Gwen.HorizontalAlignment.Left
				button.VerticalAlignment = Gwen.VerticalAlignment.Center
				button.Padding = Gwen.Padding.Three
				button.Margin = Gwen.Margin.Five
				button.ImageName = "test16.png"
				button.ImageSize = Gwen.Size.Create(32, 32)

				button = Gwen.Button.Create(hlayout2)
				button.HorizontalAlignment = Gwen.HorizontalAlignment.Left
				button.VerticalAlignment = Gwen.VerticalAlignment.Center
				button.Padding = Gwen.Padding.Three
				button.Margin = Gwen.Margin.Five
				button.ImageName = "test16.png"

				button = Gwen.Button.Create(hlayout2)
				button.HorizontalAlignment = Gwen.HorizontalAlignment.Left
				button.VerticalAlignment = Gwen.VerticalAlignment.Center
				button.Padding = Gwen.Padding.Three
				button.Margin = Gwen.Margin.Five
				button.ImageName = "test16.png"
				button.ImageTextureRect = Gwen.Rectangle.Create(4, 4, 8, 8)

				button = Gwen.Button.Create(hlayout2)
				button.HorizontalAlignment = Gwen.HorizontalAlignment.Left
				button.VerticalAlignment = Gwen.VerticalAlignment.Center
				button.Padding = Gwen.Padding.Three
				button.Margin = Gwen.Margin.Five
				button.ImageName = "test16.png"
				button.ImageColor = Gwen.Color.Create("DarkGrey")

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Create(20, 20, 20, 20)
			button.Text = "Toggle me"
			button.IsToggle = true
			button.Toggled.add(function(sender, e) print("Button: Toggled") end)
			button.ToggledOn.add(function(sender, e) print("Button: ToggledOn") end)
			button.ToggledOff.add(function(sender, e) print("Button: ToggledOff") end)

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Disabled"
			button.IsDisabled = true

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "With Tooltip"
			button.ToolTipText = "This is tooltip"

			button = Gwen.Button.Create(vlayout)
			button.Margin = Gwen.Margin.Five
			button.Padding = Gwen.Padding.Three
			button.Text = "Autosized"
			button.HorizontalAlignment = Gwen.HorizontalAlignment.Left

		button = Gwen.Button.Create(hlayout)
		button.Margin = Gwen.Margin.Five
		button.Padding = Gwen.Padding.Three
		button.Text = "Event tester"
		button.Size = Gwen.Size.Create(300, 200);
		button.Pressed.add(function(sender, e) print("Button: Pressed") end)
		button.Clicked.add(function(sender, e) print("Button: Clicked") end)
		button.Released.add(function(sender, e) print("Button: Released") end)

AddItem("Standard", "Button", this)
