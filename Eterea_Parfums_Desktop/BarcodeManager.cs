using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop
{
    public static class BarcodeManager
    {
        public static event Action<string> BarcodeReceived;

        public static void NotifyBarcode(string barcode)
        {
            BarcodeReceived?.Invoke(barcode);
        }
    }
}
