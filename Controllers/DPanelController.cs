using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class DPanelController : Controller
    {
        // GET: DPanel
        public ActionResult Index()
        {
            if (Session["DocId"] != null)
            {
                
                DataContext context = new DataContext();
                var count = (from x in context.Appointments select x).Count();
                ViewBag.count = count;
                int count2 = (from x in context.Appointments where x.DocId==5 select x).Count();
                ViewBag.count2 = count2;
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
            
        }



        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(DoctorModel doctorobj)
        {
            DataContext context = new DataContext();

            var Query = context.Doctortbls.Where(a => a.Email.Equals(doctorobj.Email) && a.Passward.Equals(doctorobj.Passward)).FirstOrDefault();
            if (Query != null)
            {
                Session["DocId"] = Query.DocId.ToString();
                Session["FName"] = Query.FName.ToString();
                Session["LName"] = Query.LName.ToString();
                Session["Email"] = Query.Email.ToString();
                return RedirectToAction("Index");
            }


            return View("Query");
        }
        ///////////////////////Education/////////////
        public ActionResult Education(Int32 docId)
        {
            if (Session["DocId"] != null)
            {
              DataContext context = new DataContext();
                List<Education> edudetails = context.Educations.Where(x => x.DocId == docId).ToList();
                
                return View(edudetails);

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //////////////////////////////////////////////////////////////////////////.
        //Add Degree
        public ActionResult AddDegree()
        {
            DataContext context = new DataContext();
            return View("AddDegree");
        }
        //Add Degree

        [HttpPost]
        public ActionResult AddDegree(EducationModel edu)
        {
            try
            {
                DataContext context = new DataContext();
                context.Educations.Add(new Education()
                {
                    DegreeName = edu.DegreeName,
                    StartDate = edu.StartDate,
                    EndDate = edu.EndDate,
                    University = edu.University,
                    Country = edu.Country,
                    City = edu.City,
                    DocId = edu.DocId,
                });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        //Details

        public ActionResult EDetails(int EId)
        {
            DataContext context = new DataContext();
            var emp = context.Educations.Find(EId);
            return View(emp);
        }



        public ActionResult EEdit(int EId)
        {
            DataContext context = new DataContext();
            var edit = context.Educations.Find(EId);
            return View(edit);
        }
        [HttpPost]

        public ActionResult EEdit(Education edu)
        {
            DataContext context = new DataContext();
            var E = context.Educations.Find(edu.EId);
            if (E != null)
            {
                E.DegreeName = edu.DegreeName;
                E.StartDate = edu.StartDate;
                E.EndDate = edu.EndDate;
                E.University = edu.University;
                E.Country = edu.Country;
                E.City = edu.City;
            }
                context.SaveChanges();
            
            return RedirectToAction("Index");

        }












        ////////////Specialization////////

        public ActionResult Specialization()
        {
            DataContext context = new DataContext();
            //List<Specialization> edudetails = context.Specializations.Where(x => x.DocId == docId).ToList();

            return View("Specialization");
        }
        [HttpPost]
        public ActionResult Specialization(SpecializationModel special)
        {
            try
            {
                DataContext context = new DataContext();
                context.Specializations.Add(new Specialization()
                {
                    SpecName=special.SpecName,
                    DocId=special.DocId,
                });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }



        //////////////////////////Appointment////////
        ///
        public ActionResult Appointment(Int32 docId)
        {
            if (Session["DocId"] != null)
            {
                DataContext context = new DataContext();
                List<Appointment> appoint = context.Appointments.Where(x => x.DocId == docId).ToList();

                return View(appoint);

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //////////// GET Details
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
        // GET Edit 







        //////////// Message Function

        public ActionResult Massage()
        {


            return View(); 
        
        }


        //////////// Report Function
        public ActionResult Report()
        {


            return View();

        }

        //////////// Profile Function
        public ActionResult profile(Int32 docId)
        {
            return View();
        }





        //////namespace
    }


}