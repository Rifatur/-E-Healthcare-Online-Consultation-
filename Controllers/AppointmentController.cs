using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            DataContext context = new DataContext();

            List<Appointment> DoctorList = context.Appointments.ToList();
            AppointmentModel doctorVm = new AppointmentModel();

            List<AppointmentModel> doctorVmList = DoctorList.Select(x => new AppointmentModel
            {
                AId = x.AId,
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
                    APM_Date=obj.APM_Date,

                    Gender = obj.Gender,
                    Age = obj.Age,

                    contactNo = obj.contactNo,
                    Message= obj.Message,

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
        public ActionResult Details(int AId)
        {
            DataContext context = new DataContext();

            Appointment dpt = context.Appointments.SingleOrDefault(x => x.AId == AId);
            AppointmentModel VM = new AppointmentModel();

            VM.AId = dpt.AId;
            VM.FName = dpt.FName;
            VM.LName = dpt.LName;
            VM.Email = dpt.Email;

            VM.Gender = dpt.Gender;
            VM.Age = dpt.Age;
            VM.Address = dpt.Address;
            VM.City = dpt.City;
            VM.State = dpt.State;

            VM.set_time = dpt.set_time;
            VM.APM_Date = dpt.APM_Date;
            VM.contactNo = dpt.contactNo;
            VM.Message = dpt.Message;

            VM.DepartmentId = dpt.DepartmentId;
            VM.DocId = dpt.DocId;
            VM.DName = dpt.Department.DName;

            VM.CreatedDate = dpt.CreatedDate;

            return View(VM);
        }



    }

}