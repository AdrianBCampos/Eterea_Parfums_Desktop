using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class Escanear : Form
    {
        public Escanear()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAutoConsultas inicioAutoConsultas = new InicioAutoConsultas();
            inicioAutoConsultas.Show();
            this.Close();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
           
        }

    }
}
