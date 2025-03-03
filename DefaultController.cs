using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace patienceStudyGroup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<Models.GroupModel> people = new List<Models.GroupModel>();

            people.Add(new Models.GroupModel { StudentNumber = "u24723399", FirstName = "Patience", LastName = "Chitsulo", EmailAddress = "patience.chitsulo@tuks.co.za" });
            people.Add(new Models.GroupModel { StudentNumber = "u24736661", FirstName = "Regopotswe", LastName = "Moholane", EmailAddress = "regopotswe.moholane@tuks.co.za" });
            people.Add(new Models.GroupModel { StudentNumber = "u24584127", FirstName = "Bih", LastName = "Abongnui", EmailAddress = "bih.abongnui@tuks.co.za" });
            people.Add(new Models.GroupModel { StudentNumber = "u24974553", FirstName = "Aviwe", LastName = "Mahlukane", EmailAddress = "aviwe.mahlukane.tuks.co.za" });
            people.Add(new Models.GroupModel { StudentNumber = "u24603199", FirstName = "Caitanya", LastName = "Narain Singh", EmailAddress = "caitanya.narainsingh@tuks.co.za" });
            return View(people);
        }
    }
}