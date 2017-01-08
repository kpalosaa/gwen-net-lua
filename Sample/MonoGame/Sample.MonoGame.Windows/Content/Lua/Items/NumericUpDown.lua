
local function OnValueChanged(s, e)
	print(string.format("NumericUpDown: ValueChanged: %d", s.Value))
end

this = Gwen.DockLayout.Create(Gwen.Canvas)

	layout = Gwen.VerticalLayout.Create(this)

		ctrl = Gwen.NumericUpDown.Create(layout)
		ctrl.Margin = Gwen.Margin.Five
		ctrl.Width = 70
		ctrl.Value = 50
		ctrl.Max = 100
		ctrl.Min = -100
		ctrl.ValueChanged.add(OnValueChanged)

		ctrl = Gwen.NumericUpDown.Create(layout)
		ctrl.Margin = Gwen.Margin.Five
		ctrl.Width = 70
		ctrl.Value = 50
		ctrl.Max = 100
		ctrl.Min = -100
		ctrl.Step = 5
		ctrl.ValueChanged.add(OnValueChanged)

		ctrl = Gwen.NumericUpDown.Create(layout)
		ctrl.Margin = Gwen.Margin.Five
		ctrl.Width = 70
		ctrl.Value = 50
		ctrl.Max = 100
		ctrl.Min = -100
		ctrl.Step = 0.1
		ctrl.ValueChanged.add(OnValueChanged)

		ctrl = Gwen.NumericUpDown.Create(layout)
		ctrl.Margin = Gwen.Margin.Five
		ctrl.Width = 70
		ctrl.Max = 999999
		ctrl.Min = 0
		ctrl.Step = 1
		ctrl.ValueChanged.add(OnValueChanged)

AddItem("Standard", "NumericUpDown", this)
