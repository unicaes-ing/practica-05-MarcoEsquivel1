using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer4()
        {
            string num1, num2, num3, num4;
            Console.WriteLine("Ingrese el primer número en formato (xxxx-xxxx)");
            num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número en formato (xxxx-xxxx)");
            num2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer número en formato (xxxx-xxxx)");
            num3 = Console.ReadLine();
            Console.WriteLine("Ingrese el cuarto número en formato (xxxx-xxxx)");
            num4 = Console.ReadLine();
            Console.WriteLine("{0}", alea(num1,num2, num3, num4));
            Console.ReadKey();
        }
        static string alea(string n1, string n2, string n3, string n4)
        {
            string ganador = " ";
            Random numran = new Random();
            int n = numran.Next(1, 4);
            switch (n)
            {
                case 1:
                    Console.WriteLine("El ganador es el numero {0}", n1);
                    break;
                case 2:
                    Console.WriteLine("El ganador es el numero {0}", n2);
                    break;
                case 3:
                    Console.WriteLine("El ganador es el numero {0}", n3);
                    break;
                case 4:
                    Console.WriteLine("El ganador es el numero {0}", n4);
                    break;
            }
            return ganador;
        }
    }
}
