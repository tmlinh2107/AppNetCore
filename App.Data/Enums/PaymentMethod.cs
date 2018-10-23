﻿using System.ComponentModel;

namespace App.Data.Enums
{
    public enum PaymentMethod
    {
        [Description("Cash on delivery")]
        CashOnDelivery,

        [Description("Online Banking")]
        OnlineBanking,

        //[Description("Payment Gateway")]
        //PaymentGateway,

        [Description("Visa")]
        Visa,

        [Description("Master Card")]
        MasterCard,

        [Description("PayPal")]
        PayPal,

        //[Description("Atm")]
        //Atm
    }
}