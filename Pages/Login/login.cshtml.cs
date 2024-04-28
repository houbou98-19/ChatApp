using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatApp.Pages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string? Username { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrEmpty(Username))
        {
            HttpContext.Session.SetString("username", Username);
            return RedirectToPage("/index");
        }

        return Page();
    }
}