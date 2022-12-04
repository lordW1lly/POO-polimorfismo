using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_polimorfismo.Models.Base;
using POO_polimorfismo.Models.Derivada;
    
namespace WindowsPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano()
            { Nombre = "Piano" };
            MessageBox.Show(piano.Afinar(piano.Nombre));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin()
            {
                Nombre= "violin"
            };
            MessageBox.Show(violin.Afinar(violin.Nombre));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra()
            {
                Nombre = "Guitarra"
            };
            MessageBox.Show(guitarra.Afinar(guitarra.Nombre));
        }
    }
}
