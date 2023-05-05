using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2
{
    public class ContactsAPIDbContext: DbContext {
        public ContactsAPIDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Contact> Contacts
        {
            get;
            set;
        }
    }
}
