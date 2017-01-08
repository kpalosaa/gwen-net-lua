
local function MenuItemSelect(s, e)
	print(string.format("Menu item selected: %s", s.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	-- Menu Strip
	menu = Gwen.MenuStrip.Create(this)
	menu.Dock = Gwen.Dock.Top

		-- File
		root = menu.AddItem("File")

			root.AddItem("Load", "test16.png", "Ctrl+L").Selected.add(MenuItemSelect)
			root.AddItem("Save", nil, "Ctrl+S").Selected.add(MenuItemSelect)
			root.AddItem("Save As..", nil, "Ctrl+A").Selected.add(MenuItemSelect)
			root.AddItem("Quit", nil, "Ctrl+Q").Selected.add(MenuItemSelect)

		-- Russian
		root = menu.AddItem("\u{043F}\u{0438}\u{0440}\u{0430}\u{0442}\u{0441}\u{0442}\u{0432}\u{043E}")

			root.AddItem("\u{5355}\u{5143}\u{6D4B}\u{8BD5}").Selected.add(MenuItemSelect)
			root.AddItem("\u{0111}\u{01A1}n v\u{1ECB} th\u{1EED} nghi\u{1EC7}m", "test16.png").Selected.add(MenuItemSelect)

		-- Embdedded Menu Items
		root = menu.AddItem("Submenu")

			checkable = root.AddItem("Checkable")
			checkable.IsCheckable = true

			rootB = root.AddItem("Two")

				rootB.AddItem("Two.One")
				rootB.AddItem("Two.Two")
				rootB.AddItem("Two.Three")
				rootB.AddItem("Two.Four")
				rootB.AddItem("Two.Five")
				rootB.AddItem("Two.Six")
				rootB.AddItem("Two.Seven")
				rootB.AddItem("Two.Eight")
				rootB.AddItem("Two.Nine", "test16.png")
	
			root.AddItem("Three")
			root.AddItem("Four")
			root.AddItem("Five")

			rootB = root.AddItem("Six")

				rootB.AddItem("Six.One")
				rootB.AddItem("Six.Two")
				rootB.AddItem("Six.Three")
				rootB.AddItem("Six.Four")
				rootB.AddItem("Six.Five", "test16.png")

				rootC = rootB.AddItem("Six.Six")
				rootC.AddItem("Sheep")
				rootC.AddItem("Goose")
				
					rootD = rootC.AddItem("Camel")
					rootD.AddItem("Eyes")
					rootD.AddItem("Nose")
					
						rootE = rootD.AddItem("Hair")
						rootE.AddItem("Blonde")
						rootE.AddItem("Black")
						
							rootF = rootE.AddItem("Red")
							rootF.AddItem("Light")
							rootF.AddItem("Medium")
							rootF.AddItem("Dark")
						
						rootE.AddItem("Brown")
					
					rootD.AddItem("Ears")
				
				rootC.AddItem("Duck")
			
			rootB.AddItem("Six.Seven")
			rootB.AddItem("Six.Eight")
			rootB.AddItem("Six.Nine")

		root.AddItem("Seven")

	-- Context Menu Strip
	lblClickMe = Gwen.Label.Create(this)
	lblClickMe.Dock = Gwen.Dock.Fill
	lblClickMe.VerticalAlignment = Gwen.VerticalAlignment.Center
	lblClickMe.Text = "Right Click Me"

	contextMenu = Gwen.Menu.Create(this)
	contextMenu.AddItem("Test")
	contextMenu.AddItem("Clickable").Clicked.add(function (s, e) print("Clickable item was clicked") end)

	lblClickMe.RightClicked.add(function (s, e) contextMenu.Position = this.CanvasPosToLocal(e.Position) contextMenu.Show() end)

AddItem("Standard", "Menu", this)
