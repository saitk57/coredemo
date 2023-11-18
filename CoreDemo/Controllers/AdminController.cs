//using BusinessLayer.Concrete;
//using BusinessLayer.ValidationRules;
//using DataAccessLayer.EntityFramework;
//using FluentValidation;
//using FluentValidation.Results;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using X.PagedList;

//namespace CoreDemo.Controllers
//{
   
//    public class AdminController : Controller
//    {
//        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

//        public IActionResult AdminCategoryList(int page=1)
//        {
//            var values = cm.GetList().ToPagedList(page, 3);
//            return View(values);
//        }

//        [HttpGet]

//        public IActionResult AdminCategoryAdd()
//        {
//            return View();
//        }

//        [HttpPost]

//        public IActionResult AdminCategoryAdd(Category p)
//        {


//            CategoryValidator cv = new CategoryValidator();
//            ValidationResult results = cv.Validate(p);


//            if (results.IsValid)
//            {
//                p.CategoryStatus = true;
                
//                p.WriterID = writerID;
//                bm.TAdd(p);
//                return RedirectToAction("BlogListByWriter", "Blog");
//            }

//            else
//            {
//                foreach (var item in results.Errors)
//                {
//                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
//                }
//            }
//            return View();
//        }
//    }
//}



//    }
//}
