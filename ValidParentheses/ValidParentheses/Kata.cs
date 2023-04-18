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
        while ((str = str.Replace("()", "")).Contains("()")) ;
        return str.Length == 0;
    }
}