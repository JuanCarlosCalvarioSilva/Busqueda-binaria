using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busqueda_binaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        vector v1 = new vector();
        busquedaBinaria b1 = new busquedaBinaria();
        private void button1_Click(object sender, EventArgs e)
        {
            b1.contador = 0;
            v1.llenar();
            Array.Sort(v1._v);
            if (b1.buscar(int.Parse(txtNum.Text), v1._v, v1._v.Length) == -1)
                lblEncontrado.Text = "Número no encontrado en la repeticion: " + b1.contador.ToString();
            else
                lblEncontrado.Text = "Número encontrado en la repeticion: " + b1.contador.ToString();
        }
    }
}
