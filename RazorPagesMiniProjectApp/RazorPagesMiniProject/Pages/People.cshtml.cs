using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoLibrary;

namespace RazorPagesMiniProject.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]  //-- Make Person a Bind Property so we can post to it
        public PersonModel Person { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Check to see if the model is valid or not, and redirect to the same page
            // or to the index page

            if (ModelState.IsValid == false) //-- ModelState is baked on PageModel
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}
