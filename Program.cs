namespace CoreAndFunctionalProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs!");
            Console.WriteLine("Program #1: Flip Coin");
            Console.WriteLine("Program #2: Leap Year");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}