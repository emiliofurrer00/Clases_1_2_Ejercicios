using System;
using System.Threading;

namespace Soluciones
{
    class Ejercicio3
    {
        public static void Solucion()
        {
            Console.WriteLine("Ingresar número entero a determinar si es el doble de un impar.");
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
            //Si bien hacerlo con ints lo redondea, los resultados sirven correctamente
            int mitad = value / 2;
            Console.WriteLine(mitad);
            Console.WriteLine($"La mitad del número {value} {(mitad % 2 > 0 ? "ES" : "NO ES")} IMPAR.");
            Thread.Sleep(1500);
            Console.WriteLine("Regresando al menú principal...");
            Thread.Sleep(3000);
        }
    }
}
