using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages.Models;

namespace WebApp_RazorPages.Pages;

public class Sign_upModel : PageModel
{

    [BindProperty]
    public SignUpFormModel Form { get; set; } = new SignUpFormModel();


    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // skicka iv�g formul�ret till en userService f�r registrering
        // var result = _userService.SignInUser(From);

        return RedirectToPage("/index");
    }
}
