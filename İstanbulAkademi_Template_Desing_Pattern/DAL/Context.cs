using İstanbulAkademi_Template_Desing_Pattern.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace İstanbulAkademi_Template_Desing_Pattern.DAL
{
    public class Context:IdentityDbContext<AppUser,  AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CNL5HMR;initial catalog=ZTemplateDesignDb;integrated security=true");
        }
    }
}
