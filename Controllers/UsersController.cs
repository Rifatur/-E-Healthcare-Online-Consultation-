using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Dashboard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }

        public ActionResult login()
        {
            DataContext context = new DataContext();
            return View();
        }
        [HttpPost]
        public ActionResult login(UsertblModel log)
        {
            DataContext context = new DataContext();
            var Query = context.Usertbls.Where(a => a.Email.Equals(log.Email) && a.Password.Equals(log.Password)).FirstOrDefault();
            if (Query != null)
            {
                Session["UserID"] = Query.UserID.ToString();
                Session["UserName"] = Query.UserName.ToString();
                Session["Email"] = Query.Email.ToString();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("login");
            }

            return View("Query");
        }

        public ActionResult Registation()
        {
            DataContext context = new DataContext();
            return View();
        }
        [HttpPost]
        public ActionResult Registation(Usertbl user )
        {
            DataContext context = new DataContext();

            context.Usertbls.Add(new Usertbl()
            {
                UserName=user.UserName,
                Email = user.Email,
                Password = user.Password,
                createdDate=user.createdDate,
            });
            context.SaveChanges();
            return RedirectToAction("login", user);
        }



    }
}