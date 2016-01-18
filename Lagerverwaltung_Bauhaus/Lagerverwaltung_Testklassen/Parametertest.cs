using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
namespace Lagerverwaltung_Testklassen
{
    [TestClass]
    public class Parametertest
    {
      
        
            
        [TestMethod]
        public void TestMethod1()
        {
            Getraenk g = new Getraenk();

            g.erstelleGetraenk(g.Fuellmenge = 0.5, g.Alkohol = true, g.Anzahl = 1, g.GetraenkeName = "Augustiner", g.GetraenkeArt = "Bier",g.Lagerort = "Lager");


            //Erwartete Ausgabe: Lagerort
            string abc = g.Lagerort;
            Console.WriteLine(abc);
            Console.ReadKey();
        }
    }
}
