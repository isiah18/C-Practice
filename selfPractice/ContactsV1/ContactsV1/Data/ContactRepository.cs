using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsV1.Models;

namespace ContactsV1.Data
{
    public class ContactRepository
    {
        private static List<Contact> _contacts = new List<Contact>();

        public ContactRepository()
        {
            if (_contacts.Count < 1)
            {
                _contacts.Add(new Contact() {FirstName = "Dave", LastName = "Balzer", PhoneNumber = "123-1234"});
                _contacts.Add(new Contact() { FirstName = "Jenny", LastName = "Number", PhoneNumber = "867-5309" });
            }
        }

        public List<Contact> LoadAll()
        {
            return _contacts;
        } 
    }
}
