using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hereWeGoAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = false;
            DateTime endTime = new DateTime(), startTime = new DateTime();  
            do
            { 
                if (error)
                {
                    // if used enters wrong date format, it will therefore be concidered false and the console will print " wrong date format,try again"
                    Console.WriteLine("oops, that does not look like the right date format, try again! (mm-dd,yyyy");
                }

				error = false;

                // asking the user to enter the first date of choice
                Console.WriteLine("Please pick your first date(mm-dd-yyyy with the dashes included): ");
                try
                {
                    startTime = DateTime.ParseExact(Console.ReadLine(), "mm-dd-yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);
            do
            {
                if (error)
					// if the user puts in the wrong date format it will print "try again with the correct date format
                    Console.WriteLine("That doest quite look like the right format, Try again! (mm-dd,yyyy)!");
					
                error = false;
                Console.WriteLine("Please pick a second date(mm-dd-yyyy with the dashes included): ");
                try
                {
                    endTime = DateTime.ParseExact(Console.ReadLine(), "mm-dd-yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            TimeSpan span = endTime.Subtract(startTime);
            int days = span.Days;
            if (days < 0)
                days *= -1; 
            // based from the correct date format of bothe dates, the console will print the calculations for years, months, days minutes and seconds
            String spanMsg = string.Format("{0} years, {1} months, {2} days, {3} hours, and {4} minutes",
                days / 365, days / 12, days, days * 24, days * 24 * 60, days * 24 * 60);
            Console.WriteLine(spanMsg);
            Console.ReadLine();
            



        }
    }
}
