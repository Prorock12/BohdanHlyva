using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class StringOperation
    {
        public string AddSplit(string input)
        {
            string result = null;
            int index = 0;
            foreach(char ch in input)
            {
                if(index==4)
                {
                    result += "-";
                    index = 0;
                }
                result += ch;
                index++;
            }
            return result;
        }
        public string RemoveSplit(string input)
        {
            string result = null;
            int index = 0;
            foreach (char ch in input)
            {
                if (index == 4)
                {
                    index = 0;
                    continue;
                }
                result += ch;
                index++;
            }
            return result;
        }
    }
}
