namespace WebApplicationTest.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public string Action0100(string name)
        {
            string result =
                $"Hello, { name }!";

            return result;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Action0200(string name)
        {
            // Begin
            //ViewBag.Message =
            //       $"Hello, { name }!";

            //return Json(data: null);
            // End

            //// Begin
            //ViewBag.MyMessage =
            //    $"Hello, { name }!";

            //return View();
            ////End

            //// Begin
            //ViewBag.Message = 12345;

            //return View();
            ////End

            //// Begin
            //ViewBag.Message =
            //    $"Hello, { name }!";

            //return View();
            ////End

            // Begin
            string message;
            
            if(name == null)
            {
                message = "Name is null!";
            }
            else
            {
                message =
                    $"Hello, { name }!";
            }

            ViewBag.Message = message;

            return View();
            //End
        }
    }

}
