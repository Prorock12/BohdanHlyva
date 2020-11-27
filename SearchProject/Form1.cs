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
        Task task1;
        static CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token = tokenSource.Token;
        public Form1()
        {
            InitializeComponent();
            ButtonFindFile.Enabled = true;
            ButtonStopSearch.Enabled = false;
        }

        private void ButtonFindFile_Click(object sender, EventArgs e)
        {
            task1 = new Task(Search);
            paths.Clear();
            treeView1.Nodes.Clear();
            wrongDirectories.Clear();
            LBFoundFiles.Items.Clear();
            LBWrong.Items.Clear();
            ButtonFindFile.Enabled = false;
            ButtonStopSearch.Enabled = true;
            task1.Start();
        }

        private void Search()
        {
            progressBar1.Value = 0;
            string[] separateFiles = txtNeedsToFindFile.Text.Split(new char[] { ',' });
            string[] separateFormats = txtFormats.Text.Split(new char[] { ',' });
            List<string> rightFile = new List<string>();
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
                    if (numericUpDown1.Value < 2)
                    {
                        MessageBox.Show("Please select numeric bigger or equal 2");
                    }
                    else
                    {

                        foreach (string input in separateFiles)
                        {
                            foreach (string format in separateFormats)
                            {
                                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Maximum = separateFiles.Length*separateFormats.Length));
                                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Step = 1));
                                progressBar1.Invoke((MethodInvoker)(() => progressBar1.PerformStep()));
                                (rightFile, wrongDirectories) = operation.FindFile(format, input, checkedListBox1, progressBar1, token, Convert.ToInt32(numericUpDown1.Value));
                                foreach (string s in rightFile)
                                {
                                    paths.Add(s);
                                }
                            }
                        }
                    }
                }
            }
            treeView.PopulateTreeView(treeView1, paths, '\\');
            ButtonFindFile.Enabled = true;
            ButtonStopSearch.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(DriveInfo.GetDrives());
        }


        private void StopSearch_Click(object sender, EventArgs e)
        {
            ButtonFindFile.Enabled = true;
            ButtonStopSearch.Enabled = false;
            progressBar1.Value = 0;
            tokenSource.Cancel();
            CancellationTokenSource tokenSource1 = new CancellationTokenSource();
            token = tokenSource1.Token;
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