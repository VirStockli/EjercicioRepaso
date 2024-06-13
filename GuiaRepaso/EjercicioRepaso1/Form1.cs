using EjercicioRepaso1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioRepaso1
{
    public partial class Form1 : Form
    {
        Controlador objeto = new Controlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarValor Ventana = new FormAgregarValor();
            if (Ventana.ShowDialog() == DialogResult.OK) 
            {
                objeto.IngresarValor(Convert.ToInt32(Ventana.tbNumero.Text));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double prom = objeto.CalcularPromedio();
            lbPromedio.Text = prom.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormResultados ventana2 = new FormResultados();
            int cualquiera = 0;
            int[] Vector2=objeto.DevolverProm(ref cualquiera);
            int n = 0;
            objeto.Burbuja(Vector2, n);
            while (n < cualquiera)
            {
                ventana2.lbResultados.Items.Add(Vector2[n].ToString());
                
            }
            ventana2.ShowDialog();
        }
    }
}
