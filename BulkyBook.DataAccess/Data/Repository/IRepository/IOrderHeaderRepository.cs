﻿using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
