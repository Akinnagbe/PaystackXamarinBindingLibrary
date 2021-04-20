using System;
using Java.Lang;

namespace TestApp.Droid.Services
{
    public class PaystackTransactionCallback : Java.Lang.Object, NG.Sterling.Paystackbindinglibrary.IPaystackTransactionCallback
    {
        public void OnError(Throwable error, string referenceId)
        {
            
        }

        public void OnSuccess(string referenceId)
        {
            Console.WriteLine(referenceId);
        }
    }
}
