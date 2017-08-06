using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation101.Models.Annotations
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool valid = false;
            valid = (value is bool && (bool) value == true);
            return valid;
        }
    }
}