using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewFunctions.NewFunctions
{
    public class New_Tuple
    {
        // タプルを使って2つの戻り値を返す
        public static (int count, int sum) Tally(IEnumerable<int> items)
        {
            var count = 0;
            var sum = 0;
            foreach (var x in items)
            {
                sum += x;
                count++;
            }

            return (count, sum);
        }
    }
}
