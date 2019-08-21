using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekApp0215
{
    static class Extensions
    {
        public static bool IsEmpty(string[]arr, string text)
        {
            foreach(var arrList in arr)
            {
                if (arrList == text)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
