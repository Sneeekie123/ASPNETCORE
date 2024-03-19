using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages.Models;

namespace WebApp_RazorPages.Pages;

public class Sign_upModel : PageModel
{

    public SignUpFormModel Form { get; set; } = null!;



    public void OnGet()
    {
        Form = new SignUpFormModel();
    }

    public void OnPost()
    {

    }
}
