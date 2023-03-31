using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAreIn;

public class WhichAreIn
{
    //https://www.codewars.com/kata/550554fd08b86f84fe000a58/train/csharp
    public static string[] inArray(string[] array1, string[] array2)
    {
        var result = new HashSet<string>();
        var sorted = array1.OrderBy(x => x).ThenBy(x => x.Length);
        foreach (var item in sorted)
        {
            foreach(var item2 in array2)
            { 
                if(item2.Contains(item)) result.Add(item);
            }
        }
        return result.ToArray();
    }

}
