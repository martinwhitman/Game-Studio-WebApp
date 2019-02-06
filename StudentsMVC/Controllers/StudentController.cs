using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsMVC.Shared.Orchestrators;
using StudentsMVC.Shared.ViewModels;

namespace StudentsMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var StudentOrchestrator = new StudentOrchestrator();

            var model = StudentOrchestrator.GetStudentDetails();

            return View(model);
        }
    }
}