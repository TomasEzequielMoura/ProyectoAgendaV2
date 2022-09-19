using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Dominio.Entidades;

namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIA DE CONTACTO EMPRESA
            Contacto contacto1 = new ContactoEmpresa(10, 10, 10, "asd", DateTime.Now.AddYears(-35));
            ContactoEmpresa contacto11 = new ContactoEmpresa(10, 10, 10, "asd", DateTime.Now.AddYears(-35));

            // INSTANCIA DE CONTACTO PERSONA
            Contacto contacto2 = new ContactoPersona(10, 10, 10, "asd", "asd", DateTime.Now.AddYears(-35));
            ContactoPersona contacto22 = (ContactoPersona)contacto2;

            //Contacto contacto3 = new Contacto(10, 10, 10);
 
            try
            {
                AgendaContactos agendaElectronica = new AgendaContactos("Diario", "Electrónica", 20);
                agendaElectronica.AgregarContacto(contacto1);
                agendaElectronica.AgregarContacto(contacto2);
                //agendaElectronica.AgregarContacto(contacto3);
                bool consolaActiva = true;
                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();
                    switch (opcionMenu)
                    {
                        case "1":
                            // listar contactos
                            Listar(agendaElectronica);
                            break;
                        case "2":
                            // agregar contactos
                            // opcion 1
                            // Contacto c = PedirInputContacto();
                            // agendaElectronica.AgregarContacto(c);
                            // // falta validacion de inputs
                            Agregar(agendaElectronica);
                            break;
                        case "3":
                            // listar contactos frecuentes
                            break;
                        case "4":
                            // eliminar contactos
                            break;
                        case "5":
                            // llamar contactos
                            break;
                        case "X":
                            consolaActiva = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }
        }

        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Seleccione la opción deseada");
        }

        public static void Listar (AgendaContactos agenda){
            // traer los contactos, iterarlos y escribirlos

            foreach (Contacto c in agenda.Contactos) {
                Console.WriteLine($"{c.Nombre} - {c.Telefono}");
            }
        }

        public static void Agregar(AgendaContactos agendaElectronica)
        {
            bool agrego = true;
            Console.WriteLine("dame nombre");
            string nombre = Console.ReadLine();

            // las validaciones van siempre en el input, nunca en la 
            if (nombre.Length < 2){
                Console.WriteLine("el nombre es demasiado corto");
                agrego = false;
            }

            string apellido = Console.ReadLine();
            string telefono = Console.ReadLine();
            string direccion = Console.ReadLine();
            string fechaNacimiento = Console.ReadLine();
            DateTime oDate = Convert.ToDateTime(fechaNacimiento);

            Contacto c1 = new Contacto(nombre, apellido, telefono, direccion, oDate);

            if (agrego) agendaElectronica.AgregarContacto(c1);

            agendaElectronica.AgregarContacto(c1);
        }


        public static Contacto PedirInputContacto()
        {
            string nombre = Console.ReadLine();
            string apellido = Console.ReadLine();
            string telefono = Console.ReadLine();
            string direccion = Console.ReadLine();
            string fechaNacimiento = Console.ReadLine();
            DateTime oDate = Convert.ToDateTime(fechaNacimiento);

            Contacto c1 = new Contacto(nombre, apellido, telefono, direccion, oDate);

            return c1;
        }

    }
}
