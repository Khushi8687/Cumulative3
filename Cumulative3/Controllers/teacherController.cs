using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Cumulative3.Controllers
{
    public class TeacherController : Controller
    {
        private readonly SchoolDbContext _dbContext;

        public TeacherController(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }
// GET: /Teacher/Index
public ActionResult Index()
        {
            return View();
        }

        // GET: /Teacher/List
        public ActionResult List()
        {
            IEnumerable<Teacher> teachers = _dbContext.Teachers;
            return View(teachers);
        }

        // GET: /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            var teacher = _dbContext.Teachers.Find(id);

            if (teacher == null)
            {
                TempData["ErrorMessage"] = "Teacher not found.";
                return RedirectToAction("List");
            }

            return View(teacher);
        }

        public ActionResult DeleteConfirm(int id)
        {
            var teacher = _dbContext.Teachers.Find(id);

            if (teacher == null)
            {
                TempData["ErrorMessage"] = "Teacher not found.";
                return RedirectToAction("List");
            }

            return View(teacher);
        }

        public ActionResult Update(int id)
        {
            var teacher = _dbContext.Teachers.Find(id);

            if (teacher == null)
            {
                TempData["ErrorMessage"] = "Teacher not found.";
                return RedirectToAction("List");
            }

            return View(teacher);
        }
    }
}