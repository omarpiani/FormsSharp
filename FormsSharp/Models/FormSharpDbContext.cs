using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSharp.Models
{
    public class FormSharpDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
