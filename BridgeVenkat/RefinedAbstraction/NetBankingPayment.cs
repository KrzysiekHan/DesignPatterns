using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeVenkat
{
    /// <summary>
    /// Refined abstraction
    /// </summary>
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("NetBanking Payment");
        } 
    }
}
