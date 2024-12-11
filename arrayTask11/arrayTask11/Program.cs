namespace arrayTask11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            start = start - 1;
            end = end - 1;
            int sum = 0;
            for (int i = start; i <= end; i++) { 
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);

        }
    }
}
