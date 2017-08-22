using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Common;


    public class ContactController : ApiController
    {
        static List<Contact> contacts = new List<Contact>();
        static ContactController()
        {
            contacts.Add(new Contact { Id = "001", Name = "zhang", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
            contacts.Add(new Contact { Id = "002", Name = "wang", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
            contacts.Add(new Contact { Id = "003", Name = "li", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
            contacts.Add(new Contact { Id = "004", Name = "zhao", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
            contacts.Add(new Contact { Id = "005", Name = "qin", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
            contacts.Add(new Contact { Id = "006", Name = "aa", PhoneNo = "0512-12345678", EmailAddress = "qinzhiqiang@qq.com", Address = "gd" });
        }

        public IEnumerable<Contact> Get(string id = null)
        {
            return from contact in contacts
                   where contact.Id == id || string.IsNullOrEmpty(id)
                   select contact;
        }

        public void Post(Contact contact)
        {
            contacts.Add(contact);
        }

        public void Put(Contact contact)
        {
            contacts.Remove(contacts.First(c => c.Id == contact.Id));
            contacts.Add(contact);
        }

        public void Remove(string id)
        {
            contacts.Remove(contacts.First(c => c.Id == id));
        }
    }
