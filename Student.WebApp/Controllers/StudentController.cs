using Student.Application.Dto;
using Student.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student.WebApp.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Student
        public ActionResult Index()
        {
            List<StudentInfoDto> studentList = _studentService.GetStudents();
            return View(studentList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentInfoDto student = _studentService.GetStudent(id);
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                StudentInfoDto stu = new StudentInfoDto()
                {
                    Code = collection["Code"],
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    Age = Convert.ToInt32(collection["Age"])
                };

                _studentService.CreateStudent(stu);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            StudentInfoDto student = _studentService.GetStudent(id);
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                StudentInfoDto stu = new StudentInfoDto()
                {
                    Id = id,
                    Code = collection["Code"],
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    Age = Convert.ToInt32(collection["Age"])
                };

                _studentService.UpdateStudent(id, stu);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
