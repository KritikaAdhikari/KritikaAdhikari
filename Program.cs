using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    internal class Program
    {


        class Calendar
        {
            static void Main()
            {
                // Example: Creating a calendar for November 2024
                int daysInMonth = 30; // November 2024 has 30 days
                int startDayOfWeek = 5; // Assuming the 1st of November starts on Friday (0=Sunday, 6=Saturday)
                int weeks = (daysInMonth + startDayOfWeek - 1) / 7 + 1;

                // Initialize a jagged array for the weeks
                int[][] calendar = new int[weeks][];

                int day = 1;

                for (int i = 0; i < weeks; i++)
                {
                    // Determine how many days are in this week
                    int daysInThisWeek = Math.Min(7, daysInMonth - day + 1 + (i == 0 ? startDayOfWeek : 0));
                    calendar[i] = new int[daysInThisWeek];

                    for (int j = 0; j < daysInThisWeek; j++)
                    {
                        if (i == 0 && j < startDayOfWeek) // Fill leading empty spaces for the first week
                        {
                            calendar[i][j] = 0; // Empty slot
                        }
                        else if (day <= daysInMonth)
                        {
                            calendar[i][j] = day++;
                        }
                    }
                }

                // Print the calendar
                Console.WriteLine("Calendar for November 2024:");
                foreach (var week in calendar)
                {
                    foreach (var d in week)
                    {
                        if (d == 0)
                        {
                            Console.Write("   "); // Empty day
                        }
                        else
                        {
                            Console.Write($"{d,2} "); // Print day
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
