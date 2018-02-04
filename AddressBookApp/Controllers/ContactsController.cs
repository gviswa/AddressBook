using AddressBookApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AddressBookApp.Api.Controllers
{
    public class ContactsController : ApiController
    {
        private IList<Contact> _contacts;

        public ContactsController()
        {
            _contacts = new List<Contact>()
            {
                new Contact() { Id=1, Name="James", Phone="78978978999" },
                new Contact() { Id=2, Name = "John", Phone = "87897987989" },
                new Contact() { Id=3, Name = "Joshua", Phone = "7979797878" }
            };
        }

        // GET: api/Contacts
        public IEnumerable<Contact> Get()
        {
            return _contacts;
        }

        // GET: api/Contacts/5
        public Contact Get(int id)
        {
            return _contacts.First(x=>x.Id == id);
        }

        // POST: api/Contacts
        public void Post([FromBody]Contact value)
        {
            _contacts.Add(value);
        }

        // PUT: api/Contacts/5
        public void Put(int id, [FromBody]Contact value)
        {
            var contact = _contacts.First(x => x.Id == id);
            contact.Name = value.Name;
            contact.Phone = value.Phone;
        }

        // DELETE: api/Contacts/5
        public void Delete(int id)
        {
            var contact = _contacts.First(x => x.Id == id);
            _contacts.Remove(contact);
        }
    }
}
