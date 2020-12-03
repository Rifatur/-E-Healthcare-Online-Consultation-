using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ADD()
        {
            DataContext context = new DataContext();

            List<Department> Dlist = context.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(Dlist, "DepartmentId", "DName");

            List<Doctortbl> dolist = context.Doctortbls.ToList();
            ViewBag.DoctorList = new SelectList(dolist, "DocId", "FName");

            return View();
        }

        [HttpPost]
        public ActionResult Addrecord(AppointmentModel obj)
        {
            try
            {
                DataContext context = new DataContext();

                context.Appointments.Add(new Appointment()
                {
                    FName = obj.FName,
                    LName = obj.LName,
                    Email = obj.Email,

                    Address = obj.Address,
                    City = obj.City,
                    State = obj.State,

                    DepartmentId = obj.DepartmentId,
                    DocId = obj.DocId,

                    set_time = obj.set_time,
                    APM_Date = obj.APM_Date,

                    Gender = obj.Gender,
                    Age = obj.Age,

                    contactNo = obj.contactNo,
                    Message = obj.Message,

                    CreatedDate = obj.CreatedDate

                });

                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");

        }//End Appoinment


        //Get Doctor From Database 


        public ActionResult Doctor()
        {
            DataContext context = new DataContext();

            List<Doctortbl> DoctorList = context.Doctortbls.ToList();
            DoctorModel doctorVm = new DoctorModel();

            List<DoctorModel> doctorVmList = DoctorList.Select(x => new DoctorModel
            {
                DocId = x.DocId,
                FName = x.FName,
                LName = x.LName,

            }).ToList();

            return View(doctorVmList);


        }




    }
}