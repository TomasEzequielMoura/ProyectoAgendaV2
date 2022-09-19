using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public abstract class Contacto
    {
        // Constructor
        public Contacto(int codigo, int llamadas, int direccion)
        {
            _codigo = codigo;
            _direccion = direccion;
            _llamadas = 0;
        }

        // atributos
        protected int _codigo;
        protected int _direccion;
        protected int _llamadas;


        // propiedades
        public int Codigo
        {
            get { return _codigo; }
            //set { _nombre = value; }
        }

        public int Direccion
        {
            get { return _direccion; }
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
