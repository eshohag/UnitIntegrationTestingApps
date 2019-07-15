using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitIntegrationTestingApps.BLL;
using UnitIntegrationTestingApps.Models;

namespace UnitIntegrationTestingApps.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = Repository.GetStudentList();
            return View(students);
        }
    }
}