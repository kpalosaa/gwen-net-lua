
this = Gwen.DockLayout.Create(Gwen.Canvas)

	local function XmlWindow(view)
		local self = Gwen.ComponentBase(view)

		function self.OnButtonClicked(s, e)
			print(string.format("%s: Clicked", s.Name))
		end

		function self.OnItemSelected(s, e)
			print(string.format("%s: ItemSelected: %s", s.Name, e.SelectedItem.Text))
		end

		function self.OnSelectionChanged(s, e)
			print(string.format("%s: SelectionChanged: %s", s.Name, e.SelectedItem.Text))
		end

		function self.OnValueChanged(s, e)
			print(string.format("%s: ValueChanged: %s", s.Name, s.Value))
		end

		function self.OnTextChanged(s, e)
			print(string.format("%s: TextChanged: %s", s.Name, s.Text))
		end

		function self.OnSubmitPressed(s, e)
			print(string.format("%s: SubmitPressed: %s", s.Name, s.Text))
		end

		function self.OnCheckChanged(s, e)
			if s.IsChecked then
				print(string.format("%s: CheckChanged: True", s.Name))
			else
				print(string.format("%s: CheckChanged: False", s.Name))
			end
		end

		function self.OnRowSelected(s, e)
			print(string.format("%s: RowSelected: %s", s.Name, e.SelectedItem.Text))
		end

		function self.OnSelected(s, e)
			print(string.format("%s: RowSelected: %s", s.TreeControl.Name, s.Text))
		end

		function self.OnClosed(s, e)
			print(string.format("%s: Closed", s.Name))
		end

		return self
	end

	Gwen.Component.Register("XmlWindow", XmlWindow, "Window.xml")

	layout = Gwen.HorizontalLayout.Create(this)
	layout.VerticalAlignment = Gwen.VerticalAlignment.Top;

	button = Gwen.Button.Create(layout)
	button.Text = "Open Window"
	button.Clicked.add(function(s, e) Gwen.Component.Create("XmlWindow", this) end)

AddItem("XML", "Window", this)
