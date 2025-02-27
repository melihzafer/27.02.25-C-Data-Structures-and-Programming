namespace MyNampespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //replacingString();
            //outputTheFruitsStartWithA();



        }
        static void replacingString()
        {
            string s = Console.ReadLine();
            string zamqna1 = s.Replace("C#", "C++");

            if (zamqna1.StartsWith("Aleksandar"))
            {
                zamqna1 = zamqna1.Replace("Aleksandar", "Alex");
            }
            Console.WriteLine(zamqna1);
        }


        static void outputTheFruitsStartWithA()
        {
            string input = Console.ReadLine();
            string[] fruits = input.Split(", ");
            //Console.WriteLine(fruits);
            string newSttring = "";
            foreach (string fruit in fruits)
            {
                if (fruit.StartsWith("a") || fruit.StartsWith("k"))
                {
                    newSttring += fruit + ", ";
                }
            }
            Console.WriteLine(newSttring);
        }
    }
}