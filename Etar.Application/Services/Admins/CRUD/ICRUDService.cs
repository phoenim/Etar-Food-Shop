using Etar.Application.Interfaces.Context;
using Etar.Application.Services.Admins.CRUD.Commands.AddNewAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Services.Admins.CRUD
{
    public interface ICRUDService
    {
        //سرویس افزودن ادمین جدید
        IAddNewAdminService addNewAdminService { get; }
    }

    public class CRUDService :ICRUDService
    {
        private readonly IDataBaseContext _context;

        public CRUDService(IDataBaseContext context)
        {
            _context = context;
        }

        private IAddNewAdminService _addAdmin;
        public IAddNewAdminService addNewAdminService
        {
            get
            {
                return _addAdmin = _addAdmin ?? new AddNewAdminService(_context);
            }
        }
    }
}
