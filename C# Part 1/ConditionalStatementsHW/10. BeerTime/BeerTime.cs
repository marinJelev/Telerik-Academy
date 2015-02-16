﻿//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according 
//to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;
using System.Threading;

namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.Write("Enter a time in the following format hh:mm tt - ");
            string input = Console.ReadLine();

            Console.WriteLine();

            try
            {
                DateTime dateTime = DateTime.ParseExact(input, "h:mm tt",
                                        CultureInfo.InvariantCulture);
                TimeSpan time = dateTime.TimeOfDay;
                TimeSpan start = new TimeSpan(13, 0, 0);
                TimeSpan end = new TimeSpan(03, 0, 0);

                if ((time >= start) || (time < end))
                {
                    Console.WriteLine("BEER time.");
                }
                else
                {
                    Console.WriteLine("NON-BEER time.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time.");
            }
        }
    }
}
