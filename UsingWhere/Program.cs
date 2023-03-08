namespace UsingWhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int length = 100;

            Console.Write("numbers[] = { ");
            for (int i = 0; i < length; i++)
            {
                int randomNumber = new Random().Next(100);
                numbers[i] = randomNumber;

                if (i % 10 == 0)
                {
                    Console.Write($"\n\t\t{numbers[i]}, ");
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }
            Console.WriteLine(" };");

            var Chetnie = from i in numbers
                          where i % 2 == 0
                          select i;

            var Nechetnie = numbers.Where(i => i % 2 != 0);

            Console.WriteLine("Chetnie: ");
            foreach (int i in Chetnie)
            {
                Console.Write($"{ i }, ");
            }
            Console.WriteLine("\n\nNechetnie: ");
            foreach (int i in Chetnie)
                Console.Write($"{i}, ");
        }
    }
}