using BulkyBook.DataAccess.Data.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Data.Repository
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfwork(ApplicationDbContext db)
        {
            _db = db;
            ApplicationUser = new ApplicationUserRepository(_db);
            Category = new CategoryRepository(_db);
            Company = new CompanyRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRespository(_db);
            SP_Call = new SP_Call(_db);
        }
        public IApplicationUser ApplicationUser { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
