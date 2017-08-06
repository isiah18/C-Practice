using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.CustomBinders
{
    public class BirthdayPersonBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerConext, ModelBindingContext bindingContext)
        {
            var person = new BirthdayPerson();

            var request = controllerConext.HttpContext.Request;

            person.FirstName = request.Form["FirstName"];
            person.LastName = request.Form["LastName"];

            int month = int.Parse(request.Form["month"]);
            int day = int.Parse(request.Form["day"]);
            int year = int.Parse(request.Form["year"]);

            person.Birthday = new DateTime(year, month, day);

            return person;
        }
    }
}