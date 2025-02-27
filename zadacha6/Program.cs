internal class Program
{
    static void Main(string[] args) {
        //Vavedete random chisla w masiv ot pet cgis;la i sortirayte go. Izpolzvayte klasa random.
        int[] arr = new int[5];
        Random random = new Random();
        Console.WriteLine("Array with random numbers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100);
            Console.WriteLine(arr[i]);
        }
        Array.Sort(arr);
        Console.WriteLine("====================================");
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", arr));
    }
}