using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sample1_demo.Pages
{
    public class user_addModel : PageModel
    {

        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Aadhar { get; set; }
        [BindProperty] public string Email { get; set; }
        [BindProperty] public string Mobile { get; set; }
        [BindProperty] public string PermanentAddress { get; set; }
        [BindProperty] public string CurrentAddress { get; set; }
        [BindProperty] public string FatherName { get; set; }
        [BindProperty] public string MotherName { get; set; }
        [BindProperty] public IFormFile UploadFile { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (UploadFile != null)
            {
                // Handle file upload (save to server, database, etc.)
            }

            // Save user details to database here

            return RedirectToPage("/Index");
        }
    }
}