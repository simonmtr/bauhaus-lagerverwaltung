using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Lagerhaltung
{
    public class Snackbestand123 : DbContext
    {
        public DbSet<Snacks> Snackss { get; set; }

        public List<Snacks> getSnackDatenbank()
        {
            List<Snacks> snackDatenbank = new List<Snacks>();
            using (var db = new Snackbestand123())
            {
                var query = from b in db.Snackss orderby b.snackName select b;
                foreach (Snacks item in query)
                {
                    snackDatenbank.Add(item);
                }
            }
            return snackDatenbank;
        }
    }
}
