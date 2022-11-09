using Core.Entitites.UserEntity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddIdentityDbContext(this IServiceCollection service)
        {
            service.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddRoles<IdentityRole>();
        }
    }
}
