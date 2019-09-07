using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "//;\n2;5,2,as;1001";

            char dl = input[2];
            char[] separator = { ',', '\n', dl };
            string[] stringList = input.Split(separator);

            int sum = 0;
            int num1 = 0;
            bool error = false;

            foreach(string item in stringList)
            {
                // Checks if input is Number vs String
                bool check = Int32.TryParse(item, out num1);
                // If string = value is not calculated.
                if (check == false) {
                    num1 = 0;
                }
                // If negative number = give error message and number that is error
                else if (num1 < 0) {
                    Console.WriteLine("\nCannot calculate negative number: " + num1);
                    num1 = 0;
                    error = true;
                // If number is over 1000 = value is ignored.
                } else if (num1 > 1000) {
                    num1 = 0;
                } else {
                    num1 = Int32.Parse(item);
                }

                sum = sum + num1;
            }

            if (error == false) {
                Console.WriteLine("\nSum = " + sum);
            // Gives error for negative numbers
            } else {
                Console.WriteLine("\nCould not calculate Sum using negative numbers.");
            }
            Console.ReadKey();

        }
    }
}
