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
        public List<Snacks> getSuessSnacks()
        {
            using (var db = new Lagerbestand())
            {
                try
                {

                    var query = from b in db.Snackss where b.IstSalzig == false select b;
                    return query.ToList();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine süßen Snacks.");
                    return null;
                }

            }
        }
        public List<Snacks> getSalzSnacks()
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Snackss where b.IstSalzig == true select b;
                    return query.ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine salzigen Snacks.");
                    return null;
                }

            }
        }
        public List<Getraenk> getLagerGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Getraenks where b.Lagerort.Equals("Lager") select b;
                    return query.ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine Getränke im Lager.");
                    return null;
                }

            }
        }
        public List<Getraenk> getBarGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Getraenks where b.Lagerort.Equals("Bar") select b;
                    return query.ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine Getränke in der Bar.");
                    return null;
                }

            }
        }
        public List<Getraenk> getThekeGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Getraenks where b.Lagerort.Equals("Theke") select b;
                    return query.ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine Getränke im Kühlschrank.");
                    return null;
                }

            }
        }
        public List<Getraenk> getGesamtGetraenke()
        {
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query = from b in db.Getraenks select b;
                    return query.ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught.", e);
                    MessageBox.Show("Es gibt keine Getränke.");
                    return null;
                }

            }
        }


        public void getraenkAusDbLoeschen(string fuellmenge, string alkohol, string anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();

            using (var db = new Lagerbestand())
            {

                try
                {
                    var query1 = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                    int aktAnzahl = query1.First().Anzahl;
                    aktAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    try
                    {
                        var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                        foreach (var a in query)
                        {
                            db.Getraenks.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var getraenk1 = new Getraenk
                    {
                        Fuellmenge = stringToX.stringToFuellmenge(fuellmenge),
                        Alkohol = stringToX.stringToBool(alkohol),
                        Anzahl = stringToX.stringToAnzahl(aktAnzahl.ToString()),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };

                    db.Getraenks.Add(getraenk1);
                    db.SaveChanges();

                }
                catch
                {
                    try
                    {
                        var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                        foreach (var a in query)
                        {
                            db.Getraenks.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var getraenk = new Getraenk
                    {
                        Fuellmenge = stringToX.stringToFuellmenge(fuellmenge),
                        Alkohol = stringToX.stringToBool(alkohol),
                        Anzahl = stringToX.stringToAnzahl(anzahl),
                        GetraenkeName = getraenkeName,
                        GetraenkeArt = getraenkeArt,
                        Lagerort = lagerort
                    };
                    db.Getraenks.Add(getraenk);
                    MessageBox.Show("Das Getränk wurde gelöscht.");
                    db.SaveChanges();
                }
            }
        }
        public void snackAusDbLoeschen(string anzahl, string snackName, string istSalzig, string snackArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query1 = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                    int aktAnzahl = query1.First().Anzahl;
                    aktAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack1 = new Snacks
                    {

                        Anzahl = stringToX.stringToAnzahl(aktAnzahl.ToString()),
                        SnackName = snackName,
                        IstSalzig = stringToX.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };

                    db.Snackss.Add(snack1);
                    db.SaveChanges();

                }
                catch
                {
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack = new Snacks
                    {
                        Anzahl = stringToX.stringToAnzahl(anzahl),
                        SnackName = snackName,
                        IstSalzig = stringToX.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                    db.Snackss.Add(snack);
                    MessageBox.Show("Der Snack wurde gelöscht.");
                    db.SaveChanges();
                }
            }
        }


        public void getraenkZuDbHinzufuegen(string fuellmenge, string alkohol, string anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            using (var db = new Lagerbestand())
            {
                
                    try
                    {
                        var query1 = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                        int aktAnzahl = query1.First().Anzahl;
                        aktAnzahl = aktAnzahl + stringToX.stringToAnzahl(anzahl);
                        try
                        {
                            var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                            foreach (var a in query)
                            {
                                db.Getraenks.Remove(a);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception caught.", e);
                        }

                        var getraenk1 = new Getraenk
                        {
                            Fuellmenge = stringToX.stringToFuellmenge(fuellmenge),
                            Alkohol = stringToX.stringToBool(alkohol),
                            Anzahl = stringToX.stringToAnzahl(aktAnzahl.ToString()),
                            GetraenkeName = getraenkeName,
                            GetraenkeArt = getraenkeArt,
                            Lagerort = lagerort
                        };

                        db.Getraenks.Add(getraenk1);
                    MessageBox.Show("Das Getränk wurde hinzugefügt.");
                    db.SaveChanges();

                    }
                    catch
                    {
                        try
                        {
                            var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) select b;
                            foreach (var a in query)
                            {
                                db.Getraenks.Remove(a);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception caught.", e);
                        }

                        var getraenk = new Getraenk
                        {
                            Fuellmenge = stringToX.stringToFuellmenge(fuellmenge),
                            Alkohol = stringToX.stringToBool(alkohol),
                            Anzahl = stringToX.stringToAnzahl(anzahl),
                            GetraenkeName = getraenkeName,
                            GetraenkeArt = getraenkeArt,
                            Lagerort = lagerort
                        };
                        db.Getraenks.Add(getraenk);
                    MessageBox.Show("Das Getränk wurde hinzugefügt.");
                    db.SaveChanges();
                    }

                

            }



        }


        public void snackZuDbHinzufuegen(string anzahl, string snackName, string istSalzig, string snackArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query1 = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                    int aktAnzahl = query1.First().Anzahl;
                    aktAnzahl = aktAnzahl + stringToX.stringToAnzahl(anzahl);
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack1 = new Snacks
                    {

                        Anzahl = stringToX.stringToAnzahl(aktAnzahl.ToString()),
                        SnackName = snackName,
                        IstSalzig = stringToX.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };

                    db.Snackss.Add(snack1);
                    MessageBox.Show("Der Snack wurde hinzugefügt.");
                    db.SaveChanges();

                }
                catch
                {
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack = new Snacks
                    {
                        Anzahl = stringToX.stringToAnzahl(anzahl),
                        SnackName = snackName,
                        IstSalzig = stringToX.stringToBool(istSalzig),
                        SnackArt = snackArt,
                        Lagerort = lagerort
                    };
                    db.Snackss.Add(snack);
                    MessageBox.Show("Der Snack wurde hinzugefügt.");
                    db.SaveChanges();
                }
            }






        }
    }
}
    
