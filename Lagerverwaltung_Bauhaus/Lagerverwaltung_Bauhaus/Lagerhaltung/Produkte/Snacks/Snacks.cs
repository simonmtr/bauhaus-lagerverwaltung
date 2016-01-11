using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks
{
    public class Snacks : ENUMsnackArt, ISnack
    {
        //variablen
        int anzahl;
        public string snackName;
        public bool istSalzig;
        public ENUMsnackArt.snackArt enumSnack;

        //konstruktor
        public Snacks()
        {
        }
        public Snacks(int anzahl,string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt)
        {
            this.anzahl = anzahl;
            this.snackName = snackName;
            this.istSalzig = istSalzig;
            this.enumSnack = snackArt;
        }

        public virtual Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt)
        {
            return new Snacks(anzahl,snackName, istSalzig, snackArt);
        }

        // datenbank

        public int SnacksId { get; set; }


        //getter und setter
        public int Anzahl
        {
            get; set;
        }
        public string SnackName
        {
            get;
            set;
        }
        public bool IstSalzig
        {
            get;
            set;
        }
        

    }
}
