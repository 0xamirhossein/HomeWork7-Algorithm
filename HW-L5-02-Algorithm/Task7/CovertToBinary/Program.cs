namespace CovertToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string binary = ConvertNum.ConvertToBinary(number);
                Console.WriteLine($"The binary representation of {number} is: {binary}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
