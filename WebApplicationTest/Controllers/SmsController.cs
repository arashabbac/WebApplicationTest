namespace WebApplicationTest.Controllers
{
    public class SmsController : Microsoft.AspNetCore.Mvc.Controller
    {
        public SmsController(Services.ISmsService smsService) : base()
        {
            SmsService = smsService;
        }

        public Services.ISmsService SmsService { get; }

        public Microsoft.AspNetCore.Mvc.IActionResult 
            Send(string cellPhoneNumber , string message)
        {
            int credit =
                SmsService.Credit;

            if(credit <= 0)
            {
                ViewBag.Message =
                    "Not Enough Credit!";

                return View();
            }

            if(SmsService.IsCellPhoneNumberValid(cellPhoneNumber) == false)
            {
                ViewBag.Message =
                    "Cell Phone Number Is Not Valid!";

                return View();
            }

            try
            {
                SmsService.SendSms(cellPhoneNumber, message);

                SmsService.Credit--;

                ViewBag.Message =
                    "SMS Sent Successfully!";

                return View();
            }
            catch(System.Exception ex)
            {
                ViewBag.Message = ex.Message;

                return View();
            }
        }
    }
}
