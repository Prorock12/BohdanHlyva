using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchProject
{
    public partial class Form1 : Form
    {
        SearchOperation operation = new SearchOperation();
        TreeViewOperation treeView = new TreeViewOperation();
        FileSearch fileSearch = new FileSearch();
        List<string> paths = new List<string>();
        List<string> wrongDirectories = new List<string>();
        Thread task1;
        bool IsStopThread = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonFindFile_Click(object sender, EventArgs e)
        {
            IsStopThread = false;
            task1 = new Thread(Search);
            paths.Clear();
            wrongDirectories.Clear();
            LBFoundFiles.Items.Clear();
            LBWrong.Items.Clear();
            task1.Start();
        }

        private void Search()
        {
            int index = 0;
            progressBar1.Value = 0;
            string[] separateFiles = txtNeedsToFindFile.Text.Split(new char[] { ',' });
            string[] separateFormats = txtFormats.Text.Split(new char[] { ',' });
            List<string> rightFile = new List<string>();
            //List<string> wrongDirectories = new List<string>();
            if (string.IsNullOrEmpty(txtFormats.Text))
            {
                MessageBox.Show("Please enter formats");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNeedsToFindFile.Text))
                {
                    MessageBox.Show("Please enter files name");
                }
                else
                {
                    foreach (string input in separateFiles)
                    {
                        foreach (string format in separateFormats)
                        {
                            (rightFile, wrongDirectories) = operation.FindFile(format, input, checkedListBox1);
                            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Maximum = separateFiles.Length * separateFormats.Length * rightFile.Count())); // + wrongDirectories.Count())));
                            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Step = 1));
                            if (IsStopThread)
                            {
                                return;
                            }
                            foreach (string s in rightFile)
                            {
                                progressBar1.Invoke((MethodInvoker)(() => progressBar1.PerformStep()));
                                paths.Add(s);
                            }
                            //foreach (string s in wrongDirectories)
                            //{
                            //    progressBar1.Invoke((MethodInvoker)(() => progressBar1.PerformStep()));
                            //    wrongPaths.Add(s);
                            //}
                        }
                    }
                }
            }
            treeView.PopulateTreeView(treeView1, paths, '\\');
            //foreach (string s in paths)
            //{
            //    if (fileSearch.FindTXT(s))
            //    {
            //        LBFoundFiles.Invoke((MethodInvoker)(() => LBFoundFiles.Items.Add(s)));
            //    }
            //    else
            //    {
            //        LBWrong.Invoke((MethodInvoker)(() => LBWrong.Items.Add(s)));
            //    }
            //}
            //LBWrong.Invoke((MethodInvoker)(() => LBWrong.Items.AddRange(wrongDirectories.ToArray())));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(DriveInfo.GetDrives());
        }


        private void StopSearch_Click(object sender, EventArgs e)
        {
            if (task1.IsAlive)
            {
                progressBar1.Value = 0;
                IsStopThread = true;
            }
        }

        private void FindTextInFile_Click(object sender, EventArgs e)
        {
            LBFoundFiles.Items.Clear();
            LBWrong.Items.Clear();
            if (string.IsNullOrEmpty(txtFindTextInFile.Text))
            {
                MessageBox.Show("Please enter some text");
            }
            else
            {
                foreach (string s in paths)
                {

                    if (fileSearch.FindTXT(s, txtFindTextInFile.Text))
                    {
                        LBFoundFiles.Invoke((MethodInvoker)(() => LBFoundFiles.Items.Add(s)));
                    }
                    else
                    {
                        LBWrong.Invoke((MethodInvoker)(() => LBWrong.Items.Add(s)));
                    }
                }
            }
            LBWrong.Invoke((MethodInvoker)(() => LBWrong.Items.AddRange(wrongDirectories.ToArray())));
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.FullPath.EndsWith("txt") ||
                node.FullPath.EndsWith("ini") || node.FullPath.EndsWith("bat") ||
                node.FullPath.EndsWith("cmd") || node.FullPath.EndsWith("js") ||
                node.FullPath.EndsWith("cs") || node.FullPath.EndsWith("xml"))
            {
                Process.Start(@"cmd.exe ", @"/c" + node.FullPath);
            }
        }

        private void LBFoundFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string result = LBFoundFiles.SelectedItem.ToString();
            Process.Start(@"cmd.exe ", @"/c" + result);
        }
    }
}