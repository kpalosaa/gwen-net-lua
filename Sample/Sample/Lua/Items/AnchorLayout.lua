
this = Gwen.DockLayout.Create(Gwen.Canvas)

	font = Gwen.Font.Create("Arial", 10)

	anchorLayout = Gwen.AnchorLayout.Create(this)
	anchorLayout.Size = Gwen.Size.Create(445, 165)
	anchorLayout.Padding = Gwen.Padding.Five
	anchorLayout.AnchorBounds = Gwen.Rectangle.Create(0, 0, 445, 165)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Left Top"
	button.AnchorBounds = Gwen.Rectangle.Create(10, 10, 100, 20)
	button.Anchor = Gwen.Anchor.LeftTop

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Center Top"
	button.AnchorBounds = Gwen.Rectangle.Create(150, 10, 100, 20)
	button.Anchor = Gwen.Anchor.Create(50, 0, 50, 0)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Right Top"
	button.AnchorBounds = Gwen.Rectangle.Create(290, 10, 100, 20)
	button.Anchor = Gwen.Anchor.RightTop

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Left Center"
	button.AnchorBounds = Gwen.Rectangle.Create(10, 50, 100, 20)
	button.Anchor = Gwen.Anchor.Create(0, 50, 0, 50)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Center"
	button.AnchorBounds = Gwen.Rectangle.Create(150, 50, 100, 20)
	button.Anchor = Gwen.Anchor.Create(50, 50, 50, 50)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Right Center"
	button.AnchorBounds = Gwen.Rectangle.Create(290, 50, 100, 20)
	button.Anchor = Gwen.Anchor.Create(100, 50, 100, 50)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Left Bottom"
	button.AnchorBounds = Gwen.Rectangle.Create(10, 90, 100, 20)
	button.Anchor = Gwen.Anchor.LeftBottom

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Center Bottom"
	button.AnchorBounds = Gwen.Rectangle.Create(150, 90, 100, 20)
	button.Anchor = Gwen.Anchor.Create(50, 100, 50, 100)

	button = Gwen.Button.Create(anchorLayout)
	button.Font = font
	button.Text = "Right Bottom"
	button.AnchorBounds = Gwen.Rectangle.Create(290, 90, 100, 20)
	button.Anchor = Gwen.Anchor.RightBottom

	horz = Gwen.HorizontalSlider.Create(anchorLayout)
	horz.AnchorBounds = Gwen.Rectangle.Create(10, 125, 380, 25)
	horz.Anchor = Gwen.Anchor.Create(0, 100, 100, 100)

	vert = Gwen.VerticalSlider.Create(anchorLayout)
	vert.AnchorBounds = Gwen.Rectangle.Create(405, 10, 25, 100)
	vert.Anchor = Gwen.Anchor.Create(100, 0, 100, 100)

	width = Gwen.HorizontalSlider.Create(this)
	width.Min = 445
	width.Max = 800
	width.Height = 25
	width.Dock = Gwen.Dock.Bottom
	width.Padding = Gwen.Padding.Five
	width.ValueChanged.add(function (s, e) anchorLayout.Width = s.Value end)

	height = Gwen.VerticalSlider.Create(this)
	height.Min = 165
	height.Max = 400
	height.Width = 25
	height.Dock = Gwen.Dock.Right
	height.Padding = Gwen.Padding.Five
	height.ValueChanged.add(function (s, e) anchorLayout.Height = s.Value end)

AddItem("Layout", "AnchorLayout", this)
