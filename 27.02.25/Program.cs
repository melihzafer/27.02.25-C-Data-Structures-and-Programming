using System;

namespace MyNampespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a fruit1:");
            string fruit1 = Console.ReadLine();
            Console.WriteLine("Type a fruit2:");
            string fruit2 = Console.ReadLine();
            Console.WriteLine("Type a fruit3:");
            string fruit3 = Console.ReadLine();
            Console.WriteLine("Type a fruit4:");
            string fruit4 = Console.ReadLine();
            Console.WriteLine("Type a fruit5:");
            string fruit5 = Console.ReadLine();

            string[] fruits = new string[] { fruit1, fruit2, fruit3, fruit4, fruit5 };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].StartsWith("A") || fruits[i].StartsWith("K"))
                {
                    Console.WriteLine(fruits[i]);
                }
            }
        }
        public void replacingString()
        {
            string s = Console.ReadLine();
            string zamqna1 = s.Replace("C#", "C++");

            if (zamqna1.StartsWith("Aleksandar"))
            {
                zamqna1 = zamqna1.Replace("Aleksandar", "Alex");
            }
            Console.WriteLine(zamqna1);
        }
    }
}