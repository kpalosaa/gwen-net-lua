
local function OnPaddingChanged(s, e)

	i = s.Value
	outer.Padding = Gwen.Padding.Create(i, i, i, i)

end

local function OnMarginChanged(s, e)

	inner = s.UserData
	i = s.Value
	inner.Margin = Gwen.Margin.Create(i, i, i, i)

end

local function OnWidthChanged(s, e)

	inner = s.UserData
	if inner.HorizontalAlignment ~= Gwen.HorizontalAlignment.Stretch then
		inner.Width = s.Value
	end

end

local function OnHeightChanged(s, e)

	inner = s.UserData
	if inner.VerticalAlignment ~= Gwen.VerticalAlignment.Stretch then
		inner.Height = s.Value
	end

end

local function OnHAlignChanged(s, e)

	inner = s.UserData
	inner.HorizontalAlignment = s.Selected.UserData
	if inner.HorizontalAlignment == Gwen.HorizontalAlignment.Stretch then
		inner.Width = Gwen.Size.Ignore
	end

end

local function OnVAlignChanged(s, e)

	inner = s.UserData
	inner.VerticalAlignment = s.Selected.UserData
	if inner.VerticalAlignment == Gwen.VerticalAlignment.Stretch then
		inner.Height = Gwen.Size.Ignore
	end

end

local function OnDockChanged(s, e)

	inner = s.UserData
	gb = inner.UserData
	w = gb.FindChildByName("Width", true).Value
	h = gb.FindChildByName("Height", true).Value
	inner.Dock = s.Selected.UserData

	if inner.Dock == Gwen.Dock.Left then
		inner.Size = Gwen.Size.Create(w, Gwen.Size.Ignore)
	elseif inner.Dock == Gwen.Dock.Top then
		inner.Size = Gwen.Size.Create(Gwen.Size.Ignore, h)
	elseif inner.Dock == Gwen.Dock.Right then
		inner.Size = Gwen.Size.Create(w, Gwen.Size.Ignore)
	elseif inner.Dock == Gwen.Dock.Bottom then
		inner.Size = Gwen.Size.Create(Gwen.Size.Ignore, h)
	else
		inner.Size = Gwen.Size.Create(Gwen.Size.Ignore, Gwen.Size.Ignore)
	end

end

local function CreateControls(subject, docking, name, container)

	gb = Gwen.GroupBox.Create(container)
	gb.Text = name
	
		hlayout = Gwen.HorizontalLayout.Create(gb)
		
			dgb = Gwen.GroupBox.Create(hlayout)
			dgb.Text = "Dock";
			
				dock = Gwen.RadioButtonGroup.Create(dgb)
				dock.UserData = subject
				dock.AddOption("Left", nil, Gwen.Dock.Left)
				dock.AddOption("Top", nil, Gwen.Dock.Top)
				dock.AddOption("Right", nil, Gwen.Dock.Right)
				dock.AddOption("Bottom", nil, Gwen.Dock.Bottom)
				dock.AddOption("Fill", nil, Gwen.Dock.Fill)
				dock.SelectByUserData(docking)
				dock.SelectionChanged.add(OnDockChanged)
			

			vlayout = Gwen.VerticalLayout.Create(hlayout)
			
				hlayout2 = Gwen.HorizontalLayout.Create(vlayout)
				
					hgb = Gwen.GroupBox.Create(hlayout2)
					hgb.Text = "H. Align"
					
						halign = Gwen.RadioButtonGroup.Create(hgb)
						halign.UserData = subject
						halign.AddOption("Left", nil, Gwen.HorizontalAlignment.Left)
						halign.AddOption("Center", nil, Gwen.HorizontalAlignment.Center)
						halign.AddOption("Right", nil, Gwen.HorizontalAlignment.Right)
						halign.AddOption("Stretch", nil, Gwen.HorizontalAlignment.Stretch)
						halign.SelectByUserData(subject.HorizontalAlignment)
						halign.SelectionChanged.add(OnHAlignChanged)
					

					vgb = Gwen.GroupBox.Create(hlayout2)
					vgb.Text = "V. Align"
					
						valign = Gwen.RadioButtonGroup.Create(vgb)
						valign.UserData = subject
						valign.AddOption("Top", nil, Gwen.VerticalAlignment.Top)
						valign.AddOption("Center", nil, Gwen.VerticalAlignment.Center)
						valign.AddOption("Bottom", nil, Gwen.VerticalAlignment.Bottom)
						valign.AddOption("Stretch", nil, Gwen.VerticalAlignment.Stretch)
						valign.SelectByUserData(subject.VerticalAlignment)
						valign.SelectionChanged.add(OnVAlignChanged)

				glayout = Gwen.GridLayout.Create(vlayout)
				glayout.SetColumnWidths({ Gwen.GridLayout.AutoSize, Gwen.GridLayout.Fill });
				
					l_width = Gwen.Label.Create(glayout)
					l_width.Text = "Width:"

					width = Gwen.HorizontalSlider.Create(glayout)
					width.Name = "Width"
					width.UserData = subject
					width.Min = 50
					width.Max = 350
					width.Value = 100
					width.ValueChanged.add(OnWidthChanged)

					l_height = Gwen.Label.Create(glayout)
					l_height.Text = "Height:"

					height = Gwen.HorizontalSlider.Create(glayout)
					height.Name = "Height"
					height.UserData = subject
					height.Min = 50
					height.Max = 350
					height.Value = 100
					height.ValueChanged.add(OnHeightChanged)

					l_margin = Gwen.Label.Create(glayout)
					l_margin.Text = "Margin:"

					margin = Gwen.HorizontalSlider.Create(glayout)
					margin.Name = "Margin"
					margin.UserData = subject
					margin.Min = 0
					margin.Max = 50
					margin.Value = 0
					margin.ValueChanged.add(OnMarginChanged)

	return gb

end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	font = Gwen.Font.Create(Gwen.Canvas.DefaultFont.FaceName, Gwen.Canvas.DefaultFont.Size * 2)

	hlayout = Gwen.HorizontalLayout.Create(this)

		vlayout = Gwen.VerticalLayout.Create(hlayout)
		
			outer = Gwen.DockLayout.Create(vlayout)
			outer.Size = Gwen.Size.Create(400, 400)
			
				inner1 = Gwen.Label.Create(outer)
				inner1.Alignment = Gwen.Alignment.Center
				inner1.Text = "1"
				inner1.Font = font
				inner1.Size = Gwen.Size.Create(100, Gwen.Size.Ignore)
				inner1.Dock = Gwen.Dock.Left

				inner2 = Gwen.Label.Create(outer)
				inner2.Alignment = Gwen.Alignment.Center
				inner2.Text = "2"
				inner2.Font = font
				inner2.Size = Gwen.Size.Create(Gwen.Size.Ignore, 100)
				inner2.Dock = Gwen.Dock.Top

				inner3 = Gwen.Label.Create(outer)
				inner3.Alignment = Gwen.Alignment.Center
				inner3.Text = "3"
				inner3.Font = font
				inner3.Size = Gwen.Size.Create(100, Gwen.Size.Ignore)
				inner3.Dock = Gwen.Dock.Right

				inner4 = Gwen.Label.Create(outer)
				inner4.Alignment = Gwen.Alignment.Center
				inner4.Text = "4"
				inner4.Font = font
				inner4.Size = Gwen.Size.Create(Gwen.Size.Ignore, 100)
				inner4.Dock = Gwen.Dock.Bottom

				inner5 = Gwen.Label.Create(outer)
				inner5.Alignment = Gwen.Alignment.Center
				inner5.Text = "5"
				inner5.Font = font
				inner5.Size = Gwen.Size.Create(Gwen.Size.Ignore, Gwen.Size.Ignore)
				inner5.Dock = Gwen.Dock.Fill

			outer.DrawDebugOutlines = true

			hlayout2 = Gwen.HorizontalLayout.Create(vlayout)
			
				l_padding = Gwen.Label.Create(hlayout2)
				l_padding.Text = "Padding:"

				padding = Gwen.HorizontalSlider.Create(hlayout2)
				padding.Min = 0
				padding.Max = 200
				padding.Value = 10
				padding.Width = 100
				padding.ValueChanged.add(OnPaddingChanged)
			
		controlsLayout = Gwen.GridLayout.Create(hlayout)
		controlsLayout.ColumnCount = 2
		
			inner1.UserData = CreateControls(inner1, Gwen.Dock.Left, "Control 1", controlsLayout);
			inner2.UserData = CreateControls(inner2, Gwen.Dock.Top, "Control 2", controlsLayout);
			inner3.UserData = CreateControls(inner3, Gwen.Dock.Right, "Control 3", controlsLayout);
			inner4.UserData = CreateControls(inner4, Gwen.Dock.Bottom, "Control 4", controlsLayout);
			inner5.UserData = CreateControls(inner5, Gwen.Dock.Fill, "Control 5", controlsLayout);

AddItem("Layout", "Docking", this)
