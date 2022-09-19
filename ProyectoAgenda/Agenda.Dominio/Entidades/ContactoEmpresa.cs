using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public sealed class ContactoEmpresa : Contacto
    {
        public ContactoEmpresa(int codigo, int llamadas, int direccion, string razonSocial, DateTime fechaConstitucion) : base(codigo, llamadas, direccion)
        {
            _razonSocial = razonSocial;
            _fechaConstitucion = fechaConstitucion;
        }
        private string _razonSocial;
        private DateTime _fechaConstitucion;

        public string RazonSocial { get => _razonSocial; }
        public DateTime FechaConstitucion { get => _fechaConstitucion; set => _fechaConstitucion = value; }
    }
}
