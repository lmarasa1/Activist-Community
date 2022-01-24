using Luca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Luca.Controllers
{
    public class UserController : Controller
    {
        public ActionResult SingUp()
        {
            return View(new Users());
        }

        public ActionResult SingUpSubmit(Users SubmittedInfo)
        {
            Context Context = new Context();
            Users User = new Users() { Email = SubmittedInfo.Email, FirstName = SubmittedInfo.FirstName, LastName = SubmittedInfo.LastName, Password = SubmittedInfo.Password };
            Context.Users.Add(User);
            Context.SaveChanges();

            return RedirectToAction("SingUp");
        }

    }
}