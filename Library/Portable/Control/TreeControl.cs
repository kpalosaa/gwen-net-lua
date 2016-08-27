using System;
using System.Collections;
using MoonSharp.Interpreter;

namespace GwenNetLua.Control
{
	public class TreeControl : Internal.ControlBase
	{
		public static TreeControl Create(Internal.ControlBase parent)
		{
			return new TreeControl(new Gwen.Control.TreeControl(parent.Target));
		}

		[MoonSharpHidden]
		public static TreeControl Create(Gwen.Control.ControlBase control)
		{
			if (control == null)
				return null;
			else
				return new TreeControl(control);
		}

		[MoonSharpHidden]
		public TreeControl(Gwen.Control.ControlBase control)
			: base(control)
		{
		}

		public bool AllowMultiSelect { get { return GetTarget<Gwen.Control.TreeControl>().AllowMultiSelect; } set { GetTarget<Gwen.Control.TreeControl>().AllowMultiSelect = value; } }
		public TreeNode RootNode { get { return TreeNode.Create(GetTarget<Gwen.Control.TreeControl>().RootNode); } }
		public TreeNode SelectedNode { get { return TreeNode.Create(GetTarget<Gwen.Control.TreeControl>().SelectedNode); } }
		public IEnumerable SelectedNodes { get { return GetTarget<Gwen.Control.TreeControl>().SelectedNodes; } }

		public TreeNode AddNode(string label, string name = null, object userData = null) { return TreeNode.Create(GetTarget<Gwen.Control.TreeControl>().AddNode(label, name, userData)); }
		public void ExpandAll() { GetTarget<Gwen.Control.TreeControl>().ExpandAll(); }
		public TreeNode FindNodeByName(string name, bool recursive = true) { return TreeNode.Create(GetTarget<Gwen.Control.TreeControl>().FindNodeByName(name, recursive)); }
		public TreeNode FindNodeByUserData(object userData, bool recursive = true) { return TreeNode.Create(GetTarget<Gwen.Control.TreeControl>().FindNodeByUserData(userData, recursive)); }
		public void RemoveAll() { GetTarget<Gwen.Control.TreeControl>().RemoveAll(); }
		public void RemoveAllNodes() { GetTarget<Gwen.Control.TreeControl>().RemoveAllNodes(); }
		public void RemoveNode(TreeNode node) { GetTarget<Gwen.Control.TreeControl>().RemoveNode(node.GetTarget<Gwen.Control.TreeNode>()); }
		public void UnselectAll() { GetTarget<Gwen.Control.TreeControl>().UnselectAll(); }

		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Collapsed
		{
			add { GetTarget<Gwen.Control.TreeControl>().Collapsed += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().Collapsed -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Expanded
		{
			add { GetTarget<Gwen.Control.TreeControl>().Expanded += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().Expanded -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> NodeDoubleClicked
		{
			add { GetTarget<Gwen.Control.TreeControl>().NodeDoubleClicked += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().NodeDoubleClicked -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Selected
		{
			add { GetTarget<Gwen.Control.TreeControl>().Selected += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().Selected -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> SelectionChanged
		{
			add { GetTarget<Gwen.Control.TreeControl>().SelectionChanged += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().SelectionChanged -= value; }
		}
		public event Gwen.Control.ControlBase.GwenEventHandler<EventArgs> Unselected
		{
			add { GetTarget<Gwen.Control.TreeControl>().Unselected += value; }
			remove { GetTarget<Gwen.Control.TreeControl>().Unselected -= value; }
		}
	}
}
