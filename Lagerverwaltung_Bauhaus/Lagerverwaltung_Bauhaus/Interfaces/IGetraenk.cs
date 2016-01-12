using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;

namespace Lagerverwaltung_Bauhaus.Interfaces
{
    public interface IGetraenk
    {
        Getraenk erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, string getraenkeArt, string lagerort);
    }
}
