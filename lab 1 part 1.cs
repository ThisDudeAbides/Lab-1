using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letsDoThisAgain
{
    class digit_3_Compare
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Would you like to check to see if two 3 digit numbers sums are equal to the same total. yes or no ?... Lets Go! ");
            var wouldYouLikeToContinue = Console.ReadLine();

            if (wouldYouLikeToContinue != null && wouldYouLikeToContinue.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
            {
                var num1 = GetIntFromUser("Please pick your first three digit whole number");
                var num2 = GetIntFromUser("Please enter a three digit whole number");

                Console.WriteLine(Compare(num1, num2) ? "True" : "False");
            }
            else
            {
                Console.WriteLine("wrong Answer, Goodbye");
            }

            // waits for the user to press a key to exit the app
            Console.ReadKey();
        }

        // <piece by piece>
        // user enters first three digit number, and  if they say "no" then  console prints "wrong answer, goodbye"
        public static int GetIntFromUser(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                var valFromUser = Console.ReadLine()?.Trim();

                if (valFromUser != null)
                {
                    int result;
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
                } // if the user enters more or less than 3 digits the cons
                Console.WriteLine("thats not the right number of digits. please try again.");
            }
        }

        public static bool Compare(int a, int b)
        { // use modulus to devide and find the remainder (singles out one digit)
            var lastDigitA = a % 10;
            var lastDigitB = b % 10;
            var sumStatic = lastDigitA + lastDigitB;

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
