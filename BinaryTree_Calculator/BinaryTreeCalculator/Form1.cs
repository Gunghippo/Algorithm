using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeCalculator
{
    public partial class BinaryTree : Form
    {
        public BinaryTree()
        {
            InitializeComponent();
        }


        public int DataTextLength;
        public string Plus = "+";
        public string Menus = "-";
        public string Muti = "*";
        public string Div = "/";

        private void GenerateTreeButton_Click(object sender, EventArgs e)
        {
            if (TreeViewData != null) TreeViewData.Nodes.Clear();
            if (string.IsNullOrEmpty(TxtData.Text)) return;
            GenerateTreeNode(inputText: TxtData.Text.Trim());
        }


        public void GenerateTreeNode(string inputText)
        {
            if (inputText == null) return;
            DataTextLength = inputText.Length - 1;
            var treeNode = CreateTreeNode(inputText: inputText);
            TreeViewData.Nodes.Add(treeNode);
        }

        private TreeNode CreateTreeNode(string inputText)
        {
            if (DataTextLength < 0) return null;
            if (!Plus.Contains(inputText[DataTextLength]) && !Menus.Contains(inputText[DataTextLength]) &&
                !Muti.Contains(inputText[DataTextLength]) && !Div.Contains(inputText[DataTextLength]))
                return new TreeNode(text: inputText[DataTextLength].ToString());
            var character = inputText[DataTextLength];
            DataTextLength -= 1;
            var treeLeft = CreateTreeNode(inputText: inputText);
            DataTextLength -= 1;
            var treeRight = CreateTreeNode(inputText: inputText);
            TreeNode[] node = null;
            if (treeLeft == null)
            {
                if (treeRight != null) node = new[] { treeRight };
            }
            else if (treeRight == null)
                node = new[] { treeLeft };
            else
                node = new[] { treeLeft, treeRight };
            return node != null ? new TreeNode(character.ToString(), node) : null;
        }

        private void TreeViewData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ResultLabel == null) return;
            ResultLabel.Text = string.Empty;
            var nodeName = TreeViewData.SelectedNode.Text;
            if (Plus.Contains(nodeName) || Menus.Contains(nodeName) ||
                Muti.Contains(nodeName) || Div.Contains(nodeName))
            {
                var node = TreeViewData.SelectedNode;
                nodeName = FindChildNode(node);
                nodeName = nodeName.Length < 6 ? nodeName.Replace('(', ' ').Replace(')', ' ').Trim() : nodeName.Substring(1, length: nodeName.Length - 2);
                var result = CalculateDataInNode(selectedNode: TreeViewData.SelectedNode);
                nodeName = nodeName + " = " + result;
                ResultLabel.Text = nodeName;
            }
            else ResultLabel.Text = nodeName;
        }

        private double CalculateDataInNode(TreeNode selectedNode)
        {
            var nodeName = selectedNode.Text;
            var amountOfNode = selectedNode.GetNodeCount(false);

            if (amountOfNode <= 0 ||
                (Plus.Contains(nodeName) && Menus.Contains(nodeName) && Muti.Contains(nodeName) &&
                 Div.Contains(nodeName))) return Convert.ToDouble(nodeName);
            switch (Convert.ToChar(nodeName))
            {
                case '+': return CalculateDataInNode(selectedNode: selectedNode.Nodes[1]) + CalculateDataInNode(selectedNode.Nodes[0]);
                case '-': return CalculateDataInNode(selectedNode: selectedNode.Nodes[1]) - CalculateDataInNode(selectedNode.Nodes[0]);
                case '*': return CalculateDataInNode(selectedNode: selectedNode.Nodes[1]) * CalculateDataInNode(selectedNode.Nodes[0]);
                case '/': return CalculateDataInNode(selectedNode: selectedNode.Nodes[1]) / CalculateDataInNode(selectedNode.Nodes[0]);
                default: return 0;
            }
            return Convert.ToDouble(nodeName);
        }

        private static string FindChildNode(TreeNode selectedNode)
        {          
            var nodeName = selectedNode.Text;
            var amountOfNode = selectedNode.GetNodeCount(false);
            if (amountOfNode > 0)
                return "(" + FindChildNode(selectedNode.Nodes[1]) + nodeName + FindChildNode(selectedNode.Nodes[0]) + ")";
            return nodeName;
        }

       
    }
}
