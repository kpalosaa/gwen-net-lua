
this = Gwen.DockLayout.Create(Gwen.Canvas)


	hlayout = Gwen.HorizontalLayout.Create(this)
	hlayout.VerticalAlignment = Gwen.VerticalAlignment.Top
	
		vlayout = Gwen.VerticalLayout.Create(hlayout)
		vlayout.Width = 200
		
			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.Value = 0.03

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.Value = 0.66
			pb.Alignment = Gwen.Alignment.Right .. Gwen.Alignment.CenterV

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.Value = 0.88
			pb.Alignment = Gwen.Alignment.Left .. Gwen.Alignment.CenterV

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.AutoLabel = false
			pb.Value = 0.20
			pb.Alignment = Gwen.Alignment.Right .. Gwen.Alignment.CenterV
			pb.Text = "40,245 MB"

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.AutoLabel = false
			pb.Value = 1.00

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.AutoLabel = false
			pb.Value = 0.00

			pb = Gwen.ProgressBar.Create(vlayout)
			pb.Margin = Gwen.Margin.Five
			pb.AutoLabel = false
			pb.Value = 0.50

        pb = Gwen.ProgressBar.Create(hlayout)
		pb.Margin = Gwen.Margin.Five
		pb.IsHorizontal = false
        pb.Value = 0.25
        pb.Alignment = Gwen.Alignment.Top .. Gwen.Alignment.CenterH

        pb = Gwen.ProgressBar.Create(hlayout)
		pb.Margin = Gwen.Margin.Five
		pb.IsHorizontal = false
        pb.Value = 0.40

        pb = Gwen.ProgressBar.Create(hlayout)
		pb.Margin = Gwen.Margin.Five
		pb.IsHorizontal = false
        pb.Alignment = Gwen.Alignment.Bottom .. Gwen.Alignment.CenterH
        pb.Value = 0.65

AddItem("Non-Interactive", "ProgressBar", this)
