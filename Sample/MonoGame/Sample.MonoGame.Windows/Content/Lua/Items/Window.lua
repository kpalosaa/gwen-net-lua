
local function OpenWindow(s, e)

    local window = Gwen.Window.Create(this)
    window.Title = string.format("Window (%d)", windowCount)
	window.Width = math.random(200, 400)
	window.Height = math.random(200, 400)
	window.Left = math.random(0, 400)
	window.Top = math.random(0, 400)
	window.Padding = Gwen.Padding.Create(6, 3, 6, 6)

		local rbg = Gwen.RadioButtonGroup.Create(window)
		rbg.Dock = Gwen.Dock.Top
		rbg.AddOption("Resize disabled", "None", Gwen.Resizing.None)
		rbg.AddOption("Resize width", "Width", Gwen.Resizing.Width)
		rbg.AddOption("Resize height", "Height", Gwen.Resizing.Height)
		rbg.AddOption("Resize both", "Both", Gwen.Resizing.Both)
		rbg.SelectionChanged.add(function (s, e) window.Resizing = s.Selected.UserData end)
		rbg.SetSelectionByName("Both")

		local dragging = Gwen.LabeledCheckBox.Create(window)
		dragging.Dock = Gwen.Dock.Top
		dragging.Text = "Dragging"
		dragging.IsChecked = true
		dragging.CheckChanged.add(function (s, e) window.IsDraggingEnabled = dragging.IsChecked end)

	windowCount = windowCount + 1

end

local function OpenWindowWithMenuAndStatusBar(s, e)

	local window = Gwen.Window.Create(this)
	window.Title = string.format("Window (%d)", windowCount)
	window.Width = math.random(200, 400)
	window.Height = math.random(200, 400)
	window.Left = math.random(0, 400)
	window.Top = math.random(0, 400)
	window.Padding = Gwen.Padding.Create(1, 0, 1, 1)

	layout = Gwen.DockLayout.Create(window)

		menuStrip = Gwen.MenuStrip.Create(layout)
		menuStrip.Dock = Gwen.Dock.Top

			-- File
			root = menuStrip.AddItem("File")
			root.AddItem("Load", "test16.png", "Ctrl+L")
			root.AddItem("Save", nil, "Ctrl+S")
			root.AddItem("Save As..", nil, "Ctrl+A")
			root.AddItem("Quit", nil, "Alt+F4").Selected.add(function (s, e) window.Close() end)

			-- Resizing
			root = menuStrip.AddItem("Resizing")
			root.AddItem("Disabled").Selected.add(function (s, e) window.Resizing = Gwen.Resizing.None end)
			root.AddItem("Width").Selected.add(function (s, e) window.Resizing = Gwen.Resizing.Width end)
			root.AddItem("Height").Selected.add(function (s, e) window.Resizing = Gwen.Resizing.Height end)
			root.AddItem("Both").Selected.add(function (s, e) window.Resizing = Gwen.Resizing.Both end)

		statusBar = Gwen.StatusBar.Create(layout)
		statusBar.Dock = Gwen.Dock.Bottom
		statusBar.Text = "Status bar"

			br = Gwen.Button.Create(statusBar)
			br.Text = "Right button"
			statusBar.AddControl(br, true)

	windowCount = windowCount + 1

end

local function OpenWindowAutoSizing(s, e)

	local window = Gwen.Window.Create(this)
	window.Title = string.format("Window (%d)", windowCount)
	window.Left = math.random(0, 400)
	window.Top = math.random(0, 400)
	window.Padding = Gwen.Padding.Create(6, 3, 6, 6)
	window.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	window.VerticalAlignment = Gwen.VerticalAlignment.Top
	window.Resizing = Gwen.Resizing.None

		layout = Gwen.VerticalLayout.Create(window)

			grb = Gwen.GroupBox.Create(layout)
			grb.Text = "Auto size"

			layout = Gwen.VerticalLayout.Create(grb)

				local label = Gwen.Label.Create(layout)
				label.Margin = Gwen.Margin.Six
				label.Text = "Label text"

				button = Gwen.Button.Create(layout)
				button.Margin = Gwen.Margin.Six
				button.Text = "Click Me"
				button.Width = 200

				label = Gwen.Label.Create(layout)
				label.Margin = Gwen.Margin.Six
				label.Text = "Hide / Show Label"

				button.Clicked.add(function (s, w) if label.IsCollapsed then label.IsCollapsed = false else label.IsCollapsed = true end end)

	windowCount = windowCount + 1

end

local function OpenWindowModal(s, e)

	local window = Gwen.Window.Create(this)
	window.Title = string.format("Window (%d)", windowCount)
	window.Left = math.random(0, 400)
	window.Top = math.random(0, 400)
	window.Padding = Gwen.Padding.Create(6, 3, 6, 6)
	window.HorizontalAlignment = Gwen.HorizontalAlignment.Left
	window.VerticalAlignment = Gwen.VerticalAlignment.Top
	window.Resizing = Gwen.Resizing.None
	window.Modal = true

		layout = Gwen.VerticalLayout.Create(window)

			grb = Gwen.GroupBox.Create(layout)
			grb.Text = "Auto size"
	
				layout = Gwen.VerticalLayout.Create(grb)

					label = Gwen.Label.Create(layout)
					label.Margin = Gwen.Margin.Six
					label.Text = "Label text"

					button = Gwen.Button.Create(layout)
					button.Margin = Gwen.Margin.Six
					button.Text = "Button"
					button.Width = 200

	windowCount = windowCount + 1

end

local function OnDismissed(s, e)
	local result
	if e.Result == Gwen.MessageBoxResult.Ok then
		result = "Ok"
	elseif e.Result == Gwen.MessageBoxResult.Retry then
		result = "Retry"
	elseif e.Result == Gwen.MessageBoxResult.Ignore then
		result = "Ignore"
	elseif e.Result == Gwen.MessageBoxResult.Abort then
		result = "Abort"
	end
	print(string.format("Message box result: %s", result))
end

local function OpenMsgbox(s, e)

    local window = Gwen.MessageBox.Create(Gwen.Canvas, "Message box test text.")
	window.Dismissed.add(OnDismissed)

end

local function OpenLongMsgbox(s, e)

	local window = Gwen.MessageBox.Create(Gwen.Canvas, "In olden times when wishing still helped one, there lived a king whose daughters were all beautiful, but the youngest was so beautiful that the sun itself, which has seen so much, was astonished whenever it shone in her face. Close by the king's castle lay a great dark forest, and under an old lime-tree in the forest was a well, and when the day was very warm, the king's child went out into the forest and sat down by the side of the cool fountain, and when she was bored she took a golden ball, and threw it up on high and caught it, and this ball was her favorite plaything.", "Long Text", Gwen.MessageBoxButtons.AbortRetryIgnore)
	window.Dismissed.add(OnDismissed)

end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)
	layout.HorizontalAlignment = Gwen.HorizontalAlignment.Left

    button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a Window"
    button.Clicked.add(OpenWindow)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a Window (with menu)"
	button.Clicked.add(OpenWindowWithMenuAndStatusBar)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a Window (auto size)"
	button.Clicked.add(OpenWindowAutoSizing)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a Window (modal)"
	button.Clicked.add(OpenWindowModal)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a MessageBox"
    button.Clicked.add(OpenMsgbox)

	button = Gwen.Button.Create(layout)
	button.Margin = Gwen.Margin.Five
	button.Text = "Open a Long MessageBox"
	button.Clicked.add(OpenLongMsgbox)

	windowCount = 0

AddItem("Containers", "Window", this)
