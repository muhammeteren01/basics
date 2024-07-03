using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if (id == 0)
            {
                //return Redirect("/course/list");
                return RedirectToAction("List","Course");
            }
            var course = Repository.GetById(id);

            return View(course);
        }

        public IActionResult List()
        {
             
            return View(Repository.Courses);
        }
    }
}
