
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using WebApp_RazorPages.Helpers;

namespace WebApp_RazorPages.Models;

public class SignUpFormModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First name" , Prompt = "Enter your first name")]
    [Required(ErrorMessage = "Invalid first name")]
    [MinLength(2, ErrorMessage = "Enter your first name")]
    public string FirstName { get; set; } = null!;


    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Enter your Last name")]
    [Required(ErrorMessage = "Invalid last name")]
    [MinLength(2, ErrorMessage = "Enter your last name")]
    public string LastName { get; set; } = null!;


    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Invalid email address")]
    [RegularExpression(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;



    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Invalid password")]
    [RegularExpression(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]", ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "ConfirmPassword", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Must confirm password")]
    [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
    public string ConfirmPassword { get; set; } = null!;



    [Display(Name = "I agree to the Terms & Conditions")]
    [CheckBoxRequired(ErrorMessage = "You must agree to the terms & conditions.")]
    public bool Terms { get; set; } = false;


}


