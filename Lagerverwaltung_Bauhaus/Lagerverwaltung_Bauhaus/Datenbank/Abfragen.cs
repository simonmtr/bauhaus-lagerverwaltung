using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Snacks;
using Lagerverwaltung_Bauhaus.Factory;

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
                    MessageBox.Show("Es gibt keine süßen Snacks.","Nicht vorhanden",MessageBoxButton.OK,MessageBoxImage.Error);
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
                    MessageBox.Show("Es gibt keine salzigen Snacks.","Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Es gibt keine Getränke im Lager.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Es gibt keine Getränke in der Bar.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Es gibt keine Getränke im Kühlschrank.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Es gibt keine Getränke.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }

            }
        }


        public void getraenkAusDbLoeschen(string fuellmenge, string alkohol, string anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            ObjektverwaltungFactory obFac = new ObjektverwaltungFactory();
            using (var db = new Lagerbestand())
            {

                try
                {
                    var query1 = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName)&&b.Lagerort.Equals(lagerort) select b;
                    int aktAnzahl = query1.First().Anzahl;
                    int vorhergesagteAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    aktAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    if (vorhergesagteAnzahl < 0)
                    {
                        MessageBox.Show("Sie haben nicht so viele Getränke auf Lager wie gelöscht werden sollen.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        if (vorhergesagteAnzahl == 0)
                        {
                            var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) && b.Lagerort.Equals(lagerort)  select b;
                            foreach (var a in query)
                            {
                                db.Getraenks.Remove(a);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            try
                            {
                                var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) && b.Lagerort.Equals(lagerort) select b;
                                foreach (var a in query)
                                {
                                    db.Getraenks.Remove(a);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception caught.", e);
                            }

                            var getraenk1 = obFac.welchesGetraenk(fuellmenge, alkohol, aktAnzahl.ToString(), getraenkeName, getraenkeArt, lagerort);


                            db.Getraenks.Add(getraenk1);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Das Getränk wurde erfolgreich gelöscht.","INFO",MessageBoxButton.OK,MessageBoxImage.Information);
                    }
                    
                    

                }
                catch
                {
                    MessageBox.Show("Es kann kein Getraenk entfernt werden dass es nicht gibt.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
        }
        public void snackAusDbLoeschen(string anzahl, string snackName, string istSalzig, string snackArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            ObjektverwaltungFactory obFac = new ObjektverwaltungFactory();
            using (var db = new Lagerbestand())
            {
                try
                {
                    var query1 = from b in db.Snackss where b.SnackArt.Equals(snackArt) && b.Lagerort.Equals(lagerort)  select b;
                    int aktAnzahl = query1.First().Anzahl;
                    int vorhergesagteAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    aktAnzahl = aktAnzahl - stringToX.stringToAnzahl(anzahl);
                    if (vorhergesagteAnzahl < 0)
                    {
                        MessageBox.Show("Sie haben nicht so viele Getränke auf Lager wie gelöscht werden sollen.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        if (vorhergesagteAnzahl == 0)
                        {
                            var query = from b in db.Snackss where b.SnackName.Equals(snackName) && b.Lagerort.Equals(lagerort)  select b;
                            foreach (var a in query)
                            {
                                db.Snackss.Remove(a);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            try
                            {
                                var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) && b.Lagerort.Equals(lagerort)  select b;
                                foreach (var a in query)
                                {
                                    db.Snackss.Remove(a);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception caught.", e);
                            }

                            var snack = obFac.welcherSnack(aktAnzahl.ToString(), snackName, istSalzig, snackArt, lagerort);

                            db.Snackss.Add(snack);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Der Snack wurde erfolgreich gelöscht.", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);

                    }


                        

                }
                catch
                {
                    MessageBox.Show("Es kann kein Snack entfernt werden dass es nicht gibt.", "Nicht vorhanden", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        public void getraenkZuDbHinzufuegen(string fuellmenge, string alkohol, string anzahl, string getraenkeName, string getraenkeArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            ObjektverwaltungFactory obFac = new ObjektverwaltungFactory();

            using (var db = new Lagerbestand())
            {
                
                    try
                    {
                        var query1 = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) && b.Lagerort.Equals(lagerort) select b;
                        int aktAnzahl = query1.First().Anzahl;
                        aktAnzahl = aktAnzahl + stringToX.stringToAnzahl(anzahl);
                        try
                        {
                            var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) && b.Lagerort.Equals(lagerort)  select b;
                            foreach (var a in query)
                            {
                                db.Getraenks.Remove(a);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception caught.", e);
                        }

                    var getraenk1 = obFac.welchesGetraenk(fuellmenge, alkohol, aktAnzahl.ToString(), getraenkeName, getraenkeArt, lagerort);
                        db.Getraenks.Add(getraenk1);
                    MessageBox.Show("Das Getränk wurde hinzugefügt.", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    db.SaveChanges();

                    }
                    catch
                    {
                        try
                        {
                            var query = from b in db.Getraenks where b.GetraenkeName.Equals(getraenkeName) && b.Lagerort.Equals(lagerort) select b;
                            foreach (var a in query)
                            {
                                db.Getraenks.Remove(a);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception caught.", e);
                        }

                    var getraenk = obFac.welchesGetraenk(fuellmenge, alkohol, anzahl, getraenkeName, getraenkeArt, lagerort);
                    db.Getraenks.Add(getraenk);
                    MessageBox.Show("Das Getränk wurde hinzugefügt.", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    db.SaveChanges();
                    }

                

            }



        }


        public void snackZuDbHinzufuegen(string anzahl, string snackName, string istSalzig, string snackArt, string lagerort)
        {
            DatenbankChecks stringToX = new DatenbankChecks();
            ObjektverwaltungFactory obFac = new ObjektverwaltungFactory();

            using (var db = new Lagerbestand())
            {
                try
                {
                    var query1 = from b in db.Snackss where b.SnackArt.Equals(snackArt) && b.Lagerort.Equals(lagerort) select b;
                    int aktAnzahl = query1.First().Anzahl;
                    aktAnzahl = aktAnzahl + stringToX.stringToAnzahl(anzahl);
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) && b.Lagerort.Equals(lagerort) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack1 = obFac.welcherSnack(aktAnzahl.ToString(), snackName, istSalzig, snackArt, lagerort);
                    

                    db.Snackss.Add(snack1);
                    MessageBox.Show("Der Snack wurde hinzugefügt.", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    db.SaveChanges();

                }
                catch
                {
                    try
                    {
                        var query = from b in db.Snackss where b.SnackArt.Equals(snackArt) && b.Lagerort.Equals(lagerort) select b;
                        foreach (var a in query)
                        {
                            db.Snackss.Remove(a);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception caught.", e);
                    }

                    var snack = obFac.welcherSnack(anzahl,  snackName,  istSalzig,  snackArt,  lagerort);

                    db.Snackss.Add(snack);
                    MessageBox.Show("Der Snack wurde hinzugefügt.", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    db.SaveChanges();
                }
            }






        }
    }
}
    
