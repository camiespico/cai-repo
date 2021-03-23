using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol.Libreria.Entidades.Equipos
{
    public class Jugador
    {
        private string nombre;
        private string apellido;
        private string dorsal;
        private int edad;
        private double peso;
        private string posicion;
        private string nacionalidad;
        private string piernahabil;

        public Jugador(string nombre, string apellido, string dorsal, int edad, double peso, string posicion, string nacionalidad, string piernahabil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dorsal = dorsal;
            this.edad = edad;
            this.peso = peso;
            this.posicion = posicion;
            this.nacionalidad = nacionalidad;
            this.piernahabil = piernahabil;
        }

        public override string ToString()
        {
            return "El Jugador "+ apellido +", "+ nombre + " tiene dorsal " + dorsal + ", su edad es "+ edad +
                " y su peso es "+ peso+ "kg. Es "+piernahabil+", su posición en la cancha es "+posicion+
                " y su nacionalidad es "+nacionalidad;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }

        public string Dorsal
        {
            get
            {
                return this.dorsal;
            }

            set
            {
                this.dorsal = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }

        }

        public double Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = value;
            }
        }

        public string Posicion
        {
            get
            {
                return this.posicion;
            }

            set
            {
                this.posicion = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }

            set
            {
                this.nacionalidad = value;
            }
        }

        public string Piernahabil
        {
            get
            {
                return this.piernahabil;
            }

            set
            {
                this.piernahabil = value;
            }
        }



    }
}
