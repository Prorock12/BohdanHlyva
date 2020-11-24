using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchProject
{
    public class SearchOperation
    {
        public (List<string>,List<string>) FindFile(string format,string input,CheckedListBox drives)
        {
            var files = new List<string>();
            var deniedAccess = new List<string>();
            foreach (DriveInfo d in drives.CheckedItems) //DriveInfo.GetDrives().Where(x => x.IsReady == true))
            {
                if (d.IsReady)
                {
                    foreach (string directories in Directory.GetDirectories(d.RootDirectory.FullName))
                    {
                        try
                        {
                            files.AddRange(Directory.GetFiles(directories, string.Concat(input, ".", format), SearchOption.AllDirectories));
                        }
                        catch(Exception ex)
                        {
                            deniedAccess.Add(directories);
                        }
                    }
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
    }
}