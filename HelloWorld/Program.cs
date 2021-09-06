using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a name to check if it is a leap year :)");
        }

        public static bool IsLeapYear(int year)
        {
            if (year%4==0&&year%100!=0)
            {
                return true;
            }
            else if (year%400==0)
            {
                return true;
            }
            return false;
        }
    }
}
