using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool leapYear;
            while (true)
            {
                Console.WriteLine("Ange ett årtal för att kontollera om det är ett skottår.");
                Console.WriteLine("För att avsluta programmet, ange år noll (0).");
                Console.Write("-->");
                year = int.Parse(Console.ReadLine());

                if (year==0)
                {
                    break;
                }
                else
                {
                    leapYear = IsLeapYear(year);
                }
                if (leapYear)
                {
                    Console.WriteLine("Årtalet är ett skottår (det har 366 dagar).");
                }
                else
                {
                    Console.WriteLine("Årtalet är inte ett skottår (det har 365 dagar).");
                }
            }
        }

        public static bool IsLeapYear(int year)
        {
            bool isLeapYear;

            if (year%4==0)
            {
                if (year%100==0)
                {
                    if (year%400==0)
                    {
                        isLeapYear = true;
                    }
                    else
                    {
                        isLeapYear = false;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = false; 
            }

            return isLeapYear;
        }
    }
}
