using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.InterfazConsola
{
    public class Contacto
    {
        // Constructor
        public Contacto(string nombre) {
            _nombre = nombre;
            _llamadas = 0;
        }

        // atributos
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono; // para poder que la persona ponga "+" o "-" usamos string
        private int _llamadas;

        // propiedades
        public string Nombre {
            get { return _nombre; }
            //set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public string Telefono
        {
            get { return _telefono; }
        }

        public int Llamadas
        {
            get { return _llamadas; }
        }

        // metodos
        public int Edad() {
            return 0;
        }
    }
}
