using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public sealed class ContactoPersona : Contacto
    {
        public ContactoPersona(int codigo, int llamadas, int direccion, string nombre, string apellido, DateTime fechaNacimiento) : base(codigo, llamadas, direccion)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
        }
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
