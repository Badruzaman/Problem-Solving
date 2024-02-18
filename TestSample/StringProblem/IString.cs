using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample.StringProblem
{
    internal interface IString
    {
        internal static string removeDuplicateWord(string str)
        {
            string[] words = str.Split(' ');
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            HashSet<string> hs = new HashSet<string>();
            foreach (string word in words)
            {
                if (!hs.Contains(word))
                {
                    hs.Add(word);
                }
            }
            var result = string.Join(" ", hs.ToArray());
            return result;
        }
        
    }
}
