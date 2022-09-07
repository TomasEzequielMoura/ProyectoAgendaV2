using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public class Contacto
    {
        // Constructor
        public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _fechaNacimiento = fechaNacimiento;
            _llamadas = 0;
        }

        // atributos
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono; // para poder que la persona ponga "+" o "-" usamos string
        private string _log;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        // propiedades
        public string Nombre
        {
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

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
        }

        public int Llamadas
        {
            get { return _llamadas; }
        }


        // metodos
        public int Edad()
        {
            double edad = (DateTime.Now - _fechaNacimiento).TotalDays / 365;
            return Convert.ToInt32(edad);
        }

        public void AgregarLog(string nuevoEvento)
        {
            _log = _log + nuevoEvento;
        }

        public void Llamar() {
            _llamadas++;
        }

    }
}
