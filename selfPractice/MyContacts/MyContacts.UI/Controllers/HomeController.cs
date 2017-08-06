using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyContacts.UI.Models;

namespace MyContacts.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var database = new FakeContactDatabase();

            var contacts = database.GetAll();

            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult AddContact()
        //{
        //    var contact = new Contact();

        //    contact.Name = Request.Form["Name"];
        //    contact.PhoneNumber = Request.Form["PhoneNumber"];

        //    var database = new FakeContactDatabase();
        //    database.Add(contact);

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            var database = new FakeContactDatabase();
            database.Add(contact);

            return RedirectToAction("Index");
        }

        //public ActionResult Edit()
        //{
        //    int contactID = int.Parse(RouteData.Values["id"].ToString());

        //    var database = new FakeContactDatabase();
        //    var contact = database.GetById(contactID);

        //    return View(contact);
        //}

        public ActionResult Edit(int id)
        {
            var database = new FakeContactDatabase();
            var contact = database.GetById(id);

            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact()
        {
            var contact = new Contact();

            contact.Name = Request.Form["Name"];
            contact.PhoneNumber = Request.Form["PhoneNumber"];
            contact.ContactId = int.Parse(Request.Form["ContactId"]);

            var database = new FakeContactDatabase();
            database.Edit(contact);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactId = int.Parse(Request.Form["ContactId"]);

            var database = new FakeContactDatabase();
            database.Delete(contactId);

            var contacts = database.GetAll();
            return View("Index", contacts);
        }
    }
}