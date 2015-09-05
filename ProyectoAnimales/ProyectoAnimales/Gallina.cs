using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Drawing;

namespace ProyectoAnimales
{
    class Gallina : Animales
    {
        public Gallina(string nombre, Image image)
            :base(nombre, image)
       {
       }

        public override void sonido()
        {
            SoundPlayer s = new SoundPlayer("gallina.wav");
            s.Play();
        }
    }
}
