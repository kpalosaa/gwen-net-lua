
local function CreateControl(parent, text)
	button = Gwen.Button.Create(parent)
	button.Text = text
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	grid = Gwen.GridLayout.Create(this)
	grid.Dock = Gwen.Dock.Fill
	grid.SetColumnWidths({ 0.2, Gwen.GridLayout.AutoSize, 140.0, 0.8 })
	grid.SetRowHeights({ 0.2, Gwen.GridLayout.AutoSize, 140.0, 0.8 })

	CreateControl(grid, "C: 20%, R: 20%")
	CreateControl(grid, "C: Auto R: 20%")
	CreateControl(grid, "C: 140, R: 20%")
	CreateControl(grid, "C: 80%, R: 20%")

	CreateControl(grid, "C: 20%, R: Auto")
	CreateControl(grid, "C: Auto R: Auto")
	CreateControl(grid, "C: 140, R: Auto")
	CreateControl(grid, "C: 80%, R: Auto")

	CreateControl(grid, "C: 20%, R: 140")
	CreateControl(grid, "C: Auto R: 140")
	CreateControl(grid, "C: 140, R: 140")
	CreateControl(grid, "C: 80%, R: 140")

	CreateControl(grid, "C: 20%, R: 80%")
	CreateControl(grid, "C: Auto R: 80%")
	CreateControl(grid, "C: 140, R: 80%")
	CreateControl(grid, "C: 80%, R: 80%")

AddItem("Layout", "GridLayout", this)
