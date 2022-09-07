using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda.Dominio.Entidades.Contacto contacto1 = new Agenda.Dominio.Entidades.Contacto("Cecilia","Lopez","1234","moldes 123", DateTime.Now.AddYears(-35));

            Agenda.Dominio.Entidades.Contacto contacto2 = new Agenda.Dominio.Entidades.Contacto("Carlos", "Landa", "789456", "11 de septiembre", DateTime.Now.AddYears(-21));

            Agenda.Dominio.Entidades.AgendaContactos agenda = new Agenda.Dominio.Entidades.AgendaContactos("Diario", "Electrónica", 20);

            agenda.AgregarContacto(contacto1);
            agenda.AgregarContacto(contacto2);
        }
    }
}
