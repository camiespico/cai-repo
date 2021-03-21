using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Libreria.Entidades.Agencia
{
    public class Auto
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }
        public string Km
        {
            get
            {
                return this.km.ToString() + " km";
            }
            set
            {
                this.km = Convert.ToInt32(value);
            }
        }
        public string Precio
        {
            get
            {
                return "$" + this.precio.ToString() + " pesos";
            }
            set
            {
                precio = Convert.ToDouble(value);
            }
        }
    }
}
