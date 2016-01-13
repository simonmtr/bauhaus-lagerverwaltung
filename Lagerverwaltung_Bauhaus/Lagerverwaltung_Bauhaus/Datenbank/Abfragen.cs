using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Datenbank
{
    public class Abfragen
    {
        public Abfragen() { }
        public List<Snacks>getSuessSnacks()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Snackss where b.istSalzig == true select b;
                return query.ToList();
            }
        }
        public List<Snacks> getSalzSnacks()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Snackss where b.istSalzig == false select b;
                return query.ToList();
            }
        }
        public List<Getraenk> getLagerGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks where b.lagerort.Equals("Lager") select b;
                return query.ToList();
            }
        }
        public List<Getraenk> getBarGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks where b.lagerort.Equals("Bar") select b;
                return query.ToList();
            }
        }
        public List<Getraenk> getThekeGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks where b.lagerort.Equals("Theke") select b;
                return query.ToList();
            }
        }
        public List<Getraenk> getGesamtGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks select b;
                return query.ToList();
            }
        }


        public void getraenkAusDbLoeschen(string getraenkeName)
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                   

                    var query = from b in db.Getraenks where b.getraenkeName.Equals(getraenkeName) select b;
                    foreach (var b in query)
                    {
                        db.Getraenks.Remove(b);
                    }

                    db.SaveChanges();
                }
                catch (EntryPointNotFoundException e)
                {
                    MessageBox.Show("Dieser Eintrag existiert nicht.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.");
                }
            }
        }
        public void snackAusDbLoeschen(string snackName)
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Snackss where b.snackName.Equals(snackName) select b;
                  
                    foreach (var a in query)
                    {
                        db.Snackss.Remove(a);
                    }
                    db.SaveChanges();
                }
                catch (EntryPointNotFoundException e)
                {
                    MessageBox.Show("Dieser Eintrag existiert nicht.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.");
                }
            }
        }

        public void getraenkZuDbHinzufuegen(double fuellmenge, string alkohol, int anzahl, string getraenkeName, string getraenkeArt,string lagerort)
        {
            using (var db = new Lagerbestand())
            {

                var query = from b in db.Getraenks where b.getraenkeName == getraenkeName select b;
                try
                {
                    int aktAnzahl = query.First().anzahl;
                    aktAnzahl = aktAnzahl + anzahl;
                }
                catch (Exception e)
                {
                    
                }
                if (alkohol.Equals("Ja"))
                {
                    var getraenk1 = new Getraenk
                    {
                        Fuellmenge = fuellmenge,
                        Alkohol = true,
                        Anzahl = anzahl,
                        GetraenkeName = getraenkeName,
                        getraenkeArt = getraenkeArt,
                        lagerort = lagerort
                    };
                    db.Getraenks.Add(getraenk1);
                }
                else
                {
                    var getraenk = new Getraenk
                    {
                        Fuellmenge = fuellmenge,
                        Alkohol = false,
                        Anzahl = anzahl,
                        GetraenkeName = getraenkeName,
                        getraenkeArt = getraenkeArt,
                        lagerort = lagerort
                    };
                    db.Getraenks.Add(getraenk);
                }
                db.SaveChanges();
            }
        }

        public void snackZuDbHinzufuegen(int anzahl, string snackName, bool istSalzig, string snackArt, string lagerort)
        {
            using (var db = new Lagerbestand())
            {

                var query = from b in db.Snackss where b.snackName == snackName select b;
                try
                {
                    int aktAnzahl = query.First().anzahl;
                    aktAnzahl = aktAnzahl + anzahl;
                }
                catch (Exception e)
                {

                }
                var snack = new Snacks
                {
                    Anzahl = anzahl,
                    SnackName = snackName,
                    IstSalzig = istSalzig,
                    SnackArt=snackArt,
                    lagerort = lagerort

                };
                db.Snackss.Add(snack);
                db.SaveChanges();

            }
        }

    }
}