using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Interfaces
{
    public interface ISnack
    {
        Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt);
    }
}
