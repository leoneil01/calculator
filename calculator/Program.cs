using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, year;
            double total, num1, num2;
            string symbol, yn, name, feel;

            Console.WriteLine("Please input your name: ");
            name = Console.ReadLine();

            bool code_run2 = true;
            while (code_run2 == true)
                try
                {
                    Console.WriteLine("Input your age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    year = 100 - age;

                    if (30 <= age)
                    {
                        Console.WriteLine($"\nWelcome ma'am/sir, {name}! I can tell, you will be 100 in the next {year} years.");
                        Console.WriteLine("Just joking. I just simple subtracted 100 to your age, without it I cannot tell.");
                        Console.WriteLine("Interested on how I did it? Well, all you have to do is join me and play along. \nPress enter to continue . . .");
                        Console.ReadLine();
                        Console.WriteLine("First, just input the first value.");
                        Console.WriteLine("Then, input the second value.");
                        Console.WriteLine("After that, just use any operator that is available here.");
                        Console.WriteLine("The available operator you can use are addition (+), subtraction (-), multiplication (*), and division (/).");
                        Console.WriteLine("Take note that all you have to input in the operator section is the symbol of each operator.");
                        Console.WriteLine("Simple enough, right? Let's begin.");
                    }
                    else if (age <= 18)
                    {
                        Console.WriteLine($"\nHello there. Welcome, {name}.");
                        Console.WriteLine("How are you? I hope you're doing fine.");
                        Console.WriteLine("You know that by subtracting your age to 100, you will know how many years it takes for you to be 100?");
                        Console.WriteLine($"Like, you will be 100 in the next {year} years.");
                        Console.WriteLine("Well, today we will gonna learn about adding, subtracting, multiplying, and dividing.");
                        Console.WriteLine("Let's start.");
                    }
                    else if (19 <= 29)
                    {
                        Console.WriteLine($"\nWelcome {name}! You will be 100 in the next {year} years.");
                        Console.WriteLine($"\nHi there {name}, let's play a little game that I created.");
                        Console.WriteLine("Just a little game called calculator.");
                        Console.WriteLine("You just have to input two integer numbers and pick an operator to use.");
                        Console.WriteLine("Simple enough, right? Now let's start.");
                    }
                    code_run2 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid! Use integer/numbers only.");
                    Console.WriteLine("Please try again.\n");
                }
            do
            {
                bool code_run = true;
                while (code_run == true)
                    try
                    {
                        Console.WriteLine("\nInput the first value: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the second value: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose an operator to be used: ");
                        symbol = Console.ReadLine();

                        switch (symbol)
                        {
                            case "+":
                                total = num1 + num2;
                                Console.WriteLine($"\nAddition of the two number: {total}");
                                break;
                            case "-":
                                total = num1 - num2;
                                Console.WriteLine($"\nSubtraction of the two umbers: {total}");
                                break;
                            case "*":
                                total = num1 * num2;
                                Console.WriteLine($"\nMultiplication of the two numbers: {total}");
                                break;
                            case "/":
                                total = num1 / num2;
                                Console.WriteLine($"\nDivision of the two numbrs: {total}");
                                break;
                            default:
                                throw new Exception
                                ("Invalid operator! Try again.\n");
                        }
                        code_run = false;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot be divisible by 0. Use another value.");
                        Console.WriteLine("Please try again.\n");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid! Use integer/numbers only.");
                        Console.WriteLine("Please try again.\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                Console.WriteLine($"\nDo you still want to continue? Please enter Y for yes. If not, just press enter to end this program.");
                yn = Console.ReadLine();
            }
            while (yn == "y" || yn == "Y");
            {
                Console.WriteLine($"Thank you very much, {name}. I hope you had fun.");
            }
        }
           
    }
}
