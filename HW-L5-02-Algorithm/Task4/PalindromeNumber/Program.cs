namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                bool isPalindrome = Check.IsPalindrome(number);
                if (isPalindrome)
                {
                    Console.WriteLine($"{number} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
