using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;

namespace ProyectoAnimales
{
    class Animales
    {
        public string nombre { set; get; }
        public Image imagen { set; get; }

        public Animales(string nom, Image im)
        {
            nombre = nom;
            imagen = im;
        }

        public virtual void sonido()
        {
            SoundPlayer s = new SoundPlayer("pollo.wav");
            s.Play();
        }
    }
}
