using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsV1.Data;
using ContactsV1.Models;
using ContactsV1.Operations;

namespace ContactsV1.Workflows
{
    public class ListContacts
    {
        public void Execute()
        {
            ContactRepository repo = new ContactRepository();
            List<Contact> contacts = repo.LoadAll();
            ContactPrinter printer = new ContactPrinter();
            printer.PrintList(contacts);
        }
    }
}
