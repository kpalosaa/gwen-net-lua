
local function OnSelection(s, e)
	print(string.format("CollapsibleList: Selected: %s", s.GetSelectedButton().Text))
end

local function OnCollapsed(s, e)
	print(string.format("CollapsibleList: CategoryCollapsed: %s", s.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

    control = Gwen.CollapsibleList.Create(this)
	control.Dock = Gwen.Dock.Fill
	control.HorizontalAlignment = Gwen.HorizontalAlignment.Left
    control.ItemSelected.add(OnSelection)
    control.CategoryCollapsed.add(OnCollapsed)

		cat = control.Add("Category One")
        cat.Add("Hello")
        cat.Add("Two")
        cat.Add("Three")
        cat.Add("Four")

        cat = control.Add("Shopping")
        cat.Add("Special")
        cat.Add("Two Noses")
        cat.Add("Orange ears")
        cat.Add("Beer")
        cat.Add("Three Eyes")
        cat.Add("Special")
        cat.Add("Two Noses")
        cat.Add("Orange ears")
        cat.Add("Beer")
        cat.Add("Three Eyes")
        cat.Add("Special")
        cat.Add("Two Noses")
        cat.Add("Orange ears")
        cat.Add("Beer")
        cat.Add("Three Eyes")

        cat = control.Add("Category One")
        cat.Add("Hello")
        cat.Add("Two")
        cat.Add("Three")
        cat.Add("Four")

AddItem("Non-standard", "CollapsibleList", this)
