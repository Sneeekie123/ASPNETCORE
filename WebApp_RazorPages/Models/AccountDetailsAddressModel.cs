using System.ComponentModel.DataAnnotations;

namespace WebApp_RazorPages.Models;

public class AccountDetailsAddressModel
{


    [Display(Name = "Address line 1", Prompt = "Enter your address")]
    [Required(ErrorMessage = "Address is required")]
    public string Addressline_1 { get; set; } = null!;

    [Display(Name = "Address line 2", Prompt = "Enter your address")]
    public string Addressline_2 { get; set; } = null!;


    [DataType(DataType.PostalCode)]
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    [Required(ErrorMessage = "Postal code is required")]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city")]
    [Required(ErrorMessage = "City is required")]

    public string City { get; set; } = null!;
}
