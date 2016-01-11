using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung
{
    public class Getraenkebestand123:DbContext
    {
        
        public DbSet<Getraenk> Getraenks { get; set; }

        public List<Getraenk> getGetraenkDatenbank()
        {
            List<Getraenk> getraenkDatenbank = new List<Getraenk>();
            using (var db = new Getraenkebestand123())
            {
                var query = from b in db.Getraenks orderby b.getraenkeName select b;
            foreach (Getraenk item in query)
                {
                    getraenkDatenbank.Add(item);
                }
            }
            return getraenkDatenbank;
        }
    }
}
