using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger;

public class Solution
{
    public int MyAtoi(string s)
    {
        int result = 0;
        char sign = '+';
        Dictionary<char, int> nums =
                     new Dictionary<char, int>();

        nums.Add('0', 0);
        nums.Add('1', 1);
        nums.Add('2', 2);
        nums.Add('3', 3);
        nums.Add('4', 4);
        nums.Add('5', 5);
        nums.Add('6', 6);
        nums.Add('7', 7);
        nums.Add('8', 8);
        nums.Add('9', 9);
        s = s.Trim();
        var arr = s.ToCharArray();
        var arrLinted = new List<char>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0 && (arr[i].Equals('+') || arr[i].Equals('-')))
            {
                arrLinted.Add(arr[i]);
            }
            else if (!nums.ContainsKey(arr[0]) && !(arr[0].Equals('+') || arr[0].Equals('-')))
            {
                return 0;
            }
            if (nums.ContainsKey(arr[i]))
            {
                arrLinted.Add(arr[i]);
            }
        }
        if (arrLinted.First().Equals('+') || arrLinted.First().Equals('-'))
        {
            sign = arrLinted.First();
            arrLinted.RemoveAt(0);
        }
        var arrLinted2 = arrLinted.ToArray();
        for (int j = 0; j < arrLinted2.Length; j++)
        {
            if(result+ nums[arrLinted2[j]] * Math.Pow(10, (arrLinted2.Length - j - 1))<=Int32.MinValue
                )
            result = (int)(result + nums[arrLinted2[j]] * Math.Pow(10, (arrLinted2.Length - j - 1)));
        }
        if (sign.Equals('-'))
        {
            result = result * (-1);

        }
        return result;

    }
}
