# StringCalulator

Basic C# Console App (Very) Limited But Positive Calculator:

This calculator does addition only so far.  It take in a string input and determines the computable values using a delimiter/delimiters. The delimiters are determined using Regex and the string is split into its separate values using .Split method.

It takes the input format of //[{delimiter1}][{delimiter2}]...\n{numbers}
As an example the string could be //[---][+++][\n][,]\n1,2---3,+++4  which will be split into 1 2 3 and 4 with a total sum of 10.

If a string that is not numerical is entered as part of the equation, it will essentially be ignored.  This is determined by using the method TryParse().  It the string can be converted to a integer, it will keep its value. So "1" equals 1.  If a non-numerical value is entered, it will not be part of the calculation. So "asdfasf" equals 0 basically having no affect on the sum.

Also, if the numerical value is over 1000, it will be ignored. The limited calculator doesn't know how to add numbers that initially start over 1000. So 1001 will basically equal 0 therefore not affecting the sum.  

If //[,][\n]\n1,2,3,1001\nasfd was entered, it would tell you the sum is 6.

The last quirk to this calculator is that it does not take negative numbers.  It is a positive calculator who likes to keep in a positive direction.  It doesn't like bad vibes, so if a negative number was entered, it would give you an error say it doesn't calculate negative numbers.

Both the values of being over 1000 or negative are checked after parsing using a simple if statement.  

Like any developer, it is still learning it's full potential.  The more you teach it, the more it will be able to do. So if you want to teach it other skills, feel free show it more code so it can be a better calculator. :) 
