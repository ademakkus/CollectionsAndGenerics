using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * var salmons = new List<string>();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
             * */
            var baliklar = new List<string>();
            baliklar.Add("hamsi");
            baliklar.Add("alabalık");
            baliklar.Add("Çipura");
            foreach (var yenibalik in baliklar)
            {
                Console.WriteLine(yenibalik+" ");
            }
            Console.ReadKey();
        }
    }
}
