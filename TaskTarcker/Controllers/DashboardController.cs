using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskTarcker.Data; // Ensure you're using the namespace where AppDbContext is defined
using TaskTarcker.Models; // To access the Task model
using Microsoft.EntityFrameworkCore; // For ToListAsync()
using System.Threading.Tasks;

namespace TaskTarcker.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        // Inject the AppDbContext via the constructor
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _context.Tasks.ToListAsync(); // Fetch tasks from the database
            return View(tasks); // Pass the tasks to the view
        }
    }
}

