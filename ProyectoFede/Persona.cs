using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaApplication
{
    class Persona
    {
        public Persona() 
        {
        
        }
        public Persona(string _nombre,string _apellido,int _edad, double _altura,double _peso , DateTime _fechaNac)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Edad = _edad;
            Altura = _altura;
            Peso = _peso;
            FechaNacimiento = _fechaNac;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Documento { get; set; }
        


        public string TraerNombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}
