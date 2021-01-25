using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMS.Controllers;
using BMS.Inteface;
using BMS.Models;
using BMS.Repository;

namespace BMS.UnitOFWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Branches = new BranchRepository(_context);
        }

        public IBranchRepository Branches { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}