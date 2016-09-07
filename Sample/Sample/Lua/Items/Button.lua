
hlayout = Gwen.HorizontalLayout.Create(Gwen.Canvas)

	vlayout = Gwen.VerticalLayout.Create(hlayout)
	vlayout.Width = 300

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Text = "Button"

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Text = "Image button (default)"
		button.ImageName = "test16.png"

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Text = "Image button (above)"
		button.ImageName = "test16.png"
		button.ImageAlign = Gwen.ImageAlign.Above

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Alignment = Gwen.Alignment.Left .. Gwen.Alignment.CenterV
		button.Text = "Image button (left)"
		button.ImageName = "test16.png"

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Alignment = Gwen.Alignment.Right .. Gwen.Alignment.CenterV
		button.Text = "Image button (right)"
		button.ImageName = "test16.png"

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Text = "Image button (image left)"
		button.ImageName = "test16.png"
		button.ImageAlign = Gwen.ImageAlign.Left .. Gwen.ImageAlign.CenterV

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Text = "Image button (image right)"
		button.ImageName = "test16.png"
		button.ImageAlign = Gwen.ImageAlign.Right .. Gwen.ImageAlign.CenterV

		button = Gwen.Button.Create(vlayout)
		button.Margin = Gwen.Margin.Create(5)
		button.Padding = Gwen.Padding.Create(3)
		button.Text = "Image button (image fill)"
		button.ImageName = "test16.png"
		button.ImageAlign = Gwen.ImageAlign.Fill

--[[
			HorizontalLayout hlayout = new HorizontalLayout(this);
			{
				VerticalLayout vlayout = new VerticalLayout(hlayout);
				vlayout.Width = 300;
				{


					button = new Control.Button(vlayout);
					button.Margin = Margin.Five;
					button.Padding = Padding.Three;
					button.Text = "Image button (image fill)";
					button.SetImage("test16.png", ImageAlign.Fill);

					HorizontalLayout hlayout2 = new HorizontalLayout(vlayout);
					{
						button = new Control.Button(hlayout2);
						button.HorizontalAlignment = HorizontalAlignment.Left;
						button.Padding = Padding.Three;
						button.Margin = Margin.Five;
						button.SetImage("test16.png");
						button.ImageSize = new Size(32, 32);

						button = new Control.Button(hlayout2);
						button.HorizontalAlignment = HorizontalAlignment.Left;
						button.VerticalAlignment = VerticalAlignment.Center;
						button.Padding = Padding.Three;
						button.Margin = Margin.Five;
						button.SetImage("test16.png");

						button = new Control.Button(hlayout2);
						button.HorizontalAlignment = HorizontalAlignment.Left;
						button.VerticalAlignment = VerticalAlignment.Center;
						button.Padding = Padding.Three;
						button.Margin = Margin.Five;
						button.SetImage("test16.png");
						button.ImageTextureRect = new Rectangle(4, 4, 8, 8);

						button = new Control.Button(hlayout2);
						button.HorizontalAlignment = HorizontalAlignment.Left;
						button.VerticalAlignment = VerticalAlignment.Center;
						button.Padding = Padding.Three;
						button.Margin = Margin.Five;
						button.SetImage("test16.png");
						button.ImageColor = Color.DarkGrey;
					}

					button = new Control.Button(vlayout);
					button.Margin = Margin.Five;
					button.Padding = new Padding(20, 20, 20, 20);
					button.Text = "Toggle me";
					button.IsToggle = true;
					button.Toggled += onToggle;
					button.ToggledOn += onToggleOn;
					button.ToggledOff += onToggleOff;

					button = new Control.Button(vlayout);
					button.Margin = Margin.Five;
					button.Padding = Padding.Three;
					button.Text = "Disabled";
					button.IsDisabled = true;

					button = new Control.Button(vlayout);
					button.Margin = Margin.Five;
					button.Padding = Padding.Three;
					button.Text = "With Tooltip";
					button.SetToolTipText("This is tooltip");

					button = new Control.Button(vlayout);
					button.Margin = Margin.Five;
					button.Padding = Padding.Three;
					button.Text = "Autosized";
					button.HorizontalAlignment = HorizontalAlignment.Left;
				}

				{
					Control.Button button = new Control.Button(hlayout);
					button.Margin = Margin.Five;
					button.Padding = Padding.Three;
					button.Text = "Event tester";
					button.Size = new Size(300, 200);
					button.Pressed += onButtonAp;
					button.Clicked += onButtonAc;
					button.Released += onButtonAr;
				}
			}
--]]












AddItem("Standard", "Button", hlayout)
