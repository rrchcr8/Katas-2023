using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses;

public class Kata
{
    public static bool ValidParentheses(string str)
    {
        int i = 0;
        while (str.Contains("()"))
        {
            i = str.LastIndexOf("()");
            str=str.Remove(i, 2);
        }
        return str.Length.Equals(0);
    }
}