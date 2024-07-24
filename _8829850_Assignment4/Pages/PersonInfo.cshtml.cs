using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Newtonsoft.Json;

namespace __8829850_Assignment4.Pages;

public class PersonInfoModel : PageModel
{
    // Create a field to hold a single Person object.
    public Person person = new Person();
    private readonly ILogger<PersonInfoModel> _logger;

    // property to hold a Person object.
    public Person Person { get; set; }

    public PersonInfoModel(ILogger<PersonInfoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Person = new Person();
    }

    public IActionResult OnPost(Person person)
    {
        // Check if the submitted data is valid.
        if (ModelState.IsValid)
        {
            // Save the person to a JSON file and redirect to the "PersonAdded" page.
            SavePersonToJson(person);
            return RedirectToPage("PersonAdded");
        }
        return Page();
    }

    // method to save a person to a JSON file.
    private void SavePersonToJson(Person person)
    {
        List<Person> people = LoadPeopleFromJson();
        people.Add(person);
        string json = JsonConvert.SerializeObject(people);
        System.IO.File.WriteAllText("People.json", json);
    }

    // method to load people data from a JSON file.
    private List<Person> LoadPeopleFromJson()
    {
        try
        {
            // Check if the JSON file "People.json" exists
            if (System.IO.File.Exists("People.json"))
            {
                string json = System.IO.File.ReadAllText("People.json");
                return JsonConvert.DeserializeObject<List<Person>>(json);
            }
        }
        catch (Exception ex)
        {
            // Log an error if there's an issue loading people from JSON.
            _logger.LogError(ex, "Error loading people from JSON");
        }

        // If the JSON file doesn't exist or an error occurs, return an empty list.
        return new List<Person>();
    }
}
