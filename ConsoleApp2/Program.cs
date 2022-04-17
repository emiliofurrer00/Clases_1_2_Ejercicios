using System;
using System.Collections.Generic;

namespace Soluciones {
    class Program 
    {
        static void Main(string[] args) {
            do {
                Console.Clear();
                Console.WriteLine("_____SOLUCIONES_____");
                Console.WriteLine("Autor: Emilio Furrer");

                string menuString = 
                    "1. ¿Es mayor que 100?\n" +
                    "2. ¿Es par o impar?\n" +
                    "3. ¿Es el doble de un impar?\n" +
                    "4. Convertir a números romanos\n" +
                    "5. ¿Quién de los dos es el menor?\n" +
                    "6. Triangulos.\n" +
                    "7. Desglosar dinero.\n" +
                    "8. Secuencia de números del 1 al N.\n" +
                    "9. Sumar 15 números.\n" +
                    "10. Determinar si hay algún múltiplo de 3 dados 5 números.\n" +
                    "11. Crear y comprobar contraseña.\n" +
                    "12. Crear y comprobar contraseña con 3 intentos. \n" +
                    "13. ¿Cuál es el número?\n" +
                    "14. ¿Cuál es el número? + Pistas.\n" +
                    "15. Sumar números\n";
                Console.WriteLine(menuString);

                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Ejercicio1.Solucion();
                        break;
                    case "2":
                        Ejercicio2.Solucion();
                        break;
                    case "3":
                        Ejercicio3.Solucion();
                        break;
                    case "4":
                        Ejercicio4.Solucion();
                        break;
                    case "5":
                        Ejercicio5.Solucion();
                        break;
                    case "6":
                        Ejercicio6.Solucion();
                        break;
                    case "7":
                        Ejercicio7.Solucion();
                        break;
                }
            } while (true);
      
        }
        //Viendo que tuve que reutilizar muchas veces la validación de un input y su conversión a int, lo separé en un metodo individual
        public static int ValidarIntInput(){
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
            return value;
        }
    }
}




