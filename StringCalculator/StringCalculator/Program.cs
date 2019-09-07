using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 2 Numbers To Be Added For Calculation:");
            string input = Console.ReadLine();

            string[] separator = { "," };
            string[] stringList = input.Split(",");

            int sum = 0;
            int num1 = 0;

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
            
            Console.WriteLine("\nSum = " + sum);

            Console.ReadKey();

        }
    }
}
