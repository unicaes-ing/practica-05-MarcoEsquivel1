using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer3()
        {
            int numero, resultado;

            Console.WriteLine("Ingrese un numero entero:");
            numero = Convert.ToInt32(Console.ReadLine());
            resultado = factorial(numero);
            Console.WriteLine("El factorial de " + numero + " es:" + resultado);
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r = r * i;
            }
            return r;
        }
    }
}
