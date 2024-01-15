using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace authentification.Pages
{
    public partial class Test: ComponentBase
    {
    }
    public class Person
    {
        [Parameter]
        [Required]
        public string Name { get; set; }
        [Parameter]
        [Range(18, 80, ErrorMessage = "Age must be between 18 and 80.")]
        public int Age { get; set; }
        [Parameter]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }



    }
}
