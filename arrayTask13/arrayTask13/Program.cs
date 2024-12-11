namespace arrayTask13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3,4, 5, 6, 7 };
            int[] reversed = new int[numbers.Length];
            int index = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversed[index] = numbers[i];
                index = index + 1;
            }
            foreach (int number in reversed)
            {

                Console.WriteLine(number);
            }
        }
    }
}
