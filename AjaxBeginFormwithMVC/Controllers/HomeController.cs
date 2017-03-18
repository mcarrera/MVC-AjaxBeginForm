using AjaxBeginFormwithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginFormwithMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employee(Employee employee)
        {
            ViewBag.Records = "Name : " + employee.FirstName + " City:  " + employee.LastName + " Addreess: " + employee.Comments;
            return PartialView("Employee");
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            return employee.FirstName.ToLower() == "fail" ? JavaScript("OnFailure('Failed');") : JavaScript("OnSuccess('OK');");
        }
    }
}