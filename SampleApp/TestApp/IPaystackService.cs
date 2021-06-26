using System;
namespace TestApp
{
    public interface IPaystackService
    {
        void TestPayment();
        bool IsCardValid();
        bool IsPanValid();
        bool IsCVVValid();
        bool IsExpiryDateValid();
        void StartFreshCharge();
        void ResumeCharge(string accessCode);
    }
}
