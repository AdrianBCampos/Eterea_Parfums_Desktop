using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public class BarcodeScannerWatcher
    {
        private FileSystemWatcher watcher;
        private string filePath;

        public BarcodeScannerWatcher(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show("El archivo txt_scan.txt no existe o la ruta es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            filePath = path;
            watcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(filePath),
                Filter = Path.GetFileName(filePath),
                NotifyFilter = NotifyFilters.LastWrite
            };

            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                // Esperar un poco para que el archivo termine de guardarse
                System.Threading.Thread.Sleep(500);

                // Asegurar que el archivo exista antes de intentar leerlo
                if (File.Exists(filePath))
                {
                    string barcode = File.ReadAllText(filePath).Trim();

                    if (!string.IsNullOrEmpty(barcode))
                    {
                        BuscarPerfume(barcode);
                    }
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"El archivo está en uso y no puede ser leído: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el código de barras: {ex.Message}");
            }
        }

        private void BuscarPerfume(string codigo)
        {
            // Llamar al controlador para buscar el perfume
            Perfume perfume = PerfumeControlador.getByCodigo(codigo);

            if (perfume != null)
            {

                // Mostrar datos en el formulario VerDatosPerfume
                VerDetallePerfume detallesForm = new VerDetallePerfume(perfume);
                detallesForm.Show();
                //VerDetallePerfume form = new VerDetallePerfume(perfume);
                //form.Show();
            }
            else
            {
                MessageBox.Show("Perfume no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}