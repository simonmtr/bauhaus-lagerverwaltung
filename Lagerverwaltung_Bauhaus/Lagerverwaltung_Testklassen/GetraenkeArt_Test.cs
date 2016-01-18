using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke.alkoholisch;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;

namespace Lagerverwaltung_Testklassen
{
    public class GetraenkeArt_Test
    {
        public void bierTest()
        {
            Bier bier = new Getraenk(0.5, true, 1,  "Augustiner", "Bier",  "Lager") as Bier;


            string getraenkart = bier.GetraenkeArt;

        }
        
    }
}
