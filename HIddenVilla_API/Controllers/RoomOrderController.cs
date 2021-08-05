using Business.Repository.IRepository;
using Microsoft.AspNetCore.Identity.UI.Services;
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
    public class RoomOrderController : Controller
    {
        private readonly IRoomOrderDetailsRepository _repository;
        private readonly IEmailSender _emailSender;

        public RoomOrderController(IRoomOrderDetailsRepository repository, IEmailSender emailSender)
        {
            _repository = repository;
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomOrderDetailsDto details)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _repository.Create(details);
                    return Ok(result);
                }
                else
                    return BadRequest(new ErrorModel() { ErrorMessage = "Error while creating room booking" });
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailsDto details)
        {
            try
            {
                var service = new SessionService();
                var sessionDetails = await service.GetAsync(details.StripeSessionId);
                if (sessionDetails.PaymentStatus == "paid")
                {
                    var result = await _repository.MarkPaymentSuccessful(details.Id);
                    if (result == null)
                    {
                        return BadRequest(new ErrorModel()
                        {
                            ErrorMessage = "Cannot mark as payment as successful"
                        });                       
                    }
                    await _emailSender.SendEmailAsync(details.Email, "Booked confirmed", "Your booking han been confirmedd with id: " + details.Id);

                    return Ok(result);
                }
                else
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Cannot mark as payment as successful"
                    });
                }

                if (ModelState.IsValid)
                {
                    var result = await _repository.Create(details);
                    return Ok(result);
                }
                else
                    return BadRequest(new ErrorModel() { ErrorMessage = "Error while creating room booking" });
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
