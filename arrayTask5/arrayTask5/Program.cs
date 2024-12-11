namespace arrayTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (int i in numbers)
            {
                if(i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
