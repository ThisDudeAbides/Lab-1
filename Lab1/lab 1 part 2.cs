using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DiffBtwDates
    {
        class Program
        {
            static void Main(string[] args)

            {   // clarifying date format
                string dateFormat = "yyyy/MM/dd";

                // identified 2 seporate dates to be compared
                string day1, day2;

                // DateTime is representative of the date and time of day.
                DateTime date1, date2;

                // ask user to enter first date
                // prints out following string to console
                Console.WriteLine("please pick your first date: <YYYY/MM/DD>");

                // bool statement that proves either true or false
                // string is assumed to be 12 midnight
                // A DateTimeFormat is where an object that defines the format of date and time data.
                //out arguments do not have to be initialized before being passed yo date1.
                // converts equivelant using specific format, information and style. method returns value that indecates if conversion is successful
                if (DateTime.TryParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out date1))

                {//asks for user to pick second date
                    Console.WriteLine("Please enter the second date: <YYYY/MM/DD>");
                    if (DateTime.TryParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out date2))
                    {
                        // expressed in whole int
                        // date one is subtracted by date two which is timeDiff
                        //.TotalDays is property of TimeSpan
                        //.TotalHours is property of TimeSpan
                        //.TotalMinutes is a property of TimeSpan
                        //.ToString represents current object that is equal to day1 and day2

                        day1 = date1.ToString("yyyy/MM/dd");
                        day2 = date2.ToString("yyyy/MM/dd");

                        // var represents a double float precision number
                        var totalDays = (date2 - date1).TotalDays;

                        // math to devide total days by 365 to single out the number of years
                        var totalYears = Math.Truncate(totalDays / 365);

                        //math to calculate months... total number of days devided by 365 to get years and devide by 12 to get months
                        var totalMonths = Math.Truncate(totalDays % 365) ;

                        // math to calculate the number of days
                        var daysTotal = Math.Truncate(totalMonths * 24);

                        // math to calculate number of hours
                        var totalHours = Math.Truncate(((totalDays % 365) * 24) * 60);

                        // math to calculate number of minutes
                        var totalMinutes = Math.Truncate((((totalDays % 365) * 60) * 24) * 60);

                        Console.WriteLine("Time bewteen two dates is {0} years, {1} months(s), {2} day(s), {3} Hour(s), {4} Minute(s)", totalYears, totalMonths, daysTotal, totalHours, totalMinutes);

                        // put in place so that the user has to hit a key before the program closes out
                        Console.Read();

                    }
                    else
                    {
                        Console.WriteLine("oops thats not the right date format. Please use YYYY/MM/DD.");
                        Console.Read();
                    }


                }
                else
                {
                    Console.WriteLine("oops thats not the right date format. Please use YYYY/MM/DD");
                    Console.Read();
                }
            }
    }
}
