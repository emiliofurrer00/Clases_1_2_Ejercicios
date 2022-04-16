using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluciones
{
    class Ejercicio6
    {
        public static void Solucion()
        {
            var lados = new int[3];

            for (int i = 0; i < 3; i++)
            {
                bool success;
                do
                {
                    success = int.TryParse(Console.ReadLine(), out lados[i]);
                    if (!success)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Input. Try again.");
                    }
                    Console.Clear();
                } while (!success);
            }

            Console.WriteLine($"Lados: \nn1 = {lados[0]}; n2 = {lados[1]}; n3 = {lados[2]} ");

            var ladosUnicos = new Dictionary<int, int>();
            foreach (int lado in lados)
            {
                if (ladosUnicos.ContainsKey(lado))
                {
                    ladosUnicos[lado]++;
                }
                else
                {
                    ladosUnicos[lado] = 1;
                }
            }

            //Clasificandolo según sus lados
            switch (ladosUnicos.Count)
            {
                case 1:
                    Console.WriteLine("Tipo: Equilatero");
                    break;
                case 2:
                    Console.WriteLine("Tipo: Isóceles");
                    break;
                case 3:
                    Console.WriteLine("Tipo: Escaleno");
                    break;
            }

            //Calculando perímetro
            int perimetro = lados.Sum();
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    }
}
