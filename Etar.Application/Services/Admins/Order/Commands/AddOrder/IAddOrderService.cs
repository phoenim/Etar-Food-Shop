﻿using Etar.Domain.Entities;
using Etar.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Application.Services.Admins.Order.Commands.AddOrder
{
    public interface IAddOrderService
    {
        Result Execute (Guid cartId);
    }
}
