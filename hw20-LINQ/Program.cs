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
            List<Pair<int,char>> list = new List<Pair<int, char>>();
            string num = (new Random().Next(10000, 1000000)).ToString();            
            for (int i = 0; i < num.Length; i++)
                list.Add(new Pair<int, char>(--ind, num[i]));
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
            string[] array = Console.ReadLine().Split();
            List<int> answerList = new List<int>();

            int arrayCount = (from i in array where (int.Parse(i) > 0) select i).Count();
            int sumOfNegative = array.Where(i => (int.Parse(i) < 0)).Sum(i => int.Parse(i));            
            answerList.Add(arrayCount);
            answerList.Add(sumOfNegative);

            Console.Write("ответ: [");
            foreach (int i in answerList)
                Console.Write($"{i} ");
            Console.Write("]");

            //**************//
            Console.WriteLine("\nЗадание 2.3 :  ");
            Console.WriteLine("Введите через пробел несколько слов:");
            string[] inputStream = Console.ReadLine().Split();
            List<Pair<int, string>> wordList = new List<Pair<int, string>>();
            foreach (var i in inputStream)
                wordList.Add(new Pair<int,string>(i.Length, i));
                
            var sortedWordList = from i in wordList
                                 orderby i.index
                                 select i;
            foreach (var i in sortedWordList)
                Console.Write($"{i.value} ");
            //**************//
            Console.WriteLine("\nЗадание 2.4 :  ");
            Console.ReadKey();
        }

        public class Pair<T,V>
        {
            public T index { get; set;}
            public V value { get; set; }
            public Pair(T i, V v)
            {
                index = i;
                value = v;
            }
        }
    }
}
