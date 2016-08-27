using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Menu : Internal.ControlBase
	{
		public static Menu Create(Internal.ControlBase parent)
		{
			return new Menu(new Gwen.Control.Menu(parent.Target));
		}

		[MoonSharpHidden]
		public static Menu Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Menu(control);
		}

		[MoonSharpHidden]
		public Menu(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool DeleteOnClose { get { return GetTarget<Gwen.Control.Menu>().DeleteOnClose; } set { GetTarget<Gwen.Control.Menu>().DeleteOnClose = value; } }
		public bool IconMarginDisabled { get { return GetTarget<Gwen.Control.Menu>().IconMarginDisabled; } set { GetTarget<Gwen.Control.Menu>().IconMarginDisabled = value; } }
		public MenuItem ParentMenuItem { get { return MenuItem.Create(GetTarget<Gwen.Control.Menu>().ParentMenuItem); } }

		public void AddDivider() { GetTarget<Gwen.Control.Menu>().AddDivider(); }
		public void AddItem(MenuItem item) { GetTarget<Gwen.Control.Menu>().AddItem(item.GetTarget<Gwen.Control.MenuItem>()); }
		public MenuItem AddItem(string text, string iconName, string accelerator = null) { return MenuItem.Create(GetTarget<Gwen.Control.Menu>().AddItem(text, iconName, accelerator)); }
		public void CloseMenus() { GetTarget<Gwen.Control.Menu>().CloseMenus(); }
		public bool IsMenuOpen() { return GetTarget<Gwen.Control.Menu>().IsMenuOpen(); }
		public void Open() { GetTarget<Gwen.Control.Menu>().Open(); }
		public void RemoveAll() { GetTarget<Gwen.Control.Menu>().RemoveAll(); }
	}
}
