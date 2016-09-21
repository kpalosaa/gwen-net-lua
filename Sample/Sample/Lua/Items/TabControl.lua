
this = Gwen.DockLayout.Create(Gwen.Canvas)

    tabControl = Gwen.TabControl.Create(this)
	tabControl.Margin = Gwen.Margin.Five
	tabControl.Width = 200
	tabControl.Dock = Gwen.Dock.Top

	group = Gwen.GroupBox.Create(this)
	group.Text = "Tab position"

		radio = Gwen.RadioButtonGroup.Create(group)
		radio.AddOption("Top", null, Gwen.Dock.Top).Select()
		radio.AddOption("Bottom", null, Gwen.Dock.Bottom)
		radio.AddOption("Left", null, Gwen.Dock.Left)
		radio.AddOption("Right", null, Gwen.Dock.Right)
		radio.SelectionChanged.add(function (s, e) tabControl.TabStripPosition = s.Selected.UserData end)

	tabControl.AddPage("Controls", group)
	tabControl.AddPage("Red", Gwen.DockLayout.Create(this))
	tabControl.AddPage("Green", Gwen.DockLayout.Create(this));
	tabControl.AddPage("Blue", Gwen.DockLayout.Create(this));
	tabControl.AddPage("Blue", Gwen.DockLayout.Create(this));
	tabControl.AddPage("Blue", Gwen.DockLayout.Create(this));

	dragMe = Gwen.TabControl.Create(this)
	dragMe.Margin = Gwen.Margin.Five
	dragMe.Width = 200
	dragMe.Dock = Gwen.Dock.Top
	dragMe.AllowReorder = true
	dragMe.AddPage("You", Gwen.DockLayout.Create(this))
	dragMe.AddPage("Can", Gwen.DockLayout.Create(this))
	dragMe.AddPage("Reorder", Gwen.DockLayout.Create(this)).ImageName = "test16.png"
	dragMe.AddPage("These", Gwen.DockLayout.Create(this))
	dragMe.AddPage("Tabs", Gwen.DockLayout.Create(this))

AddItem("Containers", "TabControl", this)
