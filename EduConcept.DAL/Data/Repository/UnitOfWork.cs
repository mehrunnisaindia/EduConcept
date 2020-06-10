using EduConcept.DAL.Data.Repository;
using EduConcept.DAL.Data.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduConcept.DAL.Data.Repository
{
    public class UnitOfWork : IUnitOfwork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category=new CategoryRepository(_db);
        }

        public  ICategoryRepository Category { get; private set; }


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

