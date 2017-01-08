
this = Gwen.DockLayout.Create(Gwen.Canvas)

	-- Normal
	img = Gwen.ImagePanel.Create(this)
	img.Margin = Gwen.Margin.Five
	img.Dock = Gwen.Dock.Top
	img.Size = Gwen.Size.Create(100, 100)
	img.ImageName = "gwen.png"

	-- Missing
	img = Gwen.ImagePanel.Create(this)
	img.Margin = Gwen.Margin.Five
	img.Dock = Gwen.Dock.Top
	img.Size = Gwen.Size.Create(100, 100)
	img.ImageName = "missingimage.png"

	-- Clicked
	img = Gwen.ImagePanel.Create(this)
	img.Margin = Gwen.Margin.Five
	img.Dock = Gwen.Dock.Top
	img.Size = Gwen.Size.Create(100, 100)
	img.ImageName = "gwen.png"
	img.Clicked.add(function (s, e) print("Image: Clicked") end)

AddItem("Non-Interactive", "ImagePanel", this)
