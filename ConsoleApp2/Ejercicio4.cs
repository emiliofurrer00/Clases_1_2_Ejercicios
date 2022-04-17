using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluciones
{
    class Ejercicio4
    {
        public static void Solucion() 
        {
            Console.WriteLine("Ingresar número entero del 1 al 10 para convertirlo a romano.");
            bool success; int value;
            do
            {
                success = int.TryParse(Console.ReadLine(), out value);
                if (!success || value > 10 || value < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Input invalido. Volver a intentar.");
                }
            } while (!success);

            string result = "";
            switch (value) 
            {
                case 1:
                    result = "I";
                    break;
                case 2:
                    result = "II";
                    break;
                case 3:
                    result = "III";
                    break;
                case 4:
                    result = "IV";
                    break;
                case 5:
                    result = "V";
                    break;
                case 6:
                    result = "VI";
                    break;
                case 7:
                    result = "VII";
                    break;
                case 8:
                    result = "VIII";
                    break;
                case 9:
                    result = "IX";
                    break;
                case 10:
                    result = "X";
                    break;
            }
            Console.Clear();
            Console.WriteLine($"El equivalente de {value} en números romanos es {result}.");
            Thread.Sleep(1500);
            Console.WriteLine("Regresando al menú principal...");
            Thread.Sleep(3000);
        }    

    }
}
