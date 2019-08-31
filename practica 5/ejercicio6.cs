using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
    class ejercicio6
    {
        //Marco René Esquivel Juárez
        //21-Agosto
        public void ejer6()
        {
            int estudiantes;
            List<decimal> calificaciones = new List<decimal>();
            decimal nota;
            do
            {
                Console.WriteLine("Ingrese la cantidad de alumnos");
                estudiantes = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (estudiantes <= 0);
            for (int i = 0; i < estudiantes; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese la nota del alumno {0}", i + 1);
                    nota = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();
                } while (nota < 0 || nota > 10);
                calificaciones.Add(nota);
            }

            Console.WriteLine("El promedio de notas es: {0} ", prom(calificaciones));
            Console.ReadKey();
        }

        static decimal prom(List<decimal> p)
        {
            decimal t= 0.00m;
            foreach (var item in p)
            {
                t = t + item;
            }
            return t / p.Count;
        }
    }
}
