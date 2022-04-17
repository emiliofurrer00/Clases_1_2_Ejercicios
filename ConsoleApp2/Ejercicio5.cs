using System;
using System.Collections.Generic;
using System.Threading;

namespace Soluciones
{
    class Ejercicio5
    {
        public static void Solucion()
        {
            Console.WriteLine("Comparar las edades de dos personas.");

            Console.WriteLine("Nombre de persona nº1:");
            string name1 = Console.ReadLine();
            if (name1 == ""){
                name1 = "Persona nº1";
            }
            Console.WriteLine("Edad de persona nº1:");
            int edad1 = Program.ValidarIntInput();

            Console.WriteLine("Nombre de persona nº2:");
            string name2 = Console.ReadLine();
            if (name2 == "")
            {
                name2 = "Persona nº2";
            }
            Console.WriteLine("Edad de persona nº2:");
            int edad2 = Program.ValidarIntInput();

            Console.Clear();
            Console.WriteLine($"{name1}, {edad1} || {name2}, {edad2}");
            if (edad1 > edad2)
            {
                Console.WriteLine($"{name1} es MAYOR que {name2}. La diferencia es de {edad1 - edad2} años.");
            }
            else if (edad2 > edad1)
            {
                Console.WriteLine($"{name2} es MAYOR que {name1}. La diferencia es de {edad2 - edad1} años.");
            }
            else {
                Console.WriteLine($"{name1} y {name2} tienen la misma edad.");
            }
            Thread.Sleep(1500);
            Console.WriteLine("Regresando al menú principal...");
            Thread.Sleep(5000);
        }
    }
}
