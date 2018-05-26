using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionnelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal compte = 300;
            bool estCrediteur = (compte >= 0);
            if (compte >= 0)
                Console.WriteLine("Votre compte est créditeur");
            else
                Console.WriteLine("Votre compte est débiteur");
        }
    }
}
