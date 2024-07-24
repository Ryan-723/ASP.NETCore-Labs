
// 
// Student ID: 8829850
// Section 2 
// 18-08-2023

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829850_S2_Q2_FE_v04.Pages;

public class ThankYouModel : PageModel
{
    public Car car = new Car();
    private readonly ILogger<ThankYouModel> _logger;

    public ThankYouModel(ILogger<ThankYouModel> logger)
    {
        try
        {
            _logger = logger;
        }
        catch (Exception a)
        {

        }
    }

    public void OnGet(Car carDetails)
    {
        try
        {
            this.car = carDetails;
        }
        catch (Exception a)
        {

        }
    }
}
