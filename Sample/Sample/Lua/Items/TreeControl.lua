
local function NodeCollapsed(s, e)
	print(string.format("Node collapsed: %s", s.Text))
end

local function NodeExpanded(s, e)
	print(string.format("Node expanded: %s", s.Text))
end

local function NodeSelected(s, e)
	print(string.format("Node selected: %s", s.Text))
end

local function NodeClicked(s, e)
	print(string.format("Node clicked: %s @(%d, %d)", s.Text, e.X, e.Y))
end

local function NodeDoubleClicked(s, e)
	print(string.format("Node double clicked: %s", s.Text))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.CrossSplitter.Create(this)
	layout.Dock = Gwen.Dock.Fill

		-- Simple Tree Control
		ctrl = Gwen.TreeControl.Create(layout)
		ctrl.AddNode("Node One")
		node = ctrl.AddNode("Node Two")
			node.AddNode("Node Two Inside")
			node.AddNode("Eyes")
			node.AddNode("Brown").AddNode("Node Two Inside").AddNode("Eyes").AddNode("Brown")
			imgnode = node.AddNode("Image")
			imgnode.ImageName = "test16.png"
			imgnode = node.AddNode("Image_Kids")
			imgnode.ImageName = "test16.png"
				imgnode.AddNode("Kid1")
				imgnode.AddNode("Kid2")
			node.AddNode("Nodes")
		ctrl.AddNode("Node Three");
		node = ctrl.AddNode("Clickables")
			click = node.AddNode("Single Click")
			click.Clicked.add(NodeClicked)
			click.RightClicked.add(NodeClicked)

			click = node.AddNode("Double Click");
			click.DoubleClicked.add(NodeDoubleClicked)
		ctrl.ExpandAll()
		ctrl.Selected.add(NodeSelected)
		ctrl.Expanded.add(NodeExpanded)
		ctrl.Collapsed.add(NodeCollapsed)

		-- Multi select Tree Control 
		ctrl = Gwen.TreeControl.Create(layout)
		ctrl.AllowMultiSelect = true
		ctrl.AddNode("Node One")
		node = ctrl.AddNode("Node Two")
			node.AddNode("Node Two Inside")
			node.AddNode("Eyes")
			nodeTwo = node.AddNode("Brown").AddNode("Node Two Inside").AddNode("Eyes")
				nodeTwo.AddNode("Brown")
				nodeTwo.AddNode("Green")
				nodeTwo.AddNode("Slime")
				nodeTwo.AddNode("Grass")
				nodeTwo.AddNode("Pipe")
			node.AddNode("More")
			node.AddNode("Nodes")
		ctrl.AddNode("Node Three")
		ctrl.ExpandAll()
		ctrl.Selected.add(NodeSelected)
		ctrl.Expanded.add(NodeExpanded)
		ctrl.Collapsed.add(NodeCollapsed)

		-- Normal Tree Control (without using the AddNode function
		ctrl = Gwen.TreeControl.Create(layout)
		node = Gwen.TreeNode.Create(ctrl)
		node.Text = "First"
		Gwen.TreeNode.Create(node).Text = "2nd first"
		node = Gwen.TreeNode.Create(ctrl)
		node.Text = "Second"
		node = Gwen.TreeNode.Create(node)
		node.Text = "Other 2nd"
		ctrl.ExpandAll()

		-- Not expanded Tree Control
		ctrl = Gwen.TreeControl.Create(layout)
		ctrl.AddNode("Node One")
		node = ctrl.AddNode("Node Two")
			node.AddNode("Node Two Inside")
			node.AddNode("Eyes")
			nodeTwo = node.AddNode("Brown").AddNode("Node Two Inside").AddNode("Eyes")
				nodeTwo.AddNode("Brown")
				nodeTwo.AddNode("Green")
				nodeTwo.AddNode("Slime")
				nodeTwo.AddNode("Grass")
				nodeTwo.AddNode("Pipe")
			node.AddNode("More")
			node.AddNode("Nodes")
		ctrl.AddNode("Node Three")
		ctrl.Selected.add(NodeSelected)
		ctrl.Expanded.add(NodeExpanded)
		ctrl.Collapsed.add(NodeCollapsed)

AddItem("Containers", "TreeControl", this)
