namespace arrayTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int max = numbers[0];
            foreach (int number in numbers) {
                if (number > max) { 
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
