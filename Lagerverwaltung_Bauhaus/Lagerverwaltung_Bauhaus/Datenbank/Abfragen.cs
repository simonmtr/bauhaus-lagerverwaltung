using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;

namespace Lagerverwaltung_Bauhaus.Datenbank
{
    public class Abfragen
    {
        public Abfragen() { }
        public void getSuessSnacks()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Snackss where b.istSalzig == true select b;
            }
        }
        public void getSalzSnacks()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Snackss where b.istSalzig == false select b;
            }
        }
        public void getLagerGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Snackss where b.enumLagerort == ENUMLagerort.Lagerort.Lager select b;
            }
        }
        public List<Getraenk> getBarGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Bar select b;
                return query.ToList();
            }
        }
        public void getThekeGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Theke select b;
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

        public void getraenkZuDbHinzufuegen(double fuellmenge, bool alkohol, int anzahl, string getraenkeName, ENUMgetraenkeArt.getraenkeArt enumGetraenk, ENUMLagerort.Lagerort enumLagerort)
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
                var getraenk = new Getraenk
                {
                    Fuellmenge = fuellmenge,
                    Alkohol = alkohol,
                    Anzahl = anzahl,
                    GetraenkeName = getraenkeName,
                    enumGetraenk = enumGetraenk,
                    enumLagerort = enumLagerort

                };
                db.Getraenks.Add(getraenk);
                db.SaveChanges();
            }

        }

        public void snackZuDbHinzufuegen(int anzahl, string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt, ENUMLagerort.Lagerort enumLagerort)
        {
            using (var db = new Lagerbestand())
            {

                var query = from b in db.Snackss where b.snackName == snackName select b;
                int aktAnzahl = query.First().anzahl;
                aktAnzahl = aktAnzahl + anzahl;
                db.SaveChanges();

            }
        }

    }
}