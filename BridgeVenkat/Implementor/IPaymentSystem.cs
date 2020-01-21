using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeVenkat
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
