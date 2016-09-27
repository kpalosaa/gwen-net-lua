using System;
using MoonSharp.Interpreter;

namespace GwenNetLua
{
	public static class Lua
	{
		public static void Init(Script script, string uiNameSpace = "Gwen")
		{
			Lua.uiNameSpace = uiNameSpace;
			Lua.script = script;

			Table nameSpace = new Table(script);

			// Register enums

			UserData.RegisterType<Gwen.HorizontalAlignment>();
			nameSpace["HorizontalAlignment"] = UserData.CreateStatic<Gwen.HorizontalAlignment>();

			UserData.RegisterType<Gwen.VerticalAlignment>();
			nameSpace["VerticalAlignment"] = UserData.CreateStatic<Gwen.VerticalAlignment>();

			UserData.RegisterType<Gwen.Dock>();
			nameSpace["Dock"] = UserData.CreateStatic<Gwen.Dock>();

			UserData.RegisterType<Gwen.Alignment>();
			nameSpace["Alignment"] = UserData.CreateStatic<Gwen.Alignment>();

			UserData.RegisterType<Gwen.Control.ImageAlign>();
			nameSpace["ImageAlign"] = UserData.CreateStatic<Gwen.Control.ImageAlign>();

			UserData.RegisterType<Gwen.Control.BorderType>();
			nameSpace["BorderType"] = UserData.CreateStatic<Gwen.Control.BorderType>();

			UserData.RegisterType<Gwen.Control.Resizing>();
			nameSpace["Resizing"] = UserData.CreateStatic<Gwen.Control.Resizing>();

			UserData.RegisterType<Gwen.Control.StartPosition>();
			nameSpace["StartPosition"] = UserData.CreateStatic<Gwen.Control.StartPosition>();

			UserData.RegisterType<Gwen.Control.MessageBoxButtons>();
			nameSpace["MessageBoxButtons"] = UserData.CreateStatic<Gwen.Control.MessageBoxButtons>();

			UserData.RegisterType<Gwen.Control.MessageBoxResult>();
			nameSpace["MessageBoxResult"] = UserData.CreateStatic<Gwen.Control.MessageBoxResult>();

			UserData.RegisterType<System.Text.RegularExpressions.RegexOptions>();
			nameSpace["RegexOptions"] = UserData.CreateStatic<System.Text.RegularExpressions.RegexOptions>();

			UserData.RegisterType<Gwen.FontStyle>();
			nameSpace["FontStyle"] = UserData.CreateStatic<Gwen.FontStyle>();

			// Register event args

			UserData.RegisterType<EventArgs>();
			UserData.RegisterProxyType<GwenNetLua.Control.MessageBoxResultEventArgs, Gwen.Control.MessageBoxResultEventArgs>(r => new GwenNetLua.Control.MessageBoxResultEventArgs(r));
			UserData.RegisterProxyType<GwenNetLua.Control.LinkClickedEventArgs, Gwen.Control.LinkClickedEventArgs>(r => new GwenNetLua.Control.LinkClickedEventArgs(r));
			UserData.RegisterProxyType<GwenNetLua.Control.ClickedEventArgs, Gwen.Control.ClickedEventArgs>(r => new GwenNetLua.Control.ClickedEventArgs(r));
			UserData.RegisterProxyType<GwenNetLua.Control.ItemSelectedEventArgs, Gwen.Control.ItemSelectedEventArgs>(r => new GwenNetLua.Control.ItemSelectedEventArgs(r));

			// Register structs

			UserData.RegisterType<GwenNetLua.Margin>();
			nameSpace["Margin"] = typeof(GwenNetLua.Margin);

			UserData.RegisterType<GwenNetLua.Padding>();
			nameSpace["Padding"] = typeof(GwenNetLua.Padding);

			UserData.RegisterType<GwenNetLua.Point>();
			nameSpace["Point"] = typeof(GwenNetLua.Point);

			UserData.RegisterType<GwenNetLua.Size>();
			nameSpace["Size"] = typeof(GwenNetLua.Size);

			UserData.RegisterType<GwenNetLua.Rectangle>();
			nameSpace["Rectangle"] = typeof(GwenNetLua.Rectangle);

			UserData.RegisterType<GwenNetLua.Font>();
			nameSpace["Font"] = typeof(GwenNetLua.Font);

			UserData.RegisterType<GwenNetLua.Color>();
			nameSpace["Color"] = typeof(GwenNetLua.Color);

			UserData.RegisterType<GwenNetLua.Anchor>();
			nameSpace["Anchor"] = typeof(GwenNetLua.Anchor);

			UserData.RegisterType<GwenNetLua.Document>();
			nameSpace["Document"] = typeof(GwenNetLua.Document);

			UserData.RegisterType<GwenNetLua.Paragraph>();
			nameSpace["Paragraph"] = typeof(GwenNetLua.Paragraph);

			UserData.RegisterType<GwenNetLua.ImageParagraph>();
			nameSpace["ImageParagraph"] = typeof(GwenNetLua.ImageParagraph);

			// Register canvas type

			UserData.RegisterType<GwenNetLua.Control.Canvas>();

			// Register non-creatable controls

			UserData.RegisterProxyType<GwenNetLua.Control.Internal.InnerContentControl, Gwen.Control.Internal.InnerContentControl>(r => new GwenNetLua.Control.Internal.InnerContentControl(r));
			UserData.RegisterProxyType<GwenNetLua.Control.Internal.TabButton, Gwen.Control.Internal.TabButton>(r => new GwenNetLua.Control.Internal.TabButton(r));

			// Register creatable controls

			UserData.RegisterProxyType<GwenNetLua.Control.AnchorLayout, Gwen.Control.Layout.AnchorLayout>(r => new GwenNetLua.Control.AnchorLayout(r));
			nameSpace["AnchorLayout"] = typeof(GwenNetLua.Control.AnchorLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.Border, Gwen.Control.Border>(r => new GwenNetLua.Control.Border(r));
			nameSpace["Border"] = typeof(GwenNetLua.Control.Border);

			UserData.RegisterProxyType<GwenNetLua.Control.Button, Gwen.Control.Button>(r => new GwenNetLua.Control.Button(r));
			nameSpace["Button"] = typeof(GwenNetLua.Control.Button);

			UserData.RegisterProxyType<GwenNetLua.Control.CheckBox, Gwen.Control.CheckBox>(r => new GwenNetLua.Control.CheckBox(r));
			nameSpace["CheckBox"] = typeof(GwenNetLua.Control.CheckBox);

			UserData.RegisterProxyType<GwenNetLua.Control.CollapsibleCategory, Gwen.Control.CollapsibleCategory>(r => new GwenNetLua.Control.CollapsibleCategory(r));
			nameSpace["CollapsibleCategory"] = typeof(GwenNetLua.Control.CollapsibleCategory);

			UserData.RegisterProxyType<GwenNetLua.Control.CollapsibleList, Gwen.Control.CollapsibleList>(r => new GwenNetLua.Control.CollapsibleList(r));
			nameSpace["CollapsibleList"] = typeof(GwenNetLua.Control.CollapsibleList);

			UserData.RegisterProxyType<GwenNetLua.Control.ComboBox, Gwen.Control.ComboBox>(r => new GwenNetLua.Control.ComboBox(r));
			nameSpace["ComboBox"] = typeof(GwenNetLua.Control.ComboBox);

			UserData.RegisterProxyType<GwenNetLua.Control.CrossSplitter, Gwen.Control.CrossSplitter>(r => new GwenNetLua.Control.CrossSplitter(r));
			nameSpace["CrossSplitter"] = typeof(GwenNetLua.Control.CrossSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.DockControl, Gwen.Control.DockControl>(r => new GwenNetLua.Control.DockControl(r));
			nameSpace["DockControl"] = typeof(GwenNetLua.Control.DockControl);

			UserData.RegisterProxyType<GwenNetLua.Control.DockLayout, Gwen.Control.Layout.DockLayout>(r => new GwenNetLua.Control.DockLayout(r));
			nameSpace["DockLayout"] = typeof(GwenNetLua.Control.DockLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.EditableComboBox, Gwen.Control.EditableComboBox>(r => new GwenNetLua.Control.EditableComboBox(r));
			nameSpace["EditableComboBox"] = typeof(GwenNetLua.Control.EditableComboBox);

			UserData.RegisterProxyType<GwenNetLua.Control.FlowLayout, Gwen.Control.Layout.FlowLayout>(r => new GwenNetLua.Control.FlowLayout(r));
			nameSpace["FlowLayout"] = typeof(GwenNetLua.Control.FlowLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.GridLayout, Gwen.Control.Layout.GridLayout>(r => new GwenNetLua.Control.GridLayout(r));
			nameSpace["GridLayout"] = typeof(GwenNetLua.Control.GridLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.GroupBox, Gwen.Control.GroupBox>(r => new GwenNetLua.Control.GroupBox(r));
			nameSpace["GroupBox"] = typeof(GwenNetLua.Control.GroupBox);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalLayout, Gwen.Control.Layout.HorizontalLayout>(r => new GwenNetLua.Control.HorizontalLayout(r));
			nameSpace["HorizontalLayout"] = typeof(GwenNetLua.Control.HorizontalLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalSlider, Gwen.Control.HorizontalSlider>(r => new GwenNetLua.Control.HorizontalSlider(r));
			nameSpace["HorizontalSlider"] = typeof(GwenNetLua.Control.HorizontalSlider);

			UserData.RegisterProxyType<GwenNetLua.Control.HorizontalSplitter, Gwen.Control.HorizontalSplitter>(r => new GwenNetLua.Control.HorizontalSplitter(r));
			nameSpace["HorizontalSplitter"] = typeof(GwenNetLua.Control.HorizontalSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.HSVColorPicker, Gwen.Control.HSVColorPicker>(r => new GwenNetLua.Control.HSVColorPicker(r));
			nameSpace["HSVColorPicker"] = typeof(GwenNetLua.Control.HSVColorPicker);

			UserData.RegisterProxyType<GwenNetLua.Control.ImagePanel, Gwen.Control.ImagePanel>(r => new GwenNetLua.Control.ImagePanel(r));
			nameSpace["ImagePanel"] = typeof(GwenNetLua.Control.ImagePanel);

			UserData.RegisterProxyType<GwenNetLua.Control.Label, Gwen.Control.Label>(r => new GwenNetLua.Control.Label(r));
			nameSpace["Label"] = typeof(GwenNetLua.Control.Label);

			UserData.RegisterProxyType<GwenNetLua.Control.LabeledCheckBox, Gwen.Control.LabeledCheckBox>(r => new GwenNetLua.Control.LabeledCheckBox(r));
			nameSpace["LabeledCheckBox"] = typeof(GwenNetLua.Control.LabeledCheckBox);

			UserData.RegisterProxyType<GwenNetLua.Control.LabeledRadioButton, Gwen.Control.LabeledRadioButton>(r => new GwenNetLua.Control.LabeledRadioButton(r));
			nameSpace["LabeledRadioButton"] = typeof(GwenNetLua.Control.LabeledRadioButton);

			UserData.RegisterProxyType<GwenNetLua.Control.LinkLabel, Gwen.Control.LinkLabel>(r => new GwenNetLua.Control.LinkLabel(r));
			nameSpace["LinkLabel"] = typeof(GwenNetLua.Control.LinkLabel);

			UserData.RegisterProxyType<GwenNetLua.Control.ListBox, Gwen.Control.ListBox>(r => new GwenNetLua.Control.ListBox(r));
			nameSpace["ListBox"] = typeof(GwenNetLua.Control.ListBox);

			UserData.RegisterProxyType<GwenNetLua.Control.ListBoxRow, Gwen.Control.ListBoxRow>(r => new GwenNetLua.Control.ListBoxRow(r));
			nameSpace["ListBoxRow"] = typeof(GwenNetLua.Control.ListBoxRow);

			UserData.RegisterProxyType<GwenNetLua.Control.Menu, Gwen.Control.Menu>(r => new GwenNetLua.Control.Menu(r));
			nameSpace["Menu"] = typeof(GwenNetLua.Control.Menu);

			UserData.RegisterProxyType<GwenNetLua.Control.MenuItem, Gwen.Control.MenuItem>(r => new GwenNetLua.Control.MenuItem(r));
			nameSpace["MenuItem"] = typeof(GwenNetLua.Control.MenuItem);

			UserData.RegisterProxyType<GwenNetLua.Control.MenuStrip, Gwen.Control.MenuStrip>(r => new GwenNetLua.Control.MenuStrip(r));
			nameSpace["MenuStrip"] = typeof(GwenNetLua.Control.MenuStrip);

			UserData.RegisterProxyType<GwenNetLua.Control.MessageBox, Gwen.Control.MessageBox>(r => new GwenNetLua.Control.MessageBox(r));
			nameSpace["MessageBox"] = typeof(GwenNetLua.Control.MessageBox);

			UserData.RegisterProxyType<GwenNetLua.Control.MultilineTextBox, Gwen.Control.MultilineTextBox>(r => new GwenNetLua.Control.MultilineTextBox(r));
			nameSpace["MultilineTextBox"] = typeof(GwenNetLua.Control.MultilineTextBox);

			UserData.RegisterProxyType<GwenNetLua.Control.NumericUpDown, Gwen.Control.NumericUpDown>(r => new GwenNetLua.Control.NumericUpDown(r));
			nameSpace["NumericUpDown"] = typeof(GwenNetLua.Control.NumericUpDown);

			UserData.RegisterProxyType<GwenNetLua.Control.Popup, Gwen.Control.Popup>(r => new GwenNetLua.Control.Popup(r));
			nameSpace["Popup"] = typeof(GwenNetLua.Control.Popup);

			UserData.RegisterProxyType<GwenNetLua.Control.ProgressBar, Gwen.Control.ProgressBar>(r => new GwenNetLua.Control.ProgressBar(r));
			nameSpace["ProgressBar"] = typeof(GwenNetLua.Control.ProgressBar);

			UserData.RegisterProxyType<GwenNetLua.Control.RadioButton, Gwen.Control.RadioButton>(r => new GwenNetLua.Control.RadioButton(r));
			nameSpace["RadioButton"] = typeof(GwenNetLua.Control.RadioButton);

			UserData.RegisterProxyType<GwenNetLua.Control.RadioButtonGroup, Gwen.Control.RadioButtonGroup>(r => new GwenNetLua.Control.RadioButtonGroup(r));
			nameSpace["RadioButtonGroup"] = typeof(GwenNetLua.Control.RadioButtonGroup);

			UserData.RegisterProxyType<GwenNetLua.Control.RichLabel, Gwen.Control.RichLabel>(r => new GwenNetLua.Control.RichLabel(r));
			nameSpace["RichLabel"] = typeof(GwenNetLua.Control.RichLabel);

			UserData.RegisterProxyType<GwenNetLua.Control.ScrollControl, Gwen.Control.ScrollControl>(r => new GwenNetLua.Control.ScrollControl(r));
			nameSpace["ScrollControl"] = typeof(GwenNetLua.Control.ScrollControl);

			UserData.RegisterProxyType<GwenNetLua.Control.StackLayout, Gwen.Control.Layout.StackLayout>(r => new GwenNetLua.Control.StackLayout(r));
			nameSpace["StackLayout"] = typeof(GwenNetLua.Control.StackLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.StatusBar, Gwen.Control.StatusBar>(r => new GwenNetLua.Control.StatusBar(r));
			nameSpace["StatusBar"] = typeof(GwenNetLua.Control.StatusBar);

			UserData.RegisterProxyType<GwenNetLua.Control.TabControl, Gwen.Control.TabControl>(r => new GwenNetLua.Control.TabControl(r));
			nameSpace["TabControl"] = typeof(GwenNetLua.Control.TabControl);

			UserData.RegisterProxyType<GwenNetLua.Control.Table, Gwen.Control.Table>(r => new GwenNetLua.Control.Table(r));
			nameSpace["Table"] = typeof(GwenNetLua.Control.Table);

			UserData.RegisterProxyType<GwenNetLua.Control.TableRow, Gwen.Control.TableRow>(r => new GwenNetLua.Control.TableRow(r));
			nameSpace["TableRow"] = typeof(GwenNetLua.Control.TableRow);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBox, Gwen.Control.TextBox>(r => new GwenNetLua.Control.TextBox(r));
			nameSpace["TextBox"] = typeof(GwenNetLua.Control.TextBox);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBoxNumeric, Gwen.Control.TextBoxNumeric>(r => new GwenNetLua.Control.TextBoxNumeric(r));
			nameSpace["TextBoxNumeric"] = typeof(GwenNetLua.Control.TextBoxNumeric);

			UserData.RegisterProxyType<GwenNetLua.Control.TextBoxPassword, Gwen.Control.TextBoxPassword>(r => new GwenNetLua.Control.TextBoxPassword(r));
			nameSpace["TextBoxPassword"] = typeof(GwenNetLua.Control.TextBoxPassword);

			UserData.RegisterProxyType<GwenNetLua.Control.ToolWindow, Gwen.Control.ToolWindow>(r => new GwenNetLua.Control.ToolWindow(r));
			nameSpace["ToolWindow"] = typeof(GwenNetLua.Control.ToolWindow);

			UserData.RegisterProxyType<GwenNetLua.Control.TreeControl, Gwen.Control.TreeControl>(r => new GwenNetLua.Control.TreeControl(r));
			nameSpace["TreeControl"] = typeof(GwenNetLua.Control.TreeControl);

			UserData.RegisterProxyType<GwenNetLua.Control.TreeNode, Gwen.Control.TreeNode>(r => new GwenNetLua.Control.TreeNode(r));
			nameSpace["TreeNode"] = typeof(GwenNetLua.Control.TreeNode);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalLayout, Gwen.Control.Layout.VerticalLayout>(r => new GwenNetLua.Control.VerticalLayout(r));
			nameSpace["VerticalLayout"] = typeof(GwenNetLua.Control.VerticalLayout);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalSlider, Gwen.Control.VerticalSlider>(r => new GwenNetLua.Control.VerticalSlider(r));
			nameSpace["VerticalSlider"] = typeof(GwenNetLua.Control.VerticalSlider);

			UserData.RegisterProxyType<GwenNetLua.Control.VerticalSplitter, Gwen.Control.VerticalSplitter>(r => new GwenNetLua.Control.VerticalSplitter(r));
			nameSpace["VerticalSplitter"] = typeof(GwenNetLua.Control.VerticalSplitter);

			UserData.RegisterProxyType<GwenNetLua.Control.Window, Gwen.Control.Window>(r => new GwenNetLua.Control.Window(r));
			nameSpace["Window"] = typeof(GwenNetLua.Control.Window);

			// Register component types

			UserData.RegisterType<Xml.ComponentServices>();
			nameSpace["Component"] = new Xml.ComponentServices(script);

			UserData.RegisterType<Xml.LuaEvent>();
			nameSpace["Event"] = typeof(Xml.LuaEvent);

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
				end", nameSpace);

			// Protect namespace

			nameSpace.MetaTable = new Table(script);
			nameSpace.MetaTable["__metatable"] = "Read-only";
			nameSpace.MetaTable["__index"] = nameSpace;
			nameSpace.MetaTable["__newindex"] = (Action<Table, DynValue, DynValue>)((tbl, index, value) =>
			{
				throw new ScriptRuntimeException($"{index} is read-only");
			});

			// Set namespace
			
			script.Globals[uiNameSpace] = nameSpace;
		}

		public static void SetCanvas(Gwen.Control.Canvas canvas)
		{
			Table nameSpace = script.Globals[uiNameSpace] as Table;

			nameSpace["Canvas"] = new GwenNetLua.Control.Canvas(canvas);
		}

		private static string uiNameSpace;
		private static Script script;
	}
}
