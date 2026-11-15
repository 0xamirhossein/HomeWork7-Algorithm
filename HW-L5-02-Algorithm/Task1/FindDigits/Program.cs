namespace FindDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int count = 0;
                int temp = Math.Abs(number);

                if (temp == 0)
                {
                    count = 1;
                }
                else
                {
                    for (int i = 0; temp > 0; i++)
                    {
                        count++;
                        temp /= 10;
                    }
                }

                Console.WriteLine($"tedad argham {number} : {count}");
            }
            else
            {
                Console.WriteLine("voroodi namotabar ast!");
            }
        }
    }
}