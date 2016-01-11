﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks.salzig
{
    public class Salzstangen : Salzsnacks
    {
        public override Snacks erstelleSnack(int anzahl,string snackName, bool istSalzig, ENUMsnackArt.snackArt enumSnack)
        {
            return new Snacks(anzahl,snackName, true, snackArt.Salzstangen);
        }
    }
}
