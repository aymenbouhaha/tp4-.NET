using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4.Data;
using tp4.Models;

namespace tp4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            UniversityContext context = UniversityContext.Instantiate_UniversityContext();
            List<Student> students = context.Student.ToList();
            foreach (Student student in students)
            {
                Debug.WriteLine(student.id);
            }
            Debug.WriteLine(context.Student.Find(2).first_name);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}