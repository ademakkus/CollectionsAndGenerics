using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();
            ht.Add("ora", "Oracle");
            ht.Add("vb", "Visual Basic");
            ht.Add("cs", "C sharp");
            ht.Add("asp", "ASP.NET");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Keys \t\t  Values");
            Console.WriteLine("-----\t\t------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "\t\t " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
