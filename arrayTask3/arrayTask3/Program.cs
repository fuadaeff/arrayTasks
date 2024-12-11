namespace arrayTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = numbers.Length - 1; i >= 0; i--) {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
