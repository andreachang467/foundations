using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            string strName; //declare a string type to read the input from console
            Console.WriteLine("Please enter the number of seconds you want converted into days, hours, minutes, and seconds");
            strName = Console.ReadLine(); //store the input


            int intVal = int.Parse(strName);  //try to "Parse" the string into a decimal


            int Days = intVal / 86400;   // Dividing the number inputed by the number of seconds in a day to find out how many days there are
            Console.WriteLine("Days: {0}", Days);   //writing out the number of days

            int DayRemainder = intVal % 86400;    // Finding the remainder of days in seconds
            int Hours = DayRemainder / 3600;      // Diving remainder seconds by seconds in an hour to find number of hours 
            Console.WriteLine("Hours: {0}", Hours);   //writing out the number of hours

            int MinutesRemainder = DayRemainder % 3600;   //Finding the remainder of minutes in seconds
            int Minutes = MinutesRemainder / 60;          // Dividing remainder seconds by seconds in a minute to find number of minutes
            Console.WriteLine("Minutes: {0}", Minutes);       // writing out the number of minutes

            int SecondsRemainder = MinutesRemainder % 60;  //Finding the remainder of seconds in seconds
            Console.WriteLine("Seconds: {0}", SecondsRemainder);   //writing out the number of seconds

            Console.ReadLine();




        }




    }
}
