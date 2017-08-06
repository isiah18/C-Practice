using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsV1.Workflows
{
    public class Menu
    {
        public void Execute()
        {
            string userInput;

            do
            {
                DisplayMenu();
                userInput = Console.ReadLine();

                ProcessUserChoice(userInput);
            } while (userInput.ToUpper() != "Q");
        }

        private void ProcessUserChoice(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    ListContacts listWorkflow = new ListContacts();
                    listWorkflow.Execute();
                    break;

            }
        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("***  Contacts V1 ***");
            Console.WriteLine("\n1. List Contacts");
            Console.WriteLine("2. Add New Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Search");
            Console.WriteLine("\nQ to quit\n\n");
            Console.WriteLine("Enter your choice: ");

        }
    }
}
