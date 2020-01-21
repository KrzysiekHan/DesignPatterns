using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeVenkat
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Payment
    {
        protected IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}
