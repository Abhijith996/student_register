using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample1_demo.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "admin" && Password == "12345")
            {
                // Redirects to the admin_user page
                return RedirectToPage("/admin_user");
            }
            else
            {
                Message = "Invalid credentials.";
                return Page(); // Stay on the same page
            }
        }

    }
}