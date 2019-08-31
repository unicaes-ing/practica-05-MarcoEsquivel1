using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio5
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer5()
        {
            decimal precio, descuento= 0, pago, si_no;
            do
            {
                Console.WriteLine("Ingrese el precio del producto");
                precio = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();
            } while (precio <= 0);
            do
            {
                Console.WriteLine("Desea ingresar un descuento 1-Si 2-no");
                si_no = Convert.ToInt32(Console.ReadLine());
            } while (si_no != 1 && si_no != 2);
            if (si_no == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese el procentaje de descuento sin el simbolo \"%\" \"0\" si no quiere agregar descuento");
                    descuento = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();
                } while (descuento < 0 || descuento > 100);
            }
            
            pago = des(precio, descuento);
            Console.WriteLine("El precio a pagar es: {0}", pago.ToString("c2"));
            Console.ReadKey();
            Console.Clear();
        }
        static decimal des(decimal p, decimal d)
        {
            decimal pag;
            d = 1 - (d / 100);
            pag = p * d;
            return pag;
        }
    }
}
