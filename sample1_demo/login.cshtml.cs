using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample1_demo
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            // Simple demo validation
            if (Username == "admin" && Password == "12345")
            {
                Message = "Login successful!";
            }
            else
            {
                Message = "Invalid credentials.";
            }
        }
    }
}
