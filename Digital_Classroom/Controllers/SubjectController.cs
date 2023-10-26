using Digital_Classroom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Digital_Classroom.Services;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Digital_Classroom.Data;
using System.Linq;

namespace Digital_Classroom.Controllers
{
    public class SubjectController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly ISubjectRepository subjectRepository;
        private readonly ClassroomContext _context;

        public SubjectController(UserManager<AppUser> userManager, ISubjectRepository subjectRepository, ClassroomContext context)
        {
            this.userManager = userManager;
            this.subjectRepository = subjectRepository;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(subjectRepository.GetAll());
        }

        [Authorize(Roles ="Teacher")]
        public IActionResult New()
        {
            return View(new Subject());
        }


        [Authorize(Roles ="Teacher")]
        [HttpPost]
        public async Task<IActionResult> New(IFormFile Image ,Subject subject)
        {
            subject.TeacherId = userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                var id = await subjectRepository.Insert(subject, Image);
                return Redirect($"/Subject/Details/{id}");
            }
            TempData["Error"] = "Error Creating Subject, Please Try Again";
            return View(subject);
        }

        [Authorize]
        public async Task<IActionResult> MySubjects(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (User.IsInRole("Teacher"))
                return View("Index", user.SubjectsTeaching);
            if (User.IsInRole("Student"))
            {
                var subjects = new List<Subject>();
                foreach (var studSubject in user.SubjectsStudying)
                {
                    subjects.Add(studSubject.Subject);
                }
                return View("Index", subjects);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Find the subject with the specified id
            var subject = _context.Subjects.FirstOrDefault(s => s.Id == id);

            if (subject == null)
            {
                // Subject not found, handle accordingly (e.g., show an error)
                return NotFound();
            }

            // Delete the subject
            _context.Subjects.Remove(subject);
            _context.SaveChanges(); // Save changes to the database

            // Redirect to a page after successful deletion
            return RedirectToAction("Index"); // You can replace "Index" with the appropriate action
        }


        public IActionResult Details(int id)
        {
            var subject = subjectRepository.GetById(id);
            return View(subject);
        }

    }
}
