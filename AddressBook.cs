using System;
using System.Collections.Generic;

namespace AddressBookExercise
{
    public class AddressBook
    {
        public Dictionary<string, Contact> AllContacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            AllContacts.Add(contact.Email, contact);
        }
        public Contact GetByEmail(string email)
        {
            if (AllContacts.ContainsKey(email)) {
                return AllContacts.GetValueOrDefault(email);
            } else {
                return null;
            }
        }
    }
}