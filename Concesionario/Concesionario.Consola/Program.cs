using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concesionario.Libreria.Entidades.Agencia;

namespace Concesionario.Consola
{
    class Agencia
    {
        static void Main(string[] args)
        {

            Auto f = new Auto();

            f.Id = 1;
            f.Marca = "Ford";
            f.Modelo = "Ka";
            f.Precio = "1200000";

            Console.WriteLine("El Auto " + f.Id + " de marca " + f.Marca + " tiene un precio de " + f.Precio);

            Console.ReadLine();


        }
    }
}
