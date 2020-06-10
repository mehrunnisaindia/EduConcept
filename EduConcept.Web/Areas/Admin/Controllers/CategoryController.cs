using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduConcept.DAL.Data.Repository.iRepository;
using Microsoft.AspNetCore.Mvc;

namespace EduConcept.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        
        private readonly IUnitOfwork _unitOfWork;

        public CategoryController(IUnitOfwork unitOfwork)
        {
            _unitOfWork = unitOfwork;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Apicalls
        [HttpGet]
        public IActionResult getAll()
        {
            return Json(new { data = _unitOfWork.Category.GetAll() }) ;
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDB = _unitOfWork.Category.Get(id);
            if(objFromDB==null)
            {
                return Json(new { success = "false", message = "Error while deleting" });
            }
            
                _unitOfWork.Category.Remove(objFromDB);
               _unitOfWork.Save();
               return Json(new { success = "true", message = "Delete Success" });
            

            
        }
        #endregion
    }
}