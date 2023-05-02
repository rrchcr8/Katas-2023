using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
   public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c is '(' or '{' or '[')
                    stack.Push(c);
                if (c is '}' or ')' or ']')
                {
                    if (stack.Count > 0)
                    {
                        var peek = stack.Pop();

                        if (peek == '(' && c != ')'
                            || peek == '{' && c != '}'
                            || peek == '[' && c != ']')
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
