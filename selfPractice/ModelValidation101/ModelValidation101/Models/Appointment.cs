using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using ModelValidation101.Models.Annotations;

namespace ModelValidation101.Models
{
    //[NoGarfieldOnMondays(ErrorMessage = "Garfield can't be here on Mondays!")]
    public class Appointment : IValidatableObject
    {
        [DisplayName("Client")]
        //[Required(ErrorMessage = "Client Name is required")]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[FurtureDate(ErrorMessage = "Please enter a date in the future")]
        public DateTime Date { get; set; }

        //[MustBeTrue(ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (ClientName.IsNullOrWhiteSpace())
            {
                errors.Add(new ValidationResult("Please enter your name", 
                    new [] {"ClientName"}));
            }
            if (DateTime.Now > Date)
            {
                errors.Add(new ValidationResult("Please enter a date in the future",
                    new [] {"Date"}));
            }
            if (errors.Count == 0 && ClientName == "Garfield" &&
                Date.DayOfWeek == DayOfWeek.Monday)
            {
                errors.Add(new ValidationResult("Garfield cannot book appointments on Mondays"));
            }
            if (!TermsAccepted)
            {
                errors.Add(new ValidationResult("You must accept the terms",
                    new [] {"TermsAccepted"}));
            }

            return errors;
        }
    }
}