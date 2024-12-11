namespace arrayTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3,5 , 12, 10, 150,134 };
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 5 == 0) {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
