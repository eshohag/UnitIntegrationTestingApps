using System;
using System.Collections.Generic;
using System.Linq;
using UnitIntegrationTestingApps.Models;

namespace UnitIntegrationTestingApps.BLL
{
    public class Repository
    {
        public static Student GetStudent()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Students.FirstOrDefault(a => a.Id == 1);
            }
        }
        public static Student GetStudentById(int id)
        {
            return new Student() { Id = 1, FirstName = "Shohag", LastName = "Hassan", Department = "CSE" };
        }

        public static List<Student> GetStudentList()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Students.ToList();
            }
        }

        public static int Create(Student aStudent)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    db.Students.Add(aStudent);
                    return db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}