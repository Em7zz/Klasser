using System;
using System.Collections.Generic;

namespace Classer
{
    class Program
    {
        private static bool item;

        public static void Main()
        {
            List<Fordon> fordonsLista = new List<Fordon>();



            Fordon f = new Fordon();
            f.SetNamn("Audi A6");
            f.SetÅlder(2018);
            f.SetTillvärkare("Volkswagen");
            f.SetVikt(1760);
            fordonsLista.Add(f);

            Console.WriteLine(f.GetNamn());
            Console.WriteLine(f.GetTillvärkare());
            Console.WriteLine(f.GetÅlder());
            Console.WriteLine(f.GetVikt());

            Console.WriteLine("   ");

            Fordon t = new Fordon();
            t.SetNamn("traktor");
            t.SetÅlder(2019);
            t.SetTillvärkare("traktor");
            t.SetVikt(5000);
            fordonsLista.Add(t);


            Console.WriteLine(t.GetNamn());
            Console.WriteLine(t.GetÅlder());
            Console.WriteLine(t.GetTillvärkare());
            Console.WriteLine(t.GetVikt());



        }

        public static void Fordon(List<Fordon> lista)
        {
            foreach (var item in lista) ;
            Console.WriteLine(item);
        }

    }
}




    


