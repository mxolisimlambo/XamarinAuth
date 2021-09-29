using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XamarinAuth.Models;

namespace XamarinAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
         //  
        // GET: /Home/Register  
        [AllowAnonymous]  
        public ActionResult Register()  
        {  
            return View();  
        }  
  
        //  
        // POST: /Home/Register  
        [HttpPost]  
        [AllowAnonymous]  
        [ValidateAntiForgeryToken]  
        public ActionResult Register(RegisterBindingModel model)  
        {  
            if (ModelState.IsValid)  
            {  
                // Info.  
                Console.WriteLine(model.Email);  
            }  
  
            // If we got this far, something failed, redisplay form  
            return View(model);  
        }

        //  
        // GET: /Home/Register  
        [AllowAnonymous]
        public ActionResult RegistertEST()
        {
            return View();
        }

        //  
        // POST: /Home/Register  
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterTEST(RegistrationTEST model)
        {
            if (!ModelState.IsValid)
            {
                // Info.  
                Console.WriteLine(model.Email);
            }

            // If we got this far, something failed, redisplay form  
            return View(model);
        }

    }
}
