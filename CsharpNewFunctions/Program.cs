using System;
using System.Collections.Generic;
using CsharpNewFunctions.NewFunctions;

namespace CsharpNewFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Tuple
            var data = new[] { 1, 2, 3, 4, 5 };
            var t = New_Tuple.Tally(data);
            Console.WriteLine($"{t.sum}/{t.count}");
            #endregion

            #region 2. 分解
            //Deconstruction
            var (key, value) = new  KeyValuePair<string, int>("one", 1);
            #endregion

            #region 3.出力変数
            //3. out variable declaration 出力変数
            var p = new New_OutVar.Point { X = 1, Y = 2 };
            p.GetCoordinate(out var x, out var y);
            //out var はTryParseなどに変数宣言を省略できる。
            //C# 6.0以前の書き方
            int v6;
            var o6 = int.TryParse("100", out v6) ? v6 : 0;
            //C#7.0の書き方
            var o7 = int.TryParse("100", out var v7) ? v7 : 0 ;
            #endregion

            #region 4. 型スイッチ
            //4. Type Switch 型スイッチ
            object obj = 100;
            New_TypeSwich.Hoge(obj);
            #endregion

            #region 5. 値の破棄
            #endregion

            #region 6. 参照戻り値と参照ローカル変数

            /*戻り値とローカル変数でも参照渡しを使えるようになった。
             戻り値の型の前、値を渡す側、値を受ける側それぞれにref修飾子を付けます
             メリットは大きなデータの無駄なコピーなく扱えるようになったためパフォーマンス向上につながる*/
            var g = 10;
            var h = 20;

            // x, y のうち、大きい方の参照を返す。この例の場合 y を参照。
            ref var m = ref Max(ref g, ref h);

            // 参照の書き換えなので、その先の y が書き換わる。
            m = 0;

            Console.WriteLine($"{g}, {h}"); // 10, 0
            #endregion

            #region 7. ローカル関数
            /*関数の中に関数を書く事ができるようになった。ローカル関数は定義した関数の中だけで使用できる。
             例: A(){B()}ならB()はA()の中でした使用できない。
             パフォーマンスの面でラムダ式より最適化されているだそうだ。まぁラムダ式わかりづらいしな。
             */
            New_LocalFunction.Hoge();
            #endregion

            #region 8.非同期メソッドの戻り値に任意の方が使えるようになった

            #endregion

            #region 9. 数値リテラル
            //二進数リテラルが書けるようになった。数値リテラルの途中で「_」を挟んで区切る事ができる。
            byte bitmask = 0b1100_0000;
            Console.WriteLine(bitmask); //192が出力される。

            var magicNumber = 0xDEAD_BEEF;
            Console.WriteLine(magicNumber);// 3735928559
            Console.WriteLine(magicNumber.ToString("X"));// DEADBEEF 
            #endregion

            #region 10. throw式
            /*次の3つの場面に限って式の中にthrowが書ける
            ・ラムダ式
            ・null合体演算子
            ・条件演算子
             */
            //式 =>の直後
            void A() => throw new NotImplementedException();    //←ローカル関数
            A();
            //null合体演算子の時
            string B(object arg) => arg as string ?? throw new ArgumentException(nameof(arg));  //←ローカル関数
            B(100);
            //条件演算子の条件外(else)の時
            string C(string arg2) => arg2.Length == 0 ? "empty" :
                args.Length < 5 ? "too short" :
                throw new InvalidOperationException("too long");
            #endregion

            #region 11. 式形式メンバーの拡張
            /*メソッド、演算、プロパティ、インデクサ(get-only)に対して式が一つだけの場合=>で省略できる。*/
            New_ExpressionBodiedExtension ebe6 = new New_ExpressionBodiedExtension(6);
            New_ExpressionBodiedExtension ebe7 = new New_ExpressionBodiedExtension("7");
            #endregion

        }

        static ref int Max(ref int x, ref int y)
        {
            if (x < y) return ref y;
            else return ref x;
        }
    }
}
