using System.ComponentModel.Design;
using System.Diagnostics;

namespace Part_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();
            List<string> vegetables = new List<string>(["CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"]);
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

                choice = "";
                Console.Clear();

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
                        Console.WriteLine();
                        Console.Write("Pick your option (1 - 10): ");
                        choice = Console.ReadLine();
                        choice = choice.Trim();
                        while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8" && choice != "9" && choice != "10")
                        {
                            Console.Write("Invalid Input. Try again: ");
                            choice = Console.ReadLine();
                            choice = choice.Trim();
                        }

                        // Sort

                        if (choice == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Here is an updated list that's sorted from greatest to smallest:");
                            numbers.Sort();
                            Console.WriteLine();
                            DisplayNumbers(numbers);
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // New list

                        else if (choice == "2")
                        {
                            numbers.Clear();
                            for (int i = 0; i < 25; i++)
                            {
                                numbers.Add(generator.Next(10, 21));
                            }
                            Console.WriteLine();
                            Console.WriteLine("Here is a new list with different random numbers:");
                            Console.WriteLine();
                            DisplayNumbers(numbers);
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Remove a number

                        else if (choice == "3")
                        {
                            int removeNum;
                            Console.WriteLine();
                            Console.Write("Enter which number you'd like to be removed: ");
                            while (!int.TryParse(Console.ReadLine(), out removeNum))
                            {
                                Console.Write("Invalid Input. Try again: ");
                            }
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == removeNum)
                                {
                                    numbers.RemoveAt(i);
                                    i--;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Removing all instances of {removeNum}. Here's an updated list:");
                            DisplayNumbers(numbers);
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Add a value

                        else if (choice == "4")
                        {
                            int addNum;
                            Console.WriteLine();
                            Console.Write("Enter which number you'd like to add: ");
                            while (!int.TryParse(Console.ReadLine(), out addNum))
                            {
                                Console.Write("Invalid Input. Try again: ");
                            }
                            numbers.Add(addNum);
                            Console.WriteLine();
                            Console.WriteLine($"Adding {addNum} to the list. Here's an updated list:");
                            DisplayNumbers(numbers);
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Count the number of occurences

                        else if (choice == "5")
                        {
                            int countedValue = 0, enteredNum;
                            Console.WriteLine();
                            Console.Write("Enter which number you'd like the to be counted: ");
                            while (!int.TryParse(Console.ReadLine(), out enteredNum))
                            {
                                Console.Write("Invalid Input. Try again: ");
                            }
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == enteredNum)
                                {
                                    countedValue++;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"{enteredNum} appeared {countedValue} times.");
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Print the largest value

                        else if (choice == "6")
                        {
                            Console.WriteLine($"Here's the largest value of the list: {numbers.Max()}");
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Print the smallest value

                        else if (choice == "7")
                        {
                            Console.WriteLine($"Here's the smallest value of the list: {numbers.Min()}");
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Print the smallest value

                        else if (choice == "8")
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Here's the sum of the numbers in the list: {numbers.Sum()}");
                            Console.WriteLine($"Here's the average of the numbers in the list: {Math.Round(numbers.Average(), 2)}");
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Determine the most frequently occuring value

                        else if (choice == "9")
                        {
                            int occurringAmount = 0, highestOccurringNum = 0, approachingNum = 1;
                            List<int> temp = new List<int>(numbers);
                            numbers.Sort();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (i == 0)
                                {
                                    highestOccurringNum = numbers[i];
                                    occurringAmount++;
                                }
                                else if (highestOccurringNum == numbers[i])
                                {
                                    occurringAmount++;
                                }
                                else if (highestOccurringNum != numbers[i])
                                {
                                    if (numbers[i] == numbers[i - 1])
                                    {
                                        approachingNum++;
                                    }
                                    else if (numbers[i] != numbers[i - 1])
                                    {
                                        approachingNum = 1;
                                    }
                                }
                                if (approachingNum > occurringAmount)
                                {
                                    highestOccurringNum = numbers[i];
                                    occurringAmount = approachingNum;
                                }
                            }
                            numbers = temp;
                            Console.WriteLine();
                            Console.WriteLine($"The number '{highestOccurringNum}' appeared the most out of all numbers, with {occurringAmount} appearances.");
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
                            Console.ReadLine();
                        }

                        // Quit

                        else if (choice == "10")
                        {
                            break;
                        }
                    }
                }

                // List of Strings

                else if (choice == "2")
                {
                    while (true)
                    {
                        choice = "";
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine("Here's a list of vegetables:");
                        Console.WriteLine();
                        DisplayVegetables(vegetables);
                        Console.WriteLine();
                        Console.WriteLine("Select what you'd like to do.");
                        Console.WriteLine();
                        Console.WriteLine("Option 1: Remove a vegetable by number");
                        Console.WriteLine("Option 2: Remove a vegetable by name");
                        Console.WriteLine("Option 3: Search for a vegetable");
                        Console.WriteLine("Option 4: Add a vegetable to the list");
                        Console.WriteLine("Option 5: Sort the list");
                        Console.WriteLine("Option 6: Clear the list");
                        Console.WriteLine("Option 7: Quit");
                        Console.WriteLine();
                        Console.Write("Pick your option (1 - 7): ");
                        choice = Console.ReadLine();
                        choice = choice.Trim();
                        while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7")
                        {
                            Console.Write("Invalid Input. Try again: ");
                            choice = Console.ReadLine();
                            choice = choice.Trim();
                        }

                        // Remove by index

                        if (choice == "1")
                        {
                            int removeNum;
                            Console.WriteLine();
                            Console.Write("Enter the corresponding number of the vegetable you'd like to be removed: ");
                            while (!int.TryParse(Console.ReadLine(), out removeNum))
                            {
                                Console.Write("Invalid Input. Try again: ");
                            }
                            while (removeNum > vegetables.Count || removeNum <= 0)
                            {
                                Console.Write("Number must be within the range of the vegetables' numbers. Try again: ");
                                while (!int.TryParse(Console.ReadLine(), out removeNum))
                                {
                                    Console.Write("Invalid Input. Try again: ");
                                }
                            }
                            vegetables.RemoveAt(removeNum - 1);
                            Console.WriteLine();
                            Console.WriteLine($"Removing vegetable #{removeNum}. Here's an updated list:");
                            DisplayVegetables(vegetables);
                            Console.WriteLine();
                            Console.WriteLine("Press 'ENTER' to select another option.");
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
                    Console.WriteLine("]");
                }
            }
        }

        public static void DisplayVegetables(List<string> vegetables)
        {
            for (int i = 0; i < vegetables.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {vegetables[i]}");
            }
        }
    }
}
