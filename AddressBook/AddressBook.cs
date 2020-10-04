using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        public List<Contact> ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }
    }
}
