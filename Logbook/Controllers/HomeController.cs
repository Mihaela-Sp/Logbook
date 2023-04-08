using LogBook.Data;
using LogBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LogBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public int SelectedLesson { get; set; }

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Student.ToListAsync();
            //ViewBag.Lessonid
            ViewData["Lessonid"] = new SelectList(_context.Lesson, "Id", "Description");
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LoadClass(int lessonid)
        {
            var students =  _context.Student.Where(x=>x.Mark.LessonId==lessonid).ToListAsync();
            return RedirectToAction("Index", students);
        }

        public IActionResult SetMark(int studentId, int lessonid, int mark)
        {
            var checkIfExists = _context.Mark.FirstOrDefault(x => x.LessonId == lessonid
                                        && x.StudentId == studentId);

            var markObject = new Mark
            {
                LessonId = lessonid,
                StudentId = studentId,
                Points = mark
            };

            if (checkIfExists == null)
            {
                _context.Mark.Add(markObject);
            }
            else
            {
                _context.Mark.Update(markObject);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
