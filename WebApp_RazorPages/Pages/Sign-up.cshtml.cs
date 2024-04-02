using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApp_RazorPages.Pages;

public class  Sign_upModel(UserService userService) : PageModel
{

    private readonly UserService _userService = userService;

    [BindProperty]
    public SignUpModel Form { get; set; } = new SignUpModel();


    public void OnGet()
    {
        
    }

    

    public async  Task<IActionResult> OnPost(Sign_upModel sign_UpModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(sign_UpModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
                return RedirectToAction("/Sign-in");
            
        }
     
        return RedirectToPage("/index");
    }
  
}
