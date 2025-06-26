using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormTestConexion : Form
    {
        public FormTestConexion()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection("Data Source=DESKTOP-12IG1S9\\MSSQLSERVER2025;Initial Catalog=eterea;User ID=as;Password=Melona88;"))
                {
                    conn.Open();
                    MessageBox.Show("✅ Conexión exitosa desde la app");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message);
            }
        }
    }
}
