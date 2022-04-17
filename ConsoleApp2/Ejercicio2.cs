using System;
using System.Threading;

namespace Soluciones
{
    class Ejercicio2
    {
        public static void Solucion(){
            Console.WriteLine("Ingresar número entero a determinar si es par.");
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
            Console.WriteLine($"El número {value} es {(value % 2 > 0 ? "IMPAR" : "PAR")}");
            Thread.Sleep(1500);
            Console.WriteLine("Regresando al menú principal...");
            Thread.Sleep(3000);
        }
    }
}
