using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatApp.Pages;
public class ChatModel : PageModel
{
    public string? Username { get; set; }

    public void OnGet()
    {
        Username = HttpContext.Session.GetString("username");
        // Use the username variable as needed
    }
}