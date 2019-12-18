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


        public void SetNamn(string n) { namn = n; }

        public string GetNamn() { return namn; }

        public void SetÅlder(int å) { årsModel = å; }

        public int GetÅlder() { return årsModel; }

        public void SetTillvärkare(string t) { tillvärkare = t; }

        public string GetTillvärkare() { return tillvärkare; }

        public void SetVikt(int v) { vikt = v; }

        public int GetVikt() { return vikt; }
    }
}
