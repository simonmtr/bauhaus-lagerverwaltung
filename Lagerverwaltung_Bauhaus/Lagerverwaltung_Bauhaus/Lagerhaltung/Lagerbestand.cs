using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung
{
    public class Lagerbestand:DbContext
    {
        
        public virtual DbSet<Getraenk> Getraenks { get; set; }
        public virtual DbSet<Snacks> Snackss { get; set; }
        public Lagerbestand()
        {
        }
    }
}
