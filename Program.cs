using System;

namespace myCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringContinueChoice = null;
            double doubleResult = 0;
            bool Result = true;

            do
            {
                Console.WriteLine("Please enter your choice : 1 - Add, 2 - Subtract, 3 - Multiply, 4 - Division");
                string strChoice = Console.ReadLine();

                if (strChoice == "1" || strChoice == "2" || strChoice == "3" || strChoice == "4")
                {
                    double doubleArgs1, doubleArgs2;

                    if (Result)
                    {
                        Console.WriteLine("Please Enter Arguments");
                        Console.Write("Arg 1 : ");
                        doubleArgs1 = double.Parse(Console.ReadLine());
                        Result = false;
                    }
                    else
                    {
                        doubleArgs1 = doubleResult;
                        Console.WriteLine("Using previous result as Arg 1: {doubleArgs1}");
                    }

                    Console.Write("Arg 2 : ");
                    doubleArgs2 = double.Parse(Console.ReadLine());

                    if (strChoice == "1")
                    {
                        doubleResult = doubleArgs1 + doubleArgs2;
                    }
                    else if (strChoice == "2")
                    {
                        doubleResult = doubleArgs1 - doubleArgs2;
                    }
                    else if (strChoice == "3")
                    {
                        doubleResult = doubleArgs1 * doubleArgs2;
                    }
                    else if (strChoice == "4")
                    {
                        if (doubleArgs2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            doubleResult = 0;
                        }
                        else
                        {
                            doubleResult = doubleArgs1 / doubleArgs2;
                        }
                    }

                    Console.Write("Result : ");
                    Console.WriteLine(doubleResult);
                }
                else
                {
                    Console.WriteLine("Invalid Choice Entered");
                }

                Console.Write("Do you want to continue Y/N? ");
                stringContinueChoice = Console.ReadLine();
            }
            while (stringContinueChoice == "Y");

            
        }
    }
}
