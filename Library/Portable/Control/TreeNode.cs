using System;
using System.Collections;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TreeNode : Internal.ControlBase
	{
		public static TreeNode Create(Internal.ControlBase parent)
		{
			return new TreeNode(new Gwen.Control.TreeNode(parent.Target));
		}

		[MoonSharpHidden]
		public static TreeNode Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new TreeNode(control);
		}

		[MoonSharpHidden]
		public TreeNode(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool IsRoot { get { return GetTarget<Gwen.Control.TreeNode>().IsRoot; } }
		public bool IsSelectable { get { return GetTarget<Gwen.Control.TreeNode>().IsSelectable; } set { GetTarget<Gwen.Control.TreeNode>().IsSelectable = value; } }
		public bool IsSelected { get { return GetTarget<Gwen.Control.TreeNode>().IsSelected; } set { GetTarget<Gwen.Control.TreeNode>().IsSelected = value; } }
		public int NodeCount { get { return GetTarget<Gwen.Control.TreeNode>().NodeCount; } }
		public IEnumerable SelectedChildren { get { return GetTarget<Gwen.Control.TreeNode>().SelectedChildren; } }
		public string Text { get { return GetTarget<Gwen.Control.TreeNode>().Text; } set { GetTarget<Gwen.Control.TreeNode>().Text = value; } }
		public TreeControl TreeControl { get { return TreeControl.Create(GetTarget<Gwen.Control.TreeNode>().TreeControl); } }
		public string ImageName { get { return GetTarget<Gwen.Control.TreeNode>().ImageName; } set { GetTarget<Gwen.Control.TreeNode>().ImageName = value; } }

		public TreeNode AddNode(string label, string name = null, object userData = null) { return TreeNode.Create(GetTarget<Gwen.Control.TreeNode>().AddNode(label, name, userData)); }
		public void Close() { GetTarget<Gwen.Control.TreeNode>().Close(); }
		public void ExpandAll() { GetTarget<Gwen.Control.TreeNode>().ExpandAll(); }
		public TreeNode FindNodeByName(string name, bool recursive = true) { return TreeNode.Create(GetTarget<Gwen.Control.TreeNode>().FindNodeByName(name, recursive)); }
		public TreeNode FindNodeByUserData(object userData, bool recursive = true) { return TreeNode.Create(GetTarget<Gwen.Control.TreeNode>().FindNodeByUserData(userData, recursive)); }
		public TreeNode InsertNode(int index, string label, string name = null, object userData = null) { return TreeNode.Create(GetTarget<Gwen.Control.TreeNode>().InsertNode(index, label, name, userData)); }
		public void Open() { GetTarget<Gwen.Control.TreeNode>().Open(); }
		public void RemoveAllNodes() { GetTarget<Gwen.Control.TreeNode>().RemoveAllNodes(); }
		public void RemoveNode(TreeNode node) { GetTarget<Gwen.Control.TreeNode>().RemoveNode(node.GetTarget<Gwen.Control.TreeNode>()); }
		public void UnselectAll() { GetTarget<Gwen.Control.TreeNode>().UnselectAll(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> Clicked
		{
			add { GetTarget<Gwen.Control.TreeNode>().Clicked += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().Clicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Collapsed
		{
			add { GetTarget<Gwen.Control.TreeNode>().Collapsed += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().Collapsed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> DoubleClicked
		{
			add { GetTarget<Gwen.Control.TreeNode>().DoubleClicked += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().DoubleClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> DoubleRightClicked
		{
			add { GetTarget<Gwen.Control.TreeNode>().DoubleRightClicked += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().DoubleRightClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Expanded
		{
			add { GetTarget<Gwen.Control.TreeNode>().Expanded += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().Expanded -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> LabelPressed
		{
			add { GetTarget<Gwen.Control.TreeNode>().LabelPressed += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().LabelPressed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> NodeDoubleClicked
		{
			add { GetTarget<Gwen.Control.TreeNode>().NodeDoubleClicked += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().NodeDoubleClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<Gwen.Control.ClickedEventArgs> RightClicked
		{
			add { GetTarget<Gwen.Control.TreeNode>().RightClicked += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().RightClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Selected
		{
			add { GetTarget<Gwen.Control.TreeNode>().Selected += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().Selected -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> SelectionChanged
		{
			add { GetTarget<Gwen.Control.TreeNode>().SelectionChanged += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().SelectionChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Unselected
		{
			add { GetTarget<Gwen.Control.TreeNode>().Unselected += value; }
			remove { GetTarget<Gwen.Control.TreeNode>().Unselected -= value; }
		}
	}
}
