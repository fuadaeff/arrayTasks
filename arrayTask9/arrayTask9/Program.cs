namespace arrayTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 }; 
            int min = numbers[0];
            foreach (int number in numbers) {
                if (number < min) {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
