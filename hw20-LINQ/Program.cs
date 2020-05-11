using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace hw20_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {   //**************//
            Console.WriteLine("Задание 2.1 :  ");
            int ind = 0;
            string num = (new Random().Next(10000, 1000000)).ToString();
            List<Pair> list = new List<Pair>();
            for (int i = 0; i < num.Length; i++)
                list.Add(new Pair(--ind, num[i]));
            var answer = from i in list
                         orderby i.index
                         select i;
            Console.WriteLine($"число: {num}");
            Console.Write("ответ: ");
            foreach (var i in answer)
                Console.Write($"{i.value} ");
            Thread.Sleep(3000);
            //***************//
            Console.WriteLine("\nЗадание 2.2 :  ");
            Console.WriteLine("Введите через пробел массив целых чисел:");

            //**************//
            Console.WriteLine("Задание 2.3 :  ");


            //**************//
            Console.WriteLine("Задание 2.4 :  ");
            Console.ReadKey();
        }

        public class Pair
        {
            public int index { get; set;}
            public char value { get; set; }
            public Pair(int i, char v)
            {
                index = i;
                value = v;
            }
        }
    }
}
