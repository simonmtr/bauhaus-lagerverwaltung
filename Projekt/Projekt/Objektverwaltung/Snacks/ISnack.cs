using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Objektverwaltung.Snacks
{
    public interface ISnack
    {
        void erstelleSnack(string snackName, bool istSalzig, ENUMsnackArt.snackArt snackArt);
    }
}
