﻿using Etar.Application.Services.Admins.Cart;
using Etar.Application.Services.Admins.Food;
using Etar.Application.Services.Admins.Order;
using Etar.Application.Services.Admins.Table;
using Etar.Application.Services.Admins.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Interfaces.Services.Admin
{
    public interface IAdminServices
    {
        IUserService UserServices { get; }
        IFoodService FoodServices { get; }
        ITableService TableServices { get; }
        ICartService CartServices { get; }
        IOrderService OrderServices { get; }
    }
}
