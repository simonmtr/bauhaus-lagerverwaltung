using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung;

namespace Lagerverwaltung_Bauhaus.Factory
{
    class ObjektverwaltungFactory
    {
        private Getraenkebestand getraenkeBestand;
        private Snackbestand snackBestand;
        public ObjektverwaltungFactory()
        {
            getraenkeBestand = new Getraenkebestand();
            snackBestand = new Snackbestand();
        }
    }
}
