internal class Program
{
    static void Main(string[] args)
    {
        //Vavedete random chisla w masiv ot pet cgis;la i sortirayte go. Izpolzvayte klasa random.
        //int[] arr = new int[5];
        //Random random = new Random();
        //Console.WriteLine("Array with random numbers:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = random.Next(1, 100);
        //    Console.WriteLine(arr[i]);
        //}
        //Array.Sort(arr);
        //Console.WriteLine("====================================");
        //Console.WriteLine("Sorted array:");
        //Console.WriteLine(string.Join(", ", arr));

        //Sazdayte dva dvumerni masiva s razmernost 3x3. zadayte randomni chisla za tqh si syzdayte treti dvumeren masiw kato elementite
        //sa rezultat ot parviq masiv minus element ot vtoriq masiv. izpolzwayte klasa random.
        int[,] arr1 = new int[3, 3];
        int[,] arr2 = new int[3, 3];
        int[,] arr3 = new int[3, 3];
        Random random = new Random();

        Console.WriteLine("Array 1 with random numbers:");
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                arr1[i, j] = random.Next(1, 100);
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("====================================");
        Console.WriteLine("Array 2 with random numbers:");
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                arr2[i, j] = random.Next(1, 100);
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("====================================");
        Console.WriteLine("Array 3 with random numbers:");
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                arr3[i, j] = arr1[i, j] - arr2[i, j];
                Console.Write(arr3[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}