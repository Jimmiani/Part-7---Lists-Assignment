namespace Part_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();
            bool done = false;
            string choice = "";
            Console.SetWindowSize(150, 40);


            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }


            while (!done)
            {
                // Intro

                Console.Clear();
                choice = "";

                Console.SetCursorPosition(53, 2);
                Console.WriteLine("Welcome to my Lists Programming Assignment!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pick what part of the assignment you'd like to see.");
                Console.WriteLine();
                Console.WriteLine("Option 1: Lists of Integers");
                Console.WriteLine("Option 2: Lists of Strings");
                Console.WriteLine("Option 3: Quit");
                Console.WriteLine();
                Console.Write("Pick your option (1 - 3): ");
                choice = Console.ReadLine();
                choice = choice.Trim();
                while (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.Write("Invalid Input. Try again: ");
                    choice = Console.ReadLine();
                    choice = choice.Trim();
                }

                // Lists of Integers

                if (choice == "1")
                {
                    while (true)
                    {
                        choice = "";
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine("Here is a list of numbers:");
                        Console.WriteLine();
                        DisplayNumbers(numbers);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Select what you'd like to do.");
                        Console.WriteLine();
                        Console.WriteLine("Option 1: Sort the list");
                        Console.WriteLine("Option 2: Make a new list of random integers");
                        Console.WriteLine("Option 3: Remove a number");
                        Console.WriteLine("Option 4: Add a value to the list");
                        Console.WriteLine("Option 5: Count the number of occurrences of a specified number");
                        Console.WriteLine("Option 6: Print the largest value");
                        Console.WriteLine("Option 7: Print the smallest value");
                        Console.WriteLine("Option 8: Print the sum and average of the numbers in the list");
                        Console.WriteLine("Option 9: Determine the most frequently occurring value(s)");
                        Console.WriteLine("Option 10: Quit");
                        Console.WriteLine("Option 11: ???");
                        Console.WriteLine();
                        Console.Write("Pick your option (1 - 11): ");
                        choice = Console.ReadLine();
                        choice = choice.Trim();
                        while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8" && choice != "9" && choice != "10" && choice != "11")
                        {
                            Console.Write("Invalid Input. Try again: ");
                            choice = Console.ReadLine();
                            choice = choice.Trim();
                        }

                        // Sort

                        if (choice == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Here is an updated list that's sorted from greatest to smallest:");
                            numbers.Sort();
                            Console.WriteLine();
                            DisplayNumbers(numbers);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }

        public static void DisplayNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("[");
                }
                Console.Write(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("]");
                }
            }
        }
    }
}
