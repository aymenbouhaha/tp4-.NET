using Microsoft.AspNetCore.Mvc;
using tp4.Data;
using tp4.Models;

namespace tp4.Controllers
{
    public class Courses : Controller
    {
        public IActionResult Index()
        {
            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            StudentRepository repository = new StudentRepository(context);
            List<string> course = repository.getCourses();
            return View(course);
        }

        [Route("/Courses/{name}")]
        public IActionResult getStudents(string name)
        {
            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            StudentRepository repository = new StudentRepository(context);
            List<Student> students = repository.getStudentsBasedOnCourse(name);
            return View(students);
        }
    }
}
