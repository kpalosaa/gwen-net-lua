
local function OnChecked(s, e)
	print("CheckBox: Checked")
end

local function OnCheckChanged(s, e)
	print("CheckBox: CheckChanged")
end

local function OnUnchecked(s, e)
	print("CheckBox: UnChecked")
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)

	check = Gwen.CheckBox.Create(layout)
	check.Margin = Gwen.Margin.Three
    check.Checked.add(OnChecked)
    check.UnChecked.add(OnUnchecked)
    check.CheckChanged.add(OnCheckChanged)

	labeled = Gwen.LabeledCheckBox.Create(layout)
	labeled.Margin = Gwen.Margin.Three
	labeled.Text = "Labeled CheckBox"
    labeled.Checked.add(OnChecked)
    labeled.UnChecked.add(OnUnchecked)
    labeled.CheckChanged.add(OnCheckChanged)

    check = Gwen.CheckBox.Create(layout)
	check.Margin = Gwen.Margin.Three
	check.IsDisabled = true

AddItem("Standard", "CheckBox", this)
