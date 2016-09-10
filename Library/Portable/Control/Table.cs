using System;
using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class Table : Internal.ControlBase
	{
		public static Table Create(Internal.ControlBase parent)
		{
			Gwen.Control.Table table = new Gwen.Control.Table(parent.Target);
			table.RowFactory = new LuaTableRowFactory(table);
			return new Table(table);
		}

		[MoonSharpHidden]
		public static Table Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new Table(control);
		}

		[MoonSharpHidden]
		public Table(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AlternateColor { get { return GetTarget<Gwen.Control.Table>().AlternateColor; } set { GetTarget<Gwen.Control.Table>().AlternateColor = value; } }
		public bool AutoSizeColumnsToContent { get { return GetTarget<Gwen.Control.Table>().AutoSizeColumnsToContent; } set { GetTarget<Gwen.Control.Table>().AutoSizeColumnsToContent = value; } }
		public int ColumnCount { get { return GetTarget<Gwen.Control.Table>().ColumnCount; } set { GetTarget<Gwen.Control.Table>().ColumnCount = value; } }
		public string DisplayMember { get { return GetTarget<Gwen.Control.Table>().DisplayMember; } set { GetTarget<Gwen.Control.Table>().DisplayMember = value; } }
		public string[] DisplayMembers { get { return GetTarget<Gwen.Control.Table>().DisplayMembers; } set { GetTarget<Gwen.Control.Table>().DisplayMembers = value; } }
		public IEnumerable ItemsSource { get { return GetTarget<Gwen.Control.Table>().ItemsSource; } set { GetTarget<Gwen.Control.Table>().ItemsSource = value; } }
		public int RowCount { get { return GetTarget<Gwen.Control.Table>().RowCount; } }

		public int AddRow(object item) { return GetTarget<Gwen.Control.Table>().GetRowIndex(GetTarget<Gwen.Control.Table>().AddRow(item)); }
		public int AddRow(string text = null, string name = "", object userData = null) { return GetTarget<Gwen.Control.Table>().GetRowIndex(GetTarget<Gwen.Control.Table>().AddRow(text, name, userData)); }
		public void Clear() { GetTarget<Gwen.Control.Table>().Clear(); }
		public int GetColumnWidth(int columnIndex) { return GetTarget<Gwen.Control.Table>().GetColumnWidth(columnIndex); }
		public int InsertRow(int index, object item) { return GetTarget<Gwen.Control.Table>().GetRowIndex(GetTarget<Gwen.Control.Table>().InsertRow(index, item)); }
		public int InsertRow(int index, string text, string name = "", object userData = null) { return GetTarget<Gwen.Control.Table>().GetRowIndex(GetTarget<Gwen.Control.Table>().InsertRow(index, text, name, userData)); }
		public void RemoveRow(int idx) { GetTarget<Gwen.Control.Table>().RemoveRow(idx); }
		public void RemoveRow(object item) { GetTarget<Gwen.Control.Table>().RemoveRow(item); }
		public void SetColumnWidth(int columnIndex, int width) { GetTarget<Gwen.Control.Table>().SetColumnWidth(columnIndex, width); }
		public void SizeColumnsToContent(int maxWidth = 0) { GetTarget<Gwen.Control.Table>().SizeColumnsToContent(maxWidth); }
	}

	internal class LuaTableRowFactory : Gwen.Control.Table.TableRowFactory
	{
		public LuaTableRowFactory(Gwen.Control.Table table)
			: base(table)
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

			SetRow(Table, row, item);

			return row;
		}

		public static void SetRow(Gwen.Control.Table table, Gwen.Control.TableRow row, object item)
		{
			string[] displayMembers = table.DisplayMembers;

			if (displayMembers == null || displayMembers.Length == 0)
			{
				string text = item.ToString();
				row.Text = text;
				row.Name = text;
				row.UserData = item;
			}
			else
			{
				if (!(item is KeyValuePair<object, object>))
					throw new ScriptRuntimeException("Expecting table item");

				var keyValuePair = (KeyValuePair<object, object>)item;

				MoonSharp.Interpreter.Table luaTable = keyValuePair.Value as MoonSharp.Interpreter.Table;
				if (luaTable == null)
					throw new ScriptRuntimeException("Expecting table");

				string col = luaTable[displayMembers[0]].ToString();
				row.Name = col;
				row.UserData = item;
				row.SetCellText(0, col);

				for (int i = 1; i < displayMembers.Length; i++)
				{
					row.SetCellText(i, luaTable[displayMembers[i]].ToString());
				}
			}
		}
	}
}
