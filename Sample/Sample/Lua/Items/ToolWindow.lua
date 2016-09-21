
local function Close(s, e)
	window = s.UserData
	window.Close()
	window.DelayedDelete()
	window.Parent = nil
end

local function OpenToolBar(s, e)

	local window = Gwen.ToolWindow.Create(this)
	window.Padding = Gwen.Padding.Five
	window.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	window.VerticalAlignment = Gwen.VerticalAlignment.Top
	window.StartPosition = Gwen.StartPosition.CenterCanvas

		layout = Gwen.HorizontalLayout.Create(window)

			for i = 1, 5, 1 do
				button = Gwen.Button.Create(layout)
				button.Size = Gwen.Size.Create(36, 36)
				button.UserData = window
				button.Clicked.add(Close)
			end

end

local function OpenToolWindow(s, e)

	local window = Gwen.ToolWindow.Create(this)
	window.Padding = Gwen.Padding.Five
	window.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	window.VerticalAlignment = Gwen.VerticalAlignment.Top
	window.StartPosition = Gwen.StartPosition.CenterCanvas
	window.Vertical = true

	layout = Gwen.GridLayout.Create(window)
	layout.ColumnCount = 2

	button = Gwen.Button.Create(layout)
	button.Size = Gwen.Size.Create(100, 40)
	button.UserData = window
	button.Clicked.add(Close)

	button = Gwen.Button.Create(layout)
	button.Size = Gwen.Size.Create(100, 40)
	button.UserData = window
	button.Clicked.add(Close)

	button = Gwen.Button.Create(layout)
	button.Size = Gwen.Size.Create(100, 40)
	button.UserData = window
	button.Clicked.add(Close)

	button = Gwen.Button.Create(layout)
	button.Size = Gwen.Size.Create(100, 40)
	button.UserData = window
	button.Clicked.add(Close)

end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)
	layout.HorizontalAlignment = Gwen.HorizontalAlignment.Left

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a ToolBar"
	button.Clicked.add(OpenToolBar)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a tool window"
	button.Clicked.add(OpenToolWindow)

AddItem("Containers", "ToolWindow", this)
