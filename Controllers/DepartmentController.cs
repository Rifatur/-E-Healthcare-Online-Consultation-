using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DataContext context = new DataContext();
            List<Department> DList = context.Departments.ToList();
            List<DepartmentModel> DVmList = DList.Select(x => new DepartmentModel
            {
                DepartmentId = x.DepartmentId,
                DName = x.DName,
                Discription = x.Discription
            }).ToList();

            return View(DVmList);
        }
        //ADD
        public ActionResult ADD()
        {
            return View("ADD");
        }
        [HttpPost]
        public ActionResult ADD(DepartmentModel obj)
        {
            DataContext context = new DataContext();

            context.Departments.Add(new Department()
            {

                DName = obj.DName,
                Discription = obj.Discription,
                createdDate=obj.createdDate
            });
            context.SaveChanges();
            return RedirectToAction("Index", obj);
        }

        //Details
        public ActionResult Details(int DepartmentId)
        {
            DataContext context = new DataContext();

            Department dpt = context.Departments.SingleOrDefault(x => x.DepartmentId == DepartmentId);
            DepartmentModel VM = new DepartmentModel();

            VM.DepartmentId = dpt.DepartmentId;
            VM.DName = dpt.DName;
            VM.Discription = dpt.Discription;
            VM.DImage = dpt.DImage;
            VM.createdDate = dpt.createdDate;

            return View(VM);
        }


       //Edit
        public ActionResult Edit(int DepartmentId)
        {
            DataContext context = new DataContext();
            var record = (from item in context.Departments
                          where item.DepartmentId == DepartmentId
                          select item).First();
            return View("Edit", record);
        }

        [HttpPost]

        public ActionResult Edit(DepartmentModel Dobj)
        {
            DataContext context = new DataContext();
            var record = (from item in context.Departments
                          where item.DepartmentId == Dobj.DepartmentId
                          select item).First();

            record.DName = Dobj.DName;
            record.Discription = Dobj.Discription;
            record.createdDate = Dobj.createdDate;

            context.SaveChanges();

            var saverecord = context.Departments.ToList();

            return RedirectToAction("Index", saverecord);
        }

        [HttpGet]
        public ActionResult Delete(int DepartmentId)
        {
            DataContext context = new DataContext();
            var Deleterecord = (from item in context.Departments
                          where item.DepartmentId == DepartmentId
                          select item).First();
            context.Departments.Remove(Deleterecord);
            context.SaveChanges();
            var saverecord = context.Departments.ToList();
            return RedirectToAction("Index", saverecord);
        }


    }
}