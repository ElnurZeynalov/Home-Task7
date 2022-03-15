using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Arrayin elementleri");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            IntResize(ref array);
            
        }
       static void IntResize(ref int[] array)
        {
            Console.WriteLine("Arraya Elave olunacaq Reqemi daxil edin");
            string Element;
            bool result;
            int Value;
            do
            {
                Element = Console.ReadLine();
                result = int.TryParse(Element, out Value);
                if (!result)
                Console.WriteLine("Reqem daxil edin");
            } while (!result);
            Value = Convert.ToInt32(Element);
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1]=Value;
            Console.WriteLine("Yeni Array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}