﻿using System;
using System.Collections.Generic;
using System.Text;
using AlgsImp.Sort;
using System.Diagnostics;
using AlgsImp.Search;
using AlgsImp.Miscellaneous;

namespace AlgsImp
{
    class Program
    {
        Stopwatch sw = new Stopwatch();
        static int[] A1 = new int[10]{4,1,3,2,16,9,10,14,8,7};
        static int[] A3 = new int[5] { 5,2,8,9,33};
        static double[] A2 = new double[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args) 
        {
            //BackTrack<int>.Test1();
            ArrayRemove<int>.Test();
            Console.Read();
        }
        static void Main2(string[] args)
        {
           

        }
      
    }
}
