using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace ProyectoAnimales
{
    public partial class Form1 : Form
    {
        ArrayList milista = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Animales objanimal = (Animales)milista[e.RowIndex];
                objanimal.sonido();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animales pollito = new Pollo("pollo", Image.FromFile("pollo.jpg"));
            milista.Add(pollito);
            Animales gallina = new Gallina("gallina", Image.FromFile("gallina.jpg"));
            milista.Add(gallina);
            Animales gallo = new Gallo("gallo", Image.FromFile("gallo.jpg"));
            milista.Add(gallo);
            
            int i=0;
            foreach(Animales item in milista)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0,i].Value = item.imagen; 
                dataGridView1[1,i].Value = item.nombre;
                dataGridView1[2,i].Value = "Da click";
                i++;
            }
        }
    }
}
