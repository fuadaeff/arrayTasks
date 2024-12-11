namespace arrayTask15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 123, 124,234 };
            int count = 0;
            if (numbers.Length == numbers2.Length) {
                for (int i = 0; i < numbers.Length; i++) {
                    for (int j = 0; j < numbers2.Length; j++) {
                        if (numbers2[i] == numbers[j])
                        {
                            count = count + 1;
                        }
                    }
                }
                if (count == numbers2.Length) {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
