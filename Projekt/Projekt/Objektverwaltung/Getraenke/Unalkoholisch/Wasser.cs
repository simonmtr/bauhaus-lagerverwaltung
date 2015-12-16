﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Getraenke.Unalkoholisch
{
    public class Wasser:Unalkoholisch
    {
        public override void erstelleGetraenk(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk)
        {
            this.fuellmenge = base.fuellmenge;
            this.alkohol = base.alkohol;
            this.anzahl = base.anzahl;
            this.getraenkeName = base.getraenkeName;
            this.enumGetraenk = getraenkeArt.Wasser;
        }
    }
}
