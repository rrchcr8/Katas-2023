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
        return array1.Distinct()
                             .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                             .OrderBy(s => s)
                             .ToArray();
    }

}
