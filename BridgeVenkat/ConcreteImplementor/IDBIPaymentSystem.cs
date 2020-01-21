using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeVenkat
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for " + paymentSystem);
        }
    }
}
