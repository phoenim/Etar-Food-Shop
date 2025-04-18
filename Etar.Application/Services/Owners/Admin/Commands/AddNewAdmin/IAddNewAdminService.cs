﻿using Etar.Domain.Entities;
using Etar.Domain.Entities.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Services.Owners.Admin.Commands.AddNewAdmin
{
    public interface IAddNewAdminService
    {
        Result Execute(ReqAddNewAdminDto request);
    }
}
