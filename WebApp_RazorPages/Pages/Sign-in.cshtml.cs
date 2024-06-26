using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages.Models;

namespace WebApp_RazorPages.Pages;

public class Sign_inModel : PageModel
{

    [BindProperty]
    public SignInModel Form { get; set; } = new SignInModel();

    public void OnGet()
    {
    }


    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/index");
    }
}
