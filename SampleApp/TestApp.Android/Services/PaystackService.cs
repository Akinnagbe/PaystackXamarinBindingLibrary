using System;
using System.Collections.Generic;
using Com.Olamidejames.Paystackxamarinandroidlibrary;
using TestApp.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(PaystackService))]
namespace TestApp.Droid.Services
{
    public class PaystackService : IPaystackService
    {
        PaystackLibrary paystack;
        string email = "";
        public PaystackService()
        {
             paystack = new PaystackLibrary();
        }
        public bool IsCardValid()
        {
            //var isCardValid = paystack.IsCardValid(new CardModel() { Cvv = chargeModel.Cvv, ExpiryMonth = chargeModel.ExpiryMonth, ExpiryYear = chargeModel.ExpiryYear, Pan = chargeModel.Pan });
            return false;
        }

        public bool IsCVVValid()
        {
            throw new NotImplementedException();
        }

        public bool IsExpiryDateValid()
        {
            throw new NotImplementedException();
        }

        public bool IsPanValid()
        {
            throw new NotImplementedException();
        }

        public void ResumeCharge(string accessCode)
        {
            var chargeModel = new ChargeCardModel
            {
                Pan = "507850785078507812",
                ExpiryMonth = 03,
                ExpiryYear = 22,
                Cvv = "081",
                Amount = 120000,
                Currency = "ngn",
                Email = email,
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
            paystack.ResumeCharge(Xamarin.Essentials.Platform.CurrentActivity, chargeModel, new PaystackTransactionCallback(), accessCode);
            
        }

        public void StartFreshCharge()
        {
            var chargeModel = new ChargeCardModel
            {
                Pan = "507850785078507812",
                ExpiryMonth = 03,
                ExpiryYear = 22,
                Cvv = "081",
                Amount = 120000,
                Currency = "ngn",
                Email = email,
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

            paystack.StartFreshCharge(chargeModel, Xamarin.Essentials.Platform.CurrentActivity, new PaystackTransactionCallback());
        }

        public void TestPayment()
        {
            
            var chargeModel = new  ChargeCardModel
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
