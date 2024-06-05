using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "You Have To Provide A Valid Category Name")]
        [MaxLength(50, ErrorMessage = "Department name Can't be More than 50 Characters")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "You Have To Provide A Valid  Description")]
        [MinLength(10, ErrorMessage = "Description Can't be less than 10 Characters")]
        public string Description { get; set; }
        [DisplayName("image")]
        [ValidateNever]
        public string? ImagePath { get; set; }

        [ValidateNever]
        public List<Game> Games { get; set; }

    }
}
