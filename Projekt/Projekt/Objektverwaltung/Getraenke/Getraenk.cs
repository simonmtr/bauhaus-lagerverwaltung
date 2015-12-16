using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Getraenke
{
    public class Getraenk: ENUMgetraenkeArt, IGetraenk
    {
//variablen
        public double fuellmenge;
        public bool alkohol;
        public int anzahl;
        public string getraenkeName;
        public ENUMgetraenkeArt.getraenkeArt enumGetraenk;

//konstruktor
        public virtual void erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk)
        {
            this.fuellmenge = fuellmenge;
            this.alkohol = alkohol;
            this.anzahl = anzahl;
            this.getraenkeName = getraenkeName;
            this.enumGetraenk = enumGetraenk;
        }

//getter und setter
        public double Fuellmenge
        {
            get;
            set;
        }
        public bool Alkohol
        {
            get;
            set;
        }
        public int Anzahl
        {
            get;
            set;
        }
        public string GetranekeName
        {
            get;
            set;
        }
    }
}
