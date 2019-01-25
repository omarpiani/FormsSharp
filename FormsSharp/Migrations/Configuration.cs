namespace FormsSharp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FormsSharp.Models.FormSharpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FormsSharp.Models.FormSharpDbContext context)
        {
            context.Contacts.AddOrUpdate(c => c.Name, 
                new Models.Contact { Name = "Omar", Email = "omar@email" }, 
                new Models.Contact { Name = "Jeff", Email = "jeff@email" });
        }
    }
}
