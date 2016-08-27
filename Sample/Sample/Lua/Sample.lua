
function AddItem(category, name, item)

	cat = list.FindChildByName(category)
	if cat == nil then
		cat = list.Add(category)
	end

	button = cat.Add(name)
	button.UserData = item
	button.Clicked.add(OnItemClicked)

	item.Parent = itemArea
	item.IsCollapsed = true

end

function OnItemClicked(sender, e)

	if lastItem != nil then
		lastItem.IsCollapsed = true
	end

	lastItem = sender.UserData
	lastItem.IsCollapsed = false

end

function OnDebugOutlinesChanged(sender, e)

	itemArea.DrawDebugOutlines = debugOutlines.IsChecked

	for _, control in pairs(Gwen.Canvas.Children) do
		if control.Type == "Window" then
			control.Content.DrawDebugOutlines = debugOutlines.IsChecked
		end
	end

end

dock = Gwen.DockControl.Create(Gwen.Canvas)
dock.Dock = Gwen.Dock.Fill

list = Gwen.CollapsibleList.Create(Gwen.Canvas)

dock.LeftDock.Add("Unit tests", list)
dock.LeftDock.Width = 150

textOutput = Gwen.ListBox.Create(Gwen.Canvas)
textOutput.AlternateColor = false

dock.BottomDock.Add("Output", textOutput)
dock.BottomDock.Height = 200

itemArea = Gwen.DockLayout.Create(dock)
itemArea.Dock = Gwen.Dock.Fill

statusBar = Gwen.StatusBar.Create(Gwen.Canvas)
statusBar.Dock = Gwen.Dock.Bottom

debugOutlines = Gwen.LabeledCheckBox.Create(statusBar)
debugOutlines.Text = "Debug outlines"
debugOutlines.CheckChanged.add(OnDebugOutlinesChanged)

incScale = Gwen.Button.Create(statusBar)
incScale.HorizontalAlignment = Gwen.HorizontalAlignment.Left
incScale.VerticalAlignment = Gwen.VerticalAlignment.Stretch
incScale.Width = 30
incScale.Margin = Gwen.Margin.Create(0, 0, 8, 0)
incScale.TextPadding = Gwen.Padding.Create(5, 0, 5, 0)
incScale.Text = "+"
incScale.Clicked.add(function(sender, e) uiScale.Value = math.min(uiScale.Value + 0.25, 3) end)

uiScale = Gwen.TextBoxNumeric.Create(statusBar)
uiScale.VerticalAlignment = Gwen.VerticalAlignment.Stretch
uiScale.Width = 70
uiScale.Value = Gwen.Canvas.Scale
uiScale.TextChanged.add(function(sender, e) Gwen.Canvas.Scale = uiScale.Value end)

decScale = Gwen.Button.Create(statusBar)
decScale.HorizontalAlignment = Gwen.HorizontalAlignment.Left
decScale.VerticalAlignment = Gwen.VerticalAlignment.Stretch
decScale.Width = 30
decScale.Margin = Gwen.Margin.Create(4, 0, 0, 0)
decScale.TextPadding = Gwen.Padding.Create(5, 0, 5, 0)
decScale.Text = "-"
decScale.Clicked.add(function(sender, e) uiScale.Value = math.max(uiScale.Value - 0.25, 1) end)

uiScaleLabel = Gwen.Label.Create(statusBar)
uiScaleLabel.VerticalAlignment = Gwen.VerticalAlignment.Stretch
uiScaleLabel.Alignment = Gwen.Alignment.Left and Gwen.Alignment.CenterV
uiScaleLabel.Text = "Scale:"

lastItem = nil
