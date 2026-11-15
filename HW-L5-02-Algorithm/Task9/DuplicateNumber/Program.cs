namespace DuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of integers separated by spaces:");

            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                bool validInput = true;


                string[] parts = input.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries
                );

                int[] nums = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out nums[i]))
                    {
                        validInput = false;
                        break;
                    }
                }

                if (!validInput)
                {
                    Console.WriteLine("Invalid input! Please enter valid integers.");
                    return;
                }

                bool result = DuplicateNum.HasDuplicate(nums);
                
                
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}