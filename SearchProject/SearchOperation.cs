using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchProject
{
    public class SearchOperation
    {
        static int number;
        public (List<string>,List<string>) FindFile(string format,string input,CheckedListBox drives, ProgressBar progressBar1, CancellationToken token,int index)
        {
            var files = new List<string>();
            var count = new List<string>();
            var deniedAccess = new List<string>();
            foreach (DriveInfo d in drives.CheckedItems)
            {
                if (d.IsReady)
                {
                    number = 2;
                    GetFiles(d.RootDirectory.FullName, input, format, ref files, ref deniedAccess, progressBar1, token, index);
                }
                else
                {
                    files.Add(d.RootDirectory.FullName + "Is no ready");
                    return (files,deniedAccess);
                }
            }
            if (files.Count == 0) 
            {
                files.Add($"File({input}.{format}) not exist");
                return (files, deniedAccess);
            }
            else
            {
                return (files, deniedAccess);
            }
        }
        private void GetFiles(string path, string input, string format, ref List<string> files, ref List<string> deniedAccess,ProgressBar progressBar1,CancellationToken token,int index)
        {
            files.AddRange(Directory.GetFiles(path, string.Concat(input, ".", format)));
            foreach (string directories in Directory.GetDirectories(path))
            {
                try
                {
                    //progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value += 1));
                    files.AddRange(Directory.GetFiles(directories, string.Concat(input, ".", format)));
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция прервана");
                        return;
                    }
                    if (index > number)
                    {
                        number++;
                        GetFiles(directories, input, format, ref files, ref deniedAccess, progressBar1, token, index);
                    }
                }
                catch (Exception ex)
                {
                    deniedAccess.Add(directories);
                }
            }
            number--;
        }
    }
}