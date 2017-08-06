using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation101.Models.Annotations
{
    public class FurtureDateAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && ((DateTime) value) > DateTime.Now;
        }
    }
}