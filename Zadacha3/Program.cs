internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int[] arr2 = new int[5];
        int sum = 0;
        double average = 0;
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Vavedi chislo za elementa {i}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        Console.WriteLine("====================================");
        foreach (int number in arr)
        {
            Console.WriteLine($"Element is {number}");
        }
        int br = 0;
        while (br < arr.Length)
        {
            Console.WriteLine($"Element is {arr[br]}");
            br++;
        }

        new array with the square of the elements of the first array
        while (br < arr.Length)
        {
            arr2[br] = (int)Math.Pow(arr[br], 2);
            br++;
        }
        do
        {
            Console.WriteLine($"Element is {arr2[br]}");
            br++;
        } while (br < arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine($"Sumata e {sum}");

        average = (double)sum / arr.Length;
        Console.WriteLine($"Srednoaritmetichnoto e {average}");


    }
}