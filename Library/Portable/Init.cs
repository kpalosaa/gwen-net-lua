using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public static class Lua
	{
		public static void Init(Script script, Gwen.Control.Canvas canvas)
		{
			Table gwen = new Table(script);

			// Register enums

			UserData.RegisterType<Gwen.HorizontalAlignment>();
			gwen["HorizontalAlignment"] = UserData.CreateStatic<Gwen.HorizontalAlignment>();

			UserData.RegisterType<Gwen.VerticalAlignment>();
			gwen["VerticalAlignment"] = UserData.CreateStatic<Gwen.VerticalAlignment>();

			UserData.RegisterType<Gwen.Dock>();
			gwen["Dock"] = UserData.CreateStatic<Gwen.Dock>();

			UserData.RegisterType<Gwen.Alignment>();
			gwen["Alignment"] = UserData.CreateStatic<Gwen.Alignment>();

			UserData.RegisterType<Gwen.Control.ImageAlign>();
			gwen["ImageAlign"] = UserData.CreateStatic<Gwen.Control.ImageAlign>();

			UserData.RegisterType<Gwen.Control.BorderType>();
			gwen["BorderType"] = UserData.CreateStatic<Gwen.Control.BorderType>();

			UserData.RegisterType<Gwen.Control.Resizing>();
			gwen["Resizing"] = UserData.CreateStatic<Gwen.Control.Resizing>();

			UserData.RegisterType<Gwen.Control.StartPosition>();
			gwen["StartPosition"] = UserData.CreateStatic<Gwen.Control.StartPosition>();

			UserData.RegisterType<Gwen.Control.MessageBoxButtons>();
			gwen["MessageBoxButtons"] = UserData.CreateStatic<Gwen.Control.MessageBoxButtons>();

			UserData.RegisterType<Gwen.Control.MessageBoxButtons>();
			gwen["MessageBoxButtons"] = UserData.CreateStatic<Gwen.Control.MessageBoxButtons>();

			UserData.RegisterType<System.Text.RegularExpressions.RegexOptions>();
			gwen["RegexOptions"] = UserData.CreateStatic<System.Text.RegularExpressions.RegexOptions>();

			// Register event args

			UserData.RegisterType<EventArgs>();
			UserData.RegisterType<Gwen.Control.ClickedEventArgs>();
			UserData.RegisterType<Gwen.Control.LinkClickedEventArgs>();
			UserData.RegisterType<Gwen.Control.MessageBoxResultEventArgs>();

			UserData.RegisterProxyType<GwenNetLua.Control.ItemSelectedEventArgs, Gwen.Control.ItemSelectedEventArgs>(r => new GwenNetLua.Control.ItemSelectedEventArgs(r));

			// Register structs

			UserData.RegisterType<GwenNetLua.Margin>();
			gwen["Margin"] = typeof(GwenNetLua.Margin);

			UserData.RegisterType<GwenNetLua.Padding>();
			gwen["Padding"] = typeof(GwenNetLua.Padding);

			UserData.RegisterType<GwenNetLua.Point>();
			gwen["Point"] = typeof(GwenNetLua.Point);

			UserData.RegisterType<GwenNetLua.Size>();
			gwen["Size"] = typeof(GwenNetLua.Size);

			UserData.RegisterType<GwenNetLua.Rectangle>();
			gwen["Rectangle"] = typeof(GwenNetLua.Rectangle);

			UserData.RegisterType<GwenNetLua.Font>();
			gwen["Font"] = typeof(GwenNetLua.Font);

			UserData.RegisterType<GwenNetLua.Color>();
			gwen["Color"] = typeof(GwenNetLua.Color);

			UserData.RegisterType<GwenNetLua.Anchor>();
			gwen["Anchor"] = typeof(GwenNetLua.Anchor);

			// Register canvas

			UserData.RegisterProxyType<GwenNetLua.Control.Canvas, Gwen.Control.Canvas>(r => new GwenNetLua.Control.Canvas(r));
			gwen["Canvas"] = new GwenNetLua.Control.Canvas(canvas);

			// Register non-creatable controls

			UserData.RegisterProxyType<GwenNetLua.Control.Internal.InnerContentControl, Gwen.Control.Internal.InnerContentControl>(r => new GwenNetLua.Control.Internal.InnerContentControl(r));

			// Register creatable controls

			UserData.RegisterProxyType<GwenNetLua.Control.AnchorLayout, Gwen.Control.Layout.AnchorLayout>(r => new GwenNetLua.Control.AnchorLayout(r));
			gwen["AnchorLayout"] = typeof(GwenNetLua.Control.AnchorLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.Border, Gwen.Control.Border>(r => new GwenNetLua.Control.Border(r));
			gwen["Border"] = typeof(GwenNetLua.Control.Border);

			UserData.RegisterProxyType<GwenNetLua.Control.Button, Gwen.Control.Button>(r => new GwenNetLua.Control.Button(r));
			gwen["Button"] = typeof(GwenNetLua.Control.Button);

			UserData.RegisterProxyType<GwenNetLua.Control.CheckBox, Gwen.Control.CheckBox>(r => new GwenNetLua.Control.CheckBox(r));
			gwen["CheckBox"] = typeof(GwenNetLua.Control.CheckBox);

			UserData.RegisterProxyType<GwenNetLua.Control.CollapsibleCategory, Gwen.Control.CollapsibleCategory>(r => new GwenNetLua.Control.CollapsibleCategory(r));
			gwen["CollapsibleCategory"] = typeof(GwenNetLua.Control.CollapsibleCategory);

			UserData.RegisterProxyType<GwenNetLua.Control.CollapsibleList, Gwen.Control.CollapsibleList>(r => new GwenNetLua.Control.CollapsibleList(r));
			gwen["CollapsibleList"] = typeof(GwenNetLua.Control.CollapsibleList);

			UserData.RegisterProxyType<GwenNetLua.Control.ComboBox, Gwen.Control.ComboBox>(r => new GwenNetLua.Control.ComboBox(r));
			gwen["ComboBox"] = typeof(GwenNetLua.Control.ComboBox);

			UserData.RegisterProxyType<GwenNetLua.Control.CrossSplitter, Gwen.Control.CrossSplitter>(r => new GwenNetLua.Control.CrossSplitter(r));
			gwen["CrossSplitter"] = typeof(GwenNetLua.Control.CrossSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.DockControl, Gwen.Control.DockControl>(r => new GwenNetLua.Control.DockControl(r));
			gwen["DockControl"] = typeof(GwenNetLua.Control.DockControl);

			UserData.RegisterProxyType<GwenNetLua.Control.DockLayout, Gwen.Control.Layout.DockLayout>(r => new GwenNetLua.Control.DockLayout(r));
			gwen["DockLayout"] = typeof(GwenNetLua.Control.DockLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.EditableComboBox, Gwen.Control.EditableComboBox>(r => new GwenNetLua.Control.EditableComboBox(r));
			gwen["EditableComboBox"] = typeof(GwenNetLua.Control.EditableComboBox);

			UserData.RegisterProxyType<GwenNetLua.Control.FlowLayout, Gwen.Control.Layout.FlowLayout>(r => new GwenNetLua.Control.FlowLayout(r));
			gwen["FlowLayout"] = typeof(GwenNetLua.Control.FlowLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.GridLayout, Gwen.Control.Layout.GridLayout>(r => new GwenNetLua.Control.GridLayout(r));
			gwen["GridLayout"] = typeof(GwenNetLua.Control.GridLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.GroupBox, Gwen.Control.GroupBox>(r => new GwenNetLua.Control.GroupBox(r));
			gwen["GroupBox"] = typeof(GwenNetLua.Control.GroupBox);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalLayout, Gwen.Control.Layout.HorizontalLayout>(r => new GwenNetLua.Control.HorizontalLayout(r));
			gwen["HorizontalLayout"] = typeof(GwenNetLua.Control.HorizontalLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalSlider, Gwen.Control.HorizontalSlider>(r => new GwenNetLua.Control.HorizontalSlider(r));
			gwen["HorizontalSlider"] = typeof(GwenNetLua.Control.HorizontalSlider);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalSplitter, Gwen.Control.HorizontalSplitter>(r => new GwenNetLua.Control.HorizontalSplitter(r));
			gwen["HorizontalSplitter"] = typeof(GwenNetLua.Control.HorizontalSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.ImagePanel, Gwen.Control.ImagePanel>(r => new GwenNetLua.Control.ImagePanel(r));
			gwen["ImagePanel"] = typeof(GwenNetLua.Control.ImagePanel);

			UserData.RegisterProxyType<GwenNetLua.Control.Label, Gwen.Control.Label>(r => new GwenNetLua.Control.Label(r));
			gwen["Label"] = typeof(GwenNetLua.Control.Label);

			UserData.RegisterProxyType<GwenNetLua.Control.LabeledCheckBox, Gwen.Control.LabeledCheckBox>(r => new GwenNetLua.Control.LabeledCheckBox(r));
			gwen["LabeledCheckBox"] = typeof(GwenNetLua.Control.LabeledCheckBox);

			UserData.RegisterProxyType<GwenNetLua.Control.LabeledRadioButton, Gwen.Control.LabeledRadioButton>(r => new GwenNetLua.Control.LabeledRadioButton(r));
			gwen["LabeledRadioButton"] = typeof(GwenNetLua.Control.LabeledRadioButton);

			UserData.RegisterProxyType<GwenNetLua.Control.ListBox, Gwen.Control.ListBox>(r => new GwenNetLua.Control.ListBox(r));
			gwen["ListBox"] = typeof(GwenNetLua.Control.ListBox);

			UserData.RegisterProxyType<GwenNetLua.Control.ListBoxRow, Gwen.Control.ListBoxRow>(r => new GwenNetLua.Control.ListBoxRow(r));
			gwen["ListBoxRow"] = typeof(GwenNetLua.Control.ListBoxRow);

			UserData.RegisterProxyType<GwenNetLua.Control.Menu, Gwen.Control.Menu>(r => new GwenNetLua.Control.Menu(r));
			gwen["Menu"] = typeof(GwenNetLua.Control.Menu);

			UserData.RegisterProxyType<GwenNetLua.Control.MenuItem, Gwen.Control.MenuItem>(r => new GwenNetLua.Control.MenuItem(r));
			gwen["MenuItem"] = typeof(GwenNetLua.Control.MenuItem);

			UserData.RegisterProxyType<GwenNetLua.Control.MenuStrip, Gwen.Control.MenuStrip>(r => new GwenNetLua.Control.MenuStrip(r));
			gwen["MenuStrip"] = typeof(GwenNetLua.Control.MenuStrip);

			UserData.RegisterProxyType<GwenNetLua.Control.MessageBox, Gwen.Control.MessageBox>(r => new GwenNetLua.Control.MessageBox(r));
			gwen["MessageBox"] = typeof(GwenNetLua.Control.MessageBox);

			UserData.RegisterProxyType<GwenNetLua.Control.MultilineTextBox, Gwen.Control.MultilineTextBox>(r => new GwenNetLua.Control.MultilineTextBox(r));
			gwen["MultilineTextBox"] = typeof(GwenNetLua.Control.MultilineTextBox);

			UserData.RegisterProxyType<GwenNetLua.Control.NumericUpDown, Gwen.Control.NumericUpDown>(r => new GwenNetLua.Control.NumericUpDown(r));
			gwen["NumericUpDown"] = typeof(GwenNetLua.Control.NumericUpDown);

			UserData.RegisterProxyType<GwenNetLua.Control.Popup, Gwen.Control.Popup>(r => new GwenNetLua.Control.Popup(r));
			gwen["Popup"] = typeof(GwenNetLua.Control.Popup);

			UserData.RegisterProxyType<GwenNetLua.Control.ProgressBar, Gwen.Control.ProgressBar>(r => new GwenNetLua.Control.ProgressBar(r));
			gwen["ProgressBar"] = typeof(GwenNetLua.Control.ProgressBar);

			UserData.RegisterProxyType<GwenNetLua.Control.RadioButton, Gwen.Control.RadioButton>(r => new GwenNetLua.Control.RadioButton(r));
			gwen["RadioButton"] = typeof(GwenNetLua.Control.RadioButton);

			UserData.RegisterProxyType<GwenNetLua.Control.RadioButtonGroup, Gwen.Control.RadioButtonGroup>(r => new GwenNetLua.Control.RadioButtonGroup(r));
			gwen["RadioButtonGroup"] = typeof(GwenNetLua.Control.RadioButtonGroup);

			UserData.RegisterProxyType<GwenNetLua.Control.ScrollControl, Gwen.Control.ScrollControl>(r => new GwenNetLua.Control.ScrollControl(r));
			gwen["ScrollControl"] = typeof(GwenNetLua.Control.ScrollControl);

			UserData.RegisterProxyType<GwenNetLua.Control.StackLayout, Gwen.Control.Layout.StackLayout>(r => new GwenNetLua.Control.StackLayout(r));
			gwen["StackLayout"] = typeof(GwenNetLua.Control.StackLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.StatusBar, Gwen.Control.StatusBar>(r => new GwenNetLua.Control.StatusBar(r));
			gwen["StatusBar"] = typeof(GwenNetLua.Control.StatusBar);

			UserData.RegisterProxyType<GwenNetLua.Control.TabControl, Gwen.Control.TabControl>(r => new GwenNetLua.Control.TabControl(r));
			gwen["TabControl"] = typeof(GwenNetLua.Control.TabControl);

			UserData.RegisterProxyType<GwenNetLua.Control.Table, Gwen.Control.Table>(r => new GwenNetLua.Control.Table(r));
			gwen["Table"] = typeof(GwenNetLua.Control.Table);

			UserData.RegisterProxyType<GwenNetLua.Control.TableRow, Gwen.Control.TableRow>(r => new GwenNetLua.Control.TableRow(r));
			gwen["TableRow"] = typeof(GwenNetLua.Control.TableRow);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBox, Gwen.Control.TextBox>(r => new GwenNetLua.Control.TextBox(r));
			gwen["TextBox"] = typeof(GwenNetLua.Control.TextBox);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBoxNumeric, Gwen.Control.TextBoxNumeric>(r => new GwenNetLua.Control.TextBoxNumeric(r));
			gwen["TextBoxNumeric"] = typeof(GwenNetLua.Control.TextBoxNumeric);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBoxPassword, Gwen.Control.TextBoxPassword>(r => new GwenNetLua.Control.TextBoxPassword(r));
			gwen["TextBoxPassword"] = typeof(GwenNetLua.Control.TextBoxPassword);

			UserData.RegisterProxyType<GwenNetLua.Control.ToolWindow, Gwen.Control.ToolWindow>(r => new GwenNetLua.Control.ToolWindow(r));
			gwen["ToolWindow"] = typeof(GwenNetLua.Control.ToolWindow);

			UserData.RegisterProxyType<GwenNetLua.Control.TreeControl, Gwen.Control.TreeControl>(r => new GwenNetLua.Control.TreeControl(r));
			gwen["TreeControl"] = typeof(GwenNetLua.Control.TreeControl);

			UserData.RegisterProxyType<GwenNetLua.Control.TreeNode, Gwen.Control.TreeNode>(r => new GwenNetLua.Control.TreeNode(r));
			gwen["TreeNode"] = typeof(GwenNetLua.Control.TreeNode);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalLayout, Gwen.Control.Layout.VerticalLayout>(r => new GwenNetLua.Control.VerticalLayout(r));
			gwen["VerticalLayout"] = typeof(GwenNetLua.Control.VerticalLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalSlider, Gwen.Control.VerticalSlider>(r => new GwenNetLua.Control.VerticalSlider(r));
			gwen["VerticalSlider"] = typeof(GwenNetLua.Control.VerticalSlider);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalSplitter, Gwen.Control.VerticalSplitter>(r => new GwenNetLua.Control.VerticalSplitter(r));
			gwen["VerticalSplitter"] = typeof(GwenNetLua.Control.VerticalSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.Window, Gwen.Control.Window>(r => new GwenNetLua.Control.Window(r));
			gwen["Window"] = typeof(GwenNetLua.Control.Window);

			// Register component types

			UserData.RegisterType<Xml.ComponentServices>();
			gwen["Component"] = new Xml.ComponentServices(script);

			UserData.RegisterType<Xml.LuaEvent>();
			gwen["Event"] = typeof(Xml.LuaEvent);

			script.DoString(@"
				function ComponentBase(view)
					local self = {}
					local compView = view
					function self.GetView()
						return compView
					end
					function self.GetControl(name)
						return Component.GetControl(compView, name)
					end
					function self.GetComponent(name)
						return Component.GetComponent(compView, name)
					end
					return self
				end", gwen);

			// Protect namespace

			gwen.MetaTable = new Table(script);
			gwen.MetaTable["__metatable"] = "Read-only";
			gwen.MetaTable["__index"] = gwen;
			gwen.MetaTable["__newindex"] = (Action<Table, DynValue, DynValue>)((tbl, index, value) =>
			{
				throw new ScriptRuntimeException($"{index} is read-only");
			});

			// Set namespace
			
			script.Globals["Gwen"] = gwen;
		}
	}
}
