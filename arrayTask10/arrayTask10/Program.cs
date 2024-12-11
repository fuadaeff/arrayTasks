using System.Security.Cryptography.X509Certificates;

namespace arrayTask10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int max = numbers[0];
            int min = numbers[0];
            int indexmin = 0;
            int indexmax = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    indexmin = i;
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    indexmax = i;
                }
            }
            numbers[indexmin] = max;
            numbers[indexmax] = min;
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
