using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wallpaper
{
    static class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(Wallpaper(0.5, 0, 2.6));

            Console.ReadKey();

        }

        public static string Wallpaper(double length, double width, double height)
        {
            if (length ==0 || width == 0 || height == 0)
            {
                return "zero";
            }

            else
            { 
            double wallSquare = 2 * (length * height + width * height);
            double squareWallpapers = (wallSquare / 5.2) * 1.15;
            int rolls = Convert.ToInt32(Math.Ceiling(squareWallpapers));

            return HumanFriendlyInteger.IntegerToWritten(rolls).ToLower();
            }
        }


        public static class HumanFriendlyInteger
        {
            static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            static string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

        public static string FriendlyInteger(int n, string leftDigits, int thousands)
        {
            if (n == 0)
            {
                return leftDigits;
            }
 
            string friendlyInt = leftDigits;
 
            if (friendlyInt.Length > 0)
            {
                friendlyInt += " ";
            }
 
            if (n < 10)
            {
                friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                friendlyInt += teens[n - 10];
            }
            else if (n < 100)
            {
                friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0);
            }
            else if (n < 1000)
            {
                friendlyInt += FriendlyInteger(n % 100, (ones[n / 100] + " Hundred"), 0);
            }
            else
            {
                friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1), 0);
            }
 
            return friendlyInt + thousandsGroups[thousands];
        }
 
        public static string IntegerToWritten(int n)
        {
            if (n == 0)
            {
                return "Zero";
            }
            else
            {
                return FriendlyInteger(n, "", 0);
            }
 
            }
        }
    }
}
