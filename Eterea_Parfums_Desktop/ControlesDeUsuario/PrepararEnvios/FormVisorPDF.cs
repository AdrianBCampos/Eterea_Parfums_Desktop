using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormVisorPDF : Form
    {

        public FormVisorPDF(string rutaPDF)
        {
            InitializeComponent();

            this.Text = "Etiqueta de Envío";
            this.WindowState = FormWindowState.Maximized;

            WebView2 visor = new WebView2();
            visor.Dock = DockStyle.Fill;

            if (!rutaPDF.StartsWith("file://"))
                rutaPDF = "file://" + rutaPDF.Replace("\\", "/");

            visor.Source = new Uri(rutaPDF);
            this.Controls.Add(visor);
        }

    
    }
}

