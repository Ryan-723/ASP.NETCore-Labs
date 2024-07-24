using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace __8829850_Assignment4.Pages;

public class PersonAddedModel : PageModel
{
    // Create a public field to hold a single Person object.
    public Person person = new Person();
    private readonly ILogger<PersonAddedModel> _logger;

    // property to hold a list of Person objects.
    public List<Person> People { get; private set; }

    public PersonAddedModel(ILogger<PersonAddedModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(Person newPerson)
    {
        People = LoadPeopleFromJson();
    }

    public void OnPost(Person person) { }

    // method to load people data from a JSON file.

    private List<Person> LoadPeopleFromJson()
    {
        if (System.IO.File.Exists("People.json"))
        {
            string json = System.IO.File.ReadAllText("People.json");
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
        return new List<Person>();
    }
}
