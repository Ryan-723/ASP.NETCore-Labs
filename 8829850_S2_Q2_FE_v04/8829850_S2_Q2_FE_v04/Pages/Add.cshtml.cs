
// 
// Student ID: 8829850
// Section 2 
// 18-08-2023

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829850_S2_Q2_FE_v04.Pages;

public class AddModel : PageModel
{
    public Car car = new Car();
    private readonly ILogger<AddModel> _logger;

    public AddModel(ILogger<AddModel> logger)
    {
        try
        {
            _logger = logger;
        }
        catch (Exception a)
        {

        }
    }

    public void OnGet()
    {
        try
        {

        }
        catch (Exception a)
        {

        }
    }
    public IActionResult OnPost(Car car)
    {
        try
        {
            return RedirectToPage("ThankYou", car);
        }
        catch (Exception a)
        {
            return null;
        }
    }
}
