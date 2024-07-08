using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAYU_Spike.Model;
using PAYU_Spike.Service;

namespace PAYU_Spike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PAYUController : ControllerBase
    {
        private readonly PayUService _payUService;
        public PAYUController(PayUService _payUService)
        {
            this._payUService = _payUService;
        }
        [HttpPost("Payment")]
        public async Task<IActionResult> InitiatePayment(PaymentRequest paymentRequest)
        {
            var txnId = "txnid103995240256";
            paymentRequest.txnId= txnId;
            var response = await _payUService.InitiatePayment(paymentRequest);
            return Ok(response);
        }
    }
}
