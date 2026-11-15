namespace ReverseNumByString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string reversedNumber = ReverseNum.ReverseNumber(number);
                Console.WriteLine($"Reversed number: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
