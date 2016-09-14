
local function OnLinkClicked(s, e)
	print(string.format("Link Clicked: %s", e.Link))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	label = Gwen.LinkLabel.Create(this)
	label.Dock = Gwen.Dock.Top
	label.HoverColor = Gwen.Color.Create(255, 255, 255, 255)
	label.Text = "Link Label (default font)"
	label.Link = "Test Link"
	label.LinkClicked.add(OnLinkClicked)

	label = Gwen.LinkLabel.Create(this)
	label.Dock = Gwen.Dock.Top;
	label.Font = Gwen.Font.Create("Comic Sans MS", 25)
	label.HoverFont = Gwen.Font.Create("Comic Sans MS", 25, Gwen.FontStyle.Underline)
	label.TextColor = Gwen.Color.Create(255, 0, 80, 205)
	label.HoverColor = Gwen.Color.Create(255, 0, 100, 255)
	label.Text = "Custom Font (Comic Sans 25)"
	label.Link = "Custom Font Link"
	label.LinkClicked.add(OnLinkClicked)

AddItem("Non-Interactive", "LinkLabel", this)
