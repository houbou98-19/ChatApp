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

    public void OnGet()
    {
        var user = HttpContext.Session.GetString("user");
        if (user != null)
        {
            Response.Redirect("/Chat");
        }
        else
        {
            Response.Redirect("/Login");
        }
    }
}
