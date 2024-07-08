using PAYU_Spike.Model;

namespace PAYU_Spike.Service
{
    public interface IPayUService
    {
        Task<string> InitiatePayment(PaymentRequest paymentRequest);
    }
}
