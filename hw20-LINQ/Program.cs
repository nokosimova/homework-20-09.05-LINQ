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
        {
            
            //**************//
            Console.WriteLine("Задание 2.1 :  ");
            int number = new Random().Next(10000, 1000000);
            var answer = number.ToString().ToCharArray().Reverse();

            Console.WriteLine($"число: {number}");
            Console.Write("результат: [");
            foreach (var item in answer)
                Console.Write($"{item} ");
            Console.WriteLine("]");

            //***************//
            Console.WriteLine("Задание 2.2 :  ");
            Console.WriteLine("Введите через пробел массив целых чисел:");
            string[] array = Console.ReadLine().Split();
            List<int> answerList = new List<int>();

            int positiveCount = array.Where(i => int.Parse(i) > 0).Count();
            int negativeSum = array.Where(i => (int.Parse(i) < 0)).Sum(i => int.Parse(i));
            answerList.Add(positiveCount);
            answerList.Add(negativeSum);

            Console.WriteLine($"ответ: [{answerList[0]},  {answerList[1]}]");
          
            //**************//
            Console.WriteLine("\nЗадание 2.3 :  ");
            Console.WriteLine("Введите через пробел несколько слов:");
            string[] inputStream = Console.ReadLine().Split();
            var answer2 = inputStream.OrderBy(i => i.Length);
            Console.Write("ответ: ");
            foreach (var i in answer2)
                Console.Write($"{i} ");

            //**************//
            Console.WriteLine("\nЗадание 2.4 :  ");
            Console.WriteLine("Введите через пробел массив целых чисел в котором все элементы равны, кроме одного:");
            string[] arr = Console.ReadLine().Split();
            var answer3 = arr.First(i => i != (arr.First())) == arr.Last(i => i != (arr.First())) ?
                arr.First(i => i != (arr.First())) : arr.First();
            Console.Write($"белая ворона - это число {answer3}");
            Console.ReadKey();
        }
    }
}