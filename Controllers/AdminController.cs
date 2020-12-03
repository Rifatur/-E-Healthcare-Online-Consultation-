using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hoyna.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["adminID"] != null)
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
        public ActionResult login(AdminModel log)
        {
            DataContext context = new DataContext();
            var Query = context.Admins.Where(a => a.Email.Equals(log.Email) && a.Password.Equals(log.Password)).FirstOrDefault();
            if (Query != null)
            {
                Session["adminID"] = Query.adminID.ToString();
                Session["Name"] = Query.Name.ToString();
                Session["Email"] = Query.Email.ToString();
                return RedirectToAction("Index");
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
        public ActionResult Registation(AdminModel user)
        {
            DataContext context = new DataContext();

            context.Admins.Add(new Admin()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                CreatedDate = user.CreatedDate,
            });
            context.SaveChanges();
            return RedirectToAction("Index", user);
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Index");
        }

    }
}