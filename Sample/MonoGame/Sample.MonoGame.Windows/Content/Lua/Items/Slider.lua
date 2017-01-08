
local function OnValueChanged(s, e)
	print(string.format("Slider: ValueChanged: %d", s.Value))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	hlayout = Gwen.HorizontalLayout.Create(this)

		vlayout = Gwen.VerticalLayout.Create(hlayout)

			slider = Gwen.HorizontalSlider.Create(vlayout)
			slider.Margin = Gwen.Margin.Ten
			slider.Width = 150
			slider.SetRange(0, 100)
			slider.Value = 25
			slider.ValueChanged.add(OnValueChanged)

			slider = Gwen.HorizontalSlider.Create(vlayout)
			slider.Margin = Gwen.Margin.Ten
			slider.Width = 150
			slider.SetRange(0, 100)
			slider.Value = 20
			slider.NotchCount = 10
			slider.SnapToNotches = true
			slider.ValueChanged.add(OnValueChanged)

        slider = Gwen.VerticalSlider.Create(hlayout)
		slider.Margin = Gwen.Margin.Ten
		slider.Height = 200
        slider.SetRange(0, 100)
        slider.Value = 25
		slider.ValueChanged.add(OnValueChanged)

        slider = Gwen.VerticalSlider.Create(hlayout)
		slider.Margin = Gwen.Margin.Ten
		slider.Height = 200
        slider.SetRange(0, 100)
        slider.Value = 20
        slider.NotchCount = 10
        slider.SnapToNotches = true
		slider.ValueChanged.add(OnValueChanged)

AddItem("Standard", "Slider", this)
