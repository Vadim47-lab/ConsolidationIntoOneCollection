using System;
using System.Collections.Generic;

namespace ConsolidationIntoOneCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Work();
        }

        private void Work()
        {
            Console.WriteLine(" Добро пожаловать в программу: Объединение в одну коллекцию!");

            List<string> firstGroupAthletes = new List<string> { "Степанов", "Иванов", "Петров", "Сидоров", "Николаев", "Александров", "Владиславов" };
            List<string> secondGroupAthletes = new List<string> { "Гоголев", "Рубленов", "Сергеев", "Кузнецов", "Николаев", "Александров", "Владиславов" };
            HashSet<string> listCollection = new HashSet<string>();

            Console.WriteLine("\n Вывод массива первой группы спортсменов = ");

            ShowDescription(firstGroupAthletes);

            Console.WriteLine("\n\n Вывод массива второй группы спортсменов = ");

            ShowDescription(secondGroupAthletes);

            foreach (var word in firstGroupAthletes)
            {
                listCollection.Add(word);
            }

            ShiftCollection(firstGroupAthletes, secondGroupAthletes, listCollection);

            Console.WriteLine("\n\n Вывод массива спортсменов, которые объединены в одну коллекцию  = ");

            ShowDescription(listCollection);

            Console.WriteLine("");
        }

        private void ShiftCollection(List<string> firstGroupAthletes, List<string> secondGroupAthletes, HashSet<string> listCollection)
        {
            for (int i = 0; i < firstGroupAthletes.Count; i++)
            {
                for (int j = 0; j < secondGroupAthletes.Count; j++)
                {
                    if (firstGroupAthletes[i] != secondGroupAthletes[j])
                    {
                        listCollection.Add(secondGroupAthletes[j]);
                    }
                }
            }
        }

        private void ShowDescription(List<string> list)
        {
            foreach (var word in list)
            {
                Console.Write(" " + word + ",");
            }
        }

        private void ShowDescription(HashSet<string> listCollection)
        {
            foreach (var word in listCollection)
            {
                Console.Write(" " + word + ",");
            }
        }
    }
}