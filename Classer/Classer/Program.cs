using System;
using System.Collections.Generic;

namespace Classer
{
    class Program
    {


        public static void Main()
        {
            List<Fordon> FordonsLista = new List<Fordon>();

            Fordon f = new Fordon("R8", 2019, "Audi", 850 );
            Console.WriteLine(f.Namn);
            Console.WriteLine(f.ÅrsModel);
            Console.WriteLine(f.Tillvärkare);
            Console.WriteLine(f.Vikt);
            FordonsLista.Add(new Fordon("R8", 2019, "Audi", 850));

            Console.WriteLine("   ");      
                       
            Fordon b = new Fordon("M5", 2019, "BMW", 750);
            Console.WriteLine(b.Namn);
            Console.WriteLine(b.ÅrsModel);
            Console.WriteLine(b.Tillvärkare);
            Console.WriteLine(b.Vikt);
        }

    }
}




    


