namespace arrayTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            decimal edediorta = 0;
            int count = numbers.Length;
            foreach (int i in numbers)
            {
                sum = sum + i;
            }

            edediorta = sum / count;
            Console.WriteLine(edediorta);
        }

    }
}
