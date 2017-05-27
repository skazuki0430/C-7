using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewFunctions.NewFunctions
{
    public static class New_LocalFunction
    {
        public static void Hoge()
        {
            string func(int n) => n >= 1 ? "Over 1" : "Under 1";    //ここで定義したローカル関数funcはHoge()内でしか使用できない。
            Console.WriteLine(func(5));
        }
    }
}
