 using System;

namespace docobjtypeProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                Console.WriteLine("Enter your choice for the program:");
                Console.WriteLine("1. Comparing two numbers");
                Console.WriteLine("2. Product of n numbers");
                Console.WriteLine("3. Is number greater than 10");
                Console.WriteLine("4. Double quotation around each word");

                int choice;

                /*while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4:");
                }
                */
                for (; ; )
                {
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4:");
                    }
                }

                switch (choice)
                {
                    case 1:
                        CompareTwoNumbers();
                        break;
                    case 2:
                        ProductOfNNumbers();
                        break;
                    case 3:
                        IsNumberGreaterThanTen();
                        break;
                    case 4:
                        DoubleQuotationAroundEachWord();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            static void CompareTwoNumbers()
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                double number1;

                while (!double.TryParse(input1, out number1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    input1 = Console.ReadLine();
                }

                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();
                double number2;

                while (!double.TryParse(input2, out number2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    input2 = Console.ReadLine();
                }

                if (number1 > number2)
                {
                    Console.WriteLine($"{number1} is greater than {number2}");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine($"{number1} is less than {number2}");
                }
                else
                {
                    Console.WriteLine($"{number1} is equal to {number2}");
                }
            }

            static void ProductOfNNumbers()
            {
                Console.Write("Enter the number of values: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }

                double product = 1;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Enter number {i}: ");
                    double number;
                    while (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.Write("Invalid input. Please enter a valid number: ");
                    }
                    product *= number;
                }

                Console.WriteLine($"The product of the {n} numbers is {product}");
            }

            static void IsNumberGreaterThanTen()
            {
                Console.Write("Enter a number: ");
                double number;

                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                if (number > 10)
                {
                    Console.WriteLine($"{number} is greater than 10");
                }
                else
                {
                    Console.WriteLine($"{number} is not greater than 10");
                }
            }

            static void DoubleQuotationAroundEachWord()
            {
                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = $"\"{words[i]}\"";
                }

                string result = string.Join(" ", words);
                Console.WriteLine(result);
          
               
            }
        }
    }

