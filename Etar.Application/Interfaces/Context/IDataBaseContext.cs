using Etar.Domain.Entities.Addresses;
using Etar.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {
        DbSet<User> users { get; set; }
        DbSet<Admin> admins { get; set; }
        DbSet<Address> addresses { get; set; }
        
    }
}
