using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;


namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks
{
    public class Snacks : ISnack
    {
        //variablen
        public int anzahl;
        public string snackName;
        public bool istSalzig;
        public string snackArt;
        public string lagerort;

        //konstruktor
        public Snacks()
        {
        }
        public Snacks(int anzahl,string snackName, bool istSalzig, string snackArt, string lagerort)
        {
            this.anzahl = anzahl;
            this.snackName = snackName;
            this.istSalzig = istSalzig;
            this.snackArt = snackArt;
            this.lagerort=lagerort;
        }

        public virtual Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, string snackArt,string lagerort)
        {
            return new Snacks(anzahl,snackName, istSalzig, snackArt,lagerort);
        }

        // datenbank

        public int SnacksId { get; set; }


        //getter und setter
        public int Anzahl
        {
            get;
            set;
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
        public string Lagerort
        {
            get;
            set;
        }
        public string SnackArt
        {
            get;
            set;
        }
        

    }
}
