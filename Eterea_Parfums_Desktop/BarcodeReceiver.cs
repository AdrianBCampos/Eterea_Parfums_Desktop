using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class BarcodeReceiver
{
    private TcpListener _server;
    private readonly int _port = 5000;

    // ✅ NUEVO: evento que podés suscribir y desuscribir en los formularios
    public static event Action<string> OnCodigoLeido;

    public void StartServer()
    {
        if (_server != null) return;

        _server = new TcpListener(IPAddress.Any, _port);
        _server.Start();
        Task.Run(() => AcceptClients());
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
                string barcode = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                // ✅ Disparar el evento. Solo invocar si el código no está vacío
                if (!string.IsNullOrWhiteSpace(barcode))
                {
                    OnCodigoLeido?.Invoke(barcode);
                }

            }
        }
    }
}


