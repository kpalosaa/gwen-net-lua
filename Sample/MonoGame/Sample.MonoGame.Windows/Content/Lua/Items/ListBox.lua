
local function RowSelected(sender, e)

	print(string.format("ListBox: RowSelected: %s", e.SelectedItem.Text))

end

local function RowUnSelected(sender, e)

	print(string.format("ListBox: RowUnselected: %s", e.SelectedItem.Text))

end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	hlayout = Gwen.HorizontalLayout.Create(this)
	hlayout.Margin = Gwen.Margin.Three
	hlayout.Dock = Gwen.Dock.Top

		ctrl = Gwen.ListBox.Create(hlayout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.AutoSizeToContent = true
		ctrl.AllowMultiSelect = true
		ctrl.AddRow("First")
		ctrl.AddRow("Blue")
		ctrl.AddRow("Yellow")
		ctrl.AddRow("Orange")
		ctrl.AddRow("Brown")
		ctrl.AddRow("Black")
		ctrl.AddRow("Green")
		ctrl.AddRow("Dog")
		ctrl.AddRow("Cat Blue")
		ctrl.AddRow("Shoes")
		ctrl.AddRow("Shirts")
		ctrl.AddRow("Chair")
		ctrl.AddRow("I'm autosized")
		ctrl.AddRow("Last")
		ctrl.SelectRowsByRegex("Bl.e|Dog")
		ctrl.RowSelected.add(RowSelected)
		ctrl.RowUnselected.add(RowUnSelected)

		ctrl = Gwen.Table.Create(hlayout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.AddRow("First")
		ctrl.AddRow("Blue")
		ctrl.AddRow("Yellow")
		ctrl.AddRow("Orange")
		ctrl.AddRow("Brown")
		ctrl.AddRow("Black")
		ctrl.AddRow("Green")
		ctrl.AddRow("Dog")
		ctrl.AddRow("Cat Blue")
		ctrl.AddRow("Shoes")
		ctrl.AddRow("Shirts")
		ctrl.AddRow("Chair")
		ctrl.AddRow("I'm autosized")
		ctrl.AddRow("Last")
		ctrl.SizeColumnsToContent();

		ctrl = Gwen.ListBox.Create(hlayout)
		ctrl.Margin = Gwen.Margin.Three
		ctrl.AutoSizeToContent = true
		ctrl.ColumnCount = 3
		ctrl.RowSelected.add(RowSelected)
		ctrl.RowUnselected.add(RowUnSelected)
			row = ctrl.AddRow("Baked Beans")
			row.SetCellText(1, "Heinz")
			row.SetCellText(2, "£3.50")
			row = ctrl.AddRow("Bananas")
			row.SetCellText(1, "Trees")
			row.SetCellText(2, "£1.27")
			row = ctrl.AddRow("Chicken")
			row.SetCellText(1, "\u{5355}\u{5143}\u{6D4B}\u{8BD5}")
			row.SetCellText(2, "£8.95")

		vlayout = Gwen.VerticalLayout.Create(hlayout)

			ctrl = Gwen.ListBox.Create(vlayout)
			ctrl.Margin = Gwen.Margin.Three
			ctrl.Height = 90
			ctrl.HorizontalAlignment = Gwen.HorizontalAlignment.Left
			ctrl.AutoSizeColumnsToContent = false
			ctrl.ColumnCount = 3
			ctrl.SetColumnWidth(0, 120)
			ctrl.SetColumnWidth(1, 150)
			ctrl.SetColumnWidth(2, 150)
				row = ctrl.AddRow("Row 1")
				row.SetCellText(1, "R1 cell 1")
				row.SetCellText(2, "Row 1 cell 2")
			ctrl.AddRow("Row 2, slightly bigger")
			ctrl[1].SetCellText(1, "Center cell")
			ctrl.AddRow("Row 3, medium")
			ctrl[2].SetCellText(2, "Last cell")

			ctrl = Gwen.ListBox.Create(vlayout)
			ctrl.Margin = Gwen.Margin.Three
			ctrl.HorizontalAlignment = Gwen.HorizontalAlignment.Left
			ctrl.AutoSizeToContent = true
			ctrl.ColumnCount = 3
				row = ctrl.AddRow("Row 1")
				row.SetCellText(1, "R1 cell 1")
				row.SetCellText(2, "Row 1 cell 2")
			ctrl.AddRow("Row 2, slightly bigger")
			ctrl[1].SetCellText(1, "Center cell")
			ctrl.AddRow("Row 3, medium")
			ctrl[2].SetCellText(2, "Last cell")

			ctrl1 = Gwen.ListBox.Create(vlayout)
			ctrl1.Margin = Gwen.Margin.Three
			ctrl1.HorizontalAlignment = Gwen.HorizontalAlignment.Left
			ctrl1.AutoSizeToContent = true
			ctrl1.Height = 110
			items = 
			{
				{ Name = "Baked Beans", Type = "Heinz", Price = 3.50 },
				{ Name = "Bananas", Type = "Trees", Price = 1.27 }
			}
			ctrl1.DisplayMembers = { "Name", "Type", "Price" }
			ctrl1.ItemsSource = items
			hlayout2 = Gwen.HorizontalLayout.Create(vlayout)
				add = Gwen.Button.Create(hlayout2)
				add.Margin = Gwen.Margin.Three
				add.Text = "Insert"
				add.Clicked.add(
					function (s, e)

						if (ctrl1.SelectedRowIndex ~= -1) then
							table.insert(items, ctrl1.SelectedRowIndex + 1, { Name = "Chicken", Type = "\u{5355}\u{5143}\u{6D4B}\u{8BD5}", Price = 8.95 })
						else
							table.insert(items, { Name = "Chicken", Type = "\u{5355}\u{5143}\u{6D4B}\u{8BD5}", Price = 8.95 })
						end

						ctrl1.ItemsSource = items

					end)
				remove = Gwen.Button.Create(hlayout2)
				remove.Margin = Gwen.Margin.Three
				remove.Text = "Remove"
				remove.Clicked.add(
					function (s, e)

						if (ctrl1.SelectedRowIndex ~= -1) then
							table.remove(items, ctrl1.SelectedRowIndex + 1)
							ctrl1.ItemsSource = items
						end

					end)

	hlayout = Gwen.HorizontalLayout.Create(this)
	hlayout.Margin = Gwen.Margin.Six
	hlayout.Dock = Gwen.Dock.Top

		ctrl2 = Gwen.ListBox.Create(hlayout)
		ctrl2.AutoSizeToContent = true
		row = ctrl2.AddRow("Row")
		ctrl2.AddRow("Text")
		ctrl2.AddRow("InternalName", "Name")
		ctrl2.AddRow("UserData", "Internal", 12)

		vlayout = Gwen.VerticalLayout.Create(hlayout)

			button = Gwen.Button.Create(vlayout)
			button.Text = "Row"
			button.Width = 100
			button.Clicked.add(function (s, e) ctrl2.SelectedRow = row end)

			button = Gwen.Button.Create(vlayout)
			button.Text = "Text"
			button.Width = 100
			button.Clicked.add(function (s, e) ctrl2.SelectRows("Text") end)

			button = Gwen.Button.Create(vlayout)
			button.Text = "Name"
			button.Width = 100
			button.Clicked.add(function (s, e) ctrl2.SelectByName("Name") end)

			button = Gwen.Button.Create(vlayout)
			button.Text = "UserData"
			button.Width = 100
			button.Clicked.add(function (s, e) ctrl2.SelectByUserData(12) end)

	multiline = Gwen.LabeledCheckBox.Create(this)
	multiline.Margin = Gwen.Margin.Six
	multiline.Dock = Gwen.Dock.Top
	multiline.Text = "Enable MultiSelect"
	multiline.CheckChanged.add(function (s, e) ctrl2.AllowMultiSelect = multiline.IsChecked end)

AddItem("Standard", "ListBox", this)
