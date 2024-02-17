﻿using Contracr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Ef
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfDataContext _context;

        public UnitOfWork(EfDataContext context)
        {
            _context = context;
        }

        public async Task Begin()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public async Task RollBack()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}

