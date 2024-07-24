using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace __8829850_Assignment3.Pages;

public class PersonAddedModel : PageModel
{
    private readonly ILogger<PersonAddedModel> _logger;

    public Person person = new Person();

    public PersonAddedModel(ILogger<PersonAddedModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(Person _person)
    {
        this.person = _person;
    }
}
