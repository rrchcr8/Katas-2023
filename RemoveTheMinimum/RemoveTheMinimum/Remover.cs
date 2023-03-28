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
        numbers.Remove(numbers.DefaultIfEmpty().Min());
        return numbers;

    }
}
