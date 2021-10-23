using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            #region problem1
            // int num = 348597;

            // int[] result1 = num.ToString().Reverse().Select(p => (int)(p - 48)).ToArray();
            // foreach(int i in result1)
            //     System.Console.Write(i);
            #endregion

            #region problem2
            //int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};
            // int[] result = new int[2] { arr.Count((i) => i > 0), arr.Where((el) => el < 0).Sum()};
            
            //System.Console.WriteLine($"{result[0]} {result[1]}");
            #endregion

            #region problem3
            // string[] arr1 = {"Telescopes", "Glasses", "Eyes", "Monocles"};

            // string[] result = arr1.OrderByDescending(p => p.Length).Reverse().ToArray();
            
            // foreach(string s in result)
            //     System.Console.WriteLine(s);
            #endregion
        }
    }
}
