using System;
using System.Collections.Generic;

namespace Soluciones
{
    class Ejercicio7
    {
        public static void Solucion()
        {
			Console.WriteLine("Ingresar monto de dinero a desglosar");
			Console.WriteLine("<!>Solo se aceptan números enteros, sin signo ni caractéres especiales.</!>");
			int dinero; bool success;
			//ENTRADA
			/*
			 * A través de TryParse y el booleano que retorna puedo realizar la validación del input.
			 * En tanto sea false, el usuario permanecerá en el bucle while.
			*/

			do
			{
				success = int.TryParse(Console.ReadLine(), out dinero);
				if (!success)
				{
					Console.Clear();
					Console.WriteLine("Input inválido. Reintentar.");
					Console.WriteLine("<!>Solo se aceptan números enteros, sin signo ni caractéres especiales.</!>");
				}
			} while (!success);

			Console.Clear();
			/*
			 * Ocupo un array con los valores posibles, y a través de un foreach
			 * voy poblando mi diccionario con la cantidad de billetes necesarios
			 */

			var billetes = new Dictionary<int, int>();
			var valoresPosibles = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
			Console.WriteLine($"Monto a desglosar: ${dinero}");

			foreach (int valor in valoresPosibles)
			{
				if (dinero >= valor)
				{
					int cantidad = dinero / valor;
					dinero -= valor * cantidad;
					billetes.Add(valor, cantidad);
				}
			}


			//SALIDA
			/*
			 * Formateando la salida y logueando en la consola.
			 * Tomo en cuenta la key (de ser 1, se tratara de monedas) y el value (la cantidad, para determinar singular/plural)
			 */

			Console.WriteLine("_____Resultado_____");
			int dictRemainingKvp = billetes.Count;
			foreach (KeyValuePair<int, int> kvp in billetes)
			{
				dictRemainingKvp--;
				if (kvp.Key > 1)
				{
					Console.WriteLine($"-{kvp.Value} {(kvp.Value > 1 ? "billetes" : "billete")} de ${kvp.Key}{(dictRemainingKvp > 0 ? ", " : ".")}");
				}
				else
				{
					Console.WriteLine($"-{kvp.Value} {(kvp.Value > 1 ? "monedas" : "moneda")} de ${kvp.Key}{(dictRemainingKvp > 0 ? ", " : ".")}");
                }
            }
			//Fin
			Console.WriteLine("____________________");
			Console.WriteLine("Fin de la solución.");
			Console.WriteLine("1. Volver a ejecutar");
			Console.WriteLine("2. Regresar al menú.");
			string choice = Console.ReadLine();
			if (choice == "1")
			{
				Solucion();
			}
			else {
				return;
			}
		}
    }
}
