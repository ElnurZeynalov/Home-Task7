using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metini taxil edin: ");
            String Sentence = Console.ReadLine();
            SpaceDeleter(Sentence);
        }
        static void SpaceDeleter(string Sentence)
        {
            int First = Sentence.IndexOf(' ');
            int Last = Sentence.LastIndexOf(' ');
            int value = Last - First;
            Console.WriteLine(Sentence.Remove(First, value));
        }
    }
}
