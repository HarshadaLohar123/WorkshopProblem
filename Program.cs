using System;

namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Arguments
            Console.WriteLine("Hello Welcome to day month year");
            Console.WriteLine("Please enter the month in the formt of(1-12)");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the year : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the day : ");
            int d = int.Parse(Console.ReadLine());

            //variable
            int yy = 0;
            int xx = 0;
            int mm = 0;
            int dd;

            //Main Logic (Gregorian calender)
            yy = y - (14 - m) / 12;
            xx = yy + yy / 4 - yy / 100 + yy / 400;
            mm = m + 12 * ((14 - m) / 12) - 2;
            dd = (d + xx + 31 * mm / 12) % 7;

            //switch case for finding particular weekday
            switch(dd)
            {
                case 0:
                    Console.WriteLine("That particular day is Sunday:");
                    break;
                case 1:
                    Console.WriteLine("That particular day is Monday:");
                    break;
                case 2:
                    Console.WriteLine("That particular day is Tuesday:");
                    break;
                case 3:
                    Console.WriteLine("That particular day is Wednesday:");
                    break;
                case 4:
                    Console.WriteLine("That particular day is Thursday :");
                    break;
                case 5:
                    Console.WriteLine("That particular day is Friday:");
                    break;
                case 6:
                    Console.WriteLine("That particular day is Saturday:");
                    break;
                default:
                    Console.WriteLine("Please enter the Perfect value");
                    break;


            }

        }
    }
}
