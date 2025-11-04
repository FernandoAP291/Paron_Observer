using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paron_Observer
{
    internal class Youtuber
    {
        private List<Subscriptor> subscriptors = new List<Subscriptor>();
        public  void agregarSubs(Subscriptor s)
        {
            subscriptors.Add(s);
            Console.WriteLine($"{s.Nombre} se ha suscrito al canal");
        }
        public void publicar(string video)
        {
            Console.WriteLine($"\n Nuevo video publicado: {video}");
            
        }
        private void notificarSubs(string video)
        {
            foreach(var s in subscriptors)
            {
                s.actualizar(video);
            }
        }
    }
}
