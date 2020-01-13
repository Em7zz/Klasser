using System;
using System.Collections.Generic;
using System.Text;

namespace Classer
{
    class Fordon
    {
        private string namn;
        private int årsModel;
        private string tillvärkare;
        private int vikt;


        public Fordon(string n, int å, string t, int v)
        {
            namn = n;
            årsModel = å;
            tillvärkare = t;
            vikt = v;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public int ÅrsModel
        {
            get { return årsModel; }
            set { årsModel = value; }
        }
        public string Tillvärkare
        {
            get { return tillvärkare; }
            set { tillvärkare = value; }
        }
        public int Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }

  
    }
}
