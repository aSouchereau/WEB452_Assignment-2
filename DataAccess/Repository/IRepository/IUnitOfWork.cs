﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlexsBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }

        public void Save();
    }
}
