using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public class AgendaContactos
    {
        public AgendaContactos(string nombre, string tipo, int maximo) {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaximaContactos = maximo;
            _contactos = new List<Contacto>();
        }

        private string _nombre;
        private string _tipo;
        private int _cantidadMaximaContactos;
        private List<Contacto> _contactos;

        public string Nombre
        {
            get { return _nombre; }
            //set { _nombre = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            //set { _nombre = value; }
        }
        public int CantidadRegistros()
        {
            return _contactos.Count;
            //set { _nombre = value; }
        }

        public void AgregarContacto(Contacto c) {
            if (CantidadRegistros() < _cantidadMaximaContactos) _contactos.Add(c);
            //else 
        }
        public void EliminarContacto(int codigo) { }
        public Contacto TraerContactoFrecuente() { return null; }
    }
}
