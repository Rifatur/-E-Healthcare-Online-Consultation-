using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            DataContext context = new DataContext();

            List<Doctortbl> DoctorList = context.Doctortbls.ToList();
            DoctorModel doctorVm = new DoctorModel();

            List<DoctorModel> doctorVmList = DoctorList.Select(x => new DoctorModel
            {
                DocId = x.DocId,
                FName = x.FName,
                LName = x.LName,
                Email = x.Email,

            }).ToList();

            return View(doctorVmList);
        }

        public ActionResult ADD()
        {
            DataContext context = new DataContext();
            List<Department> Dlist = context.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(Dlist, "DepartmentId", "DName");
            return View();
        }

        [HttpPost]
        public ActionResult Addrecord(DoctorModel obj)
        {
            try
            {
                DataContext context = new DataContext();

                context.Doctortbls.Add(new Doctortbl()
                {
                    FName = obj.FName,
                    LName = obj.LName,
                    Email = obj.Email,
                    Passward = obj.Passward,
                    DOB = obj.DOB,
                    Gander = obj.Gander,
                    DocAddress = obj.DocAddress,
                    Country = obj.Country,
                    City = obj.City,
                    State = obj.State,
                    Post = obj.Post,
                    PhoneNo = obj.PhoneNo,
                    DepartmentId = obj.DepartmentId,
                    CreatedDate = obj.CreatedDate

                });

                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");

        }//End

        //Get ::: Details
        public ActionResult Details(int DocId)
        {
            DataContext context = new DataContext();

            Doctortbl dpt = context.Doctortbls.SingleOrDefault(x => x.DocId == DocId);
            DoctorModel VM = new DoctorModel();

            VM.DocId = dpt.DocId;
            VM.FName = dpt.FName;
            VM.LName = dpt.LName;
            VM.Email = dpt.Email;
            VM.Passward = dpt.Passward;
            VM.DOB = dpt.DOB;
            VM.Gander = dpt.Gander;
            VM.DocAddress = dpt.DocAddress;
            VM.Country = dpt.Country;
            VM.City = dpt.City;
            VM.State = dpt.State;
            VM.Post = dpt.Post;
            VM.PhoneNo = dpt.PhoneNo;
            VM.DepartmentId = dpt.DepartmentId;
            VM.DName = dpt.Department.DName;
            VM.CreatedDate = dpt.CreatedDate;

            return View(VM);
        }

        //Get::Edit
        public ActionResult Edit(int DocId)
        {
            DataContext context = new DataContext();
            var record = (from item in context.Doctortbls
                          where item.DocId == DocId
                          select item).First();

            List<Department> Dlist = context.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(Dlist, "DepartmentId", "DName");

            return View("Edit", record);
        }

        [HttpPost]

        public ActionResult Edit(DoctorModel Dobj)
        {
            DataContext context = new DataContext();
            var record = (from item in context.Doctortbls
                          where item.DocId == Dobj.DocId
                          select item).First();

            record.FName = Dobj.FName;
            record.LName = Dobj.LName;
            record.Email = Dobj.Email;
            record.Passward = Dobj.Passward;
            record.DOB = Dobj.DOB;
            record.Gander = Dobj.Gander;
            record.DocAddress = Dobj.DocAddress;
            record.Country = Dobj.Country;
            record.City = Dobj.City;
            record.State = Dobj.State;
            record.Post = Dobj.Post;
            record.PhoneNo = Dobj.PhoneNo;
            record.DepartmentId = Dobj.DepartmentId;
            record.CreatedDate = Dobj.CreatedDate;

            context.SaveChanges();

            var saverecord = context.Doctortbls.ToList();

            return RedirectToAction("Index", saverecord);
        }





        [HttpGet]
        public ActionResult Delete(int DocId)
        {
            DataContext context = new DataContext();
            var Deleterecord = (from item in context.Doctortbls
                                where item.DocId == DocId
                                select item).First();
            context.Doctortbls.Remove(Deleterecord);
            context.SaveChanges();
            var saverecord = context.Doctortbls.ToList();
            return RedirectToAction("Index", saverecord);
        }







    }
}