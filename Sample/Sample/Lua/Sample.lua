
dock = Gwen.DockControl.Create(Gwen.Canvas)
dock.Dock = Gwen.Dock.Fill

list = Gwen.CollapsibleList.Create(Gwen.Canvas)

dock.LeftDock.Add("Unit tests", list)
dock.LeftDock.Width = 150

textOutput = Gwen.ListBox.Create(Gwen.Canvas)
textOutput.AlternateColor = false

dock.BottomDock.Add("Output", textOutput)
dock.BottomDock.Height = 200





function AddItem(category, name, item)

	cat = list.FindChildByName(category)
	if cat == nil then
		cat = Gwen.CollapsibleCategory.Create(list)
	end

	button = cat.Add(name)
	button.UserData = item

	item.IsCollapsed = true

end
