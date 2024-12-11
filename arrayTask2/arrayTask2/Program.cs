namespace arrayTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (int i in number) { 
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
