using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewFunctions.NewFunctions
{
    public static  class New_TypeSwich
    {
        public static void Hoge(object obj)
        {
            if (obj is string s)
            {
                Console.WriteLine("string #" + s.Length);
            }

            switch (obj)
            {
                case 7:
                    Console.WriteLine("7の時だけここに来る");
                    break;
                case int n when n > 0:
                    Console.WriteLine("正の数の時にここに来る " + n);
                    // ただし、上から順に判定するので、7 の時には来なくなる
                    break;
                case int n:
                    Console.WriteLine("整数の時にここに来る" + n);
                    // 同上、0 以下の時にしか来ない
                    break;
                default:
                    Console.WriteLine("その他");
                    break;
            }
        }
    }
}
