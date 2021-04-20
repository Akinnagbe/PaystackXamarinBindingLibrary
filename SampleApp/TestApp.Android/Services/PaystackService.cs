using System;
using System.Collections.Generic;
using NG.Sterling.Paystackbindinglibrary;
using TestApp.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(PaystackService))]
namespace TestApp.Droid.Services
{
    public class PaystackService : IPaystackService
    {


        public void TestPayment()
        {
            var paystack = new PaystackLibrary();
            var chargeModel = new ChargeCardModel
            {
                Pan = "507850785078507812",
                ExpiryMonth = 03,
                ExpiryYear = 22,
                Cvv = "081",
                Amount = 120000,
                Currency = "ngn",
                Email = "olamidejames007@gmail.com",
                Reference = Guid.NewGuid().ToString("n"),
                TransactionCharge = 13,
                CustomFields = new Dictionary<string, string>()
                {
                    {"department","Technology" },
                    {"unit","PABA" },
                    {"role","Software Developer" },
                    {"project","OneBank" }
                }

            };
            
            paystack.StartFreshCharge(chargeModel, Xamarin.Essentials.Platform.CurrentActivity,new PaystackTransactionCallback());
        }
    }
}
