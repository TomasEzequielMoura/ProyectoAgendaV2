using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public class AgendaContactos
    {
        // constructor
        public AgendaContactos(string nombre, string tipo, int maximo) {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaximaContactos = maximo;
            _contactos = new List<Contacto>();
        }

        // variables
        private string _nombre;
        private string _tipo;
        private int _cantidadMaximaContactos;
        private List<Contacto> _contactos;

        // propiedades: geter y seter
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
        public IEnumerable<Contacto> Contactos
        {
            get { return _contactos; }
            //set { _nombre = value; }
        }
        public int CantidadRegistros()
        {
            return _contactos.Count;
            //set { _nombre = value; }
        }

        public void AgregarContacto(Contacto contacto) {
            // valido que el contacto no exista.
            bool permitoAgregar = true;
            foreach (Contacto c in _contactos)
            {
                if (c.Telefono == contacto.Telefono) permitoAgregar = false;
            }
            if (permitoAgregar)
            {
                _contactos.Add(contacto);
            }
        }
        public void EliminarContacto(int codigo) { }
        public Contacto TraerContactoFrecuente() { return null; }
    }
}
