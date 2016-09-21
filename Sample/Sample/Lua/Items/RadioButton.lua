
local function OnChange(s, e)
	print(string.format("RadioButton: SelectionChanged: %s", s.Selected.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)

		group = Gwen.GroupBox.Create(layout)
		group.Margin = Gwen.Margin.Five
		group.Text = "Sample radio group"
		
			rbg = Gwen.RadioButtonGroup.Create(group)
			rbg.AddOption("Option 1")
			rbg.AddOption("Option 2")
			rbg.AddOption("Option 3")
			rbg.AddOption("\u{0627}\u{0644}\u{0622}\u{0646} \u{0644}\u{062D}\u{0636}\u{0648}\u{0631}")
			rbg.SelectionChanged.add(OnChange)

AddItem("Standard", "RadioButton", this)
