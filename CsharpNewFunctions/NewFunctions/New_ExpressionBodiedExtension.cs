using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewFunctions.NewFunctions
{
    public class New_ExpressionBodiedExtension
    {
        public int CsharpVersion { get; set; }
        //C# 6.0以前
        public New_ExpressionBodiedExtension(int ver)
        {
            this.CsharpVersion = ver;
        }
        //C#7.0以降
        public New_ExpressionBodiedExtension(string ver)=>this.CsharpVersion=int.TryParse(ver,out var result)?result:0;

    }
}
