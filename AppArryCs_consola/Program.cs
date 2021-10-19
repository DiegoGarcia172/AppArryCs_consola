using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArryCs_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            prueba[] ArregloPrueba = new prueba[5];

            for (int i = 0; i < ArregloPrueba.Length; i++)
            {


                ArregloPrueba[i] = new prueba();
                Console.WriteLine("Cual es tu nombre? ");

                string nombre = Convert.ToString(Console.ReadLine());

                ArregloPrueba[i].nombre = nombre;

                Console.WriteLine("en que escuela estas? ");

                string escuela = Convert.ToString(Console.ReadLine());


                ArregloPrueba[i].escuela = escuela;

                Console.WriteLine("Cual es la fecha del dia de hoy? ");

                string f = Convert.ToString(Console.ReadLine());

                ArregloPrueba[i].Fecha = DateTime.Now;

                Console.WriteLine("Que carrera cursas? ");

                string C = Convert.ToString(Console.ReadLine());

                ArregloPrueba[i].carrera = C;

            }



            for (int i = 0; i < ArregloPrueba.Length; i++)
            {

                Console.WriteLine(ArregloPrueba[i].ToString());

            }

            

            Console.ReadKey();

        }
    }
}
