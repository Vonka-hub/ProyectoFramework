using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TaskTarcker.Data;

namespace TaskTarcker.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // This will look for Views/Login/Index.cshtml
        }

        [HttpPost]
        public async Task<IActionResult> Login(string NombreUsuario, string Contrasena)
        {
            var user = _context.Users.SingleOrDefault(u => u.user_name == NombreUsuario);

            if (user != null && Contrasena == user.password_hash) 
            {
                // Create claims and sign-in
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.user_name),
                    // Add more claims as needed
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                // Redirect to dashboard
                return RedirectToAction("Index", "Dashboard");
            }

            // Show an error message if login fails
            ViewBag.Error = "Nombre de usuario o contraseña incorrectos";
            return View("Index"); // Returns the Login/Index.cshtml view
        }
    }
}
