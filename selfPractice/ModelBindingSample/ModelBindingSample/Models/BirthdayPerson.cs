using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingSample.Models
{
    public class BirthdayPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}