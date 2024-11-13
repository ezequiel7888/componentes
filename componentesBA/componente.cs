using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace componentesBA
{
    public class componente
    {

        public string Nombre { get; set; }


        public string Capacidad {  get; set; }

        public string Tipo { get; set; }

        public string Velocidad { get; set; }
        public int id { get; set; }

        

        public componente(int id,
            string nombre,
            string capacidad,
            string tipo,
            string velocidad)
        {
            this.id = id;  
            Nombre = nombre;
            Capacidad = capacidad;
            Tipo = tipo;
            Velocidad = velocidad;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Capacidad} {Tipo} {Velocidad}";
        }
    }

    
}