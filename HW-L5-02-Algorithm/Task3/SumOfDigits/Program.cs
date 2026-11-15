namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                number = Math.Abs(number); // for negative number
                int total = Total.SumOfDigits(number);
                Console.WriteLine($"The sum of the digits of {number} is: {total}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
