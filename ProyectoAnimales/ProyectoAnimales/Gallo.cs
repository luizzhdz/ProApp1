using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;

namespace ProyectoAnimales
{
    class Gallo : Animales
    {
        public Gallo(string nombre, Image image)
            :base(nombre, image)
       {
       }

        public override void sonido()
        {
            SoundPlayer s = new SoundPlayer("gallo.wav");
            s.Play();
        }
    }
}
