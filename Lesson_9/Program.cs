using System;
using System.Collections.Generic;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>(100);
            animals.Add("Bird");
            animals.Add("Fish");
            animals.Add("Cat");
            animals.Insert(3, "Horse");
            animals.RemoveAt(1);
            animals.Sort();
         
            Console.WriteLine("Количесво = "+ animals.Count+ " шт.");

            foreach (string animal in animals)
            Console.WriteLine(animal);
        }
    }
}