using System;
using System.Collections.Generic;
using System.Text;

namespace EduConcept.DAL.Data.Repository.iRepository
{
    public interface IUnitOfwork: IDisposable
    {
        ICategoryRepository Category { get; }

        // IUserRepository User { get; }
        void Save();

    }
}
