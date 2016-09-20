
this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.DockLayout.Create(this)

		flowLayout = Gwen.FlowLayout.Create(layout)
		flowLayout.Width = 200
		flowLayout.Padding = Gwen.Padding.Five
		flowLayout.Dock = Gwen.Dock.Fill
		flowLayout.DrawDebugOutlines = true

			for n = 1, 10, 1 do
				button = Gwen.Button.Create(flowLayout)
				button.VerticalAlignment = Gwen.VerticalAlignment.Top
				button.HorizontalAlignment = Gwen.HorizontalAlignment.Left
				button.Margin = Gwen.Margin.Five
				button.Padding = Gwen.Padding.Five
				button.ShouldDrawBackground = false
				button.Text = string.format("Button %d", n);
				button.ImageName = "test16.png"
				button.ImageAlign = Gwen.ImageAlign.Above
			end

		flowLayoutWidth = Gwen.HorizontalSlider.Create(layout)
		flowLayoutWidth.Margin = Gwen.Margin.Five
		flowLayoutWidth.Width = 500
		flowLayoutWidth.Dock = Gwen.Dock.Top
		flowLayoutWidth.Min = 50
		flowLayoutWidth.Max = 500
		flowLayoutWidth.Value = flowLayout.Width
		flowLayoutWidth.ValueChanged.add(function (s, e) flowLayout.Width = flowLayoutWidth.Value end)

AddItem("Layout", "FlowLayout", this)
