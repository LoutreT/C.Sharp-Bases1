using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoisDePrintemps
{
    class Program
    {
        static void Main(string[] args)
        {
            string mois = Avril;
            switch (mois)
            {
                case "Mars":   // Attention ici il y a 2 points à la fin de la ligne.
                case "Avril":  // Attention ici il y a 2 points à la fin de la ligne.
                case "Mai":    // Attention ici il y a 2 points à la fin de la ligne.
                    Console.WriteLine("C'est bien le printemps");
                    break;
            }
        }
    }
}
