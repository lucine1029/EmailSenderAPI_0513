using EmailSenderAPI_0513.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailSenderAPI_0513.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;

        //create an constructor, inside of constructor we receive an email sender from the denpendency injection 
        public HomeController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "ccg4test@gmail.com";
            var subject = "Test";
            var message = "Hellooooooo World, it's captain! Welcome!";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
