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
            var aStudent = new Student() { FirstName = "Abu", LastName = "Sayed", Department = "CSE,JU" };

            var students = Repository.GetStudentList();
            var create = Repository.Create(aStudent);
            var student = Repository.GetStudent();
            var studentById = Repository.GetStudentById(1);
            return View(students);
        }
    }
}