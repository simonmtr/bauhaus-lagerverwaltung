using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Datenbank;

namespace Projekt.Objektverwaltung
{
    class ObjektverwaltungFactory
    {
        private Getraenkbestand getraenkeBestand;
        private Snackbestand snackBestand;
        public ObjektverwaltungFactory()
        {
            getraenkeBestand = new Getraenkbestand();
            snackBestand = new Snackbestand();
        }
    }
}
