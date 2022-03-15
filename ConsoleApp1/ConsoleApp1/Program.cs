using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Sozu daxil edin(En az 1 boyuk 1 kicik herf ve reqem olsun)");
            string value;
            do
            {
                value = Console.ReadLine();
                Console.WriteLine(Checker(value)); 
            } while (!Checker(value)); 
        }
        static bool Checker(string value)
        {
            int count1 = 0;
            int count2 = 0;
            int count3= 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    count1++;
                }
                else if (char.IsLower(value[i]))
                {
                    count2++;
                }
                else if (char.IsDigit(value[i]))
                {
                    count3++;
                }
            }
            if (count1 >= 1 && count2 >= 1 && count3 >= 1)
            {
                return true;
            }
            return false;
        }
    }
}