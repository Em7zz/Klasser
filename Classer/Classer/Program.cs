using System;

namespace Classer
{
    class Program
    {
        public static void Main()
        {

            Fordon f = new Fordon();
            f.SetNamn("Audi A6");
            f.SetÅlder(2018);
            f.SetTillvärkare("Volkswagen");
            f.SetVikt(1760);

            Console.WriteLine(f.GetNamn());
            Console.WriteLine(f.GetTillvärkare());
            Console.WriteLine(f.GetÅlder());
            Console.WriteLine(f.GetVikt());


            Fordon t = new Fordon();
            t.SetNamn("traktor");
            t.SetÅlder();
            t.

        }

    }
}

