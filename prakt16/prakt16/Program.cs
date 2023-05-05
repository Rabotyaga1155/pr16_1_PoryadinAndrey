using System;
using System.IO;
using System.Linq;


namespace prakt16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string text = File.ReadAllText(path).ToLower();
            string[] myArray = text.Split(" ");
            Console.WriteLine("Введите слово которое хотите искать");
            string p = Console.ReadLine().ToLower();
            int count = myArray.Count();
            Console.WriteLine("Слов в тексте " +count);
            count = myArray.Count(s => s.StartsWith(p));
            Console.WriteLine("Количество слов - " + myArray.Count(item => item == p));
        }
    }
}
