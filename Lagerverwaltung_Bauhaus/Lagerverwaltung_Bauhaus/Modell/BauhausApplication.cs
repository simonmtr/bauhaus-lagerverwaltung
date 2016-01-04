using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lagerverwaltung_Bauhaus.Interfaces;

namespace Lagerverwaltung_Bauhaus.Modell
{
    class BauhausApplication
    {
        private ILagerGetraenk lagerGetraenk;
        private ILagerSnack lagerSnack;

        public BauhausApplication(ILagerGetraenk lagerG, ILagerSnack lagerS)
        {
            lagerGetraenk = lagerG;
            lagerSnack = lagerS;
        }


        public void Start()
        {
            //GUI Hauptbildschirm öffnen
        }
        public void Exit()
        {
            //Programm beenden
        }




        //hinzufügen
     //   public void getraenkHinzufügen()
    //    {

            //        }
            //        public snackHinzufügen()
            //        {

            //        }

            ////entfernen
            //        public getraenkEntfernen()
            //        {

            //        }
            //        public snackEntfernen()
            //        {

            //        }

            ////speichern
            //        public bestandSpeichernGetraenk()
            //        {

            //        }
            //        public bestandSpeichernSnack()
            //        {

            //        }


        }
}
