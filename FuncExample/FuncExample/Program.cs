﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FuncExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(1, 2));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000);
            Func<int>getRandomNumber2=()=>new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
