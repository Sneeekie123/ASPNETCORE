using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages.Models;

namespace WebApp_RazorPages.Pages;

public class AccountModel : PageModel
{

    [BindProperty]
    public AccountDetailsBasicInfoModel Form { get; set; } = new AccountDetailsBasicInfoModel();

    public AccountDetailsAddressModel Acc { get; set; } = new AccountDetailsAddressModel();

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
