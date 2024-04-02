using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        if (HttpContext.Session.GetString("username") != null)
        {
            return RedirectToPage("/Chat/Chat");
        }
        return RedirectToPage("/Login/login");
    }
}
