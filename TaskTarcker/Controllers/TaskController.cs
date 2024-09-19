namespace TaskTarcker.Controllers
{
    using TaskTarcker.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TaskTarcker.Models;
    using System;
    using Microsoft.EntityFrameworkCore;




    public class TaskController : Controller
        {
            private readonly AppDbContext _context;

            public TaskController(AppDbContext context)
            {
                _context = context;
            }

            [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskTarcker.Models.Task task)

        {
            if (ModelState.IsValid)
                {
                var userExists = await _context.Users.AnyAsync(u => u.user_id == task.UserId);
                if (!userExists)
                {
                    return Json(new { success = false, error = "Invalid User ID" });
                }
                task.CreatedAt = DateTime.Now;
                    task.UpdatedAt = DateTime.Now;

                    _context.Tasks.Add(task);
                    await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Task created successfully" });

            }
            
            return Json(new { success = false, error = "Invalid task data" });

            // If the model is not valid, return to the task creation view
            return View(task);
            }
        }
    }


