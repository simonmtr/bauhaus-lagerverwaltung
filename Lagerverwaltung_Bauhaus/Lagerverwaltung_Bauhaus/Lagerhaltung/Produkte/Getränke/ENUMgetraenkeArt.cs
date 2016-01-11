using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke
{
    public class ENUMgetraenkeArt
    {

        public enum getraenkeArt
        {
            Bier, Wein, Schnaps, Saft, Softdrink, Wasser, Kaffee
        }
        public enum fuellMengeInMl
        {
            halberLiter=500,ganzerLiter=1000,einEinHalbLiter=1500
        }
        public enum alkohol
        {
            ja, nein
        }
        public enum getraenkeName
        {

        }
        public enum getraenkeMarke
        {

        }
    }
}
