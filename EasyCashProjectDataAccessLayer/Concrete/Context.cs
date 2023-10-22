using EasyCashProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProjectDataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-47FTA5Q\\SQLEXPRESS;initial catalog=EasyCashDb;integrated Security=true");

        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

    }
}
