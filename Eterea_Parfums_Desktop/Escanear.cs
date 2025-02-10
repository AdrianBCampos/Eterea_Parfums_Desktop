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

        private InicioAutoConsultas _inicioAutoConsultas; // Referencia a InicioAutoConsulta
       
        
        public Escanear(InicioAutoConsultas inicioAutoConsultas)
        {
            InitializeComponent();

           
            _inicioAutoConsultas = inicioAutoConsultas; // Guardar la referencia
            //this.Load += (s, e) => txt_codigo_barras.Focus(); // Poner el cursor en el TextBox al abrir el form

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

        private void Escanear_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txt_codigo_barras.Focus(); // ✅ Posiciona el cursor en el TextBox
            }));
        }




        private void txt_codigo_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string codigoBarras = txt_codigo_barras.Text.Trim();

                if (!string.IsNullOrEmpty(codigoBarras))
                {
                    Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigoBarras);

                    if (perfumeEncontrado != null)
                    {
                        VerDetallePerfume formDetalle = new VerDetallePerfume(perfumeEncontrado);

                        // ✅ Manejar evento FormClosed para restaurar UI en InicioAutoConsulta
                        formDetalle.FormClosed += (s, args) =>
                        {
                            _inicioAutoConsultas?.RestaurarUI(); // Llamar al método de InicioAutoConsultas
                        };

                        formDetalle.ShowDialog();
                        this.Close(); // Cierra el form Escanear
                    }
                    else
                    {
                        this.Close();
                        _inicioAutoConsultas?.MostrarErrorCodigo();
                        this.Close();
                        _inicioAutoConsultas?.RestaurarUI();  // Llamar al método de restauración de UI
                    }
                }
            }
        }



    }
}
