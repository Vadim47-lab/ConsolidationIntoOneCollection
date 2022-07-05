using System;
using System.Collections.Generic;

namespace ConsolidationIntoOneCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateCollection();
        }

        private void CreateCollection()
        {
            Console.WriteLine(" Добро пожаловать в программу: Объединение в одну коллекцию!");

            List<string> firstGroupAthletes = new List<string> { "Степанов", "Иванов", "Петров", "Сидоров", "Николаев", "Александров", "Владиславов" };
            List<string> secondGroupAthletes = new List<string> { "Гоголев", "Рубленов", "Сергеев", "Кузнецов", "Николаев", "Александров", "Владиславов" };
            List<string> listCollection = new List<string>();

            Console.WriteLine("\n Вывод массива первой группы спортсменов = ");

            ShowDescription(firstGroupAthletes);

            Console.WriteLine("\n\n Вывод массива второй группы спортсменов = ");

            ShowDescription(secondGroupAthletes);

            foreach (var word in firstGroupAthletes)
            {
                listCollection.Add(word);
            }

            for (int i = 0; i < secondGroupAthletes.Count; i++)
            {
                if (listCollection[i] != secondGroupAthletes[i])
                {
                    listCollection.Add(secondGroupAthletes[i]);
                }
            }

            Console.WriteLine("\n\n Вывод массива спортсменов, которые объединены в одну коллекцию  = ");

            ShowDescription(listCollection);

            Console.WriteLine("");
        }

        private void ShowDescription(List<string> list)
        {
            foreach (var word in list)
            {
                Console.Write(" " + word + ",");
            }
        }
    }
}