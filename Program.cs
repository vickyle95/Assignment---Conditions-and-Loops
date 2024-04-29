using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Assignment___Conditions_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vicky Le
            // Programming 120
            // Assignment: Conditions and Loops
            // 4/27/24

            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
            //Problem6();
            Menu();

        } // Main
        public static void Problem1()
        {
            // Problem 1
            string problem1 = "Task: Write a program to take an integer input from the user. Determine if the number is positive, negative, or zero. Display the result.";
            Console.WriteLine($"Problem 1: Positive, Negative, or Zero \n{problem1}");

            // User input the number
            Console.WriteLine("Enter your number: ");
            string userInput = Console.ReadLine();
            int number;

            if(int.TryParse(userInput, out number))
            {
                // Check the value of the number
                if(number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if(number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter the valid number.");
            }

        } // Problem1();

        public static void Problem2()
        {
            // Problem 2
            string problem2 = "Task: Write a program to take three different numbers as input. Determine the largest of the three numbers and display it.";
            Console.WriteLine($"Problem 2: Largest of Three (using if / else if / else ) \n{problem2}");

            Console.WriteLine("Enter the three different numbers:");

            //User input the numbers
            Console.Write("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            // Find the largest number

            if(num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"Largest number is: {num1}");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"Largest number is: {num2}");
            }
            else
            {
                Console.WriteLine($"Largest number is: {num3}");
            }
            
        } // Problem2()
        public static void Problem3()
        {
            // Problem 3
            string problem3 = "Task: Write a program that takes an alphabet as input. Check whether the input is a vowel (a, e, i, o, u) or a consonant.";
            Console.WriteLine($"Problem 3: Check for a Vowel \n{problem3}");

            // User input the alphabet
            Console.WriteLine("Enter a single alphabet: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input != null && input.Length == 1 && char.IsLetter(input[0]))
            {
                char inputChar = input[0];

                if(inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single alphabet character.");
            }
        } // Problem3()
        
        public static void Problem4()
        {
            // Problem 4
            string problem4 = "Task: Write a program to print the multiplication table of a given number up to 10. Ask the user for a number, then print out the related multiplication table.";
            Console.WriteLine($"Problem 4: Multiplication Table \n{problem4}");

            // User input the number
            Console.WriteLine("Enter a number: ");

            if(int.TryParse(Console.ReadLine(), out int number))
            {
                if(number > 0)
                {
                    Console.WriteLine($"Multipcation Table for {number}");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{number} x {i} = {number * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        } // Problem4()

        public static void Problem5()
        {
            // Problem 5
            string problem5 = "Task: Write a program to determine if a given number is a prime number (a number only divisible by 1 and itself).";
            Console.WriteLine($"Problem 5: Check if a Number is Prime \n{problem5}");

            int number;
            string input;

            do
            {
                // User input the number
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 1)
                {
                    bool isPrime = true;

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (true);
        } // Problem5()

        public static void Problem6()
        {
            // Loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        } // Problem6()
        public static void Menu()
        {
            bool exitRequested = false;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Conditions");
                Console.WriteLine("2. Loops");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Problem 1: Positive, Negative, or Zero");
                    Console.WriteLine("Problem 2: Largest of Three (using if / else if / else)");
                    Console.WriteLine("Problem 3: Check for a Vowel");
                    Console.WriteLine("Press any other key to go back to the menu.");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Problem1();
                    }
                    else if (userInput == "2")
                    {
                        Problem2();
                    }
                    else if (userInput == "3")
                    {
                        Problem3();
                    }
                }
                // Loop Questions
                else if (userInput == "2")
                {
                    Console.WriteLine("Problem 4: Multiplication Table");
                    Console.WriteLine("Problem 5: Check if a Number is Prime");
                    Console.WriteLine("Problem 6: FizzBuzz");
                    Console.WriteLine("Press any other key to go back to the menu.");
                    userInput = Console.ReadLine();
                    if (userInput == "4")
                    {
                        Problem4();
                    }
                    else if (userInput == "5")
                    {
                        Problem5();
                    }
                    else if (userInput == "6")
                    {
                        Problem6();
                    }
                }
                // Exit
                else if (userInput == "3")
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } while (exitRequested);
        } // Menu()

    } // Class
} // Namespace
