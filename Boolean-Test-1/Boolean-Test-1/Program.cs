using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            bool estAgeDe30Ans = age == 30; 
            Console.WriteLine(estAgeDe30Ans); //. affichera TRUE
            bool estSuperieurA10 = age > 10; 
            Console.WriteLine(estSuperieurA10); //. affichera TRUE
            bool estDifferentDe30 = age != 30; 
            Console.WriteLine(estDifferentDe30); //. affichera FALSE
        }
    }
}
