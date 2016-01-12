using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;

namespace Lagerverwaltung_Bauhaus.Modell
{
    public class BauhausApplication
    {
        //private ILagerGetraenk lagerGetraenk;
        //private ILagerSnack lagerSnack;


        public BauhausApplication()
        {
        }
        public void dbErzeugen(){
            using (var db = new Lagerbestand())
            {
            }
        }



        


        
    }
}
