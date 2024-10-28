using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Correo electrónico: {correoElectronico}");
        }
    }

    public class ServicioCorreo
    {
        public void EnviarCorreoElectronico(string destinatario, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {destinatario}: {mensaje}");
        }
    }
}
