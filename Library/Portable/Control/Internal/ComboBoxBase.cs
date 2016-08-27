using System;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control.Internal
{
	public class ComboBoxBase : Internal.ButtonBase
	{
		[MoonSharpHidden]
		public ComboBoxBase(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public int SelectedIndex { get { return GetTarget<Gwen.Control.Internal.ComboBoxBase>().SelectedIndex; } set { GetTarget<Gwen.Control.Internal.ComboBoxBase>().SelectedIndex = value; } }

		public void AddItem(string label, string name = null, object userData = null) { GetTarget<Gwen.Control.Internal.ComboBoxBase>().AddItem(label, name, userData); }
		public void Close() { GetTarget<Gwen.Control.Internal.ComboBoxBase>().Close(); }
		public void Open() { GetTarget<Gwen.Control.Internal.ComboBoxBase>().Open(); }
		public void RemoveAll() { GetTarget<Gwen.Control.Internal.ComboBoxBase>().RemoveAll(); }
		public void SelectByName(string name) { GetTarget<Gwen.Control.Internal.ComboBoxBase>().SelectByName(name); }
		public void SelectByText(string text) { GetTarget<Gwen.Control.Internal.ComboBoxBase>().SelectByText(text); }
		public void SelectByUserData(object userdata) { GetTarget<Gwen.Control.Internal.ComboBoxBase>().SelectByUserData(userdata); }
		public void SetSelection(int index) { GetTarget<Gwen.Control.Internal.ComboBoxBase>().SetSelection(index); }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> ItemSelected
		{
			add { GetTarget<Gwen.Control.Internal.ComboBoxBase>().ItemSelected += value; }
			remove { GetTarget<Gwen.Control.Internal.ComboBoxBase>().ItemSelected -= value; }
		}
	}
}
