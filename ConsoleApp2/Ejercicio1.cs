using System;
using System.Collections.Generic;
using System.Threading;

namespace Soluciones
{
    class Ejercicio1
    {
        public static void Solucion()
        {
            Console.WriteLine("Ingresar número a comparar con 100.");
            bool success; int value;
            do
            {
                success = int.TryParse(Console.ReadLine(), out value);
                if (!success) 
                {
                    Console.Clear();
                    Console.WriteLine("Input invalido. Volver a intentar.");
                }
            } while (!success);
            Console.Clear();
            Console.WriteLine(value > 100 ? "El valor es MAYOR que 100." : "El valor es MENOR O IGUAL que 100");
            Thread.Sleep(1500);
            Console.WriteLine("Regresando al menú principal...");
            Thread.Sleep(3000);
            return;
        }
    }
}
