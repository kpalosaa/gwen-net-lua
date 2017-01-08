
local function ZoomTest(s, e)
	crossSplitter.Zoom(curZoom)
	curZoom = curZoom + 1
	if curZoom == 4 then
		curZoom = 0
	end
end

local function UnZoomTest(s, e)
	crossSplitter.UnZoom()
end

local function CenterPanels(s, e)
	crossSplitter.CenterPanels()
	crossSplitter.UnZoom()
end

local function ToggleSplitters(s, e)
	if crossSplitter.SplittersVisible then
		crossSplitter.SplittersVisible = false
	else
		crossSplitter.SplittersVisible = true
	end
end

curZoom = 0

this = Gwen.DockLayout.Create(Gwen.Canvas)

    crossSplitter = Gwen.CrossSplitter.Create(this)
    crossSplitter.Dock = Gwen.Dock.Fill

        splitter = Gwen.VerticalSplitter.Create(crossSplitter)
        button1 = Gwen.Button.Create(splitter)
        button1.Text = "Vertical left"
        button2 = Gwen.Button.Create(splitter)
        button2.Text = "Vertical right"
        splitter.SetPanel(0, button1)
        splitter.SetPanel(1, button2)
        crossSplitter.SetPanel(0, splitter)

        splitter = Gwen.HorizontalSplitter.Create(crossSplitter)
        button1 = Gwen.Button.Create(splitter)
        button1.Text = "Horizontal up"
        button2 = Gwen.Button.Create(splitter)
        button2.Text = "Horizontal down"
        splitter.SetPanel(0, button1)
        splitter.SetPanel(1, button2)
        crossSplitter.SetPanel(1, splitter)

        splitter = Gwen.HorizontalSplitter.Create(crossSplitter)
        button1 = Gwen.Button.Create(splitter)
        button1.Text = "Horizontal up"
        button2 = Gwen.Button.Create(splitter)
        button2.Text = "Horizontal down"
        splitter.SetPanel(0, button1)
        splitter.SetPanel(1, button2)
        crossSplitter.SetPanel(2, splitter)

        splitter = Gwen.VerticalSplitter.Create(crossSplitter)
        button1 = Gwen.Button.Create(splitter)
		button1.Text = "Vertical left"
        button2 = Gwen.Button.Create(splitter)
        button2.Text = "Vertical right"
        splitter.SetPanel(0, button1)
        splitter.SetPanel(1, button2)
        crossSplitter.SetPanel(3, splitter)

		layout = Gwen.HorizontalLayout.Create(this)
		layout.Dock = Gwen.Dock.Bottom
		layout.Margin = Gwen.Margin.Create(0, 5, 0, 5)

            button = Gwen.Button.Create(layout)
            button.Text = "Zoom"
            button.Clicked.add(ZoomTest)

            button = Gwen.Button.Create(layout)
            button.Text = "UnZoom"
            button.Clicked.add(UnZoomTest)

            button = Gwen.Button.Create(layout)
            button.Text = "CenterPanels"
            button.Clicked.add(CenterPanels)

            button = Gwen.Button.Create(layout)
            button.Text = "Splitters"
            button.Clicked.add(ToggleSplitters)

AddItem("Layout", "Splitter", this)
