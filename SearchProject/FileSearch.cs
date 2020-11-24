using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProject
{
    public class FileSearch
    {
        public bool FindTXT(string path,string foundText)
        {
            try
            {
                int count;
                if (path.EndsWith("txt") ||
                path.EndsWith("ini") || path.EndsWith("bat") ||
                path.EndsWith("cmd") || path.EndsWith("js") ||
                path.EndsWith("cs") || path.EndsWith("xml"))
                {
                    count = File.ReadLines(path).
                    TakeWhile(line => line.Contains(foundText)).Count();
                }
                else
                {
                    count = 0;
                }
                return (count != 0) ? true : false;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
