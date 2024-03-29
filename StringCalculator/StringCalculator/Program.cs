﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "//[---][+++]\n2---5,2\nasdf+++1001,10";

            //Based on formart, finds any delimiter and multiple delimiters
            var dl = Regex.Matches(input, @"\[([^]]+)]")
                .OfType<Match>()
                .Select(m => m.Groups[1].Value)
                .ToArray();

            List<string> separate = new List<string>();

            //Puts all delimiters in a list
            foreach(string d in dl) {
                separate.Add(d);
            }
            separate.Add(",");
            separate.Add("\n");
            
            string[] separator = separate.ToArray();
            string[] stringList = input.Split(separator, StringSplitOptions.None);

            int sum = 0;
            int num1 = 0;
            bool error = false;

            foreach (string item in stringList)
            {
                //Console.WriteLine(item);
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
