﻿using Etar.Application.Interfaces.Context;
using Etar.Application.Services.Owners.Admin.Commands.AddNewAdmin;
using Etar.Application.Services.Owners.Admin.Commands.EditAdmin;
using Etar.Application.Services.Owners.Admin.Commands.RemoveAdmin;
using Etar.Application.Services.Owners.Admin.Queries.GetAdmin;
using Etar.Application.Services.Owners.Admin.Queries.GetAdminOrderDetails;
using Etar.Application.Services.Owners.Admin.Queries.GetAdminOrders;
using Etar.Application.Services.Owners.Admin.Queries.GetAdmins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Services.Owners.Admin
{
    public interface IAdminService
    {
        IAddNewAdminService AddNewAdminService { get; }
        IRemoveAdminService RemoveAdminService  { get; }    
        IGetAdminsService GetAdminsService { get; }
        IGetAdminOrdersService GetAdminOrdersService { get; }
        IEditAdminService EditAdminService { get; }
        IGetAdminService GetAdminService { get; }
        IGetAdminOrderDetailsService GetAdminOrderDetailsService { get; }
    }


    public class AdminService : IAdminService
    {
        private readonly IDataBaseContext _context;

        public AdminService(IDataBaseContext context)
        {
            _context = context;
        }

        private IAddNewAdminService _addAdmin;
        public IAddNewAdminService AddNewAdminService
        {
            get 
            {
                return _addAdmin = _addAdmin ?? new AddNewAdminService(_context);
            }
        }

        private IRemoveAdminService _removeAdmin;
        public IRemoveAdminService RemoveAdminService
        {
            get
            {
                return _removeAdmin = _removeAdmin ?? new RemoveAdminService(_context);
            }
        }

        private IGetAdminsService _getAdmins;
        public IGetAdminsService GetAdminsService
        {
            get
            {
                return _getAdmins = _getAdmins ?? new GetAdminsService(_context);
            }
        }

        private IGetAdminOrdersService _getAdminOrders;
        public IGetAdminOrdersService GetAdminOrdersService
        {
            get
            {
                return _getAdminOrders = _getAdminOrders ?? new GetAdminOrdersService(_context);
            }
        }

        private IEditAdminService _editAdmin;
        public IEditAdminService EditAdminService
        {
            get
            {
                return _editAdmin = _editAdmin ?? new EditAdminService(_context);
            }
        }

        private IGetAdminService _getAdmin;
        public IGetAdminService GetAdminService
        {
            get
            {
                return _getAdmin = _getAdmin ?? new GetAdminService(_context);
            }
        }

        private IGetAdminOrderDetailsService _getAdminOrderDetails;
        public  IGetAdminOrderDetailsService GetAdminOrderDetailsService
        {
            get
            {
                return _getAdminOrderDetails = _getAdminOrderDetails ?? new GetAdminOrderDetailsService(_context);
            }
        }
    }
}
