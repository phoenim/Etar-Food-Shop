using Etar.Application.Interfaces.Context;
using Etar.Application.Interfaces.Services.Admin;
using Etar.Application.Services.Admins.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Services.Admins
{
    public class AdminServices :IAdminServices
    {
        private readonly IDataBaseContext _context;
        public AdminServices(IDataBaseContext context)
        {
            _context = context;
        }

        private ICRUDService _crudServices;
        public ICRUDService CRUDServices
        {
            get
            {
                return _crudServices = _crudServices ?? new CRUDService(_context);
            }
        }
    }
}
