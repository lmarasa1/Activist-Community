using Luca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Luca.Controllers
{
    public class PetitionController : Controller
    {
        // GET: Petition
        public ActionResult NewPetition()
        {
            return View(new Petition());
        }

        public ActionResult SubmitPetition(Petition PetitionInformation)
        {
            string image = "";
            Context Context = new Context();
            Petition Petition = new Petition() { CaptureDate = DateTime.Now, Description = PetitionInformation.Description, Title = PetitionInformation.Title, Image = image };
            Context.Petition.Add(Petition);
            Context.SaveChanges();

            return RedirectToAction("NewPetition");
        }

        public ActionResult DisplayPetitions()
        {
            Context Context = new Context();
            return View(Context.Petition.ToList());
        }
    }
}