using System;
using System.Collections.Generic;

namespace ConsolidationIntoOneCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: Объединение в одну коллекцию!");

            List<string> firstGroupAthletes = new List<string>{ "Степанов", "Иванов", "Петров", "Сидоров", "Николаев", "Александров", "Владиславов" };
            List<string> secondGroupAthletes = new List<string> { "Гоголев", "Рубленов", "Сергеев", "Кузнецов", "Николаев", "Александров", "Владиславов" };

            Console.WriteLine("\n Вывод массива первой группы спортсменов = ");

            foreach (var word in firstGroupAthletes)
            {
                Console.Write(" " + word + ",");
            }

            Console.WriteLine("\n\n Вывод массива второй группы спортсменов = ");

            foreach (var word in secondGroupAthletes)
            {
                Console.Write(" " + word + ",");
            }

            for (int i = 0; i < secondGroupAthletes.Count; i++)
            {
                if (firstGroupAthletes[i] != secondGroupAthletes[i])
                {
                    firstGroupAthletes.Add(secondGroupAthletes[i]);
                }
            }

            Console.WriteLine("\n\n Вывод массива спортсменов, которые объединены в одну коллекцию  = ");

            foreach (var word in firstGroupAthletes)
            {
                Console.Write(" " + word + ",");
            }

            Console.WriteLine("");
        }
    }
}