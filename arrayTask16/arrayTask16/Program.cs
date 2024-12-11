namespace arrayTask16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int n = 0;
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i-1] == numbers[i]) {
                    Console.WriteLine("duplicate.");
                    n = n + 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
