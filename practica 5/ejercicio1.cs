using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer1()
        {
            int dia;
            dia = dias();
            Console.WriteLine("Faltan {0} dias para terminar el año", dia);
            Console.ReadKey();
            Console.Clear();
        }
        static int dias()
        {
            int d;
            d = 365 - DateTime.Now.DayOfYear;
            return d;
        }
    }
}
