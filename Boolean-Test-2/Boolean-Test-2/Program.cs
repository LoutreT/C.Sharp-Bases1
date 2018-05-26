using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Vincent Nassau";
            string motdepasse = "test";
            if (login == "Vincent Nassau" && motdepasse == "test")
                Console.WriteLine("Bienvenue Vincent Nassau");
            else
                Console.WriteLine("Le login incorrect");
        }
    }
}
