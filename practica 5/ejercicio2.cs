using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer2()
        {
            int num;
            string valoracion;
            Console.WriteLine("Ingrerse un número entero");
            num = Convert.ToInt32(Console.ReadLine());
            valoracion = pos_neg_0(num);
            Console.WriteLine("{0}", valoracion);
            Console.ReadKey();
        }
        static string pos_neg_0(int n)
        {
            string valo = "";
            if (n < 0)
            {
                valo = "El numero es negativo";
            }
            else
            {
                if (n == 0)
                {
                    valo = "El numero es \"0\"";
                }
                else
                {
                    valo = "El numero es positivo";
                }
            }
            return valo;
        }
    }
}
