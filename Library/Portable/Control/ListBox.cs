using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class ListBox : ScrollControl
	{
		public static new ListBox Create(Internal.ControlBase parent)
		{
			Gwen.Control.ListBox listBox = new Gwen.Control.ListBox(parent.Target);
			listBox.RowFactory = new LuaListRowFactory(listBox);
			return new ListBox(listBox);
		}

		[MoonSharpHidden]
		public static new ListBox Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new ListBox(control);
		}

		[MoonSharpHidden]
		public ListBox(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AllowMultiSelect { get { return GetTarget<Gwen.Control.ListBox>().AllowMultiSelect; } set { GetTarget<Gwen.Control.ListBox>().AllowMultiSelect = value; } }
		public bool AlternateColor { get { return GetTarget<Gwen.Control.ListBox>().AlternateColor; } set { GetTarget<Gwen.Control.ListBox>().AlternateColor = value; } }
		public bool AutoSizeColumnsToContent { get { return GetTarget<Gwen.Control.ListBox>().AutoSizeColumnsToContent; } set { GetTarget<Gwen.Control.ListBox>().AutoSizeColumnsToContent = value; } }
		public int ColumnCount { get { return GetTarget<Gwen.Control.ListBox>().ColumnCount; } set { GetTarget<Gwen.Control.ListBox>().ColumnCount = value; } }
		public string DisplayMember { get { return GetTarget<Gwen.Control.ListBox>().DisplayMember; } set { GetTarget<Gwen.Control.ListBox>().DisplayMember = value; } }
		public string[] DisplayMembers { get { return GetTarget<Gwen.Control.ListBox>().DisplayMembers; } set { GetTarget<Gwen.Control.ListBox>().DisplayMembers = value; } }
		public IEnumerable ItemsSource { get { return GetTarget<Gwen.Control.ListBox>().ItemsSource; } set { GetTarget<Gwen.Control.ListBox>().ItemsSource = value; } }
		public int RowCount { get { return GetTarget<Gwen.Control.ListBox>().RowCount; } }
		public object SelectedItem { get { return GetTarget<Gwen.Control.ListBox>().SelectedItem; } set { GetTarget<Gwen.Control.ListBox>().SelectedItem = value; } }
		public int SelectedRowIndex { get { return GetTarget<Gwen.Control.ListBox>().SelectedRowIndex; } set { GetTarget<Gwen.Control.ListBox>().SelectedRowIndex = value; } }
		public IEnumerable<int> SelectedRowIndexes { get { return GetTarget<Gwen.Control.ListBox>().SelectedRows.Select(i => GetTarget<Gwen.Control.ListBox>().GetRowIndex(i)); } }
		public bool IsToggle { get { return GetTarget<Gwen.Control.ListBox>().IsToggle; } set { GetTarget<Gwen.Control.ListBox>().IsToggle = value; } }
		public ListBoxRow SelectedRow { get { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>().SelectedRow); } set { GetTarget<Gwen.Control.ListBox>().SelectedRow = value.GetTarget<Gwen.Control.ListBoxRow>(); } }
		public IEnumerable<ListBoxRow> SelectedRows { get { return GetTarget<Gwen.Control.ListBox>().SelectedRows.Select(i => new ListBoxRow(i)); } }

		public ListBoxRow this[int index] { get { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>()[index]); } }

		public ListBoxRow AddRow(object item) { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>().AddRow(item)); }
		public ListBoxRow AddRow(string text = null, string name = "", object userData = null) { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>().AddRow(text, name, userData)); }
		public ListBoxRow InsertRow(int index, object item) { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>().InsertRow(index, item)); }
		public ListBoxRow InsertRow(int index, string text, string name = "", object userData = null) { return new ListBoxRow(GetTarget<Gwen.Control.ListBox>().InsertRow(index, text, name, userData)); }
		public void Clear() { GetTarget<Gwen.Control.ListBox>().Clear(); }
		public int GetColumnWidth(int columnIndex) { return GetTarget<Gwen.Control.ListBox>().GetColumnWidth(columnIndex); }
		public void RemoveRow(int idx) { GetTarget<Gwen.Control.ListBox>().RemoveRow(idx); }
		public void RemoveRow(object item) { GetTarget<Gwen.Control.ListBox>().RemoveRow(item); }
		public void SetColumnWidth(int columnIndex, int width) { GetTarget<Gwen.Control.ListBox>().SetColumnWidth(columnIndex, width); }
		public void SizeToContent(int maxWidth = 0) { GetTarget<Gwen.Control.ListBox>().SizeToContent(maxWidth); }
		public void SelectByName(string name, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectByName(name, clearOthers); }
		public void SelectByUserData(object userData, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectByUserData(userData, clearOthers); }
		public void SelectRow(int index, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectRow(index, clearOthers); }
		public void SelectRow(object item, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectRow(item, clearOthers); }
		public void SelectRows(string rowText, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectRows(rowText, clearOthers); }
		public void SelectRowsByRegex(string pattern, System.Text.RegularExpressions.RegexOptions regexOptions = System.Text.RegularExpressions.RegexOptions.None, bool clearOthers = false) { GetTarget<Gwen.Control.ListBox>().SelectRowsByRegex(pattern, regexOptions, clearOthers); }
		public void UnselectAll() { GetTarget<Gwen.Control.ListBox>().UnselectAll(); }
		public void SizeColumnsToContent(int maxWidth = 0) { GetTarget<Gwen.Control.ListBox>().SizeColumnsToContent(maxWidth); }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> RowDoubleClicked
		{
			add { GetTarget<Gwen.Control.ListBox>().RowDoubleClicked += value; }
			remove { GetTarget<Gwen.Control.ListBox>().RowDoubleClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> RowSelected
		{
			add { GetTarget<Gwen.Control.ListBox>().RowSelected += value; }
			remove { GetTarget<Gwen.Control.ListBox>().RowSelected -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ItemSelectedEventArgs> RowUnselected
		{
			add { GetTarget<Gwen.Control.ListBox>().RowUnselected += value; }
			remove { GetTarget<Gwen.Control.ListBox>().RowUnselected -= value; }
		}
	}

	internal class LuaListRowFactory : Gwen.Control.ListBox.ListRowFactory
	{
		public LuaListRowFactory(Gwen.Control.ListBox listBox)
			: base(listBox)
		{
		}

		public override Gwen.Control.TableRow Create(object item)
		{
			if (item == null)
				return null;
			if (item is KeyValuePair<object, object>)
				if (((KeyValuePair<object, object>)item).Value == null)
					return null;

			Gwen.Control.TableRow row = CreateRow();

			LuaTableRowFactory.SetRow(Table, row, item);

			return row;
		}
	}
}
