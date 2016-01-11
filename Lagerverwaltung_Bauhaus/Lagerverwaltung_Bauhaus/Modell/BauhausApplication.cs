using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Modell
{
    class BauhausApplication
    {
        private ILagerGetraenk lagerGetraenk;
        private ILagerSnack lagerSnack;

        public BauhausApplication(ILagerGetraenk lagerG, ILagerSnack lagerS)
        {
            lagerGetraenk = lagerG;
            lagerSnack = lagerS;
        }


        public void Start()
        {
            //GUI Hauptbildschirm öffnen
        }
        public void Exit()
        {
            //Programm beenden
        }




        //hinzufügen
        public void getraenkInDbSpeichern(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk)
        {
            using (var db = new Getraenkebestand123())
            {
                var getraenk = new Getraenk
                {
                    Fuellmenge = fuellmenge,
                    Alkohol = alkohol,
                    Anzahl = anzahl,
                    GetraenkeName=getraenkeName,
                    enumGetraenk =enumGetraenk,
                };
                db.Getraenks.Add(getraenk);
                db.SaveChanges();

            }
        }

        public void snackInDbSpeichern(int anzahl, string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt)
        {
            using (var db = new Snackbestand123())
            {
                var snack = new Snacks
                {
                    Anzahl = anzahl,
                    SnackName = snackName,
                    IstSalzig = istSalzig,
                    enumSnack = snackArt,
                };
                db.Snackss.Add(snack);
                db.SaveChanges();

            }
        }


        //entfernen
        public void getraenkAusDbLoeschen(int anzahl, string getraenkeName)
        {
            using (var db = new Getraenkebestand123())
            {
                Getraenk getraenk = db.Getraenks.Find(getraenkeName);
               // db.Remove(getraenk);
                db.SaveChanges();
            }
        }

        public void snackAusDbLoeschen(int anzahl, string snackName)
        {
            using (var db = new Snackbestand123())
            {
                Snacks snack = db.Snackss.Find(snackName);
               // db.Remove(snack);
                db.SaveChanges();
            }
        }

        


        
    }
}
