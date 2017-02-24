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
        public ActionResult EmployeeMaster()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeMaster(Employee obj)
        {
            ViewBag.Records = "Name : " + obj.Name + " City:  " + obj.City + " Addreess: " + obj.Address;
            return PartialView("EmployeeMaster");
        }

        [HttpPost]
        public ActionResult Edit(Employee obj)
        {
            return obj.Name.ToLower() == "fail" ? JavaScript("OnFailure('Failed');") : JavaScript("OnSuccess('OK');");
        }
    }
}