using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace StringGenericSwapMethod
{


    class Program
    {
        
        static void Main(string[] args)
        {
            string fString, sString;
            ForegroundColor = DarkGreen;
            Console.Write("İnput first string :");
            fString = ReadLine();
            Console.Write("İnput second string :");
            sString = ReadLine();
            ForegroundColor = DarkRed;
            Console.WriteLine($"String {fString} and {sString} before string concatenation." );
            StringSwapClass.StringSwap<string>(ref fString,ref sString);
            ForegroundColor = DarkMagenta;
            Console.WriteLine($"String {fString} and {sString} after  string concatenation.");

            int s1 = 12;
            int s2 = 2333;
            ForegroundColor = DarkGreen;
            Console.WriteLine($"Number  {s1} and {s2} before int swapping.");
            StringSwapClass.StringSwap<int>(ref s1,ref s2);
            ForegroundColor = DarkGray;
            Console.WriteLine($"Number {s1} and {s2} after  int swapping.");
            ReadKey();
        }
    }
}
