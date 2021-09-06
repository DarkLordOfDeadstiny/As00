using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int indput;
            if (args != null && args.Length != 1)
            {
                Console.WriteLine("Enter a year after 1582 to check if it is a leap year :)");
                indput = getIndput();
            }
            else
            {
                indput = Convert.ToInt32(args[0]);
            }
            
            if (indput>=1582)
            {
                printAnswer(IsLeapYear(indput));
            }
        }

        static int getIndput()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("try again with a year as a real number larger than 1582");
                return getIndput();
            }
        }

        static void printAnswer(bool isLeapYear)
        {
            if (isLeapYear)
            {
                Console.WriteLine("yay");
                return;
            }
            Console.WriteLine("nay");
        }

        public static bool IsLeapYear(int year)
        {
            if ((year%4 == 0 && year%100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
