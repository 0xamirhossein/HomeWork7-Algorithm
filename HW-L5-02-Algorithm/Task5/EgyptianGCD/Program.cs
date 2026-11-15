namespace EgyptianGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers separated by space (e.g. 48 18):");
            string? input = Console.ReadLine();

            string[]? parts = input?.Split(' ');

            if (parts != null && parts.Length == 2 &&
                int.TryParse(parts[0], out int a) &&
                int.TryParse(parts[1], out int b))
            {
                
                int gcd = FindGCD.GCD(a, b);

                Console.WriteLine($"The GCD of {a} and {b} is {gcd}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter exactly two valid integers separated by a space.");
            }
        }
    }
}