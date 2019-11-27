using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace Stack_
{
    class Program
    {
        /*
         *  Stack stk = new Stack();  
    stk.Push("cs.net");  
    stk.Push("vb.net");  
    stk.Push("asp.net");  
    stk.Push("sqlserver");  
       
    foreach (object o in stk)  
    {  
       Response.Write(o + "<br>");  
    }  
         * */
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            foreach (object o in stk)
            {
                WriteLine(o + " ");
            }

            ReadKey();
        }
    }
}
