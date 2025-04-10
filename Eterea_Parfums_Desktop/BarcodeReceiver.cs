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
    private List<Action<string>> _listeners = new List<Action<string>>();

    public void StartServer()
    {
        if (_server != null) return; // evita doble inicialización

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

                NotifyListeners(barcode);
            }
        }
    }

    private void NotifyListeners(string barcode)
    {
        foreach (var listener in _listeners)
        {
            listener?.Invoke(barcode);
        }
    }

    public void RegisterListener(Action<string> listener)
    {
        if (!_listeners.Contains(listener))
        {
            _listeners.Add(listener);
        }
    }

    public void UnregisterListener(Action<string> listener)
    {
        if (_listeners.Contains(listener))
        {
            _listeners.Remove(listener);
        }
    }
}

    
