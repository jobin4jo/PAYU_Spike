namespace PAYU_Spike.Model
{
    public class PaymentRequest
    {
       public  string txnId { get; set; }
       public string amount { get; set; }
        public string productInfo { get; set; }
       public  string firstName { get; set; }
        public string email { get; set; }
        public string Phonenumber { get; set; }
    }
}
