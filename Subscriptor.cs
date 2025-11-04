using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paron_Observer
{
    internal class Subscriptor
    {
        public string Nombre;
        public Subscriptor(string nombre) 
        {
            Nombre = nombre;
        }
        public void actualizar(string video)
        {
            Console.WriteLine($"{Nombre} ha recibido la notificación delnuevo video: {video}");
        }
    }
}
