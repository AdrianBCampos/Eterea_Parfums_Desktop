using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class BarcodeReceiver
{
    private TcpListener _server;
    private readonly int _port = 5000; // Elegimos el puerto 5000, se puede cambiar

    public void StartServer()
    {
        _server = new TcpListener(IPAddress.Any, _port);
        _server.Start();
        Task.Run(() => AcceptClients()); // Ejecuta la recepción en un hilo separado
    }

    private async Task AcceptClients()
    {
        while (true)
        {
            using (var client = await _server.AcceptTcpClientAsync())
            using (var stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string barcode = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                SendBarcodeToActiveForm(barcode);
            }
        }
    }

    private void SendBarcodeToActiveForm(string barcode)
    {
        Form activeForm = Form.ActiveForm; // Obtiene el formulario que está en primer plano
        if (activeForm != null)
        {
            activeForm.Invoke((MethodInvoker)(() =>
            {
                // Busca un TextBox en el formulario activo y envía el código escaneado
                foreach (Control ctrl in activeForm.Controls)
                {
                    if (ctrl is TextBox textBox)
                    {
                        textBox.Text = barcode; // Inserta el código escaneado
                        textBox.Focus();
                        break;
                    }
                }
            }));
        }
    }
}
