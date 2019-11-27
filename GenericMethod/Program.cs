using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace GenericMethod
{
    class Program
    {
        /*
         * static void Swap<T>(ref T lhs, ref T rhs)
{
    T temp;
    temp = lhs;
    lhs = rhs;
    rhs = temp;
}
         * 
         * */
         static void Swap<T>(ref T birinci,ref T ikinci)
        {

            T temp;
            temp = birinci;
            birinci = ikinci;
            ikinci = temp;

        }
        static void Main(string[] args)
        {
            int s1 = 12;
            int s2 = 15;
            ForegroundColor = DarkYellow;
            Console.WriteLine("before swapping a={0},and b={1}", s1, s2);
            Swap<int>(ref s1, ref s2);
            ForegroundColor = DarkGreen;
            Console.WriteLine("Swapped a={0},and b={1}",s1,s2);
            ReadKey();
        }
    }
}
