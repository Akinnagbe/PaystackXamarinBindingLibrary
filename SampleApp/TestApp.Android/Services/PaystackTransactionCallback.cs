using System;
using Java.Lang;

namespace TestApp.Droid.Services
{
    public class PaystackTransactionCallback : Java.Lang.Object, Com.Olamidejames.Paystackxamarinandroidlibrary.IPaystackTransactionCallback
    {
        public void OnError(Throwable error, string referenceId)
        {
            var message = error.Message;
        }

        public void OnSuccess(string referenceId)
        {
            Console.WriteLine(referenceId);
        }
    }
}
