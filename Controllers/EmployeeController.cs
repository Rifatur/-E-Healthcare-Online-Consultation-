using Hoyna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoyna.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        DataContext context = new DataContext();
        public ActionResult Index()
        {
            List<Employee> employee = context.Employees.ToList();
            return View(employee);
        }

        public ActionResult Employeetype()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employeetype(EmployeeTypeModel type)
        {

            context.EmployeeTypes.Add(new EmployeeType()
            {
                eTypeName=type.eTypeName
            });
            context.SaveChanges();
            return RedirectToAction("Index", type);
        }


        //Upload Employee 

        public ActionResult Upload()
        {
            List<EmployeeType> eType = context.EmployeeTypes.ToList();
            ViewBag.eTypeList = new SelectList(eType, "eTypeId", "eTypeName");

            return View();
        }
        [HttpPost]
        public ActionResult Upload(EmployeeModel emp)
        {

            context.Employees.Add(new Employee
            {
                EmpFName=emp.EmpFName,
                EmpLName=emp.EmpLName,
                Email=emp.Email,
                Passward=emp.Passward,
                DOB=emp.DOB,
                EmpImage =emp.EmpImage,
                Gander=emp.Gander,
                EmpAddress=emp.EmpAddress,

                City=emp.City,
                State=emp.State,
                Post=emp.Post,
                PhoneNo=emp.PhoneNo,
                eTypeId=emp.eTypeId,
                CreatedDate=emp.CreatedDate
            });
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Details(int EmpId)
        {
            Employee employ = context.Employees.Where(x => x.EmpId == EmpId).SingleOrDefault();
            return View(employ);
        }


        [HttpGet]
        public ActionResult Delete(int EmpId)
        {
            var Deleterecord = (from item in context.Employees
                                where item.EmpId == EmpId
                                select item).First();
            context.Employees.Remove(Deleterecord);
            context.SaveChanges();
            var saverecord = context.Employees.ToList();
            return RedirectToAction("Index", saverecord);
        }






    }
}