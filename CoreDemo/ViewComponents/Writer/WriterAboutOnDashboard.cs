using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    // burası identity kütüphanesi dahil edilmeden önce maile göre login lan writerin listesini getirme kodlarıdır.
    //public class WriterAboutOnDashboard:ViewComponent
    //{
    //    WriterManager writermanager = new WriterManager(new EfWriterRepository());
    //    public IViewComponentResult Invoke()
    //    {
    //        var usermail = User.Identity.Name;
    //        Context c = new Context();
    //        var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
    //        var values = writermanager.GetWriterById(writerID);
    //        return View(values);
    //    }

    //}

    
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EfWriterRepository());
        Context c = new Context();


        public IViewComponentResult Invoke()
        {
            
            //var user = await _usermanager.FindByEmailAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.v = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = writermanager.GetWriterById(writerID);
            return View(values);
        }

    }
}
