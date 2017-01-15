using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlasciwosci1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.Wiek = 21;  //set
            Console.WriteLine(osoba1.Wiek); //get
            Console.ReadKey();


        }
    }
}
