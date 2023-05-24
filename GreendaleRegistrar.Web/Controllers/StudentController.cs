using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreendaleRegistrar.Data;
using GreendaleRegistrar.Models;

namespace GreendaleRegistrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly GreendaleRegistrarContext _context;

    public StudentsController(GreendaleRegistrarContext context)
    {
      _context = context;
    }

    // GET: Students
    public async Task<IActionResult> Index()
    {
      return View(await _context.Students.ToListAsync());
    }

    // GET: Students/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var student = await _context.Students
        .FirstOrDefaultAsync(m => m.Id == id);
        if (student == null)
        {
          return NotFound();
        }

        return View(student);
    }

    // GET: Students/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Students/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,EnrollmentDate")] Student student)
    {
      if (ModelState.IsValid)
      {
        _context.Add(student);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(student);
    }

    // Other methods for Edit, Delete etc. will go here

  }
}
