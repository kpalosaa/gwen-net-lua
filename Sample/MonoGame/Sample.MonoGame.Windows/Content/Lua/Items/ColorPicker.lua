
local function ColorChanged(s, e)
	local c = s.SelectedColor
	print(string.format("Color changed: RGB: 0x%02x%02x%02x", c.R, c.G, c.B))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	hsvPicker = Gwen.HSVColorPicker.Create(this)
	hsvPicker.Dock = Gwen.Dock.Fill
	hsvPicker.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	hsvPicker.VerticalAlignment = Gwen.VerticalAlignment.Top
	hsvPicker.ColorChanged.add(ColorChanged)

	window = Gwen.Window.Create(this)
	window.Size = Gwen.Size.Create(300, 200)
	window.Collapse()

		layout = Gwen.DockLayout.Create(window)

			hsvPicker = Gwen.HSVColorPicker.Create(layout)
			hsvPicker.Margin = Gwen.Margin.Two
			hsvPicker.Dock = Gwen.Dock.Fill
			hsvPicker.ColorChanged.add(ColorChanged)

	openWindow = Gwen.Button.Create(this)
	openWindow.Dock = Gwen.Dock.Bottom
	openWindow.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	openWindow.Text = "Open Window"
	openWindow.Clicked.add(function (s, e) window.Show() end)

AddItem("Non-standard", "ColorPicker", this)
