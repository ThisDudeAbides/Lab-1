using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitSumComparison
{
    class digit_3_Compare
    
    {
        static void Main(string[] args)
        {  // when the program runs, the console askes the user  
            //would like to check to see if the sums of two numbers are the same ... asks user yes / no
            Console.WriteLine(" Would you like to check to see if two 3 digit numbers sums are equal to the same total. yes or no ?... Lets Go! ");
            var wouldYouLikeToContinue = Console.ReadLine();

            // if user enters yes, then the console will then print 
            //asking for the first 3 digit number, then the second 3 digit number
            //if-else statement, if condition evaluates to true, the then-statement runs.If condition is false, the else-statement runs.
            if (wouldYouLikeToContinue != null && wouldYouLikeToContinue.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                var num1 = GetIntFromUser("Please pick your first three digit whole number");
                var num2 = GetIntFromUser("Please enter a three digit whole number");
               
                // the console will print true or false based from the internal calculations below
                Console.WriteLine(Compare(num1, num2) ? "True" : "False");
            }
            // if the user enters some
            else
            {  // if the user inputs no, the console will rint wrong answer, goodbye
                Console.WriteLine("wrong Answer, Goodbye");
            }

            // waits for the user to press a key to exit the program
            Console.ReadKey();
        }

        // <piece by piece>
        // if user enters yes, this portion of code then runs, 
        // user enters first three digit number, and  if they say "no" then  console prints "wrong answer, goodbye"
           //
        public static int GetIntFromUser(string msg)
        {
            //statement executes a statement or a block of statements until a specified 
            //expression evaluates to true
            while (true)
            {
                Console.WriteLine(msg);
                var valFromUser = Console.ReadLine()?.Trim();

                // null keyword is a literal that represents a null reference, one that does not refer to any object. 
                //null is the default value of reference - type variables.
                // if statement identifies which statement to run based on the value of a Boolean expression. 
                if (valFromUser != null)
                {
                    int result;

                    //out keyword causes arguments to be passed by reference
                    // both the method definition and the calling method must explicitly use the out keyword
                    //int.Tryparse Converts the string representation of a number to its 32-bit signed integer equivalent. 
                    // valFromUser.Length user ==3 refers to the users imput with a 3 digit number
                    // .Trim removes all leading and training white space white space characters from string object
                    if (int.TryParse(valFromUser.Trim(), out result) && valFromUser.Length == 3)
                    {
                        return result;
                    }
                    // if user answers "no" then the console prints "Goodbye :( "
                    if (valFromUser.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Goodbye :( ");
                        Environment.Exit(0);
                    }
                } // if the user enters more or less than 3 digits the console prints a reminder to 9try again
                Console.WriteLine("thats not the right number of digits. please try again.");
            }
        }

        public static bool Compare(int a, int b)
        { // use modulus to devide and find the remainder (singles out one digit)
            var lastDigitA = a % 10;
            var lastDigitB = b % 10;
            var sumStatic = lastDigitA + lastDigitB;

            //The do statement executes a statement or a block of statements 
            //repeatedly until a specified expression evaluates to false. 
            do
            {
                lastDigitA = a % 10;
                lastDigitB = b % 10;
                a = a / 10;
                b = b / 10;
                // you will be comparing the last digit from each 3 digit number
                var sumCompare = lastDigitA + lastDigitB;

                if (sumCompare != sumStatic)
                {
                    return false;
                }
            } while (b != 0);
            return true;
        }
    }
}
