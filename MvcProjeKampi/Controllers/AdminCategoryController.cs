using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = categoryManager.GetCategoryList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult result = validationRules.Validate(category);
            if (result.IsValid)
            {
                categoryManager.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public ActionResult DeleteCategory(int id)
        {
            var category = categoryManager.GetByID(id);
            categoryManager.CategoryDelete(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = categoryManager.GetByID(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            categoryManager.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}