﻿using Etar.Application.Interfaces.Context;
using Etar.Domain.Entities.Addresses;
using Etar.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Presistance.Context
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) 
        { }

        public DbSet<Client> users { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Address> addresses { get ; set; }

    }
}
