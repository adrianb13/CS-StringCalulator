using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1,1\n1\n1,1";

            string[] separator = { ",", "\n" };
            string[] stringList = input.Split(separator, StringSplitOptions.None);

            int sum = 0;
            int num1 = 0;
            bool error = false;

            foreach(string item in stringList)
            {
                
                bool check = Int32.TryParse(item, out num1);
                if (check == false) {
                    num1 = 0;
                } else {
                    num1 = Int32.Parse(item);
                }

                sum = sum + num1;
            }

            if (error == false) {
                Console.WriteLine("\nSum = " + sum);
            } else {
                Console.WriteLine("\nCould not calculate Sum using negative numbers.");
            }
            Console.ReadKey();

        }
    }
}
