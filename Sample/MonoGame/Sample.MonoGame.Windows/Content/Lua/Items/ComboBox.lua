
local function OnComboSelect(s, e)
	print(string.format("ComboBox: OnComboSelect: %s", e.SelectedItem.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)

		combo = Gwen.ComboBox.Create(layout)
		combo.Margin = Gwen.Margin.Five
		combo.Width = 200
		combo.AddItem("Option One", "one")
		combo.AddItem("Number Two", "two")
		combo.AddItem("Door Three", "three")
		combo.AddItem("Four Legs", "four")
		combo.AddItem("Five Birds", "five")
		combo.ItemSelected.add(OnComboSelect)

		-- Empty
		combo = Gwen.ComboBox.Create(layout)
		combo.Margin = Gwen.Margin.Five
		combo.Width = 200

		-- Lots of things
		combo = Gwen.ComboBox.Create(layout)
		combo.Margin = Gwen.Margin.Five
		combo.Width = 200
		for i = 1, 500, 1 do
			combo.AddItem(string.format("Option %d", i))
		end
		combo.ItemSelected.add(OnComboSelect)

		-- Editable
		combo = Gwen.EditableComboBox.Create(layout);
		combo.Margin = Gwen.Margin.Five
		combo.Width = 200
		combo.AddItem("Option One", "one")
		combo.AddItem("Number Two", "two")
		combo.AddItem("Door Three", "three")
		combo.AddItem("Four Legs", "four")
		combo.AddItem("Five Birds", "five")
		combo.ItemSelected.add(function (s, e) print(string.format("ComboBox: OnComboSelect: %s", e.SelectedItem.Text)) end)
		combo.TextChanged.add(function (s, e) print(string.format("ComboBox: OnTextChanged: %s", s.Text)) end)
		combo.SubmitPressed.add(function (s, e) print(string.format("ComboBox: OnSubmitPressed: %s", s.Text)) end)

		hlayout = Gwen.HorizontalLayout.Create(layout)

			-- In-Code Item Change
			combo = Gwen.ComboBox.Create(hlayout)
			combo.Margin = Gwen.Margin.Five
			combo.Width = 200

			triangle = combo.AddItem("Triangle")
			combo.AddItem("Red", "color")
			combo.AddItem("Apple", "fruit")
			combo.AddItem("Blue", "color")
			combo.AddItem("Green", "color", 12)
			combo.ItemSelected.add(OnComboSelect)

			-- Select by Menu Item
			triangleButton = Gwen.Button.Create(hlayout)
			triangleButton.Text = "Triangle"
			triangleButton.Width = 100
			triangleButton.Clicked.add(function (s, e) combo.SelectedItem = triangle end)

			-- Select by Text
			testBtn = Gwen.Button.Create(hlayout)
			testBtn.Text = "Red"
			testBtn.Width = 100
			testBtn.Clicked.add(function (s, e) combo.SelectByText("Red") end)

			-- Select by Name
			testBtn = Gwen.Button.Create(hlayout)
			testBtn.Text = "Apple"
			testBtn.Width = 100
			testBtn.Clicked.add(function (s, e) combo.SelectByName("fruit") end)

			-- Select by UserData
			testBtn = Gwen.Button.Create(hlayout)
			testBtn.Text = "Green"
			testBtn.Width = 100
			testBtn.Clicked.add(function (s, e) combo.SelectByUserData(12) end)

AddItem("Standard", "ComboBox", this)
