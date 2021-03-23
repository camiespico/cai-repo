using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol.Libreria.Entidades.Equipos;

namespace Futbol.Consola
{
    class Futbol
    {
        static void Main(string[] args)
        {
            
            Jugador j1 = new Jugador("Camilo", "Espinosa", "11", 33, 88, "Delantero", "Colombiano", "Diestro");

            Console.WriteLine(j1.Dorsal);

            j1.Dorsal = "23";

            Console.WriteLine(j1.Edad.ToString());

            Console.WriteLine("Cambio de Dorsal");

            Console.WriteLine(j1.ToString());

            Console.ReadLine();

        }
    }
}
