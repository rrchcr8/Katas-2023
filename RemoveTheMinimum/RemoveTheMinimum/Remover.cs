using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheMinimum;

internal class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count.Equals(0)) return new List<int>();
        else
        {
            var minValue = numbers.Min();
            var index = numbers.IndexOf(minValue);
            var result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!i.Equals(index)) result.Add(numbers[i]);
            }
            return result;
        }
        
    }
}
