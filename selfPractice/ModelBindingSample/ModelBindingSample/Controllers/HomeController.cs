using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingSample.CustomBinders;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPersonForm2()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult AddPersonForm2(Person person)
        {
            return View("AddPersonForm2Details", person);
        }

        public ActionResult AddPerson(Person person)
        {
            return View(person);
        }

        public ActionResult BindingComplexClassTypes()
        {
            return View(new Person() {HomeAddress = new Address()});
        }

        [HttpPost]
        public ActionResult BindingComplexClassTypes(Person person)
        {
            return View("ComplexResult2", person);
        }

        public ActionResult BindingMultipleObjects()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BindingMultipleObjects(List<Address> addresses)
        {
            return View("MultipleObjectResult", addresses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CustomBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomBinding(BirthdayPerson person)
        {
            return View("CustomBindingResult", person);
        }
    }
}