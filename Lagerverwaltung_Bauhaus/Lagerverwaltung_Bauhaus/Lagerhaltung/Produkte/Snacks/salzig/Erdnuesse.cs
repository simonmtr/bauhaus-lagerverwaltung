﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.salzig
{
    public class Erdnuesse : Salzsnacks
    {
        public override Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, string snackArt, string lagerort)
        {
            return new Snacks(anzahl,snackName, true, "Erdnuesse", lagerort);

        }
    }
}
