using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchProject
{
    public class TreeViewOperation
    {
        public void PopulateTreeView(TreeView treeView, IEnumerable<string> paths, char pathSeparator)
        {
            TreeNode lastNode = null;
            string subPathAgg;
            foreach (string path in paths)
            {
                subPathAgg = string.Empty;
                foreach (string subPath in path.Split(pathSeparator))
                {
                    subPathAgg += subPath + pathSeparator;
                    TreeNode[] nodes = treeView.Nodes.Find(subPathAgg, true);
                    if (nodes.Length == 0)
                    {
                        if (lastNode == null)
                        {
                            treeView.Invoke((MethodInvoker)delegate ()
                            {
                                lastNode = treeView.Nodes.Add(subPathAgg, subPath);
                            });
                        }
                        else
                        {
                            treeView.Invoke((MethodInvoker)delegate ()
                            {
                                lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                            });             
                        }
                    }
                    else
                        lastNode = nodes[0];
                }
                lastNode = null;
            }
        }
    }
}
