using EduConcept.BL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduConcept.DAL.Data.Repository.iRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();
        IEnumerable<Category> GetAllCategoryList();
        void Update(Category Category) ;



    }
}
