
this = Gwen.DockLayout.Create(Gwen.Canvas)

	local function ValueControl(view)
		local self = Gwen.ComponentBase(view)

		self.Value = 0
		self.Step = 1
		self.ValueChanged = Gwen.Event.Create("ValueChanged")

		function self.OnCreated(view)
			self.GetControl("Value").Value = self.Value
		end

		function self.OnButtonClicked(s, e)
			valueCtrl = self.GetControl("Value")
			name = s.name
			if name == "IndButton" then
				self.Value = self.Value + self.Step
			elseif name == "DecButton" then
				self.Value = self.Value - self.Step
			end
			valueCtrl.Value = self.Value
			self.ValueChanged.Invoke(self.GetView(), { Value = self.Value })
		end

		function self.OnSubmitPressed(s, e)
			self.Value = s.value
			self.ValueChanged.Invoke(self.GetView(), { Value = self.Value })
		end

		return self, self.OnCreated
	end

	Gwen.Component.Register("ValueControl", ValueControl, 
	[[<?xml version='1.0' encoding='UTF-8'?>
		<GridLayout ColumnWidths='25%, 50%, 25%'>
			<Button Name='DecButton' Text='Dec' Clicked='OnButtonClicked' />
			<TextBoxNumeric Name='Value' Dock='Fill' SubmitPressed='OnSubmitPressed' />
			<Button Name='IndButton' Text='Inc' Clicked='OnButtonClicked' />
		</GridLayout>
	]])

	local function Container(view)
		local self = Gwen.ComponentBase(view)

		function self.OnValueChanged(s, e)
			print(string.format("%s: ValueChanged: Value = %d", s.Name, e.Value))
		end

		return self
	end

	Gwen.Component.Register("Container", Container,
	[[<?xml version='1.0' encoding='UTF-8'?>
		<GridLayout Width='400' ColumnWidths='Auto, 100%'>
			<Label AutoSizeToContents='False' Alignment='CenterV' Text='Value 1:' />
			<ValueControl Name='Value1' Value='100' Step='2.0' ValueChanged='OnValueChanged' />
			<Label AutoSizeToContents='False' Alignment='CenterV' Text='Value 2:' />
			<ValueControl Name='Value2' Value='-10' Step='5.0' ValueChanged='OnValueChanged' />
		</GridLayout>
	]])

	Gwen.Component.Create("Container", this)

AddItem("XML", "Component", this)
