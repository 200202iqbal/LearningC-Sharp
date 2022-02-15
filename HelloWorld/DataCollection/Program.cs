using System;
using System.Collections.Generic;
namespace DataCollection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var names = new List<string> { "<names>", "Ana", "Felipe" };
            
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            names.Add("Iqbal");

            Show(names);

            var index = names.IndexOf("Felipe");
            if(index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item  is not found, IndexOf  returns {notFound}");

            Console.Write("Search name : ");
            var searchName = Console.ReadLine();
            int indexOfList = names.IndexOf(searchName);
            SearchIndex(names, indexOfList);

            Console.WriteLine("Sort list of names");
            names.Sort();

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };
            int fibonacciNumberUrutanKe = 20;
            int fibonacciNumbersCount = fibonacciNumbers.Count;


            for(int i = 0; i <  fibonacciNumberUrutanKe - fibonacciNumbersCount; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
                
            }

            var fibonacciNumbers2 = new List<int> { 1, 1 };
            while (fibonacciNumbers2.Count < 20)
            {
                var previous2 = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                var previous22 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];
                fibonacciNumbers2.Add(previous2 + previous22);
            }
            
            for(int i = 0; i < fibonacciNumbers.Count; i++)
            {
                Console.WriteLine($"Number of {i+1}, fibonacci number {fibonacciNumbers[i]}");
                Console.WriteLine($"Number of {i + 1}, fibonacci number {fibonacciNumbers2[i]}");
                Console.ReadKey();
            }
            
        }


        public static void Show(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it");
        }

        public static void SearchIndex(List<string> list, int index)
        {
            if(index != -1)
            {
                Console.WriteLine($"The name {list[index]} is at index {index}");
            }else
            {
                Console.WriteLine("Item is not found");
            }
        }
    }
}
