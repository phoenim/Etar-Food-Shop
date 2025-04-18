﻿using Etar.Domain.Entities.Users;

namespace Etar.Application.Services.Owners.Admin.Commands.AddNewAdmin
{
    public class ReqAddNewAdminDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public EAdminRoles Role { get; set; }
    }
}
