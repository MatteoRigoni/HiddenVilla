using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIddenVilla_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StripePaymentController : Controller
    {
        private readonly IConfiguration _configuration;

        public StripePaymentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StripePaymentDTO payment)
        {
            try
            {
                var domain = _configuration.GetValue<string>("HiddenVilla_Client_Url");
                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string>
                    {
                        "card"
                    },
                    LineItems = new List<SessionLineItemOptions>
                    {
                        new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                                UnitAmount = payment.Amount * 100, // convert to cents
                                Currency = "usd",
                                ProductData = new SessionLineItemPriceDataProductDataOptions
                                {
                                    Name = payment.ProductName
                                }
                            },
                            Quantity = 1
                        }
                    },
                    Mode = "payment",
                    SuccessUrl = domain + "/success-payment?session_id={{CHECKOUT_SESSION}}",
                    CancelUrl = domain + payment.ReturnUrl
                };

                var service = new Stripe.Checkout.SessionService();
                Session session = await service.CreateAsync(options);

                return Ok(new SuccessModel()
                {
                    Data = session.Id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = ex.Message
                });
            }
        }
    }
}
