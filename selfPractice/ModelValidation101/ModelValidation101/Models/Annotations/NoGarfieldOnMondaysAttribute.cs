using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation101.Models.Annotations
{
    public class NoGarfieldOnMondaysAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrWhiteSpace(app.ClientName))
            {
                return true;
            }
            else
            {
                return !(app.ClientName == "Garfield" &&
                         app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}