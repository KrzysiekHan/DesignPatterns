using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeVenkat
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank gateway for " + paymentSystem);
        }
    }
}
